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
    public partial class FrmTareo_Seguimiento : Form
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

        string opcion = "0";
        string sql1 = "";
        string sql2 = "";
        string sql3 = "";
        string sql4 = "";
        string filtro;
        DataTable dtRegistros = new DataTable();

        private Point pos = Point.Empty;
          
        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();
      
        #endregion
        
        #region Formulario

        public FrmTareo_Seguimiento()
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

            cboAnio_segui.DataSource = dt;
            cboAnio_segui.ValueMember = "Codigo";
            cboAnio_segui.DisplayMember = "Descripcion";
            cboAnio_segui.SelectedIndex = 3;
        }

        private void cargar_combo_semana(string anio)
        {
            cboSemana_segui.DataSource = AccesoLogica.listar_semanas_anio(anio);
            cboSemana_segui.ValueMember = "codigo";
            cboSemana_segui.DisplayMember = "descripcion";
        }
                
        private void cargar_fechas_segui(string anio, string semana)
        {
            DataTable dt = new DataTable();
            dt = AccesoLogica.listar_fechas_inifin(anio, semana);
            string fechaIni = dt.Rows[0]["fechaini"].ToString();
            string fechaFin = dt.Rows[0]["fechafin"].ToString();
            txtFechaInicio_segui.Text = fechaIni;
            txtFechaFin_segui.Text = fechaFin;
        }

        


        #endregion
        
        #region Eventos
       
        private void FrmTareoControl_Load(object sender, EventArgs e)
        {
            util.EstablecerAuditoria("Nuevo", usuario, "", "7093", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            cargar_combo_anio();    // cargar combo año
            try
            {
                cargar_combo_semana(cboAnio_segui.SelectedValue.ToString()); // cargar combo semana
                cargar_fechas_segui(cboAnio_segui.SelectedValue.ToString(), cboSemana_segui.SelectedValue.ToString()); // cargar fechas de inicio y fin
            }
            catch (Exception)
            {
            }
            rbtnNumRegistros.Checked = true;

            if (rbtnNumRegistros.Checked == true)
		        opcion ="1";	        
            if (rbtnTotHoras.Checked == true)
		        opcion ="2";	
            if (rbtnHorExtra.Checked == true)
		        opcion ="3";

            construir_cadena_sql();
            cargar_grilla_segui(sql1, sql2, sql3, sql4);
        }

        private void construir_cadena_sql()
        {
            sql1 = "select dni, nombre, ";
            sql2 = " from ( select bb.dni, bb.nombre, bb.fec_trab, bb.cont from (	select	d_tareo.usr_crea, d_tareo.cod_trab dni,	trabajadores.apepat + ' ' + trabajadores.apemat + ', ' + trabajadores.nombre nombre, d_tareo.fec_trab, ";
            sql3 = " from  d_tareo  right join [10.0.0.20\\STARSOFT].[IMECON].[dbo].[TRABAJADORES] trabajadores on d_tareo.cod_trab = trabajadores.dociden COLLATE Modern_Spanish_CI_AS	where  TIPOTRAB in ('20','27') and TRABAJADORES.SITUACIÓN in ('0','1') ";
            sql4 = " and swt_est<>'A' ) bb ) SOURCE   PIVOT	( SUM(SOURCE.cont) FOR SOURCE.fec_trab in ([";
            DateTime dtini = Convert.ToDateTime(txtFechaInicio_segui.Text);
            DateTime dtfin = Convert.ToDateTime(txtFechaFin_segui.Text);

            sql1 = sql1 + " COALESCE ([" + dtini.ToString("yyyy-MM-dd") + "],0) [" + dtini.ToString("yyyy-MM-dd") + "]";
            sql4 = sql4 + dtini.ToString("yyyy-MM-dd") + "]";
            for (DateTime j = dtini.AddDays(1); j <= dtfin; j = j.AddDays(1))
            {
                sql1 = sql1 + " , COALESCE ([" + j.ToString("yyyy-MM-dd") + "],0) [" + j.ToString("yyyy-MM-dd") + "] ";
                sql4 = sql4 + ",[" + j.ToString("yyyy-MM-dd") + "]";
            }

            if (rbtnNumRegistros.Checked == true)
                sql2 = sql2 + " 1 cont ";
            if (rbtnTotHoras.Checked == true)
                sql2 = sql2 + " hor_trab cont ";
            if (rbtnHorExtra.Checked == true)
                sql2 = sql2 + " hor_extr cont ";

            sql3 = sql3 + " and d_tareo.ano_reg='" + cboAnio_segui.SelectedValue.ToString() + "' and d_tareo.sem_reg='" + cboSemana_segui.SelectedValue.ToString() + "' ";
            sql4 = sql4 + ") 	) AS PIVOTABLE";

        }

        private void cargar_grilla_segui(string sql1, string sql2, string sql3, string sql4)
        {
            DataTable dt_segui = AccesoLogica.cargar_grilla_segui(sql1, sql2, sql3, sql4);
            dgvTareo_segui.DataSource = dt_segui;
            util.FormatearGrilla(dgvTareo_segui,true);
        }
        
        #endregion

        
        private void dgvTareo_ctrl_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvTareo_segui.Rows.Count>0)
            {
                txt_buscar.Enabled = true;
                txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
                txt_buscar.Focus();
                txt_buscar.Clear();
                filtro = dgvTareo_segui.Columns[e.ColumnIndex].HeaderText;
                lbl_buscar.Text = "Buscar en " + filtro;
                dgvTareo_segui.CurrentCell = dgvTareo_segui.Rows[0].Cells[e.ColumnIndex];
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            (dgvTareo_segui.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" + " ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
            lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgvTareo_segui.Rows.Count);
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
            cargar_combo_semana(cboAnio_segui.SelectedValue.ToString());
            cargar_fechas_segui(cboAnio_segui.SelectedValue.ToString(), cboSemana_segui.SelectedValue.ToString()); // cargar fechas de inicio y fin
            construir_cadena_sql();
            cargar_grilla_segui(sql1, sql2, sql3, sql4);
        }

        private void cboSemana_ctrl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_fechas_segui(cboAnio_segui.SelectedValue.ToString(), cboSemana_segui.SelectedValue.ToString()); // cargar fechas de inicio y fin
            construir_cadena_sql();
            cargar_grilla_segui(sql1, sql2, sql3, sql4);
        }

        
        private void cboAnio_ctrl_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboAnio_ctrl_Enter(object sender, EventArgs e)
        {
            cboAnio_segui.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboAnio_ctrl_Leave(object sender, EventArgs e)
        {
            cboAnio_segui.BackColor = Color.White;
        }

        private void cboSemana_ctrl_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboSemana_ctrl_Enter(object sender, EventArgs e)
        {
            cboSemana_segui.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboSemana_ctrl_Leave(object sender, EventArgs e)
        {
            cboSemana_segui.BackColor = Color.White;
        }

        private void btnEstadoTareos_Click(object sender, EventArgs e)
        {
            btn_grabar.Enabled = false;
            string anio_estados = cboAnio_segui.SelectedValue.ToString();
            string semana_estados = cboSemana_segui.SelectedValue.ToString();
            dgvTareo_segui.DataSource = null;
            dgvTareo_segui.DataSource = AccesoLogica.listar_grilla_tareo_estados(anio_estados, semana_estados);
            formatear_grilla(dgvTareo_segui);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTareo_segui_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvTareo_segui.Columns[e.ColumnIndex].Name != "dni" && this.dgvTareo_segui.Columns[e.ColumnIndex].Name != "nombre")
            {
                if (rbtnNumRegistros.Checked == true)
                {
                    try
                    {
                        if (e.Value.GetType() != typeof(System.DBNull))
                        {
                            if (e.Value.ToString() == "0")
                            {
                                e.CellStyle.BackColor = Color.Red;
                                e.CellStyle.ForeColor = Color.White;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                if (rbtnTotHoras.Checked == true)
                {
                    try
                    {
                        if (e.Value.GetType() != typeof(System.DBNull))
                        {
                            if (Convert.ToDecimal(e.Value.ToString()) > Convert.ToDecimal("8,5"))
                            {
                                e.CellStyle.BackColor = Color.Red;
                                e.CellStyle.ForeColor = Color.White;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        private void rbtnNumRegistros_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNumRegistros.Checked == true)
            {
                construir_cadena_sql();
                cargar_grilla_segui(sql1, sql2, sql3, sql4);
            }
        }

        private void rbtnTotHoras_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTotHoras.Checked == true)
            {
                construir_cadena_sql();
                cargar_grilla_segui(sql1, sql2, sql3, sql4);
            }
        }

        private void rbtnHorExtra_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHorExtra.Checked == true)
            {
                construir_cadena_sql();
                cargar_grilla_segui(sql1, sql2, sql3, sql4);
            }
        }

        private void dgvTareo_segui_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            FrmTareo_SeguimientoDet Detalle = new FrmTareo_SeguimientoDet();
            Detalle.anio = cboAnio_segui.SelectedValue.ToString();
            Detalle.semana = cboSemana_segui.SelectedValue.ToString();
            Detalle.documento = dgvTareo_segui.Rows[e.RowIndex].Cells["dni"].Value.ToString();
            Detalle.ShowDialog();
        }
    }
}
