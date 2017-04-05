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
    public partial class FrmParametrizacion : Form
    {

        #region Variables Globales

        public string formulario, grilla, usuario;
        public int GrillaId;

        #endregion

        #region Variables locales


        private Point pos = Point.Empty;
        private bool move = false;


        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();
        FrmEspera espera = new FrmEspera();

        string par1, par2, par3, par4, par5, par6, par7, par8, par9, par10, par11;

        string filtro;
        int columna, cant_col, ColumnaId, id ;
        int[] vector, vec_col ;
        bool[] vec_falg;
        bool visible_;
        #endregion

        #region Formulario

        public FrmParametrizacion()
        {
            InitializeComponent();
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
                this.SetBounds(this.Location.X, this.Location.Y, 353, 429);
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
                this.SetBounds(this.Location.X, this.Location.Y, 353, 429);
                this.Location = new System.Drawing.Point(320, 80);

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


        #region Funciones
        void formatear_grilla(DataGridView grilla_)
        {

            try
            {
                util.FormatearGrilla(grilla_,false);
                grilla_.Columns["ColumnaId"].Visible = false;
                grilla_.Columns["id"].Visible = false;
                grilla_.Columns["UserId"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Fabricación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }


        #endregion 

       
        private void FrmParametrizacion_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(600, 220);
            this.BackColor = Color.FromArgb(247, 247, 247);
            tp_tabla.BackColor = Color.FromArgb(247, 247, 247);
            tp_lineas.BackColor = Color.FromArgb(247, 247, 247);
            tp_documentos.BackColor = Color.FromArgb(247, 247, 247);
            tp_elementos.BackColor = Color.FromArgb(247, 247, 247);
            
            dgv_columnas.DataSource = AccesoLogica.consultar_FRM1(formulario, grilla, usuario, GrillaId);
            formatear_grilla(dgv_columnas);

            //foreach (DataGridViewRow row in dgv_columnas.Rows)
            //{
            //    row.Cells["Visible"].Value = true;
            //}
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_columnas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            int i = 0;
            int x = 0;
            foreach (DataGridViewRow row in dgv_columnas.Rows)
            {
      
                    cant_col++;
         
            }

            vec_col = new int[cant_col];
            vec_falg = new bool[cant_col];
            
            foreach (DataGridViewRow row in dgv_columnas.Rows)
            {
             
                        vec_col[i] = Convert.ToInt32(row.Cells["ColumnaId"].Value);
                        vec_falg[x] = Convert.ToBoolean(row.Cells["Visible"].Value);
                  
                        i++;
                        x++;

                        ColumnaId = Convert.ToInt32(row.Cells["ColumnaId"].Value);
                        id = Convert.ToInt32(row.Cells["id"].Value);
                        visible_ = Convert.ToBoolean(row.Cells["Visible"].Value);

                        int resultado_d = Negocio.grabar_parametrizacion
                            (id, usuario, ColumnaId, visible_, GrillaId);
                        if (resultado_d == 0) Negocio = null;

            }

            IForm_parametrizacion formulario_parametrizacion = this.Owner as IForm_parametrizacion;

            if (formulario_parametrizacion != null)
                formulario_parametrizacion.pasar_valores_parametrizacion(vec_col, vec_falg);
            Close();
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
           
            if (flag_seleccionar.Text == "1")
            {
              
                btn_seleccionar.Text = "Seleccionar todos";
                flag_seleccionar.Text = "0";


                foreach (DataGridViewRow row in dgv_columnas.Rows)
                {
                    row.Cells["Visible"].Value = false;
                }
            }
            else
            {
                btn_seleccionar.Text = "Ninguno";
                flag_seleccionar.Text = "1";


                foreach (DataGridViewRow row in dgv_columnas.Rows)
                {
                    row.Cells["Visible"].Value = true;
                }
            }

        }

    
    }
}
