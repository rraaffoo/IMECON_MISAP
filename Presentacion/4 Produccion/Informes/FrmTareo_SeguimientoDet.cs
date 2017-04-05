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
    public partial class FrmTareo_SeguimientoDet : Form
    {

        #region Variables globales

        public string usuario, perfil;
        public string anio;
        public string semana;
        public string documento;

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

        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();
        string filtro, cod_ot;
        int contador;
        double suma_horas_trabajadas, suma_horas_extras, suma_horas_semanales, suma_extras_semanales;


        string horas_trabajadas, horas_extras, horas_semanales, extras_semanales;

        #endregion
        
        #region Formulario

        public FrmTareo_SeguimientoDet()
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


                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));

                lbl_maximi.Text = "0";


            }
            else
            {
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
                this.SetBounds(this.Location.X, this.Location.Y, 712, 610);
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

        #region Funciones

        private void inicializar()
        {

            //util.EstablecerAuditoria(operacion, usuario, "", "7092", "S", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

        }

        void formatear_grilla(DataGridView grilla)
        {

            try
            {
                util.FormatearGrilla(grilla, true);
                grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
              //  grilla.Columns["U_CL_CODSOL"].Visible = false;

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

        private void FrmTareoAsignacio_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_responsables_tareo(anio, semana, documento);
            }
            catch (Exception)
            {
                throw;
            }
            try
            {
                cargar_responsables_asignados(documento);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private void cargar_responsables_tareo(string anio, string semana, string documento)
        {
            dgvResponsableTareo.DataSource = AccesoLogica.cargar_responsables(anio, semana, documento);
            util.FormatearGrilla(dgvResponsableTareo, true);
        }
        private void cargar_responsables_asignados(string documento)
        {
            dgvResponsablesAsign.DataSource = AccesoLogica.cargar_responsables_asign(documento);
            util.FormatearGrilla(dgvResponsablesAsign, true);
        }
        
        

    }
}
