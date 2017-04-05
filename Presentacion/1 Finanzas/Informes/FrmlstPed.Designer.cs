namespace MISAP
{
    partial class FrmlstPed
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
            this.SuspendLayout();
            // 
            // FrmlstPed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 426);
            this.Name = "FrmlstPed";
            this.Text = "FrmlstPed";
            this.Load += new System.EventHandler(this.FrmlstPed_Load);
            this.ResumeLayout(false);

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmlstPed));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_costos = new System.Windows.Forms.DataGridView();
            this.tc_pedido = new System.Windows.Forms.TabControl();
            this.tp_listado = new System.Windows.Forms.TabPage();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.tp_nuevo = new System.Windows.Forms.TabPage();
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
            this.ts_acciones = new System.Windows.Forms.ToolStrip();
            this.btn_exportar_xls = new System.Windows.Forms.ToolStripButton();
            this.btn_actualizar = new System.Windows.Forms.ToolStripButton();
            this.btn_filtro = new System.Windows.Forms.ToolStripButton();
            this.btn_parametrizacion = new System.Windows.Forms.ToolStripButton();
            this.btn_ayuda = new System.Windows.Forms.ToolStripButton();
            this.titulo = new System.Windows.Forms.ToolStrip();
            this.tsl_titulo = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.maximizar = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_costos)).BeginInit();
            this.tc_pedido.SuspendLayout();
            this.tp_listado.SuspendLayout();
            this.tp_auditoria.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ts_acciones.SuspendLayout();
            this.titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_costos
            // 
            this.dgv_costos.AllowUserToAddRows = false;
            this.dgv_costos.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dgv_costos, "dgv_costos");
            this.dgv_costos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_costos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_costos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_costos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_costos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 8.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_costos.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_costos.EnableHeadersVisualStyles = false;
            this.dgv_costos.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_costos.Name = "dgv_costos";
            this.dgv_costos.ReadOnly = true;
            this.dgv_costos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_costos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_costos_CellContentClick);
            // 
            // tc_pedido
            // 
            resources.ApplyResources(this.tc_pedido, "tc_pedido");
            this.tc_pedido.Controls.Add(this.tp_listado);
            this.tc_pedido.Controls.Add(this.tp_nuevo);
            this.tc_pedido.Controls.Add(this.tp_auditoria);
            this.tc_pedido.Name = "tc_pedido";
            this.tc_pedido.SelectedIndex = 0;
            // 
            // tp_listado
            // 
            this.tp_listado.Controls.Add(this.txttipo);
            this.tp_listado.Controls.Add(this.lbl_buscar);
            this.tp_listado.Controls.Add(this.txt_buscar);
            this.tp_listado.Controls.Add(this.dgv_costos);
            resources.ApplyResources(this.tp_listado, "tp_listado");
            this.tp_listado.Name = "tp_listado";
            // 
            // txttipo
            // 
            resources.ApplyResources(this.txttipo, "txttipo");
            this.txttipo.Name = "txttipo";
            // 
            // lbl_buscar
            // 
            resources.ApplyResources(this.lbl_buscar, "lbl_buscar");
            this.lbl_buscar.Name = "lbl_buscar";
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txt_buscar, "txt_buscar");
            this.txt_buscar.ForeColor = System.Drawing.Color.Black;
            this.txt_buscar.Name = "txt_buscar";
            // 
            // tp_nuevo
            // 
            resources.ApplyResources(this.tp_nuevo, "tp_nuevo");
            this.tp_nuevo.Name = "tp_nuevo";
            // 
            // tp_auditoria
            // 
            this.tp_auditoria.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tp_auditoria, "tp_auditoria");
            this.tp_auditoria.Name = "tp_auditoria";
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
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // txt_tipodoc
            // 
            resources.ApplyResources(this.txt_tipodoc, "txt_tipodoc");
            this.txt_tipodoc.Name = "txt_tipodoc";
            this.txt_tipodoc.ReadOnly = true;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // txt_formulario
            // 
            resources.ApplyResources(this.txt_formulario, "txt_formulario");
            this.txt_formulario.Name = "txt_formulario";
            this.txt_formulario.ReadOnly = true;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // txt_fec_modi
            // 
            resources.ApplyResources(this.txt_fec_modi, "txt_fec_modi");
            this.txt_fec_modi.Name = "txt_fec_modi";
            this.txt_fec_modi.ReadOnly = true;
            // 
            // txt_terminal_modi
            // 
            resources.ApplyResources(this.txt_terminal_modi, "txt_terminal_modi");
            this.txt_terminal_modi.Name = "txt_terminal_modi";
            this.txt_terminal_modi.ReadOnly = true;
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // txt_usr_modi
            // 
            resources.ApplyResources(this.txt_usr_modi, "txt_usr_modi");
            this.txt_usr_modi.Name = "txt_usr_modi";
            this.txt_usr_modi.ReadOnly = true;
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.Name = "label34";
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.Name = "label35";
            // 
            // txt_estado_registro
            // 
            resources.ApplyResources(this.txt_estado_registro, "txt_estado_registro");
            this.txt_estado_registro.Name = "txt_estado_registro";
            this.txt_estado_registro.ReadOnly = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txt_operacion
            // 
            resources.ApplyResources(this.txt_operacion, "txt_operacion");
            this.txt_operacion.Name = "txt_operacion";
            this.txt_operacion.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txt_fec_crea
            // 
            resources.ApplyResources(this.txt_fec_crea, "txt_fec_crea");
            this.txt_fec_crea.Name = "txt_fec_crea";
            this.txt_fec_crea.ReadOnly = true;
            // 
            // txt_terminal_crea
            // 
            resources.ApplyResources(this.txt_terminal_crea, "txt_terminal_crea");
            this.txt_terminal_crea.Name = "txt_terminal_crea";
            this.txt_terminal_crea.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txt_usr_crea
            // 
            resources.ApplyResources(this.txt_usr_crea, "txt_usr_crea");
            this.txt_usr_crea.Name = "txt_usr_crea";
            this.txt_usr_crea.ReadOnly = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // ts_acciones
            // 
            this.ts_acciones.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ts_acciones, "ts_acciones");
            this.ts_acciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_acciones.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.ts_acciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_exportar_xls,
            this.btn_actualizar,
            this.btn_filtro,
            this.btn_parametrizacion,
            this.btn_ayuda});
            this.ts_acciones.Name = "ts_acciones";
            this.ts_acciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // btn_exportar_xls
            // 
            resources.ApplyResources(this.btn_exportar_xls, "btn_exportar_xls");
            this.btn_exportar_xls.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_exportar_xls.Image = global::MISAP.Properties.Resources.FILEexcel;
            this.btn_exportar_xls.Name = "btn_exportar_xls";
            this.btn_exportar_xls.Click += new System.EventHandler(this.btn_exportar_xls_Click);
            // 
            // btn_actualizar
            // 
            resources.ApplyResources(this.btn_actualizar, "btn_actualizar");
            this.btn_actualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_actualizar.Image = global::MISAP.Properties.Resources.DATAthis;
            this.btn_actualizar.Name = "btn_actualizar";
            // 
            // btn_filtro
            // 
            resources.ApplyResources(this.btn_filtro, "btn_filtro");
            this.btn_filtro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_filtro.Image = global::MISAP.Properties.Resources.DATAfilter;
            this.btn_filtro.Name = "btn_filtro";
            // 
            // btn_parametrizacion
            // 
            resources.ApplyResources(this.btn_parametrizacion, "btn_parametrizacion");
            this.btn_parametrizacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_parametrizacion.Image = global::MISAP.Properties.Resources.TOOLSforms;
            this.btn_parametrizacion.Name = "btn_parametrizacion";
            // 
            // btn_ayuda
            // 
            resources.ApplyResources(this.btn_ayuda, "btn_ayuda");
            this.btn_ayuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ayuda.Image = global::MISAP.Properties.Resources.help;
            this.btn_ayuda.Name = "btn_ayuda";
            // 
            // titulo
            // 
            resources.ApplyResources(this.titulo, "titulo");
            this.titulo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.titulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_titulo,
            this.salir,
            this.maximizar,
            this.ninimizar});
            this.titulo.Name = "titulo";
            this.titulo.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // tsl_titulo
            // 
            resources.ApplyResources(this.tsl_titulo, "tsl_titulo");
            this.tsl_titulo.Name = "tsl_titulo";
            // 
            // salir
            // 
            this.salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.salir, "salir");
            this.salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salir.Margin = new System.Windows.Forms.Padding(0);
            this.salir.Name = "salir";
            // 
            // maximizar
            // 
            this.maximizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.maximizar, "maximizar");
            this.maximizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.maximizar.Margin = new System.Windows.Forms.Padding(0);
            this.maximizar.Name = "maximizar";
            // 
            // ninimizar
            // 
            this.ninimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.ninimizar, "ninimizar");
            this.ninimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ninimizar.Margin = new System.Windows.Forms.Padding(0);
            this.ninimizar.Name = "ninimizar";
            // 
            // FrmlstPed
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ts_acciones);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.tc_pedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmlstPed";
            this.Load += new System.EventHandler(this.FrmlstPed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_costos)).EndInit();
            this.tc_pedido.ResumeLayout(false);
            this.tp_listado.ResumeLayout(false);
            this.tp_listado.PerformLayout();
            this.tp_auditoria.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ts_acciones.ResumeLayout(false);
            this.ts_acciones.PerformLayout();
            this.titulo.ResumeLayout(false);
            this.titulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();




        }

        #endregion


        private System.Windows.Forms.DataGridView dgv_costos;
        private System.Windows.Forms.TabControl tc_pedido;
        private System.Windows.Forms.TabPage tp_listado;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.TabPage tp_nuevo;
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
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.ToolStrip ts_acciones;
        private System.Windows.Forms.ToolStripButton btn_exportar_xls;
        private System.Windows.Forms.ToolStripButton btn_actualizar;
        private System.Windows.Forms.ToolStripButton btn_filtro;
        private System.Windows.Forms.ToolStripButton btn_parametrizacion;
        private System.Windows.Forms.ToolStripButton btn_ayuda;
        private System.Windows.Forms.ToolStrip titulo;
        private System.Windows.Forms.ToolStripLabel tsl_titulo;
        private System.Windows.Forms.ToolStripButton salir;
        private System.Windows.Forms.ToolStripButton maximizar;
        private System.Windows.Forms.ToolStripButton ninimizar;
    }
}