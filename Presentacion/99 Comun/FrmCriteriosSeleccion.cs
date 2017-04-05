using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;
using Negocio;
using System.Net.Mail;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;
using SAPbobsCOM;
using Excel = Microsoft.Office.Interop.Excel;

namespace MISAP
{
    public partial class FrmCriteriosSeleccion : Form
    {
        AccesoLogica _Negocio = new AccesoLogica();
        DataTable dt, dt1, dt_inicio;
        DataTable dt_civ, dt_civ_inicio;
        
       #region Variables globales

        public string usuario, perfil, titulo_; 

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        #region Variables locales

        string titulo_rep;
        string fechaIni = "";
        string fechaFin = "";
        string anio = "";
        string semana = "";
        string tfor = "";
        string eval = "";
        string dni = "";
        string swtht = "";


        private Point pos = Point.Empty;
        private bool move = false;
        bool allowSelect = false;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();


        private BankPages extracto;
        private SAPbobsCOM.SBObob oSBObob;


        string MontoCredito, MontoDebito, FechaOperacion, Referencia;
        string ColMonto, proveedor, textbody, IP, concatenar, DNI, AREA, EMPLEADO, PERFIL;
        int posicion, columna, pedido, id_solicitud, NumLinea = 0;

        int cant_col, ColumnaId, id;
        int[] vector, vec_col;
        bool[] vec_falg;
        bool visible_;

        #endregion

        #region Formulario

        public FrmCriteriosSeleccion()
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
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); 

            
        }

     

        #endregion

        #region Eventos

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(247, 247, 247);
            tsl_titulo.Text = titulo_ + " -  " + "Criterios de selección";

            informeemp.BackColor = Color.FromArgb(247, 247, 247);
            informetareos.BackColor = Color.FromArgb(247, 247, 247); 

            if (titulo_ == "Informe de tareos")
            {
                tc_informe.TabPages.Remove(informeemp);

                // cargar mes (pestaña reporte)
                cargar_combo_anio();      
                cargar_combo_mes();
                try
                {
                    cargar_combo_semana(cboAnio_inf.SelectedValue.ToString());
                    cargar_combo_semana_proc(cboAnio_proc.SelectedValue.ToString());
                    cargar_fechas(cboAnio_proc.SelectedValue.ToString(), cboSemana_proc.SelectedValue.ToString());  
                }
                catch (Exception)
                {
                }
                cargar_combo_planilla();
                rbtnOtStarsoft.Checked = true;
                rbtnSemana.Checked = true;
                rbtnInformativos.Checked = true;
                rbtnProduccion.Checked = true;

            }


        }

        private void t_msg_Tick(object sender, EventArgs e)
        {
            lbl_msg.Text = string.Empty;
            ss_load.BackColor = Color.Transparent;
            lbl_contador_registros.Visible = true;
            lbl_msg.Visible = false;
        }

        #endregion

        #region Botones

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            
            if (rbtnInformativos.Checked == true)
            {
                try
                {

                    if (!BW.IsBusy)
                    {


                        if (rbtnProduccion.Checked == true)
                        {
                            tfor = "1";
                            titulo_rep = titulo_ + " - " + "Formato Produccción";
                        }
                        else
                        {
                            tfor = "2";
                            titulo_rep = titulo_ + " - " + "Formato RRHH";
                        }
                        if (chkHrsTot.Checked == true)
                            swtht = "1";
                        if (rbtnSemana.Checked == true)
                        {
                            DataTable dt = new DataTable();
                            semana = cboSemana_inf.SelectedValue.ToString();
                            eval = "3";
                        }

                        if (rbtnMes.Checked == true)
                        {
                            string _mes = cboMes_inf.SelectedValue.ToString();
                            string _messig = (Convert.ToInt32(_mes) == 12 ? 1 : Convert.ToInt32(_mes) + 1).ToString();
                            fechaIni = new DateTime(Convert.ToInt32(cboAnio_inf.SelectedValue.ToString()), Convert.ToInt32(cboMes_inf.SelectedValue.ToString()), 1).ToShortDateString();
                            fechaFin = Convert.ToDateTime(fechaIni).AddMonths(1).AddDays(-1).ToShortDateString();
                            eval = "1";
                        }
                        if (rbtnDesde.Checked == true)
                        {
                            fechaIni = dtpFechaIni_rep.Value.ToShortDateString();
                            fechaFin = dtpFechaFin_rep.Value.ToShortDateString();
                            eval = "2";
                        }
                        dni = txtDni_rep.Text;
                        anio = cboAnio_inf.SelectedValue.ToString();

                    
                    
                        util.mensaje_espera("Cargando, por favor espere", true, lbl_contador_registros, lbl_msg, ss_load, true);
                        BW.RunWorkerAsync();
                    
                    }
                }
                catch (Exception ex)
                {
                    util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    return;
                }
            }

            if (rbtnProcesos.Checked == true)
            {
                try
                {
                    string anio = "";
                    string semana = "";

                    anio = cboAnio_proc.SelectedValue.ToString();
                    semana = cboSemana_proc.SelectedValue.ToString();
                    string opcPlanilla = cboPlanilla_rep.SelectedValue.ToString();

                    if (opcPlanilla == "2")
                    {
                        if (AccesoLogica.reiniciar_tablas() != 0)
                        { }
                        dt = _Negocio.cargar_grilla(anio, semana);
                        dt_inicio = rbtnOtStarsoft.Checked == true ? dt.DefaultView.ToTable(true, "CODIGO", "TRABAJADOR") : dt.DefaultView.ToTable(true, "CODIGO", "TRABAJADOR", "OT");
                        //if (rbtnOtStarsoft.Checked==true)
                        //    dt_inicio = dt.DefaultView.ToTable(true, "CODIGO", "TRABAJADOR");    //agrupado por codigo, trabajador
                        //else
                        //    dt_inicio = dt.DefaultView.ToTable(true, "CODIGO", "TRABAJADOR", "OT");  //agrupado por codigo, trabajador, ot

                        DateTime dtini = Convert.ToDateTime(txtFechaIni_reg.Text);
                        DateTime dtfin = Convert.ToDateTime(txtFechaFin_reg.Text);

                        int jj = 1;
                        for (DateTime j = dtini; j <= dtfin; j = j.AddDays(1))
                        {
                            if (AccesoLogica.insertar_fecha(j.ToShortDateString(), jj.ToString()) != 0)
                                jj++;
                        }

                        foreach (DataRow item2 in dt_inicio.Rows)
                        {
                            string _codigo = item2["CODIGO"].ToString();
                            string _trabajador = item2["TRABAJADOR"].ToString();
                            string _ot = "";
                            if (rbtnOtStarsoft.Checked == true)
                            {
                                try 
	                            {
                                    _ot = _Negocio.Buscar_Ot(_codigo).Rows[0][0].ToString();
	                            }
	                            catch (Exception)
	                            {
                                    MessageBox.Show("OT de trabajador no encontrada en STARSOFT", "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                    return;
	                            }
                            }
                                
                            else
                                _ot = item2["OT"].ToString();

                            DataView dv_filtro = dt.DefaultView;
                            if (rbtnOtStarsoft.Checked == true)
                                dv_filtro.RowFilter = "(TRABAJADOR = '" + _trabajador + "' )";    //filtro por trabajador
                            else
                                dv_filtro.RowFilter = "(TRABAJADOR = '" + _trabajador + "' ) and (OT = '" + _ot + "' )";  //filtro por trabajador, ot

                            DataTable dt_filtro = dv_filtro.ToTable();
                            int i = 0;
                            if (AccesoLogica.insertar_registro(_codigo, _trabajador, _ot, "1") != 0)
                            {
                                foreach (DataRow item in dt_filtro.Rows)
                                {
                                    i = Convert.ToInt32(_Negocio.buscar_codigo(item["FECHA"].ToString()).Rows[0][0].ToString());
                                    string HTRABAJ = item["HTRABAJ"].ToString().Replace(",", ".") == "" ? "0" : item["HTRABAJ"].ToString().Replace(",", ".");
                                    string OBHE25 = item["OBHE25"].ToString().Replace(",", ".") == "" ? "0" : item["OBHE25"].ToString().Replace(",", ".");
                                    string OBHE35 = item["OBHE35"].ToString().Replace(",", ".") == "" ? "0" : item["OBHE35"].ToString().Replace(",", ".");
                                    string CCHE100 = item["CCHE100"].ToString().Replace(",", ".") == "" ? "0" : item["CCHE100"].ToString().Replace(",", ".");
                                    string DFERIADO = item["DFERIADO"].ToString().Replace(",", ".") == "" ? "0" : item["DFERIADO"].ToString().Replace(",", ".");
                                    string DFALTAS = item["DFALTAS"].ToString().Replace(",", ".") == "" ? "0" : item["DFALTAS"].ToString().Replace(",", ".");
                                    string DDMEDICO = item["DDMEDICO"].ToString().Replace(",", ".") == "" ? "0" : item["DDMEDICO"].ToString().Replace(",", ".");
                                    string DSUBENF = item["DSUBENF"].ToString().Replace(",", ".") == "" ? "0" : item["DSUBENF"].ToString().Replace(",", ".");
                                    string DSUBMAT = item["DSUBMAT"].ToString().Replace(",", ".") == "" ? "0" : item["DSUBMAT"].ToString().Replace(",", ".");
                                    string DVACAC = item["DVACAC"].ToString().Replace(",", ".") == "" ? "0" : item["DVACAC"].ToString().Replace(",", ".");
                                    string DTRABAJ = item["DTRABAJ"].ToString().Replace(",", ".") == "" ? "0" : item["DTRABAJ"].ToString().Replace(",", ".");
                                    string DLICSGO = item["DLICSGO"].ToString().Replace(",", ".") == "" ? "0" : item["DLICSGO"].ToString().Replace(",", ".");
                                    string DBAJADA = item["DBAJADA"].ToString().Replace(",", ".") == "" ? "0" : item["DBAJADA"].ToString().Replace(",", ".");

                                    string campo_HTRABAJ = string.Concat("D", i.ToString(), "HTRABAJ");
                                    string campo_OBHE25 = string.Concat("D", i.ToString(), "OBHE25");
                                    string campo_OBHE35 = string.Concat("D", i.ToString(), "OBHE35");
                                    string campo_CCHE100 = string.Concat("D", i.ToString(), "CCHE100");
                                    string campo_DFERIADO = string.Concat("D", i.ToString(), "DFERIADO");
                                    string campo_DFALTAS = string.Concat("D", i.ToString(), "DFALTAS");
                                    string campo_DDMEDICO = string.Concat("D", i.ToString(), "DDMEDICO");
                                    string campo_DSUBENF = string.Concat("D", i.ToString(), "DSUBENF");
                                    string campo_DSUBMAT = string.Concat("D", i.ToString(), "DSUBMAT");
                                    string campo_DVACAC = string.Concat("D", i.ToString(), "DVACAC");
                                    string campo_DTRABAJ = string.Concat("D", i.ToString(), "DTRABAJ");
                                    string campo_DLICSGO = string.Concat("D", i.ToString(), "DLICSGO");
                                    string campo_DBAJADA = string.Concat("D", i.ToString(), "DBAJADA");

                                    string campo_ccHTRABAJ = string.Concat("CCD", i.ToString(), "HTRABAJ");
                                    string campo_ccOBHE25 = string.Concat("CCD", i.ToString(), "OBHE25");
                                    string campo_ccOBHE35 = string.Concat("CCD", i.ToString(), "OBHE35");
                                    string campo_ccCCHE100 = string.Concat("CCD", i.ToString(), "CCHE100");
                                    string campo_ccDFERIADO = string.Concat("CCD", i.ToString(), "DFERIADO");
                                    string campo_ccDFALTAS = string.Concat("CCD", i.ToString(), "DFALTAS");
                                    string campo_ccDDMEDICO = string.Concat("CCD", i.ToString(), "DDMEDICO");
                                    string campo_ccDSUBENF = string.Concat("CCD", i.ToString(), "DSUBENF");
                                    string campo_ccDSUBMAT = string.Concat("CCD", i.ToString(), "DSUBMAT");
                                    string campo_ccDVACAC = string.Concat("CCD", i.ToString(), "DVACAC");
                                    string campo_ccDTRABAJ = string.Concat("CCD", i.ToString(), "DTRABAJ");
                                    string campo_ccDLICSGO = string.Concat("CCD", i.ToString(), "DLICSGO");
                                    string campo_ccDBAJADA = string.Concat("CCD", i.ToString(), "DBAJADA");
                                    if (AccesoLogica.actualizar_registro(_trabajador, _ot, HTRABAJ, OBHE25, OBHE35, CCHE100, DFERIADO, DFALTAS, DDMEDICO, DSUBENF, DSUBMAT, DVACAC, DTRABAJ, DLICSGO, DBAJADA, campo_HTRABAJ, campo_OBHE25, campo_OBHE35, campo_CCHE100, campo_DFERIADO, campo_DFALTAS, campo_DDMEDICO, campo_DSUBENF, campo_DSUBMAT, campo_DVACAC, campo_DTRABAJ, campo_DLICSGO, campo_DBAJADA, campo_ccHTRABAJ, campo_ccOBHE25, campo_ccOBHE35, campo_ccCCHE100, campo_ccDFERIADO, campo_ccDFALTAS, campo_ccDDMEDICO, campo_ccDSUBENF, campo_ccDSUBMAT, campo_ccDVACAC, campo_ccDTRABAJ, campo_ccDLICSGO, campo_ccDBAJADA) != 0)
                                    {
                                    }
                                    else
                                    {
                                        MessageBox.Show("error", "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                        return;
                                    }
                                }
                            }
                        }
                        //MessageBox.Show("exito", "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                        DataTable dt_final = _Negocio.Consulta_final(opcPlanilla);
                        FrmTareo_Reporte reporte = new FrmTareo_Reporte();
                        reporte.dt_reporte = dt_final;
                        reporte.titulo_rep = "REPORTE - TAREO - COMÚN";
                        reporte.ShowDialog();
                    }

                    if (opcPlanilla == "3")
                    {
                        if (AccesoLogica.reiniciar_tablas() != 0)
                        { }
                        else
                        {
                            return;
                        }
                        dt_civ = _Negocio.cargar_grilla_civil(anio, semana);
                        dt_civ_inicio = rbtnOtStarsoft.Checked == true ? dt_civ.DefaultView.ToTable(true, "CODIGO", "TRABAJADOR") : dt_civ.DefaultView.ToTable(true, "CODIGO", "TRABAJADOR", "OT");

                        DateTime dtini = Convert.ToDateTime(txtFechaIni_reg.Text);
                        DateTime dtfin = Convert.ToDateTime(txtFechaFin_reg.Text);

                        int jj = 1;
                        for (DateTime j = dtini; j <= dtfin; j = j.AddDays(1))
                        {
                            if (AccesoLogica.insertar_fecha(j.ToShortDateString(), jj.ToString()) != 0)
                                jj++;
                        }

                        foreach (DataRow item2 in dt_civ_inicio.Rows)
                        {
                            string _codigo = item2["CODIGO"].ToString();
                            string _trabajador = item2["TRABAJADOR"].ToString();
                            string _ot = "";
                            if (rbtnOtStarsoft.Checked == true)
                                try
                                {
                                    _ot = _Negocio.Buscar_Ot(_codigo).Rows[0][0].ToString();
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("OT de trabajador no encontrada en STARSOFT", "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                    return;
                                }
                            else
                                _ot = item2["OT"].ToString();
                            DataView dv_filtro = dt_civ.DefaultView;
                            if (rbtnOtStarsoft.Checked == true)
                                dv_filtro.RowFilter = "(TRABAJADOR = '" + _trabajador + "' )";    //filtro por trabajador
                            else
                                dv_filtro.RowFilter = "(TRABAJADOR = '" + _trabajador + "' ) and (OT = '" + _ot + "' )";  //filtro por trabajador, ot
                            DataTable dt_filtro = dv_filtro.ToTable();
                            int i = 0;
                            if (AccesoLogica.insertar_registro(_codigo, _trabajador, _ot, "2") != 0)
                            {
                                foreach (DataRow item in dt_filtro.Rows)
                                {
                                    i = Convert.ToInt32(_Negocio.buscar_codigo(item["FECHA"].ToString()).Rows[0][0].ToString());
                                    string CCHTRAB = item["CCHTRAB"].ToString().Replace(",", ".") == "" ? "0" : item["CCHTRAB"].ToString().Replace(",", ".");
                                    string CCDFALTA = item["CCDFALTA"].ToString().Replace(",", ".") == "" ? "0" : item["CCDFALTA"].ToString().Replace(",", ".");
                                    string CCHE60 = item["CCHE60"].ToString().Replace(",", ".") == "" ? "0" : item["CCHE60"].ToString().Replace(",", ".");
                                    string CCHE100 = item["CCHE100"].ToString().Replace(",", ".") == "" ? "0" : item["CCHE100"].ToString().Replace(",", ".");
                                    string CCHDOBLE = item["CCHDOBLE"].ToString().Replace(",", ".") == "" ? "0" : item["CCHDOBLE"].ToString().Replace(",", ".");
                                    string CCDDMED = item["CCDDMED"].ToString().Replace(",", ".") == "" ? "0" : item["CCDDMED"].ToString().Replace(",", ".");
                                    string CCFERIAD = item["CCFERIAD"].ToString().Replace(",", ".") == "" ? "0" : item["CCFERIAD"].ToString().Replace(",", ".");

                                    string campo_CCHTRAB = string.Concat("D", i.ToString(), "CCHTRAB");
                                    string campo_CCDFALTA = string.Concat("D", i.ToString(), "CCDFALTA");
                                    string campo_CCHE60 = string.Concat("D", i.ToString(), "CCHE60");
                                    string campo_CCHE100 = string.Concat("D", i.ToString(), "CCHE100");
                                    string campo_CCHDOBLE = string.Concat("D", i.ToString(), "CCHDOBLE");
                                    string campo_CCDDMED = string.Concat("D", i.ToString(), "CCDDMED");
                                    string campo_CCFERIAD = string.Concat("D", i.ToString(), "CCFERIAD");

                                    string campo_ccCCHTRAB = string.Concat("CCD", i.ToString(), "CCHTRAB");
                                    string campo_ccCCDFALTA = string.Concat("CCD", i.ToString(), "CCDFALTA");
                                    string campo_ccCCHE60 = string.Concat("CCD", i.ToString(), "CCHE60");
                                    string campo_ccCCHE100 = string.Concat("CCD", i.ToString(), "CCHE100");
                                    string campo_ccCCHDOBLE = string.Concat("CCD", i.ToString(), "CCHDOBLE");
                                    string campo_ccCCDDMED = string.Concat("CCD", i.ToString(), "CCDDMED");
                                    string campo_ccCCFERIAD = string.Concat("CCD", i.ToString(), "CCFERIAD");

                                    if (AccesoLogica.actualizar_registro_civil(_trabajador, _ot, CCHTRAB, CCDFALTA, CCHE60, CCHE100, CCHDOBLE, CCDDMED, CCFERIAD, campo_CCHTRAB, campo_CCDFALTA, campo_CCHE60, campo_CCHE100, campo_CCHDOBLE, campo_CCDDMED, campo_CCFERIAD, campo_ccCCHTRAB, campo_ccCCDFALTA, campo_ccCCHE60, campo_ccCCHE100, campo_ccCCHDOBLE, campo_ccCCDDMED, campo_ccCCFERIAD) != 0)
                                    {
                                    }
                                    else
                                    {
                                        MessageBox.Show("error", "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                        return;
                                    }
                                }
                            }
                        }
                        //MessageBox.Show("exito", "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                        DataTable dt_final = _Negocio.Consulta_final(opcPlanilla);
                        FrmTareo_Reporte reporte = new FrmTareo_Reporte();
                        reporte.dt_reporte = dt_final;
                        reporte.titulo_rep = "REPORTE - TAREO - CIVIL";
                        reporte.ShowDialog();
                    }
                    
                }
                catch (Exception ex)
                {
                    util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    return;
                }
            }
        }

        #endregion

        private void rbtnMes_CheckedChanged(object sender, EventArgs e)
        {
            cboMes_inf.Enabled = true;
            cboSemana_inf.Enabled = false;
            dtpFechaIni_rep.Enabled = false;
            dtpFechaFin_rep.Enabled = false;
        }

        private void rbtnSemana_CheckedChanged(object sender, EventArgs e)
        {
            cboMes_inf.Enabled = false;
            cboSemana_inf.Enabled = true;
            dtpFechaIni_rep.Enabled = false;
            dtpFechaFin_rep.Enabled = false;
        }

        private void rbtnDesde_CheckedChanged(object sender, EventArgs e)
        {
            cboMes_inf.Enabled = false;
            cboSemana_inf.Enabled = false;
            dtpFechaIni_rep.Enabled = true;
            dtpFechaFin_rep.Enabled = true;
        }

        private void rbtnInformativos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnInformativos.Checked == true)
            {
                gbInformativos.Enabled = true;
                gbProcesos.Enabled = false;
                gbAnalisis.Enabled = false;
            }            
        }

        private void rbtnAnalisis_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAnalisis.Checked == true)
            {
                gbInformativos.Enabled = false;
                gbProcesos.Enabled = false;
                gbAnalisis.Enabled = true;
            }
        }
        private void rbtnProcesos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnProcesos.Checked == true)
            {
                gbInformativos.Enabled = false;
                gbProcesos.Enabled = true;
                gbAnalisis.Enabled = false;
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
         
            cboAnio_inf.DataSource = dt;
            cboAnio_inf.ValueMember = "Codigo";
            cboAnio_inf.DisplayMember = "Descripcion";
            cboAnio_inf.SelectedIndex = 3;

            cboAnio_proc.DataSource = dt;
            cboAnio_proc.ValueMember = "Codigo";
            cboAnio_proc.DisplayMember = "Descripcion";
            cboAnio_proc.SelectedIndex = 3;
        }

        private void cargar_combo_mes()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");
            DataRow dr;

            dr = dt.NewRow();
            dr["Codigo"] = "1";
            dr["Descripcion"] = "Enero";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "2";
            dr["Descripcion"] = "Febrero";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "3";
            dr["Descripcion"] = "Marzo";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "4";
            dr["Descripcion"] = "Abril";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "5";
            dr["Descripcion"] = "Mayo";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "6";
            dr["Descripcion"] = "Junio";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "7";
            dr["Descripcion"] = "Julio";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "8";
            dr["Descripcion"] = "Agosto";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "9";
            dr["Descripcion"] = "Setiembre";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "10";
            dr["Descripcion"] = "Octubre";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "11";
            dr["Descripcion"] = "Noviembre";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "12";
            dr["Descripcion"] = "Diciembre";
            dt.Rows.Add(dr);

            cboMes_inf.DataSource = dt;
            cboMes_inf.ValueMember = "Codigo";
            cboMes_inf.DisplayMember = "Descripcion";
        }

        private void cargar_combo_semana(string anio)
        {
            cboSemana_inf.DataSource = AccesoLogica.listar_semanas_anio(anio);
            cboSemana_inf.ValueMember = "codigo";
            cboSemana_inf.DisplayMember = "descripcion";
        }
        private void cargar_combo_semana_proc(string anio)
        {
            cboSemana_proc.DataSource = AccesoLogica.listar_semanas_anio(anio);
            cboSemana_proc.ValueMember = "codigo";
            cboSemana_proc.DisplayMember = "descripcion";
        }
        private void cargar_combo_planilla()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");
            DataRow dr;
            dr = dt.NewRow();

            dr["Codigo"] = "1";
            dr["Descripcion"] = "Empleados";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "2";
            dr["Descripcion"] = "Obreros - reg. Comun";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "3";
            dr["Descripcion"] = "Obreros - Const. Civil";
            dt.Rows.Add(dr);

            cboPlanilla_rep.DataSource = dt;
            cboPlanilla_rep.ValueMember = "Codigo";
            cboPlanilla_rep.DisplayMember = "Descripcion";
        }

        private void cargar_fechas(string anio, string semana)
        {
            DataTable dt = new DataTable();
            dt = AccesoLogica.listar_fechas_inifin(anio, semana);

            string fechaIni = dt.Rows[0]["fechaini"].ToString();
            string fechaFin = dt.Rows[0]["fechafin"].ToString();

            txtFechaIni_reg.Text = fechaIni;
            txtFechaFin_reg.Text = fechaFin;
        }

        private void cboAnio_rep_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_combo_semana(cboAnio_inf.SelectedValue.ToString());
        }

        private void cboAnio_proc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_combo_semana_proc(cboAnio_proc.SelectedValue.ToString());
            cargar_fechas(cboAnio_proc.SelectedValue.ToString(), cboSemana_proc.SelectedValue.ToString());  
        }

        private void cboSemana_proc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_fechas(cboAnio_proc.SelectedValue.ToString(), cboSemana_proc.SelectedValue.ToString());  
        }

        private void cboAnio_inf_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_combo_semana(cboAnio_inf.SelectedValue.ToString());
        }

        private void BW_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                dt1 = AccesoLogica.Resumen_Tareo_Formato(fechaIni, fechaFin, semana, anio, tfor, eval, dni, swtht);
            }
            catch (Exception)
            {
                //util.mensaje("ocurrió un error en el proceso ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
            }            
        }

        private void BW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            util.mensaje_espera("Cargando, por favor espere", true, lbl_contador_registros, lbl_msg, ss_load, false);
            FrmTareo_Reporte reporte = new FrmTareo_Reporte();
            reporte.dt_reporte = dt1;
            reporte.titulo_rep = titulo_rep;
            reporte.ShowDialog();

        }

        
    }
}
