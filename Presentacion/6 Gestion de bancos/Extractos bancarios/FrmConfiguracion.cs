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
    public partial class FrmConfiguracion : Form
    {

       #region Variables globales

        public string usuario, perfil, bd_sap, titulo_, CodigoBanco, Banco;

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


        private BankPages extracto;
        private SAPbobsCOM.SBObob oSBObob;


        string MontoCredito, MontoDebito, FechaOperacion, Referencia;
        string ColMonto, proveedor, textbody, IP, concatenar, DNI, AREA, EMPLEADO, PERFIL;
        int posicion, columna, pedido, id_solicitud, NumLinea = 0;

        int cant_col, ColumnaId, id;
        int[] vector, vec_col;
        bool[] vec_falg;
        bool visible_;

        #endregion

        #region Formulario

        public FrmConfiguracion()
        {
              InitializeComponent();
         
        }

        private void ninimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void salir_Click(object sender, EventArgs e)
        {
            Close();
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

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(247, 247, 247);
            lbl_banco.Text = Banco;

            txt_montocredito.Text = Convert.ToString(AccesoLogica.listar_columnas_eb("consultar", CodigoBanco, "MontoCredito").Rows[0][0]);
            txt_montodebito.Text = Convert.ToString(AccesoLogica.listar_columnas_eb("consultar", CodigoBanco, "MontoDebito").Rows[0][0]);
            txt_fechaoperacion.Text = Convert.ToString(AccesoLogica.listar_columnas_eb("consultar", CodigoBanco, "FechaOperacion").Rows[0][0]);
            txt_referencia.Text = Convert.ToString(AccesoLogica.listar_columnas_eb("consultar", CodigoBanco, "Referencia").Rows[0][0]);
            txt_info.Text = Convert.ToString(AccesoLogica.listar_columnas_eb("consultar", CodigoBanco, "InfoDetallada").Rows[0][0]);
            txt_filas.Text = Convert.ToString(AccesoLogica.listar_columnas_eb("consultar", CodigoBanco, "MontoCredito").Rows[0][1]);
            txt_correlativo.Text = Convert.ToString(AccesoLogica.listar_columnas_eb("consultar", CodigoBanco, "MontoCredito").Rows[0][2]);



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

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            #region validaciones

            if (txt_montocredito.Text == string.Empty)
              {
                  util.mensaje("El campo " + lbl_montocredito.Text + " no debe estar vacio; indique un valor para " + lbl_montocredito.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                    txt_montocredito.Focus();
                    return;
                
              }

            if (txt_montodebito.Text == string.Empty)
            {
                util.mensaje("El campo " + lbl_montodebito.Text + " no debe estar vacio; indique un valor para " + lbl_montodebito.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txt_montodebito.Focus();
                return;

            }

            if (txt_fechaoperacion.Text == string.Empty)
            {
                util.mensaje("El campo " + lbl_fechaoperacion.Text + " no debe estar vacio; indique un valor para " + lbl_fechaoperacion.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txt_fechaoperacion.Focus();
                return;

            }

            if (txt_referencia.Text == string.Empty)
            {
                util.mensaje("El campo " + lbl_referencia.Text + " no debe estar vacio; indique un valor para " + lbl_referencia.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txt_referencia.Focus();
                return;

            }

            if (txt_filas.Text == string.Empty)
            {
                util.mensaje("El campo " + lbl_filas.Text + " no debe estar vacio; indique un valor para " + lbl_filas.Text + ".", false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                txt_filas.Focus();
                return;

            }

            #endregion

            try
            {
                int resultado = Negocio.mantenimiento_OCEB(CodigoBanco, lbl_banco.Text, txt_montocredito.Text, Convert.ToInt32(txt_filas.Text), "MontoCredito");
                if (resultado == 0) Negocio = null;

                int resultado_1 = Negocio.mantenimiento_OCEB(CodigoBanco, lbl_banco.Text, txt_montodebito.Text, Convert.ToInt32(txt_filas.Text), "MontoDebito");
                if (resultado_1 == 0) Negocio = null;

                int resultado_2 = Negocio.mantenimiento_OCEB(CodigoBanco, lbl_banco.Text, txt_fechaoperacion.Text, Convert.ToInt32(txt_filas.Text), "FechaOperacion");
                if (resultado_2 == 0) Negocio = null;

                int resultado_3 = Negocio.mantenimiento_OCEB(CodigoBanco, lbl_banco.Text, txt_referencia.Text, Convert.ToInt32(txt_filas.Text), "Referencia");
                if (resultado_3 == 0) Negocio = null;

                int resultado_4 = Negocio.mantenimiento_OCEB(CodigoBanco, lbl_banco.Text, txt_info.Text, Convert.ToInt32(txt_filas.Text), "InfoDetallada");
                if (resultado_4 == 0) Negocio = null;

                int resultado5 = Negocio.actualizar_correlativo(CodigoBanco, Convert.ToInt32(txt_correlativo.Text));
                if (resultado5 == 0) Negocio = null;

                util.mensaje("Operación finalizada con éxito.", true, lbl_contador_registros, lbl_msg, ss_load, t_msg);


                IForm_configuracion configuracion = this.Owner as IForm_configuracion;

                if (configuracion != null)
                    configuracion.actualizar();
                Close();
            }
            catch (Exception ex)
            {
                util.mensaje(ex.Message, false, lbl_contador_registros, lbl_msg, ss_load, t_msg);
                return;
            }
        }

        #endregion


    }
}
