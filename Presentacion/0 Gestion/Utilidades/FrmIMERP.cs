using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using WebKit;
using System.Windows.Forms;

namespace MISAP
{
    public partial class FrmIMERP : Form
    {
        public FrmIMERP()
        {
            InitializeComponent();
         
        }

        private void FrmIMERP_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            webMcod.Navigate("http://10.0.0.7/gestiondoc/index.php?controller=Documents&amp;accion=listarDocument?id=350");
            //webMcod.Document.= "zoom:300%;";
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
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmIMERP_Resize(object sender, EventArgs e)
        {
            webMcod.Height = this.Height - 100;
        }
    }
}
