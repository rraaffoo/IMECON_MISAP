namespace MISAP
{
    partial class FrmParametrizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParametrizacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.barra = new System.Windows.Forms.ToolStrip();
            this.lbl_titulo = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.maximizar = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            this.dgv_columnas = new System.Windows.Forms.DataGridView();
            this.ss_load = new System.Windows.Forms.StatusStrip();
            this.lbl_maximi = new System.Windows.Forms.ToolStripStatusLabel();
            this.flag_seleccionar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.tc_parametrizacion = new System.Windows.Forms.TabControl();
            this.tp_tabla = new System.Windows.Forms.TabPage();
            this.tp_lineas = new System.Windows.Forms.TabPage();
            this.tp_documentos = new System.Windows.Forms.TabPage();
            this.tp_elementos = new System.Windows.Forms.TabPage();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_columnas)).BeginInit();
            this.ss_load.SuspendLayout();
            this.tc_parametrizacion.SuspendLayout();
            this.tp_tabla.SuspendLayout();
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
            this.maximizar,
            this.ninimizar});
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Name = "barra";
            this.barra.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.barra.Size = new System.Drawing.Size(359, 29);
            this.barra.TabIndex = 236;
            this.barra.Text = "toolStrip1";
            this.barra.DoubleClick += new System.EventHandler(this.titulo_DoubleClick);
            this.barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            this.barra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseMove);
            this.barra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseUp);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(162, 26);
            this.lbl_titulo.Text = "Parametrizaciones de formulario";
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
            this.salir.Size = new System.Drawing.Size(23, 26);
            this.salir.Text = "Salir";
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // maximizar
            // 
            this.maximizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.maximizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.maximizar.Image = global::MISAP.Properties.Resources.Frame_Maximize0;
            this.maximizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.maximizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(23, 26);
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
            this.ninimizar.Size = new System.Drawing.Size(23, 29);
            this.ninimizar.Text = "Minimizar";
            this.ninimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ninimizar.Click += new System.EventHandler(this.ninimizar_Click);
            // 
            // dgv_columnas
            // 
            this.dgv_columnas.AllowUserToAddRows = false;
            this.dgv_columnas.AllowUserToResizeRows = false;
            this.dgv_columnas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_columnas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_columnas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_columnas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_columnas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_columnas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_columnas.ColumnHeadersHeight = 21;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_columnas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_columnas.EnableHeadersVisualStyles = false;
            this.dgv_columnas.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_columnas.Location = new System.Drawing.Point(6, 6);
            this.dgv_columnas.Name = "dgv_columnas";
            this.dgv_columnas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_columnas.Size = new System.Drawing.Size(317, 340);
            this.dgv_columnas.TabIndex = 237;
            this.dgv_columnas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_columnas_CellContentClick);
            // 
            // ss_load
            // 
            this.ss_load.AutoSize = false;
            this.ss_load.BackColor = System.Drawing.Color.Transparent;
            this.ss_load.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ss_load.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ss_load.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_maximi,
            this.flag_seleccionar});
            this.ss_load.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ss_load.Location = new System.Drawing.Point(0, 444);
            this.ss_load.Name = "ss_load";
            this.ss_load.Size = new System.Drawing.Size(359, 18);
            this.ss_load.SizingGrip = false;
            this.ss_load.TabIndex = 260;
            this.ss_load.Text = "statusStrip1";
            // 
            // lbl_maximi
            // 
            this.lbl_maximi.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbl_maximi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lbl_maximi.Name = "lbl_maximi";
            this.lbl_maximi.Size = new System.Drawing.Size(17, 13);
            this.lbl_maximi.Text = "1";
            this.lbl_maximi.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.lbl_maximi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.lbl_maximi.Visible = false;
            // 
            // flag_seleccionar
            // 
            this.flag_seleccionar.Name = "flag_seleccionar";
            this.flag_seleccionar.Size = new System.Drawing.Size(13, 13);
            this.flag_seleccionar.Text = "1";
            this.flag_seleccionar.Visible = false;
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
            this.btn_cancelar.Location = new System.Drawing.Point(91, 428);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 24);
            this.btn_cancelar.TabIndex = 262;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_OK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_OK.BackgroundImage")));
            this.btn_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_OK.Location = new System.Drawing.Point(10, 428);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 24);
            this.btn_OK.TabIndex = 261;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // tc_parametrizacion
            // 
            this.tc_parametrizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_parametrizacion.Controls.Add(this.tp_tabla);
            this.tc_parametrizacion.Controls.Add(this.tp_lineas);
            this.tc_parametrizacion.Controls.Add(this.tp_documentos);
            this.tc_parametrizacion.Controls.Add(this.tp_elementos);
            this.tc_parametrizacion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_parametrizacion.Location = new System.Drawing.Point(10, 44);
            this.tc_parametrizacion.Name = "tc_parametrizacion";
            this.tc_parametrizacion.SelectedIndex = 0;
            this.tc_parametrizacion.Size = new System.Drawing.Size(337, 379);
            this.tc_parametrizacion.TabIndex = 263;
            // 
            // tp_tabla
            // 
            this.tp_tabla.Controls.Add(this.dgv_columnas);
            this.tp_tabla.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_tabla.Location = new System.Drawing.Point(4, 23);
            this.tp_tabla.Name = "tp_tabla";
            this.tp_tabla.Padding = new System.Windows.Forms.Padding(3);
            this.tp_tabla.Size = new System.Drawing.Size(329, 352);
            this.tp_tabla.TabIndex = 0;
            this.tp_tabla.Text = "Formato de tabla";
            this.tp_tabla.UseVisualStyleBackColor = true;
            // 
            // tp_lineas
            // 
            this.tp_lineas.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_lineas.Location = new System.Drawing.Point(4, 23);
            this.tp_lineas.Name = "tp_lineas";
            this.tp_lineas.Padding = new System.Windows.Forms.Padding(3);
            this.tp_lineas.Size = new System.Drawing.Size(329, 352);
            this.tp_lineas.TabIndex = 1;
            this.tp_lineas.Text = "Formato de lineas";
            this.tp_lineas.UseVisualStyleBackColor = true;
            // 
            // tp_documentos
            // 
            this.tp_documentos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_documentos.Location = new System.Drawing.Point(4, 23);
            this.tp_documentos.Name = "tp_documentos";
            this.tp_documentos.Size = new System.Drawing.Size(329, 352);
            this.tp_documentos.TabIndex = 2;
            this.tp_documentos.Text = "Documento";
            this.tp_documentos.UseVisualStyleBackColor = true;
            // 
            // tp_elementos
            // 
            this.tp_elementos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_elementos.Location = new System.Drawing.Point(4, 23);
            this.tp_elementos.Name = "tp_elementos";
            this.tp_elementos.Size = new System.Drawing.Size(329, 352);
            this.tp_elementos.TabIndex = 3;
            this.tp_elementos.Text = "Elementos";
            this.tp_elementos.UseVisualStyleBackColor = true;
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.BackgroundImage = global::MISAP.Properties.Resources.btn;
            this.btn_seleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_seleccionar.FlatAppearance.BorderSize = 0;
            this.btn_seleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_seleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seleccionar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_seleccionar.Location = new System.Drawing.Point(220, 430);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(123, 22);
            this.btn_seleccionar.TabIndex = 275;
            this.btn_seleccionar.Text = "Ninguno";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // FrmParametrizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 462);
            this.ControlBox = false;
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.tc_parametrizacion);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.ss_load);
            this.Controls.Add(this.barra);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmParametrizacion";
            this.Load += new System.EventHandler(this.FrmParametrizacion_Load);
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_columnas)).EndInit();
            this.ss_load.ResumeLayout(false);
            this.ss_load.PerformLayout();
            this.tc_parametrizacion.ResumeLayout(false);
            this.tp_tabla.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip barra;
        private System.Windows.Forms.ToolStripLabel lbl_titulo;
        private System.Windows.Forms.ToolStripButton salir;
        private System.Windows.Forms.ToolStripButton maximizar;
        private System.Windows.Forms.ToolStripButton ninimizar;
        private System.Windows.Forms.DataGridView dgv_columnas;
        private System.Windows.Forms.StatusStrip ss_load;
        private System.Windows.Forms.ToolStripStatusLabel lbl_maximi;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TabControl tc_parametrizacion;
        private System.Windows.Forms.TabPage tp_tabla;
        private System.Windows.Forms.TabPage tp_lineas;
        private System.Windows.Forms.TabPage tp_documentos;
        private System.Windows.Forms.TabPage tp_elementos;
        private System.Windows.Forms.ToolStripStatusLabel flag_seleccionar;
        private System.Windows.Forms.Button btn_seleccionar;
    }
}