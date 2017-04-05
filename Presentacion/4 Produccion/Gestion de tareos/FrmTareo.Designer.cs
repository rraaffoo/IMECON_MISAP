namespace MISAP
{
    partial class FrmTareo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTareo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cm_grilla = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cm_grilla_copia = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_grilla_copia_tabla = new System.Windows.Forms.ToolStripMenuItem();
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
            this.t_msg = new System.Windows.Forms.Timer(this.components);
            this.l_usuario = new System.Windows.Forms.Label();
            this.l_dni = new System.Windows.Forms.Label();
            this.lbl_contador_registros = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_CODSOL = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_SOLICI = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_msg = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_maximi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_dni = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_load = new System.Windows.Forms.StatusStrip();
            this.BW = new System.ComponentModel.BackgroundWorker();
            this.BW_reg = new System.ComponentModel.BackgroundWorker();
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_usr_crea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tp_actividades = new System.Windows.Forms.TabPage();
            this.grp_actividad_nuevo = new System.Windows.Forms.GroupBox();
            this.txt_actividad_nuevo = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.lbl_actividad = new System.Windows.Forms.Label();
            this.cbo_proceso = new System.Windows.Forms.ComboBox();
            this.tp_edt = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.grp_edt_nuevo = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_edt_nuevo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cbo_num_ord_edt = new System.Windows.Forms.ComboBox();
            this.tp_tareo = new System.Windows.Forms.TabPage();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.txt16 = new System.Windows.Forms.TextBox();
            this.btnAnular_reg = new System.Windows.Forms.Button();
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
            this.txtact = new System.Windows.Forms.TextBox();
            this.txtproc = new System.Windows.Forms.TextBox();
            this.txtFechaFin_reg = new System.Windows.Forms.TextBox();
            this.txtFechaIni_reg = new System.Windows.Forms.TextBox();
            this.cboSemana_reg = new System.Windows.Forms.ComboBox();
            this.cboAnio_reg = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnIngMasivo = new System.Windows.Forms.Button();
            this.btnModMasiva = new System.Windows.Forms.Button();
            this.btnRevisar_reg = new System.Windows.Forms.Button();
            this.btnAgregar_reg = new System.Windows.Forms.Button();
            this.grp_tareo = new System.Windows.Forms.GroupBox();
            this.cboOt_reg = new System.Windows.Forms.ComboBox();
            this.cboTurno_reg = new System.Windows.Forms.ComboBox();
            this.dtpFecha_reg = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cboPersonal_reg = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboTipo_reg = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboEdt_reg = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboActividad_reg = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtHn = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cboFalta_reg = new System.Windows.Forms.ComboBox();
            this.txtHe = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTareo = new System.Windows.Forms.DataGridView();
            this.tc_tareo = new System.Windows.Forms.TabControl();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.ToolStrip();
            this.tsl_titulo = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.maximizar = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            this.lblTotalTar = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblTotalHE = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblTotalHN = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cm_grilla.SuspendLayout();
            this.ts_acciones.SuspendLayout();
            this.ss_load.SuspendLayout();
            this.tp_auditoria.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tp_actividades.SuspendLayout();
            this.grp_actividad_nuevo.SuspendLayout();
            this.tp_edt.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.grp_edt_nuevo.SuspendLayout();
            this.tp_tareo.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grp_tareo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareo)).BeginInit();
            this.tc_tareo.SuspendLayout();
            this.titulo.SuspendLayout();
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
            this.ts_acciones.Size = new System.Drawing.Size(1163, 48);
            this.ts_acciones.TabIndex = 227;
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
            this.btn_exportar_xls.Click += new System.EventHandler(this.btn_exportar_xls_Click);
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
            this.l_dni.Location = new System.Drawing.Point(431, 603);
            this.l_dni.Name = "l_dni";
            this.l_dni.Size = new System.Drawing.Size(61, 13);
            this.l_dni.TabIndex = 284;
            this.l_dni.Text = "                  ";
            this.l_dni.Visible = false;
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
            this.ss_load.Location = new System.Drawing.Point(0, 634);
            this.ss_load.Name = "ss_load";
            this.ss_load.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ss_load.Size = new System.Drawing.Size(1163, 18);
            this.ss_load.SizingGrip = false;
            this.ss_load.TabIndex = 278;
            this.ss_load.Text = "statusStrip1";
            // 
            // BW_reg
            // 
            this.BW_reg.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_reg_DoWork);
            this.BW_reg.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BW_reg_RunWorkerCompleted);
            // 
            // tp_auditoria
            // 
            this.tp_auditoria.Controls.Add(this.groupBox1);
            this.tp_auditoria.Location = new System.Drawing.Point(4, 23);
            this.tp_auditoria.Name = "tp_auditoria";
            this.tp_auditoria.Padding = new System.Windows.Forms.Padding(3);
            this.tp_auditoria.Size = new System.Drawing.Size(1137, 492);
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
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_usr_crea);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(997, 127);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // txt_tipodoc
            // 
            this.txt_tipodoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tipodoc.Location = new System.Drawing.Point(706, 40);
            this.txt_tipodoc.Name = "txt_tipodoc";
            this.txt_tipodoc.ReadOnly = true;
            this.txt_tipodoc.Size = new System.Drawing.Size(100, 20);
            this.txt_tipodoc.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(585, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 14);
            this.label12.TabIndex = 20;
            this.label12.Text = "Tipo de Documento :";
            // 
            // txt_formulario
            // 
            this.txt_formulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_formulario.Location = new System.Drawing.Point(706, 13);
            this.txt_formulario.Name = "txt_formulario";
            this.txt_formulario.ReadOnly = true;
            this.txt_formulario.Size = new System.Drawing.Size(100, 20);
            this.txt_formulario.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(585, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 14);
            this.label13.TabIndex = 18;
            this.label13.Text = "Formulario :";
            // 
            // txt_fec_modi
            // 
            this.txt_fec_modi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fec_modi.Location = new System.Drawing.Point(418, 17);
            this.txt_fec_modi.Name = "txt_fec_modi";
            this.txt_fec_modi.ReadOnly = true;
            this.txt_fec_modi.Size = new System.Drawing.Size(149, 20);
            this.txt_fec_modi.TabIndex = 15;
            // 
            // txt_terminal_modi
            // 
            this.txt_terminal_modi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_terminal_modi.Location = new System.Drawing.Point(418, 43);
            this.txt_terminal_modi.Name = "txt_terminal_modi";
            this.txt_terminal_modi.ReadOnly = true;
            this.txt_terminal_modi.Size = new System.Drawing.Size(149, 20);
            this.txt_terminal_modi.TabIndex = 17;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(302, 20);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(106, 14);
            this.label33.TabIndex = 12;
            this.label33.Text = "Fecha Modificacion :";
            // 
            // txt_usr_modi
            // 
            this.txt_usr_modi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usr_modi.Location = new System.Drawing.Point(132, 97);
            this.txt_usr_modi.Name = "txt_usr_modi";
            this.txt_usr_modi.ReadOnly = true;
            this.txt_usr_modi.Size = new System.Drawing.Size(149, 20);
            this.txt_usr_modi.TabIndex = 16;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(22, 100);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(113, 14);
            this.label34.TabIndex = 13;
            this.label34.Text = "Usuario Modificacion :";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(301, 46);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(115, 14);
            this.label35.TabIndex = 14;
            this.label35.Text = "Terminal Modificacion :";
            // 
            // txt_estado_registro
            // 
            this.txt_estado_registro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_estado_registro.Location = new System.Drawing.Point(418, 95);
            this.txt_estado_registro.Name = "txt_estado_registro";
            this.txt_estado_registro.ReadOnly = true;
            this.txt_estado_registro.Size = new System.Drawing.Size(149, 20);
            this.txt_estado_registro.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "Estado :";
            // 
            // txt_operacion
            // 
            this.txt_operacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_operacion.Location = new System.Drawing.Point(418, 69);
            this.txt_operacion.Name = "txt_operacion";
            this.txt_operacion.ReadOnly = true;
            this.txt_operacion.Size = new System.Drawing.Size(149, 20);
            this.txt_operacion.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Operacion :";
            // 
            // txt_fec_crea
            // 
            this.txt_fec_crea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fec_crea.Location = new System.Drawing.Point(132, 45);
            this.txt_fec_crea.Name = "txt_fec_crea";
            this.txt_fec_crea.ReadOnly = true;
            this.txt_fec_crea.Size = new System.Drawing.Size(149, 20);
            this.txt_fec_crea.TabIndex = 3;
            // 
            // txt_terminal_crea
            // 
            this.txt_terminal_crea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_terminal_crea.Location = new System.Drawing.Point(132, 71);
            this.txt_terminal_crea.Name = "txt_terminal_crea";
            this.txt_terminal_crea.ReadOnly = true;
            this.txt_terminal_crea.Size = new System.Drawing.Size(149, 20);
            this.txt_terminal_crea.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de Creacion :";
            // 
            // txt_usr_crea
            // 
            this.txt_usr_crea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usr_crea.Location = new System.Drawing.Point(132, 20);
            this.txt_usr_crea.Name = "txt_usr_crea";
            this.txt_usr_crea.ReadOnly = true;
            this.txt_usr_crea.Size = new System.Drawing.Size(149, 20);
            this.txt_usr_crea.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Usuario Creacion :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Terminal Creacion :";
            // 
            // tp_actividades
            // 
            this.tp_actividades.Controls.Add(this.grp_actividad_nuevo);
            this.tp_actividades.Location = new System.Drawing.Point(4, 23);
            this.tp_actividades.Name = "tp_actividades";
            this.tp_actividades.Size = new System.Drawing.Size(1137, 492);
            this.tp_actividades.TabIndex = 4;
            this.tp_actividades.Text = "Actividades";
            // 
            // grp_actividad_nuevo
            // 
            this.grp_actividad_nuevo.Controls.Add(this.txt_actividad_nuevo);
            this.grp_actividad_nuevo.Controls.Add(this.label30);
            this.grp_actividad_nuevo.Controls.Add(this.lbl_actividad);
            this.grp_actividad_nuevo.Controls.Add(this.cbo_proceso);
            this.grp_actividad_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grp_actividad_nuevo.Location = new System.Drawing.Point(14, 15);
            this.grp_actividad_nuevo.Name = "grp_actividad_nuevo";
            this.grp_actividad_nuevo.Size = new System.Drawing.Size(439, 100);
            this.grp_actividad_nuevo.TabIndex = 221;
            this.grp_actividad_nuevo.TabStop = false;
            this.grp_actividad_nuevo.Text = "Nueva actividad";
            // 
            // txt_actividad_nuevo
            // 
            this.txt_actividad_nuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_actividad_nuevo.Location = new System.Drawing.Point(80, 54);
            this.txt_actividad_nuevo.Name = "txt_actividad_nuevo";
            this.txt_actividad_nuevo.Size = new System.Drawing.Size(341, 20);
            this.txt_actividad_nuevo.TabIndex = 219;
            this.txt_actividad_nuevo.TextChanged += new System.EventHandler(this.txt_actividad_nuevo_TextChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(13, 34);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(47, 14);
            this.label30.TabIndex = 216;
            this.label30.Text = "Proceso";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_actividad
            // 
            this.lbl_actividad.AutoSize = true;
            this.lbl_actividad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actividad.Location = new System.Drawing.Point(13, 60);
            this.lbl_actividad.Name = "lbl_actividad";
            this.lbl_actividad.Size = new System.Drawing.Size(52, 14);
            this.lbl_actividad.TabIndex = 218;
            this.lbl_actividad.Text = "Actividad";
            this.lbl_actividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbo_proceso
            // 
            this.cbo_proceso.BackColor = System.Drawing.Color.White;
            this.cbo_proceso.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_proceso.FormattingEnabled = true;
            this.cbo_proceso.ItemHeight = 14;
            this.cbo_proceso.Location = new System.Drawing.Point(80, 26);
            this.cbo_proceso.Name = "cbo_proceso";
            this.cbo_proceso.Size = new System.Drawing.Size(100, 22);
            this.cbo_proceso.TabIndex = 217;
            // 
            // tp_edt
            // 
            this.tp_edt.Controls.Add(this.groupBox5);
            this.tp_edt.Controls.Add(this.grp_edt_nuevo);
            this.tp_edt.Location = new System.Drawing.Point(4, 23);
            this.tp_edt.Name = "tp_edt";
            this.tp_edt.Size = new System.Drawing.Size(1137, 492);
            this.tp_edt.TabIndex = 3;
            this.tp_edt.Text = "EDTs";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView3);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Location = new System.Drawing.Point(36, 159);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(333, 283);
            this.groupBox5.TabIndex = 222;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "EDTs registradas";
            this.groupBox5.Visible = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn3});
            this.dataGridView3.ContextMenuStrip = this.cm_grilla;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.Location = new System.Drawing.Point(9, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView3.Size = new System.Drawing.Size(312, 225);
            this.dataGridView3.TabIndex = 260;
            this.dataGridView3.Visible = false;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn3.Frozen = true;
            this.dataGridViewCheckBoxColumn3.HeaderText = "";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Width = 25;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackgroundImage = global::MISAP.Properties.Resources.btn_enfasis_dasactivado;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(234, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 21);
            this.button2.TabIndex = 279;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // grp_edt_nuevo
            // 
            this.grp_edt_nuevo.Controls.Add(this.button1);
            this.grp_edt_nuevo.Controls.Add(this.txt_edt_nuevo);
            this.grp_edt_nuevo.Controls.Add(this.label22);
            this.grp_edt_nuevo.Controls.Add(this.label23);
            this.grp_edt_nuevo.Controls.Add(this.cbo_num_ord_edt);
            this.grp_edt_nuevo.Location = new System.Drawing.Point(36, 20);
            this.grp_edt_nuevo.Name = "grp_edt_nuevo";
            this.grp_edt_nuevo.Size = new System.Drawing.Size(333, 133);
            this.grp_edt_nuevo.TabIndex = 220;
            this.grp_edt_nuevo.TabStop = false;
            this.grp_edt_nuevo.Text = "Nuevo EDT";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackgroundImage = global::MISAP.Properties.Resources.btn_enfasis_dasactivado;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(234, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 21);
            this.button1.TabIndex = 281;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_edt_nuevo
            // 
            this.txt_edt_nuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_edt_nuevo.Location = new System.Drawing.Point(93, 46);
            this.txt_edt_nuevo.Multiline = true;
            this.txt_edt_nuevo.Name = "txt_edt_nuevo";
            this.txt_edt_nuevo.Size = new System.Drawing.Size(228, 48);
            this.txt_edt_nuevo.TabIndex = 219;
            this.txt_edt_nuevo.TextChanged += new System.EventHandler(this.txt_edt_nuevo_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(13, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 14);
            this.label22.TabIndex = 216;
            this.label22.Text = "Nº OT";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(13, 50);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(26, 14);
            this.label23.TabIndex = 218;
            this.label23.Text = "EDT";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbo_num_ord_edt
            // 
            this.cbo_num_ord_edt.BackColor = System.Drawing.Color.White;
            this.cbo_num_ord_edt.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_num_ord_edt.FormattingEnabled = true;
            this.cbo_num_ord_edt.ItemHeight = 14;
            this.cbo_num_ord_edt.Location = new System.Drawing.Point(93, 18);
            this.cbo_num_ord_edt.Name = "cbo_num_ord_edt";
            this.cbo_num_ord_edt.Size = new System.Drawing.Size(228, 22);
            this.cbo_num_ord_edt.TabIndex = 217;
            // 
            // tp_tareo
            // 
            this.tp_tareo.Controls.Add(this.lbl_buscar);
            this.tp_tareo.Controls.Add(this.txt_buscar);
            this.tp_tareo.Controls.Add(this.txt16);
            this.tp_tareo.Controls.Add(this.btnAnular_reg);
            this.tp_tareo.Controls.Add(this.txt17);
            this.tp_tareo.Controls.Add(this.txt15);
            this.tp_tareo.Controls.Add(this.txt13);
            this.tp_tareo.Controls.Add(this.txt14);
            this.tp_tareo.Controls.Add(this.txt12);
            this.tp_tareo.Controls.Add(this.txt6);
            this.tp_tareo.Controls.Add(this.txt4);
            this.tp_tareo.Controls.Add(this.txt8);
            this.tp_tareo.Controls.Add(this.txt10);
            this.tp_tareo.Controls.Add(this.txt11);
            this.tp_tareo.Controls.Add(this.txt9);
            this.tp_tareo.Controls.Add(this.txt7);
            this.tp_tareo.Controls.Add(this.txt5);
            this.tp_tareo.Controls.Add(this.txt3);
            this.tp_tareo.Controls.Add(this.txt2);
            this.tp_tareo.Controls.Add(this.txt1);
            this.tp_tareo.Controls.Add(this.txtact);
            this.tp_tareo.Controls.Add(this.txtproc);
            this.tp_tareo.Controls.Add(this.txtFechaFin_reg);
            this.tp_tareo.Controls.Add(this.txtFechaIni_reg);
            this.tp_tareo.Controls.Add(this.cboSemana_reg);
            this.tp_tareo.Controls.Add(this.cboAnio_reg);
            this.tp_tareo.Controls.Add(this.groupBox4);
            this.tp_tareo.Controls.Add(this.grp_tareo);
            this.tp_tareo.Controls.Add(this.label21);
            this.tp_tareo.Controls.Add(this.label20);
            this.tp_tareo.Controls.Add(this.label5);
            this.tp_tareo.Controls.Add(this.label1);
            this.tp_tareo.Controls.Add(this.dgvTareo);
            this.tp_tareo.Location = new System.Drawing.Point(4, 23);
            this.tp_tareo.Name = "tp_tareo";
            this.tp_tareo.Padding = new System.Windows.Forms.Padding(3);
            this.tp_tareo.Size = new System.Drawing.Size(1137, 492);
            this.tp_tareo.TabIndex = 0;
            this.tp_tareo.Text = "Registrar Tareo";
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(515, 14);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(42, 14);
            this.lbl_buscar.TabIndex = 290;
            this.lbl_buscar.Text = "Buscar";
            this.lbl_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_buscar
            // 
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscar.Enabled = false;
            this.txt_buscar.Location = new System.Drawing.Point(518, 30);
            this.txt_buscar.MaxLength = 100;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(162, 20);
            this.txt_buscar.TabIndex = 268;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // txt16
            // 
            this.txt16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt16.Location = new System.Drawing.Point(893, 424);
            this.txt16.Name = "txt16";
            this.txt16.Size = new System.Drawing.Size(53, 20);
            this.txt16.TabIndex = 289;
            this.txt16.Visible = false;
            // 
            // btnAnular_reg
            // 
            this.btnAnular_reg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnular_reg.BackgroundImage = global::MISAP.Properties.Resources.btn_enfasis;
            this.btnAnular_reg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnular_reg.FlatAppearance.BorderSize = 0;
            this.btnAnular_reg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAnular_reg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAnular_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular_reg.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular_reg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAnular_reg.Location = new System.Drawing.Point(905, 4);
            this.btnAnular_reg.Name = "btnAnular_reg";
            this.btnAnular_reg.Size = new System.Drawing.Size(73, 18);
            this.btnAnular_reg.TabIndex = 14;
            this.btnAnular_reg.Text = "Anular";
            this.btnAnular_reg.UseVisualStyleBackColor = true;
            this.btnAnular_reg.Visible = false;
            this.btnAnular_reg.Click += new System.EventHandler(this.btnAnular_reg_Click);
            // 
            // txt17
            // 
            this.txt17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt17.Location = new System.Drawing.Point(952, 424);
            this.txt17.Name = "txt17";
            this.txt17.Size = new System.Drawing.Size(52, 20);
            this.txt17.TabIndex = 288;
            this.txt17.Visible = false;
            // 
            // txt15
            // 
            this.txt15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt15.Location = new System.Drawing.Point(834, 424);
            this.txt15.Name = "txt15";
            this.txt15.Size = new System.Drawing.Size(53, 20);
            this.txt15.TabIndex = 287;
            this.txt15.Visible = false;
            // 
            // txt13
            // 
            this.txt13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt13.Location = new System.Drawing.Point(717, 424);
            this.txt13.Name = "txt13";
            this.txt13.Size = new System.Drawing.Size(53, 20);
            this.txt13.TabIndex = 286;
            this.txt13.Visible = false;
            // 
            // txt14
            // 
            this.txt14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt14.Location = new System.Drawing.Point(776, 424);
            this.txt14.Name = "txt14";
            this.txt14.Size = new System.Drawing.Size(52, 20);
            this.txt14.TabIndex = 285;
            this.txt14.Visible = false;
            // 
            // txt12
            // 
            this.txt12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt12.Location = new System.Drawing.Point(658, 424);
            this.txt12.Name = "txt12";
            this.txt12.Size = new System.Drawing.Size(53, 20);
            this.txt12.TabIndex = 284;
            this.txt12.Visible = false;
            // 
            // txt6
            // 
            this.txt6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt6.Location = new System.Drawing.Point(307, 424);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(53, 20);
            this.txt6.TabIndex = 276;
            this.txt6.Visible = false;
            // 
            // txt4
            // 
            this.txt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt4.Location = new System.Drawing.Point(190, 424);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(52, 20);
            this.txt4.TabIndex = 283;
            this.txt4.Visible = false;
            // 
            // txt8
            // 
            this.txt8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt8.Location = new System.Drawing.Point(424, 424);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(52, 20);
            this.txt8.TabIndex = 275;
            this.txt8.Visible = false;
            // 
            // txt10
            // 
            this.txt10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt10.Location = new System.Drawing.Point(541, 424);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(53, 20);
            this.txt10.TabIndex = 274;
            this.txt10.Visible = false;
            // 
            // txt11
            // 
            this.txt11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt11.Location = new System.Drawing.Point(600, 424);
            this.txt11.Name = "txt11";
            this.txt11.Size = new System.Drawing.Size(52, 20);
            this.txt11.TabIndex = 273;
            this.txt11.Visible = false;
            // 
            // txt9
            // 
            this.txt9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt9.Location = new System.Drawing.Point(482, 424);
            this.txt9.Name = "txt9";
            this.txt9.Size = new System.Drawing.Size(53, 20);
            this.txt9.TabIndex = 272;
            this.txt9.Visible = false;
            // 
            // txt7
            // 
            this.txt7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt7.Location = new System.Drawing.Point(366, 424);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(52, 20);
            this.txt7.TabIndex = 271;
            this.txt7.Visible = false;
            // 
            // txt5
            // 
            this.txt5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt5.Location = new System.Drawing.Point(248, 424);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(53, 20);
            this.txt5.TabIndex = 270;
            this.txt5.Visible = false;
            // 
            // txt3
            // 
            this.txt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt3.Location = new System.Drawing.Point(127, 424);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(52, 20);
            this.txt3.TabIndex = 269;
            this.txt3.Visible = false;
            // 
            // txt2
            // 
            this.txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2.Location = new System.Drawing.Point(68, 424);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(53, 20);
            this.txt2.TabIndex = 268;
            this.txt2.Visible = false;
            // 
            // txt1
            // 
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt1.Location = new System.Drawing.Point(10, 424);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(52, 20);
            this.txt1.TabIndex = 267;
            this.txt1.Visible = false;
            // 
            // txtact
            // 
            this.txtact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtact.Location = new System.Drawing.Point(893, 398);
            this.txtact.Name = "txtact";
            this.txtact.Size = new System.Drawing.Size(111, 20);
            this.txtact.TabIndex = 266;
            this.txtact.Visible = false;
            // 
            // txtproc
            // 
            this.txtproc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproc.Location = new System.Drawing.Point(776, 398);
            this.txtproc.Name = "txtproc";
            this.txtproc.Size = new System.Drawing.Size(111, 20);
            this.txtproc.TabIndex = 265;
            this.txtproc.Visible = false;
            // 
            // txtFechaFin_reg
            // 
            this.txtFechaFin_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaFin_reg.Location = new System.Drawing.Point(323, 30);
            this.txtFechaFin_reg.Name = "txtFechaFin_reg";
            this.txtFechaFin_reg.ReadOnly = true;
            this.txtFechaFin_reg.Size = new System.Drawing.Size(82, 20);
            this.txtFechaFin_reg.TabIndex = 246;
            this.txtFechaFin_reg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFechaIni_reg
            // 
            this.txtFechaIni_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaIni_reg.Location = new System.Drawing.Point(220, 30);
            this.txtFechaIni_reg.Name = "txtFechaIni_reg";
            this.txtFechaIni_reg.ReadOnly = true;
            this.txtFechaIni_reg.Size = new System.Drawing.Size(81, 20);
            this.txtFechaIni_reg.TabIndex = 244;
            this.txtFechaIni_reg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboSemana_reg
            // 
            this.cboSemana_reg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboSemana_reg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSemana_reg.FormattingEnabled = true;
            this.cboSemana_reg.Location = new System.Drawing.Point(127, 29);
            this.cboSemana_reg.Name = "cboSemana_reg";
            this.cboSemana_reg.Size = new System.Drawing.Size(72, 21);
            this.cboSemana_reg.TabIndex = 263;
            this.cboSemana_reg.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbo_semana_DrawItem);
            this.cboSemana_reg.SelectionChangeCommitted += new System.EventHandler(this.cboSemana_reg_SelectionChangeCommitted);
            this.cboSemana_reg.Enter += new System.EventHandler(this.cbo_semana_Enter);
            this.cboSemana_reg.Leave += new System.EventHandler(this.cbo_semana_Leave);
            // 
            // cboAnio_reg
            // 
            this.cboAnio_reg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboAnio_reg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnio_reg.FormattingEnabled = true;
            this.cboAnio_reg.Location = new System.Drawing.Point(38, 29);
            this.cboAnio_reg.Name = "cboAnio_reg";
            this.cboAnio_reg.Size = new System.Drawing.Size(72, 21);
            this.cboAnio_reg.TabIndex = 262;
            this.cboAnio_reg.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbo_anio_DrawItem);
            this.cboAnio_reg.SelectionChangeCommitted += new System.EventHandler(this.cboAnio_reg_SelectionChangeCommitted);
            this.cboAnio_reg.Enter += new System.EventHandler(this.cbo_anio_Enter);
            this.cboAnio_reg.Leave += new System.EventHandler(this.cbo_anio_Leave);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnIngMasivo);
            this.groupBox4.Controls.Add(this.btnModMasiva);
            this.groupBox4.Controls.Add(this.btnRevisar_reg);
            this.groupBox4.Controls.Add(this.btnAgregar_reg);
            this.groupBox4.Location = new System.Drawing.Point(796, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(335, 37);
            this.groupBox4.TabIndex = 261;
            this.groupBox4.TabStop = false;
            // 
            // btnIngMasivo
            // 
            this.btnIngMasivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngMasivo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIngMasivo.BackgroundImage")));
            this.btnIngMasivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIngMasivo.Enabled = false;
            this.btnIngMasivo.FlatAppearance.BorderSize = 0;
            this.btnIngMasivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIngMasivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIngMasivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngMasivo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngMasivo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIngMasivo.Location = new System.Drawing.Point(171, 10);
            this.btnIngMasivo.Name = "btnIngMasivo";
            this.btnIngMasivo.Size = new System.Drawing.Size(73, 22);
            this.btnIngMasivo.TabIndex = 17;
            this.btnIngMasivo.Text = "Reg Masivo";
            this.btnIngMasivo.UseVisualStyleBackColor = true;
            this.btnIngMasivo.Click += new System.EventHandler(this.btnIngMasivo_Click);
            // 
            // btnModMasiva
            // 
            this.btnModMasiva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModMasiva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModMasiva.BackgroundImage")));
            this.btnModMasiva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModMasiva.Enabled = false;
            this.btnModMasiva.FlatAppearance.BorderSize = 0;
            this.btnModMasiva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModMasiva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModMasiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModMasiva.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModMasiva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModMasiva.Location = new System.Drawing.Point(251, 10);
            this.btnModMasiva.Name = "btnModMasiva";
            this.btnModMasiva.Size = new System.Drawing.Size(73, 22);
            this.btnModMasiva.TabIndex = 16;
            this.btnModMasiva.Text = "Mod Masiva";
            this.btnModMasiva.UseVisualStyleBackColor = true;
            this.btnModMasiva.Click += new System.EventHandler(this.btnModMasiva_Click);
            // 
            // btnRevisar_reg
            // 
            this.btnRevisar_reg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRevisar_reg.BackgroundImage = global::MISAP.Properties.Resources.btn_enfasis;
            this.btnRevisar_reg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRevisar_reg.FlatAppearance.BorderSize = 0;
            this.btnRevisar_reg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRevisar_reg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRevisar_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevisar_reg.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevisar_reg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRevisar_reg.Location = new System.Drawing.Point(91, 10);
            this.btnRevisar_reg.Name = "btnRevisar_reg";
            this.btnRevisar_reg.Size = new System.Drawing.Size(73, 22);
            this.btnRevisar_reg.TabIndex = 15;
            this.btnRevisar_reg.Text = "Revisar";
            this.btnRevisar_reg.UseVisualStyleBackColor = true;
            this.btnRevisar_reg.Click += new System.EventHandler(this.btnRevisar_reg_Click);
            // 
            // btnAgregar_reg
            // 
            this.btnAgregar_reg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar_reg.BackgroundImage = global::MISAP.Properties.Resources.btn_enfasis;
            this.btnAgregar_reg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar_reg.FlatAppearance.BorderSize = 0;
            this.btnAgregar_reg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar_reg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar_reg.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar_reg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAgregar_reg.Location = new System.Drawing.Point(11, 10);
            this.btnAgregar_reg.Name = "btnAgregar_reg";
            this.btnAgregar_reg.Size = new System.Drawing.Size(73, 22);
            this.btnAgregar_reg.TabIndex = 12;
            this.btnAgregar_reg.Text = "Agregar";
            this.btnAgregar_reg.UseVisualStyleBackColor = true;
            this.btnAgregar_reg.Click += new System.EventHandler(this.btnAgregar_reg_Click);
            // 
            // grp_tareo
            // 
            this.grp_tareo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_tareo.Controls.Add(this.cboOt_reg);
            this.grp_tareo.Controls.Add(this.cboTurno_reg);
            this.grp_tareo.Controls.Add(this.dtpFecha_reg);
            this.grp_tareo.Controls.Add(this.label8);
            this.grp_tareo.Controls.Add(this.cboPersonal_reg);
            this.grp_tareo.Controls.Add(this.label9);
            this.grp_tareo.Controls.Add(this.label10);
            this.grp_tareo.Controls.Add(this.label11);
            this.grp_tareo.Controls.Add(this.cboTipo_reg);
            this.grp_tareo.Controls.Add(this.label14);
            this.grp_tareo.Controls.Add(this.label17);
            this.grp_tareo.Controls.Add(this.label16);
            this.grp_tareo.Controls.Add(this.cboEdt_reg);
            this.grp_tareo.Controls.Add(this.label15);
            this.grp_tareo.Controls.Add(this.cboActividad_reg);
            this.grp_tareo.Controls.Add(this.label18);
            this.grp_tareo.Controls.Add(this.txtHn);
            this.grp_tareo.Controls.Add(this.label19);
            this.grp_tareo.Controls.Add(this.cboFalta_reg);
            this.grp_tareo.Controls.Add(this.txtHe);
            this.grp_tareo.Location = new System.Drawing.Point(10, 55);
            this.grp_tareo.Name = "grp_tareo";
            this.grp_tareo.Size = new System.Drawing.Size(1121, 80);
            this.grp_tareo.TabIndex = 259;
            this.grp_tareo.TabStop = false;
            // 
            // cboOt_reg
            // 
            this.cboOt_reg.BackColor = System.Drawing.Color.White;
            this.cboOt_reg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboOt_reg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOt_reg.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOt_reg.FormattingEnabled = true;
            this.cboOt_reg.ItemHeight = 14;
            this.cboOt_reg.Location = new System.Drawing.Point(481, 46);
            this.cboOt_reg.Name = "cboOt_reg";
            this.cboOt_reg.Size = new System.Drawing.Size(239, 20);
            this.cboOt_reg.TabIndex = 267;
            this.cboOt_reg.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboOt_reg_DrawItem);
            this.cboOt_reg.SelectionChangeCommitted += new System.EventHandler(this.cboOt_reg_SelectionChangeCommitted);
            this.cboOt_reg.Enter += new System.EventHandler(this.cboOt_reg_Enter);
            this.cboOt_reg.Leave += new System.EventHandler(this.cboOt_reg_Leave);
            // 
            // cboTurno_reg
            // 
            this.cboTurno_reg.BackColor = System.Drawing.Color.White;
            this.cboTurno_reg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTurno_reg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurno_reg.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTurno_reg.FormattingEnabled = true;
            this.cboTurno_reg.ItemHeight = 14;
            this.cboTurno_reg.Location = new System.Drawing.Point(47, 48);
            this.cboTurno_reg.Name = "cboTurno_reg";
            this.cboTurno_reg.Size = new System.Drawing.Size(101, 20);
            this.cboTurno_reg.TabIndex = 265;
            this.cboTurno_reg.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbo_turno_DrawItem);
            this.cboTurno_reg.Enter += new System.EventHandler(this.cbo_turno_Enter);
            this.cboTurno_reg.Leave += new System.EventHandler(this.cbo_turno_Leave);
            // 
            // dtpFecha_reg
            // 
            this.dtpFecha_reg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_reg.Location = new System.Drawing.Point(47, 18);
            this.dtpFecha_reg.Name = "dtpFecha_reg";
            this.dtpFecha_reg.Size = new System.Drawing.Size(101, 20);
            this.dtpFecha_reg.TabIndex = 264;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(171, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 14);
            this.label8.TabIndex = 130;
            this.label8.Text = "Falta";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboPersonal_reg
            // 
            this.cboPersonal_reg.BackColor = System.Drawing.Color.White;
            this.cboPersonal_reg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboPersonal_reg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPersonal_reg.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPersonal_reg.FormattingEnabled = true;
            this.cboPersonal_reg.ItemHeight = 14;
            this.cboPersonal_reg.Location = new System.Drawing.Point(481, 20);
            this.cboPersonal_reg.Name = "cboPersonal_reg";
            this.cboPersonal_reg.Size = new System.Drawing.Size(239, 20);
            this.cboPersonal_reg.TabIndex = 6;
            this.cboPersonal_reg.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbo_personal_DrawItem);
            this.cboPersonal_reg.SelectionChangeCommitted += new System.EventHandler(this.cboPersonal_reg_SelectionChangeCommitted);
            this.cboPersonal_reg.Enter += new System.EventHandler(this.cbo_personal_Enter);
            this.cboPersonal_reg.Leave += new System.EventHandler(this.cbo_personal_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 14);
            this.label9.TabIndex = 113;
            this.label9.Text = "Fecha";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 14);
            this.label10.TabIndex = 115;
            this.label10.Text = "Turno";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(174, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 14);
            this.label11.TabIndex = 117;
            this.label11.Text = "Tipo";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTipo_reg
            // 
            this.cboTipo_reg.BackColor = System.Drawing.Color.White;
            this.cboTipo_reg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTipo_reg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo_reg.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo_reg.FormattingEnabled = true;
            this.cboTipo_reg.ItemHeight = 14;
            this.cboTipo_reg.Location = new System.Drawing.Point(210, 20);
            this.cboTipo_reg.Name = "cboTipo_reg";
            this.cboTipo_reg.Size = new System.Drawing.Size(195, 20);
            this.cboTipo_reg.TabIndex = 4;
            this.cboTipo_reg.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbo_tipo_DrawItem);
            this.cboTipo_reg.SelectionChangeCommitted += new System.EventHandler(this.cboTipo_reg_SelectionChangeCommitted);
            this.cboTipo_reg.Enter += new System.EventHandler(this.cbo_tipo_Enter);
            this.cboTipo_reg.Leave += new System.EventHandler(this.cbo_tipo_Leave);
            this.cboTipo_reg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbo_tipo_MouseClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(417, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 14);
            this.label14.TabIndex = 119;
            this.label14.Text = "Personal";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(417, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 14);
            this.label17.TabIndex = 121;
            this.label17.Text = "Nº OT";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(733, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 14);
            this.label16.TabIndex = 123;
            this.label16.Text = "EDT";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboEdt_reg
            // 
            this.cboEdt_reg.BackColor = System.Drawing.Color.White;
            this.cboEdt_reg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboEdt_reg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEdt_reg.Enabled = false;
            this.cboEdt_reg.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEdt_reg.FormattingEnabled = true;
            this.cboEdt_reg.ItemHeight = 14;
            this.cboEdt_reg.Location = new System.Drawing.Point(786, 20);
            this.cboEdt_reg.Name = "cboEdt_reg";
            this.cboEdt_reg.Size = new System.Drawing.Size(192, 20);
            this.cboEdt_reg.TabIndex = 8;
            this.cboEdt_reg.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbo_edt_DrawItem);
            this.cboEdt_reg.Enter += new System.EventHandler(this.cbo_edt_Enter);
            this.cboEdt_reg.Leave += new System.EventHandler(this.cbo_edt_Leave);
            this.cboEdt_reg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbo_edt_MouseClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(733, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 14);
            this.label15.TabIndex = 125;
            this.label15.Text = "Actividad";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboActividad_reg
            // 
            this.cboActividad_reg.BackColor = System.Drawing.Color.White;
            this.cboActividad_reg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboActividad_reg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActividad_reg.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActividad_reg.FormattingEnabled = true;
            this.cboActividad_reg.ItemHeight = 14;
            this.cboActividad_reg.Location = new System.Drawing.Point(786, 46);
            this.cboActividad_reg.Name = "cboActividad_reg";
            this.cboActividad_reg.Size = new System.Drawing.Size(192, 20);
            this.cboActividad_reg.TabIndex = 9;
            this.cboActividad_reg.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbo_actividad_DrawItem);
            this.cboActividad_reg.SelectionChangeCommitted += new System.EventHandler(this.cboActividad_reg_SelectionChangeCommitted);
            this.cboActividad_reg.Enter += new System.EventHandler(this.cbo_actividad_Enter);
            this.cboActividad_reg.Leave += new System.EventHandler(this.cbo_actividad_Leave);
            this.cboActividad_reg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbo_actividad_MouseClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1004, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 14);
            this.label18.TabIndex = 127;
            this.label18.Text = "H. N.";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHn
            // 
            this.txtHn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHn.Location = new System.Drawing.Point(1043, 20);
            this.txtHn.MaxLength = 3;
            this.txtHn.Name = "txtHn";
            this.txtHn.Size = new System.Drawing.Size(35, 20);
            this.txtHn.TabIndex = 10;
            this.txtHn.Text = "0";
            this.txtHn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_hn_MouseClick);
            this.txtHn.TextChanged += new System.EventHandler(this.txtHn_TextChanged);
            this.txtHn.Enter += new System.EventHandler(this.txt_hn_Enter);
            this.txtHn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hn_KeyPress);
            this.txtHn.Leave += new System.EventHandler(this.txt_hn_Leave);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1004, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 14);
            this.label19.TabIndex = 129;
            this.label19.Text = "H. E.";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboFalta_reg
            // 
            this.cboFalta_reg.BackColor = System.Drawing.Color.White;
            this.cboFalta_reg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboFalta_reg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFalta_reg.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFalta_reg.FormattingEnabled = true;
            this.cboFalta_reg.ItemHeight = 14;
            this.cboFalta_reg.Location = new System.Drawing.Point(210, 46);
            this.cboFalta_reg.Name = "cboFalta_reg";
            this.cboFalta_reg.Size = new System.Drawing.Size(195, 20);
            this.cboFalta_reg.TabIndex = 5;
            this.cboFalta_reg.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboFalta_reg_DrawItem);
            this.cboFalta_reg.Enter += new System.EventHandler(this.cboFalta_reg_Enter);
            this.cboFalta_reg.Leave += new System.EventHandler(this.cboFalta_reg_Leave);
            // 
            // txtHe
            // 
            this.txtHe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHe.Location = new System.Drawing.Point(1043, 48);
            this.txtHe.MaxLength = 3;
            this.txtHe.Name = "txtHe";
            this.txtHe.Size = new System.Drawing.Size(35, 20);
            this.txtHe.TabIndex = 11;
            this.txtHe.Text = "0";
            this.txtHe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_he_MouseClick);
            this.txtHe.TextChanged += new System.EventHandler(this.txt_he_TextChanged);
            this.txtHe.Enter += new System.EventHandler(this.txt_he_Enter);
            this.txtHe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHe_KeyPress);
            this.txtHe.Leave += new System.EventHandler(this.txt_he_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(320, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 14);
            this.label21.TabIndex = 245;
            this.label21.Text = "Hasta:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(217, 14);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 14);
            this.label20.TabIndex = 243;
            this.label20.Text = "Desde:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 109;
            this.label5.Text = "Semana";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 14);
            this.label1.TabIndex = 107;
            this.label1.Text = "Año";
            // 
            // dgvTareo
            // 
            this.dgvTareo.AllowUserToAddRows = false;
            this.dgvTareo.AllowUserToDeleteRows = false;
            this.dgvTareo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTareo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTareo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTareo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTareo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTareo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTareo.ContextMenuStrip = this.cm_grilla;
            this.dgvTareo.EnableHeadersVisualStyles = false;
            this.dgvTareo.Location = new System.Drawing.Point(10, 141);
            this.dgvTareo.Name = "dgvTareo";
            this.dgvTareo.ReadOnly = true;
            this.dgvTareo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTareo.Size = new System.Drawing.Size(1121, 345);
            this.dgvTareo.TabIndex = 258;
            this.dgvTareo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tareo_CellContentClick);
            this.dgvTareo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareo_CellContentDoubleClick);
            this.dgvTareo.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTareo_ColumnHeaderMouseClick);
            this.dgvTareo.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_tareo_CurrentCellDirtyStateChanged_1);
            // 
            // tc_tareo
            // 
            this.tc_tareo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_tareo.Controls.Add(this.tp_tareo);
            this.tc_tareo.Controls.Add(this.tp_edt);
            this.tc_tareo.Controls.Add(this.tp_actividades);
            this.tc_tareo.Controls.Add(this.tp_auditoria);
            this.tc_tareo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_tareo.Location = new System.Drawing.Point(6, 78);
            this.tc_tareo.Multiline = true;
            this.tc_tareo.Name = "tc_tareo";
            this.tc_tareo.SelectedIndex = 0;
            this.tc_tareo.Size = new System.Drawing.Size(1145, 519);
            this.tc_tareo.TabIndex = 237;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancelar.BackgroundImage = global::MISAP.Properties.Resources.btn;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_cancelar.Location = new System.Drawing.Point(78, 603);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(64, 21);
            this.btn_cancelar.TabIndex = 239;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
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
            this.btn_grabar.Location = new System.Drawing.Point(8, 603);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(64, 21);
            this.btn_grabar.TabIndex = 238;
            this.btn_grabar.Text = "Crear";
            this.btn_grabar.UseVisualStyleBackColor = true;
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
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
            this.titulo.Size = new System.Drawing.Size(1163, 27);
            this.titulo.TabIndex = 226;
            this.titulo.Text = "toolStrip1";
            this.titulo.DoubleClick += new System.EventHandler(this.titulo_DoubleClick);
            this.titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            // 
            // tsl_titulo
            // 
            this.tsl_titulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsl_titulo.Name = "tsl_titulo";
            this.tsl_titulo.Size = new System.Drawing.Size(101, 24);
            this.tsl_titulo.Text = "Registro de tareos";
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
            // lblTotalTar
            // 
            this.lblTotalTar.AutoSize = true;
            this.lblTotalTar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTar.Location = new System.Drawing.Point(1082, 606);
            this.lblTotalTar.Name = "lblTotalTar";
            this.lblTotalTar.Size = new System.Drawing.Size(0, 14);
            this.lblTotalTar.TabIndex = 304;
            this.lblTotalTar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(981, 606);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(91, 14);
            this.label24.TabIndex = 303;
            this.label24.Text = "Personal Tareado";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalHE
            // 
            this.lblTotalHE.AutoSize = true;
            this.lblTotalHE.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHE.Location = new System.Drawing.Point(913, 606);
            this.lblTotalHE.Name = "lblTotalHE";
            this.lblTotalHE.Size = new System.Drawing.Size(0, 14);
            this.lblTotalHE.TabIndex = 302;
            this.lblTotalHE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(857, 606);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(45, 14);
            this.label25.TabIndex = 301;
            this.label25.Text = "Total HE";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalHN
            // 
            this.lblTotalHN.AutoSize = true;
            this.lblTotalHN.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHN.Location = new System.Drawing.Point(750, 606);
            this.lblTotalHN.Name = "lblTotalHN";
            this.lblTotalHN.Size = new System.Drawing.Size(0, 14);
            this.lblTotalHN.TabIndex = 300;
            this.lblTotalHN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(694, 606);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(46, 14);
            this.label26.TabIndex = 299;
            this.label26.Text = "Total HN";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmTareo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 652);
            this.ControlBox = false;
            this.Controls.Add(this.lblTotalTar);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.lblTotalHE);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.lblTotalHN);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.l_dni);
            this.Controls.Add(this.l_usuario);
            this.Controls.Add(this.ss_load);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_grabar);
            this.Controls.Add(this.tc_tareo);
            this.Controls.Add(this.ts_acciones);
            this.Controls.Add(this.titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmTareo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmTareo_Load);
            this.cm_grilla.ResumeLayout(false);
            this.ts_acciones.ResumeLayout(false);
            this.ts_acciones.PerformLayout();
            this.ss_load.ResumeLayout(false);
            this.ss_load.PerformLayout();
            this.tp_auditoria.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tp_actividades.ResumeLayout(false);
            this.grp_actividad_nuevo.ResumeLayout(false);
            this.grp_actividad_nuevo.PerformLayout();
            this.tp_edt.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.grp_edt_nuevo.ResumeLayout(false);
            this.grp_edt_nuevo.PerformLayout();
            this.tp_tareo.ResumeLayout(false);
            this.tp_tareo.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.grp_tareo.ResumeLayout(false);
            this.grp_tareo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareo)).EndInit();
            this.tc_tareo.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_grabar;
        private System.Windows.Forms.ToolStripButton btn_nuevo_b;
        private System.Windows.Forms.ToolStripButton btn_editar_b;
        private System.Windows.Forms.ToolStripButton btn_consultar_b;
        private System.Windows.Forms.ToolStripButton btn_eliminar_b;
        private System.Windows.Forms.ToolStripButton btn_imprimir;
        private System.Windows.Forms.ToolStripButton btn_aprobar;
        private System.Windows.Forms.ToolStripButton btn_desaprobar;
        private System.Windows.Forms.ToolStripButton btn_ayuda;
        private System.Windows.Forms.ToolStrip ts_acciones;
        private System.Windows.Forms.ToolStripButton btn_previsualizar;
        private System.Windows.Forms.ToolStripButton btn_exportar_xls;
        private System.Windows.Forms.ToolStripButton btn_actualizar;
        private System.Windows.Forms.ContextMenuStrip cm_grilla;
        private System.Windows.Forms.ToolStripMenuItem cm_grilla_copia;
        private System.Windows.Forms.ToolStripMenuItem cm_grilla_copia_tabla;
        private System.Windows.Forms.Timer t_msg;
        private System.Windows.Forms.Label l_usuario;
        private System.Windows.Forms.Label l_dni;
        private System.Windows.Forms.ToolStripStatusLabel lbl_contador_registros;
        private System.Windows.Forms.ToolStripStatusLabel lbl_U_CL_CODSOL;
        private System.Windows.Forms.ToolStripStatusLabel lbl_U_CL_SOLICI;
        private System.Windows.Forms.ToolStripStatusLabel lbl_msg;
        private System.Windows.Forms.ToolStripStatusLabel lbl_maximi;
        private System.Windows.Forms.ToolStripStatusLabel lbl_dni;
        private System.Windows.Forms.StatusStrip ss_load;
        private System.ComponentModel.BackgroundWorker BW;
        private System.ComponentModel.BackgroundWorker BW_reg;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_usr_crea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tp_actividades;
        private System.Windows.Forms.GroupBox grp_actividad_nuevo;
        private System.Windows.Forms.TextBox txt_actividad_nuevo;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lbl_actividad;
        private System.Windows.Forms.ComboBox cbo_proceso;
        private System.Windows.Forms.TabPage tp_edt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grp_edt_nuevo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_edt_nuevo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbo_num_ord_edt;
        private System.Windows.Forms.TabPage tp_tareo;
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
        private System.Windows.Forms.TextBox txtact;
        private System.Windows.Forms.TextBox txtproc;
        private System.Windows.Forms.TextBox txtFechaFin_reg;
        private System.Windows.Forms.TextBox txtFechaIni_reg;
        private System.Windows.Forms.ComboBox cboSemana_reg;
        private System.Windows.Forms.ComboBox cboAnio_reg;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRevisar_reg;
        private System.Windows.Forms.Button btnAnular_reg;
        private System.Windows.Forms.Button btnAgregar_reg;
        private System.Windows.Forms.GroupBox grp_tareo;
        private System.Windows.Forms.ComboBox cboOt_reg;
        private System.Windows.Forms.ComboBox cboTurno_reg;
        private System.Windows.Forms.DateTimePicker dtpFecha_reg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboPersonal_reg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboTipo_reg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboEdt_reg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboActividad_reg;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtHn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cboFalta_reg;
        private System.Windows.Forms.TextBox txtHe;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTareo;
        private System.Windows.Forms.TabControl tc_tareo;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btnModMasiva;
        private System.Windows.Forms.Button btnIngMasivo;
        private System.Windows.Forms.Label lblTotalTar;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblTotalHE;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblTotalHN;
        private System.Windows.Forms.Label label26;
    }
}