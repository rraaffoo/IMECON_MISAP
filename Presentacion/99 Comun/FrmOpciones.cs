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
    public partial class FrmOpciones : Form
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


            #region Proyectos
            if (titulo == "Lista de proyectos")
            {
                dgv_lista.DataSource = AccesoLogica.listar_proyectos("busqueda");
                btn_nuevo.Visible = false;
            }
            #endregion

            #region centro de costos
            if (titulo == "Lista de ordenes de trabajo")
            {
                dgv_lista.DataSource = AccesoLogica.listar_ot_sap_2(parametro_1, "Listar");
                btn_nuevo.Visible = false;
            }
            #endregion

            #region presupuestos
            if (titulo == "Lista de presupuestos")
            {
                dgv_lista.DataSource = AccesoLogica.listar_presupuestos();
                formatear_grilla(dgv_lista);
            }
            #endregion

            #region materiales
            if (titulo == "Lista de materiales")
            {
                this.Location = new System.Drawing.Point(600, 220);

                lbl_cantidad.Visible = true;
                txt_cantidad.Visible = true;
                btn_nuevo.Visible = false;

                dgv_lista.DataSource = AccesoLogica.listar_materiales_servicios_sap("Materiales","");
           
            }
            #endregion

            #region servicios
            if (titulo == "Lista de servicios")
            {
                this.Location = new System.Drawing.Point(600, 220);

                lbl_cantidad.Visible = true;
                txt_cantidad.Visible = true;
                btn_nuevo.Visible = false;

                dgv_lista.DataSource = AccesoLogica.listar_materiales_servicios_sap("Servicios","");
         
            }
            #endregion

            #region activos
            if (titulo == "Lista de activos")
            {
                this.Location = new System.Drawing.Point(600, 220);

                lbl_cantidad.Visible = true;
                txt_cantidad.Visible = true;
                btn_nuevo.Visible = false;
                chk_tipo.Visible = true;
                dgv_lista.DataSource = AccesoLogica.listar_materiales_servicios_sap("Activo Fijo","Nuevos");
             
            }
            #endregion

            #region mes de trabajo

            if (titulo == "Lista de mes de trabajo")
            {
                this.Location = new System.Drawing.Point(600, 220);

                lbl_cantidad.Visible = false;
                txt_cantidad.Visible = false;
                btn_nuevo.Visible = false;

                dgv_lista.DataSource = AccesoLogica.listar_mes_trabajo();
             
          
            }
            #endregion

            #region pedidos
            if (titulo == "Lista de pedidos")
            {
                this.Location = new System.Drawing.Point(600, 220);

                lbl_cantidad.Visible = false;
                txt_cantidad.Visible = false;
                btn_nuevo.Visible = false;

                //btn_seleccionar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
                //btn_seleccionar.Enabled = false;

                btn_seleccionar.Text = "Ver pedido";
                
                dgv_lista.DataSource = AccesoLogica.listar_pedidos_provision(parametro_1, parametro_1_n);
             
            }
            #endregion

            #region documentos
            if (titulo == "Lista de documentos")
            {
                this.Location = new System.Drawing.Point(600, 220);

                lbl_cantidad.Visible = false;
                txt_cantidad.Visible = false;
                btn_nuevo.Visible = false;
                btn_seleccionar.Visible = false;
                btn_cancelar.Location = new System.Drawing.Point(12, 344);
                              
               
                dtable = AccesoLogica.listar_documentos_cheque(parametro_1, parametro_1_n, parametro_2_n);
                dgv_lista.DataSource = dtable;
              

                util.TotalizarGrilla(dgv_lista);
               
            
               DataRow fila = dtable.NewRow();
               dtable.Rows.Add(fila);

                        
               DataGridViewRow rowTotal = dgv_lista.Rows[dgv_lista.Rows.Count - 1];
               rowTotal.Cells["Total"].Value = Utilidades.Total_SOL; 
               rowTotal.Cells["Total Dolares"].Value = Utilidades.Total_USD;

               rowTotal.Cells["Total Dolares"].Style.Font = new Font("Arial", 8);
               rowTotal.Cells["Total"].Style.Font = new Font("Arial", 8);

        
               //Color.FromArgb(231, 231, 231);
               btn_cancelar.Text = "OK";

            }

            #endregion

            #region cuenta contable

            if (titulo == "Lista de Cuentas")
            {
                dgv_lista.DataSource = AccesoLogica.listar_cuentas();
               

                btn_nuevo.Visible = false;
            }

            #endregion

            #region bancos

            if (titulo == "Lista de bancos")
            {
                dgv_lista.DataSource = AccesoLogica.listar_bancos();


                btn_nuevo.Visible = false;
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
            if (titulo == "Lista de materiales" || titulo == "Lista de servicios")
            {
                txt_cantidad.Focus();
            }
        }

        private void dgv_lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (titulo == "Lista de presupuestos")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["Codigo"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["Descripcion"].Value);

               IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, "", "Lista de presupuestos","");
                Close();
            }

            if (titulo == "Lista de ordenes de trabajo")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["Codigo"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["Descripcion"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, "", "Lista de ordenes de trabajo", "");
                Close();
            }

            if (titulo == "Lista de proyectos")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["Codigo"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["Descripcion"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, "", "Lista de proyectos", "");
                Close();
            }


            if (titulo == "Lista de Cuentas")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["Numero de cuenta"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["Nombre de la cuenta"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, "", "Lista de Cuentas", "");
                Close();
            }
            if (titulo == "Lista de materiales")
            {
                txt_cantidad.Focus();
            }


            if (titulo == "Lista de pedidos")
            {
                int pedido;
                try
                {
                    pedido = Convert.ToInt32(dgv_lista.CurrentRow.Cells["Nro de Pedido"].Value);
                }

                catch
                {
                    MessageBox.Show("No Existe Pedido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;

                }



                CrvPedido reporte = new CrvPedido();
                reporte.pedido = pedido;
                reporte.ShowDialog(this);
            }

            if (titulo == "Lista de bancos")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["Codigo bancario"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["Nombre de Banco"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, "", "Lista de bancos", "");
                Close();
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            (dgv_lista.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" + " ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
            formatear_grilla(dgv_lista);
        }

        private void txt_cantidad_Enter(object sender, EventArgs e)
        {
            txt_cantidad.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txt_cantidad.Text))
            {
                txt_cantidad.SelectionStart = 0;
                txt_cantidad.SelectionLength = txt_cantidad.Text.Length;
            }
        }

        private void txt_cantidad_Leave(object sender, EventArgs e)
        {
            txt_cantidad.BackColor = Color.White;
        }

        private void txt_cantidad_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_cantidad.Text))
            {
                txt_cantidad.SelectionStart = 0;
                txt_cantidad.SelectionLength = txt_cantidad.Text.Length;
            }
        }

        #endregion
        
        #region Botones

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
           
            if (titulo == "Lista de presupuestos")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["Codigo"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["Descripcion"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, "", "Lista de presupuestos","");
                Close();
            }

            if (titulo == "Lista de ordenes de trabajo")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["Codigo"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["Descripcion"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, "", "Lista de ordenes de trabajo", "");
                Close();
            }

            if (titulo == "Lista de proyectos")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["Codigo"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["Descripcion"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, "", "Lista de proyectos", "");
                Close();
            }


            if (titulo == "Lista de Cuentas")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["Numero de cuenta"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["Nombre de la cuenta"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, "", "Lista de Cuentas", "");
                Close();
            }


            if (titulo == "Lista de bancos")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["Codigo bancario"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["Nombre de Banco"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, "", "Lista de bancos", "");
                Close();
            }

            if (titulo == "Lista de mes de trabajo")
            {
                //MessageBox.Show(Convert.ToString(dgv_lista.CurrentRow.Cells["Codigo"].Value));
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["Codigo"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["Descripcion"].Value);
                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, "", "Lista de mes de trabajo","");
                Close();
            }

            if (titulo == "Lista de materiales" || titulo == "Lista de servicios" )
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["Codigo"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["Descripcion"].Value);
                par3 = Convert.ToString(dgv_lista.CurrentRow.Cells["Umed"].Value);
                par4 = Convert.ToString(txt_cantidad.Text);
                
                #region validaciones
                if (txt_cantidad.Text == string.Empty)
                {

                    MessageBox.Show("Digite la cantidad requerida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                    txt_cantidad.Focus();
                    return;
                }

                if(Convert.ToDecimal(txt_cantidad.Text) == 0)
                {
                    MessageBox.Show("Debe ingresar una cantidad diferenete de 0", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                    txt_cantidad.Focus();
                    return;
                }

                #endregion

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, par4, "Lista de materiales","");


                // Close();
            }

            if (titulo == "Lista de activos")
            {

                Int32 FilasSeleccionadas = dgv_lista.SelectedRows.Count;

                #region validaciones
                if (txt_cantidad.Text == string.Empty)
                {

                    MessageBox.Show("Digite la cantidad requerida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                    txt_cantidad.Focus();
                    return;
                }

                if (Convert.ToDecimal(txt_cantidad.Text) == 0)
                {
                    MessageBox.Show("Debe ingresar una cantidad diferenete de 0", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                    txt_cantidad.Focus();
                    return;
                }

                #endregion

                if (FilasSeleccionadas > 0)
                {
                    for (int i = 0; i < FilasSeleccionadas; i++)
                    {
                        par1 = dgv_lista.SelectedRows[i].Cells["Codigo"].Value.ToString();
                        par2 = dgv_lista.SelectedRows[i].Cells["Descripcion"].Value.ToString();
                        par3 = dgv_lista.SelectedRows[i].Cells["Umed"].Value.ToString();
                        par4 = Convert.ToString(txt_cantidad.Text);
                        par6 = dgv_lista.SelectedRows[i].Cells["Cod. Familia"].Value.ToString();


                        IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                        if (formulario_opciones != null)
                            formulario_opciones.pasar_valores(par1, par2, par3, par4, "Lista de materiales",par6);
                 }


              }
                
                
                // Close();
            }


            if (titulo == "Lista de pedidos")
            {
                int pedido;
                try
                {
                    pedido = Convert.ToInt32(dgv_lista.CurrentRow.Cells["Nro de Pedido"].Value);
                }

                catch
                {
                    MessageBox.Show("No Existe Pedido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;

                }

                CrvPedido reporte = new CrvPedido();
                reporte.pedido = pedido;
                reporte.ShowDialog(this);
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

        public FrmOpciones()
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
            txt_cantidad.Clear();

            if (!String.IsNullOrEmpty(txt_buscar.Text))
            {
                txt_buscar.SelectionStart = 0;
                txt_buscar.SelectionLength = txt_buscar.Text.Length;
            }
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validar_numeros(txt_cantidad, e);
                      
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

        private void chk_tipo_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_tipo.Checked == true)
            {
                dgv_lista.DataSource = AccesoLogica.listar_materiales_servicios_sap("Activo Fijo", "Todos");
                formatear_grilla(dgv_lista);
            }
            else
            {
                dgv_lista.DataSource = AccesoLogica.listar_materiales_servicios_sap("Activo Fijo", "Nuevos");
                formatear_grilla(dgv_lista);
            }
        }

      
      
        }

       

             
    }

