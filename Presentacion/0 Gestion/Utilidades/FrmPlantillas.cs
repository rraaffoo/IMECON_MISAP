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

namespace MISAP
{
    public partial class FrmPlantillas : Form
    {
              
        #region Variables globales

        public string usuario, perfil;

        #endregion

        #region Variables locales

        private Point pos = Point.Empty;
        private bool move = false;
        bool allowSelect = false;

        Utilidades util = new Utilidades();

        string filtro, ruta;
        int columna, id_plantilla;

        #endregion

        #region Formulario
              

        public FrmPlantillas()
        {
            InitializeComponent();
            ts_acciones.Renderer = new MyRenderer();
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

        #region Formulario externo

       
        #endregion

        #region Perzonalizacion de controles

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() :
                base(new Utilidades.MyColors()) { }
        }

        private void cbo_perfil_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "des_perf");
        }

        #endregion

        #region Eventos

        private void FrmPlantillas_Load(object sender, EventArgs e)
        {
            util.FormatearFormulario(this, ts_acciones, tc_plantilla, ss_load, txt_buscar, tp_listado, tp_nuevo, tp_auditoria);

           // this.Location = new System.Drawing.Point(320, 80);

            dgv_maestro_plantilla.DataSource = AccesoLogica.listar_maestro_plantilla();
            formatear_grilla(dgv_maestro_plantilla);

            activar_boton(true, true, false, false, false, false, true, false, false, true, false, false, true);
        }
        private void tc_plantilla_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!allowSelect) e.Cancel = true;
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            if (dgv_maestro_plantilla.Rows.Count != 0)
            {


                if (columna != 0)
                {


                    (dgv_maestro_plantilla.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + filtro + " ,'System.String') LIKE '{0}%'", txt_buscar.Text);
                    formatear_grilla(dgv_maestro_plantilla);

                }
                else
                {
                    (dgv_maestro_plantilla.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(plantilla,'System.String') LIKE '%{0}%'", txt_buscar.Text);
                    formatear_grilla(dgv_maestro_plantilla);
                }
            }
            else
            {
                (dgv_maestro_plantilla.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(plantilla,'System.String') LIKE '%{0}%'", txt_buscar.Text);
                formatear_grilla(dgv_maestro_plantilla);
            }
        }

        private void dgv_maestro_plantilla_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar.Focus();

            filtro = dgv_maestro_plantilla.Columns[e.ColumnIndex].HeaderText;
            lbl_buscar.Text = "Buscar en " + filtro;

            columna = dgv_maestro_plantilla.CurrentCell.ColumnIndex;
        }

        private void cbo_tipo_plantilla_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_cdg_tipo_plantilla.Text = cbo_tipo_plantilla.SelectedValue.ToString();

            //cargo combo proceso
            cbo_proceso.Enabled = true;
            cbo_proceso.DataSource = AccesoLogica.listar_proceso(txt_cdg_tipo_plantilla.Text);
            cbo_proceso.DisplayMember = "carpeta";
            cbo_proceso.ValueMember = "carpeta";
            cbo_proceso.SelectedItem = null;
        }

        private void cbo_proceso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_proceso.Text = cbo_proceso.SelectedValue.ToString();

            //cargo combo plantilla
            cbo_plantilla.Enabled = true;
            cbo_plantilla.DataSource = AccesoLogica.listar_plantilla(txt_proceso.Text);
            cbo_plantilla.DisplayMember = "plantilla";
            cbo_plantilla.ValueMember = "id_plantilla";
            cbo_plantilla.SelectedItem = null;
        }

        private void cbo_plantilla_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ruta = lbl_ruta.Text + "\\\\" + txt_cdg_tipo_plantilla.Text + @"\\" + txt_proceso.Text;



            txt_id_plantilla.Text = cbo_plantilla.SelectedValue.ToString();
            id_plantilla = Convert.ToInt32(txt_id_plantilla.Text);


            txt_sp.Text = Convert.ToString(AccesoLogica.consultar_plantilla(id_plantilla).Rows[0][0]);
            txt_sp_d.Text = Convert.ToString(AccesoLogica.consultar_plantilla(id_plantilla).Rows[0][1]);
            txt_bd.Text = Convert.ToString(AccesoLogica.consultar_plantilla(id_plantilla).Rows[0][2]);
            txt_aplicacion.Text = Convert.ToString(AccesoLogica.consultar_plantilla(id_plantilla).Rows[0][3]);
            txt_motor.Text = Convert.ToString(AccesoLogica.consultar_plantilla(id_plantilla).Rows[0][4]);

            btn_abrir_plantilla.Enabled = true;
            btn_ejecutar_SP.Enabled = true;
            btn_ejecutar_SP.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
            // btn_abrir_archivo.Enabled = true;

            if (txt_cdg_tipo_plantilla.Text == "SI")
            {
                txt_periodo_fin.Focus();
                txt_periodo_fin.BackColor = Color.FromArgb(254, 240, 158);
            }
        }

        #endregion

        #region Funciones

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
        void activar_campos(bool cdg_usr, bool dni, bool des_usr, bool correo, bool perfil, bool swt_usr)
        {
            

        }
        void limpiar()
        {
            txt_buscar.Clear();
           


            txt_estado_registro.Clear();
            txt_fec_crea.Clear();
            txt_formulario.Clear();

            txt_operacion.Clear();
            txt_terminal_crea.Clear();
            txt_usr_crea.Clear();

            txt_sp.Clear();
            txt_sp_d.Clear();
            txt_bd.Clear();
            txt_aplicacion.Clear();
            txt_motor.Clear();
            txt_periodo_inicio.Clear();
            txt_periodo_fin.Clear();


       
            //if (dgv_det_pedidos.Rows.Count != 0)
            //{
            //    DataTable dtg = (DataTable)dgv_det_pedidos.DataSource;
            //    dtg.Clear();
            //}



        }
        void formatear_grilla(DataGridView grilla)
        {

            try
            {

                //dgv_usuarios.Columns["swt_usr"].Visible = false;
                //dgv_usuarios.Columns["cdg_perf"].Visible = false;
                //dgv_usuarios.Columns["psw_usr"].Visible = false;

                util.FormatearGrilla(grilla,false);

                if (grilla == dgv_maestro_plantilla)
                {
                    lbl_contador_registros.Visible = true;
                    lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_maestro_plantilla.Rows.Count);
                }

                if (grilla == dgv_plantilla)
                {

                    lbl_contador_registros.Visible = true;
                    lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_plantilla.Rows.Count);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Fabricación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        #endregion

        #region Botones

        private void btn_nuevo_b_Click(object sender, EventArgs e)
        {
            limpiar();

            tc_plantilla.TabPages.Add(tp_nuevo);
            tc_plantilla.TabPages.Add(tp_auditoria);

            activar_boton(false, false, false, false, false, false, false, false, false, false, false, false, true);

            util.EstablecerAuditoria("Nuevo", usuario, "", "FrmPlantilla", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            allowSelect = true;
            tc_plantilla.SelectedIndex = 1;
            allowSelect = false;



            //cargo combo tipo planilla
            cbo_tipo_plantilla.Enabled = true;
            cbo_tipo_plantilla.DataSource = AccesoLogica.listar_tipo_plantilla();
            cbo_tipo_plantilla.DisplayMember = "tipo_plantilla";
            cbo_tipo_plantilla.ValueMember = "cdg_tipo_plantilla";
            cbo_tipo_plantilla.SelectedItem = null;

           
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FrmOpciones opciones = new FrmOpciones();
            opciones.titulo = "Lista de materiales";
            opciones.ShowDialog(this);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dgv_maestro_plantilla.DataSource = AccesoLogica.listar_maestro_plantilla();
            formatear_grilla(dgv_maestro_plantilla);
        }

        private void btn_ejecutar_SP_Click(object sender, EventArgs e)
        {
            dgv_plantilla.RowHeadersVisible = false;

            //if (txt_aplicacion.Text == "IMERP")
            //{
            //    if (txt_cdg_tipo_plantilla.Text == "SI" & txt_periodo_fin.Text == string.Empty)
            //    {
            //        MessageBox.Show("Por favor ingrese el periodo");
            //        txt_periodo_fin.Focus();
            //        return;
            //    }

            //    if (txt_periodo_fin.Text != "")
            //    {

            //        dgv_plantilla.DataSource = AccesoLogica.ejecutar_sp_imerp(txt_sp.Text, txt_periodo_inicio.Text, txt_periodo_fin.Text, "");
            //    }
            //    else
            //    {

            //        dgv_plantilla.DataSource = AccesoLogica.ejecutar_sp_imerp(txt_sp.Text, "", "", "");

            //        if (txt_sp_d.Text != "")
            //        {

            //            dgv_plantilla_d.DataSource = AccesoLogica.ejecutar_sp_imerp(txt_sp_d.Text, "", "", "");
            //        }
            //    }

            //}

            if (txt_aplicacion.Text == "STARSOFT")
            {
                if (txt_cdg_tipo_plantilla.Text == "SI" & txt_periodo_fin.Text == string.Empty)
                {
                    MessageBox.Show("Por favor ingrese el periodo");
                    txt_periodo_fin.Focus();
                    return;
                }

                if (txt_periodo_fin.Text != "")
                {

                    dgv_plantilla.DataSource = AccesoLogica.ejecutar_sp_starsoft(txt_sp.Text, txt_periodo_fin.Text);
                    dgv_plantilla_d.DataSource = AccesoLogica.ejecutar_sp_starsoft(txt_sp_d.Text, txt_periodo_fin.Text);
                }
                else
                {

                    dgv_plantilla.DataSource = AccesoLogica.ejecutar_sp_starsoft(txt_sp.Text, "");
                }
            }

            //if (txt_aplicacion.Text == "IMECON")
            //{
            //    dgv_plantilla.DataSource = AccesoLogica.ejecutar_sp_scire(txt_sp.Text);
            //}


            if (txt_aplicacion.Text == "SAP")
            {
                dgv_plantilla.DataSource = AccesoLogica.ejecutar_sp_SAP(txt_sp.Text);
            }

            formatear_grilla(dgv_plantilla);
            formatear_grilla(dgv_plantilla_d);

            btn_abrir_plantilla.Enabled = true;
            btn_abrir_plantilla.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));

            btn_ejecutar_SP.Enabled = false;
            btn_ejecutar_SP.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
        }

        private void btn_abrir_plantilla_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();

            proc.StartInfo.FileName = lbl_ruta.Text + "\\" + txt_cdg_tipo_plantilla.Text + "\\" + txt_proceso.Text + "\\" + cbo_plantilla.Text + ".xlsx";
            proc.Start();
            proc.Close();
        }

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
            util.ExportarDataGridViewExcel(dgv_maestro_plantilla, tsl_titulo.Text);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            cbo_tipo_plantilla.SelectedItem = null;
            cbo_proceso.SelectedItem = null;
            cbo_plantilla.SelectedItem = null;

            
            limpiar();

            tc_plantilla.TabPages.Remove(tp_nuevo);
            tc_plantilla.TabPages.Remove(tp_auditoria);

            allowSelect = true;
            tc_plantilla.SelectedIndex = 0;


            dgv_maestro_plantilla.DataSource = AccesoLogica.listar_maestro_plantilla();
            formatear_grilla(dgv_maestro_plantilla);

            activar_boton(true, true, false, false, false, false, true, false, false, true, false, false, true);
            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
            btn_grabar.Text = "Crear";



        }

        #endregion
        
        #region Menu contextual

        private void copiarConSinEncambezadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            util.copiar_todo_sin_encabezados(dgv_plantilla);
        }

        private void copiarConEncabezadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            util.copiar_todo_encabezados(dgv_plantilla);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            util.copiar_todo_sin_encabezados(dgv_plantilla_d);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            util.copiar_todo_encabezados(dgv_plantilla_d);
        }


        #endregion

        private void btn_suprimir_Click(object sender, EventArgs e)
        {
            cbo_tipo_plantilla.SelectedItem = null;
            cbo_proceso.SelectedItem = null;
            cbo_plantilla.SelectedItem = null;
        }

       
    }
}
