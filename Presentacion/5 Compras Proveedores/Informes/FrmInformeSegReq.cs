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
using Excel = Microsoft.Office.Interop.Excel;

namespace MISAP
{

    public partial class FrmInformeSegReq : Form, IForm_parametrizacion
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

        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();

        string filtro, ptitulo;
        DataGridView dgvExportar;
        int posicion, columna, pedido;

        int cant_col, ColumnaId, id, ni;
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

        #region Formulario externo

        public void pasar_valores_parametrizacion(int[] par1, bool[] par2)
        {
            try
            {

                ocultar_mostrar_columnas(dgv_pedidos, par1, par2);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Orden de Producción", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }
        #endregion

        #region Formulario

        public FrmInformeSegReq()
        {
            InitializeComponent();
            ts_acciones.Renderer = new MyRenderer();

            dgv_pedidos.DataSource = AccesoLogica.listar_requemiento_seguimiento("Materiales");
            formatear_grilla(dgv_pedidos);
        

            txt_tipo_l.Text = "Materiales";

            if (dgv_pedidos.Rows.Count != 0)
            {
                posicion = 0;
                txt_buscar.Enabled = true;
                filtro = dgv_pedidos.Columns[1].HeaderText;

                dgv_pedidos.CurrentCell = dgv_pedidos.Rows[0].Cells[1];
                columna = dgv_pedidos.CurrentCell.ColumnIndex;
            }

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
                this.SetBounds(this.Location.X, this.Location.Y, 858, 595);
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

            //this.WindowState = (this.WindowState == FormWindowState.Maximized ?

            //    FormWindowState.Normal
            //    : FormWindowState.Maximized);

            //if (this.WindowState == FormWindowState.Maximized)
            //{
            //    maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));


            //}

            //if (this.WindowState == FormWindowState.Normal)
            //{

            //    maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
            //}

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
                this.SetBounds(this.Location.X, this.Location.Y, 858, 595);
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

        void ocultar_mostrar_columnas(DataGridView grilla, int[] col, bool[] flag)
        {
            for (int i = 0; i < col.Length ; i++)
            {
                grilla.Columns[col[i]].Visible = flag[i];
            }
        }



        void cargar_parametrizacion(DataGridView grilla)
        {
            int i = 0;
            int x = 0;
            foreach (DataGridViewRow row in dgv_parametrizacion.Rows)
            {

                cant_col++;

            }

            vec_col = new int[cant_col];
            vec_falg = new bool[cant_col];

            foreach (DataGridViewRow row in dgv_parametrizacion.Rows)
            {

                vec_col[i] = Convert.ToInt32(row.Cells["ColumnaId"].Value);
                vec_falg[x] = Convert.ToBoolean(row.Cells["Visible"].Value);

                i++;
                x++;             
            }

            ocultar_mostrar_columnas(grilla, vec_col, vec_falg);
        }

        void formatear_grilla(DataGridView grilla)
        {

            try
            {
                util.FormatearGrilla(grilla,false);

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
            if (dgv_pedidos.Rows.Count > 1000)
            {
                DialogResult resul = MessageBox.Show("La cantidad de registros que desea exportar es muy grande y demorará, se recomienda filtrar esta información. ¿Desea exportar de todas maneras?", "Precaución", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {

                    util.mensaje_espera("Exportando, por favor espere", true, lbl_contador_registros, lbl_msg, ss_load, true);
                    util.ExportarDataGridViewExcel(dgv_pedidos, tsl_titulo.Text);
                    util.mensaje_espera("Exportando, por favor espere", true, lbl_contador_registros, lbl_msg, ss_load, false);
                    return;
                }
                else
                {
                    return;
                }
            }
            util.ExportarDataGridViewExcel(dgv_pedidos, tsl_titulo.Text);
            
            
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar.Focus();
            txt_buscar.Clear();

            dgv_pedidos.DataSource = AccesoLogica.listar_requemiento_seguimiento(txt_tipo_l.Text);
            formatear_grilla(dgv_pedidos);

            if (dgv_pedidos.Rows.Count != 0)
            {
                txt_buscar.Enabled = true;
                filtro = dgv_pedidos.Columns[0].HeaderText;

                dgv_pedidos.CurrentCell = dgv_pedidos.Rows[0].Cells[0];
                columna = dgv_pedidos.CurrentCell.ColumnIndex;
            }

            chk_aceros.Checked = false;
        }

        #endregion

        #region Eventos

        private void FrmInformeSegReq_Load(object sender, EventArgs e)
        {
            util.FormatearFormulario(this, ts_acciones, tc_pedido, ss_load, txt_buscar, tp_listado, tp_nuevo, tp_auditoria);
            this.Location = new System.Drawing.Point(320, 80);


            dgv_parametrizacion.DataSource = AccesoLogica.listar_parametros_usuario(usuario, 8001);
            cargar_parametrizacion(dgv_pedidos);
          

          
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            (dgv_pedidos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" +" ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
            lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_pedidos.Rows.Count);
        }

        private void tc_pedido_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!allowSelect) e.Cancel = true;
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

        private void rb_servicios_l_CheckedChanged(object sender, EventArgs e)
        {
            txt_tipo_l.Text = rb_servicios_l.Text;
         
            lbl_buscar.Text = "Buscar";
            txt_buscar.Clear();
            
 
            dgv_parametrizacion.DataSource = AccesoLogica.listar_parametros_usuario(usuario, 8002);

            dgv_pedidos.DataSource = null;
            dgv_pedidos.DataSource = AccesoLogica.listar_requemiento_seguimiento(txt_tipo_l.Text);
            cargar_parametrizacion(dgv_pedidos);
            formatear_grilla(dgv_pedidos);
          

            if (dgv_pedidos.Rows.Count != 0)
            {
                txt_buscar.Enabled = true;
                filtro = dgv_pedidos.Columns[0].HeaderText;

                try
                {
                    dgv_pedidos.CurrentCell = dgv_pedidos.Rows[0].Cells[0];
                    columna = dgv_pedidos.CurrentCell.ColumnIndex;
                }
                catch (Exception)
                {  
                }
                
            }

            chk_aceros.Visible = false;
            chk_aceros.Checked = false;
        }

        private void rb_materiales_l_CheckedChanged(object sender, EventArgs e)
        {
            txt_tipo_l.Text = rb_materiales_l.Text;
            lbl_buscar.Text = "Buscar";
            txt_buscar.Clear();

            dgv_parametrizacion.DataSource = AccesoLogica.listar_parametros_usuario(usuario, 8001);

            dgv_pedidos.DataSource = null;
            dgv_pedidos.DataSource = AccesoLogica.listar_requemiento_seguimiento(txt_tipo_l.Text);
            formatear_grilla(dgv_pedidos);

            if (dgv_pedidos.Rows.Count != 0)
            {
                txt_buscar.Enabled = true;
                filtro = dgv_pedidos.Columns[0].HeaderText;

                dgv_pedidos.CurrentCell = dgv_pedidos.Rows[0].Cells[0];
                columna = dgv_pedidos.CurrentCell.ColumnIndex;
            }

            chk_aceros.Visible = true;
            chk_aceros.Checked = false;
        }
        
        #endregion

        #region Menu contextual
        private void cm_grilla_copia_Click(object sender, EventArgs e)
        {
            util.copiar_contextual(dgv_pedidos);
        }

        private void cm_grilla_copia_tabla_Click(object sender, EventArgs e)
        {
            util.copiar_todo_encabezados(dgv_pedidos);
        }

        private void cm_log_modificaciones_Click(object sender, EventArgs e)
        {
            FrmLogModificaciones log = new FrmLogModificaciones();
            log.requerimiento = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Requerimiento"].Value);
            log.ShowDialog(this);
        }
        #endregion

        private void chk_aceros_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_aceros.Checked == true)
            {
                (dgv_pedidos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[Cod. Partida]" + " ,'System.String') LIKE '%{0}%'", "123");
                lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_pedidos.Rows.Count);
            }
            else
            {
                dgv_pedidos.DataSource = AccesoLogica.listar_requemiento_seguimiento("Materiales");
                formatear_grilla(dgv_pedidos);

                if (dgv_pedidos.Rows.Count != 0)
                {
                    posicion = 0;
                    txt_buscar.Enabled = true;
                    filtro = dgv_pedidos.Columns[1].HeaderText;

                    try
                    {
                        dgv_pedidos.CurrentCell = dgv_pedidos.Rows[0].Cells[1];
                        columna = dgv_pedidos.CurrentCell.ColumnIndex;
                    }
                    catch
                    { }
                }
            }

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btn_parametrizacion_Click(object sender, EventArgs e)
        {
            FrmParametrizacion parametrizacion = new FrmParametrizacion();
            parametrizacion.formulario = "FrmInformeSegReq";
            parametrizacion.usuario = usuario;

            if (txt_tipo_l.Text == "Materiales")
            {
                parametrizacion.grilla = "dgv_pedidos";
                parametrizacion.GrillaId = 8001;
            }

            if (txt_tipo_l.Text == "Servicios")
            {
                parametrizacion.grilla = "dgv_servicios";
                parametrizacion.GrillaId = 8002;

            }

            parametrizacion.ShowDialog(this);
        }

        private void verPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_pedidos.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para mostrar", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }


            if (txt_tipo_l.Text == "Materiales")
            {
                try
                {
                    pedido = Convert.ToInt32(dgv_pedidos.CurrentRow.Cells["Nro Pedido (OC)"].Value);
                }

                catch
                {
                    MessageBox.Show("No Existe Pedido", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;
                
                }
                
                   
            }

            if (txt_tipo_l.Text == "Servicios")
            {

                pedido = Convert.ToInt32(dgv_pedidos.CurrentRow.Cells["Nro Pedido (OS)"].Value);

                if (pedido == 0)
                {
                    MessageBox.Show("No Existe Pedido", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            CrvPedido reporte = new CrvPedido();
            reporte.pedido = pedido;
            reporte.ShowDialog(this);


        }

        private void verNotaDeIngresovalorizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_pedidos.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para mostrar", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            
            ni = Convert.ToInt32(dgv_pedidos.CurrentRow.Cells["Ult. NI"].Value); 

            if (txt_tipo_l.Text == "Materiales")
            {
                //try
                //{
                //    //CrvPedido reporte = new CrvPedido();
                //    //reporte.pedido = pedido;
                //    //reporte.ShowDialog(this);
                //}

                //catch
                //{
                //    //MessageBox.Show("No Existe Pedido", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                //    //return;

                //}


            }

            if (txt_tipo_l.Text == "Servicios")
            {

                try
                {
                    CrvNotaIngreso reporte = new CrvNotaIngreso();
                    reporte.ni = ni;
                    reporte.ShowDialog(this);
                }

                catch
                {
                    MessageBox.Show("No Existe Pedido", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;

                }
            }          
        }

        private void BW_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                util.ExportarDataGridViewExcel(dgvExportar, ptitulo);
            }
            catch (Exception)
            {                
                throw;
            }            
        }

        private void BW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            util.mensaje_espera("Exportando, por favor espere", true, lbl_contador_registros, lbl_msg, ss_load, false);
        }                     
    }
}
