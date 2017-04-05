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


namespace MISAP
{
    public partial class FrmCargarAsistencia : Form
    {

        #region Variables Globales

        public string formulario, titulo, usuario, cod_autorizacion;

        #endregion

        #region Variables locales


        private Point pos = Point.Empty;
        private bool move = false;


        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();

       
      
        #endregion

        #region Formulario

        public FrmCargarAsistencia()
        {
            InitializeComponent();
        }


        private void ninimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void titulo_MouseDown(object sender, MouseEventArgs e)
        {
            pos = new Point(e.X, e.Y);
            move = true;
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

        #region Eventos

        private void FrmClave_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(247, 247, 247);

            dp_dDesde.CustomFormat = "yyyy-MM-dd";
            dp_dHasta.CustomFormat = "yyyy-MM-dd";

        }

        #endregion

        #region Botones

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            if (dp_dDesde.Text == string.Empty)
            {

                MessageBox.Show("Seleccione la fecha de inicio", titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                dp_dDesde.Focus();
                return;
            }

            if (dp_dHasta.Text == string.Empty)
            {

                MessageBox.Show("Seleccione la fecha fin", titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                dp_dHasta.Focus();
                return;
            }

            int resultado = Negocio.cargar_asistencia(dp_dDesde.Text,dp_dHasta.Text, Convert.ToInt32(txt_tipo.Text));
            if (resultado == 0) Negocio = null;

            MessageBox.Show("Operación finalizada con éxito", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            
                
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "\\\\10.0.0.8\\Comun\\MISAP\\RELOJ\\att.exe";
            proc.Start();
            proc.Close();
        }

       
    }
}
