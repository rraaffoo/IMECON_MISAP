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


namespace MISAP
{
    public partial class FrmReportesLegales : Form
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

        private Point pos = Point.Empty;
        private bool move = false;
        bool allowSelect = false;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();

        string filtro, proveedor;
        int posicion, columna, pedido;

        int cant_col, ColumnaId, id, nro_factura;
        int[] vector, vec_col;
        bool[] vec_falg;
        bool visible_;

        #endregion

        #region Perzonalizacion de controles

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() :
                base(new Utilidades.MyColors()) { }
        }

        private void cbo_reporte_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cbo_periodo_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        #endregion

        #region Formulario

        public FrmReportesLegales()
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

            FormWindowState.Normal    : FormWindowState.Maximized);

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
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); 

            //pos = new Point(e.X, e.Y);
            //move = true;

            //dragging = true;
            //dragCursorPoint = Cursor.Position;
            //dragFormPoint = this.Location;
        }

        private void titulo_MouseMove(object sender, MouseEventArgs e)
        {
            //if (dragging)
            //{
            //    Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
            //    this.Location = Point.Add(dragFormPoint, new Size(dif));
            //}
            
            //if (move)
            //    this.Location = new Point((this.Left + e.X - pos.X),
            //        (this.Top + e.Y - pos.Y));
        }

        private void titulo_MouseUp(object sender, MouseEventArgs e)
        {
            //dragging = false;
            
            //move = false;
        }

        #endregion

        #region Eventos

        private void FrmReportesLegales_Load(object sender, EventArgs e)
        {
            util.FormatearFormulario(this, ts_acciones, tc_pedido, ss_load, txt_buscar, tp_listado, tp_nuevo, tp_auditoria);
            this.Location = new System.Drawing.Point(350, 0);

            //carga combo solicitante
            cbo_reporte.DataSource = AccesoLogica.listar_reporte_pdt("Listar", 0);
            cbo_reporte.DisplayMember = "Descripcion";
            cbo_reporte.ValueMember = "Codigo";
            cbo_reporte.SelectedItem = null;



        }

      
       

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            (dgv_reporte.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" + " ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
            lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_reporte.Rows.Count);
        }

        private void dgv_reporte_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar.Focus();
            txt_buscar.Clear();

            filtro = dgv_reporte.Columns[e.ColumnIndex].HeaderText;
            lbl_buscar.Text = "Buscar en " + filtro;

            dgv_reporte.CurrentCell = dgv_reporte.Rows[0].Cells[e.ColumnIndex];
        }

        private void tc_pedido_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!allowSelect) e.Cancel = true;
        }

     



     

       
        #endregion


        #region Funciones

        void formatear_grilla(DataGridView grilla)
        {

            try
            {
                util.FormatearGrilla(grilla, false);
                lbl_contador_registros.Visible = true;

                if (grilla == dgv_reporte)
                {
                    //grilla.Columns["Proveedor"].Width = 100;
                    //dgv_pedidos.Columns["U_CL_CODSOL"].Visible = false;
                    //dgv_pedidos.Columns["U_CL_SOLICI"].Visible = false;
                    lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_reporte.Rows.Count);
                }

           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Fabricación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        #endregion


        #region Botones

        private void btn_consultar_b_Click(object sender, EventArgs e)
        {
            if (dgv_reporte.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para consultar", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            util.EstablecerAuditoria("Consultar", usuario, "", "FrmProvision", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            tc_pedido.TabPages.Add(tp_nuevo);
            tp_nuevo.Text = @"Consultar";

            allowSelect = true;
            tc_pedido.SelectedIndex = 1;
            allowSelect = false;

            proveedor = Convert.ToString(dgv_reporte.CurrentRow.Cells["Proveedor"].Value);

            //dgv_facturas.DataSource = AccesoLogica.listar_facturas_provision(txt_tipo_l.Text, proveedor);
            //formatear_grilla(dgv_facturas);

         
            btn_consultar_b.Enabled = false;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            allowSelect = true;
            tc_pedido.SelectedIndex = 0;

            tc_pedido.TabPages.Remove(tp_nuevo);
            tc_pedido.TabPages.Remove(tp_auditoria);

            btn_consultar_b.Enabled = true;
            
            lbl_contador_registros.Visible = true;
            lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_reporte.Rows.Count);
        }

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
            if (dgv_reporte.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para exportar", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            util.ExportarDataGridViewExcel(dgv_reporte, tsl_titulo.Text);
        }


        #endregion


        #region Menu contextual
        private void cm_grilla_copia_Click(object sender, EventArgs e)
        {
            util.copiar_contextual(dgv_reporte);
        }

        private void cm_grilla_copia_tabla_Click(object sender, EventArgs e)
        {
            util.copiar_todo_encabezados(dgv_reporte);
        }

     
     
        #endregion

        private void cbo_reporte_SelectionChangeCommitted(object sender, EventArgs e)
        {

            //carga combo solicitante
            cbo_periodo.DataSource = AccesoLogica.listar_periodo();
            cbo_periodo.DisplayMember = "Descripcion";
            cbo_periodo.ValueMember = "Codigo";
            cbo_periodo.SelectedItem = null;

            int DocEntry;

            DocEntry = Convert.ToInt32(cbo_reporte.SelectedValue.ToString());

            txt_sp.Text = Convert.ToString(AccesoLogica.listar_reporte_pdt("Consultar", DocEntry).Rows[0][0]);
        }

        private void cbo_periodo_SelectionChangeCommitted(object sender, EventArgs e)
        {

            dgv_reporte.DataSource = AccesoLogica.ejecutar_sp_pdt(txt_sp.Text, cbo_periodo.SelectedValue.ToString());
            formatear_grilla(dgv_reporte);


            if (dgv_reporte.Rows.Count != 0)
            {
                posicion = 0;
                txt_buscar.Enabled = true;
                filtro = dgv_reporte.Columns[1].HeaderText;

                dgv_reporte.CurrentCell = dgv_reporte.Rows[0].Cells[1];
                columna = dgv_reporte.CurrentCell.ColumnIndex;
            }


            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
            btn_grabar.Enabled = true;
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"\\10.0.0.10\Anexos\PDT"))
            {
                Directory.CreateDirectory(@"\\10.0.0.10\Anexos\PDT");
            }

            TextWriter sw = new StreamWriter(@"\\10.0.0.10\Anexos\PDT\" + "0626" + "20142920558" + cbo_periodo.SelectedValue.ToString() + ".txt");

            string linea;
            string linea_f = "";
            for (int i = 0; i < dgv_reporte.Rows.Count; i++)
            {
                for (int j = 0; j < dgv_reporte.Columns.Count; j++)
                {

                    linea = dgv_reporte.Rows[i].Cells[j].Value.ToString() + "|";
                    linea_f = linea_f + linea;  
                 

                }
                sw.WriteLine(linea_f);
                linea_f = "";
            }       
            
            sw.Close();
            MessageBox.Show("Operación finalizada con éxito.", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

        }

       

    }
}
