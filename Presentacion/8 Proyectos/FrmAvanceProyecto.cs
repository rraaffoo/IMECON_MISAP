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
    public partial class FrmAvanceProyecto : Form, IForm_opciones
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
        string filtro, operacion, PrjCode ,PrcCode ,CodPresupuesto ,Fase,FechaInicio,fechafin;
        int posicion, columna, pedido, CodFase , Duracion;
        decimal Avance, Peso, factor, AvanceValorizado, totalpeso, peso_ ;
    
        int cant_col, ColumnaId, id;
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

        private void cbo_proyecto_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Nombre de proyecto");
        }

        private void cbo_ot_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "Nombre de OT");
        }

      

        #endregion

        #region Formulario externo

        public void pasar_valores(string par1, string par2, string par3, string par4, string par5, string par6)
        {
            try
            {
                #region Nuevo

                if (operacion == "Nuevo")
                {
                    if (par5 == "Lista de proyectos")
                    {
                        txt_cod_proyecto.Text = par1;
                        txt_proyecto.Text = par2;

                        btn_opciones_p.Visible = false;
                    }

                    if (par5 == "Lista de ordenes de trabajo")
                    {
                        txt_cod_ot.Text = par1;
                        txt_ot.Text = par2;

                        btn_opciones_o.Visible = false;
                    }



                    if (par5 == "Lista de presupuestos")
                    {
                        txt_codpresupuesto.Text = par1;
                        txt_presupuesto.Text = par2;

                        dgv_detalle.DataSource = AccesoLogica.consultar_partidas_s10(par1);
                        formatear_grilla(dgv_detalle);


                        if (dgv_detalle.Rows.Count != 0)
                        {

                            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                            btn_grabar.Enabled = true;

                        }
                        else
                        {
                            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
                            btn_grabar.Enabled = false;

                        }


                        btn_opciones.Visible = false;
                    }
                }
                #endregion

                #region Consultar

                if (operacion == "Consultar")
                {

                    if (par5 == "Lista de ordenes de trabajo")
                    {
                        txt_cod_ot.Text = par1;
                        txt_ot.Text = par2;

                        btn_grabar.Text = "Actualizar";
                        btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                        btn_grabar.Enabled = true;
                        btn_consultar_b.Enabled = true;

                        try
                        {
                            dgv_detalle.DataSource = AccesoLogica.consultar_OCAP("", txt_cod_ot.Text, "", 0, "", "", 0, 0, 0, operacion, "Consultar");
                            formatear_grilla(dgv_detalle);

                            txt_cod_proyecto.Text = AccesoLogica.consultar_OCAP("", txt_cod_ot.Text, "", 0, "", "", 0, 0, 0, operacion, "Consultar").Rows[0][0].ToString();
                            txt_proyecto.Text = AccesoLogica.consultar_OCAP("", txt_cod_ot.Text, "", 0, "", "", 0, 0, 0, operacion, "Consultar").Rows[0][1].ToString();
                            txt_codpresupuesto.Text = AccesoLogica.consultar_OCAP("", txt_cod_ot.Text, "", 0, "", "", 0, 0, 0, operacion, "Consultar").Rows[0][4].ToString();
                            txt_presupuesto.Text = AccesoLogica.consultar_OCAP("", txt_cod_ot.Text, "", 0, "", "", 0, 0, 0, operacion, "Consultar").Rows[0][5].ToString();

                            #region bloquea textbox

                            btn_opciones.Visible = false;
                            btn_opciones_o.Visible = false;
                            btn_opciones_p.Visible = false;

                            txt_cod_proyecto.ReadOnly = true;
                            txt_codpresupuesto.ReadOnly = true;

                            txt_cod_ot.BackColor = Color.FromArgb(231, 231, 231);
                            txt_cod_proyecto.BackColor = Color.FromArgb(231, 231, 231);
                            txt_codpresupuesto.BackColor = Color.FromArgb(231, 231, 231);

                            #endregion


                       
                        }
                        catch (Exception ex)
                        {
                            util.mensaje("No existen registros coincidentes en Control de avance", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                            return;
                        }
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
            operacion = "Nuevo";
            txt_cod_proyecto.Focus();
            
            dgv_lista.DataSource = AccesoLogica.consultar_OCAP("", "", "", 0, "", "", 0, 0, 0, "Consultar", "Listar");
          
            dgv_detalle.DataSource = AccesoLogica.consultar_partidas_s10("");
            formatear_grilla(dgv_detalle);

            if (dgv_lista.Rows.Count != 0)
            {
             
                dgv_lista.CurrentCell = dgv_lista.Rows[0].Cells[0];
              
            }
            posicion = 0;
           // limpiar(); 
            
          

            util.FormatearFormulario_sap(this, ts_acciones, tc_detalle, ss_load, tp_listado, tp_auditoria);
            this.Location = new System.Drawing.Point(320, 80);

            util.EstablecerAuditoria(operacion, usuario, "", "FrmAvanceProyecto", "S", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);


            dgv_detalle.CellValueChanged += new DataGridViewCellEventHandler(dgv_detalle_CellValueChanged);
        }

        void formatear_grilla(DataGridView grilla)
        {

            try
            {


                util.FormatearGrilla(grilla, false);
                lbl_contador_registros.Visible = true;

                lbl_contador_registros.Text = string.Format("Total de registros: {0}", grilla.Rows.Count);

                if (grilla == dgv_detalle)
                {

                    if (lbl_origen.Text == "0")
                    {
                        grilla.Columns["CodProyecto"].Visible = false;
                        grilla.Columns["Proyecto"].Visible = false;
                        grilla.Columns["CodOT"].Visible = false;
                        grilla.Columns["OT"].Visible = false;
                        grilla.Columns["CodPrespuesto"].Visible = false;
                        grilla.Columns["Presupuesto"].Visible = false;

                    

                    }

                    grilla.Columns["Factor"].ReadOnly = true;

                    grilla.Columns["Avance valorizado"].ReadOnly = true;


                        grilla.Columns["Fecha de Inicio"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        grilla.Columns["Fecha de Inicio"].DefaultCellStyle.BackColor = Color.White;

                        grilla.Columns["Fecha Fin"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        grilla.Columns["Fecha fin"].ReadOnly = true;

                        grilla.Columns["Duracion"].DefaultCellStyle.BackColor = Color.White;
                        grilla.Columns["Duracion"].Width = 62;
                    
                        grilla.Columns["Avance real %"].DefaultCellStyle.BackColor = Color.White;
                        grilla.Columns["Avance real %"].Width = 90;
                    
                        grilla.Columns["Peso"].DefaultCellStyle.BackColor = Color.White;
                        grilla.Columns["Peso"].Width = 47; 
                      
                        grilla.Columns["Descripcion"].ReadOnly = true;
                        grilla.Columns["Descripcion"].Width = 168;
                        
                        grilla.Columns["Fase"].ReadOnly = true;
                        grilla.Columns["Fase"].Width = 35;
                      
                    
                        if (operacion == "Consultar")
                        {
                            grilla.Columns["Fecha de Inicio"].ReadOnly = true;
                            grilla.Columns["Duracion"].ReadOnly = true;
                            grilla.Columns["Peso"].ReadOnly = true;

                            grilla.Columns["Fecha de Inicio"].DefaultCellStyle.BackColor = Color.FromArgb(229, 229, 229); 
                            grilla.Columns["Duracion"].DefaultCellStyle.BackColor = Color.FromArgb(229, 229, 229);
                            grilla.Columns["Peso"].DefaultCellStyle.BackColor = Color.FromArgb(229, 229, 229); 
                        }  
                
                }
            }


            catch (Exception ex)
            {
                util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;

            }
        }

        void limpiar()
        {
            txt_cod_proyecto.Clear();
            txt_proyecto.Clear();
            txt_cod_ot.Clear();
            txt_ot.Clear();
            txt_codpresupuesto.Clear();
            txt_presupuesto.Clear();

          dgv_detalle.DataSource = null;
          dgv_detalle.DataSource = AccesoLogica.consultar_partidas_s10("");
          formatear_grilla(dgv_detalle);
            
            
        
        }

        private void consultar_navegacion()
        {
            operacion = "Consultar";
            
            txt_cod_ot.Text = dgv_lista.CurrentRow.Cells["CodOT"].Value.ToString();

            dgv_detalle.DataSource = AccesoLogica.consultar_OCAP("", txt_cod_ot.Text, "", 0, "", "", 0, 0, 0, "Consultar", "Consultar");
            formatear_grilla(dgv_detalle);

            txt_cod_proyecto.Text = AccesoLogica.consultar_OCAP("", txt_cod_ot.Text, "", 0, "", "", 0, 0, 0, "Consultar", "Consultar").Rows[0][0].ToString();
            txt_proyecto.Text = AccesoLogica.consultar_OCAP("", txt_cod_ot.Text, "", 0, "", "", 0, 0, 0, "Consultar", "Consultar").Rows[0][1].ToString();
            txt_ot.Text = AccesoLogica.consultar_OCAP("", txt_cod_ot.Text, "", 0, "", "", 0, 0, 0, "Consultar", "Consultar").Rows[0][3].ToString();
            txt_codpresupuesto.Text = AccesoLogica.consultar_OCAP("", txt_cod_ot.Text, "", 0, "", "", 0, 0, 0, "Consultar", "Consultar").Rows[0][4].ToString();
            txt_presupuesto.Text = AccesoLogica.consultar_OCAP("", txt_cod_ot.Text, "", 0, "", "", 0, 0, 0, "Consultar", "Consultar").Rows[0][5].ToString();

            btn_grabar.Text = "Actualizar";
            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
            btn_grabar.Enabled = true;
            btn_consultar_b.Enabled = true;
            btn_nuevo_b.Enabled = true;
            chk_cronograma.Enabled = false;

            #region bloquea textbox

            btn_opciones.Visible = false;
            btn_opciones_o.Visible = false;
            btn_opciones_p.Visible = false;

            txt_cod_proyecto.ReadOnly = true;
            txt_codpresupuesto.ReadOnly = true;

            txt_cod_ot.BackColor = Color.FromArgb(231, 231, 231);
            txt_cod_proyecto.BackColor = Color.FromArgb(231, 231, 231);
            txt_codpresupuesto.BackColor = Color.FromArgb(231, 231, 231);

            #endregion



        }

        private void LLenarGrid(string archivo, string hoja)
        {


            //declaramos las variables         
            OleDbConnection conexion = null;
            DataSet dataSet = null;
            OleDbDataAdapter dataAdapter = null;

            string consultaHojaExcel = "Select * from [" + hoja + "$]";

            //esta cadena es para archivos excel 2007 y 2010
            //string cadenaConexionArchivoExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + archivo + "';Extended Properties=Excel 12.0;";

            //para archivos de 97-2003 usar la siguiente cadena
            string cadenaConexionArchivoExcel = "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + archivo + "';Extended Properties=Excel 8.0;";


            //Validamos que el usuario ingrese el nombre de la hoja del archivo de excel a leer
            if (string.IsNullOrEmpty(hoja))
            {
                MessageBox.Show("No hay una hoja para leer");
            }
            else
            {
                try
                {
                    //Si el usuario escribio el nombre de la hoja se procedera con la busqueda
                    conexion = new OleDbConnection(cadenaConexionArchivoExcel);//creamos la conexion con la hoja de excel
                    conexion.Open(); //abrimos la conexion
                    dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); //traemos los datos de la hoja y las guardamos en un dataSdapter
                    dataSet = new DataSet(); // creamos la instancia del objeto DataSet
                    dataAdapter.Fill(dataSet, hoja);//llenamos el dataset
                    dgv_detalle.DataSource = dataSet.Tables[0]; //le asignamos al DataGridView el contenido del dataSet
                    conexion.Close();//cerramos la conexion
                    dgv_detalle.AllowUserToAddRows = false;       //eliminamos la ultima fila del datagridview que se autoagrega

                }
                catch (Exception ex)
                {
                    util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    return;
                }
            }
        }

        #endregion

        #region Formulario

        public FrmAvanceProyecto()
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
                this.SetBounds(this.Location.X, this.Location.Y, 615, 525);
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

            //pos = new Point(e.X, e.Y);
            //move = true;

            //dragging = true;
            //dragCursorPoint = Cursor.Position;
            //dragFormPoint = this.Location;
        }

        private void titulo_MouseMove(object sender, MouseEventArgs e)
        {
            //if (dragging)
            //{
            //    Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
            //    this.Location = Point.Add(dragFormPoint, new Size(dif));
            //}
            
            //if (move)
            //    this.Location = new Point((this.Left + e.X - pos.X),
            //        (this.Top + e.Y - pos.Y));
        }

        private void titulo_MouseUp(object sender, MouseEventArgs e)
        {
            //dragging = false;
            
            //move = false;
        }

        #endregion

        #region Eventos

        private void FrmAvanceProyecto_Load(object sender, EventArgs e)
        {
           
            inicializar();
       
        }

        private void txt_codpresupuesto_Enter(object sender, EventArgs e)
        {
            if (operacion == "Nuevo")
            {
                if (chk_cronograma.Checked == false)
                {
                    chk_cronograma.Enabled = false;
                    btn_opciones.Visible = true;

                    txt_codpresupuesto.BackColor = Color.FromArgb(254, 240, 158);
                    if (!String.IsNullOrEmpty(txt_codpresupuesto.Text))
                    {
                        txt_codpresupuesto.SelectionStart = 0;
                        txt_codpresupuesto.SelectionLength = txt_codpresupuesto.Text.Length;
                    }
                }
            }
        }

        private void txt_cod_proyecto_Enter(object sender, EventArgs e)
        {
            if (operacion == "Nuevo")
            {
                btn_opciones_p.Visible = true;
                txt_cod_proyecto.BackColor = Color.FromArgb(254, 240, 158);
                if (!String.IsNullOrEmpty(txt_cod_proyecto.Text))
                {
                    txt_cod_proyecto.SelectionStart = 0;
                    txt_cod_proyecto.SelectionLength = txt_cod_proyecto.Text.Length;
                }
            }
        }

        private void txt_cod_ot_Enter(object sender, EventArgs e)
        {
            btn_opciones_o.Visible = true;

            txt_cod_ot.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txt_cod_ot.Text))
            {
                txt_cod_ot.SelectionStart = 0;
                txt_cod_ot.SelectionLength = txt_cod_ot.Text.Length;
            }
        }

        private void txt_cod_proyecto_Leave(object sender, EventArgs e)
        {
            if (operacion == "Nuevo")
            {
                txt_cod_proyecto.BackColor = Color.White;
            }
        }

        private void txt_cod_ot_Leave(object sender, EventArgs e)
        {
            txt_cod_ot.BackColor = Color.White;

            
        }

        private void txt_codpresupuesto_Leave(object sender, EventArgs e)
        {
            if (operacion == "Nuevo")
            {
                txt_cod_ot.BackColor = Color.White;
            }
        }

        private void t_msg_Tick(object sender, EventArgs e)
        {
            lbl_msg.Text = string.Empty;
            ss_load.BackColor = Color.Transparent;
            lbl_contador_registros.Visible = true;
            lbl_msg.Visible = false;
        }

        private void lb_hoja_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_origen.Text = "1";

            txt_hoja.Text = lb_hoja.SelectedItem.ToString();
            LLenarGrid(txt_archivo.Text, txt_hoja.Text); //se manda a llamar al metod
            formatear_grilla(dgv_detalle);

            if (dgv_detalle.Rows.Count != 0)
            {

                btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                btn_grabar.Enabled = true;

            }
            else
            {
                btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
                btn_grabar.Enabled = false;

            }

            lbl_origen.Text = "0";
            lb_hoja.Visible = false;
        }

        private void dgv_detalle_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string columna = dgv_detalle.Columns[e.ColumnIndex].HeaderText;
            if (operacion == "Nuevo")
            {
                if (columna == "Duracion" || columna == "Fecha de Inicio" || columna == "Avance real %" || columna == "Peso")
                {
                    dgv_detalle[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.FromArgb(254, 240, 158);
                }
            }
        }

        private void dgv_detalle_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            string columna = dgv_detalle.Columns[e.ColumnIndex].HeaderText;

            if (operacion == "Nuevo")
            {
                if (columna == "Duracion" || columna == "Fecha de Inicio" || columna == "Avance real %" || columna == "Peso")
                {
                    dgv_detalle[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                }
            }
        }

        private void txt_cod_ot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                operacion = "Consultar";

                dgv_detalle.DataSource = AccesoLogica.consultar_OCAP("", txt_cod_ot.Text, "", 0, "", "", 0, 0, 0, "Consultar", "Consultar");
                formatear_grilla(dgv_detalle);

                txt_cod_proyecto.Text = AccesoLogica.consultar_OCAP("", txt_cod_ot.Text, "", 0, "", "", 0, 0, 0, "Consultar", "Consultar").Rows[0][0].ToString();
                txt_proyecto.Text = AccesoLogica.consultar_OCAP("", txt_cod_ot.Text, "", 0, "", "", 0, 0, 0, "Consultar", "Consultar").Rows[0][1].ToString();
                txt_ot.Text = AccesoLogica.consultar_OCAP("", txt_cod_ot.Text, "", 0, "", "", 0, 0, 0, "Consultar", "Consultar").Rows[0][3].ToString();
                txt_codpresupuesto.Text = AccesoLogica.consultar_OCAP("", txt_cod_ot.Text, "", 0, "", "", 0, 0, 0, "Consultar", "Consultar").Rows[0][4].ToString();
                txt_presupuesto.Text = AccesoLogica.consultar_OCAP("", txt_cod_ot.Text, "", 0, "", "", 0, 0, 0, "Consultar", "Consultar").Rows[0][5].ToString();

                btn_grabar.Text = "Actualizar";
                btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                btn_grabar.Enabled = true;
                btn_consultar_b.Enabled = true;
                btn_nuevo_b.Enabled = true;
            }

        }

        private void chk_cronograma_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_cronograma.Checked == true)
            {
                btn_abrir_plantilla.Visible = true;
                btn_cargar_archivo.Visible = true;

                #region bloquea textbox

                btn_opciones.Visible = false;

                txt_codpresupuesto.ReadOnly = true;
                txt_presupuesto.ReadOnly = true;

                txt_codpresupuesto.BackColor = Color.FromArgb(231, 231, 231);
                txt_presupuesto.BackColor = Color.FromArgb(231, 231, 231);

                #endregion

            }
        }

        private void dgv_detalle_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgv_detalle.Columns[e.ColumnIndex].Name == "Fecha de Inicio")
            {

                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                    return;

                DateTime fecha;

                if (!DateTime.TryParse(e.FormattedValue.ToString(), out fecha))
                {
                    DataGridViewRow row = dgv_detalle.Rows[e.RowIndex];
                    util.mensaje("Valor de fecha no válido", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    e.Cancel = true;

                }
            }

            if (dgv_detalle.Columns[e.ColumnIndex].Name == "Peso"
                || dgv_detalle.Columns[e.ColumnIndex].Name == "Avance real %"
                || dgv_detalle.Columns[e.ColumnIndex].Name == "Duracion")
            {

                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                    return;

                decimal valor;

                if (!decimal.TryParse(e.FormattedValue.ToString(), out valor))
                {
                    DataGridViewRow row = dgv_detalle.Rows[e.RowIndex];
                    util.mensaje("Valor no válido", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    e.Cancel = true;

                }
            }

            if (dgv_detalle.Columns[e.ColumnIndex].Name == "Avance real %")
                {

                    decimal avance;
                    if (decimal.TryParse(e.FormattedValue.ToString(), out avance))
                    {
                        DataGridViewRow row = dgv_detalle.Rows[e.RowIndex];
                        if (avance > 100)
                        {

                            util.mensaje("Valor no válido, ingrese un valor entre [1-100] ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                            e.Cancel = true;
                        }
                    }
            }

            if (dgv_detalle.Columns[e.ColumnIndex].Name == "Peso")
            {
                decimal peso;
                if (decimal.TryParse(e.FormattedValue.ToString(), out peso))
                {
                    DataGridViewRow row = dgv_detalle.Rows[e.RowIndex];
                    if (peso > 10)
                    {

                        util.mensaje("Valor no válido, ingrese un valor entre [1-10] ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                        e.Cancel = true;
                    }
                }
            }
        }

        private void dgv_detalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv_detalle.Columns[e.ColumnIndex].Name == "Fecha de Inicio") 
            {
                DateTime fechaInicio, fechaFin;
                decimal duracion;
                foreach (DataGridViewRow row in dgv_detalle.Rows)
                {
                    if (!DateTime.TryParse(Convert.ToString(row.Cells["Fecha de Inicio"].Value), out fechaInicio))
                        continue;


                    fechaInicio = Convert.ToDateTime(fechaInicio);
                    fechaFin = Convert.ToDateTime(row.Cells["Fecha Fin"].Value);
                    TimeSpan ts = fechaInicio - fechaFin;
                    duracion = ts.Days;

                    row.Cells["Duracion"].Value = duracion;
                }

            }

            if ( dgv_detalle.Columns[e.ColumnIndex].Name == "Duracion")
            {

              
                foreach (DataGridViewRow row in dgv_detalle.Rows)
                {
                    decimal duracion;
                    DateTime fecha;

                 

                    if (!decimal.TryParse(Convert.ToString(row.Cells["Duracion"].Value), out duracion))
                        continue;

                    fecha = Convert.ToDateTime(row.Cells["Fecha de Inicio"].Value).AddDays(Convert.ToInt32(duracion));
                    row.Cells["Fecha Fin"].Value = fecha.ToString("dd/MM/yyyy");

                }


            }

            if (dgv_detalle.Columns[e.ColumnIndex].Name == "Avance real %" || dgv_detalle.Columns[e.ColumnIndex].Name == "Peso")
            {

                decimal totalpeso = 0;

                foreach (DataGridViewRow row in dgv_detalle.Rows)
                {
                    totalpeso = totalpeso + Convert.ToDecimal(row.Cells["Peso"].Value);
                }


                foreach (DataGridViewRow row in dgv_detalle.Rows)
                {
                    
                    decimal Avance = 0;
                  

                    if (!decimal.TryParse(Convert.ToString(row.Cells["Avance real %"].Value), out Avance))
                        continue;



                    if (!decimal.TryParse(Convert.ToString(row.Cells["Peso"].Value), out peso_))
                        continue;



                    factor = Convert.ToDecimal(row.Cells["Peso"].Value) / totalpeso;
                    row.Cells["Factor"].Value = factor;

                    decimal totalFila = Convert.ToDecimal(row.Cells["Factor"].Value) * Avance;
                    row.Cells["Avance valorizado"].Value = totalFila;

                               
                }


                dgv_detalle.Columns["Avance valorizado"].DefaultCellStyle.Format = "0.00#";
                dgv_detalle.Columns["Avance real %"].DefaultCellStyle.Format = "0.00#";
                dgv_detalle.Columns["Peso"].DefaultCellStyle.Format = "0.00#";
                dgv_detalle.Columns["Duracion"].DefaultCellStyle.Format = "0.00#";
                dgv_detalle.Columns["Factor"].DefaultCellStyle.Format = "0.00#";
            }

        }

        #endregion

        #region Botones

        private void btn_nuevo_b_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            

            util.EstablecerAuditoria(operacion, usuario, "", "FrmAvanceProyecto", "S", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            posicion = 0;
            limpiar();

            btn_nuevo_b.Enabled = false;
            btn_grabar.Text = "Crear";

            btn_cargar_archivo.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn));
            btn_cargar_archivo.Enabled = true;

            txt_cod_proyecto.ReadOnly = false; 
            txt_cod_proyecto.Focus();
        }

        private void btn_consultar_b_Click(object sender, EventArgs e)
        {
            operacion = "Consultar";
            limpiar();
            

            btn_nuevo_b.Enabled = true;
            btn_consultar_b.Enabled = false;
            btn_grabar.Text = "Buscar";

            btn_opciones.Visible = false;
            btn_opciones_o.Visible = false;
            btn_opciones_p.Visible = false;

            txt_cod_ot.Enabled = true;
            txt_cod_ot.Focus();

            btn_cargar_archivo.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_desactivado));
            btn_cargar_archivo.Enabled = false;
        }
       
        private void btn_opciones_Click(object sender, EventArgs e)
        {
            FrmOpciones opciones = new FrmOpciones();
            opciones.titulo = "Lista de presupuestos";
            opciones.ShowDialog(this);
        }

        private void btn_opciones_p_Click(object sender, EventArgs e)
        {
            FrmOpciones opciones = new FrmOpciones();
            opciones.titulo = "Lista de proyectos";
            opciones.ShowDialog(this);
        }

        private void btn_opciones_o_Click(object sender, EventArgs e)
        {
            FrmOpciones opciones = new FrmOpciones();
            opciones.titulo = "Lista de ordenes de trabajo";
            opciones.parametro_1 = txt_cod_proyecto.Text;
            opciones.ShowDialog(this);

        }
        
        private void btn_utlimo_Click(object sender, EventArgs e)
        {
            posicion = dgv_lista.Rows.Count - 1;

            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            consultar_navegacion();

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (posicion < dgv_lista.Rows.Count - 1)
            {
                posicion = posicion + 1;
            }


            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            consultar_navegacion();
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            posicion = 0;

            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            consultar_navegacion();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion = posicion - 1;
            }


            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
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

                if (chk_cronograma.Checked == false && operacion == "Nuevo")
                {
                    if (txt_codpresupuesto.Text == string.Empty)
                    {
                        util.mensaje("El campo " + lbl_cod_presupuesto.Text + " no debe estar vacio; indique un valor para " + lbl_cod_presupuesto.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                        txt_codpresupuesto.Focus();
                        return;

                    }
                }

                if (txt_cod_proyecto.Text == string.Empty)
                {
                    util.mensaje("El campo " + lbl_cod_proyecto.Text + " no debe estar vacio; indique un valor para " + lbl_cod_proyecto.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    txt_codpresupuesto.Focus();
                    return;

                }

                if (txt_cod_ot.Text == string.Empty)
                {
                    util.mensaje("El campo " + lbl_cod_ot.Text + " no debe estar vacio; indique un valor para " + lbl_cod_ot.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    txt_codpresupuesto.Focus();
                    return;

                }

                #endregion 
                
                #region validaciones detalle
             
                foreach (DataGridViewRow row in dgv_detalle.Rows)
                {

                    if (row.Cells["Fecha de Inicio"].Value == DBNull.Value || row.Cells["Fecha de Inicio"].Value == string.Empty)
                    {
                        util.mensaje("Existen valores vacios en la columna Fecha de Inicio", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                        return;
                    }


                    if (row.Cells["Duracion"].Value == DBNull.Value)
                    {
                        util.mensaje("Existen valores vacios en la columna Duracion ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                        return;
                    }

                    if (Convert.ToDecimal(row.Cells["Duracion"].Value) == 0)
                    {
                        util.mensaje("La duración debe ser mayor que cero ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                        return;
                    }

                    if (row.Cells["Avance real %"].Value == DBNull.Value)
                    {
                        util.mensaje("Existen valores vacios en la columna Avance real % ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                        return;
                    }

                    if (row.Cells["Peso"].Value == DBNull.Value)
                    {
                        util.mensaje("Existen valores vacios en la columna Peso ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                        return;
                    }

                    if (Convert.ToDecimal(row.Cells["Peso"].Value) == 0)
                    {
                        util.mensaje("El peso debe ser mayor que cero ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                        return;
                    }


                }
                #endregion


                try
                {
                    PrjCode = txt_cod_proyecto.Text;
                    PrcCode = txt_cod_ot.Text;
                    CodPresupuesto = txt_codpresupuesto.Text;


                    foreach (DataGridViewRow row in dgv_detalle.Rows)
                    {
                        CodFase = Convert.ToInt32(row.Cells["Fase"].Value);
                        Fase = row.Cells["Descripcion"].Value.ToString();
                        FechaInicio = Convert.ToDateTime(row.Cells["Fecha de Inicio"].Value).ToString("yyyy/MM/dd");
                        fechafin = Convert.ToDateTime(row.Cells["Fecha Fin"].Value).ToString("yyyy/MM/dd");
                        Duracion = Convert.ToInt32(row.Cells["Duracion"].Value);
                        Avance = Convert.ToDecimal(row.Cells["Avance real %"].Value);
                        Peso = Convert.ToDecimal(row.Cells["Peso"].Value);
                        factor = Convert.ToDecimal(row.Cells["Factor"].Value);
                        AvanceValorizado = Convert.ToDecimal(row.Cells["Avance valorizado"].Value);

                        int resultado = Negocio.mantenimiento_OCAP(PrjCode, PrcCode, CodPresupuesto, CodFase, Fase, FechaInicio, fechafin, Duracion, Avance, Peso, factor,AvanceValorizado, operacion);
                        if (resultado == 0) Negocio = null;
                    }


                    util.mensaje("La Operacion finalizo con exito", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                  
                    dgv_lista.DataSource = AccesoLogica.consultar_OCAP("", "", "", 0, "", "", 0, 0, 0, "Consultar", "Listar");
                    if (dgv_lista.Rows.Count != 0)
                    {
                        posicion = 0;
                        dgv_lista.CurrentCell = dgv_lista.Rows[0].Cells[0];

                    }
                
                    if (btn_grabar.Text == "Actualizar")
                    {
                        btn_grabar.Text = "OK";
                    }

                   

                }
                catch (Exception ex)
                {
                    util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    return;
                }





            }
            #endregion

        }

        private void btn_cargar_archivo_Click(object sender, EventArgs e)
        {
            try
            {
    
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx";
                dialog.Title = "Seleccione el archivo de Excel";
                dialog.FileName = string.Empty;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    txt_archivo.Text = dialog.FileName;

                    Excel.Application excel = new Excel.Application();
                    Excel._Workbook libro = excel.Workbooks.Open(txt_archivo.Text);


                    lb_hoja.Items.Clear();
                    lb_hoja.Visible = true;

                    foreach (Excel.Worksheet hojas in libro.Sheets)
                    {
                        lb_hoja.Items.Add(hojas.Name);

                    }

                    libro.Close(true);
                    excel.Quit();
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Importar maestro", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
            if (dgv_detalle.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para exportar", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            util.ExportarDataGridViewExcel(dgv_detalle, tsl_titulo.Text);
        }

        private void btn_abrir_plantilla_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();


            proc.StartInfo.FileName = "\\\\IMECON08\\Comun\\MISAP\\Anexos\\Excel\\Control de avance de proyectos.xls";
            proc.Start();
            proc.Close(); 
            
            btn_cargar_archivo.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn));
            btn_cargar_archivo.Enabled = true;


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

        //private void logDeModificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    FrmLogModificaciones log = new FrmLogModificaciones();
        //    log.requerimiento = Convert.ToString(dgv_pedidos.CurrentRow.Cells["Requerimiento"].Value);
        //    log.ShowDialog(this);
        //}


        #endregion

       

    }
}
