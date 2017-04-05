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


namespace MISAP
{
    public partial class FrmMUsuario : Form, IForm_Clave
    {

        #region Variables globales

        public string usuario, perfil;

       
        #endregion

        #region Variables locales

        private Point pos = Point.Empty;
        private bool move = false;
        bool allowSelect = false;

        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();
        string filtro;
        int columna;

        #endregion
       
        #region Formulario

        public FrmMUsuario()
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
            //    this.StartPosition = FormStartPosition.CenterScreen;
            //    maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
            //    this.SetBounds(this.Location.X, this.Location.Y, 919, 674);


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

        #region Formulario externo

        public void pasar_clave(string clave_actual, string clave, string confirmacion)
        {
            try
            {
                txt_clave.Text = clave;
                txt_clave_mcop.Text = clave;
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Orden de Producción", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        #endregion

        #region Perzonalizacion de controles

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() :
                base(new Utilidades.MyColors()) { }
        }

        private void cbo_perfil_DrawItem(object sender, DrawItemEventArgs e)
        {
            util.FormatearCombo(sender, e, "des_perf");
        }

        #endregion

        #region Botones

        private void btn_nuevo_b_Click(object sender, EventArgs e)
        {
            limpiar();
            
            tc_usuario.TabPages.Add(tp_nuevo);
            tc_usuario.TabPages.Add(tp_auditoria);

            activar_boton(false, false, false, false, false, false, false, false, false, false, false, false, true);

            util.EstablecerAuditoria("Nuevo", usuario, "", "FrmMUsuario", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            allowSelect = true;
            tc_usuario.SelectedIndex = 1;
            allowSelect = false;

            //carga combo perfil
            cbo_perfil.DataSource = AccesoLogica.obtener_perfil();
            cbo_perfil.DisplayMember = "des_perf";
            cbo_perfil.ValueMember = "cdg_perf";
            cbo_perfil.SelectedItem = null;

            //carga combo perfil MCOP
            cbo_perfil_mcop.DataSource = AccesoLogica.obtener_perfil_mcop();
            cbo_perfil_mcop.DisplayMember = "des_perf";
            cbo_perfil_mcop.ValueMember = "cdg_perf";
            cbo_perfil_mcop.SelectedItem = null;

            txt_cdg_usr.Enabled = true;
            txt_des_usr.Enabled = true;
            txt_ema_usr.Enabled = true;
            cbo_perfil.Enabled = true;
            cbo_perfil_mcop.Enabled = true;
            txt_dni.Enabled = true;
            chk_swt_usr.Enabled = true;
           

            txt_clave.BackColor = Color.FromArgb(231, 231, 231);
           

            txt_cdg_usr.CharacterCasing = CharacterCasing.Upper;
            txt_des_usr.CharacterCasing = CharacterCasing.Upper;
            txt_ema_usr.CharacterCasing = CharacterCasing.Lower;

            txt_dni.Focus();

        }

        private void btn_editar_b_Click(object sender, EventArgs e)
        {
            //limpiar();

            if (dgv_usuarios.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para modificar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            util.EstablecerAuditoria("Editar", usuario, "", "FrmMUsuario", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            btn_clave.Enabled = true;
            activar_boton(false, false, false, false, false, false, false, false, false, false, false, true, true);
            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
            btn_grabar.Text = "Actualizar";
            tc_usuario.TabPages.Add(tp_nuevo);

            tp_nuevo.Text = @"Editar";

            allowSelect = true;
            tc_usuario.SelectedIndex = 1;
            allowSelect = false;

            txt_cdg_usr.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Codigo"].Value);
            txt_des_usr.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Usuario"].Value);
            txt_usuario_mcop.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Codigo Mcop"].Value);

            //carga combo perfil
            cbo_perfil.DataSource = AccesoLogica.obtener_perfil();
            cbo_perfil.DisplayMember = "des_perf";
            cbo_perfil.ValueMember = "cdg_perf";
            cbo_perfil.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Perfil"].Value);

            //carga combo perfil
            cbo_perfil_mcop.DataSource = AccesoLogica.obtener_perfil_mcop();
            cbo_perfil_mcop.DisplayMember = "des_perf";
            cbo_perfil_mcop.ValueMember = "cdg_perf";
            cbo_perfil_mcop.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Perfil Mcop"].Value);

            txt_cdg_perf.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["cdg_perf"].Value);
            txt_ema_usr.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Correo"].Value);
            txt_cdg_perf_mcop.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Cdg Perfil Mcop"].Value);

            txt_dni.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["D.N.I."].Value);
            txt_clave.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["psw_usr"].Value);
            txt_clave_mcop.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Clave Mcop"].Value);


            string estado = Convert.ToString(dgv_usuarios.CurrentRow.Cells["swt_usr"].Value);

            if (estado == "1")
            {
                chk_swt_usr.Checked = true;
                chk_swt_usr.Text = "Activo";
            }
            else
            {
                chk_swt_usr.Checked = false;
                chk_swt_usr.Text = "Inactivo";
            }

            ////carga documentos para aprobacion

            //lb_documentos.DataSource = AccesoLogica.listar_documentos();
            //lb_documentos.DisplayMember = "nom_tipodoc";
            //lb_documentos.ValueMember = "cod_tipodoc";
            //lb_documentos.Text = "Lista de Documentos";



            activar_campos(false,true, true, true, true,true,true);

        }

        private void btn_consultar_b_Click(object sender, EventArgs e)
        {
            if (dgv_usuarios.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para consultar", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            util.EstablecerAuditoria("Consultar", usuario, "", "FrmMUsuario", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            btn_clave.Enabled = false;
            activar_boton(false, false, false, false, true, true, false, false, false, false, false, false, true);
            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
            tc_usuario.TabPages.Add(tp_nuevo);

            tp_nuevo.Text = @"Consultar";

            allowSelect = true;
            tc_usuario.SelectedIndex = 1;
            allowSelect = false;

            txt_cdg_usr.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Codigo"].Value);
            txt_des_usr.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Usuario"].Value);


            //carga combo perfil
            cbo_perfil.DataSource = AccesoLogica.obtener_perfil();
            cbo_perfil.DisplayMember = "des_perf";
            cbo_perfil.ValueMember = "cdg_perf";
            cbo_perfil.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Perfil"].Value);

            txt_cdg_perf.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["cdg_perf"].Value);
            txt_ema_usr.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Correo"].Value);

            txt_dni.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["D.N.I."].Value);
            txt_clave.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["psw_usr"].Value);

            //carga combo perfil
            cbo_perfil_mcop.DataSource = AccesoLogica.obtener_perfil_mcop();
            cbo_perfil_mcop.DisplayMember = "des_perf";
            cbo_perfil_mcop.ValueMember = "cdg_perf";
            cbo_perfil_mcop.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Perfil Mcop"].Value);

            txt_usuario_mcop.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Codigo Mcop"].Value);
            txt_clave_mcop.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Clave Mcop"].Value);
            txt_cdg_perf_mcop.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Cdg Perfil Mcop"].Value);

            string estado = Convert.ToString(dgv_usuarios.CurrentRow.Cells["swt_usr"].Value);

            if (estado == "1")
            {
                chk_swt_usr.Checked = true;
                chk_swt_usr.Text = "Activo";
            }
            else
            {
                chk_swt_usr.Checked = false;
                chk_swt_usr.Text = "Inactivo";
            }

            activar_campos(false,false, false, false, false,false,false);
        }

        private void btn_eliminar_b_Click(object sender, EventArgs e)
        {
            if (dgv_usuarios.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para eliminar", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            util.EstablecerAuditoria("Eliminar", usuario, "", "FrmMUsuario", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            AccesoLogica Negocio = new AccesoLogica();

            txt_des_usr.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Usuario"].Value);
            txt_cdg_usr.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Codigo"].Value);

            DialogResult result1 = MessageBox.Show("Desea eliminar el usuario : " +  txt_des_usr.Text, txt_operacion.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);



            if (result1 == DialogResult.Yes)
            {
                try
                {
                    int resultado = Negocio.mantenimiento_OUSR
                                  (txt_cdg_usr.Text, txt_des_usr.Text,0, txt_ema_usr.Text, txt_dni.Text, txt_cdg_perf.Text, txt_clave.Text, 0,
                                  txt_usr_crea.Text, txt_fec_crea.Text, txt_terminal_crea.Text, txt_usr_modi.Text, txt_fec_modi.Text, txt_terminal_modi.Text, txt_operacion.Text, txt_formulario.Text);
                    if (resultado == 0) Negocio = null;

                    MessageBox.Show("Los datos se eliminaron satisfactoriamente.", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                }

                finally
                {
                    limpiar();


                    tc_usuario.TabPages.Remove(tp_nuevo);
                    tc_usuario.TabPages.Remove(tp_auditoria);

                    allowSelect = true;
                    tc_usuario.SelectedIndex = 0;

                    dgv_usuarios.DataSource = AccesoLogica.listar_usuario(1, 1,"Consultar","Listar");
                    formatear_grilla(dgv_usuarios);

                    activar_campos(false, false, false, false, false,false,false);



                }
            }
        }

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
            util.ExportarDataGridViewExcel(dgv_usuarios, tsl_titulo.Text);
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            #region validaciones
            if (txt_cdg_usr.Text == string.Empty)
            {

                MessageBox.Show("Digite el codigo de usuario", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txt_cdg_usr.Focus();
                return;
            }

            if (txt_dni.Text == string.Empty)
            {

                MessageBox.Show("Digite el D.N.I", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txt_dni.Focus();
                return;
            }

            if (txt_des_usr.Text == string.Empty)
            {

                MessageBox.Show("Digite el nombre del usuario", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txt_des_usr.Focus();
                return;
           }

            if (txt_ema_usr.Text == string.Empty)
            {

                MessageBox.Show("Digite el mail del usuario", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txt_ema_usr.Focus();
                return;
            }

            if (txt_cdg_perf.Text == string.Empty)
            {

                MessageBox.Show("Seleccione el perfil", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txt_cdg_perf.Focus();
                return;

            }

            if (txt_clave.Text == string.Empty)
            {

                MessageBox.Show("Ingrese una clave de acceso", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
               btn_clave.Focus();
                return;

            }
            #endregion

            #region Operacion Nuevo
            if (txt_operacion.Text == "Nuevo")
            {


                DialogResult result1 = MessageBox.Show("Desea registrar el usuario ", "Mantenimiento de Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result1 == DialogResult.Yes)
                {
                    try
                    {
                        int swt_usr;
                        int swt_aprobacion;
                        if (chk_swt_usr.Checked)
                        {
                            swt_usr = 1;
                        }
                        else
                        {
                            swt_usr = 0;
                        }

                        if (chk_aprobacion.Checked)
                        {
                            swt_aprobacion = 1;
                        }
                        else
                        {
                            swt_aprobacion = 0;
                        }


                        int resultado = Negocio.mantenimiento_OUSR
                                   (txt_cdg_usr.Text, txt_des_usr.Text,swt_usr, txt_ema_usr.Text, txt_dni.Text,txt_cdg_perf.Text, txt_clave.Text , swt_aprobacion,
                                   txt_usr_crea.Text, txt_fec_crea.Text, txt_terminal_crea.Text, txt_usr_modi.Text, txt_fec_modi.Text, txt_terminal_modi.Text, txt_operacion.Text, txt_formulario.Text);
                        if (resultado == 0) Negocio = null;

                        //insertar en MCOP
                        int resultado_m = Negocio.sp_prd_mantenimiento_m_usuari_mcop
                                  (txt_cdg_usr.Text, txt_des_usr.Text, txt_cdg_perf_mcop.Text, swt_usr, txt_ema_usr.Text, "", "", txt_usr_crea.Text, txt_fec_crea.Text, txt_operacion.Text, txt_formulario.Text, swt_aprobacion, txt_dni.Text, txt_clave_mcop.Text);
                        if (resultado_m == 0) Negocio = null;

                        MessageBox.Show("Operación finalizada con éxito.", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);





                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                    }

                    finally
                    {
                        limpiar();




                        tc_usuario.TabPages.Remove(tp_nuevo);
                        tc_usuario.TabPages.Remove(tp_auditoria);

                        allowSelect = true;
                        tc_usuario.SelectedIndex = 0;

                        dgv_usuarios.DataSource = AccesoLogica.listar_usuario(0, 1,"Consultar","Listar");
                        formatear_grilla(dgv_usuarios);

                        activar_campos(false, false, false, false, false,false,false);
                    }
                }
            }
            #endregion

            #region Operacion Editar

            if (txt_operacion.Text == "Editar")
            {


                DialogResult result2 = MessageBox.Show("Desea actualizar los datos", txt_operacion.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result2 == DialogResult.Yes)
                {
                    try
                    {
                        int swt_usr;
                        int swt_aprobacion;

                        if (chk_swt_usr.Checked)
                        {
                            swt_usr = 1;
                        }
                        else
                        {
                            swt_usr = 0;

                        }

                        if (chk_aprobacion.Checked)
                        {
                            swt_aprobacion = 1;
                        }
                        else
                        {
                            swt_aprobacion = 0;

                        }

                        int resultado = Negocio.mantenimiento_OUSR
                                (txt_cdg_usr.Text, txt_des_usr.Text, swt_usr, txt_ema_usr.Text, txt_dni.Text, txt_cdg_perf.Text, txt_clave.Text, swt_aprobacion,
                                txt_usr_crea.Text, txt_fec_crea.Text, txt_terminal_crea.Text, txt_usr_modi.Text, txt_fec_modi.Text, txt_terminal_modi.Text, txt_operacion.Text, txt_formulario.Text);
                        if (resultado == 0) Negocio = null;



                        //insertar en MCOP
                        int resultado_m = Negocio.sp_prd_mantenimiento_m_usuari_mcop
                                  (txt_cdg_usr.Text, txt_des_usr.Text, txt_cdg_perf_mcop.Text, swt_usr, txt_ema_usr.Text, "", "", txt_usr_crea.Text, txt_fec_crea.Text, txt_operacion.Text, txt_formulario.Text, swt_aprobacion, txt_dni.Text, txt_clave_mcop.Text);
                        if (resultado_m == 0) Negocio = null;

                        //INSERTA cabecera APROBACIONES
                        foreach (DataRowView i in lb_documentos.CheckedItems)
                        {


                            //   cod_tipodoc = Convert.ToString(i["cod_tipodoc"]);
                            // formulario_a = Convert.ToString(i["formulario"]);

                            //    int resultado_m_aprobacion = Negocio.mantenimiento_m_prd_aprobaciones
                            //   (txt_cdg_perf.Text, txt_cdg_usr.Text, formulario_a, swt_aprobacion, cod_tipodoc, txt_operacion.Text);

                            //    if (resultado_m_aprobacion == 0) Negocio = null;

                        }

                        MessageBox.Show("Operación finalizada con éxito.", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);


                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                    }

                    finally
                    {

                        limpiar();

                        tc_usuario.TabPages.Remove(tp_nuevo);
                        tc_usuario.TabPages.Remove(tp_auditoria);

                        allowSelect = true;
                        tc_usuario.SelectedIndex = 0;

                        dgv_usuarios.DataSource = AccesoLogica.listar_usuario(1, 1, "Consultar", "Listar");
                        formatear_grilla(dgv_usuarios);

                        activar_boton(true, true, true, true, true, true, true, false, false, true, false, false, true);
                        btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
                        btn_grabar.Text = "Crear";
                        activar_campos(false,false, false, false, false, false,false);


                    }
                }

            }
            #endregion
        }
        
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar();

            tc_usuario.TabPages.Remove(tp_nuevo);
            tc_usuario.TabPages.Remove(tp_auditoria);

            allowSelect = true;
            tc_usuario.SelectedIndex = 0;

            dgv_usuarios.DataSource = AccesoLogica.listar_usuario(1, 1, "Consultar", "Listar");
            formatear_grilla(dgv_usuarios);

            activar_boton(true, true, true, true, true, true, true, false, false, true, false, false, true);
            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
            btn_grabar.Text = "Crear";
            activar_campos(false, false, false, false, false,false,false);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            limpiar();

            dgv_usuarios.DataSource = AccesoLogica.listar_usuario(1, 1, "Consultar", "Listar");
            formatear_grilla(dgv_usuarios);
        }

        private void btn_grabar_firma_Click(object sender, EventArgs e)
        {
            AccesoLogica Negocio = new AccesoLogica();

            FileStream stream = new FileStream(txtexaminar.Text, FileMode.Open, FileAccess.Read);
            //Se inicailiza un flujo de archivo con la imagen seleccionada desde el disco.
            BinaryReader br = new BinaryReader(stream);
            FileInfo fi = new FileInfo(txtexaminar.Text);

            //Se inicializa un arreglo de Bytes del tamaño de la imagen
            byte[] binData = new byte[stream.Length];
            //Se almacena en el arreglo de bytes la informacion que se obtiene del flujo de archivos(foto)
            //Lee el bloque de bytes del flujo y escribe los datos en un búfer dado.
            stream.Read(binData, 0, Convert.ToInt32(stream.Length));

            ////Se muetra la imagen obtenida desde el flujo de datos
            pb_firma.Image = Image.FromStream(stream);


            int resultado = Negocio.sp_prd_mantenimiento_m_prd_firma
                              (0, txt_cdg_usr.Text, binData, txt_usr_crea.Text, txt_fec_crea.Text, txt_terminal_crea.Text, txt_operacion.Text, "", "", "", txt_formulario.Text, "Cabecera", "General", "A");
            if (resultado == 0) Negocio = null;

            btn_grabar.Enabled = true;
        }

        private void btn_cargar_firma_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog examinar = new OpenFileDialog();
                examinar.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";
                DialogResult dres1 = examinar.ShowDialog();
                if (dres1 == DialogResult.Abort)
                    return;
                if (dres1 == DialogResult.Cancel)
                    return;
                txtexaminar.Text = examinar.FileName;
                pb_firma.Image = Image.FromFile(examinar.FileName);
                btn_grabar_firma.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }

            //try
            //{
            //    this.openFileDialog1.ShowDialog();
            //    if (this.openFileDialog1.FileName.Equals("") == false)
            //    {
            //        p_firma.Load(this.openFileDialog1.FileName);
            //        btn_grabar_firma.Enabled = true;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            //}
        }

        private void btn_clave_Click(object sender, EventArgs e)
        {
            FrmClave clave = new FrmClave();
            clave.formulario = "FrmMUsuario";
            clave.titulo = "Clave de acceso";
            clave.ShowDialog(this);
        }

        #endregion

        #region Funciones

        void activar_boton(bool nuevo, bool editar, bool consultar, bool eliminar, bool imprimir, bool previsualizar, bool exportar_xls, bool aprobar, bool desaprobar, bool actualizar, bool ayuda, bool grabar, bool cancelar)
        {
            btn_nuevo_b.Enabled = nuevo;
            btn_editar_b.Enabled = editar;
            btn_consultar_b.Enabled = consultar;
            btn_eliminar_b.Enabled = eliminar;
            btn_imprimir.Enabled = imprimir;
            btn_previsualizar.Enabled = previsualizar;
            btn_exportar_xls.Enabled = exportar_xls;
            btn_aprobar.Enabled = aprobar;
            btn_desaprobar.Enabled = desaprobar;
            btn_actualizar.Enabled = actualizar;
            btn_grabar.Enabled = grabar;
            btn_cancelar.Enabled = cancelar;
         
        }
        void activar_campos(bool cdg_usr, bool dni, bool des_usr, bool correo, bool perfil, bool perfil_mcop, bool swt_usr)
        {
            txt_cdg_usr.Enabled = cdg_usr;
            txt_dni.Enabled = dni;
            txt_des_usr.Enabled = des_usr ;
            txt_ema_usr.Enabled = correo;
            cbo_perfil.Enabled = perfil;
            cbo_perfil_mcop.Enabled = perfil_mcop;
            chk_swt_usr.Enabled = swt_usr;
        
        }
        void limpiar()
        {
            txt_buscar.Clear();
            txt_cdg_perf.Clear();
            txt_cdg_usr.Clear();
            txt_des_usr.Clear();
            txt_ema_usr.Clear();
            txt_dni.Clear();
            txt_clave.Clear();


            txt_estado_registro.Clear();
            txt_fec_crea.Clear();
            txt_formulario.Clear();
           
            txt_operacion.Clear();
            txt_terminal_crea.Clear();
            txt_usr_crea.Clear();

            chk_swt_usr.Checked = false; 
            cbo_perfil.SelectedItem = null;

            if (dgv_usuarios.Rows.Count != 0)
            {
                DataTable dtg = (DataTable)dgv_usuarios.DataSource;
                dtg.Clear();
            }

      

        }
        void formatear_grilla(DataGridView grilla)
        {

            try
            {
                util.FormatearGrilla(grilla,false);
                dgv_usuarios.Columns["swt_usr"].Visible = false;
                dgv_usuarios.Columns["cdg_perf"].Visible = false;
                dgv_usuarios.Columns["psw_usr"].Visible = false;
                dgv_usuarios.Columns["Cdg Perfil Mcop"].Visible = false;
                dgv_usuarios.Columns["Clave Mcop"].Visible = false;
          
              

                lbl_contador_registros.Visible = true;
                lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_usuarios.Rows.Count);



            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Fabricación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        #endregion

        #region Eventos

        private void FrmMUsuario_Load(object sender, EventArgs e)
        {
           
            util.FormatearFormulario(this, ts_acciones, tc_usuario, ss_load, txt_buscar, tp_listado, tp_nuevo, tp_auditoria);

            this.Location = new System.Drawing.Point(320, 150);

            dgv_usuarios.DataSource = AccesoLogica.listar_usuario(1, 1,"Consultar","Listar");
            formatear_grilla(dgv_usuarios);

            if (dgv_usuarios.Rows.Count != 0)
            {
                txt_buscar.Enabled = true;
                filtro = dgv_usuarios.Columns[0].HeaderText;

                dgv_usuarios.CurrentCell = dgv_usuarios.Rows[0].Cells[0];
                columna = dgv_usuarios.CurrentCell.ColumnIndex;
            }

        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
                     (dgv_usuarios.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + filtro + " ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
                 
               
            
        }

        private void txt_buscar_Leave(object sender, EventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(231, 231, 231);
            //txt_buscar.Clear();
        }

        private void txt_buscar_Enter(object sender, EventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txt_buscar.Text))
            {
                txt_buscar.SelectionStart = 0;
                txt_buscar.SelectionLength = txt_buscar.Text.Length;
            }
        }

        private void rb_todos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_usuarios.DataSource = AccesoLogica.listar_usuario(0,1,"Consultar", "Listar");
                formatear_grilla(dgv_usuarios);
                txt_buscar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Valorizaciones", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        private void rb_activos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_usuarios.DataSource = AccesoLogica.listar_usuario(1, 1, "Consultar", "Listar");
                formatear_grilla(dgv_usuarios);
                txt_buscar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Valorizaciones", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        private void rb_inactivos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_usuarios.DataSource = AccesoLogica.listar_usuario(0, 0, "Consultar", "Listar");
                formatear_grilla(dgv_usuarios);
                txt_buscar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Valorizaciones", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        private void tc_usuario_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!allowSelect) e.Cancel = true;
        }

        private void cbo_perfil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_cdg_perf.Text = cbo_perfil.SelectedValue.ToString();
        }

        private void chk_aprobacion_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_aprobacion.Checked)
                {
                    lb_documentos.Visible = true;
                    lb_documentos.Enabled = true;
                    btn_grabar.Enabled = false;
                    chk_aprobacion.Text = "Activo";

                }

                else
                {
                    lb_documentos.Visible = false;
                    chk_aprobacion.Text = "Inactivo";
                    btn_grabar.Enabled = true;
                    lb_documentos.Enabled = false;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Fabricación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        private void lb_documentos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int c_seleccionados;
            c_seleccionados = 0;

            if (e.NewValue == CheckState.Checked)
            {
                c_seleccionados = c_seleccionados + 1;
                btn_cargar_firma.Enabled = true;

            }

            else
            {
                c_seleccionados = c_seleccionados - 1;
                if (c_seleccionados == 0)
                {
                    btn_cargar_firma.Enabled = false;
                }

            }
        }

        private void dgv_usuarios_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar.Focus();
            txt_buscar.Clear();

            filtro = dgv_usuarios.Columns[e.ColumnIndex].HeaderText;
            lbl_buscar.Text = "Buscar en " + filtro;

            dgv_usuarios.CurrentCell = dgv_usuarios.Rows[0].Cells[e.ColumnIndex];
        }

  
        private void chk_swt_usr_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_swt_usr.Checked)
                {

                    if(txt_operacion.Text == "Nuevo")
                    {
                    
                        btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
                        activar_boton(false, false, false, false, false, false, false, false, false, false, false, true, true);
                    }

                  
                    #region genera usuario autimaticamente.

                    //String nombreCompleto = txt_des_usr.Text;
                    //String[] nombreSeparado = nombreCompleto.Split(' ');
                    //String datoFinal = String.Empty;

                    ////Nombre
                    //datoFinal += nombreSeparado[0].Substring(0, 1);
                    ////Apellido
                    //datoFinal += nombreSeparado[1];
                    ////Nombre1

                    //txt_cdg_usr.Text = datoFinal.ToUpper();
                    #endregion


                }

                else
                {
                    if (txt_operacion.Text == "Nuevo")
                    {

                        btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
                        activar_boton(false, false, false, false, false, false, false, false, false, false, false, false, true);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Fabricación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {
            if (txt_dni.TextLength == 8)
            {
                if (txt_operacion.Text == "Nuevo")
                {
                    try
                    {
                        txt_des_usr.Text = Convert.ToString(AccesoLogica.obtener_personal_pca(txt_dni.Text).Rows[0][0]);
                        txt_cdg_usr.Text = Convert.ToString(AccesoLogica.obtener_personal_pca(txt_dni.Text).Rows[0][1]);
                        txt_ema_usr.Text = Convert.ToString(AccesoLogica.obtener_personal_pca(txt_dni.Text).Rows[0][2]);
                        txt_usuario_mcop.Text = txt_cdg_usr.Text;
                        cbo_perfil.Focus();
                    }
                    catch
                    {
                        MessageBox.Show("El empleado no se encuentra registrado en el sistema de RRHH", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        txt_dni.Clear();
                        txt_dni.Focus();
                    }

                }



            }
        }

        private void txt_dni_Enter(object sender, EventArgs e)
        {
            txt_dni.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txt_dni.Text))
            {
                txt_dni.SelectionStart = 0;
                txt_dni.SelectionLength = txt_dni.Text.Length;
            }
        }

        private void txt_dni_Leave(object sender, EventArgs e)
        {
            txt_dni.BackColor = Color.White;
        }

        private void txt_dni_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_dni.Text))
            {
                txt_dni.SelectionStart = 0;
                txt_dni.SelectionLength = txt_dni.Text.Length;
            }
        }

        private void txt_des_usr_Enter(object sender, EventArgs e)
        {
            txt_des_usr.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txt_des_usr.Text))
            {
                txt_des_usr.SelectionStart = 0;
                txt_des_usr.SelectionLength = txt_des_usr.Text.Length;
            }
        }

        private void txt_des_usr_Leave(object sender, EventArgs e)
        {
            txt_des_usr.BackColor = Color.White;
        }

        private void txt_des_usr_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_des_usr.Text))
            {
                txt_des_usr.SelectionStart = 0;
                txt_des_usr.SelectionLength = txt_des_usr.Text.Length;
            }
        }

        private void txt_ema_usr_Enter(object sender, EventArgs e)
        {
            txt_ema_usr.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txt_ema_usr.Text))
            {
                txt_ema_usr.SelectionStart = 0;
                txt_ema_usr.SelectionLength = txt_ema_usr.Text.Length;
            }
        }

        private void txt_ema_usr_Leave(object sender, EventArgs e)
        {
            txt_ema_usr.BackColor = Color.White;
        }

        private void txt_ema_usr_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_ema_usr.Text))
            {
                txt_ema_usr.SelectionStart = 0;
                txt_ema_usr.SelectionLength = txt_ema_usr.Text.Length;
            }
        }

        private void cbo_perfil_Enter(object sender, EventArgs e)
        {
            cbo_perfil.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(cbo_perfil.Text))
            {
                cbo_perfil.SelectionStart = 0;
                cbo_perfil.SelectionLength = cbo_perfil.Text.Length;
            }
        }

        private void cbo_perfil_Leave(object sender, EventArgs e)
        {
            cbo_perfil.BackColor = Color.White;
        }

        private void cbo_perfil_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(cbo_perfil.Text))
            {
                cbo_perfil.SelectionStart = 0;
                cbo_perfil.SelectionLength = cbo_perfil.Text.Length;
            }
        }

        private void txt_cdg_usr_Enter(object sender, EventArgs e)
        {
            txt_cdg_usr.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txt_cdg_usr.Text))
            {
                txt_cdg_usr.SelectionStart = 0;
                txt_cdg_usr.SelectionLength = txt_cdg_usr.Text.Length;
            }
        }

        private void txt_cdg_usr_Leave(object sender, EventArgs e)
        {
            txt_cdg_usr.BackColor = Color.White;

        }

        private void txt_cdg_usr_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_cdg_usr.Text))
            {
                txt_cdg_usr.SelectionStart = 0;
                txt_cdg_usr.SelectionLength = txt_cdg_usr.Text.Length;
            }

        }
       
        #endregion

        #region Menu contextual

        private void cm_grilla_copia_tabla_Click(object sender, EventArgs e)
        {
            util.copiar_todo_encabezados(dgv_usuarios);
        }

        private void cm_grilla_copia_Click(object sender, EventArgs e)
        {
            util.copiar_contextual(dgv_usuarios);
        }

        #endregion

        private void txt_buscar_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_buscar.Text))
            {
                txt_buscar.SelectionStart = 0;
                txt_buscar.SelectionLength = txt_buscar.Text.Length;
            }
        }

        private void dgv_usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_usuarios.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para consultar", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            util.EstablecerAuditoria("Consultar", usuario, "", "FrmMUsuario", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            btn_clave.Enabled = false;
            activar_boton(false, false, false, false, true, true, false, false, false, false, false, false, true);
            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
            tc_usuario.TabPages.Add(tp_nuevo);

            tp_nuevo.Text = @"Consultar";

            allowSelect = true;
            tc_usuario.SelectedIndex = 1;
            allowSelect = false;

            txt_cdg_usr.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Codigo"].Value);
            txt_des_usr.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Usuario"].Value);


            //carga combo perfil
            cbo_perfil.DataSource = AccesoLogica.obtener_perfil();
            cbo_perfil.DisplayMember = "des_perf";
            cbo_perfil.ValueMember = "cdg_perf";
            cbo_perfil.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Perfil"].Value);

            txt_cdg_perf.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["cdg_perf"].Value);
            txt_ema_usr.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["Correo"].Value);

            txt_dni.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["D.N.I."].Value);
            txt_clave.Text = Convert.ToString(dgv_usuarios.CurrentRow.Cells["psw_usr"].Value);

            string estado = Convert.ToString(dgv_usuarios.CurrentRow.Cells["swt_usr"].Value);

            if (estado == "1")
            {
                chk_swt_usr.Checked = true;
                chk_swt_usr.Text = "Activo";
            }
            else
            {
                chk_swt_usr.Checked = false;
                chk_swt_usr.Text = "Inactivo";
            }

            activar_campos(false, false, false, false, false, false,false);
        }

        private void btn_previsualizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {

        }

        private void cbo_perfil_mcop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_cdg_perf_mcop.Text = cbo_perfil_mcop.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            util.CrearUsuarioAD();
        }

   
    }
}
