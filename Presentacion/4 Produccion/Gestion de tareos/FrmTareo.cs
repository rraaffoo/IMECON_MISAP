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
    public partial class FrmTareo : Form
    {

        #region Variables globales

        public string usuario, perfil;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public DataTable dtMasivo = new DataTable();
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
        
        string horasE_trabajadas, horasE_semanales;
        double suma_horasE_trabajadas, suma_horasE_semanales;
        double maxHeDia=0, maxHeSem=0, maxHnDia=0, maxHnSem=0, maxHtDia;
        string horas_trabajadas, horas_semanales;
        string msj_usu_destino, msj_usu_ccdestino;
        string tareador="";
        string ot="";
        int anio_ctrl=0;
        int semna_ctrl=0;
        string anio_reg, semana_reg, usuario_reg, permiso_reg, ot_reg;
        int estado_reg;
        DataTable dtRegistros=new DataTable();
        
        #endregion

        #region Formulario

        public FrmTareo()
        {
            InitializeComponent();
            ts_acciones.Renderer = new MyRenderer();
            titulo.Renderer = new MyRenderer();
            cm_grilla.Renderer = new MyRenderer();
        }

        private void ninimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            if (lbl_maximi.Text == "1")
            {
                this.Location = Screen.AllScreens[0].WorkingArea.Location;
                this.Size = Screen.AllScreens[0].WorkingArea.Size;
                //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));

                lbl_maximi.Text = "0";
            }
            else
            {
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
                this.SetBounds(this.Location.X, this.Location.Y, 615, 525);
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
                this.Location = Screen.AllScreens[0].WorkingArea.Location;
                this.Size = Screen.AllScreens[0].WorkingArea.Size;
                //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));

                lbl_maximi.Text = "0";
            }
            else
            {
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
                this.SetBounds(this.Location.X, this.Location.Y, 615, 525);
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

        #region Botones

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    #region obreros

            //    if (tc_tareo.SelectedIndex == 1)
            //    {

            //        if (_perfil == "151")
            //        {

            //            int cantidad = Convert.ToInt32(AccesoLogica.validar_obrero_tareo(cbo_supervisor_obr.SelectedValue.ToString(), cbo_persaonal_obr.SelectedValue.ToString()).Rows[0]["cantidad"]);
            //            if (cantidad >= 1)
            //            {
            //                MessageBox.Show("El personal ya se encuentra asignado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            //                return;

            //            }


            //            int resultado = Negocio.asignar_obrero_tareo
            //               (cbo_supervisor_obr.SelectedValue.ToString(), cbo_persaonal_obr.SelectedValue.ToString());
            //            if (resultado == 0)
            //            {
            //                Negocio = null;

            //            }
            //        }

            //        if (_perfil == "446")
            //        {

            //            //int cantidad = Convert.ToInt32(AccesoLogica.validar_obrero_tareo(cbo_supervisor_obr_nuevo.SelectedValue.ToString(), txt_dni.Text).Rows[0]["cantidad"]);
            //            //if (cantidad >= 1)
            //            //{
            //            //    MessageBox.Show("El personal ya se encuentra asignado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            //            //    return;

            //            //}


            //            //int resultado = Negocio.asignar_obrero_tareo
            //            //   (cbo_supervisor_obr_nuevo.SelectedValue.ToString(), txt_dni.Text);
            //            //if (resultado == 0)
            //            //{
            //            //    Negocio = null;

            //            //}
            //        }

            //    }

            //    #endregion

            //    #region EDT

            //    if (tc_tareo.SelectedIndex == 2)
            //    {


            //        int resultado = Negocio.insertar_edt
            //           (txt_edt_nuevo.Text, cbo_num_ord_edt.SelectedValue.ToString());
            //        if (resultado == 0)
            //        {
            //            Negocio = null;

            //        }
            //    }


            //    #endregion

            //    #region Actividad

            //    if (tc_tareo.SelectedIndex == 3)
            //    {

            //        int resultado = Negocio.insertar_actividad_tareo
            //          (cbo_proceso.SelectedValue.ToString(), txt_actividad_nuevo.Text);
            //        if (resultado == 0)
            //        {
            //            Negocio = null;

            //        }



            //    }

            //    #endregion


            //    util.mensaje("La Operacion finalizo con exito", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
            //    btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
            //    activar_boton(false, false, false, false, false, false, false, false, false, false, false, false, true);

            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error debido a: " + ex.ToString());
            //}

        }

        //private void btn_agregar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        String proceso = cboActividad_reg.Text;
        //        String[] proceso_ = proceso.Split('-');
        //        String proceso_final = String.Empty;
        //        proceso_final += proceso_[0];

        //        //int resultado = Negocio.graba_tareo
        //                   //(txt_fecha.Text, txt_turno.Text, txt_personal.Text, cbo_num_ord.Text, txt_edt.Text, txt_proceso.Text, txt_actividad.Text, Convert.ToDecimal(txt_hn.Text), Convert.ToDecimal(txt_he.Text),
        //                   //txt_falta.Text, txt_tipo.Text, txt_usr_crea.Text, txt_fecha_inicio.Text, txt_fecha_fin.Text, txt_semana.Text, "");
        //        //if (resultado == 0) Negocio = null;


        //        //dgv_tareo.DataSource = AccesoLogica.listar_tareo(txt_anio.Text, txt_semana.Text, txt_usr_crea.Text, 0, "1");
        //        formatear_grilla();

        //        btnAgregar_reg.Enabled = false;
        //        btnAgregar_reg.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
        //        activar_boton(false, false, false, false, false, false, false, false, false, false, false, true, true);

        //        //foreach (DataGridViewRow row in dgv_detalle_hh.Rows)
        //        //{
        //        //    acum_cantidad_hh = acum_cantidad_hh + Convert.ToDecimal(row.Cells["cant_hh"].Value);
        //        //    acum_costo_hh = acum_costo_hh + Convert.ToDecimal(row.Cells["costo_hh"].Value);
        //        //}



        //        //txt_cantidad.Text = Convert.ToString(acum_cantidad_hh);
        //        //txt_costo_total.Text = Convert.ToString(acum_costo_hh);




        //        //Nos movemos hasta el ultimo registros ingresado
        //        // Utilidades.DataGridViewRowPosition(dgv_tareo);
        //    }
        //    catch (Exception er)
        //    {
        //        Console.WriteLine("{0} Exception caught.", er);
        //        MessageBox.Show("Error" + er, "Grabar Registros", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        //    }
        //}

        private void btn_suprimir_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    foreach (DataGridViewRow row in dgv_tareo.Rows)
            //    {
                  
            //        if (Convert.ToBoolean(row.Cells["seleccion"].Value))
            //        {
                      

            //            int resultado = Negocio.elimina_tareo(Convert.ToString(row.Cells["Chk"].Value));
            //            if (resultado == 0) Negocio = null;


                      

            //        }
            //    }
            //    contador = 0; 
            //    //dgv_tareo.DataSource = AccesoLogica.listar_tareo(txt_anio.Text, txt_semana.Text, txt_usr_crea.Text, 0, "1");
            //    formatear_grilla();
            //    //btn_suprimir.Enabled = false;
            //    //btn_suprimir.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_desactivado));
            //    MessageBox.Show("Operación finalizada con éxito.", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error debido a: " + ex.ToString());
            //}

        }

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
           // util.ExportarDataGridViewExcel(dgv_tareo);

            //try
            //{
            //    SaveFileDialog fichero = new SaveFileDialog();
            //    fichero.Filter = "Excel (*.xlsx)|*.xlsx";
            //    fichero.FileName = dgv_tareo.Text;

            //    if (fichero.ShowDialog() == DialogResult.OK)
            //    {
            //        Excel.Application excel = new Excel.Application();
            //        Excel._Workbook libro = null;
            //        Excel._Worksheet hoja = null;
            //        Excel.Range rango = null;

            //        libro = (Excel._Workbook)excel.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            //        hoja = (Excel._Worksheet)libro.Worksheets.Add();
            //        //   hoja.Name = "TEST";
            //        ((Excel._Worksheet)excel.ActiveWorkbook.Sheets["Hoja1"]).Delete();


            //        for (int i = 0; i < dgv_tareo.Rows.Count; i++)
            //        {
            //            for (int j = 0; j < dgv_tareo.Columns.Count; j++)
            //            {
            //                hoja.Cells[i + 2, j + 1] = dgv_tareo.Rows[i].Cells[j].Value.ToString();

            //            }
            //        }

            //        for (int z = 1; z <= dgv_tareo.Columns.Count; z++)
            //        {
            //            hoja.Cells[1, z] = dgv_tareo.Columns[z - 1].HeaderText;
            //        }




            //        libro.Saved = true;
            //        libro.SaveAs(fichero.FileName);
            //        libro.Close(true);
            //        excel.Quit();
            //        MessageBox.Show("Se genero el archivo exitosamente", "MS EXCEL", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);


            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error debido a: " + ex.ToString());
            //}
        }

        #endregion

        #region Perzonalizacion de controles

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() :
                base(new Utilidades.MyColors()) { }
        }

        private void cbo_anio_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cbo_semana_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cbo_turno_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cbo_tipo_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cbo_personal_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cbo_num_ord_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "cod_ot");
        }

        private void cbo_edt_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cbo_actividad_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }
        #endregion

        #region Funciones

        void validar_permisos(string perfil)
        {
            if (perfil == "151")
            {
                grp_tareo.Enabled = true;
                //grp_actualizar_obr.Visible = true;
                //lbl_supervisor.Visible = false;
                //cbo_supervisor.Visible = false;
                
            }

            if (perfil == "446")
            {
                grp_tareo.Enabled = false;
                //grp_nuevo_obr.Visible = true;
                //grp_nuevo_obr.Location = new Point(14, 15);
                //lbl_supervisor.Visible = true;
                //cbo_supervisor.Visible = true;
            }

           
        }

        void formatear_grilla(DataGridView grilla)
        {

            try
            {
                util.FormatearGrilla(grilla, true);
                
                                         
                lbl_contador_registros.Visible = true;
                lbl_contador_registros.Text = string.Format("Total de registros: {0}", grilla.Rows.Count);

            }

           
            catch (Exception ex)
            {
                util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;

            }
        }

        void activar_boton(bool nuevo, bool editar, bool consultar, bool eliminar, bool imprimir, bool previsualizar, bool exportar_xls, bool aprobar, bool desaprobar, bool actualizar, bool ayuda, bool grabar, bool cancelar)
        {
            btn_nuevo_b.Enabled = nuevo;
            btn_editar_b.Enabled = editar;
            btn_consultar_b.Enabled = consultar;
            btn_eliminar_b.Enabled = eliminar;
            btn_imprimir.Enabled = imprimir;
            btn_previsualizar.Enabled = previsualizar;
            btn_exportar_xls.Enabled = exportar_xls;
            btn_aprobar.Enabled = aprobar;
            btn_desaprobar.Enabled = desaprobar;
            btn_actualizar.Enabled = actualizar;
            btn_grabar.Enabled = grabar;
            btn_cancelar.Enabled = cancelar;

        }

        void limpiar()
        {
            btnAgregar_reg.Enabled = false;
            btnAgregar_reg.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
        }

        #endregion

        #region Eventos

        private void FrmTareo_Load(object sender, EventArgs e)
        {
            l_usuario.Text = usuario;
            l_dni.Text = Convert.ToString(AccesoLogica.obtener_usuario(l_usuario.Text).Rows[0][4]);
            cargar_combo_anio();        // cargar combo año         
            try
            {
                cargar_combo_semana(cboAnio_reg.SelectedValue.ToString());      // cargar combo semana        
                seleccion_semana_actual();  // asignar semana actual
                cargar_fechas(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString()); // cargar fechas de inicio y fin
            }
            catch (Exception)
            {
            }
            
            if (Negocio.verificar_autorizacion("7091", "2").Rows[0][4].ToString() == "S")
                dtpFecha_reg.Enabled = false;
            else
                dtpFecha_reg.Enabled = true;
            cargar_combo_tipo();            // cargar tipo
            maximos_horas_permitidas();
            cargar_combo_turno();    // cargar turno        
            cargar_combo_falta();      // cargar falta      
            cargar_combo_personal(l_dni.Text, "1");         // cargar personal    
            cargar_combo_ot();     // cargar ot      
            cargar_combo_actividad();   // cargar actividad
            separar_actividad();
            cargar_grid_tareo(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString(), l_usuario.Text, 1, "1", cboOt_reg.SelectedValue.ToString());         // cargar grid
            //validar_permisos(_perfil);
            //lbl_dni.Text = _dni;
            //util.FormatearFormulario_otro(this, ts_acciones, tc_tareo, ss_load, tp_auditoria);
            //tp_tareo.BackColor = Color.FromArgb(247, 247, 247);
            //tp_configuracion.BackColor = Color.FromArgb(247, 247, 247);
            //tp_edt.BackColor = Color.FromArgb(247, 247, 247);
            //tp_actividades.BackColor =  Color.FromArgb(247, 247, 247);
            //formatear_grilla();

            //validar masivo
            try
            {
                if (Negocio.verificar_autorizacion_usuario(l_usuario.Text, "Masiva").Rows[0][2].ToString() == "S")
                {
                    btnModMasiva.Enabled = true;
                    btnIngMasivo.Enabled = true;
                }
            }
            catch (Exception)
            {
                btnModMasiva.Enabled = false;
                btnIngMasivo.Enabled = false;
            }
            
            util.EstablecerAuditoria("Nuevo", usuario, "", "7091", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

         
        }

        private void seleccion_semana_actual()
        {
            cboSemana_reg.SelectedValue = Convert.ToString(AccesoLogica.obtener_semana_actual().Rows[0][0]);
        }

        private void dgvTareo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            
            string _anio = cboAnio_reg.SelectedValue.ToString();
            string _semana = cboSemana_reg.SelectedValue.ToString();
            string _usuarioCrea = l_usuario.Text;
            string _dni = dgvTareo.Rows[e.RowIndex].Cells["DNI"].Value.ToString();
            string _fecha = dgvTareo.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
            string _ot = dgvTareo.Rows[e.RowIndex].Cells["Num_OT"].Value.ToString();
            if (Convert.ToString(AccesoLogica.obtener_estTareo(_anio, _semana, _usuarioCrea).Rows[0][0]) != "0")
            {
                util.mensaje("Solo es posible modificar si el tareo está EN PROCESO", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }

            //verificar semana cerrada
            try
            {
                if (Negocio.verificar_semana_cerrada(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString()).Rows.Count > 0)
                {
                    util.mensaje("Semana Cerrada, contactar al Administrador de Personal", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    return;
                }
            }
            catch (Exception)
            {
            }
            if (!verificar_holgura())
            {
                return;
            } 

            FrmTareo_Mod Modifica = new FrmTareo_Mod();
            Modifica.mod_Anio = _anio;
            Modifica.mod_Sem = _semana;
            Modifica.mod_UsrCrea = _usuarioCrea;
            Modifica.mod_CodTrab = _dni;
            Modifica.mod_FechTrab = _fecha;
            Modifica.mod_Ot = _ot;
            Modifica.FormClosed += new FormClosedEventHandler(Modifica_FormClosed);
            Modifica.ShowDialog();
        }
        private void Modifica_FormClosed(object sender, FormClosedEventArgs e)
        {
            // cargar grid
            cargar_grid_tareo(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString(), l_usuario.Text, 1, "1", "00000");   

        }

        private void cargar_grid_tareo(string anio, string semana, string usuario, int estado, string permiso, string ot)
        {
            if (!BW_reg.IsBusy)
            {
                anio_reg = anio;
                semana_reg = semana;
                usuario_reg = usuario;
                estado_reg = estado;
                permiso_reg = permiso;
                ot_reg = ot;
                dgvTareo.DataSource = null;
                txt_buscar.Enabled = false;
                util.mensaje_espera("Cargando, por favor espere", true, lbl_contador_registros, lbl_msg, ss_load,true);
                BW_reg.RunWorkerAsync();
            } 
        }

        private void BW_reg_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                dtRegistros = AccesoLogica.listar_grilla_tareo(anio_reg, semana_reg, usuario_reg, estado_reg, permiso_reg, ot_reg);
            }
            catch (Exception)
            {
                //util.mensaje("ocurrió un error en el proceso ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
            }
        }

        private void BW_reg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvTareo.DataSource = dtRegistros;
            util.mensaje_espera("Cargando, por favor espere", true, lbl_contador_registros, lbl_msg, ss_load,false);
            mostrar_totales();
            formatear_grilla(dgvTareo);
        }


        private void separar_actividad()
        {
            string cadena = cboActividad_reg.SelectedValue.ToString();
            string[] datos;
            datos = cadena.Split('|');
            txtproc.Text = datos[0].ToString();
            txtact.Text = datos[1].ToString();
        }

        private void cargar_combo_actividad()
        {
            cboActividad_reg.DataSource = AccesoLogica.listar_combo_actividad();
            cboActividad_reg.ValueMember = "codigo";
            cboActividad_reg.DisplayMember = "descripcion";
        }

        private void cargar_combo_edt(string ot)
        {
            cboEdt_reg.DataSource = AccesoLogica.listar_combo_edt(ot);
            cboEdt_reg.ValueMember = "codigo";
            cboEdt_reg.DisplayMember = "descripcion";
        }

        private void cargar_combo_personal(string dni, string origen)
        {
            cboPersonal_reg.DataSource = AccesoLogica.listar_combo_personal(dni, origen);
            cboPersonal_reg.ValueMember = "codigo";
            cboPersonal_reg.DisplayMember = "descripcion";
        }

        private void cargar_combo_ot()
        {
            cboOt_reg.DataSource = AccesoLogica.listar_combo_ot();
            cboOt_reg.ValueMember = "codigo";
            cboOt_reg.DisplayMember = "descripcion";
        }

        private void cargar_combo_falta()
        {
            cboFalta_reg.DataSource = AccesoLogica.listar_combo_falta();
            cboFalta_reg.ValueMember = "codigo";
            cboFalta_reg.DisplayMember = "descripcion";
        }

        private void cargar_combo_turno()
        {
            cboTurno_reg.DataSource = AccesoLogica.listar_combo_turno();
            cboTurno_reg.ValueMember = "codigo";
            cboTurno_reg.DisplayMember = "descripcion";
        }

        private void cargar_fechas(string anio, string semana)
        {
            DataTable dt = new DataTable();
            dt = AccesoLogica.listar_fechas_inifin(anio, semana);

            string fechaIni  = dt.Rows[0]["fechaini"].ToString();
            string fechaFin = dt.Rows[0]["fechafin"].ToString();
            dtpFecha_reg.MinDate = System.DateTime.Now.AddYears(-5);
            dtpFecha_reg.MaxDate = System.DateTime.Now.AddYears(5);
            dtpFecha_reg.Value = Convert.ToDateTime(fechaIni);            
            dtpFecha_reg.MinDate = Convert.ToDateTime(fechaIni);
            dtpFecha_reg.MaxDate = Convert.ToDateTime(fechaFin);
            
            txtFechaIni_reg.Text = fechaIni;
            txtFechaFin_reg.Text = fechaFin;
            maximos_horas_permitidas();
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
            cboAnio_reg.DataSource = dt;
            cboAnio_reg.ValueMember = "Codigo";
            cboAnio_reg.DisplayMember = "Descripcion";
            cboAnio_reg.SelectedIndex = 3;
        }

        private void cargar_combo_semana(string anio)
        {
            cboSemana_reg.DataSource = AccesoLogica.listar_semanas_anio(anio);
            cboSemana_reg.ValueMember = "codigo"; 
            cboSemana_reg.DisplayMember = "descripcion";
        }

        private void cargar_combo_tipo()
        {
            cboTipo_reg.DataSource = AccesoLogica.listar_combo_tipo();
            cboTipo_reg.ValueMember = "codigo"; 
            cboTipo_reg.DisplayMember = "descripcion";
        }
        
        private void cboAnio_reg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_combo_semana(cboAnio_reg.SelectedValue.ToString());
            cargar_fechas(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString());
            cargar_grid_tareo(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString(), l_usuario.Text, 1, "1", "00000");
        }
        
        

        private void cboSemana_reg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_fechas(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString());
            cargar_grid_tareo(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString(), l_usuario.Text, 1, "1", "00000");
        }

        

        private void cbo_supervisor_obr_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
            activar_boton(false, false, false, false, false, false, false, false, false, false, false, true, true);
        }

        private void cbo_supervisor_obr_nuevo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
            activar_boton(false, false, false, false, false, false, false, false, false, false, false, true, true);
        }

        private void txt_edt_nuevo_TextChanged(object sender, EventArgs e)
        {
            if (txt_edt_nuevo.TextLength > 0)
            {
                btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                activar_boton(false, false, false, false, false, false, false, false, false, false, false, true, true);

            }
        }

        private void txt_actividad_nuevo_TextChanged(object sender, EventArgs e)
        {
            if (txt_actividad_nuevo.TextLength > 0)
            {
                btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                activar_boton(false, false, false, false, false, false, false, false, false, false, false, true, true);

            }
        }

        private void txt_he_TextChanged(object sender, EventArgs e)
        {
            if (cboPersonal_reg.SelectedValue.ToString() == "00000")
            {
                util.mensaje("Debe seleccionar un personal para realizar esta operación", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txtHe.Text = "0";
                return;
            }

            if (cboTipo_reg.SelectedValue.ToString() == "00000")
            {
                util.mensaje("Debe seleccionar un Tipo de día para realizar esta operación", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txtHn.Text = "0";
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
                if (!validar_horas_extra())
                {
                    return;
                }

            }
        }

        private Boolean validar_horas_extra()
        {
            horasE_trabajadas = Convert.ToString(AccesoLogica.validar_horas_semanales(cboPersonal_reg.SelectedValue.ToString(), dtpFecha_reg.Value.ToShortDateString(), txtFechaIni_reg.Text, txtFechaFin_reg.Text, l_usuario.Text).Rows[0][1]);
            horasE_semanales = Convert.ToString(AccesoLogica.validar_horas_semanales(cboPersonal_reg.SelectedValue.ToString(), dtpFecha_reg.Value.ToShortDateString(), txtFechaIni_reg.Text, txtFechaFin_reg.Text, l_usuario.Text).Rows[0][3]);

            suma_horasE_trabajadas = float.Parse(horasE_trabajadas, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + float.Parse(txtHe.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"));
            suma_horasE_semanales = float.Parse(horasE_semanales, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + float.Parse(txtHe.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"));

            if (Convert.ToDouble(suma_horasE_trabajadas) > maxHeDia)
            {
                util.mensaje("no puede ingresar horas extra mayor a " + maxHeDia, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txtHe.Text="0";
                txtHe.SelectionStart = 0;
                txtHe.SelectionLength = txtHn.Text.Length;
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

        private void dgv_tareo_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvTareo.IsCurrentCellDirty)
            {
                dgvTareo.CommitEdit(DataGridViewDataErrorContexts.Commit);

            }
        }

        private void cbo_anio_Enter(object sender, EventArgs e)
        {
            cboAnio_reg.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cbo_anio_Leave(object sender, EventArgs e)
        {
            cboAnio_reg.BackColor = Color.White;
        }

        private void cbo_semana_Enter(object sender, EventArgs e)
        {
            cboSemana_reg.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cbo_semana_Leave(object sender, EventArgs e)
        {
            cboSemana_reg.BackColor = Color.White;
        }

       private void dp_fecha_Enter(object sender, EventArgs e)
        {

        }

        private void dp_fecha_Leave(object sender, EventArgs e)
        {
            
        }

        private void cbo_turno_Enter(object sender, EventArgs e)
        {
            cboTurno_reg.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cbo_turno_Leave(object sender, EventArgs e)
        {
            cboTurno_reg.BackColor = Color.White;
        }

        private void cbo_turno_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void cbo_tipo_Enter(object sender, EventArgs e)
        {
            cboTipo_reg.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cbo_tipo_Leave(object sender, EventArgs e)
        {
            cboTipo_reg.BackColor = Color.White;
        }

        private void cbo_tipo_MouseClick(object sender, MouseEventArgs e)
        {
        }
        private void cboFalta_reg_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboFalta_reg_Enter(object sender, EventArgs e)
        {
            cboFalta_reg.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboFalta_reg_Leave(object sender, EventArgs e)
        {
            cboFalta_reg.BackColor = Color.White;
        }
        private void cbo_personal_Enter(object sender, EventArgs e)
        {
            cboPersonal_reg.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cbo_personal_Leave(object sender, EventArgs e)
        {
            cboPersonal_reg.BackColor = Color.White;
        }

        private void cbo_num_ord_Enter(object sender, EventArgs e)
        {
            cboOt_reg.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cbo_num_ord_Leave(object sender, EventArgs e)
        {
            cboOt_reg.BackColor = Color.White;
        }

        private void cbo_num_ord_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void cbo_edt_Enter(object sender, EventArgs e)
        {
            cboEdt_reg.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cbo_edt_Leave(object sender, EventArgs e)
        {
            cboEdt_reg.BackColor = Color.White;
        }

        private void cbo_edt_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void cbo_actividad_Enter(object sender, EventArgs e)
        {
            cboActividad_reg.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cbo_actividad_Leave(object sender, EventArgs e)
        {
            cboActividad_reg.BackColor = Color.White;
        }

        private void cbo_actividad_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void txt_hn_Enter(object sender, EventArgs e)
        {
            txtHn.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txtHn.Text))
            {
                txtHn.SelectionStart = 0;
                txtHn.SelectionLength = txtHn.Text.Length;
            }
        }

        private void txt_hn_Leave(object sender, EventArgs e)
        {
            txtHn.BackColor = Color.White;
            txtHe.Enabled = true;
            txtHe.Focus();
        }

        private void txt_hn_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtHn.Text))
            {
                txtHn.SelectionStart = 0;
                txtHn.SelectionLength = txtHn.Text.Length;
            }
        }

        private void txt_he_Enter(object sender, EventArgs e)
        {
          

            txtHe.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txtHe.Text))
            {
                txtHe.SelectionStart = 0;
                txtHe.SelectionLength = txtHe.Text.Length;
            }
        }

        private void txt_he_Leave(object sender, EventArgs e)
        {
            txtHe.BackColor = Color.White;
        }

        private void txt_he_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtHe.Text))
            {
                txtHe.SelectionStart = 0;
                txtHe.SelectionLength = txtHe.Text.Length;
            }
        }


        #endregion

        #region Menu contextual

        private void cm_grilla_copia_tabla_Click(object sender, EventArgs e)
        {
            util.copiar_todo_encabezados(dgvTareo);
        }

        private void cm_grilla_copia_Click(object sender, EventArgs e)
        {
            util.copiar_contextual(dgvTareo);
        }

        #endregion

        private void dgv_tareo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (dgvTareo.Columns[e.ColumnIndex].Name == "seleccion")
            {
                DataGridViewRow row = dgvTareo.Rows[e.RowIndex];
                DataGridViewCheckBoxCell cellSelecion = row.Cells["seleccion"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(cellSelecion.Value))
                {
                        contador = contador + 1;
                        if (contador != 0)
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(252, 221, 130);
                        }   
                }
                else
                {
                    contador = contador - 1;
                    if (contador == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(231, 231, 231);
                    }
                    
                }
            }

        }

        private void dgv_tareo_CurrentCellDirtyStateChanged_1(object sender, EventArgs e)
        {
            if (dgvTareo.IsCurrentCellDirty)
            {
                dgvTareo.CommitEdit(DataGridViewDataErrorContexts.Commit);

            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            validar_permisos(perfil);
        }

        private void t_msg_Tick(object sender, EventArgs e)
        {
            lbl_msg.Text = string.Empty;
            ss_load.BackColor = Color.Transparent;
            lbl_contador_registros.Visible = true;
            lbl_msg.Visible = false;
        }

        private void txt_hn_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validar_numeros(txtHn, e);
            if (e.KeyChar == 13)
            {
                txtHe.Focus();
            }
        }

      

        private void cboOt_reg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // cargar combo EDT
            cargar_combo_edt(cboOt_reg.SelectedValue.ToString());
            cboEdt_reg.SelectedItem = null;
            cboEdt_reg.Enabled = true;
            cboEdt_reg.Focus();
        }

        private void txtHn_TextChanged(object sender, EventArgs e)
        {
            if (cboPersonal_reg.SelectedValue.ToString() == "00000")
            {
                util.mensaje("Debe seleccionar un personal para realizar esta operación", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txtHn.Text = "0";
                return;
            }
            if (cboTipo_reg.SelectedValue.ToString() == "00000")
            {
                util.mensaje("Debe seleccionar un Tipo de día para realizar esta operación", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txtHn.Text = "0";
                return;
            }
            

            if ( txtHn.Text.Length == 1)
            {
                if (txtHn.Text ==".")
                {
                    txtHn.Text = "0.";
                    txtHn.Select(txtHn.Text.Length, 0);
                }
            }
            if (txtHn.Text != string.Empty)
            {
                try
                {
                    if (!validar_horas_normales())
                        return;

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

        

        private Boolean validar_horas_normales()
        {
            horas_trabajadas = Convert.ToString(AccesoLogica.validar_horas_semanales(cboPersonal_reg.SelectedValue.ToString(), dtpFecha_reg.Value.ToShortDateString(), txtFechaIni_reg.Text, txtFechaFin_reg.Text, l_usuario.Text).Rows[0][0]);
            horas_semanales = Convert.ToString(AccesoLogica.validar_horas_semanales(cboPersonal_reg.SelectedValue.ToString(), dtpFecha_reg.Value.ToShortDateString(), txtFechaIni_reg.Text, txtFechaFin_reg.Text, l_usuario.Text).Rows[0][2]);

            suma_horas_trabajadas = float.Parse(horas_trabajadas, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + float.Parse(txtHn.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"));
            suma_horas_semanales = float.Parse(horas_semanales, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + float.Parse(txtHn.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"));

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

        private void btnAgregar_reg_Click(object sender, EventArgs e)
        {
            string estTareo="";
            if (cboPersonal_reg.SelectedValue.ToString()=="00000" || cboOt_reg.SelectedValue.ToString()=="00000")
            {
                util.mensaje("Debe seleccionar un personal y una OT para ralizar esta operación", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
            //verificar semana cerrada
            try
            {
                if (Negocio.verificar_semana_cerrada(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString()).Rows.Count > 0)
                {
                    util.mensaje("Semana Cerrada, contactar al Administrador de Personal", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    return;
                }
            }
            catch (Exception)
            {
            }
            //verificar holgura
            if (!verificar_holgura())
            {
                return;
            } 
            //verificar switch de asistencia
            try
            {
                if (Negocio.verificar_autorizacion_usuario(l_usuario.Text,"Asistencia").Rows[0][2].ToString()=="S")
                {                
                    if (Negocio.verificar_asistencia(cboPersonal_reg.SelectedValue.ToString(), dtpFecha_reg.Value.ToShortDateString()).Rows.Count <= 0)
                    {
                        DialogResult resul = MessageBox.Show("personal: " + cboPersonal_reg.SelectedText.ToString() + "  no tiene asistencia en fecha: " + dtpFecha_reg.Value.ToShortDateString() + ". ¿Desea ingresar con Horas trabajadas en CERO?", "PRECAUCIÓN", MessageBoxButtons.YesNo);
                        if (resul == DialogResult.No)
                        {
                            return;
                        }
                        else
                        {
                            txtHn.Text = "0";
                            txtHe.Text = "0";
                        }
                    }
                }
            }
            catch (Exception)
            {
                DialogResult resul = MessageBox.Show("personal: " + cboPersonal_reg.SelectedText.ToString() + "  no tiene asistencia en fecha: " + dtpFecha_reg.Value.ToShortDateString() + ". ¿Desea ingresar con Horas trabajadas en CERO?", "PRECAUCIÓN", MessageBoxButtons.YesNo);
                if (resul == DialogResult.No)
                {
                    return;
                }
                else
                {
                    txtHn.Text = "0";
                    txtHe.Text = "0";
                }
            }

            try
            {
                estTareo = Convert.ToString(AccesoLogica.obtener_estTareo(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString(), usuario).Rows[0][0]);
            }
            catch (Exception)
            {
                estTareo = "0";
            }
            
            if (estTareo == "0")
            {
                txt1.Text = dtpFecha_reg.Value.ToShortDateString();
                txt2.Text = cboTurno_reg.SelectedValue.ToString();
                txt3.Text = cboPersonal_reg.SelectedValue.ToString();
                txt4.Text = cboOt_reg.SelectedValue.ToString();
                if (txt4.Text.Substring(0, 3) == "OTF" || txt4.Text.Substring(0, 3) == "OTM")
                {
                    txt4.Text = string.Concat("20", txt4.Text.Substring(3, 5));
                }
                if (cboEdt_reg.SelectedValue == null)
                    txt5.Text = "";
                else
                    txt5.Text = cboEdt_reg.SelectedValue.ToString();
                txt6.Text = txtproc.Text;
                txt7.Text = txtact.Text;
                txt8.Text = txtHn.Text;
                txt9.Text = txtHe.Text;
                txt10.Text = cboFalta_reg.SelectedValue.ToString();
                txt11.Text = cboTipo_reg.SelectedValue.ToString();
                txt12.Text = l_usuario.Text;
                txt13.Text = txtFechaIni_reg.Text;
                txt14.Text = txtFechaFin_reg.Text;
                txt15.Text = cboSemana_reg.SelectedValue.ToString();
                txt16.Text = "";

                if (AccesoLogica.grabar_tareo(txt1.Text, txt2.Text, txt3.Text, txt4.Text, txt5.Text, txt6.Text, txt7.Text, txt8.Text, txt9.Text, txt10.Text, txt11.Text, txt12.Text, txt13.Text, txt14.Text, txt15.Text, txt16.Text) != 0)
                {
                    util.mensaje("Registro grabado exitosamente", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    cargar_grid_tareo(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString(), l_usuario.Text, 1, "1", "00000");
                }
                else
                {
                    util.mensaje("Error al grabar el registro", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                }
            }
            else
            {
                util.mensaje("No es posible agregar registros a un tareo REVISADO o APROBADO", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
            }
        }

        private bool verificar_holgura()
        {
            try
            {
                int holgura = Convert.ToInt32(Negocio.verificar_autorizacion_usuario(l_usuario.Text, "Holgura").Rows[0][2].ToString());
                DateTime oldDate = dtpFecha_reg.Value;
                DateTime newDate = DateTime.Now;
                TimeSpan ts = newDate - oldDate;

                if (ts.Days + 1 > holgura)
                {
                    util.mensaje("Holgura no permitida. No se puede realizar esta operación.", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                util.mensaje("Holgura no permitida. No se puede realizar esta operación.", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return false;
            }
        }

        private void btnRevisar_reg_Click(object sender, EventArgs e)
        {
            string estTareo;
            if (dgvTareo.Rows.Count<=0)
            {
                util.mensaje("No es posible realizar esta operación", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
            //verificar semana cerrada
            try
            {
                if (Negocio.verificar_semana_cerrada(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString()).Rows.Count > 0)
                {
                    util.mensaje("Semana Cerrada, contactar al Administrador de Personal", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    return;
                }
            }
            catch (Exception)
            {
            }

            try
            {
                estTareo = Convert.ToString(AccesoLogica.obtener_estTareo(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString(), l_usuario.Text).Rows[0][0]);
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
                    AccesoLogica.revisar_tareo(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString(), l_usuario.Text, "1", l_usuario.Text);
                    util.mensaje("La revisión se realizó con éxito", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    cargar_grid_tareo(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString(), l_usuario.Text, 1, "1", "00000");
                    EnviarEmail(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString(), l_usuario.Text, "1"); 
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

        private void btnSubirArch_reg_Click(object sender, EventArgs e)
        {
            FrmTareo_Importar abrir = new FrmTareo_Importar();
            abrir.anio = cboAnio_reg.SelectedValue.ToString();
            abrir.semana = cboSemana_reg.SelectedValue.ToString();
            abrir.fecha_inicio = txtFechaIni_reg.Text;
            abrir.fecha_fin = txtFechaFin_reg.Text;
            abrir.tareador = l_dni.Text;
            abrir.ShowDialog();            
        }

        private void txtHe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAgregar_reg.Focus();
            }
        }

        private void btnAnular_reg_Click(object sender, EventArgs e)
        {
            if (dgvTareo.Rows.Count <= 0)
            {
                util.mensaje("No es posible realizar esta operación", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
            
            string estTareo = Convert.ToString(AccesoLogica.obtener_estTareo(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString(), usuario).Rows[0][0]);
            if (estTareo == "0")
            {
                DialogResult resul = MessageBox.Show("¿Está seguro que quiere anular este tareo?", "Anular Tareo", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    if (AccesoLogica.anular_tareo(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString(), l_usuario.Text, "A", l_usuario.Text) != 0)
                    {
                        util.mensaje("Anulación exitosa", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                        cargar_grid_tareo(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString(), l_usuario.Text, 1, "1", "00000");
                    }
                    else
                    {
                        util.mensaje("Error en la Anulación", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    }
                }
            }
            else
            {
                util.mensaje("No es posible anular un tareo REVISADO o APROBADO", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
            }
        }

        private void btnBuscar_reg_Click(object sender, EventArgs e)
        {
            dgvTareo.DataSource = null;
            string ot = cboOt_reg.SelectedValue.ToString();
            cargar_grid_tareo(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString(), l_usuario.Text, 1, "1", ot);
            //dgvTareo.DataSource = AccesoLogica.listar_grilla_tareo(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString(), l_usuario.Text, 1, "1", ot);
        }

        private void dgvTareo_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvTareo.Rows.Count > 0)
            {
                txt_buscar.Enabled = true;
                txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
                txt_buscar.Focus();
                txt_buscar.Clear();

                filtro = dgvTareo.Columns[e.ColumnIndex].HeaderText;
                lbl_buscar.Text = "Buscar en " + filtro;

                dgvTareo.CurrentCell = dgvTareo.Rows[0].Cells[e.ColumnIndex];
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            (dgvTareo.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" + " ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
            lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgvTareo.Rows.Count);
            mostrar_totales();
        }

        private void btnModMasiva_Click(object sender, EventArgs e)
        {
            if (dgvTareo.Rows.Count <= 0)
            {
                util.mensaje("No es posible realizar esta operación", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
            if (AccesoLogica.obtener_estTareo(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString(), l_usuario.Text).Rows[0][0].ToString() != "0")
            {
                util.mensaje("Para modificar, el tareo debe estar EN PROCESO", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }

            //verificar semana cerrada
            try
            {
                if (Negocio.verificar_semana_cerrada(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString()).Rows.Count > 0)
                {
                    util.mensaje("Semana Cerrada, contactar al Administrador de Personal", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    return;
                }
            }
            catch (Exception)
            {
            }

            FrmTareo_ModMasiva masivo = new FrmTareo_ModMasiva();
            masivo.masiv_Anio = cboAnio_reg.SelectedValue.ToString();
            masivo.masiv_Sem = cboSemana_reg.SelectedValue.ToString();
            masivo.masiv_UsrCrea = l_usuario.Text;
            masivo.FormClosed += new FormClosedEventHandler(masivo_FormClosed);
            masivo.ShowDialog();
        }
        private void masivo_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargar_grid_tareo(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString(), l_usuario.Text, 1, "1", "00000");   
        }

        private void cboTipo_reg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtHn.Text = "0";
            txtHe.Text = "0";
            maximos_horas_permitidas();
        }

        private void maximos_horas_permitidas()
        {
            if (txtFechaIni_reg.Text=="" || txtFechaFin_reg.Text=="")
            {
                util.mensaje("Seleccione una semana válida", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
            DataTable dtHoras = Negocio.listar_configuracion_horas();
            DateTime oldDate = Convert.ToDateTime(txtFechaIni_reg.Text);
            DateTime newDate = Convert.ToDateTime(txtFechaFin_reg.Text);
            TimeSpan ts = newDate - oldDate;

            int diferenciaDias = 0;
            if (ts.Days+1>7)
	        {
		        diferenciaDias = ts.Days-6;
	        }

            if (cboTipo_reg.SelectedValue.ToString() == "00" || cboTipo_reg.SelectedValue.ToString() == "03") //dia normal o dia bajada
            {
                maxHnDia = float.Parse(dtHoras.Rows[0][0].ToString() == string.Empty ? "0" : dtHoras.Rows[0][0].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"));  //8.5;
                maxHnSem = float.Parse(dtHoras.Rows[0][3].ToString() == string.Empty ? "0" : dtHoras.Rows[0][3].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + (diferenciaDias * float.Parse(dtHoras.Rows[0][5].ToString() == string.Empty ? "0" : dtHoras.Rows[0][5].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"))); // 65; //48;
                maxHeDia = float.Parse(dtHoras.Rows[0][1].ToString() == string.Empty ? "0" : dtHoras.Rows[0][1].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")); //6.5;
                maxHeSem = float.Parse(dtHoras.Rows[0][4].ToString() == string.Empty ? "0" : dtHoras.Rows[0][4].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + (diferenciaDias * float.Parse(dtHoras.Rows[0][6].ToString() == string.Empty ? "0" : dtHoras.Rows[0][6].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"))); //35; // 25;
                maxHtDia = float.Parse(dtHoras.Rows[0][2].ToString() == string.Empty ? "0" : dtHoras.Rows[0][2].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")); //15;
            }
            if (cboTipo_reg.SelectedValue.ToString() == "01" || cboTipo_reg.SelectedValue.ToString() == "02") //dia descanso o feriado
            {
                maxHnDia = float.Parse(dtHoras.Rows[0][7].ToString() == string.Empty ? "0" : dtHoras.Rows[0][7].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")); //0;
                maxHnSem = float.Parse(dtHoras.Rows[0][10].ToString() == string.Empty ? "0" : dtHoras.Rows[0][10].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + (diferenciaDias * float.Parse(dtHoras.Rows[0][12].ToString() == string.Empty ? "0" : dtHoras.Rows[0][12].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"))); //65; // 48;
                maxHeDia = float.Parse(dtHoras.Rows[0][8].ToString() == string.Empty ? "0" : dtHoras.Rows[0][8].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")); //10;
                maxHeSem = float.Parse(dtHoras.Rows[0][11].ToString() == string.Empty ? "0" : dtHoras.Rows[0][11].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + (diferenciaDias * float.Parse(dtHoras.Rows[0][13].ToString() == string.Empty ? "0" : dtHoras.Rows[0][13].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"))); //35; //25;
                maxHtDia = float.Parse(dtHoras.Rows[0][9].ToString() == string.Empty ? "0" : dtHoras.Rows[0][9].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")); //10;
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
           "<br/>" + "El tareo correspondiente al usuario: " + msj_usuario + ", año: " + msj_anio + ", semana: " + msj_semana +"\r\n" +
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

        private void cboActividad_reg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            separar_actividad();
        }

        private void cboPersonal_reg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void cboOt_reg_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboOt_reg_Enter(object sender, EventArgs e)
        {
            cboOt_reg.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboOt_reg_Leave(object sender, EventArgs e)
        {
            cboOt_reg.BackColor = Color.White;
        }

        private void btnIngMasivo_Click(object sender, EventArgs e)
        {
            string estTareo="";
            if (dgvTareo.Rows.Count > 0)
	            estTareo = Convert.ToString(AccesoLogica.obtener_estTareo(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString(), usuario).Rows[0][0]);
            else
                estTareo = "0";

            if (estTareo != "0")
            {
                util.mensaje("No es posible agregar registros a un tareo REVISADO o APROBADO", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }

            //verificar semana cerrada
            try
            {
                if (Negocio.verificar_semana_cerrada(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString()).Rows.Count > 0)
                {
                    util.mensaje("Semana Cerrada, contactar al Administrador de Personal", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    return;
                }
            }
            catch (Exception)
            {
            }

            FrmTareo_IngresoMasivo ingMasivo = new FrmTareo_IngresoMasivo();
            ingMasivo.usuario = l_usuario.Text;
            ingMasivo.dni = l_dni.Text;
            ingMasivo.vAnio = cboAnio_reg.SelectedValue.ToString();
            ingMasivo.vSemana = cboSemana_reg.SelectedValue.ToString();
            ingMasivo.vfecha = dtpFecha_reg.Value.ToShortDateString();
            ingMasivo.vTurno = cboTurno_reg.SelectedValue.ToString();
            ingMasivo.vTipo = cboTipo_reg.SelectedValue.ToString();
            ingMasivo.vFalta = cboFalta_reg.SelectedValue.ToString();
            ingMasivo.vOt = cboOt_reg.SelectedValue.ToString();
            try
            {
                ingMasivo.vEdt = cboEdt_reg.SelectedValue.ToString();
            }
            catch (Exception)
            {
                ingMasivo.vEdt = "";
            }
            
            ingMasivo.vActividad = cboActividad_reg.SelectedValue.ToString();
            ingMasivo.vHn = txtHn.Text;
            ingMasivo.vHe = txtHe.Text;
            ingMasivo.FormClosed += new FormClosedEventHandler(ingMasivo_FormClosed);
            ingMasivo.ShowDialog();
        }

        private void ingMasivo_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargar_grid_tareo(cboAnio_reg.SelectedValue.ToString(), cboSemana_reg.SelectedValue.ToString(), l_usuario.Text, 1, "1", cboOt_reg.SelectedValue.ToString());
        }

        private void mostrar_totales()
        {
            DataTable dt = dgv_a_dt(dgvTareo, false);
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
        

    }
}
