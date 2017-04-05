namespace MISAP
{
    partial class FrmTareo_ModMasiva
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.chkOT = new System.Windows.Forms.CheckBox();
            this.chkHe = new System.Windows.Forms.CheckBox();
            this.chkHn = new System.Windows.Forms.CheckBox();
            this.chkFalta = new System.Windows.Forms.CheckBox();
            this.chkTipo = new System.Windows.Forms.CheckBox();
            this.chkTurno = new System.Windows.Forms.CheckBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.txtHn_mod = new System.Windows.Forms.TextBox();
            this.txtHe_mod = new System.Windows.Forms.TextBox();
            this.lblTareador_masiv = new System.Windows.Forms.Label();
            this.lblSemana_masiv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAnio_masiv = new System.Windows.Forms.Label();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboFalta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTituloReporte = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cboOT = new System.Windows.Forms.ComboBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cm_grilla.SuspendLayout();
            this.ts_acciones.SuspendLayout();
            this.ss_load.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            // 
            // cm_grilla_copia_tabla
            // 
            this.cm_grilla_copia_tabla.Name = "cm_grilla_copia_tabla";
            this.cm_grilla_copia_tabla.Size = new System.Drawing.Size(134, 22);
            this.cm_grilla_copia_tabla.Text = "Copia tabla";
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
            this.ts_acciones.Size = new System.Drawing.Size(370, 48);
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
            this.ss_load.Location = new System.Drawing.Point(0, 429);
            this.ss_load.Name = "ss_load";
            this.ss_load.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ss_load.Size = new System.Drawing.Size(370, 18);
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
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.cboTipo);
            this.groupBox4.Controls.Add(this.cboOT);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtObservacion);
            this.groupBox4.Controls.Add(this.chkOT);
            this.groupBox4.Controls.Add(this.chkHe);
            this.groupBox4.Controls.Add(this.chkHn);
            this.groupBox4.Controls.Add(this.chkFalta);
            this.groupBox4.Controls.Add(this.chkTipo);
            this.groupBox4.Controls.Add(this.chkTurno);
            this.groupBox4.Controls.Add(this.btn_cancelar);
            this.groupBox4.Controls.Add(this.btn_grabar);
            this.groupBox4.Controls.Add(this.txtHn_mod);
            this.groupBox4.Controls.Add(this.txtHe_mod);
            this.groupBox4.Controls.Add(this.lblTareador_masiv);
            this.groupBox4.Controls.Add(this.lblSemana_masiv);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lblAnio_masiv);
            this.groupBox4.Controls.Add(this.cboTurno);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cboFalta);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(8, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 348);
            this.groupBox4.TabIndex = 285;
            this.groupBox4.TabStop = false;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(95, 261);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(232, 51);
            this.txtObservacion.TabIndex = 303;
            // 
            // chkOT
            // 
            this.chkOT.AutoSize = true;
            this.chkOT.Location = new System.Drawing.Point(26, 125);
            this.chkOT.Name = "chkOT";
            this.chkOT.Size = new System.Drawing.Size(41, 17);
            this.chkOT.TabIndex = 301;
            this.chkOT.Text = "OT";
            this.chkOT.UseVisualStyleBackColor = true;
            this.chkOT.CheckedChanged += new System.EventHandler(this.chkOT_CheckedChanged);
            // 
            // chkHe
            // 
            this.chkHe.AutoSize = true;
            this.chkHe.Location = new System.Drawing.Point(26, 234);
            this.chkHe.Name = "chkHe";
            this.chkHe.Size = new System.Drawing.Size(50, 17);
            this.chkHe.TabIndex = 299;
            this.chkHe.Text = "H. E.";
            this.chkHe.UseVisualStyleBackColor = true;
            this.chkHe.CheckedChanged += new System.EventHandler(this.chkHe_CheckedChanged);
            // 
            // chkHn
            // 
            this.chkHn.AutoSize = true;
            this.chkHn.Location = new System.Drawing.Point(26, 208);
            this.chkHn.Name = "chkHn";
            this.chkHn.Size = new System.Drawing.Size(51, 17);
            this.chkHn.TabIndex = 298;
            this.chkHn.Text = "H. N.";
            this.chkHn.UseVisualStyleBackColor = true;
            this.chkHn.CheckedChanged += new System.EventHandler(this.chkHn_CheckedChanged);
            // 
            // chkFalta
            // 
            this.chkFalta.AutoSize = true;
            this.chkFalta.Location = new System.Drawing.Point(26, 176);
            this.chkFalta.Name = "chkFalta";
            this.chkFalta.Size = new System.Drawing.Size(49, 17);
            this.chkFalta.TabIndex = 297;
            this.chkFalta.Text = "Falta";
            this.chkFalta.UseVisualStyleBackColor = true;
            this.chkFalta.CheckedChanged += new System.EventHandler(this.chkFalta_CheckedChanged);
            // 
            // chkTipo
            // 
            this.chkTipo.AutoSize = true;
            this.chkTipo.Location = new System.Drawing.Point(26, 150);
            this.chkTipo.Name = "chkTipo";
            this.chkTipo.Size = new System.Drawing.Size(47, 17);
            this.chkTipo.TabIndex = 296;
            this.chkTipo.Text = "Tipo";
            this.chkTipo.UseVisualStyleBackColor = true;
            this.chkTipo.CheckedChanged += new System.EventHandler(this.chkTipo_CheckedChanged);
            // 
            // chkTurno
            // 
            this.chkTurno.AutoSize = true;
            this.chkTurno.Location = new System.Drawing.Point(26, 98);
            this.chkTurno.Name = "chkTurno";
            this.chkTurno.Size = new System.Drawing.Size(54, 17);
            this.chkTurno.TabIndex = 295;
            this.chkTurno.Text = "Turno";
            this.chkTurno.UseVisualStyleBackColor = true;
            this.chkTurno.CheckedChanged += new System.EventHandler(this.chkTurno_CheckedChanged);
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
            this.btn_cancelar.Location = new System.Drawing.Point(178, 318);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(64, 21);
            this.btn_cancelar.TabIndex = 293;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_grabar
            // 
            this.btn_grabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_grabar.BackgroundImage = global::MISAP.Properties.Resources.btn_enfasis_dasactivado;
            this.btn_grabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_grabar.FlatAppearance.BorderSize = 0;
            this.btn_grabar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_grabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grabar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grabar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_grabar.Location = new System.Drawing.Point(90, 318);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(64, 21);
            this.btn_grabar.TabIndex = 292;
            this.btn_grabar.Text = "Grabar";
            this.btn_grabar.UseVisualStyleBackColor = true;
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // txtHn_mod
            // 
            this.txtHn_mod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHn_mod.Enabled = false;
            this.txtHn_mod.Location = new System.Drawing.Point(95, 207);
            this.txtHn_mod.MaxLength = 3;
            this.txtHn_mod.Name = "txtHn_mod";
            this.txtHn_mod.Size = new System.Drawing.Size(59, 20);
            this.txtHn_mod.TabIndex = 284;
            this.txtHn_mod.Text = "0";
            // 
            // txtHe_mod
            // 
            this.txtHe_mod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHe_mod.Enabled = false;
            this.txtHe_mod.Location = new System.Drawing.Point(94, 233);
            this.txtHe_mod.MaxLength = 3;
            this.txtHe_mod.Name = "txtHe_mod";
            this.txtHe_mod.Size = new System.Drawing.Size(59, 20);
            this.txtHe_mod.TabIndex = 285;
            this.txtHe_mod.Text = "0";
            // 
            // lblTareador_masiv
            // 
            this.lblTareador_masiv.AutoSize = true;
            this.lblTareador_masiv.Location = new System.Drawing.Point(87, 69);
            this.lblTareador_masiv.Name = "lblTareador_masiv";
            this.lblTareador_masiv.Size = new System.Drawing.Size(50, 13);
            this.lblTareador_masiv.TabIndex = 281;
            this.lblTareador_masiv.Text = "Tareador";
            // 
            // lblSemana_masiv
            // 
            this.lblSemana_masiv.AutoSize = true;
            this.lblSemana_masiv.Location = new System.Drawing.Point(87, 50);
            this.lblSemana_masiv.Name = "lblSemana_masiv";
            this.lblSemana_masiv.Size = new System.Drawing.Size(46, 13);
            this.lblSemana_masiv.TabIndex = 280;
            this.lblSemana_masiv.Text = "Semana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 279;
            this.label2.Text = "Semana:";
            // 
            // lblAnio_masiv
            // 
            this.lblAnio_masiv.AutoSize = true;
            this.lblAnio_masiv.Location = new System.Drawing.Point(87, 31);
            this.lblAnio_masiv.Name = "lblAnio_masiv";
            this.lblAnio_masiv.Size = new System.Drawing.Size(28, 13);
            this.lblAnio_masiv.TabIndex = 278;
            this.lblAnio_masiv.Text = "Anio";
            // 
            // cboTurno
            // 
            this.cboTurno.BackColor = System.Drawing.Color.White;
            this.cboTurno.Enabled = false;
            this.cboTurno.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTurno.FormattingEnabled = true;
            this.cboTurno.ItemHeight = 14;
            this.cboTurno.Location = new System.Drawing.Point(95, 96);
            this.cboTurno.Name = "cboTurno";
            this.cboTurno.Size = new System.Drawing.Size(232, 22);
            this.cboTurno.TabIndex = 276;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 14);
            this.label9.TabIndex = 270;
            this.label9.Text = "Tareador:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboFalta
            // 
            this.cboFalta.BackColor = System.Drawing.Color.White;
            this.cboFalta.Enabled = false;
            this.cboFalta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFalta.FormattingEnabled = true;
            this.cboFalta.ItemHeight = 14;
            this.cboFalta.Location = new System.Drawing.Point(95, 174);
            this.cboFalta.Name = "cboFalta";
            this.cboFalta.Size = new System.Drawing.Size(232, 22);
            this.cboFalta.TabIndex = 269;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año:";
            // 
            // lblTituloReporte
            // 
            this.lblTituloReporte.AutoSize = true;
            this.lblTituloReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReporte.Location = new System.Drawing.Point(14, 92);
            this.lblTituloReporte.Name = "lblTituloReporte";
            this.lblTituloReporte.Size = new System.Drawing.Size(0, 24);
            this.lblTituloReporte.TabIndex = 286;
            // 
            // titulo
            // 
            this.titulo.AutoSize = false;
            this.titulo.BackgroundImage = global::MISAP.Properties.Resources.shell_header_2;
            this.titulo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.titulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.salir,
            this.ninimizar});
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.titulo.Size = new System.Drawing.Size(370, 27);
            this.titulo.TabIndex = 226;
            this.titulo.Text = "toolStrip1";
            this.titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            this.titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseMove);
            this.titulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseUp);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(117, 24);
            this.toolStripLabel1.Text = "Modificación Masiva";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 14);
            this.label3.TabIndex = 304;
            this.label3.Text = "Observación:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboOT
            // 
            this.cboOT.BackColor = System.Drawing.Color.White;
            this.cboOT.Enabled = false;
            this.cboOT.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOT.FormattingEnabled = true;
            this.cboOT.ItemHeight = 14;
            this.cboOT.Location = new System.Drawing.Point(95, 123);
            this.cboOT.Name = "cboOT";
            this.cboOT.Size = new System.Drawing.Size(232, 22);
            this.cboOT.TabIndex = 305;
            // 
            // cboTipo
            // 
            this.cboTipo.BackColor = System.Drawing.Color.White;
            this.cboTipo.Enabled = false;
            this.cboTipo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.ItemHeight = 14;
            this.cboTipo.Location = new System.Drawing.Point(95, 148);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(232, 22);
            this.cboTipo.TabIndex = 306;
            // 
            // FrmTareo_ModMasiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 447);
            this.ControlBox = false;
            this.Controls.Add(this.lblTituloReporte);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.l_dni);
            this.Controls.Add(this.l_usuario);
            this.Controls.Add(this.ss_load);
            this.Controls.Add(this.ts_acciones);
            this.Controls.Add(this.titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmTareo_ModMasiva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmTareo_Mod_Load);
            this.cm_grilla.ResumeLayout(false);
            this.ts_acciones.ResumeLayout(false);
            this.ts_acciones.PerformLayout();
            this.ss_load.ResumeLayout(false);
            this.ss_load.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.titulo.ResumeLayout(false);
            this.titulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip titulo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton salir;
        private System.Windows.Forms.ToolStripButton ninimizar;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblTituloReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboFalta;
        private System.Windows.Forms.Label lblTareador_masiv;
        private System.Windows.Forms.Label lblSemana_masiv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAnio_masiv;
        private System.Windows.Forms.TextBox txtHn_mod;
        private System.Windows.Forms.TextBox txtHe_mod;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_grabar;
        private System.Windows.Forms.CheckBox chkHe;
        private System.Windows.Forms.CheckBox chkHn;
        private System.Windows.Forms.CheckBox chkFalta;
        private System.Windows.Forms.CheckBox chkTipo;
        private System.Windows.Forms.CheckBox chkTurno;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.CheckBox chkOT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboOT;
    }
}