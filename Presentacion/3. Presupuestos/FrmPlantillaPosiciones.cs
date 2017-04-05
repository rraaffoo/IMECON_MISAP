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

namespace MISAP
{
    public partial class FrmPlantillaPosiciones : Form, IForm_opciones
    {
       
        #region Variables globales

        public string usuario, perfil;



        #endregion

        #region Variables locales

        private Point pos = Point.Empty;
        private bool move = false;
       // bool allowSelect = false;

        Utilidades util = new Utilidades();

        string filtro;
        int columna;

        #endregion

        #region Formulario

        public FrmPlantillaPosiciones()
        {
            InitializeComponent();
            ts_acciones.Renderer = new MyRenderer();
            titulo.Renderer = new MyRenderer();
        }


        private void ninimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizar_Click(object sender, EventArgs e)
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
                this.Location = new System.Drawing.Point(320, 150);
               // this.StartPosition = FormStartPosition.CenterScreen;
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
                this.SetBounds(this.Location.X, this.Location.Y, 749, 631);
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
                this.Location = new System.Drawing.Point(320, 150);
                // this.StartPosition = FormStartPosition.CenterScreen;
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
                this.SetBounds(this.Location.X, this.Location.Y, 749, 631);
                lbl_maximi.Text = "1";
            }

        }

        private void titulo_MouseDown(object sender, MouseEventArgs e)
        {
            pos = new Point(e.X, e.Y);
            move = true;
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
                if (par5 == "Lista de presupuestos")
                {
                    txt_codpresupuesto.Text = par1;
                    txt_codpresupuesto.BackColor = Color.White;

                    txt_presupuesto.Text = par2;
                    txt_presupuesto.BackColor = Color.White;

                    dgv_posiciones.DataSource = AccesoLogica.consultar_posiciones(par1);
                    formatear_grilla();

                    activar_boton(false, false, false, false, false, false, true, false, false, true, false, false, true);
                   
                    btn_opciones.Visible = false;
                    txt_buscar.Enabled = true;
                    txt_buscar.Focus();
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
        #endregion
        
        #region Eventos
        private void FrmPlantillaPosiciones_Load(object sender, EventArgs e)
        {
            util.FormatearFormulario(this, ts_acciones, tc_usuario, ss_load, txt_buscar, tp_listado, tp_nuevo, tp_auditoria);

            this.Location = new System.Drawing.Point(320, 150);
            txt_buscar.BackColor = Color.FromArgb(231, 231, 231);
            txt_codpresupuesto.BackColor = Color.FromArgb(231, 231, 231);
            txt_presupuesto.BackColor = Color.FromArgb(231, 231, 231);


            //foreach (DataGridViewColumn col in dgv_posiciones.Columns)
            //{
            //    col.SortMode = DataGridViewColumnSortMode.NotSortable;

            //}
        }

        private void dgv_posiciones_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar.Focus();

            filtro = dgv_posiciones.Columns[e.ColumnIndex].HeaderText;
            lbl_buscar.Text = "Buscar en " + filtro;

            columna = dgv_posiciones.CurrentCell.ColumnIndex;
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            
            if (dgv_posiciones.Rows.Count != 0)
            {
                

                if (columna != 0)
                {


                    (dgv_posiciones.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" +   filtro  + " ,'System.String') LIKE '{0}%'", txt_buscar.Text);
                    formatear_grilla();

                }
                else
                {
                    (dgv_posiciones.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(Secuencial,'System.String') LIKE '%{0}%'", txt_buscar.Text);
                    formatear_grilla();
                }
            }
            else
            {
                (dgv_posiciones.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(Secuencial,'System.String') LIKE '%{0}%'", txt_buscar.Text);
                formatear_grilla();
            }
        }

        private void txt_codpresupuesto_Leave(object sender, EventArgs e)
        {
            txt_codpresupuesto.BackColor = Color.White;
            //btn_opciones.Visible = false;
           
        }

        private void txt_codpresupuesto_Enter(object sender, EventArgs e)
        {
            txt_codpresupuesto.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txt_codpresupuesto.Text))
            {
                txt_codpresupuesto.SelectionStart = 0;
                txt_codpresupuesto.SelectionLength = txt_codpresupuesto.Text.Length;
            }

        }

        private void txt_codpresupuesto_MouseClick(object sender, MouseEventArgs e)
        {
            btn_opciones.Visible = true;
            txt_codpresupuesto.ReadOnly = false;
            if (!String.IsNullOrEmpty(txt_codpresupuesto.Text))
            {
                txt_codpresupuesto.SelectionStart = 0;
                txt_codpresupuesto.SelectionLength = txt_codpresupuesto.Text.Length;
            }
        }

        private void txt_codpresupuesto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Convert.ToInt32(e.KeyChar) == Convert.ToInt32(Keys.Enter))
            {
                txt_buscar.Clear();

                dgv_posiciones.DataSource = AccesoLogica.consultar_posiciones(txt_codpresupuesto.Text);
                formatear_grilla();

                activar_boton(false, false, false, false, false, false, true, false, false, true, false, false, true);

                txt_codpresupuesto.BackColor = Color.White;
                btn_opciones.Visible = false;
                txt_buscar.Enabled = true;
                txt_buscar.Focus();
            }
        }

        private void txt_buscar_Enter(object sender, EventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txt_buscar.Text))
            {
                txt_buscar.SelectionStart = 0;
                txt_buscar.SelectionLength = txt_buscar.Text.Length;
            }
        }

        private void txt_buscar_MouseClick(object sender, MouseEventArgs e)
        {
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

        #endregion

        #region Botones


        private void btn_nuevo_b_Click(object sender, EventArgs e)
        {
            activar_boton(false, false, false, false, false, false, false, false, false, false, false, false, true);
            txt_codpresupuesto.ReadOnly = false;
            txt_codpresupuesto.BackColor = Color.FromArgb(254, 240, 158);
            txt_codpresupuesto.Focus();
            btn_opciones.Visible = true;

        }

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
            util.ExportarDataGridViewExcel(dgv_posiciones, tsl_titulo.Text);
        }

        private void btn_opciones_Click(object sender, EventArgs e)
        {
            FrmOpciones opciones = new FrmOpciones();
            opciones.titulo = "Lista de presupuestos";
            opciones.ShowDialog(this);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dgv_posiciones.DataSource = AccesoLogica.consultar_posiciones(txt_codpresupuesto.Text);
            formatear_grilla();
        }

        #endregion 
        
        #region Funciones

        void activar_boton(bool nuevo, bool editar, bool consultar, bool eliminar, bool imprimir, bool previsualizar, bool exportar_xls, bool aprobar, bool desaprobar, bool actualizar, bool ayuda, bool grabar, bool cancelar)
        {
            btn_nuevo_b.Enabled = nuevo;
            btn_editar_b.Enabled = editar;
            btn_consultar_b.Enabled = consultar;
            btn_eliminar_b.Enabled = eliminar;
            btn_imprimir.Enabled = imprimir;
            btn_previsualizar.Enabled = previsualizar;
            btn_exportar_xls.Enabled = exportar_xls;
            btn_aprobar.Enabled = aprobar;
            btn_desaprobar.Enabled = desaprobar;
            btn_actualizar.Enabled = actualizar;
            btn_grabar.Enabled = grabar;
            btn_cancelar.Enabled = cancelar;

        }

        void formatear_grilla()
        {
            try
            {
                dgv_posiciones.Columns["Secuencial"].Width = 30;
                dgv_posiciones.Columns["TipoPos"].Width = 45;
                dgv_posiciones.Columns["Orden"].Width = 55;
                dgv_posiciones.Columns["Unidad de medida"].Width = 35;
                dgv_posiciones.Columns["TipoPos"].Width = 25;


                util.FormatearGrilla(dgv_posiciones,false);
                lbl_contador_registros.Visible = true;
                lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_posiciones.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Fabricación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
        }

        #endregion

        #region Menu contextual

        private void cm_grilla_copia_tabla_Click(object sender, EventArgs e)
        {
            util.copiar_todo_encabezados(dgv_posiciones);
        }

        private void cm_grilla_copia_Click(object sender, EventArgs e)
        {
            util.copiar_contextual(dgv_posiciones);
        }

        #endregion

        

    }
}
