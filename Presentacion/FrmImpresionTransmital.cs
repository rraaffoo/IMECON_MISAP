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
using System.Runtime.InteropServices;

namespace MISAP
{
    public partial class FrmImpresionTransmital : Form
    {
        #region Variables Globales

        public string formulario, titulo, bd, sp, parametro_1, parametro_2, parametro_3, parametro_4;
        public int parametro_1_n, parametro_2_n;

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


        Utilidades util = new Utilidades();
        DataTable dtable = new DataTable();
        DataSet ds = new DataSet();
        AccesoLogica _negocio = new AccesoLogica();

        string ppcodigo, ppfecha, ppestado, ppcodProy, palmacen;
        string par1, par2, par3, par4, par6;

        string filtro;
        int columna;

        decimal total_sol, total_dolar;
        decimal total_sol_ = 0, total_dolar_ = 0;


        #endregion

        #region Eventos

        private void FrmOpciones_Load(object sender, EventArgs e)
        {
            lbl_titulo.Text = titulo;
            this.BackColor = Color.FromArgb(247, 247, 247);
            txtTransmital.BackColor = Color.FromArgb(254, 240, 158);

        }
        
        #endregion

        #region Botones

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {



            try
            {

                dtable = AccesoLogica.impresion_transmital(txtTransmital.Text);


                //DataSet ds = new DataSet();
                //ds.Tables.Add(dtable);
                //ds.WriteXmlSchema("C:\\tmp\\RptImpresionTransmital.xml");

                Rpt_ImpresionTransmital Rpt = new Rpt_ImpresionTransmital();
                Rpt.Refresh();
                Rpt.SetDataSource(dtable);
                CrvReporte form = new CrvReporte((Object)Rpt);
                //form.Text = "Vista previa - ";
                form.ShowDialog();
                Rpt.Dispose();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error: " + Ex.Message);
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Funciones
        

        #endregion

        #region Formulario

        public FrmImpresionTransmital()
        {
            InitializeComponent();
        }

        public FrmImpresionTransmital(string pcodigo, string pfecha, string pestado, string pcodProy)
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

                //for (int i = 0; i < dgv_lista.Columns.Count - 1; i++)
                //{
                //    dgv_lista.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //}
                //dgv_lista.Columns[dgv_lista.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                
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

            //pos = new Point(e.X, e.Y);
            //move = true;
        }

        private void titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.Location = new Point((this.Left + e.X - pos.X),
                    (this.Top + e.Y - pos.Y));
        }

        private void titulo_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        #endregion

        private void txt_buscar_Enter(object sender, EventArgs e)
        {
            txtTransmital.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txtTransmital.Text))
            {
                txtTransmital.SelectionStart = 0;
                txtTransmital.SelectionLength = txtTransmital.Text.Length;
            }
        }

        private void txt_buscar_Leave(object sender, EventArgs e)
        {
            txtTransmital.BackColor = Color.White;
        }

        private void txt_buscar_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTransmital.Text))
            {
                txtTransmital.SelectionStart = 0;
                txtTransmital.SelectionLength = txtTransmital.Text.Length;
            }
        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                dtable = AccesoLogica.impresion_transmitalTM(txtTransmital.Text);


                //DataSet ds = new DataSet();
                //ds.Tables.Add(dtable);
                //ds.WriteXmlSchema("C:\\tmp\\RptImpresionTransmitalTM.xml");

                Rpt_ImpresionTransmitalTM Rpt = new Rpt_ImpresionTransmitalTM();
                Rpt.Refresh();
                Rpt.SetDataSource(dtable);
                CrvReporte form = new CrvReporte((Object)Rpt);
                form.ShowDialog();
                Rpt.Dispose();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error: " + Ex.Message);
            }            
        }
    }
}

