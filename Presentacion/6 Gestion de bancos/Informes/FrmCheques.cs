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
    public partial class FrmCheques : Form
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

        int cant_col, ColumnaId, id, nro_pago;
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

        private void cbo_responsable_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cbo_anio_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {

        }

        #endregion

        #region Formulario

        public FrmCheques()
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

        private void FrmCheques_Load(object sender, EventArgs e)
        {
            util.FormatearFormulario(this, ts_acciones, tc_cheque, ss_load, txt_buscar, tp_listado, tp_nuevo, tp_auditoria);
            this.Location = new System.Drawing.Point(350, 0);



            dgv_proveedores.DataSource = AccesoLogica.listar_proveedores_cheque("");
            formatear_grilla(dgv_proveedores);

          

            if (dgv_proveedores.Rows.Count != 0)
            {
                posicion = 0;
                txt_buscar.Enabled = true;
                filtro = dgv_proveedores.Columns[1].HeaderText;

                dgv_proveedores.CurrentCell = dgv_proveedores.Rows[0].Cells[1];
                columna = dgv_proveedores.CurrentCell.ColumnIndex;
            }
        }

      

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            (dgv_proveedores.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" + " ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
            lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_proveedores.Rows.Count);
        }

        private void dgv_proveedores_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar.Focus();
            txt_buscar.Clear();

            filtro = dgv_proveedores.Columns[e.ColumnIndex].HeaderText;
            lbl_buscar.Text = "Buscar en " + filtro;

            dgv_proveedores.CurrentCell = dgv_proveedores.Rows[0].Cells[e.ColumnIndex];
        }

        private void tc_pedido_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!allowSelect) e.Cancel = true;
        }

        private void txt_buscar_factura_TextChanged(object sender, EventArgs e)
        {
            (dgv_cheques.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" + " ,'System.String') LIKE '%{0}%'", txt_buscar_factura.Text);
            lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_cheques.Rows.Count);
        }

        private void dgv_facturas_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_buscar_factura.Enabled = true;
            txt_buscar_factura.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar_factura.Focus();
            txt_buscar_factura.Clear();

            filtro = dgv_cheques.Columns[e.ColumnIndex].HeaderText;
            lbl_buscar_factura.Text = "Buscar en " + filtro;

            dgv_cheques.CurrentCell = dgv_cheques.Rows[0].Cells[e.ColumnIndex];
        }

        private void dgv_proveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_proveedores.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para consultar", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            util.EstablecerAuditoria("Consultar", usuario, "", "FrmCheque", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            tc_cheque.TabPages.Add(tp_nuevo);
            tp_nuevo.Text = @"Consultar";

            allowSelect = true;
            tc_cheque.SelectedIndex = 1;
            allowSelect = false;

            proveedor = Convert.ToString(dgv_proveedores.CurrentRow.Cells["Proveedor"].Value);

            dgv_cheques.DataSource = AccesoLogica.listar_cheques("", proveedor);
            formatear_grilla(dgv_cheques);


            btn_consultar_b.Enabled = false;
        }

        private void dgv_facturas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nro_pago = Convert.ToInt32(dgv_cheques.CurrentRow.Cells["Nro Pago"].Value);

            FrmOpciones opciones = new FrmOpciones();
            opciones.titulo = "Lista de documentos";
            opciones.parametro_1 = "";
            opciones.parametro_1_n = 0;
            opciones.parametro_2_n = nro_pago;
            opciones.ShowDialog(this);
        }

        #endregion


        #region Funciones

        void formatear_grilla(DataGridView grilla)
        {

            try
            {
                util.FormatearGrilla(grilla, false);
                lbl_contador_registros.Visible = true;

                if (grilla == dgv_proveedores)
                {
                    grilla.Columns["Proveedor"].Width = 100;
                    //dgv_pedidos.Columns["U_CL_CODSOL"].Visible = false;
                    //dgv_pedidos.Columns["U_CL_SOLICI"].Visible = false;
                    lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_proveedores.Rows.Count);
                }

                if (grilla == dgv_cheques)
                {
                                       
                    lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_cheques.Rows.Count);
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
            if (dgv_proveedores.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para consultar", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            util.EstablecerAuditoria("Consultar", usuario, "", "FrmCheque", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            tc_cheque.TabPages.Add(tp_nuevo);
            tp_nuevo.Text = @"Consultar";

            allowSelect = true;
            tc_cheque.SelectedIndex = 1;
            allowSelect = false;

            proveedor = Convert.ToString(dgv_proveedores.CurrentRow.Cells["Proveedor"].Value);

            dgv_cheques.DataSource = AccesoLogica.listar_cheques("", proveedor);
            formatear_grilla(dgv_cheques);

         
            btn_consultar_b.Enabled = false;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            allowSelect = true;
            tc_cheque.SelectedIndex = 0;

            tc_cheque.TabPages.Remove(tp_nuevo);
            tc_cheque.TabPages.Remove(tp_auditoria);

            btn_consultar_b.Enabled = true;
            
            lbl_contador_registros.Visible = true;
            lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_proveedores.Rows.Count);
        }

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
            if (dgv_proveedores.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para exportar", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            util.ExportarDataGridViewExcel(dgv_proveedores, tsl_titulo.Text);
        }


        #endregion


        #region Menu contextual
        private void cm_grilla_copia_Click(object sender, EventArgs e)
        {
            util.copiar_contextual(dgv_proveedores);
        }

        private void cm_grilla_copia_tabla_Click(object sender, EventArgs e)
        {
            util.copiar_todo_encabezados(dgv_proveedores);
        }

        private void verPedidosOCOSToolStripMenuItem_Click(object sender, EventArgs e)
        {


            nro_pago = Convert.ToInt32(dgv_cheques.CurrentRow.Cells["Numero SAP"].Value);

            FrmOpciones opciones = new FrmOpciones();
            opciones.titulo = "Lista de pedidos";
           // opciones.parametro_1 = txt_tipo_l.Text;
            opciones.parametro_1_n = nro_pago;
            opciones.ShowDialog(this);




        }
     
        #endregion





    }
}
