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
    public partial class FrmPCA : Form
    {
        
        #region Variables globales

        public string usuario, perfil, sociedad;

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


        int pca;
        string dni;
        string apellidos;
        string nombres;
        int id_area;
        int id_perfil;
        string id_usuario;
        int id_movimiento;
        string id_usuario_g;
        string contraseña;
        int id_servicio;
        int linea;

        string fecha;

        string autorizado;
        string swt_estado;
        string operacion;
        string usr_crea;
        string fec_crea;
        string terminal_crea;
        string operacion_mod;
        string usr_mod;
        string fec_mod;
        string terminal_mod;
        string formulario;
        string estado_registro;

        int contador;


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

        public FrmPCA()
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

            FormWindowState.Normal : FormWindowState.Maximized);

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

        private void FrmPCA_Load(object sender, EventArgs e)
        {
            operacion = "listar";

            util.FormatearFormulario(this, ts_acciones, tc_pca, ss_load, txt_buscar, tp_listado, tp_nuevo, tp_auditoria);
            this.Location = new System.Drawing.Point(350, 0);


            dgv_pca.DataSource = AccesoLogica.listar_pca(pca, dni, apellidos, nombres, id_area, id_perfil, id_usuario, id_movimiento, fecha, autorizado, swt_estado, operacion, usr_crea, fec_crea, terminal_crea, operacion_mod,
                                                           usr_mod, fec_mod, terminal_mod, formulario, estado_registro);
            formatear_grilla(dgv_pca);


            if (dgv_pca.Rows.Count != 0)
            {
                posicion = 0;
                txt_buscar.Enabled = true;
                filtro = dgv_pca.Columns[1].HeaderText;

                dgv_pca.CurrentCell = dgv_pca.Rows[0].Cells[1];
                columna = dgv_pca.CurrentCell.ColumnIndex;
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            (dgv_pca.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" + " ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
            lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_pca.Rows.Count);
        }

        private void dgv_pca_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar.Focus();
            txt_buscar.Clear();

            filtro = dgv_pca.Columns[e.ColumnIndex].HeaderText;
            lbl_buscar.Text = "Buscar en " + filtro;

            dgv_pca.CurrentCell = dgv_pca.Rows[0].Cells[e.ColumnIndex];
        }

        private void tc_pca_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!allowSelect) e.Cancel = true;
        }

        private void dgv_pca_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_pca.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para consultar", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            util.EstablecerAuditoria("Consultar", usuario, "", "FrmPCA", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            tc_pca.TabPages.Add(tp_nuevo);
            tp_nuevo.Text = @"Consultar";

            allowSelect = true;
            tc_pca.SelectedIndex = 1;
            allowSelect = false;


        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {
            if (txt_dni.TextLength == 8)
            {
                if (txt_operacion.Text == "Nuevo")
                {
                    try
                    {
                        txt_apellidos.Text = Convert.ToString(AccesoLogica.obtener_personal(txt_dni.Text, cbo_sociedad.Text).Rows[0]["APELLIDOS"]);
                        txt_nombres.Text = Convert.ToString(AccesoLogica.obtener_personal(txt_dni.Text, cbo_sociedad.Text).Rows[0]["NOMBRE"]);

                        cbo_area.Enabled = true;
                        cbo_area.Focus();
                        if (txt_operacion.Text == "Nuevo")
                        {
                            //Llenar combo area
                            cbo_area.Enabled = true;
                            cbo_area.DataSource = AccesoLogica.listar_area();
                            cbo_area.DisplayMember = "area";
                            cbo_area.ValueMember = "id_area";
                            cbo_area.SelectedItem = null;
                            cbo_area.Focus();
                        }
                        
                    }
                    catch
                    {
                        MessageBox.Show("D.N.I No existe", "PCA", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        txt_dni.Clear();
                        txt_dni.Focus();
                    }

                   
                  
                }


                if (txt_operacion.Text == "Editar")
                {
                    try
                    {
                        txt_apellidos.Text = Convert.ToString(AccesoLogica.obtener_personal(txt_dni.Text,cbo_sociedad.Text).Rows[0][0]);
                        txt_nombres.Text = Convert.ToString(AccesoLogica.obtener_personal(txt_dni.Text, cbo_sociedad.Text).Rows[0][1]);

                    }
                    catch
                    {
                        MessageBox.Show("D.N.I No existe", "PCA", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        txt_dni.Clear();
                        txt_dni.Focus();
                    }

                }
            }
        }

        private void txt_apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == Convert.ToInt32(Keys.Enter))
            {
                txt_nombres.Enabled = true;
                txt_nombres.Focus();
            }
        }

        private void txt_apellidos_Leave(object sender, EventArgs e)
        {
            if (txt_operacion.Text == "Nuevo")
            {
                txt_nombres.Enabled = true;
                txt_nombres.Focus();
            }
        }

        private void txt_nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == Convert.ToInt32(Keys.Enter))
            {
                //Llenar combo area
                cbo_area.Enabled = true;
                cbo_area.DataSource = AccesoLogica.listar_area();
                cbo_area.DisplayMember = "area";
                cbo_area.ValueMember = "id_area";
                cbo_area.SelectedItem = null;
                cbo_area.Focus();
            }
        }

        private void txt_nombres_Leave(object sender, EventArgs e)
        {
            
        }

        private void cbo_area_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_id_area.Text = cbo_area.SelectedValue.ToString();

            //Llenar combo perfil
            cbo_perfil.Enabled = true;
            cbo_perfil.DataSource = AccesoLogica.listar_perfil(Convert.ToInt32(txt_id_area.Text));
            cbo_perfil.DisplayMember = "perfil";
            cbo_perfil.ValueMember = "id_perfil";
            cbo_perfil.SelectedItem = null;
            cbo_perfil.Focus();

            //Llenar combo perfil
            cbo_ot.Enabled = true;
            cbo_ot.DataSource = AccesoLogica.listar_ot(Convert.ToInt32(txt_id_area.Text));
            cbo_ot.DisplayMember = "PrcCode";
            cbo_ot.ValueMember = "PrcCode";
            cbo_ot.SelectedItem = null;
            cbo_ot.Focus();

            txt_id_perfil.Clear();
        }

        private void cbo_perfil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_id_perfil.Text = cbo_perfil.SelectedValue.ToString();

            //Llenar combo movimiento
            cbo_movimiento.Enabled = true;
            cbo_movimiento.DataSource = AccesoLogica.listar_movimiento();
            cbo_movimiento.DisplayMember = "movimiento";
            cbo_movimiento.ValueMember = "id_movimiento";
            cbo_movimiento.SelectedItem = null;
            cbo_movimiento.Focus();
        }

        private void cbo_movimiento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_id_movimiento.Text = cbo_movimiento.SelectedValue.ToString();


            btn_credenciales.Enabled = true;
        }


        private void dgv_servicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (dgv_servicios.Columns[e.ColumnIndex].Name == "seleccion")
            {
                DataGridViewRow row = dgv_servicios.Rows[e.RowIndex];
                DataGridViewCheckBoxCell cellSelecion = row.Cells["seleccion"] as DataGridViewCheckBoxCell;


                if (Convert.ToBoolean(cellSelecion.Value))
                {
                    chk_todos.Checked = false;
                    row.DefaultCellStyle.BackColor = Color.FromArgb(252, 221, 130);

                    btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                    activar_boton(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true);

                    contador = contador + 1;

                }

                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(231, 231, 231);
                    contador = contador - 1;

                    if (contador == 0)
                    {

                        btn_grabar.Enabled = false;
                        btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
                    }

                }
            }
        }

        private void dgv_servicios_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_servicios.IsCurrentCellDirty)
            {
                dgv_servicios.CommitEdit(DataGridViewDataErrorContexts.Commit);

            }
        }

        #endregion

        #region Funciones

        void formatear_grilla(DataGridView grilla)
        {

            try
            {
                util.FormatearGrilla(grilla, false);
              

                if (grilla == dgv_pca)
                {
                    // grilla.Columns["Proveedor"].Width = 100;
                    //dgv_pedidos.Columns["U_CL_CODSOL"].Visible = false;
                    //dgv_pedidos.Columns["U_CL_SOLICI"].Visible = false;
                    lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_pca.Rows.Count);
                    lbl_contador_registros.Visible = true;
                }


                if (grilla == dgv_servicios)
                {
                    if(txt_operacion.Text == "Nuevo")
                    {
                        grilla.RowHeadersVisible = false;
                        dgv_servicios.Columns["linea"].Visible = false;
                        dgv_servicios.Columns["#"].Visible = false;
                        grilla.Columns["seleccion"].Width = 35;
                    }

                    if(txt_operacion.Text == "Editar")
                    {
                        grilla.RowHeadersVisible = false;
                        dgv_servicios.Columns["linea"].Visible = false;
                        grilla.Columns["seleccion"].Width = 40;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Fabricación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

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

        void limpiar()
        {
            txt_usr_crea.Clear();
            txt_fec_crea.Clear();
            txt_terminal_crea.Clear();
            txt_operacion.Clear();
            txt_estado_registro.Clear();

            txt_id_pca.Clear();
            txt_dni.Clear();
            txt_nombres.Clear();
            txt_apellidos.Clear();
            txt_id_area.Clear();
            txt_id_perfil.Clear();
            txt_id_movimiento.Clear();
            txt_id_usuario.Clear();

            cbo_area.Text = "";
            cbo_movimiento.Text = "";
            cbo_perfil.Text = "";

            chk_todos.Checked = false;

            dgv_servicios.DataSource = null;
        }

        void bloquear()
        {
            dtp_fecha.Enabled = false;
            txt_dni.Enabled = false;
            txt_nombres.Enabled = false;
            txt_apellidos.Enabled = false;

            cbo_area.Enabled = false;
            cbo_movimiento.Enabled = false;
            cbo_perfil.Enabled = false;

            btn_credenciales.Enabled = false;

        }

        #endregion

        #region Botones

        private void btn_nuevo_b_Click(object sender, EventArgs e)
        {


            limpiar();

            tc_pca.TabPages.Add(tp_nuevo);
            tc_pca.TabPages.Remove(tp_auditoria);

            activar_boton(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true);

            util.EstablecerAuditoria("Nuevo", usuario, "", "FrmPCA", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            lbl_contador_registros.Visible = false;

            allowSelect = true;
            tc_pca.SelectedIndex = 1;
            allowSelect = false;

            txt_apellidos.CharacterCasing = CharacterCasing.Upper;
            txt_nombres.CharacterCasing = CharacterCasing.Upper;


            dtp_fecha.CustomFormat = "yyyy-MM-dd HH:mm";
            dtp_fecha.Value = DateTime.Now;

            lbl_fecha.Text = string.Format("Fecha :" + DateTime.Now.ToString("yyyy-MM-dd HH:mm"));

            dtp_fecha.Enabled = true;

            txt_dni.Enabled = true;
            cbo_sociedad.Focus();

            txt_id_pca.Text = Convert.ToString(AccesoLogica.obtener_nro_pca().Rows[0][0]);

            btn_credenciales.Visible = true;

            dgv_servicios.DataSource = AccesoLogica.listar_servicios_pca();
            formatear_grilla(dgv_servicios);
        }

        private void btn_consultar_b_Click(object sender, EventArgs e)
        {
            if (dgv_pca.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para consultar", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            util.EstablecerAuditoria("Consultar", usuario, "", "FrmProvision", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            tc_pca.TabPages.Add(tp_nuevo);
            tp_nuevo.Text = @"Consultar";

            allowSelect = true;
            tc_pca.SelectedIndex = 1;
            allowSelect = false;


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
           
            activar_boton(true, true, true, true, true, false, false, false, false, true, true, true, false, false, true, true, true, false, true);

            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
            btn_grabar.Text = "Crear";

            limpiar();



            dgv_pca.DataSource = AccesoLogica.listar_pca(pca, dni, apellidos, nombres, id_area, id_perfil, id_usuario, id_movimiento, fecha, autorizado, swt_estado, operacion, usr_crea, fec_crea, terminal_crea, operacion_mod,
                                         usr_mod, fec_mod, terminal_mod, formulario, estado_registro);


            lbl_contador_registros.Visible = true;
            lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_pca.Rows.Count);


            allowSelect = true;
            tc_pca.SelectedIndex = 0;

            tc_pca.TabPages.Remove(tp_nuevo);
            tc_pca.TabPages.Remove(tp_auditoria);


        }

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
            if (dgv_pca.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para exportar", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            util.ExportarDataGridViewExcel(dgv_pca, tsl_titulo.Text);
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {

            if (txt_operacion.Text == "Nuevo")
            {
                try
                {
                    usr_crea = Convert.ToString(txt_usr_crea.Text);
                    fec_crea = Convert.ToString(txt_fec_crea.Text);
                    terminal_crea = Convert.ToString(txt_terminal_crea.Text);
                    operacion = Convert.ToString(txt_operacion.Text);
                    estado_registro = Convert.ToString(txt_estado_registro.Text);

                    dni = txt_dni.Text;
                    pca = Convert.ToInt32(txt_id_pca.Text);
                    apellidos = txt_apellidos.Text;
                    nombres = txt_nombres.Text;
                    id_area = Convert.ToInt32(txt_id_area.Text);
                    id_perfil = Convert.ToInt32(txt_id_perfil.Text);
                    id_usuario = txt_id_usuario.Text;
                    id_movimiento = Convert.ToInt32(txt_id_movimiento.Text);
                    fecha = dtp_fecha.Text;
                    swt_estado = "A";


                    int resultado = Negocio.mantenimiento_pca(pca, dni, apellidos, nombres, id_area, id_perfil, id_usuario, id_movimiento, fecha, autorizado, swt_estado, operacion, usr_crea, fec_crea, terminal_crea, operacion_mod,
                                                           usr_mod, fec_mod, terminal_mod, formulario, estado_registro, txt_id_ot.Text);
                    if (resultado == 0) Negocio = null;

                    foreach (DataGridViewRow row in dgv_servicios.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["seleccion"].Value))
                        {
                            linea = linea + 1;
                            id_servicio = Convert.ToInt32(row.Cells["#"].Value);
                            id_usuario_g = Convert.ToString(row.Cells["Usuario"].Value);
                            contraseña = Convert.ToString(row.Cells["Contraseña"].Value);

                            int resultado_d = Negocio.mantenimiento_pca_d(pca, linea, id_usuario_g, id_servicio, contraseña, fecha, swt_estado, operacion, usr_crea, fec_crea, terminal_crea, operacion_mod,
                                                           usr_mod, fec_mod, terminal_mod, formulario, estado_registro);
                            if (resultado_d == 0) Negocio = null;
                        }
                    }


                    MessageBox.Show("Operación finalizada con éxito.", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                }



                catch (Exception ex)
                {
                    MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Maquina", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                }

                finally
                {
                    limpiar();
                    bloquear();

                    tc_pca.TabPages.Remove(tp_nuevo);
                    tc_pca.TabPages.Remove(tp_auditoria);

                    allowSelect = true;
                    tc_pca.SelectedIndex = 0;

                    btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
                    btn_grabar.Text = "Crear";
                    activar_boton(true, true, true, true, true, false, false, false, false, true, true, true, false, false, true, true, true, false, true);
                    linea = 0;

                    dgv_pca.DataSource = AccesoLogica.listar_pca(pca, dni, apellidos, nombres, id_area, id_perfil, id_usuario, id_movimiento, fecha, autorizado, swt_estado, "listar", usr_crea, fec_crea, terminal_crea, operacion_mod,
                                                            usr_mod, fec_mod, terminal_mod, formulario, estado_registro);


                }
            }


            if (txt_operacion.Text == "Editar")
            {
                try
                {
                    usr_mod = Convert.ToString(txt_usr_crea.Text);
                    fec_mod = Convert.ToString(txt_fec_crea.Text);
                    terminal_mod = Convert.ToString(txt_terminal_crea.Text);
                    operacion_mod = Convert.ToString(txt_operacion.Text);
                    estado_registro = Convert.ToString(txt_estado_registro.Text);

                    dni = txt_dni.Text;
                    pca = Convert.ToInt32(txt_id_pca.Text);
                    apellidos = txt_apellidos.Text;
                    nombres = txt_nombres.Text;
                    id_area = Convert.ToInt32(txt_id_area.Text);
                    id_perfil = Convert.ToInt32(txt_id_perfil.Text);
                    id_usuario = txt_id_usuario.Text;
                    id_movimiento = Convert.ToInt32(txt_id_movimiento.Text);
                    fecha = dtp_fecha.Text;
                    swt_estado = "A";


                    int resultado = Negocio.mantenimiento_pca(pca, dni, apellidos, nombres, id_area, id_perfil, id_usuario, id_movimiento, fecha, autorizado, swt_estado, operacion, usr_crea, fec_crea, terminal_crea, operacion_mod,
                                                           usr_mod, fec_mod, terminal_mod, formulario, estado_registro, txt_id_ot.Text);
                    if (resultado == 0) Negocio = null;

                    foreach (DataGridViewRow row in dgv_servicios.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["seleccion"].Value))
                        {
                            linea = Convert.ToInt32(row.Cells["linea"].Value);
                            id_servicio = Convert.ToInt32(row.Cells["#"].Value);
                            id_usuario_g = Convert.ToString(row.Cells["Usuario"].Value);
                            contraseña = Convert.ToString(row.Cells["Contraseña"].Value);

                            int resultado_d = Negocio.mantenimiento_pca_d(pca, linea, id_usuario_g, id_servicio, contraseña, fecha, swt_estado, operacion, usr_crea, fec_crea, terminal_crea, operacion_mod,
                                                           usr_mod, fec_mod, terminal_mod, formulario, estado_registro);
                            if (resultado_d == 0) Negocio = null;
                        }
                    }



                    MessageBox.Show("Operación finalizada con éxito.", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);


                }



                catch (Exception ex)
                {
                    MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Maquina", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                }

                finally
                {
                    limpiar();
                    bloquear();

                    tc_pca.TabPages.Remove(tp_nuevo);
                    tc_pca.TabPages.Remove(tp_auditoria);

                    allowSelect = true;
                    tc_pca.SelectedIndex = 0;

                    btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
                    btn_grabar.Text = "Crear";
                    activar_boton(true, true, true, true, true, false, false, false, false, true, true, true, false, false, true, true, true, false, true);
                    linea = 0;

                    dgv_pca.DataSource = AccesoLogica.listar_pca(pca, dni, apellidos, nombres, id_area, id_perfil, id_usuario, id_movimiento, fecha, autorizado, swt_estado, "listar", usr_crea, fec_crea, terminal_crea, operacion_mod,
                                                            usr_mod, fec_mod, terminal_mod, formulario, estado_registro);


                }
            }

        }

        private void btn_editar_b_Click(object sender, EventArgs e)
        {

            activar_boton(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true);

            util.EstablecerAuditoria("Editar", usuario, "", "FrmPCA", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);
            lbl_contador_registros.Visible = false;

            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
            btn_grabar.Enabled = true;
            btn_grabar.Text = "Actualizar";

            tc_pca.TabPages.Add(tp_nuevo);

            tp_nuevo.Text = @"Editar";

            allowSelect = true;
            tc_pca.SelectedIndex = 1;
            allowSelect = false;


            dtp_fecha.Enabled = true;
            txt_apellidos.Enabled = true;
            txt_nombres.Enabled = true;
            txt_id_usuario.Enabled = true;



            dtp_fecha.CustomFormat = "yyyy-MM-dd HH:mm";
            dtp_fecha.Value = DateTime.Now;

            txt_dni.Enabled = true;
            txt_dni.Focus();
            //CABECERA PCA
            dtp_fecha.Text = Convert.ToString(dgv_pca.CurrentRow.Cells["Fecha"].Value);
            txt_id_pca.Text = Convert.ToString(dgv_pca.CurrentRow.Cells["PCA"].Value);
            txt_dni.Text = Convert.ToString(dgv_pca.CurrentRow.Cells["D.N.I."].Value);
            txt_apellidos.Text = Convert.ToString(dgv_pca.CurrentRow.Cells["Apellidos"].Value);
            txt_nombres.Text = Convert.ToString(dgv_pca.CurrentRow.Cells["Nombres"].Value);
            txt_id_usuario.Text = Convert.ToString(dgv_pca.CurrentRow.Cells["Usuario"].Value);
            lbl_fecha.Text = string.Format("Fecha :" + Convert.ToString(dgv_pca.CurrentRow.Cells["Fecha"].Value));


            //Llenar combo area
            cbo_area.Enabled = true;
            cbo_area.DataSource = AccesoLogica.listar_area();
            cbo_area.DisplayMember = "area";
            cbo_area.ValueMember = "id_area";
            cbo_area.Text = Convert.ToString(dgv_pca.CurrentRow.Cells["Area"].Value);
            txt_id_area.Text = cbo_area.SelectedValue.ToString();


            //Llenar combo perfil
            cbo_perfil.Enabled = true;
            cbo_perfil.DataSource = AccesoLogica.listar_perfil(Convert.ToInt32(txt_id_area.Text));
            cbo_perfil.DisplayMember = "perfil";
            cbo_perfil.ValueMember = "id_perfil";
            cbo_perfil.Text = Convert.ToString(dgv_pca.CurrentRow.Cells["Perfil"].Value);
            txt_id_perfil.Text = cbo_perfil.SelectedValue.ToString();

            //Llenar combo movimiento
            cbo_movimiento.Enabled = true;
            cbo_movimiento.DataSource = AccesoLogica.listar_movimiento();
            cbo_movimiento.DisplayMember = "movimiento";
            cbo_movimiento.ValueMember = "id_movimiento";
            cbo_movimiento.Text = Convert.ToString(dgv_pca.CurrentRow.Cells["Movimiento"].Value);
            txt_id_movimiento.Text = cbo_movimiento.SelectedValue.ToString();

            //DETALLE PCA
            dgv_servicios.DataSource = AccesoLogica.listar_pca_d(Convert.ToInt32(txt_id_pca.Text), linea, id_usuario_g, id_servicio, contraseña, swt_estado, "listar", usr_crea, fec_crea, terminal_crea, operacion_mod,
                                                                usr_mod, fec_mod, terminal_mod, formulario, estado_registro);
            formatear_grilla(dgv_servicios);

            btn_credenciales.Visible = false;
        }

        private void btn_credenciales_Click(object sender, EventArgs e)
        {


            if (txt_dni.Text == string.Empty)
            {

                MessageBox.Show("Digite el D.N.I.", "Mantenimiento de PCA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txt_dni.Focus();
                return;

            }

            if (txt_apellidos.Text == string.Empty)
            {

                MessageBox.Show("Digite los Apellidos", "Mantenimiento de PCA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txt_apellidos.Focus();
                return;

            }

            if (txt_nombres.Text == string.Empty)
            {

                MessageBox.Show("Digite los Nombres", "Mantenimiento de PCA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txt_nombres.Focus();
                return;

            }




            String nombreCompleto = txt_nombres.Text;
            String[] nombreSeparado = nombreCompleto.Split(' ');

            String apellidoCompleto = txt_apellidos.Text;
            String[] ApellidoSeparado = apellidoCompleto.Split(' ');


            String usuario = String.Empty;

            string usuario_cdi = txt_dni.Text.Substring(0, 4);

            int longitud;
            string dni_2 = txt_dni.Text;

            longitud = dni_2.Length - 4;


            string contraseña_cdi = dni_2.Substring(longitud, 4);


            //USUARIO
            usuario += nombreSeparado[0].Substring(0, 1) + ApellidoSeparado[0];

            txt_id_usuario.Text = usuario.ToLower();

            foreach (DataGridViewRow row in dgv_servicios.Rows)
            {

                int id_servicio;

                id_servicio = Convert.ToInt32(row.Cells["#"].Value);


                row.Cells["Usuario"].Value = usuario.ToLower();
                row.Cells["Contraseña"].Value = "Ime2017.";
                row.Cells["Fecha"].Value = dtp_fecha.Text;



                if (id_servicio == 2)
                {
                    row.Cells["Usuario"].Value = usuario.ToLower() + "@imecon.com.pe";
                    row.Cells["Contraseña"].Value = "Ime2017.";
                    row.Cells["Fecha"].Value = dtp_fecha.Text;
                }



                if (id_servicio == 4)
                {
                    row.Cells["Usuario"].Value = usuario_cdi;
                    row.Cells["Contraseña"].Value = contraseña_cdi;
                    row.Cells["Fecha"].Value = dtp_fecha.Text;
                }




            }

            txt_id_usuario.Enabled = true;
            MessageBox.Show("Las credenciales se generaron satisfactoriamente", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btn_previsualizar_Click(object sender, EventArgs e)
        {
            try
            {

                CrvPCA rpt_pca = new CrvPCA();
                rpt_pca._id_pca = Convert.ToInt32(dgv_pca.CurrentRow.Cells["PCA"].Value);
                rpt_pca.Text = "PARTE DE CONTROL DE ACCESO # " + Convert.ToInt32(dgv_pca.CurrentRow.Cells["PCA"].Value);
                rpt_pca.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "PCA", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }

        }

        #endregion

        #region Menu contextual
        private void cm_grilla_copia_Click(object sender, EventArgs e)
        {
            util.copiar_contextual(dgv_pca);
        }

        private void cm_grilla_copia_tabla_Click(object sender, EventArgs e)
        {
            util.copiar_todo_encabezados(dgv_pca);
        }



        #endregion

        
    }
}
