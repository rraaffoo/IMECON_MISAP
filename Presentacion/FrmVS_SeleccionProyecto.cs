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
using System.Runtime.InteropServices;

namespace MISAP
{
    public partial class FrmVS_SeleccionProyecto : Form
    {
        #region Variables Globales

        public string usuario, perfil, bd_sap;
        public string formulario, titulo, bd, sp, parametro_1, parametro_2, parametro_3, parametro_4;
        public int parametro_1_n, parametro_2_n;

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


        Utilidades util = new Utilidades();
        DataTable dtable = new DataTable();

        string formProcedencia;


        #endregion

        AccesoLogica _negocio = new AccesoLogica();

        #region Eventos

        private void FrmOpciones_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = usuario;
            txtperfil_cod.Text = perfil;
            cargar_combo_proyectos();
        }

        private void cargar_combo_proyectos()
        {
            cbo_proyecto.DataSource = _negocio.listar_combo_proyectos("combo");
            cbo_proyecto.ValueMember = "codigo";
            cbo_proyecto.DisplayMember = "descripcion";
        }



        #endregion

        #region Botones



        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Funciones
        void formatear_grilla(DataGridView grilla)
        {

            try
            {
                util.FormatearGrilla(grilla, false);


                if (titulo == "Lista de proyectos" || titulo == "Lista de ordenes de trabajo" || titulo == "Lista de presupuestos")
                {
                    grilla.Columns["Codigo"].Width = 139;
                    grilla.Columns["Descripcion"].Width = 250;

                }

                if (titulo == "Lista de materiales" || titulo == "Lista de servicios" || titulo == "Lista de activos")
                {
                    grilla.Columns["Codigo"].Width = 146;
                    grilla.Columns["Descripcion"].Width = 243;

                    grilla.Columns["Umed"].Width = 40;


                }

                if (titulo == "Lista de mes de trabajo")
                {
                    grilla.Columns["Codigo"].Width = 146;
                    grilla.Columns["Descripcion"].Width = 243;
                    grilla.Columns["Codigo"].DefaultCellStyle.Format = "dd/MM/yyyy";

                }

                if (titulo == "Lista de Cuentas")
                {
                    grilla.Columns["Numero de cuenta"].Width = 146;
                    grilla.Columns["Nombre de la cuenta"].Width = 243;

                }

                if (titulo == "Lista de bancos")
                {
                    grilla.Columns["Codigo bancario"].Width = 146;
                    grilla.Columns["Nombre de Banco"].Width = 243;
                }

                if (titulo == "Lista de documentos")
                {
                    grilla.Columns["Total"].DefaultCellStyle.Format = "###,##0.00";
                    grilla.Columns["Total Dolares"].DefaultCellStyle.Format = "###,##0.00";
                    grilla.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    grilla.Columns["Total Dolares"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Fabricación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }


        #endregion

        #region Formulario

        public FrmVS_SeleccionProyecto()
        {
            InitializeComponent();
            //formatear_grilla(dgv_lista);
        }
        public FrmVS_SeleccionProyecto(string proc)
        {
            InitializeComponent();
            //formatear_grilla(dgv_lista);
            formProcedencia = proc;
        }

        private void ninimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizar_Click(object sender, EventArgs e)
        {

            this.WindowState = (this.WindowState == FormWindowState.Maximized ?

                FormWindowState.Normal
                : FormWindowState.Maximized);

            if (this.WindowState == FormWindowState.Maximized)
            {
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));

                //for (int i = 0; i < dgv_lista.Columns.Count - 1; i++)
                //{
                //    dgv_lista.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //}
                //dgv_lista.Columns[dgv_lista.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                //for (int i = 0; i < dgv_lista.Columns.Count; i++)
                //{
                //    int colw = dgv_lista.Columns[i].Width;
                //    dgv_lista.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //    dgv_lista.Columns[i].Width = colw;
                //}

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
            //    this.StartPosition = FormStartPosition.CenterScreen;
            //    maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
            //    this.SetBounds(this.Location.X, this.Location.Y, 919, 674);


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

        private void txt_buscar_Enter(object sender, EventArgs e)
        {
            //txt_buscar.BackColor = Color.FromArgb(254, 240, 158);
            //if (!String.IsNullOrEmpty(txt_buscar.Text))
            //{
            //    txt_buscar.SelectionStart = 0;
            //    txt_buscar.SelectionLength = txt_buscar.Text.Length;
            //}
        }

        private void txt_buscar_Leave(object sender, EventArgs e)
        {
            //txt_buscar.BackColor = Color.White;
        }

        private void txt_buscar_MouseClick(object sender, MouseEventArgs e)
        {
            //txt_cantidad.Clear();

            //if (!String.IsNullOrEmpty(txt_buscar.Text))
            //{
            //    txt_buscar.SelectionStart = 0;
            //    txt_buscar.SelectionLength = txt_buscar.Text.Length;
            //}
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //util.validar_numeros(txt_cantidad, e);

        }

        private void dgv_lista_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            //txt_buscar.Focus();
            //txt_buscar.Clear();

            //filtro = dgv_lista.Columns[e.ColumnIndex].HeaderText;
            //dgv_lista.Text = "Buscar en " + filtro;

            //dgv_lista.CurrentCell = dgv_lista.Rows[0].Cells[e.ColumnIndex];
        }

        private void chk_tipo_CheckedChanged(object sender, EventArgs e)
        {
            //if (chk_tipo.Checked == true)
            //{
            //    dgv_lista.DataSource = AccesoLogica.listar_materiales_servicios_sap("Activo Fijo", "Todos");
            //    formatear_grilla(dgv_lista);
            //}
            //else
            //{
            //    dgv_lista.DataSource = AccesoLogica.listar_materiales_servicios_sap("Activo Fijo", "Nuevos");
            //    formatear_grilla(dgv_lista);
            //}
        }

        private void cbo_proyecto_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cbo_proyecto_Enter(object sender, EventArgs e)
        {
            cbo_proyecto.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cbo_proyecto_Leave(object sender, EventArgs e)
        {
            cbo_proyecto.BackColor = Color.White;
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (cbo_proyecto.SelectedValue.ToString() != "0")
            {
                switch (formProcedencia)
                {
                    case "SD":
                        FrmVS_SolicitudDinero frmSD = new FrmVS_SolicitudDinero(cbo_proyecto.SelectedValue.ToString());
                        frmSD.usuario = txtUsuario.Text;
                        frmSD.perfil = txtperfil_cod.Text;
                        frmSD.ShowDialog();
                        break;
                    case "GR":
                        FrmVS_GestionRendiciones frmGR = new FrmVS_GestionRendiciones(cbo_proyecto.SelectedValue.ToString());
                        frmGR.usuario = txtUsuario.Text;
                        frmGR.perfil = txtperfil_cod.Text;
                        frmGR.ShowDialog();
                        break;
                    case "GC":
                        FrmVS_GestionCajaChica frmGC = new FrmVS_GestionCajaChica(cbo_proyecto.SelectedValue.ToString());
                        frmGC.usuario = txtUsuario.Text;
                        frmGC.perfil = txtperfil_cod.Text;
                        frmGC.ShowDialog();
                        break;
                    default:
                        break;
                }


                

            }

        }

    }




}

