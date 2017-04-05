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
    public partial class CrvPedido : Form
    {

        public int pedido;

        public CrvPedido()
        {
            InitializeComponent();
        }

        private void CrvPedido_Load(object sender, EventArgs e)
        {

        }

        private void reporte()
        {
            try
            {

                rptPedidoDeCompraFD reporte = new rptPedidoDeCompraFD();
                reporte.SetDatabaseLogon("sa", "B1Admin", "SAPIMECONSERVER", "SBO_IMECON_PRODUCCION");
                reporte.SetParameterValue("DocKey@", pedido);
                crv_pedido.ReportSource = reporte;


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void crv_pedido_Load(object sender, EventArgs e)
        {
            reporte();
        }

    }
}
