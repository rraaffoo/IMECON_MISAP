namespace MISAP
{
    partial class FrmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracion));
            this.btn_grabar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.ss_load = new System.Windows.Forms.StatusStrip();
            this.lbl_contador_registros = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_CODSOL = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_U_CL_SOLICI = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_msg = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_maximi = new System.Windows.Forms.ToolStripStatusLabel();
            this.t_msg = new System.Windows.Forms.Timer(this.components);
            this.titulo = new System.Windows.Forms.ToolStrip();
            this.tsl_titulo = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            this.txt_referencia = new System.Windows.Forms.TextBox();
            this.lbl_referencia = new System.Windows.Forms.Label();
            this.lbl_fechaoperacion = new System.Windows.Forms.Label();
            this.txt_fechaoperacion = new System.Windows.Forms.TextBox();
            this.lbl_montodebito = new System.Windows.Forms.Label();
            this.txt_montodebito = new System.Windows.Forms.TextBox();
            this.lbl_montocredito = new System.Windows.Forms.Label();
            this.txt_montocredito = new System.Windows.Forms.TextBox();
            this.lbl_banco = new System.Windows.Forms.Label();
            this.txt_filas = new System.Windows.Forms.TextBox();
            this.lbl_filas = new System.Windows.Forms.Label();
            this.txt_info = new System.Windows.Forms.TextBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.txt_correlativo = new System.Windows.Forms.TextBox();
            this.lbl_correlativo = new System.Windows.Forms.Label();
            this.ss_load.SuspendLayout();
            this.titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_grabar
            // 
            this.btn_grabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_grabar.BackgroundImage = global::MISAP.Properties.Resources.btn_enfasis;
            this.btn_grabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_grabar.FlatAppearance.BorderSize = 0;
            this.btn_grabar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_grabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grabar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grabar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_grabar.Location = new System.Drawing.Point(7, 211);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(64, 21);
            this.btn_grabar.TabIndex = 283;
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
            this.btn_cancelar.Location = new System.Drawing.Point(77, 211);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(64, 21);
            this.btn_cancelar.TabIndex = 284;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.salir_Click);
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
            this.ss_load.Location = new System.Drawing.Point(0, 234);
            this.ss_load.Name = "ss_load";
            this.ss_load.Size = new System.Drawing.Size(559, 17);
            this.ss_load.SizingGrip = false;
            this.ss_load.TabIndex = 285;
            this.ss_load.Text = "statusStrip1";
            // 
            // lbl_contador_registros
            // 
            this.lbl_contador_registros.AutoSize = false;
            this.lbl_contador_registros.BackColor = System.Drawing.Color.Transparent;
            this.lbl_contador_registros.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contador_registros.Name = "lbl_contador_registros";
            this.lbl_contador_registros.Size = new System.Drawing.Size(180, 12);
            this.lbl_contador_registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_contador_registros.Visible = false;
            // 
            // lbl_U_CL_CODSOL
            // 
            this.lbl_U_CL_CODSOL.Name = "lbl_U_CL_CODSOL";
            this.lbl_U_CL_CODSOL.Size = new System.Drawing.Size(0, 12);
            // 
            // lbl_U_CL_SOLICI
            // 
            this.lbl_U_CL_SOLICI.Name = "lbl_U_CL_SOLICI";
            this.lbl_U_CL_SOLICI.Size = new System.Drawing.Size(0, 12);
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
            this.lbl_msg.Size = new System.Drawing.Size(29, 12);
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
            this.lbl_maximi.Size = new System.Drawing.Size(18, 12);
            this.lbl_maximi.Text = "1";
            this.lbl_maximi.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.lbl_maximi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.lbl_maximi.Visible = false;
            // 
            // t_msg
            // 
            this.t_msg.Interval = 4000;
            this.t_msg.Tick += new System.EventHandler(this.t_msg_Tick);
            // 
            // titulo
            // 
            this.titulo.AutoSize = false;
            this.titulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titulo.BackgroundImage")));
            this.titulo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.titulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_titulo,
            this.salir,
            this.ninimizar});
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.titulo.Size = new System.Drawing.Size(559, 27);
            this.titulo.TabIndex = 286;
            this.titulo.Text = "toolStrip1";
            this.titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            // 
            // tsl_titulo
            // 
            this.tsl_titulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsl_titulo.Name = "tsl_titulo";
            this.tsl_titulo.Size = new System.Drawing.Size(239, 24);
            this.tsl_titulo.Text = "Configuracion extractos de cuentas externas";
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
            // txt_referencia
            // 
            this.txt_referencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_referencia.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_referencia.Location = new System.Drawing.Point(133, 121);
            this.txt_referencia.Name = "txt_referencia";
            this.txt_referencia.Size = new System.Drawing.Size(176, 20);
            this.txt_referencia.TabIndex = 3;
            this.txt_referencia.Tag = "ingrese";
            // 
            // lbl_referencia
            // 
            this.lbl_referencia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_referencia.Location = new System.Drawing.Point(9, 128);
            this.lbl_referencia.Name = "lbl_referencia";
            this.lbl_referencia.Size = new System.Drawing.Size(124, 14);
            this.lbl_referencia.TabIndex = 293;
            this.lbl_referencia.Text = "Referencia";
            // 
            // lbl_fechaoperacion
            // 
            this.lbl_fechaoperacion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaoperacion.Location = new System.Drawing.Point(9, 106);
            this.lbl_fechaoperacion.Name = "lbl_fechaoperacion";
            this.lbl_fechaoperacion.Size = new System.Drawing.Size(124, 14);
            this.lbl_fechaoperacion.TabIndex = 292;
            this.lbl_fechaoperacion.Text = "Fecha de operacion";
            // 
            // txt_fechaoperacion
            // 
            this.txt_fechaoperacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fechaoperacion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_fechaoperacion.Location = new System.Drawing.Point(133, 100);
            this.txt_fechaoperacion.Name = "txt_fechaoperacion";
            this.txt_fechaoperacion.Size = new System.Drawing.Size(176, 20);
            this.txt_fechaoperacion.TabIndex = 2;
            this.txt_fechaoperacion.Tag = "ingrese";
            // 
            // lbl_montodebito
            // 
            this.lbl_montodebito.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_montodebito.Location = new System.Drawing.Point(9, 85);
            this.lbl_montodebito.Name = "lbl_montodebito";
            this.lbl_montodebito.Size = new System.Drawing.Size(124, 14);
            this.lbl_montodebito.TabIndex = 291;
            this.lbl_montodebito.Text = "Monto de debito";
            // 
            // txt_montodebito
            // 
            this.txt_montodebito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_montodebito.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_montodebito.Location = new System.Drawing.Point(133, 79);
            this.txt_montodebito.Name = "txt_montodebito";
            this.txt_montodebito.Size = new System.Drawing.Size(176, 20);
            this.txt_montodebito.TabIndex = 1;
            this.txt_montodebito.Tag = "ingrese";
            // 
            // lbl_montocredito
            // 
            this.lbl_montocredito.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_montocredito.Location = new System.Drawing.Point(9, 64);
            this.lbl_montocredito.Name = "lbl_montocredito";
            this.lbl_montocredito.Size = new System.Drawing.Size(124, 14);
            this.lbl_montocredito.TabIndex = 289;
            this.lbl_montocredito.Text = "Monto de credito";
            // 
            // txt_montocredito
            // 
            this.txt_montocredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_montocredito.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_montocredito.Location = new System.Drawing.Point(133, 58);
            this.txt_montocredito.Margin = new System.Windows.Forms.Padding(0);
            this.txt_montocredito.MaxLength = 8;
            this.txt_montocredito.Name = "txt_montocredito";
            this.txt_montocredito.Size = new System.Drawing.Size(176, 20);
            this.txt_montocredito.TabIndex = 0;
            this.txt_montocredito.Tag = "ingrese";
            // 
            // lbl_banco
            // 
            this.lbl_banco.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_banco.Location = new System.Drawing.Point(9, 40);
            this.lbl_banco.Name = "lbl_banco";
            this.lbl_banco.Size = new System.Drawing.Size(301, 11);
            this.lbl_banco.TabIndex = 295;
            // 
            // txt_filas
            // 
            this.txt_filas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_filas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_filas.Location = new System.Drawing.Point(133, 163);
            this.txt_filas.Name = "txt_filas";
            this.txt_filas.Size = new System.Drawing.Size(176, 20);
            this.txt_filas.TabIndex = 5;
            this.txt_filas.Tag = "ingrese";
            // 
            // lbl_filas
            // 
            this.lbl_filas.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filas.Location = new System.Drawing.Point(9, 170);
            this.lbl_filas.Name = "lbl_filas";
            this.lbl_filas.Size = new System.Drawing.Size(124, 14);
            this.lbl_filas.TabIndex = 296;
            this.lbl_filas.Text = "Cant. filas encabezado";
            // 
            // txt_info
            // 
            this.txt_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_info.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_info.Location = new System.Drawing.Point(133, 142);
            this.txt_info.Name = "txt_info";
            this.txt_info.Size = new System.Drawing.Size(176, 20);
            this.txt_info.TabIndex = 4;
            this.txt_info.Tag = "ingrese";
            // 
            // lbl_info
            // 
            this.lbl_info.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(10, 149);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(124, 14);
            this.lbl_info.TabIndex = 298;
            this.lbl_info.Text = "Info. Detalle";
            // 
            // txt_correlativo
            // 
            this.txt_correlativo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_correlativo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_correlativo.Location = new System.Drawing.Point(133, 184);
            this.txt_correlativo.Name = "txt_correlativo";
            this.txt_correlativo.Size = new System.Drawing.Size(176, 20);
            this.txt_correlativo.TabIndex = 299;
            this.txt_correlativo.Tag = "ingrese";
            // 
            // lbl_correlativo
            // 
            this.lbl_correlativo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correlativo.Location = new System.Drawing.Point(9, 191);
            this.lbl_correlativo.Name = "lbl_correlativo";
            this.lbl_correlativo.Size = new System.Drawing.Size(124, 14);
            this.lbl_correlativo.TabIndex = 300;
            this.lbl_correlativo.Text = "Correlativo";
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 251);
            this.ControlBox = false;
            this.Controls.Add(this.txt_correlativo);
            this.Controls.Add(this.lbl_correlativo);
            this.Controls.Add(this.txt_info);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.txt_filas);
            this.Controls.Add(this.lbl_filas);
            this.Controls.Add(this.lbl_banco);
            this.Controls.Add(this.txt_referencia);
            this.Controls.Add(this.lbl_referencia);
            this.Controls.Add(this.lbl_fechaoperacion);
            this.Controls.Add(this.txt_fechaoperacion);
            this.Controls.Add(this.lbl_montodebito);
            this.Controls.Add(this.txt_montodebito);
            this.Controls.Add(this.lbl_montocredito);
            this.Controls.Add(this.txt_montocredito);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.ss_load);
            this.Controls.Add(this.btn_grabar);
            this.Controls.Add(this.btn_cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmConfiguracion";
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            this.ss_load.ResumeLayout(false);
            this.ss_load.PerformLayout();
            this.titulo.ResumeLayout(false);
            this.titulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_grabar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.StatusStrip ss_load;
        private System.Windows.Forms.ToolStripStatusLabel lbl_contador_registros;
        private System.Windows.Forms.ToolStripStatusLabel lbl_U_CL_CODSOL;
        private System.Windows.Forms.ToolStripStatusLabel lbl_U_CL_SOLICI;
        private System.Windows.Forms.ToolStripStatusLabel lbl_msg;
        private System.Windows.Forms.ToolStripStatusLabel lbl_maximi;
        private System.Windows.Forms.Timer t_msg;
        private System.Windows.Forms.ToolStrip titulo;
        private System.Windows.Forms.ToolStripLabel tsl_titulo;
        private System.Windows.Forms.ToolStripButton salir;
        private System.Windows.Forms.ToolStripButton ninimizar;
        private System.Windows.Forms.TextBox txt_referencia;
        private System.Windows.Forms.Label lbl_referencia;
        private System.Windows.Forms.Label lbl_fechaoperacion;
        private System.Windows.Forms.TextBox txt_fechaoperacion;
        private System.Windows.Forms.Label lbl_montodebito;
        private System.Windows.Forms.TextBox txt_montodebito;
        private System.Windows.Forms.Label lbl_montocredito;
        private System.Windows.Forms.TextBox txt_montocredito;
        private System.Windows.Forms.Label lbl_banco;
        private System.Windows.Forms.TextBox txt_filas;
        private System.Windows.Forms.Label lbl_filas;
        private System.Windows.Forms.TextBox txt_info;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.TextBox txt_correlativo;
        private System.Windows.Forms.Label lbl_correlativo;
    }
}