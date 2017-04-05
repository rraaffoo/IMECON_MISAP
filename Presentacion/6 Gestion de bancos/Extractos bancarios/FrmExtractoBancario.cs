using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;
using Negocio;
using System.Net.Mail;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;
using SAPbobsCOM;
using Excel = Microsoft.Office.Interop.Excel;



namespace MISAP
{




    public partial class FrmExtractoBancario : Form, IForm_opciones, IForm_configuracion
    {

        #region Variables globales

        public string usuario, perfil, bd_sap;

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
        bool Ejecucion = false;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();
        FrmEspera espera = new FrmEspera();

        private BankPages extracto;
        private SAPbobsCOM.SBObob oSBObob;


        string dia, mes, anio, MontoCredito, MontoDebito, FechaOperacion, Referencia, InfoDetallada, operacion, cuenta;
         
        int posicion, columna, pedido, id_solicitud, NumLinea = 0, contador, correlativo;

        int cant_col, ColumnaId, id;
        int[] vector, vec_col;
        bool[] vec_falg;
        bool visible_;

        decimal abono, total_abono;

        #endregion

        #region Formulario

           public FrmExtractoBancario()
        {
              InitializeComponent();
         
        }

        private void ninimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizar_Click(object sender, EventArgs e)
        {

            this.WindowState = (this.WindowState == FormWindowState.Maximized ?

            FormWindowState.Normal    : FormWindowState.Maximized);

            if (this.WindowState == FormWindowState.Maximized)
            {
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));


            }

            if (this.WindowState == FormWindowState.Normal)
            {

                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
            }




            //if (lbl_maximi.Text == "1")
            //{
            //    this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //    maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));

            //    lbl_maximi.Text = "0";
            //}
            //else
            //{
            //    maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
            //    this.SetBounds(this.Location.X, this.Location.Y, 858, 595);
            //    this.Location = new System.Drawing.Point(320, 80);

            //    lbl_maximi.Text = "1";
            //}

        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void titulo_DoubleClick(object sender, EventArgs e)
        {

            this.WindowState = (this.WindowState == FormWindowState.Maximized ?

                FormWindowState.Normal
                : FormWindowState.Maximized);

            if (this.WindowState == FormWindowState.Maximized)
            {
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));


            }

            if (this.WindowState == FormWindowState.Normal)
            {

                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
            }

            //if (lbl_maximi.Text == "1")
            //{
            //    this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //    maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));

            //    lbl_maximi.Text = "0";
            //}
            //else
            //{
            //    maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
            //    this.SetBounds(this.Location.X, this.Location.Y, 858, 595);
            //    this.Location = new System.Drawing.Point(320, 80);

            //    lbl_maximi.Text = "1";
            //}



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

        #region Formulario externo

        public void pasar_valores(string par1, string par2, string par3, string par4, string par5, string par6)
        {
            try
            {
                if (par5 == "Lista de Cuentas")
                {
                    txt_cuenta.Text = par1;
                    lbl_nombre_cuenta.Text = par2;
                    txt_banco.Focus();
                    
                }

                if (par5 == "Lista de bancos")
                {
                    txt_CodigoBanco.Text = par1;
                    txt_banco.Text = par2;

                    dgv_columnas.DataSource = AccesoLogica.listar_columnas_eb("listar", par1,"");

                    btn_cargar_archivo.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn));
                    btn_cargar_archivo.Enabled = true;
                    btn_cargar_archivo.Focus();

                    btn_configuracion.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn));
                    btn_configuracion.Enabled = true;

                    GenerarNumEstado();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Orden de Producción", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        public void actualizar()
        {
            dgv_columnas.DataSource = AccesoLogica.listar_columnas_eb("listar", txt_CodigoBanco.Text, "");
        }


        #endregion

        #region Funciones

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
                  
                    dgv_extracto.DataSource = dataSet.Tables[0]; //le asignamos al DataGridView el contenido del dataSet

                    DataTable dtable = new DataTable();
                    dtable = dataSet.Tables[0];

                    #region asignar columnas
                    foreach (DataGridViewRow row in dgv_columnas.Rows)
                    {
                        if (Convert.ToString(row.Cells["Tipo"].Value) == "MontoCredito")
                        {

                            MontoCredito = Convert.ToString(row.Cells["Descripcion"].Value);

                        }

                        if (Convert.ToString(row.Cells["Tipo"].Value) == "MontoDebito")
                        {

                            MontoDebito = Convert.ToString(row.Cells["Descripcion"].Value);

                        }
                    }
                    #endregion

                    decimal total_1, total_2, total_1_ = 0, total_2_ = 0;

                    if (dgv_extracto.Rows.Count != 0)
                    {
                        foreach (DataGridViewRow row in dgv_extracto.Rows)
                        {
                            total_1 = Convert.ToDecimal(row.Cells[MontoCredito].Value);
                            total_1_ = total_1_ + total_1;


                            total_2 = Convert.ToDecimal(row.Cells[MontoDebito].Value);
                            total_2_ = total_2_ + total_2;

                        }

                        txt_total_1.Text = Convert.ToString(total_1_);
                        lbl_total_1.Text = "Total " + MontoCredito;
                        txt_total_2.Text = Convert.ToString(total_2_);
                        lbl_total_2.Text = "Total " + MontoDebito;
                    }
                                  
                    
                    conexion.Close();//cerramos la conexion
                    dgv_extracto.AllowUserToAddRows = false;       //eliminamos la ultima fila del datagridview que se autoagrega
                    chk_todos.Visible = false;
                }
                catch (Exception ex)
                {
                    util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    return;
                }
            }
        }

        void formatear_grilla(DataGridView grilla)
        {

            try
            {
                util.FormatearGrilla(grilla, false);
                lbl_contador_registros.Visible = true;

                grilla.RowHeadersWidth = 40;

                    if (grilla == dgv_extracto)
                    {

                        if (operacion == "Eliminar")
                        {
                             // grilla.Columns["Proveedor"].Width = 100;
                              //dgv_pedidos.Columns["U_CL_CODSOL"].Visible = false;
                              grilla.Columns["seleccion"].Visible = true;
                       
                        }

                        if (operacion == "Nuevo")
                        {
                            for (int i = 0; i < grilla.Rows.Count; i++)
                            {
                                grilla.Rows[i].HeaderCell.Value = (i + 1).ToString();
                                grilla.Rows[i].HeaderCell.Style.Font = new Font("Calibri", 7);
                            }

                        }
                         lbl_contador_registros.Text = string.Format("Total de registros: {0}", grilla.Rows.Count);
                    }
                }

            
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Fabricación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        void limpiar()
        {
            txt_cuenta.Clear();
            txt_CodigoBanco.Clear();
            txt_banco.Clear();
            txt_num_estado.Clear();
            txt_archivo.Clear();
            txt_hoja.Clear();
            txt_correlativo.Clear();
            lbl_nombre_cuenta.Text = "";
            txt_total_1.Clear();
            txt_total_2.Clear();
            lb_hoja.Items.Clear();
            lb_hoja.Visible = false;
            dgv_extracto.DataSource = null;
            dgv_columnas.DataSource = null;
            chk_todos.Visible = false;

            txt_cuenta.ReadOnly = true;
            txt_banco.ReadOnly = true;
            txt_cuenta.Enabled = false;
            txt_banco.Enabled = false;
            txt_banco.BackColor = Color.FromArgb(231, 231, 231);
            txt_cuenta.BackColor = Color.FromArgb(231, 231, 231);

            btn_opciones.Visible = false;
            btn_opciones_b.Visible = false;

            btn_nuevo_b.Enabled = true;
            btn_eliminar_b.Enabled = true;

           
            txt_num_estado.Enabled = false;

            dgv_extracto.RowHeadersVisible = false;



            btn_configuracion.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_desactivado));
            btn_configuracion.Enabled = false;

            btn_cargar_archivo.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_desactivado));
            btn_cargar_archivo.Enabled = false;

            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
            btn_grabar.Enabled = false;
        }


        private void eliminar_extracto()
        {
            try
            {
                conexion_sap();
                extracto = (BankPages)Conexion.oCompany.GetBusinessObject(BoObjectTypes.oBankPages);

                foreach (DataGridViewRow row in dgv_extracto.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["seleccion"].Value))
                    {

                        id = Convert.ToInt32(row.Cells["Id"].Value);
                        cuenta = Convert.ToString(row.Cells["Cuenta"].Value);

                        extracto.GetByKey(cuenta, id);

                        if (extracto.Remove() == 0)
                        {
                            //string docEntry = Conexion.oCompany.GetNewObjectKey();

                        }
                        else
                        {
                            int rpta = 0;
                            string msj = "";
                            Conexion.oCompany.GetLastError(out rpta, out msj);
                            util.mensaje(rpta + " " + msj, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                            return;
                        }
                    }
                }

                util.mensaje("La Operacion finalizo con exito", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                dgv_extracto.DataSource = AccesoLogica.listar_extractos(txt_cuenta.Text, 0, Convert.ToInt32(txt_num_estado.Text));
                formatear_grilla(dgv_extracto);
                chk_todos.Visible = true;

            }

            catch (Exception ex)
            {
                util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }

            Action a = () =>
            {
                Ejecucion = false;
                espera.Close();

            };

            espera.Invoke(a);

        }

        void conexion_sap()
        {
          
            Conexion.InitializeCompany(bd_sap);
            Conexion.oCompany.Connect();

            if (Conexion.oCompany.Connected == false)
            {
                MessageBox.Show("No se pudo conectar a SAP, intente nuevamente... ", "Aprobar", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                // MessageBox.Show("Se conecto a SAP");

            }
        }

        void GenerarNumEstado()
        {
            dia = DateTime.Now.Day.ToString();
            mes =  DateTime.Now.Month.ToString();
            anio = DateTime.Now.Year.ToString();
           
            correlativo = Convert.ToInt32(Convert.ToString(AccesoLogica.listar_columnas_eb("consultar", txt_CodigoBanco.Text, "MontoCredito").Rows[0][2])) + 1;
            txt_correlativo.Text = Convert.ToString(correlativo);

            txt_num_estado.Text = txt_correlativo.Text;
         }

        private void Accion()
        {
           

            #region Nuevo
            if (operacion == "Nuevo")
            {
         
                Conexion.InitializeCompany(bd_sap);
                Conexion.oCompany.Connect();

                if (Conexion.oCompany.Connected == false)
                {
                    MessageBox.Show("No se pudo conectar a SAP, intente nuevamente... ", "SAP", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    // MessageBox.Show("Se conecto a SAP");

                }
                extracto = (BankPages)Conexion.oCompany.GetBusinessObject(BoObjectTypes.oBankPages);
                extracto.AccountCode = txt_cuenta.Text;
                extracto.StatementNumber = Convert.ToInt32(txt_num_estado.Text);

                try
                {
                    foreach (DataGridViewRow row in dgv_extracto.Rows)
                    {

                        int posicion = Convert.ToInt32(row.Index) + 2;
                        //if (Convert.ToDouble(row.Cells[MontoCredito].Value) < 0)
                        //{
                        //    extracto.CreditAmount = 0;
                        //    extracto.DebitAmount = Convert.ToDouble(row.Cells[MontoCredito].Value) * -1;
                        //    extracto.DueDate = Convert.ToDateTime(row.Cells[FechaOperacion].Value);
                        //    extracto.Reference = Convert.ToString(row.Cells[Referencia].Value);
                        //    extracto.Memo = Convert.ToString(row.Cells[InfoDetallada].Value);

                        //    if (extracto.Add() == 0)
                        //    {
                        //        string docEntry = Conexion.oCompany.GetNewObjectKey();

                        //    }
                        //    else
                        //    {
                        //        int rpta = 0;
                        //        string msj = "";
                        //        Conexion.oCompany.GetLastError(out rpta, out msj);
                        //        util.mensaje(rpta + " " + msj, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                        //        return;
                        //    }
                        //}

                        //if (Convert.ToDouble(row.Cells[MontoDebito].Value) > 0)
                        //{
                        extracto.DebitAmount = Convert.ToDouble(row.Cells[MontoDebito].Value); ;
                        extracto.CreditAmount = Convert.ToDouble(row.Cells[MontoCredito].Value);
                        extracto.DueDate = Convert.ToDateTime(row.Cells[FechaOperacion].Value);
                        extracto.Reference = Convert.ToString(row.Cells[Referencia].Value);
                        extracto.Memo = Convert.ToString(row.Cells[InfoDetallada].Value);

                        if (extracto.Add() == 0)
                        {
                            string docEntry = Conexion.oCompany.GetNewObjectKey();

                        }
                        else
                        {
                            int rpta = 0;
                            string msj = "";
                            Conexion.oCompany.GetLastError(out rpta, out msj);
                            MessageBox.Show(rpta + " " + msj + " fila Nº :" + posicion);
                          //  util.mensaje(rpta + " " + msj, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                            return;
                        }
                        //}



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                  //  util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    return;
                }

                int resultado = Negocio.actualizar_correlativo(txt_CodigoBanco.Text, Convert.ToInt32(txt_correlativo.Text));
                if (resultado == 0) Negocio = null;

             


            }
            #endregion

            #region Eliminar
            if (operacion == "Eliminar")
            {
                if (txt_num_estado.Text == string.Empty)
                {
                    MessageBox.Show("El campo " + lbl_num_estado.Text + " no debe estar vacio; indique un valor para ");
                 //   util.mensaje("El campo " + lbl_num_estado.Text + " no debe estar vacio; indique un valor para " + lbl_num_estado.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    txt_cuenta.Focus();
                    return;

                }

                try
                {
                    conexion_sap();
                    extracto = (BankPages)Conexion.oCompany.GetBusinessObject(BoObjectTypes.oBankPages);


                    foreach (DataGridViewRow row in dgv_extracto.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["seleccion"].Value))
                        {

                            id = Convert.ToInt32(row.Cells["Id"].Value);
                            cuenta = Convert.ToString(row.Cells["Cuenta"].Value);
                            extracto.GetByKey(cuenta, id);

                            if (extracto.Remove() == 0)
                            {
                                //string docEntry = Conexion.oCompany.GetNewObjectKey();
                            }
                            else
                            {
                                int rpta = 0;
                                string msj = "";
                                Conexion.oCompany.GetLastError(out rpta, out msj);
                                MessageBox.Show(rpta + " " + msj);
                                //util.mensaje(rpta + " " + msj, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                                return;
                            }
                        }
                    }


                    //dgv_extracto.DataSource = AccesoLogica.listar_extractos(txt_cuenta.Text, 0, Convert.ToInt32(txt_num_estado.Text));
                    //formatear_grilla(dgv_extracto);
                    //chk_todos.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    return;
                }

            }
            #endregion

            Action a = () =>
            {
                Ejecucion = false;
                espera.Close();


            };

            espera.Invoke(a);
                    
          
        }

        #endregion

        #region Eventos

        private void FrmExtractoBancario_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(247, 247, 247);
            lb_hoja.BackColor = Color.FromArgb(247, 247, 247);

            operacion = "Nuevo";
            dgv_extracto.RowHeadersVisible = false;

            txt_banco.BackColor = Color.FromArgb(231, 231, 231);
            txt_cuenta.BackColor = Color.FromArgb(231, 231, 231);
            txt_num_estado.BackColor = Color.FromArgb(231, 231, 231);
        }

        private void t_msg_Tick(object sender, EventArgs e)
        {
            lbl_msg.Text = string.Empty;
            ss_load.BackColor = Color.Transparent;
            lbl_contador_registros.Visible = true;
            lbl_msg.Visible = false;
        }

        private void txt_dni_Enter(object sender, EventArgs e)
        {
            btn_opciones.Visible = true;
            txt_cuenta.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txt_cuenta.Text))
            {
                txt_cuenta.SelectionStart = 0;
                txt_cuenta.SelectionLength = txt_cuenta.Text.Length;
            }
        }

        private void txt_cuenta_Leave(object sender, EventArgs e)
        {
          //  btn_opciones.Visible = false;
            txt_cuenta.BackColor = Color.White;
        }

        private void dgv_extracto_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          // ColMonto = dgv_extracto.Columns[e.ColumnIndex].HeaderText;
         

           //if (lb_columnas.Items.Contains(ColMonto))
           //{

           //    util.mensaje("La columna " + ColMonto + " ya ha sido seleccionada", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
           //}
           //else
           //{
           //    lb_columnas.Items.Add(ColMonto);
           //}

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_hoja.Text= lb_hoja.SelectedItem.ToString();
            LLenarGrid(txt_archivo.Text, txt_hoja.Text); //se manda a llamar al metod
            formatear_grilla(dgv_extracto);
            
            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
            btn_grabar.Enabled = true;
        }
        
        private void txt_banco_Enter(object sender, EventArgs e)
        {
            btn_opciones_b.Visible = true;
            txt_banco.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txt_banco.Text))
            {
                txt_banco.SelectionStart = 0;
                txt_banco.SelectionLength = txt_banco.Text.Length;
            }
        }

        private void txt_banco_Leave(object sender, EventArgs e)
        {
            txt_banco.BackColor = Color.White;
        }
        
        #endregion

        #region Botones

        private void btn_opciones_Click(object sender, EventArgs e)
        {
            FrmOpciones opciones = new FrmOpciones();
            opciones.titulo = "Lista de Cuentas";
            opciones.ShowDialog(this);
        }

        private void btn_opciones_b_Click(object sender, EventArgs e)
        {
            FrmOpciones opciones = new FrmOpciones();
            opciones.titulo = "Lista de bancos";
            opciones.ShowDialog(this);
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            //#region Conexion SAP

            //util.ConexionSap(bd_sap);

            //#endregion
           

            // Environment.Exit(0);


            #region asignar columnas


            foreach (DataGridViewRow row in dgv_columnas.Rows)
            {
                if (Convert.ToString(row.Cells["Tipo"].Value) == "MontoCredito")
                {

                    MontoCredito = Convert.ToString(row.Cells["Descripcion"].Value);

                }

                if (Convert.ToString(row.Cells["Tipo"].Value) == "MontoDebito")
                {

                    MontoDebito = Convert.ToString(row.Cells["Descripcion"].Value);

                }

                if (Convert.ToString(row.Cells["Tipo"].Value) == "FechaOperacion")
                {

                    FechaOperacion = Convert.ToString(row.Cells["Descripcion"].Value);

                }

                if (Convert.ToString(row.Cells["Tipo"].Value) == "Referencia")
                {

                    Referencia = Convert.ToString(row.Cells["Descripcion"].Value);

                }

                if (Convert.ToString(row.Cells["Tipo"].Value) == "InfoDetallada")
                {

                    InfoDetallada = Convert.ToString(row.Cells["Descripcion"].Value);

                }


            }
            #endregion

            #region validaciones

            if (operacion == "Nuevo")
            {
                if (txt_cuenta.Text == string.Empty)
                {
                    util.mensaje("El campo " + lbl_cuenta.Text + " no debe estar vacio; indique un valor para " + lbl_cuenta.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    txt_cuenta.Focus();
                    return;

                }

                if (txt_CodigoBanco.Text == string.Empty)
                {
                    util.mensaje("El campo " + lbl_banco.Text + " no debe estar vacio; indique un valor para " + lbl_banco.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    txt_CodigoBanco.Focus();
                    return;
                }

                if (txt_num_estado.Text == string.Empty)
                {
                    util.mensaje("El campo " + lbl_num_estado.Text + " no debe estar vacio; indique un valor para " + lbl_num_estado.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    txt_cuenta.Focus();
                    return;

                }

                foreach (DataGridViewRow row in dgv_extracto.Rows)
                {
                    int posicion = Convert.ToInt32(row.Index) + 2;

                   


                    if (row.Cells[MontoCredito].Value == DBNull.Value)
                    {
                        util.mensaje("Existen valores vacios en la columna " + MontoCredito, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                        return;
                    }

                    string abono = row.Cells[MontoCredito].Value.ToString();

                    if (!util.EsNumero(abono))
                    {
                        util.mensaje("No es un monto valido en la fila: " + posicion + " de la columna " + MontoCredito, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);


                        return;
                    }


                    if (row.Cells[MontoDebito].Value == DBNull.Value)
                    {
                        util.mensaje("Existen valores vacios en la columna " + MontoDebito, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                        return;
                    }

                    string cargo = row.Cells[MontoDebito].Value.ToString();

                    if (!util.EsNumero(cargo))
                    {
                        util.mensaje("No es un monto valido en la fila: " + posicion + " de la columna " + MontoDebito, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                        return;
                    }


                    if (row.Cells[FechaOperacion].Value == DBNull.Value)
                    {
                        util.mensaje("Existen valores vacios en la columna " + FechaOperacion, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                        return;
                    }

                    string valCelda = row.Cells[FechaOperacion].Value.ToString();


                    if (!util.EsFecha(valCelda))
                    {
                        util.mensaje("No es un monto valido en la fila: " + posicion + " de la columna " + FechaOperacion, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                        return;
                    }

                }
            }
            #endregion

            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
            btn_grabar.Enabled = false;

            Thread tr = new Thread(Accion);
            tr.Start();
            //Es necesario lanzar el formMesaje como ShowDialog
            Ejecucion = true;

            //Evita que mientras se está ejecutando el thread se cierre el formulario
            espera.FormClosing += (o, p) =>
            {
                p.Cancel = Ejecucion;
            };

            espera.ShowDialog();

            MessageBox.Show("La Operacion finalizo con exito " + lbl_contador_registros.Text +  " procesados");

            //util.mensaje("La Operacion finalizo con exito", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);

            Conexion.oCompany.Disconnect();
        
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

                txt_cuenta.Enabled = false;
                txt_banco.Enabled = false;

              

            }

            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Importar maestro", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            FrmConfiguracion conf = new FrmConfiguracion();
            conf.titulo_ = "Lista de bancos";
            conf.CodigoBanco = txt_CodigoBanco.Text;
            conf.Banco = txt_banco.Text;
            conf.ShowDialog(this);
        }

        private void btn_eliminar_b_Click(object sender, EventArgs e)
        {
            operacion = "Eliminar";

            txt_cuenta.Enabled = true;
            txt_cuenta.ReadOnly = false;
            txt_cuenta.Focus();

            btn_nuevo_b.Enabled = false;
            btn_eliminar_b.Enabled = false;

    
            txt_num_estado.Enabled = true;
            txt_num_estado.ReadOnly = false;
            txt_num_estado.BackColor = Color.White;
            txt_cuenta.ReadOnly = false;

            txt_banco.Enabled = true;
            txt_banco.ReadOnly = true;
        }

        private void btn_nuevo_b_Click(object sender, EventArgs e)
        {
            limpiar();

            btn_nuevo_b.Enabled = false;
            btn_eliminar_b.Enabled = false;

            txt_cuenta.Enabled = true;
            txt_banco.Enabled = true;

            txt_banco.ReadOnly = false;
            txt_cuenta.ReadOnly = false;

            txt_cuenta.Focus();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar();

            
        }

        #endregion

      

        private void txt_num_estado_Leave(object sender, EventArgs e)
        {
            dgv_extracto.DataSource = AccesoLogica.listar_extractos(txt_cuenta.Text, 0, Convert.ToInt32(txt_num_estado.Text));
            formatear_grilla(dgv_extracto);
            chk_todos.Visible = true;
        }

        private void dgv_extracto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            try
            {
                if (dgv_extracto.Columns[e.ColumnIndex].Name == "seleccion")
                {
                    DataGridViewRow row = dgv_extracto.Rows[e.RowIndex];
                    DataGridViewCheckBoxCell cellSelecion = row.Cells["seleccion"] as DataGridViewCheckBoxCell;

                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                        btn_grabar.Enabled = true;

                        row.DefaultCellStyle.BackColor = Color.FromArgb(252, 221, 130);
                        contador = contador + 1;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(231, 231, 231);
                        contador = contador - 1;

                        if (contador == 0)
                        {
                            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                            btn_grabar.Enabled = false;
                        }
                    }
                }
            }
            catch
            { 
            
            }
        }

        private void dgv_extracto_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_extracto.IsCurrentCellDirty)
            {
                dgv_extracto.CommitEdit(DataGridViewDataErrorContexts.Commit);

            }
        }

        private void chk_todos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_todos.Checked)
                {

                    foreach (DataGridViewRow row in dgv_extracto.Rows)
                    {
                        row.Cells[0].Value = true;
                        row.DefaultCellStyle.BackColor = Color.FromArgb(252, 221, 130);
                        btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                        btn_grabar.Enabled = true;

                    }
                }

                else
                {
                    foreach (DataGridViewRow row in dgv_extracto.Rows)
                    {
                        row.Cells[0].Value = false;
                        row.DefaultCellStyle.BackColor = Color.FromArgb(231, 231, 231);
                        btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                        btn_grabar.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Fabricación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        private void txt_num_estado_KeyPress(object sender, KeyPressEventArgs e)
        {
          util.validar_numeros(txt_num_estado,e);
        }

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {

        }

    

      

       
    }
}
