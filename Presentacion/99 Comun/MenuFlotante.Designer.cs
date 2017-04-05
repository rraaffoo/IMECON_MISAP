namespace MISAP
{
    partial class FrmMenuFlotante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuFlotante));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Importar transmital");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Planificacion de la produccion", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Control de la produccion");
            this.titulo = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.maximizar = new System.Windows.Forms.ToolStripButton();
            this.ninimizar = new System.Windows.Forms.ToolStripButton();
            this.tc_solicitud = new System.Windows.Forms.TabControl();
            this.tp_modulos = new System.Windows.Forms.TabPage();
            this.tv_menu = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_maximi = new System.Windows.Forms.Label();
            this.lbl_bd = new System.Windows.Forms.Label();
            this.l_perfil_cod = new System.Windows.Forms.Label();
            this.l_usuario = new System.Windows.Forms.Label();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.titulo.SuspendLayout();
            this.tc_solicitud.SuspendLayout();
            this.tp_modulos.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStripLabel1,
            this.salir,
            this.maximizar,
            this.ninimizar});
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.titulo.Size = new System.Drawing.Size(309, 31);
            this.titulo.TabIndex = 244;
            this.titulo.Text = "Menú principal";
            this.titulo.DoubleClick += new System.EventHandler(this.titulo_DoubleClick);
            this.titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            this.titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseMove);
            this.titulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseUp);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(87, 28);
            this.toolStripLabel1.Text = "Menú principal";
            // 
            // salir
            // 
            this.salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(23, 28);
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
            this.maximizar.Size = new System.Drawing.Size(23, 28);
            this.maximizar.Text = "Miminimizar tamaño";
            this.maximizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // ninimizar
            // 
            this.ninimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ninimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ninimizar.Image = ((System.Drawing.Image)(resources.GetObject("ninimizar.Image")));
            this.ninimizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ninimizar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.ninimizar.Margin = new System.Windows.Forms.Padding(0);
            this.ninimizar.Name = "ninimizar";
            this.ninimizar.Size = new System.Drawing.Size(23, 31);
            this.ninimizar.Text = "Minimizar";
            this.ninimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ninimizar.Click += new System.EventHandler(this.ninimizar_Click);
            // 
            // tc_solicitud
            // 
            this.tc_solicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_solicitud.Controls.Add(this.tp_modulos);
            this.tc_solicitud.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tc_solicitud.Font = new System.Drawing.Font("Arial", 8.25F);
            this.tc_solicitud.ItemSize = new System.Drawing.Size(96, 22);
            this.tc_solicitud.Location = new System.Drawing.Point(12, 85);
            this.tc_solicitud.Multiline = true;
            this.tc_solicitud.Name = "tc_solicitud";
            this.tc_solicitud.SelectedIndex = 0;
            this.tc_solicitud.Size = new System.Drawing.Size(276, 374);
            this.tc_solicitud.TabIndex = 245;
            this.tc_solicitud.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tc_solicitud_DrawItem);
            // 
            // tp_modulos
            // 
            this.tp_modulos.BackColor = System.Drawing.Color.Transparent;
            this.tp_modulos.Controls.Add(this.tv_menu);
            this.tp_modulos.Location = new System.Drawing.Point(4, 26);
            this.tp_modulos.Name = "tp_modulos";
            this.tp_modulos.Size = new System.Drawing.Size(268, 344);
            this.tp_modulos.TabIndex = 2;
            this.tp_modulos.Text = "Modulos";
            // 
            // tv_menu
            // 
            this.tv_menu.BackColor = System.Drawing.Color.Gainsboro;
            this.tv_menu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tv_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_menu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_menu.ForeColor = System.Drawing.Color.Black;
            this.tv_menu.FullRowSelect = true;
            this.tv_menu.HideSelection = false;
            this.tv_menu.ImageIndex = 0;
            this.tv_menu.ImageList = this.imageList1;
            this.tv_menu.ItemHeight = 25;
            this.tv_menu.LineColor = System.Drawing.Color.White;
            this.tv_menu.Location = new System.Drawing.Point(0, 0);
            this.tv_menu.Name = "tv_menu";
            treeNode1.Name = "Node2";
            treeNode1.NodeFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode1.Text = "Importar transmital";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Planificacion de la produccion";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Control de la produccion";
            this.tv_menu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            this.tv_menu.SelectedImageIndex = 0;
            this.tv_menu.ShowLines = false;
            this.tv_menu.ShowPlusMinus = false;
            this.tv_menu.ShowRootLines = false;
            this.tv_menu.Size = new System.Drawing.Size(268, 344);
            this.tv_menu.TabIndex = 106;
            this.tv_menu.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.tv_menu_DrawNode);
            this.tv_menu.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.tv_menu_NodeMouseHover);
            this.tv_menu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_menu_AfterSelect_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "LevelClosed.png");
            this.imageList1.Images.SetKeyName(1, "LastLevel.png");
            this.imageList1.Images.SetKeyName(2, "LevelOpen.png");
            // 
            // lbl_maximi
            // 
            this.lbl_maximi.AutoSize = true;
            this.lbl_maximi.Location = new System.Drawing.Point(274, 45);
            this.lbl_maximi.Name = "lbl_maximi";
            this.lbl_maximi.Size = new System.Drawing.Size(13, 14);
            this.lbl_maximi.TabIndex = 246;
            this.lbl_maximi.Text = "1";
            this.lbl_maximi.Visible = false;
            // 
            // lbl_bd
            // 
            this.lbl_bd.AutoSize = true;
            this.lbl_bd.Location = new System.Drawing.Point(13, 38);
            this.lbl_bd.Name = "lbl_bd";
            this.lbl_bd.Size = new System.Drawing.Size(38, 14);
            this.lbl_bd.TabIndex = 247;
            this.lbl_bd.Text = "MISAP";
            // 
            // l_perfil_cod
            // 
            this.l_perfil_cod.AutoSize = true;
            this.l_perfil_cod.Location = new System.Drawing.Point(105, 57);
            this.l_perfil_cod.Name = "l_perfil_cod";
            this.l_perfil_cod.Size = new System.Drawing.Size(31, 14);
            this.l_perfil_cod.TabIndex = 248;
            this.l_perfil_cod.Text = "perfil";
            this.l_perfil_cod.Visible = false;
            // 
            // l_usuario
            // 
            this.l_usuario.AutoSize = true;
            this.l_usuario.Location = new System.Drawing.Point(13, 57);
            this.l_usuario.Name = "l_usuario";
            this.l_usuario.Size = new System.Drawing.Size(44, 14);
            this.l_usuario.TabIndex = 249;
            this.l_usuario.Text = "Usuario";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem2.Text = "2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem3.Text = "2";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem4.Text = "2";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem5.Text = "2";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.AutoSize = false;
            this.toolStripMenuItem6.CheckOnClick = true;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.RightToLeftAutoMirrorImage = true;
            this.toolStripMenuItem6.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem6.Text = "2";
            // 
            // FrmMenuFlotante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 485);
            this.ControlBox = false;
            this.Controls.Add(this.l_usuario);
            this.Controls.Add(this.l_perfil_cod);
            this.Controls.Add(this.lbl_bd);
            this.Controls.Add(this.lbl_maximi);
            this.Controls.Add(this.tc_solicitud);
            this.Controls.Add(this.titulo);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmMenuFlotante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmMenuFlotante_Load);
            this.titulo.ResumeLayout(false);
            this.titulo.PerformLayout();
            this.tc_solicitud.ResumeLayout(false);
            this.tp_modulos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip titulo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton salir;
        private System.Windows.Forms.ToolStripButton maximizar;
        private System.Windows.Forms.ToolStripButton ninimizar;
        private System.Windows.Forms.TabControl tc_solicitud;
        private System.Windows.Forms.TabPage tp_modulos;
        private System.Windows.Forms.TreeView tv_menu;
        private System.Windows.Forms.Label lbl_maximi;
        private System.Windows.Forms.Label lbl_bd;
        private System.Windows.Forms.Label l_perfil_cod;
        private System.Windows.Forms.Label l_usuario;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
    }
}