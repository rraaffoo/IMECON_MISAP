namespace MISAP
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_cdg_usr = new System.Windows.Forms.TextBox();
            this.txt_psw_usr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_bd_externa = new System.Windows.Forms.TextBox();
            this.titulo = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rb_produccion = new System.Windows.Forms.RadioButton();
            this.rb_pruebas = new System.Windows.Forms.RadioButton();
            this.cbo_bd_sociedad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ambiente = new System.Windows.Forms.TextBox();
            this.txt_sociedad = new System.Windows.Forms.TextBox();
            this.titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(592, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "                           ";
            // 
            // txt_ip
            // 
            this.txt_ip.Font = new System.Drawing.Font("Tahoma", 7.4F);
            this.txt_ip.Location = new System.Drawing.Point(12, 140);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(16, 19);
            this.txt_ip.TabIndex = 20;
            this.txt_ip.Text = "ip";
            this.txt_ip.Visible = false;
            // 
            // txt_cdg_usr
            // 
            this.txt_cdg_usr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cdg_usr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cdg_usr.Font = new System.Drawing.Font("Tahoma", 7.4F);
            this.txt_cdg_usr.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_cdg_usr.Location = new System.Drawing.Point(294, 134);
            this.txt_cdg_usr.Name = "txt_cdg_usr";
            this.txt_cdg_usr.Size = new System.Drawing.Size(159, 19);
            this.txt_cdg_usr.TabIndex = 23;
            this.txt_cdg_usr.Text = "DCHUCOS";
            this.txt_cdg_usr.Leave += new System.EventHandler(this.txt_cdg_usr_Leave);
            // 
            // txt_psw_usr
            // 
            this.txt_psw_usr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_psw_usr.Font = new System.Drawing.Font("Tahoma", 7.4F);
            this.txt_psw_usr.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_psw_usr.Location = new System.Drawing.Point(294, 155);
            this.txt_psw_usr.Name = "txt_psw_usr";
            this.txt_psw_usr.Size = new System.Drawing.Size(159, 19);
            this.txt_psw_usr.TabIndex = 24;
            this.txt_psw_usr.Text = "da2810ga";
            this.txt_psw_usr.UseSystemPasswordChar = true;
            this.txt_psw_usr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_psw_usr_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.4F);
            this.label6.Location = new System.Drawing.Point(177, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "Clave de acceso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.4F);
            this.label7.Location = new System.Drawing.Point(177, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "ID de usuario";
            // 
            // txt_bd_externa
            // 
            this.txt_bd_externa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bd_externa.Font = new System.Drawing.Font("Arial", 7.4F);
            this.txt_bd_externa.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_bd_externa.Location = new System.Drawing.Point(12, 69);
            this.txt_bd_externa.Multiline = true;
            this.txt_bd_externa.Name = "txt_bd_externa";
            this.txt_bd_externa.Size = new System.Drawing.Size(154, 19);
            this.txt_bd_externa.TabIndex = 246;
            this.txt_bd_externa.Text = "SBO_IMECON_PRODUCCION";
            this.txt_bd_externa.Visible = false;
            // 
            // titulo
            // 
            this.titulo.AutoSize = false;
            this.titulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titulo.BackgroundImage")));
            this.titulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titulo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.titulo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.titulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.titulo.Size = new System.Drawing.Size(476, 31);
            this.titulo.TabIndex = 245;
            this.titulo.Text = "Menú principal";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(170, 28);
            this.toolStripLabel1.Text = "MISAP Modulo de interfaz SAP";
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_finalizar.BackgroundImage = global::MISAP.Properties.Resources.btn;
            this.btn_finalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_finalizar.FlatAppearance.BorderSize = 0;
            this.btn_finalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_finalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalizar.Font = new System.Drawing.Font("Arial", 7.4F);
            this.btn_finalizar.Location = new System.Drawing.Point(380, 241);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(73, 24);
            this.btn_finalizar.TabIndex = 11;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = false;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.Transparent;
            this.btn_ok.BackgroundImage = global::MISAP.Properties.Resources.btn_enfasis;
            this.btn_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ok.FlatAppearance.BorderSize = 0;
            this.btn_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Arial", 7.4F);
            this.btn_ok.Location = new System.Drawing.Point(299, 241);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 24);
            this.btn_ok.TabIndex = 10;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MISAP.Properties.Resources.fondo_login;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 221);
            this.pictureBox1.TabIndex = 247;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MISAP.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(153, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 248;
            this.pictureBox2.TabStop = false;
            // 
            // rb_produccion
            // 
            this.rb_produccion.AutoSize = true;
            this.rb_produccion.Checked = true;
            this.rb_produccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_produccion.Location = new System.Drawing.Point(11, 119);
            this.rb_produccion.Name = "rb_produccion";
            this.rb_produccion.Size = new System.Drawing.Size(78, 18);
            this.rb_produccion.TabIndex = 250;
            this.rb_produccion.TabStop = true;
            this.rb_produccion.Text = "Produccion";
            this.rb_produccion.UseVisualStyleBackColor = true;
            this.rb_produccion.Visible = false;
            this.rb_produccion.CheckedChanged += new System.EventHandler(this.rb_produccion_CheckedChanged);
            // 
            // rb_pruebas
            // 
            this.rb_pruebas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_pruebas.Location = new System.Drawing.Point(12, 140);
            this.rb_pruebas.Name = "rb_pruebas";
            this.rb_pruebas.Size = new System.Drawing.Size(77, 38);
            this.rb_pruebas.TabIndex = 251;
            this.rb_pruebas.Text = "Pruebas";
            this.rb_pruebas.UseVisualStyleBackColor = true;
            this.rb_pruebas.Visible = false;
            this.rb_pruebas.CheckedChanged += new System.EventHandler(this.rb_pruebas_CheckedChanged);
            // 
            // cbo_bd_sociedad
            // 
            this.cbo_bd_sociedad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbo_bd_sociedad.Font = new System.Drawing.Font("Tahoma", 7.4F);
            this.cbo_bd_sociedad.FormattingEnabled = true;
            this.cbo_bd_sociedad.Items.AddRange(new object[] {
            "IMECON S.A.",
            "IMECON SELVA S.A.C."});
            this.cbo_bd_sociedad.Location = new System.Drawing.Point(294, 111);
            this.cbo_bd_sociedad.Name = "cbo_bd_sociedad";
            this.cbo_bd_sociedad.Size = new System.Drawing.Size(159, 20);
            this.cbo_bd_sociedad.TabIndex = 253;
            this.cbo_bd_sociedad.SelectedValueChanged += new System.EventHandler(this.cbo_bd_sociedad_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.4F);
            this.label2.Location = new System.Drawing.Point(177, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 12);
            this.label2.TabIndex = 254;
            this.label2.Text = "Seleccione la sociedad";
            // 
            // txt_ambiente
            // 
            this.txt_ambiente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ambiente.Font = new System.Drawing.Font("Arial", 7.4F);
            this.txt_ambiente.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_ambiente.Location = new System.Drawing.Point(12, 44);
            this.txt_ambiente.Multiline = true;
            this.txt_ambiente.Name = "txt_ambiente";
            this.txt_ambiente.Size = new System.Drawing.Size(154, 19);
            this.txt_ambiente.TabIndex = 255;
            this.txt_ambiente.Text = "Produccion";
            this.txt_ambiente.Visible = false;
            // 
            // txt_sociedad
            // 
            this.txt_sociedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sociedad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sociedad.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_sociedad.Location = new System.Drawing.Point(12, 94);
            this.txt_sociedad.Multiline = true;
            this.txt_sociedad.Name = "txt_sociedad";
            this.txt_sociedad.Size = new System.Drawing.Size(154, 19);
            this.txt_sociedad.TabIndex = 256;
            this.txt_sociedad.Text = "Produccion";
            this.txt_sociedad.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(476, 277);
            this.ControlBox = false;
            this.Controls.Add(this.txt_sociedad);
            this.Controls.Add(this.txt_ambiente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_bd_sociedad);
            this.Controls.Add(this.rb_pruebas);
            this.Controls.Add(this.rb_produccion);
            this.Controls.Add(this.txt_bd_externa);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_psw_usr);
            this.Controls.Add(this.txt_cdg_usr);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            this.titulo.ResumeLayout(false);
            this.titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_cdg_usr;
        private System.Windows.Forms.TextBox txt_psw_usr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip titulo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TextBox txt_bd_externa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rb_produccion;
        private System.Windows.Forms.RadioButton rb_pruebas;
        private System.Windows.Forms.ComboBox cbo_bd_sociedad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ambiente;
        private System.Windows.Forms.TextBox txt_sociedad;


        public System.Drawing.SizeF AutoScaleDimensions { get; set; }
    }
}