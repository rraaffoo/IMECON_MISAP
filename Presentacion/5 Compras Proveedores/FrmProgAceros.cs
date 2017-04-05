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
using System.Text.RegularExpressions;

namespace MISAP
{
    public partial class FrmProgAceros : Form
    {
       

        
        #region Variables globales

        public string usuario, perfil, PrcCode, U_CL_DESCRI, flag_pr_falt;

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
        string filtro, operacion, perfil_;
        int posicion, columna, idreg, cant_col, ColumnaId, id, swtigv,  NumLinea ;
        decimal cantidad_,longitud_;
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

        
        //private void cbo_ot_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    util.FormatearCombo(sender, e, "Nombre de OT");
        //}

      

        #endregion

        #region Formulario externo

     
        #endregion

        #region Funciones

        private void inicializar()
        {

            
            operacion = "Nuevo";
            formatear_grilla(dgv_lista);
          


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

        #endregion

        #region Formulario

         public FrmProgAceros()
        {
            InitializeComponent();
            
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
            }
            else
            {
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
                this.SetBounds(this.Location.X, this.Location.Y, 794, 452); 
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

        }

       
        #endregion

        #region Eventos

        private void FrmProgAceros_Load(object sender, EventArgs e)
        {

            this.Location = new System.Drawing.Point(320, 80);
            txt_U_CL_DESCRI.Text = U_CL_DESCRI;
            txt_PrcCode.Text = PrcCode;

            if (flag_pr_falt == "Ver faltante")
            {
                dgv_lista.DataSource = AccesoLogica.informe_seguimiento_aceros(flag_pr_falt, txt_PrcCode.Text);
                formatear_grilla(dgv_lista);
                btn_grabar.Visible = false;
                btn_cancelar.Visible = false;
            }
            else
            {
                if (flag_pr_falt == "Cargar programacion")
                {
                    
                }
            }

             //   txt_agrupar.Text = "Agrupado";
             //   dgv_lista.DataSource = AccesoLogica.informe_seguimiento_aceros(txt_agrupar.Text, txt_PrcCode.Text);
             //   formatear_grilla(dgv_lista);

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



                #endregion

                #region validaciones detalle

                #endregion


                try
                {
                    foreach (DataGridViewRow row in dgv_lista.Rows)
                    {
                        perfil_ = Convert.ToString(row.Cells["Perfilg"].Value);
                        longitud_ = Convert.ToDecimal(row.Cells["Longitudg"].Value);
                        cantidad_ = Convert.ToDecimal(row.Cells["Cantidadg"].Value);


                        int resultado = Negocio.mantenimiento_OPAC(txt_PrcCode.Text, perfil_, longitud_, cantidad_);
                        if (resultado == 0) Negocio = null;

                    }

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

        private void tsm_pegar_Click(object sender, EventArgs e)
        {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.Text))
            {
                if (dgv_lista.RowCount > 0)
                    dgv_lista.Rows.Clear();

                string[] pastedRows = Regex.Split(o.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                int j = 0;
                foreach (string pastedRow in pastedRows)
                {
                    string[] pastedRowCells = pastedRow.Split(new char[] { '\t' });

                    dgv_lista.Rows.Add();
                    int myRowIndex = dgv_lista.Rows.Count - 1;

                    using (DataGridViewRow myDataGridViewRow = dgv_lista.Rows[j])
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            myDataGridViewRow.Cells[i].Value = pastedRowCells[i];
                    }
                    j++;
                }
                formatear_grilla(dgv_lista);
                btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                btn_grabar.Enabled = true;
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
