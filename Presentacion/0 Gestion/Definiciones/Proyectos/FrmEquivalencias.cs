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
using SAPbobsCOM;
using System.Configuration;
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;

namespace MISAP
{
    public partial class FrmEquivalencias : Form
    {
      


        #region Variables globales

        public string usuario, perfil;

        #endregion

        #region Variables locales

        private Point pos = Point.Empty;
        private bool move = false;
        bool allowSelect = false;
        bool Ejecucion = false;

        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();
        FrmEspera espera = new FrmEspera();

        string filtro, num_ped, cdg_prod, cdg_eqv, num_ord, usr_crea, fec_crea, swt_est, obs_item, Proyecto,
            usract, tipact, fecact, horact, anio, cdgemp, textbody, msg,responsable,estado, ItemDescription, UM, IP; 
        int columna, posicion, contador, line_sap, DocEntry;
        decimal can_ped, can_desp, can_ing, fac_eqv, can_cmp, can_ocom, swt_apr, swt_rev, web_num, cja_chk;

        private Documents documento;
        private StockTransfer documentos;

        #endregion

        #region Formulario

        public FrmEquivalencias()
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
                this.SetBounds(this.Location.X, this.Location.Y,747, 516);
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
                this.SetBounds(this.Location.X, this.Location.Y, 747, 516);
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
            if (e.Index < 0)
                return;

            ComboBox combo = sender as ComboBox;

            // DataRowView drv = ((DataRowView)(combo.Items[e.Index]));
            //   string name = drv[display].ToString();


            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(252, 220, 130)), e.Bounds);
            else
                e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);

            e.Graphics.DrawString(combo.Items[e.Index].ToString(), e.Font, new SolidBrush(combo.ForeColor), new System.Drawing.Point(e.Bounds.X, e.Bounds.Y));


            e.DrawFocusRectangle();
        }

        #endregion

        #region Eventos

        private void FrmEquivalencias_Load(object sender, EventArgs e)
        {
            this.Activate();

            //valida_permisos(perfil);
            
            util.FormatearFormulario(this, ts_acciones, tc_anexo, ss_load, txt_buscar, tp_listado, tp_nuevo, tp_auditoria);
            this.Location = new System.Drawing.Point(320, 80);
           
        
            dgv_ot.DataSource = AccesoLogica.listar_equivalencia();
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

        private void tc_usuario_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!allowSelect) e.Cancel = true;
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {

            (dgv_ot.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" + " ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
            lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_ot.Rows.Count);

        }

        private void dgv_anexo_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar.Focus();
            txt_buscar.Clear();

            filtro = dgv_ot.Columns[e.ColumnIndex].HeaderText;
            lbl_buscar.Text = "Buscar en " + filtro;

            dgv_ot.CurrentCell = dgv_ot.Rows[0].Cells[e.ColumnIndex];

        }

        #endregion
        
        #region Funciones

        void activar_boton(
            bool nuevo,
            bool editar,
            bool consultar,
            bool eliminar,
            bool imprimir,
            bool primero,
            bool anterior,
            bool siguiente,
            bool ultimo,
            bool previsualizar,
            bool exportar_xls,
            bool plantilla,
            bool aprobar,
            bool desaprobar,
            bool actualizar,
            bool filtro,
            bool ayuda,
            bool grabar,
            bool cancelar)
        {
            btn_nuevo_b.Enabled = nuevo;
            btn_editar_b.Enabled = editar;
            btn_consultar_b.Enabled = consultar;
            btn_eliminar_b.Enabled = eliminar;
            btn_imprimir.Enabled = imprimir;
            btn_primero.Enabled = primero;
            btn_anterior.Enabled = anterior;
            btn_siguiente.Enabled = siguiente;
            btn_utlimo.Enabled = ultimo;
            btn_previsualizar.Enabled = previsualizar;
            btn_exportar_xls.Enabled = exportar_xls;
            btn_plantilla.Enabled = plantilla;
            btn_aprobar.Enabled = aprobar;
            btn_desaprobar.Enabled = desaprobar;
            btn_actualizar.Enabled = actualizar;
            btn_filtro.Enabled = filtro;
            btn_grabar.Enabled = grabar;
            btn_cancelar.Enabled = cancelar;

        }
        void activar_campos(bool cdg_usr, bool dni, bool des_usr, bool correo, bool perfil, bool swt_usr)
        {


        }
        void limpiar()
        {
            txt_buscar.Clear();

            txt_estado_registro.Clear();
            txt_fec_crea.Clear();
            txt_formulario.Clear();

            txt_operacion.Clear();
            txt_terminal_crea.Clear();
            txt_usr_crea.Clear();

           
            txt_obs.Clear();
          
            
            txt_celular.Clear();

          
            cbo_tipo.SelectedIndex = -1;
            cbo_sucursal.SelectedIndex = -1;

       

            cbo_tipo.Enabled = false;
            cbo_sucursal.Enabled = false;

        

         
            txt_obs.ReadOnly = true;

        }
        void formatear_grilla(DataGridView grilla)
        {

            try
            {

                //dgv_usuarios.Columns["swt_usr"].Visible = false;
                //dgv_usuarios.Columns["cdg_perf"].Visible = false;
                //dgv_usuarios.Columns["psw_usr"].Visible = false;

                util.FormatearGrilla(grilla, true);

                if (grilla == dgv_ot)
                {
                    //grilla.Columns["cdg_origen"].Visible = false;
                    //grilla.Columns["U_CL_CODSOL"].Visible = false;
                    //grilla.Columns["U_CL_SOLICI"].Visible = false;
                    lbl_contador_registros.Visible = true;
                    lbl_contador_registros.Text = string.Format("Total de registros: {0}", grilla.Rows.Count);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Fabricación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        void valida_permisos(string perfil)
        {
            if (perfil == "001")
            {
                activar_boton(true, true, true, true, true, false, false, false, false, true, true, true, false, false, true, true, true, true, true);
            }
            if (perfil == "007")
            {
                activar_boton(true, true, true, true, true, false, false, false, false, true, true, false, false, false, true, true, true, true, true);
            }
            if (perfil == "008")
            {
                activar_boton(true, true, true, true, true, false, false, false, false, true, true, false, false, false, true, true, true, true, true);
            }

        }

        void insertar_auditoria(string operacion, string formulario, string tipo_doc, string nro_doc)
        {
         

        }
        #endregion

        #region Botones

        private void btn_nuevo_b_Click(object sender, EventArgs e)
        {
           
        
        }

    
        private void btn_grabar_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            valida_permisos(perfil);

        }

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
            if (dgv_ot.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para exportar", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            util.ExportarDataGridViewExcel(dgv_ot, tsl_titulo.Text);
                 
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
        


        }

        private void btn_consultar_b_Click(object sender, EventArgs e)
        {
          
         


        }

        private void btn_aprobar_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_desaprobar_Click(object sender, EventArgs e)
        {
           

        }

        private void btn_previsualizar_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_eliminar_b_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
          
          
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion = posicion - 1;
            }


            dgv_ot.CurrentCell = dgv_ot.Rows[posicion].Cells[1];

           // cdg_origen.Text = Convert.ToString(dgv_anexo.CurrentRow.Cells["cdg_origen"].Value);
          
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            posicion = 0;

            dgv_ot.CurrentCell = dgv_ot.Rows[posicion].Cells[1];

           // cdg_origen.Text = Convert.ToString(dgv_anexo.CurrentRow.Cells["cdg_origen"].Value);
          

        }

        private void btn_utlimo_Click(object sender, EventArgs e)
        {
            posicion = dgv_ot.Rows.Count - 1;

            dgv_ot.CurrentCell = dgv_ot.Rows[posicion].Cells[1];

           // cdg_origen.Text = Convert.ToString(dgv_anexo.CurrentRow.Cells["cdg_origen"].Value);
           

        }

        private void btn_filtro_Click(object sender, EventArgs e)
        {
            if (dgv_ot.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para filtrar", "Filtrar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }


            FrmFiltro filtro = new FrmFiltro();
            filtro.anio = anio;
            filtro.perfil = perfil;
            filtro.usuario = usuario;
            filtro.estado = "";
            filtro.formulario = "FrmPedidos";
            filtro.ShowDialog(this);
        }

        private void btn_editar_b_Click(object sender, EventArgs e)
        {
           

        }

        #endregion

        #region Menu contextual

        private void cm_grilla_copia_Click(object sender, EventArgs e)
        {
            util.copiar_contextual(dgv_ot);
        }

        private void cm_grilla_copia_tabla_Click(object sender, EventArgs e)
        {
            util.copiar_todo_encabezados(dgv_ot);
        }

        private void logDeModificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        #endregion




    }
}
