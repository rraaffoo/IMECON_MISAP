﻿namespace MISAP
{
    partial class FrmInformeSegAcerosDet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformeSegAcerosDet));
            this.ts_acciones = new System.Windows.Forms.ToolStrip();
            this.btn_exportar_xls = new System.Windows.Forms.ToolStripButton();
            this.btn_actualizar = new System.Windows.Forms.ToolStripButton();
            this.btn_filtro = new System.Windows.Forms.ToolStripButton();
            this.btn_parametrizacion = new System.Windows.Forms.ToolStripButton();
            this.btn_ayuda = new System.Windows.Forms.ToolStripButton();
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
            this.tp_nuevo = new System.Windows.Forms.TabPage();
            this.tp_listado = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rb_transferido = new System.Windows.Forms.RadioButton();
            this.rb_Consumido = new System.Windows.Forms.RadioButton();
            this.rb_Ingresado = new System.Windows.Forms.RadioButton();
            this.rb_PorIngresar = new System.Windows.Forms.RadioButton();
            this.rb_solicitado = new System.Windows.Forms.RadioButton();
            this.dgv_parametrizacion = new System.Windows.Forms.DataGridView();
            this.cm_grilla = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cm_grilla_copia = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_grilla_copia_tabla = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_detalle = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.dgv_lista = new System.Windows.Forms.DataGridView();
            this.tc_pedido = new System.Windows.Forms.TabControl();
            this.ss_load = new System.Windows.Forms.StatusStrip();
            this.lbl_maximi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_contador_registros = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_CODSOL = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_SOLICI = new System.Windows.Forms.ToolStripStatusLabel();
            this.titulo = new System.Windows.Forms.ToolStrip();
            this.tsl_titulo = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.maximizar = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            this.rb_devuelto = new System.Windows.Forms.RadioButton();
            this.ts_acciones.SuspendLayout();
            this.tp_auditoria.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tp_listado.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parametrizacion)).BeginInit();
            this.cm_grilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).BeginInit();
            this.tc_pedido.SuspendLayout();
            this.ss_load.SuspendLayout();
            this.titulo.SuspendLayout();
            this.SuspendLayout();
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
            this.ts_acciones.Size = new System.Drawing.Size(852, 47);
            this.ts_acciones.TabIndex = 258;
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
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
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
            this.btn_filtro.Click += new System.EventHandler(this.btn_filtro_Click);
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
            this.btn_parametrizacion.Click += new System.EventHandler(this.btn_parametrizacion_Click);
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
            // tp_auditoria
            // 
            this.tp_auditoria.Controls.Add(this.groupBox1);
            this.tp_auditoria.Location = new System.Drawing.Point(4, 23);
            this.tp_auditoria.Name = "tp_auditoria";
            this.tp_auditoria.Padding = new System.Windows.Forms.Padding(3);
            this.tp_auditoria.Size = new System.Drawing.Size(844, 445);
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
            // tp_nuevo
            // 
            this.tp_nuevo.Location = new System.Drawing.Point(4, 23);
            this.tp_nuevo.Name = "tp_nuevo";
            this.tp_nuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tp_nuevo.Size = new System.Drawing.Size(844, 445);
            this.tp_nuevo.TabIndex = 0;
            this.tp_nuevo.Text = "Nuevo";
            // 
            // tp_listado
            // 
            this.tp_listado.Controls.Add(this.groupBox4);
            this.tp_listado.Controls.Add(this.lbl_buscar);
            this.tp_listado.Controls.Add(this.txt_buscar);
            this.tp_listado.Controls.Add(this.dgv_lista);
            this.tp_listado.Location = new System.Drawing.Point(4, 23);
            this.tp_listado.Name = "tp_listado";
            this.tp_listado.Size = new System.Drawing.Size(844, 445);
            this.tp_listado.TabIndex = 2;
            this.tp_listado.Text = "Listado";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.rb_devuelto);
            this.groupBox4.Controls.Add(this.rb_transferido);
            this.groupBox4.Controls.Add(this.rb_Consumido);
            this.groupBox4.Controls.Add(this.rb_Ingresado);
            this.groupBox4.Controls.Add(this.rb_PorIngresar);
            this.groupBox4.Controls.Add(this.rb_solicitado);
            this.groupBox4.Controls.Add(this.dgv_parametrizacion);
            this.groupBox4.Location = new System.Drawing.Point(213, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(623, 60);
            this.groupBox4.TabIndex = 265;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mostrar";
            // 
            // rb_transferido
            // 
            this.rb_transferido.AutoSize = true;
            this.rb_transferido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_transferido.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_transferido.Location = new System.Drawing.Point(88, 27);
            this.rb_transferido.Name = "rb_transferido";
            this.rb_transferido.Size = new System.Drawing.Size(80, 18);
            this.rb_transferido.TabIndex = 285;
            this.rb_transferido.Text = "Transferido";
            this.rb_transferido.UseVisualStyleBackColor = true;
            this.rb_transferido.CheckedChanged += new System.EventHandler(this.rb_transferido_CheckedChanged);
            // 
            // rb_Consumido
            // 
            this.rb_Consumido.AutoSize = true;
            this.rb_Consumido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_Consumido.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Consumido.Location = new System.Drawing.Point(421, 27);
            this.rb_Consumido.Name = "rb_Consumido";
            this.rb_Consumido.Size = new System.Drawing.Size(77, 18);
            this.rb_Consumido.TabIndex = 284;
            this.rb_Consumido.Text = "Consumido";
            this.rb_Consumido.UseVisualStyleBackColor = true;
            this.rb_Consumido.CheckedChanged += new System.EventHandler(this.rb_Consumido_CheckedChanged);
            // 
            // rb_Ingresado
            // 
            this.rb_Ingresado.AutoSize = true;
            this.rb_Ingresado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_Ingresado.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Ingresado.Location = new System.Drawing.Point(265, 27);
            this.rb_Ingresado.Name = "rb_Ingresado";
            this.rb_Ingresado.Size = new System.Drawing.Size(72, 18);
            this.rb_Ingresado.TabIndex = 283;
            this.rb_Ingresado.Text = "Ingresado";
            this.rb_Ingresado.UseVisualStyleBackColor = true;
            this.rb_Ingresado.CheckedChanged += new System.EventHandler(this.rb_Ingresado_CheckedChanged);
            // 
            // rb_PorIngresar
            // 
            this.rb_PorIngresar.AutoSize = true;
            this.rb_PorIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_PorIngresar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_PorIngresar.Location = new System.Drawing.Point(178, 27);
            this.rb_PorIngresar.Name = "rb_PorIngresar";
            this.rb_PorIngresar.Size = new System.Drawing.Size(83, 18);
            this.rb_PorIngresar.TabIndex = 282;
            this.rb_PorIngresar.Text = "Por ingresar";
            this.rb_PorIngresar.UseVisualStyleBackColor = true;
            this.rb_PorIngresar.CheckedChanged += new System.EventHandler(this.rb_PorIngresar_CheckedChanged);
            // 
            // rb_solicitado
            // 
            this.rb_solicitado.AutoSize = true;
            this.rb_solicitado.Checked = true;
            this.rb_solicitado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_solicitado.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_solicitado.Location = new System.Drawing.Point(12, 27);
            this.rb_solicitado.Name = "rb_solicitado";
            this.rb_solicitado.Size = new System.Drawing.Size(70, 18);
            this.rb_solicitado.TabIndex = 281;
            this.rb_solicitado.TabStop = true;
            this.rb_solicitado.Text = "Solicitado";
            this.rb_solicitado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_solicitado.UseVisualStyleBackColor = true;
            this.rb_solicitado.CheckedChanged += new System.EventHandler(this.rb_solicitado_CheckedChanged);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_parametrizacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_parametrizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_parametrizacion.ContextMenuStrip = this.cm_grilla;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_parametrizacion.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_parametrizacion.EnableHeadersVisualStyles = false;
            this.dgv_parametrizacion.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_parametrizacion.Location = new System.Drawing.Point(538, 11);
            this.dgv_parametrizacion.Name = "dgv_parametrizacion";
            this.dgv_parametrizacion.ReadOnly = true;
            this.dgv_parametrizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_parametrizacion.Size = new System.Drawing.Size(66, 43);
            this.dgv_parametrizacion.TabIndex = 266;
            this.dgv_parametrizacion.Visible = false;
            // 
            // cm_grilla
            // 
            this.cm_grilla.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cm_grilla_copia,
            this.cm_grilla_copia_tabla,
            this.toolStripSeparator1,
            this.tsm_detalle});
            this.cm_grilla.Name = "cm_grilla";
            this.cm_grilla.Size = new System.Drawing.Size(135, 76);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // tsm_detalle
            // 
            this.tsm_detalle.Name = "tsm_detalle";
            this.tsm_detalle.Size = new System.Drawing.Size(134, 22);
            this.tsm_detalle.Text = "Ver Detalle";
            this.tsm_detalle.Click += new System.EventHandler(this.tsm_detalle_Click);
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
            // dgv_lista
            // 
            this.dgv_lista.AllowUserToAddRows = false;
            this.dgv_lista.AllowUserToDeleteRows = false;
            this.dgv_lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_lista.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_lista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lista.ContextMenuStrip = this.cm_grilla;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_lista.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_lista.EnableHeadersVisualStyles = false;
            this.dgv_lista.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_lista.Location = new System.Drawing.Point(8, 71);
            this.dgv_lista.Name = "dgv_lista";
            this.dgv_lista.ReadOnly = true;
            this.dgv_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_lista.Size = new System.Drawing.Size(828, 363);
            this.dgv_lista.TabIndex = 224;
            this.dgv_lista.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_pedidos_ColumnHeaderMouseClick);
            // 
            // tc_pedido
            // 
            this.tc_pedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_pedido.Controls.Add(this.tp_listado);
            this.tc_pedido.Controls.Add(this.tp_nuevo);
            this.tc_pedido.Controls.Add(this.tp_auditoria);
            this.tc_pedido.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_pedido.Location = new System.Drawing.Point(0, 78);
            this.tc_pedido.Name = "tc_pedido";
            this.tc_pedido.SelectedIndex = 0;
            this.tc_pedido.Size = new System.Drawing.Size(852, 472);
            this.tc_pedido.TabIndex = 274;
            this.tc_pedido.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tc_pedido_Selecting);
            // 
            // ss_load
            // 
            this.ss_load.AutoSize = false;
            this.ss_load.BackColor = System.Drawing.Color.Transparent;
            this.ss_load.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ss_load.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ss_load.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_maximi,
            this.lbl_contador_registros,
            this.lbl_U_CL_CODSOL,
            this.lbl_U_CL_SOLICI});
            this.ss_load.Location = new System.Drawing.Point(0, 565);
            this.ss_load.Name = "ss_load";
            this.ss_load.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ss_load.Size = new System.Drawing.Size(852, 24);
            this.ss_load.SizingGrip = false;
            this.ss_load.TabIndex = 275;
            this.ss_load.Text = "statusStrip1";
            // 
            // lbl_maximi
            // 
            this.lbl_maximi.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbl_maximi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lbl_maximi.Name = "lbl_maximi";
            this.lbl_maximi.Size = new System.Drawing.Size(17, 19);
            this.lbl_maximi.Text = "1";
            this.lbl_maximi.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.lbl_maximi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.lbl_maximi.Visible = false;
            // 
            // lbl_contador_registros
            // 
            this.lbl_contador_registros.BackColor = System.Drawing.Color.Transparent;
            this.lbl_contador_registros.Name = "lbl_contador_registros";
            this.lbl_contador_registros.Size = new System.Drawing.Size(75, 19);
            this.lbl_contador_registros.Text = "Total registros";
            // 
            // lbl_U_CL_CODSOL
            // 
            this.lbl_U_CL_CODSOL.Name = "lbl_U_CL_CODSOL";
            this.lbl_U_CL_CODSOL.Size = new System.Drawing.Size(0, 19);
            // 
            // lbl_U_CL_SOLICI
            // 
            this.lbl_U_CL_SOLICI.Name = "lbl_U_CL_SOLICI";
            this.lbl_U_CL_SOLICI.Size = new System.Drawing.Size(0, 19);
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
            this.titulo.Size = new System.Drawing.Size(852, 27);
            this.titulo.TabIndex = 257;
            this.titulo.Text = "toolStrip1";
            this.titulo.DoubleClick += new System.EventHandler(this.titulo_DoubleClick);
            this.titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            // 
            // tsl_titulo
            // 
            this.tsl_titulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsl_titulo.Name = "tsl_titulo";
            this.tsl_titulo.Size = new System.Drawing.Size(183, 24);
            this.tsl_titulo.Text = "Detalle de seguminetos de aceros";
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
            // rb_devuelto
            // 
            this.rb_devuelto.AutoSize = true;
            this.rb_devuelto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_devuelto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_devuelto.Location = new System.Drawing.Point(343, 27);
            this.rb_devuelto.Name = "rb_devuelto";
            this.rb_devuelto.Size = new System.Drawing.Size(66, 18);
            this.rb_devuelto.TabIndex = 286;
            this.rb_devuelto.Text = "Devuelto";
            this.rb_devuelto.UseVisualStyleBackColor = true;
            this.rb_devuelto.CheckedChanged += new System.EventHandler(this.rb_devuelto_CheckedChanged);
            // 
            // FrmInformeSegAcerosDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 589);
            this.ControlBox = false;
            this.Controls.Add(this.ss_load);
            this.Controls.Add(this.tc_pedido);
            this.Controls.Add(this.ts_acciones);
            this.Controls.Add(this.titulo);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmInformeSegAcerosDet";
            this.Load += new System.EventHandler(this.FrmInformeSegReq_Load);
            this.ts_acciones.ResumeLayout(false);
            this.ts_acciones.PerformLayout();
            this.tp_auditoria.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tp_listado.ResumeLayout(false);
            this.tp_listado.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parametrizacion)).EndInit();
            this.cm_grilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).EndInit();
            this.tc_pedido.ResumeLayout(false);
            this.ss_load.ResumeLayout(false);
            this.ss_load.PerformLayout();
            this.titulo.ResumeLayout(false);
            this.titulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip titulo;
        private System.Windows.Forms.ToolStripLabel tsl_titulo;
        private System.Windows.Forms.ToolStripButton salir;
        private System.Windows.Forms.ToolStripButton maximizar;
        private System.Windows.Forms.ToolStripButton ninimizar;
        private System.Windows.Forms.ToolStrip ts_acciones;
        private System.Windows.Forms.ToolStripButton btn_exportar_xls;
        private System.Windows.Forms.ToolStripButton btn_actualizar;
        private System.Windows.Forms.ToolStripButton btn_filtro;
        private System.Windows.Forms.ToolStripButton btn_ayuda;
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
        private System.Windows.Forms.TabPage tp_nuevo;
        private System.Windows.Forms.TabPage tp_listado;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridView dgv_lista;
        private System.Windows.Forms.TabControl tc_pedido;
        private System.Windows.Forms.StatusStrip ss_load;
        private System.Windows.Forms.ToolStripStatusLabel lbl_maximi;
        private System.Windows.Forms.ToolStripStatusLabel lbl_contador_registros;
        private System.Windows.Forms.ToolStripStatusLabel lbl_U_CL_CODSOL;
        private System.Windows.Forms.ToolStripStatusLabel lbl_U_CL_SOLICI;
        private System.Windows.Forms.ContextMenuStrip cm_grilla;
        private System.Windows.Forms.ToolStripMenuItem cm_grilla_copia;
        private System.Windows.Forms.ToolStripMenuItem cm_grilla_copia_tabla;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_parametrizacion;
        private System.Windows.Forms.ToolStripMenuItem tsm_detalle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_parametrizacion;
        private System.Windows.Forms.RadioButton rb_Consumido;
        private System.Windows.Forms.RadioButton rb_Ingresado;
        private System.Windows.Forms.RadioButton rb_PorIngresar;
        private System.Windows.Forms.RadioButton rb_solicitado;
        private System.Windows.Forms.RadioButton rb_transferido;
        private System.Windows.Forms.RadioButton rb_devuelto;
    }
}