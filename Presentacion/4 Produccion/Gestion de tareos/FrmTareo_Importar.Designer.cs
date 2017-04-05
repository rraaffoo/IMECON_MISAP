namespace MISAP
{
    partial class FrmTareo_Importar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFechaFin_imp = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtFechaIni_imp = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTareo_imp = new System.Windows.Forms.DataGridView();
            this.seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cm_grilla = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cm_grilla_copia = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_grilla_copia_tabla = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_load = new System.Windows.Forms.StatusStrip();
            this.lbl_contador_registros = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_CODSOL = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_SOLICI = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_msg = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_dni = new System.Windows.Forms.ToolStripStatusLabel();
            this.t_msg = new System.Windows.Forms.Timer(this.components);
            this.l_usuario = new System.Windows.Forms.Label();
            this.l_dni = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt16 = new System.Windows.Forms.TextBox();
            this.txt17 = new System.Windows.Forms.TextBox();
            this.txt15 = new System.Windows.Forms.TextBox();
            this.txt13 = new System.Windows.Forms.TextBox();
            this.txt14 = new System.Windows.Forms.TextBox();
            this.txt12 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.txt11 = new System.Windows.Forms.TextBox();
            this.txt9 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.cboTareador_imp = new System.Windows.Forms.ComboBox();
            this.label44 = new System.Windows.Forms.Label();
            this.cboSemana_imp = new System.Windows.Forms.ComboBox();
            this.cboAnio_imp = new System.Windows.Forms.ComboBox();
            this.btnSubirArch_imp = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.ToolStrip();
            this.tsl_titulo = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.maximizar = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            this.ts_acciones = new System.Windows.Forms.ToolStrip();
            this.btn_nuevo_b = new System.Windows.Forms.ToolStripButton();
            this.btn_editar_b = new System.Windows.Forms.ToolStripButton();
            this.btn_consultar_b = new System.Windows.Forms.ToolStripButton();
            this.btn_eliminar_b = new System.Windows.Forms.ToolStripButton();
            this.btn_imprimir = new System.Windows.Forms.ToolStripButton();
            this.btn_previsualizar = new System.Windows.Forms.ToolStripButton();
            this.btn_exportar_xls = new System.Windows.Forms.ToolStripButton();
            this.btn_aprobar = new System.Windows.Forms.ToolStripButton();
            this.btn_desaprobar = new System.Windows.Forms.ToolStripButton();
            this.btn_actualizar = new System.Windows.Forms.ToolStripButton();
            this.btn_ayuda = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareo_imp)).BeginInit();
            this.cm_grilla.SuspendLayout();
            this.ss_load.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.titulo.SuspendLayout();
            this.ts_acciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFechaFin_imp
            // 
            this.txtFechaFin_imp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaFin_imp.Location = new System.Drawing.Point(617, 94);
            this.txtFechaFin_imp.Name = "txtFechaFin_imp";
            this.txtFechaFin_imp.ReadOnly = true;
            this.txtFechaFin_imp.Size = new System.Drawing.Size(69, 20);
            this.txtFechaFin_imp.TabIndex = 246;
            this.txtFechaFin_imp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(534, 96);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 14);
            this.label21.TabIndex = 245;
            this.label21.Text = "Hasta";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFechaIni_imp
            // 
            this.txtFechaIni_imp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaIni_imp.Location = new System.Drawing.Point(434, 94);
            this.txtFechaIni_imp.Name = "txtFechaIni_imp";
            this.txtFechaIni_imp.ReadOnly = true;
            this.txtFechaIni_imp.Size = new System.Drawing.Size(69, 20);
            this.txtFechaIni_imp.TabIndex = 244;
            this.txtFechaIni_imp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(345, 96);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 14);
            this.label20.TabIndex = 243;
            this.label20.Text = "Desde";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(187, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 109;
            this.label5.Text = "Semana";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 14);
            this.label1.TabIndex = 107;
            this.label1.Text = "Año";
            // 
            // dgvTareo_imp
            // 
            this.dgvTareo_imp.AllowUserToAddRows = false;
            this.dgvTareo_imp.AllowUserToDeleteRows = false;
            this.dgvTareo_imp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTareo_imp.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTareo_imp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTareo_imp.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTareo_imp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTareo_imp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seleccion});
            this.dgvTareo_imp.ContextMenuStrip = this.cm_grilla;
            this.dgvTareo_imp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTareo_imp.EnableHeadersVisualStyles = false;
            this.dgvTareo_imp.Location = new System.Drawing.Point(3, 16);
            this.dgvTareo_imp.Name = "dgvTareo_imp";
            this.dgvTareo_imp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTareo_imp.Size = new System.Drawing.Size(987, 371);
            this.dgvTareo_imp.TabIndex = 258;
            this.dgvTareo_imp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tareo_CellContentClick);
            this.dgvTareo_imp.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_tareo_CurrentCellDirtyStateChanged_1);
            // 
            // seleccion
            // 
            this.seleccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.seleccion.Frozen = true;
            this.seleccion.HeaderText = "";
            this.seleccion.Name = "seleccion";
            this.seleccion.Visible = false;
            this.seleccion.Width = 25;
            // 
            // cm_grilla
            // 
            this.cm_grilla.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cm_grilla_copia,
            this.cm_grilla_copia_tabla});
            this.cm_grilla.Name = "cm_grilla";
            this.cm_grilla.Size = new System.Drawing.Size(135, 48);
            // 
            // cm_grilla_copia
            // 
            this.cm_grilla_copia.Name = "cm_grilla_copia";
            this.cm_grilla_copia.Size = new System.Drawing.Size(134, 22);
            this.cm_grilla_copia.Text = "Copia";
            this.cm_grilla_copia.Click += new System.EventHandler(this.cm_grilla_copia_Click);
            // 
            // cm_grilla_copia_tabla
            // 
            this.cm_grilla_copia_tabla.Name = "cm_grilla_copia_tabla";
            this.cm_grilla_copia_tabla.Size = new System.Drawing.Size(134, 22);
            this.cm_grilla_copia_tabla.Text = "Copia tabla";
            this.cm_grilla_copia_tabla.Click += new System.EventHandler(this.cm_grilla_copia_tabla_Click);
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
            this.toolStripStatusLabel1,
            this.lbl_dni});
            this.ss_load.Location = new System.Drawing.Point(0, 566);
            this.ss_load.Name = "ss_load";
            this.ss_load.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ss_load.Size = new System.Drawing.Size(1013, 18);
            this.ss_load.SizingGrip = false;
            this.ss_load.TabIndex = 278;
            this.ss_load.Text = "statusStrip1";
            // 
            // lbl_contador_registros
            // 
            this.lbl_contador_registros.BackColor = System.Drawing.Color.Transparent;
            this.lbl_contador_registros.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contador_registros.Name = "lbl_contador_registros";
            this.lbl_contador_registros.Size = new System.Drawing.Size(75, 13);
            this.lbl_contador_registros.Text = "Total registros";
            this.lbl_contador_registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lbl_msg.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.ForeColor = System.Drawing.Color.White;
            this.lbl_msg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_msg.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(31, 13);
            this.lbl_msg.Text = "msg";
            this.lbl_msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_msg.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(18, 13);
            this.toolStripStatusLabel1.Text = "1";
            this.toolStripStatusLabel1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripStatusLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripStatusLabel1.Visible = false;
            // 
            // lbl_dni
            // 
            this.lbl_dni.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbl_dni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(33, 13);
            this.lbl_dni.Text = "DNI";
            this.lbl_dni.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.lbl_dni.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.lbl_dni.Visible = false;
            // 
            // t_msg
            // 
            this.t_msg.Interval = 4000;
            this.t_msg.Tick += new System.EventHandler(this.t_msg_Tick);
            // 
            // l_usuario
            // 
            this.l_usuario.AutoSize = true;
            this.l_usuario.Location = new System.Drawing.Point(269, 596);
            this.l_usuario.Name = "l_usuario";
            this.l_usuario.Size = new System.Drawing.Size(61, 13);
            this.l_usuario.TabIndex = 283;
            this.l_usuario.Text = "                  ";
            this.l_usuario.Visible = false;
            // 
            // l_dni
            // 
            this.l_dni.AutoSize = true;
            this.l_dni.Location = new System.Drawing.Point(431, 596);
            this.l_dni.Name = "l_dni";
            this.l_dni.Size = new System.Drawing.Size(61, 13);
            this.l_dni.TabIndex = 284;
            this.l_dni.Text = "                  ";
            this.l_dni.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txt16);
            this.groupBox4.Controls.Add(this.txt17);
            this.groupBox4.Controls.Add(this.txt15);
            this.groupBox4.Controls.Add(this.txt13);
            this.groupBox4.Controls.Add(this.txt14);
            this.groupBox4.Controls.Add(this.txt12);
            this.groupBox4.Controls.Add(this.txt6);
            this.groupBox4.Controls.Add(this.txt4);
            this.groupBox4.Controls.Add(this.txt8);
            this.groupBox4.Controls.Add(this.txt10);
            this.groupBox4.Controls.Add(this.txt11);
            this.groupBox4.Controls.Add(this.txt9);
            this.groupBox4.Controls.Add(this.txt7);
            this.groupBox4.Controls.Add(this.txt5);
            this.groupBox4.Controls.Add(this.txt3);
            this.groupBox4.Controls.Add(this.txt2);
            this.groupBox4.Controls.Add(this.txt1);
            this.groupBox4.Controls.Add(this.dgvTareo_imp);
            this.groupBox4.Location = new System.Drawing.Point(8, 146);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(993, 390);
            this.groupBox4.TabIndex = 285;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Listado de Registros a Importar";
            // 
            // txt16
            // 
            this.txt16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt16.Location = new System.Drawing.Point(196, 247);
            this.txt16.Name = "txt16";
            this.txt16.Size = new System.Drawing.Size(53, 20);
            this.txt16.TabIndex = 306;
            this.txt16.Visible = false;
            // 
            // txt17
            // 
            this.txt17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt17.Location = new System.Drawing.Point(256, 169);
            this.txt17.Name = "txt17";
            this.txt17.Size = new System.Drawing.Size(52, 20);
            this.txt17.TabIndex = 305;
            this.txt17.Visible = false;
            // 
            // txt15
            // 
            this.txt15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt15.Location = new System.Drawing.Point(197, 221);
            this.txt15.Name = "txt15";
            this.txt15.Size = new System.Drawing.Size(53, 20);
            this.txt15.TabIndex = 304;
            this.txt15.Visible = false;
            // 
            // txt13
            // 
            this.txt13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt13.Location = new System.Drawing.Point(9, 247);
            this.txt13.Name = "txt13";
            this.txt13.Size = new System.Drawing.Size(53, 20);
            this.txt13.TabIndex = 303;
            this.txt13.Visible = false;
            // 
            // txt14
            // 
            this.txt14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt14.Location = new System.Drawing.Point(197, 195);
            this.txt14.Name = "txt14";
            this.txt14.Size = new System.Drawing.Size(52, 20);
            this.txt14.TabIndex = 302;
            this.txt14.Visible = false;
            // 
            // txt12
            // 
            this.txt12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt12.Location = new System.Drawing.Point(9, 221);
            this.txt12.Name = "txt12";
            this.txt12.Size = new System.Drawing.Size(53, 20);
            this.txt12.TabIndex = 301;
            this.txt12.Visible = false;
            // 
            // txt6
            // 
            this.txt6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt6.Location = new System.Drawing.Point(126, 169);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(53, 20);
            this.txt6.TabIndex = 299;
            this.txt6.Visible = false;
            // 
            // txt4
            // 
            this.txt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt4.Location = new System.Drawing.Point(70, 221);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(52, 20);
            this.txt4.TabIndex = 300;
            this.txt4.Visible = false;
            // 
            // txt8
            // 
            this.txt8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt8.Location = new System.Drawing.Point(128, 221);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(52, 20);
            this.txt8.TabIndex = 298;
            this.txt8.Visible = false;
            // 
            // txt10
            // 
            this.txt10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt10.Location = new System.Drawing.Point(197, 169);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(53, 20);
            this.txt10.TabIndex = 297;
            this.txt10.Visible = false;
            // 
            // txt11
            // 
            this.txt11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt11.Location = new System.Drawing.Point(8, 195);
            this.txt11.Name = "txt11";
            this.txt11.Size = new System.Drawing.Size(52, 20);
            this.txt11.TabIndex = 296;
            this.txt11.Visible = false;
            // 
            // txt9
            // 
            this.txt9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt9.Location = new System.Drawing.Point(129, 247);
            this.txt9.Name = "txt9";
            this.txt9.Size = new System.Drawing.Size(53, 20);
            this.txt9.TabIndex = 295;
            this.txt9.Visible = false;
            // 
            // txt7
            // 
            this.txt7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt7.Location = new System.Drawing.Point(128, 195);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(52, 20);
            this.txt7.TabIndex = 294;
            this.txt7.Visible = false;
            // 
            // txt5
            // 
            this.txt5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt5.Location = new System.Drawing.Point(70, 247);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(53, 20);
            this.txt5.TabIndex = 293;
            this.txt5.Visible = false;
            // 
            // txt3
            // 
            this.txt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt3.Location = new System.Drawing.Point(70, 195);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(52, 20);
            this.txt3.TabIndex = 292;
            this.txt3.Visible = false;
            // 
            // txt2
            // 
            this.txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2.Location = new System.Drawing.Point(67, 169);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(53, 20);
            this.txt2.TabIndex = 291;
            this.txt2.Visible = false;
            // 
            // txt1
            // 
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt1.Location = new System.Drawing.Point(9, 169);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(52, 20);
            this.txt1.TabIndex = 290;
            this.txt1.Visible = false;
            // 
            // cboTareador_imp
            // 
            this.cboTareador_imp.BackColor = System.Drawing.Color.White;
            this.cboTareador_imp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTareador_imp.FormattingEnabled = true;
            this.cboTareador_imp.ItemHeight = 14;
            this.cboTareador_imp.Location = new System.Drawing.Point(78, 119);
            this.cboTareador_imp.Name = "cboTareador_imp";
            this.cboTareador_imp.Size = new System.Drawing.Size(239, 22);
            this.cboTareador_imp.TabIndex = 290;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(13, 125);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(50, 14);
            this.label44.TabIndex = 289;
            this.label44.Text = "Tareador";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboSemana_imp
            // 
            this.cboSemana_imp.FormattingEnabled = true;
            this.cboSemana_imp.Location = new System.Drawing.Point(244, 93);
            this.cboSemana_imp.Name = "cboSemana_imp";
            this.cboSemana_imp.Size = new System.Drawing.Size(72, 21);
            this.cboSemana_imp.TabIndex = 292;
            this.cboSemana_imp.SelectionChangeCommitted += new System.EventHandler(this.cboSemana_imp_SelectionChangeCommitted);
            // 
            // cboAnio_imp
            // 
            this.cboAnio_imp.FormattingEnabled = true;
            this.cboAnio_imp.Location = new System.Drawing.Point(78, 93);
            this.cboAnio_imp.Name = "cboAnio_imp";
            this.cboAnio_imp.Size = new System.Drawing.Size(72, 21);
            this.cboAnio_imp.TabIndex = 291;
            this.cboAnio_imp.SelectionChangeCommitted += new System.EventHandler(this.cboAnio_imp_SelectionChangeCommitted);
            // 
            // btnSubirArch_imp
            // 
            this.btnSubirArch_imp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSubirArch_imp.BackgroundImage = global::MISAP.Properties.Resources.btn_explorar;
            this.btnSubirArch_imp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubirArch_imp.FlatAppearance.BorderSize = 0;
            this.btnSubirArch_imp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSubirArch_imp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSubirArch_imp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirArch_imp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirArch_imp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubirArch_imp.Location = new System.Drawing.Point(467, 124);
            this.btnSubirArch_imp.Name = "btnSubirArch_imp";
            this.btnSubirArch_imp.Size = new System.Drawing.Size(26, 14);
            this.btnSubirArch_imp.TabIndex = 286;
            this.btnSubirArch_imp.UseVisualStyleBackColor = true;
            this.btnSubirArch_imp.Click += new System.EventHandler(this.btnSubirArch_imp_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportar.BackgroundImage = global::MISAP.Properties.Resources.btn_enfasis;
            this.btnImportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImportar.Enabled = false;
            this.btnImportar.FlatAppearance.BorderSize = 0;
            this.btnImportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnImportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnImportar.Location = new System.Drawing.Point(11, 542);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(80, 21);
            this.btnImportar.TabIndex = 238;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackgroundImage = global::MISAP.Properties.Resources.btn;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(97, 542);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 21);
            this.btnCancelar.TabIndex = 293;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.titulo.Size = new System.Drawing.Size(1013, 27);
            this.titulo.TabIndex = 294;
            this.titulo.Text = "toolStrip1";
            this.titulo.DoubleClick += new System.EventHandler(this.titulo_DoubleClick);
            this.titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            // 
            // tsl_titulo
            // 
            this.tsl_titulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsl_titulo.Name = "tsl_titulo";
            this.tsl_titulo.Size = new System.Drawing.Size(123, 24);
            this.tsl_titulo.Text = "Importación de tareos";
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
            this.salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(23, 24);
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
            this.maximizar.Size = new System.Drawing.Size(23, 24);
            this.maximizar.Text = "Miminimizar tamaño";
            this.maximizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // ninimizar
            // 
            this.ninimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
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
            // ts_acciones
            // 
            this.ts_acciones.BackColor = System.Drawing.Color.White;
            this.ts_acciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ts_acciones.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_acciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_acciones.ImageScalingSize = new System.Drawing.Size(18, 19);
            this.ts_acciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nuevo_b,
            this.btn_editar_b,
            this.btn_consultar_b,
            this.btn_eliminar_b,
            this.btn_imprimir,
            this.btn_previsualizar,
            this.btn_exportar_xls,
            this.btn_aprobar,
            this.btn_desaprobar,
            this.btn_actualizar,
            this.btn_ayuda});
            this.ts_acciones.Location = new System.Drawing.Point(0, 27);
            this.ts_acciones.Name = "ts_acciones";
            this.ts_acciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ts_acciones.Size = new System.Drawing.Size(1013, 48);
            this.ts_acciones.TabIndex = 295;
            this.ts_acciones.Text = "toolStrip1";
            // 
            // btn_nuevo_b
            // 
            this.btn_nuevo_b.AutoSize = false;
            this.btn_nuevo_b.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_nuevo_b.Enabled = false;
            this.btn_nuevo_b.Image = global::MISAP.Properties.Resources.DATAadd;
            this.btn_nuevo_b.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nuevo_b.Name = "btn_nuevo_b";
            this.btn_nuevo_b.Size = new System.Drawing.Size(28, 42);
            this.btn_nuevo_b.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nuevo_b.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btn_nuevo_b.ToolTipText = "Nuevo";
            // 
            // btn_editar_b
            // 
            this.btn_editar_b.AutoSize = false;
            this.btn_editar_b.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_editar_b.Enabled = false;
            this.btn_editar_b.Image = global::MISAP.Properties.Resources.TOOLSdoceditor;
            this.btn_editar_b.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_editar_b.Name = "btn_editar_b";
            this.btn_editar_b.Size = new System.Drawing.Size(28, 42);
            this.btn_editar_b.Text = "Editar";
            this.btn_editar_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_editar_b.ToolTipText = "Editar";
            // 
            // btn_consultar_b
            // 
            this.btn_consultar_b.AutoSize = false;
            this.btn_consultar_b.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_consultar_b.Enabled = false;
            this.btn_consultar_b.Image = global::MISAP.Properties.Resources.DATAfind;
            this.btn_consultar_b.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_consultar_b.Name = "btn_consultar_b";
            this.btn_consultar_b.Size = new System.Drawing.Size(28, 42);
            this.btn_consultar_b.Text = "Consultar";
            this.btn_consultar_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_eliminar_b
            // 
            this.btn_eliminar_b.AutoSize = false;
            this.btn_eliminar_b.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_eliminar_b.Enabled = false;
            this.btn_eliminar_b.Image = global::MISAP.Properties.Resources.linkMapIconCancellation;
            this.btn_eliminar_b.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_eliminar_b.Name = "btn_eliminar_b";
            this.btn_eliminar_b.Size = new System.Drawing.Size(28, 42);
            this.btn_eliminar_b.Text = "Eliminar";
            this.btn_eliminar_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_eliminar_b.ToolTipText = "Eliminar";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.AutoSize = false;
            this.btn_imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_imprimir.Enabled = false;
            this.btn_imprimir.Image = global::MISAP.Properties.Resources.FILEprint;
            this.btn_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(28, 42);
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_imprimir.ToolTipText = "Imprimir";
            // 
            // btn_previsualizar
            // 
            this.btn_previsualizar.AutoSize = false;
            this.btn_previsualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_previsualizar.Enabled = false;
            this.btn_previsualizar.Image = global::MISAP.Properties.Resources.FILEprintp;
            this.btn_previsualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_previsualizar.Name = "btn_previsualizar";
            this.btn_previsualizar.Size = new System.Drawing.Size(28, 45);
            this.btn_previsualizar.Text = "Previsualizar";
            this.btn_previsualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_previsualizar.ToolTipText = "Previsualizar";
            // 
            // btn_exportar_xls
            // 
            this.btn_exportar_xls.AutoSize = false;
            this.btn_exportar_xls.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_exportar_xls.Enabled = false;
            this.btn_exportar_xls.Image = global::MISAP.Properties.Resources.FILEexcel;
            this.btn_exportar_xls.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_exportar_xls.Name = "btn_exportar_xls";
            this.btn_exportar_xls.Size = new System.Drawing.Size(28, 45);
            this.btn_exportar_xls.Text = "MS EXCEL";
            this.btn_exportar_xls.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_exportar_xls.ToolTipText = "MS EXCEL";
            // 
            // btn_aprobar
            // 
            this.btn_aprobar.AutoSize = false;
            this.btn_aprobar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_aprobar.Enabled = false;
            this.btn_aprobar.Image = global::MISAP.Properties.Resources.linkMapIconaancellation;
            this.btn_aprobar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_aprobar.Name = "btn_aprobar";
            this.btn_aprobar.Size = new System.Drawing.Size(28, 42);
            this.btn_aprobar.Text = "Aprobar";
            this.btn_aprobar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_aprobar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_aprobar.ToolTipText = "Aprobar";
            // 
            // btn_desaprobar
            // 
            this.btn_desaprobar.AutoSize = false;
            this.btn_desaprobar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_desaprobar.Enabled = false;
            this.btn_desaprobar.Image = global::MISAP.Properties.Resources.linkMapIconNotAuthorised;
            this.btn_desaprobar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_desaprobar.Name = "btn_desaprobar";
            this.btn_desaprobar.Size = new System.Drawing.Size(28, 42);
            this.btn_desaprobar.Text = "Rechazar";
            this.btn_desaprobar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_desaprobar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_desaprobar.ToolTipText = "Rechazar";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.AutoSize = false;
            this.btn_actualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_actualizar.Enabled = false;
            this.btn_actualizar.Image = global::MISAP.Properties.Resources.DATAthis;
            this.btn_actualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(28, 42);
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_actualizar.ToolTipText = "Actualizar";
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.AutoSize = false;
            this.btn_ayuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ayuda.Image = global::MISAP.Properties.Resources.help;
            this.btn_ayuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(28, 42);
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ayuda.ToolTipText = "Ayuda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 14);
            this.label2.TabIndex = 296;
            this.label2.Text = "Archivo para importar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmTareo_Importar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 584);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ts_acciones);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cboSemana_imp);
            this.Controls.Add(this.cboAnio_imp);
            this.Controls.Add(this.cboTareador_imp);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.btnSubirArch_imp);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtFechaFin_imp);
            this.Controls.Add(this.l_dni);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.l_usuario);
            this.Controls.Add(this.txtFechaIni_imp);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.ss_load);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImportar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmTareo_Importar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmTareo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareo_imp)).EndInit();
            this.cm_grilla.ResumeLayout(false);
            this.ss_load.ResumeLayout(false);
            this.ss_load.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.titulo.ResumeLayout(false);
            this.titulo.PerformLayout();
            this.ts_acciones.ResumeLayout(false);
            this.ts_acciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFechaFin_imp;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtFechaIni_imp;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvTareo_imp;
        private System.Windows.Forms.ContextMenuStrip cm_grilla;
        private System.Windows.Forms.ToolStripMenuItem cm_grilla_copia;
        private System.Windows.Forms.ToolStripMenuItem cm_grilla_copia_tabla;
        private System.Windows.Forms.StatusStrip ss_load;
        private System.Windows.Forms.ToolStripStatusLabel lbl_contador_registros;
        private System.Windows.Forms.ToolStripStatusLabel lbl_U_CL_CODSOL;
        private System.Windows.Forms.ToolStripStatusLabel lbl_U_CL_SOLICI;
        private System.Windows.Forms.ToolStripStatusLabel lbl_msg;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_dni;
        private System.Windows.Forms.Timer t_msg;
        private System.Windows.Forms.Label l_usuario;
        private System.Windows.Forms.Label l_dni;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSubirArch_imp;
        private System.Windows.Forms.ComboBox cboTareador_imp;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txt16;
        private System.Windows.Forms.TextBox txt17;
        private System.Windows.Forms.TextBox txt15;
        private System.Windows.Forms.TextBox txt13;
        private System.Windows.Forms.TextBox txt14;
        private System.Windows.Forms.TextBox txt12;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.TextBox txt11;
        private System.Windows.Forms.TextBox txt9;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.ComboBox cboSemana_imp;
        private System.Windows.Forms.ComboBox cboAnio_imp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStrip titulo;
        private System.Windows.Forms.ToolStripLabel tsl_titulo;
        private System.Windows.Forms.ToolStripButton salir;
        private System.Windows.Forms.ToolStripButton maximizar;
        private System.Windows.Forms.ToolStripButton ninimizar;
        private System.Windows.Forms.ToolStrip ts_acciones;
        private System.Windows.Forms.ToolStripButton btn_nuevo_b;
        private System.Windows.Forms.ToolStripButton btn_editar_b;
        private System.Windows.Forms.ToolStripButton btn_consultar_b;
        private System.Windows.Forms.ToolStripButton btn_eliminar_b;
        private System.Windows.Forms.ToolStripButton btn_imprimir;
        private System.Windows.Forms.ToolStripButton btn_previsualizar;
        private System.Windows.Forms.ToolStripButton btn_exportar_xls;
        private System.Windows.Forms.ToolStripButton btn_aprobar;
        private System.Windows.Forms.ToolStripButton btn_desaprobar;
        private System.Windows.Forms.ToolStripButton btn_actualizar;
        private System.Windows.Forms.ToolStripButton btn_ayuda;
        private System.Windows.Forms.Label label2;
    }
}