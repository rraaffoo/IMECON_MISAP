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
    public partial class FrmTareo_IngresoMasivo : Form
    {

        #region Variables globales

        public string usuario, perfil;
        public string dni;
        public string vAnio;
        public string vSemana;
        public string vfecha;
        public string vfechaIni;
        public string vfechaFin;
        public string vTurno;
        public string vTipo;
        public string vFalta;
        public string vOt;
        public string vEdt;
        public string vActividad;
        public string vProc;
        public string vAct2;
        public string vHn;
        public string vHe;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        #endregion

        #region Variables locales


        DataTable dtMSV = new DataTable();
        private Point pos = Point.Empty;
        private bool move = false;
        bool allowSelect = false;

        string horasE_trabajadas, horasE_semanales;
        double suma_horasE_trabajadas, suma_horasE_semanales;
        double maxHeDia = 0, maxHeSem = 0, maxHnDia = 0, maxHnSem = 0, maxHtDia;
        string horas_trabajadas, horas_semanales;

        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();
        string filtro, cod_ot;
        int contador;
        double suma_horas_trabajadas, suma_horas_extras, suma_horas_semanales, suma_extras_semanales;
               

        #endregion
        
        #region Formulario

        public FrmTareo_IngresoMasivo()
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

        private void FrmTareo_IngresoMasivo_Load(object sender, EventArgs e)
        {
            l_dni.Text = dni;
            l_usuario.Text = usuario;
            cargar_combo_anio();        // cargar combo año         
            try
            {
                cargar_combo_semana(cboAnio_msv.SelectedValue.ToString());      // cargar combo semana        
                //seleccion_semana_actual();  // asignar semana actual
                cargar_fechas(cboAnio_msv.SelectedValue.ToString(), cboSemana_msv.SelectedValue.ToString()); // cargar fechas de inicio y fin
            }
            catch (Exception)
            {
            }
            if (Negocio.verificar_autorizacion("7091", "2").Rows[0][4].ToString() == "S")
                dtpFecha_msv.Enabled = false;
            else
                dtpFecha_msv.Enabled = true;
            cargar_combo_tipo();            // cargar tipo
            maximos_horas_permitidas();
            cargar_combo_turno();    // cargar turno        
            cargar_combo_falta();      // cargar falta      
            cargar_combo_ot();     // cargar ot   
            cargar_combo_actividad();   // cargar actividad
            separar_actividad();
            cargar_grilla_ingmasivo(l_dni.Text, dtpFecha_msv.Value.ToShortDateString());
            actualizar_combos();

            dtMSV.Columns.Add("Codigo");
            dtMSV.Columns.Add("Descripcion");
            
        }

        private void actualizar_combos()
        {
            cboAnio_msv.SelectedValue = vAnio;
            cargar_combo_semana(cboAnio_msv.SelectedValue.ToString());
            cboSemana_msv.SelectedValue = vSemana;
            cargar_fechas(cboAnio_msv.SelectedValue.ToString(), cboSemana_msv.SelectedValue.ToString());
            dtpFecha_msv.Value = Convert.ToDateTime(vfecha);
            cboTurno_msv.SelectedValue = vTurno;
            cboTipo_msv.SelectedValue = vTipo;
            cboFalta_msv.SelectedValue = vFalta;
            cboOt_msv.SelectedValue = vOt;
            cargar_combo_edt(cboOt_msv.SelectedValue.ToString());
            cboEdt_msv.SelectedValue = vEdt;
            cboActividad_msv.SelectedValue = vActividad;
            txtHn.Text = vHn;
            txtHe.Text = vHe;
        }

        #region carga_combos
        private void cargar_combo_actividad()
        {
            cboActividad_msv.DataSource = AccesoLogica.listar_combo_actividad();
            cboActividad_msv.ValueMember = "codigo";
            cboActividad_msv.DisplayMember = "descripcion";
        }

        private void cargar_combo_edt(string ot)
        {
            cboEdt_msv.DataSource = AccesoLogica.listar_combo_edt(ot);
            cboEdt_msv.ValueMember = "codigo";
            cboEdt_msv.DisplayMember = "descripcion";
        }

        private void cargar_combo_ot()
        {
            cboOt_msv.DataSource = AccesoLogica.listar_combo_ot();
            cboOt_msv.ValueMember = "codigo";
            cboOt_msv.DisplayMember = "descripcion";
        }

        private void cargar_combo_falta()
        {
            cboFalta_msv.DataSource = AccesoLogica.listar_combo_falta();
            cboFalta_msv.ValueMember = "codigo";
            cboFalta_msv.DisplayMember = "descripcion";
        }

        private void cargar_combo_turno()
        {
            cboTurno_msv.DataSource = AccesoLogica.listar_combo_turno();
            cboTurno_msv.ValueMember = "codigo";
            cboTurno_msv.DisplayMember = "descripcion";
        }

        private void cargar_fechas(string anio, string semana)
        {
            DataTable dt = new DataTable();
            dt = AccesoLogica.listar_fechas_inifin(anio, semana);

            string fechaIni = dt.Rows[0]["fechaini"].ToString();
            string fechaFin = dt.Rows[0]["fechafin"].ToString();
            dtpFecha_msv.MinDate = System.DateTime.Now.AddYears(-5);
            dtpFecha_msv.MaxDate = System.DateTime.Now.AddYears(5);
            dtpFecha_msv.Value = Convert.ToDateTime(fechaIni);
            dtpFecha_msv.MinDate = Convert.ToDateTime(fechaIni);
            dtpFecha_msv.MaxDate = Convert.ToDateTime(fechaFin);

            txtFechaIni_msv.Text = fechaIni;
            txtFechaFin_msv.Text = fechaFin;
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
            cboAnio_msv.DataSource = dt;
            cboAnio_msv.ValueMember = "Codigo";
            cboAnio_msv.DisplayMember = "Descripcion";
            cboAnio_msv.SelectedIndex = 3;
        }

        private void cargar_combo_semana(string anio)
        {
            cboSemana_msv.DataSource = AccesoLogica.listar_semanas_anio(anio);
            cboSemana_msv.ValueMember = "codigo";
            cboSemana_msv.DisplayMember = "descripcion";
        }

        private void cargar_combo_tipo()
        {
            cboTipo_msv.DataSource = AccesoLogica.listar_combo_tipo();
            cboTipo_msv.ValueMember = "codigo";
            cboTipo_msv.DisplayMember = "descripcion";
        }
        #endregion

        private void separar_actividad()
        {
            string cadena = cboActividad_msv.SelectedValue.ToString();
            string[] datos;
            datos = cadena.Split('|');
            txtproc.Text = datos[0].ToString();
            txtact.Text = datos[1].ToString();
        }

        private void maximos_horas_permitidas()
        {
            if (cboTipo_msv.SelectedValue.ToString() == "00" || cboTipo_msv.SelectedValue.ToString() == "03") //dia normal o dia bajada
            {
                maxHnDia = 8.5;
                maxHnSem = 48;
                maxHeDia = 6.5;
                maxHeSem = 25;
                maxHtDia = 15;
            }
            if (cboTipo_msv.SelectedValue.ToString() == "01" || cboTipo_msv.SelectedValue.ToString() == "02") //dia descanso o feriado
            {
                maxHnDia = 0;
                maxHnSem = 48;
                maxHeDia = 10;
                maxHeSem = 25;
                maxHtDia = 10;
            }
        }

        private void cargar_grilla_ingmasivo(string _dni, string _fecha)
        {
            dgvPerAsignado.DataSource = Negocio.cargar_grilla_ingmasivo(_dni, _fecha);
            formatear_grilla(dgvPerAsignado);
        }
        
        private void t_msg_Tick(object sender, EventArgs e)
        {
            lbl_msg.Text = string.Empty;
            ss_load.BackColor = Color.Transparent;
            lbl_contador_registros.Visible = true;
            lbl_msg.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cboOt_msv.SelectedValue.ToString() == "00000")
            {
                util.mensaje("Debe seleccionar una OT para ralizar esta operación", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }

            string mensajeError = "";
            vAnio = cboAnio_msv.SelectedValue.ToString();
            vSemana = cboSemana_msv.SelectedValue.ToString();
            vfecha = dtpFecha_msv.Value.ToShortDateString();
            vfechaIni = txtFechaIni_msv.Text;
            vfechaFin = txtFechaFin_msv.Text;
            vTurno = cboTurno_msv.SelectedValue.ToString();
            vTipo = cboTipo_msv.SelectedValue.ToString();
            vFalta = cboFalta_msv.SelectedValue.ToString();
            vOt = cboOt_msv.SelectedValue.ToString();
            try
            {
                vEdt = cboEdt_msv.SelectedValue.ToString();
            }
            catch (Exception)
            {
                vEdt = "";
            }
            vActividad = cboActividad_msv.SelectedValue.ToString();
            vProc = txtproc.Text;
            vAct2 = txtact.Text;
            vHn = txtHn.Text;
            vHe = txtHe.Text;

            
            DataRow dr;

            if (dgvPerAsignado.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvPerAsignado.Rows)
                {
                    if (row.Selected == true)
                    {
                        dr = dtMSV.NewRow();
                        dr["Codigo"] = row.Cells["codigo"].Value.ToString();
                        dr["Descripcion"] = row.Cells["descripcion"].Value.ToString();
                        dtMSV.Rows.Add(dr);
                    }
                }
            }
            else
            {
                util.mensaje("No se seleccionó ningún registro", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }

            foreach (DataRow item in dtMSV.Rows)
            {
                if (vOt.Substring(0, 3) == "OTF" || vOt.Substring(0, 3) == "OTM")
                {
                    vOt = string.Concat("20", vOt.Substring(3, 5));
                }
                if (vEdt == null)
                    vEdt = "";
                
                string _cod = item["Codigo"].ToString();
                string _nombre = item["Descripcion"].ToString();
                if (validar_horas_normales(_cod, vHn, vfecha, vfechaIni, vfechaFin) && validar_horas_extra(_cod, vHn, vfecha, vfechaIni, vfechaFin))
                {
                    if (AccesoLogica.grabar_tareo(vfecha, vTurno, _cod, vOt, vEdt, vProc, vAct2, vHn, vHe, vFalta, vTipo, l_usuario.Text, vfechaIni, vfechaFin, vSemana, "") != 0)
                    {
                        //util.mensaje("Registro grabado exitosamente", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    }
                }
                else
                {
                    mensajeError = mensajeError + _cod + "-" + _nombre + ", \n";
                }
                
            }

            if (mensajeError.Length > 0)
                MessageBox.Show("No se pudo cargar información  de: \n"+ mensajeError);
            this.Close();
        }

        private void cboAnio_msv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_combo_semana(cboAnio_msv.SelectedValue.ToString());
            cargar_fechas(cboAnio_msv.SelectedValue.ToString(), cboSemana_msv.SelectedValue.ToString());
        }

        private void cboSemana_msv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_fechas(cboAnio_msv.SelectedValue.ToString(), cboSemana_msv.SelectedValue.ToString());
        }



        private Boolean validar_horas_normales(string dniPersonal, string hn, string fechaMSV, string fechaIniMSV, string fechaFinMSV)
        {
            horas_trabajadas = Convert.ToString(AccesoLogica.validar_horas_semanales(dniPersonal, fechaMSV, fechaIniMSV, fechaFinMSV, l_usuario.Text).Rows[0][0]);
            horas_semanales = Convert.ToString(AccesoLogica.validar_horas_semanales(dniPersonal, fechaMSV, fechaIniMSV, fechaFinMSV, l_usuario.Text).Rows[0][2]);

            suma_horas_trabajadas = float.Parse(horas_trabajadas, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + float.Parse(hn, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"));
            suma_horas_semanales = float.Parse(horas_semanales, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + float.Parse(hn, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"));

            if (Convert.ToDouble(suma_horas_trabajadas) > maxHnDia)
            {
                util.mensaje("La cantidad de horas trabajadas por dia no puede ser mayor a " + maxHnDia + " horas ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txtHn.Text = "0";
                txtHn.SelectionStart = 0;
                txtHn.SelectionLength = txtHn.Text.Length;
                return false;
            }

            if (Convert.ToDouble(suma_horas_semanales) > maxHnSem)
            {
                util.mensaje("La cantidad de horas trabajadas semanales no puede ser mayor a " + maxHnSem + " horas ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txtHn.Text = "0";
                txtHn.SelectionStart = 0;
                txtHn.SelectionLength = txtHn.Text.Length;
                return false;
            }
            if (float.Parse(txtHn.Text == string.Empty ? "0" : txtHn.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + float.Parse(txtHe.Text == string.Empty ? "0" : txtHe.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) > maxHtDia)
            {
                util.mensaje("La cantidad de horas totales diaria no puede ser mayor a " + maxHtDia + " horas ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txtHn.Text = "0";
                txtHn.SelectionStart = 0;
                txtHn.SelectionLength = txtHn.Text.Length;
                return false;
            }
            return true;
        }

        private Boolean validar_horas_extra(string dniPersonal, string he, string fechaMSV, string fechaIniMSV, string fechaFinMSV)
        {
            horasE_trabajadas = Convert.ToString(AccesoLogica.validar_horas_semanales(dniPersonal, fechaMSV, fechaIniMSV, fechaFinMSV, l_usuario.Text).Rows[0][1]);
            horasE_semanales = Convert.ToString(AccesoLogica.validar_horas_semanales(dniPersonal, fechaMSV, fechaIniMSV, fechaFinMSV, l_usuario.Text).Rows[0][3]);

            suma_horasE_trabajadas = float.Parse(horasE_trabajadas, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + float.Parse(he, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"));
            suma_horasE_semanales = float.Parse(horasE_semanales, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + float.Parse(he, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"));

            if (Convert.ToDouble(suma_horasE_trabajadas) > maxHeDia)
            {
                util.mensaje("no puede ingresar horas extra mayor a " + maxHeDia, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txtHe.Text = "0";
                txtHe.SelectionStart = 0;
                txtHe.SelectionLength = txtHn.Text.Length;
                //btnAgregar_reg.Enabled = false;
                return false;
            }

            if (Convert.ToDouble(suma_horasE_semanales) > maxHeSem)
            {
                util.mensaje("La cantidad de horas extra semanales no puede ser mayor a " + maxHeSem + "horas ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txtHe.Text = "0";
                txtHe.SelectionStart = 0;
                txtHe.SelectionLength = txtHn.Text.Length;
                return false;
            }


            if (float.Parse(txtHn.Text == string.Empty ? "0" : txtHn.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + float.Parse(txtHe.Text == string.Empty ? "0" : txtHe.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) > maxHtDia)
            {
                util.mensaje("La cantidad de horas totales por día no puede ser mayor a " + maxHtDia + " horas ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txtHe.Text = "0";
                txtHe.SelectionStart = 0;
                txtHe.SelectionLength = txtHn.Text.Length;
                return false;
            }
            return true;
        }

        private void txtHn_TextChanged(object sender, EventArgs e)
        {
            if (cboTipo_msv.SelectedValue.ToString() == "00000")
            {
                util.mensaje("Debe seleccionar un Tipo de día para realizar esta operación", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txtHn.Text = "0";
                return;
            }


            if (txtHn.Text.Length == 1)
            {
                if (txtHn.Text == ".")
                {
                    txtHn.Text = "0.";
                    txtHn.Select(txtHn.Text.Length, 0);
                }
            }
            if (txtHn.Text != string.Empty)
            {
                try
                {
                    if (float.Parse(txtHn.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) > maxHnDia)
                    {
                        util.mensaje("No puede ingresar mas de " + maxHnDia + " horas", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                        txtHn.Text = "0";
                        txtHn.SelectionStart = 0;
                        txtHn.SelectionLength = txtHn.Text.Length;
                        return;
                    }                    
                }

                catch (Exception)
                {
                    txtHn.Text = "0";
                    txtHe.Text = "0";
                    util.mensaje("Error", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    throw;
                }
            }
        }

        private void cboActividad_msv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            separar_actividad();
        }

        private void cboTipo_msv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtHn.Text = "0";
            //txtHe.Text = "0";
            maximos_horas_permitidas();
        }

        private void txtHe_TextChanged(object sender, EventArgs e)
        {
            if (cboTipo_msv.SelectedValue.ToString() == "00000")
            {
                util.mensaje("Debe seleccionar un Tipo de día para realizar esta operación", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txtHe.Text = "0";
                return;
            }


            if (txtHe.Text.Length == 1)
            {
                if (txtHe.Text == ".")
                {
                    txtHe.Text = "0.";
                    txtHe.Select(txtHe.Text.Length, 0);
                }
            }
            if (txtHe.Text != string.Empty)
            {
                try
                {
                    if (float.Parse(txtHe.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) > maxHeDia)
                    {
                        util.mensaje("No puede ingresar mas de " + maxHeDia + " horas", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                        txtHe.SelectionStart = 0;
                        txtHe.SelectionLength = txtHn.Text.Length;
                        return;
                    }
                }

                catch (Exception)
                {
                    //txtHn.Text = "0";
                    txtHe.Text = "0";
                    util.mensaje("Error", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    throw;
                }
            }
        }

        private void cboOt_msv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_combo_edt(cboOt_msv.SelectedValue.ToString());
            cboEdt_msv.SelectedItem = null;
            cboEdt_msv.Enabled = true;
            cboEdt_msv.Focus();
        }

        private void txtHn_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validar_numeros(txtHn, e);
            if (e.KeyChar == 13)
            {
                txtHe.Focus();
            }
        }

        #region diseno_combos
        private void cboAnio_msv_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboAnio_msv_Enter(object sender, EventArgs e)
        {
            cboAnio_msv.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboAnio_msv_Leave(object sender, EventArgs e)
        {
            cboAnio_msv.BackColor = Color.White;
        }

        private void cboSemana_msv_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboSemana_msv_Enter(object sender, EventArgs e)
        {
            cboSemana_msv.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboSemana_msv_Leave(object sender, EventArgs e)
        {
            cboSemana_msv.BackColor = Color.White;
        }

        private void cboTurno_msv_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboTurno_msv_Enter(object sender, EventArgs e)
        {
            cboTurno_msv.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboTurno_msv_Leave(object sender, EventArgs e)
        {
            cboTurno_msv.BackColor = Color.White;
        }

        private void cboTipo_msv_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboTipo_msv_Enter(object sender, EventArgs e)
        {
            cboTipo_msv.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboTipo_msv_Leave(object sender, EventArgs e)
        {
            cboTipo_msv.BackColor = Color.White;
        }

        private void cboFalta_msv_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboFalta_msv_Enter(object sender, EventArgs e)
        {
            cboFalta_msv.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboFalta_msv_Leave(object sender, EventArgs e)
        {
            cboFalta_msv.BackColor = Color.White;
        }

        private void cboOt_msv_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboOt_msv_Enter(object sender, EventArgs e)
        {
            cboOt_msv.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboOt_msv_Leave(object sender, EventArgs e)
        {
            cboOt_msv.BackColor = Color.White;
        }

        private void cboEdt_msv_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboEdt_msv_Enter(object sender, EventArgs e)
        {
            cboEdt_msv.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboEdt_msv_Leave(object sender, EventArgs e)
        {
            cboEdt_msv.BackColor = Color.White;
        }

        private void cboActividad_msv_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboActividad_msv_Enter(object sender, EventArgs e)
        {
            cboActividad_msv.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboActividad_msv_Leave(object sender, EventArgs e)
        {
            cboActividad_msv.BackColor = Color.White;
        }
        #endregion

        private void dtpFecha_msv_ValueChanged(object sender, EventArgs e)
        {
            cargar_grilla_ingmasivo(l_dni.Text, dtpFecha_msv.Value.ToShortDateString());
        }

    }
}
