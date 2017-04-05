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
    public partial class FrmTareo_Reporte : Form
    {
       
        
        #region Variables globales

        public string _usuario, _perfil, _dni, titulo_rep;
        public DataTable dt_reporte = new DataTable();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        #region Variables locales


        string filtro;
        private Point pos = Point.Empty;
        private bool move = false;
       
        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();
       
        #endregion

        #region Formulario

        public FrmTareo_Reporte()
        {
            InitializeComponent();
            
        }

        private void ninimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizar_Click(object sender, EventArgs e)
        {

            this.WindowState = (this.WindowState == FormWindowState.Maximized ?

                FormWindowState.Normal
                : FormWindowState.Maximized);

            if (this.WindowState == FormWindowState.Maximized)
            {
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));


            }

            if (this.WindowState == FormWindowState.Normal)
            {

                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
            }


            //if (lbl_maximi.Text == "1")
            //{
            //    this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //    maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));

            //    lbl_maximi.Text = "0";
            //}
            //else
            //{
            //    this.StartPosition = FormStartPosition.CenterScreen;
            //    maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
            //    this.SetBounds(this.Location.X, this.Location.Y, 919, 674);


            //    lbl_maximi.Text = "1";
            //}
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void titulo_DoubleClick(object sender, EventArgs e)
        {

            this.WindowState = (this.WindowState == FormWindowState.Maximized ?

                FormWindowState.Normal
                : FormWindowState.Maximized);

            if (this.WindowState == FormWindowState.Maximized)
            {
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));


            }

            if (this.WindowState == FormWindowState.Normal)
            {

                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
            }

        }

        private void titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); 
        }
             
        #endregion

        #region Botones
        
        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
            if (dgvTareo_reporte.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para exportar", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            util.exportarExcel(dgvTareo_reporte);
        }


        #endregion

        #region Perzonalizacion de controles

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() :
                base(new Utilidades.MyColors()) { }
        }

        
        #endregion

        #region Funciones

        void formatear_grilla()
        {

            try
            {
                util.FormatearGrilla(dgvTareo_reporte, false);
              
                lbl_contador_registros.Visible = true;
                lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgvTareo_reporte.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Fabricación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        void activar_boton(bool nuevo, bool editar, bool consultar, bool eliminar, bool imprimir, bool previsualizar, bool exportar_xls, bool aprobar, bool desaprobar, bool actualizar, bool ayuda, bool grabar, bool cancelar)
        {
          
            btn_exportar_xls.Enabled = exportar_xls;
            btn_actualizar.Enabled = actualizar;
         

        }

        #endregion

        #region Eventos

        private void FrmTareo_Load(object sender, EventArgs e)
        {
            tsl_titulo.Text = titulo_rep;
           dgvTareo_reporte.DataSource = dt_reporte;
           formatear_grilla();

        }

        private void dgvTareo_reporte_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvTareo_reporte.Rows.Count > 0)
            {
                txt_buscar.Enabled = true;
                txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
                txt_buscar.Focus();
                txt_buscar.Clear();

                filtro = dgvTareo_reporte.Columns[e.ColumnIndex].HeaderText;
                lbl_buscar.Text = "Buscar en " + filtro;

                dgvTareo_reporte.CurrentCell = dgvTareo_reporte.Rows[0].Cells[e.ColumnIndex];
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            (dgvTareo_reporte.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" + " ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
            lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgvTareo_reporte.Rows.Count);
        }

        #endregion

        #region Menu contextual

        private void cm_grilla_copia_tabla_Click(object sender, EventArgs e)
        {
            util.copiar_todo_encabezados(dgvTareo_reporte);
        }

        private void cm_grilla_copia_Click(object sender, EventArgs e)
        {
            util.copiar_contextual(dgvTareo_reporte);
        }

        #endregion

        

    

    }

}
