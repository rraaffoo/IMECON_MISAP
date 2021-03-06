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


namespace MISAP
{

    public partial class FrmInformeSegAcerosDet : Form, IForm_parametrizacion
    {
        
        #region Variables globales

        public string usuario, perfil, ot;


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

        private void cbo_PrcCode_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Codigo");
        }

        //private void cbo_anio_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        //{

        //}

        #endregion

        #region Formulario externo

        public void pasar_valores_parametrizacion(int[] par1, bool[] par2)
        {
            try
            {

                ocultar_mostrar_columnas(dgv_lista, par1, par2);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Orden de Producción", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }
        #endregion

        #region Formulario

        public FrmInformeSegAcerosDet()
        {
            InitializeComponent();
            ts_acciones.Renderer = new MyRenderer();
            inicializar();

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
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); 
        }

        #endregion

        #region Funciones

        void ocultar_mostrar_columnas(DataGridView grilla, int[] col, bool[] flag)
        {
            for (int i = 0; i < col.Length ; i++)
            {
                grilla.Columns[col[i]].Visible = flag[i];
            }
        }

        void cargar_parametrizacion(DataGridView grilla)
        {
            int i = 0;
            int x = 0;
            foreach (DataGridViewRow row in dgv_parametrizacion.Rows)
            {

                cant_col++;

            }

            vec_col = new int[cant_col];
            vec_falg = new bool[cant_col];

            foreach (DataGridViewRow row in dgv_parametrizacion.Rows)
            {

                vec_col[i] = Convert.ToInt32(row.Cells["ColumnaId"].Value);
                vec_falg[x] = Convert.ToBoolean(row.Cells["Visible"].Value);

                i++;
                x++;             
            }

            ocultar_mostrar_columnas(grilla, vec_col, vec_falg);
        }

        void formatear_grilla(DataGridView grilla)
        {

            try
            {
                util.FormatearGrilla(grilla,false);

                if (grilla == dgv_lista)
                {
                    //dgv_pedidos.Columns["cdg_origen"].Visible = false;
                    //dgv_pedidos.Columns["U_CL_CODSOL"].Visible = false;
                    //dgv_pedidos.Columns["U_CL_SOLICI"].Visible = false;
                    lbl_contador_registros.Visible = true;
                    lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_lista.Rows.Count);
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Fabricación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        void inicializar()
        {

            util.FormatearFormulario(this, ts_acciones, tc_pedido, ss_load, txt_buscar, tp_listado, tp_nuevo, tp_auditoria);
            this.Location = new System.Drawing.Point(320, 80);

            // dgv_parametrizacion.DataSource = AccesoLogica.listar_parametros_usuario(usuario, 8001);


          
            formatear_grilla(dgv_lista);
            cargar_parametrizacion(dgv_lista);

            if (dgv_lista.Rows.Count != 0)
            {
                posicion = 0;
                txt_buscar.Enabled = true;
                filtro = dgv_lista.Columns[1].HeaderText;

                dgv_lista.CurrentCell = dgv_lista.Rows[0].Cells[1];
                columna = dgv_lista.CurrentCell.ColumnIndex;
            }

            
          
        }


        #endregion

        #region Botones

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
            if (dgv_lista.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para exportar", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            util.ExportarDataGridViewExcel(dgv_lista, tsl_titulo.Text);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar.Focus();
            txt_buscar.Clear();

            dgv_lista.DataSource = AccesoLogica.informe_seguimiento_aceros("Detallado", ot);
            formatear_grilla(dgv_lista);

            if (dgv_lista.Rows.Count != 0)
            {
                txt_buscar.Enabled = true;
                filtro = dgv_lista.Columns[0].HeaderText;

                dgv_lista.CurrentCell = dgv_lista.Rows[0].Cells[0];
                columna = dgv_lista.CurrentCell.ColumnIndex;
            }

            
           // chk_aceros.Checked = false;
        }

        private void btn_parametrizacion_Click(object sender, EventArgs e)
        {
            FrmParametrizacion parametrizacion = new FrmParametrizacion();
            parametrizacion.formulario = "FrmInformeSegReq";
            parametrizacion.usuario = usuario;
            parametrizacion.grilla = "dgv_pedidos";
            parametrizacion.GrillaId = 8001;
            parametrizacion.ShowDialog(this);
        }

        #endregion

        #region Eventos

        private void FrmInformeSegReq_Load(object sender, EventArgs e)
        {
            dgv_lista.DataSource = AccesoLogica.informe_seguimiento_aceros_det("SOLICITADO", ot);
            formatear_grilla(dgv_lista);
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            (dgv_lista.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" +" ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
       
        }

        private void tc_pedido_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!allowSelect) e.Cancel = true;
        }

        private void dgv_pedidos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar.Enabled = true;
            txt_buscar.Focus();
            txt_buscar.Clear();

            filtro = dgv_lista.Columns[e.ColumnIndex].HeaderText;
            lbl_buscar.Text = "Buscar en " + filtro;

            dgv_lista.CurrentCell = dgv_lista.Rows[0].Cells[e.ColumnIndex];
            
        }

            
        #endregion

        #region Menu contextual

        private void cm_grilla_copia_Click(object sender, EventArgs e)
        {
            util.copiar_contextual(dgv_lista);
        }

        private void cm_grilla_copia_tabla_Click(object sender, EventArgs e)
        {
            util.copiar_todo_encabezados(dgv_lista);
        }

    

        private void tsm_detalle_Click(object sender, EventArgs e)
        {
            if (dgv_lista.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para mostrar", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

        }

    

        private void btn_filtro_Click(object sender, EventArgs e)
        {

        }

        private void rb_PorIngresar_CheckedChanged(object sender, EventArgs e)
        {
            dgv_lista.DataSource = null;
            dgv_lista.DataSource = AccesoLogica.informe_seguimiento_aceros_det(rb_PorIngresar.Text, ot);
            formatear_grilla(dgv_lista);
        }

        private void rb_Ingresado_CheckedChanged(object sender, EventArgs e)
        {
            dgv_lista.DataSource = null;
            dgv_lista.DataSource = AccesoLogica.informe_seguimiento_aceros_det(rb_Ingresado.Text, ot);
            formatear_grilla(dgv_lista);
        }

        private void rb_Consumido_CheckedChanged(object sender, EventArgs e)
        {
            dgv_lista.DataSource = null;
            dgv_lista.DataSource = AccesoLogica.informe_seguimiento_aceros_det(rb_Consumido.Text, ot);
            formatear_grilla(dgv_lista);
        }

        private void rb_solicitado_CheckedChanged(object sender, EventArgs e)
        {
            dgv_lista.DataSource = null;
            dgv_lista.DataSource = AccesoLogica.informe_seguimiento_aceros_det(rb_solicitado.Text, ot);
            formatear_grilla(dgv_lista);
        }

        private void rb_transferido_CheckedChanged(object sender, EventArgs e)
        {
            dgv_lista.DataSource = null;
            dgv_lista.DataSource = AccesoLogica.informe_seguimiento_aceros_det(rb_transferido.Text, ot);
            formatear_grilla(dgv_lista);
        }

        private void rb_devuelto_CheckedChanged(object sender, EventArgs e)
        {
            dgv_lista.DataSource = null;
            dgv_lista.DataSource = AccesoLogica.informe_seguimiento_aceros_det(rb_devuelto.Text, ot);
            formatear_grilla(dgv_lista);
        }
                //private void cm_log_modificaciones_Click(object sender, EventArgs e)
        //{
        //    FrmLogModificaciones log = new FrmLogModificaciones();
        //    log.requerimiento = Convert.ToString(dgv_lista.CurrentRow.Cells["Requerimiento"].Value);
        //    log.ShowDialog(this);
        //}
        #endregion

        //private void chk_aceros_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chk_aceros.Checked == true)
        //    {
        //        (dgv_lista.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[Cod. Partida]" + " ,'System.String') LIKE '%{0}%'", "123");
        //        lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_lista.Rows.Count);
        //    }
        //    else
        //    {
        //        dgv_lista.DataSource = AccesoLogica.listar_requemiento_seguimiento("Materiales");
        //        formatear_grilla(dgv_lista);

        //        if (dgv_lista.Rows.Count != 0)
        //        {
        //            posicion = 0;
        //            txt_buscar.Enabled = true;
        //            filtro = dgv_lista.Columns[1].HeaderText;

        //            dgv_lista.CurrentCell = dgv_lista.Rows[0].Cells[1];
        //            columna = dgv_lista.CurrentCell.ColumnIndex;
        //        }
        //    }

        //}
               
    }
}
