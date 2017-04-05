namespace MISAP
{
    partial class FrmExtractoBancario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExtractoBancario));
            this.ss_load = new System.Windows.Forms.StatusStrip();
            this.lbl_contador_registros = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_CODSOL = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_SOLICI = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_msg = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_maximi = new System.Windows.Forms.ToolStripStatusLabel();
            this.t_msg = new System.Windows.Forms.Timer(this.components);
            this.lbl_nombre_cuenta = new System.Windows.Forms.Label();
            this.dgv_extracto = new System.Windows.Forms.DataGridView();
            this.seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbl_cuenta = new System.Windows.Forms.Label();
            this.txt_cuenta = new System.Windows.Forms.TextBox();
            this.txt_archivo = new System.Windows.Forms.TextBox();
            this.txt_hoja = new System.Windows.Forms.TextBox();
            this.lb_hoja = new System.Windows.Forms.ListBox();
            this.lbl_banco = new System.Windows.Forms.Label();
            this.txt_banco = new System.Windows.Forms.TextBox();
            this.txt_CodigoBanco = new System.Windows.Forms.TextBox();
            this.dgv_columnas = new System.Windows.Forms.DataGridView();
            this.btn_configuracion = new System.Windows.Forms.Button();
            this.btn_opciones_b = new System.Windows.Forms.Button();
            this.btn_cargar_archivo = new System.Windows.Forms.Button();
            this.btn_opciones = new System.Windows.Forms.Button();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.ToolStrip();
            this.tsl_titulo = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.maximizar = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            this.txt_num_estado = new System.Windows.Forms.TextBox();
            this.lbl_num_estado = new System.Windows.Forms.Label();
            this.ts_acciones = new System.Windows.Forms.ToolStrip();
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
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.txt_correlativo = new System.Windows.Forms.TextBox();
            this.lbl_total_1 = new System.Windows.Forms.Label();
            this.txt_total_1 = new System.Windows.Forms.TextBox();
            this.txt_total_2 = new System.Windows.Forms.TextBox();
            this.lbl_total_2 = new System.Windows.Forms.Label();
            this.ss_load.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_extracto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_columnas)).BeginInit();
            this.titulo.SuspendLayout();
            this.ts_acciones.SuspendLayout();
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
            this.lbl_maximi});
            this.ss_load.Location = new System.Drawing.Point(0, 438);
            this.ss_load.Name = "ss_load";
            this.ss_load.Size = new System.Drawing.Size(731, 18);
            this.ss_load.SizingGrip = false;
            this.ss_load.TabIndex = 283;
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
            // t_msg
            // 
            this.t_msg.Interval = 5000;
            this.t_msg.Tick += new System.EventHandler(this.t_msg_Tick);
            // 
            // lbl_nombre_cuenta
            // 
            this.lbl_nombre_cuenta.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_cuenta.Location = new System.Drawing.Point(309, 86);
            this.lbl_nombre_cuenta.Name = "lbl_nombre_cuenta";
            this.lbl_nombre_cuenta.Size = new System.Drawing.Size(301, 11);
            this.lbl_nombre_cuenta.TabIndex = 284;
            // 
            // dgv_extracto
            // 
            this.dgv_extracto.AllowUserToAddRows = false;
            this.dgv_extracto.AllowUserToDeleteRows = false;
            this.dgv_extracto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_extracto.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_extracto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_extracto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_extracto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_extracto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seleccion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_extracto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_extracto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_extracto.EnableHeadersVisualStyles = false;
            this.dgv_extracto.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_extracto.Location = new System.Drawing.Point(8, 149);
            this.dgv_extracto.Name = "dgv_extracto";
            this.dgv_extracto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_extracto.Size = new System.Drawing.Size(716, 240);
            this.dgv_extracto.TabIndex = 285;
            this.dgv_extracto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_extracto_CellContentClick);
            this.dgv_extracto.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_extracto_ColumnHeaderMouseClick);
            this.dgv_extracto.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_extracto_CurrentCellDirtyStateChanged);
            // 
            // seleccion
            // 
            this.seleccion.Frozen = true;
            this.seleccion.HeaderText = "";
            this.seleccion.Name = "seleccion";
            this.seleccion.Visible = false;
            this.seleccion.Width = 40;
            // 
            // lbl_cuenta
            // 
            this.lbl_cuenta.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuenta.Location = new System.Drawing.Point(6, 86);
            this.lbl_cuenta.Name = "lbl_cuenta";
            this.lbl_cuenta.Size = new System.Drawing.Size(124, 14);
            this.lbl_cuenta.TabIndex = 287;
            this.lbl_cuenta.Text = "Cuenta mayor";
            this.lbl_cuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_cuenta
            // 
            this.txt_cuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cuenta.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_cuenta.Enabled = false;
            this.txt_cuenta.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuenta.Location = new System.Drawing.Point(130, 80);
            this.txt_cuenta.Margin = new System.Windows.Forms.Padding(0);
            this.txt_cuenta.MaxLength = 8;
            this.txt_cuenta.Name = "txt_cuenta";
            this.txt_cuenta.ReadOnly = true;
            this.txt_cuenta.Size = new System.Drawing.Size(176, 21);
            this.txt_cuenta.TabIndex = 286;
            this.txt_cuenta.Tag = "ingrese";
            this.txt_cuenta.Enter += new System.EventHandler(this.txt_dni_Enter);
            this.txt_cuenta.Leave += new System.EventHandler(this.txt_cuenta_Leave);
            // 
            // txt_archivo
            // 
            this.txt_archivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_archivo.Location = new System.Drawing.Point(384, 416);
            this.txt_archivo.Multiline = true;
            this.txt_archivo.Name = "txt_archivo";
            this.txt_archivo.Size = new System.Drawing.Size(71, 19);
            this.txt_archivo.TabIndex = 294;
            this.txt_archivo.Visible = false;
            // 
            // txt_hoja
            // 
            this.txt_hoja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hoja.Location = new System.Drawing.Point(434, 414);
            this.txt_hoja.Multiline = true;
            this.txt_hoja.Name = "txt_hoja";
            this.txt_hoja.Size = new System.Drawing.Size(21, 19);
            this.txt_hoja.TabIndex = 297;
            this.txt_hoja.Visible = false;
            // 
            // lb_hoja
            // 
            this.lb_hoja.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_hoja.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hoja.FormattingEnabled = true;
            this.lb_hoja.ItemHeight = 14;
            this.lb_hoja.Location = new System.Drawing.Point(309, 99);
            this.lb_hoja.Name = "lb_hoja";
            this.lb_hoja.Size = new System.Drawing.Size(301, 46);
            this.lb_hoja.TabIndex = 298;
            this.lb_hoja.Visible = false;
            this.lb_hoja.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbl_banco
            // 
            this.lbl_banco.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_banco.Location = new System.Drawing.Point(6, 109);
            this.lbl_banco.Name = "lbl_banco";
            this.lbl_banco.Size = new System.Drawing.Size(124, 14);
            this.lbl_banco.TabIndex = 299;
            this.lbl_banco.Text = "Nombre del banco";
            this.lbl_banco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_banco
            // 
            this.txt_banco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_banco.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_banco.Enabled = false;
            this.txt_banco.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_banco.Location = new System.Drawing.Point(130, 102);
            this.txt_banco.Margin = new System.Windows.Forms.Padding(0);
            this.txt_banco.MaxLength = 8;
            this.txt_banco.Name = "txt_banco";
            this.txt_banco.ReadOnly = true;
            this.txt_banco.Size = new System.Drawing.Size(176, 21);
            this.txt_banco.TabIndex = 300;
            this.txt_banco.Tag = "ingrese";
            this.txt_banco.Enter += new System.EventHandler(this.txt_banco_Enter);
            this.txt_banco.Leave += new System.EventHandler(this.txt_banco_Leave);
            // 
            // txt_CodigoBanco
            // 
            this.txt_CodigoBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CodigoBanco.Location = new System.Drawing.Point(311, 102);
            this.txt_CodigoBanco.Multiline = true;
            this.txt_CodigoBanco.Name = "txt_CodigoBanco";
            this.txt_CodigoBanco.Size = new System.Drawing.Size(67, 19);
            this.txt_CodigoBanco.TabIndex = 302;
            this.txt_CodigoBanco.Visible = false;
            // 
            // dgv_columnas
            // 
            this.dgv_columnas.AllowUserToAddRows = false;
            this.dgv_columnas.AllowUserToDeleteRows = false;
            this.dgv_columnas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_columnas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_columnas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_columnas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_columnas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_columnas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_columnas.EnableHeadersVisualStyles = false;
            this.dgv_columnas.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_columnas.Location = new System.Drawing.Point(384, 86);
            this.dgv_columnas.Name = "dgv_columnas";
            this.dgv_columnas.ReadOnly = true;
            this.dgv_columnas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_columnas.Size = new System.Drawing.Size(340, 64);
            this.dgv_columnas.TabIndex = 303;
            this.dgv_columnas.Visible = false;
            // 
            // btn_configuracion
            // 
            this.btn_configuracion.BackgroundImage = global::MISAP.Properties.Resources.btn_desactivado;
            this.btn_configuracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_configuracion.Enabled = false;
            this.btn_configuracion.FlatAppearance.BorderSize = 0;
            this.btn_configuracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_configuracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_configuracion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_configuracion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_configuracion.Location = new System.Drawing.Point(596, 413);
            this.btn_configuracion.Name = "btn_configuracion";
            this.btn_configuracion.Size = new System.Drawing.Size(123, 22);
            this.btn_configuracion.TabIndex = 304;
            this.btn_configuracion.Text = "Configuracion";
            this.btn_configuracion.UseVisualStyleBackColor = true;
            this.btn_configuracion.Click += new System.EventHandler(this.btn_configuracion_Click);
            // 
            // btn_opciones_b
            // 
            this.btn_opciones_b.BackColor = System.Drawing.Color.Transparent;
            this.btn_opciones_b.BackgroundImage = global::MISAP.Properties.Resources.MENUchoosefromlist;
            this.btn_opciones_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_opciones_b.FlatAppearance.BorderSize = 0;
            this.btn_opciones_b.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_opciones_b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_opciones_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_opciones_b.Location = new System.Drawing.Point(289, 105);
            this.btn_opciones_b.Name = "btn_opciones_b";
            this.btn_opciones_b.Size = new System.Drawing.Size(14, 14);
            this.btn_opciones_b.TabIndex = 301;
            this.btn_opciones_b.UseVisualStyleBackColor = false;
            this.btn_opciones_b.Visible = false;
            this.btn_opciones_b.Click += new System.EventHandler(this.btn_opciones_b_Click);
            // 
            // btn_cargar_archivo
            // 
            this.btn_cargar_archivo.BackgroundImage = global::MISAP.Properties.Resources.btn_desactivado;
            this.btn_cargar_archivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cargar_archivo.Enabled = false;
            this.btn_cargar_archivo.FlatAppearance.BorderSize = 0;
            this.btn_cargar_archivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cargar_archivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cargar_archivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargar_archivo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar_archivo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_cargar_archivo.Location = new System.Drawing.Point(467, 413);
            this.btn_cargar_archivo.Name = "btn_cargar_archivo";
            this.btn_cargar_archivo.Size = new System.Drawing.Size(123, 22);
            this.btn_cargar_archivo.TabIndex = 293;
            this.btn_cargar_archivo.Text = "Cargar archivo";
            this.btn_cargar_archivo.UseVisualStyleBackColor = true;
            this.btn_cargar_archivo.Click += new System.EventHandler(this.btn_cargar_archivo_Click);
            // 
            // btn_opciones
            // 
            this.btn_opciones.BackColor = System.Drawing.Color.Transparent;
            this.btn_opciones.BackgroundImage = global::MISAP.Properties.Resources.MENUchoosefromlist;
            this.btn_opciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_opciones.FlatAppearance.BorderSize = 0;
            this.btn_opciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_opciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_opciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_opciones.Location = new System.Drawing.Point(289, 83);
            this.btn_opciones.Name = "btn_opciones";
            this.btn_opciones.Size = new System.Drawing.Size(14, 14);
            this.btn_opciones.TabIndex = 292;
            this.btn_opciones.UseVisualStyleBackColor = false;
            this.btn_opciones.Visible = false;
            this.btn_opciones.Click += new System.EventHandler(this.btn_opciones_Click);
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
            this.btn_grabar.Location = new System.Drawing.Point(4, 414);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(64, 21);
            this.btn_grabar.TabIndex = 281;
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
            this.btn_cancelar.Location = new System.Drawing.Point(74, 414);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(64, 21);
            this.btn_cancelar.TabIndex = 282;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
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
            this.titulo.Size = new System.Drawing.Size(731, 27);
            this.titulo.TabIndex = 259;
            this.titulo.Text = "toolStrip1";
            this.titulo.DoubleClick += new System.EventHandler(this.titulo_DoubleClick);
            this.titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            // 
            // tsl_titulo
            // 
            this.tsl_titulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsl_titulo.Name = "tsl_titulo";
            this.tsl_titulo.Size = new System.Drawing.Size(194, 24);
            this.tsl_titulo.Text = "Tratar extractos de cuentas externas";
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
            // txt_num_estado
            // 
            this.txt_num_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_num_estado.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_num_estado.Enabled = false;
            this.txt_num_estado.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_estado.Location = new System.Drawing.Point(130, 124);
            this.txt_num_estado.Margin = new System.Windows.Forms.Padding(0);
            this.txt_num_estado.MaxLength = 25;
            this.txt_num_estado.Name = "txt_num_estado";
            this.txt_num_estado.ReadOnly = true;
            this.txt_num_estado.Size = new System.Drawing.Size(176, 21);
            this.txt_num_estado.TabIndex = 306;
            this.txt_num_estado.Tag = "ingrese";
            this.txt_num_estado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_estado_KeyPress);
            this.txt_num_estado.Leave += new System.EventHandler(this.txt_num_estado_Leave);
            // 
            // lbl_num_estado
            // 
            this.lbl_num_estado.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num_estado.Location = new System.Drawing.Point(6, 131);
            this.lbl_num_estado.Name = "lbl_num_estado";
            this.lbl_num_estado.Size = new System.Drawing.Size(124, 14);
            this.lbl_num_estado.TabIndex = 305;
            this.lbl_num_estado.Text = "Nº estado de cuenta";
            this.lbl_num_estado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.ts_acciones.Size = new System.Drawing.Size(731, 47);
            this.ts_acciones.TabIndex = 308;
            this.ts_acciones.Text = "acciones";
            // 
            // btn_nuevo_b
            // 
            this.btn_nuevo_b.AutoSize = false;
            this.btn_nuevo_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_nuevo_b.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            this.btn_editar_b.Enabled = false;
            this.btn_editar_b.Image = global::MISAP.Properties.Resources.TOOLSdoceditor;
            this.btn_editar_b.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_editar_b.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_editar_b.Name = "btn_editar_b";
            this.btn_editar_b.Size = new System.Drawing.Size(29, 44);
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
            this.btn_consultar_b.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_consultar_b.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_consultar_b.Name = "btn_consultar_b";
            this.btn_consultar_b.Size = new System.Drawing.Size(29, 44);
            this.btn_consultar_b.Text = "Consultar";
            this.btn_consultar_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_eliminar_b
            // 
            this.btn_eliminar_b.AutoSize = false;
            this.btn_eliminar_b.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_eliminar_b.Image = global::MISAP.Properties.Resources.linkMapIconCancellation;
            this.btn_eliminar_b.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_eliminar_b.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_eliminar_b.Name = "btn_eliminar_b";
            this.btn_eliminar_b.Size = new System.Drawing.Size(29, 44);
            this.btn_eliminar_b.Text = "Eliminar";
            this.btn_eliminar_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_eliminar_b.ToolTipText = "Eliminar";
            this.btn_eliminar_b.Click += new System.EventHandler(this.btn_eliminar_b_Click);
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
            this.btn_primero.Enabled = false;
            this.btn_primero.Image = global::MISAP.Properties.Resources.DATAfirst;
            this.btn_primero.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_primero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(29, 44);
            this.btn_primero.Text = "Primer reg. datos";
            this.btn_primero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_primero.ToolTipText = "Primer reg. datos";
            // 
            // btn_anterior
            // 
            this.btn_anterior.AutoSize = false;
            this.btn_anterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_anterior.Enabled = false;
            this.btn_anterior.Image = global::MISAP.Properties.Resources.DATAprevious;
            this.btn_anterior.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_anterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(29, 44);
            this.btn_anterior.Text = "Registro de datos anterior";
            this.btn_anterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_anterior.ToolTipText = "Registro de datos anterior";
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.AutoSize = false;
            this.btn_siguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_siguiente.Enabled = false;
            this.btn_siguiente.Image = global::MISAP.Properties.Resources.DATAnext;
            this.btn_siguiente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_siguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(29, 44);
            this.btn_siguiente.Text = "Registro de datos siguiente";
            this.btn_siguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_siguiente.ToolTipText = "Registro de datos siguiente";
            // 
            // btn_utlimo
            // 
            this.btn_utlimo.AutoSize = false;
            this.btn_utlimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_utlimo.Enabled = false;
            this.btn_utlimo.Image = global::MISAP.Properties.Resources.DATAlast;
            this.btn_utlimo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_utlimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_utlimo.Name = "btn_utlimo";
            this.btn_utlimo.Size = new System.Drawing.Size(29, 44);
            this.btn_utlimo.Text = "Ultimo reg. datos";
            this.btn_utlimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_utlimo.ToolTipText = "Ultimo reg. datos";
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
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_todos.Location = new System.Drawing.Point(63, 153);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(12, 11);
            this.chk_todos.TabIndex = 309;
            this.chk_todos.UseVisualStyleBackColor = true;
            this.chk_todos.Visible = false;
            this.chk_todos.CheckedChanged += new System.EventHandler(this.chk_todos_CheckedChanged);
            // 
            // txt_correlativo
            // 
            this.txt_correlativo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_correlativo.Location = new System.Drawing.Point(312, 124);
            this.txt_correlativo.Multiline = true;
            this.txt_correlativo.Name = "txt_correlativo";
            this.txt_correlativo.Size = new System.Drawing.Size(67, 19);
            this.txt_correlativo.TabIndex = 310;
            this.txt_correlativo.Visible = false;
            // 
            // lbl_total_1
            // 
            this.lbl_total_1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_1.Location = new System.Drawing.Point(189, 401);
            this.lbl_total_1.Name = "lbl_total_1";
            this.lbl_total_1.Size = new System.Drawing.Size(80, 14);
            this.lbl_total_1.TabIndex = 311;
            this.lbl_total_1.Text = "Total";
            this.lbl_total_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_total_1
            // 
            this.txt_total_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total_1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_total_1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.txt_total_1.Location = new System.Drawing.Point(192, 415);
            this.txt_total_1.Margin = new System.Windows.Forms.Padding(0);
            this.txt_total_1.MaxLength = 25;
            this.txt_total_1.Name = "txt_total_1";
            this.txt_total_1.ReadOnly = true;
            this.txt_total_1.Size = new System.Drawing.Size(77, 22);
            this.txt_total_1.TabIndex = 312;
            this.txt_total_1.Tag = "ingrese";
            this.txt_total_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_total_2
            // 
            this.txt_total_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total_2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_total_2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_2.Location = new System.Drawing.Point(289, 415);
            this.txt_total_2.Margin = new System.Windows.Forms.Padding(0);
            this.txt_total_2.MaxLength = 25;
            this.txt_total_2.Name = "txt_total_2";
            this.txt_total_2.ReadOnly = true;
            this.txt_total_2.Size = new System.Drawing.Size(77, 22);
            this.txt_total_2.TabIndex = 314;
            this.txt_total_2.Tag = "ingrese";
            this.txt_total_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_total_2
            // 
            this.lbl_total_2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_2.Location = new System.Drawing.Point(286, 401);
            this.lbl_total_2.Name = "lbl_total_2";
            this.lbl_total_2.Size = new System.Drawing.Size(92, 14);
            this.lbl_total_2.TabIndex = 313;
            this.lbl_total_2.Text = "Total";
            this.lbl_total_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmExtractoBancario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 456);
            this.ControlBox = false;
            this.Controls.Add(this.txt_total_2);
            this.Controls.Add(this.lbl_total_2);
            this.Controls.Add(this.txt_total_1);
            this.Controls.Add(this.lbl_total_1);
            this.Controls.Add(this.txt_correlativo);
            this.Controls.Add(this.chk_todos);
            this.Controls.Add(this.ts_acciones);
            this.Controls.Add(this.txt_num_estado);
            this.Controls.Add(this.lbl_num_estado);
            this.Controls.Add(this.btn_configuracion);
            this.Controls.Add(this.txt_CodigoBanco);
            this.Controls.Add(this.btn_opciones_b);
            this.Controls.Add(this.txt_banco);
            this.Controls.Add(this.lbl_banco);
            this.Controls.Add(this.lb_hoja);
            this.Controls.Add(this.txt_hoja);
            this.Controls.Add(this.txt_archivo);
            this.Controls.Add(this.btn_cargar_archivo);
            this.Controls.Add(this.btn_opciones);
            this.Controls.Add(this.lbl_cuenta);
            this.Controls.Add(this.txt_cuenta);
            this.Controls.Add(this.dgv_extracto);
            this.Controls.Add(this.lbl_nombre_cuenta);
            this.Controls.Add(this.ss_load);
            this.Controls.Add(this.btn_grabar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.dgv_columnas);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmExtractoBancario";
            this.Load += new System.EventHandler(this.FrmExtractoBancario_Load);
            this.ss_load.ResumeLayout(false);
            this.ss_load.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_extracto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_columnas)).EndInit();
            this.titulo.ResumeLayout(false);
            this.titulo.PerformLayout();
            this.ts_acciones.ResumeLayout(false);
            this.ts_acciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip titulo;
        private System.Windows.Forms.ToolStripLabel tsl_titulo;
        private System.Windows.Forms.ToolStripButton salir;
        private System.Windows.Forms.ToolStripButton maximizar;
        private System.Windows.Forms.ToolStripButton ninimizar;
        private System.Windows.Forms.Button btn_grabar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.StatusStrip ss_load;
        private System.Windows.Forms.ToolStripStatusLabel lbl_contador_registros;
        private System.Windows.Forms.ToolStripStatusLabel lbl_U_CL_CODSOL;
        private System.Windows.Forms.ToolStripStatusLabel lbl_U_CL_SOLICI;
        private System.Windows.Forms.ToolStripStatusLabel lbl_msg;
        private System.Windows.Forms.ToolStripStatusLabel lbl_maximi;
        private System.Windows.Forms.Timer t_msg;
        private System.Windows.Forms.Label lbl_nombre_cuenta;
        private System.Windows.Forms.DataGridView dgv_extracto;
        private System.Windows.Forms.Label lbl_cuenta;
        private System.Windows.Forms.TextBox txt_cuenta;
        private System.Windows.Forms.Button btn_opciones;
        private System.Windows.Forms.Button btn_cargar_archivo;
        private System.Windows.Forms.TextBox txt_archivo;
        private System.Windows.Forms.TextBox txt_hoja;
        private System.Windows.Forms.ListBox lb_hoja;
        private System.Windows.Forms.Label lbl_banco;
        private System.Windows.Forms.TextBox txt_banco;
        private System.Windows.Forms.Button btn_opciones_b;
        private System.Windows.Forms.TextBox txt_CodigoBanco;
        private System.Windows.Forms.DataGridView dgv_columnas;
        private System.Windows.Forms.Button btn_configuracion;
        private System.Windows.Forms.TextBox txt_num_estado;
        private System.Windows.Forms.Label lbl_num_estado;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccion;
        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.TextBox txt_correlativo;
        private System.Windows.Forms.Label lbl_total_1;
        private System.Windows.Forms.TextBox txt_total_1;
        private System.Windows.Forms.TextBox txt_total_2;
        private System.Windows.Forms.Label lbl_total_2;
    }
}