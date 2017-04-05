namespace MISAP
{
    partial class FrmDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDocumentos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ss_load = new System.Windows.Forms.StatusStrip();
            this.lbl_contador_registros = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_CODSOL = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_SOLICI = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_msg = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_maximi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_origen = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.tc_detalle = new System.Windows.Forms.TabControl();
            this.tp_contenido = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_SaldoPendiente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ImporteAplicado = new System.Windows.Forms.TextBox();
            this.chk_igv = new System.Windows.Forms.CheckBox();
            this.lbl_moneda = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_retencion = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.txt_CurrCode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_impuesto = new System.Windows.Forms.TextBox();
            this.cbo_CurrName = new System.Windows.Forms.ComboBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_SubTotal = new System.Windows.Forms.TextBox();
            this.chk_GuiaRemision = new System.Windows.Forms.CheckBox();
            this.txt_GuiaRemision = new System.Windows.Forms.TextBox();
            this.chk_NotaIngreso = new System.Windows.Forms.CheckBox();
            this.txt_NotaIngreso = new System.Windows.Forms.TextBox();
            this.chk_OS = new System.Windows.Forms.CheckBox();
            this.txt_OS = new System.Windows.Forms.TextBox();
            this.chk_OC = new System.Windows.Forms.CheckBox();
            this.txt_OC = new System.Windows.Forms.TextBox();
            this.chk_NroLetra = new System.Windows.Forms.CheckBox();
            this.txt_NroLetra = new System.Windows.Forms.TextBox();
            this.chk_DocReferencia = new System.Windows.Forms.CheckBox();
            this.txt_DocReferencia = new System.Windows.Forms.TextBox();
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
            this.btn_borrar_anexo = new System.Windows.Forms.Button();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.btn_explorar = new System.Windows.Forms.Button();
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
            this.txt_TipoDocumento = new System.Windows.Forms.TextBox();
            this.cm_grilla = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cm_grilla_copia = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_grilla_copia_tabla = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_CardCode = new System.Windows.Forms.Label();
            this.t_msg = new System.Windows.Forms.Timer(this.components);
            this.txt_CardCode = new System.Windows.Forms.TextBox();
            this.txt_Observaciones = new System.Windows.Forms.TextBox();
            this.lbl_Observaciones = new System.Windows.Forms.Label();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CardName = new System.Windows.Forms.TextBox();
            this.lbl_tdoc = new System.Windows.Forms.Label();
            this.lbl_numerodoc = new System.Windows.Forms.Label();
            this.txt_serie = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.dp_FechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_vencimiento = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_idreg = new System.Windows.Forms.TextBox();
            this.dp_FechaRecepcion = new System.Windows.Forms.DateTimePicker();
            this.dp_FechaDocumento = new System.Windows.Forms.DateTimePicker();
            this.txt_U_CL_DESCRI = new System.Windows.Forms.TextBox();
            this.lbl_ot = new System.Windows.Forms.Label();
            this.txt_PrcCode = new System.Windows.Forms.TextBox();
            this.txt_estadodoc = new System.Windows.Forms.TextBox();
            this.lbl_prioridad = new System.Windows.Forms.Label();
            this.cbo_prioridad = new System.Windows.Forms.ComboBox();
            this.txt_prioridad = new System.Windows.Forms.TextBox();
            this.cm_formulario = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmi_eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_FechaRecepcion = new System.Windows.Forms.TextBox();
            this.txt_FechaVencimiento = new System.Windows.Forms.TextBox();
            this.txt_FechaDocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_numref = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DocDate = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_DocNum = new System.Windows.Forms.TextBox();
            this.btn_cargo = new System.Windows.Forms.Button();
            this.btn_opciones_3 = new System.Windows.Forms.Button();
            this.btn_opciones_2 = new System.Windows.Forms.Button();
            this.btn_opciones = new System.Windows.Forms.Button();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.ToolStrip();
            this.tsl_titulo = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.maximizar = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            this.ss_load.SuspendLayout();
            this.ts_acciones.SuspendLayout();
            this.tc_detalle.SuspendLayout();
            this.tp_contenido.SuspendLayout();
            this.tp_anexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_anexo_consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_anexo)).BeginInit();
            this.tp_listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).BeginInit();
            this.tp_auditoria.SuspendLayout();
            this.cm_grilla.SuspendLayout();
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
            this.tc_detalle.Location = new System.Drawing.Point(12, 262);
            this.tc_detalle.Name = "tc_detalle";
            this.tc_detalle.SelectedIndex = 0;
            this.tc_detalle.Size = new System.Drawing.Size(682, 223);
            this.tc_detalle.TabIndex = 344;
            // 
            // tp_contenido
            // 
            this.tp_contenido.AutoScroll = true;
            this.tp_contenido.BackColor = System.Drawing.SystemColors.Control;
            this.tp_contenido.Controls.Add(this.label11);
            this.tp_contenido.Controls.Add(this.txt_SaldoPendiente);
            this.tp_contenido.Controls.Add(this.label8);
            this.tp_contenido.Controls.Add(this.txt_ImporteAplicado);
            this.tp_contenido.Controls.Add(this.chk_igv);
            this.tp_contenido.Controls.Add(this.lbl_moneda);
            this.tp_contenido.Controls.Add(this.label20);
            this.tp_contenido.Controls.Add(this.txt_retencion);
            this.tp_contenido.Controls.Add(this.label19);
            this.tp_contenido.Controls.Add(this.txt_Total);
            this.tp_contenido.Controls.Add(this.txt_CurrCode);
            this.tp_contenido.Controls.Add(this.label14);
            this.tp_contenido.Controls.Add(this.label9);
            this.tp_contenido.Controls.Add(this.txt_impuesto);
            this.tp_contenido.Controls.Add(this.cbo_CurrName);
            this.tp_contenido.Controls.Add(this.lbl_total);
            this.tp_contenido.Controls.Add(this.txt_SubTotal);
            this.tp_contenido.Controls.Add(this.chk_GuiaRemision);
            this.tp_contenido.Controls.Add(this.txt_GuiaRemision);
            this.tp_contenido.Controls.Add(this.chk_NotaIngreso);
            this.tp_contenido.Controls.Add(this.txt_NotaIngreso);
            this.tp_contenido.Controls.Add(this.chk_OS);
            this.tp_contenido.Controls.Add(this.txt_OS);
            this.tp_contenido.Controls.Add(this.chk_OC);
            this.tp_contenido.Controls.Add(this.txt_OC);
            this.tp_contenido.Controls.Add(this.chk_NroLetra);
            this.tp_contenido.Controls.Add(this.txt_NroLetra);
            this.tp_contenido.Controls.Add(this.chk_DocReferencia);
            this.tp_contenido.Controls.Add(this.txt_DocReferencia);
            this.tp_contenido.Controls.Add(this.label18);
            this.tp_contenido.Location = new System.Drawing.Point(4, 20);
            this.tp_contenido.Name = "tp_contenido";
            this.tp_contenido.Padding = new System.Windows.Forms.Padding(3);
            this.tp_contenido.Size = new System.Drawing.Size(674, 199);
            this.tp_contenido.TabIndex = 0;
            this.tp_contenido.Text = "Contenido";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(361, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 15);
            this.label11.TabIndex = 410;
            this.label11.Text = "Saldo pendiente";
            // 
            // txt_SaldoPendiente
            // 
            this.txt_SaldoPendiente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SaldoPendiente.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_SaldoPendiente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SaldoPendiente.Location = new System.Drawing.Point(521, 170);
            this.txt_SaldoPendiente.Name = "txt_SaldoPendiente";
            this.txt_SaldoPendiente.ReadOnly = true;
            this.txt_SaldoPendiente.Size = new System.Drawing.Size(143, 21);
            this.txt_SaldoPendiente.TabIndex = 409;
            this.txt_SaldoPendiente.Text = "0";
            this.txt_SaldoPendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(361, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 15);
            this.label8.TabIndex = 408;
            this.label8.Text = "Importe aplicado";
            // 
            // txt_ImporteAplicado
            // 
            this.txt_ImporteAplicado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ImporteAplicado.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_ImporteAplicado.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ImporteAplicado.Location = new System.Drawing.Point(521, 148);
            this.txt_ImporteAplicado.Name = "txt_ImporteAplicado";
            this.txt_ImporteAplicado.ReadOnly = true;
            this.txt_ImporteAplicado.Size = new System.Drawing.Size(143, 21);
            this.txt_ImporteAplicado.TabIndex = 407;
            this.txt_ImporteAplicado.Text = "0";
            this.txt_ImporteAplicado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chk_igv
            // 
            this.chk_igv.AutoSize = true;
            this.chk_igv.Checked = true;
            this.chk_igv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_igv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_igv.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_igv.Location = new System.Drawing.Point(424, 86);
            this.chk_igv.Name = "chk_igv";
            this.chk_igv.Size = new System.Drawing.Size(48, 17);
            this.chk_igv.TabIndex = 406;
            this.chk_igv.Text = "I.G.V";
            this.chk_igv.UseVisualStyleBackColor = true;
            this.chk_igv.CheckedChanged += new System.EventHandler(this.chk_igv_CheckedChanged);
            // 
            // lbl_moneda
            // 
            this.lbl_moneda.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moneda.Location = new System.Drawing.Point(361, 45);
            this.lbl_moneda.Name = "lbl_moneda";
            this.lbl_moneda.Size = new System.Drawing.Size(124, 14);
            this.lbl_moneda.TabIndex = 397;
            this.lbl_moneda.Text = "Moneda";
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(361, 111);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(124, 14);
            this.label20.TabIndex = 405;
            this.label20.Text = "Retencion";
            // 
            // txt_retencion
            // 
            this.txt_retencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_retencion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_retencion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_retencion.Location = new System.Drawing.Point(521, 104);
            this.txt_retencion.Name = "txt_retencion";
            this.txt_retencion.Size = new System.Drawing.Size(143, 21);
            this.txt_retencion.TabIndex = 404;
            this.txt_retencion.Text = "0";
            this.txt_retencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(361, 132);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(143, 15);
            this.label19.TabIndex = 403;
            this.label19.Text = "Total del documento";
            // 
            // txt_Total
            // 
            this.txt_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Total.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Total.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.Location = new System.Drawing.Point(521, 126);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(143, 21);
            this.txt_Total.TabIndex = 402;
            this.txt_Total.Text = "0";
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_CurrCode
            // 
            this.txt_CurrCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CurrCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_CurrCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CurrCode.Location = new System.Drawing.Point(485, 40);
            this.txt_CurrCode.Name = "txt_CurrCode";
            this.txt_CurrCode.Size = new System.Drawing.Size(30, 21);
            this.txt_CurrCode.TabIndex = 378;
            this.txt_CurrCode.Tag = "ingrese";
            this.txt_CurrCode.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(361, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 13);
            this.label14.TabIndex = 401;
            this.label14.Text = "Montos del documento";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(361, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 14);
            this.label9.TabIndex = 399;
            this.label9.Text = "Impuesto";
            // 
            // txt_impuesto
            // 
            this.txt_impuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_impuesto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_impuesto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_impuesto.Location = new System.Drawing.Point(521, 82);
            this.txt_impuesto.Name = "txt_impuesto";
            this.txt_impuesto.ReadOnly = true;
            this.txt_impuesto.Size = new System.Drawing.Size(143, 21);
            this.txt_impuesto.TabIndex = 398;
            this.txt_impuesto.Text = "0";
            this.txt_impuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbo_CurrName
            // 
            this.cbo_CurrName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_CurrName.FormattingEnabled = true;
            this.cbo_CurrName.Location = new System.Drawing.Point(521, 37);
            this.cbo_CurrName.Name = "cbo_CurrName";
            this.cbo_CurrName.Size = new System.Drawing.Size(143, 21);
            this.cbo_CurrName.TabIndex = 385;
            this.cbo_CurrName.SelectionChangeCommitted += new System.EventHandler(this.cbo_CurrName_SelectionChangeCommitted);
            // 
            // lbl_total
            // 
            this.lbl_total.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(361, 66);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(143, 15);
            this.lbl_total.TabIndex = 397;
            this.lbl_total.Text = "Total antes del descuento";
            // 
            // txt_SubTotal
            // 
            this.txt_SubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SubTotal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_SubTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SubTotal.Location = new System.Drawing.Point(521, 60);
            this.txt_SubTotal.Name = "txt_SubTotal";
            this.txt_SubTotal.Size = new System.Drawing.Size(143, 21);
            this.txt_SubTotal.TabIndex = 396;
            this.txt_SubTotal.Text = "0";
            this.txt_SubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_SubTotal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_SubTotal_MouseClick);
            this.txt_SubTotal.TextChanged += new System.EventHandler(this.txt_SubTotal_TextChanged);
            this.txt_SubTotal.Enter += new System.EventHandler(this.txt_SubTotal_Enter);
            // 
            // chk_GuiaRemision
            // 
            this.chk_GuiaRemision.AutoSize = true;
            this.chk_GuiaRemision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_GuiaRemision.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_GuiaRemision.Location = new System.Drawing.Point(12, 147);
            this.chk_GuiaRemision.Name = "chk_GuiaRemision";
            this.chk_GuiaRemision.Size = new System.Drawing.Size(101, 17);
            this.chk_GuiaRemision.TabIndex = 291;
            this.chk_GuiaRemision.Text = "Guia de remision";
            this.chk_GuiaRemision.UseVisualStyleBackColor = true;
            this.chk_GuiaRemision.CheckedChanged += new System.EventHandler(this.chk_GuiaRemision_CheckedChanged);
            // 
            // txt_GuiaRemision
            // 
            this.txt_GuiaRemision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_GuiaRemision.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_GuiaRemision.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GuiaRemision.Location = new System.Drawing.Point(115, 143);
            this.txt_GuiaRemision.Name = "txt_GuiaRemision";
            this.txt_GuiaRemision.ReadOnly = true;
            this.txt_GuiaRemision.Size = new System.Drawing.Size(143, 21);
            this.txt_GuiaRemision.TabIndex = 290;
            this.txt_GuiaRemision.Tag = "ingrese";
            // 
            // chk_NotaIngreso
            // 
            this.chk_NotaIngreso.AutoSize = true;
            this.chk_NotaIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_NotaIngreso.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_NotaIngreso.Location = new System.Drawing.Point(12, 125);
            this.chk_NotaIngreso.Name = "chk_NotaIngreso";
            this.chk_NotaIngreso.Size = new System.Drawing.Size(99, 17);
            this.chk_NotaIngreso.TabIndex = 289;
            this.chk_NotaIngreso.Text = "Nota de ingreso";
            this.chk_NotaIngreso.UseVisualStyleBackColor = true;
            this.chk_NotaIngreso.CheckedChanged += new System.EventHandler(this.chk_NotaIngreso_CheckedChanged);
            // 
            // txt_NotaIngreso
            // 
            this.txt_NotaIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NotaIngreso.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_NotaIngreso.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NotaIngreso.Location = new System.Drawing.Point(115, 121);
            this.txt_NotaIngreso.Name = "txt_NotaIngreso";
            this.txt_NotaIngreso.ReadOnly = true;
            this.txt_NotaIngreso.Size = new System.Drawing.Size(143, 21);
            this.txt_NotaIngreso.TabIndex = 288;
            this.txt_NotaIngreso.Tag = "ingrese";
            this.txt_NotaIngreso.TextChanged += new System.EventHandler(this.txt_NotaIngreso_TextChanged);
            // 
            // chk_OS
            // 
            this.chk_OS.AutoSize = true;
            this.chk_OS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_OS.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_OS.Location = new System.Drawing.Point(12, 103);
            this.chk_OS.Name = "chk_OS";
            this.chk_OS.Size = new System.Drawing.Size(92, 17);
            this.chk_OS.TabIndex = 287;
            this.chk_OS.Text = "Orden servicio";
            this.chk_OS.UseVisualStyleBackColor = true;
            this.chk_OS.CheckedChanged += new System.EventHandler(this.chk_OS_CheckedChanged);
            // 
            // txt_OS
            // 
            this.txt_OS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_OS.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_OS.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OS.Location = new System.Drawing.Point(115, 99);
            this.txt_OS.Name = "txt_OS";
            this.txt_OS.ReadOnly = true;
            this.txt_OS.Size = new System.Drawing.Size(143, 21);
            this.txt_OS.TabIndex = 286;
            this.txt_OS.Tag = "ingrese";
            // 
            // chk_OC
            // 
            this.chk_OC.AutoSize = true;
            this.chk_OC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_OC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_OC.Location = new System.Drawing.Point(12, 81);
            this.chk_OC.Name = "chk_OC";
            this.chk_OC.Size = new System.Drawing.Size(91, 17);
            this.chk_OC.TabIndex = 285;
            this.chk_OC.Text = "Orden compra";
            this.chk_OC.UseVisualStyleBackColor = true;
            this.chk_OC.CheckedChanged += new System.EventHandler(this.chk_OC_CheckedChanged);
            // 
            // txt_OC
            // 
            this.txt_OC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_OC.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_OC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OC.Location = new System.Drawing.Point(115, 77);
            this.txt_OC.Name = "txt_OC";
            this.txt_OC.ReadOnly = true;
            this.txt_OC.Size = new System.Drawing.Size(143, 21);
            this.txt_OC.TabIndex = 284;
            this.txt_OC.Tag = "ingrese";
            // 
            // chk_NroLetra
            // 
            this.chk_NroLetra.AutoSize = true;
            this.chk_NroLetra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_NroLetra.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_NroLetra.Location = new System.Drawing.Point(12, 59);
            this.chk_NroLetra.Name = "chk_NroLetra";
            this.chk_NroLetra.Size = new System.Drawing.Size(75, 17);
            this.chk_NroLetra.TabIndex = 283;
            this.chk_NroLetra.Text = "Nº de letra";
            this.chk_NroLetra.UseVisualStyleBackColor = true;
            this.chk_NroLetra.CheckedChanged += new System.EventHandler(this.chk_NroLetra_CheckedChanged);
            // 
            // txt_NroLetra
            // 
            this.txt_NroLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NroLetra.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_NroLetra.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NroLetra.Location = new System.Drawing.Point(115, 55);
            this.txt_NroLetra.Name = "txt_NroLetra";
            this.txt_NroLetra.ReadOnly = true;
            this.txt_NroLetra.Size = new System.Drawing.Size(143, 21);
            this.txt_NroLetra.TabIndex = 282;
            this.txt_NroLetra.Tag = "ingrese";
            // 
            // chk_DocReferencia
            // 
            this.chk_DocReferencia.AutoSize = true;
            this.chk_DocReferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_DocReferencia.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_DocReferencia.Location = new System.Drawing.Point(12, 37);
            this.chk_DocReferencia.Name = "chk_DocReferencia";
            this.chk_DocReferencia.Size = new System.Drawing.Size(97, 17);
            this.chk_DocReferencia.TabIndex = 281;
            this.chk_DocReferencia.Text = "Doc. referencia";
            this.chk_DocReferencia.UseVisualStyleBackColor = true;
            this.chk_DocReferencia.CheckedChanged += new System.EventHandler(this.chk_DocReferencia_CheckedChanged);
            // 
            // txt_DocReferencia
            // 
            this.txt_DocReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DocReferencia.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_DocReferencia.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DocReferencia.Location = new System.Drawing.Point(115, 33);
            this.txt_DocReferencia.Name = "txt_DocReferencia";
            this.txt_DocReferencia.ReadOnly = true;
            this.txt_DocReferencia.Size = new System.Drawing.Size(143, 21);
            this.txt_DocReferencia.TabIndex = 255;
            this.txt_DocReferencia.Tag = "ingrese";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(11, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(156, 13);
            this.label18.TabIndex = 254;
            this.label18.Text = "Documentos relacionados:";
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
            this.tp_anexo.Size = new System.Drawing.Size(674, 199);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_anexo_consulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_anexo_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_anexo_consulta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_anexo_consulta.EnableHeadersVisualStyles = false;
            this.dgv_anexo_consulta.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_anexo_consulta.Location = new System.Drawing.Point(16, 17);
            this.dgv_anexo_consulta.Name = "dgv_anexo_consulta";
            this.dgv_anexo_consulta.ReadOnly = true;
            this.dgv_anexo_consulta.Size = new System.Drawing.Size(535, 176);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_anexo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_anexo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_anexo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ruta_,
            this.archivo_,
            this.fecha_,
            this.extension_,
            this.AbsEntry,
            this.line,
            this.local_r});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_anexo.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_anexo.EnableHeadersVisualStyles = false;
            this.dgv_anexo.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_anexo.Location = new System.Drawing.Point(16, 17);
            this.dgv_anexo.Name = "dgv_anexo";
            this.dgv_anexo.ReadOnly = true;
            this.dgv_anexo.Size = new System.Drawing.Size(535, 176);
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
            // btn_borrar_anexo
            // 
            this.btn_borrar_anexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_borrar_anexo.BackgroundImage = global::MISAP.Properties.Resources.btn_desactivado;
            this.btn_borrar_anexo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar_anexo.Enabled = false;
            this.btn_borrar_anexo.FlatAppearance.BorderSize = 0;
            this.btn_borrar_anexo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_borrar_anexo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_borrar_anexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar_anexo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar_anexo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_borrar_anexo.Location = new System.Drawing.Point(567, 147);
            this.btn_borrar_anexo.Name = "btn_borrar_anexo";
            this.btn_borrar_anexo.Size = new System.Drawing.Size(71, 21);
            this.btn_borrar_anexo.TabIndex = 361;
            this.btn_borrar_anexo.Text = "Borrar";
            this.btn_borrar_anexo.UseVisualStyleBackColor = true;
            this.btn_borrar_anexo.Click += new System.EventHandler(this.btn_borrar_anexo_Click);
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btn_explorar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            // tp_listado
            // 
            this.tp_listado.BackColor = System.Drawing.SystemColors.Control;
            this.tp_listado.Controls.Add(this.dgv_lista);
            this.tp_listado.Location = new System.Drawing.Point(4, 20);
            this.tp_listado.Name = "tp_listado";
            this.tp_listado.Padding = new System.Windows.Forms.Padding(3);
            this.tp_listado.Size = new System.Drawing.Size(674, 199);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_lista.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_lista.EnableHeadersVisualStyles = false;
            this.dgv_lista.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_lista.Location = new System.Drawing.Point(7, 15);
            this.dgv_lista.Name = "dgv_lista";
            this.dgv_lista.Size = new System.Drawing.Size(657, 178);
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
            this.tp_auditoria.Size = new System.Drawing.Size(674, 199);
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
            // txt_TipoDocumento
            // 
            this.txt_TipoDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TipoDocumento.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_TipoDocumento.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TipoDocumento.Location = new System.Drawing.Point(133, 148);
            this.txt_TipoDocumento.Name = "txt_TipoDocumento";
            this.txt_TipoDocumento.Size = new System.Drawing.Size(143, 21);
            this.txt_TipoDocumento.TabIndex = 3;
            this.txt_TipoDocumento.Tag = "ingrese";
            this.txt_TipoDocumento.Enter += new System.EventHandler(this.txt_TipoDocumento_Enter);
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
            // lbl_CardCode
            // 
            this.lbl_CardCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CardCode.Location = new System.Drawing.Point(9, 89);
            this.lbl_CardCode.Name = "lbl_CardCode";
            this.lbl_CardCode.Size = new System.Drawing.Size(124, 14);
            this.lbl_CardCode.TabIndex = 347;
            this.lbl_CardCode.Text = "Proveedor";
            // 
            // t_msg
            // 
            this.t_msg.Interval = 5000;
            this.t_msg.Tick += new System.EventHandler(this.t_msg_Tick);
            // 
            // txt_CardCode
            // 
            this.txt_CardCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CardCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_CardCode.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CardCode.Location = new System.Drawing.Point(133, 82);
            this.txt_CardCode.Name = "txt_CardCode";
            this.txt_CardCode.Size = new System.Drawing.Size(143, 21);
            this.txt_CardCode.TabIndex = 0;
            this.txt_CardCode.Tag = "ingrese";
            this.txt_CardCode.Enter += new System.EventHandler(this.txt_CardCode_Enter);
            this.txt_CardCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idreg_KeyPress);
            this.txt_CardCode.Leave += new System.EventHandler(this.txt_IdActivo_Leave);
            // 
            // txt_Observaciones
            // 
            this.txt_Observaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Observaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Observaciones.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Observaciones.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Observaciones.Location = new System.Drawing.Point(133, 491);
            this.txt_Observaciones.Multiline = true;
            this.txt_Observaciones.Name = "txt_Observaciones";
            this.txt_Observaciones.Size = new System.Drawing.Size(143, 42);
            this.txt_Observaciones.TabIndex = 374;
            this.txt_Observaciones.Tag = "ingrese";
            // 
            // lbl_Observaciones
            // 
            this.lbl_Observaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Observaciones.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Observaciones.Location = new System.Drawing.Point(9, 496);
            this.lbl_Observaciones.Name = "lbl_Observaciones";
            this.lbl_Observaciones.Size = new System.Drawing.Size(124, 14);
            this.lbl_Observaciones.TabIndex = 375;
            this.lbl_Observaciones.Text = "Observaciones";
            // 
            // txt_Code
            // 
            this.txt_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Code.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Code.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Code.Location = new System.Drawing.Point(282, 148);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(30, 21);
            this.txt_Code.TabIndex = 387;
            this.txt_Code.Tag = "ingrese";
            this.txt_Code.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 14);
            this.label1.TabIndex = 388;
            this.label1.Text = "Nombre";
            // 
            // txt_CardName
            // 
            this.txt_CardName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CardName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_CardName.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CardName.Location = new System.Drawing.Point(133, 104);
            this.txt_CardName.Name = "txt_CardName";
            this.txt_CardName.ReadOnly = true;
            this.txt_CardName.Size = new System.Drawing.Size(208, 21);
            this.txt_CardName.TabIndex = 389;
            this.txt_CardName.Tag = "ingrese";
            // 
            // lbl_tdoc
            // 
            this.lbl_tdoc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tdoc.Location = new System.Drawing.Point(9, 157);
            this.lbl_tdoc.Name = "lbl_tdoc";
            this.lbl_tdoc.Size = new System.Drawing.Size(124, 14);
            this.lbl_tdoc.TabIndex = 390;
            this.lbl_tdoc.Text = "Tipo de documento";
            // 
            // lbl_numerodoc
            // 
            this.lbl_numerodoc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numerodoc.Location = new System.Drawing.Point(9, 179);
            this.lbl_numerodoc.Name = "lbl_numerodoc";
            this.lbl_numerodoc.Size = new System.Drawing.Size(124, 14);
            this.lbl_numerodoc.TabIndex = 392;
            this.lbl_numerodoc.Text = "Numero de documento";
            // 
            // txt_serie
            // 
            this.txt_serie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_serie.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_serie.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serie.Location = new System.Drawing.Point(133, 170);
            this.txt_serie.Name = "txt_serie";
            this.txt_serie.Size = new System.Drawing.Size(33, 21);
            this.txt_serie.TabIndex = 393;
            this.txt_serie.Tag = "ingrese";
            // 
            // txt_numero
            // 
            this.txt_numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_numero.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_numero.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(167, 170);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(109, 21);
            this.txt_numero.TabIndex = 394;
            this.txt_numero.Tag = "ingrese";
            // 
            // lbl_hora
            // 
            this.lbl_hora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_hora.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.Location = new System.Drawing.Point(383, 173);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(124, 14);
            this.lbl_hora.TabIndex = 386;
            this.lbl_hora.Text = "Fecha del documento";
            // 
            // dp_FechaVencimiento
            // 
            this.dp_FechaVencimiento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dp_FechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_FechaVencimiento.Location = new System.Drawing.Point(669, 144);
            this.dp_FechaVencimiento.Name = "dp_FechaVencimiento";
            this.dp_FechaVencimiento.Size = new System.Drawing.Size(17, 21);
            this.dp_FechaVencimiento.TabIndex = 378;
            this.dp_FechaVencimiento.ValueChanged += new System.EventHandler(this.dp_FechaVencimiento_ValueChanged);
            // 
            // lbl_fecha_vencimiento
            // 
            this.lbl_fecha_vencimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_fecha_vencimiento.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_vencimiento.Location = new System.Drawing.Point(383, 150);
            this.lbl_fecha_vencimiento.Name = "lbl_fecha_vencimiento";
            this.lbl_fecha_vencimiento.Size = new System.Drawing.Size(124, 14);
            this.lbl_fecha_vencimiento.TabIndex = 385;
            this.lbl_fecha_vencimiento.Text = "Fecha de vencimiento";
            // 
            // label17
            // 
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(383, 128);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 14);
            this.label17.TabIndex = 383;
            this.label17.Text = "Fecha de recepcion";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(383, 106);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 14);
            this.label16.TabIndex = 382;
            this.label16.Text = "Estado";
            // 
            // txt_estado
            // 
            this.txt_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_estado.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_estado.Location = new System.Drawing.Point(543, 100);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.ReadOnly = true;
            this.txt_estado.Size = new System.Drawing.Size(143, 21);
            this.txt_estado.TabIndex = 381;
            this.txt_estado.Text = "Pendiente";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(383, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 14);
            this.label15.TabIndex = 380;
            this.label15.Text = "Nº";
            // 
            // txt_idreg
            // 
            this.txt_idreg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_idreg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_idreg.Location = new System.Drawing.Point(543, 78);
            this.txt_idreg.Name = "txt_idreg";
            this.txt_idreg.ReadOnly = true;
            this.txt_idreg.Size = new System.Drawing.Size(143, 21);
            this.txt_idreg.TabIndex = 379;
            this.txt_idreg.Enter += new System.EventHandler(this.txt_idreg_Enter);
            this.txt_idreg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idreg_KeyPress);
            // 
            // dp_FechaRecepcion
            // 
            this.dp_FechaRecepcion.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dp_FechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_FechaRecepcion.Location = new System.Drawing.Point(669, 122);
            this.dp_FechaRecepcion.Name = "dp_FechaRecepcion";
            this.dp_FechaRecepcion.Size = new System.Drawing.Size(17, 21);
            this.dp_FechaRecepcion.TabIndex = 395;
            this.dp_FechaRecepcion.ValueChanged += new System.EventHandler(this.dp_FechaRecepcion_ValueChanged);
            // 
            // dp_FechaDocumento
            // 
            this.dp_FechaDocumento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dp_FechaDocumento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_FechaDocumento.Location = new System.Drawing.Point(669, 166);
            this.dp_FechaDocumento.Name = "dp_FechaDocumento";
            this.dp_FechaDocumento.Size = new System.Drawing.Size(17, 21);
            this.dp_FechaDocumento.TabIndex = 396;
            this.dp_FechaDocumento.ValueChanged += new System.EventHandler(this.dp_FechaDocumento_ValueChanged);
            // 
            // txt_U_CL_DESCRI
            // 
            this.txt_U_CL_DESCRI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_U_CL_DESCRI.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_U_CL_DESCRI.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_U_CL_DESCRI.Location = new System.Drawing.Point(133, 126);
            this.txt_U_CL_DESCRI.Name = "txt_U_CL_DESCRI";
            this.txt_U_CL_DESCRI.Size = new System.Drawing.Size(143, 21);
            this.txt_U_CL_DESCRI.TabIndex = 397;
            this.txt_U_CL_DESCRI.Tag = "ingrese";
            this.txt_U_CL_DESCRI.Enter += new System.EventHandler(this.txt_U_CL_DESCRI_Enter);
            // 
            // lbl_ot
            // 
            this.lbl_ot.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ot.Location = new System.Drawing.Point(9, 133);
            this.lbl_ot.Name = "lbl_ot";
            this.lbl_ot.Size = new System.Drawing.Size(124, 14);
            this.lbl_ot.TabIndex = 398;
            this.lbl_ot.Text = "Orden de trabajo";
            // 
            // txt_PrcCode
            // 
            this.txt_PrcCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PrcCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_PrcCode.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PrcCode.Location = new System.Drawing.Point(282, 126);
            this.txt_PrcCode.Name = "txt_PrcCode";
            this.txt_PrcCode.Size = new System.Drawing.Size(30, 21);
            this.txt_PrcCode.TabIndex = 400;
            this.txt_PrcCode.Tag = "ingrese";
            this.txt_PrcCode.Visible = false;
            // 
            // txt_estadodoc
            // 
            this.txt_estadodoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_estadodoc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_estadodoc.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estadodoc.Location = new System.Drawing.Point(507, 100);
            this.txt_estadodoc.Name = "txt_estadodoc";
            this.txt_estadodoc.Size = new System.Drawing.Size(30, 21);
            this.txt_estadodoc.TabIndex = 401;
            this.txt_estadodoc.Tag = "ingrese";
            this.txt_estadodoc.Text = "1";
            this.txt_estadodoc.Visible = false;
            // 
            // lbl_prioridad
            // 
            this.lbl_prioridad.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prioridad.Location = new System.Drawing.Point(9, 201);
            this.lbl_prioridad.Name = "lbl_prioridad";
            this.lbl_prioridad.Size = new System.Drawing.Size(124, 14);
            this.lbl_prioridad.TabIndex = 402;
            this.lbl_prioridad.Text = "Prioridad";
            // 
            // cbo_prioridad
            // 
            this.cbo_prioridad.FormattingEnabled = true;
            this.cbo_prioridad.Items.AddRange(new object[] {
            "Normal",
            "Alta",
            "Muy alta"});
            this.cbo_prioridad.Location = new System.Drawing.Point(133, 192);
            this.cbo_prioridad.Name = "cbo_prioridad";
            this.cbo_prioridad.Size = new System.Drawing.Size(143, 21);
            this.cbo_prioridad.TabIndex = 403;
            this.cbo_prioridad.SelectedValueChanged += new System.EventHandler(this.cbo_prioridad_SelectedValueChanged);
            // 
            // txt_prioridad
            // 
            this.txt_prioridad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_prioridad.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_prioridad.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prioridad.Location = new System.Drawing.Point(282, 192);
            this.txt_prioridad.Name = "txt_prioridad";
            this.txt_prioridad.Size = new System.Drawing.Size(30, 21);
            this.txt_prioridad.TabIndex = 404;
            this.txt_prioridad.Tag = "ingrese";
            this.txt_prioridad.Visible = false;
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
            // txt_FechaRecepcion
            // 
            this.txt_FechaRecepcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FechaRecepcion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_FechaRecepcion.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FechaRecepcion.Location = new System.Drawing.Point(543, 122);
            this.txt_FechaRecepcion.Name = "txt_FechaRecepcion";
            this.txt_FechaRecepcion.Size = new System.Drawing.Size(143, 21);
            this.txt_FechaRecepcion.TabIndex = 405;
            this.txt_FechaRecepcion.Tag = "ingrese";
            // 
            // txt_FechaVencimiento
            // 
            this.txt_FechaVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FechaVencimiento.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_FechaVencimiento.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FechaVencimiento.Location = new System.Drawing.Point(543, 144);
            this.txt_FechaVencimiento.Name = "txt_FechaVencimiento";
            this.txt_FechaVencimiento.Size = new System.Drawing.Size(143, 21);
            this.txt_FechaVencimiento.TabIndex = 406;
            this.txt_FechaVencimiento.Tag = "ingrese";
            // 
            // txt_FechaDocumento
            // 
            this.txt_FechaDocumento.AcceptsTab = true;
            this.txt_FechaDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FechaDocumento.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_FechaDocumento.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FechaDocumento.Location = new System.Drawing.Point(543, 166);
            this.txt_FechaDocumento.Name = "txt_FechaDocumento";
            this.txt_FechaDocumento.Size = new System.Drawing.Size(143, 21);
            this.txt_FechaDocumento.TabIndex = 407;
            this.txt_FechaDocumento.Tag = "ingrese";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 14);
            this.label4.TabIndex = 410;
            this.label4.Text = "Nº de cargo";
            // 
            // txt_numref
            // 
            this.txt_numref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_numref.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_numref.Location = new System.Drawing.Point(543, 188);
            this.txt_numref.Name = "txt_numref";
            this.txt_numref.ReadOnly = true;
            this.txt_numref.Size = new System.Drawing.Size(143, 21);
            this.txt_numref.TabIndex = 409;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(383, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 14);
            this.label5.TabIndex = 411;
            this.label5.Text = "Fecha de contabilizacion";
            // 
            // txt_DocDate
            // 
            this.txt_DocDate.AcceptsTab = true;
            this.txt_DocDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DocDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_DocDate.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DocDate.Location = new System.Drawing.Point(543, 210);
            this.txt_DocDate.Name = "txt_DocDate";
            this.txt_DocDate.ReadOnly = true;
            this.txt_DocDate.Size = new System.Drawing.Size(143, 21);
            this.txt_DocDate.TabIndex = 412;
            this.txt_DocDate.Tag = "ingrese";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(383, 238);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(124, 14);
            this.label21.TabIndex = 414;
            this.label21.Text = "Nº SAP";
            // 
            // txt_DocNum
            // 
            this.txt_DocNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DocNum.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_DocNum.Location = new System.Drawing.Point(543, 232);
            this.txt_DocNum.Name = "txt_DocNum";
            this.txt_DocNum.ReadOnly = true;
            this.txt_DocNum.Size = new System.Drawing.Size(143, 21);
            this.txt_DocNum.TabIndex = 413;
            // 
            // btn_cargo
            // 
            this.btn_cargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cargo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cargo.BackgroundImage")));
            this.btn_cargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cargo.FlatAppearance.BorderSize = 0;
            this.btn_cargo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cargo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_cargo.Location = new System.Drawing.Point(579, 557);
            this.btn_cargo.Name = "btn_cargo";
            this.btn_cargo.Size = new System.Drawing.Size(111, 21);
            this.btn_cargo.TabIndex = 408;
            this.btn_cargo.Text = "Generar cargo";
            this.btn_cargo.UseVisualStyleBackColor = true;
            this.btn_cargo.Click += new System.EventHandler(this.btn_cargo_Click);
            // 
            // btn_opciones_3
            // 
            this.btn_opciones_3.BackColor = System.Drawing.Color.Transparent;
            this.btn_opciones_3.BackgroundImage = global::MISAP.Properties.Resources.MENUchoosefromlist;
            this.btn_opciones_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_opciones_3.FlatAppearance.BorderSize = 0;
            this.btn_opciones_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_opciones_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_opciones_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_opciones_3.Location = new System.Drawing.Point(260, 128);
            this.btn_opciones_3.Name = "btn_opciones_3";
            this.btn_opciones_3.Size = new System.Drawing.Size(14, 14);
            this.btn_opciones_3.TabIndex = 399;
            this.btn_opciones_3.UseVisualStyleBackColor = false;
            this.btn_opciones_3.Visible = false;
            this.btn_opciones_3.Click += new System.EventHandler(this.btn_opciones_3_Click);
            // 
            // btn_opciones_2
            // 
            this.btn_opciones_2.BackColor = System.Drawing.Color.Transparent;
            this.btn_opciones_2.BackgroundImage = global::MISAP.Properties.Resources.MENUchoosefromlist;
            this.btn_opciones_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_opciones_2.FlatAppearance.BorderSize = 0;
            this.btn_opciones_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_opciones_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_opciones_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_opciones_2.Location = new System.Drawing.Point(260, 152);
            this.btn_opciones_2.Name = "btn_opciones_2";
            this.btn_opciones_2.Size = new System.Drawing.Size(14, 14);
            this.btn_opciones_2.TabIndex = 391;
            this.btn_opciones_2.UseVisualStyleBackColor = false;
            this.btn_opciones_2.Visible = false;
            this.btn_opciones_2.Click += new System.EventHandler(this.btn_opciones_2_Click);
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
            this.btn_opciones.Location = new System.Drawing.Point(260, 85);
            this.btn_opciones.Name = "btn_opciones";
            this.btn_opciones.Size = new System.Drawing.Size(14, 14);
            this.btn_opciones.TabIndex = 384;
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
            this.tsl_titulo.Size = new System.Drawing.Size(136, 24);
            this.tsl_titulo.Text = "Registro de documentos";
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
            // FrmDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 604);
            this.ContextMenuStrip = this.cm_formulario;
            this.ControlBox = false;
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txt_DocNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_DocDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_numref);
            this.Controls.Add(this.btn_cargo);
            this.Controls.Add(this.txt_prioridad);
            this.Controls.Add(this.cbo_prioridad);
            this.Controls.Add(this.lbl_prioridad);
            this.Controls.Add(this.txt_estadodoc);
            this.Controls.Add(this.txt_PrcCode);
            this.Controls.Add(this.btn_opciones_3);
            this.Controls.Add(this.lbl_ot);
            this.Controls.Add(this.txt_U_CL_DESCRI);
            this.Controls.Add(this.dp_FechaDocumento);
            this.Controls.Add(this.dp_FechaRecepcion);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_serie);
            this.Controls.Add(this.lbl_numerodoc);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.btn_opciones_2);
            this.Controls.Add(this.dp_FechaVencimiento);
            this.Controls.Add(this.lbl_tdoc);
            this.Controls.Add(this.lbl_fecha_vencimiento);
            this.Controls.Add(this.txt_CardName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_TipoDocumento);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_idreg);
            this.Controls.Add(this.btn_opciones);
            this.Controls.Add(this.txt_Observaciones);
            this.Controls.Add(this.lbl_Observaciones);
            this.Controls.Add(this.txt_CardCode);
            this.Controls.Add(this.lbl_CardCode);
            this.Controls.Add(this.ts_acciones);
            this.Controls.Add(this.btn_grabar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.ss_load);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.tc_detalle);
            this.Controls.Add(this.txt_FechaRecepcion);
            this.Controls.Add(this.txt_FechaVencimiento);
            this.Controls.Add(this.txt_FechaDocumento);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmDocumentos";
            this.Load += new System.EventHandler(this.FrmAvanceProyecto_Load);
            this.ss_load.ResumeLayout(false);
            this.ss_load.PerformLayout();
            this.ts_acciones.ResumeLayout(false);
            this.ts_acciones.PerformLayout();
            this.tc_detalle.ResumeLayout(false);
            this.tp_contenido.ResumeLayout(false);
            this.tp_contenido.PerformLayout();
            this.tp_anexo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_anexo_consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_anexo)).EndInit();
            this.tp_listado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).EndInit();
            this.tp_auditoria.ResumeLayout(false);
            this.tp_auditoria.PerformLayout();
            this.cm_grilla.ResumeLayout(false);
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
        private System.Windows.Forms.Label lbl_CardCode;
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
        private System.Windows.Forms.TextBox txt_TipoDocumento;
        private System.Windows.Forms.TextBox txt_CardCode;
        private System.Windows.Forms.TextBox txt_Observaciones;
        private System.Windows.Forms.Label lbl_Observaciones;
        private System.Windows.Forms.Button btn_opciones;
        private System.Windows.Forms.ComboBox cbo_CurrName;
        private System.Windows.Forms.TextBox txt_CurrCode;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CardName;
        private System.Windows.Forms.Label lbl_tdoc;
        private System.Windows.Forms.Button btn_opciones_2;
        private System.Windows.Forms.Label lbl_numerodoc;
        private System.Windows.Forms.TextBox txt_serie;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.DateTimePicker dp_FechaVencimiento;
        private System.Windows.Forms.Label lbl_fecha_vencimiento;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_idreg;
        private System.Windows.Forms.DateTimePicker dp_FechaRecepcion;
        private System.Windows.Forms.DateTimePicker dp_FechaDocumento;
        private System.Windows.Forms.Label lbl_moneda;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_DocReferencia;
        private System.Windows.Forms.CheckBox chk_GuiaRemision;
        private System.Windows.Forms.TextBox txt_GuiaRemision;
        private System.Windows.Forms.CheckBox chk_NotaIngreso;
        private System.Windows.Forms.TextBox txt_NotaIngreso;
        private System.Windows.Forms.CheckBox chk_OS;
        private System.Windows.Forms.TextBox txt_OS;
        private System.Windows.Forms.CheckBox chk_OC;
        private System.Windows.Forms.TextBox txt_OC;
        private System.Windows.Forms.CheckBox chk_NroLetra;
        private System.Windows.Forms.TextBox txt_NroLetra;
        private System.Windows.Forms.CheckBox chk_DocReferencia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_impuesto;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_SubTotal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_retencion;
        private System.Windows.Forms.TextBox txt_U_CL_DESCRI;
        private System.Windows.Forms.Label lbl_ot;
        private System.Windows.Forms.Button btn_opciones_3;
        private System.Windows.Forms.TextBox txt_PrcCode;
        private System.Windows.Forms.ToolStripLabel tsl_titulo;
        private System.Windows.Forms.ToolStripButton salir;
        private System.Windows.Forms.ToolStripButton maximizar;
        private System.Windows.Forms.ToolStripButton ninimizar;
        private System.Windows.Forms.ToolStrip titulo;
        private System.Windows.Forms.TextBox txt_estadodoc;
        private System.Windows.Forms.CheckBox chk_igv;
        private System.Windows.Forms.Label lbl_prioridad;
        private System.Windows.Forms.ComboBox cbo_prioridad;
        private System.Windows.Forms.TextBox txt_prioridad;
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
        private System.Windows.Forms.TextBox txt_FechaRecepcion;
        private System.Windows.Forms.TextBox txt_FechaVencimiento;
        private System.Windows.Forms.TextBox txt_FechaDocumento;
        private System.Windows.Forms.Button btn_cargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_numref;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DocDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_SaldoPendiente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ImporteAplicado;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_DocNum;
    }
}