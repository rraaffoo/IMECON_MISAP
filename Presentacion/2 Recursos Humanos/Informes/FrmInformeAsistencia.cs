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

    public partial class FrmInformeAsistencia : Form, IForm_parametrizacion, IForm_Listado
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

        string filtro="";
        int posicion, columna, pedido;
        
        int cant_col, ColumnaId, id, ni;
        int[] vector, vec_col;
        bool[] vec_falg;
        bool visible_;

        DateTime dtini;
        DateTime dtfin;
        string fechaDesde="";
        string fechaHasta="";
        DataTable dtPersonal;
        DataTable dtAsistencia;
        DataTable dtPresentacion;
        DataTable dtMarcaciones;
        List<string> lstAsistencia = new List<string>();

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

                ocultar_mostrar_columnas(dgvLista, par1, par2);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Orden de Producción", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }
        
        #endregion

        #region Formulario

        public FrmInformeAsistencia()
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

        //void cargar_parametrizacion(DataGridView grilla)
        //{
        //    int i = 0;
        //    int x = 0;
        //    foreach (DataGridViewRow row in dgv_parametrizacion.Rows)
        //    {

        //        cant_col++;

        //    }

        //    vec_col = new int[cant_col];
        //    vec_falg = new bool[cant_col];

        //    foreach (DataGridViewRow row in dgv_parametrizacion.Rows)
        //    {

        //        vec_col[i] = Convert.ToInt32(row.Cells["ColumnaId"].Value);
        //        vec_falg[x] = Convert.ToBoolean(row.Cells["Visible"].Value);

        //        i++;
        //        x++;             
        //    }

        //    ocultar_mostrar_columnas(grilla, vec_col, vec_falg);
        //}

        void formatear_grilla(DataGridView grilla)
        {

            try
            {
                util.FormatearGrilla(grilla,true);

                if (grilla == dgvLista)
                {
                    grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                                     
                    lbl_contador_registros.Visible = true;
                    lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgvLista.Rows.Count);
                
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
            //this.Location = new System.Drawing.Point(320, 80);

            //dgv_parametrizacion.DataSource = AccesoLogica.listar_parametros_usuario(usuario, 8001);


            //dgv_lista.DataSource = AccesoLogica.informe_seguimiento_contratos(0, "Consultar", "Listar");
            //formatear_grilla(dgv_lista);
            //cargar_parametrizacion(dgv_lista);

            if (dgvLista.Rows.Count != 0)
            {
                posicion = 0;
                txt_buscar.Enabled = true;
                filtro = dgvLista.Columns[1].HeaderText;

                dgvLista.CurrentCell = dgvLista.Rows[0].Cells[1];
                columna = dgvLista.CurrentCell.ColumnIndex;
            }
            else
            {
                txt_buscar.Text = "";
                txt_buscar.Enabled = true;
            }

            
        }

        void resaltarfilas()
        {
            foreach (DataGridViewRow row in dgvLista.Rows)
            {


                if (row.Cells["Estado"].Value.ToString() == "OBSERVADO")
                {
                   // row.Cells["Estado"].Style.BackColor = Color.Red;
                    row.Cells["Estado"].Style.ForeColor = Color.Red;
                    //row.DefaultCellStyle.ForeColor = Color.Red;

                }


            }
        }

        #endregion

        #region Botones

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para exportar", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            util.exportarExcel(dgvLista);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
           // chk_aceros.Checked = false;
        }

        private void btn_parametrizacion_Click(object sender, EventArgs e)
        {
            //FrmParametrizacion parametrizacion = new FrmParametrizacion();
            //parametrizacion.formulario = "FrmInformeSegReq";
            //parametrizacion.usuario = usuario;
            //parametrizacion.grilla = "dgv_pedidos";
            //parametrizacion.GrillaId = 8001;
            //parametrizacion.ShowDialog(this);
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

        private void FrmInformeAsistencia_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Now;
            dtpFechaHasta.Value = DateTime.Now;
            //inicializar();
            //formatear_grilla(dgv_lista);
            //cargar_grilla_asistencia();
            
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            if (filtro != string.Empty && filtro != "")
            {
                (dgvLista.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" + " ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
                formatear_grilla(dgvLista);
            }
            
        }

        private void dgv_pedidos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            filtro = dgvLista.Columns[e.ColumnIndex].HeaderText;
            lbl_buscar.Text = "Buscar en " + filtro;

            dgvLista.CurrentCell = dgvLista.Rows[0].Cells[e.ColumnIndex];
            txt_buscar.Enabled = true;

            txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar.Focus();
            txt_buscar.Clear();
        }

        private void dgv_lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }
        #endregion

        #region Menu contextual

        private void cm_grilla_copia_Click(object sender, EventArgs e)
        {
            util.copiar_contextual(dgvLista);
        }

        private void cm_grilla_copia_tabla_Click(object sender, EventArgs e)
        {
            util.copiar_todo_encabezados(dgvLista);
        }

        

       

        //private void cm_log_modificaciones_Click(object sender, EventArgs e)
        //{
        //    FrmLogModificaciones log = new FrmLogModificaciones();
        //    log.requerimiento = Convert.ToString(dgv_lista.CurrentRow.Cells["Requerimiento"].Value);
        //    log.ShowDialog(this);
        //}

        #endregion

        private void cargar_grilla_asistencia()
        {
            dgvLista.DataSource = null;
            TimeSpan ts = dtpFechaHasta.Value - dtpFechaDesde.Value;
            int differenceInDays = ts.Days;
            if (differenceInDays >= 31)
            {
                util.mensaje("el rango de fechas no puede exceder de 31 dias", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
            if (differenceInDays < 0)
            {
                util.mensaje("el rango de fechas no es válido", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
            if (!BW.IsBusy)
            {
                util.mensaje_espera("Cargando, por favor espere", true, lbl_contador_registros, lbl_msg, ss_load, true);
                dgvLista.DataSource = null;
                txt_buscar.Enabled = false;
                txt_buscar.Text = "";
                fechaDesde = dtpFechaDesde.Value.ToShortDateString();
                fechaHasta = dtpFechaHasta.Value.ToShortDateString();
                BW.RunWorkerAsync();
            }

        }
        private void BW_DoWork(object sender, DoWorkEventArgs e)
        {
            dtPresentacion.Columns.Add("DNI");
            dtPresentacion.Columns.Add("NOMBRES");
            dtPresentacion.Columns.Add("AREA");
            dtPresentacion.Columns.Add("CARGO");
            dtPresentacion.Columns.Add("TIPTRAB");
            dtPresentacion.Columns.Add("OT");
            dtPresentacion.Columns.Add("dia_01");
            dtPresentacion.Columns.Add("dia_02");
            dtPresentacion.Columns.Add("dia_03");
            dtPresentacion.Columns.Add("dia_04");
            dtPresentacion.Columns.Add("dia_05");
            dtPresentacion.Columns.Add("dia_06");
            dtPresentacion.Columns.Add("dia_07");
            dtPresentacion.Columns.Add("dia_08");
            dtPresentacion.Columns.Add("dia_09");
            dtPresentacion.Columns.Add("dia_10");
            dtPresentacion.Columns.Add("dia_11");
            dtPresentacion.Columns.Add("dia_12");
            dtPresentacion.Columns.Add("dia_13");
            dtPresentacion.Columns.Add("dia_14");
            dtPresentacion.Columns.Add("dia_15");
            dtPresentacion.Columns.Add("dia_16");
            dtPresentacion.Columns.Add("dia_17");
            dtPresentacion.Columns.Add("dia_18");
            dtPresentacion.Columns.Add("dia_19");
            dtPresentacion.Columns.Add("dia_20");
            dtPresentacion.Columns.Add("dia_21");
            dtPresentacion.Columns.Add("dia_22");
            dtPresentacion.Columns.Add("dia_23");
            dtPresentacion.Columns.Add("dia_24");
            dtPresentacion.Columns.Add("dia_25");
            dtPresentacion.Columns.Add("dia_26");
            dtPresentacion.Columns.Add("dia_27");
            dtPresentacion.Columns.Add("dia_28");
            dtPresentacion.Columns.Add("dia_29");
            dtPresentacion.Columns.Add("dia_30");
            dtPresentacion.Columns.Add("dia_31");

            try
            {
                //int aa = Negocio.limpiar_tabla_asistencia();
                dtPersonal = Negocio.Cargar_personal();
                foreach (DataRow item in dtPersonal.Rows)
                {
                    DataRow dr;
                    dr = dtPresentacion.NewRow();
                    dr["DNI"] = item["dni"].ToString();
                    dr["NOMBRES"] = string.Concat(item["apepat"].ToString(), " ", item["apemat"].ToString(), ", ", item["nombre"].ToString());
                    dr["AREA"] = item["departamento"].ToString();
                    dr["CARGO"] = item["cargo"].ToString();
                    dr["TIPTRAB"] = item["tipotrab"].ToString();
                    dr["OT"] = item["ccosto"].ToString();

                    string diaN;
                    string _codigo = item["dni"].ToString();
                    //string _trabajador = string.Concat(item["apepat"].ToString(), " ", item["apemat"].ToString(), ", ", item["nombre"].ToString());
                    //string _area = item["departamento"].ToString();
                    //string _cargo = item["cargo"].ToString();
                    //string _tipotrab = item["tipotrab"].ToString();
                    //string _ot = item["ccosto"].ToString();
                    dtMarcaciones = Negocio.listar_marcaciones(fechaDesde, fechaHasta);
                    dtini = Convert.ToDateTime(fechaDesde);
                    dtfin = Convert.ToDateTime(fechaHasta);

                    int jj = 0;
                    for (DateTime j = dtini; j <= dtfin; j = j.AddDays(1))
                    {
                        try
                        {
                            diaN = string.Concat("dia_"+(jj+1).ToString().PadLeft(2,'0'));
                            //lstAsistencia.Add(Negocio.buscar_asistencia(_codigo, j.ToShortDateString()).Rows[0][0].ToString());
                            DataRow[] dr1= dtMarcaciones.Select("dni = '" + _codigo + "' and fecha = '" + j.ToShortDateString()+"'");
                            dr[diaN] = dr1[0]["marcacion"].ToString();
                            //dr[diaN] = Negocio.buscar_asistencia(_codigo, j.ToShortDateString()).Rows[0][0].ToString();
                        }
                        catch
                        {
                            diaN = string.Concat("dia_" + (jj + 1).ToString().PadLeft(2, '0'));
                            //lstAsistencia.Add(" - ");
                            dr[diaN] = " - ";
                        }
                        jj++;

                    }
                    for (int ii = jj + 1; ii <= 31; ii++)
                    {
                        //lstAsistencia.Add(" - ");
                        diaN = string.Concat("dia_" + (jj + 1).ToString().PadLeft(2, '0'));
                        dr[diaN] = " - ";
                    }
                    //int iii = Negocio.insertar_asistencia_rango(_codigo, _trabajador, _area, _cargo, _tipotrab, _ot, lstAsistencia);
                    dtPresentacion.Rows.Add(dr);
                    lstAsistencia.Clear();
                }
                //dtAsistencia = Negocio.Cargar_asistencia_rango();
                dtAsistencia = dtPresentacion;

                int nn = 1;
                for (DateTime j = dtini; j <= dtfin; j = j.AddDays(1))
                {
                    string dia = string.Concat("dia_" + nn.ToString().PadLeft(2, '0'));
                    dtAsistencia.Columns[dia].ColumnName = "["+ j.ToShortDateString() +"]";
                    nn++;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void BW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvLista.DataSource = dtAsistencia;
            formatear_grilla(dgvLista);
            util.mensaje_espera("Cargando, por favor espere", true, lbl_contador_registros, lbl_msg, ss_load, false);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dtPersonal = new DataTable();
            dtAsistencia = new DataTable();
            dtPresentacion = new DataTable();
            dtMarcaciones = new DataTable();
            
            txt_buscar.Text = "";
            inicializar();
            btnBuscar.BackColor = Color.FromArgb(254, 240, 158);
            cargar_grilla_asistencia();
        }

        
               
    }
}
