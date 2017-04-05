using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;
using System.Reflection;
using System.Drawing.Drawing2D;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;


namespace MISAP
{
    public partial class FrmMenu : Form, IForm_login
    {
        #region variables globales
        public string _usuario,_perfil_cod,_perfil_desc,_bd,_version, bd_sap, ip, dni;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        #region variables publicas
        string contador_fabricacion, contador_insp_1, contador_granallado, contador_pintado, contador_insp_2, contador_despacho;
          
       

        string menu_id, visible;

        private Point pos = Point.Empty;
        private bool move = false;
        private System.Reflection.Assembly Ensamblado;

        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();
      
        ToolStripMenuItem menuid;
        DataTable dtMenus;
        #endregion
        
        #region Eventos

        public FrmMenu()
        {
            InitializeComponent();
          menu_principal.Renderer = new MyRenderer();
          ts_barra.Renderer = new MyRenderer();

          timer1.Tick += new EventHandler(timer1_Tick);
          timer1 = new Timer();
          timer1.Interval = 1000;

        }
        private void Menu_Load(object sender, EventArgs e)
        {

            if (!timer1.Enabled)
                timer1.Start();
            else
                timer1.Stop();
            personalizar_formulario();

           
         
  
        }
        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            AccesoLogica Negocio = new AccesoLogica();

            if (l_usuario.Text != string.Empty)
            {
                int id_session = Convert.ToInt32(AccesoLogica.obtener_id_session(l_usuario.Text).Rows[0][0]);


                string hfin = DateTime.Now.ToLongTimeString();
                string strHostName = string.Empty;
                strHostName = Dns.GetHostName();


                IPAddress[] hostIPs = Dns.GetHostAddresses(strHostName);
                for (int i = 0; i < hostIPs.Length; i++) { txt_ip.Text = hostIPs[i].ToString(); }

                int resultado_log = Negocio.insertar_log_session(l_usuario.Text, Environment.MachineName, DateTime.Now.ToString("yyyy-MM-dd HH:mm"), txt_ip.Text, Environment.UserName, SystemInformation.UserDomainName, "0", "", hfin, id_session);
            }

        }
        private void FrmMenu_Activated(object sender, EventArgs e)
        {
           
           
            if (lbl_load.Text == "0")
            {
                lbl_load.Text = "1";
                Login Login = new Login();
                Login.ShowDialog(this);

            
            }

        }
        void timer1_Tick(object sender, EventArgs e)
        {
           lbl_reloj.Text = DateTime.Now.ToLongDateString();
        }
        private void t_reloj_Tick(object sender, EventArgs e)
        {
            lbl_reloj.Text = DateTime.Now.ToString("dd-MM-yyyy")  +  "\n" + DateTime.Now.ToShortTimeString();
        }

        #endregion
       
        #region funciones

        void validar_permisos(ToolStripItem menu_id, Boolean Visible)
        {
            //menu_id.Visible = false;

            //if (l_perfil_cod.Text == "001")
            //{
            //    tsb_costos.Visible = true;
            //    tsb_empleados.Visible = true;
            //    tsb_asientos_planillas.Visible = true;

            //}
           
      
      

        }
        void personalizar_formulario()
        {
            
            //CAMBIA COLOR DE FONDO MDI
            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.FromArgb(252, 252, 252);
                    break;
                }
            }

            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            ts_barra.BackColor = Color.FromArgb(253, 253, 253);
            this.BackColor = Color.FromArgb(252, 252, 252);
            ss_menu.BackColor = Color.FromArgb(231, 231, 231);
            menu_principal.BackColor = Color.FromArgb(250, 250, 250);
          
  }
             
        #endregion
        
        #region Formulario
        private void salir_Click(object sender, EventArgs e)
        {
            AccesoLogica Negocio = new AccesoLogica();

            int id_session = Convert.ToInt32(AccesoLogica.obtener_id_session(l_usuario.Text).Rows[0][0]);


            string hfin = DateTime.Now.ToLongTimeString();
            string strHostName = string.Empty;
            strHostName = Dns.GetHostName();


            IPAddress[] hostIPs = Dns.GetHostAddresses(strHostName);
            for (int i = 0; i < hostIPs.Length; i++) { txt_ip.Text = hostIPs[i].ToString(); }

            int resultado_log = Negocio.insertar_log_session(l_usuario.Text, Environment.MachineName, DateTime.Now.ToString("yyyy-MM-dd HH:mm"), txt_ip.Text, Environment.UserName, SystemInformation.UserDomainName, "0", "", hfin, id_session);


          

            Close();
        }


        private void ninimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizar_Click(object sender, EventArgs e)
        {

            this.WindowState = (this.WindowState == FormWindowState.Maximized ?

                  FormWindowState.Normal :
                  FormWindowState.Maximized);

            if (this.WindowState == FormWindowState.Maximized)
            {
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));


            }

            if (this.WindowState == FormWindowState.Normal)
            {

                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
            }

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

        }
    
        private void title_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Maximized ?
         FormWindowState.Normal :
         FormWindowState.Maximized);
        }
        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); 
            
            //pos = new Point(e.X, e.Y);
            //move = true;
        }
        private void title_MouseMove(object sender, MouseEventArgs e)
        {

        }
        #endregion

        #region Form Externo

        public void pasar_credenciales(string usuario, string perfil_cod, string perfil_des, string bd_externa, string version, string dni, string ip)
        {
            try
            {
                lbl_ambiente.Text = usuario +"\n" + bd_externa;
                lbl_ambiente.Visible = true;
                l_usuario.Text = usuario;
                l_perfil_cod.Text = perfil_cod;
                l_perfil_desc.Text = perfil_des;
                l_dni.Text = dni;
                l_ip.Text = ip;
                lbl_bd_externa.Text = bd_externa;
                lbl_bd.Text = "MISAP";
                lbl_version.Text = version;
                ss_menu.Visible = true;

                //Ensamblado = System.Reflection.Assembly.GetExecutingAssembly();
                //this.menu_principal.Items.Clear();
                //this.CargarMenus(l_perfil_cod.Text);
            
}
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Orden de Producción", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        #endregion

        #region perzonalizacion de controles
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() :
                base(new Utilidades.MyColors()) { }
        }

    
       
        #endregion

        #region Botones
       
        #endregion



        
        #region Menu

        //ARCHIVO
        private void tsi_relanzarUsuario_Click(object sender, EventArgs e)
        {
        
            string usuario_ = Convert.ToString(AccesoLogica.obtener_usuario(l_usuario.Text).Rows[0][0]);
            string password_ = Convert.ToString(AccesoLogica.obtener_usuario(l_usuario.Text).Rows[0][1]);
            string perfil_cod = Convert.ToString(AccesoLogica.obtener_usuario(l_usuario.Text).Rows[0][2]);
            string perfil_des = Convert.ToString(AccesoLogica.obtener_usuario(l_usuario.Text).Rows[0][3]);

            l_usuario.Text = usuario_;
            l_perfil_cod.Text = perfil_cod;
            l_perfil_desc.Text = perfil_des;
        }
        private void id_55_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog(this);
        }
       
        private void id_25_Click(object sender, EventArgs e)
        {
            FrmReportesLegales pdt = new FrmReportesLegales();
            pdt.MdiParent = this;
            pdt.usuario = l_usuario.Text;
            pdt.perfil = l_perfil_cod.Text;
            pdt.Show();
        }
       
        private void id_4_Click(object sender, EventArgs e)
        {
            if (l_perfil_cod.Text == "001")
            {

                FrmMUsuario usuario = new FrmMUsuario();
                // usuario.MdiParent = this;
                usuario.usuario = l_usuario.Text;
                usuario.perfil = l_perfil_cod.Text;
                usuario.Show();
            }
            else
            {
                MessageBox.Show("No cuenta con acceso", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }

           
        }

        private void id_8_Click(object sender, EventArgs e)
        {
            if (l_perfil_cod.Text == "009" || l_perfil_cod.Text == "001")
            {

                FrmAsientosContables asientos = new FrmAsientosContables();
                // asientos.MdiParent = this;
                asientos.usuario = l_usuario.Text;
                asientos.perfil = l_perfil_cod.Text;
                asientos.Show();
            }
            else
            {
                MessageBox.Show("No cuenta con acceso", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            
         
        }

        private void id_9_Click(object sender, EventArgs e)
        {
            FrmPlantillaPosiciones posiciones = new FrmPlantillaPosiciones();
            //posiciones.MdiParent = this;
            posiciones.usuario = l_usuario.Text;
            posiciones.perfil = l_perfil_cod.Text;
            posiciones.Show();
        }

        private void id_12_Click(object sender, EventArgs e)
        {
            FrmClave clave = new FrmClave();
            clave.MdiParent = this;
            clave.formulario = "FrmMenu";
            clave.titulo = "Modificar clave de acceso";
            clave.usuario = l_usuario.Text;
            clave.Show();
        }

        private void id_14_Click(object sender, EventArgs e)
        {
            FrmPedidos pedidos = new FrmPedidos();
            //posiciones.MdiParent = this;
            pedidos.usuario = l_usuario.Text;
            pedidos.perfil = l_perfil_cod.Text;
            pedidos.bd_sap = lbl_bd_externa.Text;
            pedidos.Show();
        }

        private void id_16_Click(object sender, EventArgs e)
        {
            FrmPlantillas plantillas = new FrmPlantillas();
            plantillas.MdiParent = this;
            plantillas.usuario = l_usuario.Text;
            plantillas.perfil = l_perfil_cod.Text;
            plantillas.Show();
        }
       
        //VENTANA
        private void tsi_menu_principal_Click(object sender, EventArgs e)
        {
            FrmMenuFlotante menuf = new FrmMenuFlotante();
            menuf.MdiParent = this;
            menuf.usuario = l_usuario.Text;
            menuf.perfil = l_perfil_cod.Text;
            menuf.Show();
        }
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        
        #endregion

        private void tsb_requerimientos_Click(object sender, EventArgs e)
        {
            FrmPedidos pedidos = new FrmPedidos();
            //posiciones.MdiParent = this;
            pedidos.usuario = l_usuario.Text;
            pedidos.perfil = l_perfil_cod.Text;
            pedidos.bd_sap = lbl_bd_externa.Text;
            pedidos.Show();
        }

        private void id_18_Click(object sender, EventArgs e)
        {
            FrmInformeSegReq segped = new FrmInformeSegReq();
            //posiciones.MdiParent = this;
            segped.usuario = l_usuario.Text;
            segped.perfil = l_perfil_cod.Text;
            segped.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmInformeSegReq segped = new FrmInformeSegReq();
            //posiciones.MdiParent = this;
            segped.usuario = l_usuario.Text;
            segped.perfil = l_perfil_cod.Text;
            segped.Show();
        }

        private void id_19_Click(object sender, EventArgs e)
        {
            if (l_perfil_cod.Text == "009" || l_perfil_cod.Text == "001")
            {

                FrmEmpleados empleados = new FrmEmpleados();
                empleados.MdiParent = this;
                empleados.usuario = l_usuario.Text;
                empleados.perfil = l_perfil_cod.Text;
                empleados.Show();
            }
            else
            {
                MessageBox.Show("No cuenta con acceso", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {


            if (l_perfil_cod.Text == "009" || l_perfil_cod.Text == "001")
            {

                FrmEmpleados empleados = new FrmEmpleados();
                empleados.MdiParent = this;
                empleados.usuario = l_usuario.Text;
                empleados.perfil = l_perfil_cod.Text;
                empleados.Show();
            }
            else
            {
                MessageBox.Show("No cuenta con acceso", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (l_perfil_cod.Text == "009" || l_perfil_cod.Text == "001")
            {

                FrmAsientosContables asientos = new FrmAsientosContables();
                // asientos.MdiParent = this;
                asientos.usuario = l_usuario.Text;
                asientos.perfil = l_perfil_cod.Text;
                asientos.Show();
            }
            else
            {
                MessageBox.Show("No cuenta con acceso", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
        }

        private void menu_principal_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Maximized ?

                FormWindowState.Normal :
                FormWindowState.Maximized);

            if (this.WindowState == FormWindowState.Maximized)
            {
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));


            }

            if (this.WindowState == FormWindowState.Normal)
            {

                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tsb_portal_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "\\\\10.0.0.20\\Documentacion\\index.html";
            proc.Start();
            proc.Close();


            //FrmPortalSIG portal = new FrmPortalSIG();
            ////portal.MdiParent = this;
            ////portal.usuario = l_usuario.Text;
            ////portal.perfil = l_perfil_cod.Text;
            //portal.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmClave clave = new FrmClave();
            clave.MdiParent = this;
            clave.formulario = "FrmMenu";
            clave.titulo = "Modificar clave de acceso";
            clave.usuario = l_usuario.Text;
            clave.Show();
        }

   
        private void tsb_anexos_Click(object sender, EventArgs e)
        {
            FrmAnexo anexo = new FrmAnexo();
            //anexo.MdiParent = this;
            anexo.usuario = l_usuario.Text;
            anexo.Show();
        }

        private void tsb_ot_Click(object sender, EventArgs e)
        {
            FrmEquivalencias equivalencia = new FrmEquivalencias();
            //anexo.MdiParent = this;
            equivalencia.usuario = l_usuario.Text;
            equivalencia.Show();
        }

        private void tsb_seg_Click(object sender, EventArgs e)
        {
            FrmReporteStockTotal stock = new FrmReporteStockTotal();
            stock.MdiParent = this;
           // stock.usuario = l_usuario.Text;
        //    stock.perfil = l_perfil_cod.Text;
            stock.Show();
        }

        private void tsb_facturas_Click(object sender, EventArgs e)
        {
            FrmProvision facturas = new FrmProvision();
            facturas.MdiParent = this;
            facturas.usuario = l_usuario.Text;
            facturas.perfil = l_perfil_cod.Text;
            facturas.Show();
        }

        private void pCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (l_perfil_cod.Text == "001")
            {

                FrmPCA PCA = new FrmPCA();
                PCA.MdiParent = this;
                PCA.usuario = l_usuario.Text;
                PCA.perfil = l_perfil_cod.Text;
                PCA.Show();
            }
            else
            {
                MessageBox.Show("No cuenta con acceso", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
        }

        private void tsb_cheques_Click(object sender, EventArgs e)
        {
            FrmCheques cheque = new FrmCheques();
            cheque.MdiParent = this;
            cheque.usuario = l_usuario.Text;
            cheque.perfil = l_perfil_cod.Text;
            cheque.Show();
        }

        private void tsb_pca_Click(object sender, EventArgs e)
        {
            if (l_perfil_cod.Text == "001")
            {

                FrmPCA PCA = new FrmPCA();
                PCA.MdiParent = this;
                PCA.usuario = l_usuario.Text;
                PCA.perfil = l_perfil_cod.Text;
                PCA.Show();
            }
            else
            {
                MessageBox.Show("No cuenta con acceso", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }

           
        }

        private void tsb_sae_Click(object sender, EventArgs e)
        {
            FrmSolicitudAlta sae = new FrmSolicitudAlta();
            sae.MdiParent = this;
            sae.usuario = l_usuario.Text;
            sae.perfil = l_perfil_cod.Text;
            sae.Show();
        }

        private void id_30_Click(object sender, EventArgs e)
        {
            FrmExtractoBancario eb = new FrmExtractoBancario();
            //sae.MdiParent = this;
            eb.bd_sap = lbl_bd_externa.Text;
            eb.usuario = l_usuario.Text;
            eb.perfil = l_perfil_cod.Text;
            eb.Show();
        }

        private void btn_asistencia_Click(object sender, EventArgs e)
        {
          
        }

        private void tsb_marcador_Click(object sender, EventArgs e)
        {
            int resultado_c = Negocio.insertar_marcacion(l_dni.Text, l_usuario.Text,l_ip.Text);
            if (resultado_c == 0) Negocio = null;

            MessageBox.Show("La hora de marcacion fue : " + DateTime.Now.ToString("yyyy-MM-dd hh:mm"));
        }

        private void tsb_IMERP_Click(object sender, EventArgs e)
        {
            //FrmIMERP IMERP = new FrmIMERP();
            ////IMERP.MdiParent = this;
            ////portal.usuario = l_usuario.Text;
            ////portal.perfil = l_perfil_cod.Text;
            //IMERP.Show();
        }

        private void id_32_Click(object sender, EventArgs e)
        {
            if (l_perfil_cod.Text == "001")
            {

                FrmAvanceProyecto ap = new FrmAvanceProyecto();
                ap.usuario = l_usuario.Text;
                ap.perfil = l_perfil_cod.Text;
                ap.Show();
            }
            else
            {

                MessageBox.Show("No cuenta con acceso", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }

           
        }

        private void ts_seg_saldo_Click(object sender, EventArgs e)
        {
            FrmSeguimientoSaldos segsal = new FrmSeguimientoSaldos();
            //posiciones.MdiParent = this;
            segsal.usuario = l_usuario.Text;
            segsal.perfil = l_perfil_cod.Text;
            segsal.Show();
        }

        private void tsb_costos_Click(object sender, EventArgs e)
        {
            if (l_perfil_cod.Text == "001" || l_perfil_cod.Text == "008")
            {

                FrmCostos costos = new FrmCostos();
                //posiciones.MdiParent = this;
                costos.usuario = l_usuario.Text;
                costos.perfil = l_perfil_cod.Text;
                costos.Show();
            }
            else
            {

                MessageBox.Show("No cuenta con acceso", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
         
        }

        private void solicitudDeAltaDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSolicitudAlta sae = new FrmSolicitudAlta();
            sae.MdiParent = this;
            sae.usuario = l_usuario.Text;
            sae.perfil = l_perfil_cod.Text;
            sae.Show();
        }

        private void stockDeMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteStockTotal stock = new FrmReporteStockTotal();
            stock.MdiParent = this;
            // stock.usuario = l_usuario.Text;
            //    stock.perfil = l_perfil_cod.Text;
            stock.Show();
        }

        private void seguimientoDeSaldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSeguimientoSaldos segsal = new FrmSeguimientoSaldos();
            //posiciones.MdiParent = this;
            segsal.usuario = l_usuario.Text;
            segsal.perfil = l_perfil_cod.Text;
            segsal.Show();
        }

        private void costosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (l_perfil_cod.Text == "001" || l_perfil_cod.Text == "008")
            {

                FrmCostos costos = new FrmCostos();
                //posiciones.MdiParent = this;
                costos.usuario = l_usuario.Text;
                costos.perfil = l_perfil_cod.Text;
                costos.Show();
            }
            else
            {

                MessageBox.Show("No cuenta con acceso", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
         
        }

        private void informeDeChequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCheques cheque = new FrmCheques();
            cheque.MdiParent = this;
            cheque.usuario = l_usuario.Text;
            cheque.perfil = l_perfil_cod.Text;
            cheque.Show();
        }

        private void informeDeFacturasDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProvision facturas = new FrmProvision();
            facturas.MdiParent = this;
            facturas.usuario = l_usuario.Text;
            facturas.perfil = l_perfil_cod.Text;
            facturas.Show();
        }

      

        private void equivalenciasDeOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEquivalencias equivalencia = new FrmEquivalencias();
            //anexo.MdiParent = this;
            equivalencia.usuario = l_usuario.Text;
            equivalencia.Show();
        }

        private void portalDocSGIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Maximized ?

              FormWindowState.Normal :
              FormWindowState.Maximized);

            if (this.WindowState == FormWindowState.Maximized)
            {
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));


            }

            if (this.WindowState == FormWindowState.Normal)
            {

                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
            }
        }

        private void marcadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int resultado_c = Negocio.insertar_marcacion(l_dni.Text, l_usuario.Text, l_ip.Text);
            if (resultado_c == 0) Negocio = null;

            MessageBox.Show("La hora de marcacion fue : " + DateTime.Now.ToString("yyyy-MM-dd hh:mm"));
        }

        private void id_10_Click(object sender, EventArgs e)
        {

        }

        private void id_38_Click(object sender, EventArgs e)
        {

        }

        private void id_57_Click(object sender, EventArgs e)
        {
            FrmEstadoOT estadoOT = new FrmEstadoOT();
            //posiciones.MdiParent = this;
            estadoOT.usuario = l_usuario.Text;
            estadoOT.perfil = l_perfil_cod.Text;
            estadoOT.Show();
        }

        private void t_msg_Tick(object sender, EventArgs e)
        {

            lbl_msg.Text = string.Empty;
            ss_menu.BackColor = Color.Transparent;
            lbl_msg.Visible = false;
           
      
        }

        private void id_31_Click(object sender, EventArgs e)
        {

        }

        private void CargarMenus(string perfil)
        {
            dtMenus = new DataTable();
            dtMenus = AccesoLogica.consultar_permisos_mnu(perfil);
         
            foreach (DataRow MenuPadre in dtMenus.Select("parent_id=0", "PosicionMenu ASC"))
            {
                ToolStripItem[] Menu = new ToolStripItem[1];
                Menu[0] = new ToolStripMenuItem();
                Menu[0].ForeColor = Color.FromArgb(250, 250, 250); ;
                Menu[0].Name = MenuPadre["menu_id"].ToString();
                Menu[0].Text = MenuPadre["Name"].ToString();
                Menu[0].Tag = MenuPadre["formulario"].ToString();
                //Menu[0].Image = (Image)MenuPadre["IconoMenu"];
                //Averiguando si tiene Hijos o no
                if (dtMenus.Select("parent_id=" + MenuPadre["menu_id"]).Length == 0)
                {
                    //Sino tiene hijos lo agrego a la barra de menu principal
                    //mnu_Principal.Items.Add((String)MenuPadre["DescripcionMenu"], null, new EventHandler(MenuItemClicked));

                    //---Menu[0].Click += new EventHandler(MenuItemClicked);
                    menu_principal.Items.Add(Menu[0]);
                }
                else
                {
                    //Si tiene hijos llamo a la funcion recursiva y Agrego el Item sin Evento
                    //AgregarMenuHijo(mnu_Principal.Items.Add((String)MenuPadre["DescripcionMenu"]));
                    menu_principal.Items.Add(Menu[0]);
                    AgregarMenuHijo(Menu[0]);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
          //  this.menu_principal.Items.Clear();

            dtMenus = new DataTable();
            dtMenus = AccesoLogica.consultar_permisos_mnu(l_perfil_cod.Text);
          
            foreach (DataRow MenuPadre in dtMenus.Select("parent_id=0", "PosicionMenu ASC"))
            {
                ToolStripItem[] Menu = new ToolStripItem[1];
                Menu[0] = new ToolStripMenuItem();
                Menu[0].ForeColor = Color.White;
                Menu[0].Name = MenuPadre["menu_id"].ToString();
                Menu[0].Text = MenuPadre["Name"].ToString();
                Menu[0].Tag = MenuPadre["formulario"].ToString();
                //Menu[0].Image = (Image)MenuPadre["IconoMenu"];
                //Averiguando si tiene Hijos o no
                if (dtMenus.Select("parent_id=" + MenuPadre["menu_id"]).Length == 0)
                {
                    //Sino tiene hijos lo agrego a la barra de menu principal
                    //mnu_Principal.Items.Add((String)MenuPadre["DescripcionMenu"], null, new EventHandler(MenuItemClicked));
                  
                   Menu[0].Click += new EventHandler(MenuItemClicked);
                    menu_principal.Items.Add(Menu[0]);
                }
                else
                {
                    //Si tiene hijos llamo a la funcion recursiva y Agrego el Item sin Evento
                    //AgregarMenuHijo(mnu_Principal.Items.Add((String)MenuPadre["DescripcionMenu"]));
                    menu_principal.Items.Add(Menu[0]);
                    AgregarMenuHijo(Menu[0]);
                }
            }
        }

        private void AgregarMenuHijo(ToolStripItem MenuItemPadre)
        {
            ToolStripMenuItem MenuPadre = (ToolStripMenuItem)MenuItemPadre;

            //Obtengo el ID del menu Enviado para saber si tiene hijos o no
            //int Id = (int)(dtMenus.Select("DescripcionMenu='" +MenuPadre.Text+"'")[0]["Id_Menu"]);
            string Id = MenuPadre.Name;


            //Averiguando si tiene Hijos o no
            if (dtMenus.Select("parent_id=" + Id).Length == 0)
            {
                //Si No tiene Hijos Solo Agrego el Evento
               //--- MenuPadre.Click += new EventHandler(MenuItemClicked);
            }
            else
            {
                //Si Aun tiene Hijos
                foreach (DataRow Menu in dtMenus.Select("parent_id=" + Id, "PosicionMenu ASC"))
                {
                    ToolStripItem[] NuevoMenu = new ToolStripItem[1];
                    NuevoMenu[0] = new ToolStripMenuItem();
                    NuevoMenu[0].BackColor = Color.WhiteSmoke;
                    NuevoMenu[0].Name = Menu["menu_id"].ToString();
                    NuevoMenu[0].Text = Menu["Name"].ToString();
                    NuevoMenu[0].Tag = Menu["formulario"].ToString();
                    //Averiguo se es un separador
                    if (Menu["Name"].ToString() == "-")
                    {
                        //MenuPadre.DropDownItems.Add((String)Menu["DescripcionMenu"]);
                        MenuPadre.DropDownItems.Add(NuevoMenu[0].Text);
                    }
                    else
                    {
                        
                        //Averiguando si tiene Hijos o no
                        if (dtMenus.Select("parent_id=" + Menu["menu_id"]).Length == 0)
                        {
                            //Sino tiene hijos lo agrego al Menu Padre
                            NuevoMenu[0].Click += new EventHandler(MenuItemClicked);
                            MenuPadre.DropDownItems.Add(NuevoMenu[0]);
                        }
                        else
                        {
                            //Si tiene hijos llamo a la funcion recursiva y Agrego el Item sin Evento
                            MenuPadre.DropDownItems.Add(NuevoMenu[0]);
                            AgregarMenuHijo(NuevoMenu[0]);
                        }
                    }
                }
            }
        }

        private void MenuItemClicked(object sender, EventArgs e)
        {
            // if the sender is a ToolStripMenuItem
            if (sender.GetType() == typeof(ToolStripMenuItem))
            {
                string NombreFormulario = ((ToolStripItem)sender).Tag.ToString();
                Object ObjFrm;
                Type tipo = Ensamblado.GetType(Ensamblado.GetName().Name + "." + NombreFormulario);
             
                if (tipo == null)
                {
                    MessageBox.Show("No se encontró el formulario", "Error de ubicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!this.FormularioEstaAbierto(NombreFormulario))
                    {
                        ObjFrm = Activator.CreateInstance(tipo);
                        Form formulario_ = (Form)ObjFrm;
                        
                        //formulario_.usuario = l_usuario.Text;
                        //formulario_.perfil = l_perfil_cod.Text;
                        formulario_.Show();

                       // Plantilla Formulario = (Plantilla)ObjFrm;
                      //  Formulario.Id_Perfil = l_perfil_cod.Text;
                       // Formulario.MdiParent = this;
                        //Formulario.Show();
                    }
                }
            }
        }

        private Boolean FormularioEstaAbierto(String NombreDelFrm)
        {
            if (this.MdiChildren.Length > 0)
            {
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    //MessageBox.Show(NombreDelFrm.Substring(NombreDelFrm.IndexOf("Frm_"), NombreDelFrm.Length - NombreDelFrm.IndexOf("Frm_")));
                    if (this.MdiChildren[i].Name == NombreDelFrm.Substring(NombreDelFrm.IndexOf("Frm_"), NombreDelFrm.Length - NombreDelFrm.IndexOf("Frm_")))
                    {
                        MessageBox.Show("El formulario solicitado ya se encuentra abierto");
                        return true;
                    }
                }
                return false;
            }
            else
                return false;
        }

        private void id_58_Click(object sender, EventArgs e)
        {
            if (l_perfil_cod.Text == "001")
            {

                FrmActivos servidores = new FrmActivos();
                servidores.usuario = l_usuario.Text;
                servidores.perfil = l_perfil_cod.Text;
                servidores.Show();
            }
            else
            {
                MessageBox.Show("No cuenta con acceso", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
        }

        private void id_59_Click(object sender, EventArgs e)
        {

            FrmMaestroArticulo articulo = new FrmMaestroArticulo();
            articulo.usuario = l_usuario.Text;
            articulo.perfil = l_perfil_cod.Text;
            articulo.bd_sap = lbl_bd_externa.Text;
            #region Conexion SAP

            util.mensaje("Conextando a SAP", true, lbl_contador_registros, lbl_msg, ss_menu, t_msg);

            Conexion.InitializeCompany(lbl_bd_externa.Text);
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

            #endregion
            articulo.Show();
           
         
        }

        private void id_60_Click(object sender, EventArgs e)
        {
                FrmCargarAsistencia asistencia = new FrmCargarAsistencia();
                asistencia.MdiParent = this;
                asistencia.usuario = l_usuario.Text;
                asistencia.Show();
        
        }

     

        private void id_70_Click(object sender, EventArgs e)
        {
            FrmTareosCostos tareos = new FrmTareosCostos();
            tareos.MdiParent = this;
            tareos.usuario = l_usuario.Text;
            tareos.Show();
        }

        private void ts_seg_aceros_Click(object sender, EventArgs e)
        {
            FrmInformeSegAceros segaceros = new FrmInformeSegAceros();
            //posiciones.MdiParent = this;
            segaceros.usuario = l_usuario.Text;
            segaceros.perfil = l_perfil_cod.Text;
            segaceros.Show();
        }

        private void id_71_Click(object sender, EventArgs e)
        {

            FrmDocumentos regdoc = new FrmDocumentos();
            regdoc.usuario = l_usuario.Text;
            regdoc.perfil = l_perfil_cod.Text;
            regdoc.Show();
        }

        private void id_72_Click(object sender, EventArgs e)
        {
            FrmCargoDoc cargo = new FrmCargoDoc();
            cargo.usuario = l_usuario.Text;
            cargo.perfil = l_perfil_cod.Text;
            cargo.Show();
        }

        private void id_80_Click(object sender, EventArgs e)
        {


            FrmEmpleadosCese empleadoscese = new FrmEmpleadosCese();
            empleadoscese.MdiParent = this;
            empleadoscese.usuario = l_usuario.Text;
            empleadoscese.perfil = l_perfil_cod.Text;
            empleadoscese.Show();
         
        }

        private void id_76_Click(object sender, EventArgs e)
        {
            string pass = Convert.ToString(Convert.ToInt32(AccesoLogica.verificar_acceso(l_dni.Text).Rows[0][0]));
            if (pass == "2" || pass == "4")
            {
                FrmTareoAsignacion asignaciontareo = new FrmTareoAsignacion();
                asignaciontareo.usuario = l_usuario.Text;
                asignaciontareo.perfil = l_perfil_cod.Text;
                asignaciontareo.Show();
            }
            else
            {
                MessageBox.Show("No cuenta con acceso", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void id_90_Click(object sender, EventArgs e)
        {
            FrmFichaEquipo asignaciontareo = new FrmFichaEquipo();
            asignaciontareo.usuario = l_usuario.Text;
            asignaciontareo.perfil = l_perfil_cod.Text;
            asignaciontareo.Show();
        }

        private void id_74_Click(object sender, EventArgs e)
        {
            string pass = Convert.ToString(Convert.ToInt32(AccesoLogica.verificar_acceso(l_dni.Text).Rows[0][0]));
          
            if (pass == "1" || pass == "4")
            {
                FrmTareo registrotareo = new FrmTareo();
                registrotareo.usuario = l_usuario.Text;
                registrotareo.perfil = l_perfil_cod.Text;
                registrotareo.Show();
            }
            else
            {
                MessageBox.Show("No cuenta con acceso", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            
        }

        private void id_75_Click(object sender, EventArgs e)
        {
            string pass = Convert.ToString(Convert.ToInt32(AccesoLogica.verificar_acceso(l_dni.Text).Rows[0][0]));
            if (pass == "2" || pass == "3" || pass == "4")
            {
                FrmTareoControl controltareo = new FrmTareoControl();
                controltareo.usuario = l_usuario.Text;
                controltareo.perfil = l_perfil_cod.Text;
                controltareo.Show();
            }
            else
            {
                MessageBox.Show("No cuenta con acceso", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void id_78_Click(object sender, EventArgs e)
        {
            string pass = Convert.ToString(Convert.ToInt32(AccesoLogica.verificar_acceso(l_dni.Text).Rows[0][0]));
            if (pass == "1" || pass == "2" || pass == "3" || pass == "4")
            {
            FrmCriteriosSeleccion informetareos = new FrmCriteriosSeleccion();
            informetareos.usuario = l_usuario.Text;
            informetareos.perfil = l_perfil_cod.Text;
            informetareos.titulo_ = "Informe de tareos";
            informetareos.Show();
            }
            else
            {
                MessageBox.Show("No cuenta con acceso", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void id_99_Click(object sender, EventArgs e)
        {
            string pass = Convert.ToString(Convert.ToInt32(AccesoLogica.verificar_acceso(l_dni.Text).Rows[0][0]));
            if (pass == "2" || pass == "4")
            {
                FrmTareo_Importar abrir = new FrmTareo_Importar();
                abrir.tareador = l_dni.Text;
                abrir.Show();
            }
            else
            {
                MessageBox.Show("No cuenta con acceso", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void seguimientoDeTareosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pass = Convert.ToString(Convert.ToInt32(AccesoLogica.verificar_acceso(l_dni.Text).Rows[0][0]));
            if (pass == "2" || pass == "4")
            {
                FrmTareo_Seguimiento abrir = new FrmTareo_Seguimiento();
                abrir.Show();
            }
            else
            {
                MessageBox.Show("No cuenta con acceso", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
           // FrmDocumentos
        }

        private void id_91_Click(object sender, EventArgs e)
        {
            
        }

        private void id_92_Click(object sender, EventArgs e)
        {
            FrmInformeSegContrato ap = new FrmInformeSegContrato();
            ap.usuario = l_usuario.Text;
            ap.perfil = l_perfil_cod.Text;
            ap.Show();
        }

        private void id_95_Click(object sender, EventArgs e)
        {
            FrmContratos contrato = new FrmContratos();
            contrato.usuario = l_usuario.Text; ;
            contrato.perfil = l_perfil_cod.Text;
            contrato.operacion_ = "Nuevo";
            contrato.Show();
        }

        private void id_98_Click(object sender, EventArgs e)
        {
            string pass = Convert.ToString(Convert.ToInt32(AccesoLogica.verificar_acceso(l_dni.Text).Rows[0][0]));
            if (pass == "2" || pass == "4")
            {
                FrmTareo_Configuracion configuracion = new FrmTareo_Configuracion();
                configuracion.usuario = l_usuario.Text;
                configuracion.perfil = l_perfil_cod.Text;
                configuracion.Show();
            }
            else
            {
                MessageBox.Show("No cuenta con acceso", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void id_100_Click(object sender, EventArgs e)
        {
        
            FrmInformeAsistencia asistencia = new FrmInformeAsistencia();
            asistencia.usuario = l_usuario.Text;
            asistencia.perfil = l_perfil_cod.Text;
            asistencia.Show();
        
        }

        private void id_42_Click(object sender, EventArgs e)
        {

            FrmAnexo anexo = new FrmAnexo();
            anexo.usuario = l_usuario.Text;
            anexo.Show();
        }

        private void id_104_Click(object sender, EventArgs e)
        {
            FrmInformeSegCambiosApl ap = new FrmInformeSegCambiosApl();
            ap.usuario = l_usuario.Text;
            ap.perfil = l_perfil_cod.Text;
            ap.Show();
        }

        private void id_105_Click(object sender, EventArgs e)
        {
            FrmInformeInventarioIPs ip = new FrmInformeInventarioIPs();
            ip.usuario = l_usuario.Text;
            ip.perfil = l_perfil_cod.Text;
            ip.Show();
        }

        private void proyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVS_GestionProyectos abrir = new FrmVS_GestionProyectos();
            abrir.usuario = l_usuario.Text;
            abrir.perfil = l_perfil_cod.Text;
            abrir.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVS_GestionUsuarios abrir = new FrmVS_GestionUsuarios();
            abrir.usuario = l_usuario.Text;
            abrir.perfil = l_perfil_cod.Text;
            abrir.Show();
        }

        private void solicitudDeDineroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVS_SeleccionProyecto abrir = new FrmVS_SeleccionProyecto("SD");
            abrir.usuario = l_usuario.Text;
            abrir.perfil = l_perfil_cod.Text;
            abrir.Show();
        }

        private void asignacionDeRendicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVS_SeleccionProyecto abrir = new FrmVS_SeleccionProyecto("GR");
            abrir.usuario = l_usuario.Text;
            abrir.perfil = l_perfil_cod.Text;
            abrir.Show();            
        }

        private void registroDeGastosCajaChicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVS_SeleccionProyecto abrir = new FrmVS_SeleccionProyecto("GC");
            abrir.usuario = l_usuario.Text;
            abrir.perfil = l_perfil_cod.Text;
            abrir.Show();  
        }


     

        #region Barra
       
        #endregion  

    }
}
