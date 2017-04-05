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
using System.Management;

namespace MISAP
{
    public partial class FrmActivos : Form, IForm_Listado
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

         string model_disco;
        double memoria_b = 0;
        Int64 disco_b = 0;

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
        int posicion, columna, IdVm;
      
    
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
                    if (par5 == "Lista de servicios")
                    {
                        txt_Id_Servicio.Text = par1;
                        txt_Servicio.Text = par2;

                        btn_opciones.Visible = false;
                    }

                  
                }
                #endregion

                #region Consultar

                if (operacion == "Consultar")
                {

                    if (par5 == "Lista de Activos")
                    {
                        txt_IdActivo.Text= par1;
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
            operacion = "Consultar";
            txt_NombreVm.Focus();

            dgv_lista.DataSource = AccesoLogica.consultar_OACT("", "Consultar", "Listar");

            dgv_detalle.DataSource = AccesoLogica.consultar_ACT1("");
            formatear_grilla(dgv_detalle);

            if (dgv_lista.Rows.Count != 0)
            {
                posicion = 0;
                dgv_lista.CurrentCell = dgv_lista.Rows[0].Cells[0];
              
            }
            // limpiar(); 


            //carga combo nomedas
            cbo_TipoActivo.DataSource = AccesoLogica.consultar_ACT2(0, "Consultar", "Listar");
            cbo_TipoActivo.DisplayMember = "tipo";
            cbo_TipoActivo.ValueMember = "TipoID";
            cbo_TipoActivo.SelectedItem = null;


            util.FormatearFormulario_sap(this, ts_acciones, tc_detalle, ss_load, tp_listado, tp_auditoria);
            util.Formateardetalle(tp_contenido, tp_anexo);
            this.Location = new System.Drawing.Point(320, 80);

            util.EstablecerAuditoria(operacion, usuario, "", "7090", "S", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

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

                    grilla.Columns["id_servicio"].Visible = false;
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
           
           util.limpiarTextBoxes(this);
           this.txt_IdActivo.Focus();
             
        }
       
       

        private void consultar_navegacion()
        {
            try
            {
                operacion = "Consultar";


                dgv_detalle.DataSource = AccesoLogica.consultar_ACT1(txt_IdActivo.Text);
                formatear_grilla(dgv_detalle);

                
                txt_IdActivo.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["IdActivo"].ToString();
                txt_CodInventario.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["InventarioId"].ToString();
                cbo_ClaseActivo.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["ClaseActivo"].ToString();
                cbo_SubClaseActivo.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["SubClaseActivo"].ToString();
                cbo_TipoActivo.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["TipoActivo"].ToString();

                txt_Marca.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["Marca"].ToString();
                txt_Modelo.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["Modelo"].ToString();
                txt_NroSerie.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["NroSerie"].ToString();

                txt_EstadoId.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["EstadoId"].ToString();
                txt_Estado.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["Estado"].ToString();

                txt_NombreVm.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["NombreVm"].ToString();
                txt_PlacaVm.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["Placa"].ToString();
                txt_ProcesadorVm.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["ProcesadorVm"].ToString();
                txt_MemoriaVm.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["MemoriaVm"].ToString();
                txt_HddVm.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["HddVm"].ToString();
                cbo_cluster.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["Cluster"].ToString();
                txt_RutaVm.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["RutaVm"].ToString();
                txt_RutaVhd.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["RutaVhd"].ToString();

                txt_IPSrv.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["IPSrv"].ToString();          
                txt_NombreSrv.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["NombreSrv"].ToString();
                txt_Placa.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["PlacaVm"].ToString();
                txt_Procesador.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["Procesador"].ToString();
                txt_Memoria.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["Memoria"].ToString();
                txt_HDD.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["HDD"].ToString();
 
                txt_SO.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["SO"].ToString();

                txt_IPSrvPublica.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["IPSrvPublica"].ToString();
                txt_UsuarioAdmin.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["UsuarioAdmin"].ToString();
                txt_PasswordAdmin.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["PasswordAdmin"].ToString();
                txt_UsuarioSa.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["UsuarioSa"].ToString();
                txt_PasswordSa.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["PasswordSa"].ToString();
                txt_Observaciones.Text = AccesoLogica.consultar_OACT(txt_IdActivo.Text, "Consultar", "Consultar").Rows[0]["Observaciones"].ToString();



                btn_grabar.Text = "Actualizar";
                btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                btn_grabar.Enabled = true;
                btn_consultar_b.Enabled = true;
                btn_nuevo_b.Enabled = true;


                #region bloquea textbox

               // util.BloquearTextBoxes(this);

                btn_opciones.Visible = false;
                txt_Servicio.ReadOnly = true;
                txt_Servicio.BackColor = Color.FromArgb(231, 231, 231);

                txt_IdActivo.Enabled = false;
                txt_IdActivo.BackColor = Color.FromArgb(231, 231, 231);

                #endregion

                txt_NombreSrv.Focus();
            }
            catch
            {
                util.mensaje("No existen registros coincidentes", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
        }

        #endregion

        #region Formulario

        public FrmActivos()
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

        private void txt_NombreVm_Enter(object sender, EventArgs e)
        {
            if (operacion == "Nuevo")
            {
               
                    txt_NombreVm.BackColor = Color.FromArgb(254, 240, 158);
                    if (!String.IsNullOrEmpty(txt_NombreVm.Text))
                    {
                        txt_NombreVm.SelectionStart = 0;
                        txt_NombreVm.SelectionLength = txt_NombreVm.Text.Length;
                    }
                
            }
        }

        private void txt_IdActivo_Enter(object sender, EventArgs e)
        {
           

                txt_IdActivo.BackColor = Color.FromArgb(254, 240, 158);
                if (!String.IsNullOrEmpty(txt_IdActivo.Text))
                {
                    txt_IdActivo.SelectionStart = 0;
                    txt_IdActivo.SelectionLength = txt_IdActivo.Text.Length;
                }
           
        }
        
        private void t_msg_Tick(object sender, EventArgs e)
        {
            lbl_msg.Text = string.Empty;
            ss_load.BackColor = Color.Transparent;
            lbl_contador_registros.Visible = true;
            lbl_msg.Visible = false;
        }


        #endregion

        #region Botones

        private void btn_nuevo_b_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            

            util.EstablecerAuditoria(operacion, usuario, "", "FrmServidores", "S", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            posicion = 0;
            limpiar();

            txt_IdActivo.Enabled = true;
            txt_IdActivo.Focus();
            btn_nuevo_b.Enabled = false;
            btn_consultar_b.Enabled = true;
            btn_grabar.Text = "Crear";

      
        }

        private void btn_consultar_b_Click(object sender, EventArgs e)
        {
            operacion = "Consultar";
            limpiar();
            

            btn_nuevo_b.Enabled = true;
            btn_consultar_b.Enabled = false;
            btn_grabar.Text = "Buscar";

         
            btn_opciones.Visible = false;

            txt_IdActivo.Enabled = true;
            txt_IdActivo.Focus();

        }
       
        
        private void btn_opciones_Click(object sender, EventArgs e)
        {
            FrmOpciones opciones = new FrmOpciones();
            opciones.titulo = "Lista de ordenes de trabajo";
          //  opciones.parametro_1 = txt_cod_proyecto.Text;
            opciones.ShowDialog(this);

        }
        
        private void btn_utlimo_Click(object sender, EventArgs e)
        {
            posicion = dgv_lista.Rows.Count - 1;

            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            txt_IdActivo.Text = dgv_lista.CurrentRow.Cells[0].Value.ToString();
            consultar_navegacion();

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (posicion < dgv_lista.Rows.Count - 1)
            {
                posicion = posicion + 1;
            }


            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            txt_IdActivo.Text = dgv_lista.CurrentRow.Cells[0].Value.ToString();
            consultar_navegacion();
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            posicion = 0;

            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            txt_IdActivo.Text = dgv_lista.CurrentRow.Cells[0].Value.ToString();
            consultar_navegacion();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion = posicion - 1;
            }


            dgv_lista.CurrentCell = dgv_lista.Rows[posicion].Cells[0];
            txt_IdActivo.Text = dgv_lista.CurrentRow.Cells[0].Value.ToString();
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

             
               

                if (txt_Servicio.Text == string.Empty)
                {
                    util.mensaje("El campo " + lbl_MemoriaVm.Text + " no debe estar vacio; indique un valor para " + lbl_MemoriaVm.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    txt_Servicio.Focus();
                    return;

                }

                #endregion 
                
                #region validaciones detalle
             
                foreach (DataGridViewRow row in dgv_detalle.Rows)
                {

                  

                    //if (row.Cells["Duracion"].Value == DBNull.Value)
                    //{
                    //    util.mensaje("Existen valores vacios en la columna Duracion ", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    //    return;
                    //}

                  


                }
                #endregion


                try
                {
                    IdVm = Convert.ToInt32(txt_IdActivo.Text);
                 
                        //int resultado = Negocio.mantenimiento_OCAP(PrjCode, PrcCode, CodPresupuesto, CodFase, Fase, FechaInicio, fechafin, Duracion, Avance, Peso, factor,AvanceValorizado, operacion);
                        //if (resultado == 0) Negocio = null;
                 

                    util.mensaje("La Operacion finalizo con exito", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                  
                    dgv_lista.DataSource = AccesoLogica.consultar_OACT("", "Consultar", "Listar");
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

    

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
            if (dgv_detalle.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para exportar", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            util.ExportarDataGridViewExcel(dgv_detalle, tsl_titulo.Text);
        }

        private void txt_IdVm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                if (txt_IdActivo.Text == "*")
                {
                    FrmListado Listado = new FrmListado();
                    Listado.titulo = "Lista de Activos";
                    Listado.ShowDialog(this);
                }
                else
                {
                    consultar_navegacion();
                }
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

      

        private void txt_IdActivo_Leave(object sender, EventArgs e)
        {
            txt_IdActivo.BackColor = Color.White;
        }

        private void btn_busqueda_Click(object sender, EventArgs e)
        {
                      

                try
                {
                    ConnectionOptions options = new ConnectionOptions();
                    options.Username = "eterrones";
                    options.Password = "3_t3rr0n3s";
                    options.Authority = "ntlmdomain:imecon.com";
                    ManagementScope scope = new ManagementScope("\\\\" + txt_IPSrv.Text + "\\root\\cimv2", options);
                    scope.Connect();

                    //Ahora obteniendo info acerca del OS

                    ObjectQuery so = new ObjectQuery("select * from Win32_OperatingSystem");
                    ObjectQuery cpu = new ObjectQuery("select *  FROM   Win32_Processor");
                    ObjectQuery memoria_q = new ObjectQuery("select *  FROM  Win32_PhysicalMemory");
                    ObjectQuery disco_q = new ObjectQuery("select *  FROM   Win32_DiskDrive "); //Win32_LogicalDisk WHERE MediaType = 12
                    ObjectQuery placa_q = new ObjectQuery("select *  FROM    Win32_BaseBoard");
                    ObjectQuery mascara_q = new ObjectQuery("select *  FROM    Win32_NetworkAdapterConfiguration  WHERE IPEnabled = 'True' ");
                    ObjectQuery marca_q = new ObjectQuery("SELECT * FROM Win32_ComputerSystem ");


                    ManagementObjectSearcher wmiSearcher = new ManagementObjectSearcher(scope, so);
                    ManagementObjectSearcher wmiSearcher2 = new ManagementObjectSearcher(scope, cpu);
                    ManagementObjectSearcher wmiSearcher3 = new ManagementObjectSearcher(scope, memoria_q);
                    ManagementObjectSearcher wmiSearcher4 = new ManagementObjectSearcher(scope, disco_q);
                    ManagementObjectSearcher wmiSearcher5 = new ManagementObjectSearcher(scope, placa_q);
                    ManagementObjectSearcher wmiSearcher6 = new ManagementObjectSearcher(scope, mascara_q);
                    ManagementObjectSearcher wmiSearcher7 = new ManagementObjectSearcher(scope, marca_q);
                    

                    ManagementObjectCollection queryWMICollection = wmiSearcher.Get();
                    ManagementObjectCollection queryWMICollection2 = wmiSearcher2.Get();
                    ManagementObjectCollection queryWMICollection3 = wmiSearcher3.Get();
                    ManagementObjectCollection queryWMICollection4 = wmiSearcher4.Get();
                    ManagementObjectCollection queryWMICollection5 = wmiSearcher5.Get();
                    ManagementObjectCollection queryWMICollection6 = wmiSearcher6.Get();
                    ManagementObjectCollection queryWMICollection7 = wmiSearcher7.Get();

                    

                     //Marca del equipo
                    foreach (ManagementObject m in queryWMICollection7)
                    {

                        txt_Marca.Text = Convert.ToString(m["Manufacturer"]);
                        txt_Modelo.Text = Convert.ToString(m["Model"]);
                    }

                    //Nombre del equipo
                    foreach (ManagementObject m in queryWMICollection)
                    {

                        txt_NombreSrv.Text = Convert.ToString(m["CSName"]);
                    }

                    //Procesador
                    foreach (ManagementObject m in queryWMICollection2)
                    {
                        txt_Procesador.Text = Convert.ToString(m["Name"]);
                    }

                    //Memoria
                    foreach (ManagementObject m in queryWMICollection3)
                    {
                        memoria_b = memoria_b + Convert.ToDouble(m["Capacity"]);

                    }

                    string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
                    int i;
                    double memoria = memoria_b;
                    for (i = 0; i < Suffix.Length && memoria_b >= 1024; i++, memoria_b /= 1024)
                    {
                        memoria = memoria_b / 1024.0;
                    }

                    txt_Memoria.Text = String.Format("{0:0.##} {1}", memoria, Suffix[i]);

                    //Disco duro
                    foreach (ManagementObject m in queryWMICollection4)
                    {
                        disco_b = Convert.ToInt64(m["Size"]);
                        model_disco = Convert.ToString(m["Model"]);

                    }

                    string[] Suffix_d = { "B", "KB", "MB", "GB", "TB" };
                    int j;
                    Int64 disco = disco_b;
                    for (j = 0; j < Suffix_d.Length && disco_b >= 1024; j++, Convert.ToInt64(disco_b /= 1024))
                    {
                        disco = Convert.ToInt64(disco_b / 1024.0);
                    }

                    txt_HDD.Text = model_disco + " " + String.Format("{0:0.##} {1}", disco, Suffix_d[j]);


                    //Placa madre
                    foreach (ManagementObject m in queryWMICollection5)
                    {
                        //MessageBox.Show(Convert.ToString(m["Manufacturer"] + " " + m["Product"]));
                        txt_Placa.Text = m["Manufacturer"] + " " + m["Product"];
                    }
                }
                catch (Exception ex)
                {

                    util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    return;
                }


              

               
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
