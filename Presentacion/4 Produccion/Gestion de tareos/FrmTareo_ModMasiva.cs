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
    public partial class FrmTareo_ModMasiva : Form
    {
        public string masiv_Anio="";
        public string masiv_Sem = "";
        public string masiv_UsrCrea = "";
        

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
        double suma_horas_trabajadas, suma_horas_extras, suma_horas_semanales, suma_extras_semanales;


        string horas_trabajadas, horas_extras, horas_semanales, extras_semanales;

        #endregion

        #region Formulario

        public FrmTareo_ModMasiva()
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

            cargar_combo_turno();   // cargar turno
            cargar_combo_ot();      // cargar ot
            cargar_combo_tipo();    // cargar tipo
            cargar_combo_falta();   // cargar falta
            // cargar EDT
            //cargar_combo_edt();

            lblAnio_masiv.Text = masiv_Anio;
            lblSemana_masiv.Text = masiv_Sem;
            lblTareador_masiv.Text = masiv_UsrCrea;            
        }
        private void cargar_combo_turno()
        {
            cboTurno.DataSource = AccesoLogica.listar_combo_turno();
            cboTurno.ValueMember = "codigo";
            cboTurno.DisplayMember = "descripcion";
        }
        
        private void cargar_combo_ot()
        {
            cboOT.DataSource = AccesoLogica.listar_combo_ot();
            cboOT.ValueMember = "codigo";
            cboOT.DisplayMember = "codigo";
        }

        private void cargar_combo_tipo()
        {
            cboTipo.DataSource = AccesoLogica.listar_combo_tipo();
            cboTipo.ValueMember = "codigo";
            cboTipo.DisplayMember = "descripcion";
        }

        private void cargar_combo_falta()
        {
            cboFalta.DataSource = AccesoLogica.listar_combo_falta();
            cboFalta.ValueMember = "codigo";
            cboFalta.DisplayMember = "descripcion";
        }
        #endregion

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            string pAnio = masiv_Anio;
            string pSemana = masiv_Sem;
            string pTareador = masiv_UsrCrea;
            string pTurno = chkTurno.Checked ? cboTurno.SelectedValue.ToString() : "";
            string pOT = chkOT.Checked ? cboOT.SelectedValue.ToString() : "";
            string pTipo = chkTipo.Checked ? cboTipo.SelectedValue.ToString() : "";
            string pFalta = chkFalta.Checked ? cboFalta.SelectedValue.ToString() : "";
            string pHn = chkHn.Checked ? txtHn_mod.Text : "";
            string pHe = chkHe.Checked ? txtHe_mod.Text : "";
            string pObservacion = txtObservacion.Text;
            if (AccesoLogica.obtener_estTareo(pAnio, pSemana, pTareador).Rows[0][0].ToString() != "0")
            {
                util.mensaje("Para modificar, el tareo debe estar EN PROCESO", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }

            if (AccesoLogica.actualizar_tareo_masivo(pAnio, pSemana, pTareador, pTurno, pOT, pTipo, pFalta, pHn, pHe, pObservacion) != 0)
            {
                util.mensaje("Actualización exitosa", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
            }
            else
            {
                util.mensaje("Error en la Actualización", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
            }
        }

        private void chkTurno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTurno.Checked)
                cboTurno.Enabled = true;
            else
                cboTurno.Enabled = false;
        }

        private void chkTipo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTipo.Checked)
                cboTipo.Enabled = true;
            else
                cboTipo.Enabled = false;
        }

        private void chkFalta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFalta.Checked)
                cboFalta.Enabled = true;
            else
                cboFalta.Enabled = false;
        }

        private void chkHn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHn.Checked)
                txtHn_mod.Enabled = true;
            else
                txtHn_mod.Enabled = false;
        }

        private void chkHe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHe.Checked)
                txtHe_mod.Enabled = true;
            else
                txtHe_mod.Enabled = false;
        }

        private void chkOT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOT.Checked)
                cboOT.Enabled = true;
            else
                cboOT.Enabled = false;
        }

        

        #region Menu contextual



        #endregion










    }

}
