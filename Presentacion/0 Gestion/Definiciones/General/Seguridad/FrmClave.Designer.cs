namespace MISAP
{
    partial class FrmClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClave));
            this.barra = new System.Windows.Forms.ToolStrip();
            this.lbl_titulo = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.lbl_clave = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.lbl_clave_antigua = new System.Windows.Forms.Label();
            this.lbl_num_ord = new System.Windows.Forms.Label();
            this.txt_clave_antigua = new System.Windows.Forms.TextBox();
            this.lbl_confirmacion = new System.Windows.Forms.Label();
            this.txt_confirmacion = new System.Windows.Forms.TextBox();
            this.txt_clave_bd = new System.Windows.Forms.TextBox();
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
            this.lbl_titulo.Size = new System.Drawing.Size(98, 24);
            this.lbl_titulo.Text = "Clave de acceso";
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
            this.btn_cancelar.Location = new System.Drawing.Point(93, 132);
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
            this.btn_grabar.Location = new System.Drawing.Point(12, 132);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(75, 22);
            this.btn_grabar.TabIndex = 3;
            this.btn_grabar.Text = "OK";
            this.btn_grabar.UseVisualStyleBackColor = true;
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // lbl_clave
            // 
            this.lbl_clave.AutoSize = true;
            this.lbl_clave.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clave.Location = new System.Drawing.Point(12, 66);
            this.lbl_clave.Name = "lbl_clave";
            this.lbl_clave.Size = new System.Drawing.Size(88, 14);
            this.lbl_clave.TabIndex = 253;
            this.lbl_clave.Text = "Clave de acceso";
            // 
            // txt_clave
            // 
            this.txt_clave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_clave.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_clave.Location = new System.Drawing.Point(141, 60);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(101, 20);
            this.txt_clave.TabIndex = 1;
            this.txt_clave.Tag = "ingrese";
            this.txt_clave.UseSystemPasswordChar = true;
            this.txt_clave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_clave_MouseClick);
            this.txt_clave.Enter += new System.EventHandler(this.txt_clave_Enter);
            this.txt_clave.Leave += new System.EventHandler(this.txt_clave_Leave);
            // 
            // lbl_clave_antigua
            // 
            this.lbl_clave_antigua.AutoSize = true;
            this.lbl_clave_antigua.Location = new System.Drawing.Point(12, 41);
            this.lbl_clave_antigua.Name = "lbl_clave_antigua";
            this.lbl_clave_antigua.Size = new System.Drawing.Size(72, 14);
            this.lbl_clave_antigua.TabIndex = 250;
            this.lbl_clave_antigua.Text = "Clave antigua";
            this.lbl_clave_antigua.Visible = false;
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
            // txt_clave_antigua
            // 
            this.txt_clave_antigua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_clave_antigua.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_clave_antigua.Location = new System.Drawing.Point(141, 35);
            this.txt_clave_antigua.Name = "txt_clave_antigua";
            this.txt_clave_antigua.Size = new System.Drawing.Size(102, 20);
            this.txt_clave_antigua.TabIndex = 0;
            this.txt_clave_antigua.UseSystemPasswordChar = true;
            this.txt_clave_antigua.Visible = false;
            this.txt_clave_antigua.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_clave_antigua_MouseClick);
            this.txt_clave_antigua.Enter += new System.EventHandler(this.txt_clave_antigua_Enter);
            this.txt_clave_antigua.Leave += new System.EventHandler(this.txt_clave_antigua_Leave);
            // 
            // lbl_confirmacion
            // 
            this.lbl_confirmacion.AutoSize = true;
            this.lbl_confirmacion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmacion.Location = new System.Drawing.Point(12, 91);
            this.lbl_confirmacion.Name = "lbl_confirmacion";
            this.lbl_confirmacion.Size = new System.Drawing.Size(54, 14);
            this.lbl_confirmacion.TabIndex = 252;
            this.lbl_confirmacion.Text = "Confirmar";
            // 
            // txt_confirmacion
            // 
            this.txt_confirmacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_confirmacion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_confirmacion.Location = new System.Drawing.Point(141, 85);
            this.txt_confirmacion.Name = "txt_confirmacion";
            this.txt_confirmacion.Size = new System.Drawing.Size(102, 20);
            this.txt_confirmacion.TabIndex = 2;
            this.txt_confirmacion.UseSystemPasswordChar = true;
            this.txt_confirmacion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_confirmacion_MouseClick);
            this.txt_confirmacion.Enter += new System.EventHandler(this.txt_confirmacion_Enter);
            this.txt_confirmacion.Leave += new System.EventHandler(this.txt_confirmacion_Leave);
            // 
            // txt_clave_bd
            // 
            this.txt_clave_bd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_clave_bd.Location = new System.Drawing.Point(249, 35);
            this.txt_clave_bd.Name = "txt_clave_bd";
            this.txt_clave_bd.Size = new System.Drawing.Size(39, 20);
            this.txt_clave_bd.TabIndex = 254;
            this.txt_clave_bd.Visible = false;
            // 
            // FrmClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 166);
            this.ControlBox = false;
            this.Controls.Add(this.txt_clave_bd);
            this.Controls.Add(this.lbl_clave);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.lbl_clave_antigua);
            this.Controls.Add(this.lbl_num_ord);
            this.Controls.Add(this.txt_clave_antigua);
            this.Controls.Add(this.lbl_confirmacion);
            this.Controls.Add(this.txt_confirmacion);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_grabar);
            this.Controls.Add(this.barra);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmClave";
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
        private System.Windows.Forms.Label lbl_clave;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label lbl_clave_antigua;
        private System.Windows.Forms.Label lbl_num_ord;
        private System.Windows.Forms.TextBox txt_clave_antigua;
        private System.Windows.Forms.Label lbl_confirmacion;
        private System.Windows.Forms.TextBox txt_confirmacion;
        private System.Windows.Forms.TextBox txt_clave_bd;
    }
}