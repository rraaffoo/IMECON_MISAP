using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MISAP
{
    public partial class CrvNotaIngreso : Form
    {
        public int ni;

        public CrvNotaIngreso()
        {
            InitializeComponent();
        }

        private void CrvNotaIngreso_Load(object sender, EventArgs e)
        {

        }

        private void reporte()
        {
            try
            {

                rptAvanceValorizacionEMC reporte = new rptAvanceValorizacionEMC();
                reporte.SetDatabaseLogon("sa", "B1Admin", "SAPIMECONSERVER", "SBO_IMECON_PRODUCCION");
                reporte.SetParameterValue("DocKey@", ni);
                crv_ni.ReportSource = reporte;


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void crv_ni_Load(object sender, EventArgs e)
        {
            reporte();
        }
    }
}
