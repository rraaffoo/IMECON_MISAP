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
    public partial class FrmTareoControl : Form
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
        DataTable dtRegistros = new DataTable();

        private Point pos = Point.Empty;
          
        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();
      
        #endregion
        
        #region Formulario

        public FrmTareoControl()
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

        private void cargar_combo_tareadores()
        {
            //cboTareador_ctrl.DataSource = AccesoLogica.listar_combo_tareadores();
            //cboTareador_ctrl.ValueMember = "codigo";
            //cboTareador_ctrl.DisplayMember = "descripcion";

            DataTable dt = new DataTable();
            dt = AccesoLogica.listar_combo_tareadores();
            DataRow dr;
            dr = dt.NewRow();

            dr["Codigo"] = "00000000";
            dr["Descripcion"] = "__Todos__";
            dt.Rows.InsertAt(dr, 0); // .Add(dr);
            cboTareador_ctrl.DataSource = dt;
            cboTareador_ctrl.ValueMember = "codigo";
            cboTareador_ctrl.DisplayMember = "descripcion";
            cboTareador_ctrl.SelectedIndex = 0;
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

            cboAnio_ctrl.DataSource = dt;
            cboAnio_ctrl.ValueMember = "Codigo";
            cboAnio_ctrl.DisplayMember = "Descripcion";
            cboAnio_ctrl.SelectedIndex = 3;

        }

        private void cargar_combo_semana(string anio)
        {
            cboSemana_ctrl.DataSource = AccesoLogica.listar_semanas_anio(anio);
            cboSemana_ctrl.ValueMember = "codigo";
            cboSemana_ctrl.DisplayMember = "descripcion";
        }

        private void cargar_fechas_ctrl(string anio, string semana)
        {
            DataTable dt = new DataTable();
            dt = AccesoLogica.listar_fechas_inifin(anio, semana);
            string fechaIni = dt.Rows[0]["fechaini"].ToString();
            string fechaFin = dt.Rows[0]["fechafin"].ToString();
            txtFechaInicio_ctrl.Text = fechaIni;
            txtFechaFin_ctrl.Text = fechaFin;
        }

        private void cargar_combo_ot()
        {
            cboOT_ctrl.DataSource = AccesoLogica.listar_combo_ot();
            cboOT_ctrl.ValueMember = "codigo";
            cboOT_ctrl.DisplayMember = "descripcion";
        }


        #endregion
        
        #region Eventos
       
        private void FrmTareoControl_Load(object sender, EventArgs e)
        {
            util.EstablecerAuditoria("Nuevo", usuario, "", "7093", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            l_usuario.Text = usuario;
            l_dni.Text = Convert.ToString(AccesoLogica.obtener_usuario(l_usuario.Text).Rows[0][4]);
            cargar_combo_tareadores();  // cargar tareador 
            cargar_combo_anio();    // cargar combo año
            try
            {
                cargar_combo_semana(cboAnio_ctrl.SelectedValue.ToString()); // cargar combo semana
                cargar_fechas_ctrl(cboAnio_ctrl.SelectedValue.ToString(), cboSemana_ctrl.SelectedValue.ToString()); // cargar fechas de inicio y fin
            }
            catch (Exception)
            {
            }
            //if (Negocio.verificar_autorizacion("7091", "1").Rows[0][4].ToString() == "S")
            //    chkRegistroAsistencia.Checked = true;
            //else
            //    chkRegistroAsistencia.Checked = false;
            //if (Negocio.verificar_autorizacion("7091", "2").Rows[0][4].ToString() == "S")
            //    chkRegistroDiaActual.Checked = true;
            //else
            //    chkRegistroDiaActual.Checked = false;
           

            // cargar ot
            cargar_combo_ot();
            rbtnTodos.Checked = true;
        }
        
        #endregion

        private void btnAprobar_Ctrl_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(Convert.ToInt32(AccesoLogica.verificar_acceso(l_dni.Text).Rows[0][0])) != "3")
            {
                return;
            }
            if (dgvTareo_ctrl.Rows.Count <= 0)
            {
                util.mensaje("No es posible realizar esta operación", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
            string estTareo = Convert.ToString(AccesoLogica.obtener_estTareo(cboAnio_ctrl.SelectedValue.ToString(), cboSemana_ctrl.SelectedValue.ToString(), usuario).Rows[0][0]);
            string tareador = Convert.ToString(AccesoLogica.obtener_user(cboTareador_ctrl.SelectedValue.ToString()).Rows[0][0]);
            if (estTareo == "1")
            {
                DialogResult resul = MessageBox.Show("¿Está seguro que quiere aprobar este tareo?", "Aprobar Tareo", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    AccesoLogica.revisar_tareo(cboAnio_ctrl.SelectedValue.ToString(), cboSemana_ctrl.SelectedValue.ToString(), tareador, "2", usuario);
                    util.mensaje("Se realizó la aprobación de manera exitosa", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    dgvTareo_ctrl.DataSource = null;
                    dgvTareo_ctrl.DataSource = AccesoLogica.listar_grilla_tareo_ctrl(Convert.ToInt32(cboAnio_ctrl.SelectedValue.ToString()), Convert.ToInt32(cboSemana_ctrl.SelectedValue.ToString()), tareador, 1, "", "");
                    formatear_grilla(dgvTareo_ctrl);
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

        private void btnBuscar_Ctrl_Click(object sender, EventArgs e)
        {
            if (!BW.IsBusy)
            {
                btn_grabar.Enabled = true;
                util.mensaje_espera("Cargando, por favor espere", true, lbl_contador_registros, lbl_msg, ss_load, true);
                dgvTareo_ctrl.DataSource = null;
                txt_buscar.Enabled = false;
                try
                {
                    if (cboTareador_ctrl.SelectedValue.ToString() != "00000000")
                    {
                        tareador = Convert.ToString(AccesoLogica.obtener_user(cboTareador_ctrl.SelectedValue.ToString()).Rows[0][0]);
                    }
                    else
                    {
                        tareador = "todos";
                    }
                    
                }
                catch (Exception)
                {
                    util.mensaje_espera("Usuario no se encuentra o no tiene DNI en tabla OUSR", false, lbl_contador_registros, lbl_msg, ss_load, true);
                    return;
                }
                pfiltro = rbtnTodos.Checked == true ? 1 : 2;
                anio_ctrl = Convert.ToInt32(cboAnio_ctrl.SelectedValue.ToString());
                semna_ctrl = Convert.ToInt32(cboSemana_ctrl.SelectedValue.ToString());
                ot = cboOT_ctrl.SelectedValue.ToString();
                if (ot == "00000")
                {
                    ot = "";
                }
                else
                {
                    if (ot.Substring(0, 3) == "OTF" || ot.Substring(0, 3) == "OTM")
                    {
                        ot = string.Concat("20", ot.Substring(3, 5));
                    }
                }
                BW.RunWorkerAsync();
            } 
        }

        private void BW_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                dtRegistros = AccesoLogica.listar_grilla_tareo_ctrl(anio_ctrl, semna_ctrl, tareador, pfiltro, "", ot);

            }
            catch (Exception)
            {
                //util.mensaje("ocurrió un error en el proceso ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
            }
        }

        private void BW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvTareo_ctrl.DataSource = dtRegistros;
            formatear_grilla(dgvTareo_ctrl);
            mostrar_totales();
            util.mensaje_espera("Cargando, por favor espere", true, lbl_contador_registros, lbl_msg, ss_load, false);
        }

        private void mostrar_totales()
        {
            DataTable dt = dgv_a_dt(dgvTareo_ctrl, false);
            lblTotalHN.Text = dt.Compute("SUM(HN)", "").ToString();
            lblTotalHE.Text = dt.Compute("SUM(HE)", "").ToString();
            IEnumerable<IGrouping<string, DataRow>> query = from item in dt.AsEnumerable()
                                                            group item by item["Nombre"].ToString() into g
                                                            select g;
            DataTable resultado = Transformar(query);
            lblTotalTar.Text = resultado.Rows.Count.ToString();
        }
        private DataTable Transformar(IEnumerable<IGrouping<string, DataRow>> datos)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre");
            
            foreach (IGrouping<string, DataRow> item in datos)
            {
                DataRow row2 = dt.NewRow();
                row2["Nombre"] = item.Key;
                dt.Rows.Add(row2);
            }
            return dt;
        }

        private DataTable dgv_a_dt(DataGridView dgv, bool ignorarHideColumns)
        {
            try
            {
                if (dgv.ColumnCount == 0) return null;
                DataTable dtSource = new DataTable();
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    if (ignorarHideColumns & !col.Visible) continue;
                    if (col.Name == string.Empty) continue;
                    dtSource.Columns.Add(col.Name, col.ValueType);
                    dtSource.Columns[col.Name].Caption = col.HeaderText;
                }
                if (dtSource.Columns.Count == 0) return null;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    DataRow drNewRow = dtSource.NewRow();
                    foreach (DataColumn col in dtSource.Columns)
                    {
                        drNewRow[col.ColumnName] = row.Cells[col.ColumnName].Value;
                    }
                    dtSource.Rows.Add(drNewRow);
                }
                return dtSource;
            }
            catch { return null; }
        }

        //private void btnSubirArch_Ctrl_Click(object sender, EventArgs e)
        //{
        //    FrmTareo_Importar abrir = new FrmTareo_Importar();
        //    abrir.anio = cboAnio_ctrl.SelectedValue.ToString();
        //    abrir.semana = cboSemana_ctrl.SelectedValue.ToString();
        //    abrir.fecha_inicio = txtFechaInicio_ctrl.Text;
        //    abrir.fecha_fin = txtFechaFin_ctrl.Text;
        ////    abrir.tareador = l_dni.Text;
        //    abrir.ShowDialog(); 
        //}

        private void dgvTareo_ctrl_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvTareo_ctrl.Rows.Count>0)
            {
                txt_buscar.Enabled = true;
                txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
                txt_buscar.Focus();
                txt_buscar.Clear();
                filtro = dgvTareo_ctrl.Columns[e.ColumnIndex].HeaderText;
                lbl_buscar.Text = "Buscar en " + filtro;
                dgvTareo_ctrl.CurrentCell = dgvTareo_ctrl.Rows[0].Cells[e.ColumnIndex];
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            (dgvTareo_ctrl.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" + " ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
            lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgvTareo_ctrl.Rows.Count);
            mostrar_totales();
        }

        private void btnReabrir_Click(object sender, EventArgs e)
        {
            if (dgvTareo_ctrl.Rows.Count <= 0)
            {
                util.mensaje("No es posible realizar esta operación", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }

            try
            {
                string tareador = Convert.ToString(AccesoLogica.obtener_user(cboTareador_ctrl.SelectedValue.ToString()).Rows[0][0]);
                string estTareo = Convert.ToString(AccesoLogica.obtener_estTareo(cboAnio_ctrl.SelectedValue.ToString(), cboSemana_ctrl.SelectedValue.ToString(), tareador).Rows[0][0]);
                
                if (estTareo == "1" || estTareo == "2")
                {
                    DialogResult resul = MessageBox.Show("¿Está seguro que quiere reabrir este tareo?", "Reabrir Tareo", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                    AccesoLogica.revisar_tareo(cboAnio_ctrl.SelectedValue.ToString(), cboSemana_ctrl.SelectedValue.ToString(), tareador, "0", usuario);
                    util.mensaje("El tareo se pasó a estado EN PROCESO", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    dgvTareo_ctrl.DataSource = null;
                    dgvTareo_ctrl.DataSource = AccesoLogica.listar_grilla_tareo_ctrl(Convert.ToInt32(cboAnio_ctrl.SelectedValue.ToString()), Convert.ToInt32(cboSemana_ctrl.SelectedValue.ToString()), tareador, 1, "", "");
                    formatear_grilla(dgvTareo_ctrl);
                    EnviarEmail(cboAnio_ctrl.SelectedValue.ToString(), cboSemana_ctrl.SelectedValue.ToString(), tareador, "0");
                    }
                }
                else
                {
                    util.mensaje("El tareo ya se encuentra EN PROCESO ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                }
            }
            catch (Exception ex)
            {
                util.mensaje("error: "+ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
            }
        }

        private void t_msg_Tick(object sender, EventArgs e)
        {
            lbl_msg.Text = string.Empty;
            ss_load.BackColor = Color.Transparent;
            lbl_contador_registros.Visible = true;
            lbl_msg.Visible = false;
        }

        private void cboAnio_ctrl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_combo_semana(cboAnio_ctrl.SelectedValue.ToString());
            cargar_fechas_ctrl(cboAnio_ctrl.SelectedValue.ToString(), cboSemana_ctrl.SelectedValue.ToString()); // cargar fechas de inicio y fin
        }

        private void cboSemana_ctrl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_fechas_ctrl(cboAnio_ctrl.SelectedValue.ToString(), cboSemana_ctrl.SelectedValue.ToString()); // cargar fechas de inicio y fin
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            string tareador;
            string estTareo;
            if (Convert.ToString(Convert.ToInt32(AccesoLogica.verificar_acceso(l_dni.Text).Rows[0][0])) != "2" && Convert.ToString(Convert.ToInt32(AccesoLogica.verificar_acceso(l_dni.Text).Rows[0][0])) != "3")
            {
                return;
            }
            if (dgvTareo_ctrl.Rows.Count <= 0)
            {
                util.mensaje("No es posible realizar esta operación", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
            try
            {
                tareador = Convert.ToString(AccesoLogica.obtener_user(cboTareador_ctrl.SelectedValue.ToString()).Rows[0][0]);
                estTareo = Convert.ToString(AccesoLogica.obtener_estTareo(cboAnio_ctrl.SelectedValue.ToString(), cboSemana_ctrl.SelectedValue.ToString(), tareador).Rows[0][0]);
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
                    AccesoLogica.revisar_tareo(cboAnio_ctrl.SelectedValue.ToString(), cboSemana_ctrl.SelectedValue.ToString(), tareador, "2", usuario);
                    util.mensaje("Se realizó la aprobación de manera exitosa", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    dgvTareo_ctrl.DataSource = null;
                    dgvTareo_ctrl.DataSource = AccesoLogica.listar_grilla_tareo_ctrl(Convert.ToInt32(cboAnio_ctrl.SelectedValue.ToString()), Convert.ToInt32(cboSemana_ctrl.SelectedValue.ToString()), tareador, 1, "", "");
                    formatear_grilla(dgvTareo_ctrl);
                    EnviarEmail(cboAnio_ctrl.SelectedValue.ToString(), cboSemana_ctrl.SelectedValue.ToString(), tareador, "2");
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

        private bool EnviarEmail(string msj_anio, string msj_semana, string msj_usuario, string msj_tipo)
        {

            // Tipo Mensaje:
            // 0: tareo reabierto    1: tareo Revisado     2: tareo Aprobado
            if (msj_tipo == "0")
            {
                msj_tipo = "En Proceso";
                msj_usu_destino = msj_usuario;
                msj_usu_ccdestino = "lgutierrezc";
            }
            else
            {
                if (msj_tipo == "1")
                {
                    msj_tipo = "Revisado";
                    msj_usu_destino = "holivera";
                    msj_usu_ccdestino = "lgutierrezc";
                }
                else
                {
                    if (msj_tipo == "2")
                    {
                        msj_tipo = "Aprobado";
                        msj_usu_destino = "holivera";
                        msj_usu_ccdestino = msj_usuario;
                    }
                }
            }
            string textbody =
           "<br/>" + "Estimado(s):" + "<br>" +
           "<br/>" + "El tareo correspondiente al usuario: " + msj_usuario + ", año: " + msj_anio + ", semana: " + msj_semana + "\r\n" +
           "<br/>" + " pasó al estado: " + msj_tipo.ToUpper() + " por el usuario: " + usuario + " <br>" +
            "<br/>" + " " + "\r\n" +
           "<br/>" + " " + "\r\n" +
           "<br/>" + "Administrador MISAP" + "<br>";

            MailMessage msg = new MailMessage();

            msg.To.Add(msj_usu_destino + "@imecon.com.pe");
            msg.CC.Add(msj_usu_ccdestino + "@imecon.com.pe");
            msg.From = new MailAddress("misap@imecon.com.pe", "Modulo de Interfaz SAP", System.Text.Encoding.UTF8);
            msg.Subject = "Tareo usuario: " + msj_usuario + ", año: " + msj_anio + ", semana: " + msj_semana;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = textbody;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("seg_docum@imecon.com.pe", "$3g#d0cum");
            client.Port = 587;
            client.Host = "smtp.gmail.com";//Este es el smtp valido para Gmail
            client.EnableSsl = true; //Esto es para que vaya a través de SSL que es obligatorio con GMail
            try
            {
                client.Send(msg);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //private void chkRegistroAsistencia_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chkRegistroAsistencia.Checked == true)
        //    {
        //        AccesoLogica.actualizar_autorizacion("7091", "1", "S");
        //    }
        //    else
        //    {
        //        AccesoLogica.actualizar_autorizacion("7091", "1", "N");
        //    }
        //}

        //private void chkRegistroDiaActual_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chkRegistroDiaActual.Checked == true)
        //    {
        //        AccesoLogica.actualizar_autorizacion("7091", "2", "S");
        //    }
        //    else
        //    {
        //        AccesoLogica.actualizar_autorizacion("7091", "2", "N");
        //    }
        //}

        private void cboTareador_ctrl_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboTareador_ctrl_Enter(object sender, EventArgs e)
        {
            cboTareador_ctrl.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboTareador_ctrl_Leave(object sender, EventArgs e)
        {
            cboTareador_ctrl.BackColor = Color.White;
        }

        private void cboOT_ctrl_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboOT_ctrl_Enter(object sender, EventArgs e)
        {
            cboOT_ctrl.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboOT_ctrl_Leave(object sender, EventArgs e)
        {
            cboOT_ctrl.BackColor = Color.White;
        }

        private void cboAnio_ctrl_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboAnio_ctrl_Enter(object sender, EventArgs e)
        {
            cboAnio_ctrl.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboAnio_ctrl_Leave(object sender, EventArgs e)
        {
            cboAnio_ctrl.BackColor = Color.White;
        }

        private void cboSemana_ctrl_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboSemana_ctrl_Enter(object sender, EventArgs e)
        {
            cboSemana_ctrl.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboSemana_ctrl_Leave(object sender, EventArgs e)
        {
            cboSemana_ctrl.BackColor = Color.White;
        }

        private void btnEstadoTareos_Click(object sender, EventArgs e)
        {
            btn_grabar.Enabled = false;
            string anio_estados = cboAnio_ctrl.SelectedValue.ToString();
            string semana_estados = cboSemana_ctrl.SelectedValue.ToString();
            dgvTareo_ctrl.DataSource = null;
            dgvTareo_ctrl.DataSource = AccesoLogica.listar_grilla_tareo_estados(anio_estados, semana_estados);
            formatear_grilla(dgvTareo_ctrl);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTareo_ctrl_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            FrmTareo_SeguimientoDet Detalle = new FrmTareo_SeguimientoDet();
            Detalle.anio = cboAnio_ctrl.SelectedValue.ToString();
            Detalle.semana = cboSemana_ctrl.SelectedValue.ToString();
            Detalle.documento = dgvTareo_ctrl.Rows[e.RowIndex].Cells["DNI"].Value.ToString();
            Detalle.ShowDialog();
        }

        
    }
}
