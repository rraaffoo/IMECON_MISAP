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

namespace MISAP
{
    public partial class FrmlstPed : Form
    {
        #region Variables globales

        public string usuario, perfil;

        #endregion

        #region Variables locales

        private Point pos = Point.Empty;
        private bool move = false;
        bool allowSelect = false;

        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();

        string filtro;
        int posicion, columna, pedido;

        int cant_col, ColumnaId, id, ni;
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

        private void cbo_responsable_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Descripcion");
        }

        private void cbo_anio_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {

        }

        #endregion

        #region Formulario externo


        #endregion

        #region Formulario

        public FrmlstPed()
        {
            InitializeComponent();
            ts_acciones.Renderer = new MyRenderer();
        }

        private void titulo_MouseDown(object sender, MouseEventArgs e)
        {
            pos = new Point(e.X, e.Y);
            move = true;
        }

        #endregion

        #region Funciones

        void ocultar_mostrar_columnas(DataGridView grilla, int[] col, bool[] flag)
        {
            for (int i = 0; i < col.Length; i++)
            {
                grilla.Columns[col[i]].Visible = flag[i];
            }
        }



        void formatear_grilla(DataGridView grilla)
        {

            try
            {
                util.FormatearGrilla(grilla, false);

                if (grilla == dgv_costos)
                {
                    //dgv_pedidos.Columns["cdg_origen"].Visible = false;
                    //dgv_pedidos.Columns["U_CL_CODSOL"].Visible = false;
                    //dgv_pedidos.Columns["U_CL_SOLICI"].Visible = false;
                    //lbl_contador_registros.Visible = true;
                    //lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_costos.Rows.Count);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Fabricación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        #endregion



        public string tipo = "";
        public string ot = "";

        private void ts_acciones_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgv_costos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmlstPed_Load(object sender, EventArgs e)
        {
            txttipo.Text = tipo;
            string tm = "";

            switch (tipo)
            {
                case "MATERIALES": tm = "M"; break;
                case "SERVICIOS": tm = "S"; break;
                case "ACTIVOS FIJOS": tm = "A"; break;
            }
            dgv_costos.DataSource = AccesoLogica.listar_costos2(tm, ot, "", "", "1", "1");
            formatear_grilla(dgv_costos);
        }

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {

            if (dgv_costos.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para exportar", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            util.ExportarDataGridViewExcel(dgv_costos, tsl_titulo.Text);
        }
    }
}
