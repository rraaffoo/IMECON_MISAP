﻿namespace MISAP
{
    partial class FrmInformeSegReq
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformeSegReq));
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
            this.dgv_parametrizacion = new System.Windows.Forms.DataGridView();
            this.cm_grilla = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cm_grilla_copia = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_grilla_copia_tabla = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cm_log_modificaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.verPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verNotaDeIngresovalorizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chk_aceros = new System.Windows.Forms.CheckBox();
            this.txt_tipo_l = new System.Windows.Forms.TextBox();
            this.rb_servicios_l = new System.Windows.Forms.RadioButton();
            this.rb_materiales_l = new System.Windows.Forms.RadioButton();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.dgv_pedidos = new System.Windows.Forms.DataGridView();
            this.tc_pedido = new System.Windows.Forms.TabControl();
            this.titulo = new System.Windows.Forms.ToolStrip();
            this.tsl_titulo = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.maximizar = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            this.BW = new System.ComponentModel.BackgroundWorker();
            this.ss_load = new System.Windows.Forms.StatusStrip();
            this.lbl_contador_registros = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_CODSOL = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_SOLICI = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_msg = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_maximi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_dni = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts_acciones.SuspendLayout();
            this.tp_auditoria.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tp_listado.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parametrizacion)).BeginInit();
            this.cm_grilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).BeginInit();
            this.tc_pedido.SuspendLayout();
            this.titulo.SuspendLayout();
            this.ss_load.SuspendLayout();
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
            this.btn_parametrizacion.Image = global::MISAP.Properties.Resources.TOOLSforms;
            this.btn_parametrizacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_parametrizacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_parametrizacion.Name = "btn_parametrizacion";
            this.btn_parametrizacion.Size = new System.Drawing.Size(29, 44);
            this.btn_parametrizacion.Text = "Parametrizaciones de formulario";
            this.btn_parametrizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_parametrizacion.ToolTipText = "Parametrizaciones de formulario";
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
            this.tp_listado.Controls.Add(this.dgv_parametrizacion);
            this.tp_listado.Controls.Add(this.groupBox4);
            this.tp_listado.Controls.Add(this.lbl_buscar);
            this.tp_listado.Controls.Add(this.txt_buscar);
            this.tp_listado.Controls.Add(this.dgv_pedidos);
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
            this.groupBox4.Controls.Add(this.chk_aceros);
            this.groupBox4.Controls.Add(this.txt_tipo_l);
            this.groupBox4.Controls.Add(this.rb_servicios_l);
            this.groupBox4.Controls.Add(this.rb_materiales_l);
            this.groupBox4.Location = new System.Drawing.Point(213, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(623, 60);
            this.groupBox4.TabIndex = 265;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtrar";
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
            this.dgv_parametrizacion.Location = new System.Drawing.Point(485, 16);
            this.dgv_parametrizacion.Name = "dgv_parametrizacion";
            this.dgv_parametrizacion.ReadOnly = true;
            this.dgv_parametrizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_parametrizacion.Size = new System.Drawing.Size(351, 49);
            this.dgv_parametrizacion.TabIndex = 266;
            this.dgv_parametrizacion.Visible = false;
            // 
            // cm_grilla
            // 
            this.cm_grilla.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cm_grilla_copia,
            this.cm_grilla_copia_tabla,
            this.toolStripSeparator1,
            this.cm_log_modificaciones,
            this.verPedidoToolStripMenuItem,
            this.verNotaDeIngresovalorizaciónToolStripMenuItem});
            this.cm_grilla.Name = "cm_grilla";
            this.cm_grilla.Size = new System.Drawing.Size(245, 120);
            // 
            // cm_grilla_copia
            // 
            this.cm_grilla_copia.Name = "cm_grilla_copia";
            this.cm_grilla_copia.Size = new System.Drawing.Size(244, 22);
            this.cm_grilla_copia.Text = "Copia";
            this.cm_grilla_copia.Click += new System.EventHandler(this.cm_grilla_copia_Click);
            // 
            // cm_grilla_copia_tabla
            // 
            this.cm_grilla_copia_tabla.Name = "cm_grilla_copia_tabla";
            this.cm_grilla_copia_tabla.Size = new System.Drawing.Size(244, 22);
            this.cm_grilla_copia_tabla.Text = "Copia tabla";
            this.cm_grilla_copia_tabla.Click += new System.EventHandler(this.cm_grilla_copia_tabla_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(241, 6);
            // 
            // cm_log_modificaciones
            // 
            this.cm_log_modificaciones.Name = "cm_log_modificaciones";
            this.cm_log_modificaciones.Size = new System.Drawing.Size(244, 22);
            this.cm_log_modificaciones.Text = "Log de modificaciones";
            this.cm_log_modificaciones.Click += new System.EventHandler(this.cm_log_modificaciones_Click);
            // 
            // verPedidoToolStripMenuItem
            // 
            this.verPedidoToolStripMenuItem.Name = "verPedidoToolStripMenuItem";
            this.verPedidoToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.verPedidoToolStripMenuItem.Text = "Ver Pedido";
            this.verPedidoToolStripMenuItem.Click += new System.EventHandler(this.verPedidoToolStripMenuItem_Click);
            // 
            // verNotaDeIngresovalorizaciónToolStripMenuItem
            // 
            this.verNotaDeIngresovalorizaciónToolStripMenuItem.Name = "verNotaDeIngresovalorizaciónToolStripMenuItem";
            this.verNotaDeIngresovalorizaciónToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.verNotaDeIngresovalorizaciónToolStripMenuItem.Text = "Ver nota de ingreso/valorización";
            this.verNotaDeIngresovalorizaciónToolStripMenuItem.Click += new System.EventHandler(this.verNotaDeIngresovalorizaciónToolStripMenuItem_Click);
            // 
            // chk_aceros
            // 
            this.chk_aceros.AutoSize = true;
            this.chk_aceros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_aceros.Location = new System.Drawing.Point(6, 36);
            this.chk_aceros.Name = "chk_aceros";
            this.chk_aceros.Size = new System.Drawing.Size(81, 18);
            this.chk_aceros.TabIndex = 280;
            this.chk_aceros.Text = "Sólo aceros";
            this.chk_aceros.UseVisualStyleBackColor = true;
            this.chk_aceros.CheckedChanged += new System.EventHandler(this.chk_aceros_CheckedChanged);
            // 
            // txt_tipo_l
            // 
            this.txt_tipo_l.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tipo_l.Location = new System.Drawing.Point(160, 11);
            this.txt_tipo_l.Name = "txt_tipo_l";
            this.txt_tipo_l.Size = new System.Drawing.Size(29, 20);
            this.txt_tipo_l.TabIndex = 279;
            this.txt_tipo_l.Visible = false;
            // 
            // rb_servicios_l
            // 
            this.rb_servicios_l.AutoSize = true;
            this.rb_servicios_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_servicios_l.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_servicios_l.Location = new System.Drawing.Point(85, 16);
            this.rb_servicios_l.Name = "rb_servicios_l";
            this.rb_servicios_l.Size = new System.Drawing.Size(69, 18);
            this.rb_servicios_l.TabIndex = 279;
            this.rb_servicios_l.Text = "Servicios";
            this.rb_servicios_l.UseVisualStyleBackColor = true;
            this.rb_servicios_l.CheckedChanged += new System.EventHandler(this.rb_servicios_l_CheckedChanged);
            // 
            // rb_materiales_l
            // 
            this.rb_materiales_l.AutoSize = true;
            this.rb_materiales_l.Checked = true;
            this.rb_materiales_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_materiales_l.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_materiales_l.Location = new System.Drawing.Point(6, 16);
            this.rb_materiales_l.Name = "rb_materiales_l";
            this.rb_materiales_l.Size = new System.Drawing.Size(73, 18);
            this.rb_materiales_l.TabIndex = 278;
            this.rb_materiales_l.TabStop = true;
            this.rb_materiales_l.Text = "Materiales";
            this.rb_materiales_l.UseVisualStyleBackColor = true;
            this.rb_materiales_l.CheckedChanged += new System.EventHandler(this.rb_materiales_l_CheckedChanged);
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
            // dgv_pedidos
            // 
            this.dgv_pedidos.AllowUserToAddRows = false;
            this.dgv_pedidos.AllowUserToDeleteRows = false;
            this.dgv_pedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_pedidos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_pedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedidos.ContextMenuStrip = this.cm_grilla;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_pedidos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_pedidos.EnableHeadersVisualStyles = false;
            this.dgv_pedidos.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_pedidos.Location = new System.Drawing.Point(8, 71);
            this.dgv_pedidos.Name = "dgv_pedidos";
            this.dgv_pedidos.ReadOnly = true;
            this.dgv_pedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_pedidos.Size = new System.Drawing.Size(828, 363);
            this.dgv_pedidos.TabIndex = 224;
            this.dgv_pedidos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_pedidos_ColumnHeaderMouseClick);
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
            this.tsl_titulo.Size = new System.Drawing.Size(173, 24);
            this.tsl_titulo.Text = "Seguimiento de requerimientos";
            this.tsl_titulo.Click += new System.EventHandler(this.toolStripLabel1_Click);
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
            // BW
            // 
            this.BW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_DoWork);
            this.BW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BW_RunWorkerCompleted);
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
            this.lbl_dni});
            this.ss_load.Location = new System.Drawing.Point(0, 571);
            this.ss_load.Name = "ss_load";
            this.ss_load.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ss_load.Size = new System.Drawing.Size(852, 18);
            this.ss_load.SizingGrip = false;
            this.ss_load.TabIndex = 280;
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
            // FrmInformeSegReq
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
            this.Name = "FrmInformeSegReq";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).EndInit();
            this.tc_pedido.ResumeLayout(false);
            this.titulo.ResumeLayout(false);
            this.titulo.PerformLayout();
            this.ss_load.ResumeLayout(false);
            this.ss_load.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgv_pedidos;
        private System.Windows.Forms.TabControl tc_pedido;
        private System.Windows.Forms.ContextMenuStrip cm_grilla;
        private System.Windows.Forms.ToolStripMenuItem cm_grilla_copia;
        private System.Windows.Forms.ToolStripMenuItem cm_grilla_copia_tabla;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cm_log_modificaciones;
        private System.Windows.Forms.ToolStripButton btn_parametrizacion;
        private System.Windows.Forms.ToolStripMenuItem verPedidoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_tipo_l;
        private System.Windows.Forms.RadioButton rb_servicios_l;
        private System.Windows.Forms.RadioButton rb_materiales_l;
        private System.Windows.Forms.DataGridView dgv_parametrizacion;
        private System.Windows.Forms.CheckBox chk_aceros;
        private System.Windows.Forms.ToolStripMenuItem verNotaDeIngresovalorizaciónToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker BW;
        private System.Windows.Forms.StatusStrip ss_load;
        private System.Windows.Forms.ToolStripStatusLabel lbl_contador_registros;
        private System.Windows.Forms.ToolStripStatusLabel lbl_U_CL_CODSOL;
        private System.Windows.Forms.ToolStripStatusLabel lbl_U_CL_SOLICI;
        private System.Windows.Forms.ToolStripStatusLabel lbl_msg;
        private System.Windows.Forms.ToolStripStatusLabel lbl_maximi;
        private System.Windows.Forms.ToolStripStatusLabel lbl_dni;
    }
}