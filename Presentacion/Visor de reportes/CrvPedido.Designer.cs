namespace MISAP
{
    partial class CrvPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crv_pedido = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_pedido
            // 
            this.crv_pedido.ActiveViewIndex = -1;
            this.crv_pedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_pedido.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_pedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_pedido.EnableRefresh = false;
            this.crv_pedido.Location = new System.Drawing.Point(0, 0);
            this.crv_pedido.Name = "crv_pedido";
            this.crv_pedido.ShowGroupTreeButton = false;
            this.crv_pedido.ShowParameterPanelButton = false;
            this.crv_pedido.ShowRefreshButton = false;
            this.crv_pedido.Size = new System.Drawing.Size(656, 500);
            this.crv_pedido.TabIndex = 267;
            this.crv_pedido.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crv_pedido.Load += new System.EventHandler(this.crv_pedido_Load);
            // 
            // CrvPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 500);
            this.Controls.Add(this.crv_pedido);
            this.Name = "CrvPedido";
            this.Text = "Pedido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CrvPedido_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_pedido;
    }
}