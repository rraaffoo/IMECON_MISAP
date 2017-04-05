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
using SAPbobsCOM;
using System.Configuration;
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace MISAP
{
    public partial class FrmVS_GastoMantenimiento : Form, IForm_opciones //, IForm_filtro
    {
        #region Variables globales

        public string usuario, perfil, bd_sap;

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
        bool Ejecucion = false;

        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();
        FrmEspera espera = new FrmEspera();

        private string pdocEntry;
        string flagOperacion;
        public string impuesto;
        public string pcodProy;
        public string pOt;
        public string docEntryGC;

        private Documents documento;
        private StockTransfer documentos;

        private SAPbobsCOM.SBObob oSBObob;
        #endregion

        #region Formulario

        public FrmVS_GastoMantenimiento()
        {
            InitializeComponent();
            ts_acciones.Renderer = new MyRenderer();
        }
        public FrmVS_GastoMantenimiento(string docEntry)
        {
            InitializeComponent();
            ts_acciones.Renderer = new MyRenderer();
            pdocEntry = docEntry;
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
                this.SetBounds(this.Location.X, this.Location.Y, 862, 663);
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
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));

                lbl_maximi.Text = "0";
            }
            else
            {
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
                this.SetBounds(this.Location.X, this.Location.Y, 862, 663);
                this.Location = new System.Drawing.Point(320, 80);

                lbl_maximi.Text = "1";
            }

        }

        private void titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

            //pos = new Point(e.X, e.Y);
            //move = true;
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

        public void pasar_valores(string par1, string par2, string par3, string par4, string par5, string par6)
        {
            try
            {
                if (par5 == "Listado de Articulos")
                {
                    txtArticuloCod.Text = par1;
                    txtArticuloDesc.Text = par2;
                    txtUnidadMedida.Text = par3;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Orden de Producción", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
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
            if (e.Index < 0)
                return;

            ComboBox combo = sender as ComboBox;

            // DataRowView drv = ((DataRowView)(combo.Items[e.Index]));
            //   string name = drv[display].ToString();


            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(252, 220, 130)), e.Bounds);
            else
                e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);

            e.Graphics.DrawString(combo.Items[e.Index].ToString(), e.Font, new SolidBrush(combo.ForeColor), new System.Drawing.Point(e.Bounds.X, e.Bounds.Y));


            e.DrawFocusRectangle();
        }

        #endregion

        #region Eventos

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            //cargar_combo_tipo_documento();
            //cargar_combo_moneda();
            //cargar_combo_tipo();
            //dtpFecha.Value = DateTime.Now;
            dgvListado.DataSource = Negocio.VS_Listar_Gasto_detalle(pdocEntry);
            txtdocEntry.Text = pdocEntry;
            txtcodProy.Text = pcodProy;
            txtnroOT.Text = pOt;
            txtdocEntryGC.Text = docEntryGC;
            totalizar();
            formatear_grilla(dgvListado);
            if (dgvListado.Rows.Count > 0)
            {
                dgvListado.MultiSelect = false;
                dgvListado.MultiSelect = true;
                dgvListado.Rows[0].Selected = true;

                pasar_dgv_to_txt(0);                
            }
        }

        private void configuracion_inicial_controles()
        {
            txtArticuloCod.BackColor = SystemColors.Control;
            txtArticuloDesc.BackColor = SystemColors.Control;
            txtUnidadMedida.BackColor = SystemColors.Control;
            txtCantidad.BackColor = SystemColors.Control;
            txtPrecioUnitario.BackColor = SystemColors.Control;

            txtCantidad.ReadOnly = true;
            txtPrecioUnitario.ReadOnly = true;

            btnNuevo.Visible = true;
            btnModificar.Visible = true;
            btnSuprimir.Visible = true;
            btnGrabar.Visible = false;
            btnCancelar.Visible = false;
            
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            btnSuprimir.Enabled = true;
            dgvListado.Enabled = true;
            btnBuscarArticulo.Visible = false;
        }

        private void pasar_dgv_to_txt(int rownum)
        {
            DataGridViewRow row = dgvListado.Rows[rownum];
            txtArticuloCod.Text = row.Cells["ccodArt"].Value.ToString();
            txtArticuloDesc.Text = row.Cells["cdesArt"].Value.ToString();
            txtUnidadMedida.Text = row.Cells["cundMed"].Value.ToString();
            txtCantidad.Text = row.Cells["ccant"].Value.ToString();
            txtPrecioUnitario.Text = row.Cells["cprecio"].Value.ToString();
            txtdocEntryGC.Text = row.Cells["cdocEntryGC"].Value.ToString();
            txtlineId.Text = row.Cells["clineId"].Value.ToString();
            txtcodProy.Text = row.Cells["ccodProy"].Value.ToString();
            txtnroOT.Text = row.Cells["cnroOT"].Value.ToString();
            txtdocEntry1.Text = row.Cells["cdocEntry"].Value.ToString();
        }

        
        private void totalizar()
        {
            try
            {
                decimal total = 0;
                foreach (DataGridViewRow row in dgvListado.Rows)
                {
                    total = total + Convert.ToDecimal(row.Cells["cPrecioTotal"].Value.ToString());
                }
                txtTotalAntes.Text = total.ToString();
                txtImpuesto.Text = decimal.Round((Convert.ToDecimal(impuesto) * total/100),2).ToString();
                txtTotalDocumento.Text = decimal.Round((Convert.ToDecimal(txtTotalAntes.Text) + Convert.ToDecimal(txtImpuesto.Text)),2).ToString();
                }
            catch (Exception ex)
            {
                util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
            }
        }

        

        private void cargar_combo_tipo_documento()
        {
            //cboTipoDocumento.DataSource = Negocio.VS_Listar_Parametro("tipo_documento","busqueda");
            //cboTipoDocumento.ValueMember = "CODIGO";
            //cboTipoDocumento.DisplayMember = "DESCRIPCION";
        }


        void formatear_grilla(DataGridView grilla)
        {
            try
            {
                util.FormatearGrilla(grilla, true);
                lbl_contador_registros.Visible = true;
                lbl_contador_registros.Text = string.Format("Total de registros: {0}", grilla.Rows.Count);
                //grilla.Columns["lineId"].Visible = false;
                grilla.Columns["cuenta"].Visible = false;
                //grilla.Columns["codProy"].Visible = false;
                //grilla.Columns["nroOT"].Visible = false;
                //grilla.Columns["docEntryGC"].Visible = false;
                grilla.Columns["codCentroCosto1"].Visible = false;
                grilla.Columns["codCentroCosto2"].Visible = false;
                grilla.Columns["codCentroCosto3"].Visible = false;
                grilla.Columns["codCentroCosto4"].Visible = false;
                grilla.Columns["codCentroCosto5"].Visible = false;
                grilla.Columns["nomCentroCosto1"].Visible = false;
                grilla.Columns["nomCentroCosto2"].Visible = false;
                grilla.Columns["nomCentroCosto3"].Visible = false;
                grilla.Columns["nomCentroCosto4"].Visible = false;
                grilla.Columns["nomCentroCosto5"].Visible = false;
                //grilla.Columns["monto"].DefaultCellStyle.Format = "#";
                
                grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
        }

        private void tc_usuario_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!allowSelect) e.Cancel = true;
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {


            //(dgv_pedidos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" + " ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
            //lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_pedidos.Rows.Count);


        }

        private void cbo_anio_SelectedValueChanged(object sender, EventArgs e)
        {
            //anio = cbo_anio.Text;

            //if (cbo_anio.Text == "Todos")
            //{
            //    anio = "";
            //}

            //if (rb_materiales_l.Checked == true)
            //{
            //    dgv_pedidos.DataSource = AccesoLogica.listar_pedidos_misap("", anio, usuario,perfil);
            //    formatear_grilla(dgv_pedidos);
            //}

            //if (rb_servicios_l.Checked == true)
            //{
            //    dgv_pedidos.DataSource = AccesoLogica.listar_servicios("", anio,usuario,perfil);
            //    formatear_grilla(dgv_pedidos);
            //}


        }

        private void cbo_anio_Click(object sender, EventArgs e)
        {
            //txt_buscar.Clear();
        }

        private void cbo_num_ord_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //carga combo responsable
            //cbo_responsable.DataSource = AccesoLogica.listar_responsable_misap(cbo_num_ord.SelectedValue.ToString());
            //cbo_responsable.DisplayMember = "Descripcion";
            //cbo_responsable.ValueMember = "Codigo";
            //cbo_responsable.SelectedItem = null;
            //cbo_responsable.Enabled = true;
            //cbo_responsable.Focus();

            //txt_proyecto.Text = Convert.ToString(AccesoLogica.listar_proyectos_sap(cbo_num_ord.SelectedValue.ToString()).Rows[0][1]);
            //txt_cod_proyecto.Text =  Convert.ToString(AccesoLogica.listar_proyectos_sap(cbo_num_ord.SelectedValue.ToString()).Rows[0][0]);


            // txt_cliente.Text = Convert.ToString(AccesoLogica.obtener_cliente(cbo_num_ord.SelectedValue.ToString()).Rows[0]["des_cli"]);
        }

        private void cbo_responsable_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //int empID;

            //empID = Convert.ToInt32(cbo_responsable.SelectedValue.ToString());

            //responsable = Convert.ToString(AccesoLogica.consultar_empelado(empID).Rows[0]["U_CDG_USER"]);
            //btn_agregar.Enabled = true;
            //btn_agregar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
        }

        private void txt_obs_Enter(object sender, EventArgs e)
        {
            //txt_obs.BackColor = Color.FromArgb(254, 240, 158);
            //if (!String.IsNullOrEmpty(txt_obs.Text))
            //{
            //    txt_obs.SelectionStart = 0;
            //    txt_obs.SelectionLength = txt_obs.Text.Length;
            //}
        }

        private void txt_obs_Leave(object sender, EventArgs e)
        {
            //txt_obs.BackColor = Color.White;
        }

        private void txt_obs_MouseClick(object sender, MouseEventArgs e)
        {
            //if (!String.IsNullOrEmpty(txt_obs.Text))
            //{
            //    txt_obs.SelectionStart = 0;
            //    txt_obs.SelectionLength = txt_obs.Text.Length;
            //}
        }

        private void rb_materiales_CheckedChanged(object sender, EventArgs e)
        {
            //dp_fecha_necesaria.Enabled = true;
            //cbo_num_ord.Enabled = true;
            //cbo_num_ord.Focus();

            //txt_tipo.Text = rb_materiales.Text;
            //txt_pedido.Text = Convert.ToString(AccesoLogica.obtener_num_ped("MAT").Rows[0][0]);
            //num_ped = txt_pedido.Text;
        }
        private void rb_servicios_CheckedChanged(object sender, EventArgs e)
        {

            //dp_fecha_necesaria.Enabled = true;
            //cbo_num_ord.Enabled = true;
            //cbo_num_ord.Focus();

            //txt_tipo.Text = rb_servicios.Text;
            //txt_pedido.Text = Convert.ToString(AccesoLogica.obtener_num_ped("SER").Rows[0][0]);
            //num_ped = txt_pedido.Text;

        }
        private void rb_activos_CheckedChanged(object sender, EventArgs e)
        {
            //dp_fecha_necesaria.Enabled = true;
            //cbo_num_ord.Enabled = true;
            //cbo_num_ord.Focus();

            //txt_tipo.Text = rb_activos.Text;
            //txt_pedido.Text = Convert.ToString(AccesoLogica.obtener_num_ped("MAT").Rows[0][0]);
            //num_ped = txt_pedido.Text;
        }

        private void rb_todos_CheckedChanged(object sender, EventArgs e)
        {

            //try
            //{
            //    txt_buscar.Clear();
            //    cbo_anio.SelectedIndex = -1;
            //    rb_materiales.Checked = true;
            //    dgv_pedidos.DataSource = AccesoLogica.listar_pedidos_misap("", "", usuario,perfil);
            //    formatear_grilla(dgv_pedidos);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Valorizaciones", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            //}


        }

        private void dgv_pedidos_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            //txt_buscar.Focus();
            //txt_buscar.Clear();

            //filtro = dgv_pedidos.Columns[e.ColumnIndex].HeaderText;
            //lbl_buscar.Text = "Buscar en " + filtro;

            //dgv_pedidos.CurrentCell = dgv_pedidos.Rows[0].Cells[e.ColumnIndex];

            //columna = dgv_pedidos.CurrentCell.ColumnIndex;


        }

        private void rb_servicios_l_CheckedChanged(object sender, EventArgs e)
        {
            //txt_tipo_l.Text = rb_servicios_l.Text;
            //lbl_buscar.Text = "Buscar";
            //txt_buscar.Clear();
            //dgv_pedidos.DataSource = AccesoLogica.listar_servicios("", anio,usuario,perfil);
            //formatear_grilla(dgv_pedidos);

            //if (dgv_pedidos.Rows.Count != 0)
            //{
            //    txt_buscar.Enabled = true;
            //    filtro = dgv_pedidos.Columns[0].HeaderText;

            //    dgv_pedidos.CurrentCell = dgv_pedidos.Rows[0].Cells[0];
            //    columna = dgv_pedidos.CurrentCell.ColumnIndex;
            //}
        }

        private void rb_materiales_l_CheckedChanged(object sender, EventArgs e)
        {
            //txt_tipo_l.Text = rb_materiales_l.Text;
            //lbl_buscar.Text = "Buscar";
            //txt_buscar.Clear();
            //dgv_pedidos.DataSource = AccesoLogica.listar_pedidos_misap("", anio, usuario,perfil);
            //formatear_grilla(dgv_pedidos);

            //if (dgv_pedidos.Rows.Count != 0)
            //{
            //    txt_buscar.Enabled = true;
            //    filtro = dgv_pedidos.Columns[0].HeaderText;

            //    dgv_pedidos.CurrentCell = dgv_pedidos.Rows[0].Cells[0];
            //    columna = dgv_pedidos.CurrentCell.ColumnIndex;
            //}
        }

        private void rb_activos_l_CheckedChanged(object sender, EventArgs e)
        {
            //txt_tipo_l.Text = rb_activos_l.Text;
            //lbl_buscar.Text = "Buscar";
            //txt_buscar.Clear();
            //dgv_pedidos.DataSource = AccesoLogica.listar_activos("", anio, usuario, perfil);
            //formatear_grilla(dgv_pedidos);

            //dgv_pedidos.Columns["Cod. Autorizacion"].Visible = false;

            //if (dgv_pedidos.Rows.Count != 0)
            //{
            //    txt_buscar.Enabled = true;
            //    filtro = dgv_pedidos.Columns[0].HeaderText;

            //    dgv_pedidos.CurrentCell = dgv_pedidos.Rows[0].Cells[0];
            //    columna = dgv_pedidos.CurrentCell.ColumnIndex;
            //}
        }

        private void cbo_num_ord_Enter(object sender, EventArgs e)
        {
            //cbo_num_ord.BackColor = Color.FromArgb(254, 240, 158);
            //if (!String.IsNullOrEmpty(cbo_num_ord.Text))
            //{
            //    cbo_num_ord.SelectionStart = 0;
            //    cbo_num_ord.SelectionLength = cbo_num_ord.Text.Length;
            //}
        }

        private void cbo_num_ord_Leave(object sender, EventArgs e)
        {
            //cbo_num_ord.BackColor = Color.White;
        }

        private void cbo_num_ord_MouseClick(object sender, MouseEventArgs e)
        {
            //if (!String.IsNullOrEmpty(cbo_num_ord.Text))
            //{
            //    cbo_num_ord.SelectionStart = 0;
            //    cbo_num_ord.SelectionLength = cbo_num_ord.Text.Length;
            //}
        }

        private void cbo_responsable_Enter(object sender, EventArgs e)
        {
            //cbo_responsable.BackColor = Color.FromArgb(254, 240, 158);
            //if (!String.IsNullOrEmpty(cbo_responsable.Text))
            //{
            //    cbo_responsable.SelectionStart = 0;
            //    cbo_responsable.SelectionLength = cbo_responsable.Text.Length;
            //}
        }

        private void cbo_responsable_Leave(object sender, EventArgs e)
        {
            //cbo_responsable.BackColor = Color.White;
        }

        private void cbo_responsable_MouseClick(object sender, MouseEventArgs e)
        {
            //if (!String.IsNullOrEmpty(cbo_responsable.Text))
            //{
            //    cbo_responsable.SelectionStart = 0;
            //    cbo_responsable.SelectionLength = cbo_responsable.Text.Length;
            //}
        }

        private void btn_ejecutar_SP_Click(object sender, EventArgs e)
        {
            //dgv_plantilla.DataSource = AccesoLogica.ejecutar_sp_imerp(txt_sp.Text, "", "", "");
            //formatear_grilla(dgv_plantilla);
            //dgv_plantilla_d.DataSource = AccesoLogica.ejecutar_sp_imerp(txt_sp_d.Text, "", "", "");
            //formatear_grilla(dgv_plantilla_d);
        }

        
        

        #endregion

        #region Funciones

        void activar_boton(
            bool nuevo,
            bool editar,
            bool consultar,
            bool eliminar,
            bool imprimir,
            bool primero,
            bool anterior,
            bool siguiente,
            bool ultimo,
            bool previsualizar,
            bool exportar_xls,
            bool plantilla,
            bool aprobar,
            bool desaprobar,
            bool actualizar,
            bool filtro,
            bool ayuda,
            bool grabar,
            bool cancelar)
        {
            btn_nuevo_b.Enabled = nuevo;
            btn_editar_b.Enabled = editar;
            btn_consultar_b.Enabled = consultar;
            btn_eliminar_b.Enabled = eliminar;
            btn_imprimir.Enabled = imprimir;
            btn_primero.Enabled = primero;
            btn_anterior.Enabled = anterior;
            btn_siguiente.Enabled = siguiente;
            btn_utlimo.Enabled = ultimo;
            btn_previsualizar.Enabled = previsualizar;
            btn_exportar_xls.Enabled = exportar_xls;
            btn_plantilla.Enabled = plantilla;
            btn_aprobar.Enabled = aprobar;
            btn_desaprobar.Enabled = desaprobar;
            btn_actualizar.Enabled = actualizar;
            btn_filtro.Enabled = filtro;
            btn_grabar.Enabled = grabar;
            btn_cancelar.Enabled = cancelar;

        }
        void activar_campos(bool cdg_usr, bool dni, bool des_usr, bool correo, bool perfil, bool swt_usr)
        {


        }

        void generar_codigo_autorizacion()
        {

            Random obj = new Random();
            string posibles = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int longitud = posibles.Length;
            char letra;
            int longitudnuevacadena = 5;
            string nuevacadena = "";

            for (int i = 0; i < longitudnuevacadena; i++)
            {
                letra = posibles[obj.Next(longitud)];
                nuevacadena += letra.ToString();
            }

            //txt_codigo_autorizacion.Text = nuevacadena;

        }
        void mensaje(string msg, bool tipo)
        {
            //tipo true=exito false=error

            if (tipo == true)
            {

                lbl_contador_registros.Visible = false;
                ss_load.BackColor = Color.FromArgb(127, 182, 123);
                lbl_msg.ForeColor = Color.Black;
                lbl_msg.Text = msg;
                t_msg.Start();
            }

            if (tipo == false)
            {
                lbl_contador_registros.Visible = false;
                ss_load.BackColor = Color.FromArgb(204, 0, 0);
                lbl_msg.ForeColor = Color.White;
                lbl_msg.Text = msg;
                t_msg.Start();
            }


        }

        void limpiar()
        {
            // txt_buscar.Clear();

            // txt_estado_registro.Clear();
            // txt_fec_crea.Clear();
            // txt_formulario.Clear();

            // txt_operacion.Clear();
            // txt_terminal_crea.Clear();
            // txt_usr_crea.Clear();

            // txt_estado.Clear();
            // txt_fecha.Clear();
            // txt_pedido.Clear();
            // txt_obs.Clear();
            // txt_proyecto.Clear();

            // txt_cod_ot.Clear();
            // txt_cod_proyecto.Clear();

            // dgv_det_pedidos.Rows.Clear();
            // cbo_responsable.SelectedIndex = -1;
            // cbo_num_ord.SelectedIndex = -1;

            // rb_materiales.Checked = false;
            // rb_servicios.Checked = false;

            // cbo_responsable.Enabled = false;
            // cbo_num_ord.Enabled = false;

            // rb_materiales_l.Checked = true;
            // rb_servicios_l.Checked = false;

            // dp_fecha_necesaria.Enabled = false;
            // btn_suprimir.Enabled = false;
            // txt_obs.ReadOnly = true;

            // btn_agregar.Enabled = false;

            //// txt_cod_proyecto.Visible = false;
            // txt_cod_ot.Visible = false;

            //if (dgv_det_pedidos.Rows.Count != 0)
            //{
            //    DataTable dtg = (DataTable)dgv_det_pedidos.DataSource;
            //    dtg.Clear();
            //}


        }


        void valida_permisos(string perfil)
        {
            if (perfil == "001")
            {
                activar_boton(true, true, true, true, true, false, false, false, false, true, true, true, false, false, true, true, true, true, true);
            }
            if (perfil == "007")
            {
                activar_boton(true, true, true, true, true, false, false, false, false, true, true, false, false, false, true, true, true, true, true);
            }
            if (perfil == "008")
            {
                activar_boton(true, true, true, true, true, false, false, false, false, true, true, false, false, false, true, true, true, true, true);
            }

            if (perfil == "009")
            {
                activar_boton(true, true, true, true, true, false, false, false, false, true, true, false, false, false, true, true, true, true, true);
            }
        }




        private StringBuilder htmlMessageBody(DataGridView dg)
        {
            StringBuilder strB = new StringBuilder();
            //create html & table
            strB.AppendLine("<html><body><center><table border='1' cellpadding='0' cellspacing='0'>");
            strB.AppendLine("<tr>");
            //cteate table header
            for (int i = 0; i < dg.Columns.Count; i++)
            {
                strB.AppendLine("<td align='center' valign='middle'>" + dg.Columns[i].HeaderText + "</td>");
            }
            //create table body
            strB.AppendLine("<tr>");
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                strB.AppendLine("<tr>");
                foreach (DataGridViewCell dgvc in dg.Rows[i].Cells)
                {
                    strB.AppendLine("<td align='center' valign='middle'>" + dgvc.Value.ToString() + "</td>");
                }
                strB.AppendLine("</tr>");

            }
            //table footer & end of html file
            strB.AppendLine("</table></center></body></html>");
            return strB;
        }







        #endregion






        private void t_msg_Tick(object sender, EventArgs e)
        {
            lbl_msg.Text = string.Empty;

            ss_load.BackColor = Color.Transparent;
            lbl_contador_registros.Visible = true;
            lbl_msg.Visible = false;
        }

        private void tp_nuevo_Click(object sender, EventArgs e)
        {

        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                pasar_dgv_to_txt(e.RowIndex);
            }
        }

        private void btnBuscarSD_Click(object sender, EventArgs e)
        {
            //string pcodigo = "";
            //string pfecha = "";
            //string pestado = "A";
            //string pcodProy = proyecto;
            FrmVS_Opciones opciones = new FrmVS_Opciones();
            opciones.titulo = "Listado de Articulos";
            opciones.ShowDialog(this);
        }

        private void btnBuscaRendicion_Click(object sender, EventArgs e)
        {
            //string pcodigo = "";
            //string pfecha = "";
            //string pestado = "";
            //string pcodProy = proyecto;
            //FrmVS_Opciones opciones = new FrmVS_Opciones(pcodigo, pfecha, pestado, pcodProy);
            //opciones.titulo = "Listado de Rendiciones";
            //opciones.ShowDialog(this);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtArticuloCod.BackColor = SystemColors.Window;
            txtArticuloDesc.BackColor = SystemColors.Window;
            txtUnidadMedida.BackColor = SystemColors.Window;
            txtCantidad.BackColor = SystemColors.Window;
            txtPrecioUnitario.BackColor = SystemColors.Window;

            txtArticuloCod.Text = "";
            txtArticuloDesc.Text = "";
            txtUnidadMedida.Text = "";
            txtCantidad.Text = "";
            txtPrecioUnitario.Text = "";
            

            txtCantidad.ReadOnly = false;
            txtPrecioUnitario.ReadOnly = false;
            btnNuevo.Visible = true;
            btnModificar.Visible = false;
            btnSuprimir.Visible = false; 
            btnGrabar.Visible = true;
            btnCancelar.Visible = true;

            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnSuprimir.Enabled = false; 

            btnBuscarArticulo.Visible = true;

            flagOperacion = "nuevo";
            dgvListado.Enabled = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            configuracion_inicial_controles();

            try
            {
                if (flagOperacion == "nuevo")
                {
                    Negocio.VS_OOGD_RegMod(0, 0, txtArticuloCod.Text, txtArticuloDesc.Text, txtUnidadMedida.Text, txtCantidad.Text, txtPrecioUnitario.Text, txtdocEntryGC.Text, txtcodProy.Text, txtnroOT.Text, 0);
                    
                    util.mensaje("Se creó el registro de manera exitosa", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                }

                if (flagOperacion == "modificar")
                {
                    Negocio.VS_OOGD_RegMod(Convert.ToInt32(txtdocEntry1.Text), Convert.ToInt32(txtlineId.Text), txtArticuloCod.Text, txtArticuloDesc.Text, txtUnidadMedida.Text, txtCantidad.Text, txtPrecioUnitario.Text, txtdocEntryGC.Text, txtcodProy.Text, txtnroOT.Text, 0);
                    
                    util.mensaje("Se modificó el registro de manera exitosa", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                }
                dgvListado.DataSource = Negocio.VS_Listar_Gasto_detalle(pdocEntry);
                formatear_grilla(dgvListado);
                totalizar();
            }
            catch (Exception ex)
            {
                util.mensaje("Error: " + ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
            }


            if (dgvListado.Rows.Count > 0)
            {
                dgvListado.MultiSelect = false;
                dgvListado.MultiSelect = true;
                dgvListado.Rows[0].Selected = true;

                pasar_dgv_to_txt(0);
                totalizar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            configuracion_inicial_controles();

            if (dgvListado.Rows.Count > 0)
            {
                dgvListado.MultiSelect = false;
                dgvListado.MultiSelect = true;
                dgvListado.Rows[0].Selected = true;

                pasar_dgv_to_txt(0);
                totalizar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtArticuloCod.BackColor = SystemColors.Window;
            txtArticuloDesc.BackColor = SystemColors.Window;
            txtUnidadMedida.BackColor = SystemColors.Window;
            txtCantidad.BackColor = SystemColors.Window;
            txtPrecioUnitario.BackColor = SystemColors.Window;
                        
            txtCantidad.ReadOnly = false;
            txtPrecioUnitario.ReadOnly = false;
            btnNuevo.Visible = false;
            btnModificar.Visible = true;
            btnSuprimir.Visible = false;
            btnGrabar.Visible = true;
            btnCancelar.Visible = true;

            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnSuprimir.Enabled = false;

            btnBuscarArticulo.Visible = true;

            flagOperacion = "modificar";
            dgvListado.Enabled = false;
        }

        private void btnSuprimir_Click(object sender, EventArgs e)
        {
            configuracion_inicial_controles();
            
            DialogResult resul = MessageBox.Show("¿Está seguro que quiere eliminar este Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                try
                {
                    Negocio.VS_OOGD_Eliminar(Convert.ToInt32(txtdocEntry1.Text));
                    util.mensaje("Se eliminó el registro de manera exitosa", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    dgvListado.DataSource = Negocio.VS_Listar_Gasto_detalle(pdocEntry);
                    formatear_grilla(dgvListado);
                    totalizar();
                }
                catch (Exception ex)
                {
                    util.mensaje("Error: " + ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                }

                if (dgvListado.Rows.Count > 0)
                {
                    dgvListado.MultiSelect = false;
                    dgvListado.MultiSelect = true;
                    dgvListado.Rows[0].Selected = true;
                    pasar_dgv_to_txt(0);
                    totalizar();
                }
            }
        }

        private void dgvListado_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData & Keys.KeyCode)
            {
                case Keys.Up:
                case Keys.Enter:
                case Keys.Right:
                case Keys.Down:
                case Keys.Left:
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
            }
        }
    }
}