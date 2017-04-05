using System;
using System.Drawing;
using System.Threading; 
using System.Windows.Forms;

namespace MISAP
{
    public partial class FrmEspera : Form
    {
        public string Message;


        public FrmEspera()
        {
            InitializeComponent();
                   
        }



        private void FrmEspera_Load(object sender, EventArgs e)
        {
            mensaje.Text = Message;
        }

        private void FrmEspera_Activated(object sender, EventArgs e)
        {
            mensaje.Text = Message;
        }
        
          



    }
}
