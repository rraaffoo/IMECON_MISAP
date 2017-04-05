namespace MISAP
{
    partial class FrmPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidos));
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
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_num_ord = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_responsable = new System.Windows.Forms.ComboBox();
            this.tc_pedido = new System.Windows.Forms.TabControl();
            this.tp_listado = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rb_activos_l = new System.Windows.Forms.RadioButton();
            this.crv_requerimiento = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txt_tipo_l = new System.Windows.Forms.TextBox();
            this.rb_servicios_l = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.rb_materiales_l = new System.Windows.Forms.RadioButton();
            this.cbo_anio = new System.Windows.Forms.ComboBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.dgv_pedidos = new System.Windows.Forms.DataGridView();
            this.cm_grilla = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cm_grilla_copia = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_grilla_copia_tabla = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.verPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.logDeModificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tp_nuevo = new System.Windows.Forms.TabPage();
            this.txt_DocEntry = new System.Windows.Forms.TextBox();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_aprobado = new System.Windows.Forms.Label();
            this.txt_aprobado_por = new System.Windows.Forms.TextBox();
            this.txt_codigo_autorizacion = new System.Windows.Forms.TextBox();
            this.txt_flag_activo_ti = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rb_activos = new System.Windows.Forms.RadioButton();
            this.txt_cod_ot = new System.Windows.Forms.TextBox();
            this.txt_cod_proyecto = new System.Windows.Forms.TextBox();
            this.txt_proyecto = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.cdg_origen = new System.Windows.Forms.TextBox();
            this.txt_U_CL_CODSOL = new System.Windows.Forms.TextBox();
            this.txt_U_CDG_USER = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_U_CL_SOLICI = new System.Windows.Forms.TextBox();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.txt_responsable = new System.Windows.Forms.TextBox();
            this.btn_suprimir = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_ot = new System.Windows.Forms.TextBox();
            this.rb_servicios = new System.Windows.Forms.RadioButton();
            this.rb_materiales = new System.Windows.Forms.RadioButton();
            this.dp_fecha_necesaria = new System.Windows.Forms.DateTimePicker();
            this.txtexaminar = new System.Windows.Forms.TextBox();
            this.lbl_pedido = new System.Windows.Forms.Label();
            this.txt_pedido = new System.Windows.Forms.TextBox();
            this.dgv_det_pedidos = new System.Windows.Forms.DataGridView();
            this.cdgprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.med = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candesp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_det_pedidos_consulta = new System.Windows.Forms.DataGridView();
            this.seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.tp_plantilla = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_plantilla = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_plantilla_d = new System.Windows.Forms.DataGridView();
            this.txt_sp_d = new System.Windows.Forms.TextBox();
            this.txt_sp = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_ejecutar_SP = new System.Windows.Forms.Button();
            this.btn_abrir_plantilla = new System.Windows.Forms.Button();
            this.t_msg = new System.Windows.Forms.Timer(this.components);
            this.ss_load = new System.Windows.Forms.StatusStrip();
            this.lbl_maximi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_contador_registros = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_CODSOL = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_SOLICI = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_msg = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.ToolStrip();
            this.tsl_titulo = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.maximizar = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.ts_acciones.SuspendLayout();
            this.tc_pedido.SuspendLayout();
            this.tp_listado.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).BeginInit();
            this.cm_grilla.SuspendLayout();
            this.tp_nuevo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_det_pedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_det_pedidos_consulta)).BeginInit();
            this.tp_auditoria.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tp_plantilla.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_plantilla)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_plantilla_d)).BeginInit();
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
            this.ts_acciones.Size = new System.Drawing.Size(856, 47);
            this.ts_acciones.TabIndex = 257;
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
            this.btn_editar_b.Image = global::MISAP.Properties.Resources.TOOLSdoceditor;
            this.btn_editar_b.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_editar_b.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_editar_b.Name = "btn_editar_b";
            this.btn_editar_b.Size = new System.Drawing.Size(29, 44);
            this.btn_editar_b.Text = "Editar";
            this.btn_editar_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_editar_b.ToolTipText = "Editar";
            this.btn_editar_b.Click += new System.EventHandler(this.btn_editar_b_Click);
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
            this.btn_imprimir.Image = global::MISAP.Properties.Resources.FILEprint;
            this.btn_imprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(29, 44);
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_imprimir.ToolTipText = "Imprimir";
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
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
            this.btn_plantilla.Click += new System.EventHandler(this.btn_plantilla_Click);
            // 
            // btn_aprobar
            // 
            this.btn_aprobar.AutoSize = false;
            this.btn_aprobar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_aprobar.Enabled = false;
            this.btn_aprobar.Image = global::MISAP.Properties.Resources.linkMapIconaancellation;
            this.btn_aprobar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_aprobar.Name = "btn_aprobar";
            this.btn_aprobar.Size = new System.Drawing.Size(29, 44);
            this.btn_aprobar.Text = "Aprobar";
            this.btn_aprobar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_aprobar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_aprobar.ToolTipText = "Aprobar";
            this.btn_aprobar.Click += new System.EventHandler(this.btn_aprobar_Click);
            // 
            // btn_desaprobar
            // 
            this.btn_desaprobar.AutoSize = false;
            this.btn_desaprobar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_desaprobar.Enabled = false;
            this.btn_desaprobar.Image = global::MISAP.Properties.Resources.linkMapIconNotAuthorised;
            this.btn_desaprobar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_desaprobar.Name = "btn_desaprobar";
            this.btn_desaprobar.Size = new System.Drawing.Size(29, 44);
            this.btn_desaprobar.Text = "Rechazar";
            this.btn_desaprobar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_desaprobar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_desaprobar.ToolTipText = "Rechazar";
            this.btn_desaprobar.Click += new System.EventHandler(this.btn_desaprobar_Click);
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
            this.btn_filtro.Click += new System.EventHandler(this.btn_filtro_Click);
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
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(571, 98);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(37, 14);
            this.lbl_fecha.TabIndex = 263;
            this.lbl_fecha.Text = "Fecha";
            // 
            // txt_fecha
            // 
            this.txt_fecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fecha.Location = new System.Drawing.Point(661, 92);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(148, 20);
            this.txt_fecha.TabIndex = 264;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 14);
            this.label1.TabIndex = 265;
            this.label1.Text = "Fecha necesaria";
            // 
            // cbo_num_ord
            // 
            this.cbo_num_ord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_num_ord.Enabled = false;
            this.cbo_num_ord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_num_ord.FormattingEnabled = true;
            this.cbo_num_ord.Location = new System.Drawing.Point(107, 90);
            this.cbo_num_ord.Name = "cbo_num_ord";
            this.cbo_num_ord.Size = new System.Drawing.Size(458, 22);
            this.cbo_num_ord.TabIndex = 1;
            this.cbo_num_ord.SelectionChangeCommitted += new System.EventHandler(this.cbo_num_ord_SelectionChangeCommitted);
            this.cbo_num_ord.Enter += new System.EventHandler(this.cbo_num_ord_Enter);
            this.cbo_num_ord.Leave += new System.EventHandler(this.cbo_num_ord_Leave);
            this.cbo_num_ord.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbo_num_ord_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 14);
            this.label2.TabIndex = 268;
            this.label2.Text = "O.T.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 14);
            this.label3.TabIndex = 269;
            this.label3.Text = "Responsable O.T.";
            // 
            // cbo_responsable
            // 
            this.cbo_responsable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbo_responsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_responsable.Enabled = false;
            this.cbo_responsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_responsable.FormattingEnabled = true;
            this.cbo_responsable.Location = new System.Drawing.Point(107, 114);
            this.cbo_responsable.Name = "cbo_responsable";
            this.cbo_responsable.Size = new System.Drawing.Size(458, 21);
            this.cbo_responsable.TabIndex = 2;
            this.cbo_responsable.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbo_responsable_DrawItem);
            this.cbo_responsable.SelectionChangeCommitted += new System.EventHandler(this.cbo_responsable_SelectionChangeCommitted);
            this.cbo_responsable.Enter += new System.EventHandler(this.cbo_responsable_Enter);
            this.cbo_responsable.Leave += new System.EventHandler(this.cbo_responsable_Leave);
            this.cbo_responsable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbo_responsable_MouseClick);
            // 
            // tc_pedido
            // 
            this.tc_pedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_pedido.Controls.Add(this.tp_listado);
            this.tc_pedido.Controls.Add(this.tp_nuevo);
            this.tc_pedido.Controls.Add(this.tp_auditoria);
            this.tc_pedido.Controls.Add(this.tp_plantilla);
            this.tc_pedido.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_pedido.Location = new System.Drawing.Point(9, 78);
            this.tc_pedido.Name = "tc_pedido";
            this.tc_pedido.SelectedIndex = 0;
            this.tc_pedido.Size = new System.Drawing.Size(835, 485);
            this.tc_pedido.TabIndex = 273;
            this.tc_pedido.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tc_usuario_Selecting);
            // 
            // tp_listado
            // 
            this.tp_listado.Controls.Add(this.groupBox4);
            this.tp_listado.Controls.Add(this.lbl_buscar);
            this.tp_listado.Controls.Add(this.txt_buscar);
            this.tp_listado.Controls.Add(this.dgv_pedidos);
            this.tp_listado.Location = new System.Drawing.Point(4, 23);
            this.tp_listado.Name = "tp_listado";
            this.tp_listado.Size = new System.Drawing.Size(827, 458);
            this.tp_listado.TabIndex = 2;
            this.tp_listado.Text = "Listado";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rb_activos_l);
            this.groupBox4.Controls.Add(this.crv_requerimiento);
            this.groupBox4.Controls.Add(this.txt_tipo_l);
            this.groupBox4.Controls.Add(this.rb_servicios_l);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.rb_materiales_l);
            this.groupBox4.Controls.Add(this.cbo_anio);
            this.groupBox4.Location = new System.Drawing.Point(12, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(803, 44);
            this.groupBox4.TabIndex = 264;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtrar";
            // 
            // rb_activos_l
            // 
            this.rb_activos_l.AutoSize = true;
            this.rb_activos_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_activos_l.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_activos_l.Location = new System.Drawing.Point(160, 20);
            this.rb_activos_l.Name = "rb_activos_l";
            this.rb_activos_l.Size = new System.Drawing.Size(84, 18);
            this.rb_activos_l.TabIndex = 280;
            this.rb_activos_l.Text = "Activos fijos";
            this.rb_activos_l.UseVisualStyleBackColor = true;
            this.rb_activos_l.CheckedChanged += new System.EventHandler(this.rb_activos_l_CheckedChanged);
            // 
            // crv_requerimiento
            // 
            this.crv_requerimiento.ActiveViewIndex = -1;
            this.crv_requerimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_requerimiento.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_requerimiento.EnableRefresh = false;
            this.crv_requerimiento.Location = new System.Drawing.Point(473, 11);
            this.crv_requerimiento.Name = "crv_requerimiento";
            this.crv_requerimiento.ShowGroupTreeButton = false;
            this.crv_requerimiento.ShowParameterPanelButton = false;
            this.crv_requerimiento.ShowRefreshButton = false;
            this.crv_requerimiento.Size = new System.Drawing.Size(143, 27);
            this.crv_requerimiento.TabIndex = 265;
            this.crv_requerimiento.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crv_requerimiento.Visible = false;
            // 
            // txt_tipo_l
            // 
            this.txt_tipo_l.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tipo_l.Location = new System.Drawing.Point(401, 17);
            this.txt_tipo_l.Name = "txt_tipo_l";
            this.txt_tipo_l.Size = new System.Drawing.Size(62, 20);
            this.txt_tipo_l.TabIndex = 279;
            this.txt_tipo_l.Visible = false;
            // 
            // rb_servicios_l
            // 
            this.rb_servicios_l.AutoSize = true;
            this.rb_servicios_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_servicios_l.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_servicios_l.Location = new System.Drawing.Point(85, 20);
            this.rb_servicios_l.Name = "rb_servicios_l";
            this.rb_servicios_l.Size = new System.Drawing.Size(69, 18);
            this.rb_servicios_l.TabIndex = 279;
            this.rb_servicios_l.Text = "Servicios";
            this.rb_servicios_l.UseVisualStyleBackColor = true;
            this.rb_servicios_l.CheckedChanged += new System.EventHandler(this.rb_servicios_l_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(268, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 14);
            this.label11.TabIndex = 265;
            this.label11.Text = "Año";
            // 
            // rb_materiales_l
            // 
            this.rb_materiales_l.AutoSize = true;
            this.rb_materiales_l.Checked = true;
            this.rb_materiales_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_materiales_l.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_materiales_l.Location = new System.Drawing.Point(6, 20);
            this.rb_materiales_l.Name = "rb_materiales_l";
            this.rb_materiales_l.Size = new System.Drawing.Size(73, 18);
            this.rb_materiales_l.TabIndex = 278;
            this.rb_materiales_l.TabStop = true;
            this.rb_materiales_l.Text = "Materiales";
            this.rb_materiales_l.UseVisualStyleBackColor = true;
            this.rb_materiales_l.CheckedChanged += new System.EventHandler(this.rb_materiales_l_CheckedChanged);
            // 
            // cbo_anio
            // 
            this.cbo_anio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbo_anio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_anio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_anio.FormattingEnabled = true;
            this.cbo_anio.Items.AddRange(new object[] {
            "Todos",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cbo_anio.Location = new System.Drawing.Point(301, 16);
            this.cbo_anio.Name = "cbo_anio";
            this.cbo_anio.Size = new System.Drawing.Size(77, 21);
            this.cbo_anio.TabIndex = 268;
            this.cbo_anio.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbo_anio_DrawItem);
            this.cbo_anio.SelectedValueChanged += new System.EventHandler(this.cbo_anio_SelectedValueChanged);
            this.cbo_anio.Click += new System.EventHandler(this.cbo_anio_Click);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Location = new System.Drawing.Point(9, 69);
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
            this.txt_buscar.Location = new System.Drawing.Point(12, 86);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedidos.ContextMenuStrip = this.cm_grilla;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_pedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_pedidos.EnableHeadersVisualStyles = false;
            this.dgv_pedidos.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_pedidos.Location = new System.Drawing.Point(12, 109);
            this.dgv_pedidos.Name = "dgv_pedidos";
            this.dgv_pedidos.ReadOnly = true;
            this.dgv_pedidos.Size = new System.Drawing.Size(803, 333);
            this.dgv_pedidos.TabIndex = 224;
            this.dgv_pedidos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pedidos_CellContentDoubleClick_1);
            this.dgv_pedidos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_pedidos_ColumnHeaderMouseClick);
            // 
            // cm_grilla
            // 
            this.cm_grilla.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cm_grilla_copia,
            this.cm_grilla_copia_tabla,
            this.toolStripSeparator1,
            this.verPedidoToolStripMenuItem,
            this.toolStripSeparator2,
            this.logDeModificacionesToolStripMenuItem});
            this.cm_grilla.Name = "cm_grilla";
            this.cm_grilla.Size = new System.Drawing.Size(195, 104);
            // 
            // cm_grilla_copia
            // 
            this.cm_grilla_copia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cm_grilla_copia.Name = "cm_grilla_copia";
            this.cm_grilla_copia.Size = new System.Drawing.Size(194, 22);
            this.cm_grilla_copia.Text = "Copia";
            this.cm_grilla_copia.Click += new System.EventHandler(this.cm_grilla_copia_Click);
            // 
            // cm_grilla_copia_tabla
            // 
            this.cm_grilla_copia_tabla.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cm_grilla_copia_tabla.Name = "cm_grilla_copia_tabla";
            this.cm_grilla_copia_tabla.Size = new System.Drawing.Size(194, 22);
            this.cm_grilla_copia_tabla.Text = "Copia tabla";
            this.cm_grilla_copia_tabla.Click += new System.EventHandler(this.cm_grilla_copia_tabla_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // verPedidoToolStripMenuItem
            // 
            this.verPedidoToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.verPedidoToolStripMenuItem.Name = "verPedidoToolStripMenuItem";
            this.verPedidoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.verPedidoToolStripMenuItem.Text = "Ver Pedido";
            this.verPedidoToolStripMenuItem.Click += new System.EventHandler(this.verPedidoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // logDeModificacionesToolStripMenuItem
            // 
            this.logDeModificacionesToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.logDeModificacionesToolStripMenuItem.Name = "logDeModificacionesToolStripMenuItem";
            this.logDeModificacionesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.logDeModificacionesToolStripMenuItem.Text = "Log de modificaciones";
            this.logDeModificacionesToolStripMenuItem.Click += new System.EventHandler(this.logDeModificacionesToolStripMenuItem_Click);
            // 
            // tp_nuevo
            // 
            this.tp_nuevo.Controls.Add(this.txt_DocEntry);
            this.tp_nuevo.Controls.Add(this.txt_obs);
            this.tp_nuevo.Controls.Add(this.label9);
            this.tp_nuevo.Controls.Add(this.groupBox3);
            this.tp_nuevo.Controls.Add(this.dgv_det_pedidos);
            this.tp_nuevo.Controls.Add(this.dgv_det_pedidos_consulta);
            this.tp_nuevo.Location = new System.Drawing.Point(4, 23);
            this.tp_nuevo.Name = "tp_nuevo";
            this.tp_nuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tp_nuevo.Size = new System.Drawing.Size(827, 458);
            this.tp_nuevo.TabIndex = 0;
            this.tp_nuevo.Text = "Nuevo";
            // 
            // txt_DocEntry
            // 
            this.txt_DocEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DocEntry.Location = new System.Drawing.Point(761, 47);
            this.txt_DocEntry.Name = "txt_DocEntry";
            this.txt_DocEntry.ReadOnly = true;
            this.txt_DocEntry.Size = new System.Drawing.Size(54, 20);
            this.txt_DocEntry.TabIndex = 296;
            // 
            // txt_obs
            // 
            this.txt_obs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_obs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_obs.Location = new System.Drawing.Point(9, 361);
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.ReadOnly = true;
            this.txt_obs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_obs.Size = new System.Drawing.Size(812, 91);
            this.txt_obs.TabIndex = 277;
            this.txt_obs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_obs_MouseClick);
            this.txt_obs.Enter += new System.EventHandler(this.txt_obs_Enter);
            this.txt_obs.Leave += new System.EventHandler(this.txt_obs_Leave);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 14);
            this.label9.TabIndex = 276;
            this.label9.Text = "Comentarios";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lbl_aprobado);
            this.groupBox3.Controls.Add(this.txt_aprobado_por);
            this.groupBox3.Controls.Add(this.txt_codigo_autorizacion);
            this.groupBox3.Controls.Add(this.txt_flag_activo_ti);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.rb_activos);
            this.groupBox3.Controls.Add(this.txt_cod_ot);
            this.groupBox3.Controls.Add(this.txt_cod_proyecto);
            this.groupBox3.Controls.Add(this.txt_proyecto);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_estado);
            this.groupBox3.Controls.Add(this.cdg_origen);
            this.groupBox3.Controls.Add(this.txt_U_CL_CODSOL);
            this.groupBox3.Controls.Add(this.txt_U_CDG_USER);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txt_U_CL_SOLICI);
            this.groupBox3.Controls.Add(this.txt_tipo);
            this.groupBox3.Controls.Add(this.txt_responsable);
            this.groupBox3.Controls.Add(this.btn_suprimir);
            this.groupBox3.Controls.Add(this.btn_agregar);
            this.groupBox3.Controls.Add(this.txt_ot);
            this.groupBox3.Controls.Add(this.rb_servicios);
            this.groupBox3.Controls.Add(this.rb_materiales);
            this.groupBox3.Controls.Add(this.dp_fecha_necesaria);
            this.groupBox3.Controls.Add(this.txtexaminar);
            this.groupBox3.Controls.Add(this.txt_fecha);
            this.groupBox3.Controls.Add(this.lbl_fecha);
            this.groupBox3.Controls.Add(this.cbo_responsable);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbo_num_ord);
            this.groupBox3.Controls.Add(this.lbl_pedido);
            this.groupBox3.Controls.Add(this.txt_pedido);
            this.groupBox3.Location = new System.Drawing.Point(6, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(815, 180);
            this.groupBox3.TabIndex = 88;
            this.groupBox3.TabStop = false;
            // 
            // lbl_aprobado
            // 
            this.lbl_aprobado.AutoSize = true;
            this.lbl_aprobado.Location = new System.Drawing.Point(291, 117);
            this.lbl_aprobado.Name = "lbl_aprobado";
            this.lbl_aprobado.Size = new System.Drawing.Size(78, 14);
            this.lbl_aprobado.TabIndex = 299;
            this.lbl_aprobado.Text = "Aprobador por";
            // 
            // txt_aprobado_por
            // 
            this.txt_aprobado_por.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_aprobado_por.Location = new System.Drawing.Point(375, 115);
            this.txt_aprobado_por.Name = "txt_aprobado_por";
            this.txt_aprobado_por.ReadOnly = true;
            this.txt_aprobado_por.Size = new System.Drawing.Size(190, 20);
            this.txt_aprobado_por.TabIndex = 298;
            this.txt_aprobado_por.Visible = false;
            // 
            // txt_codigo_autorizacion
            // 
            this.txt_codigo_autorizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_codigo_autorizacion.Location = new System.Drawing.Point(602, 13);
            this.txt_codigo_autorizacion.Name = "txt_codigo_autorizacion";
            this.txt_codigo_autorizacion.Size = new System.Drawing.Size(62, 20);
            this.txt_codigo_autorizacion.TabIndex = 297;
            this.txt_codigo_autorizacion.Visible = false;
            // 
            // txt_flag_activo_ti
            // 
            this.txt_flag_activo_ti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_flag_activo_ti.Location = new System.Drawing.Point(534, 13);
            this.txt_flag_activo_ti.Name = "txt_flag_activo_ti";
            this.txt_flag_activo_ti.Size = new System.Drawing.Size(62, 20);
            this.txt_flag_activo_ti.TabIndex = 296;
            this.txt_flag_activo_ti.Text = "0";
            this.txt_flag_activo_ti.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(457, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 20);
            this.textBox1.TabIndex = 295;
            this.textBox1.Visible = false;
            // 
            // rb_activos
            // 
            this.rb_activos.AutoSize = true;
            this.rb_activos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_activos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_activos.Location = new System.Drawing.Point(175, 15);
            this.rb_activos.Name = "rb_activos";
            this.rb_activos.Size = new System.Drawing.Size(74, 18);
            this.rb_activos.TabIndex = 294;
            this.rb_activos.Text = "Activo Fijo";
            this.rb_activos.UseVisualStyleBackColor = true;
            this.rb_activos.CheckedChanged += new System.EventHandler(this.rb_activos_CheckedChanged);
            // 
            // txt_cod_ot
            // 
            this.txt_cod_ot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cod_ot.Location = new System.Drawing.Point(107, 92);
            this.txt_cod_ot.Name = "txt_cod_ot";
            this.txt_cod_ot.ReadOnly = true;
            this.txt_cod_ot.Size = new System.Drawing.Size(92, 20);
            this.txt_cod_ot.TabIndex = 293;
            this.txt_cod_ot.Visible = false;
            // 
            // txt_cod_proyecto
            // 
            this.txt_cod_proyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cod_proyecto.Location = new System.Drawing.Point(107, 68);
            this.txt_cod_proyecto.Name = "txt_cod_proyecto";
            this.txt_cod_proyecto.ReadOnly = true;
            this.txt_cod_proyecto.Size = new System.Drawing.Size(91, 20);
            this.txt_cod_proyecto.TabIndex = 292;
            // 
            // txt_proyecto
            // 
            this.txt_proyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_proyecto.Location = new System.Drawing.Point(204, 68);
            this.txt_proyecto.Name = "txt_proyecto";
            this.txt_proyecto.ReadOnly = true;
            this.txt_proyecto.Size = new System.Drawing.Size(361, 20);
            this.txt_proyecto.TabIndex = 291;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 14);
            this.label16.TabIndex = 290;
            this.label16.Text = "Proyecto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 289;
            this.label4.Text = "Estado";
            // 
            // txt_estado
            // 
            this.txt_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_estado.Location = new System.Drawing.Point(661, 68);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.ReadOnly = true;
            this.txt_estado.Size = new System.Drawing.Size(148, 20);
            this.txt_estado.TabIndex = 288;
            // 
            // cdg_origen
            // 
            this.cdg_origen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cdg_origen.Location = new System.Drawing.Point(389, 13);
            this.cdg_origen.Name = "cdg_origen";
            this.cdg_origen.Size = new System.Drawing.Size(62, 20);
            this.cdg_origen.TabIndex = 283;
            this.cdg_origen.Visible = false;
            // 
            // txt_U_CL_CODSOL
            // 
            this.txt_U_CL_CODSOL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_U_CL_CODSOL.Location = new System.Drawing.Point(107, 44);
            this.txt_U_CL_CODSOL.Name = "txt_U_CL_CODSOL";
            this.txt_U_CL_CODSOL.ReadOnly = true;
            this.txt_U_CL_CODSOL.Size = new System.Drawing.Size(27, 20);
            this.txt_U_CL_CODSOL.TabIndex = 287;
            // 
            // txt_U_CDG_USER
            // 
            this.txt_U_CDG_USER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_U_CDG_USER.Location = new System.Drawing.Point(140, 44);
            this.txt_U_CDG_USER.Name = "txt_U_CDG_USER";
            this.txt_U_CDG_USER.ReadOnly = true;
            this.txt_U_CDG_USER.Size = new System.Drawing.Size(104, 20);
            this.txt_U_CDG_USER.TabIndex = 286;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 14);
            this.label14.TabIndex = 285;
            this.label14.Text = "Solicitante";
            // 
            // txt_U_CL_SOLICI
            // 
            this.txt_U_CL_SOLICI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_U_CL_SOLICI.Location = new System.Drawing.Point(250, 44);
            this.txt_U_CL_SOLICI.Name = "txt_U_CL_SOLICI";
            this.txt_U_CL_SOLICI.ReadOnly = true;
            this.txt_U_CL_SOLICI.Size = new System.Drawing.Size(315, 20);
            this.txt_U_CL_SOLICI.TabIndex = 284;
            // 
            // txt_tipo
            // 
            this.txt_tipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tipo.Location = new System.Drawing.Point(321, 13);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(62, 20);
            this.txt_tipo.TabIndex = 278;
            this.txt_tipo.Visible = false;
            // 
            // txt_responsable
            // 
            this.txt_responsable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_responsable.Location = new System.Drawing.Point(107, 114);
            this.txt_responsable.Name = "txt_responsable";
            this.txt_responsable.ReadOnly = true;
            this.txt_responsable.Size = new System.Drawing.Size(176, 20);
            this.txt_responsable.TabIndex = 280;
            this.txt_responsable.Visible = false;
            // 
            // btn_suprimir
            // 
            this.btn_suprimir.BackgroundImage = global::MISAP.Properties.Resources.btn_desactivado;
            this.btn_suprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_suprimir.Enabled = false;
            this.btn_suprimir.FlatAppearance.BorderSize = 0;
            this.btn_suprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_suprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_suprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suprimir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suprimir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_suprimir.Location = new System.Drawing.Point(91, 151);
            this.btn_suprimir.Name = "btn_suprimir";
            this.btn_suprimir.Size = new System.Drawing.Size(73, 22);
            this.btn_suprimir.TabIndex = 274;
            this.btn_suprimir.Text = "Suprimir";
            this.btn_suprimir.UseVisualStyleBackColor = true;
            this.btn_suprimir.Click += new System.EventHandler(this.btn_suprimir_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImage = global::MISAP.Properties.Resources.btn_enfasis_dasactivado;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_agregar.Enabled = false;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_agregar.Location = new System.Drawing.Point(13, 151);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(72, 22);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_ot
            // 
            this.txt_ot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ot.Location = new System.Drawing.Point(204, 92);
            this.txt_ot.Name = "txt_ot";
            this.txt_ot.ReadOnly = true;
            this.txt_ot.Size = new System.Drawing.Size(361, 20);
            this.txt_ot.TabIndex = 279;
            this.txt_ot.Visible = false;
            // 
            // rb_servicios
            // 
            this.rb_servicios.AutoSize = true;
            this.rb_servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_servicios.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_servicios.Location = new System.Drawing.Point(95, 15);
            this.rb_servicios.Name = "rb_servicios";
            this.rb_servicios.Size = new System.Drawing.Size(69, 18);
            this.rb_servicios.TabIndex = 277;
            this.rb_servicios.Text = "Servicios";
            this.rb_servicios.UseVisualStyleBackColor = true;
            this.rb_servicios.CheckedChanged += new System.EventHandler(this.rb_servicios_CheckedChanged);
            // 
            // rb_materiales
            // 
            this.rb_materiales.AutoSize = true;
            this.rb_materiales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_materiales.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_materiales.Location = new System.Drawing.Point(12, 15);
            this.rb_materiales.Name = "rb_materiales";
            this.rb_materiales.Size = new System.Drawing.Size(73, 18);
            this.rb_materiales.TabIndex = 276;
            this.rb_materiales.Text = "Materiales";
            this.rb_materiales.UseVisualStyleBackColor = true;
            this.rb_materiales.CheckedChanged += new System.EventHandler(this.rb_materiales_CheckedChanged);
            // 
            // dp_fecha_necesaria
            // 
            this.dp_fecha_necesaria.Enabled = false;
            this.dp_fecha_necesaria.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_fecha_necesaria.Location = new System.Drawing.Point(661, 115);
            this.dp_fecha_necesaria.Name = "dp_fecha_necesaria";
            this.dp_fecha_necesaria.Size = new System.Drawing.Size(148, 20);
            this.dp_fecha_necesaria.TabIndex = 275;
            // 
            // txtexaminar
            // 
            this.txtexaminar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtexaminar.Enabled = false;
            this.txtexaminar.Location = new System.Drawing.Point(431, 355);
            this.txtexaminar.Name = "txtexaminar";
            this.txtexaminar.Size = new System.Drawing.Size(141, 20);
            this.txtexaminar.TabIndex = 221;
            this.txtexaminar.Visible = false;
            // 
            // lbl_pedido
            // 
            this.lbl_pedido.AutoSize = true;
            this.lbl_pedido.Location = new System.Drawing.Point(571, 50);
            this.lbl_pedido.Name = "lbl_pedido";
            this.lbl_pedido.Size = new System.Drawing.Size(84, 14);
            this.lbl_pedido.TabIndex = 282;
            this.lbl_pedido.Text = "Requerimiento #";
            // 
            // txt_pedido
            // 
            this.txt_pedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pedido.Location = new System.Drawing.Point(661, 44);
            this.txt_pedido.Name = "txt_pedido";
            this.txt_pedido.ReadOnly = true;
            this.txt_pedido.Size = new System.Drawing.Size(88, 20);
            this.txt_pedido.TabIndex = 0;
            // 
            // dgv_det_pedidos
            // 
            this.dgv_det_pedidos.AllowUserToAddRows = false;
            this.dgv_det_pedidos.AllowUserToDeleteRows = false;
            this.dgv_det_pedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_det_pedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_det_pedidos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_det_pedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_det_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_det_pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdgprod,
            this.material,
            this.med,
            this.canped,
            this.candesp,
            this.cancmp,
            this.Cod_Familia});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_det_pedidos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_det_pedidos.EnableHeadersVisualStyles = false;
            this.dgv_det_pedidos.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_det_pedidos.Location = new System.Drawing.Point(6, 189);
            this.dgv_det_pedidos.Name = "dgv_det_pedidos";
            this.dgv_det_pedidos.ReadOnly = true;
            this.dgv_det_pedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_det_pedidos.Size = new System.Drawing.Size(815, 152);
            this.dgv_det_pedidos.TabIndex = 225;
            // 
            // cdgprod
            // 
            this.cdgprod.FillWeight = 110.7445F;
            this.cdgprod.HeaderText = "Codigo";
            this.cdgprod.Name = "cdgprod";
            this.cdgprod.ReadOnly = true;
            // 
            // material
            // 
            this.material.FillWeight = 110.7445F;
            this.material.HeaderText = "Material";
            this.material.Name = "material";
            this.material.ReadOnly = true;
            // 
            // med
            // 
            this.med.HeaderText = "UM";
            this.med.Name = "med";
            this.med.ReadOnly = true;
            // 
            // canped
            // 
            this.canped.FillWeight = 110.7445F;
            this.canped.HeaderText = "Cant. pedida";
            this.canped.Name = "canped";
            this.canped.ReadOnly = true;
            // 
            // candesp
            // 
            this.candesp.FillWeight = 110.7445F;
            this.candesp.HeaderText = "Cant. Atendida";
            this.candesp.Name = "candesp";
            this.candesp.ReadOnly = true;
            // 
            // cancmp
            // 
            this.cancmp.FillWeight = 110.7445F;
            this.cancmp.HeaderText = "Por comprar";
            this.cancmp.Name = "cancmp";
            this.cancmp.ReadOnly = true;
            // 
            // Cod_Familia
            // 
            this.Cod_Familia.HeaderText = "Cod. Familia";
            this.Cod_Familia.Name = "Cod_Familia";
            this.Cod_Familia.ReadOnly = true;
            // 
            // dgv_det_pedidos_consulta
            // 
            this.dgv_det_pedidos_consulta.AllowUserToAddRows = false;
            this.dgv_det_pedidos_consulta.AllowUserToDeleteRows = false;
            this.dgv_det_pedidos_consulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_det_pedidos_consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_det_pedidos_consulta.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_det_pedidos_consulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_det_pedidos_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_det_pedidos_consulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seleccion});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_det_pedidos_consulta.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_det_pedidos_consulta.EnableHeadersVisualStyles = false;
            this.dgv_det_pedidos_consulta.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_det_pedidos_consulta.Location = new System.Drawing.Point(6, 190);
            this.dgv_det_pedidos_consulta.Name = "dgv_det_pedidos_consulta";
            this.dgv_det_pedidos_consulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_det_pedidos_consulta.Size = new System.Drawing.Size(815, 152);
            this.dgv_det_pedidos_consulta.TabIndex = 278;
            this.dgv_det_pedidos_consulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_det_pedidos_consulta_CellContentClick);
            this.dgv_det_pedidos_consulta.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_det_pedidos_consulta_CurrentCellDirtyStateChanged);
            // 
            // seleccion
            // 
            this.seleccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.seleccion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.seleccion.Frozen = true;
            this.seleccion.HeaderText = "";
            this.seleccion.Name = "seleccion";
            this.seleccion.Width = 25;
            // 
            // tp_auditoria
            // 
            this.tp_auditoria.Controls.Add(this.groupBox1);
            this.tp_auditoria.Location = new System.Drawing.Point(4, 23);
            this.tp_auditoria.Name = "tp_auditoria";
            this.tp_auditoria.Padding = new System.Windows.Forms.Padding(3);
            this.tp_auditoria.Size = new System.Drawing.Size(827, 458);
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
            this.groupBox1.Location = new System.Drawing.Point(46, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 310);
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
            // tp_plantilla
            // 
            this.tp_plantilla.Controls.Add(this.tabControl1);
            this.tp_plantilla.Controls.Add(this.txt_sp_d);
            this.tp_plantilla.Controls.Add(this.txt_sp);
            this.tp_plantilla.Controls.Add(this.label15);
            this.tp_plantilla.Controls.Add(this.btn_ejecutar_SP);
            this.tp_plantilla.Controls.Add(this.btn_abrir_plantilla);
            this.tp_plantilla.Location = new System.Drawing.Point(4, 23);
            this.tp_plantilla.Name = "tp_plantilla";
            this.tp_plantilla.Size = new System.Drawing.Size(827, 458);
            this.tp_plantilla.TabIndex = 3;
            this.tp_plantilla.Text = "Plantilla";
            this.tp_plantilla.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 439);
            this.tabControl1.TabIndex = 303;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_plantilla);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(808, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cabecera";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_plantilla
            // 
            this.dgv_plantilla.AllowUserToAddRows = false;
            this.dgv_plantilla.AllowUserToDeleteRows = false;
            this.dgv_plantilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_plantilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_plantilla.EnableHeadersVisualStyles = false;
            this.dgv_plantilla.Location = new System.Drawing.Point(3, 3);
            this.dgv_plantilla.Name = "dgv_plantilla";
            this.dgv_plantilla.ReadOnly = true;
            this.dgv_plantilla.Size = new System.Drawing.Size(802, 406);
            this.dgv_plantilla.TabIndex = 109;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_plantilla_d);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(808, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_plantilla_d
            // 
            this.dgv_plantilla_d.AllowUserToAddRows = false;
            this.dgv_plantilla_d.AllowUserToDeleteRows = false;
            this.dgv_plantilla_d.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_plantilla_d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_plantilla_d.EnableHeadersVisualStyles = false;
            this.dgv_plantilla_d.Location = new System.Drawing.Point(3, 3);
            this.dgv_plantilla_d.Name = "dgv_plantilla_d";
            this.dgv_plantilla_d.ReadOnly = true;
            this.dgv_plantilla_d.Size = new System.Drawing.Size(802, 406);
            this.dgv_plantilla_d.TabIndex = 110;
            // 
            // txt_sp_d
            // 
            this.txt_sp_d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sp_d.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sp_d.Location = new System.Drawing.Point(548, 13);
            this.txt_sp_d.Name = "txt_sp_d";
            this.txt_sp_d.ReadOnly = true;
            this.txt_sp_d.Size = new System.Drawing.Size(139, 20);
            this.txt_sp_d.TabIndex = 299;
            this.txt_sp_d.Text = "BPVS_TRASLADOS_DET";
            this.txt_sp_d.Visible = false;
            // 
            // txt_sp
            // 
            this.txt_sp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sp.Location = new System.Drawing.Point(404, 13);
            this.txt_sp.Name = "txt_sp";
            this.txt_sp.ReadOnly = true;
            this.txt_sp.Size = new System.Drawing.Size(138, 20);
            this.txt_sp.TabIndex = 298;
            this.txt_sp.Text = "BPVS_TRASLADOS_CAB";
            this.txt_sp.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(257, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 14);
            this.label15.TabIndex = 297;
            this.label15.Text = "Stored Procedure Cabecera :";
            this.label15.Visible = false;
            // 
            // btn_ejecutar_SP
            // 
            this.btn_ejecutar_SP.BackgroundImage = global::MISAP.Properties.Resources.btn_enfasis_dasactivado;
            this.btn_ejecutar_SP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ejecutar_SP.Enabled = false;
            this.btn_ejecutar_SP.FlatAppearance.BorderSize = 0;
            this.btn_ejecutar_SP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ejecutar_SP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ejecutar_SP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ejecutar_SP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ejecutar_SP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ejecutar_SP.Location = new System.Drawing.Point(7, 11);
            this.btn_ejecutar_SP.Name = "btn_ejecutar_SP";
            this.btn_ejecutar_SP.Size = new System.Drawing.Size(72, 22);
            this.btn_ejecutar_SP.TabIndex = 301;
            this.btn_ejecutar_SP.Text = "Ejecutar";
            this.btn_ejecutar_SP.UseVisualStyleBackColor = true;
            this.btn_ejecutar_SP.Click += new System.EventHandler(this.btn_ejecutar_SP_Click);
            // 
            // btn_abrir_plantilla
            // 
            this.btn_abrir_plantilla.BackgroundImage = global::MISAP.Properties.Resources.btn_enfasis_dasactivado;
            this.btn_abrir_plantilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_abrir_plantilla.Enabled = false;
            this.btn_abrir_plantilla.FlatAppearance.BorderSize = 0;
            this.btn_abrir_plantilla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_abrir_plantilla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_abrir_plantilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abrir_plantilla.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abrir_plantilla.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_abrir_plantilla.Location = new System.Drawing.Point(85, 11);
            this.btn_abrir_plantilla.Name = "btn_abrir_plantilla";
            this.btn_abrir_plantilla.Size = new System.Drawing.Size(77, 22);
            this.btn_abrir_plantilla.TabIndex = 302;
            this.btn_abrir_plantilla.Text = "Abrir plantilla";
            this.btn_abrir_plantilla.UseVisualStyleBackColor = true;
            // 
            // t_msg
            // 
            this.t_msg.Interval = 3000;
            this.t_msg.Tick += new System.EventHandler(this.t_msg_Tick);
            // 
            // ss_load
            // 
            this.ss_load.AutoSize = false;
            this.ss_load.BackColor = System.Drawing.Color.Transparent;
            this.ss_load.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ss_load.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ss_load.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_maximi,
            this.lbl_contador_registros,
            this.lbl_U_CL_CODSOL,
            this.lbl_U_CL_SOLICI,
            this.lbl_msg});
            this.ss_load.Location = new System.Drawing.Point(0, 616);
            this.ss_load.Name = "ss_load";
            this.ss_load.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ss_load.Size = new System.Drawing.Size(856, 18);
            this.ss_load.SizingGrip = false;
            this.ss_load.TabIndex = 278;
            this.ss_load.Text = "statusStrip1";
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
            // lbl_contador_registros
            // 
            this.lbl_contador_registros.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.lbl_contador_registros.BackColor = System.Drawing.Color.Transparent;
            this.lbl_contador_registros.Name = "lbl_contador_registros";
            this.lbl_contador_registros.Size = new System.Drawing.Size(420, 13);
            this.lbl_contador_registros.Spring = true;
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
            this.lbl_msg.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.lbl_msg.AutoSize = false;
            this.lbl_msg.BackColor = System.Drawing.Color.Transparent;
            this.lbl_msg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lbl_msg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lbl_msg.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.ForeColor = System.Drawing.Color.White;
            this.lbl_msg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_msg.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(420, 13);
            this.lbl_msg.Spring = true;
            this.lbl_msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_grabar
            // 
            this.btn_grabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_grabar.BackgroundImage = global::MISAP.Properties.Resources.btn_enfasis_dasactivado;
            this.btn_grabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_grabar.Enabled = false;
            this.btn_grabar.FlatAppearance.BorderSize = 0;
            this.btn_grabar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_grabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grabar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grabar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_grabar.Location = new System.Drawing.Point(4, 583);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(75, 22);
            this.btn_grabar.TabIndex = 261;
            this.btn_grabar.Text = "Crear";
            this.btn_grabar.UseVisualStyleBackColor = true;
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
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
            this.btn_cancelar.Location = new System.Drawing.Point(85, 583);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 22);
            this.btn_cancelar.TabIndex = 262;
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
            this.titulo.Size = new System.Drawing.Size(856, 27);
            this.titulo.TabIndex = 256;
            this.titulo.Text = "toolStrip1";
            this.titulo.DoubleClick += new System.EventHandler(this.titulo_DoubleClick);
            this.titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            // 
            // tsl_titulo
            // 
            this.tsl_titulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsl_titulo.Name = "tsl_titulo";
            this.tsl_titulo.Size = new System.Drawing.Size(215, 24);
            this.tsl_titulo.Text = "Requerimiento de materiales y servicios";
            this.tsl_titulo.DoubleClick += new System.EventHandler(this.titulo_DoubleClick);
            this.tsl_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            this.tsl_titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseMove);
            this.tsl_titulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseUp);
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
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 634);
            this.ControlBox = false;
            this.Controls.Add(this.ss_load);
            this.Controls.Add(this.tc_pedido);
            this.Controls.Add(this.btn_grabar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.ts_acciones);
            this.Controls.Add(this.titulo);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmPedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.ts_acciones.ResumeLayout(false);
            this.ts_acciones.PerformLayout();
            this.tc_pedido.ResumeLayout(false);
            this.tp_listado.ResumeLayout(false);
            this.tp_listado.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).EndInit();
            this.cm_grilla.ResumeLayout(false);
            this.tp_nuevo.ResumeLayout(false);
            this.tp_nuevo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_det_pedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_det_pedidos_consulta)).EndInit();
            this.tp_auditoria.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tp_plantilla.ResumeLayout(false);
            this.tp_plantilla.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_plantilla)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_plantilla_d)).EndInit();
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
        private System.Windows.Forms.Button btn_grabar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_num_ord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_responsable;
        private System.Windows.Forms.TabControl tc_pedido;
        private System.Windows.Forms.TabPage tp_listado;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridView dgv_pedidos;
        private System.Windows.Forms.TabPage tp_nuevo;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txtexaminar;
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
        private System.Windows.Forms.DataGridView dgv_det_pedidos;
        private System.Windows.Forms.Button btn_suprimir;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DateTimePicker dp_fecha_necesaria;
        private System.Windows.Forms.TextBox txt_obs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbo_anio;
        private System.Windows.Forms.RadioButton rb_servicios;
        private System.Windows.Forms.RadioButton rb_materiales;
        private System.Windows.Forms.RadioButton rb_servicios_l;
        private System.Windows.Forms.RadioButton rb_materiales_l;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.ToolStripButton btn_plantilla;
        private System.Windows.Forms.TabPage tp_plantilla;
        private System.Windows.Forms.TextBox txt_sp_d;
        private System.Windows.Forms.TextBox txt_sp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_plantilla;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_plantilla_d;
        private System.Windows.Forms.Button btn_ejecutar_SP;
        private System.Windows.Forms.Button btn_abrir_plantilla;
        private System.Windows.Forms.TextBox txt_responsable;
        private System.Windows.Forms.TextBox txt_ot;
        private System.Windows.Forms.Label lbl_pedido;
        private System.Windows.Forms.TextBox txt_pedido;
        private System.Windows.Forms.TextBox txt_tipo_l;
        private System.Windows.Forms.DataGridView dgv_det_pedidos_consulta;
        private System.Windows.Forms.TextBox cdg_origen;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_requerimiento;
        private System.Windows.Forms.ToolStripButton btn_primero;
        private System.Windows.Forms.ToolStripButton btn_anterior;
        private System.Windows.Forms.ToolStripButton btn_siguiente;
        private System.Windows.Forms.ToolStripButton btn_utlimo;
        private System.Windows.Forms.ToolStripButton btn_filtro;
        private System.Windows.Forms.TextBox txt_U_CL_CODSOL;
        private System.Windows.Forms.TextBox txt_U_CDG_USER;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_U_CL_SOLICI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccion;
        private System.Windows.Forms.TextBox txt_proyecto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_cod_proyecto;
        private System.Windows.Forms.TextBox txt_cod_ot;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rb_activos;
        private System.Windows.Forms.RadioButton rb_activos_l;
        private System.Windows.Forms.ContextMenuStrip cm_grilla;
        private System.Windows.Forms.ToolStripMenuItem cm_grilla_copia;
        private System.Windows.Forms.ToolStripMenuItem cm_grilla_copia_tabla;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem logDeModificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox txt_DocEntry;
        private System.Windows.Forms.Timer t_msg;
        private System.Windows.Forms.StatusStrip ss_load;
        private System.Windows.Forms.ToolStripStatusLabel lbl_maximi;
        private System.Windows.Forms.ToolStripStatusLabel lbl_contador_registros;
        private System.Windows.Forms.ToolStripStatusLabel lbl_U_CL_CODSOL;
        private System.Windows.Forms.ToolStripStatusLabel lbl_U_CL_SOLICI;
        private System.Windows.Forms.ToolStripStatusLabel lbl_msg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdgprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn med;
        private System.Windows.Forms.DataGridViewTextBoxColumn canped;
        private System.Windows.Forms.DataGridViewTextBoxColumn candesp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Familia;
        private System.Windows.Forms.TextBox txt_flag_activo_ti;
        private System.Windows.Forms.TextBox txt_codigo_autorizacion;
        private System.Windows.Forms.Label lbl_aprobado;
        private System.Windows.Forms.TextBox txt_aprobado_por;
        private System.ServiceProcess.ServiceController serviceController1;
    }
}