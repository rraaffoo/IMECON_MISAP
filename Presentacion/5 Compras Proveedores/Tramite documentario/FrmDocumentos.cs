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
    public partial class FrmDocumentos : Form, IForm_Listado
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
                    if (par5 == "Lista de Socios de negocios")
                    {
                        txt_CardCode.Text = par1;
                        txt_CardName.Text = par2;

                     
                    }

                    if (par5 == "Lista de Ordenes de trabajo")
                    {
                        txt_PrcCode.Text = par1;
                        txt_U_CL_DESCRI.Text  = par2;


                    }

                    if (par5 == "Lista de tipos de documentos")
                    {
                        txt_Code.Text = par1;
                        txt_TipoDocumento.Text = par2;


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

                    if (par5 == "Lista de documentos registrados")
                    {
                        txt_idreg.Text= par1;
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
            txt_CardCode.Focus();


            dp_FechaRecepcion.CustomFormat = "yyyy-MM-dd";
            dp_FechaDocumento.CustomFormat = "yyyy-MM-dd";
            dp_FechaVencimiento.CustomFormat = "yyyy-MM-dd";

            txt_FechaRecepcion.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txt_FechaDocumento.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txt_FechaVencimiento.Text = DateTime.Now.ToString("yyyy-MM-dd");

            dgv_lista.DataSource = AccesoLogica.consultar_OTDC(0, "Consultar", "Listar");
            formatear_grilla(dgv_lista);

            formatear_grilla(dgv_anexo_consulta);
          

            dgv_anexo_consulta.Visible = true;
            dgv_anexo.Visible = false;

            posicion = 0;
            if (dgv_lista.Rows.Count != 0)
            {
                posicion = 0;
                dgv_lista.CurrentCell = dgv_lista.Rows[0].Cells[0];
              
            }
            
            ObtenerIdReg();

            //carga combo nomedas
            cbo_CurrName.DataSource = AccesoLogica.consultar_OCRN("", "Consultar", "Listar");
            cbo_CurrName.DisplayMember = "CurrName";
            cbo_CurrName.ValueMember = "CurrCode";
            cbo_CurrName.SelectedItem = null;

            cbo_prioridad.SelectedItem = null;

            txt_estado.Text = "Pendiente";
            txt_SubTotal.Text = "0";
            txt_impuesto.Text = "0";
            txt_Total.Text = "0";
            txt_retencion.Text = "0";
            txt_numref.Text = "0";
            txt_estadodoc.Text = "1";
            swtigv = 1;
            util.EstablecerAuditoria(operacion, usuario, "", "7088", "S", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            #region desbloquea textbox

            btn_opciones.Visible = false;
            txt_CardCode.Enabled = true;
            txt_CardCode.BackColor = Color.White;
                   

            txt_idreg.ReadOnly = true;
            txt_idreg.BackColor = Color.FromArgb(231, 231, 231);


            txt_serie.ReadOnly = false;
            txt_serie.BackColor = Color.White;


            txt_numero.ReadOnly = false;
            txt_numero.BackColor = Color.White;


            txt_estado.ReadOnly = true;
            txt_estado.BackColor = Color.FromArgb(231, 231, 231);


            btn_opciones_2.Visible = false;
            txt_TipoDocumento.Enabled = true;
            txt_TipoDocumento.BackColor = Color.White;



            #endregion



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
            this.txt_CardCode.Focus();

        }

        private void consultar_navegacion()
        {
            try
            {
                operacion = "Consultar";


                //dgv_detalle.DataSource = AccesoLogica.consultar_ACT1(txt_IdActivo.Text);
                //formatear_grilla(dgv_detalle);

                dgv_anexo_consulta.DataSource = AccesoLogica.consultar_OANX(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar");
                formatear_grilla(dgv_anexo_consulta);

                txt_idreg.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Nro"].ToString();
                txt_estadodoc.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Codigo de estado"].ToString();
                txt_estado.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Estado"].ToString();
                txt_numref.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Lote"].ToString();
                txt_CardCode.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Proveedor"].ToString();
                txt_CardName.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Nombre"].ToString();
                txt_PrcCode.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Codigo OT"].ToString();
                txt_U_CL_DESCRI.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Orden de trabajo"].ToString();
                txt_Code.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Codigo de documento"].ToString();
                txt_TipoDocumento.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Documento"].ToString();
                txt_serie.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Serie"].ToString();
                txt_numero.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Numero de documento"].ToString();
                txt_FechaRecepcion.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Fecha de recepcion"].ToString();
                txt_FechaDocumento.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Fecha de documento"].ToString();
                txt_DocDate.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Fecha de contabilización"].ToString();
                txt_FechaVencimiento.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Fecha de vencimiento"].ToString();
                txt_prioridad.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Codigo de prioridad"].ToString();
                cbo_prioridad.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Prioridad"].ToString();
                txt_CurrCode.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Codigo de moneda"].ToString();
                cbo_CurrName.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Moneda"].ToString();
                txt_SubTotal.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Sub Total"].ToString();
                swtigv = Convert.ToInt32(AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Incluye impuesto"].ToString());

                if (swtigv == 1)
                {

                    chk_igv.Checked = true;

                }
                else
                {
                    chk_igv.Checked = false;
                }

                txt_impuesto.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Impuesto"].ToString();
                txt_Total.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Total"].ToString();
                txt_retencion.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Retencion"].ToString();
                txt_ImporteAplicado.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Importe aplicado"].ToString();
                txt_SaldoPendiente.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Saldo pendiente"].ToString();
                txt_DocNum.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Nº SAP"].ToString();
            
                txt_Observaciones.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Observaciones"].ToString();
                txt_DocReferencia.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Documento de referencia"].ToString();
                txt_NroLetra.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Nro de letra"].ToString();
                txt_OC.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Orden de compra"].ToString();
                txt_OS.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Orden de srvicio"].ToString();
                txt_NotaIngreso.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Nota de ingreso"].ToString();
                txt_GuiaRemision.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Guia de remision"].ToString();
                txt_usr_crea.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Creador"].ToString();
             //   txt_fec_crea.Text = AccesoLogica.consultar_OTDC(Convert.ToInt32(txt_idreg.Text), "Consultar", "Consultar").Rows[0]["Creado"].ToString();




                btn_grabar.Text = "Actualizar";
                btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                btn_grabar.Enabled = true;
                btn_consultar_b.Enabled = true;
                btn_nuevo_b.Enabled = true;


                #region bloquea textbox

                btn_opciones.Visible = false;
                txt_CardCode.Enabled = false;
                txt_CardCode.BackColor = Color.FromArgb(231, 231, 231);

                txt_CardName.ReadOnly = true;
                txt_CardName.BackColor = Color.FromArgb(231, 231, 231);

                txt_idreg.ReadOnly = true;
                txt_idreg.BackColor = Color.FromArgb(231, 231, 231);


                txt_serie.ReadOnly = true;
                txt_serie.BackColor = Color.FromArgb(231, 231, 231);


                txt_numero.ReadOnly = true;
                txt_numero.BackColor = Color.FromArgb(231, 231, 231);


                txt_estado.ReadOnly = true;
                txt_estado.BackColor = Color.FromArgb(231, 231, 231);


                btn_opciones_2.Visible = false;
                txt_TipoDocumento.Enabled = false;
                txt_TipoDocumento.BackColor = Color.FromArgb(231, 231, 231);



                #endregion
                txt_U_CL_DESCRI.Focus();
              
            }
            catch
            {
                util.mensaje("No existen registros coincidentes", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
        }

        #endregion

        #region Formulario

        public FrmDocumentos()
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

        private void txt_TipoDocumento_Enter(object sender, EventArgs e)
        {
            if (operacion == "Nuevo")
            {
               
                    txt_TipoDocumento.BackColor = Color.FromArgb(254, 240, 158);
                    btn_opciones_2.Visible = true;
                    if (!String.IsNullOrEmpty(txt_TipoDocumento.Text))
                    {
                        txt_TipoDocumento.SelectionStart = 0;
                        txt_TipoDocumento.SelectionLength = txt_TipoDocumento.Text.Length;
                    }
                
            }
        }

        private void txt_CardCode_Enter(object sender, EventArgs e)
        {
           
                txt_CardCode.BackColor = Color.FromArgb(254, 240, 158);
                btn_opciones.Visible = true;
                if (!String.IsNullOrEmpty(txt_CardCode.Text))
                {
                    txt_CardCode.SelectionStart = 0;
                    txt_CardCode.SelectionLength = txt_CardCode.Text.Length;
                }
           
        }

        private void txt_IdActivo_Leave(object sender, EventArgs e)
        {
            txt_CardCode.BackColor = Color.White;
        }

        private void txt_U_CL_DESCRI_Enter(object sender, EventArgs e)
        {
            txt_U_CL_DESCRI.BackColor = Color.FromArgb(254, 240, 158);
            btn_opciones_3.Visible = true;
            if (!String.IsNullOrEmpty(txt_U_CL_DESCRI.Text))
            {
                txt_U_CL_DESCRI.SelectionStart = 0;
                txt_U_CL_DESCRI.SelectionLength = txt_U_CL_DESCRI.Text.Length;
            }
        }

        private void chk_DocReferencia_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_DocReferencia.Checked == true)
            {
                txt_DocReferencia.ReadOnly = false;
                txt_DocReferencia.Focus();
            }
            else
            {
                txt_DocReferencia.ReadOnly = true;
            }
        }

        private void chk_NroLetra_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_NroLetra.Checked == true)
            {
                txt_NroLetra.ReadOnly = false;
                txt_NroLetra.Focus();
            }
            else
            {
                txt_NroLetra.ReadOnly = true;
            }
        }

        private void chk_OC_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_OC.Checked == true)
            {
                txt_OC.ReadOnly = false;
                txt_OC.Focus();
            }
            else
            {
                txt_OC.ReadOnly = true;
            }
        }

        private void chk_OS_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_OS.Checked == true)
            {
                txt_OS.ReadOnly = false;
                txt_OS.Focus();
            }
            else
            {
                txt_OS.ReadOnly = true;
            }
        }

        private void chk_NotaIngreso_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_NotaIngreso.Checked == true)
            {
                txt_NotaIngreso.ReadOnly = false;
                txt_NotaIngreso.Focus();
            }
            else
            {
                txt_NotaIngreso.ReadOnly = true;
            }
        }

        private void chk_GuiaRemision_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_GuiaRemision.Checked == true)
            {
                txt_GuiaRemision.ReadOnly = false;
                txt_GuiaRemision.Focus();
            }
            else
            {
                txt_GuiaRemision.ReadOnly = true;
            }
        }

        private void chk_igv_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_igv.Checked == true)
            {
                swtigv = 1;
                subtotal = Convert.ToDecimal(txt_SubTotal.Text);

                impuesto = subtotal * 0.18m;

                total = impuesto + subtotal;

                txt_impuesto.Text = impuesto.ToString("N2");
                txt_Total.Text = total.ToString("N2");
            }
            else
            {
                swtigv = 0;
                txt_impuesto.Text = "0";
                subtotal = Convert.ToDecimal(txt_SubTotal.Text);
                txt_Total.Text = subtotal.ToString("N2");
            }
        }

        private void cbo_prioridad_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbo_prioridad.Text == "Normal")
            {
                txt_prioridad.Text = "1";
            }

            if (cbo_prioridad.Text == "Alta")
            {
                txt_prioridad.Text = "2";
            }

            if (cbo_prioridad.Text == "Muy alta")
            {
                txt_prioridad.Text = "3";
            }
        }

        private void cbo_CurrName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_CurrCode.Text = cbo_CurrName.SelectedValue.ToString();
        }

        private void txt_SubTotal_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_SubTotal.Text))
            {
                if (chk_igv.Checked == true)
                {
                    subtotal = Convert.ToDecimal(txt_SubTotal.Text);

                    impuesto = subtotal * 0.18m;

                    total = impuesto + subtotal;

                    txt_impuesto.Text = impuesto.ToString("N2");
                    txt_Total.Text = total.ToString("N2");
                }
                else
                {
                    subtotal = Convert.ToDecimal(txt_SubTotal.Text);


                    txt_Total.Text = subtotal.ToString("N2");
                }
            }
        }

        private void txt_NotaIngreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void dp_FechaRecepcion_ValueChanged(object sender, EventArgs e)
        {
           txt_FechaRecepcion.Text = dp_FechaRecepcion.Text;
        }

        private void dp_FechaVencimiento_ValueChanged(object sender, EventArgs e)
        {
            txt_FechaVencimiento.Text = dp_FechaVencimiento.Text;
        }

        private void dp_FechaDocumento_ValueChanged(object sender, EventArgs e)
        {

            txt_FechaDocumento.Text = dp_FechaDocumento.Text;
        }

        private void txt_idreg_Enter(object sender, EventArgs e)
        {

            txt_idreg.BackColor = Color.FromArgb(254, 240, 158);

            if (!String.IsNullOrEmpty(txt_idreg.Text))
            {
                txt_idreg.SelectionStart = 0;
                txt_idreg.SelectionLength = txt_idreg.Text.Length;
            }

        }

        private void txt_SubTotal_Enter(object sender, EventArgs e)
        {
            txt_SubTotal.BackColor = Color.FromArgb(254, 240, 158);

            if (!String.IsNullOrEmpty(txt_SubTotal.Text))
            {
                txt_SubTotal.SelectionStart = 0;
                txt_SubTotal.SelectionLength = txt_CardCode.Text.Length;
            }
        }

        private void txt_SubTotal_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_SubTotal.Text))
            {
                txt_SubTotal.SelectionStart = 0;
                txt_SubTotal.SelectionLength = txt_SubTotal.Text.Length;
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

        public void btn_nuevo_b_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            inicializar();

            txt_CardCode.Enabled = true;
            txt_CardCode.Focus();
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

            txt_idreg.Enabled = true;
            txt_idreg.ReadOnly = false;
            txt_idreg.Clear();
            txt_idreg.Focus();
          


        }
             
        private void btn_opciones_Click(object sender, EventArgs e)
        {
            FrmListado opciones = new FrmListado();
            opciones.titulo = "Lista de Socios de negocios";
            opciones.parametro_1 = "PL";
            opciones.ShowDialog(this);

        }
        
        private void btn_utlimo_Click(object sender, EventArgs e)
        {
            posicion = dgv_lista.Rows.Count - 1;

            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            txt_idreg.Text = dgv_lista.CurrentRow.Cells[0].Value.ToString();
            consultar_navegacion();

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (posicion < dgv_lista.Rows.Count - 1)
            {
                posicion = posicion + 1;
            }


            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            txt_idreg.Text = dgv_lista.CurrentRow.Cells[0].Value.ToString();
            consultar_navegacion();
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            posicion = 0;

            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            txt_idreg.Text = dgv_lista.CurrentRow.Cells[0].Value.ToString();
            consultar_navegacion();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion = posicion - 1;
            }


            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            txt_idreg.Text = dgv_lista.CurrentRow.Cells[0].Value.ToString();
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

                if (txt_CardCode.Text == string.Empty)
                {
                    util.mensaje("El campo " + lbl_CardCode.Text + " no debe estar vacio; indique un valor para " + lbl_CardCode.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    txt_CardCode.Focus();
                    return;

                }

                if (txt_U_CL_DESCRI.Text == string.Empty)
                {
                    util.mensaje("El campo " + lbl_ot.Text + " no debe estar vacio; indique un valor para " + lbl_ot.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    txt_U_CL_DESCRI.Focus();
                    return;

                }

                if (txt_SubTotal.Text == string.Empty)
                {
                    util.mensaje("El campo " + lbl_total.Text + " no debe estar vacio; indique un valor para " + lbl_total.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    txt_SubTotal.Focus();
                    return;

                }

                if (txt_TipoDocumento.Text == string.Empty)
                {
                    util.mensaje("El campo " + lbl_tdoc.Text + " no debe estar vacio; indique un valor para " + lbl_tdoc.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    txt_TipoDocumento.Focus();
                    return;

                }

                if (txt_CurrCode.Text == string.Empty)
                {
                    util.mensaje("El campo " + lbl_moneda.Text + " no debe estar vacio; indique un valor para " + lbl_moneda.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    cbo_CurrName.Focus();
                    return;

                }

                if (txt_serie.Text == string.Empty)
                {
                    util.mensaje("El campo serie " + " no debe estar vacio; indique un valor para serie.", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    txt_serie.Focus();
                    return;

                }

                if (txt_numero.Text == string.Empty)
                {
                    util.mensaje("El campo " + lbl_numerodoc.Text + " no debe estar vacio; indique un valor para " + lbl_numerodoc.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    txt_numero.Focus();
                    return;

                }

                if (txt_prioridad.Text == string.Empty)
                {
                    util.mensaje("El campo " + lbl_prioridad.Text + " no debe estar vacio; indique un valor para " + lbl_prioridad.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    cbo_prioridad.Focus();
                    return;

                }


                #endregion 
                
                #region validaciones detalle
             
                #endregion

              

                try
                {
                                   
                        int resultado = Negocio.mantenimiento_OTDC
                            (
                           Convert.ToInt32(txt_idreg.Text), 
                           txt_CardCode.Text, 
                           txt_Code.Text,
                           txt_serie.Text, 
                           txt_numero.Text,
                           txt_FechaDocumento.Text,
                           txt_FechaVencimiento.Text, 
                           txt_CurrCode.Text, 
                           Convert.ToDecimal(txt_SubTotal.Text),
                           swtigv, 
                           Convert.ToDecimal(txt_impuesto.Text),
                           Convert.ToDecimal(txt_Total.Text), 
                           Convert.ToDecimal(txt_retencion.Text),
                           txt_Observaciones.Text, 
                           txt_DocReferencia.Text, 
                           txt_NroLetra.Text, 
                           txt_PrcCode.Text, 
                           txt_OC.Text, 
                           txt_OS.Text, 
                           txt_NotaIngreso.Text,
                           txt_GuiaRemision.Text,
                           Convert.ToInt32(txt_prioridad.Text), 
                           Convert.ToInt32(txt_estadodoc.Text), 
                           "",	
                           "",	
                           "", 
                           0,	
                           "",	
                           "",	
                           0,
                           txt_fec_crea.Text, 
                           txt_usr_crea.Text,
                           DateTime.Now.ToString("yyyy-MM-dd hh:mm"), 
                           txt_usr_modi.Text, 
                           Convert.ToInt32(txt_numref.Text), 
                           operacion,
                           txt_formulario.Text,
                           txt_FechaRecepcion.Text
                           );

                        if (resultado != 1)
                        {
                           /// Negocio = null;

                            lbl_msg.Text = AccesoLogica.consultar_OERR(resultado).Rows[0]["Mensaje"].ToString();

                            util.mensaje(lbl_msg.Text, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                            return;
                        }


                      //  GrabarAnexos();
                                    
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

                if (txt_idreg.Text == "*")
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

                dgv_anexo.Rows.Add(@"\\10.0.0.8\Comun\MISAP\Anexos\Tramite documentario", archi, txt_fec_crea.Text, ext, txt_idreg.Text, NumLinea, openarchivo);

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

                int resultado = Negocio.mantenimiento_OTDC
                    (
                   Convert.ToInt32(txt_idreg.Text),
                   txt_CardCode.Text,
                   txt_Code.Text,
                   txt_serie.Text,
                   txt_numero.Text,
                   dp_FechaDocumento.Text,
                   dp_FechaVencimiento.Text,
                   txt_CurrCode.Text,
                   Convert.ToDecimal(txt_SubTotal.Text),
                   swtigv,
                   Convert.ToDecimal(txt_impuesto.Text),
                   Convert.ToDecimal(txt_Total.Text),
                   Convert.ToDecimal(txt_retencion.Text),
                   txt_Observaciones.Text,
                   txt_DocReferencia.Text,
                   txt_NroLetra.Text,
                   txt_PrcCode.Text,
                   txt_OC.Text,
                   txt_OS.Text,
                   txt_NotaIngreso.Text,
                   txt_GuiaRemision.Text,
                   Convert.ToInt32(txt_prioridad.Text),
                   Convert.ToInt32(txt_estadodoc.Text),
                   "",
                   "",
                   "",
                   0,
                   "",
                   "",
                   0,
                   txt_fec_crea.Text,
                   txt_usr_crea.Text,
                   DateTime.Now.ToString("yyyy-MM-dd hh:mm"),
                   txt_usr_modi.Text,
                   Convert.ToInt32(txt_numref.Text),
                   operacion,
                   txt_formulario.Text,
                   dp_FechaRecepcion.Text
                   );
                if (resultado == 0) Negocio = null;

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

        private void btn_cargo_Click(object sender, EventArgs e)
        {
            FrmCargoDoc cargo = new FrmCargoDoc();
            cargo.usuario = usuario;
            cargo.perfil = perfil;
            cargo.Show();
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
