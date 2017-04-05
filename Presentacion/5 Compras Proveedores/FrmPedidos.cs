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
    public partial class FrmPedidos : Form, IForm_opciones, IForm_filtro
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

        string filtro, num_ped, cdg_prod, cdg_eqv, num_ord, usr_crea, fec_crea, swt_est, obs_item, Proyecto, docEntry, TipoSolicitud,
            usract, tipact, fecact, horact, anio, cdgemp, textbody, msg,responsable,estado, ItemDescription, UM, IP; 
        int columna, posicion, contador, line_sap, DocEntry, pedido, cant_item = 0, contador_equipo_ti=0, contador_otros=0;
        decimal can_ped, can_desp, can_ing, fac_eqv, can_cmp, can_ocom, swt_apr, swt_rev, web_num, cja_chk;

        private Documents documento;
        private StockTransfer documentos;
       
        private SAPbobsCOM.SBObob oSBObob;
        #endregion

        #region Formulario

        public FrmPedidos()
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
                if (par5 == "Lista de materiales")
                {
                    if (txt_operacion.Text == "Nuevo")
                    {
                        #region validaciones

                        //cant_item = dgv_det_pedidos.Rows.Count;
                        

                        //if (cant_item >= 10)
                        //{
                        //    //MessageBox.Show("No se puede realizar requerimientos con mas de 10 Items", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        //     mensaje("No se puede generar requerimientos con mas de 10 Items", false);
                        //    return;
                        //}

                        foreach (DataGridViewRow row in dgv_det_pedidos.Rows)
                        {

                            if (par1 == Convert.ToString(row.Cells["cdgprod"].Value))
                            {

                                util.mensaje("El articulo " + par1 + " ya existe en el requerimiento", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                                return;
                            }
                            
                            
                                                                              
                        }

                       
                        #endregion


                        dgv_det_pedidos.Rows.Add(par1, par2, par3, par4, "0.00", "0.00",par6);
                        formatear_grilla(dgv_det_pedidos);

                        int i;
                        for (i = 0; i <= dgv_det_pedidos.Rows.Count - 1; i++)
                        {
                            dgv_det_pedidos.Rows[i].HeaderCell.Value = (i + 1).ToString();
                        }

                        btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                        activar_boton(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true);

                        rb_materiales.Enabled = false;
                        rb_servicios.Enabled = false;
                        rb_activos.Enabled = false;

                        btn_suprimir.Enabled = true;
                        btn_suprimir.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn));

                        txt_obs.Enabled = true;
                        txt_obs.ReadOnly = false;
                    }

                    if (txt_operacion.Text == "Editar")
                    {
                        #region validaciones
                        foreach (DataGridViewRow row_ in dgv_det_pedidos_consulta.Rows)
                        {

                            if (par1 == Convert.ToString(row_.Cells["Codigo"].Value))
                            {
                                MessageBox.Show("El articulo ya existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                                return;
                            }
                        }


                        #endregion

                        DataTable dt = dgv_det_pedidos_consulta.DataSource as DataTable;

                        DataRow row = dt.NewRow();

                        row["#"] = dgv_det_pedidos_consulta.Rows.Count + 1;
                        row["Codigo"] = par1;
                        row["Material"] = par2;
                        row["U.M."] = par3;
                        row["Cant. pedida"] = par4;
                       


                        int i;
                        for (i = 0; i <= dgv_det_pedidos_consulta.Rows.Count - 1; i++)
                        {

                            dgv_det_pedidos_consulta.Rows[i].Cells["#"].Value = (i + 1).ToString();
                        }

                        dt.Rows.Add(row);
                        formatear_grilla(dgv_det_pedidos_consulta);

                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Orden de Producción", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        public void pasar_valores_filtro(string par1, string par2, string par3, string par4, string par5, string par6, string par7, string par8, string par9, string par10,string par11)
        {
            try
            {


                dgv_pedidos.DataSource = AccesoLogica.listar_pedidos_filtro(par1, par2, par3, par4, par5, par6, par7, par8, par9, par10, par11);
                formatear_grilla(dgv_pedidos);
                   

                

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
            this.Activate();

            valida_permisos(perfil);

            util.FormatearFormulario(this, ts_acciones, tc_pedido, ss_load, txt_buscar, tp_listado, tp_nuevo, tp_auditoria);
            this.Location = new System.Drawing.Point(320, 80);
            tc_pedido.TabPages.Remove(tp_plantilla);
            tp_plantilla.BackColor = Color.FromArgb(247, 247, 247);



            cbo_anio.Text = anio;
            anio = DateTime.Now.Year.ToString();

            try
            {
                cbo_anio.Text = anio;
            }

            catch (Exception ex)
            { 
            
            }
                txt_tipo_l.Text = "Materiales";
            dgv_pedidos.DataSource = AccesoLogica.listar_pedidos_misap("", anio, usuario, perfil);
            formatear_grilla(dgv_pedidos);
           

            if (dgv_pedidos.Rows.Count != 0)
            {
                posicion = 0;
                txt_buscar.Enabled = true;
                filtro = dgv_pedidos.Columns[1].HeaderText;

                dgv_pedidos.CurrentCell = dgv_pedidos.Rows[0].Cells[1];
                columna = dgv_pedidos.CurrentCell.ColumnIndex;
            }
           
        }
        
        private void tc_usuario_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!allowSelect) e.Cancel = true;
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {


            (dgv_pedidos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" + " ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
            lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_pedidos.Rows.Count);


        }

        private void cbo_anio_SelectedValueChanged(object sender, EventArgs e)
        {
            anio = cbo_anio.Text;
            
            if (cbo_anio.Text == "Todos")
            {
                anio = "";
            }
            
            if (rb_materiales_l.Checked == true)
            {
                dgv_pedidos.DataSource = AccesoLogica.listar_pedidos_misap("", anio, usuario,perfil);
                formatear_grilla(dgv_pedidos);
            }

            if (rb_servicios_l.Checked == true)
            {
                dgv_pedidos.DataSource = AccesoLogica.listar_servicios("", anio,usuario,perfil);
                formatear_grilla(dgv_pedidos);
            }

            
        }

        private void cbo_anio_Click(object sender, EventArgs e)
        {
          txt_buscar.Clear();
        }

        private void cbo_num_ord_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //carga combo responsable
            cbo_responsable.DataSource = AccesoLogica.listar_responsable_misap(cbo_num_ord.SelectedValue.ToString());
            cbo_responsable.DisplayMember = "Descripcion";
            cbo_responsable.ValueMember = "Codigo";
            cbo_responsable.SelectedItem = null;
            cbo_responsable.Enabled = true;
            cbo_responsable.Focus();

            txt_proyecto.Text = Convert.ToString(AccesoLogica.listar_proyectos_sap(cbo_num_ord.SelectedValue.ToString()).Rows[0][1]);
            txt_cod_proyecto.Text =  Convert.ToString(AccesoLogica.listar_proyectos_sap(cbo_num_ord.SelectedValue.ToString()).Rows[0][0]);
          
          
      // txt_cliente.Text = Convert.ToString(AccesoLogica.obtener_cliente(cbo_num_ord.SelectedValue.ToString()).Rows[0]["des_cli"]);
        }
        
        private void cbo_responsable_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int empID;

            empID = Convert.ToInt32(cbo_responsable.SelectedValue.ToString());
           
            responsable = Convert.ToString(AccesoLogica.consultar_empelado(empID).Rows[0]["U_CDG_USER"]);
            btn_agregar.Enabled = true;
            btn_agregar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
        }

        private void txt_obs_Enter(object sender, EventArgs e)
        {
            txt_obs.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txt_obs.Text))
            {
                txt_obs.SelectionStart = 0;
                txt_obs.SelectionLength = txt_obs.Text.Length;
            }
        }

        private void txt_obs_Leave(object sender, EventArgs e)
        {
            txt_obs.BackColor = Color.White;
        }

        private void txt_obs_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_obs.Text))
            {
                txt_obs.SelectionStart = 0;
                txt_obs.SelectionLength = txt_obs.Text.Length;
            }
        }

        private void rb_materiales_CheckedChanged(object sender, EventArgs e)
        {
            dp_fecha_necesaria.Enabled = true;
            cbo_num_ord.Enabled = true;
            cbo_num_ord.Focus();

            txt_tipo.Text = rb_materiales.Text;
            txt_pedido.Text = Convert.ToString(AccesoLogica.obtener_num_ped("MAT").Rows[0][0]);
            num_ped = txt_pedido.Text;
        }
        private void rb_servicios_CheckedChanged(object sender, EventArgs e)
        {

            dp_fecha_necesaria.Enabled = true;
            cbo_num_ord.Enabled = true;
            cbo_num_ord.Focus();

            txt_tipo.Text = rb_servicios.Text;
            txt_pedido.Text = Convert.ToString(AccesoLogica.obtener_num_ped("SER").Rows[0][0]);
            num_ped = txt_pedido.Text;
            
        }
        private void rb_activos_CheckedChanged(object sender, EventArgs e)
        {
            dp_fecha_necesaria.Enabled = true;
            cbo_num_ord.Enabled = true;
            cbo_num_ord.Focus();

            txt_tipo.Text = rb_activos.Text;
            txt_pedido.Text = Convert.ToString(AccesoLogica.obtener_num_ped("MAT").Rows[0][0]);
            num_ped = txt_pedido.Text;
        }

        private void rb_todos_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                txt_buscar.Clear();
                cbo_anio.SelectedIndex = -1;
                rb_materiales.Checked = true;
                dgv_pedidos.DataSource = AccesoLogica.listar_pedidos_misap("", "", usuario,perfil);
                formatear_grilla(dgv_pedidos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Valorizaciones", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }


        }

        private void dgv_pedidos_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar.Focus();
            txt_buscar.Clear();

            filtro = dgv_pedidos.Columns[e.ColumnIndex].HeaderText;
            lbl_buscar.Text = "Buscar en " + filtro;

            dgv_pedidos.CurrentCell = dgv_pedidos.Rows[0].Cells[e.ColumnIndex];

            //columna = dgv_pedidos.CurrentCell.ColumnIndex;


        }

        private void rb_servicios_l_CheckedChanged(object sender, EventArgs e)
        {
            txt_tipo_l.Text = rb_servicios_l.Text;
            lbl_buscar.Text = "Buscar";
            txt_buscar.Clear();
            dgv_pedidos.DataSource = AccesoLogica.listar_servicios("", anio,usuario,perfil);
            formatear_grilla(dgv_pedidos);

            if (dgv_pedidos.Rows.Count != 0)
            {
                txt_buscar.Enabled = true;
                filtro = dgv_pedidos.Columns[0].HeaderText;

                dgv_pedidos.CurrentCell = dgv_pedidos.Rows[0].Cells[0];
                columna = dgv_pedidos.CurrentCell.ColumnIndex;
            }
        }

        private void rb_materiales_l_CheckedChanged(object sender, EventArgs e)
        {
            txt_tipo_l.Text = rb_materiales_l.Text;
            lbl_buscar.Text = "Buscar";
            txt_buscar.Clear();
            dgv_pedidos.DataSource = AccesoLogica.listar_pedidos_misap("", anio, usuario,perfil);
            formatear_grilla(dgv_pedidos);

            if (dgv_pedidos.Rows.Count != 0)
            {
                txt_buscar.Enabled = true;
                filtro = dgv_pedidos.Columns[0].HeaderText;

                dgv_pedidos.CurrentCell = dgv_pedidos.Rows[0].Cells[0];
                columna = dgv_pedidos.CurrentCell.ColumnIndex;
            }
        }

        private void rb_activos_l_CheckedChanged(object sender, EventArgs e)
        {
            txt_tipo_l.Text = rb_activos_l.Text;
            lbl_buscar.Text = "Buscar";
            txt_buscar.Clear();
            dgv_pedidos.DataSource = AccesoLogica.listar_activos("", anio, usuario, perfil);
            formatear_grilla(dgv_pedidos);

            dgv_pedidos.Columns["Cod. Autorizacion"].Visible = false;

            if (dgv_pedidos.Rows.Count != 0)
            {
                txt_buscar.Enabled = true;
                filtro = dgv_pedidos.Columns[0].HeaderText;

                dgv_pedidos.CurrentCell = dgv_pedidos.Rows[0].Cells[0];
                columna = dgv_pedidos.CurrentCell.ColumnIndex;
            }
        }

        private void cbo_num_ord_Enter(object sender, EventArgs e)
        {
            cbo_num_ord.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(cbo_num_ord.Text))
            {
                cbo_num_ord.SelectionStart = 0;
                cbo_num_ord.SelectionLength = cbo_num_ord.Text.Length;
            }
        }

        private void cbo_num_ord_Leave(object sender, EventArgs e)
        {
            cbo_num_ord.BackColor = Color.White;
        }

        private void cbo_num_ord_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(cbo_num_ord.Text))
            {
                cbo_num_ord.SelectionStart = 0;
                cbo_num_ord.SelectionLength = cbo_num_ord.Text.Length;
            }
        }

        private void cbo_responsable_Enter(object sender, EventArgs e)
        {
            cbo_responsable.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(cbo_responsable.Text))
            {
                cbo_responsable.SelectionStart = 0;
                cbo_responsable.SelectionLength = cbo_responsable.Text.Length;
            }
        }

        private void cbo_responsable_Leave(object sender, EventArgs e)
        {
            cbo_responsable.BackColor = Color.White;
        }

        private void cbo_responsable_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(cbo_responsable.Text))
            {
                cbo_responsable.SelectionStart = 0;
                cbo_responsable.SelectionLength = cbo_responsable.Text.Length;
            }
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
            if (e.RowIndex == -1)
                return;

            if (dgv_det_pedidos_consulta.Columns[e.ColumnIndex].Name == "seleccion")
            {
                DataGridViewRow row = dgv_det_pedidos_consulta.Rows[e.RowIndex];
                DataGridViewCheckBoxCell cellSelecion = row.Cells["seleccion"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(cellSelecion.Value))
                {
                    btn_suprimir.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn));
                    btn_suprimir.Enabled = true;

                    row.DefaultCellStyle.BackColor = Color.FromArgb(252, 221, 130);
                    contador = contador + 1;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(231, 231, 231);
                    contador = contador - 1;

                    if (contador == 0)
                    {
                        btn_suprimir.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_desactivado));
                        btn_suprimir.Enabled = false;
                    }
                }
            }
        }

        private void dgv_det_pedidos_consulta_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_det_pedidos_consulta.IsCurrentCellDirty)
            {
                dgv_det_pedidos_consulta.CommitEdit(DataGridViewDataErrorContexts.Commit);

            }
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

        private void dgv_pedidos_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_pedidos.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para consultar", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            util.EstablecerAuditoria("Consultar", usuario, "", "FrmMUsuario", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            if (perfil == "001" || perfil == "008")
            {
                activar_boton(false, false, false, false, true, true, true, true, true, true, false, false, true, true, false, false, false, false, true);
            }
            else
            {
                activar_boton(false, false, false, false, true, true, true, true, true, true, false, false, false, false, false, false, false, false, true);
            }


            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
            tc_pedido.TabPages.Add(tp_nuevo);

            tp_nuevo.Text = @"Consultar";

            allowSelect = true;
            tc_pedido.SelectedIndex = 1;
            allowSelect = false;

            txt_ot.Visible = true;
            txt_cod_ot.Visible = true;
            txt_responsable.Visible = true;

            cbo_responsable.Visible = false;
            cbo_num_ord.Visible = false;

            rb_materiales.Enabled = false;
            rb_servicios.Enabled = false;


            if (rb_materiales_l.Checked == true)
            {
                rb_materiales.Checked = true;

            }

            if (rb_servicios_l.Checked == true)
            {
                rb_servicios.Checked = true;

            }


            if (rb_activos_l.Checked == true)
            {
                rb_activos.Checked = true;

            }

            cdg_origen.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["cdg_origen"].Value);
            txt_pedido.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Requerimiento"].Value);
            txt_ot.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Descripcion"].Value);
            txt_obs.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Observacion"].Value);
            txt_responsable.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Responsable"].Value);
            txt_fecha.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Fecha"].Value);
            txt_estado.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Estado"].Value);
            txt_U_CDG_USER.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Solicitante"].Value);
            txt_U_CL_CODSOL.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["U_CL_CODSOL"].Value);
            txt_U_CL_SOLICI.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["U_CL_SOLICI"].Value);
            txt_proyecto.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["PrjName"].Value);
            txt_cod_proyecto.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["PrjCode"].Value);
             txt_cod_ot.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["OT"].Value);
            txt_ot.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Descripcion"].Value);
            dp_fecha_necesaria.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Fec. Req."].Value);
            txt_DocEntry.Text =  Convert.ToString(dgv_pedidos.CurrentRow.Cells["Documento SAP"].Value);

            dgv_det_pedidos.Visible = false;

            dgv_det_pedidos_consulta.DataSource = AccesoLogica.consultar_detalle_ped_misap(txt_tipo_l.Text, txt_pedido.Text, cdg_origen.Text);
            formatear_grilla(dgv_det_pedidos_consulta);
        }


        private void cbo_proyecto_SelectionChangeCommitted(object sender, EventArgs e)
        {



        }

        private void dgv_pedidos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

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

                txt_codigo_autorizacion.Text = nuevacadena;
        
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
            txt_buscar.Clear();
           
            txt_estado_registro.Clear();
            txt_fec_crea.Clear();
            txt_formulario.Clear();

            txt_operacion.Clear();
            txt_terminal_crea.Clear();
            txt_usr_crea.Clear();

            txt_estado.Clear();
            txt_fecha.Clear();
            txt_pedido.Clear();
            txt_obs.Clear();
            txt_proyecto.Clear();

            txt_cod_ot.Clear();
            txt_cod_proyecto.Clear();

            dgv_det_pedidos.Rows.Clear();
            cbo_responsable.SelectedIndex = -1;
            cbo_num_ord.SelectedIndex = -1;

            rb_materiales.Checked = false;
            rb_servicios.Checked = false;

            cbo_responsable.Enabled = false;
            cbo_num_ord.Enabled = false;

            rb_materiales_l.Checked = true;
            rb_servicios_l.Checked = false;

            dp_fecha_necesaria.Enabled = false;
            btn_suprimir.Enabled = false;
            txt_obs.ReadOnly = true;

            btn_agregar.Enabled = false;

           // txt_cod_proyecto.Visible = false;
            txt_cod_ot.Visible = false;

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

                if (grilla == dgv_pedidos)
                {
                    dgv_pedidos.Columns["cdg_origen"].Visible = false;
                    dgv_pedidos.Columns["U_CL_CODSOL"].Visible = false;
                    dgv_pedidos.Columns["U_CL_SOLICI"].Visible = false;
                   
                    lbl_contador_registros.Visible = true;
                    lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_pedidos.Rows.Count);
                }

                if (grilla == dgv_det_pedidos)
                {
                    grilla.RowHeadersVisible = true;
                    lbl_contador_registros.Visible = true;
                    lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_det_pedidos.Rows.Count);
       
                }

                if (grilla == dgv_det_pedidos_consulta)
                {
                    if (txt_operacion.Text == "Consultar")
                    {
                        dgv_det_pedidos_consulta.Columns["seleccion"].Visible = false;
                    }

                    if (txt_operacion.Text == "Editar")
                    {
                        dgv_det_pedidos_consulta.Columns["seleccion"].Visible = true;
                    }
                    dgv_det_pedidos_consulta.Columns["#"].Visible = false;
                    lbl_contador_registros.Visible = true;
                    lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_det_pedidos_consulta.Rows.Count);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Fabricación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        void valida_permisos(string perfil)
        {
            if (perfil == "001")
            {
                activar_boton(true, true, true, true, true, false,false,false,false, true, true, true, false, false, true,true, true, true, true);
            }
            if (perfil == "007")
            {
                activar_boton(true, true, true, true, true, false,false,false,false, true, true, false, false, false, true,true, true, true, true);
            }
            if (perfil == "008")
            {
                activar_boton(true, true, true, true, true, false,false,false,false, true, true, false, false, false, true,true, true, true, true);
            }

            if (perfil == "009")
            {
                activar_boton(true, true, true, true, true, false, false, false, false, true, true, false, false, false, true, true, true, true, true);
            }
        }


        private bool EnviarEmail_aprobacion()
        {
            textbody =
           "<br/>" + "Estimados:" + "<br>" +
           "<br/>" + "El requerimiento Nº " + num_ped + " para la OT Nº " + num_ord + "\r\n" +
           "<br/>" + " fue aprobado el " + DateTime.Now.ToString() + " por el usuario: " + usuario +  " generando la solicitud de " + TipoSolicitud + " Nº: " + docEntry +  "<br>" +
            "<br/>" + " " + "\r\n" +
           "<br/>" + " " + "\r\n" +
           "<br/>" + "Administrador MISAP" + "<br>" + 
           "<br/>" + " BD SAP : " + bd_sap  + "<br>";
            
            MailMessage msg = new MailMessage();

            msg.To.Add(usr_crea + "@imecon.com.pe");
            msg.CC.Add("aprobacion_misap@imecon.com.pe");
            msg.From = new MailAddress("misap@imecon.com.pe", "Modulo de Interfaz SAP", System.Text.Encoding.UTF8);
            msg.Subject = "REQUERIMIENTO Nº " + num_ped + " APROBADO POR " + usuario;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = textbody;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true; //Si vas a enviar un correo con contenido html entonces cambia el valor a true


            //ADJUNTAR DOCUMENTO
            //System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment("\\\\10.0.0.8\\comun\\MCOP\\SOLICITUDES\\" + txt_nro_solicitud.Text + ".xls");
            //msg.Attachments.Add(attachment);

            //Aquí es donde se hace lo especial


            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("seg_docum@imecon.com.pe", "$3g#d0cum");
            client.Port = 587;
            client.Host = "smtp.gmail.com";//Este es el smtp valido para Gmail
            client.EnableSsl = true; //Esto es para que vaya a través de SSL que es obligatorio con GMail
            try
            {
                client.Send(msg);
                return true;
            }
            catch
            {
                return false;
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

        private bool EnviarEmail_rechazo()
        {
            textbody =
           "<br/>" + "Estimados:" + "<br>" +
           "<br/>" + "El requerimiento Nº " + num_ped + " para la OT Nº " + num_ord + "\r\n" +
           "<br/>" + " fue rechazado por: " + usuario + "<br>" +
            "<br/>" + " " + "\r\n" +
           "<br/>" + " " + "\r\n" +
           "<br/>" + "Administrador MISAP" + "<br>";

            MailMessage msg = new MailMessage();

            msg.To.Add(usr_crea + "@imecon.com.pe");
            msg.CC.Add("seg_docum@imecon.com.pe");
            msg.From = new MailAddress("misap@imecon.com.pe", "Modulo de Interfaz SAP", System.Text.Encoding.UTF8);
            msg.Subject = "REQUERIMIENTO Nº " + num_ped + " RECHAZADO POR " + usuario;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = textbody;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true; //Si vas a enviar un correo con contenido html entonces cambia el valor a true


            //ADJUNTAR DOCUMENTO
            //System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment("\\\\10.0.0.8\\comun\\MCOP\\SOLICITUDES\\" + txt_nro_solicitud.Text + ".xls");
            //msg.Attachments.Add(attachment);

            //Aquí es donde se hace lo especial


            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("seg_docum@imecon.com.pe", "$3g#d0cum");
            client.Port = 587;
            client.Host = "smtp.gmail.com";//Este es el smtp valido para Gmail
            client.EnableSsl = true; //Esto es para que vaya a través de SSL que es obligatorio con GMail
            try
            {
                client.Send(msg);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool EnviarEmail_solicitud_rechazo()
        {
            textbody =
           "<br/>" + "Estimados:" + "<br>" +
           "<br/>" + "El usuario " + usuario + " esta solicitando el rechazo del requerimiento Nº " + num_ped + " para la OT Nº " + num_ord + "\r\n" +
         //   "<br/>" + " con el siguiente detalle " + "\r\n" +
         //   htmlMessageBody(dgv_det_pedidos_consulta).ToString() +
            "<br/>" + " " + "\r\n" +
            "<br/>" + "Comentarios :" + txt_obs.Text +  "\r\n" +
            "<br/>" + " " + "\r\n" +
            "<br/>" + " " + "\r\n" +
            "<br/>" + "Administrador MISAP" + "<br>";

            MailMessage msg = new MailMessage();

            msg.To.Add(txt_aprobado_por.Text + "@imecon.com.pe");
            msg.CC.Add("eterrones@imecon.com.pe");
            msg.From = new MailAddress("misap@imecon.com.pe", "Modulo de Interfaz SAP", System.Text.Encoding.UTF8);
            msg.Subject = "SOLICITUD DE RECHAZO - REQUERIMIENTO Nº " + num_ped;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = textbody;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true; //Si vas a enviar un correo con contenido html entonces cambia el valor a true


            //ADJUNTAR DOCUMENTO
            //System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment("\\\\10.0.0.8\\comun\\MCOP\\SOLICITUDES\\" + txt_nro_solicitud.Text + ".xls");
            //msg.Attachments.Add(attachment);

            //Aquí es donde se hace lo especial


            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("seg_docum@imecon.com.pe", "$3g#d0cum");
            client.Port = 587;
            client.Host = "smtp.gmail.com";//Este es el smtp valido para Gmail
            client.EnableSsl = true; //Esto es para que vaya a través de SSL que es obligatorio con GMail
            try
            {
                client.Send(msg);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool EnviarEmail_pedido()
        {
           

            MailMessage msg = new MailMessage();


            #region envio JEFE DE TI


            if (txt_flag_activo_ti.Text == "1")
            {
               
               
                textbody =
                     "<br/>" + "Estimado:" + "<br>" +
                     "<br/>" + "El requerimiento Nº " + num_ped + " para la OT Nº " + num_ord + "\r\n" +
                     "<br/>" + " con codigo de autorizacion " + txt_codigo_autorizacion.Text +  " requiere de su aprobación" + "<br>" +
                     "<br/>" + txt_obs.Text + "\r\n" +
                     "<br/>" + " " + "\r\n" +
                     "<br/>" + " " + "\r\n" +
                     "<br/>" + "Administrador MISAP" + "<br>";
                
                    msg.To.Add("jefatura_ti@imecon.com.pe");

                            }
            else
            {
                textbody =
                    "<br/>" + "Estimado:" + "<br>" +
                    "<br/>" + "El requerimiento Nº " + num_ped + " para la OT Nº " + num_ord + "\r\n" +
                    "<br/>" + " requiere de su aprobación" + "<br>" +
                    "<br/>" + txt_obs.Text + "\r\n" +
                    "<br/>" + " " + "\r\n" +
                    "<br/>" + " " + "\r\n" +
                    "<br/>" + "Administrador MISAP" + "<br>";

                msg.To.Add(responsable + "@imecon.com.pe");
            }


            #endregion

          //  msg.To.Add(responsable + "@imecon.com.pe");
            msg.CC.Add("seg_docum@imecon.com.pe");
            msg.From = new MailAddress("misap@imecon.com.pe", "Modulo de Interfaz SAP", System.Text.Encoding.UTF8);
            msg.Subject = "REQUERIMIENTO Nº " + num_ped + " POR APROBAR";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = textbody;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true; //Si vas a enviar un correo con contenido html entonces cambia el valor a true


            //ADJUNTAR DOCUMENTO
            //System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment("\\\\10.0.0.8\\comun\\MCOP\\SOLICITUDES\\" + txt_nro_solicitud.Text + ".xls");
            //msg.Attachments.Add(attachment);

            //Aquí es donde se hace lo especial


            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("seg_docum@imecon.com.pe", "$3g#d0cum");
            client.Port = 587;
            client.Host = "smtp.gmail.com";//Este es el smtp valido para Gmail
            client.EnableSsl = true; //Esto es para que vaya a través de SSL que es obligatorio con GMail
            try
            {
                client.Send(msg);
                return true;
            }
            catch
            {
                return false;
            }
        }

        void insertar_auditoria(string operacion, string formulario, string tipo_doc, string nro_doc )
        {
            string strHostName = string.Empty;
            strHostName = Dns.GetHostName();


            IPAddress[] hostIPs = Dns.GetHostAddresses(strHostName);
            for (int i = 0; i < hostIPs.Length; i++) { IP = hostIPs[i].ToString(); }

            int resultado_auditoria = Negocio.insertar_OAUD(usuario, DateTime.Now.ToString("yyyy-MM-dd HH:mm"), Environment.MachineName, IP, Environment.UserName, operacion, formulario, tipo_doc, nro_doc);


        }
        #endregion

        #region Botones

        private void btn_nuevo_b_Click(object sender, EventArgs e)
        {
            limpiar();

            tc_pedido.TabPages.Add(tp_nuevo);
            tc_pedido.TabPages.Add(tp_auditoria);

            activar_boton(false, false, false, false, false, false, false, false, false,false, false, false, false, false, false,false, false, false, true);

            util.EstablecerAuditoria("Nuevo", usuario, "", "FrmPedidos", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            allowSelect = true;
            tc_pedido.SelectedIndex = 1;
            allowSelect = false;

            ////carga combo proyectos
            //cbo_proyecto.DataSource = AccesoLogica.listar_proyectos_sap();
            //cbo_proyecto.DisplayMember = "PrjName";
            //cbo_proyecto.ValueMember = "PrjCode";
            //cbo_proyecto.SelectedItem = null;

            txt_U_CDG_USER.Text = usuario;
            try
            {
                txt_U_CL_CODSOL.Text = Convert.ToString(AccesoLogica.obtener_usuario_SAP(usuario).Rows[0][0]);
                txt_U_CL_SOLICI.Text = Convert.ToString(AccesoLogica.obtener_usuario_SAP(usuario).Rows[0][1]);
            }
            catch
            {
                MessageBox.Show("El usuario no existe en el SAP o no se ha registrado el usuario MISAP en el maestro de empleados", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }

            
            
            txt_estado.Text = "PENDIENTE";

            //carga combo OT
            cbo_num_ord.DataSource = AccesoLogica.listar_ot_sap();
            cbo_num_ord.DisplayMember = "Descripcion";
            cbo_num_ord.ValueMember = "num_ord";
            cbo_num_ord.SelectedItem = null;
           
          

            txt_fecha.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
            dp_fecha_necesaria.CustomFormat = "yyyy-MM-dd HH:mm";
            dp_fecha_necesaria.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
            formatear_grilla(dgv_det_pedidos);

            rb_servicios.Enabled = true;
            rb_materiales.Enabled = true; 
            rb_activos.Enabled = true;

            generar_codigo_autorizacion();
            lbl_aprobado.Visible = false;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            
                if (rb_materiales.Checked == true)
                {
                    FrmOpciones opciones = new FrmOpciones();
                    opciones.titulo = "Lista de materiales";
                    opciones.ShowDialog(this);
                }

                if (rb_servicios.Checked == true)
                {
                    FrmOpciones opciones = new FrmOpciones();
                    opciones.titulo = "Lista de servicios";
                    opciones.ShowDialog(this);
                }

                if (rb_activos.Checked == true)
                {
                    FrmOpciones opciones = new FrmOpciones();
                    opciones.titulo = "Lista de activos";
                    opciones.ShowDialog(this);
                }
        }

        private void btn_suprimir_Click(object sender, EventArgs e)
        {

            #region Nuevo
            if (txt_operacion.Text == "Nuevo")
            {
                if (dgv_det_pedidos.Rows.Count != 0)
                {

                    //foreach (DataGridViewRow row in dgv_det_pedidos.Rows)
                    //{
                        
                    //    if (row.Selected == true)
                    //    {
                    //        dgv_det_pedidos.Rows.Remove(row);
                    //    }
                    //}


                    int fila = dgv_det_pedidos.CurrentRow.Index;
                    dgv_det_pedidos.Rows.RemoveAt(fila);

                    foreach (DataGridViewRow row in dgv_det_pedidos.Rows)
                    {

                        if (Convert.ToString(row.Cells["Cod_Familia"].Value) == "611")
                        {
                            contador_equipo_ti = contador_equipo_ti + 1;
                        }
                        else
                        {
                            contador_otros = contador_otros + 1;

                        }

                    }
                }
                else
                {
                    MessageBox.Show("No existen items para eliminar.", "Suprimir Items", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                    btn_suprimir.Enabled = false;
                    btn_suprimir.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_desactivado));
                }
            }
            #endregion 

            #region Editar
            if (txt_operacion.Text == "Editar")
            {
                num_ped = txt_pedido.Text;

                if (dgv_det_pedidos_consulta.Rows.Count != 0)
                {
                    if (rb_materiales.Checked == true)
                    {
                        //graba detalle
                        foreach (DataGridViewRow row in dgv_det_pedidos_consulta.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells["seleccion"].Value))
                            {

                                can_ped = Convert.ToInt32(row.Cells["Cant. pedida"].Value);
                                int linea = Convert.ToInt32(row.Cells["#"].Value);
                                cdg_prod = Convert.ToString(row.Cells["Codigo"].Value);

                                int resultado_d = Negocio.grabar_detalle_ped
                                    (num_ped, cdg_prod, can_ped, 0, 0, "", 0, 0, 0, num_ord,
                                     0, 0, "", "", "", "", usuario, 0, 0, "", txt_usr_modi.Text,
                                     txt_usr_modi.Text, "X", linea, txt_operacion.Text);
                                if (resultado_d == 0) Negocio = null;
                            }
                        }
                    }


                    List<DataGridViewRow> list = new List<DataGridViewRow>();

                    foreach (DataGridViewRow row in dgv_det_pedidos_consulta.Rows)
                    {              
	                    DataGridViewCheckBoxCell celdaseleccionada = row.Cells["seleccion"] as DataGridViewCheckBoxCell;

                        if (Convert.ToBoolean(celdaseleccionada.Value))
                            list.Add(row);
	
                   }

                foreach (DataGridViewRow row in list)	
                {
                    cdg_prod = Convert.ToString(row.Cells["Codigo"].Value);
                   	dgv_det_pedidos_consulta.Rows.Remove(row);

                }

                int i;
                for (i = 0; i <= dgv_det_pedidos_consulta.Rows.Count - 1; i++)
                {
                 
                  dgv_det_pedidos_consulta.Rows[i].Cells["#"].Value = (i + 1).ToString();
                }
                btn_suprimir.Enabled = false;
                btn_suprimir.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_desactivado));
              
                }
                else
                {
                    MessageBox.Show("No existen items para eliminar.", "Suprimir Items", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                    btn_suprimir.Enabled = false;
                    btn_suprimir.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_desactivado));
                }
            }
            #endregion
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            contador_equipo_ti = 0;
            contador_otros = 0;

            #region validaciones

            foreach (DataGridViewRow row in dgv_det_pedidos.Rows)
            {
                if (Convert.ToString(row.Cells["Cod_Familia"].Value)=="611")
                {
                    contador_equipo_ti = contador_equipo_ti + 1;
                    txt_flag_activo_ti.Text = "1";
                }
                else
                {
                    contador_otros = contador_otros + 1;
                }  
            }

            if (contador_equipo_ti != 0)
            {
                if (dgv_det_pedidos.Rows.Count != contador_equipo_ti)
                {
                    util.mensaje("No se permite agregar articulos de tipo Equipos informaticos con otros tipos de articulos en el mismo requerimiento",
                              false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    contador_equipo_ti = 0;
                    contador_otros = 0;
                    txt_flag_activo_ti.Text = "0";
                    return;
                }
            }

           

            #endregion

            #region Operacion Nuevo
            if (txt_operacion.Text == "Nuevo")
            {


                DialogResult result1 = MessageBox.Show("Desea registrar el pedido", "Mantenimiento de Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result1 == DialogResult.Yes)
                {
                    try
                    {
                        num_ord = cbo_num_ord.SelectedValue.ToString();
                        cdgemp = cbo_responsable.SelectedValue.ToString();




                        if (rb_materiales.Checked == true || rb_activos.Checked == true)
                        {

                           num_ped = Convert.ToString(AccesoLogica.obtener_num_ped("MAT").Rows[0][0]);


                            int resultado = Negocio.grabar_cabecera_ped
                                       (
                                         num_ped, txt_fecha.Text, num_ord, cdgemp, dp_fecha_necesaria.Text, txt_obs.Text,
                                         "", "", 0, 0, usuario, "", "", "", txt_usr_crea.Text, "", "", "", "", "", "", "", 0, "", txt_U_CL_CODSOL.Text, txt_U_CL_SOLICI.Text, txt_operacion.Text,txt_codigo_autorizacion.Text

                                       );
                            if (resultado == 0) Negocio = null;
                            
                            //graba detalle
                            foreach (DataGridViewRow row in dgv_det_pedidos.Rows)
                            {
                                
                                int linea = Convert.ToInt32(row.HeaderCell.Value);
                                cdg_prod = Convert.ToString(row.Cells["cdgprod"].Value);
                                ItemDescription = Convert.ToString(row.Cells["Material"].Value);
                                can_ped = Convert.ToDecimal(row.Cells["canped"].Value);
                                UM = Convert.ToString(row.Cells["med"].Value);
                                                            
                                int resultado_d = Negocio.grabar_detalle_ped
                                    (num_ped, cdg_prod, can_ped, 0, 0, "", 0, 0, 0, num_ord,
                                     0, 0, "", "", "", "", usuario, 0, 0, "", txt_usr_crea.Text,
                                     txt_usr_modi.Text, "P", linea, txt_operacion.Text);
                                if (resultado_d == 0) Negocio = null;

                            }


                            //actualizar nro_trans
                            int resultado_c = Negocio.actualizar_num_ped(num_ped, "num_ped_mat");
                            if (resultado_c == 0) Negocio = null;


                        }

                        #region Servicios

                        if (rb_servicios.Checked == true)
                        {
                                num_ped = Convert.ToString(AccesoLogica.obtener_num_ped("SER").Rows[0][0]);
                          

                            int resultado = Negocio.grabar_cabecera_ser
                                       (
                                         num_ped, txt_fecha.Text, num_ord, cdgemp, dp_fecha_necesaria.Text, txt_obs.Text,
                                         "", "", 0, usuario, "", txt_usr_crea.Text, "", "", "", "", "", "", "", "P", txt_U_CL_CODSOL.Text, txt_U_CL_SOLICI.Text, txt_operacion.Text
             
                                       );
                            if (resultado == 0) Negocio = null;


                            //graba detalle
                            foreach (DataGridViewRow row in dgv_det_pedidos.Rows)
                            {
                                cdg_prod = Convert.ToString(row.Cells["cdgprod"].Value);
                                can_ped = Convert.ToDecimal(row.Cells["canped"].Value);
                                int linea = Convert.ToInt32(row.HeaderCell.Value);

                                int resultado_d = Negocio.grabar_detalle_ser
                                    (num_ped, cdg_prod, can_ped, 0, 0, "", 0, 0, 0, num_ord,
                                     0, "", "", "", "", usuario,  txt_usr_crea.Text,
                                     "", "P", linea, txt_operacion.Text);
                                if (resultado_d == 0) Negocio = null;

                              

                            }

                            //actualizar nro_trans
                            int resultado_c = Negocio.actualizar_num_ped(num_ped, "num_ped_serv");
                            if (resultado_c == 0) Negocio = null;

                        }

                        #endregion


                        EnviarEmail_pedido();
                        MessageBox.Show("Operación finalizada con éxito.", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                      
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                    }

                    finally
                    {
                        
                   
                        #region auditoria
                        insertar_auditoria("Crear", "FrmPedidos", "REQ", num_ped);
                        #endregion 

                     

                        limpiar();

                        

                        if (txt_tipo.Text == "Materiales" || txt_tipo.Text == "Activo Fijo")
                        {
                            dgv_pedidos.DataSource = AccesoLogica.listar_pedidos_misap("", anio, usuario,perfil);
                            formatear_grilla(dgv_pedidos);
                            rb_materiales_l.Checked = true;

                        }

                        if (txt_tipo.Text == "Servicios")
                        {
                            dgv_pedidos.DataSource = AccesoLogica.listar_servicios("", anio,usuario,perfil);
                            formatear_grilla(dgv_pedidos);
                            rb_servicios_l.Checked = true;
                        }


                        valida_permisos(perfil);
                        btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));

                        btn_agregar.Enabled = false;
                        btn_agregar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
                        btn_suprimir.Enabled = false;
                        btn_suprimir.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));

                        dp_fecha_necesaria.Enabled = false;
                        txt_obs.Enabled = false;
                        txt_tipo.Clear();


                        tc_pedido.TabPages.Remove(tp_nuevo);
                        tc_pedido.TabPages.Remove(tp_auditoria);

                        allowSelect = true;
                        tc_pedido.SelectedIndex = 0;
                    }
                }
            }



            #endregion

            #region Operacion Editar

            if (txt_operacion.Text == "Editar")
            {


                DialogResult result2 = MessageBox.Show("Desea actualizar los datos", txt_operacion.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result2 == DialogResult.Yes)
                {
                    try
                    {
                        num_ped = txt_pedido.Text;
               
                        if (rb_materiales.Checked == true)
                        {


                            int resultado = Negocio.grabar_cabecera_ped
                                       (
                                         num_ped, txt_fecha.Text, num_ord, cdgemp, dp_fecha_necesaria.Text, txt_obs.Text,
                                         "", "", 0, 0, usuario, "", "", "", txt_usr_crea.Text, "", "", "", "", "", "", "", 0, "", txt_U_CL_CODSOL.Text, txt_U_CL_SOLICI.Text, txt_operacion.Text,""

                                       );
                            if (resultado == 0) Negocio = null;

                          
                            //graba detalle
                            foreach (DataGridViewRow row in dgv_det_pedidos_consulta.Rows)
                            {
                                can_ped = Convert.ToDecimal(row.Cells["Cant. pedida"].Value);
                                int linea = Convert.ToInt32(row.Cells["#"].Value);
                                cdg_prod = Convert.ToString(row.Cells["Codigo"].Value);
                                
                                int resultado_d = Negocio.grabar_detalle_ped
                                    (num_ped, cdg_prod , can_ped, 0, 0, "", 0, 0, 0, num_ord,
                                     0, 0, "", "", "", "", usuario, 0, 0, "", txt_usr_modi.Text,
                                     txt_usr_modi.Text, "P", linea, txt_operacion.Text);
                                if (resultado_d == 0) Negocio = null;

                            }

                        
                        }

                        if (rb_servicios.Checked == true)
                        {



                            int resultado = Negocio.grabar_cabecera_ser
                                       (
                                         num_ped, txt_fecha.Text, num_ord, cdgemp, dp_fecha_necesaria.Text, txt_obs.Text,
                                         "", "", 0, usuario, "", txt_usr_crea.Text, "", "", "", "", "", "", "", "P", txt_U_CL_CODSOL.Text, txt_U_CL_SOLICI.Text, txt_operacion.Text

                                       );
                            if (resultado == 0) Negocio = null;

                            //graba detalle
                            foreach (DataGridViewRow row in dgv_det_pedidos_consulta.Rows)
                            {
                                can_ped = Convert.ToInt32(row.Cells["Cant. pedida"].Value);
                                int linea = Convert.ToInt32(row.Cells["#"].Value);
                                cdg_prod = Convert.ToString(row.Cells["Codigo"].Value);

                                int resultado_d = Negocio.grabar_detalle_ser
                                    (num_ped, cdg_prod, can_ped, 0, 0, "", 0, 0, 0, num_ord,
                                     0, "", "", "", "", usuario, txt_usr_crea.Text,
                                      txt_usr_crea.Text, "P", linea, txt_operacion.Text);
                                if (resultado_d == 0) Negocio = null;



                            }


                        }
                        
                        MessageBox.Show("Operacion finalizada con exito", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);


                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                    }

                    finally
                    {


                        #region auditoria
                        insertar_auditoria("Editar", "FrmPedidos", "REQ", num_ped);
                        #endregion 

                        limpiar();



                        if (txt_tipo.Text == "Materiales")
                        {
                            dgv_pedidos.DataSource = AccesoLogica.listar_pedidos_misap("", anio, usuario, perfil);
                            formatear_grilla(dgv_pedidos);
                            rb_materiales_l.Checked = true;

                        }

                        if (txt_tipo.Text == "Servicios")
                        {
                            dgv_pedidos.DataSource = AccesoLogica.listar_servicios("", anio, usuario, perfil);
                            formatear_grilla(dgv_pedidos);
                            rb_servicios_l.Checked = true;
                        }


                        valida_permisos(perfil);
                        btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
                        btn_grabar.Text = "Crear";

                        btn_agregar.Enabled = false;
                        btn_agregar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
                        btn_suprimir.Enabled = false;
                        btn_suprimir.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));

                        dp_fecha_necesaria.Enabled = false;
                        txt_obs.Enabled = false;
                        txt_tipo.Clear();


                        tc_pedido.TabPages.Remove(tp_nuevo);
                        tc_pedido.TabPages.Remove(tp_auditoria);

                        allowSelect = true;
                        tc_pedido.SelectedIndex = 0;



                    }
                }

            }
            #endregion
        }

        private void Accion()
        {
            try
            {

                num_ped = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Requerimiento"].Value);
                num_ord = Convert.ToString(dgv_pedidos.CurrentRow.Cells["OT"].Value);
                usr_crea = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Solicitante"].Value);
                Proyecto = Convert.ToString(dgv_pedidos.CurrentRow.Cells["PrjCode"].Value);
                line_sap = 0;

                #region Conexion SAP


                Conexion.InitializeCompany(bd_sap);
                Conexion.oCompany.Connect();

                if (Conexion.oCompany.Connected == false)
                {
                    MessageBox.Show("No se pudo conectar a SAP, intente nuevamente... ", "Aprobar", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    // MessageBox.Show("Se conecto a SAP");

                }

                // Environment.Exit(0);

                #endregion


                #region SERVICIOS

                if (rb_servicios.Checked == true)
                {
                    this.documento = (Documents)Conexion.oCompany.GetBusinessObject(BoObjectTypes.oPurchaseRequest);

              
                    #region cabecera solicitud de compra SAP

                    documento.DocDate = DateTime.Parse(txt_fecha.Text);
                    documento.TaxDate = DateTime.Parse(txt_fecha.Text);
                    documento.UserFields.Fields.Item("U_CL_TIPREQ").Value = "S";
                    documento.UserFields.Fields.Item("U_CL_COMENTARIO").Value = txt_obs.Text;
                    documento.DocType = BoDocumentTypes.dDocument_Items;
                    documento.DocDueDate = DateTime.Parse(dp_fecha_necesaria.Text);
                    documento.RequriedDate = DateTime.Parse(dp_fecha_necesaria.Text);
                    documento.ReqType = 171;
                    documento.Requester = txt_U_CL_CODSOL.Text;
                    documento.RequesterName = txt_U_CL_SOLICI.Text;
                    documento.UserFields.Fields.Item("U_CL_NUMREQ").Value = txt_pedido.Text;
                    documento.UserFields.Fields.Item("U_CL_MSNPED").Value = txt_pedido.Text;
                    documento.UserFields.Fields.Item("U_IB1_PROY").Value = txt_cod_proyecto.Text;
                    documento.UserFields.Fields.Item("U_IB1_OT").Value = txt_cod_ot.Text;

                    #endregion

                    #region detalle solicitud de compra SAP

                    //graba detalle
                    foreach (DataGridViewRow row in dgv_det_pedidos_consulta.Rows)
                    {
                        cdg_prod = Convert.ToString(row.Cells["Codigo"].Value);
                        ItemDescription = Convert.ToString(row.Cells["Material"].Value);
                        UM = Convert.ToString(row.Cells["U.M."].Value);
                        can_ped = Convert.ToDecimal(row.Cells["Cant. pedida"].Value);

                        documento.Lines.SetCurrentLine(line_sap);
                        documento.Lines.ItemCode = cdg_prod;
                        documento.Lines.ItemDescription = ItemDescription;
                        documento.Lines.Quantity = Double.Parse(can_ped.ToString());
                        documento.Lines.WarehouseCode = "CENTRAL";
                        documento.Lines.TaxLiable = BoYesNoEnum.tYES;

                        if (txt_cod_proyecto.Text == "PCF")
                        {
                            documento.Lines.CostingCode = txt_cod_ot.Text;

                        }
                        else
                        {
                            documento.Lines.CostingCode2 = txt_cod_ot.Text;
                        }

                        documento.Lines.ProjectCode = txt_cod_proyecto.Text;
                        documento.Lines.UserFields.Fields.Item("U_CL_MSNPED").Value = txt_pedido.Text;
                        documento.Lines.MeasureUnit = UM;
                     

                        if ((line_sap + 1) < dgv_det_pedidos_consulta.RowCount)
                        {
                            documento.Lines.Add();
                        }

                        line_sap = line_sap + 1;

                    }

                    #endregion

                    #region Graba en SAP
                    if (documento.Add() == 0)
                    {
                        docEntry = Conexion.oCompany.GetNewObjectKey();
                        int resultado_d = Negocio.actualizar_DocEntry(txt_pedido.Text, Convert.ToInt32(docEntry), txt_tipo_l.Text);
                        if (resultado_d == 0) Negocio = null;
                        TipoSolicitud = "Compra";
                    }
                    else
                    {
                        int rpta = 0;
                        string msj = "";
                        Conexion.oCompany.GetLastError(out rpta, out msj);
                        MessageBox.Show(rpta + " " + msj);
                        espera.Close();
                        return;
                    }
                    #endregion
                }
                #endregion


                #region MATERIALES

                if (rb_materiales.Checked == true)
                {

                    this.documentos = (StockTransfer)Conexion.oCompany.GetBusinessObject(BoObjectTypes.oInventoryTransferRequest);

                    #region cabecera solicitud de compra SAP

                    documentos.DocDate = DateTime.Parse(txt_fecha.Text);
                    documentos.TaxDate = DateTime.Parse(txt_fecha.Text);
                    documentos.UserFields.Fields.Item("U_CL_INCREQ").Value = "Y";
                    documentos.UserFields.Fields.Item("U_CL_NUMREQ").Value = txt_pedido.Text;
                    documentos.UserFields.Fields.Item("U_IB1_PROY").Value = txt_cod_proyecto.Text;
                    documentos.UserFields.Fields.Item("U_IB1_OT").Value = txt_cod_ot.Text;
                    documentos.UserFields.Fields.Item("U_CL_FECHNE").Value = DateTime.Parse(dp_fecha_necesaria.Text);
                    documentos.UserFields.Fields.Item("U_CL_TIPSOL").Value = "E";
                    documentos.UserFields.Fields.Item("U_CL_CODSOL").Value = txt_U_CL_CODSOL.Text;
                    documentos.UserFields.Fields.Item("U_CL_SOLICI").Value = txt_U_CL_SOLICI.Text;
                    documentos.UserFields.Fields.Item("U_CL_TIPREQ").Value = "M";
                    documentos.UserFields.Fields.Item("U_CL_MSNPED").Value = txt_pedido.Text;
                    documentos.UserFields.Fields.Item("U_CL_COMENTARIO").Value = txt_obs.Text;
                    documentos.FromWarehouse = "STOCK";
                    documentos.ToWarehouse = "CENTRAL";


                    #endregion

                    #region detalle solicitud de compra SAP

                    //graba detalle
                    foreach (DataGridViewRow row in dgv_det_pedidos_consulta.Rows)
                    {
                        cdg_prod = Convert.ToString(row.Cells["Codigo"].Value);
                        ItemDescription = Convert.ToString(row.Cells["Material"].Value);
                        UM = Convert.ToString(row.Cells["U.M."].Value);
                        can_ped = Convert.ToDecimal(row.Cells["Cant. pedida"].Value);

                        documentos.Lines.SetCurrentLine(line_sap);
                        documentos.Lines.ItemCode = cdg_prod;
                        documentos.Lines.ItemDescription = ItemDescription;
                        documentos.Lines.Quantity = Double.Parse(can_ped.ToString());
                        documentos.Lines.WarehouseCode = "CENTRAL";
                        documentos.Lines.FromWarehouseCode = "STOCK";

                        if (txt_cod_proyecto.Text == "PCF")
                        {
                            documentos.Lines.DistributionRule = txt_cod_ot.Text;

                        }
                        else
                        {
                            documentos.Lines.DistributionRule2 = txt_cod_ot.Text;
                        }

                        documentos.Lines.ProjectCode = txt_cod_proyecto.Text;
                        documentos.Lines.UserFields.Fields.Item("U_CL_MSNPED").Value = txt_pedido.Text;
                        documentos.Lines.MeasureUnit = UM;

                        if ((line_sap + 1) < dgv_det_pedidos_consulta.RowCount)
                        {
                            documentos.Lines.Add();
                        }

                        line_sap = line_sap + 1;

                    }

                    #endregion


                    #region Graba en SAP
                    if (documentos.Add() == 0)
                    {
                        docEntry = Conexion.oCompany.GetNewObjectKey();
                        int resultado_d = Negocio.actualizar_DocEntry(txt_pedido.Text, Convert.ToInt32(docEntry), txt_tipo_l.Text);
                        if (resultado_d == 0) Negocio = null;
                        TipoSolicitud = "Traslado";

                    }
                    else
                    {
                        int rpta = 0;
                        string msj = "";
                        Conexion.oCompany.GetLastError(out rpta, out msj);
                        MessageBox.Show(rpta + " " + msj);
                        espera.Close();
                        return;
                    }
                    #endregion
                }
                #endregion


                #region ACTIVOS

                if (rb_activos.Checked == true)
                {

                    this.documento = (Documents)Conexion.oCompany.GetBusinessObject(BoObjectTypes.oPurchaseRequest);


                    #region cabecera solicitud de compra SAP

                    documento.DocDate = DateTime.Parse(txt_fecha.Text);
                    documento.TaxDate = DateTime.Parse(txt_fecha.Text);
                    documento.UserFields.Fields.Item("U_CL_TIPREQ").Value = "A";
                    documento.UserFields.Fields.Item("U_CL_COMENTARIO").Value = txt_obs.Text;
                    documento.DocType = BoDocumentTypes.dDocument_Items;
                    documento.DocDueDate = DateTime.Parse(dp_fecha_necesaria.Text);
                    documento.RequriedDate = DateTime.Parse(dp_fecha_necesaria.Text);
                    documento.ReqType = 171;
                    documento.Requester = txt_U_CL_CODSOL.Text;
                    documento.RequesterName = txt_U_CL_SOLICI.Text;
                    documento.UserFields.Fields.Item("U_CL_NUMREQ").Value = txt_pedido.Text;
                    documento.UserFields.Fields.Item("U_CL_MSNPED").Value = txt_pedido.Text;
                    documento.UserFields.Fields.Item("U_IB1_PROY").Value = txt_cod_proyecto.Text;
                    documento.UserFields.Fields.Item("U_IB1_OT").Value = txt_cod_ot.Text;


                    #endregion

                    #region detalle solicitud de compra SAP

                    //graba detalle
                    foreach (DataGridViewRow row in dgv_det_pedidos_consulta.Rows)
                    {
                        cdg_prod = Convert.ToString(row.Cells["Codigo"].Value);
                        ItemDescription = Convert.ToString(row.Cells["Material"].Value);
                        UM = Convert.ToString(row.Cells["U.M."].Value);
                        can_ped = Convert.ToDecimal(row.Cells["Cant. pedida"].Value);

                        documento.Lines.SetCurrentLine(line_sap);
                        documento.Lines.ItemCode = cdg_prod;
                        documento.Lines.ItemDescription = ItemDescription;
                        documento.Lines.Quantity = Double.Parse(can_ped.ToString());
                        documento.Lines.WarehouseCode = "CENTRAL";
                        documento.Lines.TaxLiable = BoYesNoEnum.tYES;

                        if (txt_cod_proyecto.Text == "PCF")
                        {
                            documento.Lines.CostingCode = txt_cod_ot.Text;

                        }
                        else
                        {
                            documento.Lines.CostingCode2 = txt_cod_ot.Text;
                        }

                        documento.Lines.ProjectCode = txt_cod_proyecto.Text;
                        documento.Lines.UserFields.Fields.Item("U_CL_MSNPED").Value = txt_pedido.Text;
                        documento.Lines.MeasureUnit = UM;

                        if ((line_sap + 1) < dgv_det_pedidos_consulta.RowCount)
                        {
                            documento.Lines.Add();
                           
                        }

                        line_sap = line_sap + 1;

                    }

                    #endregion

                    #region Graba en SAP
                    if (documento.Add() == 0)
                    {
                        docEntry = Conexion.oCompany.GetNewObjectKey();
                        int resultado_d = Negocio.actualizar_DocEntry(txt_pedido.Text, Convert.ToInt32(docEntry), txt_tipo_l.Text);
                        if (resultado_d == 0) Negocio = null;
                        TipoSolicitud = "Compra";
                    }
                    else
                    {
                        int rpta = 0;
                        string msj = "";
                        Conexion.oCompany.GetLastError(out rpta, out msj);
                        MessageBox.Show(rpta + " " + msj);
                        espera.Close();
                        return;
                    }
                    #endregion
                }
                #endregion


                espera.Message = "Actualizando estado";
                int resultado_c = Negocio.actualizar_estado(txt_pedido.Text, "A", usuario, txt_tipo_l.Text);
                if (resultado_c == 0) Negocio = null;

              

                Conexion.oCompany.Disconnect();


                espera.Message = "Enviando mail al solicitante";
                EnviarEmail_aprobacion();

                #region auditoria
                insertar_auditoria("Aprobar", "FrmPedidos", "REQ", num_ped);
                #endregion


            }

            catch (Exception ex)
            {

                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }

            Action a = () =>
            {
                Ejecucion = false;
                espera.Close();

            };

            espera.Invoke(a);

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            valida_permisos(perfil);

            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
            btn_agregar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
            btn_suprimir.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_desactivado));
            btn_grabar.Text = "Crear";

       //  limpiar();

        
            txt_ot.Visible = false;
            txt_responsable.Visible = false;

            cbo_responsable.Visible = true;
            cbo_num_ord.Visible = true;
            rb_materiales.Visible = true;
            rb_servicios.Visible = true;
            rb_activos.Visible = true;

            dgv_det_pedidos.Visible = true;

            //dgv_pedidos.DataSource = AccesoLogica.listar_pedidos_misap("", anio, usuario,perfil);
            //formatear_grilla(dgv_pedidos);


       

            allowSelect = true;
            tc_pedido.SelectedIndex = 0;

            tc_pedido.TabPages.Remove(tp_nuevo);
            tc_pedido.TabPages.Remove(tp_auditoria);
            tc_pedido.TabPages.Remove(tp_plantilla);

            anio = DateTime.Now.Year.ToString();

            if (txt_tipo_l.Text == "Materiales")
            {

                dgv_pedidos.DataSource = AccesoLogica.listar_pedidos_misap("", anio, usuario, perfil);
                formatear_grilla(dgv_pedidos);
            }

            if (txt_tipo_l.Text == "Activos fijos")
            {

                dgv_pedidos.DataSource = AccesoLogica.listar_pedidos_misap("", anio, usuario, perfil);
                formatear_grilla(dgv_pedidos);
            }

            if (txt_tipo_l.Text == "Servicios")
            {

                dgv_pedidos.DataSource = AccesoLogica.listar_servicios("", anio, usuario, perfil);
                formatear_grilla(dgv_pedidos);
            }

            if (dgv_pedidos.Rows.Count != 0)
            {

                cbo_anio.SelectedIndex = -1;
                txt_buscar.Enabled = true;
                filtro = dgv_pedidos.Columns[0].HeaderText;

                dgv_pedidos.CurrentCell = dgv_pedidos.Rows[0].Cells[0];
                columna = dgv_pedidos.CurrentCell.ColumnIndex;
            }

        }

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
            if (dgv_pedidos.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para exportar", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            util.ExportarDataGridViewExcel(dgv_pedidos, tsl_titulo.Text);

            #region auditoria
            insertar_auditoria("Exportar", "FrmPedidos", "REQ", num_ped);
            #endregion 
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            anio = DateTime.Now.Year.ToString();

            if (txt_tipo_l.Text == "Materiales")
            {

                dgv_pedidos.DataSource = AccesoLogica.listar_pedidos_misap("", anio, usuario, perfil);
                formatear_grilla(dgv_pedidos);
            }

            if (txt_tipo_l.Text == "Servicios")
            {

                dgv_pedidos.DataSource = AccesoLogica.listar_servicios("", anio, usuario, perfil);
                formatear_grilla(dgv_pedidos);
            }
            
            if (dgv_pedidos.Rows.Count != 0)
            {
              
                cbo_anio.SelectedIndex = -1;
                txt_buscar.Enabled = true;
                filtro = dgv_pedidos.Columns[0].HeaderText;

                dgv_pedidos.CurrentCell = dgv_pedidos.Rows[0].Cells[0];
                columna = dgv_pedidos.CurrentCell.ColumnIndex;
            }
        }

        private void btn_plantilla_Click(object sender, EventArgs e)
        {
            tc_pedido.TabPages.Add(tp_plantilla);
            tc_pedido.TabPages.Add(tp_auditoria);

            activar_boton(false, false, false, false, false, false, false, false, false,false, false, false, false, false, false,false, false, false, true);

            util.EstablecerAuditoria("Nuevo", usuario, "", "FrmMUsuario", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            btn_abrir_plantilla.Enabled = true;
            btn_ejecutar_SP.Enabled = true;
            btn_ejecutar_SP.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));

            allowSelect = true;
            tc_pedido.SelectedIndex = 1;
            allowSelect = false;
        }

        private void btn_consultar_b_Click(object sender, EventArgs e)
        {
            if (dgv_pedidos.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para consultar", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            util.EstablecerAuditoria("Consultar", usuario, "", "FrmPedidos", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            if (perfil == "001" || perfil == "008")
            {
                activar_boton(false, false, false, false, true,  true,true,true,true, true, false, false, true, true, false,false, false, false, true);
            }
            else
            {
                activar_boton(false, false, false, false, true, true, true, true, true,true, false, false, false, false, false,false, false, false, true);
            }
            
            
            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
            tc_pedido.TabPages.Add(tp_nuevo);

            tp_nuevo.Text = @"Consultar";

            allowSelect = true;
            tc_pedido.SelectedIndex = 1;
            allowSelect = false;

            
         
            txt_ot.Visible = true;
            txt_responsable.Visible = true;
            txt_proyecto.Visible = true;
            txt_cod_ot.Visible = true;
            cbo_responsable.Visible = false;
            cbo_num_ord.Visible = false;
            txt_aprobado_por.Visible = true;

            rb_materiales.Enabled = false;
            rb_servicios.Enabled = false;
            rb_activos.Enabled = false;

            dp_fecha_necesaria.Enabled = false;
            txt_obs.Enabled = true;
            
            if (rb_materiales_l.Checked == true)
            {
                rb_materiales.Checked = true;

            }

            if (rb_servicios_l.Checked == true)
            {
                rb_servicios.Checked = true;

            }

            if (rb_activos_l.Checked == true)
            {
                rb_activos.Checked = true;
                txt_codigo_autorizacion.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Cod. Autorizacion"].Value);

            }

            cdg_origen.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["cdg_origen"].Value);
            txt_pedido.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Requerimiento"].Value);
            txt_cod_ot.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["OT"].Value);
            txt_ot.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Descripcion"].Value);
            txt_obs.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Observacion"].Value);
            txt_responsable.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Responsable"].Value);
            txt_U_CDG_USER.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Solicitante"].Value);
            txt_fecha.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Fecha"].Value);
            txt_estado.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Estado"].Value);
            txt_U_CL_CODSOL.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["U_CL_CODSOL"].Value);
            txt_U_CL_SOLICI.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["U_CL_SOLICI"].Value);
            txt_proyecto.Text =  Convert.ToString(dgv_pedidos.CurrentRow.Cells["PrjName"].Value);
            txt_cod_proyecto.Text =  Convert.ToString(dgv_pedidos.CurrentRow.Cells["PrjCode"].Value);
            dp_fecha_necesaria.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Fec. Req."].Value);
            txt_DocEntry.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Documento SAP"].Value);
            txt_aprobado_por.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Aprobado por"].Value);
           

            dgv_det_pedidos.Visible = false;

            dgv_det_pedidos_consulta.DataSource = AccesoLogica.consultar_detalle_ped_misap(txt_tipo_l.Text, txt_pedido.Text, cdg_origen.Text);
            formatear_grilla(dgv_det_pedidos_consulta);

            dgv_det_pedidos_consulta.ReadOnly = true;

            #region auditoria
            insertar_auditoria("Consultar", "FrmPedidos", "REQ", txt_pedido.Text);
            #endregion 

        }

        private void btn_aprobar_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES
        
            if (rb_activos.Checked == true)
            {
                foreach (DataGridViewRow row in dgv_det_pedidos_consulta.Rows)
                {

                    if (Convert.ToString(row.Cells["Partida"].Value) == "611")
                    {

                        util.mensaje("El requerimiento contiene articulos del tipo Equipo Informatico, si desea aprobar ingrese el codigo de aprobación", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);

                        FrmClave clave = new FrmClave();
                        // clave.MdiParent = this;
                        clave.formulario = "FrmPedidos";
                        clave.titulo = "Codigo de atorizacion";
                        clave.cod_autorizacion = txt_codigo_autorizacion.Text;
                        clave.ShowDialog(this);

                    }

                    
                 }
           

            }


            if (dgv_pedidos.Rows.Count == 0)
            {
                util.mensaje("No Existe Informacion para apobar", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }

            if (txt_estado.Text == "APROBADO")
            {
                util.mensaje("El requerimiento ya fue aprobado", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
              
            }

            if (txt_cod_proyecto.Text == "PCF")
            {
                if (txt_responsable.Text != usuario)
                {
                    util.mensaje("Imposible aprobar, Ud. no es responsable de la OT", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    return;
                }

            }
            #endregion
            

            btn_aprobar.Enabled = false;
            Thread tr = new Thread(Accion);
            tr.Start();
            //Es necesario lanzar el formMesaje como ShowDialog
            Ejecucion = true;

            //Evita que mientras se está ejecutando el thread se cierre el formulario
            espera.FormClosing += (o, p) =>
            {
                p.Cancel = Ejecucion;
            };

            espera.ShowDialog();

            txt_estado.Text = "APROBADO";

            util.mensaje("Operación finalizada con éxito.", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
          
            dgv_pedidos.DataSource = AccesoLogica.listar_pedidos_misap("", anio, usuario,perfil);
            formatear_grilla(dgv_pedidos);
          

        }

        private void btn_desaprobar_Click(object sender, EventArgs e)
        {
            try
            {
                num_ped = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Requerimiento"].Value);
                num_ord = Convert.ToString(dgv_pedidos.CurrentRow.Cells["OT"].Value);
                usr_crea = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Solicitante"].Value);
                
                
                
                
                if (txt_estado.Text == "APROBADO")
                {
                    //DocEntry = Convert.ToInt32(dgv_pedidos.CurrentRow.Cells["Documento SAP"].Value);

                    DocEntry = Convert.ToInt32(txt_DocEntry.Text);

                    #region VALIDACIONES

                    if (dgv_pedidos.Rows.Count == 0)
                    {
                        MessageBox.Show("No Existe Informacion para rechazar", "Rechazar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        return;
                    }


                    if (usuario != txt_aprobado_por.Text)
                    {
                        EnviarEmail_solicitud_rechazo();
                        MessageBox.Show("Se enviara la solicitud de Rechazao", "Rechazar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        return;

                    }

                    //consultar solicitud de compra o transferencia de stock
                    int c;
                    c = Convert.ToInt32(AccesoLogica.validar_req_sap(DocEntry, txt_tipo_l.Text).Rows[0][0]);

                    if (c > 0)
                    {

                        MessageBox.Show("No es posible rechazar el requerimiento, ya cuenta con Pedido de compra", "Rechazar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        return;
                    }




                    #endregion

                    
                    #region Conexion SAP


                    Conexion.InitializeCompany(bd_sap);
                    Conexion.oCompany.Connect();

                    if (Conexion.oCompany.Connected == false)
                    {
                        MessageBox.Show("No se pudo conectar a SAP, intente nuevamente... ", "Aprobar", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    else
                    {
                        // MessageBox.Show("Se conecto a SAP");

                    }

                    // Environment.Exit(0);

                    #endregion


                    #region Cancelar SERVICIOS

                    if (rb_servicios.Checked == true)
                    {
                        this.documento = (Documents)Conexion.oCompany.GetBusinessObject(BoObjectTypes.oPurchaseRequest);

                        documento.GetByKey(DocEntry);
                        documento.Cancel();

                    }

                    #endregion

                    #region Cancelar Materiales

                    if (rb_materiales.Checked == true)
                    {
                        this.documentos = (StockTransfer)Conexion.oCompany.GetBusinessObject(BoObjectTypes.oInventoryTransferRequest);

                        documentos.GetByKey(DocEntry);

                        documentos.Close();

                    }

                    #endregion



                    #region Cancelar Activos

                    if (rb_activos.Checked == true)
                    {
                        this.documento = (Documents)Conexion.oCompany.GetBusinessObject(BoObjectTypes.oPurchaseRequest);

                        documento.GetByKey(DocEntry);
                        documento.Cancel();

                    }

                    #endregion

                    int resultado_c = Negocio.actualizar_estado(txt_pedido.Text, "R", usuario, txt_tipo_l.Text);
                    if (resultado_c == 0) Negocio = null;
                    txt_estado.Text = "RECHAZADO";


                    EnviarEmail_rechazo();
                    MessageBox.Show("Operación finalizada con éxito.", "Rechazar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                  
                }

                else
                {
                    int resultado_c = Negocio.actualizar_estado(txt_pedido.Text, "R", usuario, txt_tipo_l.Text);
                    if (resultado_c == 0) Negocio = null;
                    txt_estado.Text = "RECHAZADO";


                    EnviarEmail_rechazo();
                    MessageBox.Show("Operación finalizada con éxito.", "Rechazar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                }

                #region auditoria
                insertar_auditoria("Rechazar", "FrmPedidos", "REQ", num_ped);
                #endregion
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
            finally
            {
               

            }

        }

        private void btn_previsualizar_Click(object sender, EventArgs e)
        {
            if (dgv_pedidos.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para mostrar", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }


            num_ped = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Requerimiento"].Value);

            CrvRequerimiento reporte = new CrvRequerimiento();
            reporte.num_ped = num_ped;
            reporte.tipo = txt_tipo_l.Text;
            reporte.ShowDialog(this);


            #region auditoria
            insertar_auditoria("Previsualizar", "FrmPedidos", "REQ", num_ped);
            #endregion 

        }

        private void btn_eliminar_b_Click(object sender, EventArgs e)
        {
           
            try
            {
                
                num_ped = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Requerimiento"].Value);
                estado = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Estado"].Value);

                if (Convert.ToString(dgv_pedidos.CurrentRow.Cells["Estado"].Value) != "PENDIENTE")
                {
                  
                    util.mensaje("El requerimiento no puede ser eliminado", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    return;
                }

                string solicitante = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Solicitante"].Value);

                if (solicitante != usuario)
                {

                    util.mensaje("El requerimiento no puede ser eliminado por un usuario diferente al solicitante", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    return;
                }

                
                int resultado_c = Negocio.actualizar_estado(num_ped, "X", usuario, txt_tipo_l.Text);
                if (resultado_c == 0) Negocio = null;

                MessageBox.Show("Operación finalizada con éxito.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                util.mensaje("Operación finalizada con éxito.", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);


                #region auditoria
                insertar_auditoria("Eliminar", "FrmPedidos", "REQ", num_ped);
                #endregion 

            }

            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
            finally
            {
                txt_tipo_l.Text = "Materiales";

                dgv_pedidos.DataSource = AccesoLogica.listar_pedidos_misap("", anio, usuario, perfil);
                formatear_grilla(dgv_pedidos);

                rb_materiales_l.Checked = true;

                if (dgv_pedidos.Rows.Count != 0)
                {
                    txt_buscar.Enabled = true;
                    filtro = dgv_pedidos.Columns[1].HeaderText;

                    dgv_pedidos.CurrentCell = dgv_pedidos.Rows[0].Cells[1];
                    columna = dgv_pedidos.CurrentCell.ColumnIndex;
                }

            }

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            if (dgv_pedidos.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para imprimir", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            num_ped = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Requerimiento"].Value);


            RptRequerimiento reporte = new RptRequerimiento();
            reporte.SetDatabaseLogon("sa", "B1Admin", "SAPIMECONSERVER", "MISAP");
            reporte.SetParameterValue("@num_ped", num_ped);
            reporte.SetParameterValue("@tipo", txt_tipo_l.Text);
            crv_requerimiento.ReportSource = reporte;
            crv_requerimiento.PrintReport();

            #region auditoria
            insertar_auditoria("Imprimir", "FrmPedidos", "REQ", num_ped);
            #endregion 
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (posicion < dgv_pedidos.Rows.Count - 1)
            {
                posicion = posicion + 1;
            }


            dgv_pedidos.CurrentCell = dgv_pedidos.Rows[posicion].Cells[1];

            cdg_origen.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["cdg_origen"].Value);
            txt_pedido.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Requerimiento"].Value);
            txt_cod_ot.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["OT"].Value);
            txt_ot.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Descripcion"].Value);
            txt_U_CDG_USER.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Solicitante"].Value);
            txt_obs.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Observacion"].Value);
            txt_responsable.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Responsable"].Value);
            txt_fecha.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Fecha"].Value);
            txt_estado.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Estado"].Value);
            txt_U_CL_CODSOL.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["U_CL_CODSOL"].Value);
            txt_U_CL_SOLICI.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["U_CL_SOLICI"].Value);
            txt_proyecto.Text =  Convert.ToString(dgv_pedidos.CurrentRow.Cells["PrjName"].Value);
            txt_cod_proyecto.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["PrjCode"].Value);
            dp_fecha_necesaria.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Fec. Req."].Value);
            txt_DocEntry.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Documento SAP"].Value);
            txt_aprobado_por.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Aprobado por"].Value);
            dgv_det_pedidos.Visible = false;

            dgv_det_pedidos_consulta.DataSource = AccesoLogica.consultar_detalle_ped_misap(txt_tipo_l.Text, txt_pedido.Text, cdg_origen.Text);
            formatear_grilla(dgv_det_pedidos_consulta);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion = posicion - 1;
            }


            dgv_pedidos.CurrentCell = dgv_pedidos.Rows[posicion].Cells[1];

            cdg_origen.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["cdg_origen"].Value);
            txt_pedido.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Requerimiento"].Value);
            txt_cod_ot.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["OT"].Value);
            txt_ot.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Descripcion"].Value);
            txt_obs.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Observacion"].Value);
            txt_responsable.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Responsable"].Value);
            txt_fecha.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Fecha"].Value);
            txt_estado.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Estado"].Value);
            txt_U_CDG_USER.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Solicitante"].Value);
            txt_U_CL_CODSOL.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["U_CL_CODSOL"].Value);
            txt_U_CL_SOLICI.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["U_CL_SOLICI"].Value);
            txt_proyecto.Text =  Convert.ToString(dgv_pedidos.CurrentRow.Cells["PrjName"].Value);
            txt_cod_proyecto.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["PrjCode"].Value);
            dp_fecha_necesaria.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Fec. Req."].Value);
            txt_DocEntry.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Documento SAP"].Value);
            txt_aprobado_por.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Aprobado por"].Value);

            dgv_det_pedidos.Visible = false;

            dgv_det_pedidos_consulta.DataSource = AccesoLogica.consultar_detalle_ped_misap(txt_tipo_l.Text, txt_pedido.Text, cdg_origen.Text);
            formatear_grilla(dgv_det_pedidos_consulta);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            posicion = 0;

            dgv_pedidos.CurrentCell = dgv_pedidos.Rows[posicion].Cells[1];

            cdg_origen.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["cdg_origen"].Value);
            txt_pedido.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Requerimiento"].Value);
            txt_cod_ot.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["OT"].Value);
            txt_ot.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Descripcion"].Value);
            txt_obs.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Observacion"].Value);
            txt_responsable.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Responsable"].Value);
            txt_fecha.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Fecha"].Value);
            txt_estado.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Estado"].Value);
            txt_U_CDG_USER.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Solicitante"].Value);
            txt_U_CL_CODSOL.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["U_CL_CODSOL"].Value);
            txt_U_CL_SOLICI.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["U_CL_SOLICI"].Value);
            txt_proyecto.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["PrjName"].Value);
            txt_cod_proyecto.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["PrjCode"].Value);
            dp_fecha_necesaria.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Fec. Req."].Value);
            txt_DocEntry.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Documento SAP"].Value);
            txt_aprobado_por.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Aprobado por"].Value);

            dgv_det_pedidos.Visible = false;

            dgv_det_pedidos_consulta.DataSource = AccesoLogica.consultar_detalle_ped_misap(txt_tipo_l.Text, txt_pedido.Text, cdg_origen.Text);
            formatear_grilla(dgv_det_pedidos_consulta);

        }

        private void btn_utlimo_Click(object sender, EventArgs e)
        {
            posicion = dgv_pedidos.Rows.Count - 1;

            dgv_pedidos.CurrentCell = dgv_pedidos.Rows[posicion].Cells[1];

            cdg_origen.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["cdg_origen"].Value);
            txt_pedido.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Requerimiento"].Value);
            txt_cod_ot.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["OT"].Value);
            txt_ot.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Descripcion"].Value);
            txt_U_CDG_USER.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Solicitante"].Value);
            txt_obs.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Observacion"].Value);
            txt_responsable.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Responsable"].Value);
            txt_fecha.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Fecha"].Value);
            txt_estado.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Estado"].Value);
            txt_U_CL_CODSOL.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["U_CL_CODSOL"].Value);
            txt_U_CL_SOLICI.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["U_CL_SOLICI"].Value);
            txt_proyecto.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["PrjName"].Value);
            txt_cod_proyecto.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["PrjCode"].Value);
            dp_fecha_necesaria.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Fec. Req."].Value);
            txt_DocEntry.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Documento SAP"].Value);
            txt_aprobado_por.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Aprobado por"].Value);
            dgv_det_pedidos.Visible = false;

            dgv_det_pedidos_consulta.DataSource = AccesoLogica.consultar_detalle_ped_misap(txt_tipo_l.Text, txt_pedido.Text, cdg_origen.Text);
            formatear_grilla(dgv_det_pedidos_consulta);

        }

        private void btn_filtro_Click(object sender, EventArgs e)
        {
            if (dgv_pedidos.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para filtrar", "Filtrar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }


            FrmFiltro filtro = new FrmFiltro();
            filtro.anio = anio;
            filtro.perfil = perfil;
            filtro.usuario = usuario;
            filtro.estado = "";
            filtro.tipo = txt_tipo_l.Text;
            filtro.formulario = "FrmPedidos";
            filtro.ShowDialog(this);
        }

        private void btn_editar_b_Click(object sender, EventArgs e)
        {
            if (dgv_pedidos.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para editar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            
            if (Convert.ToString(dgv_pedidos.CurrentRow.Cells["Estado"].Value) != "PENDIENTE")
            {
                MessageBox.Show("El requerimiento no puede ser modificado", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            string solicitante = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Solicitante"].Value);

            if (solicitante != usuario)
            {
                MessageBox.Show("El requerimiento no puede ser modificado por un usuario diferente al solicitante", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }



            activar_boton(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true);

            util.EstablecerAuditoria("Editar", usuario, "", "FrmPedidos", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
            btn_grabar.Enabled = true;
            btn_grabar.Text = "Actualizar";
            tc_pedido.TabPages.Add(tp_nuevo);

            tp_nuevo.Text = @"Editar";

            allowSelect = true;
            tc_pedido.SelectedIndex = 1;
            allowSelect = false;

            txt_cod_ot.Visible = true;
            txt_ot.Visible = true;
            txt_responsable.Visible = true;
            txt_proyecto.Visible = true;
            cbo_responsable.Visible = false;
            cbo_num_ord.Visible = false;

            txt_obs.ReadOnly = false;
            txt_obs.Enabled = true;

            rb_materiales.Enabled = false;
            rb_servicios.Enabled = false;

            txt_obs.ReadOnly = false;
            dgv_det_pedidos_consulta.ReadOnly = false;

            if (rb_materiales_l.Checked == true)
            {
                rb_materiales.Checked = true;
               
            }

            if (rb_servicios_l.Checked == true)
            {
                rb_servicios.Checked = true;
                
            }

            cdg_origen.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["cdg_origen"].Value);
            txt_pedido.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Requerimiento"].Value);
            txt_cod_ot.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["OT"].Value);
            txt_ot.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Descripcion"].Value);
            txt_obs.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Observacion"].Value);
            txt_responsable.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Responsable"].Value);
            txt_U_CDG_USER.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Solicitante"].Value);
            txt_fecha.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Fecha"].Value);
            txt_estado.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Estado"].Value);
            txt_U_CL_CODSOL.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["U_CL_CODSOL"].Value);
            txt_U_CL_SOLICI.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["U_CL_SOLICI"].Value);
            txt_proyecto.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["PrjName"].Value);
            txt_cod_proyecto.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["PrjCode"].Value);
            dp_fecha_necesaria.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Fec. Req."].Value);
            
            btn_agregar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
            btn_agregar.Enabled = true;

       

            num_ord = Convert.ToString(dgv_pedidos.CurrentRow.Cells["OT"].Value);
            
            dgv_det_pedidos.Visible = false;

            dgv_det_pedidos_consulta.DataSource = AccesoLogica.consultar_detalle_ped_misap(txt_tipo_l.Text, txt_pedido.Text, cdg_origen.Text);
            formatear_grilla(dgv_det_pedidos_consulta);

         

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

        private void logDeModificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmLogModificaciones log = new FrmLogModificaciones();
            log.requerimiento = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Requerimiento"].Value);
            log.ShowDialog(this);
        }


        #endregion

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

        private void t_msg_Tick(object sender, EventArgs e)
        {
            lbl_msg.Text = string.Empty;

            ss_load.BackColor = Color.Transparent;
            lbl_contador_registros.Visible = true;
            lbl_msg.Visible = false;
        }

      
    }
}
