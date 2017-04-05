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
    public partial class FrmDefiniciones : Form
    {
        
        #region Variables globales

        public string usuario, perfil, operacion_, titulo_;
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

        #region Funciones

        private void inicializar()
        {
            this.BackColor = Color.FromArgb(247, 247, 247);
            txt_buscar.BackColor = Color.FromArgb(254, 240, 158);
       //     formatear_grilla(dgv_lista);

          
        }

        void formatear_grilla(DataGridView grilla)
        {

            try
            {
                util.FormatearGrillaDefiniciones(grilla, false);
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
             
        #endregion

        #region Formulario

        public FrmDefiniciones()
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
            tsl_titulo.Text = titulo_ + " - Definiciones";

            #region Homologacion plan de cuentas
            if (titulo_ == "Homologacion plan de cuentas")
            {
              dgv_lista.DataSource = AccesoLogica.consultar_OPCE("", "Consultar", "Listar");
            }
            #endregion

            
                txt_buscar.Enabled = true;
               

          // formatear_grilla(dgv_lista);

          

        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            (dgv_lista.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" + " ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
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

    
        #endregion

        private void dgv_lista_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
          //  util.DataGridViewRowPosition(dgv_lista);
            dgv_lista[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
        }

        private void dgv_lista_CellEnter(object sender, DataGridViewCellEventArgs e)

        {
           // util.DataGridViewRowPosition(dgv_lista);
            dgv_lista[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.FromArgb(254, 240, 158);

      
        }

        private void dgv_lista_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar.Focus();
            txt_buscar.Clear();

            filtro = dgv_lista.Columns[e.ColumnIndex].HeaderText;
            dgv_lista.Text = "Buscar en " + filtro;

            dgv_lista.CurrentCell = dgv_lista.Rows[0].Cells[e.ColumnIndex];
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {

        }

        private void dgv_lista_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
            btn_grabar.Enabled = true;
            btn_grabar.Text = "Actualizar";
        }

       
     


    }
}
