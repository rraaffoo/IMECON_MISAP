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
using System.Runtime.InteropServices;

namespace MISAP
{
    public partial class FrmEmpleados : Form
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
        bool Ejecucion = false;

        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();
        FrmEspera espera = new FrmEspera();

        string CINT, NOM1, NOM2, APEP, APEM, SEXO, DNI, TEMP, AREA, TELM, TELF, EMAIL, ACTIVO, ESTADO, ERROR, filtro;
        int CSAP, posicion, columna;
        
        
        #endregion

        #region Formulario

           public FrmEmpleados()
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

        #region Perzonalizacion de controles

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() :
                base(new Utilidades.MyColors()) { }
        }

        #endregion

        #region Eventos

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            this.Activate();

            valida_permisos(perfil);
            util.FormatearFormulario(this, ts_acciones, tc_pedido, ss_load, txt_buscar, tp_listado, tp_nuevo, tp_auditoria);
      
            dgv_empleados.DataSource = AccesoLogica.listar_empleados("SAP","","","","");
            formatear_grilla(dgv_empleados);

            if (dgv_empleados.Rows.Count != 0)
            {
                posicion = 0;
                txt_buscar.Enabled = true;
                filtro = dgv_empleados.Columns[1].HeaderText;

                dgv_empleados.CurrentCell = dgv_empleados.Rows[0].Cells[1];
                columna = dgv_empleados.CurrentCell.ColumnIndex;
            }

        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {

            (dgv_empleados.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" + " ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
            lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_empleados.Rows.Count);
        }

        private void dgv_empleados_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar.Focus();
            txt_buscar.Clear();

            filtro = dgv_empleados.Columns[e.ColumnIndex].HeaderText;
            lbl_buscar.Text = "Buscar en " + filtro;

            dgv_empleados.CurrentCell = dgv_empleados.Rows[0].Cells[e.ColumnIndex];
        }

        private void rb_activos_CheckedChanged(object sender, EventArgs e)
        {
            (dgv_empleados.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[ACTIVO]" + " ,'System.String') LIKE '%{0}%'", "1");
            lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_empleados.Rows.Count);
        }

        private void chk_tipo_CheckedChanged(object sender, EventArgs e)
        {
            rb_activos.Checked = false;
            rb_inactivos.Checked = false;
            rb_todos.Checked = true;

            if (chk_tipo.Checked == true)
            {
                rb_activos.Checked = false;
                rb_inactivos.Checked = false;
                rb_todos.Checked = true;

                dgv_empleados.DataSource = null;
                dgv_empleados.DataSource = AccesoLogica.listar_empleados("MARINGO","","","","");
                formatear_grilla(dgv_empleados);
            }
            else
            {
                dgv_empleados.DataSource = null;
                dgv_empleados.DataSource = AccesoLogica.listar_empleados("SAP","","","","");
                formatear_grilla(dgv_empleados);

                if (dgv_empleados.Rows.Count != 0)
                {
                    posicion = 0;
                    txt_buscar.Enabled = true;
                    filtro = dgv_empleados.Columns[1].HeaderText;

                    dgv_empleados.CurrentCell = dgv_empleados.Rows[0].Cells[1];
                    columna = dgv_empleados.CurrentCell.ColumnIndex;
                }
            }
        }

        private void rb_inactivos_CheckedChanged(object sender, EventArgs e)
        {
            (dgv_empleados.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[ACTIVO]" + " ,'System.String') LIKE '%{0}%'", "0");
            lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_empleados.Rows.Count);

        }

        private void rb_todos_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_tipo.Checked == true)
            {
                dgv_empleados.DataSource = null;
                dgv_empleados.DataSource = AccesoLogica.listar_empleados("MARINGO","","","","");
                formatear_grilla(dgv_empleados);
            }
            else
            {
                dgv_empleados.DataSource = null;
                dgv_empleados.DataSource = AccesoLogica.listar_empleados("SAP","","","","");
                formatear_grilla(dgv_empleados);

                if (dgv_empleados.Rows.Count != 0)
                {
                    posicion = 0;
                    txt_buscar.Enabled = true;
                    filtro = dgv_empleados.Columns[1].HeaderText;

                    dgv_empleados.CurrentCell = dgv_empleados.Rows[0].Cells[1];
                    columna = dgv_empleados.CurrentCell.ColumnIndex;
                }
            }
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
     
        void limpiar()
        {
            txt_buscar.Clear();

        }
        void formatear_grilla(DataGridView grilla)
        {

            try
            {

                //dgv_usuarios.Columns["swt_usr"].Visible = false;
                //dgv_usuarios.Columns["cdg_perf"].Visible = false;
                //dgv_usuarios.Columns["psw_usr"].Visible = false;

                util.FormatearGrilla(grilla,false);

                if (grilla == dgv_empleados)
                {
                    lbl_contador_registros.Visible = true;
                    lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_empleados.Rows.Count);
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
                activar_boton(false, false, false, false, false, false, false, false, false, true, true, true, false, false, true, false, true, true, true);
            }
            

        }



        #endregion

        #region Botones

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
            if (dgv_empleados.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para exportar", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            util.ExportarDataGridViewExcel(dgv_empleados, tsl_titulo.Text);
        }
        private void btn_grabar_Click(object sender, EventArgs e)
        {

            try
            {
                Thread tr = new Thread(accion_grabar_empleado);
                tr.Start();
                //Es necesario lanzar el formMesaje como ShowDialog
                Ejecucion = true;

                //Evita que mientras se está ejecutando el thread se cierre el formulario
                espera.FormClosing += (o, p) =>
                {
                    p.Cancel = Ejecucion;
                };

                espera.ShowDialog();


                MessageBox.Show("Operación finalizada con éxito.", "Grabar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            catch
            {
                espera.Close();
            }

        }
      
        #endregion

        #region Acciones

        private void accion_grabar_empleado()
        {

            try
            {
                foreach (DataGridViewRow row in dgv_empleados.Rows)
                {
                    CINT = Convert.ToString(row.Cells["CODTRAB"].Value);
                    NOM1 = Convert.ToString(row.Cells["NOM1"].Value);
                    NOM2 = Convert.ToString(row.Cells["NOM2"].Value);
                    APEP = Convert.ToString(row.Cells["APEP"].Value);
                    APEM = Convert.ToString(row.Cells["APEM"].Value);
                    SEXO = Convert.ToString(row.Cells["SEXO"].Value);
                    DNI = Convert.ToString(row.Cells["DNI"].Value);
                    TEMP = Convert.ToString(row.Cells["TEMP"].Value);
                    AREA = Convert.ToString(row.Cells["AREA"].Value);
                    TELM = Convert.ToString(row.Cells["TELM"].Value);
                    TELF = Convert.ToString(row.Cells["TELF"].Value);
                    EMAIL = Convert.ToString(row.Cells["EMAIL"].Value);
                    ACTIVO = Convert.ToString(row.Cells["ACTIVO"].Value);
                    ESTADO = Convert.ToString(row.Cells["ESTADO"].Value);
                    // CSAP = Convert.ToInt32(row.Cells["CSAP"].Value);
                    ERROR = Convert.ToString(row.Cells["ERROR"].Value);


                    int resultado = Negocio.grabar_empleado
                        (CINT, NOM1, NOM2, APEP, APEM, SEXO, DNI, TEMP, AREA, TELM, TELF, EMAIL, ACTIVO, ESTADO, CSAP, ERROR);
                    if (resultado == 0) Negocio = null;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " " + "Emplado" + " " + CINT);
            }

            Action a = () =>
            {
                Ejecucion = false;
                espera.Close();

            };

            espera.Invoke(a);

        }

        #endregion

        private void btn_nuevo_b_Click(object sender, EventArgs e)
        {

        }

     
    }
}
