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
    public partial class CrvPCA : Form
    {
        public int _id_pca;

        public CrvPCA()
        {
            InitializeComponent();
        }

        private void reporte_pca()
        {
            try
            {

                RptPCA reporte = new RptPCA();
                reporte.SetDatabaseLogon("sa", "B1Admin", "SAPIMECONSERVER", "MISAP");
                reporte.SetParameterValue("@id_pca", _id_pca);
                crv_pca.ReportSource = reporte;
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }





        private void CrvPCA_Load(object sender, EventArgs e)
        {

        }

        private void crv_pca_Load(object sender, EventArgs e)
        {
            reporte_pca();
        }
    }
}
