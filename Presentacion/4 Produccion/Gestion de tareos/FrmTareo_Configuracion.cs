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
    public partial class FrmTareo_Configuracion : Form
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

        string tareador = "";
        string ot = "";
        int anio_ctrl = 0;
        int semna_ctrl = 0;
        string anio_reg, semana_reg, usuario_reg, permiso_reg, ot_reg;
        string msj_usu_destino, msj_usu_ccdestino;
        int estado_reg,pfiltro;
        string filtro;
        string valorPrevio;
        DataTable dtRegistros = new DataTable();

        private Point pos = Point.Empty;
          
        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();
      
        #endregion
        
        #region Formulario

        public FrmTareo_Configuracion()
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
        
        #region Eventos
       
        private void FrmTareoControl_Load(object sender, EventArgs e)
        {
            util.EstablecerAuditoria("Nuevo", usuario, "", "7093", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);
            cargar_combo_asistencia();
            //cargar_combo_cerrada();
            cargar_combo_masivo();
            cargar_combo_anio();
            cargar_combo_anio_cerrada();
            cargar_combo_semana_conf(cboAnio_conf.SelectedValue.ToString());
            cargar_combo_semana_cerrada(cboAnioCerrada.SelectedValue.ToString());
            cargar_combo_tareadores();
            cargar_combo_personal_total();
            cargar_combo_acceso();
            cargar_configuracion_horas();
            rbtnAsistencia.Checked = true;
            
        }

        private void cargar_combo_semana_cerrada(string anio)
        {
            cboSemanaCerrada.DataSource = AccesoLogica.listar_semanas_anio(anio);
            cboSemanaCerrada.ValueMember = "codigo";
            cboSemanaCerrada.DisplayMember = "descripcion";
        }

        private void cargar_combo_anio_cerrada()
        {
            int anio_actual = System.DateTime.Now.Year;
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");
            DataRow dr;

            for (int i = anio_actual - 3; i <= anio_actual; i++)
            {
                dr = dt.NewRow();
                dr["Codigo"] = i.ToString();
                dr["Descripcion"] = i.ToString();
                dt.Rows.Add(dr);
            }

            cboAnioCerrada.DataSource = dt;
            cboAnioCerrada.ValueMember = "Codigo";
            cboAnioCerrada.DisplayMember = "Descripcion";
            cboAnioCerrada.SelectedIndex = 3;
        }

        private void cargar_configuracion_horas()
        {
            DataTable dtHoras = Negocio.listar_configuracion_horas();
            txtHN_normal.Text = dtHoras.Rows[0][0].ToString();
            txtHE_normal.Text = dtHoras.Rows[0][1].ToString();
            txtHT_normal.Text = dtHoras.Rows[0][2].ToString();
            txtHNsem_normal.Text = dtHoras.Rows[0][3].ToString();
            txtHEsem_normal.Text = dtHoras.Rows[0][4].ToString();
            txtHNsemad_normal.Text = dtHoras.Rows[0][5].ToString();
            txtHEsemAdd_normal.Text = dtHoras.Rows[0][6].ToString();
            txtHN_feriado.Text = dtHoras.Rows[0][7].ToString();
            txtHE_feriado.Text = dtHoras.Rows[0][8].ToString();
            txtHT_feriado.Text = dtHoras.Rows[0][9].ToString();
            txtHNsem_feriado.Text = dtHoras.Rows[0][10].ToString();
            txtHEsem_feriado.Text = dtHoras.Rows[0][11].ToString();
            txtHNsemAdd_feriado.Text = dtHoras.Rows[0][12].ToString();
            txtHEsemAdd_feriado.Text = dtHoras.Rows[0][13].ToString();
        }

        private void cargar_combo_acceso()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");
            DataRow dr;
            dr = dt.NewRow();

            dr["Codigo"] = "0";
            dr["Descripcion"] = "Sin Acceso";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "1";
            dr["Descripcion"] = "Tareador";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "2";
            dr["Descripcion"] = "Administrador de Personal";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "3";
            dr["Descripcion"] = "Jefe de Planta";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "4";
            dr["Descripcion"] = "Desarrollo de Sistemas";
            dt.Rows.Add(dr);

            cboNivelAcceso.DataSource = dt;
            cboNivelAcceso.ValueMember = "Codigo";
            cboNivelAcceso.DisplayMember = "Descripcion";
        }

        private void cargar_combo_personal_total()
        {
            cboPersonal.DataSource = Negocio.Listar_Personal_Activo();
            cboPersonal.ValueMember = "codigo";
            cboPersonal.DisplayMember = "descripcion";
        }

        private void cargar_combo_tareadores()
        {
            cboTareador_ctrl.DataSource = AccesoLogica.listar_combo_tareadores();
            cboTareador_ctrl.ValueMember = "codigo";
            cboTareador_ctrl.DisplayMember = "descripcion";
        }

        private void cargar_combo_anio()
        {
            int anio_actual = System.DateTime.Now.Year;
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");
            DataRow dr;

            for (int i = anio_actual - 3; i <= anio_actual; i++)
            {
                dr = dt.NewRow();
                dr["Codigo"] = i.ToString();
                dr["Descripcion"] = i.ToString();
                dt.Rows.Add(dr);
            }

            cboAnio_conf.DataSource = dt;
            cboAnio_conf.ValueMember = "Codigo";
            cboAnio_conf.DisplayMember = "Descripcion";
            cboAnio_conf.SelectedIndex = 3;

        }


        private void cargar_combo_semana_conf(string anio)
        {
            cboSemana_conf.DataSource = AccesoLogica.listar_semanas_anio(anio);
            cboSemana_conf.ValueMember = "codigo";
            cboSemana_conf.DisplayMember = "descripcion";
        }

        private void cargar_grilla_tareadores(string opcion)
        {
            dgvConfiguracion.DataSource = Negocio.cargar_grilla_tareadores(opcion);
        }

        private void cargar_combo_asistencia()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");
            DataRow dr;

            dr = dt.NewRow();
            dr["Codigo"] = "N";
            dr["Descripcion"] = "NO";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "S";
            dr["Descripcion"] = "SI";
            dt.Rows.Add(dr);
                        
            cboAsistencia.DataSource = dt;
            cboAsistencia.ValueMember = "Codigo";
            cboAsistencia.DisplayMember = "Descripcion";
        }

        

        private void cargar_combo_masivo()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");
            DataRow dr;

            dr = dt.NewRow();
            dr["Codigo"] = "N";
            dr["Descripcion"] = "NO";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "S";
            dr["Descripcion"] = "SI";
            dt.Rows.Add(dr);
            
            cboMasivo.DataSource = dt;
            cboMasivo.ValueMember = "Codigo";
            cboMasivo.DisplayMember = "Descripcion";
        }
        #endregion

        private void t_msg_Tick(object sender, EventArgs e)
        {
            lbl_msg.Text = string.Empty;
            ss_load.BackColor = Color.Transparent;
            lbl_contador_registros.Visible = true;
            lbl_msg.Visible = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnAsistencia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAsistencia.Checked)
            {
                lblTitulo.Text = "CONSIDERAR ASISTENCIA";
                gbAsistencia.BackColor = Color.White;
                gbHolgura.BackColor = SystemColors.Control;
                gbCerrada.BackColor = SystemColors.Control;
                gbMasivo.BackColor = SystemColors.Control;
                gbAsistencia.Enabled = true;
                gbHolgura.Enabled = false;
                gbCerrada.Enabled = false; 
                gbMasivo.Enabled = false;
                reiniciar_controles_configuracion();
                dgvConfiguracion.DataSource = Negocio.listar_validacion_usuario("asistencia");
                util.FormatearGrilla(dgvConfiguracion, true);
                dgvConfiguracion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }
        
        private void rbtnHolgura_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHolgura.Checked)
            {
                lblTitulo.Text = "DÍAS DE HOLGURA";
                gbAsistencia.BackColor = SystemColors.Control;
                gbHolgura.BackColor = Color.White;
                gbCerrada.BackColor = SystemColors.Control;
                gbMasivo.BackColor = SystemColors.Control;
                gbAsistencia.Enabled = false;
                gbHolgura.Enabled = true;
                gbCerrada.Enabled = false;
                gbMasivo.Enabled = false;
                reiniciar_controles_configuracion();
                dgvConfiguracion.DataSource = Negocio.listar_validacion_usuario("holgura");
                util.FormatearGrilla(dgvConfiguracion, true);
                dgvConfiguracion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void rbtnCerrada_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCerrada.Checked)
            {
                lblTitulo.Text = "SEMANA CERRADA";
                gbAsistencia.BackColor = SystemColors.Control;
                gbHolgura.BackColor = SystemColors.Control;
                gbCerrada.BackColor = Color.White;
                gbMasivo.BackColor = SystemColors.Control;
                gbAsistencia.Enabled = false;
                gbHolgura.Enabled = false;
                gbCerrada.Enabled = true;
                gbMasivo.Enabled = false;
                reiniciar_controles_configuracion();
                dgvConfiguracion.DataSource = Negocio.listar_validacion_usuario("cerrada");
                util.FormatearGrilla(dgvConfiguracion, true);
                dgvConfiguracion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void rbtnMasivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMasivo.Checked)
            {
                lblTitulo.Text = "REGISTRO MASIVO";
                gbAsistencia.BackColor = SystemColors.Control;
                gbHolgura.BackColor = SystemColors.Control;
                gbCerrada.BackColor = SystemColors.Control;
                gbMasivo.BackColor = Color.White;
                gbAsistencia.Enabled = false;
                gbHolgura.Enabled = false;
                gbCerrada.Enabled = false;
                gbMasivo.Enabled = true;
                reiniciar_controles_configuracion();
                dgvConfiguracion.DataSource = Negocio.listar_validacion_usuario("masivo");
                util.FormatearGrilla(dgvConfiguracion, true);
                dgvConfiguracion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void reiniciar_controles_configuracion()
        {
            txtUsuario.Text = "";
            txtUsuarioHolgura.Text = "";
            txtUsuarioMasivo.Text = "";
            txtNombre.Text = "";
            txtNombreHolgura.Text = "";
            txtNombreMasivo.Text = "";
            cboAsistencia.SelectedIndex = 0;
            numHolgura.Value = 1;
            cboMasivo.SelectedIndex = 0;
        }


        private void cboAnio_conf_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboAnio_conf_Enter(object sender, EventArgs e)
        {
            cboAnio_conf.BackColor = Color.FromArgb(254, 240, 158);
        }


        private void cboAnio_conf_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_combo_semana_conf(cboAnio_conf.SelectedValue.ToString());
        }

        private void cboAnio_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboSemana_conf_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboSemana_conf_Enter(object sender, EventArgs e)
        {
            cboAnio_conf.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboSemana_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboTareador_ctrl_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboPersonal_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboNivelAcceso_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboAsistencia_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboTareador_ctrl_Enter_1(object sender, EventArgs e)
        {
            cboTareador_ctrl.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboPersonal_Enter(object sender, EventArgs e)
        {
            cboPersonal.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboNivelAcceso_Enter(object sender, EventArgs e)
        {
            cboNivelAcceso.BackColor = Color.FromArgb(254, 240, 158);
            valorPrevio = cboNivelAcceso.SelectedValue.ToString();
        }

        private void btnReabrir_Click(object sender, EventArgs e)
        {
            try
            {
                string tareador = Convert.ToString(AccesoLogica.obtener_user(cboTareador_ctrl.SelectedValue.ToString()).Rows[0][0]);
                string estTareo = Convert.ToString(AccesoLogica.obtener_estTareo(cboAnio_conf.SelectedValue.ToString(), cboSemana_conf.SelectedValue.ToString(), tareador).Rows[0][0]);

                if (estTareo == "1" || estTareo == "2")
                {
                    DialogResult resul = MessageBox.Show("¿Está seguro que quiere reabrir este tareo?", "Reabrir Tareo", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        AccesoLogica.revisar_tareo(cboAnio_conf.SelectedValue.ToString(), cboSemana_conf.SelectedValue.ToString(), tareador, "0", usuario);
                        util.mensaje("El tareo se pasó a estado EN PROCESO", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    }
                }
                else
                {
                    util.mensaje("El tareo ya se encuentra EN PROCESO ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                }
            }
            catch (Exception ex)
            {
                util.mensaje("error: " + ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
            }
        }

        private void btnRevisar_Click(object sender, EventArgs e)
        {
            string tareador = Convert.ToString(AccesoLogica.obtener_user(cboTareador_ctrl.SelectedValue.ToString()).Rows[0][0]);
            string estTareo;

            try
            {
                estTareo = Convert.ToString(AccesoLogica.obtener_estTareo(cboAnio_conf.SelectedValue.ToString(), cboSemana_conf.SelectedValue.ToString(), tareador).Rows[0][0]);
            }
            catch (Exception)
            {
                util.mensaje("Error en la operación", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }

            if (estTareo == "0")
            {
                DialogResult resul = MessageBox.Show("¿Está seguro que quiere realizar la revisión de este tareo?", "Revisar Tareo", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    AccesoLogica.revisar_tareo(cboAnio_conf.SelectedValue.ToString(), cboSemana_conf.SelectedValue.ToString(), tareador, "1", l_usuario.Text);
                    util.mensaje("La revisión se realizó con éxito", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                }
                else
                {
                    return;
                }
            }
            else
            {
                util.mensaje("Solo se puede efectuar la revisión si el tareo esta en proceso ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
            }
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            string tareador;
            string estTareo;
            
            try
            {
                tareador = Convert.ToString(AccesoLogica.obtener_user(cboTareador_ctrl.SelectedValue.ToString()).Rows[0][0]);
                estTareo = Convert.ToString(AccesoLogica.obtener_estTareo(cboAnio_conf.SelectedValue.ToString(), cboSemana_conf.SelectedValue.ToString(), tareador).Rows[0][0]);
            }
            catch (Exception)
            {
                util.mensaje("Error en la operación", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }

            if (estTareo == "1")
            {
                DialogResult resul = MessageBox.Show("¿Está seguro que quiere aprobar este tareo?", "Aprobar Tareo", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    AccesoLogica.revisar_tareo(cboAnio_conf.SelectedValue.ToString(), cboSemana_conf.SelectedValue.ToString(), tareador, "2", usuario);
                    util.mensaje("Se realizó la aprobación de manera exitosa", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                }
            }
            else
            {
                if (estTareo == "0")
                    util.mensaje("No se puede aprobar si no tiene REVISIÓN ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                if (estTareo == "2")
                    util.mensaje("El tareo ya se encuentra en estado APROBADO ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
            }
        }

        private void cboPersonal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string pass = Convert.ToString(Convert.ToInt32(AccesoLogica.verificar_acceso(cboPersonal.SelectedValue.ToString()).Rows[0][0]));
                cboNivelAcceso.SelectedValue = pass;
                chkNivelAcceso.Enabled = true;
            }
            catch (Exception)
            {
                util.mensaje("Error, Verificar estado SWT_TAREO del trabajado en STARSOFT", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                chkNivelAcceso.Enabled = false;
                return;
            }

        }

        private void chkNivelAcceso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNivelAcceso.Checked == true)
            {
                cboNivelAcceso.Enabled = true;
            }
            else
            {
                cboNivelAcceso.Enabled = false;
            }
        }

        private void cboNivelAcceso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                int val = AccesoLogica.actualizar_nivel_acceso(cboPersonal.SelectedValue.ToString(), cboNivelAcceso.SelectedValue.ToString());
                if (cboNivelAcceso.SelectedValue.ToString() == "1" && valorPrevio!="1")
                {
                    int val1 = Negocio.insertar_validaciones_tareador(cboPersonal.SelectedValue.ToString(),"ins");
                }
                if (cboNivelAcceso.SelectedValue.ToString() != "1" && valorPrevio=="1")
                {
                    int val1 = Negocio.insertar_validaciones_tareador(cboPersonal.SelectedValue.ToString(), "del");
                }
            }
            catch (Exception)
            {
                util.mensaje("Error, Verificar dni del trabajado en STARSOFT", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
            cboNivelAcceso.Enabled = false;
            chkNivelAcceso.Checked= false;
        }
        
        private void dgvConfiguracion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (rbtnAsistencia.Checked)
                {
                    txtUsuario.Text = dgvConfiguracion.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtNombre.Text = dgvConfiguracion.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cboAsistencia.SelectedValue = dgvConfiguracion.Rows[e.RowIndex].Cells[2].Value.ToString() == "Si" ? 'S' : 'N';
                }

                if (rbtnHolgura.Checked)
                {
                    txtUsuarioHolgura.Text = dgvConfiguracion.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtNombreHolgura.Text = dgvConfiguracion.Rows[e.RowIndex].Cells[1].Value.ToString();
                    numHolgura.Value = Convert.ToDecimal(dgvConfiguracion.Rows[e.RowIndex].Cells[2].Value.ToString());
                }

                if (rbtnCerrada.Checked)
                {
                    cboAnioCerrada.SelectedValue = dgvConfiguracion.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cargar_combo_semana_cerrada(cboAnioCerrada.SelectedValue.ToString());
                    cboSemanaCerrada.SelectedValue = dgvConfiguracion.Rows[e.RowIndex].Cells[1].Value.ToString();
                }

                if (rbtnMasivo.Checked)
                {
                    txtUsuarioMasivo.Text = dgvConfiguracion.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtNombreMasivo.Text = dgvConfiguracion.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cboMasivo.SelectedValue = dgvConfiguracion.Rows[e.RowIndex].Cells[2].Value.ToString() == "Si" ? 'S' : 'N';
                }
            }
        }

        private void btnGrabarAsistencia_Click(object sender, EventArgs e)
        {
            try
            {
                int val = AccesoLogica.actualizar_configuracion(txtUsuario.Text, "asistencia", cboAsistencia.SelectedValue.ToString());
                dgvConfiguracion.DataSource = Negocio.listar_validacion_usuario("asistencia");
            }
            catch (Exception)
            {
                util.mensaje("Error", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
        }

        private void btnGrabarHolgura_Click(object sender, EventArgs e)
        {
            try
            {
                int val = AccesoLogica.actualizar_configuracion(txtUsuarioHolgura.Text, "holgura", numHolgura.Value.ToString());
                dgvConfiguracion.DataSource = Negocio.listar_validacion_usuario("holgura");
                util.FormatearGrilla(dgvConfiguracion, true);
            }
            catch (Exception)
            {
                util.mensaje("Error", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
        }

        private void btnGrabarCerrada_Click(object sender, EventArgs e)
        {
            try
            {
                int val = AccesoLogica.actualizar_configuracion(cboAnioCerrada.SelectedValue.ToString() , "cerrada_add", cboSemanaCerrada.SelectedValue.ToString());
                dgvConfiguracion.DataSource = Negocio.listar_validacion_usuario("cerrada");
                util.FormatearGrilla(dgvConfiguracion, true);
            }
            catch (Exception)
            {
                util.mensaje("Error", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
        }

        private void btnGrabarMasivo_Click(object sender, EventArgs e)
        {
            try
            {
                int val = AccesoLogica.actualizar_configuracion(txtUsuarioMasivo.Text, "masivo", cboMasivo.SelectedValue.ToString());
                dgvConfiguracion.DataSource = Negocio.listar_validacion_usuario("masivo");
                util.FormatearGrilla(dgvConfiguracion, true);
            }
            catch (Exception)
            {
                util.mensaje("Error", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
        }

        private void btnTodosAsistencia_Click(object sender, EventArgs e)
        {
            try
            {
                int val = AccesoLogica.actualizar_configuracion_todos("asistencia", cboAsistencia.SelectedValue.ToString());
                dgvConfiguracion.DataSource = Negocio.listar_validacion_usuario("asistencia");
                util.FormatearGrilla(dgvConfiguracion, true);
            }
            catch (Exception)
            {
                util.mensaje("Error", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
        }

        private void btnTodosHolgura_Click(object sender, EventArgs e)
        {
            try
            {
                int val = AccesoLogica.actualizar_configuracion_todos("holgura", numHolgura.Value.ToString());
                dgvConfiguracion.DataSource = Negocio.listar_validacion_usuario("holgura");
                util.FormatearGrilla(dgvConfiguracion, true);
            }
            catch (Exception)
            {
                util.mensaje("Error", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
        }

        private void btnTodosCerrada_Click(object sender, EventArgs e)
        {
            try
            {
                int val = AccesoLogica.actualizar_configuracion(cboAnioCerrada.SelectedValue.ToString(), "cerrada_del", cboSemanaCerrada.SelectedValue.ToString());
                dgvConfiguracion.DataSource = Negocio.listar_validacion_usuario("cerrada");
                util.FormatearGrilla(dgvConfiguracion, true);
            }
            catch (Exception)
            {
                util.mensaje("Error", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
        }

        private void btnTodosMasivo_Click(object sender, EventArgs e)
        {
            try
            {
                int val = AccesoLogica.actualizar_configuracion_todos("masivo", cboMasivo.SelectedValue.ToString());
                dgvConfiguracion.DataSource = Negocio.listar_validacion_usuario("masivo");
                util.FormatearGrilla(dgvConfiguracion, true);
            }
            catch (Exception)
            {
                util.mensaje("Error", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
        }

        private void btnValoresXDefecto_Click(object sender, EventArgs e)
        {
            cargar_configuracion_horas_defecto();
        }

        private void cargar_configuracion_horas_defecto()
        {
            DataTable dtHoras = Negocio.listar_configuracion_horas_defecto();
            txtHN_normal.Text = dtHoras.Rows[0][0].ToString();
            txtHE_normal.Text = dtHoras.Rows[0][1].ToString();
            txtHT_normal.Text = dtHoras.Rows[0][2].ToString();
            txtHNsem_normal.Text = dtHoras.Rows[0][3].ToString();
            txtHEsem_normal.Text = dtHoras.Rows[0][4].ToString();
            txtHNsemad_normal.Text = dtHoras.Rows[0][5].ToString();
            txtHEsemAdd_normal.Text = dtHoras.Rows[0][6].ToString();
            txtHN_feriado.Text = dtHoras.Rows[0][7].ToString();
            txtHE_feriado.Text = dtHoras.Rows[0][8].ToString();
            txtHT_feriado.Text = dtHoras.Rows[0][9].ToString();
            txtHNsem_feriado.Text = dtHoras.Rows[0][10].ToString();
            txtHEsem_feriado.Text = dtHoras.Rows[0][11].ToString();
            txtHNsemAdd_feriado.Text = dtHoras.Rows[0][12].ToString();
            txtHEsemAdd_feriado.Text = dtHoras.Rows[0][13].ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int val = AccesoLogica.actualizar_configuracion_horas(  txtHN_normal.Text==""?"0":txtHN_normal.Text,                txtHE_normal.Text==""?"0":txtHE_normal.Text,                txtHT_normal.Text==""?"0":txtHT_normal.Text,  
                                                                        txtHNsem_normal.Text==""?"0":txtHNsem_normal.Text,          txtHEsem_normal.Text==""?"0":txtHEsem_normal.Text,          txtHNsemad_normal.Text==""?"0":txtHNsemad_normal.Text,     
                                                                        txtHEsemAdd_normal.Text==""?"0":txtHEsemAdd_normal.Text,    txtHN_feriado.Text==""?"0":txtHN_feriado.Text,              txtHE_feriado.Text==""?"0":txtHE_feriado.Text, 
                                                                        txtHT_feriado.Text==""?"0":txtHT_feriado.Text,              txtHNsem_feriado.Text==""?"0":txtHNsem_feriado.Text,        txtHEsem_feriado.Text==""?"0":txtHEsem_feriado.Text,  
                                                                        txtHNsemAdd_feriado.Text==""?"0":txtHNsemAdd_feriado.Text,  txtHEsemAdd_feriado.Text==""?"0":txtHEsemAdd_feriado.Text);                
            }
            catch (Exception)
            {
                util.mensaje("Error al actualizar configuración de Horas", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
        }

        private void txtHN_normal_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validar_numeros(txtHN_normal, e);
        }

        private void txtHE_normal_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validar_numeros(txtHE_normal, e);
        }

        private void txtHT_normal_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validar_numeros(txtHT_normal, e);
        }

        private void txtHNsem_normal_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validar_numeros(txtHNsem_normal, e);
        }

        private void txtHEsem_normal_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validar_numeros(txtHEsem_normal, e);
        }

        private void txtHNsemad_normal_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validar_numeros(txtHNsemad_normal, e);
        }

        private void txtHEsemAdd_normal_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validar_numeros(txtHEsemAdd_normal, e);
        }

        private void txtHN_feriado_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validar_numeros(txtHN_feriado, e);
        }

        private void txtHE_feriado_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validar_numeros(txtHE_feriado, e);
        }

        private void txtHT_feriado_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validar_numeros(txtHT_feriado, e);
        }

        private void txtHNsem_feriado_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validar_numeros(txtHNsem_feriado, e);
        }

        private void txtHEsem_feriado_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validar_numeros(txtHEsem_feriado, e);
        }

        private void txtHNsemAdd_feriado_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validar_numeros(txtHNsemAdd_feriado, e);
        }

        private void txtHEsemAdd_feriado_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validar_numeros(txtHEsemAdd_feriado, e);
        }

        private void cboAnioCerrada_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_combo_semana_cerrada(cboAnioCerrada.SelectedValue.ToString());
        }

        private void cboAnioCerrada_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboAnioCerrada_Enter(object sender, EventArgs e)
        {
            cboAnioCerrada.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboSemanaCerrada_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboSemanaCerrada_Enter(object sender, EventArgs e)
        {
            cboAnioCerrada.BackColor = Color.FromArgb(254, 240, 158);
        }
    }
}
