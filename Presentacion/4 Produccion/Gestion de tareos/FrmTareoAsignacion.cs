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
    public partial class FrmTareoAsignacion : Form
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

        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();
        string filtro, cod_ot;
        int contador;
        double suma_horas_trabajadas, suma_horas_extras, suma_horas_semanales, suma_extras_semanales;


        string horas_trabajadas, horas_extras, horas_semanales, extras_semanales;

        #endregion
        
        #region Formulario

        public FrmTareoAsignacion()
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
            cargar_combo_tareadores();  // cargar tareador
            cargar_grid_personal_asignado(cboTareador_conf.SelectedValue.ToString());   // cargar personal asignado
            cargar_combo_personal_total();  // cargar personal
        }

        private void cargar_combo_tareadores()
        {
            cboTareador_conf.DataSource = AccesoLogica.listar_combo_tareadores();
            cboTareador_conf.ValueMember = "codigo";
            cboTareador_conf.DisplayMember = "descripcion";
        }
        
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                    string taread = AccesoLogica.buscar_asignacion(cboPersonal_conf.SelectedValue.ToString()).Rows[0][0].ToString();
                    DialogResult resul = MessageBox.Show("Personal está asignado a " + taread + " ¿Desea ASIGNAR de todas maneras este personal?", "Personal Asignado", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        if (AccesoLogica.asignar_trab_tareador(cboTareador_conf.SelectedValue.ToString(), cboPersonal_conf.SelectedValue.ToString(), usuario) != 0)
                        {
                            util.mensaje("Asignado con Éxito", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                            cargar_grid_personal_asignado(cboTareador_conf.SelectedValue.ToString());
                        }
                        else
                        {
                            util.mensaje("Error al asignar", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                        }
                    }
                    else
                    {
                        return;
                    }
            }
            catch (Exception)
            {   
            }
            if (AccesoLogica.asignar_trab_tareador(cboTareador_conf.SelectedValue.ToString(), cboPersonal_conf.SelectedValue.ToString(), usuario) != 0)
            {
                util.mensaje("Asignado con Éxito", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                cargar_grid_personal_asignado(cboTareador_conf.SelectedValue.ToString());
            }
            else
            {
                util.mensaje("Error al asignar", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
            }
 
        }

      

        private void cargar_grid_personal_asignado(string dni)
        {
            dgvPerAsignado.DataSource = AccesoLogica.listar_grid_personal(dni,"2");
            formatear_grilla(dgvPerAsignado);


        }
      
        private void cargar_combo_personal_total()
        {
            cboPersonal_conf.DataSource = AccesoLogica.listar_combo_personal_total();
            cboPersonal_conf.ValueMember = "codigo";
            cboPersonal_conf.DisplayMember = "descripcion";
        }



        private void btnDesasignar_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Está seguro que desea DESASIGNAR este personal?", "Personal Asignado", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                string nro, nombre;

                Int32 FilasSeleccionadas = dgvPerAsignado.SelectedRows.Count;


                if (FilasSeleccionadas > 0)
                {
                    int elim = 0;
                    while (FilasSeleccionadas != elim)
                        foreach (DataGridViewRow row in dgvPerAsignado.Rows)
                        {
                            if (row.Selected == true)
                            {
                                nro = row.Cells["codigo"].Value.ToString();
                                nombre = row.Cells["descripcion"].Value.ToString();

                                if (AccesoLogica.desasignar_trab_tareador(cboTareador_conf.SelectedValue.ToString(), row.Cells["codigo"].Value.ToString(), usuario) != 0)
                                    elim++;
                            }
                        }
                }
                else
                {
                    util.mensaje("Debe seleccionar uno o más registros para DESASIGNAR", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                }
                cargar_grid_personal_asignado(cboTareador_conf.SelectedValue.ToString());
            }
            else
            {
                return;
            }
        }

        private void cboTareador_conf_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_grid_personal_asignado(cboTareador_conf.SelectedValue.ToString());
        }

        private void t_msg_Tick(object sender, EventArgs e)
        {
            lbl_msg.Text = string.Empty;
            ss_load.BackColor = Color.Transparent;
            lbl_contador_registros.Visible = true;
            lbl_msg.Visible = false;
        }

    }
}
