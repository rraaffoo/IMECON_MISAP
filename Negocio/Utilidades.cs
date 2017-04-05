using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing.Text;
using System.Data;
using System.IO;
using System.Diagnostics;
using System.Resources;
//using System.Runtime.InteropServices;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace MISAP
{



    public interface IForm_login
    {
        void pasar_credenciales(string usuario, string perfil_cod, string perfil_des,string bd_externa, string version, string dni, string ip);
    }


    public interface IForm_Clave
    {
        void pasar_clave(string clave_actual, string clave, string confirmacion);
    }

    public interface IForm_opciones
    {
        void pasar_valores(string par1, string par2, string par3, string par4, string par5, string par6);
    }

    public interface IForm_Listado
    {
        void pasar_valores(string par1, string par2, string par3, string par4, string par5, string par6);
    }

    public interface IForm_configuracion
    {
        void actualizar();
    }

    public interface IForm_filtro
    {
        void pasar_valores_filtro(string par1, string par2, string par3, string par4, string par5, string par6, string par7, string par8, string par9, string par10, string par11);
    }

    public interface IForm_parametrizacion
    {
        void pasar_valores_parametrizacion(int[] par1, bool[] par2);
    }
    
    public class Utilidades
    {
        public static decimal total_soles, total_usd, total_Col1, total_Col2;

        public interface IForm
        {
            void actualizar_cbo_proceso();
        }
        

        /// <summary>
        /// Funcion booleana encargada buscar y seleccionar un Row de un control DataGridView
        /// 
        /// </summary>
        /// <Autor>José Luis García Bautista</Autor>
        /// <typeparam name="T">Tipo de dato del valor bucado</typeparam>
        /// <param name="dgv">Control DataGridView donde se realizara la busqueda</param>
        /// <param name="searchedValue">Valor buscado</param>
        /// <param name="columnIndex">Indice de la columna que contiene el valor a buscar</param>
        /// <returns>True si el valor fue encontrado en caso contrario False</returns>
        public static bool FindValue<T>(DataGridView dgv, T searchedValue, int columnIndex)
        {
            DataGridViewRow row = dgv.Rows.Cast<DataGridViewRow>().FirstOrDefault(x => searchedValue.Equals(Convert.ChangeType(x.Cells[columnIndex].Value, typeof(T))));

            if (row != null)
            {

                dgv.CurrentCell = dgv.Rows[row.Index].Cells[columnIndex];

                dgv.FirstDisplayedCell = dgv.CurrentCell;

                return true;
            }
            return false;
        }

        /// <summary>
        /// Método encargado de Establecer la posición del ultimo Row 
        /// ingresado en un control DataGridView
        /// </summary>
        /// <param name="dgv">Control DataGridView</param>
        public void DataGridViewRowPosition(DataGridView dgv)
        {
            DataGridViewCell cell = dgv.CurrentCell;
            if (cell == null) return;

            cell = dgv.Rows[dgv.RowCount - 1].Cells[0];
            dgv.CurrentCell = cell;
            if (dgv.CurrentRow != null) dgv.CurrentRow.Selected = true;
         
        }

        /// <summary>
        /// Método encargado de copiar al Clipboard el valor contenido en el Parametro
        /// dataValue
        /// </summary>
        /// <param name="dataValue"></param>
        public static void CopyCellToClipboard(string dataValue)
        {
            Clipboard.SetText(dataValue);
        }

        /// <summary>
        /// Método encargado de copiar al ClipBoard el valor del Row actual
        /// del control DataGridview enviado
        /// </summary>
        /// <param name="dgv"></param>
        public static void CopyRowToClipboard(DataGridView dgv)
        {
            DataObject dataObj = dgv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        
        public void copiar_contextual(DataGridView _dgv)
        {
            DataObject d = _dgv.GetClipboardContent();
            Clipboard.SetDataObject(d);
        }
        
        public void copiar_todo_encabezados(DataGridView _dgv)
        {
            //Copy to clipboard
            _dgv.SelectAll();
            _dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            DataObject dataObj = _dgv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            _dgv.ClearSelection();
          //  MessageBox.Show("Se copio al portapapeles");
          
        }
        
        public void copiar_todo_sin_encabezados(DataGridView _dgv)
        {
            //Copy to clipboard
            _dgv.SelectAll();
            _dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            DataObject dataObj = _dgv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            _dgv.ClearSelection();
            //  MessageBox.Show("Se copio al portapapeles");

        }

        public void TotalizarGrilla(DataGridView grilla)

        {
            
            decimal total_sol, total_dolar, total_sol_ = 0 , total_dolar_ = 0;

            if (grilla.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in grilla.Rows)
                {
                    total_sol = Convert.ToDecimal(row.Cells["Total"].Value);
                    total_sol_ = total_sol_ + total_sol;


                    total_dolar = Convert.ToDecimal(row.Cells["Total Dolares"].Value);
                    total_dolar_ = total_dolar_ + total_dolar;

                }

                total_soles = total_sol_;
               total_usd =  total_dolar_;
            
            }



             
        }

        public static decimal Total_SOL
        {
            get 
            {
                
                return total_soles; 
            }
        }

        public static decimal Total_USD
        {
            get
            {

                return total_usd;
            }
        }

        public void TotalizarGrilla_2(DataGridView grilla, string ColName_1, string ColName_2)
        {

            decimal total_1, total_2, total_1_ = 0, total_2_ = 0;

            if (grilla.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in grilla.Rows)
                {
                    total_1 = Convert.ToDecimal(row.Cells[ColName_1].Value);
                    total_1_ = total_1_ + total_1;


                    total_2 = Convert.ToDecimal(row.Cells[ColName_2].Value);
                    total_2_ = total_2_ + total_2;

                }

                total_Col1 = total_1_;
                total_Col2 = total_2_;

            }




        }

        public static decimal Total_1
        {
            get
            {

                return total_Col1;
            }
        }

        public static decimal Total_2
        {
            get
            {

                return total_Col2;
            }
        }


        public void CrearUsuarioAD()
        {

            try
            {
                PrincipalContext contextoUsuarios = new PrincipalContext(ContextType.Domain, "imecon.com", "eterrones", "3_t3rr0n3s");
                UserPrincipal usuario = new UserPrincipal(contextoUsuarios, "eterronesr", "Imecon2016.", true);
                usuario.GivenName = "Edison Carlos";
                usuario.Surname = "Terrones Rojas";
                usuario.UserPrincipalName = "eterronesr";
                // usuario.Name = "eterrones";
                usuario.DisplayName = "Edison Carlos Terrones Rojas";
                usuario.Description = "TIC";
                usuario.EmailAddress = "eterronesr@imecon.com.pe";
                // usuario.SetPassword("Imecon2016.");
                usuario.ExpirePasswordNow();
                //usuario.PasswordNeverExpires = true;
                usuario.Save();

                PrincipalContext contextoGrupos = new PrincipalContext(ContextType.Domain, "imecon.com", "ou=TIC,dc=imecon.com,dc=com", "eterrones", "3_t3rr0n3s");
                GroupPrincipal grupo = GroupPrincipal.FindByIdentity(contextoGrupos, "TIC");
                grupo.Members.Add(usuario);
                grupo.Save();
            }
            catch (Exception ex)
            {
                
            }
                      
        }

        public void FormatearGrilla(DataGridView grilla, bool ordenar)
        {
            try
            {
                grilla.RowHeadersVisible = true;
                grilla.RowHeadersWidth = 31;
                grilla.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                grilla.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 231, 231);
                grilla.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                grilla.RowHeadersDefaultCellStyle.Font = new Font("Tahoma", 8);
                grilla.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grilla.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(194, 200, 205);
                grilla.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

                grilla.BackgroundColor = Color.FromArgb(231, 231, 231);
                grilla.BackColor = Color.FromArgb(231, 231, 231);
                grilla.GridColor = Color.FromArgb(204, 204, 204);
                grilla.DefaultCellStyle.BackColor = Color.FromArgb(231, 231, 231);
                grilla.DefaultCellStyle.ForeColor = Color.Black;
                grilla.DefaultCellStyle.Font = new Font("Tahoma", 7.4F);
                grilla.RowTemplate.Height = 16;
                grilla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 231, 231);
                grilla.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                grilla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                grilla.ColumnHeadersHeight = 16;
                grilla.DefaultCellStyle.SelectionBackColor = Color.FromArgb(252, 221, 130);
                grilla.DefaultCellStyle.SelectionForeColor = Color.Black;
                          

                if (ordenar == false)
                {
                    foreach (DataGridViewColumn col in grilla.Columns)
                    {
                        col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }                
                }

                //for (int i = 0; i < grilla.Rows.Count; i++)
                //{
                //    grilla.Rows[i].HeaderCell.Value = (i + 1).ToString();
                //    //grilla.Rows[i].HeaderCell.Style.Font = new Font("Calibri", 8);
                //}

                //DataGridViewCellStyle style = new DataGridViewCellStyle();
                //style.Font = new Font(grilla.Font, FontStyle.Bold);
                //grilla.Rows[4].DefaultCellStyle = style;



            }
            catch(Exception ex)
            {
                MessageBox.Show("Error debido a: " + ex.ToString());
            }
        }

        public void FormatearGrillaDefiniciones(DataGridView grilla, bool ordenar)
        {
            try
            {
                grilla.RowHeadersVisible = true;
                grilla.RowHeadersWidth = 31;
             //   grilla.SelectionMode = DataGridViewSelectionMode.CellSelect;
                grilla.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 231, 231);
                grilla.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                grilla.RowHeadersDefaultCellStyle.Font = new Font("Tahoma", 8);
                grilla.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grilla.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(194, 200, 205);
                grilla.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
               /// grilla.Columns[0].HeaderText = "#";
                                
                grilla.BackgroundColor = Color.FromArgb(255, 255, 255);
                grilla.BackColor = Color.FromArgb(255, 255, 255);
                grilla.GridColor = Color.FromArgb(204, 204, 204);
                grilla.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                grilla.DefaultCellStyle.ForeColor = Color.Black;
                grilla.DefaultCellStyle.Font = new Font("Tahoma", 7.4F);
                grilla.RowTemplate.Height = 16;
                grilla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 231, 231);
                grilla.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                grilla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                grilla.ColumnHeadersHeight = 16;
             grilla.DefaultCellStyle.SelectionBackColor = Color.FromArgb(254, 240, 158);
              grilla.DefaultCellStyle.SelectionForeColor = Color.Black;



                //if (ordenar == false)
                //{
                //    foreach (DataGridViewColumn col in grilla.Columns)
                //    {
                //        col.SortMode = DataGridViewColumnSortMode.NotSortable;
                //    }
                //}

                //for (int i = 0; i < grilla.Rows.Count; i++)
                //{
                //    grilla.Rows[i].HeaderCell.Value = (i + 1).ToString();
                //    grilla.Rows[i].HeaderCell.Style.Font = new Font("Tahoma", 6.4F); ;
                //}

                //DataGridViewCellStyle style = new DataGridViewCellStyle();
                //style.Font = new Font(grilla.Font, FontStyle.Bold);
                //grilla.Rows[4].DefaultCellStyle = style;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error debido a: " + ex.ToString());
            }
        }

        public void FormatearFormulario(Form formulario, ToolStrip acciones, TabControl tab, StatusStrip estado, System.Windows.Forms.TextBox buscar, TabPage tp_listado, TabPage tp_nuevo, TabPage tp_auditoria)
        {
         
            formulario.Location = new System.Drawing.Point(320, 0);
            formulario.BackColor = Color.FromArgb(247, 247, 247);
            acciones.BackColor = Color.FromArgb(253, 253, 253);
            buscar.BackColor = Color.FromArgb(254, 240, 158);
            tp_listado.BackColor = Color.FromArgb(247, 247, 247);
            tp_nuevo.BackColor = Color.FromArgb(247, 247, 247);
            tp_auditoria.BackColor = Color.FromArgb(247, 247, 247);

            estado.BackColor = Color.FromArgb(231, 231, 231);


            tab.TabPages.Remove(tp_nuevo);
            tab.TabPages.Remove(tp_auditoria);

        }

        public void FormatearFormulario_sap(Form formulario, ToolStrip acciones, TabControl tab, StatusStrip estado, TabPage tp_listado, TabPage tp_auditoria)
        {

            formulario.Location = new System.Drawing.Point(320, 0);
            formulario.BackColor = Color.FromArgb(247, 247, 247);
            acciones.BackColor = Color.FromArgb(253, 253, 253);
            estado.BackColor = Color.FromArgb(231, 231, 231);
            tab.TabPages.Remove(tp_listado);
            tab.TabPages.Remove(tp_auditoria);
        }

        public void FormatearFormulario_sap_informe(Form formulario, ToolStrip acciones, TabControl tab, StatusStrip estado,System.Windows.Forms.TextBox buscar, TabPage tp_listado, TabPage tp_auditoria)
        {

            formulario.Location = new System.Drawing.Point(320, 0);
            formulario.BackColor = Color.FromArgb(247, 247, 247);
            acciones.BackColor = Color.FromArgb(253, 253, 253);
            estado.BackColor = Color.FromArgb(231, 231, 231);

            buscar.BackColor = Color.FromArgb(254, 240, 158);
            tp_listado.BackColor = Color.FromArgb(247, 247, 247);
            tp_auditoria.BackColor = Color.FromArgb(247, 247, 247);

            estado.BackColor = Color.FromArgb(231, 231, 231);
           // formulario.Font = new Font("Tahoma", 7.50F);


            tab.TabPages.Remove(tp_auditoria);
        }


        public void Formateardetalle(TabPage tp_contenido, TabPage tp_anexo )
        {
            tp_contenido.BackColor = Color.FromArgb(247, 247, 247);
            tp_anexo.BackColor = Color.FromArgb(247, 247, 247);
           

        }

        public void limpiarTextBoxes(Control parent)
        {

            //Limpiar de manera rapida

            foreach (Control c in parent.Controls)
            {

                if (c is TextBox)
                {
                    
                    c.Text = "";

                }

                if (c.Controls.Count > 0)
                {

                    limpiarTextBoxes(c);

                }

            }

        }


        public void tamanioTextBoxes(Control parent)
        {

            //Limpiar de manera rapida

            foreach (Control c in parent.Controls)
            {

                if (c is TextBox)
                {
                    c.AutoSize = false;
                    c.Size = new System.Drawing.Size(148, 16);
                }

                if (c.Controls.Count > 0)
                {

                    tamanioTextBoxes(c);

                }

            }
        }

        public void BloquearTextBoxes(Control parent)
        {

            //Limpiar de manera rapida

            foreach (Control c in parent.Controls)
            {

                if (c is TextBox)
                {

                    c.Enabled = false;
                }

                if (c.Controls.Count > 0)
                {

                    BloquearTextBoxes(c);

                }

            }

        }

        public void EstablecerAuditoria(string operacion, string usuario, string tipodoc, string formulario, string estado_reg, System.Windows.Forms.TextBox usuario_crea, System.Windows.Forms.TextBox fecha_crea, System.Windows.Forms.TextBox terminal_crea, System.Windows.Forms.TextBox usuario_modi, System.Windows.Forms.TextBox fecha_modi, System.Windows.Forms.TextBox terminal_modi, System.Windows.Forms.TextBox txtformulario, System.Windows.Forms.TextBox txtoperacion, System.Windows.Forms.TextBox txtestado_reg, System.Windows.Forms.TextBox txttipodoc)
        {
            //Establece valores de auditoria

            if (operacion == "Nuevo")
            {
                usuario_crea.Text = usuario;
                fecha_crea.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                terminal_crea.Text = Environment.MachineName;
            }

            if (operacion == "Editar" || operacion == "Eliminar")
            {

                usuario_modi.Text = usuario;
                fecha_modi.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                terminal_modi.Text = Environment.MachineName;
            }

            txtoperacion.Text = operacion;
            txtformulario.Text = formulario;
            txtestado_reg.Text = estado_reg;
            txttipodoc.Text = tipodoc;


        }
        
        public void ExportarDataGridViewExcel(DataGridView dgv, string titulo)
        {
            try
            {
                //SaveFileDialog fichero = new SaveFileDialog();
                //fichero.Filter = "Excel (*.xlsx)|*.xlsx";
                //fichero.FileName = titulo;

                //if (fichero.ShowDialog() == DialogResult.OK)
                //{
                //    Excel.Application excel = new Excel.Application();
                //    Excel._Workbook libro = null;
                //    Excel._Worksheet hoja = null;
                //    Excel.Range rango = null;
                //    string temp;

                //    libro = (Excel._Workbook)excel.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                //    hoja = (Excel._Worksheet)libro.Worksheets.Add();
                //    hoja.Name = "Datos";
                //    ((Excel._Worksheet)excel.ActiveWorkbook.Sheets["Hoja1"]).Delete();

                //    for (int z = 1; z <= grd.Columns.Count; z++)
                //    {
                //        if (grd.Columns[z-1].Visible == true)
                //        {
                //            hoja.Cells[1, z] = grd.Columns[z - 1].HeaderText;
                //        }
                //    }

                //    //Recorremos el DataGridView rellenando la hoja de trabajo
                //    for (int i = 0; i < grd.Rows.Count; i++)
                //    {
                //            for (int j = 0; j < grd.Columns.Count; j++)
                //            {
                //              //  if (grd.Columns[j].Visible == true)
                //               // {
                //                    //temp = grd[j, i].Value.ToString();
                //                    //hoja.Cells[i + 2, j+1] = temp;

                //                    hoja.Cells[i + 2, j + 1] = grd.Rows[i].Cells[j].Value.ToString();

                //                    //hoja.Cells[i + 2, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                //                //}
                //            }
                //    }        

                //    //hoja.Columns.AutoFit();
                //    libro.Saved = true;
                //    libro.SaveAs(fichero.FileName);
                //    libro.Close(true);
                //    excel.Quit();
                //    MessageBox.Show("Se genero el archivo exitosamente", "MS EXCEL", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                //}

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = titulo + ".xls";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    copyAlltoClipboard(dgv);    // copiar datos del datagridview

                    object misValue = System.Reflection.Missing.Value;
                    Excel.Application xlexcel = new Excel.Application();

                    xlexcel.DisplayAlerts = false;      // no mostrar mensajes de alerta
                    Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                    Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];  // pegar datos copiados
                    CR.Select();
                    xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                    Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;    //borro la primera columna
                    delRng.Delete(Type.Missing);
                    xlWorkSheet.get_Range("A1").Select();

                    xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);   // guardar archivo en posicion indicada
                    xlexcel.DisplayAlerts = true;
                    xlWorkBook.Close(true, misValue, misValue);
                    xlexcel.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlexcel);

                    Clipboard.Clear();      // limpiar clipboard
                    dgv.ClearSelection();

                    if (File.Exists(sfd.FileName))      // abrir archivo excel generado
                        System.Diagnostics.Process.Start(sfd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error debido a: " + ex.ToString());
            }

        }

        public void exportarExcel(DataGridView dgv)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Exportado_a_Excel.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                copyAlltoClipboard(dgv);    // copiar datos del datagridview

                object misValue = System.Reflection.Missing.Value;
                Excel.Application xlexcel = new Excel.Application();

                xlexcel.DisplayAlerts = false; // no mostrar mensajes de alerta
                Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                Excel.Range rng = xlWorkSheet.get_Range("A:B").Cells;       // formato de la columna A y B                
                rng.NumberFormat = "@";

                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];      // pegar datos copiados
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;    //borro la primera columna
                delRng.Delete(Type.Missing);
                xlWorkSheet.get_Range("A1").Select();

                xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);   // guardar archivo en posicion indicada
                xlexcel.DisplayAlerts = true;
                xlWorkBook.Close(true, misValue, misValue);
                xlexcel.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlexcel);

                Clipboard.Clear();      // limpiar clipboard
                dgv.ClearSelection();

                if (File.Exists(sfd.FileName))      // abrir archivo excel generado
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        private void copyAlltoClipboard(DataGridView dgv)
        {
            dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgv.SelectAll();
            DataObject dataObj = dgv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }


        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Error " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }


        public void importarExcel(DataGridView dgv, String nombreHoja)
        {
            OleDbConnection conn;
            OleDbDataAdapter MyDataAdapter;
            DataTable dt;
            String ruta = "";
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files |*.xlsx";
                openfile1.Title = "Seleccione el archivo de Excel a importar";
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        ruta = openfile1.FileName;
                    }
                }

                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                MyDataAdapter = new OleDbDataAdapter("Select * from [" + nombreHoja + "$]", conn);
                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception)
            {

                dgv.DataSource = null;

            }
        }

        public void mensaje(string msg, bool tipo, ToolStripStatusLabel lcontador, ToolStripStatusLabel lmsg, StatusStrip sload, Timer tmsg)
        {
            //tipo true=exito false=error

            
            if (tipo == true)
            {
             
                lcontador.Visible = false;
                lmsg.Visible = true;
                lmsg.BackgroundImage =  ((System.Drawing.Image)(Negocio.Properties.Resources.StatusSuccess));
                sload.BackColor = Color.FromArgb(127, 182, 123);
                lmsg.ForeColor = Color.Black;
                lmsg.Text = "     " + msg;
                tmsg.Start();
               
            }

            if (tipo == false)
            {
                lcontador.Visible = false;
                lmsg.Visible = true;
                lmsg.BackgroundImage = ((System.Drawing.Image)(Negocio.Properties.Resources.StatusError));
                sload.BackColor = Color.FromArgb(204, 0, 0);
                lmsg.ForeColor = Color.White;
                lmsg.Text = "     " + msg;
                tmsg.Start();
            }


        }

        public void mensaje_espera(string msg, bool tipo, ToolStripStatusLabel lcontador, ToolStripStatusLabel lmsg, StatusStrip sload, bool show)
        {
                                  
            lcontador.Visible = !show;
            lmsg.Visible = show;
            lmsg.BackgroundImage = ((System.Drawing.Image)(Negocio.Properties.Resources.StatusWarning));
            if(show == true)
            {
                sload.BackColor =  Color.FromArgb(159, 177, 203);
            }
            else
            {
                sload.BackColor =  Color.Transparent;
            }
            lmsg.ForeColor = Color.Black;
            lmsg.Text = "     " + msg;
          

        }
        
        public Boolean EsFecha(String fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean EsNumero(String numero)
        {
            try
            {
                Decimal.Parse(numero);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void FormatearCombo(object sender, DrawItemEventArgs e, string display)
        {
            if (e.Index < 0)
                return;

            ComboBox combo = sender as ComboBox;

            DataRowView drv = ((DataRowView)(combo.Items[e.Index]));
            string name = drv[display].ToString();


            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(252, 220, 130)), e.Bounds);
            else
                e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);

            e.Graphics.DrawString(name, e.Font, new SolidBrush(combo.ForeColor), new System.Drawing.Point(e.Bounds.X, e.Bounds.Y));

            e.DrawFocusRectangle();
        }

        public Boolean validar_mail(String email)
        {

            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void validar_numeros(System.Windows.Forms.TextBox txt, KeyPressEventArgs e)
        {
            bool IsDec = false;
            int nroDec = 0;

            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            for (int i = 0; i < txt.Text.Length; i++)
            {
                if (txt.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }

            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        public void ConexionSap(string bd_sap)
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

            // Environment.Exit(0);
        
        }

        public class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(252, 220, 130); }
            }

         

            public override Color MenuItemPressedGradientBegin
            {
                get
                {
                    return Color.Empty;
                }
            }

            public override Color ImageMarginRevealedGradientBegin
            {
                get
                {
                    return Color.Empty;
                }
            }

            public override Color ImageMarginRevealedGradientEnd
            {
                get
                {
                    return Color.Empty;
                }
            }

            public override Color ImageMarginGradientBegin
            {
                get
                {
                    return Color.Empty;
                }
            }

            public override Color ImageMarginGradientEnd
            {
                get
                {
                    return Color.Empty;
                }
            }
            public override Color MenuItemPressedGradientEnd
            {
                get
                {
                    return Color.Empty;
                }
            }
            public override Color MenuItemBorder
            {
                get
                {
                    return Color.Empty;
                }
            }

            public override Color MenuBorder
            {
                get
                {
                    return Color.Empty;
                }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.Empty; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.Empty; }
            }

            public override Color  ButtonSelectedGradientBegin
            {
	            get 
	            { 
                    return  Color.FromArgb(242, 242, 242); 
		           
	            }
            }

            public override Color ButtonSelectedGradientEnd
            {
                get
                {
                    return Color.FromArgb(250, 250, 250); 
                }
            }

            public override Color ButtonSelectedGradientMiddle
            {
                get
                {
                    return Color.FromArgb(229, 229, 229);
                }
            }

            public override Color ButtonSelectedBorder
            {
                get
                {
                    return Color.FromArgb(177, 177, 177);
                }
            }
        }

    }

  


}
