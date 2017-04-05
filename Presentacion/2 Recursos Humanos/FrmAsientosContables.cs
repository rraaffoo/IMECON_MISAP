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

namespace MISAP
{
    public partial class FrmAsientosContables : Form, IForm_opciones
    {

        #region Variables globales

        public string usuario, perfil;



        #endregion

        #region Variables locales

        private Point pos = Point.Empty;
        private bool move = false;
        bool allowSelect = false;
        bool Ejecucion = false;
             
        AccesoLogica Negocio = new AccesoLogica();
        Utilidades util = new Utilidades();
        FrmEspera espera = new FrmEspera();

        string filtro, CUENTA, EMPDNI, EMPNOM, GLOSA, CCOSTO, FECHA, TIPO, ESTADO, cod_provi;
        int columna, CRONO, CINT, LINEA, CSAP;
        decimal DEBIT, CREDIT, FCDEBIT, FCCREDIT;

        #endregion

        #region Formulario externo

        public void pasar_valores(string par1, string par2, string par3, string par4, string par5, string par6)
        {
            try
            {
                if (par5 == "Lista de mes de trabajo")
                {
                    txt_mes.Text = par2;

                    dgv_asientos.DataSource = AccesoLogica.listar_periodos_cronograma(par1);
                    formatear_grilla(dgv_asientos);

                    if (perfil == "001")
                    {
                        activar_boton(false, false, true, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Orden de Producción", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

       
        #endregion
        
        #region Formulario

         public FrmAsientosContables()
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

            this.WindowState = (this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized);

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

        #region Perzonalizacion de controles

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() :
                base(new Utilidades.MyColors()) { }
        }
        #endregion
        
        #region Eventos
        private void FrmAsientosContables_Load(object sender, EventArgs e)
        {

            this.Activate();

            //valida_permisos(perfil);



            util.FormatearFormulario(this, ts_acciones, tc_asientos, ss_load, txt_buscar, tp_listado, tp_nuevo, tp_auditoria);
         


          this.Location = new System.Drawing.Point(320, 100);
          txt_buscar.BackColor = Color.FromArgb(231, 231, 231);
          txt_mes.BackColor = Color.FromArgb(231, 231, 231);

          lbl_hostname.Text = Environment.MachineName;

        }
        #endregion

        #region botones

        private void btn_opciones_Click(object sender, EventArgs e)
        {
            FrmOpciones opciones = new FrmOpciones();
            opciones.titulo = "Lista de mes de trabajo";
            opciones.ShowDialog(this);
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

            txt_mes.Clear();


        }
        void formatear_grilla(DataGridView grilla)
        {

            try
            {

                util.FormatearGrilla(grilla,false);
                lbl_contador_registros.Text = string.Format("Total de registros: {0}", grilla.Rows.Count);
                //if (grilla == dgv_pedidos)
                //{
                //    dgv_pedidos.Columns["cdg_origen"].Visible = false;
                //    dgv_pedidos.Columns["U_CL_CODSOL"].Visible = false;
                //    dgv_pedidos.Columns["U_CL_SOLICI"].Visible = false;
                //    lbl_contador_registros.Visible = true;
                //    
                //}

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
                activar_boton(false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true);
            }
          

        }
        #endregion

        private void btn_nuevo_b_Click(object sender, EventArgs e)
        {
            txt_mes.ReadOnly = false;
            txt_mes.BackColor = Color.FromArgb(254, 240, 158);
            txt_mes.Focus();
            btn_opciones.Visible = true;
        }

        private void tc_asientos_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!allowSelect) e.Cancel = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            valida_permisos(perfil);

            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis_dasactivado));
            btn_grabar.Text = "Crear";

            limpiar();



            dgv_asientos.DataSource = null;
        //    formatear_grilla(dgv_pedidos);

            allowSelect = true;
            tc_asientos.SelectedIndex = 0;
            tc_asientos.TabPages.Remove(tp_nuevo);
            tc_asientos.TabPages.Remove(tp_auditoria);
            btn_opciones.Visible = true;
         
        }

        private void btn_consultar_b_Click(object sender, EventArgs e)
        {
            if (dgv_asientos.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para consultar", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }


           
            tc_asientos.TabPages.Add(tp_nuevo);
            tc_asientos.TabPages.Add(tp_auditoria);



            btn_grabar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
            activar_boton(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true);
         

            util.EstablecerAuditoria("Nuevo", usuario, "", "FrmAsientosContables", "A", txt_usr_crea, txt_fec_crea, txt_terminal_crea, txt_usr_modi, txt_fec_modi, txt_terminal_modi, txt_formulario, txt_operacion, txt_estado_registro, txt_tipodoc);

            allowSelect = true;
            tc_asientos.SelectedIndex = 1;
            allowSelect = false;

            CRONO = Convert.ToInt32(dgv_asientos.CurrentRow.Cells["CODIGO"].Value);
            cod_provi = Convert.ToString(dgv_asientos.CurrentRow.Cells["TIPO_PROVI"].Value);


            dgv_cabecera_asientos.DataSource = AccesoLogica.listar_asientos_planillas(CRONO, "Cabecera", cod_provi);
            formatear_grilla(dgv_cabecera_asientos);

            dgv_detalle_asientos.DataSource = AccesoLogica.listar_asientos_planillas(CRONO, "Detalle", cod_provi);
            formatear_grilla(dgv_detalle_asientos);

            btn_opciones.Visible = false;

            btn_validar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_enfasis));
            btn_validar.Enabled = true;
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            try
            {
                Thread tr = new Thread(accion_grabar_asiento);
                tr.Start();
                //Es necesario lanzar el formMesaje como ShowDialog
                Ejecucion = true;

                //Evita que mientras se está ejecutando el thread se cierre el formulario
                espera.FormClosing += (o, p) =>
                {
                    p.Cancel = Ejecucion;
                };

                espera.ShowDialog();


                MessageBox.Show("Operación finalizada con éxito.", "Grabar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            catch
            {
                espera.Close();
            }
        }

        #region Acciones

        private void accion_grabar_asiento()
        {

            try
            {
                foreach (DataGridViewRow row in dgv_cabecera_asientos.Rows)
                {
                    CINT = Convert.ToInt32(row.Cells["CINT"].Value);
                    FECHA = Convert.ToString(row.Cells["FECHA"].Value);
                    TIPO = Convert.ToString(row.Cells["TIPO"].Value);
                    GLOSA = Convert.ToString(row.Cells["GLOSA"].Value);
                    ESTADO = Convert.ToString(row.Cells["ESTADO"].Value);
                    //CSAP = Convert.ToInt32(row.Cells["CSAP"].Value);
                
                    int resultado_c = Negocio.grabar_cabecera_asiento(CINT,FECHA,TIPO,GLOSA,ESTADO,CSAP);
                    if (resultado_c == 0) Negocio = null;

                }


                foreach (DataGridViewRow row in dgv_detalle_asientos.Rows)
                {
                    CINT = Convert.ToInt32(row.Cells["CINT"].Value);
                    LINEA = Convert.ToInt32(row.Cells["LINEA"].Value);
                    CUENTA = Convert.ToString(row.Cells["CUENTA"].Value);
                    EMPDNI = Convert.ToString(row.Cells["EMPDNI"].Value);
                    EMPNOM = Convert.ToString(row.Cells["EMPNOM"].Value);
                    DEBIT = Convert.ToDecimal(row.Cells["DEBIT"].Value);
                    CREDIT = Convert.ToDecimal(row.Cells["CREDIT"].Value);
                    FCDEBIT = Convert.ToDecimal(row.Cells["FCDEBIT"].Value);
                    FCCREDIT = Convert.ToDecimal(row.Cells["FCCREDIT"].Value);
                    GLOSA = Convert.ToString(row.Cells["GLOSA"].Value);
                    CCOSTO = Convert.ToString(row.Cells["CCOSTO"].Value);

                    int resultado_d = Negocio.grabar_detalle_asiento
                        (CINT, LINEA, CUENTA, EMPDNI, EMPNOM, DEBIT, CREDIT, FCDEBIT, FCCREDIT, GLOSA, CCOSTO);
                    if (resultado_d == 0) Negocio = null;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " " + "Asiento detalle" + " " + CINT);
            }

            Action a = () =>
            {
                Ejecucion = false;
                espera.Close();

            };

            espera.Invoke(a);

        }

        #endregion

        private void btn_validar_Click(object sender, EventArgs e)
        {
            FrmDefiniciones definiciones = new FrmDefiniciones();
            definiciones.usuario = usuario;
            definiciones.perfil = perfil;
            definiciones.titulo_= "Homologacion plan de cuentas";
            definiciones.Show();
        }

       

    }
}
