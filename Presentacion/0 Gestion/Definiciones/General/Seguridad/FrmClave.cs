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
    public partial class FrmClave : Form
    {

        #region Variables Globales

        public string formulario, titulo, usuario, cod_autorizacion;

        #endregion

        #region Variables locales


        private Point pos = Point.Empty;
        private bool move = false;


        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();

       
      
        #endregion

        #region Formulario

        public FrmClave()
        {
            InitializeComponent();
        }


        private void ninimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
        private void salir_Click(object sender, EventArgs e)
        {
            Close();
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

        #region Eventos

        private void FrmClave_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(247, 247, 247);
            lbl_titulo.Text = titulo;

            if (formulario == "FrmMenu")
            {
                lbl_clave_antigua.Visible = true;
                txt_clave_antigua.Visible = true;
                lbl_clave.Text = "Clave nueva";
                txt_clave_bd.Text = Convert.ToString(AccesoLogica.obtener_clave(usuario).Rows[0][0]);
                btn_grabar.Text = "Actualizar";
                txt_clave_antigua.Focus();

            }

            if (formulario == "FrmMUsuario")
            {
                txt_clave.Focus();
            }

            if (formulario == "FrmPedidos")
            {
                txt_clave_antigua.Visible = false;
                txt_confirmacion.Visible = false;
                lbl_confirmacion.Visible = false;
                lbl_clave.Text = titulo;
            }

        }

        private void txt_clave_Enter(object sender, EventArgs e)
        {
            txt_clave.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txt_clave.Text))
            {
                txt_clave.SelectionStart = 0;
                txt_clave.SelectionLength = txt_clave.Text.Length;
            }
        }

        private void txt_clave_Leave(object sender, EventArgs e)
        {
            txt_clave.BackColor = Color.White;
        }

        private void txt_clave_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_clave.Text))
            {
                txt_clave.SelectionStart = 0;
                txt_clave.SelectionLength = txt_clave.Text.Length;
            }
        }

        private void txt_confirmacion_Enter(object sender, EventArgs e)
        {
            txt_confirmacion.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txt_confirmacion.Text))
            {
                txt_confirmacion.SelectionStart = 0;
                txt_confirmacion.SelectionLength = txt_confirmacion.Text.Length;
            }
        }

        private void txt_confirmacion_Leave(object sender, EventArgs e)
        {
            txt_confirmacion.BackColor = Color.White;
        }

        private void txt_confirmacion_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_confirmacion.Text))
            {
                txt_confirmacion.SelectionStart = 0;
                txt_confirmacion.SelectionLength = txt_confirmacion.Text.Length;
            }
        }

        private void txt_clave_antigua_Enter(object sender, EventArgs e)
        {
            txt_clave_antigua.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txt_clave_antigua.Text))
            {
                txt_clave_antigua.SelectionStart = 0;
                txt_clave_antigua.SelectionLength = txt_clave_antigua.Text.Length;
            }
        }

        private void txt_clave_antigua_Leave(object sender, EventArgs e)
        {
            txt_clave_antigua.BackColor = Color.White;
        }

        private void txt_clave_antigua_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_clave_antigua.Text))
            {
                txt_clave_antigua.SelectionStart = 0;
                txt_clave_antigua.SelectionLength = txt_clave_antigua.Text.Length;
            }
        }

        #endregion

        #region Botones

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            if (txt_clave.Text == string.Empty)
            {

                MessageBox.Show("Digite la clave", titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txt_clave.Focus();
                return;
            }

        
            
            
            if (formulario == "FrmMUsuario")
            {
                if (txt_confirmacion.Text == string.Empty)
                {

                    MessageBox.Show("Digite la confirmación de clave", titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    txt_confirmacion.Focus();
                    return;
                }

                if (txt_clave.Text == txt_confirmacion.Text)
                {
                    IForm_Clave clave = this.Owner as IForm_Clave;

                    if (clave != null)
                        clave.pasar_clave("", txt_clave.Text, "");
                    Close();
                }
                else
                {
                    MessageBox.Show("Las claves no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txt_clave.Clear();
                    txt_confirmacion.Clear();
                    txt_clave.Focus();
                    return;

                }
            }


            if (formulario == "FrmMenu")
            {
                if (txt_confirmacion.Text == string.Empty)
                {

                    MessageBox.Show("Digite la confirmación de clave", titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    txt_confirmacion.Focus();
                    return;
                }

                if (txt_clave_antigua.Text != txt_clave_bd.Text)
                {
                    MessageBox.Show("Clave de acceso errónea", titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    txt_clave_antigua.Clear();
                    txt_clave_antigua.Focus();
                    return;
                }


                if (txt_clave.Text == txt_confirmacion.Text)
                {
                    int resultado = Negocio.mantenimiento_OUSR
                                (usuario, "", 0, "", "", "", txt_clave.Text, 0, "", "", "", "", "", "", "Editar", "FrmClave");
                    if (resultado == 0) Negocio = null;

                    

                   MessageBox.Show("Operación finalizada con éxito", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                   Close();

                   
                }
                else
                {
                    MessageBox.Show("Las claves no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txt_clave.Clear();
                    txt_confirmacion.Clear();
                    txt_clave.Focus();
                    return;

                }
            }


            if (formulario == "FrmPedidos")
            {
                if (txt_clave.Text != cod_autorizacion)
                {
                    MessageBox.Show("El codigo de autorizacion no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txt_clave.Clear();
                    txt_clave.Focus();

                    return;
                }
                else
                {
                    Close();
                }
                
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

       
    }
}
