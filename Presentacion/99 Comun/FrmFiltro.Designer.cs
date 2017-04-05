namespace MISAP
{
    partial class FrmFiltro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiltro));
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_requerimiento = new System.Windows.Forms.ComboBox();
            this.cbo_solicitante = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_ot = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_responsable = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_estado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_fecha_crea = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_fecha_requerida = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_requerimiento = new System.Windows.Forms.TextBox();
            this.txt_ot = new System.Windows.Forms.TextBox();
            this.txt_solicitante = new System.Windows.Forms.TextBox();
            this.txt_responsable = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_fecha_crea = new System.Windows.Forms.TextBox();
            this.txt_fecha_req = new System.Windows.Forms.TextBox();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_filtro = new System.Windows.Forms.Button();
            this.barra = new System.Windows.Forms.ToolStrip();
            this.lbl_titulo = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            this.barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 14);
            this.label1.TabIndex = 240;
            this.label1.Text = "Reuqerimiento # :";
            // 
            // cbo_requerimiento
            // 
            this.cbo_requerimiento.FormattingEnabled = true;
            this.cbo_requerimiento.Location = new System.Drawing.Point(137, 37);
            this.cbo_requerimiento.Name = "cbo_requerimiento";
            this.cbo_requerimiento.Size = new System.Drawing.Size(201, 22);
            this.cbo_requerimiento.TabIndex = 241;
            this.cbo_requerimiento.SelectionChangeCommitted += new System.EventHandler(this.cbo_requerimiento_SelectionChangeCommitted);
            // 
            // cbo_solicitante
            // 
            this.cbo_solicitante.FormattingEnabled = true;
            this.cbo_solicitante.Location = new System.Drawing.Point(137, 65);
            this.cbo_solicitante.Name = "cbo_solicitante";
            this.cbo_solicitante.Size = new System.Drawing.Size(201, 22);
            this.cbo_solicitante.TabIndex = 243;
            this.cbo_solicitante.SelectionChangeCommitted += new System.EventHandler(this.cbo_solicitante_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 242;
            this.label2.Text = "Solicitante :";
            // 
            // cbo_ot
            // 
            this.cbo_ot.FormattingEnabled = true;
            this.cbo_ot.Location = new System.Drawing.Point(137, 93);
            this.cbo_ot.Name = "cbo_ot";
            this.cbo_ot.Size = new System.Drawing.Size(201, 22);
            this.cbo_ot.TabIndex = 245;
            this.cbo_ot.SelectionChangeCommitted += new System.EventHandler(this.cbo_ot_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 14);
            this.label3.TabIndex = 244;
            this.label3.Text = "OT :";
            // 
            // cbo_responsable
            // 
            this.cbo_responsable.FormattingEnabled = true;
            this.cbo_responsable.Location = new System.Drawing.Point(137, 121);
            this.cbo_responsable.Name = "cbo_responsable";
            this.cbo_responsable.Size = new System.Drawing.Size(201, 22);
            this.cbo_responsable.TabIndex = 247;
            this.cbo_responsable.SelectionChangeCommitted += new System.EventHandler(this.cbo_responsable_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 14);
            this.label4.TabIndex = 246;
            this.label4.Text = "Responsable :";
            // 
            // cbo_estado
            // 
            this.cbo_estado.FormattingEnabled = true;
            this.cbo_estado.Location = new System.Drawing.Point(137, 149);
            this.cbo_estado.Name = "cbo_estado";
            this.cbo_estado.Size = new System.Drawing.Size(201, 22);
            this.cbo_estado.TabIndex = 249;
            this.cbo_estado.SelectionChangeCommitted += new System.EventHandler(this.cbo_estado_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 248;
            this.label5.Text = "Estado :";
            // 
            // cbo_fecha_crea
            // 
            this.cbo_fecha_crea.FormattingEnabled = true;
            this.cbo_fecha_crea.Location = new System.Drawing.Point(137, 177);
            this.cbo_fecha_crea.Name = "cbo_fecha_crea";
            this.cbo_fecha_crea.Size = new System.Drawing.Size(201, 22);
            this.cbo_fecha_crea.TabIndex = 251;
            this.cbo_fecha_crea.SelectionChangeCommitted += new System.EventHandler(this.cbo_fecha_crea_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 14);
            this.label6.TabIndex = 250;
            this.label6.Text = "Fecha de creacion  :";
            // 
            // cbo_fecha_requerida
            // 
            this.cbo_fecha_requerida.FormattingEnabled = true;
            this.cbo_fecha_requerida.Location = new System.Drawing.Point(137, 205);
            this.cbo_fecha_requerida.Name = "cbo_fecha_requerida";
            this.cbo_fecha_requerida.Size = new System.Drawing.Size(201, 22);
            this.cbo_fecha_requerida.TabIndex = 253;
            this.cbo_fecha_requerida.SelectionChangeCommitted += new System.EventHandler(this.cbo_fecha_requerida_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 14);
            this.label7.TabIndex = 252;
            this.label7.Text = "Fecha requerida  :";
            // 
            // txt_requerimiento
            // 
            this.txt_requerimiento.Location = new System.Drawing.Point(137, 37);
            this.txt_requerimiento.Name = "txt_requerimiento";
            this.txt_requerimiento.Size = new System.Drawing.Size(100, 20);
            this.txt_requerimiento.TabIndex = 254;
            this.txt_requerimiento.Visible = false;
            // 
            // txt_ot
            // 
            this.txt_ot.Location = new System.Drawing.Point(137, 93);
            this.txt_ot.Name = "txt_ot";
            this.txt_ot.Size = new System.Drawing.Size(100, 20);
            this.txt_ot.TabIndex = 255;
            this.txt_ot.Visible = false;
            // 
            // txt_solicitante
            // 
            this.txt_solicitante.Location = new System.Drawing.Point(137, 65);
            this.txt_solicitante.Name = "txt_solicitante";
            this.txt_solicitante.Size = new System.Drawing.Size(100, 20);
            this.txt_solicitante.TabIndex = 256;
            this.txt_solicitante.Visible = false;
            // 
            // txt_responsable
            // 
            this.txt_responsable.Location = new System.Drawing.Point(137, 123);
            this.txt_responsable.Name = "txt_responsable";
            this.txt_responsable.Size = new System.Drawing.Size(100, 20);
            this.txt_responsable.TabIndex = 257;
            this.txt_responsable.Visible = false;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(137, 151);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(100, 20);
            this.txt_estado.TabIndex = 258;
            this.txt_estado.Visible = false;
            // 
            // txt_fecha_crea
            // 
            this.txt_fecha_crea.Location = new System.Drawing.Point(137, 177);
            this.txt_fecha_crea.Name = "txt_fecha_crea";
            this.txt_fecha_crea.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha_crea.TabIndex = 259;
            this.txt_fecha_crea.Visible = false;
            // 
            // txt_fecha_req
            // 
            this.txt_fecha_req.Location = new System.Drawing.Point(137, 205);
            this.txt_fecha_req.Name = "txt_fecha_req";
            this.txt_fecha_req.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha_req.TabIndex = 260;
            this.txt_fecha_req.Visible = false;
            // 
            // btn_borrar
            // 
            this.btn_borrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_borrar.BackgroundImage = global::MISAP.Properties.Resources.btn;
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_borrar.FlatAppearance.BorderSize = 0;
            this.btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_borrar.Location = new System.Drawing.Point(263, 279);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(75, 22);
            this.btn_borrar.TabIndex = 239;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_cancelar.Location = new System.Drawing.Point(89, 279);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 22);
            this.btn_cancelar.TabIndex = 238;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_filtro
            // 
            this.btn_filtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_filtro.BackgroundImage = global::MISAP.Properties.Resources.btn;
            this.btn_filtro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_filtro.FlatAppearance.BorderSize = 0;
            this.btn_filtro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_filtro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filtro.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_filtro.Location = new System.Drawing.Point(8, 279);
            this.btn_filtro.Name = "btn_filtro";
            this.btn_filtro.Size = new System.Drawing.Size(75, 22);
            this.btn_filtro.TabIndex = 237;
            this.btn_filtro.Text = "Filtro";
            this.btn_filtro.UseVisualStyleBackColor = true;
            this.btn_filtro.Click += new System.EventHandler(this.btn_filtro_Click);
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
            this.barra.Size = new System.Drawing.Size(358, 25);
            this.barra.TabIndex = 234;
            this.barra.Text = "Filtro";
            this.barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            this.barra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseMove);
            this.barra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseUp);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(34, 22);
            this.lbl_titulo.Text = "Filtro";
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
            this.salir.Size = new System.Drawing.Size(23, 22);
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
            this.ninimizar.Size = new System.Drawing.Size(23, 25);
            this.ninimizar.Text = "Minimizar";
            this.ninimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ninimizar.Click += new System.EventHandler(this.ninimizar_Click);
            // 
            // FrmFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 313);
            this.ControlBox = false;
            this.Controls.Add(this.txt_fecha_req);
            this.Controls.Add(this.txt_fecha_crea);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_responsable);
            this.Controls.Add(this.txt_solicitante);
            this.Controls.Add(this.txt_ot);
            this.Controls.Add(this.txt_requerimiento);
            this.Controls.Add(this.cbo_fecha_requerida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbo_fecha_crea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbo_estado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_responsable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_ot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_solicitante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_requerimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_filtro);
            this.Controls.Add(this.barra);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmFiltro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmOpciones_Load);
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_filtro;
        private System.Windows.Forms.ToolStripLabel lbl_titulo;
        private System.Windows.Forms.ToolStripButton ninimizar;
        private System.Windows.Forms.ToolStripButton salir;
        private System.Windows.Forms.ToolStrip barra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_requerimiento;
        private System.Windows.Forms.ComboBox cbo_solicitante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_ot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_responsable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_estado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_fecha_crea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_fecha_requerida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_requerimiento;
        private System.Windows.Forms.TextBox txt_ot;
        private System.Windows.Forms.TextBox txt_solicitante;
        private System.Windows.Forms.TextBox txt_responsable;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_fecha_crea;
        private System.Windows.Forms.TextBox txt_fecha_req;
    }
}