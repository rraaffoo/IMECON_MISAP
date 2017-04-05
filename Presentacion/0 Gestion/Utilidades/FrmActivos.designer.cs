namespace MISAP
{
    partial class FrmActivos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActivos));
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
            this.lbl_ProcesadorVm = new System.Windows.Forms.Label();
            this.lbl_MemoriaVm = new System.Windows.Forms.Label();
            this.lbl_NombreVhd = new System.Windows.Forms.Label();
            this.txt_PlacaVm = new System.Windows.Forms.TextBox();
            this.lbl_NombreVm = new System.Windows.Forms.Label();
            this.tc_detalle = new System.Windows.Forms.TabControl();
            this.tp_contenido = new System.Windows.Forms.TabPage();
            this.lbl_Placa = new System.Windows.Forms.Label();
            this.txt_Placa = new System.Windows.Forms.TextBox();
            this.btn_busqueda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Procesador = new System.Windows.Forms.TextBox();
            this.txt_Memoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_HDD = new System.Windows.Forms.TextBox();
            this.txt_RutaVhd = new System.Windows.Forms.TextBox();
            this.txt_PasswordSa = new System.Windows.Forms.TextBox();
            this.txt_IPSrv = new System.Windows.Forms.TextBox();
            this.lbl_IPSrv = new System.Windows.Forms.Label();
            this.lbl_PasswordSa = new System.Windows.Forms.Label();
            this.txt_SO = new System.Windows.Forms.TextBox();
            this.lbl_IPSrvPublica = new System.Windows.Forms.Label();
            this.txt_UsuarioSa = new System.Windows.Forms.TextBox();
            this.lbl_SO = new System.Windows.Forms.Label();
            this.txt_NombreSrv = new System.Windows.Forms.TextBox();
            this.txt_IPSrvPublica = new System.Windows.Forms.TextBox();
            this.txt_ProcesadorVm = new System.Windows.Forms.TextBox();
            this.lbl_NombreSrv = new System.Windows.Forms.Label();
            this.lbl_UsuarioSa = new System.Windows.Forms.Label();
            this.txt_NombreVm = new System.Windows.Forms.TextBox();
            this.lbl_UsuarioAdmin = new System.Windows.Forms.Label();
            this.txt_UsuarioAdmin = new System.Windows.Forms.TextBox();
            this.txt_MemoriaVm = new System.Windows.Forms.TextBox();
            this.lbl_PasswordAdmin = new System.Windows.Forms.Label();
            this.lbl_HddVm = new System.Windows.Forms.Label();
            this.txt_PasswordAdmin = new System.Windows.Forms.TextBox();
            this.lbl_RutaVhd = new System.Windows.Forms.Label();
            this.txt_RutaVm = new System.Windows.Forms.TextBox();
            this.txt_HddVm = new System.Windows.Forms.TextBox();
            this.lbl_RutaVm = new System.Windows.Forms.Label();
            this.cbo_cluster = new System.Windows.Forms.ComboBox();
            this.lbl_Cluster = new System.Windows.Forms.Label();
            this.tp_servicios = new System.Windows.Forms.TabPage();
            this.lbl_Servicio = new System.Windows.Forms.Label();
            this.dgv_detalle = new System.Windows.Forms.DataGridView();
            this.cm_grilla = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cm_grilla_copia = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_grilla_copia_tabla = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_Id_Servicio = new System.Windows.Forms.TextBox();
            this.txt_Servicio = new System.Windows.Forms.TextBox();
            this.btn_opciones = new System.Windows.Forms.Button();
            this.tp_anexo = new System.Windows.Forms.TabPage();
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
            this.tp_virtual = new System.Windows.Forms.TabPage();
            this.lbl_IdVm = new System.Windows.Forms.Label();
            this.t_msg = new System.Windows.Forms.Timer(this.components);
            this.txt_IdActivo = new System.Windows.Forms.TextBox();
            this.txt_Observaciones = new System.Windows.Forms.TextBox();
            this.lbl_Observaciones = new System.Windows.Forms.Label();
            this.lbl_SubClaseActivo = new System.Windows.Forms.Label();
            this.lbl_TipoActivo = new System.Windows.Forms.Label();
            this.txt_NroSerie = new System.Windows.Forms.TextBox();
            this.lbl_NroSerie = new System.Windows.Forms.Label();
            this.txt_Modelo = new System.Windows.Forms.TextBox();
            this.lbl_Modelo = new System.Windows.Forms.Label();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_ClaseActivo = new System.Windows.Forms.Label();
            this.cbo_TipoActivo = new System.Windows.Forms.ComboBox();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.ToolStrip();
            this.tsl_titulo = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.maximizar = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            this.txt_Estado = new System.Windows.Forms.TextBox();
            this.txt_EstadoId = new System.Windows.Forms.TextBox();
            this.txt_CodInventario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_SubClaseActivo = new System.Windows.Forms.ComboBox();
            this.cbo_ClaseActivo = new System.Windows.Forms.ComboBox();
            this.ss_load.SuspendLayout();
            this.ts_acciones.SuspendLayout();
            this.tc_detalle.SuspendLayout();
            this.tp_contenido.SuspendLayout();
            this.tp_servicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).BeginInit();
            this.cm_grilla.SuspendLayout();
            this.tp_listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).BeginInit();
            this.tp_auditoria.SuspendLayout();
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
            this.ss_load.Location = new System.Drawing.Point(0, 625);
            this.ss_load.Name = "ss_load";
            this.ss_load.Size = new System.Drawing.Size(739, 18);
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
            this.ts_acciones.Size = new System.Drawing.Size(739, 47);
            this.ts_acciones.TabIndex = 313;
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
            this.btn_editar_b.Visible = false;
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
            // lbl_ProcesadorVm
            // 
            this.lbl_ProcesadorVm.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProcesadorVm.Location = new System.Drawing.Point(364, 62);
            this.lbl_ProcesadorVm.Name = "lbl_ProcesadorVm";
            this.lbl_ProcesadorVm.Size = new System.Drawing.Size(124, 14);
            this.lbl_ProcesadorVm.TabIndex = 329;
            this.lbl_ProcesadorVm.Text = "Procesador virtual";
            // 
            // lbl_MemoriaVm
            // 
            this.lbl_MemoriaVm.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MemoriaVm.Location = new System.Drawing.Point(364, 84);
            this.lbl_MemoriaVm.Name = "lbl_MemoriaVm";
            this.lbl_MemoriaVm.Size = new System.Drawing.Size(124, 14);
            this.lbl_MemoriaVm.TabIndex = 328;
            this.lbl_MemoriaVm.Text = "Memoria Virtual";
            // 
            // lbl_NombreVhd
            // 
            this.lbl_NombreVhd.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreVhd.Location = new System.Drawing.Point(364, 41);
            this.lbl_NombreVhd.Name = "lbl_NombreVhd";
            this.lbl_NombreVhd.Size = new System.Drawing.Size(124, 14);
            this.lbl_NombreVhd.TabIndex = 327;
            this.lbl_NombreVhd.Text = "Placa";
            // 
            // txt_PlacaVm
            // 
            this.txt_PlacaVm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PlacaVm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_PlacaVm.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PlacaVm.Location = new System.Drawing.Point(488, 35);
            this.txt_PlacaVm.Name = "txt_PlacaVm";
            this.txt_PlacaVm.Size = new System.Drawing.Size(197, 21);
            this.txt_PlacaVm.TabIndex = 1;
            this.txt_PlacaVm.Tag = "ingrese";
            // 
            // lbl_NombreVm
            // 
            this.lbl_NombreVm.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreVm.Location = new System.Drawing.Point(364, 20);
            this.lbl_NombreVm.Name = "lbl_NombreVm";
            this.lbl_NombreVm.Size = new System.Drawing.Size(124, 14);
            this.lbl_NombreVm.TabIndex = 325;
            this.lbl_NombreVm.Text = "Nombre activo virtual";
            // 
            // tc_detalle
            // 
            this.tc_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_detalle.Controls.Add(this.tp_contenido);
            this.tc_detalle.Controls.Add(this.tp_servicios);
            this.tc_detalle.Controls.Add(this.tp_anexo);
            this.tc_detalle.Controls.Add(this.tp_listado);
            this.tc_detalle.Controls.Add(this.tp_auditoria);
            this.tc_detalle.Controls.Add(this.tp_virtual);
            this.tc_detalle.ItemSize = new System.Drawing.Size(80, 16);
            this.tc_detalle.Location = new System.Drawing.Point(12, 211);
            this.tc_detalle.Name = "tc_detalle";
            this.tc_detalle.SelectedIndex = 0;
            this.tc_detalle.Size = new System.Drawing.Size(711, 310);
            this.tc_detalle.TabIndex = 344;
            // 
            // tp_contenido
            // 
            this.tp_contenido.AutoScroll = true;
            this.tp_contenido.BackColor = System.Drawing.SystemColors.Control;
            this.tp_contenido.Controls.Add(this.lbl_Placa);
            this.tp_contenido.Controls.Add(this.txt_Placa);
            this.tp_contenido.Controls.Add(this.btn_busqueda);
            this.tp_contenido.Controls.Add(this.label1);
            this.tp_contenido.Controls.Add(this.label4);
            this.tp_contenido.Controls.Add(this.txt_Procesador);
            this.tp_contenido.Controls.Add(this.txt_Memoria);
            this.tp_contenido.Controls.Add(this.label5);
            this.tp_contenido.Controls.Add(this.txt_HDD);
            this.tp_contenido.Controls.Add(this.txt_RutaVhd);
            this.tp_contenido.Controls.Add(this.lbl_NombreVm);
            this.tp_contenido.Controls.Add(this.txt_PasswordSa);
            this.tp_contenido.Controls.Add(this.txt_IPSrv);
            this.tp_contenido.Controls.Add(this.txt_PlacaVm);
            this.tp_contenido.Controls.Add(this.lbl_IPSrv);
            this.tp_contenido.Controls.Add(this.lbl_PasswordSa);
            this.tp_contenido.Controls.Add(this.lbl_NombreVhd);
            this.tp_contenido.Controls.Add(this.txt_SO);
            this.tp_contenido.Controls.Add(this.lbl_IPSrvPublica);
            this.tp_contenido.Controls.Add(this.lbl_MemoriaVm);
            this.tp_contenido.Controls.Add(this.txt_UsuarioSa);
            this.tp_contenido.Controls.Add(this.lbl_SO);
            this.tp_contenido.Controls.Add(this.lbl_ProcesadorVm);
            this.tp_contenido.Controls.Add(this.txt_NombreSrv);
            this.tp_contenido.Controls.Add(this.txt_IPSrvPublica);
            this.tp_contenido.Controls.Add(this.txt_ProcesadorVm);
            this.tp_contenido.Controls.Add(this.lbl_NombreSrv);
            this.tp_contenido.Controls.Add(this.lbl_UsuarioSa);
            this.tp_contenido.Controls.Add(this.txt_NombreVm);
            this.tp_contenido.Controls.Add(this.lbl_UsuarioAdmin);
            this.tp_contenido.Controls.Add(this.txt_UsuarioAdmin);
            this.tp_contenido.Controls.Add(this.txt_MemoriaVm);
            this.tp_contenido.Controls.Add(this.lbl_PasswordAdmin);
            this.tp_contenido.Controls.Add(this.lbl_HddVm);
            this.tp_contenido.Controls.Add(this.txt_PasswordAdmin);
            this.tp_contenido.Controls.Add(this.lbl_RutaVhd);
            this.tp_contenido.Controls.Add(this.txt_RutaVm);
            this.tp_contenido.Controls.Add(this.txt_HddVm);
            this.tp_contenido.Controls.Add(this.lbl_RutaVm);
            this.tp_contenido.Controls.Add(this.cbo_cluster);
            this.tp_contenido.Controls.Add(this.lbl_Cluster);
            this.tp_contenido.Location = new System.Drawing.Point(4, 20);
            this.tp_contenido.Name = "tp_contenido";
            this.tp_contenido.Padding = new System.Windows.Forms.Padding(3);
            this.tp_contenido.Size = new System.Drawing.Size(703, 286);
            this.tp_contenido.TabIndex = 0;
            this.tp_contenido.Text = "Contenido";
            // 
            // lbl_Placa
            // 
            this.lbl_Placa.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Placa.Location = new System.Drawing.Point(11, 62);
            this.lbl_Placa.Name = "lbl_Placa";
            this.lbl_Placa.Size = new System.Drawing.Size(124, 14);
            this.lbl_Placa.TabIndex = 400;
            this.lbl_Placa.Text = "Placa";
            // 
            // txt_Placa
            // 
            this.txt_Placa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Placa.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Placa.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Placa.Location = new System.Drawing.Point(135, 57);
            this.txt_Placa.Name = "txt_Placa";
            this.txt_Placa.Size = new System.Drawing.Size(197, 21);
            this.txt_Placa.TabIndex = 399;
            this.txt_Placa.Tag = "ingrese";
            // 
            // btn_busqueda
            // 
            this.btn_busqueda.BackColor = System.Drawing.Color.Transparent;
            this.btn_busqueda.BackgroundImage = global::MISAP.Properties.Resources.MENUsearch;
            this.btn_busqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_busqueda.FlatAppearance.BorderSize = 0;
            this.btn_busqueda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_busqueda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_busqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busqueda.Location = new System.Drawing.Point(314, 17);
            this.btn_busqueda.Name = "btn_busqueda";
            this.btn_busqueda.Size = new System.Drawing.Size(14, 14);
            this.btn_busqueda.TabIndex = 398;
            this.btn_busqueda.UseVisualStyleBackColor = false;
            this.btn_busqueda.Click += new System.EventHandler(this.btn_busqueda_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 14);
            this.label1.TabIndex = 393;
            this.label1.Text = "Memoria";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 14);
            this.label4.TabIndex = 394;
            this.label4.Text = "Procesador";
            // 
            // txt_Procesador
            // 
            this.txt_Procesador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Procesador.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Procesador.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Procesador.Location = new System.Drawing.Point(135, 79);
            this.txt_Procesador.Name = "txt_Procesador";
            this.txt_Procesador.Size = new System.Drawing.Size(197, 21);
            this.txt_Procesador.TabIndex = 392;
            this.txt_Procesador.Tag = "ingrese";
            // 
            // txt_Memoria
            // 
            this.txt_Memoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Memoria.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Memoria.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Memoria.Location = new System.Drawing.Point(135, 101);
            this.txt_Memoria.Name = "txt_Memoria";
            this.txt_Memoria.Size = new System.Drawing.Size(197, 21);
            this.txt_Memoria.TabIndex = 395;
            this.txt_Memoria.Tag = "ingrese";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 14);
            this.label5.TabIndex = 397;
            this.label5.Text = "HDD";
            // 
            // txt_HDD
            // 
            this.txt_HDD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_HDD.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_HDD.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HDD.Location = new System.Drawing.Point(135, 123);
            this.txt_HDD.Name = "txt_HDD";
            this.txt_HDD.Size = new System.Drawing.Size(197, 21);
            this.txt_HDD.TabIndex = 396;
            this.txt_HDD.Tag = "ingrese";
            // 
            // txt_RutaVhd
            // 
            this.txt_RutaVhd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RutaVhd.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_RutaVhd.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RutaVhd.Location = new System.Drawing.Point(488, 167);
            this.txt_RutaVhd.Name = "txt_RutaVhd";
            this.txt_RutaVhd.Size = new System.Drawing.Size(197, 21);
            this.txt_RutaVhd.TabIndex = 372;
            this.txt_RutaVhd.Tag = "ingrese";
            // 
            // txt_PasswordSa
            // 
            this.txt_PasswordSa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PasswordSa.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_PasswordSa.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PasswordSa.Location = new System.Drawing.Point(135, 255);
            this.txt_PasswordSa.Name = "txt_PasswordSa";
            this.txt_PasswordSa.Size = new System.Drawing.Size(197, 21);
            this.txt_PasswordSa.TabIndex = 391;
            this.txt_PasswordSa.Tag = "ingrese";
            // 
            // txt_IPSrv
            // 
            this.txt_IPSrv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IPSrv.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_IPSrv.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IPSrv.Location = new System.Drawing.Point(135, 13);
            this.txt_IPSrv.Name = "txt_IPSrv";
            this.txt_IPSrv.Size = new System.Drawing.Size(197, 21);
            this.txt_IPSrv.TabIndex = 381;
            this.txt_IPSrv.Tag = "ingrese";
            // 
            // lbl_IPSrv
            // 
            this.lbl_IPSrv.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IPSrv.Location = new System.Drawing.Point(11, 20);
            this.lbl_IPSrv.Name = "lbl_IPSrv";
            this.lbl_IPSrv.Size = new System.Drawing.Size(124, 14);
            this.lbl_IPSrv.TabIndex = 380;
            this.lbl_IPSrv.Text = "IP del activo";
            // 
            // lbl_PasswordSa
            // 
            this.lbl_PasswordSa.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PasswordSa.Location = new System.Drawing.Point(11, 262);
            this.lbl_PasswordSa.Name = "lbl_PasswordSa";
            this.lbl_PasswordSa.Size = new System.Drawing.Size(124, 14);
            this.lbl_PasswordSa.TabIndex = 390;
            this.lbl_PasswordSa.Text = "Pass Base de datos";
            // 
            // txt_SO
            // 
            this.txt_SO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SO.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_SO.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SO.Location = new System.Drawing.Point(135, 145);
            this.txt_SO.Name = "txt_SO";
            this.txt_SO.Size = new System.Drawing.Size(197, 21);
            this.txt_SO.TabIndex = 379;
            this.txt_SO.Tag = "ingrese";
            // 
            // lbl_IPSrvPublica
            // 
            this.lbl_IPSrvPublica.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IPSrvPublica.Location = new System.Drawing.Point(11, 174);
            this.lbl_IPSrvPublica.Name = "lbl_IPSrvPublica";
            this.lbl_IPSrvPublica.Size = new System.Drawing.Size(124, 14);
            this.lbl_IPSrvPublica.TabIndex = 382;
            this.lbl_IPSrvPublica.Text = "IP publica del activo";
            // 
            // txt_UsuarioSa
            // 
            this.txt_UsuarioSa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UsuarioSa.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_UsuarioSa.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UsuarioSa.Location = new System.Drawing.Point(135, 233);
            this.txt_UsuarioSa.Name = "txt_UsuarioSa";
            this.txt_UsuarioSa.Size = new System.Drawing.Size(197, 21);
            this.txt_UsuarioSa.TabIndex = 389;
            this.txt_UsuarioSa.Tag = "ingrese";
            // 
            // lbl_SO
            // 
            this.lbl_SO.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SO.Location = new System.Drawing.Point(11, 152);
            this.lbl_SO.Name = "lbl_SO";
            this.lbl_SO.Size = new System.Drawing.Size(124, 14);
            this.lbl_SO.TabIndex = 378;
            this.lbl_SO.Text = "Sistema Operativo";
            // 
            // txt_NombreSrv
            // 
            this.txt_NombreSrv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NombreSrv.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_NombreSrv.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreSrv.Location = new System.Drawing.Point(135, 35);
            this.txt_NombreSrv.Name = "txt_NombreSrv";
            this.txt_NombreSrv.Size = new System.Drawing.Size(197, 21);
            this.txt_NombreSrv.TabIndex = 377;
            this.txt_NombreSrv.Tag = "ingrese";
            // 
            // txt_IPSrvPublica
            // 
            this.txt_IPSrvPublica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IPSrvPublica.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_IPSrvPublica.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IPSrvPublica.Location = new System.Drawing.Point(135, 167);
            this.txt_IPSrvPublica.Name = "txt_IPSrvPublica";
            this.txt_IPSrvPublica.Size = new System.Drawing.Size(197, 21);
            this.txt_IPSrvPublica.TabIndex = 383;
            this.txt_IPSrvPublica.Tag = "ingrese";
            // 
            // txt_ProcesadorVm
            // 
            this.txt_ProcesadorVm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProcesadorVm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_ProcesadorVm.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProcesadorVm.Location = new System.Drawing.Point(488, 57);
            this.txt_ProcesadorVm.Name = "txt_ProcesadorVm";
            this.txt_ProcesadorVm.Size = new System.Drawing.Size(197, 21);
            this.txt_ProcesadorVm.TabIndex = 3;
            this.txt_ProcesadorVm.Tag = "ingrese";
            // 
            // lbl_NombreSrv
            // 
            this.lbl_NombreSrv.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreSrv.Location = new System.Drawing.Point(11, 42);
            this.lbl_NombreSrv.Name = "lbl_NombreSrv";
            this.lbl_NombreSrv.Size = new System.Drawing.Size(124, 14);
            this.lbl_NombreSrv.TabIndex = 376;
            this.lbl_NombreSrv.Text = "Nombre del Activo";
            // 
            // lbl_UsuarioSa
            // 
            this.lbl_UsuarioSa.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UsuarioSa.Location = new System.Drawing.Point(11, 240);
            this.lbl_UsuarioSa.Name = "lbl_UsuarioSa";
            this.lbl_UsuarioSa.Size = new System.Drawing.Size(124, 14);
            this.lbl_UsuarioSa.TabIndex = 388;
            this.lbl_UsuarioSa.Text = "User Base de Datos";
            // 
            // txt_NombreVm
            // 
            this.txt_NombreVm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NombreVm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_NombreVm.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreVm.Location = new System.Drawing.Point(488, 13);
            this.txt_NombreVm.Name = "txt_NombreVm";
            this.txt_NombreVm.Size = new System.Drawing.Size(197, 21);
            this.txt_NombreVm.TabIndex = 0;
            this.txt_NombreVm.Tag = "ingrese";
            this.txt_NombreVm.Enter += new System.EventHandler(this.txt_NombreVm_Enter);
            // 
            // lbl_UsuarioAdmin
            // 
            this.lbl_UsuarioAdmin.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UsuarioAdmin.Location = new System.Drawing.Point(11, 196);
            this.lbl_UsuarioAdmin.Name = "lbl_UsuarioAdmin";
            this.lbl_UsuarioAdmin.Size = new System.Drawing.Size(124, 14);
            this.lbl_UsuarioAdmin.TabIndex = 384;
            this.lbl_UsuarioAdmin.Text = "User Admininistrador";
            // 
            // txt_UsuarioAdmin
            // 
            this.txt_UsuarioAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UsuarioAdmin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_UsuarioAdmin.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UsuarioAdmin.Location = new System.Drawing.Point(135, 189);
            this.txt_UsuarioAdmin.Name = "txt_UsuarioAdmin";
            this.txt_UsuarioAdmin.Size = new System.Drawing.Size(197, 21);
            this.txt_UsuarioAdmin.TabIndex = 385;
            this.txt_UsuarioAdmin.Tag = "ingrese";
            // 
            // txt_MemoriaVm
            // 
            this.txt_MemoriaVm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MemoriaVm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_MemoriaVm.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MemoriaVm.Location = new System.Drawing.Point(488, 79);
            this.txt_MemoriaVm.Name = "txt_MemoriaVm";
            this.txt_MemoriaVm.Size = new System.Drawing.Size(197, 21);
            this.txt_MemoriaVm.TabIndex = 362;
            this.txt_MemoriaVm.Tag = "ingrese";
            // 
            // lbl_PasswordAdmin
            // 
            this.lbl_PasswordAdmin.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PasswordAdmin.Location = new System.Drawing.Point(11, 218);
            this.lbl_PasswordAdmin.Name = "lbl_PasswordAdmin";
            this.lbl_PasswordAdmin.Size = new System.Drawing.Size(124, 14);
            this.lbl_PasswordAdmin.TabIndex = 386;
            this.lbl_PasswordAdmin.Text = "Pass Administrador";
            // 
            // lbl_HddVm
            // 
            this.lbl_HddVm.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HddVm.Location = new System.Drawing.Point(364, 106);
            this.lbl_HddVm.Name = "lbl_HddVm";
            this.lbl_HddVm.Size = new System.Drawing.Size(124, 14);
            this.lbl_HddVm.TabIndex = 365;
            this.lbl_HddVm.Text = "HDD virtual";
            // 
            // txt_PasswordAdmin
            // 
            this.txt_PasswordAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PasswordAdmin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_PasswordAdmin.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PasswordAdmin.Location = new System.Drawing.Point(135, 211);
            this.txt_PasswordAdmin.Name = "txt_PasswordAdmin";
            this.txt_PasswordAdmin.Size = new System.Drawing.Size(197, 21);
            this.txt_PasswordAdmin.TabIndex = 387;
            this.txt_PasswordAdmin.Tag = "ingrese";
            // 
            // lbl_RutaVhd
            // 
            this.lbl_RutaVhd.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RutaVhd.Location = new System.Drawing.Point(364, 174);
            this.lbl_RutaVhd.Name = "lbl_RutaVhd";
            this.lbl_RutaVhd.Size = new System.Drawing.Size(124, 14);
            this.lbl_RutaVhd.TabIndex = 371;
            this.lbl_RutaVhd.Text = "Ruta HDD virtual";
            // 
            // txt_RutaVm
            // 
            this.txt_RutaVm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RutaVm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_RutaVm.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RutaVm.Location = new System.Drawing.Point(488, 145);
            this.txt_RutaVm.Name = "txt_RutaVm";
            this.txt_RutaVm.Size = new System.Drawing.Size(197, 21);
            this.txt_RutaVm.TabIndex = 370;
            this.txt_RutaVm.Tag = "ingrese";
            // 
            // txt_HddVm
            // 
            this.txt_HddVm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_HddVm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_HddVm.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HddVm.Location = new System.Drawing.Point(488, 101);
            this.txt_HddVm.Name = "txt_HddVm";
            this.txt_HddVm.Size = new System.Drawing.Size(197, 21);
            this.txt_HddVm.TabIndex = 364;
            this.txt_HddVm.Tag = "ingrese";
            // 
            // lbl_RutaVm
            // 
            this.lbl_RutaVm.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RutaVm.Location = new System.Drawing.Point(364, 152);
            this.lbl_RutaVm.Name = "lbl_RutaVm";
            this.lbl_RutaVm.Size = new System.Drawing.Size(124, 14);
            this.lbl_RutaVm.TabIndex = 369;
            this.lbl_RutaVm.Text = "Ruta Maquina virtual";
            // 
            // cbo_cluster
            // 
            this.cbo_cluster.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbo_cluster.FormattingEnabled = true;
            this.cbo_cluster.Items.AddRange(new object[] {
            "CLUSTER 01",
            "CLUSTER 02"});
            this.cbo_cluster.Location = new System.Drawing.Point(488, 123);
            this.cbo_cluster.Name = "cbo_cluster";
            this.cbo_cluster.Size = new System.Drawing.Size(197, 21);
            this.cbo_cluster.TabIndex = 368;
            // 
            // lbl_Cluster
            // 
            this.lbl_Cluster.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cluster.Location = new System.Drawing.Point(364, 128);
            this.lbl_Cluster.Name = "lbl_Cluster";
            this.lbl_Cluster.Size = new System.Drawing.Size(124, 14);
            this.lbl_Cluster.TabIndex = 367;
            this.lbl_Cluster.Text = "Cluster";
            // 
            // tp_servicios
            // 
            this.tp_servicios.BackColor = System.Drawing.SystemColors.Control;
            this.tp_servicios.Controls.Add(this.lbl_Servicio);
            this.tp_servicios.Controls.Add(this.dgv_detalle);
            this.tp_servicios.Controls.Add(this.txt_Id_Servicio);
            this.tp_servicios.Controls.Add(this.txt_Servicio);
            this.tp_servicios.Controls.Add(this.btn_opciones);
            this.tp_servicios.Location = new System.Drawing.Point(4, 20);
            this.tp_servicios.Name = "tp_servicios";
            this.tp_servicios.Size = new System.Drawing.Size(703, 285);
            this.tp_servicios.TabIndex = 5;
            this.tp_servicios.Text = "Servicios";
            // 
            // lbl_Servicio
            // 
            this.lbl_Servicio.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Servicio.Location = new System.Drawing.Point(11, 19);
            this.lbl_Servicio.Name = "lbl_Servicio";
            this.lbl_Servicio.Size = new System.Drawing.Size(124, 14);
            this.lbl_Servicio.TabIndex = 378;
            this.lbl_Servicio.Text = "Servicio";
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle.ContextMenuStrip = this.cm_grilla;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_detalle.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_detalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_detalle.EnableHeadersVisualStyles = false;
            this.dgv_detalle.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_detalle.Location = new System.Drawing.Point(14, 39);
            this.dgv_detalle.Name = "dgv_detalle";
            this.dgv_detalle.Size = new System.Drawing.Size(637, 212);
            this.dgv_detalle.TabIndex = 6;
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
            // txt_Id_Servicio
            // 
            this.txt_Id_Servicio.AcceptsTab = true;
            this.txt_Id_Servicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Id_Servicio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Id_Servicio.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id_Servicio.Location = new System.Drawing.Point(284, 12);
            this.txt_Id_Servicio.Name = "txt_Id_Servicio";
            this.txt_Id_Servicio.Size = new System.Drawing.Size(31, 21);
            this.txt_Id_Servicio.TabIndex = 373;
            this.txt_Id_Servicio.Tag = "ingrese";
            this.txt_Id_Servicio.Visible = false;
            // 
            // txt_Servicio
            // 
            this.txt_Servicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Servicio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Servicio.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Servicio.Location = new System.Drawing.Point(135, 12);
            this.txt_Servicio.Name = "txt_Servicio";
            this.txt_Servicio.Size = new System.Drawing.Size(143, 21);
            this.txt_Servicio.TabIndex = 379;
            this.txt_Servicio.Tag = "ingrese";
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
            this.btn_opciones.Location = new System.Drawing.Point(262, 15);
            this.btn_opciones.Name = "btn_opciones";
            this.btn_opciones.Size = new System.Drawing.Size(14, 14);
            this.btn_opciones.TabIndex = 356;
            this.btn_opciones.UseVisualStyleBackColor = false;
            this.btn_opciones.Visible = false;
            this.btn_opciones.Click += new System.EventHandler(this.btn_opciones_Click);
            // 
            // tp_anexo
            // 
            this.tp_anexo.BackColor = System.Drawing.SystemColors.Control;
            this.tp_anexo.Location = new System.Drawing.Point(4, 20);
            this.tp_anexo.Name = "tp_anexo";
            this.tp_anexo.Padding = new System.Windows.Forms.Padding(3);
            this.tp_anexo.Size = new System.Drawing.Size(703, 285);
            this.tp_anexo.TabIndex = 1;
            this.tp_anexo.Text = "Anexos";
            // 
            // tp_listado
            // 
            this.tp_listado.BackColor = System.Drawing.SystemColors.Control;
            this.tp_listado.Controls.Add(this.dgv_lista);
            this.tp_listado.Location = new System.Drawing.Point(4, 20);
            this.tp_listado.Name = "tp_listado";
            this.tp_listado.Padding = new System.Windows.Forms.Padding(3);
            this.tp_listado.Size = new System.Drawing.Size(703, 285);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_lista.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_lista.EnableHeadersVisualStyles = false;
            this.dgv_lista.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_lista.Location = new System.Drawing.Point(7, 15);
            this.dgv_lista.Name = "dgv_lista";
            this.dgv_lista.Size = new System.Drawing.Size(657, 235);
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
            this.tp_auditoria.Size = new System.Drawing.Size(703, 285);
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
            // tp_virtual
            // 
            this.tp_virtual.BackColor = System.Drawing.SystemColors.Control;
            this.tp_virtual.Location = new System.Drawing.Point(4, 20);
            this.tp_virtual.Name = "tp_virtual";
            this.tp_virtual.Size = new System.Drawing.Size(703, 285);
            this.tp_virtual.TabIndex = 4;
            this.tp_virtual.Text = "Virtual";
            // 
            // lbl_IdVm
            // 
            this.lbl_IdVm.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdVm.Location = new System.Drawing.Point(9, 89);
            this.lbl_IdVm.Name = "lbl_IdVm";
            this.lbl_IdVm.Size = new System.Drawing.Size(124, 14);
            this.lbl_IdVm.TabIndex = 347;
            this.lbl_IdVm.Text = "Codigo de Activo";
            // 
            // t_msg
            // 
            this.t_msg.Interval = 5000;
            this.t_msg.Tick += new System.EventHandler(this.t_msg_Tick);
            // 
            // txt_IdActivo
            // 
            this.txt_IdActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdActivo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_IdActivo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdActivo.Location = new System.Drawing.Point(133, 82);
            this.txt_IdActivo.Name = "txt_IdActivo";
            this.txt_IdActivo.Size = new System.Drawing.Size(143, 21);
            this.txt_IdActivo.TabIndex = 0;
            this.txt_IdActivo.Tag = "ingrese";
            this.txt_IdActivo.Enter += new System.EventHandler(this.txt_IdActivo_Enter);
            this.txt_IdActivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IdVm_KeyPress);
            this.txt_IdActivo.Leave += new System.EventHandler(this.txt_IdActivo_Leave);
            // 
            // txt_Observaciones
            // 
            this.txt_Observaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Observaciones.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Observaciones.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Observaciones.Location = new System.Drawing.Point(133, 527);
            this.txt_Observaciones.Multiline = true;
            this.txt_Observaciones.Name = "txt_Observaciones";
            this.txt_Observaciones.Size = new System.Drawing.Size(143, 42);
            this.txt_Observaciones.TabIndex = 374;
            this.txt_Observaciones.Tag = "ingrese";
            // 
            // lbl_Observaciones
            // 
            this.lbl_Observaciones.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Observaciones.Location = new System.Drawing.Point(9, 532);
            this.lbl_Observaciones.Name = "lbl_Observaciones";
            this.lbl_Observaciones.Size = new System.Drawing.Size(124, 14);
            this.lbl_Observaciones.TabIndex = 375;
            this.lbl_Observaciones.Text = "Observaciones";
            // 
            // lbl_SubClaseActivo
            // 
            this.lbl_SubClaseActivo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubClaseActivo.Location = new System.Drawing.Point(9, 155);
            this.lbl_SubClaseActivo.Name = "lbl_SubClaseActivo";
            this.lbl_SubClaseActivo.Size = new System.Drawing.Size(124, 14);
            this.lbl_SubClaseActivo.TabIndex = 378;
            this.lbl_SubClaseActivo.Text = "Sub clase de Activo";
            // 
            // lbl_TipoActivo
            // 
            this.lbl_TipoActivo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoActivo.Location = new System.Drawing.Point(9, 177);
            this.lbl_TipoActivo.Name = "lbl_TipoActivo";
            this.lbl_TipoActivo.Size = new System.Drawing.Size(124, 14);
            this.lbl_TipoActivo.TabIndex = 380;
            this.lbl_TipoActivo.Text = "Tipo de Activo";
            // 
            // txt_NroSerie
            // 
            this.txt_NroSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NroSerie.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_NroSerie.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NroSerie.Location = new System.Drawing.Point(543, 126);
            this.txt_NroSerie.Name = "txt_NroSerie";
            this.txt_NroSerie.Size = new System.Drawing.Size(143, 21);
            this.txt_NroSerie.TabIndex = 387;
            this.txt_NroSerie.Tag = "ingrese";
            // 
            // lbl_NroSerie
            // 
            this.lbl_NroSerie.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NroSerie.Location = new System.Drawing.Point(419, 133);
            this.lbl_NroSerie.Name = "lbl_NroSerie";
            this.lbl_NroSerie.Size = new System.Drawing.Size(124, 14);
            this.lbl_NroSerie.TabIndex = 386;
            this.lbl_NroSerie.Text = "Nº de serie";
            // 
            // txt_Modelo
            // 
            this.txt_Modelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Modelo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Modelo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Modelo.Location = new System.Drawing.Point(543, 104);
            this.txt_Modelo.Name = "txt_Modelo";
            this.txt_Modelo.Size = new System.Drawing.Size(143, 21);
            this.txt_Modelo.TabIndex = 385;
            this.txt_Modelo.Tag = "ingrese";
            // 
            // lbl_Modelo
            // 
            this.lbl_Modelo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Modelo.Location = new System.Drawing.Point(419, 111);
            this.lbl_Modelo.Name = "lbl_Modelo";
            this.lbl_Modelo.Size = new System.Drawing.Size(124, 14);
            this.lbl_Modelo.TabIndex = 384;
            this.lbl_Modelo.Text = "Modelo";
            // 
            // txt_Marca
            // 
            this.txt_Marca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Marca.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Marca.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Marca.Location = new System.Drawing.Point(543, 82);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(143, 21);
            this.txt_Marca.TabIndex = 383;
            this.txt_Marca.Tag = "ingrese";
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marca.Location = new System.Drawing.Point(419, 89);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(124, 14);
            this.lbl_Marca.TabIndex = 382;
            this.lbl_Marca.Text = "Marca";
            // 
            // lbl_estado
            // 
            this.lbl_estado.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(419, 155);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(124, 14);
            this.lbl_estado.TabIndex = 388;
            this.lbl_estado.Text = "Estado";
            // 
            // lbl_ClaseActivo
            // 
            this.lbl_ClaseActivo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClaseActivo.Location = new System.Drawing.Point(9, 132);
            this.lbl_ClaseActivo.Name = "lbl_ClaseActivo";
            this.lbl_ClaseActivo.Size = new System.Drawing.Size(124, 14);
            this.lbl_ClaseActivo.TabIndex = 392;
            this.lbl_ClaseActivo.Text = "Clase de activo";
            // 
            // cbo_TipoActivo
            // 
            this.cbo_TipoActivo.FormattingEnabled = true;
            this.cbo_TipoActivo.Location = new System.Drawing.Point(133, 170);
            this.cbo_TipoActivo.Name = "cbo_TipoActivo";
            this.cbo_TipoActivo.Size = new System.Drawing.Size(143, 21);
            this.cbo_TipoActivo.TabIndex = 393;
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
            this.btn_grabar.Location = new System.Drawing.Point(6, 596);
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
            this.btn_cancelar.Location = new System.Drawing.Point(76, 596);
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
            this.titulo.Size = new System.Drawing.Size(739, 27);
            this.titulo.TabIndex = 260;
            this.titulo.Text = "toolStrip1";
            this.titulo.DoubleClick += new System.EventHandler(this.titulo_DoubleClick);
            this.titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            // 
            // tsl_titulo
            // 
            this.tsl_titulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsl_titulo.Name = "tsl_titulo";
            this.tsl_titulo.Size = new System.Drawing.Size(111, 24);
            this.tsl_titulo.Text = "Catalogo de activos";
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
            // txt_Estado
            // 
            this.txt_Estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Estado.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Estado.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Estado.Location = new System.Drawing.Point(543, 148);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.Size = new System.Drawing.Size(143, 21);
            this.txt_Estado.TabIndex = 394;
            this.txt_Estado.Tag = "ingrese";
            // 
            // txt_EstadoId
            // 
            this.txt_EstadoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EstadoId.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_EstadoId.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EstadoId.Location = new System.Drawing.Point(510, 148);
            this.txt_EstadoId.Name = "txt_EstadoId";
            this.txt_EstadoId.Size = new System.Drawing.Size(27, 21);
            this.txt_EstadoId.TabIndex = 395;
            this.txt_EstadoId.Tag = "ingrese";
            this.txt_EstadoId.Visible = false;
            // 
            // txt_CodInventario
            // 
            this.txt_CodInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CodInventario.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_CodInventario.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodInventario.Location = new System.Drawing.Point(133, 104);
            this.txt_CodInventario.Name = "txt_CodInventario";
            this.txt_CodInventario.Size = new System.Drawing.Size(143, 21);
            this.txt_CodInventario.TabIndex = 397;
            this.txt_CodInventario.Tag = "ingrese";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 14);
            this.label8.TabIndex = 398;
            this.label8.Text = "Codigo de inventario";
            // 
            // cbo_SubClaseActivo
            // 
            this.cbo_SubClaseActivo.FormattingEnabled = true;
            this.cbo_SubClaseActivo.Items.AddRange(new object[] {
            "FISICO",
            "VIRTUAL"});
            this.cbo_SubClaseActivo.Location = new System.Drawing.Point(133, 148);
            this.cbo_SubClaseActivo.Name = "cbo_SubClaseActivo";
            this.cbo_SubClaseActivo.Size = new System.Drawing.Size(143, 21);
            this.cbo_SubClaseActivo.TabIndex = 399;
            // 
            // cbo_ClaseActivo
            // 
            this.cbo_ClaseActivo.FormattingEnabled = true;
            this.cbo_ClaseActivo.Items.AddRange(new object[] {
            "INTERNO",
            "EXTERNO"});
            this.cbo_ClaseActivo.Location = new System.Drawing.Point(133, 126);
            this.cbo_ClaseActivo.Name = "cbo_ClaseActivo";
            this.cbo_ClaseActivo.Size = new System.Drawing.Size(143, 21);
            this.cbo_ClaseActivo.TabIndex = 400;
            // 
            // FrmActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 643);
            this.ControlBox = false;
            this.Controls.Add(this.cbo_ClaseActivo);
            this.Controls.Add(this.cbo_SubClaseActivo);
            this.Controls.Add(this.txt_CodInventario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_EstadoId);
            this.Controls.Add(this.txt_Estado);
            this.Controls.Add(this.cbo_TipoActivo);
            this.Controls.Add(this.lbl_ClaseActivo);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.txt_NroSerie);
            this.Controls.Add(this.lbl_NroSerie);
            this.Controls.Add(this.txt_Modelo);
            this.Controls.Add(this.lbl_Modelo);
            this.Controls.Add(this.txt_Marca);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.lbl_TipoActivo);
            this.Controls.Add(this.lbl_SubClaseActivo);
            this.Controls.Add(this.txt_Observaciones);
            this.Controls.Add(this.lbl_Observaciones);
            this.Controls.Add(this.txt_IdActivo);
            this.Controls.Add(this.lbl_IdVm);
            this.Controls.Add(this.ts_acciones);
            this.Controls.Add(this.btn_grabar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.ss_load);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.tc_detalle);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmActivos";
            this.Load += new System.EventHandler(this.FrmAvanceProyecto_Load);
            this.ss_load.ResumeLayout(false);
            this.ss_load.PerformLayout();
            this.ts_acciones.ResumeLayout(false);
            this.ts_acciones.PerformLayout();
            this.tc_detalle.ResumeLayout(false);
            this.tp_contenido.ResumeLayout(false);
            this.tp_contenido.PerformLayout();
            this.tp_servicios.ResumeLayout(false);
            this.tp_servicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).EndInit();
            this.cm_grilla.ResumeLayout(false);
            this.tp_listado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).EndInit();
            this.tp_auditoria.ResumeLayout(false);
            this.tp_auditoria.PerformLayout();
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
        private System.Windows.Forms.Label lbl_ProcesadorVm;
        private System.Windows.Forms.Label lbl_MemoriaVm;
        private System.Windows.Forms.Label lbl_NombreVhd;
        private System.Windows.Forms.TextBox txt_PlacaVm;
        private System.Windows.Forms.Label lbl_NombreVm;
        private System.Windows.Forms.TabControl tc_detalle;
        private System.Windows.Forms.TabPage tp_contenido;
        private System.Windows.Forms.TabPage tp_anexo;
        private System.Windows.Forms.TextBox txt_ProcesadorVm;
        private System.Windows.Forms.Label lbl_IdVm;
        private System.Windows.Forms.DataGridView dgv_detalle;
        private System.Windows.Forms.Timer t_msg;
        private System.Windows.Forms.Button btn_opciones;
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
        private System.Windows.Forms.TextBox txt_NombreVm;
        private System.Windows.Forms.TextBox txt_MemoriaVm;
        private System.Windows.Forms.TextBox txt_IdActivo;
        private System.Windows.Forms.TextBox txt_HddVm;
        private System.Windows.Forms.Label lbl_HddVm;
        private System.Windows.Forms.Label lbl_Cluster;
        private System.Windows.Forms.ComboBox cbo_cluster;
        private System.Windows.Forms.TextBox txt_RutaVm;
        private System.Windows.Forms.Label lbl_RutaVm;
        private System.Windows.Forms.TextBox txt_RutaVhd;
        private System.Windows.Forms.Label lbl_RutaVhd;
        private System.Windows.Forms.TextBox txt_Id_Servicio;
        private System.Windows.Forms.TextBox txt_Observaciones;
        private System.Windows.Forms.Label lbl_Observaciones;
        private System.Windows.Forms.TextBox txt_NombreSrv;
        private System.Windows.Forms.Label lbl_NombreSrv;
        private System.Windows.Forms.TextBox txt_SO;
        private System.Windows.Forms.Label lbl_SO;
        private System.Windows.Forms.TextBox txt_IPSrv;
        private System.Windows.Forms.Label lbl_IPSrv;
        private System.Windows.Forms.TextBox txt_IPSrvPublica;
        private System.Windows.Forms.Label lbl_IPSrvPublica;
        private System.Windows.Forms.TextBox txt_UsuarioAdmin;
        private System.Windows.Forms.Label lbl_UsuarioAdmin;
        private System.Windows.Forms.TextBox txt_PasswordAdmin;
        private System.Windows.Forms.Label lbl_PasswordAdmin;
        private System.Windows.Forms.TextBox txt_PasswordSa;
        private System.Windows.Forms.Label lbl_PasswordSa;
        private System.Windows.Forms.TextBox txt_UsuarioSa;
        private System.Windows.Forms.Label lbl_UsuarioSa;
        private System.Windows.Forms.TabPage tp_virtual;
        private System.Windows.Forms.TabPage tp_servicios;
        private System.Windows.Forms.Label lbl_SubClaseActivo;
        private System.Windows.Forms.Label lbl_TipoActivo;
        private System.Windows.Forms.TextBox txt_NroSerie;
        private System.Windows.Forms.Label lbl_NroSerie;
        private System.Windows.Forms.TextBox txt_Modelo;
        private System.Windows.Forms.Label lbl_Modelo;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Procesador;
        private System.Windows.Forms.TextBox txt_Memoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_HDD;
        private System.Windows.Forms.Label lbl_Servicio;
        private System.Windows.Forms.TextBox txt_Servicio;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_ClaseActivo;
        private System.Windows.Forms.ComboBox cbo_TipoActivo;
        private System.Windows.Forms.Button btn_busqueda;
        private System.Windows.Forms.Label lbl_Placa;
        private System.Windows.Forms.TextBox txt_Placa;
        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.TextBox txt_EstadoId;
        private System.Windows.Forms.TextBox txt_CodInventario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_SubClaseActivo;
        private System.Windows.Forms.ComboBox cbo_ClaseActivo;
    }
}