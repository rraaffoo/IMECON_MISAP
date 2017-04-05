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
    public partial class FrmListado : Form
    {
        #region Variables Globales
        
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

        string par1, par2, par3, par4, par6;
        
        string filtro;
        int columna;

        decimal total_sol, total_dolar;
        decimal total_sol_ = 0, total_dolar_ = 0;


        #endregion
       
        #region Eventos

        private void FrmOpciones_Load(object sender, EventArgs e)
        {
            lbl_titulo.Text = titulo;
            this.BackColor = Color.FromArgb(247, 247, 247);
            txt_buscar.BackColor = Color.FromArgb(254, 240, 158);


            #region Activos e TI
            if (titulo == "Lista de Activos")
            {
                dgv_lista.DataSource = AccesoLogica.consultar_OACT("", "Consultar", "Listar");
            }
            #endregion

            #region Articulos Aceros
            if (titulo == "Lista de Articulos")
            {
                dgv_lista.DataSource = AccesoLogica.consultar_OITM("", "Consultar", "Listar");
            }
            #endregion

            #region Ingresos Pedidos
            if (titulo == "Lista de ingresos")
            {
                dgv_lista.DataSource = AccesoLogica.consultar_paSeguiMat(parametro_1,parametro_2);
            }
            #endregion

            #region Socios de Negocio
            if (titulo == "Lista de Socios de negocios")
            {
                dgv_lista.DataSource = AccesoLogica.consultar_OCRD(parametro_1, "", "Consultar", "Listar");
            }
            #endregion

            #region Ordenes de trabajo
            if (titulo == "Lista de Ordenes de trabajo")
            {
                dgv_lista.DataSource = AccesoLogica.consultar_OPRC("",  "Consultar", "Listar");
            }
            #endregion
          
            #region Tipos de documentos

            if (titulo == "Lista de tipos de documentos")
            {
                dgv_lista.DataSource = AccesoLogica.consultar_BPVSLN_SUNAT_T10("", "Consultar", "Listar");
            }
            #endregion

            #region Lista de documentos registrados

            if (titulo == "Lista de documentos registrados")
            {
                dgv_lista.DataSource = AccesoLogica.consultar_OTDC(0, "Consultar", "Listar");
            }
            #endregion

            #region Lista de cargos

            if (titulo == "Lista de cargos")
            {
                dgv_lista.DataSource = AccesoLogica.consultar_TDC1(0, "Consultar", "Listar");
            }
            #endregion

            #region Lista de PCA

            if (titulo == "Lista de PCA")
            {

                 dgv_lista.DataSource = AccesoLogica.consultar_OPCA(0, "Consultar", "Listar");
            }
            #endregion


            if (dgv_lista.Rows.Count != 0)
            {
               // posicion = 0;
                txt_buscar.Enabled = true;
                filtro = dgv_lista.Columns[0].HeaderText;

                dgv_lista.CurrentCell = dgv_lista.Rows[0].Cells[0];
                columna = dgv_lista.CurrentCell.ColumnIndex;
            }


         
        }

        private void dgv_lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv_lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (titulo == "Lista de Activos")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells[0].Value);

                IForm_Listado formulario_listado = this.Owner as IForm_Listado;

                if (formulario_listado != null)
                    formulario_listado.pasar_valores(par1, par2, par3, "", "Lista de Activos", "");
                Close();
            }

            if (titulo == "Lista de documentos registrados")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells[0].Value);

                IForm_Listado formulario_listado = this.Owner as IForm_Listado;

                if (formulario_listado != null)
                    formulario_listado.pasar_valores(par1, par2, par3, "", "Lista de documentos registrados", "");
                Close();
            }


          

            if (titulo == "Lista de cargos")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells[0].Value);

                IForm_Listado formulario_listado = this.Owner as IForm_Listado;

                if (formulario_listado != null)
                    formulario_listado.pasar_valores(par1, par2, par3, "", "Lista de cargos", "");
                Close();
            }

            if (titulo == "Lista de Articulos")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells[0].Value);

                IForm_Listado formulario_listado = this.Owner as IForm_Listado;

                if (formulario_listado != null)
                    formulario_listado.pasar_valores(par1, par2, par3, "", "Lista de Articulos", "");
                Close();
            }

            if (titulo == "Lista de Socios de negocios")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells[0].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells[1].Value);

                IForm_Listado formulario_listado = this.Owner as IForm_Listado;

                if (formulario_listado != null)
                    formulario_listado.pasar_valores(par1, par2, par3, "", "Lista de Socios de negocios", "");
                Close();
            }

            
            if (titulo == "Lista de Ordenes de trabajo")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells[0].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells[1].Value);

                IForm_Listado formulario_listado = this.Owner as IForm_Listado;

                if (formulario_listado != null)
                    formulario_listado.pasar_valores(par1, par2, par3, "", "Lista de Ordenes de trabajo", "");
                Close();
            }

            if (titulo == "Lista de tipos de documentos")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells[0].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells[1].Value);
                

                IForm_Listado formulario_listado = this.Owner as IForm_Listado;

                if (formulario_listado != null)
                    formulario_listado.pasar_valores(par1, par2, par3, "", "Lista de tipos de documentos", "");
                Close();
            }
           
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            (dgv_lista.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" + " ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
            formatear_grilla(dgv_lista);
        }

      


        #endregion
        
        #region Botones

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {

            if (titulo == "Lista de Activos")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells[0].Value);

                IForm_Listado formulario_listado = this.Owner as IForm_Listado;

                if (formulario_listado != null)
                    formulario_listado.pasar_valores(par1, par2, par3, "", "Lista de Activos", "");
                Close();
            }



            if (titulo == "Lista de documentos registrados")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells[0].Value);

                IForm_Listado formulario_listado = this.Owner as IForm_Listado;

                if (formulario_listado != null)
                    formulario_listado.pasar_valores(par1, par2, par3, "", "Lista de documentos registrados", "");
                Close();
            }

            if (titulo == "Lista de cargos")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells[0].Value);

                IForm_Listado formulario_listado = this.Owner as IForm_Listado;

                if (formulario_listado != null)
                    formulario_listado.pasar_valores(par1, par2, par3, "", "Lista de cargos", "");
                Close();
            }

            if (titulo == "Lista de Articulos")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells[0].Value);

                IForm_Listado formulario_listado = this.Owner as IForm_Listado;

                if (formulario_listado != null)
                    formulario_listado.pasar_valores(par1, par2, par3, "", "Lista de Articulos", "");
                Close();
            }

            if (titulo == "Lista de Socios de negocios")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells[0].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells[1].Value);

                IForm_Listado formulario_listado = this.Owner as IForm_Listado;

                if (formulario_listado != null)
                    formulario_listado.pasar_valores(par1, par2, par3, "", "Lista de Socios de negocios", "");
                Close();
            }

            if (titulo == "Lista de Ordenes de trabajo")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells[0].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells[1].Value);

                IForm_Listado formulario_listado = this.Owner as IForm_Listado;

                if (formulario_listado != null)
                    formulario_listado.pasar_valores(par1, par2, par3, "", "Lista de Ordenes de trabajo", "");
                Close();
            }

            if (titulo == "Lista de tipos de documentos")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells[0].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells[1].Value);

                IForm_Listado formulario_listado = this.Owner as IForm_Listado;

                if (formulario_listado != null)
                    formulario_listado.pasar_valores(par1, par2, par3, "", "Lista de tipos de documentos", "");
                Close();
            }

            if (titulo == "Lista de PCA")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells[0].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells[1].Value);
                par3 = Convert.ToString(dgv_lista.CurrentRow.Cells[2].Value);
                par4 = Convert.ToString(dgv_lista.CurrentRow.Cells[3].Value);
                par6 = Convert.ToString(dgv_lista.CurrentRow.Cells[4].Value);

                IForm_Listado formulario_listado = this.Owner as IForm_Listado;

                if (formulario_listado != null)
                    formulario_listado.pasar_valores(par1, par2, par3, par4, "Lista de PCA", par6);
                Close();
            }
      
        }

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
                util.FormatearGrilla(grilla,false);


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
                    grilla.Columns["Total"].DefaultCellStyle.Format ="###,##0.00";
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

        public FrmListado()
        {
            InitializeComponent();
            formatear_grilla(dgv_lista);
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

                for (int i = 0; i < dgv_lista.Columns.Count; i++)
                {
                    int colw = dgv_lista.Columns[i].Width;
                    dgv_lista.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgv_lista.Columns[i].Width = colw;
                }
     
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
            txt_buscar.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txt_buscar.Text))
            {
                txt_buscar.SelectionStart = 0;
                txt_buscar.SelectionLength = txt_buscar.Text.Length;
            }
        }

        private void txt_buscar_Leave(object sender, EventArgs e)
        {
            txt_buscar.BackColor = Color.White;
        }

        private void txt_buscar_MouseClick(object sender, MouseEventArgs e)
        {
                     if (!String.IsNullOrEmpty(txt_buscar.Text))
            {
                txt_buscar.SelectionStart = 0;
                txt_buscar.SelectionLength = txt_buscar.Text.Length;
            }
        }

      

        private void dgv_lista_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar.Focus();
            txt_buscar.Clear();

            filtro = dgv_lista.Columns[e.ColumnIndex].HeaderText;
            dgv_lista.Text = "Buscar en " + filtro;

            dgv_lista.CurrentCell = dgv_lista.Rows[0].Cells[e.ColumnIndex];
        }

        private void cm_grilla_copia_Click(object sender, EventArgs e)
        {
            util.copiar_contextual(dgv_lista);
        }

        private void cm_grilla_copia_tabla_Click(object sender, EventArgs e)
        {
            util.copiar_todo_encabezados(dgv_lista);
        }

        private void cm_exportar_excel_Click(object sender, EventArgs e)
        {
            util.ExportarDataGridViewExcel(dgv_lista, lbl_titulo.Text);
        }

        private void dgv_lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

      
      
        }

       

             
    }

