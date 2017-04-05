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
using System.Management;


namespace MISAP
{
    public partial class FrmFichaEquipo : Form, IForm_Listado
    {

        #region Variables globales

        public string usuario, perfil;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        #region Variables locales
        
        string model_disco;
        double memoria_b = 0;
        Int64 disco_b = 0;
        
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
        int posicion, DocEntry, NumLinea;
    
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

        //private void cbo_ot_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    util.FormatearCombo(sender, e, "Nombre de OT");
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
                    if (par5 == "Lista de PCA")
                    {
                        txt_IdPCA.Text = par1;
                        txt_empleado.Text = par2;
                        txt_Area.Text = par3;
                        txt_Perfil.Text = par4;
                        txt_Usuario.Text = par6;

                    }



                }
                #endregion

                #region Consultar

                if (operacion == "Consultar")
                {

                    if (par5 == "Lista de Ordenes de trabajo")
                    {
                        txt_IdArea.Text = par1;
                        txt_Area.Text = par2;


                    }

                    if (par5 == "Lista de documentos registrados")
                    {
                        txt_DocEntry.Text = par1;
                        consultar_navegacion();

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

            operacion = "Nuevo";
            txt_IdPCA.Focus();



            dp_FechaDocumento.CustomFormat = "yyyy-MM-dd";
            txt_FechaDocumento.Text = DateTime.Now.ToString("yyyy-MM-dd");


            dgv_detalle.DataSource = AccesoLogica.consultar_OCTE(0, "Consultar", "Listar");
            formatear_grilla(dgv_detalle);

            formatear_grilla(dgv_anexo_consulta);


            dgv_anexo_consulta.Visible = true;
            dgv_anexo.Visible = false;

            posicion = 0;
            if (dgv_lista.Rows.Count != 0)
            {
                posicion = 0;
                dgv_lista.CurrentCell = dgv_lista.Rows[0].Cells[0];

            }
            ObtenerDocEntry();

            txt_estado.Text = "Pendiente";
            txt_estadodoc.Text = "1";

            util.EstablecerAuditoria(operacion, usuario, "", "7089", "S", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            #region desbloquea textbox

            btn_opciones.Visible = false;
            txt_IdPCA.Enabled = true;
            txt_IdPCA.BackColor = Color.White;

            txt_DocEntry.ReadOnly = true;
            txt_DocEntry.BackColor = Color.FromArgb(231, 231, 231);

            txt_estado.ReadOnly = true;
            txt_estado.BackColor = Color.FromArgb(231, 231, 231);





            #endregion



        }

        void ObtenerDocEntry()
        {
            DocEntry = Convert.ToInt32(Convert.ToString(AccesoLogica.consultar_OAIN(0, "Consultar", "Obtener").Rows[0][0]));
            txt_DocEntry.Text = Convert.ToString(DocEntry);

        }

        void formatear_grilla(DataGridView grilla)
        {

            try
            {
                util.FormatearGrilla(grilla, false);
                lbl_contador_registros.Visible = true;

                lbl_contador_registros.Text = string.Format("Total de registros: {0}", grilla.Rows.Count);

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

                    int resultado = Negocio.mantenimiento_OANX(Convert.ToInt32(txt_DocEntry.Text), NumLinea, ruta_local, ruta_red, archi, ext, txt_fec_crea.Text, 0, "", "", "", operacion);
                    if (resultado == 0) Negocio = null;
                }
            }
        }

        void limpiar(string operacion)
        {

            util.limpiarTextBoxes(this);
            this.txt_IdPCA.Focus();

        }

        private void consultar_navegacion()
        {
            try
            {
                //   operacion = "Consultar";


                //   //dgv_detalle.DataSource = AccesoLogica.consultar_ACT1(txt_IdActivo.Text);
                //   //formatear_grilla(dgv_detalle);

                //   dgv_anexo_consulta.DataSource = AccesoLogica.consultar_OANX(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar");
                //   formatear_grilla(dgv_anexo_consulta);

                //   txt_idreg.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Nro"].ToString();
                //   txt_estadodoc.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Codigo de estado"].ToString();
                //   txt_estado.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Estado"].ToString();
                //   txt_numref.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Lote"].ToString();
                //   txt_IdPCA.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Proveedor"].ToString();

                //   txt_PrcCode.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Codigo OT"].ToString();
                //   txt_U_CL_DESCRI.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Orden de trabajo"].ToString();
                //   txt_Code.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Codigo de documento"].ToString();
                //   txt_TipoDocumento.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Documento"].ToString();
                //   txt_serie.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Serie"].ToString();
                //   txt_numero.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Numero de documento"].ToString();

                //   txt_FechaDocumento.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Fecha de documento"].ToString();
                //   txt_DocDate.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Fecha de contabilización"].ToString();

                //   txt_prioridad.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Codigo de prioridad"].ToString();
                //   cbo_prioridad.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Prioridad"].ToString();
                //   txt_CurrCode.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Codigo de moneda"].ToString();
                //   cbo_CurrName.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Moneda"].ToString();
                //   txt_SubTotal.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Sub Total"].ToString();
                //   swtigv = Convert.ToInt32(AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Incluye impuesto"].ToString());

                //   if (swtigv == 1)
                //   {

                //       chk_igv.Checked = true;

                //   }
                //   else
                //   {
                //       chk_igv.Checked = false;
                //   }

                //   txt_impuesto.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Impuesto"].ToString();
                //   txt_Total.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Total"].ToString();
                //   txt_retencion.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Retencion"].ToString();
                //   txt_ImporteAplicado.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Importe aplicado"].ToString();
                //   txt_SaldoPendiente.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Saldo pendiente"].ToString();
                //   txt_DocNum.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Nº SAP"].ToString();

                //   txt_Observaciones.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Observaciones"].ToString();
                //   txt_DocReferencia.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Documento de referencia"].ToString();
                //   txt_NroLetra.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Nro de letra"].ToString();
                //   txt_OC.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Orden de compra"].ToString();
                //   txt_OS.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Orden de srvicio"].ToString();
                //   txt_NotaIngreso.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Nota de ingreso"].ToString();
                //   txt_GuiaRemision.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Guia de remision"].ToString();
                //   txt_usr_crea.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Creador"].ToString();
                ////   txt_fec_crea.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Creado"].ToString();




                //   btn_grabar.Text = "Actualizar";
                //   btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                //   btn_grabar.Enabled = true;
                //   btn_consultar_b.Enabled = true;
                //   btn_nuevo_b.Enabled = true;


                //   #region bloquea textbox

                //   btn_opciones.Visible = false;
                //   txt_IdPCA.Enabled = false;
                //   txt_IdPCA.BackColor = Color.FromArgb(231, 231, 231);

                //   txt_CardName.ReadOnly = true;
                //   txt_CardName.BackColor = Color.FromArgb(231, 231, 231);

                //   txt_idreg.ReadOnly = true;
                //   txt_idreg.BackColor = Color.FromArgb(231, 231, 231);


                //   txt_serie.ReadOnly = true;
                //   txt_serie.BackColor = Color.FromArgb(231, 231, 231);


                //   txt_numero.ReadOnly = true;
                //   txt_numero.BackColor = Color.FromArgb(231, 231, 231);


                //   txt_estado.ReadOnly = true;
                //   txt_estado.BackColor = Color.FromArgb(231, 231, 231);


                //   btn_opciones_2.Visible = false;
                //   txt_TipoDocumento.Enabled = false;
                //   txt_TipoDocumento.BackColor = Color.FromArgb(231, 231, 231);



                //   #endregion
                //   txt_U_CL_DESCRI.Focus();

            }
            catch
            {
                util.mensaje("No existen registros coincidentes", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
        }

        #endregion

        #region Formulario

        public FrmFichaEquipo()
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
                if (Screen.AllScreens.Length > 1)
                {
                    this.Location = Screen.AllScreens[1].WorkingArea.Location;
                    this.Size = Screen.AllScreens[1].WorkingArea.Size;

                    maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));

                    lbl_maximi.Text = "0";
                }
                else
                {

                    this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                    maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));

                    lbl_maximi.Text = "0";

                }

            }
            else
            {
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
                this.SetBounds(this.Location.X, this.Location.Y, 712, 610);
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

        private void FrmAvanceProyecto_Load(object sender, EventArgs e)
        {

            util.FormatearFormulario_sap(this, ts_acciones, tc_detalle, ss_load, tp_listado, tp_auditoria);
            util.Formateardetalle(tp_contenido, tp_anexo);
            this.Location = new System.Drawing.Point(320, 80);

            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
            btn_grabar.Enabled = true;

        }



        private void txt_CardCode_Enter(object sender, EventArgs e)
        {

            txt_IdPCA.BackColor = Color.FromArgb(254, 240, 158);
            btn_opciones.Visible = true;
            if (!String.IsNullOrEmpty(txt_IdPCA.Text))
            {
                txt_IdPCA.SelectionStart = 0;
                txt_IdPCA.SelectionLength = txt_IdPCA.Text.Length;
            }

        }

        private void txt_IdActivo_Leave(object sender, EventArgs e)
        {
            txt_IdPCA.BackColor = Color.White;
        }


        private void dp_FechaDocumento_ValueChanged(object sender, EventArgs e)
        {

            txt_FechaDocumento.Text = dp_FechaDocumento.Text;
        }

        private void txt_idreg_Enter(object sender, EventArgs e)
        {

            txt_DocEntry.BackColor = Color.FromArgb(254, 240, 158);

            if (!String.IsNullOrEmpty(txt_DocEntry.Text))
            {
                txt_DocEntry.SelectionStart = 0;
                txt_DocEntry.SelectionLength = txt_DocEntry.Text.Length;
            }

        }

        private void t_msg_Tick(object sender, EventArgs e)
        {
            lbl_msg.Text = string.Empty;
            ss_load.BackColor = Color.Transparent;
            lbl_contador_registros.Visible = true;
            lbl_msg.Visible = false;
        }

        private void dgv_anexo_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            btn_visualizar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn));
            btn_visualizar.Enabled = true;

            btn_borrar_anexo.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn));
            btn_borrar_anexo.Enabled = true;

        }

        private void dgv_anexo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            archi = dgv_anexo.CurrentRow.Cells["archivo_"].Value.ToString();
            ext = dgv_anexo.CurrentRow.Cells["extension_"].Value.ToString();


            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = @"\\10.0.0.8\Comun\MISAP\Anexos\Tramite documentario\" + archi + ext;
            proc.Start();
            proc.Close();
        }

        private void dgv_anexo_consulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            btn_visualizar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn));
            btn_visualizar.Enabled = true;

            btn_borrar_anexo.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn));
            btn_borrar_anexo.Enabled = true;
        }

        private void dgv_anexo_consulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            archi = dgv_anexo_consulta.CurrentRow.Cells["Nombre de archivo"].Value.ToString();
            ext = dgv_anexo_consulta.CurrentRow.Cells["Extension"].Value.ToString();


            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = @"\\10.0.0.8\Comun\MISAP\Anexos\Tramite documentario\" + archi + ext;
            proc.Start();
            proc.Close();
        }




        #endregion

        #region Botones

        private void btn_nuevo_b_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            inicializar();

            txt_IdPCA.Enabled = true;
            txt_IdPCA.Focus();
            btn_nuevo_b.Enabled = false;
            btn_consultar_b.Enabled = true;
            btn_grabar.Text = "Crear";

        }

        private void btn_consultar_b_Click(object sender, EventArgs e)
        {
            operacion = "Consultar";
            limpiar(operacion);


            btn_nuevo_b.Enabled = true;
            btn_consultar_b.Enabled = false;
            btn_grabar.Text = "Buscar";


            btn_opciones.Visible = false;

            txt_DocEntry.Enabled = true;
            txt_DocEntry.ReadOnly = false;
            txt_DocEntry.Clear();
            txt_DocEntry.Focus();



        }

        private void btn_opciones_Click(object sender, EventArgs e)
        {
            FrmListado opciones = new FrmListado();
            opciones.titulo = "Lista de PCA";
            // opciones.parametro_1 = "PL";
            opciones.ShowDialog(this);

        }

        private void btn_utlimo_Click(object sender, EventArgs e)
        {
            posicion = dgv_lista.Rows.Count - 1;

            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            txt_DocEntry.Text = dgv_lista.CurrentRow.Cells[0].Value.ToString();
            consultar_navegacion();

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (posicion < dgv_lista.Rows.Count - 1)
            {
                posicion = posicion + 1;
            }


            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            txt_DocEntry.Text = dgv_lista.CurrentRow.Cells[0].Value.ToString();
            consultar_navegacion();
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            posicion = 0;

            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            txt_DocEntry.Text = dgv_lista.CurrentRow.Cells[0].Value.ToString();
            consultar_navegacion();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion = posicion - 1;
            }


            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            txt_DocEntry.Text = dgv_lista.CurrentRow.Cells[0].Value.ToString();
            consultar_navegacion();
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            #region Nuevo

            if (operacion == "Nuevo" || operacion == "Consultar")
            {
                if (btn_grabar.Text == "OK")
                {
                    Close();
                }

                #region validaciones cabecera

                if (txt_IdPCA.Text == string.Empty)
                {
                    util.mensaje("El campo " + lbl_IdPCA.Text + " no debe estar vacio; indique un valor para " + lbl_IdPCA.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    txt_IdPCA.Focus();
                    return;

                }

                if (txt_Area.Text == string.Empty)
                {
                    util.mensaje("El campo " + lbl_ot.Text + " no debe estar vacio; indique un valor para " + lbl_ot.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    txt_Area.Focus();
                    return;

                }


                #endregion

                #region validaciones detalle

                #endregion



                try
                {

                    //int resultado = Negocio.mantenimiento_OTDC
                    //    (
                    //   Convert.ToInt32(txt_idreg.Text), 
                    //   txt_IdPCA.Text, 
                    //   txt_Code.Text,
                    //   txt_serie.Text, 
                    //   txt_numero.Text,
                    //   txt_FechaDocumento.Text,
                    //   txt_FechaVencimiento.Text, 
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
                    //   txt_FechaRecepcion.Text
                    //   );

                    //if (resultado != 1)
                    //{
                    //   /// Negocio = null;

                    //    lbl_msg.Text = AccesoLogica.consultar_OERR(resultado).Rows[0]["Mensaje"].ToString();

                    //    util.mensaje(lbl_msg.Text, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    //    return;
                    //}


                    //GrabarAnexos();

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
            #endregion

        }

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
            //if (dgv_detalle.Rows.Count == 0)
            //{
            //    MessageBox.Show("No Existe Informacion para exportar", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //    return;
            //}
            //util.ExportarDataGridViewExcel(dgv_detalle, tsl_titulo.Text);
        }

        private void txt_idreg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                if (txt_DocEntry.Text == "*")
                {
                    FrmListado Listado = new FrmListado();
                    Listado.titulo = "Lista de documentos registrados";
                    Listado.ShowDialog(this);
                }
                else
                {
                    consultar_navegacion();
                }
            }
        }

        private void btn_opciones_3_Click(object sender, EventArgs e)
        {
            FrmListado opciones = new FrmListado();
            opciones.titulo = "Lista de Ordenes de trabajo";
            opciones.ShowDialog(this);
        }

        private void btn_opciones_2_Click(object sender, EventArgs e)
        {
            FrmListado opciones = new FrmListado();
            opciones.titulo = "Lista de tipos de documentos";
            opciones.ShowDialog(this);
        }

        private void btn_borrar_anexo_Click(object sender, EventArgs e)
        {
            if (operacion == "Nuevo")
            {
                int fila = dgv_anexo.CurrentRow.Index;
                dgv_anexo.Rows.RemoveAt(fila);

                archi = dgv_anexo.CurrentRow.Cells["archivo_"].Value.ToString();
                ext = dgv_anexo.CurrentRow.Cells["extension_"].Value.ToString();
                System.IO.File.Delete(@"\\10.0.0.8\Comun\MISAP\Anexos\Tramite documentario\" + archi + ext);


                btn_visualizar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_desactivado));
                btn_visualizar.Enabled = false;

                btn_borrar_anexo.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_desactivado));
                btn_borrar_anexo.Enabled = false;

                btn_visualizar.Focus();
            }

            if (operacion == "Consultar")
            {
                int fila = dgv_anexo.CurrentRow.Index;
                dgv_anexo.Rows.RemoveAt(fila);

                archi = dgv_anexo.CurrentRow.Cells["archivo_"].Value.ToString();
                ext = dgv_anexo.CurrentRow.Cells["extension_"].Value.ToString();
                System.IO.File.Delete(@"\\10.0.0.8\Comun\MISAP\Anexos\Tramite documentario\" + archi + ext);


                btn_visualizar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_desactivado));
                btn_visualizar.Enabled = false;

                btn_borrar_anexo.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_desactivado));
                btn_borrar_anexo.Enabled = false;

                btn_visualizar.Focus();
            }
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {

            if (operacion == "Nuevo")
            {

                archi = dgv_anexo.CurrentRow.Cells["archivo_"].Value.ToString();
                ext = dgv_anexo.CurrentRow.Cells["extension_"].Value.ToString();


                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = @"\\10.0.0.8\Comun\MISAP\Anexos\Tramite documentario\" + archi + ext;
                proc.Start();
                proc.Close();
            }

            if (operacion == "Consultar")
            {

                archi = dgv_anexo_consulta.CurrentRow.Cells["Nombre de archivo"].Value.ToString();
                ext = dgv_anexo_consulta.CurrentRow.Cells["Extension"].Value.ToString();


                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = @"\\10.0.0.8\Comun\MISAP\Anexos\Tramite documentario\" + archi + ext;
                proc.Start();
                proc.Close();
            }

        }

        private void btn_explorar_Click(object sender, EventArgs e)
        {
            dgv_anexo_consulta.Visible = false;
            dgv_anexo.Visible = true;

            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"\\10.0.0.8\Comun\MISAP\Anexos\Tramite documentario";

            open.Filter = "Documentos (*.pdf, *.jpg,*.txt,*.sql,*.html,*.dwg)|*.pdf;*.jpg;*.txt;*.sql;*.html;*.dwg";
            open.FilterIndex = 1;

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string paths = Application.StartupPath;
                archi = System.IO.Path.GetFileNameWithoutExtension(open.FileName);
                ext = System.IO.Path.GetExtension(open.FileName);
                openarchivo = open.FileName;
                NumLinea = NumLinea + 1;

                dgv_anexo.Rows.Add(@"\\10.0.0.8\Comun\MISAP\Anexos\Tramite documentario", archi, txt_fec_crea.Text, ext, txt_DocEntry.Text, NumLinea, openarchivo);

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
                //   txt_IdPCA.Text,
                //   txt_Code.Text,
                //   txt_serie.Text,
                //   txt_numero.Text,
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

                //util.mensaje("La Operacion finalizo con exito", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);


                //if (btn_grabar.Text == "Actualizar")
                //{
                //    btn_grabar.Text = "OK";
                //}

                //inicializar();


            }
            catch (Exception ex)
            {
                util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }

        }

        private void btn_cargo_Click(object sender, EventArgs e)
        {
            FrmCargoDoc cargo = new FrmCargoDoc();
            cargo.usuario = usuario;
            cargo.perfil = perfil;
            cargo.Show();
        }

        private void txt_IpEquipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == Convert.ToInt32(Keys.Enter))
            {

                ConnectionOptions options = new ConnectionOptions();
                options.Username = "eterrones";
                options.Password = "3_t3rr0n3s";
                options.Authority = "ntlmdomain:imecon.com";
                ManagementScope scope = new ManagementScope("\\\\" + txt_IpEquipo.Text + "\\root\\cimv2", options);

                scope.Connect();



                //Ahora obteniendo info acerca del OS

                ObjectQuery so = new ObjectQuery("select * from Win32_OperatingSystem");
                ObjectQuery cpu = new ObjectQuery("select *  FROM   Win32_Processor");
                ObjectQuery memoria_q = new ObjectQuery("select *  FROM  Win32_PhysicalMemory");
                ObjectQuery disco_q = new ObjectQuery("select *  FROM   Win32_DiskDrive "); //Win32_LogicalDisk WHERE MediaType = 12
                ObjectQuery placa_q = new ObjectQuery("select *  FROM    Win32_BaseBoard");
                ObjectQuery mascara_q = new ObjectQuery("select *  FROM    Win32_NetworkAdapterConfiguration  WHERE IPEnabled = 'True' ");


                ManagementObjectSearcher wmiSearcher = new ManagementObjectSearcher(scope, so);
                ManagementObjectSearcher wmiSearcher2 = new ManagementObjectSearcher(scope, cpu);
                ManagementObjectSearcher wmiSearcher3 = new ManagementObjectSearcher(scope, memoria_q);
                ManagementObjectSearcher wmiSearcher4 = new ManagementObjectSearcher(scope, disco_q);
                ManagementObjectSearcher wmiSearcher5 = new ManagementObjectSearcher(scope, placa_q);
                ManagementObjectSearcher wmiSearcher6 = new ManagementObjectSearcher(scope, mascara_q);

                ManagementObjectCollection queryWMICollection = wmiSearcher.Get();
                ManagementObjectCollection queryWMICollection2 = wmiSearcher2.Get();
                ManagementObjectCollection queryWMICollection3 = wmiSearcher3.Get();
                ManagementObjectCollection queryWMICollection4 = wmiSearcher4.Get();
                ManagementObjectCollection queryWMICollection5 = wmiSearcher5.Get();
                ManagementObjectCollection queryWMICollection6 = wmiSearcher6.Get();

                foreach (ManagementObject m in queryWMICollection)
                {


                    // MessageBox.Show(Convert.ToString(m["Caption"]));

                    dgv_detalle.Rows[18].Cells["Descripcion"].Value = m["Caption"];
                    txt_NombreEquipo.Text = Convert.ToString(m["CSName"]);
                }


                foreach (ManagementObject m in queryWMICollection6)
                {


                    // MessageBox.Show(Convert.ToString(m["Caption"]));


                    // txt_mascara_equipo.Text = Convert.ToString(m["IPSubnet"]);
                }

                foreach (ManagementObject m in queryWMICollection2)
                {
                    // MessageBox.Show(Convert.ToString(m["Name"]));
                    dgv_detalle.Rows[1].Cells["Descripcion"].Value = m["Name"];
                }



                foreach (ManagementObject m in queryWMICollection3)
                {
                    memoria_b = memoria_b + Convert.ToDouble(m["Capacity"]);
                    // MessageBox.Show(Convert.ToString(m["Capacity"]));
                }

                string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
                int i;
                double memoria = memoria_b;
                for (i = 0; i < Suffix.Length && memoria_b >= 1024; i++, memoria_b /= 1024)
                {
                    memoria = memoria_b / 1024.0;
                }

                // MessageBox.Show(String.Format("{0:0.##} {1}", memoria, Suffix[i]));
                dgv_detalle.Rows[2].Cells["Descripcion"].Value = String.Format("{0:0.##} {1}", memoria, Suffix[i]);


                foreach (ManagementObject m in queryWMICollection4)
                {
                    //MessageBox.Show(Convert.ToString(m["Size"]));
                    disco_b = Convert.ToInt64(m["Size"]);
                    model_disco = Convert.ToString(m["Model"]);

                }

                string[] Suffix_d = { "B", "KB", "MB", "GB", "TB" };
                int j;
                Int64 disco = disco_b;
                for (j = 0; j < Suffix_d.Length && disco_b >= 1024; j++, Convert.ToInt64(disco_b /= 1024))
                {
                    disco = Convert.ToInt64(disco_b / 1024.0);
                }

                //MessageBox.Show(String.Format("{0:0.##} {1}", disco, Suffix_d[j]));
                dgv_detalle.Rows[3].Cells["Descripcion"].Value = model_disco + " " + String.Format("{0:0.##} {1}", disco, Suffix_d[j]);

                foreach (ManagementObject m in queryWMICollection5)
                {
                    //MessageBox.Show(Convert.ToString(m["Manufacturer"] + " " + m["Product"]));
                    dgv_detalle.Rows[0].Cells["Descripcion"].Value = m["Manufacturer"] + " " + m["Product"];
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

        private void txt_CodInventario_Enter(object sender, EventArgs e)
        {

            txt_CodInventario.BackColor = Color.FromArgb(254, 240, 158);
            btn_ListaInventario.Visible = true;
            if (!String.IsNullOrEmpty(txt_CodInventario.Text))
            {
                txt_CodInventario.SelectionStart = 0;
                txt_CodInventario.SelectionLength = txt_CodInventario.Text.Length;
            }
        }
    }
}
