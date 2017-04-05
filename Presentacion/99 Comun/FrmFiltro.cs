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
    public partial class FrmFiltro : Form
    {
        #region Variables Globales

        public string formulario, titulo, bd, sp, parametro_1, parametro_2, parametro_3, parametro_4, anio, perfil, usuario, estado,tipo;
        
        #endregion

        #region Variables locales


        private Point pos = Point.Empty;
        private bool move = false;
   

        Utilidades util = new Utilidades();

        string par1, par2, par3, par4;
        
        string filtro;
        int columna;

        #endregion
       
        #region Eventos

        private void FrmOpciones_Load(object sender, EventArgs e)
        {
                     this.BackColor = Color.FromArgb(247, 247, 247);

            //carga combo req
            cbo_requerimiento.DataSource = AccesoLogica.listar_combo_filtro(formulario, "num_ped", estado, anio, usuario, perfil, tipo);
            cbo_requerimiento.DisplayMember = "Descripcion";
            cbo_requerimiento.ValueMember = "Codigo";
            cbo_requerimiento.SelectedItem = null;

            //carga combo solicitante
            cbo_solicitante.DataSource = AccesoLogica.listar_combo_filtro(formulario, "usu_crea", estado, anio, usuario, perfil, tipo);
            cbo_solicitante.DisplayMember = "Descripcion";
            cbo_solicitante.ValueMember = "Codigo";
            cbo_solicitante.SelectedItem = null;

            //carga combo solicitante
            cbo_ot.DataSource = AccesoLogica.listar_combo_filtro(formulario, "num_ord", estado, anio, usuario, perfil, tipo);
            cbo_ot.DisplayMember = "Descripcion";
            cbo_ot.ValueMember = "Codigo";
            cbo_ot.SelectedItem = null;

            //carga combo responsable
            cbo_responsable.DataSource = AccesoLogica.listar_combo_filtro(formulario, "U_CDG_USER", estado, anio, usuario, perfil, tipo);
            cbo_responsable.DisplayMember = "Descripcion";
            cbo_responsable.ValueMember = "Codigo";
            cbo_responsable.SelectedItem = null;

            //carga combo estado
            cbo_estado.DataSource = AccesoLogica.listar_combo_filtro(formulario, "Estado", estado, anio, usuario, perfil, tipo);
            cbo_estado.DisplayMember = "Descripcion";
            cbo_estado.ValueMember = "Codigo";
            cbo_estado.SelectedItem = null;

            //carga combo fech creacion
            cbo_fecha_crea.DataSource = AccesoLogica.listar_combo_filtro(formulario, "fec_crea", estado, anio, usuario, perfil, tipo);
            cbo_fecha_crea.DisplayMember = "Descripcion";
            cbo_fecha_crea.ValueMember = "Codigo";
            cbo_fecha_crea.SelectedItem = null;

            //carga combo fecha requerida
            cbo_fecha_requerida.DataSource = AccesoLogica.listar_combo_filtro(formulario, "fec_req", estado, anio, usuario, perfil, tipo);
            cbo_fecha_requerida.DisplayMember = "Descripcion";
            cbo_fecha_requerida.ValueMember = "Codigo";
            cbo_fecha_requerida.SelectedItem = null;

        }

        
       
       
        #endregion
        
        #region Botones

       

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Funciones

        void limpiar()
        {
            cbo_requerimiento.SelectedItem = null;
            cbo_ot.SelectedItem = null;
            cbo_responsable.SelectedItem = null;
            cbo_fecha_crea.SelectedItem = null;
            cbo_fecha_requerida.SelectedItem = null;
            cbo_estado.SelectedItem = null;
            cbo_solicitante.SelectedItem = null;

            txt_requerimiento.Clear();
            txt_solicitante.Clear();
            txt_ot.Clear();
            txt_responsable.Clear();
            txt_estado.Clear();
            txt_fecha_crea.Clear();
            txt_fecha_req.Clear();
        }

        #endregion 

        #region Formulario

        public FrmFiltro()
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

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn_filtro_Click(object sender, EventArgs e)
        {
            IForm_filtro formulario_filtro = this.Owner as IForm_filtro;

           


            if (formulario_filtro != null)
                formulario_filtro.pasar_valores_filtro
                (
                txt_requerimiento.Text,
                txt_solicitante.Text,
               txt_ot.Text,
                txt_responsable.Text,
               txt_estado.Text,
               txt_fecha_crea.Text,
               txt_fecha_req.Text,
                usuario,
                perfil,
                tipo,
                anio
                );
        }

        private void cbo_requerimiento_SelectionChangeCommitted(object sender, EventArgs e)
        {
           txt_requerimiento.Text = cbo_requerimiento.SelectedValue.ToString();
        }

        private void cbo_solicitante_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_solicitante.Text = cbo_solicitante.SelectedValue.ToString();
        }

        private void cbo_ot_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_ot.Text = cbo_ot.SelectedValue.ToString();
        }

        private void cbo_responsable_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_responsable.Text = cbo_responsable.SelectedValue.ToString();
        }

        private void cbo_estado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_estado.Text = cbo_estado.SelectedValue.ToString();
        }

        private void cbo_fecha_crea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_fecha_crea.Text = cbo_fecha_crea.SelectedValue.ToString();
        }

        private void cbo_fecha_requerida_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_fecha_req.Text = cbo_fecha_requerida.SelectedValue.ToString();
        }


             
    }
}
