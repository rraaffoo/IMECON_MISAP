using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;
using System.Data.OleDb;
using System.Security.Principal;
using System.Diagnostics;
using MISAP;
using System.Net;
using System.Net.NetworkInformation;
using System.Configuration;

namespace MISAP
{
    public partial class Login : Form
    {
        public string _base_datos;
     

        public Login()
        {
            InitializeComponent();
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            AccesoLogica Negocio = new AccesoLogica();


            string usuario = Convert.ToString(txt_cdg_usr.Text);
            string password = Convert.ToString(txt_psw_usr.Text);

            #region IMECON

            if (txt_sociedad.Text == "IMECON S.A.")
            {

                try
                {

                    DataTable dtr = AccesoLogica.obtener_usuario(usuario);
                    string usuario_ = Convert.ToString(AccesoLogica.obtener_usuario(usuario).Rows[0][0]);
                    string password_ = Convert.ToString(AccesoLogica.obtener_usuario(usuario).Rows[0][1]);
                    string perfil_cod = Convert.ToString(AccesoLogica.obtener_usuario(usuario).Rows[0][2]);
                    string perfil_des = Convert.ToString(AccesoLogica.obtener_usuario(usuario).Rows[0][3]);
                    string dni = Convert.ToString(AccesoLogica.obtener_usuario(usuario).Rows[0][4]);

                    string hinicio = DateTime.Now.ToLongTimeString();

                    string strHostName = string.Empty;
                    strHostName = Dns.GetHostName();
                    IPAddress[] hostIPs = Dns.GetHostAddresses(strHostName);
                    for (int i = 0; i < hostIPs.Length; i++)
                    {
                        txt_ip.Text = hostIPs[i].ToString();
                    }

                    //Convert.ToString(AccesoLogica.validar_conexion(usuario).Rows[0][0])

                    if (usuario == usuario_ && password == password_)
                    {



                        FrmMenu m = new FrmMenu();
                        m._usuario = usuario;
                        m._perfil_cod = perfil_cod;
                        m._perfil_desc = perfil_des;
                        m._bd = _base_datos;
                        m.bd_sap = txt_bd_externa.Text;
                        m.ip = txt_ip.Text;
                        m.dni = dni;

                        int resultado_log = Negocio.insertar_log_session(usuario, Environment.MachineName, DateTime.Now.ToString("yyyy-MM-dd HH:mm"), txt_ip.Text, Environment.UserName, SystemInformation.UserDomainName, "1", hinicio, "", 0);

                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config.AppSettings.Settings["AMBIENTEMISAP"].Value = txt_ambiente.Text;
                        config.AppSettings.Settings["DestinoDB"].Value = txt_bd_externa.Text;
                        config.Save(ConfigurationSaveMode.Modified);

                        IForm_login flogin = this.Owner as IForm_login;
                        if (flogin != null)
                            flogin.pasar_credenciales(usuario, perfil_cod, perfil_des, txt_bd_externa.Text, "", dni, txt_ip.Text);
                        Close();
                        m.Focus();


                    }
                    else
                    {
                        MessageBox.Show("Ingreso de contraseña no válido, vuelva a intentarlo");
                        txt_cdg_usr.Clear();
                        txt_psw_usr.Clear();
                        txt_cdg_usr.Focus();
                        txt_cdg_usr.BackColor = Color.FromArgb(254, 240, 158);
                        txt_psw_usr.BackColor = Color.White;


                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ud. No cuenta con acceso " + ex, "Login", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                    txt_cdg_usr.Clear();
                    txt_psw_usr.Clear();
                    txt_cdg_usr.Focus();
                    txt_cdg_usr.BackColor = Color.FromArgb(254, 240, 158);
                    txt_psw_usr.BackColor = Color.White;
                }
            }

            #endregion

            #region IMECON SELVA

            if (txt_sociedad.Text == "IMECON SELVA S.A.C.")
            {


                try
                {


                    string usuario_ = Convert.ToString(AccesoLogica.obtener_usuario_is(usuario).Rows[0][0]);
                    string password_ = Convert.ToString(AccesoLogica.obtener_usuario_is(usuario).Rows[0][1]);
                  
                    
                    if (usuario == usuario_ && password == password_)
                    {

                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.FileName = @"\\10.0.0.8\Comun\ISMISAP\Application Files\ISMISAP_1_0_0_1369\ISMISAP.exe";
                        startInfo.Arguments = usuario_ + " " + password_;
                        Process p = Process.Start(startInfo);

                        this.Close();
                        Application.Exit();


                    }
                    else
                    {
                        MessageBox.Show("Ingreso de contraseña no válido, vuelva a intentarlo");
                        txt_cdg_usr.Clear();
                        txt_psw_usr.Clear();
                        txt_cdg_usr.Focus();
                        txt_cdg_usr.BackColor = Color.FromArgb(254, 240, 158);
                        txt_psw_usr.BackColor = Color.White;


                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ud. No cuenta con acceso " + ex, "Login", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                    txt_cdg_usr.Clear();
                    txt_psw_usr.Clear();
                    txt_cdg_usr.Focus();
                    txt_cdg_usr.BackColor = Color.FromArgb(254, 240, 158);
                    txt_psw_usr.BackColor = Color.White;
                }





          
            }

            #endregion

        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void txt_psw_usr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == Convert.ToInt32(Keys.Enter))
            {


                AccesoLogica Negocio = new AccesoLogica();
                string usuario = Convert.ToString(txt_cdg_usr.Text);
                string password = Convert.ToString(txt_psw_usr.Text);

                #region IMECON

                if (txt_sociedad.Text == "IMECON S.A.")
                {



                    try
                    {
                        string usuario_ = Convert.ToString(AccesoLogica.obtener_usuario(usuario).Rows[0][0]);
                        string password_ = Convert.ToString(AccesoLogica.obtener_usuario(usuario).Rows[0][1]);
                        string perfil_cod = Convert.ToString(AccesoLogica.obtener_usuario(usuario).Rows[0][2]);
                        string perfil_des = Convert.ToString(AccesoLogica.obtener_usuario(usuario).Rows[0][3]);
                        string dni = Convert.ToString(AccesoLogica.obtener_usuario(usuario).Rows[0][4]);

                        string hinicio = DateTime.Now.ToLongTimeString();
                        string version = Convert.ToString(Environment.Version);
                        string strHostName = string.Empty;
                        strHostName = Dns.GetHostName();
                        IPAddress[] hostIPs = Dns.GetHostAddresses(strHostName);
                        for (int i = 0; i < hostIPs.Length; i++)
                        {
                            txt_ip.Text = hostIPs[i].ToString();
                        }

                        if (usuario == usuario_ && password == password_)
                        {
                            FrmMenu m = new FrmMenu();
                            m._usuario = usuario;
                            m._perfil_cod = perfil_cod;
                            m._perfil_desc = perfil_des;
                            m._bd = _base_datos;
                            m.bd_sap = txt_bd_externa.Text;
                            m.ip = txt_ip.Text;
                            m.dni = dni;
                            int resultado_log = Negocio.insertar_log_session(usuario, Environment.MachineName, DateTime.Now.ToString("yyyy-MM-dd HH:mm"), txt_ip.Text, Environment.UserName, SystemInformation.UserDomainName, "", hinicio, "", 0);

                            IForm_login flogin = this.Owner as IForm_login;
                            if (flogin != null)
                                flogin.pasar_credenciales(usuario, perfil_cod, perfil_des, txt_bd_externa.Text, version, dni, txt_ip.Text);
                            Close();
                            m.Focus();

                        }
                        else
                        {

                            MessageBox.Show("Ingreso de contraseña no válido, vuelva a intentarlo");
                            txt_cdg_usr.Clear();
                            txt_psw_usr.Clear();
                            txt_cdg_usr.Focus();
                            txt_cdg_usr.BackColor = Color.FromArgb(254, 240, 158);
                            txt_psw_usr.BackColor = Color.White;
                        }
                    }



                    catch (Exception ex)
                    {

                        MessageBox.Show("Ud. No cuenta con acceso " + ex, "Login ", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        txt_cdg_usr.Clear();
                        txt_psw_usr.Clear();
                        txt_cdg_usr.Focus();
                        txt_cdg_usr.BackColor = Color.FromArgb(254, 240, 158);
                        txt_psw_usr.BackColor = Color.White;

                    }

                }
                #endregion


                #region IMECON SELVA

                if (txt_sociedad.Text == "IMECON SELVA S.A.C.")
                {


                    try
                    {


                        string usuario_ = Convert.ToString(AccesoLogica.obtener_usuario_is(usuario).Rows[0][0]);
                        string password_ = Convert.ToString(AccesoLogica.obtener_usuario_is(usuario).Rows[0][1]);


                        if (usuario == usuario_ && password == password_)
                        {

                            ProcessStartInfo startInfo = new ProcessStartInfo();
                            startInfo.FileName = @"\\10.0.0.8\Comun\ISMISAP\Application Files\ISMISAP_1_0_0_1369\ISMISAP.exe";
                            startInfo.Arguments = usuario_ + " " + password_;
                            Process p = Process.Start(startInfo);

                            this.Close();
                            Application.Exit();


                        }
                        else
                        {
                            MessageBox.Show("Ingreso de contraseña no válido, vuelva a intentarlo");
                            txt_cdg_usr.Clear();
                            txt_psw_usr.Clear();
                            txt_cdg_usr.Focus();
                            txt_cdg_usr.BackColor = Color.FromArgb(254, 240, 158);
                            txt_psw_usr.BackColor = Color.White;


                        }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Ud. No cuenta con acceso " + ex, "Login", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        txt_cdg_usr.Clear();
                        txt_psw_usr.Clear();
                        txt_cdg_usr.Focus();
                        txt_cdg_usr.BackColor = Color.FromArgb(254, 240, 158);
                        txt_psw_usr.BackColor = Color.White;
                    }






                }

                #endregion
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
         

            cbo_bd_sociedad.Text = "IMECON S.A.";
         
        //    cbo_base_datos.Text = "MISAP";
            txt_cdg_usr.CharacterCasing = CharacterCasing.Upper;

            WindowsIdentity currentUser = WindowsIdentity.GetCurrent();
            
            txt_cdg_usr.Text = Environment.UserName ;
          txt_psw_usr.Focus();
          txt_psw_usr.BackColor = Color.FromArgb(254, 240, 158);

        }

        private void txt_cdg_usr_TextChanged(object sender, System.EventArgs e)
        {
            txt_psw_usr.Focus();
        }

        private void txt_cdg_usr_Leave(object sender, System.EventArgs e)
        {
            txt_cdg_usr.BackColor = Color.White;
            txt_psw_usr.Focus();
            txt_psw_usr.BackColor = Color.FromArgb(254, 240, 158);
        }

     
        private void rb_produccion_CheckedChanged(object sender, System.EventArgs e)
        {
    
         //   cbo_base_datos.Text = "MISAP";
            cbo_bd_sociedad.Enabled = false;
            cbo_bd_sociedad.Text = "SBO_IMECON_PRODUCCION";
            txt_bd_externa.Text = "SBO_IMECON_PRODUCCION";
            txt_ambiente.Text = rb_produccion.Text;
        }

        private void rb_pruebas_CheckedChanged(object sender, System.EventArgs e)
        {
            cbo_bd_sociedad.Enabled = true;
            //carga combo cbo_bd_sap
            cbo_bd_sociedad.DataSource = AccesoLogica.listar_bd_sap();
            cbo_bd_sociedad.DisplayMember = "name";
            cbo_bd_sociedad.ValueMember = "database_id";
            cbo_bd_sociedad.SelectedItem = null;

            txt_ambiente.Text = rb_pruebas.Text;
       //     cbo_base_datos.Text = "MISAP";
        }

      

        private void txt_mostrar_Click(object sender, EventArgs e)
        {
            rb_produccion.Visible = true;
            rb_produccion.Visible = true;
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == Convert.ToInt32(Keys.F1))
            {
                rb_produccion.Visible = true;
                rb_produccion.Visible = true;
            }
        }

        private void txt_psw_usr_Enter(object sender, EventArgs e)
        {
            txt_psw_usr.BackColor = Color.FromArgb(254, 240, 158);
        }

        private void cbo_bd_sociedad_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_sociedad.Text = cbo_bd_sociedad.Text;
        }

    }
    }

