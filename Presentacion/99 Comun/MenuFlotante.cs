using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;
using System.Reflection;
using System.Drawing.Drawing2D;

namespace MISAP
{
    public partial class FrmMenuFlotante : Form
    {
        public string usuario;
        public string perfil;

        private Point pos = Point.Empty;
        private bool move = false;
        private TreeNode previousNode = null;
        private System.Reflection.Assembly Ensamblado;

        // Create a Font object for the node tags.
        Font tagFont = new Font("Helvetica", 8, FontStyle.Bold);

        public FrmMenuFlotante()
        {
            InitializeComponent();
        }

        private void FrmMenuFlotante_Load(object sender, EventArgs e)
        {

            this.Location = new Point(0, 0);

            l_usuario.Text = usuario;
            l_perfil_cod.Text = perfil;
          
            tv_menu.BackColor = Color.FromArgb(221, 221, 221);
            tp_modulos.BackColor = Color.FromArgb(252, 252, 252);
            cargar_tv_menu();
          
        }
        void cargar_tv_menu()
        {
            tv_menu.Nodes.Clear();
            TreeNode padre = null;
            TreeNode hijo = null;

           // DataTable dt_menu = AccesoLogica.listar_menu("P", 1);
            DataTable dtMenus = new DataTable();
            dtMenus = AccesoLogica.consultar_permisos_mnu(perfil);
            if (dtMenus != null)
            {
                 
         
            foreach (DataRow MenuPadre in dtMenus.Select("parent_id=0", "PosicionMenu ASC"))
            {

                padre = new TreeNode(MenuPadre.ItemArray[2].ToString());

                DataTable dt_menu_d = AccesoLogica.listar_menu_d("H", Convert.ToInt32(MenuPadre.ItemArray[0].ToString()), 1);

                foreach (DataRow dr_menu_d in dt_menu_d.Rows)
                {


                    hijo = new TreeNode(dr_menu_d.ItemArray[2].ToString());
                    padre.Nodes.Add(hijo);

                }
                tv_menu.Nodes.Add(padre);

                    
                }

                string ti;
                foreach (TreeNode node in tv_menu.Nodes)
                {

                    if (node.Parent == null)
                    {

                        node.NodeFont = new Font(tv_menu.Font, FontStyle.Bold); ;
                        node.ImageIndex = 0;
                        ti = node.Text;


                    }
                   
                }

               

            }
            else MessageBox.Show("No hay actividades para mostrar");

            
        }

        private void tv_menu_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            Color backColorSelected = Color.FromArgb(252, 185, 19);
            Color backColor = Color.FromArgb(221, 221, 221);

           e.Graphics.DrawRectangle(SystemPens.Control, e.Bounds);
           
            TextRenderer.DrawText(e.Graphics, e.Node.Text, e.Node.TreeView.Font, e.Node.Bounds, e.Node.ForeColor);

            e.DrawDefault = true;

        }

        private void tc_solicitud_DrawItem(object sender, DrawItemEventArgs e)
        {
            //this eventhandler is called only if:
            //DrawMode = OwnerDrawFixed

            //define how to handle which tabs
            var redTabIdxList = new List<int>() { 0, 1, 2, 3 };
            var orangeTabIdxList = new List<int>() { 4, 5, 6 };

            //customize the tabs
            if (redTabIdxList.Contains(e.Index))
            {
                var bshBack = new LinearGradientBrush(e.Bounds, Color.FromArgb(243, 243, 243), Color.FromArgb(243, 243, 243), LinearGradientMode.Horizontal);

                e.Graphics.FillRectangle(bshBack, e.Bounds);


            }

            //also draw the text
            var fntTab = e.Font;
            var bshFore = new SolidBrush(Color.Black);
            string tabName = this.tc_solicitud.TabPages[e.Index].Text;
            var sftTab = new StringFormat();

            sftTab.Alignment = StringAlignment.Center;
            sftTab.LineAlignment = StringAlignment.Center;


            var recTab = new Rectangle(e.Bounds.X, e.Bounds.Y + 4, e.Bounds.Width, e.Bounds.Height - 4);
            e.Graphics.DrawString(tabName, fntTab, bshFore, recTab, sftTab);


         
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void titulo_DoubleClick(object sender, EventArgs e)
        {
            if (lbl_maximi.Text == "1")
            {
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));

                lbl_maximi.Text = "0";
            }
            else
            {
                this.StartPosition = FormStartPosition.CenterScreen;
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
                this.SetBounds(this.Location.X, this.Location.Y, 919, 674);


                lbl_maximi.Text = "1";
            }
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            if (lbl_maximi.Text == "1")
            {
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));

                lbl_maximi.Text = "0";
            }
            else
            {
                this.StartPosition = FormStartPosition.CenterScreen;
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
                this.SetBounds(this.Location.X, this.Location.Y, 919, 674);


                lbl_maximi.Text = "1";
            }
        }

        private void titulo_MouseDown(object sender, MouseEventArgs e)
        {
            pos = new Point(e.X, e.Y);
            move = true;
        }

        private void titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.Location = new Point((this.Left + e.X - pos.X),
                    (this.Top + e.Y - pos.Y));
        }

        private void titulo_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void ninimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tv_menu_MouseHover(object sender, EventArgs e)
        {
            this.tv_menu.Cursor = Cursors.Arrow;
        }

        private void tv_menu_NodeMouseHover(object sender, System.Windows.Forms.TreeNodeMouseHoverEventArgs e)

        {
            if (previousNode != null)
            {
                previousNode.ForeColor = Color.Black;
                previousNode.BackColor = Color.FromArgb(221, 221, 221);
            }

            e.Node.ForeColor = Color.Black;
            e.Node.BackColor = Color.FromArgb(252, 185, 19);

            previousNode = e.Node;
        }

        private void tv_menu_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            try
            {
                string opcion = "";
                string formulario = "";

                if (tv_menu.SelectedNode.IsExpanded)
                {
                    tv_menu.SelectedNode.Collapse();

                }
                else
                {
                    //tv_menu.CollapseAll();
                    tv_menu.SelectedNode.Expand();
                   //  tv_menu.SelectedNode.PrevNode.Collapse();
                  //  tv_menu.SelectedNode.NextNode.Collapse();
                }


                opcion = tv_menu.SelectedNode.Text.ToString();
                formulario = Convert.ToString(AccesoLogica.consultar_m_prd_menu(opcion).Rows[0]["formulario"]);

                  Object ObjFrm;
                  Type tipo = Ensamblado.GetType(Ensamblado.GetName().Name + "." + formulario);

                if (tipo == null)
                {
                    MessageBox.Show("No se encontró el formulario", "Error de ubicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                        ObjFrm = Activator.CreateInstance(tipo);
                        Form formulario_ = (Form)ObjFrm;

                        //formulario_.usuario = l_usuario.Text;
                        //formulario_.perfil = l_perfil_cod.Text;
                        formulario_.Show();

                    
                }
              
            }
            catch { }
        }

      
        private void AddFormInPanel(Form fh)
        {
           
           // Form fh = new Form fh;

         
          } 
       
    }
}
