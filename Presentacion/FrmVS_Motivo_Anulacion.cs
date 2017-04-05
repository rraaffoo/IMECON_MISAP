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
    public partial class FrmVS_Motivo_Anulacion : Form
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
        AccesoLogica _negocio = new AccesoLogica();

        string ppcodigo, ppfecha, ppestado, ppcodProy, palmacen;
        string par1, par2, par3, par4, par6;

        string filtro;
        int columna;

        decimal total_sol, total_dolar;
        decimal total_sol_ = 0, total_dolar_ = 0;

        public string pCodigo, pMonto, pMoneda, pMotivo, pMotivoAdic, pEstado, pUsuario, pProyecto, pComentario, pEmpleadoCod, pEmpleadoDesc;
        public DateTime pFecha;


        #endregion

        #region Eventos

        private void FrmOpciones_Load(object sender, EventArgs e)
        {
            lbl_titulo.Text = titulo;
            this.BackColor = Color.FromArgb(247, 247, 247);
            txtMotivoRechazo.BackColor = Color.FromArgb(254, 240, 158);
            txtMotivoRechazo.Focus();
        }

        #endregion

        #region Botones

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Funciones
        

        #endregion

        #region Formulario

        public FrmVS_Motivo_Anulacion()
        {
            InitializeComponent();
        }

        public FrmVS_Motivo_Anulacion(string pcodigo, string pfecha, string pestado, string pcodProy)
        {
            InitializeComponent();
            ppcodigo = pcodigo; 
            ppfecha = pfecha; 
            ppestado = pestado;
            ppcodProy = pcodProy;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtMotivoRechazo.Text != string.Empty)
            {
                try
                {
                    pMotivoAdic = txtMotivoRechazo.Text;
                    _negocio.VS_SD_RegMod(pCodigo, pFecha, pMonto, pMoneda, pMotivo, pMotivoAdic, pEstado, pUsuario, pProyecto, pComentario, pEmpleadoCod, pEmpleadoDesc);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: "+ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el motivo del rechazo");
            }
            
        }

       

        
    }
}

