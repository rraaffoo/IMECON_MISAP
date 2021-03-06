﻿using System;
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
using System.Runtime.InteropServices;
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace MISAP
{
    public partial class FrmEstadoOT : Form
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

        public FrmEstadoOT()
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
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); 
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
                util.FormatearGrilla(grilla, true);

                if (grilla == dgv_ot)
                {
                    //dgv_pedidos.Columns["cdg_origen"].Visible = false;
                    //dgv_pedidos.Columns["U_CL_CODSOL"].Visible = false;
                    //dgv_pedidos.Columns["U_CL_SOLICI"].Visible = false;
                    lbl_contador_registros.Visible = true;
                    lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_ot.Rows.Count);
                    
                    grilla.Columns["PESO EN KGS"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    grilla.Columns["PESO EN KGS"].DefaultCellStyle.Format = "###,##0.00";

                    grilla.Columns["MONTO CONTRATO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    grilla.Columns["MONTO CONTRATO"].DefaultCellStyle.Format = "###,##0.00";

                    if (perfil == "001")
                    {

                        grilla.Columns["Monto OC US$"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        grilla.Columns["Monto OC Soles"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        grilla.Columns["Monto OS US$"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        grilla.Columns["Monto OS Soles"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        
                        grilla.Columns["Monto OC US$"].DefaultCellStyle.Format = "###,##0.00";
                        grilla.Columns["Monto OC US$"].DefaultCellStyle.Format = "###,##0.00";
                        grilla.Columns["Monto OC Soles"].DefaultCellStyle.Format = "###,##0.00";
                        grilla.Columns["Monto OS US$"].DefaultCellStyle.Format = "###,##0.00";
                        grilla.Columns["Monto OS Soles"].DefaultCellStyle.Format = "###,##0.00";
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Fabricación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        #endregion

        private void FrmSeguimientoSaldos_Load(object sender, EventArgs e)
        {
            util.FormatearFormulario(this, ts_acciones, tc_pedido, ss_load, txt_buscar, tp_listado, tp_nuevo, tp_auditoria);
            this.Location = new System.Drawing.Point(320, 80);

            //cbo_OT.DataSource = AccesoLogica.consultar_estado_ot("", "Listar");
            //cbo_OT.DisplayMember = "Descripcion";
            //cbo_OT.ValueMember = "Codigo";
            //cbo_OT.SelectedItem = null;
            //cbo_OT.Focus();


            dgv_ot.DataSource = AccesoLogica.consultar_estado_ot(perfil,"");
            formatear_grilla(dgv_ot);
         

        

            if (dgv_ot.Rows.Count != 0)
            {
                posicion = 0;
                txt_buscar.Enabled = true;
                filtro = dgv_ot.Columns[1].HeaderText;

                dgv_ot.CurrentCell = dgv_ot.Rows[0].Cells[1];
                columna = dgv_ot.CurrentCell.ColumnIndex;
            }
        }

        private void cbo_OT_SelectionChangeCommitted(object sender, EventArgs e)
        {


            dgv_ot.DataSource = AccesoLogica.listar_saldo_seguimiento(cbo_OT.SelectedValue.ToString());
            formatear_grilla(dgv_ot);
         
        }

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
            if (dgv_ot.Rows.Count == 0)
            {
                util.mensaje("No Existe Informacion para exportar", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
               return;
            }
            util.ExportarDataGridViewExcel(dgv_ot, tsl_titulo.Text);
        }

        private void t_msg_Tick(object sender, EventArgs e)
        {
            lbl_msg.Text = string.Empty;
            ss_load.BackColor = Color.Transparent;
            lbl_contador_registros.Visible = true;
            lbl_msg.Visible = false;
        }

        private void ss_load_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {

            (dgv_ot.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" + " ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
            lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_ot.Rows.Count);
        }

        private void dgv_ot_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar.Focus();
            txt_buscar.Clear();

            filtro = dgv_ot.Columns[e.ColumnIndex].HeaderText;
            lbl_buscar.Text = "Buscar en " + filtro;

            dgv_ot.CurrentCell = dgv_ot.Rows[0].Cells[e.ColumnIndex];
        }


    }
}
