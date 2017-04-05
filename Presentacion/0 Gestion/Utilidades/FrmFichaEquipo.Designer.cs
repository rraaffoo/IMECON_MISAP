namespace MISAP
{
    partial class FrmFichaEquipo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFichaEquipo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgv_detalle = new System.Windows.Forms.DataGridView();
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
            this.cm_grilla = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cm_grilla_copia = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_grilla_copia_tabla = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_IdPCA = new System.Windows.Forms.Label();
            this.t_msg = new System.Windows.Forms.Timer(this.components);
            this.txt_IdPCA = new System.Windows.Forms.TextBox();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_DocEntry = new System.Windows.Forms.TextBox();
            this.dp_FechaDocumento = new System.Windows.Forms.DateTimePicker();
            this.txt_Area = new System.Windows.Forms.TextBox();
            this.lbl_ot = new System.Windows.Forms.Label();
            this.txt_IdArea = new System.Windows.Forms.TextBox();
            this.txt_estadodoc = new System.Windows.Forms.TextBox();
            this.cm_formulario = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmi_eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_FechaDocumento = new System.Windows.Forms.TextBox();
            this.btn_opciones = new System.Windows.Forms.Button();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.ToolStrip();
            this.tsl_titulo = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.maximizar = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            this.txt_empID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_empleado = new System.Windows.Forms.TextBox();
            this.txt_IdPerfil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Perfil = new System.Windows.Forms.TextBox();
            this.txt_UsuarioEquipo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_IpEquipo = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_NombreEquipo = new System.Windows.Forms.TextBox();
            this.cbo_TipoMov = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ListaInventario = new System.Windows.Forms.Button();
            this.txt_CodInventario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ss_load.SuspendLayout();
            this.ts_acciones.SuspendLayout();
            this.tc_detalle.SuspendLayout();
            this.tp_contenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).BeginInit();
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
            this.tc_detalle.Location = new System.Drawing.Point(12, 241);
            this.tc_detalle.Name = "tc_detalle";
            this.tc_detalle.SelectedIndex = 0;
            this.tc_detalle.Size = new System.Drawing.Size(682, 310);
            this.tc_detalle.TabIndex = 344;
            // 
            // tp_contenido
            // 
            this.tp_contenido.AutoScroll = true;
            this.tp_contenido.BackColor = System.Drawing.SystemColors.Control;
            this.tp_contenido.Controls.Add(this.dgv_detalle);
            this.tp_contenido.Location = new System.Drawing.Point(4, 20);
            this.tp_contenido.Name = "tp_contenido";
            this.tp_contenido.Padding = new System.Windows.Forms.Padding(3);
            this.tp_contenido.Size = new System.Drawing.Size(674, 286);
            this.tp_contenido.TabIndex = 0;
            this.tp_contenido.Text = "Contenido";
            // 
            // dgv_detalle
            // 
            this.dgv_detalle.AllowUserToAddRows = false;
            this.dgv_detalle.AllowUserToDeleteRows = false;
            this.dgv_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_detalle.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_detalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_detalle.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgv_detalle.EnableHeadersVisualStyles = false;
            this.dgv_detalle.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_detalle.Location = new System.Drawing.Point(9, 11);
            this.dgv_detalle.Name = "dgv_detalle";
            this.dgv_detalle.Size = new System.Drawing.Size(659, 255);
            this.dgv_detalle.TabIndex = 358;
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
            this.tp_anexo.Size = new System.Drawing.Size(674, 286);
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
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_anexo_consulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgv_anexo_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_anexo_consulta.DefaultCellStyle = dataGridViewCellStyle28;
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
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_anexo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgv_anexo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_anexo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ruta_,
            this.archivo_,
            this.fecha_,
            this.extension_,
            this.AbsEntry,
            this.line,
            this.local_r});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_anexo.DefaultCellStyle = dataGridViewCellStyle30;
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
            this.tp_listado.Size = new System.Drawing.Size(674, 286);
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
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_lista.DefaultCellStyle = dataGridViewCellStyle32;
            this.dgv_lista.EnableHeadersVisualStyles = false;
            this.dgv_lista.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_lista.Location = new System.Drawing.Point(7, 15);
            this.dgv_lista.Name = "dgv_lista";
            this.dgv_lista.Size = new System.Drawing.Size(657, 265);
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
            this.tp_auditoria.Size = new System.Drawing.Size(674, 286);
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
            // lbl_IdPCA
            // 
            this.lbl_IdPCA.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdPCA.Location = new System.Drawing.Point(9, 89);
            this.lbl_IdPCA.Name = "lbl_IdPCA";
            this.lbl_IdPCA.Size = new System.Drawing.Size(124, 14);
            this.lbl_IdPCA.TabIndex = 347;
            this.lbl_IdPCA.Text = "Nº de PCA";
            // 
            // t_msg
            // 
            this.t_msg.Interval = 5000;
            this.t_msg.Tick += new System.EventHandler(this.t_msg_Tick);
            // 
            // txt_IdPCA
            // 
            this.txt_IdPCA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdPCA.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_IdPCA.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdPCA.Location = new System.Drawing.Point(133, 82);
            this.txt_IdPCA.Name = "txt_IdPCA";
            this.txt_IdPCA.Size = new System.Drawing.Size(143, 21);
            this.txt_IdPCA.TabIndex = 0;
            this.txt_IdPCA.Tag = "ingrese";
            this.txt_IdPCA.Enter += new System.EventHandler(this.txt_CardCode_Enter);
            this.txt_IdPCA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idreg_KeyPress);
            this.txt_IdPCA.Leave += new System.EventHandler(this.txt_IdActivo_Leave);
            // 
            // lbl_hora
            // 
            this.lbl_hora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_hora.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.Location = new System.Drawing.Point(383, 129);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(124, 14);
            this.lbl_hora.TabIndex = 386;
            this.lbl_hora.Text = "Fecha de movimiento";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label15.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(383, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 14);
            this.label15.TabIndex = 380;
            this.label15.Text = "Nº";
            // 
            // txt_DocEntry
            // 
            this.txt_DocEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DocEntry.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_DocEntry.Location = new System.Drawing.Point(543, 78);
            this.txt_DocEntry.Name = "txt_DocEntry";
            this.txt_DocEntry.ReadOnly = true;
            this.txt_DocEntry.Size = new System.Drawing.Size(143, 21);
            this.txt_DocEntry.TabIndex = 379;
            this.txt_DocEntry.Enter += new System.EventHandler(this.txt_idreg_Enter);
            this.txt_DocEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idreg_KeyPress);
            // 
            // dp_FechaDocumento
            // 
            this.dp_FechaDocumento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dp_FechaDocumento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_FechaDocumento.Location = new System.Drawing.Point(669, 122);
            this.dp_FechaDocumento.Name = "dp_FechaDocumento";
            this.dp_FechaDocumento.Size = new System.Drawing.Size(17, 21);
            this.dp_FechaDocumento.TabIndex = 396;
            this.dp_FechaDocumento.ValueChanged += new System.EventHandler(this.dp_FechaDocumento_ValueChanged);
            // 
            // txt_Area
            // 
            this.txt_Area.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Area.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Area.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Area.Location = new System.Drawing.Point(133, 126);
            this.txt_Area.Name = "txt_Area";
            this.txt_Area.ReadOnly = true;
            this.txt_Area.Size = new System.Drawing.Size(143, 21);
            this.txt_Area.TabIndex = 397;
            this.txt_Area.Tag = "ingrese";
            // 
            // lbl_ot
            // 
            this.lbl_ot.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ot.Location = new System.Drawing.Point(9, 133);
            this.lbl_ot.Name = "lbl_ot";
            this.lbl_ot.Size = new System.Drawing.Size(124, 14);
            this.lbl_ot.TabIndex = 398;
            this.lbl_ot.Text = "Area";
            // 
            // txt_IdArea
            // 
            this.txt_IdArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdArea.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_IdArea.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdArea.Location = new System.Drawing.Point(282, 126);
            this.txt_IdArea.Name = "txt_IdArea";
            this.txt_IdArea.Size = new System.Drawing.Size(30, 21);
            this.txt_IdArea.TabIndex = 400;
            this.txt_IdArea.Tag = "ingrese";
            this.txt_IdArea.Visible = false;
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
            // txt_FechaDocumento
            // 
            this.txt_FechaDocumento.AcceptsTab = true;
            this.txt_FechaDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FechaDocumento.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_FechaDocumento.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FechaDocumento.Location = new System.Drawing.Point(543, 122);
            this.txt_FechaDocumento.Name = "txt_FechaDocumento";
            this.txt_FechaDocumento.Size = new System.Drawing.Size(143, 21);
            this.txt_FechaDocumento.TabIndex = 407;
            this.txt_FechaDocumento.Tag = "ingrese";
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
            this.tsl_titulo.Size = new System.Drawing.Size(162, 24);
            this.tsl_titulo.Text = "Ficha de equipo de cómputo ";
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
            // txt_empID
            // 
            this.txt_empID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_empID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_empID.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empID.Location = new System.Drawing.Point(282, 104);
            this.txt_empID.Name = "txt_empID";
            this.txt_empID.Size = new System.Drawing.Size(30, 21);
            this.txt_empID.TabIndex = 418;
            this.txt_empID.Tag = "ingrese";
            this.txt_empID.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 14);
            this.label1.TabIndex = 417;
            this.label1.Text = "Empleado";
            // 
            // txt_empleado
            // 
            this.txt_empleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_empleado.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_empleado.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empleado.Location = new System.Drawing.Point(133, 104);
            this.txt_empleado.Name = "txt_empleado";
            this.txt_empleado.ReadOnly = true;
            this.txt_empleado.Size = new System.Drawing.Size(143, 21);
            this.txt_empleado.TabIndex = 416;
            this.txt_empleado.Tag = "ingrese";
            // 
            // txt_IdPerfil
            // 
            this.txt_IdPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdPerfil.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_IdPerfil.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdPerfil.Location = new System.Drawing.Point(282, 148);
            this.txt_IdPerfil.Name = "txt_IdPerfil";
            this.txt_IdPerfil.Size = new System.Drawing.Size(30, 21);
            this.txt_IdPerfil.TabIndex = 421;
            this.txt_IdPerfil.Tag = "ingrese";
            this.txt_IdPerfil.Visible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 14);
            this.label4.TabIndex = 420;
            this.label4.Text = "Perfil";
            // 
            // txt_Perfil
            // 
            this.txt_Perfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Perfil.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Perfil.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Perfil.Location = new System.Drawing.Point(133, 148);
            this.txt_Perfil.Name = "txt_Perfil";
            this.txt_Perfil.ReadOnly = true;
            this.txt_Perfil.Size = new System.Drawing.Size(143, 21);
            this.txt_Perfil.TabIndex = 419;
            this.txt_Perfil.Tag = "ingrese";
            // 
            // txt_UsuarioEquipo
            // 
            this.txt_UsuarioEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UsuarioEquipo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_UsuarioEquipo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UsuarioEquipo.Location = new System.Drawing.Point(282, 170);
            this.txt_UsuarioEquipo.Name = "txt_UsuarioEquipo";
            this.txt_UsuarioEquipo.Size = new System.Drawing.Size(30, 21);
            this.txt_UsuarioEquipo.TabIndex = 424;
            this.txt_UsuarioEquipo.Tag = "ingrese";
            this.txt_UsuarioEquipo.Visible = false;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(9, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 14);
            this.label17.TabIndex = 423;
            this.label17.Text = "Usuario";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Usuario.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Usuario.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.Location = new System.Drawing.Point(133, 170);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.ReadOnly = true;
            this.txt_Usuario.Size = new System.Drawing.Size(143, 21);
            this.txt_Usuario.TabIndex = 422;
            this.txt_Usuario.Tag = "ingrese";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 412;
            this.label5.Text = "Dirección IP";
            // 
            // txt_IpEquipo
            // 
            this.txt_IpEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IpEquipo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_IpEquipo.Location = new System.Drawing.Point(133, 192);
            this.txt_IpEquipo.Name = "txt_IpEquipo";
            this.txt_IpEquipo.Size = new System.Drawing.Size(143, 21);
            this.txt_IpEquipo.TabIndex = 411;
            this.txt_IpEquipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_IpEquipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IpEquipo_KeyPress);
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(9, 221);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(124, 14);
            this.label21.TabIndex = 426;
            this.label21.Text = "Nombre de equipo";
            // 
            // txt_NombreEquipo
            // 
            this.txt_NombreEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NombreEquipo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_NombreEquipo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreEquipo.Location = new System.Drawing.Point(133, 214);
            this.txt_NombreEquipo.Name = "txt_NombreEquipo";
            this.txt_NombreEquipo.ReadOnly = true;
            this.txt_NombreEquipo.Size = new System.Drawing.Size(143, 21);
            this.txt_NombreEquipo.TabIndex = 425;
            this.txt_NombreEquipo.Tag = "ingrese";
            // 
            // cbo_TipoMov
            // 
            this.cbo_TipoMov.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbo_TipoMov.FormattingEnabled = true;
            this.cbo_TipoMov.Location = new System.Drawing.Point(543, 144);
            this.cbo_TipoMov.Name = "cbo_TipoMov";
            this.cbo_TipoMov.Size = new System.Drawing.Size(143, 21);
            this.cbo_TipoMov.TabIndex = 427;
            // 
            // label8
            // 
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(383, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 14);
            this.label8.TabIndex = 428;
            this.label8.Text = "Tipo de movimiento";
            // 
            // btn_ListaInventario
            // 
            this.btn_ListaInventario.BackColor = System.Drawing.Color.Transparent;
            this.btn_ListaInventario.BackgroundImage = global::MISAP.Properties.Resources.MENUchoosefromlist;
            this.btn_ListaInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ListaInventario.FlatAppearance.BorderSize = 0;
            this.btn_ListaInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ListaInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ListaInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListaInventario.Location = new System.Drawing.Point(668, 170);
            this.btn_ListaInventario.Name = "btn_ListaInventario";
            this.btn_ListaInventario.Size = new System.Drawing.Size(14, 14);
            this.btn_ListaInventario.TabIndex = 431;
            this.btn_ListaInventario.UseVisualStyleBackColor = false;
            this.btn_ListaInventario.Visible = false;
            // 
            // txt_CodInventario
            // 
            this.txt_CodInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CodInventario.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_CodInventario.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodInventario.Location = new System.Drawing.Point(543, 167);
            this.txt_CodInventario.Name = "txt_CodInventario";
            this.txt_CodInventario.Size = new System.Drawing.Size(143, 21);
            this.txt_CodInventario.TabIndex = 429;
            this.txt_CodInventario.Tag = "ingrese";
            this.txt_CodInventario.Enter += new System.EventHandler(this.txt_CodInventario_Enter);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(383, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 14);
            this.label9.TabIndex = 430;
            this.label9.Text = "Codigo de inventario";
            // 
            // FrmFichaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 604);
            this.ContextMenuStrip = this.cm_formulario;
            this.ControlBox = false;
            this.Controls.Add(this.btn_ListaInventario);
            this.Controls.Add(this.txt_CodInventario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbo_TipoMov);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txt_NombreEquipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_IpEquipo);
            this.Controls.Add(this.txt_UsuarioEquipo);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.txt_IdPerfil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Perfil);
            this.Controls.Add(this.txt_empID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_empleado);
            this.Controls.Add(this.txt_estadodoc);
            this.Controls.Add(this.txt_IdArea);
            this.Controls.Add(this.lbl_ot);
            this.Controls.Add(this.txt_Area);
            this.Controls.Add(this.dp_FechaDocumento);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_DocEntry);
            this.Controls.Add(this.btn_opciones);
            this.Controls.Add(this.txt_IdPCA);
            this.Controls.Add(this.lbl_IdPCA);
            this.Controls.Add(this.ts_acciones);
            this.Controls.Add(this.btn_grabar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.ss_load);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.tc_detalle);
            this.Controls.Add(this.txt_FechaDocumento);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmFichaEquipo";
            this.Load += new System.EventHandler(this.FrmAvanceProyecto_Load);
            this.ss_load.ResumeLayout(false);
            this.ss_load.PerformLayout();
            this.ts_acciones.ResumeLayout(false);
            this.ts_acciones.PerformLayout();
            this.tc_detalle.ResumeLayout(false);
            this.tp_contenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).EndInit();
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
        private System.Windows.Forms.Label lbl_IdPCA;
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
        private System.Windows.Forms.TextBox txt_IdPCA;
        private System.Windows.Forms.Button btn_opciones;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_DocEntry;
        private System.Windows.Forms.DateTimePicker dp_FechaDocumento;
        private System.Windows.Forms.TextBox txt_Area;
        private System.Windows.Forms.Label lbl_ot;
        private System.Windows.Forms.TextBox txt_IdArea;
        private System.Windows.Forms.ToolStripLabel tsl_titulo;
        private System.Windows.Forms.ToolStripButton salir;
        private System.Windows.Forms.ToolStripButton maximizar;
        private System.Windows.Forms.ToolStripButton ninimizar;
        private System.Windows.Forms.ToolStrip titulo;
        private System.Windows.Forms.TextBox txt_estadodoc;
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
        private System.Windows.Forms.TextBox txt_empID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_empleado;
        private System.Windows.Forms.TextBox txt_IdPerfil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Perfil;
        private System.Windows.Forms.TextBox txt_UsuarioEquipo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_IpEquipo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_NombreEquipo;
        private System.Windows.Forms.DataGridView dgv_detalle;
        private System.Windows.Forms.ComboBox cbo_TipoMov;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ListaInventario;
        private System.Windows.Forms.TextBox txt_CodInventario;
        private System.Windows.Forms.Label label9;
    }
}