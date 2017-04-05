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
using System.Diagnostics;
//using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing.Text;
using System.Windows.Controls;



namespace MISAP
{
    public partial class FrmTareo_Mod : Form
    {
        public string mod_Anio="";
        public string mod_Sem = "";
        public string mod_UsrCrea = "";
        public string mod_CodTrab = "";
        public string mod_FechTrab = "";
        public string mod_Ot = "";
        

        #region Variables globales
        public string _usuario, _perfil, _dni;
        #endregion

        #region Variables locales

        

        private Point pos = Point.Empty;
        private bool move = false;
        bool allowSelect = false;

        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();
        string filtro, cod_ot;
        int contador;
        double maxHeDia = 0, maxHeSem = 0, maxHnDia = 0, maxHnSem = 0, maxHtDia;
        string horasE_trabajadas, horasE_semanales, horas_trabajadas, horas_semanales;
        double suma_horasE_trabajadas=0, suma_horasE_semanales=0, suma_horas_trabajadas=0, suma_horas_semanales=0;


        #endregion

        #region Formulario

        public FrmTareo_Mod()
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

        #region Botones
        
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

        
        #endregion

        #region Funciones

        void validar_permisos(string perfil)
        {
            if (perfil == "151")
            {
                //grp_tareo.Enabled = true;
                //grp_actualizar_obr.Visible = true;
                //lbl_supervisor.Visible = false;
                //cbo_supervisor.Visible = false;
                
            }

            if (perfil == "446")
            {
                //grp_tareo.Enabled = false;
                //grp_nuevo_obr.Visible = true;
                //grp_nuevo_obr.Location = new Point(14, 15);
                //lbl_supervisor.Visible = true;
                //cbo_supervisor.Visible = true;
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
            //btnImportar.Enabled = grabar;
            //btnCancelar.Enabled = cancelar;

        }

        void limpiar()
        {
            //txt_semana.Clear();
            //txt_turno.Clear();
            //txt_personal.Clear();
            //txt_edt.Clear();
            //txt_tipo.Clear();
            //txt_falta.Clear();
            //txt_proceso.Clear();
            //txt_actividad.Clear();
            //txt_anio.Clear();
            //txt_supervisor.Clear();
            //txt_fecha.Clear();

            //btnAgregar_reg.Enabled = false;
            //btnAgregar_reg.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
        }

        #endregion

        #region Eventos
        private void FrmTareo_Mod_Load(object sender, EventArgs e)
        {
            // cargar turno
            cargar_combo_turno();
            // cargar ot
            cargar_combo_ot();
            // cargar tipo
            cargar_combo_tipo();
            // cargar falta
            cargar_combo_falta();
            // cargar EDT
            //cargar_combo_edt();
            // cargar actividad
            cargar_combo_actividad();
            separar_actividad();

            DataTable dt= AccesoLogica.Buscar_registro(mod_Anio, mod_Sem, mod_UsrCrea, mod_CodTrab, mod_FechTrab, mod_Ot);
            lblNombres_mod.Text = dt.Rows[0]["Nombre"].ToString();
            lblDni_mod.Text = dt.Rows[0]["dni"].ToString();
            lblFecha_mod.Text = Convert.ToDateTime(dt.Rows[0]["fecha"].ToString()).ToShortDateString();
            cboTurno_mod.SelectedValue = dt.Rows[0]["turno"].ToString();
            //cboOt_mod.SelectedValue = dt.Rows[0]["ot"].ToString();
            cboTipo_mod.SelectedValue = dt.Rows[0]["tipo"].ToString();
            cboFalta_mod.SelectedValue = dt.Rows[0]["falta"].ToString();
            //cboEdt_mod.SelectedValue = dt.Rows[0]["edt"].ToString();
            cboActividad_mod.SelectedValue = dt.Rows[0]["actividad"].ToString();
            txtHn_mod.Text = dt.Rows[0]["hor_trab"].ToString().Replace(",",".");
            txtHe_mod.Text = dt.Rows[0]["hor_extr"].ToString().Replace(",", ".");
            txtHe_old.Text = txtHe_mod.Text;
            txthn_old.Text = txtHn_mod.Text;
            maximos_horas_permitidas();
            string cadena = cboActividad_mod.SelectedValue.ToString();
            string[] datos;
            datos = cadena.Split('|');
            txtproc.Text = datos[0].ToString();
            txtact.Text = datos[1].ToString();
        }
        private void cargar_combo_turno()
        {
            cboTurno_mod.DataSource = AccesoLogica.listar_combo_turno();
            cboTurno_mod.ValueMember = "codigo";
            cboTurno_mod.DisplayMember = "descripcion";
        }
        
        private void cargar_combo_ot()
        {
            //cboOt_mod.DataSource = AccesoLogica.listar_combo_ot();
            //cboOt_mod.ValueMember = "codigo";
            //cboOt_mod.DisplayMember = "codigo";
        }

        private void cargar_combo_tipo()
        {
            cboTipo_mod.DataSource = AccesoLogica.listar_combo_tipo();
            cboTipo_mod.ValueMember = "codigo";
            cboTipo_mod.DisplayMember = "descripcion";
        }

        private void cargar_combo_falta()
        {
            cboFalta_mod.DataSource = AccesoLogica.listar_combo_falta();
            cboFalta_mod.ValueMember = "codigo";
            cboFalta_mod.DisplayMember = "descripcion";
        }

        private void separar_actividad()
        {
            string cadena = cboActividad_mod.SelectedValue.ToString();
            string[] datos;
            datos = cadena.Split('|');
            txtproc.Text = datos[0].ToString();
            txtact.Text = datos[1].ToString();
        }

        private void cargar_combo_actividad()
        {
            cboActividad_mod.DataSource = AccesoLogica.listar_combo_actividad();
            cboActividad_mod.ValueMember = "codigo";
            cboActividad_mod.DisplayMember = "descripcion";
        }
        private void cargar_combo_edt(string ot)
        {
            //cboEdt_mod.DataSource = AccesoLogica.listar_combo_edt(ot);
            //cboEdt_mod.ValueMember = "codigo";
            //cboEdt_mod.DisplayMember = "descripcion";
        }

        private void cboOt_mod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // cargar combo EDT
            //cargar_combo_edt(cboOt_mod.SelectedValue.ToString());
            //cboEdt_mod.SelectedItem = null;
            //cboEdt_mod.Enabled = true;
            //cboEdt_mod.Focus();
        }

        #endregion

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //verificar semana cerrada
            try
            {
                if (Negocio.verificar_semana_cerrada(mod_Anio, mod_Sem).Rows.Count > 0)
                {
                    util.mensaje("Semana Cerrada, contactar al Administrador de Personal", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    return;
                }
            }
            catch (Exception)
            {
            }

            if (AccesoLogica.anula_registro_tareo(mod_Anio, mod_Sem, mod_UsrCrea, mod_CodTrab, mod_FechTrab, mod_Ot) != 0)
            {
                util.mensaje("Anulación exitosa", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                this.Close();
            }
            else
            {
                util.mensaje("Error en la Anulación", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
            }
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            //validar horas normales y extra
            if (!(validar_horas_extra() && validar_horas_normales()))
            {
                return;
            }
            //verificar semana cerrada
            try
            {
                if (Negocio.verificar_semana_cerrada(mod_Anio, mod_Sem).Rows.Count > 0)
                {
                    util.mensaje("Semana Cerrada, contactar al Administrador de Personal", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    return;
                }
            }
            catch (Exception)
            {
            }
            //verificar switch de asistencia
            try
            {
                if (Negocio.verificar_autorizacion_usuario(mod_UsrCrea, "Asistencia").Rows[0][2].ToString() == "S")
                {
                    if (Negocio.verificar_asistencia(mod_CodTrab, mod_FechTrab).Rows.Count <= 0)
                    {
                        DialogResult resul = MessageBox.Show("personal no tiene asistencia en fecha: " + mod_FechTrab + ". Horas trabajadas se actualizarán con cero", "PRECAUCIÓN", MessageBoxButtons.YesNo);
                        if (resul == DialogResult.No)
                        {
                            return;
                        }
                        else
                        {
                            txtHn_mod.Text = "0";
                            txtHe_mod.Text = "0";
                        }
                    }
                }
            }
            catch (Exception)
            {
                DialogResult resul = MessageBox.Show("personal no tiene asistencia en fecha: " + mod_FechTrab + ". Horas trabajadas se actualizarán con cero", "PRECAUCIÓN", MessageBoxButtons.YesNo);
                if (resul == DialogResult.No)
                {
                    return;
                }
                else
                {
                    txtHn_mod.Text = "0";
                    txtHe_mod.Text = "0";
                }
            }
            try
            {
                if (AccesoLogica.actualizar_tareo(mod_Anio, mod_Sem, mod_UsrCrea, mod_CodTrab, mod_FechTrab, cboTurno_mod.SelectedValue.ToString(), cboTipo_mod.SelectedValue.ToString(), cboFalta_mod.SelectedValue.ToString(), txtproc.Text, txtact.Text, txtHn_mod.Text, txtHe_mod.Text, mod_Ot) != 0)
                {
                    util.mensaje("Actualización exitosa", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    this.Close();
                }
                else
                {
                    util.mensaje("Error en la Actualización", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                }
            }
            catch (Exception)
            {
                util.mensaje("Error en la Actualización", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
            }
            
        }

        private Boolean validar_horas_extra()
        {
            DataTable dt = new DataTable();
            dt = AccesoLogica.listar_fechas_inifin(mod_Anio, mod_Sem);

            string fechaIni = dt.Rows[0]["fechaini"].ToString();
            string fechaFin = dt.Rows[0]["fechafin"].ToString();

            horasE_trabajadas = Convert.ToString(AccesoLogica.validar_horas_semanales(mod_CodTrab, mod_FechTrab, fechaIni, fechaFin, mod_UsrCrea).Rows[0][1]);
            horasE_semanales = Convert.ToString(AccesoLogica.validar_horas_semanales(mod_CodTrab, mod_FechTrab, fechaIni, fechaFin, mod_UsrCrea).Rows[0][3]);

            suma_horasE_trabajadas = float.Parse(horasE_trabajadas, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) - float.Parse(txtHe_old.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + float.Parse(txtHe_mod.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"));
            suma_horasE_semanales = float.Parse(horasE_semanales, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) - float.Parse(txtHe_old.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + float.Parse(txtHe_mod.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"));

            if (Convert.ToDouble(suma_horasE_trabajadas) > maxHeDia)
            {
                util.mensaje("no puede ingresar horas extra mayor a " + maxHeDia, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txtHe_mod.Text = "0";
                txtHe_mod.SelectionStart = 0;
                txtHe_mod.SelectionLength = txtHe_mod.Text.Length;
                return false;
            }

            if (Convert.ToDouble(suma_horasE_semanales) > maxHeSem)
            {
                util.mensaje("Horas extra semanales no puede ser mayor a " + maxHeSem + "horas ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txtHe_mod.Text = "0";
                txtHe_mod.SelectionStart = 0;
                txtHe_mod.SelectionLength = txtHe_mod.Text.Length;
                return false;
            }


            if (float.Parse(txtHn_mod.Text == string.Empty ? "0" : txtHn_mod.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + float.Parse(txtHe_mod.Text == string.Empty ? "0" : txtHe_mod.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) > maxHtDia)
            {
                util.mensaje("Horas extra totales diaria no puede ser mayor a " + maxHtDia + " horas ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txtHe_mod.Text = "0";
                txtHe_mod.SelectionStart = 0;
                txtHe_mod.SelectionLength = txtHe_mod.Text.Length;
                return false;
            }
            return true;
        }

        private Boolean validar_horas_normales()
        {
            DataTable dt = new DataTable();
            dt = AccesoLogica.listar_fechas_inifin(mod_Anio, mod_Sem);

            string fechaIni = dt.Rows[0]["fechaini"].ToString();
            string fechaFin = dt.Rows[0]["fechafin"].ToString();

            horas_trabajadas = Convert.ToString(AccesoLogica.validar_horas_semanales(mod_CodTrab, mod_FechTrab, fechaIni, fechaFin, mod_UsrCrea).Rows[0][0]);
            horas_semanales = Convert.ToString(AccesoLogica.validar_horas_semanales(mod_CodTrab, mod_FechTrab, fechaIni, fechaFin, mod_UsrCrea).Rows[0][2]);

            suma_horas_trabajadas = float.Parse(horas_trabajadas, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) - float.Parse(txthn_old.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + float.Parse(txtHn_mod.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"));
            suma_horas_semanales = float.Parse(horas_semanales, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) - float.Parse(txthn_old.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + float.Parse(txtHn_mod.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"));

            
            if (Convert.ToDouble(suma_horas_trabajadas) > maxHnDia)
            {
                util.mensaje("Horas trabajadas por dia no puede ser mayor a " + maxHnDia + " horas ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txtHn_mod.Text = "0";
                txtHn_mod.SelectionStart = 0;
                txtHn_mod.SelectionLength = txtHn_mod.Text.Length;
                return false;
            }

            if (Convert.ToDouble(suma_horas_semanales) > maxHnSem)
            {
                util.mensaje("Horas trabajadas semanales no puede ser mayor a " + maxHnSem + " horas ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txtHn_mod.Text = "0";
                txtHn_mod.SelectionStart = 0;
                txtHn_mod.SelectionLength = txtHn_mod.Text.Length;
                return false;
            }
            if (float.Parse(txtHn_mod.Text == string.Empty ? "0" : txtHn_mod.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + float.Parse(txtHe_mod.Text == string.Empty ? "0" : txtHe_mod.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) > maxHtDia)
            {
                util.mensaje("Horas totales diaria no puede ser mayor a " + maxHtDia + " horas ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txtHn_mod.Text = "0";
                txtHn_mod.SelectionStart = 0;
                txtHn_mod.SelectionLength = txtHn_mod.Text.Length;
                return false;
            }
            return true;
        }

        private void maximos_horas_permitidas()
        {
            DataTable dt = new DataTable();
            dt = AccesoLogica.listar_fechas_inifin(mod_Anio, mod_Sem);

            string fechaIni = dt.Rows[0]["fechaini"].ToString();
            string fechaFin = dt.Rows[0]["fechafin"].ToString();

            DataTable dtHoras = Negocio.listar_configuracion_horas();
            DateTime oldDate = Convert.ToDateTime(fechaIni);
            DateTime newDate = Convert.ToDateTime(fechaFin);
            TimeSpan ts = newDate - oldDate;

            int diferenciaDias = 0;
            if (ts.Days + 1 > 7)
            {
                diferenciaDias = ts.Days - 6;
            }

            if (cboTipo_mod.SelectedValue.ToString() == "00" || cboTipo_mod.SelectedValue.ToString() == "03") //dia normal o dia bajada
            {
                maxHnDia = float.Parse(dtHoras.Rows[0][0].ToString() == string.Empty ? "0" : dtHoras.Rows[0][0].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"));  //8.5;
                maxHnSem = float.Parse(dtHoras.Rows[0][3].ToString() == string.Empty ? "0" : dtHoras.Rows[0][3].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + (diferenciaDias * float.Parse(dtHoras.Rows[0][5].ToString() == string.Empty ? "0" : dtHoras.Rows[0][5].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"))); // 65; //48;
                maxHeDia = float.Parse(dtHoras.Rows[0][1].ToString() == string.Empty ? "0" : dtHoras.Rows[0][1].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")); //6.5;
                maxHeSem = float.Parse(dtHoras.Rows[0][4].ToString() == string.Empty ? "0" : dtHoras.Rows[0][4].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + (diferenciaDias * float.Parse(dtHoras.Rows[0][6].ToString() == string.Empty ? "0" : dtHoras.Rows[0][6].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"))); //35; // 25;
                maxHtDia = float.Parse(dtHoras.Rows[0][2].ToString() == string.Empty ? "0" : dtHoras.Rows[0][2].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")); //15;
            }
            if (cboTipo_mod.SelectedValue.ToString() == "01" || cboTipo_mod.SelectedValue.ToString() == "02") //dia descanso o feriado
            {
                maxHnDia = float.Parse(dtHoras.Rows[0][7].ToString() == string.Empty ? "0" : dtHoras.Rows[0][7].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")); //0;
                maxHnSem = float.Parse(dtHoras.Rows[0][10].ToString() == string.Empty ? "0" : dtHoras.Rows[0][10].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + (diferenciaDias * float.Parse(dtHoras.Rows[0][12].ToString() == string.Empty ? "0" : dtHoras.Rows[0][12].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"))); //65; // 48;
                maxHeDia = float.Parse(dtHoras.Rows[0][8].ToString() == string.Empty ? "0" : dtHoras.Rows[0][8].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")); //10;
                maxHeSem = float.Parse(dtHoras.Rows[0][11].ToString() == string.Empty ? "0" : dtHoras.Rows[0][11].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")) + (diferenciaDias * float.Parse(dtHoras.Rows[0][13].ToString() == string.Empty ? "0" : dtHoras.Rows[0][13].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"))); //35; //25;
                maxHtDia = float.Parse(dtHoras.Rows[0][9].ToString() == string.Empty ? "0" : dtHoras.Rows[0][9].ToString(), System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US")); //10;
            }
        }

        private void t_msg_Tick(object sender, EventArgs e)
        {
            lbl_msg.Text = string.Empty;
            ss_load.BackColor = Color.Transparent;
            lbl_contador_registros.Visible = true;
            lbl_msg.Visible = false;
        }

        private void cboActividad_mod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            separar_actividad();
        }

        #region Menu contextual



        #endregion










    }

}
