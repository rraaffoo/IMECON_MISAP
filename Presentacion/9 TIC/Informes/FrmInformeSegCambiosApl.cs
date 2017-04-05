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
using System.Runtime.InteropServices;


namespace MISAP
{

    public partial class FrmInformeSegCambiosApl : Form, IForm_parametrizacion, IForm_Listado
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
        DataTable dt, dt1;
        DataTable dtReporte= new DataTable() ;

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

        public void pasar_valores(string par1, string par2, string par3, string par4, string par5, string par6)
        {
            try
            {
                    if (par5 == "Lista de Ordenes de trabajo")
                    {
                      

                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Orden de Producción", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

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

        public FrmInformeSegCambiosApl()
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
                    grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                                     
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

            util.FormatearFormulario_sap_informe(this, ts_acciones, tc_listado, ss_load, txt_buscar, tp_listado, tp_auditoria);
            this.Location = new System.Drawing.Point(320, 80);

            // dgv_parametrizacion.DataSource = AccesoLogica.listar_parametros_usuario(usuario, 8001);

            dt = AccesoLogica.informe_seguimiento_cambios_apl(0, "Consultar", "Listar");
            dgv_lista.DataSource = dt;
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

        void resaltarfilas()
        {
            foreach (DataGridViewRow row in dgv_lista.Rows)
            {


                if (row.Cells["Estado"].Value.ToString() == "OBSERVADO")
                {
                   // row.Cells["Estado"].Style.BackColor = Color.Red;
                    row.Cells["Estado"].Style.ForeColor = Color.Red;
                    //row.DefaultCellStyle.ForeColor = Color.Red;

                }


            }
        }

        /// <summary>
        /// /////////////////////////////////////////////////////////////////////
        /// </summary>
        private void cargar_combo_anio()
        {
            int anio_actual = System.DateTime.Now.Year;
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");
            DataRow dr;
            
            dr = dt.NewRow();
            dr["Codigo"] = "0";
            dr["Descripcion"] = "[ Todos ]";
            dt.Rows.Add(dr);

            for (int i = 2013; i <= anio_actual; i++)
            {
                dr = dt.NewRow();
                dr["Codigo"] = i.ToString();
                dr["Descripcion"] = i.ToString();
                dt.Rows.Add(dr);
            }

            cboAnio.DataSource = dt;
            cboAnio.ValueMember = "Codigo";
            cboAnio.DisplayMember = "Descripcion";
            cboAnio.SelectedIndex = 0;

        }

        private void cargar_combo_mes()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");
            DataRow dr;

            dr = dt.NewRow();
            dr["Codigo"] = "0";
            dr["Descripcion"] = "[ Todos ]";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "1";
            dr["Descripcion"] = "Enero";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "2";
            dr["Descripcion"] = "Febrero";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "3";
            dr["Descripcion"] = "Marzo";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "4";
            dr["Descripcion"] = "Abril";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "5";
            dr["Descripcion"] = "Mayo";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "6";
            dr["Descripcion"] = "Junio";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "7";
            dr["Descripcion"] = "Julio";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "8";
            dr["Descripcion"] = "Agosto";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "9";
            dr["Descripcion"] = "Setiembre";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "10";
            dr["Descripcion"] = "Octubre";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "11";
            dr["Descripcion"] = "Noviembre";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "12";
            dr["Descripcion"] = "Diciembre";
            dt.Rows.Add(dr);

            cboMes.DataSource = dt;
            cboMes.ValueMember = "Codigo";
            cboMes.DisplayMember = "Descripcion";
        }

        private void FiltrarRegistros()
        {
            dt1 = dt;

            //Construcción de la cadena de Filtro
            string cadena = "";
            if (cboAnio.SelectedValue.ToString() != "0")
                cadena = ((cadena != "") ? (cadena + "and ") : "") + "Convert([anio],'System.String') LIKE '%" + cboAnio.SelectedValue.ToString() + "%'";
            if (cboMes.SelectedValue.ToString() != "0")
                cadena = ((cadena != "") ? (cadena + "and ") : "") + "Convert([mes],'System.String') LIKE '%" + cboMes.SelectedValue.ToString() + "%'";
            DataView dv = new DataView(dt);
            dv.RowFilter = cadena;

            dt1 = dv.ToTable();
            dtReporte = dt1.Copy();

            dgv_lista.DataSource = null;
            dgv_lista.DataSource = dt1;
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

            dgv_lista.DataSource = null;
            dgv_lista.DataSource = AccesoLogica.informe_seguimiento_cambios_apl(0, "Consultar", "Listar");
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
            parametrizacion.grilla = "dgv_segapl";
            parametrizacion.GrillaId = 8001;
            parametrizacion.ShowDialog(this);
        }

        private void btn_filtro_Click(object sender, EventArgs e)
        {

        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "\\\\IMECON08\\Comun\\MISAP\\MANUALES\\GUIA RAPIDA SEGUIMIENTO DE ACEROS.pdf";
            proc.Start();
            proc.Close();
        }

        #endregion

        #region Eventos

        private void FrmInformeSegReq_Load(object sender, EventArgs e)
        {
            cargar_combo_anio();
            cargar_combo_mes();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            (dgv_lista.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" +" ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
            formatear_grilla(dgv_lista);

        }

        private void dgv_pedidos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar.Focus();
            txt_buscar.Clear();

            filtro = dgv_lista.Columns[e.ColumnIndex].HeaderText;
            lbl_buscar.Text = "Buscar en " + filtro;

            dgv_lista.CurrentCell = dgv_lista.Rows[0].Cells[e.ColumnIndex];
            
        }

        private void dgv_lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmContratos contrato = new FrmContratos();
            contrato.usuario = usuario;
            contrato.perfil = perfil;
            contrato.idreg_ = Convert.ToInt32(dgv_lista.CurrentRow.Cells["#"].Value);
            contrato.operacion_ = "Consultar";
            contrato.Show();
      


        }

        private void cboAnio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FiltrarRegistros();
        }

        private void cboMes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FiltrarRegistros();
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

            FrmContratos contrato = new FrmContratos();
            contrato.usuario = usuario;
            contrato.perfil = perfil;
            contrato.idreg_ = Convert.ToInt32(dgv_lista.CurrentRow.Cells["#"].Value);
            contrato.operacion_ = "Consultar";
            contrato.Show();

        }

        private void ss_load_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_previsualizar_Click(object sender, EventArgs e)
        {
            if (cboAnio.SelectedValue.ToString()=="0" || cboMes.SelectedValue.ToString()=="0")
            {
                util.mensaje("Debe seleccionar año y mes", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
            try
            {
                //DataSet ds = new DataSet();
                //ds.Tables.Add(dtReporte);
                //ds.WriteXmlSchema("C:\\tmp\\RptInformeSegCambios.xml");

                rptInformeSegcambios Rpt = new rptInformeSegcambios();
                Rpt.Refresh();
                Rpt.SetDataSource(dtReporte);
                CrvReporte form = new CrvReporte((Object)Rpt);
                //form.Text = "Vista previa - ";
                form.ShowDialog();
                Rpt.Dispose();
            }
            catch (Exception Ex)
            {
                util.mensaje("Error: "+Ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
            }
        }

        private void t_msg_Tick(object sender, EventArgs e)
        {
            lbl_msg.Text = string.Empty;
            ss_load.BackColor = Color.Transparent;
            lbl_contador_registros.Visible = true;
            lbl_msg.Visible = false;
        }

        

       

        //private void cm_log_modificaciones_Click(object sender, EventArgs e)
        //{
        //    FrmLogModificaciones log = new FrmLogModificaciones();
        //    log.requerimiento = Convert.ToString(dgv_lista.CurrentRow.Cells["Requerimiento"].Value);
        //    log.ShowDialog(this);
        //}

        #endregion

               
    }
}
