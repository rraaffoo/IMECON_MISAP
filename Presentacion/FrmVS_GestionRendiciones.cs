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
    public partial class FrmVS_GestionRendiciones : Form, IForm_opciones //, IForm_filtro
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

        private string proyecto;

        private Documents documento;
        private StockTransfer documentos;

        private SAPbobsCOM.SBObob oSBObob;
        #endregion

        #region Formulario

        public FrmVS_GestionRendiciones()
        {
            InitializeComponent();
            ts_acciones.Renderer = new MyRenderer();
        }
        public FrmVS_GestionRendiciones(string pproyecto)
        {
            InitializeComponent();
            ts_acciones.Renderer = new MyRenderer();
            proyecto = pproyecto;
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
                if (par5 == "Listado de SD")
                {
                    txtSolicitud.Text = par1;
                    txtMonto.Text = par3;
                    cboMoneda.SelectedValue = par4=="SOL"?"1":"2";
                }
                if (par5 == "Listado de Rendiciones")
                {
                    string[] cadena1 = par1.Split('|');
                    txtCodigoRend.Text = cadena1[0];
                    txtOT.Text = cadena1[1];
                    txtFecha.Text = par2;
                    string[] cadena2 = par3.Split('|');
                    txtEmpleadoCod.Text = cadena2[0];
                    txtEmpleadoDesc.Text = cadena2[1];
                    string[] cadena3 = par4.Split('|');
                    txtMontoRend.Text = cadena3[0];
                    cboMonedaRend.SelectedValue = cadena3[1]=="SOL"?"1":"2";
                }
                //if (par5 == "Listado de Cuentas")
                //{
                //    txtCuenta.Text = par1;
                //    txtCuentaDesc.Text = par2;                    
                //}
                //if (par5 == "Listado de Cuentas de Rendición")
                //{
                //    txtCuentaRendicion.Text = par1;
                //    txtCuentaRendicionDesc.Text = par2;
                //}

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
            //cargar_combo_proyecto();
            //cargar_combo_almacen();
            //cargar_combo_ubicacion();
            //cargar_combo_cuenta();
            cargar_combo_moneda();
            cargar_combo_moneda_rend();
            //cargar_combo_ctaRendicion();
            //cargar_combo_estado();
            //dgvListado.DataSource = Negocio.VS_Listar_SD_AsigRendiciones(proyecto);
            formatear_grilla(dgvListado);
            if (dgvListado.Rows.Count > 0)
            {
                dgvListado.MultiSelect = false;
                dgvListado.MultiSelect = true;
                dgvListado.Rows[0].Selected = true;

                //DataGridViewRow row = dgvListado.Rows[0];
                //txtProyecto.Text = row.Cells["CODIGO PROYECTO"].Value.ToString();
                //txtProyectoDesc.Text = row.Cells["DESC. PROYECTO"].Value.ToString();
                //txtAlmacen.Text = row.Cells["CODIGO ALMACEN"].Value.ToString();
                //txtAlmacenDesc.Text = row.Cells["CODIGO ALMACEN"].Value.ToString();
                //txtUbicacion.Text = row.Cells["idUbicacion"].Value.ToString();
                //txtUbicacionDesc.Text = row.Cells["idUbicacion"].Value.ToString();
                //txtCuenta.Text = row.Cells["codCuenta"].Value.ToString();
                //txtCuentaDesc.Text = row.Cells["codCuenta"].Value.ToString();
                //txtTotalCaja.Text = row.Cells["totalCaja"].Value.ToString();
                //cboMoneda.SelectedValue = row.Cells["moneda"].Value.ToString() == "SOL" ? "1" : "2";
                //txtCuentaRendicion.Text = row.Cells["codCuentaRen"].Value.ToString();
                //txtCuentaRendicionDesc.Text = row.Cells["codCuentaRen"].Value.ToString();
                //txtOT.Text = row.Cells["NRO OT"].Value.ToString();
                //cboEstado.SelectedValue = row.Cells["COD_ESTADO"].Value.ToString();
                //txtComentario.Text = row.Cells["comentarios"].Value.ToString();
            }
        }

        private void cargar_combo_moneda()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");
            DataRow dr;

            dr = dt.NewRow();
            dr["Codigo"] = "1";
            dr["Descripcion"] = "Soles";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "2";
            dr["Descripcion"] = "Dólares";
            dt.Rows.Add(dr);

            cboMoneda.DataSource = dt;
            cboMoneda.ValueMember = "Codigo";
            cboMoneda.DisplayMember = "Descripcion";

        }
        private void cargar_combo_moneda_rend()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");
            DataRow dr;

            dr = dt.NewRow();
            dr["Codigo"] = "1";
            dr["Descripcion"] = "Soles";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "2";
            dr["Descripcion"] = "Dólares";
            dt.Rows.Add(dr);

            cboMonedaRend.DataSource = dt;
            cboMonedaRend.ValueMember = "Codigo";
            cboMonedaRend.DisplayMember = "Descripcion";
        }

        private void cargar_combo_empleados()
        {
            //cboAlmacen.DataSource = Negocio.Listar_Empleados();
            //cboAlmacen.ValueMember = "empID";
            //cboAlmacen.DisplayMember = "fullName";
        }


        void formatear_grilla(DataGridView grilla)
        {
            try
            {
                util.FormatearGrilla(grilla, true);
                lbl_contador_registros.Visible = true;
                lbl_contador_registros.Text = string.Format("Total de registros: {0}", grilla.Rows.Count);
                //grilla.Columns["idUbicacion"].Visible = false;
                //grilla.Columns["codCuenta"].Visible = false;
                //grilla.Columns["totalCaja"].Visible = false;
                //grilla.Columns["codCuentaRen"].Visible = false;
                //grilla.Columns["COD_ESTADO"].Visible = false;
                //grilla.Columns["moneda"].Visible = false;
                //grilla.Columns["comentarios"].Visible = false;
                //grilla.Columns["monto"].DefaultCellStyle.Format = "#";
                //grilla.Columns["monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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

        private void dgv_det_pedidos_consulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex == -1)
            //    return;

            //if (dgv_det_pedidos_consulta.Columns[e.ColumnIndex].Name == "seleccion")
            //{
            //    DataGridViewRow row = dgv_det_pedidos_consulta.Rows[e.RowIndex];
            //    DataGridViewCheckBoxCell cellSelecion = row.Cells["seleccion"] as DataGridViewCheckBoxCell;

            //    if (Convert.ToBoolean(cellSelecion.Value))
            //    {
            //        btn_suprimir.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn));
            //        btn_suprimir.Enabled = true;

            //        row.DefaultCellStyle.BackColor = Color.FromArgb(252, 221, 130);
            //        contador = contador + 1;
            //    }
            //    else
            //    {
            //        row.DefaultCellStyle.BackColor = Color.FromArgb(231, 231, 231);
            //        contador = contador - 1;

            //        if (contador == 0)
            //        {
            //            btn_suprimir.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_desactivado));
            //            btn_suprimir.Enabled = false;
            //        }
            //    }
            //}
        }

        private void dgv_det_pedidos_consulta_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //if (dgv_det_pedidos_consulta.IsCurrentCellDirty)
            //{
            //    dgv_det_pedidos_consulta.CommitEdit(DataGridViewDataErrorContexts.Commit);

            //}
        }


        private void dgv_pedidos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            //txt_buscar.Focus();
            //txt_buscar.Clear();

            //filtro = dgv_pedidos.Columns[e.ColumnIndex].HeaderText;
            //lbl_buscar.Text = "Buscar en " + filtro;

            //dgv_pedidos.CurrentCell = dgv_pedidos.Rows[0].Cells[e.ColumnIndex];

        }

        private void dgv_pedidos_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgv_pedidos.Rows.Count == 0)
            //{
            //    MessageBox.Show("No Existe Informacion para consultar", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //    return;
            //}

            //util.EstablecerAuditoria("Consultar", usuario, "", "FrmMUsuario", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            //if (perfil == "001" || perfil == "008")
            //{
            //    activar_boton(false, false, false, false, true, true, true, true, true, true, false, false, true, true, false, false, false, false, true);
            //}
            //else
            //{
            //    activar_boton(false, false, false, false, true, true, true, true, true, true, false, false, false, false, false, false, false, false, true);
            //}


            //btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
            //tc_pedido.TabPages.Add(tp_nuevo);

            //tp_nuevo.Text = @"Consultar";

            //allowSelect = true;
            //tc_pedido.SelectedIndex = 1;
            //allowSelect = false;

            //txt_ot.Visible = true;
            //txt_cod_ot.Visible = true;
            //txt_responsable.Visible = true;

            //cbo_responsable.Visible = false;
            //cbo_num_ord.Visible = false;

            //rb_materiales.Enabled = false;
            //rb_servicios.Enabled = false;


            //if (rb_materiales_l.Checked == true)
            //{
            //    rb_materiales.Checked = true;

            //}

            //if (rb_servicios_l.Checked == true)
            //{
            //    rb_servicios.Checked = true;

            //}


            //if (rb_activos_l.Checked == true)
            //{
            //    rb_activos.Checked = true;

            //}

            //cdg_origen.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["cdg_origen"].Value);
            //txt_pedido.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Requerimiento"].Value);
            //txt_ot.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Descripcion"].Value);
            //txt_obs.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Observacion"].Value);
            //txt_responsable.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Responsable"].Value);
            //txt_fecha.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Fecha"].Value);
            //txt_estado.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Estado"].Value);
            //txt_U_CDG_USER.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Solicitante"].Value);
            //txt_U_CL_CODSOL.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["U_CL_CODSOL"].Value);
            //txt_U_CL_SOLICI.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["U_CL_SOLICI"].Value);
            //txt_proyecto.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["PrjName"].Value);
            //txt_cod_proyecto.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["PrjCode"].Value);
            // txt_cod_ot.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["OT"].Value);
            //txt_ot.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Descripcion"].Value);
            //dp_fecha_necesaria.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Fec. Req."].Value);
            //txt_DocEntry.Text =  Convert.ToString(dgv_pedidos.CurrentRow.Cells["Documento SAP"].Value);

            //dgv_det_pedidos.Visible = false;

            //dgv_det_pedidos_consulta.DataSource = AccesoLogica.consultar_detalle_ped_misap(txt_tipo_l.Text, txt_pedido.Text, cdg_origen.Text);
            //formatear_grilla(dgv_det_pedidos_consulta);
        }


        private void cbo_proyecto_SelectionChangeCommitted(object sender, EventArgs e)
        {



        }

        private void dgv_pedidos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        
        private void cboMoneda_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboMoneda_Enter(object sender, EventArgs e)
        {
            cboMoneda.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboMoneda_Leave(object sender, EventArgs e)
        {
            cboMoneda.BackColor = Color.White;
        }

        private void cboMonedaRend_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cboMonedaRend_Enter(object sender, EventArgs e)
        {
            cboMonedaRend.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cboMonedaRend_Leave(object sender, EventArgs e)
        {
            cboMonedaRend.BackColor = Color.White;
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
                //DataGridViewRow row = dgvListado.Rows[e.RowIndex];
                //txtProyecto.Text = row.Cells["CODIGO PROYECTO"].Value.ToString();
                //txtProyectoDesc.Text = row.Cells["DESC. PROYECTO"].Value.ToString();
                ////cboProyecto.SelectedValue = row.Cells["CODIGO PROYECTO"].Value.ToString();
                //txtAlmacen.Text = row.Cells["CODIGO ALMACEN"].Value.ToString();
                //txtAlmacenDesc.Text = row.Cells["CODIGO ALMACEN"].Value.ToString();
                //txtUbicacion.Text = row.Cells["idUbicacion"].Value.ToString();
                //txtUbicacionDesc.Text = row.Cells["idUbicacion"].Value.ToString();
                //txtCuenta.Text = row.Cells["codCuenta"].Value.ToString();
                //txtCuentaDesc.Text = row.Cells["codCuenta"].Value.ToString();
                //txtTotalCaja.Text = row.Cells["totalCaja"].Value.ToString();
                //cboMoneda.SelectedValue = row.Cells["moneda"].Value.ToString()=="SOL"?"1":"2";
                //txtCuentaRendicion.Text = row.Cells["codCuentaRen"].Value.ToString();
                //txtCuentaRendicionDesc.Text = row.Cells["codCuentaRen"].Value.ToString();
                //txtOT.Text = row.Cells["NRO OT"].Value.ToString();
                //cboEstado.SelectedValue = row.Cells["COD_ESTADO"].Value.ToString();
                //txtComentario.Text = row.Cells["comentarios"].Value.ToString();
            }
        }

        private void btnBuscarSD_Click(object sender, EventArgs e)
        {
            string pcodigo = "";
            string pfecha = "";
            string pestado = "A";
            string pcodProy = proyecto;
            FrmVS_Opciones opciones = new FrmVS_Opciones(pcodigo, pfecha, pestado, pcodProy);
            opciones.titulo = "Listado de SD";
            opciones.ShowDialog(this);
        }

        private void btnBuscaRendicion_Click(object sender, EventArgs e)
        {
            string pcodigo = "";
            string pfecha = "";
            string pestado = "";
            string pcodProy = proyecto;
            FrmVS_Opciones opciones = new FrmVS_Opciones(pcodigo, pfecha, pestado, pcodProy);
            opciones.titulo = "Listado de Rendiciones";
            opciones.ShowDialog(this);
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
