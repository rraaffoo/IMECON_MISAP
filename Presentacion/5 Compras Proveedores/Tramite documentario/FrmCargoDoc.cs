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
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace MISAP
{
    public partial class FrmCargoDoc : Form, IForm_Listado
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

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();
        
        DateTimePicker oDateTimePicker;
        string filtro, operacion, archi, ext, rut, openarchivo, ruta_local, ruta_red;
        int posicion, columna, NroLote, cant_col, ColumnaId, id, swtigv, NumLinea;
        decimal impuesto , subtotal, total;
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

        //private void cbo_proyecto_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    util.FormatearCombo(sender, e, "Nombre de proyecto");
        //}

        //private void cbo_ot_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    util.FormatearCombo(sender, e, "Nombre de OT");
        //}

      

        #endregion

        #region Formulario externo

        public void pasar_valores(string par1, string par2, string par3, string par4, string par5, string par6)
        {
            try
            {
                #region Nuevo

                if (operacion == "Nuevo")
                {
                    

                  
                }
                #endregion

                #region Consultar

                if (operacion == "Consultar")
                {

              
                    if (par5 == "Lista de cargos")
                    {
                        txt_lote.Text= par1;
                        consultar_navegacion();

                    }          
                      
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Orden de Producción", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        #endregion

        #region Funciones

        private void inicializar()
        {

            limpiar(operacion);
            
            operacion = "Nuevo";

            txt_FechaDocumento.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dp_FechaDocumento.CustomFormat = "yyyy-MM-dd";
            dp_FechaReg.CustomFormat = "yyyy-MM-dd";


      
            dgv_registro.DataSource = AccesoLogica.consultar_OTDC(0, "Consultar", "Resumen");
            formatear_grilla(dgv_registro);

            dgv_lista.DataSource = AccesoLogica.consultar_TDC1(0, "Consultar", "Listar");
            formatear_grilla(dgv_lista);

            formatear_grilla(dgv_anexo_consulta);
            formatear_grilla(dgv_cargo);

            dgv_anexo_consulta.Visible = true;
            dgv_anexo.Visible = false;

            posicion = 0;
            if (dgv_lista.Rows.Count != 0)
            {
                posicion = 0;
                dgv_lista.CurrentCell = dgv_lista.Rows[0].Cells[0];
              
            }

            ObtenerNroLote();


           
            #region desbloquear controles

            if (dgv_registro.RowCount > 0)
            {
                btn_agregar_seleccion.Enabled = true;
            }

            dp_FechaReg.Enabled = true;
            txt_fechaReg.Enabled = true;


            #endregion

        }

        void ObtenerNroLote()
        {
            NroLote = Convert.ToInt32(Convert.ToString(AccesoLogica.consultar_TDC1(0, "Consultar", "Obtener").Rows[0][0]));
            txt_lote.Text = Convert.ToString(NroLote);

        }

        void formatear_grilla(DataGridView grilla)
        {

            try
            {
                util.FormatearGrilla(grilla, false);
                lbl_contador_registros.Visible = true;

                if (grilla == dgv_registro )
                {
                    if (operacion == "Nuevo")
                    {

                        grilla.Columns["Nro"].Visible = false;
                        grilla.Columns["Fecha"].Visible = false;
                        grilla.Columns["Serie"].Width = 35;
                        grilla.Columns["Numero de documento"].Width = 90;
                        grilla.Columns["Nombre"].Width = 126;
                        grilla.Columns["Serie"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        grilla.Columns["Numero de documento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                     

                        grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }

                    if (operacion == "Consultar")
                    {

                        grilla.Columns["Nº de lote"].Visible = false;
                        grilla.Columns["Fecha de documento"].Visible = false;

                        grilla.Columns["Nro"].Width = 90;
                        grilla.Columns["Nro"].Visible = false;
                        
                        grilla.Columns["Nombre"].Width = 126;

                        grilla.Columns["Serie"].Width = 35;
                        grilla.Columns["Serie"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                        grilla.Columns["Nro de documento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                        grilla.Columns["Fecha de recepcion"].Visible = false; 

                        grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }

                if (grilla == dgv_cargo)
                {
                    grilla.Columns["serieg"].Width = 35;
                    grilla.Columns["documentog"].Width = 90;
                    grilla.Columns["nombreg"].Width = 126;
                    grilla.Columns["serieg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    grilla.Columns["documentog"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                }
                lbl_contador_registros.Text = string.Format("Total de registros: {0}", grilla.Rows.Count);

             }


            catch (Exception ex)
            {
                util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;

            }
        }

        void GenerarReporte()
        {
            CrvCargoDoc reporte = new CrvCargoDoc();
            reporte.NroLote = Convert.ToInt32(txt_lote.Text);
            reporte.Show();
        }

        void GrabarAnexos()
        {
            if (dgv_anexo.Rows.Count != 0)
            {
                ruta_red = @"\\10.0.0.8\Comun\MISAP\Anexos\Tramite documentario\";
                foreach (DataGridViewRow row in dgv_anexo.Rows)
                {
                    archi = Convert.ToString(row.Cells["archivo_"].Value);
                    ext = Convert.ToString(row.Cells["extension_"].Value);
                    ruta_local = Convert.ToString(row.Cells["local_r"].Value);
                    NumLinea = Convert.ToInt32(row.Cells["Line"].Value);
                    
                    System.IO.File.Copy(ruta_local, ruta_red + archi + ext);
                    
                    int resultado = Negocio.mantenimiento_OANX(Convert.ToInt32(txt_lote.Text), NumLinea, ruta_local, ruta_red, archi, ext, txt_fec_crea.Text, 0, "", "", "", operacion);
                    if (resultado == 0) Negocio = null;
                }
            }
        }

        void limpiar(string operacion)
        {
            
            util.limpiarTextBoxes(this);
            this.txt_lote.Focus();

        }

        private void consultar_navegacion()
        {
            try
            {
                operacion = "Consultar";
                btn_previsualizar.Enabled = true;



                txt_lote.Text = AccesoLogica.consultar_TDC1(Convert.ToInt32(txt_lote.Text), "Consultar", "Consultar").Rows[0]["Nº de lote"].ToString();
                txt_FechaDocumento.Text = AccesoLogica.consultar_TDC1(Convert.ToInt32(txt_lote.Text), "Consultar", "Consultar").Rows[0]["Fecha de documento"].ToString();

                dgv_registro.DataSource = AccesoLogica.consultar_TDC1(Convert.ToInt32(txt_lote.Text), "Consultar", "Consultar");
                formatear_grilla(dgv_registro);

                btn_grabar.Text = "Actualizar";
                btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                btn_grabar.Enabled = true;
                btn_consultar_b.Enabled = true;
                btn_nuevo_b.Enabled = true;


                #region bloquear controles

                
                txt_lote.ReadOnly = true;
                txt_lote.BackColor = Color.FromArgb(231, 231, 231);

                btn_agregar_seleccion.Enabled = false;
                btn_agregar_all_seleccion.Enabled = false;

                dp_FechaReg.Enabled = false;
                txt_fechaReg.Enabled = false;
                

                #endregion

                if (dgv_cargo.RowCount > 0) dgv_cargo.Rows.Clear();

                btn_grabar.Focus();
              
            }
            catch
            {
                util.mensaje("No existen registros coincidentes", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
        }

        #endregion

        #region Formulario

        public FrmCargoDoc()
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
                this.SetBounds(this.Location.X, this.Location.Y, 712, 610); 
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
                this.SetBounds(this.Location.X, this.Location.Y, 615, 525);
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

        #region Eventos

        private void FrmAvanceProyecto_Load(object sender, EventArgs e)
        {

            util.FormatearFormulario_sap(this, ts_acciones, tc_detalle, ss_load, tp_listado, tp_auditoria);
            util.Formateardetalle(tp_contenido, tp_anexo);
            this.Location = new System.Drawing.Point(320, 90);
            
           

            util.EstablecerAuditoria(operacion, usuario, "", "FrmCargoDoc", "S", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            

        }

        private void dp_FechaDocumento_ValueChanged(object sender, EventArgs e)
        {

            txt_FechaDocumento.Text = dp_FechaDocumento.Text;
        }

        private void txt_idreg_Enter(object sender, EventArgs e)
        {

            txt_lote.BackColor = Color.FromArgb(254, 240, 158);

            if (!String.IsNullOrEmpty(txt_lote.Text))
            {
                txt_lote.SelectionStart = 0;
                txt_lote.SelectionLength = txt_lote.Text.Length;
            }

        }

        
        private void t_msg_Tick(object sender, EventArgs e)
        {
            lbl_msg.Text = string.Empty;
            ss_load.BackColor = Color.Transparent;
            lbl_contador_registros.Visible = true;
            lbl_msg.Visible = false;
        }

        private void dgv_anexo_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            btn_visualizar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn));
            btn_visualizar.Enabled = true;

            btn_borrar_anexo.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn));
            btn_borrar_anexo.Enabled = true;

        }

        private void dgv_anexo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            archi = dgv_anexo.CurrentRow.Cells["archivo_"].Value.ToString();
            ext = dgv_anexo.CurrentRow.Cells["extension_"].Value.ToString();


            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = @"\\10.0.0.8\Comun\MISAP\Anexos\Tramite documentario\" + archi + ext;
            proc.Start();
            proc.Close();
        }

        private void dgv_anexo_consulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            btn_visualizar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn));
            btn_visualizar.Enabled = true;

            btn_borrar_anexo.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn));
            btn_borrar_anexo.Enabled = true;
        }

        private void dgv_anexo_consulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            archi = dgv_anexo_consulta.CurrentRow.Cells["Nombre de archivo"].Value.ToString();
            ext = dgv_anexo_consulta.CurrentRow.Cells["Extension"].Value.ToString();


            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = @"\\10.0.0.8\Comun\MISAP\Anexos\Tramite documentario\" + archi + ext;
            proc.Start();
            proc.Close();
        }

   


        #endregion

        #region Botones

        private void btn_nuevo_b_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            inicializar();

            btn_nuevo_b.Enabled = false;
            btn_consultar_b.Enabled = true;
            btn_grabar.Text = "Crear";

        }

        private void btn_consultar_b_Click(object sender, EventArgs e)
        {
            operacion = "Consultar";
          //  limpiar(operacion);
            

            btn_nuevo_b.Enabled = true;
            btn_consultar_b.Enabled = false;
            btn_grabar.Text = "Buscar";

         
            txt_lote.Enabled = true;
            txt_lote.ReadOnly = false;
            txt_lote.Clear();
            txt_lote.Focus();
          


        }
                    
        private void btn_utlimo_Click(object sender, EventArgs e)
        {
            if (dgv_lista.Rows.Count == 0)
            {
             
                util.mensaje("No Existe Informacion para exportar", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
            
            posicion = dgv_lista.Rows.Count - 1;

            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            txt_lote.Text = dgv_lista.CurrentRow.Cells[0].Value.ToString();
            consultar_navegacion();

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (dgv_lista.Rows.Count == 0)
            {

                util.mensaje("No Existe Informacion para exportar", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
            
            if (posicion < dgv_lista.Rows.Count - 1)
            {
                posicion = posicion + 1;
            }


            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            txt_lote.Text = dgv_lista.CurrentRow.Cells[0].Value.ToString();
            consultar_navegacion();
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            if (dgv_lista.Rows.Count == 0)
            {

                util.mensaje("No Existe Informacion para exportar", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
            
            posicion = 0;

            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            txt_lote.Text = dgv_lista.CurrentRow.Cells[0].Value.ToString();
            consultar_navegacion();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (dgv_lista.Rows.Count == 0)
            {

                util.mensaje("No Existe Informacion para exportar", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
            
            if (posicion > 0)
            {
                posicion = posicion - 1;
            }


            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            txt_lote.Text = dgv_lista.CurrentRow.Cells[0].Value.ToString();
            consultar_navegacion();
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            #region Nuevo

            if (operacion == "Nuevo" || operacion == "Consultar")
            {
                if (btn_grabar.Text == "OK")
                {
                    Close();
                }

                #region validaciones cabecera

                #endregion 
                
                #region validaciones detalle
             
                #endregion


                try
                {
                        foreach (DataGridViewRow row in dgv_cargo.Rows)
                            {
                                
                                int idreg = Convert.ToInt32(row.Cells["nrog"].Value);
                                                            
                                int resultado = Negocio.mantenimiento_TDC1
                                     (Convert.ToInt32(txt_lote.Text),txt_FechaDocumento.Text,idreg,
                                     txt_usr_crea.Text, txt_fec_crea.Text, txt_terminal_crea.Text, txt_usr_modi.Text,
                                     txt_fec_modi.Text, txt_terminal_modi.Text,operacion, txt_formulario.Text
                                     );
                                if (resultado == 0) Negocio = null;

                         }
                      
                        GrabarAnexos();

                        util.mensaje("La Operacion finalizo con exito", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                  


                 
                    if (btn_grabar.Text == "Actualizar")
                    {
                        btn_grabar.Text = "OK";
                    }


                    if (dgv_cargo.RowCount > 0) dgv_cargo.Rows.Clear();
                    inicializar();
                    

                }
                catch (Exception ex)
                {
                    util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    return;
                }

            }
            #endregion

        }

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
            //if (dgv_detalle.Rows.Count == 0)
            //{
            //    MessageBox.Show("No Existe Informacion para exportar", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //    return;
            //}
            //util.ExportarDataGridViewExcel(dgv_detalle, tsl_titulo.Text);
        }

        private void txt_idreg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                if (txt_lote.Text == "*")
                {
                    FrmListado Listado = new FrmListado();
                    Listado.titulo = "Lista de cargos";
                    Listado.ShowDialog(this);
                }
                else
                {
                    consultar_navegacion();
                }
            }
        }

        private void btn_borrar_anexo_Click(object sender, EventArgs e)
        {
            if (operacion == "Nuevo")
            {
                int fila = dgv_anexo.CurrentRow.Index;
                dgv_anexo.Rows.RemoveAt(fila);

                archi = dgv_anexo.CurrentRow.Cells["archivo_"].Value.ToString();
                ext = dgv_anexo.CurrentRow.Cells["extension_"].Value.ToString();
                System.IO.File.Delete(@"\\10.0.0.8\Comun\MISAP\Anexos\Tramite documentario\" + archi + ext);


                btn_visualizar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_desactivado));
                btn_visualizar.Enabled = false;

                btn_borrar_anexo.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_desactivado));
                btn_borrar_anexo.Enabled = false;

                btn_visualizar.Focus();
            }

            if (operacion == "Consultar")
            {
                int fila = dgv_anexo.CurrentRow.Index;
                dgv_anexo.Rows.RemoveAt(fila);

                archi = dgv_anexo.CurrentRow.Cells["archivo_"].Value.ToString();
                ext = dgv_anexo.CurrentRow.Cells["extension_"].Value.ToString();
                System.IO.File.Delete(@"\\10.0.0.8\Comun\MISAP\Anexos\Tramite documentario\" + archi + ext);


                btn_visualizar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_desactivado));
                btn_visualizar.Enabled = false;

                btn_borrar_anexo.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_desactivado));
                btn_borrar_anexo.Enabled = false;

                btn_visualizar.Focus();
            }
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {

            if (operacion == "Nuevo")
            {

                archi = dgv_anexo.CurrentRow.Cells["archivo_"].Value.ToString();
                ext = dgv_anexo.CurrentRow.Cells["extension_"].Value.ToString();


                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = @"\\10.0.0.8\Comun\MISAP\Anexos\Tramite documentario\" + archi + ext;
                proc.Start();
                proc.Close();
            }

            if (operacion == "Consultar")
            {

                archi = dgv_anexo_consulta.CurrentRow.Cells["Nombre de archivo"].Value.ToString();
                ext = dgv_anexo_consulta.CurrentRow.Cells["Extension"].Value.ToString();


                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = @"\\10.0.0.8\Comun\MISAP\Anexos\Tramite documentario\" + archi + ext;
                proc.Start();
                proc.Close();
            }

        }

        private void btn_explorar_Click(object sender, EventArgs e)
        {
            dgv_anexo_consulta.Visible = false;
            dgv_anexo.Visible = true;

            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"\\10.0.0.8\Comun\MISAP\Anexos\Tramite documentario";

            open.Filter = "Documentos (*.pdf, *.jpg,*.txt,*.sql,*.html,*.dwg)|*.pdf;*.jpg;*.txt;*.sql;*.html;*.dwg";
            open.FilterIndex = 1;

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string paths = Application.StartupPath;
                archi = System.IO.Path.GetFileNameWithoutExtension(open.FileName);
                ext = System.IO.Path.GetExtension(open.FileName);
                openarchivo = open.FileName;
                NumLinea = NumLinea + 1;

                dgv_anexo.Rows.Add(@"\\10.0.0.8\Comun\MISAP\Anexos\Tramite documentario", archi, txt_fec_crea.Text, ext, txt_lote.Text, NumLinea, openarchivo);

            }
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

        private void cmi_eliminar_Click(object sender, EventArgs e)
        {
            operacion = "Eliminar";
            try
            {

                util.mensaje("La Operacion finalizo con exito", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);


                if (btn_grabar.Text == "Actualizar")
                {
                    btn_grabar.Text = "OK";
                }

                inicializar();


            }
            catch (Exception ex)
            {
                util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }

        }

        private void txt_fechaReg_TextChanged(object sender, EventArgs e)
        {
            if (dgv_registro.Rows.Count != 0)
            {
                (dgv_registro.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(Fecha,'System.String') LIKE '%{0}%'", txt_fechaReg.Text);

            }
        }

        private void dp_FechaReg_ValueChanged(object sender, EventArgs e)
        {
            if (dgv_cargo.RowCount > 0) dgv_cargo.Rows.Clear();
            txt_fechaReg.Text = dp_FechaReg.Text;
        }

        private void btn_pasar_Click(object sender, EventArgs e)
        {
            string nro,nombre,serie,documento;

            Int32 FilasSeleccionadas = dgv_registro.SelectedRows.Count;

           
                if (FilasSeleccionadas > 0)
                {
                    
                    foreach (DataGridViewRow row in dgv_registro.Rows)
                    {
                        if (row.Selected == true)
                        {
                            nro = row.Cells["Nro"].Value.ToString();
                            nombre = row.Cells["Nombre"].Value.ToString();
                            serie = row.Cells["Serie"].Value.ToString();
                            documento = row.Cells["Numero de documento"].Value.ToString();

                            dgv_cargo.Rows.Add(nro, nombre, serie, documento);
                            //dgv_registro.Rows.Remove(row);
                        }
                    }


                    int mm = dgv_registro.SelectedRows.Count;
                    int elim = 0;
                    while (mm != elim)
                    {
                        foreach (DataGridViewRow row in dgv_registro.Rows)
                        {
                            if (row.Selected == true)
                            {
                                dgv_registro.Rows.Remove(row);
                                elim++;
                            }
                        }
                    }

                    btn_anular_seleccion.Enabled = true;
                       
                 }

                btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                btn_grabar.Enabled = true;
        }

        private void btn_previsualizar_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        private void dgv_cargo_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_anular_seleccion_Click(object sender, EventArgs e)
        {
            string nro, nombre, serie, documento;

            Int32 FilasSeleccionadas = dgv_cargo.SelectedRows.Count;


            if (FilasSeleccionadas > 0)
            {

                foreach (DataGridViewRow row in dgv_cargo.Rows)
                {
                    if (row.Selected == true)
                    {
                        nro = row.Cells["nrog"].Value.ToString();
                        nombre = row.Cells["Nombreg"].Value.ToString();
                        serie = row.Cells["serieg"].Value.ToString();
                        documento = row.Cells["documentog"].Value.ToString();

                        dgv_registro.Rows.Add(nro, nombre, serie, documento);
                        //dgv_registro.Rows.Remove(row);
                    }
                }


                int mm = dgv_cargo.SelectedRows.Count;
                int elim = 0;
                while (mm != elim)
                {
                    foreach (DataGridViewRow row in dgv_cargo.Rows)
                    {
                        if (row.Selected == true)
                        {
                            dgv_cargo.Rows.Remove(row);
                            elim++;
                        }
                    }
                }

            }

            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
            btn_grabar.Enabled = true;
        }

        private void btn_agregar_all_seleccion_Click(object sender, EventArgs e)
        {
            string nro, nombre, serie, documento;


                foreach (DataGridViewRow row in dgv_registro.Rows)
                {
                   
                        nro = row.Cells["Nro"].Value.ToString();
                        nombre = row.Cells["Nombre"].Value.ToString();
                        serie = row.Cells["Serie"].Value.ToString();
                        documento = row.Cells["Numero de documento"].Value.ToString();

                        dgv_cargo.Rows.Add(nro, nombre, serie, documento);
                        //dgv_registro.Rows.Remove(row);
                    
                }

                dgv_registro.DataSource = null;

                btn_agregar_seleccion.Enabled = false;
                btn_agregar_all_seleccion.Enabled = false;

            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
            btn_grabar.Enabled = true;
        }

       

  

     
       
        //private void logDeModificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    FrmLogModificaciones log = new FrmLogModificaciones();
        //    log.requerimiento = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Requerimiento"].Value);
        //    log.ShowDialog(this);
        //}
        
        #endregion

       
    }
}
