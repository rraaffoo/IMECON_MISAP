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
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;


namespace MISAP
{
    public partial class FrmSolicitudAlta : Form
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

        string filtro, proveedor, textbody, IP, concatenar, DNI, AREA , EMPLEADO, PERFIL;
        int posicion, columna, pedido, id_solicitud, NumLinea= 0;

        int cant_col, ColumnaId, id; 
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

        private void cbo_area_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "area");
        }

        private void cbo_perfil_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "perfil");
        }

        private void cbo_cc_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "PrcName");
        }


        #endregion

        #region Formulario

        public FrmSolicitudAlta()
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
            if (txt_validacion_evento.Text == "0")
            {
                DialogResult result = MessageBox.Show("Los datos no guardados se perderán. ¿Desea continuar sin guardar?", "Mensaje sistema", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    int resultado = Negocio.mantenimiento_OSAE
                         (Convert.ToInt32(txt_id_solicitud.Text), txt_fecha_documento.Text, txt_dni.Text, txt_empleado.Text, txt_mail_personal.Text, 0, 0, txt_id_cc.Text,
                            dp_fecha_induccion.Text, cbo_hora.Text, "X",
                            txt_usr_crea.Text, txt_fec_crea.Text, txt_terminal_crea.Text, txt_usr_modi.Text, txt_fec_modi.Text, txt_terminal_modi.Text, "Eliminar", txt_formulario.Text, txt_estado_registro.Text, NumLinea);
                    if (resultado == 0) Negocio = null;
                    Close();

                }
                else
                {
                    return;
                }

            }

            else
            {
                Close();
            }


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

        private void FrmSolicitudAlta_Load(object sender, EventArgs e)
        {

            valida_permisos(perfil);

            util.FormatearFormulario(this, ts_acciones, tc_solicitudes, ss_load, txt_buscar, tp_listado, tp_nuevo, tp_auditoria);
            this.Location = new System.Drawing.Point(350, 0);

         
            dgv_solicitudes.DataSource = AccesoLogica.listar_solicitudes_alta("P","CABECERA",0);
            formatear_grilla(dgv_solicitudes);
                    

            if (dgv_solicitudes.Rows.Count != 0)
            {
                posicion = 0;
                txt_buscar.Enabled = true;
                filtro = dgv_solicitudes.Columns[1].HeaderText;

                dgv_solicitudes.CurrentCell = dgv_solicitudes.Rows[0].Cells[1];
                columna = dgv_solicitudes.CurrentCell.ColumnIndex;
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            (dgv_solicitudes.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" + " ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
            lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_solicitudes.Rows.Count);
        }

        private void dgv_solicitudes_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar.Focus();
            txt_buscar.Clear();

            filtro = dgv_solicitudes.Columns[e.ColumnIndex].HeaderText;
            lbl_buscar.Text = "Buscar en " + filtro;

            dgv_solicitudes.CurrentCell = dgv_solicitudes.Rows[0].Cells[e.ColumnIndex];
        }

        private void tc_solicitudes_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!allowSelect) e.Cancel = true;
        }

        private void dgv_solicitudes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_solicitudes.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para consultar", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            util.EstablecerAuditoria("Consultar", usuario, "", "FrmProvision", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            tc_solicitudes.TabPages.Add(tp_nuevo);
            tp_nuevo.Text = @"Consultar";

            allowSelect = true;
            tc_solicitudes.SelectedIndex = 1;
            allowSelect = false;

            proveedor = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["Proveedor"].Value);

       

            btn_consultar_b.Enabled = false;
        }

        private void cbo_cc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_id_cc.Text = cbo_cc.SelectedValue.ToString();
            dp_fecha_induccion.Focus();
        }

        private void cbo_area_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Llenar combo perfil
            cbo_perfil.Enabled = true;
            cbo_perfil.DataSource = AccesoLogica.listar_perfil(Convert.ToInt32(cbo_area.SelectedValue.ToString()));
            cbo_perfil.DisplayMember = "perfil";
            cbo_perfil.ValueMember = "id_perfil";
            cbo_perfil.SelectedItem = null;
            cbo_perfil.Focus();

            txt_id_area.Text = cbo_area.SelectedValue.ToString();
        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {
            if (txt_dni.TextLength == 8)
            {
               
                if (txt_operacion.Text == "Nuevo" || txt_operacion.Text == "Editar")
                {
                    try
                    {
                        txt_empleado.Text = Convert.ToString(AccesoLogica.obtener_personal(txt_dni.Text, cbo_sociedad.Text).Rows[0][0]);
                        txt_area.Text = Convert.ToString(AccesoLogica.obtener_personal(txt_dni.Text, cbo_sociedad.Text).Rows[0]["AREA"]);
                        txt_perfil.Text = Convert.ToString(AccesoLogica.obtener_personal(txt_dni.Text, cbo_sociedad.Text).Rows[0]["PERFIL"]);
                        txt_cc.Text = Convert.ToString(AccesoLogica.obtener_personal(txt_dni.Text, cbo_sociedad.Text).Rows[0]["CC"]);
                        txt_id_area.Text = Convert.ToString(AccesoLogica.obtener_personal(txt_dni.Text, cbo_sociedad.Text).Rows[0]["ID_AREA"]);
                        txt_id_perfil.Text = Convert.ToString(AccesoLogica.obtener_personal(txt_dni.Text, cbo_sociedad.Text).Rows[0]["ID_PERFIL"]);
                        txt_id_cc.Text = Convert.ToString(AccesoLogica.obtener_personal(txt_dni.Text, cbo_sociedad.Text).Rows[0]["ID_CC"]);
                        txt_mail_personal.Text = Convert.ToString(AccesoLogica.obtener_personal(txt_dni.Text, cbo_sociedad.Text).Rows[0]["MAIL"]);
                        dp_fecha_induccion.Focus();




                    }

                    catch (Exception ex)
                    {

                        mensaje(ex.Message, false);
                        txt_dni.Clear();
                        txt_dni.Focus();
                        return;

                    }
                }
                dp_fecha_induccion.Focus();
            }
        }

        private void txt_dni_Enter(object sender, EventArgs e)
        {
            txt_dni.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txt_dni.Text))
            {
                txt_dni.SelectionStart = 0;
                txt_dni.SelectionLength = txt_dni.Text.Length;
            }
        }

        private void txt_dni_Leave(object sender, EventArgs e)
        {

            txt_dni.BackColor = Color.White;
 
                       
        }

        private void txt_dni_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_dni.Text))
            {
                txt_dni.SelectionStart = 0;
                txt_dni.SelectionLength = txt_dni.Text.Length;
            }
        }

        private void txt_mail_personal_Enter(object sender, EventArgs e)
        {
            txt_mail_personal.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txt_mail_personal.Text))
            {
                txt_mail_personal.SelectionStart = 0;
                txt_mail_personal.SelectionLength = txt_mail_personal.Text.Length;
            }
        }

        private void txt_mail_personal_Leave(object sender, EventArgs e)
        {
            txt_mail_personal.BackColor = Color.White;
        }

        private void txt_mail_personal_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_mail_personal.Text))
            {
                txt_mail_personal.SelectionStart = 0;
                txt_mail_personal.SelectionLength = txt_mail_personal.Text.Length;
            }
        }

        private void cbo_perfil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_id_perfil.Text = cbo_perfil.SelectedValue.ToString();

            cbo_cc.DataSource = AccesoLogica.listar_ot(0);
            cbo_cc.DisplayMember = "PrcName";
            cbo_cc.ValueMember = "PrcCode";
            cbo_cc.SelectedItem = null;
            cbo_cc.Focus();



        }

        private void cbo_hora_SelectedValueChanged(object sender, EventArgs e)
        {

            btn_agregar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
            btn_agregar.Enabled = true;

      
        }

        private void t_error_Tick(object sender, EventArgs e)
        {
            lbl_msg.Text = string.Empty;
            ss_load.BackColor = Color.Transparent;
            lbl_contador_registros.Visible = true;
            lbl_msg.Visible = false;
        }

        private void dp_fecha_induccion_ValueChanged(object sender, EventArgs e)
        {
            //txt_fecha_induccion.Text = dp_fecha_induccion.Text;
        }

        private void dgv_detalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_dni.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["DNI"].Value);
            txt_empleado.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Empleado"].Value);
            txt_mail_personal.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Mail"].Value);
            txt_area.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Area"].Value);
            txt_perfil.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Perfil"].Value);
            txt_cc.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Centro de Costo"].Value);

            //Llenar combo area
            cbo_area.DataSource = AccesoLogica.listar_area();
            cbo_area.DisplayMember = "area";
            cbo_area.ValueMember = "id_area";
            cbo_area.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Area"].Value);
            txt_id_area.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["id_area"].Value);

            //carga combo perfil
            cbo_perfil.DataSource = AccesoLogica.listar_perfil(Convert.ToInt32(cbo_area.SelectedValue.ToString()));
            cbo_perfil.DisplayMember = "perfil";
            cbo_perfil.ValueMember = "id_perfil";
            cbo_perfil.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Perfil"].Value);
            txt_id_perfil.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["id_perfil"].Value);

            ////carga combo cc
            cbo_cc.DataSource = AccesoLogica.listar_ot(0);
            cbo_cc.DisplayMember = "PrcName";
            cbo_cc.ValueMember = "PrcCode";
            cbo_cc.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Centro de Costo"].Value);
            txt_id_cc.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["CC"].Value);


            txt_NumLinea.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Linea"].Value);
        }

        private void dgv_detalle_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_dni.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["DNI"].Value);
            txt_empleado.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Empleado"].Value);
            txt_mail_personal.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Mail"].Value);
            txt_area.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Area"].Value);
            txt_perfil.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Perfil"].Value);
            txt_cc.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Centro de Costo"].Value);

            //Llenar combo area
            cbo_area.DataSource = AccesoLogica.listar_area();
            cbo_area.DisplayMember = "area";
            cbo_area.ValueMember = "id_area";
            cbo_area.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Area"].Value);
            txt_id_area.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["id_area"].Value);

            //carga combo perfil
            cbo_perfil.DataSource = AccesoLogica.listar_perfil(Convert.ToInt32(cbo_area.SelectedValue.ToString()));
            cbo_perfil.DisplayMember = "perfil";
            cbo_perfil.ValueMember = "id_perfil";
            cbo_perfil.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Perfil"].Value);
            txt_id_perfil.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["id_perfil"].Value);

            ////carga combo cc
            cbo_cc.DataSource = AccesoLogica.listar_ot(0);
            cbo_cc.DisplayMember = "PrcName";
            cbo_cc.ValueMember = "PrcCode";
            cbo_cc.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Centro de Costo"].Value);
            txt_id_cc.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["CC"].Value);

            txt_NumLinea.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Linea"].Value);
        }

        private void btn_utlimo_Click(object sender, EventArgs e)
        {
            posicion = dgv_solicitudes.Rows.Count - 1;

            dgv_solicitudes.CurrentCell = dgv_solicitudes.Rows[posicion].Cells[1];


            //CARGA CABECERA
            txt_id_solicitud.Text = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["Solicitud"].Value);
            txt_fecha_documento.Text = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["Fecha"].Value);
            txt_estado.Text = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["Estado"].Value);
      
           


            //CARGA DETALLE
            dgv_detalle.DataSource = AccesoLogica.listar_solicitudes_alta("P", "DETALLE", Convert.ToInt32(txt_id_solicitud.Text));
            formatear_grilla(dgv_detalle);

            txt_dni.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["DNI"].Value);
            txt_empleado.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Empleado"].Value);
            txt_mail_personal.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Mail"].Value);
            cbo_cc.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Centro de Costo"].Value);
            cbo_perfil.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Perfil"].Value);
            cbo_area.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Area"].Value);

            dp_fecha_induccion.CustomFormat = "yyyy-MM-dd";
            txt_fecha_induccion.Text = Convert.ToDateTime(dgv_detalle.CurrentRow.Cells["F. Induccion"].Value).ToString("yyyy-MM-dd");
            dp_fecha_induccion.Text = txt_fecha_induccion.Text;

            cbo_hora.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["H. Induccion"].Value);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            posicion = 0;

            dgv_solicitudes.CurrentCell = dgv_solicitudes.Rows[posicion].Cells[1];

            //CARGA CABECERA
            txt_id_solicitud.Text = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["Solicitud"].Value);
            txt_fecha_documento.Text = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["Fecha"].Value);
            txt_estado.Text = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["Estado"].Value);
           

            cbo_hora.Text = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["H. Induccion"].Value);


            //CARGA DETALLE
            dgv_detalle.DataSource = AccesoLogica.listar_solicitudes_alta("P", "DETALLE", Convert.ToInt32(txt_id_solicitud.Text));
            formatear_grilla(dgv_detalle);

            txt_dni.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["DNI"].Value);
            txt_empleado.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Empleado"].Value);
            txt_mail_personal.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Mail"].Value);
            cbo_cc.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Centro de Costo"].Value);
            cbo_perfil.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Perfil"].Value);
            cbo_area.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Area"].Value);

            dp_fecha_induccion.CustomFormat = "yyyy-MM-dd";
            txt_fecha_induccion.Text = Convert.ToDateTime(dgv_detalle.CurrentRow.Cells["F. Induccion"].Value).ToString("yyyy-MM-dd");
            dp_fecha_induccion.Text = txt_fecha_induccion.Text; 

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion = posicion - 1;
            }

            dgv_solicitudes.CurrentCell = dgv_solicitudes.Rows[posicion].Cells[1];

            //CARGA CABECERA
            txt_id_solicitud.Text = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["Solicitud"].Value);
            txt_fecha_documento.Text = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["Fecha"].Value);
            txt_estado.Text = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["Estado"].Value);
            
         


            //CARGA DETALLE
            dgv_detalle.DataSource = AccesoLogica.listar_solicitudes_alta("P", "DETALLE", Convert.ToInt32(txt_id_solicitud.Text));
            formatear_grilla(dgv_detalle);

            txt_dni.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["DNI"].Value);
            txt_empleado.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Empleado"].Value);
            txt_mail_personal.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Mail"].Value);
            cbo_cc.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Centro de Costo"].Value);
            cbo_perfil.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Perfil"].Value);
            cbo_area.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Area"].Value);

            dp_fecha_induccion.CustomFormat = "yyyy-MM-dd";
            txt_fecha_induccion.Text = Convert.ToDateTime(dgv_detalle.CurrentRow.Cells["F. Induccion"].Value).ToString("yyyy-MM-dd");
            dp_fecha_induccion.Text = txt_fecha_induccion.Text;

            cbo_hora.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["H. Induccion"].Value);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (posicion < dgv_solicitudes.Rows.Count - 1)
            {
                posicion = posicion + 1;
            }


            dgv_solicitudes.CurrentCell = dgv_solicitudes.Rows[posicion].Cells[1];

            //CARGA CABECERA
            txt_id_solicitud.Text = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["Solicitud"].Value);
            txt_fecha_documento.Text = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["Fecha"].Value);
            txt_estado.Text = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["Estado"].Value);
           
          


            //CARGA DETALLE
            dgv_detalle.DataSource = AccesoLogica.listar_solicitudes_alta("P", "DETALLE", Convert.ToInt32(txt_id_solicitud.Text));
            formatear_grilla(dgv_detalle);

            txt_dni.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["DNI"].Value);
            txt_empleado.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Empleado"].Value);
            txt_mail_personal.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Mail"].Value);
            cbo_cc.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Centro de Costo"].Value);
            cbo_perfil.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Perfil"].Value);
            cbo_area.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["Area"].Value);


            dp_fecha_induccion.CustomFormat = "yyyy-MM-dd";
            txt_fecha_induccion.Text = Convert.ToDateTime(dgv_detalle.CurrentRow.Cells["F. Induccion"].Value).ToString("yyyy-MM-dd");
            dp_fecha_induccion.Text = txt_fecha_induccion.Text;

            cbo_hora.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells["H. Induccion"].Value);
        }


        #endregion

        #region Funciones

        void formatear_grilla(DataGridView grilla)
        {

            try
            {
                util.FormatearGrilla(grilla, false);
                lbl_contador_registros.Visible = true;

                if (grilla == dgv_solicitudes)
                {
                   // grilla.Columns["Proveedor"].Width = 100;
                    //dgv_pedidos.Columns["U_CL_CODSOL"].Visible = false;
                  
                    lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_solicitudes.Rows.Count);
                }


                if (grilla == dgv_detalle)
                {
                    // grilla.Columns["Proveedor"].Width = 100;
                    dgv_detalle.Columns["Solicitud"].Visible = false;
                    dgv_detalle.Columns["Fecha"].Visible = false;
                    dgv_detalle.Columns["CC"].Visible = false;
                   // dgv_detalle.Columns["F. Induccion"].Visible = false;
                    dgv_detalle.Columns["H. Induccion"].Visible = false;
                    dgv_detalle.Columns["Estado"].Visible = false;
                    dgv_detalle.Columns["Linea"].Visible = false;
                    dgv_detalle.Columns["id_area"].Visible = false;
                    dgv_detalle.Columns["id_perfil"].Visible = false;

                    lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_detalle.Rows.Count);
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

        void limpiar(string operacion)
        {
            txt_dni.Clear();
            txt_empleado.Clear();
            txt_mail_personal.Clear();
            txt_area.Clear();
            txt_perfil.Clear();
            txt_cc.Clear();
            
            if (operacion == "Nuevo")
            {
                txt_fecha_documento.Clear();
                txt_id_solicitud.Clear();
                txt_estado.Clear();
                txt_fecha_induccion.Clear();
                cbo_area.SelectedIndex = -1;
                cbo_perfil.SelectedIndex = -1;
                cbo_cc.SelectedIndex = -1; 
                cbo_hora.SelectedIndex = -1;
                dp_fecha_induccion.MinDate = Convert.ToDateTime("01/01/1753");
                dgv_detalle.DataSource = null;


            }

            if (operacion == "Agregar")
            {
                cbo_area.SelectedIndex = -1;
                cbo_perfil.SelectedIndex = -1;
                cbo_cc.SelectedIndex = -1;
                
            }

            

        }

        void valida_permisos(string perfil)
        {
            if (perfil == "001")
            {
                activar_boton(true, true, true, true, true, false, false, false, false, true, true, false, false, false, true, true, true, false, true);
            }
            if (perfil == "007")
            {
                activar_boton(true, true, true, true, true, false, false, false, false, true, true, false, false, false, true, true, true, false, true);
            }
            if (perfil == "008")
            {
                activar_boton(true, true, true, true, true, false, false, false, false, true, true, false, false, false, true, true, true, false, true);
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


        private bool EnviarEmail_por_aprobar()
        {

            textbody =
           "<br/>" + "Estimado:" + "<br>" +
           "<br/>" + "La Solicitud Nº " + txt_id_solicitud.Text + "\r\n" + "requiere de su aprobacion :" +
             htmlMessageBody(dgv_detalle).ToString() +
           "<br/>" + "Administrador MISAP" + "<br>";

            MailMessage msg = new MailMessage();

            msg.To.Add("induccion@imecon.com.pe");
            msg.CC.Add("seg_docum@imecon.com.pe");
            msg.From = new MailAddress("misap@imecon.com.pe", "Modulo de Interfaz SAP", System.Text.Encoding.UTF8);
            msg.Subject = "SOLICITUD DE ALTA DE EMPLEADO Nº " + txt_id_solicitud.Text + " POR APROBAR";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body =textbody; //textbody;
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

        void insertar_auditoria(string operacion, string formulario, string tipo_doc, string nro_doc)
        {
            string strHostName = string.Empty;
            strHostName = Dns.GetHostName();


            IPAddress[] hostIPs = Dns.GetHostAddresses(strHostName);
            for (int i = 0; i < hostIPs.Length; i++) { IP = hostIPs[i].ToString(); }

            int resultado_auditoria = Negocio.insertar_OAUD(usuario, DateTime.Now.ToString("yyyy-MM-dd HH:mm"), Environment.MachineName, IP, Environment.UserName, operacion, formulario, tipo_doc, nro_doc);


        }

        void mensaje(string msg, bool tipo)
        {
            //tipo true=exito false=error

            if (tipo == true)
            {

                lbl_contador_registros.Visible = false;
                lbl_msg.Visible = true;
                lbl_msg.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.StatusSuccess));
                ss_load.BackColor = Color.FromArgb(127, 182, 123);
                lbl_msg.ForeColor = Color.Black;
                lbl_msg.Text = "     " + msg;
                t_msg.Start();
            }

            if (tipo == false)
            {
                lbl_contador_registros.Visible = false;
                lbl_msg.Visible = true;
                lbl_msg.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.StatusError));
                ss_load.BackColor = Color.FromArgb(204, 0, 0);
                lbl_msg.ForeColor = Color.White;
                lbl_msg.Text = "     " + msg; 
                t_msg.Start();
            }


        }

        #endregion
        
        #region Botones

        private void btn_nuevo_b_Click(object sender, EventArgs e)
        {
            tc_solicitudes.TabPages.Add(tp_nuevo);
            tc_solicitudes.TabPages.Add(tp_auditoria);

            activar_boton(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true);

            util.EstablecerAuditoria("Nuevo", usuario, "", "FrmSolicitudAlta", "S", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            util.Formateardetalle(tp_contenido, tp_anexo);

            allowSelect = true;
            tc_solicitudes.SelectedIndex = 1;
            allowSelect = false;

            lbl_contador_registros.Visible = false;
            
            tp_nuevo.Text = @"Nuevo";
            limpiar("Nuevo");
          
            txt_dni.ReadOnly = false;
            txt_mail_personal.ReadOnly = false;

            txt_dni.Focus();
            cbo_area.Enabled = true;
            cbo_perfil.Enabled = true;
            cbo_cc.Enabled = true;
            cbo_hora.Enabled = true;
            dp_fecha_induccion.Enabled = true;

            btn_agregar.Visible = true;

            txt_id_solicitud.Text = Convert.ToString(AccesoLogica.obtener_nro_solicitud_alta().Rows[0][0]);
            txt_estado.Text = "Pendiente";

            txt_fecha_documento.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm");

            dp_fecha_induccion.CustomFormat = "yyyy-MM-dd";
            dp_fecha_induccion.MinDate = DateTime.Now.AddDays(1);
            txt_fecha_induccion.Text = dp_fecha_induccion.Text;

            //Llenar combo area
            cbo_area.Enabled = true;
            cbo_area.DataSource = AccesoLogica.listar_area();
            cbo_area.DisplayMember = "area";
            cbo_area.ValueMember = "id_area";
            cbo_area.SelectedItem = null;

            cbo_hora.SelectedItem = null;

        }

        private void btn_consultar_b_Click(object sender, EventArgs e)
        {
            if (dgv_solicitudes.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para consultar", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            util.EstablecerAuditoria("Consultar", usuario, "", "FrmSolicitudAlta", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);
            activar_boton(false, false, false, false, true, true, true, true, true, true, false, false, true, true, false, false, false, false, true);
            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));

            
            tc_solicitudes.TabPages.Add(tp_nuevo);

            tp_nuevo.Text = @"Consultar";

            allowSelect = true;
            tc_solicitudes.SelectedIndex = 1;
            allowSelect = false;

            btn_cancelar.Focus();

            txt_dni.ReadOnly = true;
            txt_mail_personal.ReadOnly = true;
            cbo_area.Enabled = false;
            cbo_perfil.Enabled = false;
            cbo_cc.Enabled = false;
            cbo_hora.Enabled = false;
           // dp_fecha_induccion.Enabled = false;
            btn_agregar.Visible = false;
                   
            //CARGA CABECERA
            txt_id_solicitud.Text = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["Solicitud"].Value);
            txt_fecha_documento.Text = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["Fecha"].Value);
            txt_estado.Text = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["Estado"].Value);
           
            cbo_hora.Text = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["H. Induccion"].Value);

            dp_fecha_induccion.CustomFormat = "yyyy-MM-dd";
            txt_fecha_induccion.Text = Convert.ToDateTime(dgv_solicitudes.CurrentRow.Cells["F. Induccion"].Value).ToString("yyyy-MM-dd");
            dp_fecha_induccion.Text = txt_fecha_induccion.Text;

      
            //CARGA DETALLE
            dgv_detalle.DataSource = AccesoLogica.listar_solicitudes_alta("P", "DETALLE", Convert.ToInt32(txt_id_solicitud.Text));
            formatear_grilla(dgv_detalle);

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            valida_permisos(perfil);
         
            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
            btn_grabar.Text = "Crear";

            limpiar("Nuevo");

            allowSelect = true;
            tc_solicitudes.SelectedIndex = 0;

            tc_solicitudes.TabPages.Remove(tp_nuevo);
            tc_solicitudes.TabPages.Remove(tp_auditoria);
            
            dgv_solicitudes.DataSource = AccesoLogica.listar_solicitudes_alta("P", "CABECERA", 0);
            formatear_grilla(dgv_solicitudes);

            dp_fecha_induccion.MinDate =Convert.ToDateTime("01/01/1753");
        }

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
            if (dgv_solicitudes.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para exportar", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            util.ExportarDataGridViewExcel(dgv_solicitudes, tsl_titulo.Text);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            #region validaciones

            foreach (DataGridViewRow row in dgv_detalle.Rows)
            {

                if (txt_dni.Text == Convert.ToString(row.Cells["DNI"].Value))
                {
                    mensaje("El empleado ya existe", false);
                    return;
                }
            }

          

            if (txt_dni.Text == string.Empty)
            {
                mensaje("El campo " + lbl_dni.Text + " no debe estar vacio; indique un valor para " + lbl_dni.Text + ".",false);
                txt_dni.Focus();
                return;
            }

            if (txt_mail_personal.Text == string.Empty)
            {
                mensaje("El campo " + lbl_mail_personal.Text + " no debe estar vacio; indique un valor para " + lbl_mail_personal.Text + ".", false);
                txt_mail_personal.Focus();
                return;
            }


            if (util.validar_mail(txt_mail_personal.Text) == false)
            {
                mensaje("El valor para " + lbl_mail_personal.Text + " no es valido. " , false);
                txt_mail_personal.Focus();
                return;
            }


            //if (cbo_hora.Text == string.Empty)
            //{
            //    mensaje("El campo " + lbl_hora.Text + " no debe estar vacio; indique un valor para " + lbl_hora.Text + ".", false);
            //    cbo_hora.Focus();
            //     return;
            //}

            //if (cbo_area.Text == string.Empty)
            //{
            //    mensaje("El campo " + lbl_area.Text + " no debe estar vacio; indique un valor para " + lbl_area.Text + ".", false);
            //    cbo_area.Focus();
            //    return;
            //}

            //if (cbo_perfil.Text == string.Empty)
            //{
            //    mensaje("El campo " + lbl_perfil.Text + " no debe estar vacio; indique un valor para " + lbl_perfil.Text + ".", false);
            //    cbo_perfil.Focus();
            //   return;
            //}

            //if (cbo_cc.Text == string.Empty)
            //{
            //    mensaje("El campo " + lbl_cc.Text + " no debe estar vacio; indique un valor para " + lbl_cc.Text + ".", false);
            //    cbo_perfil.Focus();
            //    t_msg.Start();
            //    return;
            //}

            t_msg.Stop();
            #endregion

            #region Operacion Nuevo

            if (txt_operacion.Text == "Nuevo")
            {
                try
                {
                    NumLinea = NumLinea + 1;
                    
                    int resultado = Negocio.mantenimiento_OSAE
                        (Convert.ToInt32(txt_id_solicitud.Text), txt_fecha_documento.Text, txt_dni.Text, txt_empleado.Text, txt_mail_personal.Text, Convert.ToInt32(txt_id_area.Text), Convert.ToInt32(txt_id_perfil.Text), txt_id_cc.Text,
                           txt_fecha_induccion.Text, cbo_hora.Text, "P",
                           txt_usr_crea.Text, txt_fec_crea.Text, txt_terminal_crea.Text, txt_usr_modi.Text, txt_fec_modi.Text, txt_terminal_modi.Text, txt_operacion.Text, txt_formulario.Text, txt_estado_registro.Text, NumLinea);
                    if (resultado == 0) Negocio = null;

                    dgv_detalle.DataSource = AccesoLogica.listar_solicitudes_alta("P", "DETALLE", Convert.ToInt32(txt_id_solicitud.Text));
                    formatear_grilla(dgv_detalle);

                    limpiar("Agregar");
                    txt_dni.Focus();

                    dp_fecha_induccion.Enabled = false;
                    cbo_hora.Enabled = false;

                    btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                    activar_boton(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true);
                    
                    //pendiente de grabar = 0;
                    //grabado = 1
                    txt_validacion_evento.Text = "0";

                }

                catch (Exception ex)
                {
                    mensaje(ex.Message, false);
                    return;
                }
                

            }
            #endregion
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            #region Operacion Nuevo
            if (txt_operacion.Text == "Nuevo")
            {
                try
                {
                    EnviarEmail_por_aprobar(); 
                    dgv_solicitudes.DataSource = AccesoLogica.listar_solicitudes_alta("P", "CABECERA", 0);
                    formatear_grilla(dgv_solicitudes);

                    btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
                    btn_grabar.Text = "Crear";


                    mensaje("Operación finalizada con éxito.", true);

                }

                catch (Exception ex)
                {

                    mensaje(ex.Message, false);
                    return;

                }
                finally
                {
                    limpiar("Nuevo");

                    btn_agregar.Enabled = false;

                    tc_solicitudes.TabPages.Remove(tp_nuevo);
                    tc_solicitudes.TabPages.Remove(tp_auditoria);

                    allowSelect = true;
                    tc_solicitudes.SelectedIndex = 0;

                    valida_permisos(perfil);
                }
           
            }
            #endregion

            #region Operacion Editar

            if (txt_operacion.Text == "Editar")
            {
                #region validaciones

                if (txt_dni.Text == string.Empty)
                {
                     mensaje("El campo " + lbl_dni.Text + " no debe estar vacio; indique un valor para " + lbl_dni.Text + ".", false);
                    txt_dni.Focus();
                    return;
                }

                if (txt_mail_personal.Text == string.Empty)
                {
                    mensaje("El campo " + lbl_mail_personal.Text + " no debe estar vacio; indique un valor para " + lbl_mail_personal.Text + ".", false);
                    txt_mail_personal.Focus();
                    return;
                }

                if (cbo_hora.Text == string.Empty)
                {
                    mensaje("El campo " + lbl_hora.Text + " no debe estar vacio; indique un valor para " + lbl_hora.Text + ".", false);
                    cbo_hora.Focus();
                    return;
                }

                if (cbo_area.Text == string.Empty)
                {
                    mensaje("El campo " + lbl_area.Text + " no debe estar vacio; indique un valor para " + lbl_area.Text + ".", false);
                    cbo_area.Focus();
                    return;
                }

                if (cbo_perfil.Text == string.Empty)
                {
                    mensaje("El campo " + lbl_perfil.Text + " no debe estar vacio; indique un valor para " + lbl_perfil.Text + ".", false);
                    cbo_perfil.Focus();
                    return;
                }

                if (cbo_cc.Text == string.Empty)
                {
                    mensaje("El campo " + lbl_cc.Text + " no debe estar vacio; indique un valor para " + lbl_cc.Text + ".", false);
                    cbo_perfil.Focus();
                    t_msg.Start();
                    return;
                }

                t_msg.Stop();
                #endregion

                    try
                    {
                        int resultado = Negocio.mantenimiento_OSAE
                        (Convert.ToInt32(txt_id_solicitud.Text), txt_fecha_documento.Text, txt_dni.Text, txt_empleado.Text, txt_mail_personal.Text, Convert.ToInt32(txt_id_area.Text), Convert.ToInt32(txt_id_perfil.Text), txt_id_cc.Text,
                           dp_fecha_induccion.Text, cbo_hora.Text, "P",
                           txt_usr_crea.Text, txt_fec_crea.Text, txt_terminal_crea.Text, txt_usr_modi.Text, txt_fec_modi.Text, txt_terminal_modi.Text, txt_operacion.Text, txt_formulario.Text, txt_estado_registro.Text,Convert.ToInt32(txt_NumLinea.Text));
                    if (resultado == 0) Negocio = null;

                    dgv_detalle.DataSource = AccesoLogica.listar_solicitudes_alta("P", "DETALLE", Convert.ToInt32(txt_id_solicitud.Text));
                    formatear_grilla(dgv_detalle);

                   // EnviarEmail_por_aprobar();

                   util.mensaje("Operación finalizada con éxito.", true, lbl_contador_registros,lbl_msg,ss_load,t_msg);
                     //   mensaje("Operación finalizada con éxito.",true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                               
                 
                    //btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
                    //btn_grabar.Text = "Crear";

                    }

                    catch (Exception ex)
                    {
                        mensaje(ex.Message, false);
                        return;

                    }

              

                }

            #endregion
        }

        private void btn_eliminar_b_Click(object sender, EventArgs e)
        {

            if (dgv_solicitudes.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para eliminar", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            util.EstablecerAuditoria("Eliminar", usuario, "", "FrmSolicitudAlta", "N", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            try
            {
                id_solicitud = Convert.ToInt32(dgv_solicitudes.CurrentRow.Cells["Solicitud"].Value);

                int resultado = Negocio.mantenimiento_OSAE
                          (id_solicitud, txt_fecha_documento.Text, txt_dni.Text, txt_empleado.Text, txt_mail_personal.Text, 0, 0, txt_id_cc.Text,
                             dp_fecha_induccion.Text, cbo_hora.Text, "X",
                             txt_usr_crea.Text, txt_fec_crea.Text, txt_terminal_crea.Text, txt_usr_modi.Text, txt_fec_modi.Text, txt_terminal_modi.Text, txt_operacion.Text, txt_formulario.Text, txt_estado_registro.Text, NumLinea);
                if (resultado == 0) Negocio = null;

                #region auditoria
                insertar_auditoria("Eliminar", "FrmSolicitudAlta", "SAE", Convert.ToString(id_solicitud));
                #endregion 

                dgv_solicitudes.DataSource = AccesoLogica.listar_solicitudes_alta("P","CABECERA",0);
                formatear_grilla(dgv_solicitudes);


                if (dgv_solicitudes.Rows.Count != 0)
                {
                    posicion = 0;
                    txt_buscar.Enabled = true;
                    filtro = dgv_solicitudes.Columns[1].HeaderText;

                    dgv_solicitudes.CurrentCell = dgv_solicitudes.Rows[0].Cells[1];
                    columna = dgv_solicitudes.CurrentCell.ColumnIndex;
                }

                valida_permisos(perfil);
                mensaje("Operación finalizada con éxito.", true);

            }

            catch (Exception ex)
            {

                mensaje(ex.Message, false);
                return;

            }




        }

        private void btn_editar_b_Click(object sender, EventArgs e)
        {
            // limpiar("Editar");

            if (dgv_solicitudes.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para modificar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            util.EstablecerAuditoria("Editar", usuario, "", "FrmSolicitudAlta", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            activar_boton(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true);
            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));

            btn_grabar.Text = "Actualizar";
            tc_solicitudes.TabPages.Add(tp_nuevo);

            tp_nuevo.Text = @"Editar";

            allowSelect = true;
            tc_solicitudes.SelectedIndex = 1;
            allowSelect = false;


            btn_agregar.Visible = false;
            txt_dni.ReadOnly = false;
            txt_mail_personal.ReadOnly = false;


            cbo_hora.Enabled = true;
            dp_fecha_induccion.Enabled = true;
            cbo_area.Enabled = true;
            cbo_perfil.Enabled = true;
            cbo_cc.Enabled = true;



            //CARGA CABECERA
            txt_id_solicitud.Text = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["Solicitud"].Value);
            txt_fecha_documento.Text = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["Fecha"].Value);
            txt_estado.Text = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["Estado"].Value);

            dp_fecha_induccion.CustomFormat = "yyyy-MM-dd";
            txt_fecha_induccion.Text = Convert.ToDateTime(dgv_solicitudes.CurrentRow.Cells["F. Induccion"].Value).ToString("yyyy-MM-dd");
            dp_fecha_induccion.Text = txt_fecha_induccion.Text;
            cbo_hora.Text = Convert.ToString(dgv_solicitudes.CurrentRow.Cells["H. Induccion"].Value);


            //CARGA DETALLE
            dgv_detalle.DataSource = AccesoLogica.listar_solicitudes_alta("P", "DETALLE", Convert.ToInt32(txt_id_solicitud.Text));
            formatear_grilla(dgv_detalle);

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dgv_solicitudes.DataSource = AccesoLogica.listar_solicitudes_alta("P", "CABECERA", 0);
            formatear_grilla(dgv_solicitudes);
        }

        #endregion

        #region Menu contextual
        private void cm_grilla_copia_Click(object sender, EventArgs e)
        {
            util.copiar_contextual(dgv_solicitudes);
        }

        private void cm_grilla_copia_tabla_Click(object sender, EventArgs e)
        {
            util.copiar_todo_encabezados(dgv_solicitudes);
        }

    
     
        #endregion

        private void rb_pendiente_CheckedChanged(object sender, EventArgs e)
        {
            
            lbl_buscar.Text = "Buscar";
            txt_buscar.Clear();
                 

            dgv_solicitudes.DataSource = AccesoLogica.listar_solicitudes_alta("P","CABECERA",0);
            formatear_grilla(dgv_solicitudes);
                    

            if (dgv_solicitudes.Rows.Count != 0)
            {
                posicion = 0;
                txt_buscar.Enabled = true;
                filtro = dgv_solicitudes.Columns[1].HeaderText;

                dgv_solicitudes.CurrentCell = dgv_solicitudes.Rows[0].Cells[1];
                columna = dgv_solicitudes.CurrentCell.ColumnIndex;
            }
        }

        private void rb_atendido_CheckedChanged(object sender, EventArgs e)
        {
            lbl_buscar.Text = "Buscar";
            txt_buscar.Clear();


            dgv_solicitudes.DataSource = AccesoLogica.listar_solicitudes_alta("AT", "CABECERA", 0);
            formatear_grilla(dgv_solicitudes);


            if (dgv_solicitudes.Rows.Count != 0)
            {
                posicion = 0;
                txt_buscar.Enabled = true;
                filtro = dgv_solicitudes.Columns[1].HeaderText;

                dgv_solicitudes.CurrentCell = dgv_solicitudes.Rows[0].Cells[1];
                columna = dgv_solicitudes.CurrentCell.ColumnIndex;
            }
        }

    }
}
