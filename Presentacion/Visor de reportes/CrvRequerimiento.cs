using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using CrystalDecisions.Shared;

namespace MISAP
{
    public partial class CrvRequerimiento : Form
    {
        public string num_ped, tipo;

        public CrvRequerimiento()
        {
            InitializeComponent();
        }

        private void CrvRequerimiento_Load(object sender, EventArgs e)
        {

        }

        private void crv_requerimiento_Load(object sender, EventArgs e)
        {
            reporte();
        }

        private void reporte()
        {
            try
            {

                RptRequerimiento reporte = new RptRequerimiento();
                reporte.SetDatabaseLogon("sa", "B1Admin", "SAPIMECONSERVER", "MISAP");
                reporte.SetParameterValue("@num_ped", num_ped);
                reporte.SetParameterValue("@tipo", tipo);
                crv_requerimiento.ReportSource = reporte;
                

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

      


    }
}
