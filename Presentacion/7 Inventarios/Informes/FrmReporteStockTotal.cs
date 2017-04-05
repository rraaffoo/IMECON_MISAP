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

namespace MISAP
{
    public partial class FrmReporteStockTotal : Form
    {

        #region Variables globales

        public string usuario, perfil;

        #endregion

        #region Variables locales

        private Point pos = Point.Empty;
        private bool move = false;
        bool allowSelect = false;

        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();

        string filtro;
        int posicion, columna;

        #endregion

        #region Formulario

        public FrmReporteStockTotal()
        {
            InitializeComponent();
            ts_acciones.Renderer = new MyRenderer();
        }

        private void ninimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Text = tsl_titulo.Text;
           
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
            //    maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
            //    this.SetBounds(this.Location.X, this.Location.Y, 858, 595);
            //    this.Location = new System.Drawing.Point(320, 80);

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

            //if (lbl_maximi.Text == "1")
            //{
            //    this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //    maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));

            //    lbl_maximi.Text = "0";
            //}
            //else
            //{
            //    maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
            //    this.SetBounds(this.Location.X, this.Location.Y, 858, 595);
            //    this.Location = new System.Drawing.Point(320, 80);

            //    lbl_maximi.Text = "1";
            //}



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

        #region Perzonalizacion de controles

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() :
                base(new Utilidades.MyColors()) { }
        }

        private void cbo_responsable_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cbo_anio_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {

        }

        #endregion

        #region Eventos
        
        private void FrmReporteStockTotal_Load(object sender, EventArgs e)
        {
            util.FormatearFormulario(this, ts_acciones, tc_pedido, ss_load, txt_buscar, tp_listado, tp_nuevo, tp_auditoria);
            this.Location = new System.Drawing.Point(350, 0);

            try
            {
                dgv_pedidos.DataSource = AccesoLogica.listar_stock("");
                formatear_grilla(dgv_pedidos);
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR");
            }

            if (dgv_pedidos.Rows.Count != 0)
            {
                posicion = 0;
                txt_buscar.Enabled = true;
                filtro = dgv_pedidos.Columns[1].HeaderText;

                dgv_pedidos.CurrentCell = dgv_pedidos.Rows[0].Cells[1];
                columna = dgv_pedidos.CurrentCell.ColumnIndex;
            }


            //carga combo OT
            cbo_OT.DataSource = AccesoLogica.listar_ubicaciones_sap();
            cbo_OT.DisplayMember = "Descripcion";
            cbo_OT.ValueMember = "num_ord";
            cbo_OT.SelectedItem = null;
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            (dgv_pedidos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" + " ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
            lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_pedidos.Rows.Count);
        }

        private void cbo_OT_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgv_pedidos.DataSource = AccesoLogica.listar_stock(cbo_OT.SelectedValue.ToString());
            formatear_grilla(dgv_pedidos);

            //cbo_OT.SelectedValue.ToString()
        }

        private void dgv_pedidos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar.Focus();
            txt_buscar.Clear();

            filtro = dgv_pedidos.Columns[e.ColumnIndex].HeaderText;
            lbl_buscar.Text = "Buscar en " + filtro;

            dgv_pedidos.CurrentCell = dgv_pedidos.Rows[0].Cells[e.ColumnIndex];
        }

        #endregion

        #region Funciones

        void ocultar_mostrar_columnas(DataGridView grilla, int[] col, bool[] flag)
        {
            for (int i = 0; i < col.Length; i++)
            {
                grilla.Columns[col[i]].Visible = flag[i];
            }
        }


        void cargar_parametrizacion(DataGridView grilla, int[] col, bool[] flag, string usuario)
        {


            for (int i = 0; i < col.Length; i++)
            {
                grilla.Columns[col[i]].Visible = flag[i];
            }
        }

        void formatear_grilla(DataGridView grilla)
        {

            try
            {
                util.FormatearGrilla(grilla, true);

                if (grilla == dgv_pedidos)
                {
                    //dgv_pedidos.Columns["cdg_origen"].Visible = false;
                    //dgv_pedidos.Columns["U_CL_CODSOL"].Visible = false;
                    //dgv_pedidos.Columns["U_CL_SOLICI"].Visible = false;
                    lbl_contador_registros.Visible = true;
                    lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_pedidos.Rows.Count);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Fabricación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        #endregion

        #region Botones

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
            if (dgv_pedidos.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para exportar", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            util.ExportarDataGridViewExcel(dgv_pedidos, tsl_titulo.Text);
        }

        #endregion

        private void FrmReporteStockTotal_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Text = "";
        }

        private void cm_log_modificaciones_Click(object sender, EventArgs e)
        {

        }

        private void cm_ver_ingresos_Click(object sender, EventArgs e)
        {
            FrmListado Listado = new FrmListado();
            Listado.titulo = "Lista de ingresos";
            Listado.parametro_1 = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Cod. Material"].Value);
            Listado.parametro_2 = Convert.ToString(dgv_pedidos.CurrentRow.Cells["OT"].Value);
            Listado.ShowDialog(this);
        }

        private void cm_grilla_copia_tabla_Click(object sender, EventArgs e)
        {

        }

    }
}
