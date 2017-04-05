namespace MISAP
{
    partial class CrvPCA
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
            this.crv_pca = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_pca
            // 
            this.crv_pca.ActiveViewIndex = -1;
            this.crv_pca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_pca.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_pca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_pca.EnableRefresh = false;
            this.crv_pca.Location = new System.Drawing.Point(0, 0);
            this.crv_pca.Name = "crv_pca";
            this.crv_pca.ShowGroupTreeButton = false;
            this.crv_pca.ShowParameterPanelButton = false;
            this.crv_pca.ShowRefreshButton = false;
            this.crv_pca.Size = new System.Drawing.Size(673, 399);
            this.crv_pca.TabIndex = 2;
            this.crv_pca.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crv_pca.Load += new System.EventHandler(this.crv_pca_Load);
            // 
            // CrvPCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 399);
            this.Controls.Add(this.crv_pca);
            this.Name = "CrvPCA";
            this.Text = "PARTE DE CONTROL DE ACCESO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CrvPCA_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_pca;
    }
}