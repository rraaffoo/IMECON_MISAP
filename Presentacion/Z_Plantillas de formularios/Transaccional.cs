using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Negocio;
using System.Net.Mail;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace MISAP
{
    public partial class Transaccional : Form
    {
        
        #region Variables globales

        public string usuario, perfil, operacion_;
        public int idreg_;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        #region Variables locales

        private Point pos = Point.Empty;
        private bool move = false;
        bool allowSelect = false;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();
        
        DateTimePicker oDateTimePicker;
        string filtro, operacion, archi, ext, rut, openarchivo, ruta_local, ruta_red;
        int posicion, columna, idreg, cant_col, ColumnaId, id, swtigv,  NumLinea ;
        decimal impuesto , subtotal, total;
        int[] vector, vec_col;
        bool[] vec_falg;
        bool visible_;

        #endregion

        #region Perzonalizacion de controles

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() :
                base(new Utilidades.MyColors()) { }
        }

        //private void cbo_proyecto_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    util.FormatearCombo(sender, e, "Nombre de proyecto");
        //}

        #endregion

        #region Formulario externo

        public void pasar_valores(string par1, string par2, string par3, string par4, string par5, string par6)
        {
            try
            {
                #region Nuevo

                if (operacion == "Nuevo")
                {
                    if (par5 == "Lista de Ordenes de trabajo")
                    {
                        txt_PrcCode.Text = par1;
                        txt_U_CL_DESCRI.Text  = par2;

                    }

                }
                #endregion

                #region Consultar

                if (operacion == "Consultar")
                {

                    if (par5 == "Lista de Ordenes de trabajo")
                    {
                        txt_PrcCode.Text = par1;
                        txt_U_CL_DESCRI.Text = par2;


                    }

                      
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Orden de Producción", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        #endregion

        #region Funciones

        private void inicializar()
        {

            limpiar(operacion);

            dgv_lista.DataSource = AccesoLogica.informe_seguimiento_contratos(0, "Consultar", "Listar");
            formatear_grilla(dgv_lista);

            formatear_grilla(dgv_anexo_consulta);

           //util.tamanioTextBoxes(this);
         

        }

        void ObtenerIdReg()
        {
            idreg = Convert.ToInt32(Convert.ToString(AccesoLogica.consultar_OTDC(0, "Consultar", "Obtener").Rows[0][0]));
            txt_idreg.Text = Convert.ToString(idreg);

        }

        void formatear_grilla(DataGridView grilla)
        {

            try
            {
                util.FormatearGrilla(grilla, false);
                lbl_contador_registros.Visible = true;

                lbl_contador_registros.Text = string.Format("Total de registros: {0}", grilla.Rows.Count);

                //if (grilla == dgv_log)
                //{
                    //grilla.Columns["#"].Visible = false;
                    //grilla.Columns["OT"].Visible = false;
                    //grilla.Columns["Cliente"].Visible = false;
                    
                //}

             }


            catch (Exception ex)
            {
                util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;

            }
        }

        void GrabarAnexos()
        {
            if (dgv_anexo.Rows.Count != 0)
            {
                ruta_red = @"\\10.0.0.8\Comun\MISAP\Anexos\Tramite documentario\";
                foreach (DataGridViewRow row in dgv_anexo.Rows)
                {
                    archi = Convert.ToString(row.Cells["archivo_"].Value);
                    ext = Convert.ToString(row.Cells["extension_"].Value);
                    ruta_local = Convert.ToString(row.Cells["local_r"].Value);
                    NumLinea = Convert.ToInt32(row.Cells["Line"].Value);
                    
                    System.IO.File.Copy(ruta_local, ruta_red + archi + ext);
                    
                    int resultado = Negocio.mantenimiento_OANX(Convert.ToInt32(txt_idreg.Text), NumLinea, ruta_local, ruta_red, archi, ext, txt_fec_crea.Text, 0, "", "", "", operacion);
                    if (resultado == 0) Negocio = null;
                }
            }
        }

        void limpiar(string operacion)
        {
            
            util.limpiarTextBoxes(this);
            this.txt_PrcCode.Focus();

        }

        private void consultar_navegacion()
        {
            try
            {
                operacion = "Consultar";


                //dgv_detalle.DataSource = AccesoLogica.consultar_ACT1(txt_IdActivo.Text);
                //formatear_grilla(dgv_detalle);

                

                DataTable dt = AccesoLogica.informe_seguimiento_contratos(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar");

                txt_idreg.Text = dt.Rows[0]["#"].ToString();
                txt_PrcCode.Text = dt.Rows[0]["OT"].ToString();
             
               // chk_Atraso.Checked = dt.Rows[0]["Por atraso"].ToString() == "Si" ? true : false;
                
                dgv_log.DataSource = AccesoLogica.consultar_CTR1(0, "Consultar", "Consultar", txt_PrcCode.Text);
                formatear_grilla(dgv_log);

                dgv_anexo_consulta.DataSource = AccesoLogica.consultar_OANX(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar");
                formatear_grilla(dgv_anexo_consulta);



                btn_grabar.Text = "Actualizar";
                btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                btn_grabar.Enabled = true;
                btn_consultar_b.Enabled = true;
                btn_nuevo_b.Enabled = true;


                #region bloquea textbox

                btn_opciones.Visible = false;
                txt_PrcCode.Enabled = false;
                txt_PrcCode.BackColor = Color.FromArgb(231, 231, 231);

                txt_U_CL_DESCRI.ReadOnly = true;
                txt_U_CL_DESCRI.BackColor = Color.FromArgb(231, 231, 231);

                txt_idreg.ReadOnly = true;
                txt_idreg.BackColor = Color.FromArgb(231, 231, 231);
                
                #endregion
            
            }
            catch (Exception ex)
            {
                util.mensaje("No existen registros coincidentes", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
        }

        #endregion

        #region Formulario

        public Transaccional()
        {
            InitializeComponent();
            ts_acciones.Renderer = new MyRenderer();
            inicializar();
        }

        private void ninimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizar_Click(object sender, EventArgs e)
        {

            if (lbl_maximi.Text == "1")
            {

                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));

                lbl_maximi.Text = "0";

                //if (Screen.AllScreens.Length > 1)
                //{
                //    this.Location = Screen.AllScreens[1].WorkingArea.Location;
                //    this.Size = Screen.AllScreens[1].WorkingArea.Size;

                //    maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));

                //    lbl_maximi.Text = "0";
                //}
                //else
                //{

                //    this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                //    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                //    maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));

                //    lbl_maximi.Text = "0";

                //}

            }
            else
            {
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
                this.SetBounds(this.Location.X, this.Location.Y, 893, 680);
                this.Location = new System.Drawing.Point(320, 80);
               
                lbl_maximi.Text = "1";
            }


         

        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void titulo_DoubleClick(object sender, EventArgs e)
        {

            if (lbl_maximi.Text == "1")
            {
                this.Location = Screen.AllScreens[0].WorkingArea.Location;
                this.Size = Screen.AllScreens[0].WorkingArea.Size;
                //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));

                lbl_maximi.Text = "0";
            }
            else
            {
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
                this.SetBounds(this.Location.X, this.Location.Y, 615, 525);
                this.Location = new System.Drawing.Point(320, 80);

                lbl_maximi.Text = "1";
            }
        }

        private void titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); 

        }

       
        #endregion

        #region Eventos

        private void FrmPlanHomologacion_Load(object sender, EventArgs e)
        {

            util.FormatearFormulario_sap(this, ts_acciones, tc_detalle, ss_load, tp_listado, tp_auditoria);
            util.Formateardetalle(tp_contenido, tp_anexo);
            this.Location = new System.Drawing.Point(320, 80);

            tp_contenido.Text = "Contenido";

            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
            btn_grabar.Enabled = true;

            if (operacion_ == "Nuevo")
            {
                operacion = operacion_;
                txt_PrcCode.Focus();

                posicion = 0;
                if (dgv_lista.Rows.Count != 0)
                {
                    posicion = 0;
                    dgv_lista.CurrentCell = dgv_lista.Rows[0].Cells[0];

                }

                dgv_anexo_consulta.Visible = true;
                dgv_anexo.Visible = false;


                ObtenerIdReg();

                txt_estado.Text = "Abierto";
                util.EstablecerAuditoria(operacion, usuario, "", "7088", "S", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

                #region desbloquea textbox

                btn_opciones.Visible = false;
                txt_PrcCode.Enabled = true;
                txt_PrcCode.BackColor = Color.White;


                txt_idreg.ReadOnly = true;
                txt_idreg.BackColor = Color.FromArgb(231, 231, 231);

                txt_estado.ReadOnly = true;
                txt_estado.BackColor = Color.FromArgb(231, 231, 231);

                #endregion

            }

            if (operacion_ == "Consultar")
            {
                operacion = operacion_;

                btn_nuevo_b.Enabled = true;
                btn_consultar_b.Enabled = true;
                btn_grabar.Text = "Buscar";


                btn_opciones.Visible = false;

                txt_idreg.Text = Convert.ToString(idreg_);
                txt_idreg.ReadOnly = true;

                consultar_navegacion();

            }


        }

        #endregion

        #region Menu contextual

        private void cm_grilla_copia_Click(object sender, EventArgs e)
        {
            util.copiar_contextual(dgv_lista);
        }

        private void cm_grilla_copia_tabla_Click(object sender, EventArgs e)
        {
            util.copiar_todo_encabezados(dgv_lista);
        }

        private void cmi_eliminar_Click(object sender, EventArgs e)
        {
            operacion = "Eliminar";
            try
            {

                //int resultado = Negocio.mantenimiento_OTDC
                //    (
                //   Convert.ToInt32(txt_idreg.Text),
                //   txt_PrcCode.Text,

                //   dp_FechaDocumento.Text,
                //   dp_FechaVencimiento.Text,
                //   txt_CurrCode.Text,
                //   Convert.ToDecimal(txt_SubTotal.Text),
                //   swtigv,
                //   Convert.ToDecimal(txt_impuesto.Text),
                //   Convert.ToDecimal(txt_Total.Text),
                //   Convert.ToDecimal(txt_retencion.Text),
                //   txt_Observaciones.Text,
                //   txt_DocReferencia.Text,
                //   txt_NroLetra.Text,
                //   txt_PrcCode.Text,
                //   txt_OC.Text,
                //   txt_OS.Text,
                //   txt_NotaIngreso.Text,
                //   txt_GuiaRemision.Text,
                //   Convert.ToInt32(txt_prioridad.Text),
                //   Convert.ToInt32(txt_estadodoc.Text),
                //   "",
                //   "",
                //   "",
                //   0,
                //   "",
                //   "",
                //   0,
                //   txt_fec_crea.Text,
                //   txt_usr_crea.Text,
                //   DateTime.Now.ToString("yyyy-MM-dd hh:mm"),
                //   txt_usr_modi.Text,
                //   Convert.ToInt32(txt_numref.Text),
                //   operacion,
                //   txt_formulario.Text,
                //   dp_FechaRecepcion.Text
                //   );
                //if (resultado == 0) Negocio = null;

                util.mensaje("La Operacion finalizo con exito", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);


                if (btn_grabar.Text == "Actualizar")
                {
                    btn_grabar.Text = "OK";
                }

                inicializar();


            }
            catch (Exception ex)
            {
                util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }

        }

           
        //private void logDeModificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    FrmLogModificaciones log = new FrmLogModificaciones();
        //    log.requerimiento = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Requerimiento"].Value);
        //    log.ShowDialog(this);
        //}

        #endregion


    }
}
