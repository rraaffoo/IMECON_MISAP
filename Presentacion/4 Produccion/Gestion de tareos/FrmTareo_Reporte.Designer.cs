﻿namespace MISAP
{
    partial class FrmTareo_Reporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTareo_Reporte));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.titulo = new System.Windows.Forms.ToolStrip();
            this.tsl_titulo = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.maximizar = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            this.ts_acciones = new System.Windows.Forms.ToolStrip();
            this.btn_exportar_xls = new System.Windows.Forms.ToolStripButton();
            this.btn_actualizar = new System.Windows.Forms.ToolStripButton();
            this.btn_filtro = new System.Windows.Forms.ToolStripButton();
            this.btn_parametrizacion = new System.Windows.Forms.ToolStripButton();
            this.btn_ayuda = new System.Windows.Forms.ToolStripButton();
            this.tc_pedido = new System.Windows.Forms.TabControl();
            this.tp_listado = new System.Windows.Forms.TabPage();
            this.dgv_parametrizacion = new System.Windows.Forms.DataGridView();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.dgvTareo_reporte = new System.Windows.Forms.DataGridView();
            this.tp_auditoria = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tipodoc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_formulario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_fec_modi = new System.Windows.Forms.TextBox();
            this.txt_terminal_modi = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txt_usr_modi = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txt_estado_registro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_operacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_fec_crea = new System.Windows.Forms.TextBox();
            this.txt_terminal_crea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_usr_crea = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cm_grilla.SuspendLayout();
            this.ss_load.SuspendLayout();
            this.titulo.SuspendLayout();
            this.ts_acciones.SuspendLayout();
            this.tc_pedido.SuspendLayout();
            this.tp_listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parametrizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareo_reporte)).BeginInit();
            this.tp_auditoria.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.ss_load.Location = new System.Drawing.Point(0, 783);
            this.ss_load.Name = "ss_load";
            this.ss_load.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ss_load.Size = new System.Drawing.Size(1341, 18);
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
            // titulo
            // 
            this.titulo.AutoSize = false;
            this.titulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titulo.BackgroundImage")));
            this.titulo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.titulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_titulo,
            this.salir,
            this.maximizar,
            this.ninimizar});
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.titulo.Size = new System.Drawing.Size(1341, 27);
            this.titulo.TabIndex = 286;
            this.titulo.Text = "toolStrip1";
            this.titulo.DoubleClick += new System.EventHandler(this.titulo_DoubleClick);
            this.titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            // 
            // tsl_titulo
            // 
            this.tsl_titulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsl_titulo.Name = "tsl_titulo";
            this.tsl_titulo.Size = new System.Drawing.Size(99, 24);
            this.tsl_titulo.Text = "Reporte de tareos";
            this.tsl_titulo.DoubleClick += new System.EventHandler(this.titulo_DoubleClick);
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
            // maximizar
            // 
            this.maximizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.maximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maximizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
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
            // ts_acciones
            // 
            this.ts_acciones.BackColor = System.Drawing.Color.White;
            this.ts_acciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ts_acciones.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_acciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_acciones.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.ts_acciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_exportar_xls,
            this.btn_actualizar,
            this.btn_filtro,
            this.btn_parametrizacion,
            this.btn_ayuda});
            this.ts_acciones.Location = new System.Drawing.Point(0, 27);
            this.ts_acciones.Name = "ts_acciones";
            this.ts_acciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ts_acciones.Size = new System.Drawing.Size(1341, 47);
            this.ts_acciones.TabIndex = 287;
            this.ts_acciones.Text = "acciones";
            // 
            // btn_exportar_xls
            // 
            this.btn_exportar_xls.AutoSize = false;
            this.btn_exportar_xls.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_exportar_xls.Image = global::MISAP.Properties.Resources.FILEexcel;
            this.btn_exportar_xls.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_exportar_xls.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_exportar_xls.Name = "btn_exportar_xls";
            this.btn_exportar_xls.Size = new System.Drawing.Size(29, 44);
            this.btn_exportar_xls.Text = "MS EXCEL";
            this.btn_exportar_xls.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_exportar_xls.ToolTipText = "MS EXCEL";
            this.btn_exportar_xls.Click += new System.EventHandler(this.btn_exportar_xls_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.AutoSize = false;
            this.btn_actualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_actualizar.Image = global::MISAP.Properties.Resources.DATAthis;
            this.btn_actualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_actualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(29, 44);
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_actualizar.ToolTipText = "Actualizar";
            // 
            // btn_filtro
            // 
            this.btn_filtro.AutoSize = false;
            this.btn_filtro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_filtro.Enabled = false;
            this.btn_filtro.Image = global::MISAP.Properties.Resources.DATAfilter;
            this.btn_filtro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_filtro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_filtro.Name = "btn_filtro";
            this.btn_filtro.Size = new System.Drawing.Size(29, 44);
            this.btn_filtro.Text = "Filtro";
            this.btn_filtro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_filtro.ToolTipText = "Filtro";
            // 
            // btn_parametrizacion
            // 
            this.btn_parametrizacion.AutoSize = false;
            this.btn_parametrizacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_parametrizacion.Enabled = false;
            this.btn_parametrizacion.Image = global::MISAP.Properties.Resources.TOOLSforms;
            this.btn_parametrizacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_parametrizacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_parametrizacion.Name = "btn_parametrizacion";
            this.btn_parametrizacion.Size = new System.Drawing.Size(29, 44);
            this.btn_parametrizacion.Text = "Filtro";
            this.btn_parametrizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_parametrizacion.ToolTipText = "Filtro";
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.AutoSize = false;
            this.btn_ayuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ayuda.Image = global::MISAP.Properties.Resources.help;
            this.btn_ayuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_ayuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(29, 44);
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ayuda.ToolTipText = "Ayuda";
            // 
            // tc_pedido
            // 
            this.tc_pedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_pedido.Controls.Add(this.tp_listado);
            this.tc_pedido.Controls.Add(this.tp_auditoria);
            this.tc_pedido.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_pedido.Location = new System.Drawing.Point(12, 77);
            this.tc_pedido.Name = "tc_pedido";
            this.tc_pedido.SelectedIndex = 0;
            this.tc_pedido.Size = new System.Drawing.Size(1317, 691);
            this.tc_pedido.TabIndex = 288;
            // 
            // tp_listado
            // 
            this.tp_listado.Controls.Add(this.dgv_parametrizacion);
            this.tp_listado.Controls.Add(this.lbl_buscar);
            this.tp_listado.Controls.Add(this.txt_buscar);
            this.tp_listado.Controls.Add(this.dgvTareo_reporte);
            this.tp_listado.Location = new System.Drawing.Point(4, 23);
            this.tp_listado.Name = "tp_listado";
            this.tp_listado.Size = new System.Drawing.Size(1309, 664);
            this.tp_listado.TabIndex = 2;
            this.tp_listado.Text = "Listado";
            // 
            // dgv_parametrizacion
            // 
            this.dgv_parametrizacion.AllowUserToAddRows = false;
            this.dgv_parametrizacion.AllowUserToDeleteRows = false;
            this.dgv_parametrizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_parametrizacion.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_parametrizacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_parametrizacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_parametrizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_parametrizacion.ContextMenuStrip = this.cm_grilla;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_parametrizacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_parametrizacion.EnableHeadersVisualStyles = false;
            this.dgv_parametrizacion.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_parametrizacion.Location = new System.Drawing.Point(530, 3);
            this.dgv_parametrizacion.Name = "dgv_parametrizacion";
            this.dgv_parametrizacion.ReadOnly = true;
            this.dgv_parametrizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_parametrizacion.Size = new System.Drawing.Size(353, 39);
            this.dgv_parametrizacion.TabIndex = 266;
            this.dgv_parametrizacion.Visible = false;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Location = new System.Drawing.Point(3, 5);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(42, 14);
            this.lbl_buscar.TabIndex = 263;
            this.lbl_buscar.Text = "Buscar";
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscar.Enabled = false;
            this.txt_buscar.Font = new System.Drawing.Font("Arial", 8.25F);
            this.txt_buscar.ForeColor = System.Drawing.Color.Black;
            this.txt_buscar.Location = new System.Drawing.Point(3, 22);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(175, 20);
            this.txt_buscar.TabIndex = 262;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // dgvTareo_reporte
            // 
            this.dgvTareo_reporte.AllowUserToAddRows = false;
            this.dgvTareo_reporte.AllowUserToDeleteRows = false;
            this.dgvTareo_reporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTareo_reporte.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTareo_reporte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTareo_reporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTareo_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareo_reporte.ContextMenuStrip = this.cm_grilla;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTareo_reporte.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTareo_reporte.EnableHeadersVisualStyles = false;
            this.dgvTareo_reporte.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvTareo_reporte.Location = new System.Drawing.Point(8, 52);
            this.dgvTareo_reporte.Name = "dgvTareo_reporte";
            this.dgvTareo_reporte.ReadOnly = true;
            this.dgvTareo_reporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTareo_reporte.Size = new System.Drawing.Size(1293, 601);
            this.dgvTareo_reporte.TabIndex = 224;
            this.dgvTareo_reporte.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTareo_reporte_ColumnHeaderMouseClick);
            // 
            // tp_auditoria
            // 
            this.tp_auditoria.Controls.Add(this.groupBox1);
            this.tp_auditoria.Location = new System.Drawing.Point(4, 23);
            this.tp_auditoria.Name = "tp_auditoria";
            this.tp_auditoria.Padding = new System.Windows.Forms.Padding(3);
            this.tp_auditoria.Size = new System.Drawing.Size(1309, 664);
            this.tp_auditoria.TabIndex = 1;
            this.tp_auditoria.Text = "Auditoria";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tipodoc);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_formulario);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_fec_modi);
            this.groupBox1.Controls.Add(this.txt_terminal_modi);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.txt_usr_modi);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.txt_estado_registro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_operacion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_fec_crea);
            this.groupBox1.Controls.Add(this.txt_terminal_crea);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_usr_crea);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 310);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // txt_tipodoc
            // 
            this.txt_tipodoc.Location = new System.Drawing.Point(133, 271);
            this.txt_tipodoc.Name = "txt_tipodoc";
            this.txt_tipodoc.ReadOnly = true;
            this.txt_tipodoc.Size = new System.Drawing.Size(148, 20);
            this.txt_tipodoc.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(22, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 14);
            this.label12.TabIndex = 20;
            this.label12.Text = "Tipo de Documento :";
            // 
            // txt_formulario
            // 
            this.txt_formulario.Location = new System.Drawing.Point(132, 243);
            this.txt_formulario.Name = "txt_formulario";
            this.txt_formulario.ReadOnly = true;
            this.txt_formulario.Size = new System.Drawing.Size(149, 20);
            this.txt_formulario.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(23, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 14);
            this.label13.TabIndex = 18;
            this.label13.Text = "Formulario :";
            // 
            // txt_fec_modi
            // 
            this.txt_fec_modi.Location = new System.Drawing.Point(132, 132);
            this.txt_fec_modi.Name = "txt_fec_modi";
            this.txt_fec_modi.ReadOnly = true;
            this.txt_fec_modi.Size = new System.Drawing.Size(149, 20);
            this.txt_fec_modi.TabIndex = 15;
            // 
            // txt_terminal_modi
            // 
            this.txt_terminal_modi.Location = new System.Drawing.Point(132, 160);
            this.txt_terminal_modi.Name = "txt_terminal_modi";
            this.txt_terminal_modi.ReadOnly = true;
            this.txt_terminal_modi.Size = new System.Drawing.Size(149, 20);
            this.txt_terminal_modi.TabIndex = 17;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(23, 136);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(106, 14);
            this.label33.TabIndex = 12;
            this.label33.Text = "Fecha Modificacion :";
            // 
            // txt_usr_modi
            // 
            this.txt_usr_modi.Location = new System.Drawing.Point(132, 104);
            this.txt_usr_modi.Name = "txt_usr_modi";
            this.txt_usr_modi.ReadOnly = true;
            this.txt_usr_modi.Size = new System.Drawing.Size(149, 20);
            this.txt_usr_modi.TabIndex = 16;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(22, 108);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(113, 14);
            this.label34.TabIndex = 13;
            this.label34.Text = "Usuario Modificacion :";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(22, 164);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(115, 14);
            this.label35.TabIndex = 14;
            this.label35.Text = "Terminal Modificacion :";
            // 
            // txt_estado_registro
            // 
            this.txt_estado_registro.Location = new System.Drawing.Point(132, 216);
            this.txt_estado_registro.Name = "txt_estado_registro";
            this.txt_estado_registro.ReadOnly = true;
            this.txt_estado_registro.Size = new System.Drawing.Size(149, 20);
            this.txt_estado_registro.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "Estado :";
            // 
            // txt_operacion
            // 
            this.txt_operacion.Location = new System.Drawing.Point(132, 188);
            this.txt_operacion.Name = "txt_operacion";
            this.txt_operacion.ReadOnly = true;
            this.txt_operacion.Size = new System.Drawing.Size(149, 20);
            this.txt_operacion.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Operacion :";
            // 
            // txt_fec_crea
            // 
            this.txt_fec_crea.Location = new System.Drawing.Point(132, 48);
            this.txt_fec_crea.Name = "txt_fec_crea";
            this.txt_fec_crea.ReadOnly = true;
            this.txt_fec_crea.Size = new System.Drawing.Size(149, 20);
            this.txt_fec_crea.TabIndex = 3;
            // 
            // txt_terminal_crea
            // 
            this.txt_terminal_crea.Location = new System.Drawing.Point(132, 76);
            this.txt_terminal_crea.Name = "txt_terminal_crea";
            this.txt_terminal_crea.ReadOnly = true;
            this.txt_terminal_crea.Size = new System.Drawing.Size(149, 20);
            this.txt_terminal_crea.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha de Creacion :";
            // 
            // txt_usr_crea
            // 
            this.txt_usr_crea.Location = new System.Drawing.Point(132, 22);
            this.txt_usr_crea.Name = "txt_usr_crea";
            this.txt_usr_crea.ReadOnly = true;
            this.txt_usr_crea.Size = new System.Drawing.Size(149, 20);
            this.txt_usr_crea.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 14);
            this.label8.TabIndex = 1;
            this.label8.Text = "Usuario Creacion :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 14);
            this.label10.TabIndex = 2;
            this.label10.Text = "Terminal Creacion :";
            // 
            // FrmTareo_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 801);
            this.ControlBox = false;
            this.Controls.Add(this.tc_pedido);
            this.Controls.Add(this.ts_acciones);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.l_dni);
            this.Controls.Add(this.l_usuario);
            this.Controls.Add(this.ss_load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmTareo_Reporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmTareo_Load);
            this.cm_grilla.ResumeLayout(false);
            this.ss_load.ResumeLayout(false);
            this.ss_load.PerformLayout();
            this.titulo.ResumeLayout(false);
            this.titulo.PerformLayout();
            this.ts_acciones.ResumeLayout(false);
            this.ts_acciones.PerformLayout();
            this.tc_pedido.ResumeLayout(false);
            this.tp_listado.ResumeLayout(false);
            this.tp_listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parametrizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareo_reporte)).EndInit();
            this.tp_auditoria.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ToolStrip titulo;
        private System.Windows.Forms.ToolStripLabel tsl_titulo;
        private System.Windows.Forms.ToolStripButton salir;
        private System.Windows.Forms.ToolStripButton maximizar;
        private System.Windows.Forms.ToolStripButton ninimizar;
        private System.Windows.Forms.ToolStrip ts_acciones;
        private System.Windows.Forms.ToolStripButton btn_exportar_xls;
        private System.Windows.Forms.ToolStripButton btn_actualizar;
        private System.Windows.Forms.ToolStripButton btn_filtro;
        private System.Windows.Forms.ToolStripButton btn_parametrizacion;
        private System.Windows.Forms.ToolStripButton btn_ayuda;
        private System.Windows.Forms.TabControl tc_pedido;
        private System.Windows.Forms.TabPage tp_listado;
        private System.Windows.Forms.DataGridView dgv_parametrizacion;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridView dgvTareo_reporte;
        private System.Windows.Forms.TabPage tp_auditoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tipodoc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_formulario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_fec_modi;
        private System.Windows.Forms.TextBox txt_terminal_modi;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txt_usr_modi;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txt_estado_registro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_operacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_fec_crea;
        private System.Windows.Forms.TextBox txt_terminal_crea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_usr_crea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}