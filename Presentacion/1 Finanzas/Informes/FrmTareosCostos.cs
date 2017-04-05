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
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;

namespace MISAP
{
    public partial class FrmTareosCostos : Form
    {

        #region Variables Globales

        public string formulario, titulo, usuario, cod_autorizacion;

        #endregion

        #region Variables locales


        private Point pos = Point.Empty;
        private bool move = false;


        Utilidades util = new Utilidades();
        AccesoLogica Negocio = new AccesoLogica();

        bool Ejecucion = false;
        FrmEspera espera = new FrmEspera();

        #endregion

        #region Formulario

        public FrmTareosCostos()
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

        #region Eventos

        private void FrmClave_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(247, 247, 247);

            dp_dDesde.CustomFormat = "dd/MM/yyyy";
            dp_dHasta.CustomFormat = "dd/MM/yyyy";

        }

        #endregion

        #region Botones

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            if (dp_dDesde.Text == string.Empty)
            {

                MessageBox.Show("Seleccione la fecha de inicio", titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                dp_dDesde.Focus();
                return;
            }

            if (dp_dHasta.Text == string.Empty)
            {

                MessageBox.Show("Seleccione la fecha fin", titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                dp_dHasta.Focus();
                return;
            }

            string mes =  Convert.ToString(dp_dHasta.Value.Month);

            if(Convert.ToInt32(mes) >= 10)
            {
                mes = Convert.ToString(dp_dHasta.Value.Month);
            }
            else
            {
                mes = 0 + Convert.ToString(dp_dHasta.Value.Month);
              
            }

            dgv_detalle.DataSource = AccesoLogica.listar_tareos_costos(dp_dDesde.Text, dp_dHasta.Text, "", "", "", "2", mes);
                //MessageBox.Show("Operación finalizada con éxito", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
             formatear_grilla(dgv_detalle);
                
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "\\\\10.0.0.8\\Comun\\MISAP\\RELOJ\\att.exe";
            proc.Start();
            proc.Close();
        }

        private void maximizar_Click(object sender, EventArgs e)
        {

        }

        void Accion()
        {
            try
            {
                    Excel.Application excel = new Excel.Application();
                    Excel._Workbook libro = null;
                    Excel._Worksheet hoja = null;
                    Excel.Range rango = null;
                    string temp;

                    libro = (Excel._Workbook)excel.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                    hoja = (Excel._Worksheet)libro.Worksheets.Add();
                    hoja.Name = "Datos";
                    ((Excel._Worksheet)excel.ActiveWorkbook.Sheets["Hoja1"]).Delete();

                    for (int z = 1; z <= dgv_detalle.Columns.Count; z++)
                    {
                        if (dgv_detalle.Columns[z - 1].Visible == true)
                        {
                            hoja.Cells[1, z] = dgv_detalle.Columns[z - 1].HeaderText;
                        }
                    }

                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 0; i < dgv_detalle.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgv_detalle.Columns.Count; j++)
                        {
                            //  if (grd.Columns[j].Visible == true)
                            // {
                            //temp = grd[j, i].Value.ToString();
                            //hoja.Cells[i + 2, j+1] = temp;

                            hoja.Cells[i + 2, j + 1] = dgv_detalle.Rows[i].Cells[j].Value.ToString();

                            //hoja.Cells[i + 2, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                            //}
                        }

                    }



                    //hoja.Columns.AutoFit();

                    libro.Saved = true;
                    libro.SaveAs(lbl_titulo.Text);
                    libro.Close(true);
                    excel.Quit();
                    MessageBox.Show("Se genero el archivo exitosamente", "MS EXCEL", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);


                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error debido a: " + ex.ToString());
            }

            Action a = () => { Ejecucion = false; espera.Close(); };
            espera.Invoke(a);
        
        }

        private void btn_exportar_xls_Click(object sender, EventArgs e)
        {
            if (dgv_detalle.Rows.Count == 0)
            {
                MessageBox.Show("No Existe Informacion para exportar", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            lbl_espera.Visible = true;
            lbl_contador_registros.Visible = false;
            lbl_espera.Text = "Procesando por favor espere";
            util.ExportarDataGridViewExcel(dgv_detalle, lbl_titulo.Text);
            lbl_espera.Visible = false;
            lbl_contador_registros.Visible = true;
            
            //SaveFileDialog fichero = new SaveFileDialog();
             //   fichero.Filter = "Excel (*.xlsx)|*.xlsx";
             //   fichero.FileName = lbl_titulo.Text;

             //   if (fichero.ShowDialog() == DialogResult.OK)
             //   {
             //       Thread tr = new Thread(Accion);
             //       tr.Start();
             //       //Es necesario lanzar el formMesaje como ShowDialog
             //       Ejecucion = true;

             //       //Evita que mientras se está ejecutando el thread se cierre el formulario
             //       espera.FormClosing += (o, p) =>
             //       {
             //           p.Cancel = Ejecucion;
             //       };

             //       espera.ShowDialog();
             //   }

          

           
        }

        void formatear_grilla(DataGridView grilla)
        {

            try
            {

                //dgv_usuarios.Columns["swt_usr"].Visible = false;
                //dgv_usuarios.Columns["cdg_perf"].Visible = false;
                //dgv_usuarios.Columns["psw_usr"].Visible = false;

                util.FormatearGrilla(grilla, false);
                lbl_contador_registros.Text = string.Format("Total de registros: {0}", grilla.Rows.Count);
                lbl_contador_registros.Visible = true;
            }
            catch
            {}

        }

        private void cm_grilla_copia_tabla_Click(object sender, EventArgs e)
        {
            util.copiar_todo_encabezados(dgv_detalle);
        }
       }
    }

