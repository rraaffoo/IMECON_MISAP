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
using SAPbobsCOM;

namespace MISAP
{
    public partial class FrmMaestroArticulo : Form, IForm_Listado
    {

        #region Variables globales

        public string usuario, perfil, bd_sap;

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
        string operacion, ItemCode;
        int posicion, columna, IdVm;
      
    
        int cant_col, ColumnaId, id;
        int[] vector, vec_col;
        bool[] vec_falg;
        bool visible_;

        private Documents documento;
        private Items oItem;
        private StockTransfer documentos;


        private SAPbobsCOM.SBObob oSBObob;

        #endregion

        #region Perzonalizacion de controles

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() :
                base(new Utilidades.MyColors()) { }
        }

        private void cbo_proyecto_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Nombre de proyecto");
        }

        private void cbo_ot_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Nombre de OT");
        }

      

        #endregion

        #region Formulario externo

        public void pasar_valores(string par1, string par2, string par3, string par4, string par5, string par6)
        {
            try
            {
                #region Consultar

                if (operacion == "Consultar")
                {

                    if (par5 == "Lista de Articulos")
                    {
                        txt_ItemCode.Text = par1;
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
            operacion = "Consultar"; 
            txt_ItemCode.BackColor = Color.FromArgb(254, 240, 158);
            txt_ItemCode.Focus();

            dgv_lista.DataSource = AccesoLogica.consultar_OITM("", "Consultar", "Listar");
                     

            if (dgv_lista.Rows.Count != 0)
            {
                posicion = 0;
                dgv_lista.CurrentCell = dgv_lista.Rows[0].Cells[0];
              
            }
            // limpiar(); 
            
          

            util.FormatearFormulario_sap(this, ts_acciones, tc_detalle, ss_load, tp_listado, tp_auditoria);
            util.Formateardetalle(tp_contenido,tp_listado);
            this.Location = new System.Drawing.Point(320, 80);

            util.EstablecerAuditoria(operacion, usuario, "", "FrmMaestroArticulo", "S", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);
         
            

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

        void limpiar()
        {
           
           util.limpiarTextBoxes(this);
           this.txt_ItemCode.Focus();
             
        }
       
        private void consultar_navegacion()
        {
            try
            {
                operacion = "Consultar";


                txt_ItemCode.Text = AccesoLogica.consultar_OITM(txt_ItemCode.Text, "Consultar", "Consultar").Rows[0][0].ToString();
                txt_ItemName.Text = AccesoLogica.consultar_OITM(txt_ItemCode.Text, "Consultar", "Consultar").Rows[0][1].ToString();
                txt_ItemGrpCod.Text = AccesoLogica.consultar_OITM(txt_ItemCode.Text, "Consultar", "Consultar").Rows[0][2].ToString();
                txt_DesPar.Text = AccesoLogica.consultar_OITM(txt_ItemCode.Text, "Consultar", "Consultar").Rows[0][3].ToString();
                txt_Familia.Text = AccesoLogica.consultar_OITM(txt_ItemCode.Text, "Consultar", "Consultar").Rows[0][4].ToString();
                txt_DesCorta.Text = AccesoLogica.consultar_OITM(txt_ItemCode.Text, "Consultar", "Consultar").Rows[0][5].ToString();
                txt_longitud.Text = AccesoLogica.consultar_OITM(txt_ItemCode.Text, "Consultar", "Consultar").Rows[0][6].ToString();
                txt_Peso.Text = AccesoLogica.consultar_OITM(txt_ItemCode.Text, "Consultar", "Consultar").Rows[0][7].ToString();
              

                btn_grabar.Text = "Actualizar";
                btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                btn_grabar.Enabled = true;
                btn_consultar_b.Enabled = true;
           

                #region bloquea textbox

               // txt_ItemCode.Enabled = false;
                txt_ItemCode.ReadOnly = true;
                txt_ItemCode.BackColor = Color.FromArgb(231, 231, 231);

                txt_ItemName.ReadOnly = true;
                txt_ItemName.BackColor = Color.FromArgb(231, 231, 231);

                txt_ItemGrpCod.ReadOnly = true;
                txt_ItemGrpCod.BackColor = Color.FromArgb(231, 231, 231);

                txt_DesPar.ReadOnly = true;
                txt_DesPar.BackColor = Color.FromArgb(231, 231, 231);

                txt_Familia.ReadOnly = true;
                txt_Familia.BackColor = Color.FromArgb(231, 231, 231);


                #endregion
                txt_DesCorta.BackColor = Color.FromArgb(254, 240, 158);
                txt_DesCorta.Focus();
            }
            catch
            {
                util.mensaje("No existen registros coincidentes", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
        }

        #endregion

        #region Formulario

        public FrmMaestroArticulo()
        {
            InitializeComponent();
            ts_acciones.Renderer = new MyRenderer();
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
            }
            else
            {
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
                this.SetBounds(this.Location.X, this.Location.Y, 615, 525);
                this.Location = new System.Drawing.Point(320, 80);

                lbl_maximi.Text = "1";
            }


         

        }

        private void salir_Click(object sender, EventArgs e)
        {
            if (lbl_estado_evento.Text == "0")
            {
                DialogResult result = MessageBox.Show("Los datos no guardados se perderán. ¿Desea continuar sin guardar?", "Mensaje sistema", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Conexion.oCompany.Disconnect();
                    Close();

                }
                else
                {
                    return;
                }

            }

            else
            {
                Close();
            }
        }

        private void titulo_DoubleClick(object sender, EventArgs e)
        {

            if (lbl_maximi.Text == "1")
            {
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
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

            //pos = new Point(e.X, e.Y);
            //move = true;

            //dragging = true;
            //dragCursorPoint = Cursor.Position;
            //dragFormPoint = this.Location;
        }

        private void titulo_MouseMove(object sender, MouseEventArgs e)
        {
            //if (dragging)
            //{
            //    Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
            //    this.Location = Point.Add(dragFormPoint, new Size(dif));
            //}
            
            //if (move)
            //    this.Location = new Point((this.Left + e.X - pos.X),
            //        (this.Top + e.Y - pos.Y));
        }

        private void titulo_MouseUp(object sender, MouseEventArgs e)
        {
            //dragging = false;
            
            //move = false;
        }

        #endregion

        #region Eventos

        private void FrmAvanceProyecto_Load(object sender, EventArgs e)
        {
           
            inicializar();
       
        }

      

        
        private void t_msg_Tick(object sender, EventArgs e)
        {
            lbl_msg.Text = string.Empty;
            ss_load.BackColor = Color.Transparent;
            lbl_contador_registros.Visible = true;
            lbl_msg.Visible = false;
        }


        #endregion

        #region Botones

        private void btn_nuevo_b_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_consultar_b_Click(object sender, EventArgs e)
        {
            operacion = "Consultar";
            limpiar();
            

            btn_nuevo_b.Enabled = true;
            btn_consultar_b.Enabled = false;
            btn_grabar.Text = "Buscar";

         
           // txt_ItemCode.Enabled = true;
            txt_ItemCode.ReadOnly = false;
            txt_ItemCode.BackColor = Color.FromArgb(254, 240, 158);
            txt_ItemCode.Focus();

        }
       
        
        private void btn_opciones_Click(object sender, EventArgs e)
        {
            FrmOpciones opciones = new FrmOpciones();
            opciones.titulo = "Lista de ordenes de trabajo";
          //  opciones.parametro_1 = txt_cod_proyecto.Text;
            opciones.ShowDialog(this);

        }
        
        private void btn_utlimo_Click(object sender, EventArgs e)
        {
            posicion = dgv_lista.Rows.Count - 1;

            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            txt_ItemCode.Text = dgv_lista.CurrentRow.Cells[0].Value.ToString();
            consultar_navegacion();

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (posicion < dgv_lista.Rows.Count - 1)
            {
                posicion = posicion + 1;
            }


            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            txt_ItemCode.Text = dgv_lista.CurrentRow.Cells[0].Value.ToString();
            consultar_navegacion();
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            posicion = 0;

            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            txt_ItemCode.Text = dgv_lista.CurrentRow.Cells[0].Value.ToString();
            consultar_navegacion();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion = posicion - 1;
            }


            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            txt_ItemCode.Text = dgv_lista.CurrentRow.Cells[0].Value.ToString();
            consultar_navegacion();
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
         
            if (operacion == "Consultar")
            {
                if (btn_grabar.Text == "OK")
                {
                    Conexion.oCompany.Disconnect();
                    Close();
                }

                try
                {
                        this.oItem = (Items)Conexion.oCompany.GetBusinessObject(BoObjectTypes.oItems);
                        oItem.GetByKey(txt_ItemCode.Text);

                        oItem.UserFields.Fields.Item("U_U_DSC_MAT").Value = txt_DesCorta.Text;
                        //oItem.PurchaseWidthUnit1 =  Int32.Parse(txt_Peso.ToString());
                        //oItem.PurchaseUnitLength1 = Int32.Parse(txt_longitud.ToString());

                        if (oItem.Update() == 0)
                        {
                            util.mensaje("Operación finalizada con éxito", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                        }

                        else
                        {
                            int rpta = 0;
                            string msj = "";
                            Conexion.oCompany.GetLastError(out rpta, out msj);
                            util.mensaje(rpta + " " + msj, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                            return;
                        }
              
                    
                        if (btn_grabar.Text == "Actualizar")
                        {
                            btn_grabar.Text = "OK";
                        }

                }
                catch (Exception ex)
                {
                    util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    return;
                }

            }
       

        }

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
          
        }

        private void txt_ItemCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                if (txt_ItemCode.Text == "*")
                {
                    FrmListado Listado = new FrmListado();
                    Listado.titulo = "Lista de Articulos";
                    Listado.ShowDialog(this);
                }
                else
                {
                    if (txt_ItemCode.Text != "")
                    {
                        consultar_navegacion();
                    }
                }
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



        private void txt_ItemCode_Leave(object sender, EventArgs e)
        {
            if (operacion != "Consultar")
            {
                txt_ItemCode.BackColor = Color.White;
            }
        }

        private void txt_ItemCode_Enter(object sender, EventArgs e)
        {
            if (operacion != "Consultar")
            {
                txt_ItemCode.BackColor = Color.FromArgb(254, 240, 158);
                if (!String.IsNullOrEmpty(txt_ItemCode.Text))
                {
                    txt_ItemCode.SelectionStart = 0;
                    txt_ItemCode.SelectionLength = txt_ItemCode.Text.Length;
                }
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
