namespace MISAP
{
    partial class FrmCargarAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargarAsistencia));
            this.barra = new System.Windows.Forms.ToolStrip();
            this.lbl_titulo = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.lbl_dHasta = new System.Windows.Forms.Label();
            this.lbl_dDesde = new System.Windows.Forms.Label();
            this.lbl_num_ord = new System.Windows.Forms.Label();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.dp_dDesde = new System.Windows.Forms.DateTimePicker();
            this.dp_dHasta = new System.Windows.Forms.DateTimePicker();
            this.btn_abrir = new System.Windows.Forms.Button();
            this.barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.AutoSize = false;
            this.barra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra.BackgroundImage")));
            this.barra.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.barra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_titulo,
            this.salir,
            this.ninimizar});
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Name = "barra";
            this.barra.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.barra.Size = new System.Drawing.Size(320, 27);
            this.barra.TabIndex = 235;
            this.barra.Text = "toolStrip1";
            this.barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            this.barra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseMove);
            this.barra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseUp);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(118, 24);
            this.lbl_titulo.Text = "Carga de asistencia";
            this.lbl_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            this.lbl_titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseMove);
            this.lbl_titulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseUp);
            // 
            // salir
            // 
            this.salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(23, 24);
            this.salir.Text = "Salir";
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // ninimizar
            // 
            this.ninimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ninimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ninimizar.Image = ((System.Drawing.Image)(resources.GetObject("ninimizar.Image")));
            this.ninimizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ninimizar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.ninimizar.Margin = new System.Windows.Forms.Padding(0);
            this.ninimizar.Name = "ninimizar";
            this.ninimizar.Size = new System.Drawing.Size(23, 27);
            this.ninimizar.Text = "Minimizar";
            this.ninimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ninimizar.Click += new System.EventHandler(this.ninimizar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_cancelar.Location = new System.Drawing.Point(93, 102);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 22);
            this.btn_cancelar.TabIndex = 246;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_grabar
            // 
            this.btn_grabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_grabar.BackgroundImage = global::MISAP.Properties.Resources.btn_enfasis;
            this.btn_grabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_grabar.FlatAppearance.BorderSize = 0;
            this.btn_grabar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_grabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grabar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grabar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_grabar.Location = new System.Drawing.Point(12, 102);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(75, 22);
            this.btn_grabar.TabIndex = 3;
            this.btn_grabar.Text = "OK";
            this.btn_grabar.UseVisualStyleBackColor = true;
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // lbl_dHasta
            // 
            this.lbl_dHasta.AutoSize = true;
            this.lbl_dHasta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dHasta.Location = new System.Drawing.Point(12, 66);
            this.lbl_dHasta.Name = "lbl_dHasta";
            this.lbl_dHasta.Size = new System.Drawing.Size(52, 14);
            this.lbl_dHasta.TabIndex = 253;
            this.lbl_dHasta.Text = "Fecha fin";
            // 
            // lbl_dDesde
            // 
            this.lbl_dDesde.AutoSize = true;
            this.lbl_dDesde.Location = new System.Drawing.Point(12, 41);
            this.lbl_dDesde.Name = "lbl_dDesde";
            this.lbl_dDesde.Size = new System.Drawing.Size(79, 14);
            this.lbl_dDesde.TabIndex = 250;
            this.lbl_dDesde.Text = "Fecha de inicio";
            // 
            // lbl_num_ord
            // 
            this.lbl_num_ord.AutoSize = true;
            this.lbl_num_ord.Location = new System.Drawing.Point(140, 81);
            this.lbl_num_ord.Name = "lbl_num_ord";
            this.lbl_num_ord.Size = new System.Drawing.Size(0, 14);
            this.lbl_num_ord.TabIndex = 249;
            this.lbl_num_ord.Visible = false;
            // 
            // txt_tipo
            // 
            this.txt_tipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tipo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_tipo.Location = new System.Drawing.Point(249, 36);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(27, 20);
            this.txt_tipo.TabIndex = 2;
            this.txt_tipo.Text = "1";
            this.txt_tipo.UseSystemPasswordChar = true;
            this.txt_tipo.Visible = false;
            // 
            // dp_dDesde
            // 
            this.dp_dDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_dDesde.Location = new System.Drawing.Point(141, 36);
            this.dp_dDesde.Name = "dp_dDesde";
            this.dp_dDesde.Size = new System.Drawing.Size(102, 20);
            this.dp_dDesde.TabIndex = 254;
            // 
            // dp_dHasta
            // 
            this.dp_dHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_dHasta.Location = new System.Drawing.Point(141, 60);
            this.dp_dHasta.Name = "dp_dHasta";
            this.dp_dHasta.Size = new System.Drawing.Size(102, 20);
            this.dp_dHasta.TabIndex = 255;
            // 
            // btn_abrir
            // 
            this.btn_abrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_abrir.BackgroundImage = global::MISAP.Properties.Resources.btn_enfasis;
            this.btn_abrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_abrir.FlatAppearance.BorderSize = 0;
            this.btn_abrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_abrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_abrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abrir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abrir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_abrir.Location = new System.Drawing.Point(233, 102);
            this.btn_abrir.Name = "btn_abrir";
            this.btn_abrir.Size = new System.Drawing.Size(75, 22);
            this.btn_abrir.TabIndex = 256;
            this.btn_abrir.Text = "Abrir reloj";
            this.btn_abrir.UseVisualStyleBackColor = true;
            this.btn_abrir.Click += new System.EventHandler(this.btn_abrir_Click);
            // 
            // FrmCargarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 136);
            this.ControlBox = false;
            this.Controls.Add(this.btn_abrir);
            this.Controls.Add(this.dp_dHasta);
            this.Controls.Add(this.dp_dDesde);
            this.Controls.Add(this.lbl_dHasta);
            this.Controls.Add(this.lbl_dDesde);
            this.Controls.Add(this.lbl_num_ord);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_grabar);
            this.Controls.Add(this.barra);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCargarAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmClave_Load);
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barra;
        private System.Windows.Forms.ToolStripLabel lbl_titulo;
        private System.Windows.Forms.ToolStripButton salir;
        private System.Windows.Forms.ToolStripButton ninimizar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_grabar;
        private System.Windows.Forms.Label lbl_dHasta;
        private System.Windows.Forms.Label lbl_dDesde;
        private System.Windows.Forms.Label lbl_num_ord;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.DateTimePicker dp_dDesde;
        private System.Windows.Forms.DateTimePicker dp_dHasta;
        private System.Windows.Forms.Button btn_abrir;
    }
}