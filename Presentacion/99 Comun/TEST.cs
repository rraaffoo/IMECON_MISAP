using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;
using System.Collections;
using System.IO;
using System.Diagnostics;
using System.Data.OleDb;
using System.Windows.Forms.VisualStyles;
using System.Reflection;


//using Excel = Microsoft.Office.Interop.Excel;
//using System.Reflection; 

namespace MISAP
{
    public partial class TEST : Form
    {
        int cant_total;
        string marca;
        string descripcion;
        string revision;
        string nro_op;
        int nro_trans;
        string ruta;
        string archivo;

        public Object oDoc;
        public string FileName;
        Utilidades util = new Utilidades();
       
        public TEST()
        
        {
            InitializeComponent();
         webBrowser2.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser2_DocumentCompleted);
                     }

        private void TEST_Load(object sender, EventArgs e)
        {
            dgv_d_prd_marca.DataSource = AccesoLogica.consultar_d_prd_marca("101-15", "AS", "","");

            dgv_elementos.DataSource = AccesoLogica.consultar_d_prd_marca("101-15", "AS", "", "");
            formatear_grilla();

            //Button link = new Button();
            //link.Image = ((System.Drawing.Image)(Properties.Resources.ButtonLink));

            DataGridViewButtonColumn colBotones = new DataGridViewButtonColumn();
            colBotones.Name = "colBotones";
            colBotones.HeaderText = "Valor Stock";

            this.dgv_elementos.Columns.Add(colBotones);

           

            //DataGridViewImageColumn columna = new DataGridViewImageColumn();
            //columna.Name = "Imagen";
            //dgv_elementos.Columns.Add(columna);
            //dgv_elementos.Rows[0].Cells["Imagen"].Value = ((System.Drawing.Image)(Properties.Resources.ButtonLink));
         

            openFileDialog1.Filter = "Documentos de Office (*.docx, *.xlsx, *.pptx)|*.docx;*.xlsx;*.pptx";
            openFileDialog1.FilterIndex = 1;
        }

        void formatear_grilla()
        {

            util.FormatearGrilla(dgv_elementos,false);


        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            oDoc = e.GetType().InvokeMember("document", System.Reflection.BindingFlags.GetProperty, null, e, null);
            Object oApplication = e.GetType().InvokeMember("Application", System.Reflection.BindingFlags.GetProperty, null, oDoc, null);

          //  oDoc = e.GetType().InvokeMember("Document", BindingFlags.GetProperty, null, e, null);
         //   Object oApplication = e.GetType().InvokeMember("Application", BindingFlags.GetProperty, null, oDoc, null);

        }

       


        private void button1_Click(object sender, EventArgs e)
        {
            AccesoLogica Negocio = new AccesoLogica();
            DataTable data2 = new DataTable();
            data2.Columns.Add("item", typeof(int));
            data2.Columns.Add("nro_op", typeof(string));
            data2.Columns.Add("marca", typeof(string));
            data2.Columns.Add("cant_unitario", typeof(int));
            data2.Columns.Add("nro_trans", typeof(int));

           // ArrayList STR = new ArrayList();
           // Hashtable Cadenas = new Hashtable();

            int j = 0;
            foreach (DataGridViewRow row in this.dgv_d_prd_marca.Rows)
            {
                if (Convert.ToBoolean(row.Cells["seleccion"].Value))
                {

                    data2.Rows.Add(Convert.ToInt32(row.Cells["item"].Value),
                        row.Cells["nro_op"].Value.ToString(),
                        row.Cells["marca"].Value.ToString(),
                        Convert.ToInt32(row.Cells["cant_unitario"].Value),
                         Convert.ToInt32(row.Cells["nro_trans"].Value)
                        
                        
                        );
                 j++;
                }
            }

            var rets = (from p in data2.AsEnumerable()
                        select p.Field<int>("item")).Distinct().ToArray();
            int i = 0;
            int par=0;
            int item=0;
           
       
            foreach (int el in rets)
            {

                par = el;
                i = 0;
                if (data2.Rows.Count > 0)
                foreach (DataRow row in data2.Rows)
                {


                    item = 0;
                    if (row["item"] != null)
                    {
                        item = Convert.ToInt32(row["item"]);
                        

                        if (par == item)
                        {
                            i++;
                            marca = Convert.ToString(row["marca"]);
                            nro_op = Convert.ToString(row["nro_op"]);
                            nro_trans = Convert.ToInt32(row["nro_trans"]);
                        }
                    }



                }
             
                int resultado = Negocio.sp_insertar_m_prd_test(par,nro_op, marca, i,nro_trans);
                if (resultado == 0) Negocio = null;
                
               
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string startFolder = @ruta;

            // Take a snapshot of the file system.
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(startFolder);

            // This method assumes that the application has discovery permissions
            // for all folders under the specified path.
            IEnumerable<System.IO.FileInfo> fileList = dir.GetFiles("*.*", System.IO.SearchOption.AllDirectories);

            //Create the query
            IEnumerable<System.IO.FileInfo> fileQuery =
                from file in fileList
                where file.Extension == ".dwg"
                orderby file.Name
                select file;

            //Execute the query. This might write out a lot of files!
            foreach (System.IO.FileInfo fi in fileQuery)
            {
                Console.WriteLine(fi.FullName);
            }

            // Create and execute a new query by using the previous 
            // query as a starting point. fileQuery is not 
            // executed again until the call to Last()
            var newestFile =
                (from file in fileQuery
                 orderby file.CreationTime
                 select new { file.FullName, file.CreationTime })
                .Last();

            Console.WriteLine("\r\nThe newest .txt file is {0}. Creation time: {1}",
                newestFile.FullName, newestFile.CreationTime);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private void visualizarPlanoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {


                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                ruta = "\\\\imecon08\\BOper\\CONTROL DOCUMENT\\";

                string num_ord = txt_num_ord.Text;
                int tam_var = num_ord.Length;
                string Var_Sub = num_ord.Substring((tam_var - 2), 2);


                ruta = ruta + "PROJECT 20" + Var_Sub + "\\" + txt_num_ord.Text + "\\Desarrollo\\TT\\";


                marca = Convert.ToString(dgv_d_prd_marca.CurrentRow.Cells["marca"].Value);
                descripcion = Convert.ToString(dgv_d_prd_marca.CurrentRow.Cells["descripcion"].Value);
                revision = Convert.ToString(dgv_d_prd_marca.CurrentRow.Cells["revision"].Value);



                archivo = marca + " - " + descripcion + " - " + "Rev " + revision + ".dwg";

                // archivo = ruta + archivo;

                MessageBox.Show(archivo);

                DirectoryInfo di = new DirectoryInfo(ruta);
                recorrerDir(di);



                proc.StartInfo.FileName = txt_ruta.Text + "\\" + archivo;
                proc.Start();
                proc.Close();
            }
            catch (Exception ex)
            {
                //if (MessageBox.Show("Error: " + ex.Message + "\n" + "No existe Plano",
                //                   "Abrir Planos", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation
                //                   ) == DialogResult.Cancel) ;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
          
        }

        private void recorrerDir(DirectoryInfo di)
        {
             FileInfo[] fics;
             DirectoryInfo[] dirs;
            
            try
            {
                fics = di.GetFiles(archivo, SearchOption.TopDirectoryOnly);
                foreach (FileInfo fi in fics)
                {
                    txt_ruta.Text = fi.DirectoryName;
                }

                dirs = di.GetDirectories();
                foreach (DirectoryInfo dir in dirs)
                {
                       recorrerDir(dir);
                }
                
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("Error: " + ex.Message + "\n" + "¿Quieres cancelar o continuar?",
                                   "Buscar en directorios", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation
                                   ) == DialogResult.Cancel) ;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           exporta_a_excel();
        }


        public void exporta_a_excel()
        {
            ////creamos un objeto de tipo Excel sobre le cual vamos a trabajar (solo si ya agregamos la  referencia y la libreria) 
            //Microsoft.Office.Interop.Excel.ApplicationClass excel = new  Excel.ApplicationClass();
            ////agregamos un nuevo libro a nuestro objeto excel
            //excel.Application.Workbooks.Add(true);
            ////contador para las columnas
            //int ColumnIndex = 0;
            ////este ciclo es para saber cuantas columnas y que nombre de encabezado tiene nuestro grid e irlas agregando a nuestro objeto excel
            //foreach (DataGridViewColumn col in dgv_d_prd_marca.Columns)
            //{
            //    //aumentamos la variable de uno en uno por cada columna en el grid
            //    ColumnIndex++;
            // //agregamos una nueva celda con el nombre de la columna para tener el encabezado de nuestra tabla de registro:
            ////ejemplo:
            //    /*
            //     * Nombre | apellido | direccion | telefono
            //     * 
            //     * y de esta forma copiamos el encabezado de nuestro data grid a nuestro objeto de escel
            //     * */
            //    excel.Cells[1, ColumnIndex] = col.Name;
            //}
            ////variable para saber el numero de renglones
            //int rowIndex = 0;
            ////recorremos el grid cumpliedo la condicion del foreach que por cada renglon que halla en el grid hara lo que esta dentro del ciclo
            //foreach (DataGridViewRow row in dgv_d_prd_marca.Rows)
            //{
            //    //aumentamos el numero del renglon
            //    rowIndex++;
            //    //el numero de columnas lo regresamos a cero
            //    ColumnIndex = 0;
            //    //en este ciclo recorremos cada columna del renglon en el que estamos trabajando, el recorrido es simple es recorrer una matriz
            //    foreach (DataGridViewColumn col in dgv_d_prd_marca.Columns)
            //    {
            //        //aumentamos la columna
            //        ColumnIndex++;
            //        //agregamos el valor contenido en determinada posicion del grid a nuestro objeto de excel.
            //        /*
            //         ejemplo: excel.cell[0+1,1]= row.cell["Nombre].value"
            //         * 
            //         * 
            //         */
            //        excel.Cells[rowIndex + 1, ColumnIndex] = row.Cells[col.Name].Value;
            //        //vamos a ir recorriendo todas las columnas, renglon por renglon hasta terminar los renglones que tenga nuestro grid
            //    }
            //}
            ////finalmente mostramos en pantalla nuestro archivo de excel listo para ser guardado.
            //excel.Visible = true;
            ////habilitamos una hoja
            ////Worksheet worksheet = (Worksheet)excel.ActiveSheet;
        } 



        private void ExportarDataGridViewExcel(DataGridView grd)
        {
            
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Excel.Application xlApp;
            //Excel.Workbook xlWorkBook;
            //Excel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;

            //xlApp = new Excel.Application();
            //xlWorkBook = xlApp.Workbooks.Add(misValue);
            //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //int i = 0;
            //int j = 0;

            //for (i = 0; i <= dgv_d_prd_marca.RowCount - 1; i++)
            //{
            //    for (j = 0; j <= dgv_d_prd_marca.ColumnCount - 1; j++)
            //    {
            //        DataGridViewCell cell = dgv_d_prd_marca[j, i];
            //        xlWorkSheet.Cells[i + 3, j + 1] = cell.Value;
            //    }
            //}

            //xlWorkBook.SaveAs("csharp.net-informations.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlWorkBook.Close(true, misValue, misValue);
            //xlApp.Quit();

            //releaseObject(xlWorkSheet);
            //releaseObject(xlWorkBook);
            //releaseObject(xlApp);

            //MessageBox.Show("Excel file created , you can find the file c:\\csharp.net-informations.xls");
        }

        private void releaseObject(object obj)
        {
            //try
            //{
            //    System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
            //    obj = null;
            //}
            //catch (Exception ex)
            //{
            //    obj = null;
            //    MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            //}
            //finally
            //{
            //    GC.Collect();
            //}
        }

        private void imagenes_Click(object sender, EventArgs e)
        {
            
        }

        private void Imagenes()
        {
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\";
            open.Filter = "All Files (*.*)|*.*";
            open.FilterIndex = 1;

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string paths = Application.StartupPath;
                archivo = System.IO.Path.GetFileName(open.FileName);
                System.IO.File.Copy(open.FileName, @"c:\\TEST\\" + archivo);
                MessageBox.Show("El arhivo se cargo satisfactoriamente");
            }
          


        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // Get file name.
            string name = saveFileDialog1.FileName;
            // Write to the file name selected.
            // ... You can write the text from a TextBox instead of a string literal.
            File.WriteAllText(name, "test");
        }


        private void button6_Click(object sender, EventArgs e)
        {
             
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            FileName = openFileDialog1.FileName;

            if (FileName.Length != 0)
            {
                Object refmissing = System.Reflection.Missing.Value;
                oDoc = null;
                webBrowser1.Navigate(FileName);

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string num_ord = "190-15";
            string ruta = @"\\10.0.0.8\Comun\MISAP\NO CONFORMIDADES\\" + num_ord;

            if (System.IO.Directory.Exists(ruta))
            {
                //código si fichero existe 
                MessageBox.Show("EXISTE NO CREA");
            }
            else
            {
                MessageBox.Show("NO EXISTE CREO");

                Directory.CreateDirectory(ruta);
                //código si fichero no existe 
            }

         
        
        }

        private void dgv_elementos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //if (e.RowIndex == 1 && e.ColumnIndex == 1)
            //{
            //    using (Image img = Image.FromFile(@"c:\ButtonLink.png"))
            //    {
            //        e.Graphics.DrawImage(img, e.CellBounds.Left, e.CellBounds.Top - 5, e.CellBounds.Right, e.CellBounds.Bottom - 5);

            //        e.PaintContent(e.ClipBounds);
            //        e.Handled = true;
            //    }
            //}

            if (e.ColumnIndex >= 0 && this.dgv_elementos.Columns[e.ColumnIndex].Name == "link" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                
                DataGridViewButtonCell celBoton = this.dgv_elementos.Rows[e.RowIndex].Cells["link"] as DataGridViewButtonCell;
                Image IMG = ((System.Drawing.Image)(Properties.Resources.ButtonLink));
                e.Graphics.DrawImage(IMG, e.CellBounds.Left + 3, e.CellBounds.Top + 5);

           
                dgv_elementos.Columns["link"].DefaultCellStyle.BackColor = Color.FromArgb(231, 231, 231);
                this.dgv_elementos.Rows[e.RowIndex].Height = IMG.Height + 10;
                this.dgv_elementos.Columns[e.ColumnIndex].Width = IMG.Width + 10;

                e.Handled = true;
            }

        }

        private void dgv_elementos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string item;
            
            if (this.dgv_elementos.Columns[e.ColumnIndex].Name == "link")
            {
                item = Convert.ToString(dgv_elementos.CurrentRow.Cells["item"].Value);

                MessageBox.Show("Mostrar lista de componentes " + item);
            }
        }

     
        
    }
}
