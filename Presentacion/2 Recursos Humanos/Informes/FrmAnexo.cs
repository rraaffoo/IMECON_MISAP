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
    public partial class FrmAnexo : Form
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

          public FrmAnexo()
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

        private void FrmAnexo_Load(object sender, EventArgs e)
        {
            this.Activate();

            valida_permisos(perfil);
            
            util.FormatearFormulario(this, ts_acciones, tc_anexo, ss_load, txt_buscar, tp_listado, tp_nuevo, tp_auditoria);
            this.Location = new System.Drawing.Point(320, 80);
            btnSuprimir.Visible = false;
            anio = DateTime.Now.Year.ToString();
            cargar_grilla();
        }

        private void cargar_grilla()
        {
            dgv_anexo.DataSource = null;
            dgv_anexo.DataSource = AccesoLogica.listar_anexo();
            pasar_dgv_to_txt(0);
            formatear_grilla(dgv_anexo);

            if (dgv_anexo.Rows.Count != 0)
            {
                posicion = 0;
                txt_buscar.Enabled = true;
                filtro = dgv_anexo.Columns[1].HeaderText;

                dgv_anexo.CurrentCell = dgv_anexo.Rows[0].Cells[1];
                columna = dgv_anexo.CurrentCell.ColumnIndex;
            }
        }

        
        private void tc_usuario_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!allowSelect) e.Cancel = true;
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {

            (dgv_anexo.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" + " ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
            lbl_contador_registros.Text = string.Format("Total de registros: {0}", dgv_anexo.Rows.Count);

        }

        private void dgv_anexo_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar.Focus();
            txt_buscar.Clear();

            filtro = dgv_anexo.Columns[e.ColumnIndex].HeaderText;
            lbl_buscar.Text = "Buscar en " + filtro;

            dgv_anexo.CurrentCell = dgv_anexo.Rows[0].Cells[e.ColumnIndex];

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
            txtAnexo.Clear();         
            txt_obs.ReadOnly = true;

            txtDni.Clear();
            txtNombre.Clear();
            txtAnexo.Clear();
            txtRpc.Clear();
            txtOtro.Clear();
            txtArea.Clear();
            txtCargo.Clear();

        }
        void formatear_grilla(DataGridView grilla)
        {

            try
            {
                util.FormatearGrilla(grilla, true);

                if (grilla == dgv_anexo)
                {
                    grilla.Columns["DNI"].Visible = false;
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


        

        private bool EnviarEmail_pedido()
        {
            textbody =
           "<br/>" + "Estimado:" + "<br>" +
           "<br/>" + "El requerimiento Nº " + num_ped + " para la OT Nº " + num_ord + "\r\n" +
           "<br/>" + " requiere de su aprobación" + "<br>" +
            "<br/>" + txt_obs.Text + "\r\n" +
            "<br/>" + " " + "\r\n" +
           "<br/>" + " " + "\r\n" +
           "<br/>" + "Administrador MISAP" + "<br>";

            MailMessage msg = new MailMessage();

            msg.To.Add(responsable + "@imecon.com.pe");
            msg.CC.Add("seg_docum@imecon.com.pe");
            msg.From = new MailAddress("misap@imecon.com.pe", "Modulo de Interfaz SAP", System.Text.Encoding.UTF8);
            msg.Subject = "REQUERIMIENTO Nº " + num_ped + " POR APROBAR";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = textbody;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true; //Si vas a enviar un correo con contenido html entonces cambia el valor a true


            //ADJUNTAR DOCUMENTO
            //System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment("\\\\10.0.0.8\\comun\\MCOP\\SOLICITUDES\\" + txt_nro_solicitud.Text + ".xls");
            //msg.Attachments.Add(attachment);

            //Aquí es donde se hace lo especial


            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("seg_docum@imecon.com.pe", "$3g#d0cum");
            client.Port = 587;
            client.Host = "smtp.gmail.com";//Este es el smtp valido para Gmail
            client.EnableSsl = true; //Esto es para que vaya a través de SSL que es obligatorio con GMail
            try
            {
                client.Send(msg);
                return true;
            }
            catch
            {
                return false;
            }
        }

        void insertar_auditoria(string operacion, string formulario, string tipo_doc, string nro_doc)
        {
            string strHostName = string.Empty;
            strHostName = Dns.GetHostName();


            IPAddress[] hostIPs = Dns.GetHostAddresses(strHostName);
            for (int i = 0; i < hostIPs.Length; i++) { IP = hostIPs[i].ToString(); }

            int resultado_auditoria = Negocio.insertar_OAUD(usuario, DateTime.Now.ToString("yyyy-MM-dd HH:mm"), Environment.MachineName, IP, Environment.UserName, operacion, formulario, tipo_doc, nro_doc);


        }
        #endregion

        #region Botones

        private void btn_nuevo_b_Click(object sender, EventArgs e)
        {
            if (!verificar_acceso())
                return;

            limpiar();

            tc_anexo.TabPages.Add(tp_nuevo);
            tc_anexo.TabPages.Add(tp_auditoria);

            activar_boton(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true);
            util.EstablecerAuditoria("Nuevo", usuario, "", "FrmPedidos", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            allowSelect = true;
            tc_anexo.SelectedIndex = 1;
            allowSelect = false;

            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
            btn_grabar.Enabled = true;
            btn_grabar.Text = "Crear";

            btnSuprimir.Visible = false;
            chkOtro.Visible = true;
            chkOtro.Checked = false;
            formatear_grilla(dgv_anexo);
            txtDni.Text = "";
            txtDni.Focus();
            
        }

        private bool verificar_acceso()
        {
            if (usuario=="RBARRIOS" || usuario=="ETERRONES" || usuario =="RIZAGUIRRE" || usuario=="PCHAMAN" || usuario =="MSALINAS" )
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
    
        private void btn_grabar_Click(object sender, EventArgs e)
        {
            

            #region Operacion Nuevo
            if (txt_operacion.Text == "Nuevo")
            {
                DialogResult result1 = MessageBox.Show("Está seguro de grabar el registro?", "Nuevo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result1 == DialogResult.Yes)
                {
                    try
                    {
                        if (chkOtro.Checked)
                        {
                            int aa = Negocio.nuevo_registro_anexo_nom(txtNombre.Text, txtAnexo.Text, txtRpc.Text, txtOtro.Text);                       
                        }
                        else
                        {
                            int aa = Negocio.nuevo_registro_anexo(txtDni.Text, txtAnexo.Text, txtRpc.Text, txtOtro.Text);                            
                        }
                        util.mensaje("Se creó el registro de manera exitosa", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);                        
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                    }

                    finally
                    {
                        limpiar();
                        //valida_permisos(perfil);
                        cargar_grilla();
                        activar_boton(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
                        btnSuprimir.Visible = false;
                        btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
                        
                        tc_anexo.TabPages.Remove(tp_nuevo);
                        tc_anexo.TabPages.Remove(tp_auditoria);

                        txtDni.Enabled = true;
                        txtNombre.Enabled = false;
                        chkOtro.Visible = false;
                        allowSelect = true;
                        tc_anexo.SelectedIndex = 0;
                    }
                }
            }

            #endregion

            #region Operacion Editar

            if (txt_operacion.Text == "Editar")
            {
                DialogResult result2 = MessageBox.Show("Confirmar la Actualización", txt_operacion.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result2 == DialogResult.Yes)
                {
                    try
                    {
                        if (txtDni.Text=="99999999")
                        {
                            int aa= Negocio.actualizar_anexo(txtDni.Text, txtAnexo.Text, txtRpc.Text, txtOtro.Text,"nom");
                        }
                        else
                        {
                            int aa = Negocio.actualizar_anexo(txtDni.Text, txtAnexo.Text, txtRpc.Text, txtOtro.Text,"dni");
                        }                        
                        util.mensaje("Operación finalizada con ÉXITO", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                    }

                    finally
                    {                        
                        cargar_grilla();
                        limpiar();
                        activar_boton(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
                        valida_permisos(perfil);
                        btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
                        btn_grabar.Text = "Crear";
                        btnSuprimir.Visible = false;
                        

                        tc_anexo.TabPages.Remove(tp_nuevo);
                        tc_anexo.TabPages.Remove(tp_auditoria);

                        allowSelect = true;
                        tc_anexo.SelectedIndex = 0;



                    }
                }

            }
            #endregion
        }

       

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            //valida_permisos(perfil);
            activar_boton(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
            btn_grabar.Text = "Crear";
            btn_grabar.Enabled = false;
            // limpiar();
            btnSuprimir.Visible = false;

            allowSelect = true;
            tc_anexo.SelectedIndex = 0;

            txtDni.Enabled = true;
            txtNombre.Enabled = false;
            chkOtro.Visible = false;
            tc_anexo.TabPages.Remove(tp_nuevo);
            tc_anexo.TabPages.Remove(tp_auditoria);
 
        }

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
            if (dgv_anexo.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para exportar", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            util.ExportarDataGridViewExcel(dgv_anexo,tsl_titulo.Text);
                 
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            anio = DateTime.Now.Year.ToString();


        }

        private void btn_consultar_b_Click(object sender, EventArgs e)
        {
            if (dgv_anexo.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para consultar", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            util.EstablecerAuditoria("Consultar", usuario, "", "FrmPedidos", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            if (perfil == "001" || perfil == "008")
            {
                activar_boton(false, false, false, false, true, true, true, true, true, true, false, false, true, true, false, false, false, false, true);
            }
            else
            {
                activar_boton(false, false, false, false, true, true, true, true, true, true, false, false, false, false, false, false, false, false, true);
            }


            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
            tc_anexo.TabPages.Add(tp_nuevo);

            tp_nuevo.Text = @"Consultar";

            allowSelect = true;
            tc_anexo.SelectedIndex = 1;
            allowSelect = false;

           
         

        
            txt_obs.Enabled = true;

           // cdg_origen.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["cdg_origen"].Value);
         


        }

        private void btn_aprobar_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_desaprobar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Operación finalizada con éxito.", "Rechazar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                #region auditoria
                insertar_auditoria("Rechazar", "FrmPedidos", "REQ", num_ped);
                #endregion
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
            finally
            {
            }

        }

        private void btn_previsualizar_Click(object sender, EventArgs e)
        {
            if (dgv_anexo.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para mostrar", txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }


            num_ped = Convert.ToString(dgv_anexo.CurrentRow.Cells["Requerimiento"].Value);

            CrvRequerimiento reporte = new CrvRequerimiento();
            reporte.num_ped = num_ped;
            reporte.ShowDialog(this);


            #region auditoria
            insertar_auditoria("Previsualizar", "FrmPedidos", "REQ", num_ped);
            #endregion

        }

        private void btn_eliminar_b_Click(object sender, EventArgs e)
        {
            if (dgv_anexo.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            try
            {
                    MessageBox.Show("Operación finalizada con éxito.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                
                #region auditoria
                insertar_auditoria("Eliminar", "FrmPedidos", "REQ", num_ped);
                #endregion

            }

            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
            finally
            {
               
            }

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            if (dgv_anexo.Rows.Count == 0)
            {
                util.mensaje("No Existe Informacion para imprimir", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }

           // num_ped = Convert.ToString(dgv_anexo.CurrentRow.Cells["Requerimiento"].Value);


            RptRequerimiento reporte = new RptRequerimiento();
            reporte.SetDatabaseLogon("sa", "B1Admin", "SAPIMECONSERVER", "MISAP");
            reporte.SetParameterValue("@num_ped", num_ped);
            crv_requerimiento.ReportSource = reporte;
            crv_requerimiento.PrintReport();

            #region auditoria
            insertar_auditoria("Imprimir", "FrmPedidos", "REQ", num_ped);
            #endregion
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (posicion < dgv_anexo.Rows.Count - 1)
            {
                posicion = posicion + 1;
            }


            dgv_anexo.CurrentCell = dgv_anexo.Rows[posicion].Cells[1];

           // cdg_origen.Text = Convert.ToString(dgv_pedidos.CurrentRow.Cells["cdg_origen"].Value);
          
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion = posicion - 1;
            }


            dgv_anexo.CurrentCell = dgv_anexo.Rows[posicion].Cells[1];

           // cdg_origen.Text = Convert.ToString(dgv_anexo.CurrentRow.Cells["cdg_origen"].Value);
          
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            posicion = 0;

            dgv_anexo.CurrentCell = dgv_anexo.Rows[posicion].Cells[1];

           // cdg_origen.Text = Convert.ToString(dgv_anexo.CurrentRow.Cells["cdg_origen"].Value);
          

        }

        private void btn_utlimo_Click(object sender, EventArgs e)
        {
            posicion = dgv_anexo.Rows.Count - 1;

            dgv_anexo.CurrentCell = dgv_anexo.Rows[posicion].Cells[1];

           // cdg_origen.Text = Convert.ToString(dgv_anexo.CurrentRow.Cells["cdg_origen"].Value);
        }

        private void btn_filtro_Click(object sender, EventArgs e)
        {
            if (dgv_anexo.Rows.Count == 0)
            {
                util.mensaje("No Existe Informacion para filtrar", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
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
            if (!verificar_acceso())
                return;

            if (dgv_anexo.Rows.Count == 0)
            {
                util.mensaje("No existe información para editar", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }


            //if (Convert.ToString(dgv_anexo.CurrentRow.Cells["Estado"].Value) != "PENDIENTE")
            //{
            //    MessageBox.Show("El requerimiento no puede ser modificado", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //    return;
            //}

            //string solicitante = Convert.ToString(dgv_anexo.CurrentRow.Cells["Solicitante"].Value);

            //if (solicitante != usuario)
            //{
            //    MessageBox.Show("El requerimiento no puede ser modificado por un usuario diferente al solicitante", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //    return;
            //}

            activar_boton(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true);
            //cargar_grilla();
            util.EstablecerAuditoria("Editar", usuario, "", "FrmPedidos", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
            btn_grabar.Enabled = true;
            btn_grabar.Text = "Actualizar";
            tc_anexo.TabPages.Add(tp_nuevo);

            tp_nuevo.Text = @"Editar";
            btnSuprimir.Visible = true;
            allowSelect = true;
            tc_anexo.SelectedIndex = 1;
            allowSelect = false;

       
          
            txt_obs.ReadOnly = false;
            txt_obs.Enabled = true;

            txt_obs.ReadOnly = false;
       

        }

        #endregion

        #region Menu contextual

        private void cm_grilla_copia_Click(object sender, EventArgs e)
        {
            util.copiar_contextual(dgv_anexo);
        }

        private void cm_grilla_copia_tabla_Click(object sender, EventArgs e)
        {
            util.copiar_todo_encabezados(dgv_anexo);
        }

        private void logDeModificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmLogModificaciones log = new FrmLogModificaciones();
            log.requerimiento = Convert.ToString(dgv_anexo.CurrentRow.Cells["Requerimiento"].Value);
            log.ShowDialog(this);
        }


        #endregion

        private void dgv_anexo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                pasar_dgv_to_txt(e.RowIndex);
            }
        }

        private void pasar_dgv_to_txt(int rownum)
        {
            DataGridViewRow row = dgv_anexo.Rows[rownum];
            txtDni.Text = row.Cells["DNI"].Value.ToString();
            txtNombre.Text = row.Cells["NOMBRE"].Value.ToString();
            txtAnexo.Text = row.Cells["ANEXO"].Value.ToString();
            txtRpc.Text = row.Cells["RPC"].Value.ToString();
            txtOtro.Text = row.Cells["OTRO"].Value.ToString();
            txtArea.Text = row.Cells["AREA"].Value.ToString();
            txtCargo.Text = row.Cells["CARGO"].Value.ToString();            
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (txtDni.Text=="99999999")
            {
                return;
            }
            
            if (txtDni.Text.Length==8)
            {
                try
                    {
                        DataTable dtRegistro = Negocio.buscar_anexo(txtDni.Text);
                        DataRow dr = dtRegistro.Rows[0];
                        txtNombre.Text = dr["NOMBRE"].ToString();
                        txtArea.Text = dr["AREA"].ToString();
                        txtCargo.Text = dr["CARGO"].ToString();       
                    }
                catch (Exception)
                    {
                        util.mensaje("DNI no registrado en el StarSoft", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    }
            }
        }

        private void t_msg_Tick(object sender, EventArgs e)
        {
            lbl_msg.Text = string.Empty;

            ss_load.BackColor = Color.Transparent;
            lbl_contador_registros.Visible = true;
            lbl_msg.Visible = false;
        }

        private void btnSuprimir_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Está seguro de suprimir este registro?", "Suprimir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result1 == DialogResult.Yes)
            {
                try
                {
                    if (txtDni.Text=="99999999")
                    {
                        int aa = Negocio.suprimir_registro_anexo(txtNombre.Text, "nom");
                    }
                    else
                    {
                        int aa = Negocio.suprimir_registro_anexo(txtDni.Text,"dni");
                    }
                    util.mensaje("Se eliminó registro de manera exitosa", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, txt_operacion.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                }

                finally
                {
                    cargar_grilla();
                    limpiar();
                    //valida_permisos(perfil);
                    activar_boton(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
                    btnSuprimir.Visible = false;
                    btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));

                    tc_anexo.TabPages.Remove(tp_nuevo);
                    tc_anexo.TabPages.Remove(tp_auditoria);

                    allowSelect = true;
                    tc_anexo.SelectedIndex = 0;
                }
            }
        }

        private void chkOtro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOtro.Checked)
            {
                txtDni.Enabled = false;
                txtNombre.Enabled = true;
                txtNombre.Focus();
            }
            else
            {
                txtDni.Enabled = true;
                txtNombre.Enabled = false;
                txtDni.Focus();
            }
        }

        
      
    }
}
