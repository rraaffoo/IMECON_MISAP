using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAPbobsCOM;
using MISAP.Entity;
//using SAPbouiCOM;

namespace MISAP
{
    public partial class Lanzador : Form
    {
        public Lanzador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmVS_SeleccionProyecto abrir = new FrmVS_SeleccionProyecto("SD");
            abrir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmVS_SeleccionProyecto abrir = new FrmVS_SeleccionProyecto("GP");
            abrir.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmVS_SeleccionProyecto abrir = new FrmVS_SeleccionProyecto("GU");
            abrir.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmVS_SeleccionProyecto abrir = new FrmVS_SeleccionProyecto("GR");
            abrir.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmVS_SeleccionProyecto abrir = new FrmVS_SeleccionProyecto("GC");
            abrir.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmImpresionTransmital abrir = new FrmImpresionTransmital();
            abrir.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmInformeAsistencia abrir = new FrmInformeAsistencia();
            abrir.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmPCA abrir = new FrmPCA();
            abrir.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmTareoControl abrir = new FrmTareoControl();
            abrir.Show();
        }


        Documents op;

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("prueba");
        }
    
        
    }
}
