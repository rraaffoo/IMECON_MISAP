namespace MISAP
{
    partial class FrmTareo_IngresoMasivo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtact = new System.Windows.Forms.TextBox();
            this.txtproc = new System.Windows.Forms.TextBox();
            this.dgvPerAsignado = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.ToolStrip();
            this.tsl_titulo = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.maximizar = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            this.ss_load = new System.Windows.Forms.StatusStrip();
            this.lbl_contador_registros = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_CODSOL = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_SOLICI = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_msg = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_maximi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_origen = new System.Windows.Forms.ToolStripStatusLabel();
            this.t_msg = new System.Windows.Forms.Timer(this.components);
            this.l_dni = new System.Windows.Forms.Label();
            this.l_fecha = new System.Windows.Forms.Label();
            this.cboTurno_msv = new System.Windows.Forms.ComboBox();
            this.dtpFecha_msv = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboTipo_msv = new System.Windows.Forms.ComboBox();
            this.cboFalta_msv = new System.Windows.Forms.ComboBox();
            this.txtFechaFin_msv = new System.Windows.Forms.TextBox();
            this.txtFechaIni_msv = new System.Windows.Forms.TextBox();
            this.cboSemana_msv = new System.Windows.Forms.ComboBox();
            this.cboAnio_msv = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOt_msv = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboEdt_msv = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboActividad_msv = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtHn = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtHe = new System.Windows.Forms.TextBox();
            this.l_usuario = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerAsignado)).BeginInit();
            this.titulo.SuspendLayout();
            this.ss_load.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.txtact);
            this.groupBox3.Controls.Add(this.txtproc);
            this.groupBox3.Controls.Add(this.dgvPerAsignado);
            this.groupBox3.Location = new System.Drawing.Point(18, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 326);
            this.groupBox3.TabIndex = 124;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccione Personal:";
            // 
            // txtact
            // 
            this.txtact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtact.Location = new System.Drawing.Point(352, 19);
            this.txtact.Name = "txtact";
            this.txtact.Size = new System.Drawing.Size(111, 20);
            this.txtact.TabIndex = 342;
            this.txtact.Visible = false;
            // 
            // txtproc
            // 
            this.txtproc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproc.Location = new System.Drawing.Point(235, 19);
            this.txtproc.Name = "txtproc";
            this.txtproc.Size = new System.Drawing.Size(111, 20);
            this.txtproc.TabIndex = 341;
            this.txtproc.Visible = false;
            // 
            // dgvPerAsignado
            // 
            this.dgvPerAsignado.AllowUserToAddRows = false;
            this.dgvPerAsignado.AllowUserToDeleteRows = false;
            this.dgvPerAsignado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPerAsignado.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPerAsignado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPerAsignado.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerAsignado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPerAsignado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPerAsignado.EnableHeadersVisualStyles = false;
            this.dgvPerAsignado.Location = new System.Drawing.Point(3, 16);
            this.dgvPerAsignado.Name = "dgvPerAsignado";
            this.dgvPerAsignado.ReadOnly = true;
            this.dgvPerAsignado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerAsignado.Size = new System.Drawing.Size(463, 307);
            this.dgvPerAsignado.TabIndex = 260;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAceptar.BackgroundImage = global::MISAP.Properties.Resources.btn_enfasis;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAceptar.Location = new System.Drawing.Point(381, 589);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 21);
            this.btnAceptar.TabIndex = 280;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = false;
            this.titulo.BackgroundImage = global::MISAP.Properties.Resources.shell_header_2;
            this.titulo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.titulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_titulo,
            this.salir,
            this.maximizar,
            this.ninimizar});
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.titulo.Size = new System.Drawing.Size(506, 27);
            this.titulo.TabIndex = 281;
            this.titulo.Text = "toolStrip1";
            this.titulo.DoubleClick += new System.EventHandler(this.titulo_DoubleClick);
            this.titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            // 
            // tsl_titulo
            // 
            this.tsl_titulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsl_titulo.Name = "tsl_titulo";
            this.tsl_titulo.Size = new System.Drawing.Size(87, 24);
            this.tsl_titulo.Text = "Ingreso Masivo";
            this.tsl_titulo.DoubleClick += new System.EventHandler(this.titulo_DoubleClick);
            this.tsl_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            // 
            // salir
            // 
            this.salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salir.Image = global::MISAP.Properties.Resources.Frame_Close0;
            this.salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salir.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.salir.Margin = new System.Windows.Forms.Padding(0);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(23, 27);
            this.salir.Text = "Salir";
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // maximizar
            // 
            this.maximizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.maximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maximizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.maximizar.Image = global::MISAP.Properties.Resources.Frame_Maximize0;
            this.maximizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.maximizar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.maximizar.Margin = new System.Windows.Forms.Padding(0);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(23, 27);
            this.maximizar.Text = "Miminimizar tamaño";
            this.maximizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // ninimizar
            // 
            this.ninimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ninimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ninimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ninimizar.Image = global::MISAP.Properties.Resources.Frame_Minimize0;
            this.ninimizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ninimizar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.ninimizar.Margin = new System.Windows.Forms.Padding(0);
            this.ninimizar.Name = "ninimizar";
            this.ninimizar.Size = new System.Drawing.Size(23, 27);
            this.ninimizar.Text = "Minimizar";
            this.ninimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ninimizar.Click += new System.EventHandler(this.ninimizar_Click);
            // 
            // ss_load
            // 
            this.ss_load.AutoSize = false;
            this.ss_load.BackColor = System.Drawing.Color.Transparent;
            this.ss_load.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ss_load.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ss_load.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_contador_registros,
            this.lbl_U_CL_CODSOL,
            this.lbl_U_CL_SOLICI,
            this.lbl_msg,
            this.lbl_maximi,
            this.lbl_origen});
            this.ss_load.Location = new System.Drawing.Point(0, 613);
            this.ss_load.Name = "ss_load";
            this.ss_load.Size = new System.Drawing.Size(506, 18);
            this.ss_load.SizingGrip = false;
            this.ss_load.TabIndex = 311;
            this.ss_load.Text = "statusStrip1";
            // 
            // lbl_contador_registros
            // 
            this.lbl_contador_registros.AutoSize = false;
            this.lbl_contador_registros.BackColor = System.Drawing.Color.Transparent;
            this.lbl_contador_registros.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contador_registros.Name = "lbl_contador_registros";
            this.lbl_contador_registros.Size = new System.Drawing.Size(180, 13);
            this.lbl_contador_registros.Text = "Total registros";
            this.lbl_contador_registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_contador_registros.Visible = false;
            // 
            // lbl_U_CL_CODSOL
            // 
            this.lbl_U_CL_CODSOL.Name = "lbl_U_CL_CODSOL";
            this.lbl_U_CL_CODSOL.Size = new System.Drawing.Size(0, 13);
            // 
            // lbl_U_CL_SOLICI
            // 
            this.lbl_U_CL_SOLICI.Name = "lbl_U_CL_SOLICI";
            this.lbl_U_CL_SOLICI.Size = new System.Drawing.Size(0, 13);
            // 
            // lbl_msg
            // 
            this.lbl_msg.BackColor = System.Drawing.Color.Transparent;
            this.lbl_msg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lbl_msg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lbl_msg.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.ForeColor = System.Drawing.Color.White;
            this.lbl_msg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_msg.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(29, 13);
            this.lbl_msg.Text = "msg";
            this.lbl_msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_msg.Visible = false;
            // 
            // lbl_maximi
            // 
            this.lbl_maximi.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbl_maximi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lbl_maximi.Name = "lbl_maximi";
            this.lbl_maximi.Size = new System.Drawing.Size(18, 13);
            this.lbl_maximi.Text = "1";
            this.lbl_maximi.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.lbl_maximi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.lbl_maximi.Visible = false;
            // 
            // lbl_origen
            // 
            this.lbl_origen.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbl_origen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lbl_origen.Name = "lbl_origen";
            this.lbl_origen.Size = new System.Drawing.Size(18, 13);
            this.lbl_origen.Text = "0";
            this.lbl_origen.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.lbl_origen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.lbl_origen.Visible = false;
            // 
            // t_msg
            // 
            this.t_msg.Interval = 5000;
            this.t_msg.Tick += new System.EventHandler(this.t_msg_Tick);
            // 
            // l_dni
            // 
            this.l_dni.AutoSize = true;
            this.l_dni.Location = new System.Drawing.Point(307, 592);
            this.l_dni.Name = "l_dni";
            this.l_dni.Size = new System.Drawing.Size(61, 13);
            this.l_dni.TabIndex = 312;
            this.l_dni.Text = "                  ";
            this.l_dni.Visible = false;
            // 
            // l_fecha
            // 
            this.l_fecha.AutoSize = true;
            this.l_fecha.Location = new System.Drawing.Point(398, 523);
            this.l_fecha.Name = "l_fecha";
            this.l_fecha.Size = new System.Drawing.Size(61, 13);
            this.l_fecha.TabIndex = 313;
            this.l_fecha.Text = "                  ";
            this.l_fecha.Visible = false;
            // 
            // cboTurno_msv
            // 
            this.cboTurno_msv.BackColor = System.Drawing.Color.White;
            this.cboTurno_msv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTurno_msv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurno_msv.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTurno_msv.FormattingEnabled = true;
            this.cboTurno_msv.ItemHeight = 14;
            this.cboTurno_msv.Location = new System.Drawing.Point(84, 123);
            this.cboTurno_msv.Name = "cboTurno_msv";
            this.cboTurno_msv.Size = new System.Drawing.Size(101, 20);
            this.cboTurno_msv.TabIndex = 321;
            this.cboTurno_msv.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboTurno_msv_DrawItem);
            this.cboTurno_msv.Enter += new System.EventHandler(this.cboTurno_msv_Enter);
            this.cboTurno_msv.Leave += new System.EventHandler(this.cboTurno_msv_Leave);
            // 
            // dtpFecha_msv
            // 
            this.dtpFecha_msv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_msv.Location = new System.Drawing.Point(84, 93);
            this.dtpFecha_msv.Name = "dtpFecha_msv";
            this.dtpFecha_msv.Size = new System.Drawing.Size(101, 20);
            this.dtpFecha_msv.TabIndex = 320;
            this.dtpFecha_msv.ValueChanged += new System.EventHandler(this.dtpFecha_msv_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(235, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 14);
            this.label8.TabIndex = 319;
            this.label8.Text = "Falta";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 14);
            this.label9.TabIndex = 316;
            this.label9.Text = "Fecha";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 14);
            this.label10.TabIndex = 317;
            this.label10.Text = "Turno";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(235, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 14);
            this.label11.TabIndex = 318;
            this.label11.Text = "Tipo";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTipo_msv
            // 
            this.cboTipo_msv.BackColor = System.Drawing.Color.White;
            this.cboTipo_msv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTipo_msv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo_msv.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo_msv.FormattingEnabled = true;
            this.cboTipo_msv.ItemHeight = 14;
            this.cboTipo_msv.Location = new System.Drawing.Point(290, 95);
            this.cboTipo_msv.Name = "cboTipo_msv";
            this.cboTipo_msv.Size = new System.Drawing.Size(195, 20);
            this.cboTipo_msv.TabIndex = 314;
            this.cboTipo_msv.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboTipo_msv_DrawItem);
            this.cboTipo_msv.SelectionChangeCommitted += new System.EventHandler(this.cboTipo_msv_SelectionChangeCommitted);
            this.cboTipo_msv.Enter += new System.EventHandler(this.cboTipo_msv_Enter);
            this.cboTipo_msv.Leave += new System.EventHandler(this.cboTipo_msv_Leave);
            // 
            // cboFalta_msv
            // 
            this.cboFalta_msv.BackColor = System.Drawing.Color.White;
            this.cboFalta_msv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboFalta_msv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFalta_msv.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFalta_msv.FormattingEnabled = true;
            this.cboFalta_msv.ItemHeight = 14;
            this.cboFalta_msv.Location = new System.Drawing.Point(290, 121);
            this.cboFalta_msv.Name = "cboFalta_msv";
            this.cboFalta_msv.Size = new System.Drawing.Size(195, 20);
            this.cboFalta_msv.TabIndex = 315;
            this.cboFalta_msv.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboFalta_msv_DrawItem);
            this.cboFalta_msv.Enter += new System.EventHandler(this.cboFalta_msv_Enter);
            this.cboFalta_msv.Leave += new System.EventHandler(this.cboFalta_msv_Leave);
            // 
            // txtFechaFin_msv
            // 
            this.txtFechaFin_msv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaFin_msv.Location = new System.Drawing.Point(355, 50);
            this.txtFechaFin_msv.Name = "txtFechaFin_msv";
            this.txtFechaFin_msv.ReadOnly = true;
            this.txtFechaFin_msv.Size = new System.Drawing.Size(82, 20);
            this.txtFechaFin_msv.TabIndex = 327;
            this.txtFechaFin_msv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFechaIni_msv
            // 
            this.txtFechaIni_msv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaIni_msv.Location = new System.Drawing.Point(252, 50);
            this.txtFechaIni_msv.Name = "txtFechaIni_msv";
            this.txtFechaIni_msv.ReadOnly = true;
            this.txtFechaIni_msv.Size = new System.Drawing.Size(81, 20);
            this.txtFechaIni_msv.TabIndex = 325;
            this.txtFechaIni_msv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboSemana_msv
            // 
            this.cboSemana_msv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboSemana_msv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSemana_msv.Enabled = false;
            this.cboSemana_msv.FormattingEnabled = true;
            this.cboSemana_msv.Location = new System.Drawing.Point(159, 49);
            this.cboSemana_msv.Name = "cboSemana_msv";
            this.cboSemana_msv.Size = new System.Drawing.Size(72, 21);
            this.cboSemana_msv.TabIndex = 329;
            this.cboSemana_msv.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboSemana_msv_DrawItem);
            this.cboSemana_msv.SelectionChangeCommitted += new System.EventHandler(this.cboSemana_msv_SelectionChangeCommitted);
            this.cboSemana_msv.Enter += new System.EventHandler(this.cboSemana_msv_Enter);
            this.cboSemana_msv.Leave += new System.EventHandler(this.cboSemana_msv_Leave);
            // 
            // cboAnio_msv
            // 
            this.cboAnio_msv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboAnio_msv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnio_msv.Enabled = false;
            this.cboAnio_msv.FormattingEnabled = true;
            this.cboAnio_msv.Location = new System.Drawing.Point(70, 49);
            this.cboAnio_msv.Name = "cboAnio_msv";
            this.cboAnio_msv.Size = new System.Drawing.Size(72, 21);
            this.cboAnio_msv.TabIndex = 328;
            this.cboAnio_msv.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboAnio_msv_DrawItem);
            this.cboAnio_msv.SelectionChangeCommitted += new System.EventHandler(this.cboAnio_msv_SelectionChangeCommitted);
            this.cboAnio_msv.Enter += new System.EventHandler(this.cboAnio_msv_Enter);
            this.cboAnio_msv.Leave += new System.EventHandler(this.cboAnio_msv_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(352, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 14);
            this.label21.TabIndex = 326;
            this.label21.Text = "Hasta:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(249, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 14);
            this.label20.TabIndex = 324;
            this.label20.Text = "Desde:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 323;
            this.label5.Text = "Semana";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 14);
            this.label1.TabIndex = 322;
            this.label1.Text = "Año";
            // 
            // cboOt_msv
            // 
            this.cboOt_msv.BackColor = System.Drawing.Color.White;
            this.cboOt_msv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboOt_msv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOt_msv.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOt_msv.FormattingEnabled = true;
            this.cboOt_msv.ItemHeight = 14;
            this.cboOt_msv.Location = new System.Drawing.Point(290, 147);
            this.cboOt_msv.Name = "cboOt_msv";
            this.cboOt_msv.Size = new System.Drawing.Size(195, 20);
            this.cboOt_msv.TabIndex = 333;
            this.cboOt_msv.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboOt_msv_DrawItem);
            this.cboOt_msv.SelectionChangeCommitted += new System.EventHandler(this.cboOt_msv_SelectionChangeCommitted);
            this.cboOt_msv.Enter += new System.EventHandler(this.cboOt_msv_Enter);
            this.cboOt_msv.Leave += new System.EventHandler(this.cboOt_msv_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(235, 151);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 14);
            this.label17.TabIndex = 331;
            this.label17.Text = "Nº OT";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(235, 176);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 14);
            this.label16.TabIndex = 332;
            this.label16.Text = "EDT";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboEdt_msv
            // 
            this.cboEdt_msv.BackColor = System.Drawing.Color.White;
            this.cboEdt_msv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboEdt_msv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEdt_msv.Enabled = false;
            this.cboEdt_msv.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEdt_msv.FormattingEnabled = true;
            this.cboEdt_msv.ItemHeight = 14;
            this.cboEdt_msv.Location = new System.Drawing.Point(290, 173);
            this.cboEdt_msv.Name = "cboEdt_msv";
            this.cboEdt_msv.Size = new System.Drawing.Size(195, 20);
            this.cboEdt_msv.TabIndex = 330;
            this.cboEdt_msv.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboEdt_msv_DrawItem);
            this.cboEdt_msv.Enter += new System.EventHandler(this.cboEdt_msv_Enter);
            this.cboEdt_msv.Leave += new System.EventHandler(this.cboEdt_msv_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(235, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 14);
            this.label15.TabIndex = 335;
            this.label15.Text = "Actividad";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboActividad_msv
            // 
            this.cboActividad_msv.BackColor = System.Drawing.Color.White;
            this.cboActividad_msv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboActividad_msv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActividad_msv.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActividad_msv.FormattingEnabled = true;
            this.cboActividad_msv.ItemHeight = 14;
            this.cboActividad_msv.Location = new System.Drawing.Point(290, 199);
            this.cboActividad_msv.Name = "cboActividad_msv";
            this.cboActividad_msv.Size = new System.Drawing.Size(195, 20);
            this.cboActividad_msv.TabIndex = 334;
            this.cboActividad_msv.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboActividad_msv_DrawItem);
            this.cboActividad_msv.SelectionChangeCommitted += new System.EventHandler(this.cboActividad_msv_SelectionChangeCommitted);
            this.cboActividad_msv.Enter += new System.EventHandler(this.cboActividad_msv_Enter);
            this.cboActividad_msv.Leave += new System.EventHandler(this.cboActividad_msv_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(291, 237);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 14);
            this.label18.TabIndex = 338;
            this.label18.Text = "H. N.";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHn
            // 
            this.txtHn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHn.Location = new System.Drawing.Point(330, 231);
            this.txtHn.MaxLength = 3;
            this.txtHn.Name = "txtHn";
            this.txtHn.Size = new System.Drawing.Size(35, 20);
            this.txtHn.TabIndex = 336;
            this.txtHn.Text = "0";
            this.txtHn.TextChanged += new System.EventHandler(this.txtHn_TextChanged);
            this.txtHn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHn_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(410, 237);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 14);
            this.label19.TabIndex = 339;
            this.label19.Text = "H. E.";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHe
            // 
            this.txtHe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHe.Location = new System.Drawing.Point(449, 231);
            this.txtHe.MaxLength = 3;
            this.txtHe.Name = "txtHe";
            this.txtHe.Size = new System.Drawing.Size(35, 20);
            this.txtHe.TabIndex = 337;
            this.txtHe.Text = "0";
            this.txtHe.TextChanged += new System.EventHandler(this.txtHe_TextChanged);
            // 
            // l_usuario
            // 
            this.l_usuario.AutoSize = true;
            this.l_usuario.Location = new System.Drawing.Point(229, 592);
            this.l_usuario.Name = "l_usuario";
            this.l_usuario.Size = new System.Drawing.Size(61, 13);
            this.l_usuario.TabIndex = 340;
            this.l_usuario.Text = "                  ";
            this.l_usuario.Visible = false;
            // 
            // FrmTareo_IngresoMasivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 631);
            this.ControlBox = false;
            this.Controls.Add(this.l_usuario);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtHn);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtHe);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cboActividad_msv);
            this.Controls.Add(this.cboOt_msv);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cboEdt_msv);
            this.Controls.Add(this.txtFechaFin_msv);
            this.Controls.Add(this.txtFechaIni_msv);
            this.Controls.Add(this.cboSemana_msv);
            this.Controls.Add(this.cboAnio_msv);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTurno_msv);
            this.Controls.Add(this.dtpFecha_msv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboTipo_msv);
            this.Controls.Add(this.cboFalta_msv);
            this.Controls.Add(this.l_fecha);
            this.Controls.Add(this.l_dni);
            this.Controls.Add(this.ss_load);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmTareo_IngresoMasivo";
            this.Load += new System.EventHandler(this.FrmTareo_IngresoMasivo_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerAsignado)).EndInit();
            this.titulo.ResumeLayout(false);
            this.titulo.PerformLayout();
            this.ss_load.ResumeLayout(false);
            this.ss_load.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPerAsignado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ToolStrip titulo;
        private System.Windows.Forms.ToolStripLabel tsl_titulo;
        private System.Windows.Forms.ToolStripButton salir;
        private System.Windows.Forms.ToolStripButton maximizar;
        private System.Windows.Forms.ToolStripButton ninimizar;
        private System.Windows.Forms.StatusStrip ss_load;
        private System.Windows.Forms.ToolStripStatusLabel lbl_contador_registros;
        private System.Windows.Forms.ToolStripStatusLabel lbl_U_CL_CODSOL;
        private System.Windows.Forms.ToolStripStatusLabel lbl_U_CL_SOLICI;
        private System.Windows.Forms.ToolStripStatusLabel lbl_msg;
        private System.Windows.Forms.ToolStripStatusLabel lbl_maximi;
        private System.Windows.Forms.ToolStripStatusLabel lbl_origen;
        private System.Windows.Forms.Timer t_msg;
        private System.Windows.Forms.Label l_dni;
        private System.Windows.Forms.Label l_fecha;
        private System.Windows.Forms.ComboBox cboTurno_msv;
        private System.Windows.Forms.DateTimePicker dtpFecha_msv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboTipo_msv;
        private System.Windows.Forms.ComboBox cboFalta_msv;
        private System.Windows.Forms.TextBox txtFechaFin_msv;
        private System.Windows.Forms.TextBox txtFechaIni_msv;
        private System.Windows.Forms.ComboBox cboSemana_msv;
        private System.Windows.Forms.ComboBox cboAnio_msv;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOt_msv;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboEdt_msv;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboActividad_msv;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtHn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtHe;
        private System.Windows.Forms.Label l_usuario;
        private System.Windows.Forms.TextBox txtact;
        private System.Windows.Forms.TextBox txtproc;
    }
}