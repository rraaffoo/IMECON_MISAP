namespace MISAP
{
    partial class FrmCriteriosSeleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCriteriosSeleccion));
            this.btn_grabar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.ss_load = new System.Windows.Forms.StatusStrip();
            this.lbl_contador_registros = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_CODSOL = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_SOLICI = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_msg = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_maximi = new System.Windows.Forms.ToolStripStatusLabel();
            this.t_msg = new System.Windows.Forms.Timer(this.components);
            this.titulo = new System.Windows.Forms.ToolStrip();
            this.tsl_titulo = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            this.lbl_montocredito = new System.Windows.Forms.Label();
            this.txt_montocredito = new System.Windows.Forms.TextBox();
            this.tc_informe = new System.Windows.Forms.TabControl();
            this.informetareos = new System.Windows.Forms.TabPage();
            this.rbtnProcesos = new System.Windows.Forms.RadioButton();
            this.rbtnAnalisis = new System.Windows.Forms.RadioButton();
            this.rbtnInformativos = new System.Windows.Forms.RadioButton();
            this.gbAnalisis = new System.Windows.Forms.GroupBox();
            this.rbtnPlanilla = new System.Windows.Forms.RadioButton();
            this.rbtnConsolidado = new System.Windows.Forms.RadioButton();
            this.gbProcesos = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnOtDiferenciado = new System.Windows.Forms.RadioButton();
            this.rbtnOtStarsoft = new System.Windows.Forms.RadioButton();
            this.cboSemana_proc = new System.Windows.Forms.ComboBox();
            this.txtFechaFin_reg = new System.Windows.Forms.TextBox();
            this.cboAnio_proc = new System.Windows.Forms.ComboBox();
            this.txtFechaIni_reg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPlanilla_rep = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gbInformativos = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboAnio_inf = new System.Windows.Forms.ComboBox();
            this.cboMes_inf = new System.Windows.Forms.ComboBox();
            this.cboSemana_inf = new System.Windows.Forms.ComboBox();
            this.dtpFechaFin_rep = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIni_rep = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.rbtnMes = new System.Windows.Forms.RadioButton();
            this.rbtnSemana = new System.Windows.Forms.RadioButton();
            this.rbtnDesde = new System.Windows.Forms.RadioButton();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnProduccion = new System.Windows.Forms.RadioButton();
            this.rbtnRrhh = new System.Windows.Forms.RadioButton();
            this.chkHrsTot = new System.Windows.Forms.CheckBox();
            this.txtDni_rep = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.informeemp = new System.Windows.Forms.TabPage();
            this.BW = new System.ComponentModel.BackgroundWorker();
            this.ss_load.SuspendLayout();
            this.titulo.SuspendLayout();
            this.tc_informe.SuspendLayout();
            this.informetareos.SuspendLayout();
            this.gbAnalisis.SuspendLayout();
            this.gbProcesos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbInformativos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.informeemp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_grabar
            // 
            this.btn_grabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_grabar.BackgroundImage = global::MISAP.Properties.Resources.btn_enfasis;
            this.btn_grabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_grabar.FlatAppearance.BorderSize = 0;
            this.btn_grabar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_grabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grabar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grabar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_grabar.Location = new System.Drawing.Point(14, 607);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(64, 21);
            this.btn_grabar.TabIndex = 283;
            this.btn_grabar.Text = "OK";
            this.btn_grabar.UseVisualStyleBackColor = true;
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_cancelar.Location = new System.Drawing.Point(84, 607);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(64, 21);
            this.btn_cancelar.TabIndex = 284;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.salir_Click);
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
            this.lbl_maximi});
            this.ss_load.Location = new System.Drawing.Point(0, 631);
            this.ss_load.Name = "ss_load";
            this.ss_load.Size = new System.Drawing.Size(439, 17);
            this.ss_load.SizingGrip = false;
            this.ss_load.TabIndex = 285;
            this.ss_load.Text = "statusStrip1";
            // 
            // lbl_contador_registros
            // 
            this.lbl_contador_registros.AutoSize = false;
            this.lbl_contador_registros.BackColor = System.Drawing.Color.Transparent;
            this.lbl_contador_registros.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contador_registros.Name = "lbl_contador_registros";
            this.lbl_contador_registros.Size = new System.Drawing.Size(180, 12);
            this.lbl_contador_registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_contador_registros.Visible = false;
            // 
            // lbl_U_CL_CODSOL
            // 
            this.lbl_U_CL_CODSOL.Name = "lbl_U_CL_CODSOL";
            this.lbl_U_CL_CODSOL.Size = new System.Drawing.Size(0, 12);
            // 
            // lbl_U_CL_SOLICI
            // 
            this.lbl_U_CL_SOLICI.Name = "lbl_U_CL_SOLICI";
            this.lbl_U_CL_SOLICI.Size = new System.Drawing.Size(0, 12);
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
            this.lbl_msg.Size = new System.Drawing.Size(29, 12);
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
            this.lbl_maximi.Size = new System.Drawing.Size(18, 12);
            this.lbl_maximi.Text = "1";
            this.lbl_maximi.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.lbl_maximi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.lbl_maximi.Visible = false;
            // 
            // t_msg
            // 
            this.t_msg.Interval = 4000;
            this.t_msg.Tick += new System.EventHandler(this.t_msg_Tick);
            // 
            // titulo
            // 
            this.titulo.AutoSize = false;
            this.titulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titulo.BackgroundImage")));
            this.titulo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.titulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_titulo,
            this.salir,
            this.ninimizar});
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.titulo.Size = new System.Drawing.Size(439, 27);
            this.titulo.TabIndex = 286;
            this.titulo.Text = "toolStrip1";
            this.titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            // 
            // tsl_titulo
            // 
            this.tsl_titulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsl_titulo.Name = "tsl_titulo";
            this.tsl_titulo.Size = new System.Drawing.Size(119, 24);
            this.tsl_titulo.Text = "Criterios de seleccion";
            this.tsl_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            // 
            // salir
            // 
            this.salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salir.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.salir.Margin = new System.Windows.Forms.Padding(0);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(23, 27);
            this.salir.Text = "Salir";
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // ninimizar
            // 
            this.ninimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ninimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            // lbl_montocredito
            // 
            this.lbl_montocredito.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_montocredito.Location = new System.Drawing.Point(17, 99);
            this.lbl_montocredito.Name = "lbl_montocredito";
            this.lbl_montocredito.Size = new System.Drawing.Size(124, 14);
            this.lbl_montocredito.TabIndex = 289;
            this.lbl_montocredito.Text = "Monto de credito";
            // 
            // txt_montocredito
            // 
            this.txt_montocredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_montocredito.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_montocredito.Location = new System.Drawing.Point(141, 93);
            this.txt_montocredito.Margin = new System.Windows.Forms.Padding(0);
            this.txt_montocredito.MaxLength = 8;
            this.txt_montocredito.Name = "txt_montocredito";
            this.txt_montocredito.Size = new System.Drawing.Size(176, 20);
            this.txt_montocredito.TabIndex = 0;
            this.txt_montocredito.Tag = "ingrese";
            // 
            // tc_informe
            // 
            this.tc_informe.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tc_informe.Controls.Add(this.informetareos);
            this.tc_informe.Controls.Add(this.informeemp);
            this.tc_informe.ItemSize = new System.Drawing.Size(1, 1);
            this.tc_informe.Location = new System.Drawing.Point(0, 43);
            this.tc_informe.Name = "tc_informe";
            this.tc_informe.SelectedIndex = 0;
            this.tc_informe.Size = new System.Drawing.Size(438, 562);
            this.tc_informe.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tc_informe.TabIndex = 301;
            // 
            // informetareos
            // 
            this.informetareos.Controls.Add(this.rbtnProcesos);
            this.informetareos.Controls.Add(this.rbtnAnalisis);
            this.informetareos.Controls.Add(this.rbtnInformativos);
            this.informetareos.Controls.Add(this.gbAnalisis);
            this.informetareos.Controls.Add(this.gbProcesos);
            this.informetareos.Controls.Add(this.gbInformativos);
            this.informetareos.Location = new System.Drawing.Point(4, 5);
            this.informetareos.Name = "informetareos";
            this.informetareos.Size = new System.Drawing.Size(430, 553);
            this.informetareos.TabIndex = 1;
            this.informetareos.UseVisualStyleBackColor = true;
            // 
            // rbtnProcesos
            // 
            this.rbtnProcesos.AutoSize = true;
            this.rbtnProcesos.Location = new System.Drawing.Point(32, 290);
            this.rbtnProcesos.Name = "rbtnProcesos";
            this.rbtnProcesos.Size = new System.Drawing.Size(69, 17);
            this.rbtnProcesos.TabIndex = 303;
            this.rbtnProcesos.Text = "Procesos";
            this.rbtnProcesos.UseVisualStyleBackColor = true;
            this.rbtnProcesos.CheckedChanged += new System.EventHandler(this.rbtnProcesos_CheckedChanged);
            // 
            // rbtnAnalisis
            // 
            this.rbtnAnalisis.AutoSize = true;
            this.rbtnAnalisis.Location = new System.Drawing.Point(29, 453);
            this.rbtnAnalisis.Name = "rbtnAnalisis";
            this.rbtnAnalisis.Size = new System.Drawing.Size(101, 17);
            this.rbtnAnalisis.TabIndex = 304;
            this.rbtnAnalisis.Text = "Análsis y Costos";
            this.rbtnAnalisis.UseVisualStyleBackColor = true;
            this.rbtnAnalisis.CheckedChanged += new System.EventHandler(this.rbtnAnalisis_CheckedChanged);
            // 
            // rbtnInformativos
            // 
            this.rbtnInformativos.AutoSize = true;
            this.rbtnInformativos.Location = new System.Drawing.Point(28, 24);
            this.rbtnInformativos.Name = "rbtnInformativos";
            this.rbtnInformativos.Size = new System.Drawing.Size(82, 17);
            this.rbtnInformativos.TabIndex = 302;
            this.rbtnInformativos.Text = "Informativos";
            this.rbtnInformativos.UseVisualStyleBackColor = true;
            this.rbtnInformativos.CheckedChanged += new System.EventHandler(this.rbtnInformativos_CheckedChanged);
            // 
            // gbAnalisis
            // 
            this.gbAnalisis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAnalisis.Controls.Add(this.rbtnPlanilla);
            this.gbAnalisis.Controls.Add(this.rbtnConsolidado);
            this.gbAnalisis.Location = new System.Drawing.Point(20, 455);
            this.gbAnalisis.Name = "gbAnalisis";
            this.gbAnalisis.Size = new System.Drawing.Size(391, 84);
            this.gbAnalisis.TabIndex = 305;
            this.gbAnalisis.TabStop = false;
            // 
            // rbtnPlanilla
            // 
            this.rbtnPlanilla.AutoSize = true;
            this.rbtnPlanilla.Location = new System.Drawing.Point(12, 56);
            this.rbtnPlanilla.Name = "rbtnPlanilla";
            this.rbtnPlanilla.Size = new System.Drawing.Size(149, 17);
            this.rbtnPlanilla.TabIndex = 275;
            this.rbtnPlanilla.Text = "Tareo por Planilla de pago";
            this.rbtnPlanilla.UseVisualStyleBackColor = true;
            // 
            // rbtnConsolidado
            // 
            this.rbtnConsolidado.AutoSize = true;
            this.rbtnConsolidado.Location = new System.Drawing.Point(12, 32);
            this.rbtnConsolidado.Name = "rbtnConsolidado";
            this.rbtnConsolidado.Size = new System.Drawing.Size(129, 17);
            this.rbtnConsolidado.TabIndex = 274;
            this.rbtnConsolidado.Text = "Consolidado de Tareo";
            this.rbtnConsolidado.UseVisualStyleBackColor = true;
            // 
            // gbProcesos
            // 
            this.gbProcesos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProcesos.Controls.Add(this.groupBox1);
            this.gbProcesos.Controls.Add(this.cboSemana_proc);
            this.gbProcesos.Controls.Add(this.txtFechaFin_reg);
            this.gbProcesos.Controls.Add(this.cboAnio_proc);
            this.gbProcesos.Controls.Add(this.txtFechaIni_reg);
            this.gbProcesos.Controls.Add(this.label2);
            this.gbProcesos.Controls.Add(this.cboPlanilla_rep);
            this.gbProcesos.Controls.Add(this.label1);
            this.gbProcesos.Controls.Add(this.label26);
            this.gbProcesos.Controls.Add(this.checkBox1);
            this.gbProcesos.Location = new System.Drawing.Point(20, 292);
            this.gbProcesos.Name = "gbProcesos";
            this.gbProcesos.Size = new System.Drawing.Size(391, 134);
            this.gbProcesos.TabIndex = 304;
            this.gbProcesos.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnOtDiferenciado);
            this.groupBox1.Controls.Add(this.rbtnOtStarsoft);
            this.groupBox1.Location = new System.Drawing.Point(263, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 66);
            this.groupBox1.TabIndex = 306;
            this.groupBox1.TabStop = false;
            // 
            // rbtnOtDiferenciado
            // 
            this.rbtnOtDiferenciado.AutoSize = true;
            this.rbtnOtDiferenciado.Location = new System.Drawing.Point(8, 39);
            this.rbtnOtDiferenciado.Name = "rbtnOtDiferenciado";
            this.rbtnOtDiferenciado.Size = new System.Drawing.Size(101, 17);
            this.rbtnOtDiferenciado.TabIndex = 289;
            this.rbtnOtDiferenciado.TabStop = true;
            this.rbtnOtDiferenciado.Text = "OT diferenciado";
            this.rbtnOtDiferenciado.UseVisualStyleBackColor = true;
            // 
            // rbtnOtStarsoft
            // 
            this.rbtnOtStarsoft.AutoSize = true;
            this.rbtnOtStarsoft.Location = new System.Drawing.Point(8, 15);
            this.rbtnOtStarsoft.Name = "rbtnOtStarsoft";
            this.rbtnOtStarsoft.Size = new System.Drawing.Size(77, 17);
            this.rbtnOtStarsoft.TabIndex = 288;
            this.rbtnOtStarsoft.TabStop = true;
            this.rbtnOtStarsoft.Text = "OT starsoft";
            this.rbtnOtStarsoft.UseVisualStyleBackColor = true;
            // 
            // cboSemana_proc
            // 
            this.cboSemana_proc.FormattingEnabled = true;
            this.cboSemana_proc.Location = new System.Drawing.Point(67, 65);
            this.cboSemana_proc.Name = "cboSemana_proc";
            this.cboSemana_proc.Size = new System.Drawing.Size(117, 21);
            this.cboSemana_proc.TabIndex = 309;
            this.cboSemana_proc.SelectionChangeCommitted += new System.EventHandler(this.cboSemana_proc_SelectionChangeCommitted);
            // 
            // txtFechaFin_reg
            // 
            this.txtFechaFin_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaFin_reg.Location = new System.Drawing.Point(154, 86);
            this.txtFechaFin_reg.Name = "txtFechaFin_reg";
            this.txtFechaFin_reg.ReadOnly = true;
            this.txtFechaFin_reg.Size = new System.Drawing.Size(82, 20);
            this.txtFechaFin_reg.TabIndex = 307;
            this.txtFechaFin_reg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFechaFin_reg.Visible = false;
            // 
            // cboAnio_proc
            // 
            this.cboAnio_proc.FormattingEnabled = true;
            this.cboAnio_proc.Location = new System.Drawing.Point(67, 39);
            this.cboAnio_proc.Name = "cboAnio_proc";
            this.cboAnio_proc.Size = new System.Drawing.Size(117, 21);
            this.cboAnio_proc.TabIndex = 308;
            this.cboAnio_proc.SelectionChangeCommitted += new System.EventHandler(this.cboAnio_proc_SelectionChangeCommitted);
            // 
            // txtFechaIni_reg
            // 
            this.txtFechaIni_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaIni_reg.Location = new System.Drawing.Point(51, 86);
            this.txtFechaIni_reg.Name = "txtFechaIni_reg";
            this.txtFechaIni_reg.ReadOnly = true;
            this.txtFechaIni_reg.Size = new System.Drawing.Size(81, 20);
            this.txtFechaIni_reg.TabIndex = 306;
            this.txtFechaIni_reg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFechaIni_reg.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 287;
            this.label2.Text = "Semana";
            // 
            // cboPlanilla_rep
            // 
            this.cboPlanilla_rep.FormattingEnabled = true;
            this.cboPlanilla_rep.Location = new System.Drawing.Point(67, 106);
            this.cboPlanilla_rep.Name = "cboPlanilla_rep";
            this.cboPlanilla_rep.Size = new System.Drawing.Size(215, 21);
            this.cboPlanilla_rep.TabIndex = 284;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 14);
            this.label1.TabIndex = 284;
            this.label1.Text = "Año";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(15, 109);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(39, 14);
            this.label26.TabIndex = 280;
            this.label26.Text = "Planilla";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(288, 108);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 17);
            this.checkBox1.TabIndex = 276;
            this.checkBox1.Text = "Mostrar Detalle";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // gbInformativos
            // 
            this.gbInformativos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInformativos.Controls.Add(this.groupBox3);
            this.gbInformativos.Controls.Add(this.groupBox2);
            this.gbInformativos.Controls.Add(this.chkHrsTot);
            this.gbInformativos.Controls.Add(this.txtDni_rep);
            this.gbInformativos.Controls.Add(this.label29);
            this.gbInformativos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbInformativos.Location = new System.Drawing.Point(20, 26);
            this.gbInformativos.Name = "gbInformativos";
            this.gbInformativos.Size = new System.Drawing.Size(391, 235);
            this.gbInformativos.TabIndex = 303;
            this.gbInformativos.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboAnio_inf);
            this.groupBox3.Controls.Add(this.cboMes_inf);
            this.groupBox3.Controls.Add(this.cboSemana_inf);
            this.groupBox3.Controls.Add(this.dtpFechaFin_rep);
            this.groupBox3.Controls.Add(this.dtpFechaIni_rep);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.rbtnMes);
            this.groupBox3.Controls.Add(this.rbtnSemana);
            this.groupBox3.Controls.Add(this.rbtnDesde);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Location = new System.Drawing.Point(38, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 127);
            this.groupBox3.TabIndex = 308;
            this.groupBox3.TabStop = false;
            // 
            // cboAnio_inf
            // 
            this.cboAnio_inf.FormattingEnabled = true;
            this.cboAnio_inf.Location = new System.Drawing.Point(77, 14);
            this.cboAnio_inf.Name = "cboAnio_inf";
            this.cboAnio_inf.Size = new System.Drawing.Size(117, 21);
            this.cboAnio_inf.TabIndex = 289;
            this.cboAnio_inf.SelectionChangeCommitted += new System.EventHandler(this.cboAnio_inf_SelectionChangeCommitted);
            // 
            // cboMes_inf
            // 
            this.cboMes_inf.FormattingEnabled = true;
            this.cboMes_inf.Location = new System.Drawing.Point(77, 39);
            this.cboMes_inf.Name = "cboMes_inf";
            this.cboMes_inf.Size = new System.Drawing.Size(117, 21);
            this.cboMes_inf.TabIndex = 288;
            // 
            // cboSemana_inf
            // 
            this.cboSemana_inf.FormattingEnabled = true;
            this.cboSemana_inf.Location = new System.Drawing.Point(77, 64);
            this.cboSemana_inf.Name = "cboSemana_inf";
            this.cboSemana_inf.Size = new System.Drawing.Size(117, 21);
            this.cboSemana_inf.TabIndex = 286;
            // 
            // dtpFechaFin_rep
            // 
            this.dtpFechaFin_rep.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin_rep.Location = new System.Drawing.Point(219, 92);
            this.dtpFechaFin_rep.Name = "dtpFechaFin_rep";
            this.dtpFechaFin_rep.Size = new System.Drawing.Size(88, 20);
            this.dtpFechaFin_rep.TabIndex = 287;
            // 
            // dtpFechaIni_rep
            // 
            this.dtpFechaIni_rep.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni_rep.Location = new System.Drawing.Point(77, 92);
            this.dtpFechaIni_rep.Name = "dtpFechaIni_rep";
            this.dtpFechaIni_rep.Size = new System.Drawing.Size(88, 20);
            this.dtpFechaIni_rep.TabIndex = 285;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(175, 97);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(34, 14);
            this.label27.TabIndex = 284;
            this.label27.Text = "hasta";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbtnMes
            // 
            this.rbtnMes.AutoSize = true;
            this.rbtnMes.Location = new System.Drawing.Point(5, 36);
            this.rbtnMes.Name = "rbtnMes";
            this.rbtnMes.Size = new System.Drawing.Size(45, 17);
            this.rbtnMes.TabIndex = 274;
            this.rbtnMes.Text = "Mes";
            this.rbtnMes.UseVisualStyleBackColor = true;
            this.rbtnMes.CheckedChanged += new System.EventHandler(this.rbtnMes_CheckedChanged);
            // 
            // rbtnSemana
            // 
            this.rbtnSemana.AutoSize = true;
            this.rbtnSemana.Location = new System.Drawing.Point(5, 63);
            this.rbtnSemana.Name = "rbtnSemana";
            this.rbtnSemana.Size = new System.Drawing.Size(64, 17);
            this.rbtnSemana.TabIndex = 275;
            this.rbtnSemana.Text = "Semana";
            this.rbtnSemana.UseVisualStyleBackColor = true;
            this.rbtnSemana.CheckedChanged += new System.EventHandler(this.rbtnSemana_CheckedChanged);
            // 
            // rbtnDesde
            // 
            this.rbtnDesde.AutoSize = true;
            this.rbtnDesde.Location = new System.Drawing.Point(5, 90);
            this.rbtnDesde.Name = "rbtnDesde";
            this.rbtnDesde.Size = new System.Drawing.Size(56, 17);
            this.rbtnDesde.TabIndex = 276;
            this.rbtnDesde.Text = "Desde";
            this.rbtnDesde.UseVisualStyleBackColor = true;
            this.rbtnDesde.CheckedChanged += new System.EventHandler(this.rbtnDesde_CheckedChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(23, 16);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(27, 14);
            this.label32.TabIndex = 263;
            this.label32.Text = "Año";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnProduccion);
            this.groupBox2.Controls.Add(this.rbtnRrhh);
            this.groupBox2.Location = new System.Drawing.Point(8, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 56);
            this.groupBox2.TabIndex = 307;
            this.groupBox2.TabStop = false;
            // 
            // rbtnProduccion
            // 
            this.rbtnProduccion.AutoSize = true;
            this.rbtnProduccion.Location = new System.Drawing.Point(6, 11);
            this.rbtnProduccion.Name = "rbtnProduccion";
            this.rbtnProduccion.Size = new System.Drawing.Size(120, 17);
            this.rbtnProduccion.TabIndex = 274;
            this.rbtnProduccion.Text = "Formato Producción";
            this.rbtnProduccion.UseVisualStyleBackColor = true;
            // 
            // rbtnRrhh
            // 
            this.rbtnRrhh.AutoSize = true;
            this.rbtnRrhh.Location = new System.Drawing.Point(6, 32);
            this.rbtnRrhh.Name = "rbtnRrhh";
            this.rbtnRrhh.Size = new System.Drawing.Size(98, 17);
            this.rbtnRrhh.TabIndex = 275;
            this.rbtnRrhh.Text = "Formato RRHH";
            this.rbtnRrhh.UseVisualStyleBackColor = true;
            // 
            // chkHrsTot
            // 
            this.chkHrsTot.AutoSize = true;
            this.chkHrsTot.Location = new System.Drawing.Point(12, 208);
            this.chkHrsTot.Name = "chkHrsTot";
            this.chkHrsTot.Size = new System.Drawing.Size(130, 17);
            this.chkHrsTot.TabIndex = 276;
            this.chkHrsTot.Text = "Mostrar Horas Totales";
            this.chkHrsTot.UseVisualStyleBackColor = true;
            // 
            // txtDni_rep
            // 
            this.txtDni_rep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDni_rep.Location = new System.Drawing.Point(249, 205);
            this.txtDni_rep.MaxLength = 8;
            this.txtDni_rep.Name = "txtDni_rep";
            this.txtDni_rep.Size = new System.Drawing.Size(117, 20);
            this.txtDni_rep.TabIndex = 277;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(196, 208);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(23, 14);
            this.label29.TabIndex = 278;
            this.label29.Text = "DNI";
            // 
            // informeemp
            // 
            this.informeemp.Controls.Add(this.txt_montocredito);
            this.informeemp.Controls.Add(this.lbl_montocredito);
            this.informeemp.Location = new System.Drawing.Point(4, 5);
            this.informeemp.Name = "informeemp";
            this.informeemp.Size = new System.Drawing.Size(430, 553);
            this.informeemp.TabIndex = 0;
            this.informeemp.UseVisualStyleBackColor = true;
            // 
            // BW
            // 
            this.BW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_DoWork);
            this.BW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BW_RunWorkerCompleted);
            // 
            // FrmCriteriosSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 648);
            this.ControlBox = false;
            this.Controls.Add(this.ss_load);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.btn_grabar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.tc_informe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCriteriosSeleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            this.ss_load.ResumeLayout(false);
            this.ss_load.PerformLayout();
            this.titulo.ResumeLayout(false);
            this.titulo.PerformLayout();
            this.tc_informe.ResumeLayout(false);
            this.informetareos.ResumeLayout(false);
            this.informetareos.PerformLayout();
            this.gbAnalisis.ResumeLayout(false);
            this.gbAnalisis.PerformLayout();
            this.gbProcesos.ResumeLayout(false);
            this.gbProcesos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbInformativos.ResumeLayout(false);
            this.gbInformativos.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.informeemp.ResumeLayout(false);
            this.informeemp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_grabar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.StatusStrip ss_load;
        private System.Windows.Forms.ToolStripStatusLabel lbl_contador_registros;
        private System.Windows.Forms.ToolStripStatusLabel lbl_U_CL_CODSOL;
        private System.Windows.Forms.ToolStripStatusLabel lbl_U_CL_SOLICI;
        private System.Windows.Forms.ToolStripStatusLabel lbl_msg;
        private System.Windows.Forms.ToolStripStatusLabel lbl_maximi;
        private System.Windows.Forms.Timer t_msg;
        private System.Windows.Forms.ToolStrip titulo;
        private System.Windows.Forms.ToolStripLabel tsl_titulo;
        private System.Windows.Forms.ToolStripButton salir;
        private System.Windows.Forms.ToolStripButton ninimizar;
        private System.Windows.Forms.Label lbl_montocredito;
        private System.Windows.Forms.TextBox txt_montocredito;
        private System.Windows.Forms.TabControl tc_informe;
        private System.Windows.Forms.TabPage informeemp;
        private System.Windows.Forms.TabPage informetareos;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtDni_rep;
        private System.Windows.Forms.RadioButton rbtnDesde;
        private System.Windows.Forms.RadioButton rbtnSemana;
        private System.Windows.Forms.RadioButton rbtnMes;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.RadioButton rbtnInformativos;
        private System.Windows.Forms.RadioButton rbtnProcesos;
        private System.Windows.Forms.RadioButton rbtnAnalisis;
        private System.Windows.Forms.GroupBox gbInformativos;
        private System.Windows.Forms.CheckBox chkHrsTot;
        private System.Windows.Forms.RadioButton rbtnRrhh;
        private System.Windows.Forms.RadioButton rbtnProduccion;
        private System.Windows.Forms.GroupBox gbProcesos;
        private System.Windows.Forms.ComboBox cboPlanilla_rep;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox gbAnalisis;
        private System.Windows.Forms.RadioButton rbtnPlanilla;
        private System.Windows.Forms.RadioButton rbtnConsolidado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnOtDiferenciado;
        private System.Windows.Forms.RadioButton rbtnOtStarsoft;
        private System.Windows.Forms.TextBox txtFechaFin_reg;
        private System.Windows.Forms.TextBox txtFechaIni_reg;
        private System.Windows.Forms.ComboBox cboSemana_proc;
        private System.Windows.Forms.ComboBox cboAnio_proc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboAnio_inf;
        private System.Windows.Forms.ComboBox cboMes_inf;
        private System.Windows.Forms.ComboBox cboSemana_inf;
        private System.Windows.Forms.DateTimePicker dtpFechaFin_rep;
        private System.Windows.Forms.DateTimePicker dtpFechaIni_rep;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker BW;
    }
}