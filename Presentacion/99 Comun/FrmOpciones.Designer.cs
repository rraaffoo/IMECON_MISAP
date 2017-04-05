namespace MISAP
{
    partial class FrmOpciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpciones));
            this.Co = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.dgv_lista = new System.Windows.Forms.DataGridView();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.barra = new System.Windows.Forms.ToolStrip();
            this.lbl_titulo = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.maximizar = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.chk_tipo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).BeginInit();
            this.barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // Co
            // 
            this.Co.AutoSize = true;
            this.Co.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Co.Location = new System.Drawing.Point(9, 34);
            this.Co.Name = "Co";
            this.Co.Size = new System.Drawing.Size(42, 14);
            this.Co.TabIndex = 236;
            this.Co.Text = "Buscar";
            // 
            // txt_buscar
            // 
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.txt_buscar.Location = new System.Drawing.Point(79, 29);
            this.txt_buscar.Multiline = true;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(190, 19);
            this.txt_buscar.TabIndex = 0;
            this.txt_buscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_buscar_MouseClick);
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            this.txt_buscar.Enter += new System.EventHandler(this.txt_buscar_Enter);
            this.txt_buscar.Leave += new System.EventHandler(this.txt_buscar_Leave);
            // 
            // dgv_lista
            // 
            this.dgv_lista.AllowUserToAddRows = false;
            this.dgv_lista.AllowUserToDeleteRows = false;
            this.dgv_lista.AllowUserToResizeRows = false;
            this.dgv_lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_lista.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_lista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_lista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_lista.ColumnHeadersHeight = 21;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_lista.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_lista.EnableHeadersVisualStyles = false;
            this.dgv_lista.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_lista.Location = new System.Drawing.Point(12, 54);
            this.dgv_lista.Name = "dgv_lista";
            this.dgv_lista.ReadOnly = true;
            this.dgv_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lista.Size = new System.Drawing.Size(464, 196);
            this.dgv_lista.TabIndex = 235;
            this.dgv_lista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lista_CellClick);
            this.dgv_lista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lista_CellDoubleClick);
            this.dgv_lista.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_lista_ColumnHeaderMouseDoubleClick);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nuevo.BackgroundImage = global::MISAP.Properties.Resources.btn_desactivado;
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_nuevo.Enabled = false;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_nuevo.Location = new System.Drawing.Point(13, 262);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(75, 22);
            this.btn_nuevo.TabIndex = 239;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
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
            this.btn_cancelar.Location = new System.Drawing.Point(94, 262);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 22);
            this.btn_cancelar.TabIndex = 238;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_seleccionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_seleccionar.BackgroundImage")));
            this.btn_seleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_seleccionar.FlatAppearance.BorderSize = 0;
            this.btn_seleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_seleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seleccionar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_seleccionar.Location = new System.Drawing.Point(13, 262);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(75, 22);
            this.btn_seleccionar.TabIndex = 237;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // barra
            // 
            this.barra.AutoSize = false;
            this.barra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra.BackgroundImage")));
            this.barra.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.barra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_titulo,
            this.salir,
            this.maximizar,
            this.ninimizar});
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Name = "barra";
            this.barra.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.barra.Size = new System.Drawing.Size(488, 25);
            this.barra.TabIndex = 234;
            this.barra.Text = "toolStrip1";
            this.barra.DoubleClick += new System.EventHandler(this.titulo_DoubleClick);
            this.barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            this.barra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseMove);
            this.barra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseUp);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(34, 22);
            this.lbl_titulo.Text = "LIsta";
            this.lbl_titulo.DoubleClick += new System.EventHandler(this.titulo_DoubleClick);
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
            // maximizar
            // 
            this.maximizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.maximizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.maximizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(23, 22);
            this.maximizar.Text = "Miminimizar tamaño";
            this.maximizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
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
            // txt_cantidad
            // 
            this.txt_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.txt_cantidad.Location = new System.Drawing.Point(364, 29);
            this.txt_cantidad.Multiline = true;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(64, 19);
            this.txt_cantidad.TabIndex = 240;
            this.txt_cantidad.Visible = false;
            this.txt_cantidad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_cantidad_MouseClick);
            this.txt_cantidad.Enter += new System.EventHandler(this.txt_cantidad_Enter);
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            this.txt_cantidad.Leave += new System.EventHandler(this.txt_cantidad_Leave);
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(309, 31);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(49, 14);
            this.lbl_cantidad.TabIndex = 241;
            this.lbl_cantidad.Text = "Cantidad";
            this.lbl_cantidad.Visible = false;
            // 
            // chk_tipo
            // 
            this.chk_tipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_tipo.AutoSize = true;
            this.chk_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_tipo.Location = new System.Drawing.Point(386, 262);
            this.chk_tipo.Name = "chk_tipo";
            this.chk_tipo.Size = new System.Drawing.Size(90, 18);
            this.chk_tipo.TabIndex = 281;
            this.chk_tipo.Text = "Mostrar todos";
            this.chk_tipo.UseVisualStyleBackColor = true;
            this.chk_tipo.Visible = false;
            this.chk_tipo.CheckedChanged += new System.EventHandler(this.chk_tipo_CheckedChanged);
            // 
            // FrmOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 290);
            this.ControlBox = false;
            this.Controls.Add(this.chk_tipo);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.Co);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.dgv_lista);
            this.Controls.Add(this.barra);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmOpciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmOpciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).EndInit();
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Label Co;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridView dgv_lista;
        private System.Windows.Forms.ToolStripLabel lbl_titulo;
        private System.Windows.Forms.ToolStripButton ninimizar;
        private System.Windows.Forms.ToolStripButton salir;
        private System.Windows.Forms.ToolStrip barra;
        private System.Windows.Forms.ToolStripButton maximizar;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.CheckBox chk_tipo;
    }
}