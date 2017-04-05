namespace MISAP
{
    partial class CrvRequerimiento
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
            this.crv_requerimiento = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_requerimiento
            // 
            this.crv_requerimiento.ActiveViewIndex = -1;
            this.crv_requerimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_requerimiento.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_requerimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_requerimiento.EnableRefresh = false;
            this.crv_requerimiento.Location = new System.Drawing.Point(0, 0);
            this.crv_requerimiento.Name = "crv_requerimiento";
            this.crv_requerimiento.ShowGroupTreeButton = false;
            this.crv_requerimiento.ShowParameterPanelButton = false;
            this.crv_requerimiento.ShowRefreshButton = false;
            this.crv_requerimiento.Size = new System.Drawing.Size(593, 427);
            this.crv_requerimiento.TabIndex = 1;
            this.crv_requerimiento.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crv_requerimiento.Load += new System.EventHandler(this.crv_requerimiento_Load);
            // 
            // CrvRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 427);
            this.Controls.Add(this.crv_requerimiento);
            this.Name = "CrvRequerimiento";
            this.Text = "Requerimiento de ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CrvRequerimiento_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_requerimiento;
    }
}