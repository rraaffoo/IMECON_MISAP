namespace MISAP
{
    partial class FrmCargoDoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargoDoc));
            this.ss_load = new System.Windows.Forms.StatusStrip();
            this.lbl_contador_registros = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_CODSOL = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_SOLICI = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_msg = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_maximi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_origen = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts_acciones = new System.Windows.Forms.ToolStrip();
            this.tc_detalle = new System.Windows.Forms.TabControl();
            this.tp_contenido = new System.Windows.Forms.TabPage();
            this.dp_FechaReg = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_cargo = new System.Windows.Forms.DataGridView();
            this.nrog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_grilla = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cm_grilla_copia = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_grilla_copia_tabla = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_fechaReg = new System.Windows.Forms.TextBox();
            this.dgv_registro = new System.Windows.Forms.DataGridView();
            this.lbl_DocEntrega = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tp_anexo = new System.Windows.Forms.TabPage();
            this.dgv_anexo_consulta = new System.Windows.Forms.DataGridView();
            this.dgv_anexo = new System.Windows.Forms.DataGridView();
            this.ruta_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archivo_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extension_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbsEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.local_r = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_listado = new System.Windows.Forms.TabPage();
            this.dgv_lista = new System.Windows.Forms.DataGridView();
            this.tp_auditoria = new System.Windows.Forms.TabPage();
            this.txt_tipodoc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_operacion = new System.Windows.Forms.TextBox();
            this.txt_formulario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_estado_registro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_fec_modi = new System.Windows.Forms.TextBox();
            this.txt_usr_crea = new System.Windows.Forms.TextBox();
            this.txt_terminal_modi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txt_terminal_crea = new System.Windows.Forms.TextBox();
            this.txt_usr_modi = new System.Windows.Forms.TextBox();
            this.txt_fec_crea = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.t_msg = new System.Windows.Forms.Timer(this.components);
            this.lbl_hora = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_lote = new System.Windows.Forms.TextBox();
            this.dp_FechaDocumento = new System.Windows.Forms.DateTimePicker();
            this.cm_formulario = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmi_eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_FechaDocumento = new System.Windows.Forms.TextBox();
            this.btn_nuevo_b = new System.Windows.Forms.ToolStripButton();
            this.btn_editar_b = new System.Windows.Forms.ToolStripButton();
            this.btn_consultar_b = new System.Windows.Forms.ToolStripButton();
            this.btn_eliminar_b = new System.Windows.Forms.ToolStripButton();
            this.btn_imprimir = new System.Windows.Forms.ToolStripButton();
            this.btn_primero = new System.Windows.Forms.ToolStripButton();
            this.btn_anterior = new System.Windows.Forms.ToolStripButton();
            this.btn_siguiente = new System.Windows.Forms.ToolStripButton();
            this.btn_utlimo = new System.Windows.Forms.ToolStripButton();
            this.btn_previsualizar = new System.Windows.Forms.ToolStripButton();
            this.btn_exportar_xls = new System.Windows.Forms.ToolStripButton();
            this.btn_plantilla = new System.Windows.Forms.ToolStripButton();
            this.btn_aprobar = new System.Windows.Forms.ToolStripButton();
            this.btn_desaprobar = new System.Windows.Forms.ToolStripButton();
            this.btn_actualizar = new System.Windows.Forms.ToolStripButton();
            this.btn_filtro = new System.Windows.Forms.ToolStripButton();
            this.btn_ayuda = new System.Windows.Forms.ToolStripButton();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.ToolStrip();
            this.tsl_titulo = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.maximizar = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            this.btn_anular_all_seleccion = new System.Windows.Forms.Button();
            this.btn_anular_seleccion = new System.Windows.Forms.Button();
            this.btn_agregar_seleccion = new System.Windows.Forms.Button();
            this.btn_borrar_anexo = new System.Windows.Forms.Button();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.btn_explorar = new System.Windows.Forms.Button();
            this.btn_agregar_all_seleccion = new System.Windows.Forms.Button();
            this.ss_load.SuspendLayout();
            this.ts_acciones.SuspendLayout();
            this.tc_detalle.SuspendLayout();
            this.tp_contenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cargo)).BeginInit();
            this.cm_grilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registro)).BeginInit();
            this.tp_anexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_anexo_consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_anexo)).BeginInit();
            this.tp_listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).BeginInit();
            this.tp_auditoria.SuspendLayout();
            this.cm_formulario.SuspendLayout();
            this.titulo.SuspendLayout();
            this.SuspendLayout();
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
            this.ss_load.Location = new System.Drawing.Point(0, 586);
            this.ss_load.Name = "ss_load";
            this.ss_load.Size = new System.Drawing.Size(706, 18);
            this.ss_load.SizingGrip = false;
            this.ss_load.TabIndex = 310;
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
            // ts_acciones
            // 
            this.ts_acciones.BackColor = System.Drawing.Color.White;
            this.ts_acciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ts_acciones.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_acciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_acciones.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.ts_acciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nuevo_b,
            this.btn_editar_b,
            this.btn_consultar_b,
            this.btn_eliminar_b,
            this.btn_imprimir,
            this.btn_primero,
            this.btn_anterior,
            this.btn_siguiente,
            this.btn_utlimo,
            this.btn_previsualizar,
            this.btn_exportar_xls,
            this.btn_plantilla,
            this.btn_aprobar,
            this.btn_desaprobar,
            this.btn_actualizar,
            this.btn_filtro,
            this.btn_ayuda});
            this.ts_acciones.Location = new System.Drawing.Point(0, 27);
            this.ts_acciones.Name = "ts_acciones";
            this.ts_acciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ts_acciones.Size = new System.Drawing.Size(706, 47);
            this.ts_acciones.TabIndex = 313;
            this.ts_acciones.Text = "acciones";
            // 
            // tc_detalle
            // 
            this.tc_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_detalle.Controls.Add(this.tp_contenido);
            this.tc_detalle.Controls.Add(this.tp_anexo);
            this.tc_detalle.Controls.Add(this.tp_listado);
            this.tc_detalle.Controls.Add(this.tp_auditoria);
            this.tc_detalle.ItemSize = new System.Drawing.Size(80, 16);
            this.tc_detalle.Location = new System.Drawing.Point(12, 133);
            this.tc_detalle.Name = "tc_detalle";
            this.tc_detalle.SelectedIndex = 0;
            this.tc_detalle.Size = new System.Drawing.Size(682, 410);
            this.tc_detalle.TabIndex = 344;
            // 
            // tp_contenido
            // 
            this.tp_contenido.AutoScroll = true;
            this.tp_contenido.BackColor = System.Drawing.SystemColors.Control;
            this.tp_contenido.Controls.Add(this.btn_agregar_all_seleccion);
            this.tp_contenido.Controls.Add(this.btn_anular_all_seleccion);
            this.tp_contenido.Controls.Add(this.btn_anular_seleccion);
            this.tp_contenido.Controls.Add(this.dp_FechaReg);
            this.tp_contenido.Controls.Add(this.btn_agregar_seleccion);
            this.tp_contenido.Controls.Add(this.label1);
            this.tp_contenido.Controls.Add(this.dgv_cargo);
            this.tp_contenido.Controls.Add(this.txt_fechaReg);
            this.tp_contenido.Controls.Add(this.dgv_registro);
            this.tp_contenido.Controls.Add(this.lbl_DocEntrega);
            this.tp_contenido.Controls.Add(this.label18);
            this.tp_contenido.Location = new System.Drawing.Point(4, 20);
            this.tp_contenido.Name = "tp_contenido";
            this.tp_contenido.Padding = new System.Windows.Forms.Padding(3);
            this.tp_contenido.Size = new System.Drawing.Size(674, 386);
            this.tp_contenido.TabIndex = 0;
            this.tp_contenido.Text = "Contenido";
            // 
            // dp_FechaReg
            // 
            this.dp_FechaReg.AllowDrop = true;
            this.dp_FechaReg.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dp_FechaReg.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dp_FechaReg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_FechaReg.Location = new System.Drawing.Point(287, 12);
            this.dp_FechaReg.Name = "dp_FechaReg";
            this.dp_FechaReg.Size = new System.Drawing.Size(17, 21);
            this.dp_FechaReg.TabIndex = 409;
            this.dp_FechaReg.ValueChanged += new System.EventHandler(this.dp_FechaReg_ValueChanged);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 14);
            this.label1.TabIndex = 408;
            this.label1.Text = "Fecha de registro";
            // 
            // dgv_cargo
            // 
            this.dgv_cargo.AllowUserToAddRows = false;
            this.dgv_cargo.AllowUserToDeleteRows = false;
            this.dgv_cargo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_cargo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_cargo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cargo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgv_cargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrog,
            this.nombreg,
            this.serieg,
            this.documentog});
            this.dgv_cargo.ContextMenuStrip = this.cm_grilla;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_cargo.DefaultCellStyle = dataGridViewCellStyle28;
            this.dgv_cargo.EnableHeadersVisualStyles = false;
            this.dgv_cargo.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_cargo.Location = new System.Drawing.Point(353, 58);
            this.dgv_cargo.Name = "dgv_cargo";
            this.dgv_cargo.ReadOnly = true;
            this.dgv_cargo.Size = new System.Drawing.Size(309, 316);
            this.dgv_cargo.StandardTab = true;
            this.dgv_cargo.TabIndex = 403;
            this.dgv_cargo.Click += new System.EventHandler(this.dgv_cargo_Click);
            // 
            // nrog
            // 
            this.nrog.HeaderText = "Nro";
            this.nrog.Name = "nrog";
            this.nrog.ReadOnly = true;
            this.nrog.Visible = false;
            // 
            // nombreg
            // 
            this.nombreg.HeaderText = "Nombre";
            this.nombreg.Name = "nombreg";
            this.nombreg.ReadOnly = true;
            // 
            // serieg
            // 
            this.serieg.HeaderText = "Serie";
            this.serieg.Name = "serieg";
            this.serieg.ReadOnly = true;
            // 
            // documentog
            // 
            this.documentog.HeaderText = "Numero de documento";
            this.documentog.Name = "documentog";
            this.documentog.ReadOnly = true;
            // 
            // cm_grilla
            // 
            this.cm_grilla.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cm_grilla_copia,
            this.cm_grilla_copia_tabla,
            this.toolStripSeparator1});
            this.cm_grilla.Name = "cm_grilla";
            this.cm_grilla.Size = new System.Drawing.Size(135, 54);
            // 
            // cm_grilla_copia
            // 
            this.cm_grilla_copia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cm_grilla_copia.Name = "cm_grilla_copia";
            this.cm_grilla_copia.Size = new System.Drawing.Size(134, 22);
            this.cm_grilla_copia.Text = "Copia";
            this.cm_grilla_copia.Click += new System.EventHandler(this.cm_grilla_copia_Click);
            // 
            // cm_grilla_copia_tabla
            // 
            this.cm_grilla_copia_tabla.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cm_grilla_copia_tabla.Name = "cm_grilla_copia_tabla";
            this.cm_grilla_copia_tabla.Size = new System.Drawing.Size(134, 22);
            this.cm_grilla_copia_tabla.Text = "Copia tabla";
            this.cm_grilla_copia_tabla.Click += new System.EventHandler(this.cm_grilla_copia_tabla_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // txt_fechaReg
            // 
            this.txt_fechaReg.AcceptsTab = true;
            this.txt_fechaReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fechaReg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_fechaReg.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fechaReg.Location = new System.Drawing.Point(161, 12);
            this.txt_fechaReg.Name = "txt_fechaReg";
            this.txt_fechaReg.Size = new System.Drawing.Size(143, 21);
            this.txt_fechaReg.TabIndex = 410;
            this.txt_fechaReg.Tag = "ingrese";
            this.txt_fechaReg.TextChanged += new System.EventHandler(this.txt_fechaReg_TextChanged);
            // 
            // dgv_registro
            // 
            this.dgv_registro.AllowUserToAddRows = false;
            this.dgv_registro.AllowUserToDeleteRows = false;
            this.dgv_registro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_registro.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_registro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_registro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_registro.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_registro.EnableHeadersVisualStyles = false;
            this.dgv_registro.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_registro.Location = new System.Drawing.Point(9, 58);
            this.dgv_registro.Name = "dgv_registro";
            this.dgv_registro.ReadOnly = true;
            this.dgv_registro.Size = new System.Drawing.Size(309, 316);
            this.dgv_registro.TabIndex = 402;
            // 
            // lbl_DocEntrega
            // 
            this.lbl_DocEntrega.AutoSize = true;
            this.lbl_DocEntrega.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DocEntrega.Location = new System.Drawing.Point(363, 41);
            this.lbl_DocEntrega.Name = "lbl_DocEntrega";
            this.lbl_DocEntrega.Size = new System.Drawing.Size(150, 14);
            this.lbl_DocEntrega.TabIndex = 401;
            this.lbl_DocEntrega.Text = "Documentos para entrega";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(145, 14);
            this.label18.TabIndex = 254;
            this.label18.Text = "Documentos registrados";
            // 
            // tp_anexo
            // 
            this.tp_anexo.BackColor = System.Drawing.SystemColors.Control;
            this.tp_anexo.Controls.Add(this.dgv_anexo_consulta);
            this.tp_anexo.Controls.Add(this.dgv_anexo);
            this.tp_anexo.Controls.Add(this.btn_borrar_anexo);
            this.tp_anexo.Controls.Add(this.btn_visualizar);
            this.tp_anexo.Controls.Add(this.btn_explorar);
            this.tp_anexo.Location = new System.Drawing.Point(4, 20);
            this.tp_anexo.Name = "tp_anexo";
            this.tp_anexo.Padding = new System.Windows.Forms.Padding(3);
            this.tp_anexo.Size = new System.Drawing.Size(674, 386);
            this.tp_anexo.TabIndex = 1;
            this.tp_anexo.Text = "Anexos";
            // 
            // dgv_anexo_consulta
            // 
            this.dgv_anexo_consulta.AllowUserToAddRows = false;
            this.dgv_anexo_consulta.AllowUserToDeleteRows = false;
            this.dgv_anexo_consulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_anexo_consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_anexo_consulta.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_anexo_consulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_anexo_consulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgv_anexo_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_anexo_consulta.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgv_anexo_consulta.EnableHeadersVisualStyles = false;
            this.dgv_anexo_consulta.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_anexo_consulta.Location = new System.Drawing.Point(16, 17);
            this.dgv_anexo_consulta.Name = "dgv_anexo_consulta";
            this.dgv_anexo_consulta.ReadOnly = true;
            this.dgv_anexo_consulta.Size = new System.Drawing.Size(535, 198);
            this.dgv_anexo_consulta.TabIndex = 362;
            this.dgv_anexo_consulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_anexo_consulta_CellClick);
            this.dgv_anexo_consulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_anexo_consulta_CellDoubleClick);
            // 
            // dgv_anexo
            // 
            this.dgv_anexo.AllowUserToAddRows = false;
            this.dgv_anexo.AllowUserToDeleteRows = false;
            this.dgv_anexo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_anexo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_anexo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_anexo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_anexo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgv_anexo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_anexo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ruta_,
            this.archivo_,
            this.fecha_,
            this.extension_,
            this.AbsEntry,
            this.line,
            this.local_r});
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_anexo.DefaultCellStyle = dataGridViewCellStyle32;
            this.dgv_anexo.EnableHeadersVisualStyles = false;
            this.dgv_anexo.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_anexo.Location = new System.Drawing.Point(16, 17);
            this.dgv_anexo.Name = "dgv_anexo";
            this.dgv_anexo.ReadOnly = true;
            this.dgv_anexo.Size = new System.Drawing.Size(535, 198);
            this.dgv_anexo.TabIndex = 358;
            this.dgv_anexo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_anexo_CellClick);
            this.dgv_anexo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_anexo_CellDoubleClick);
            // 
            // ruta_
            // 
            this.ruta_.HeaderText = "Via de acceso destino";
            this.ruta_.Name = "ruta_";
            this.ruta_.ReadOnly = true;
            // 
            // archivo_
            // 
            this.archivo_.HeaderText = "Nombre de archivo";
            this.archivo_.Name = "archivo_";
            this.archivo_.ReadOnly = true;
            // 
            // fecha_
            // 
            this.fecha_.HeaderText = "Fecha del anexo";
            this.fecha_.Name = "fecha_";
            this.fecha_.ReadOnly = true;
            // 
            // extension_
            // 
            this.extension_.HeaderText = "Extension";
            this.extension_.Name = "extension_";
            this.extension_.ReadOnly = true;
            this.extension_.Visible = false;
            // 
            // AbsEntry
            // 
            this.AbsEntry.HeaderText = "id";
            this.AbsEntry.Name = "AbsEntry";
            this.AbsEntry.ReadOnly = true;
            this.AbsEntry.Visible = false;
            // 
            // line
            // 
            this.line.HeaderText = "Linea";
            this.line.Name = "line";
            this.line.ReadOnly = true;
            this.line.Visible = false;
            // 
            // local_r
            // 
            this.local_r.HeaderText = "Ruta local";
            this.local_r.Name = "local_r";
            this.local_r.ReadOnly = true;
            this.local_r.Visible = false;
            // 
            // tp_listado
            // 
            this.tp_listado.BackColor = System.Drawing.SystemColors.Control;
            this.tp_listado.Controls.Add(this.dgv_lista);
            this.tp_listado.Location = new System.Drawing.Point(4, 20);
            this.tp_listado.Name = "tp_listado";
            this.tp_listado.Padding = new System.Windows.Forms.Padding(3);
            this.tp_listado.Size = new System.Drawing.Size(674, 386);
            this.tp_listado.TabIndex = 2;
            this.tp_listado.Text = "Listado";
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
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_lista.DefaultCellStyle = dataGridViewCellStyle34;
            this.dgv_lista.EnableHeadersVisualStyles = false;
            this.dgv_lista.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_lista.Location = new System.Drawing.Point(7, 15);
            this.dgv_lista.Name = "dgv_lista";
            this.dgv_lista.Size = new System.Drawing.Size(657, 386);
            this.dgv_lista.TabIndex = 357;
            // 
            // tp_auditoria
            // 
            this.tp_auditoria.BackColor = System.Drawing.SystemColors.Control;
            this.tp_auditoria.Controls.Add(this.txt_tipodoc);
            this.tp_auditoria.Controls.Add(this.label12);
            this.tp_auditoria.Controls.Add(this.txt_operacion);
            this.tp_auditoria.Controls.Add(this.txt_formulario);
            this.tp_auditoria.Controls.Add(this.label10);
            this.tp_auditoria.Controls.Add(this.label3);
            this.tp_auditoria.Controls.Add(this.label13);
            this.tp_auditoria.Controls.Add(this.txt_estado_registro);
            this.tp_auditoria.Controls.Add(this.label7);
            this.tp_auditoria.Controls.Add(this.txt_fec_modi);
            this.tp_auditoria.Controls.Add(this.txt_usr_crea);
            this.tp_auditoria.Controls.Add(this.txt_terminal_modi);
            this.tp_auditoria.Controls.Add(this.label2);
            this.tp_auditoria.Controls.Add(this.label33);
            this.tp_auditoria.Controls.Add(this.txt_terminal_crea);
            this.tp_auditoria.Controls.Add(this.txt_usr_modi);
            this.tp_auditoria.Controls.Add(this.txt_fec_crea);
            this.tp_auditoria.Controls.Add(this.label34);
            this.tp_auditoria.Controls.Add(this.label6);
            this.tp_auditoria.Controls.Add(this.label35);
            this.tp_auditoria.Location = new System.Drawing.Point(4, 20);
            this.tp_auditoria.Name = "tp_auditoria";
            this.tp_auditoria.Size = new System.Drawing.Size(674, 386);
            this.tp_auditoria.TabIndex = 3;
            this.tp_auditoria.Text = "Auditoria";
            // 
            // txt_tipodoc
            // 
            this.txt_tipodoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tipodoc.Location = new System.Drawing.Point(402, 35);
            this.txt_tipodoc.Name = "txt_tipodoc";
            this.txt_tipodoc.ReadOnly = true;
            this.txt_tipodoc.Size = new System.Drawing.Size(148, 21);
            this.txt_tipodoc.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(291, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Tipo de Documento :";
            // 
            // txt_operacion
            // 
            this.txt_operacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_operacion.Location = new System.Drawing.Point(127, 165);
            this.txt_operacion.Name = "txt_operacion";
            this.txt_operacion.ReadOnly = true;
            this.txt_operacion.Size = new System.Drawing.Size(149, 21);
            this.txt_operacion.TabIndex = 9;
            // 
            // txt_formulario
            // 
            this.txt_formulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_formulario.Location = new System.Drawing.Point(401, 9);
            this.txt_formulario.Name = "txt_formulario";
            this.txt_formulario.ReadOnly = true;
            this.txt_formulario.Size = new System.Drawing.Size(149, 21);
            this.txt_formulario.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Terminal Creacion :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Usuario Creacion :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(292, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Formulario :";
            // 
            // txt_estado_registro
            // 
            this.txt_estado_registro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_estado_registro.Location = new System.Drawing.Point(402, 61);
            this.txt_estado_registro.Name = "txt_estado_registro";
            this.txt_estado_registro.ReadOnly = true;
            this.txt_estado_registro.Size = new System.Drawing.Size(149, 21);
            this.txt_estado_registro.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Estado :";
            // 
            // txt_fec_modi
            // 
            this.txt_fec_modi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fec_modi.Location = new System.Drawing.Point(127, 113);
            this.txt_fec_modi.Name = "txt_fec_modi";
            this.txt_fec_modi.ReadOnly = true;
            this.txt_fec_modi.Size = new System.Drawing.Size(149, 21);
            this.txt_fec_modi.TabIndex = 15;
            // 
            // txt_usr_crea
            // 
            this.txt_usr_crea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usr_crea.Location = new System.Drawing.Point(127, 10);
            this.txt_usr_crea.Name = "txt_usr_crea";
            this.txt_usr_crea.ReadOnly = true;
            this.txt_usr_crea.Size = new System.Drawing.Size(149, 21);
            this.txt_usr_crea.TabIndex = 4;
            // 
            // txt_terminal_modi
            // 
            this.txt_terminal_modi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_terminal_modi.Location = new System.Drawing.Point(127, 139);
            this.txt_terminal_modi.Name = "txt_terminal_modi";
            this.txt_terminal_modi.ReadOnly = true;
            this.txt_terminal_modi.Size = new System.Drawing.Size(149, 21);
            this.txt_terminal_modi.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de Creacion :";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(18, 116);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(103, 13);
            this.label33.TabIndex = 12;
            this.label33.Text = "Fecha Modificacion :";
            // 
            // txt_terminal_crea
            // 
            this.txt_terminal_crea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_terminal_crea.Location = new System.Drawing.Point(127, 61);
            this.txt_terminal_crea.Name = "txt_terminal_crea";
            this.txt_terminal_crea.ReadOnly = true;
            this.txt_terminal_crea.Size = new System.Drawing.Size(149, 21);
            this.txt_terminal_crea.TabIndex = 5;
            // 
            // txt_usr_modi
            // 
            this.txt_usr_modi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usr_modi.Location = new System.Drawing.Point(127, 87);
            this.txt_usr_modi.Name = "txt_usr_modi";
            this.txt_usr_modi.ReadOnly = true;
            this.txt_usr_modi.Size = new System.Drawing.Size(149, 21);
            this.txt_usr_modi.TabIndex = 16;
            // 
            // txt_fec_crea
            // 
            this.txt_fec_crea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fec_crea.Location = new System.Drawing.Point(127, 35);
            this.txt_fec_crea.Name = "txt_fec_crea";
            this.txt_fec_crea.ReadOnly = true;
            this.txt_fec_crea.Size = new System.Drawing.Size(149, 21);
            this.txt_fec_crea.TabIndex = 3;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(17, 90);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(112, 13);
            this.label34.TabIndex = 13;
            this.label34.Text = "Usuario Modificacion :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Operacion :";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(17, 142);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(116, 13);
            this.label35.TabIndex = 14;
            this.label35.Text = "Terminal Modificacion :";
            // 
            // t_msg
            // 
            this.t_msg.Interval = 5000;
            this.t_msg.Tick += new System.EventHandler(this.t_msg_Tick);
            // 
            // lbl_hora
            // 
            this.lbl_hora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_hora.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.Location = new System.Drawing.Point(9, 108);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(124, 14);
            this.lbl_hora.TabIndex = 386;
            this.lbl_hora.Text = "Fecha del documento";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 14);
            this.label15.TabIndex = 380;
            this.label15.Text = "Nº de lote";
            // 
            // txt_lote
            // 
            this.txt_lote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lote.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_lote.Location = new System.Drawing.Point(169, 79);
            this.txt_lote.Name = "txt_lote";
            this.txt_lote.ReadOnly = true;
            this.txt_lote.Size = new System.Drawing.Size(143, 21);
            this.txt_lote.TabIndex = 379;
            this.txt_lote.Enter += new System.EventHandler(this.txt_idreg_Enter);
            this.txt_lote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idreg_KeyPress);
            // 
            // dp_FechaDocumento
            // 
            this.dp_FechaDocumento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dp_FechaDocumento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_FechaDocumento.Location = new System.Drawing.Point(295, 101);
            this.dp_FechaDocumento.Name = "dp_FechaDocumento";
            this.dp_FechaDocumento.Size = new System.Drawing.Size(17, 21);
            this.dp_FechaDocumento.TabIndex = 396;
            this.dp_FechaDocumento.ValueChanged += new System.EventHandler(this.dp_FechaDocumento_ValueChanged);
            // 
            // cm_formulario
            // 
            this.cm_formulario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmi_eliminar,
            this.toolStripSeparator2});
            this.cm_formulario.Name = "cm_grilla";
            this.cm_formulario.Size = new System.Drawing.Size(118, 32);
            // 
            // cmi_eliminar
            // 
            this.cmi_eliminar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmi_eliminar.Enabled = false;
            this.cmi_eliminar.Name = "cmi_eliminar";
            this.cmi_eliminar.Size = new System.Drawing.Size(117, 22);
            this.cmi_eliminar.Text = "Eliminar";
            this.cmi_eliminar.Click += new System.EventHandler(this.cmi_eliminar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(114, 6);
            // 
            // txt_FechaDocumento
            // 
            this.txt_FechaDocumento.AcceptsTab = true;
            this.txt_FechaDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FechaDocumento.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_FechaDocumento.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FechaDocumento.Location = new System.Drawing.Point(169, 101);
            this.txt_FechaDocumento.Name = "txt_FechaDocumento";
            this.txt_FechaDocumento.Size = new System.Drawing.Size(143, 21);
            this.txt_FechaDocumento.TabIndex = 407;
            this.txt_FechaDocumento.Tag = "ingrese";
            // 
            // btn_nuevo_b
            // 
            this.btn_nuevo_b.AutoSize = false;
            this.btn_nuevo_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_nuevo_b.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_nuevo_b.Enabled = false;
            this.btn_nuevo_b.Image = global::MISAP.Properties.Resources.DATAadd;
            this.btn_nuevo_b.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_nuevo_b.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nuevo_b.Margin = new System.Windows.Forms.Padding(0);
            this.btn_nuevo_b.Name = "btn_nuevo_b";
            this.btn_nuevo_b.Size = new System.Drawing.Size(29, 44);
            this.btn_nuevo_b.Text = "Nuevo";
            this.btn_nuevo_b.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nuevo_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_nuevo_b.ToolTipText = "Nuevo";
            this.btn_nuevo_b.Click += new System.EventHandler(this.btn_nuevo_b_Click);
            // 
            // btn_editar_b
            // 
            this.btn_editar_b.AutoSize = false;
            this.btn_editar_b.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_editar_b.Image = global::MISAP.Properties.Resources.TOOLSdoceditor;
            this.btn_editar_b.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_editar_b.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_editar_b.Name = "btn_editar_b";
            this.btn_editar_b.Size = new System.Drawing.Size(29, 44);
            this.btn_editar_b.Text = "Editar";
            this.btn_editar_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_editar_b.ToolTipText = "Editar";
            this.btn_editar_b.Visible = false;
            // 
            // btn_consultar_b
            // 
            this.btn_consultar_b.AutoSize = false;
            this.btn_consultar_b.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_consultar_b.Image = global::MISAP.Properties.Resources.DATAfind;
            this.btn_consultar_b.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_consultar_b.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_consultar_b.Name = "btn_consultar_b";
            this.btn_consultar_b.Size = new System.Drawing.Size(29, 44);
            this.btn_consultar_b.Text = "Consultar";
            this.btn_consultar_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_consultar_b.Click += new System.EventHandler(this.btn_consultar_b_Click);
            // 
            // btn_eliminar_b
            // 
            this.btn_eliminar_b.AutoSize = false;
            this.btn_eliminar_b.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_eliminar_b.Enabled = false;
            this.btn_eliminar_b.Image = global::MISAP.Properties.Resources.linkMapIconCancellation;
            this.btn_eliminar_b.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_eliminar_b.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_eliminar_b.Name = "btn_eliminar_b";
            this.btn_eliminar_b.Size = new System.Drawing.Size(29, 44);
            this.btn_eliminar_b.Text = "Eliminar";
            this.btn_eliminar_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_eliminar_b.ToolTipText = "Eliminar";
            this.btn_eliminar_b.Visible = false;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.AutoSize = false;
            this.btn_imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_imprimir.Enabled = false;
            this.btn_imprimir.Image = global::MISAP.Properties.Resources.FILEprint;
            this.btn_imprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(29, 44);
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_imprimir.ToolTipText = "Imprimir";
            // 
            // btn_primero
            // 
            this.btn_primero.AutoSize = false;
            this.btn_primero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_primero.Image = global::MISAP.Properties.Resources.DATAfirst;
            this.btn_primero.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_primero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(29, 44);
            this.btn_primero.Text = "Primer reg. datos";
            this.btn_primero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_primero.ToolTipText = "Primer reg. datos";
            this.btn_primero.Click += new System.EventHandler(this.btn_primero_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.AutoSize = false;
            this.btn_anterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_anterior.Image = global::MISAP.Properties.Resources.DATAprevious;
            this.btn_anterior.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_anterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(29, 44);
            this.btn_anterior.Text = "Registro de datos anterior";
            this.btn_anterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_anterior.ToolTipText = "Registro de datos anterior";
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.AutoSize = false;
            this.btn_siguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_siguiente.Image = global::MISAP.Properties.Resources.DATAnext;
            this.btn_siguiente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_siguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(29, 44);
            this.btn_siguiente.Text = "Registro de datos siguiente";
            this.btn_siguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_siguiente.ToolTipText = "Registro de datos siguiente";
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_utlimo
            // 
            this.btn_utlimo.AutoSize = false;
            this.btn_utlimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_utlimo.Image = global::MISAP.Properties.Resources.DATAlast;
            this.btn_utlimo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_utlimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_utlimo.Name = "btn_utlimo";
            this.btn_utlimo.Size = new System.Drawing.Size(29, 44);
            this.btn_utlimo.Text = "Ultimo reg. datos";
            this.btn_utlimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_utlimo.ToolTipText = "Ultimo reg. datos";
            this.btn_utlimo.Click += new System.EventHandler(this.btn_utlimo_Click);
            // 
            // btn_previsualizar
            // 
            this.btn_previsualizar.AutoSize = false;
            this.btn_previsualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_previsualizar.Enabled = false;
            this.btn_previsualizar.Image = global::MISAP.Properties.Resources.FILEprintp;
            this.btn_previsualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_previsualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_previsualizar.Name = "btn_previsualizar";
            this.btn_previsualizar.Size = new System.Drawing.Size(29, 44);
            this.btn_previsualizar.Text = "Previsualizar";
            this.btn_previsualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_previsualizar.ToolTipText = "Previsualizar";
            this.btn_previsualizar.Click += new System.EventHandler(this.btn_previsualizar_Click);
            // 
            // btn_exportar_xls
            // 
            this.btn_exportar_xls.AutoSize = false;
            this.btn_exportar_xls.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_exportar_xls.Enabled = false;
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
            // btn_plantilla
            // 
            this.btn_plantilla.AutoSize = false;
            this.btn_plantilla.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_plantilla.Enabled = false;
            this.btn_plantilla.Image = global::MISAP.Properties.Resources.RnDrows;
            this.btn_plantilla.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_plantilla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_plantilla.Name = "btn_plantilla";
            this.btn_plantilla.Size = new System.Drawing.Size(29, 44);
            this.btn_plantilla.Text = "PLANTILLA TRASLADOS";
            this.btn_plantilla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_plantilla.ToolTipText = "PLANTILLA TRASLADOS";
            this.btn_plantilla.Visible = false;
            // 
            // btn_aprobar
            // 
            this.btn_aprobar.AutoSize = false;
            this.btn_aprobar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_aprobar.Enabled = false;
            this.btn_aprobar.Image = global::MISAP.Properties.Resources.linkMapIconaancellation;
            this.btn_aprobar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_aprobar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_aprobar.Name = "btn_aprobar";
            this.btn_aprobar.Size = new System.Drawing.Size(29, 44);
            this.btn_aprobar.Text = "Aprobar";
            this.btn_aprobar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_aprobar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_aprobar.ToolTipText = "Aprobar";
            this.btn_aprobar.Visible = false;
            // 
            // btn_desaprobar
            // 
            this.btn_desaprobar.AutoSize = false;
            this.btn_desaprobar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_desaprobar.Enabled = false;
            this.btn_desaprobar.Image = global::MISAP.Properties.Resources.linkMapIconNotAuthorised;
            this.btn_desaprobar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_desaprobar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_desaprobar.Name = "btn_desaprobar";
            this.btn_desaprobar.Size = new System.Drawing.Size(29, 44);
            this.btn_desaprobar.Text = "Rechazar";
            this.btn_desaprobar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_desaprobar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_desaprobar.ToolTipText = "Rechazar";
            this.btn_desaprobar.Visible = false;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.AutoSize = false;
            this.btn_actualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_actualizar.Enabled = false;
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
            // btn_grabar
            // 
            this.btn_grabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_grabar.BackgroundImage = global::MISAP.Properties.Resources.btn_enfasis_dasactivado;
            this.btn_grabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_grabar.Enabled = false;
            this.btn_grabar.FlatAppearance.BorderSize = 0;
            this.btn_grabar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_grabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grabar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grabar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_grabar.Location = new System.Drawing.Point(6, 557);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(64, 21);
            this.btn_grabar.TabIndex = 311;
            this.btn_grabar.Text = "Crear";
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
            this.btn_cancelar.Location = new System.Drawing.Point(76, 557);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(64, 21);
            this.btn_cancelar.TabIndex = 312;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.salir_Click);
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
            this.titulo.Size = new System.Drawing.Size(706, 27);
            this.titulo.TabIndex = 260;
            this.titulo.Text = "toolStrip1";
            this.titulo.DoubleClick += new System.EventHandler(this.titulo_DoubleClick);
            this.titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            // 
            // tsl_titulo
            // 
            this.tsl_titulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsl_titulo.Name = "tsl_titulo";
            this.tsl_titulo.Size = new System.Drawing.Size(125, 24);
            this.tsl_titulo.Text = "Cargo de documentos";
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
            // btn_anular_all_seleccion
            // 
            this.btn_anular_all_seleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_anular_all_seleccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_anular_all_seleccion.Enabled = false;
            this.btn_anular_all_seleccion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_anular_all_seleccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_anular_all_seleccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_anular_all_seleccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_anular_all_seleccion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anular_all_seleccion.Image = global::MISAP.Properties.Resources.ANULAR_ALL_SELECCION;
            this.btn_anular_all_seleccion.ImageKey = "(ninguno)";
            this.btn_anular_all_seleccion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_anular_all_seleccion.Location = new System.Drawing.Point(324, 176);
            this.btn_anular_all_seleccion.Name = "btn_anular_all_seleccion";
            this.btn_anular_all_seleccion.Size = new System.Drawing.Size(20, 20);
            this.btn_anular_all_seleccion.TabIndex = 413;
            this.btn_anular_all_seleccion.Text = " ";
            this.btn_anular_all_seleccion.UseVisualStyleBackColor = true;
            this.btn_anular_all_seleccion.Visible = false;
            // 
            // btn_anular_seleccion
            // 
            this.btn_anular_seleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_anular_seleccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_anular_seleccion.Enabled = false;
            this.btn_anular_seleccion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_anular_seleccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_anular_seleccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_anular_seleccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_anular_seleccion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anular_seleccion.Image = global::MISAP.Properties.Resources.ANULAR_SELECCION;
            this.btn_anular_seleccion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_anular_seleccion.Location = new System.Drawing.Point(324, 150);
            this.btn_anular_seleccion.Name = "btn_anular_seleccion";
            this.btn_anular_seleccion.Size = new System.Drawing.Size(20, 20);
            this.btn_anular_seleccion.TabIndex = 412;
            this.btn_anular_seleccion.UseVisualStyleBackColor = true;
            this.btn_anular_seleccion.Visible = false;
            this.btn_anular_seleccion.Click += new System.EventHandler(this.btn_anular_seleccion_Click);
            // 
            // btn_agregar_seleccion
            // 
            this.btn_agregar_seleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_agregar_seleccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar_seleccion.Enabled = false;
            this.btn_agregar_seleccion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_agregar_seleccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_agregar_seleccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_agregar_seleccion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_seleccion.Image = global::MISAP.Properties.Resources.AGREGAR_SELECCION;
            this.btn_agregar_seleccion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_agregar_seleccion.Location = new System.Drawing.Point(324, 124);
            this.btn_agregar_seleccion.Name = "btn_agregar_seleccion";
            this.btn_agregar_seleccion.Size = new System.Drawing.Size(20, 20);
            this.btn_agregar_seleccion.TabIndex = 408;
            this.btn_agregar_seleccion.UseVisualStyleBackColor = true;
            this.btn_agregar_seleccion.Click += new System.EventHandler(this.btn_pasar_Click);
            // 
            // btn_borrar_anexo
            // 
            this.btn_borrar_anexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_borrar_anexo.BackgroundImage = global::MISAP.Properties.Resources.btn_desactivado;
            this.btn_borrar_anexo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar_anexo.Enabled = false;
            this.btn_borrar_anexo.FlatAppearance.BorderSize = 0;
            this.btn_borrar_anexo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_borrar_anexo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_borrar_anexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar_anexo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar_anexo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_borrar_anexo.Location = new System.Drawing.Point(567, 194);
            this.btn_borrar_anexo.Name = "btn_borrar_anexo";
            this.btn_borrar_anexo.Size = new System.Drawing.Size(71, 21);
            this.btn_borrar_anexo.TabIndex = 361;
            this.btn_borrar_anexo.Text = "Borrar";
            this.btn_borrar_anexo.UseVisualStyleBackColor = true;
            this.btn_borrar_anexo.Click += new System.EventHandler(this.btn_borrar_anexo_Click);
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_visualizar.BackgroundImage = global::MISAP.Properties.Resources.btn_desactivado;
            this.btn_visualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_visualizar.Enabled = false;
            this.btn_visualizar.FlatAppearance.BorderSize = 0;
            this.btn_visualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_visualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visualizar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_visualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_visualizar.Location = new System.Drawing.Point(567, 64);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(71, 21);
            this.btn_visualizar.TabIndex = 360;
            this.btn_visualizar.Text = "Visualizar";
            this.btn_visualizar.UseVisualStyleBackColor = true;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // btn_explorar
            // 
            this.btn_explorar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_explorar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_explorar.BackgroundImage")));
            this.btn_explorar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_explorar.FlatAppearance.BorderSize = 0;
            this.btn_explorar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_explorar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_explorar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_explorar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_explorar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_explorar.Location = new System.Drawing.Point(567, 17);
            this.btn_explorar.Name = "btn_explorar";
            this.btn_explorar.Size = new System.Drawing.Size(71, 21);
            this.btn_explorar.TabIndex = 359;
            this.btn_explorar.Text = "Explorar";
            this.btn_explorar.UseVisualStyleBackColor = true;
            this.btn_explorar.Click += new System.EventHandler(this.btn_explorar_Click);
            // 
            // btn_agregar_all_seleccion
            // 
            this.btn_agregar_all_seleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_agregar_all_seleccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar_all_seleccion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_agregar_all_seleccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_agregar_all_seleccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_agregar_all_seleccion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_all_seleccion.Image = global::MISAP.Properties.Resources.AGREGAR_ALL_SELECCION;
            this.btn_agregar_all_seleccion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_agregar_all_seleccion.Location = new System.Drawing.Point(324, 98);
            this.btn_agregar_all_seleccion.Name = "btn_agregar_all_seleccion";
            this.btn_agregar_all_seleccion.Size = new System.Drawing.Size(20, 20);
            this.btn_agregar_all_seleccion.TabIndex = 414;
            this.btn_agregar_all_seleccion.UseVisualStyleBackColor = true;
            this.btn_agregar_all_seleccion.Click += new System.EventHandler(this.btn_agregar_all_seleccion_Click);
            // 
            // FrmCargoDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 604);
            this.ContextMenuStrip = this.cm_formulario;
            this.ControlBox = false;
            this.Controls.Add(this.dp_FechaDocumento);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_lote);
            this.Controls.Add(this.ts_acciones);
            this.Controls.Add(this.btn_grabar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.ss_load);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.tc_detalle);
            this.Controls.Add(this.txt_FechaDocumento);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCargoDoc";
            this.Load += new System.EventHandler(this.FrmAvanceProyecto_Load);
            this.ss_load.ResumeLayout(false);
            this.ss_load.PerformLayout();
            this.ts_acciones.ResumeLayout(false);
            this.ts_acciones.PerformLayout();
            this.tc_detalle.ResumeLayout(false);
            this.tp_contenido.ResumeLayout(false);
            this.tp_contenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cargo)).EndInit();
            this.cm_grilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registro)).EndInit();
            this.tp_anexo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_anexo_consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_anexo)).EndInit();
            this.tp_listado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).EndInit();
            this.tp_auditoria.ResumeLayout(false);
            this.tp_auditoria.PerformLayout();
            this.cm_formulario.ResumeLayout(false);
            this.titulo.ResumeLayout(false);
            this.titulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ss_load;
        private System.Windows.Forms.ToolStripStatusLabel lbl_contador_registros;
        private System.Windows.Forms.ToolStripStatusLabel lbl_U_CL_CODSOL;
        private System.Windows.Forms.ToolStripStatusLabel lbl_U_CL_SOLICI;
        private System.Windows.Forms.ToolStripStatusLabel lbl_msg;
        private System.Windows.Forms.ToolStripStatusLabel lbl_maximi;
        private System.Windows.Forms.Button btn_grabar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ToolStrip ts_acciones;
        private System.Windows.Forms.ToolStripButton btn_nuevo_b;
        private System.Windows.Forms.ToolStripButton btn_editar_b;
        private System.Windows.Forms.ToolStripButton btn_consultar_b;
        private System.Windows.Forms.ToolStripButton btn_eliminar_b;
        private System.Windows.Forms.ToolStripButton btn_imprimir;
        private System.Windows.Forms.ToolStripButton btn_primero;
        private System.Windows.Forms.ToolStripButton btn_anterior;
        private System.Windows.Forms.ToolStripButton btn_siguiente;
        private System.Windows.Forms.ToolStripButton btn_utlimo;
        private System.Windows.Forms.ToolStripButton btn_previsualizar;
        private System.Windows.Forms.ToolStripButton btn_exportar_xls;
        private System.Windows.Forms.ToolStripButton btn_plantilla;
        private System.Windows.Forms.ToolStripButton btn_aprobar;
        private System.Windows.Forms.ToolStripButton btn_desaprobar;
        private System.Windows.Forms.ToolStripButton btn_actualizar;
        private System.Windows.Forms.ToolStripButton btn_filtro;
        private System.Windows.Forms.ToolStripButton btn_ayuda;
        private System.Windows.Forms.TabControl tc_detalle;
        private System.Windows.Forms.TabPage tp_contenido;
        private System.Windows.Forms.TabPage tp_anexo;
        private System.Windows.Forms.Timer t_msg;
        private System.Windows.Forms.DataGridView dgv_lista;
        private System.Windows.Forms.TabPage tp_listado;
        private System.Windows.Forms.TabPage tp_auditoria;
        private System.Windows.Forms.TextBox txt_tipodoc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_operacion;
        private System.Windows.Forms.TextBox txt_formulario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_estado_registro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_fec_modi;
        private System.Windows.Forms.TextBox txt_usr_crea;
        private System.Windows.Forms.TextBox txt_terminal_modi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txt_terminal_crea;
        private System.Windows.Forms.TextBox txt_usr_modi;
        private System.Windows.Forms.TextBox txt_fec_crea;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ToolStripStatusLabel lbl_origen;
        private System.Windows.Forms.ContextMenuStrip cm_grilla;
        private System.Windows.Forms.ToolStripMenuItem cm_grilla_copia;
        private System.Windows.Forms.ToolStripMenuItem cm_grilla_copia_tabla;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_lote;
        private System.Windows.Forms.DateTimePicker dp_FechaDocumento;
        private System.Windows.Forms.Label lbl_DocEntrega;
        private System.Windows.Forms.ToolStripLabel tsl_titulo;
        private System.Windows.Forms.ToolStripButton salir;
        private System.Windows.Forms.ToolStripButton maximizar;
        private System.Windows.Forms.ToolStripButton ninimizar;
        private System.Windows.Forms.ToolStrip titulo;
        private System.Windows.Forms.ContextMenuStrip cm_formulario;
        private System.Windows.Forms.ToolStripMenuItem cmi_eliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btn_explorar;
        private System.Windows.Forms.DataGridView dgv_anexo;
        private System.Windows.Forms.Button btn_borrar_anexo;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn archivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn extension;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruta_;
        private System.Windows.Forms.DataGridViewTextBoxColumn archivo_;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_;
        private System.Windows.Forms.DataGridViewTextBoxColumn extension_;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbsEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn line;
        private System.Windows.Forms.DataGridViewTextBoxColumn local_r;
        private System.Windows.Forms.DataGridView dgv_anexo_consulta;
        private System.Windows.Forms.TextBox txt_FechaDocumento;
        private System.Windows.Forms.DataGridView dgv_cargo;
        private System.Windows.Forms.DateTimePicker dp_FechaReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_fechaReg;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrog;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreg;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieg;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentog;
        private System.Windows.Forms.Button btn_agregar_seleccion;
        private System.Windows.Forms.DataGridView dgv_registro;
        private System.Windows.Forms.Button btn_anular_seleccion;
        private System.Windows.Forms.Button btn_anular_all_seleccion;
        private System.Windows.Forms.Button btn_agregar_all_seleccion;
    }
}