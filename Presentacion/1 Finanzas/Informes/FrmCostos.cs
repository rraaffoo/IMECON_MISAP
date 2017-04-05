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
    public partial class FrmCostos : Form
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

        public FrmCostos()
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
                this.SetBounds(this.Location.X, this.Location.Y, 858, 595);
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
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
                this.SetBounds(this.Location.X, this.Location.Y, 858, 595);
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
                    lbl_contador_registros.Visible = true;
                    lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_costos.Rows.Count);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Fabricación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        #endregion

       public string tipo="";
       public string ot = "";

        private void FrmCostos_Load(object sender, EventArgs e)
        {
            util.FormatearFormulario(this, ts_acciones, tc_pedido, ss_load, txt_buscar, tp_listado, tp_nuevo, tp_auditoria);
            this.Location = new System.Drawing.Point(220, 80);

            cbo_OT.DataSource = AccesoLogica.listar_ot_sap_2("", "Listar");
            cbo_OT.DisplayMember = "Descripcion";
            cbo_OT.ValueMember = "Codigo";
            cbo_OT.SelectedItem = null;
            cbo_OT.Focus();


            dgv_costos.DataSource = AccesoLogica.listar_costos("M", "", "", "","1");
            formatear_grilla(dgv_costos);
         

            if (dgv_costos.Rows.Count != 0)
            {
                posicion = 0;
                txt_buscar.Enabled = true;
                filtro = dgv_costos.Columns[1].HeaderText;

                dgv_costos.CurrentCell = dgv_costos.Rows[0].Cells[1];
                columna = dgv_costos.CurrentCell.ColumnIndex;
            }

            dp_fec_crea_fin.Text = "";
            dp_fec_crea_ini.Text = "";
        }

        private void cbo_OT_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_ot.Text = cbo_OT.SelectedValue.ToString();

            dgv_costos.DataSource = AccesoLogica.listar_costos("M", txt_ot.Text, "", "", "1");
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

        private void dp_fec_crea_ini_ValueChanged(object sender, EventArgs e)
        {
            txt_fecha_ini.Text = dp_fec_crea_ini.Text;

        }

        private void dp_fec_crea_fin_ValueChanged(object sender, EventArgs e)
        {
            txt_fecha_fin.Text = dp_fec_crea_fin.Text;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string fechaini = txt_fecha_ini.Text;
            string fechafin = txt_fecha_fin.Text;
            string ot = txt_ot.Text;
            string mat = "M";
            string tip = "1";
            btn_ok.Enabled = false;
            cbo_OT.Enabled = false;

           // dgv_costos.DataSource = AccesoLogica.listar_costos("M", txt_ot.Text, "", "", "1");
            if (chk_fecha.Checked == true)
            {
                if (fechaini != "" && fechafin != "")
                {
                    tip = "";

                }
                else {
                    fechaini = "";
                    fechafin = "";
                }
 
            }

            dgv_costos.DataSource = AccesoLogica.listar_costos(mat, ot, fechaini, fechafin, tip);
            formatear_grilla(dgv_costos);
            btn_ok.Enabled = true;
            cbo_OT.Enabled = true;
        }

        private void chk_fecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_fecha.Checked == true)
            {
                lbl_ini.Visible = true;
                lbl_fin.Visible = true;
                dp_fec_crea_ini.Visible = true;
                dp_fec_crea_fin.Visible = true;
             //   btn_ok.Visible = true;
            }
            else
            {
                lbl_ini.Visible = false;
                lbl_fin.Visible = false;
                dp_fec_crea_ini.Visible = false;
                dp_fec_crea_fin.Visible = false;
               // btn_ok.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dgv_costos_CellDoubleClick(Object sender, DataGridViewCellEventArgs e) 
        {
            string tip = (string)dgv_costos.CurrentRow.Cells[0].Value;
            txttipo.Text = tip;
            if (tip != "")
            {
                FrmlstPed lstPed = new FrmlstPed();
                lstPed.tipo = txttipo.Text;
                lstPed.ot = txt_ot.Text;
                lstPed.Show(this);
            }
        }
        
        private void titulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ts_acciones_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cbo_OT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_costos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string tip = (string)dgv_costos.CurrentRow.Cells[0].Value;
            txttipo.Text = tip;
            if (tip != "")
            {
                FrmlstPed lstPed = new FrmlstPed();
                lstPed.tipo = txttipo.Text;
                lstPed.ot = txt_ot.Text;
                lstPed.Show(this);
            }
        }
    }
}
