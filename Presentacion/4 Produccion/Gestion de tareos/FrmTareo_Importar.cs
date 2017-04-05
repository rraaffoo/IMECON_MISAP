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
    public partial class FrmTareo_Importar : Form
    {
        public string anio="";
        public string semana="";
        public string fecha_inicio="";
        public string fecha_fin="";
        public string tareador = "";

        #region Variables globales
        public string _usuario, _perfil, _dni;
        #endregion

        #region Variables locales

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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

        public FrmTareo_Importar()
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

            this.WindowState = (this.WindowState == FormWindowState.Maximized ?

                FormWindowState.Normal
                : FormWindowState.Maximized);

            if (this.WindowState == FormWindowState.Maximized)
            {
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));


            }

            if (this.WindowState == FormWindowState.Normal)
            {

                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
            }


            //if (lbl_maximi.Text == "1")
            //{
            //    this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //    maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));

            //    lbl_maximi.Text = "0";
            //}
            //else
            //{
            //    this.StartPosition = FormStartPosition.CenterScreen;
            //    maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
            //    this.SetBounds(this.Location.X, this.Location.Y, 919, 674);


            //    lbl_maximi.Text = "1";
            //}
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void titulo_DoubleClick(object sender, EventArgs e)
        {

            this.WindowState = (this.WindowState == FormWindowState.Maximized ?

                FormWindowState.Normal
                : FormWindowState.Maximized);

            if (this.WindowState == FormWindowState.Maximized)
            {
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));


            }

            if (this.WindowState == FormWindowState.Normal)
            {

                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
            }

        }

        private void titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); 
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

        private void cbo_anio_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "anio");
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
            util.FormatearCombo(sender, e, "datos");
        }

        private void cbo_num_ord_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "cod_ot");
        }

        private void cbo_edt_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "des_edt");
        }

        private void cbo_actividad_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "actividad");
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
        

        void formatear_grilla()
        {

            try
            {
                //util.FormatearGrilla(dgv_tareo);
                dgvTareo_imp.RowHeadersVisible = false;
                dgvTareo_imp.Columns["seleccion"].Visible = false;

                if (dgvTareo_imp.Rows.Count != 0)
                {
                   // dgv_tareo.Columns["seleccion"].Visible = true;
                    dgvTareo_imp.Columns["Chk"].Visible = false;
                    dgvTareo_imp.Columns["turn_trab"].Visible = false;
                    dgvTareo_imp.Columns["Tipo_Suspension_RL_Id"].Visible = false;
                    dgvTareo_imp.Columns["Tipo_Dia_Id"].Visible = false;
                    dgvTareo_imp.Columns["cod_trab"].Visible = false;
                   // dgv_tareo.Columns["id_edt"].Visible = false;
                    dgvTareo_imp.Columns["fec_ini"].Visible = false;
                    dgvTareo_imp.Columns["fec_fin"].Visible = false;
                    dgvTareo_imp.Columns["swt_est"].Visible = false;
                    dgvTareo_imp.Columns["activ"].Visible = false;
                    dgvTareo_imp.Columns["proceso"].Visible = false;

                    dgvTareo_imp.Columns["Orden_de_Trabajo"].HeaderText = "Orden de Trabajo";
                    dgvTareo_imp.Columns["Tipo_Suspension"].HeaderText = "Tipo Suspension";
                    dgvTareo_imp.Columns["Descanso_Feriado"].HeaderText = "Descanso Feriado";

                    dgvTareo_imp.Columns["Cargo"].Width = 150;
                    dgvTareo_imp.Columns["Nombre"].Width = 150;
                   // dgv_tareo.Columns["Tipo_Suspension"].Width = 150;

                    dgvTareo_imp.Columns["HN"].Width = 25;
                    dgvTareo_imp.Columns["HN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgvTareo_imp.Columns["HE"].Width = 25;
                    dgvTareo_imp.Columns["HE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                }



              



                lbl_contador_registros.Visible = true;
                lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgvTareo_imp.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Fabricación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

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
            btnImportar.Enabled = grabar;
            btnCancelar.Enabled = cancelar;

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

        private void FrmTareo_Load(object sender, EventArgs e)
        {
            cargar_combo_anio();    // cargar combo año
            try
            {
                cargar_combo_semana(cboAnio_imp.SelectedValue.ToString());  // cargar combo semana
                cargar_fechas(cboAnio_imp.SelectedValue.ToString(), cboSemana_imp.SelectedValue.ToString());    // cargar fechas de inicio y fin
            }
            catch (Exception)
            {                
            }
            
            cargar_combo_tareadores();  // cargar tareadores
            cboTareador_imp.SelectedValue = tareador;
            if (cboTareador_imp.Text == "")
                cboTareador_imp.Enabled = true;
            else
                cboTareador_imp.Enabled = false;            
        }

        private void cargar_fechas(string anio, string semana)
        {
            DataTable dt = new DataTable();
            dt = AccesoLogica.listar_fechas_inifin(anio, semana);

            string fechaIni = dt.Rows[0]["fechaini"].ToString();
            string fechaFin = dt.Rows[0]["fechafin"].ToString();
            
            txtFechaIni_imp.Text = fechaIni;
            txtFechaFin_imp.Text = fechaFin;
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
            cboAnio_imp.DataSource = dt;
            cboAnio_imp.ValueMember = "Codigo";
            cboAnio_imp.DisplayMember = "Descripcion";
            cboAnio_imp.SelectedIndex = 3;
        }

        private void cargar_combo_semana(string anio)
        {
            cboSemana_imp.DataSource = AccesoLogica.listar_semanas_anio(anio);
            cboSemana_imp.ValueMember = "codigo";
            cboSemana_imp.DisplayMember = "descripcion";
        }


        private void cargar_combo_tareadores()
        {
            cboTareador_imp.DataSource = AccesoLogica.listar_combo_tareadores();
            cboTareador_imp.ValueMember = "codigo";
            cboTareador_imp.DisplayMember = "descripcion";
        }

        private void dgv_tareo_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvTareo_imp.IsCurrentCellDirty)
               dgvTareo_imp.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }



        private void dp_fecha_Enter(object sender, EventArgs e)
        {
            //dtpFecha_reg.BackColor = Color.FromArgb(254, 240, 158);

        }

        private void dp_fecha_Leave(object sender, EventArgs e)
        {
            //dtpFecha_reg.BackColor = Color.White;
        }

        private void dp_fecha_ValueChanged(object sender, EventArgs e)
        {
            //txt_fecha.Text = dp_fecha.Text;
            //cbo_turno.Enabled = true;
            //cbo_turno.Focus();
        }


        #endregion

        #region Menu contextual

        private void cm_grilla_copia_tabla_Click(object sender, EventArgs e)
        {
            util.copiar_todo_encabezados(dgvTareo_imp);
        }

        private void cm_grilla_copia_Click(object sender, EventArgs e)
        {
            util.copiar_contextual(dgvTareo_imp);
        }

        #endregion

        private void dgv_tareo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (dgvTareo_imp.Columns[e.ColumnIndex].Name == "seleccion")
            {
                DataGridViewRow row = dgvTareo_imp.Rows[e.RowIndex];
                DataGridViewCheckBoxCell cellSelecion = row.Cells["seleccion"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(cellSelecion.Value))
                {
                        contador = contador + 1;
                        if (contador != 0)
                        {
                            //btn_suprimir.Enabled = true;
                            //btn_suprimir.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn));
                            row.DefaultCellStyle.BackColor = Color.FromArgb(252, 221, 130);
                        }   
                }
                else
                {
                    contador = contador - 1;
                    if (contador == 0)
                    {
                        //btn_suprimir.Enabled = false; 
                        //btn_suprimir.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_desactivado));
                        row.DefaultCellStyle.BackColor = Color.FromArgb(231, 231, 231);
                    }
                    
                }
            }

        }

        private void dgv_tareo_CurrentCellDirtyStateChanged_1(object sender, EventArgs e)
        {
            if (dgvTareo_imp.IsCurrentCellDirty)
            {
                dgvTareo_imp.CommitEdit(DataGridViewDataErrorContexts.Commit);

            }
        }

        

        private void t_msg_Tick(object sender, EventArgs e)
        {
            lbl_msg.Text = string.Empty;
            ss_load.BackColor = Color.Transparent;
            lbl_contador_registros.Visible = true;
            lbl_msg.Visible = false;
        }


        private void btnSubirArch_imp_Click(object sender, EventArgs e)
        {
            dgvTareo_imp.DataSource = null;
            util.importarExcel(dgvTareo_imp, "Hoja1");
            if (dgvTareo_imp.RowCount > 0)
                btnImportar.Enabled = true;
            else
                btnImportar.Enabled = false;
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                tareador = Convert.ToString(AccesoLogica.obtener_user(cboTareador_imp.SelectedValue.ToString()).Rows[0][0]);
            }
            catch (Exception)
            {
                util.mensaje("Debe seleccionar un Tareador", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
            

            try
            {
                foreach (DataGridViewRow row in dgvTareo_imp.Rows)
                {
                    if (row.Cells["Fecha"].Value.ToString() != "" && row.Cells["Turno"].Value.ToString() != "")
                    {
                        txt1.Text = row.Cells["Fecha"].Value.ToString();
                        txt2.Text = row.Cells["Turno"].Value.ToString();
                        txt3.Text = row.Cells["DNI"].Value.ToString();
                        txt4.Text = row.Cells["Actividad"].Value.ToString();
                        if ( txt4.Text.Substring(0,3)=="OTF" || txt4.Text.Substring(0,3)=="OTM")
                        {
                            txt4.Text = string.Concat("20", txt4.Text.Substring(3, 5));
                        }
                        txt5.Text = "";
                        txt6.Text = row.Cells["Actividad2"].Value.ToString();
                        txt7.Text = "";
                        txt8.Text = row.Cells["Horas_Trab"].Value.ToString().Replace(",", ".");
                        txt9.Text = row.Cells["Horas_Extras"].Value.ToString().Replace(",",".");
                        txt10.Text = row.Cells["Tipo_Suspension"].Value.ToString();
                        txt11.Text = row.Cells["Descanso_Feriado"].Value.ToString();
                        txt12.Text = tareador;
                        txt13.Text = txtFechaIni_imp.Text;
                        txt14.Text = txtFechaFin_imp.Text;
                        txt15.Text = cboSemana_imp.SelectedValue.ToString();
                        txt16.Text = "";
                        AccesoLogica.grabar_tareo(txt1.Text, txt2.Text, txt3.Text, txt4.Text, txt5.Text, txt6.Text, txt7.Text, txt8.Text, txt9.Text, txt10.Text, txt11.Text, txt12.Text, txt13.Text, txt14.Text, txt15.Text, txt16.Text);
                    }
                }
                MessageBox.Show("Exito");
                //util.mensaje("Exito", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                //util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
            }
            
        }

        private void cboAnio_imp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_combo_semana(cboAnio_imp.SelectedValue.ToString());
            cargar_fechas(cboAnio_imp.SelectedValue.ToString(), cboSemana_imp.SelectedValue.ToString());
        }

        private void cboSemana_imp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_fechas(cboAnio_imp.SelectedValue.ToString(), cboSemana_imp.SelectedValue.ToString());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        

        
        

        

    }

}
