namespace MISAP
{
    partial class CrvNotaIngreso
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
            this.crv_ni = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_ni
            // 
            this.crv_ni.ActiveViewIndex = -1;
            this.crv_ni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_ni.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_ni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_ni.EnableRefresh = false;
            this.crv_ni.Location = new System.Drawing.Point(0, 0);
            this.crv_ni.Name = "crv_ni";
            this.crv_ni.ShowGroupTreeButton = false;
            this.crv_ni.ShowParameterPanelButton = false;
            this.crv_ni.ShowRefreshButton = false;
            this.crv_ni.Size = new System.Drawing.Size(645, 475);
            this.crv_ni.TabIndex = 268;
            this.crv_ni.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crv_ni.Load += new System.EventHandler(this.crv_ni_Load);
            // 
            // CrvNotaIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 475);
            this.Controls.Add(this.crv_ni);
            this.Name = "CrvNotaIngreso";
            this.Text = "Nota de Ingreso";
            this.Load += new System.EventHandler(this.CrvNotaIngreso_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_ni;
    }
}