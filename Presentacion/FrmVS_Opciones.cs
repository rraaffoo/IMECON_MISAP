﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Negocio;
using System.Runtime.InteropServices;

namespace MISAP
{
    public partial class FrmVS_Opciones : Form
    {
        #region Variables Globales

        public string formulario, titulo, bd, sp, parametro_1, parametro_2, parametro_3, parametro_4;
        public int parametro_1_n, parametro_2_n;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        #region Variables locales


        private Point pos = Point.Empty;
        private bool move = false;


        Utilidades util = new Utilidades();
        DataTable dtable = new DataTable();
        AccesoLogica _negocio = new AccesoLogica();

        string ppcodigo, ppfecha, ppestado, ppcodProy, palmacen;
        string par1, par2, par3, par4, par6;

        string filtro;
        int columna;

        decimal total_sol, total_dolar;
        decimal total_sol_ = 0, total_dolar_ = 0;


        #endregion

        #region Eventos

        private void FrmOpciones_Load(object sender, EventArgs e)
        {
            lbl_titulo.Text = titulo;
            this.BackColor = Color.FromArgb(247, 247, 247);
            txt_buscar.BackColor = Color.FromArgb(254, 240, 158);


            #region Proyectos
            if (titulo == "Listado de Proyectos")
            {
                dgv_lista.DataSource = _negocio.VS_Listar_Proyectos("busqueda");
                btn_nuevo.Visible = false;
                formatear_grilla(dgv_lista);
                dgv_lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            #endregion

            #region Almacenes
            if (titulo == "Listado de Almacenes")
            {
                dgv_lista.DataSource = _negocio.VS_Listar_Parametro("almacenes", "busqueda");
                btn_nuevo.Visible = false;
                formatear_grilla(dgv_lista);
                dgv_lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            #endregion

            #region Ubicaciones
            if (titulo == "Listado de Ubicaciones")
            {
                dgv_lista.DataSource = _negocio.VS_Listar_Ubicaciones(ppcodigo);
                btn_nuevo.Visible = false;
                formatear_grilla(dgv_lista);
                dgv_lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            #endregion

            #region Cuentas
            if (titulo == "Listado de Cuentas")
            {
                dgv_lista.DataSource = _negocio.VS_Listar_Parametro("cuentas", "busqueda");
                btn_nuevo.Visible = false;
                formatear_grilla(dgv_lista);
                dgv_lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            #endregion

            #region Cuentas de Rendicion
            if (titulo == "Listado de Cuentas de Rendición")
            {
                dgv_lista.DataSource = _negocio.VS_Listar_Parametro("cuentas_rendicion", "busqueda");
                btn_nuevo.Visible = false;
                formatear_grilla(dgv_lista);
                dgv_lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            #endregion

            #region Usuarios
            if (titulo == "Listado de Usuarios")
            {
                dgv_lista.DataSource = _negocio.VS_Listar_Parametro("usuarios", "busqueda");
                btn_nuevo.Visible = false;
                formatear_grilla(dgv_lista);
                dgv_lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            #endregion

            #region Proyectos VS
            if (titulo == "Listado de Proyectos VS")
            {
                dgv_lista.DataSource = _negocio.VS_Listar_Parametro("proyectosVS", "busqueda");
                btn_nuevo.Visible = false;
                formatear_grilla(dgv_lista);
                dgv_lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            #endregion

            #region Roles
            if (titulo == "Listado de Roles")
            {
                dgv_lista.DataSource = _negocio.VS_Listar_Parametro("roles", "busqueda");
                btn_nuevo.Visible = false;
                formatear_grilla(dgv_lista);
                dgv_lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            #endregion

            #region Solicitud de dinero
            if (titulo == "Listado de SD")
            {
                dgv_lista.DataSource = _negocio.VS_Listar_Rendiciones(ppcodigo, ppfecha, ppestado, ppcodProy);
                btn_nuevo.Visible = false;
                formatear_grilla(dgv_lista);
                dgv_lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            #endregion

            #region Rendiciones
            if (titulo == "Listado de Rendiciones")
            {
                dgv_lista.DataSource = _negocio.VS_Listar_SD_AsigRendiciones(ppcodProy);
                btn_nuevo.Visible = false;
                formatear_grilla(dgv_lista);
                dgv_lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            #endregion

            //#region Empleados
            //if (titulo == "Listado de Empleados")
            //{
            //    dgv_lista.DataSource = _negocio.Listar_Empleados();
            //    btn_nuevo.Visible = false;
            //    formatear_grilla(dgv_lista);
            //    dgv_lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //}
            //#endregion

            #region Artículos
            if (titulo == "Listado de Articulos")
            {
                dgv_lista.DataSource = _negocio.VS_Listar_Parametro("articulos", "busqueda");
                btn_nuevo.Visible = false;
                formatear_grilla(dgv_lista);
                dgv_lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            #endregion

            #region Proveedores
            if (titulo == "Listado de Proveedores")
            {
                dgv_lista.DataSource = _negocio.VS_Listar_Parametro("proveedores", "busqueda");
                btn_nuevo.Visible = false;
                formatear_grilla(dgv_lista);
                dgv_lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            #endregion

            #region Impuestos
            if (titulo == "Listado de Impuestos")
            {
                dgv_lista.DataSource = _negocio.VS_Listar_Parametro("impuestos", "busqueda");
                btn_nuevo.Visible = false;
                formatear_grilla(dgv_lista);
                dgv_lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            #endregion

            #region Empleados
            if (titulo == "Listado de Empleados")
            {
                dgv_lista.DataSource = _negocio.VS_Listar_Parametro("empleados", "busqueda");
                btn_nuevo.Visible = false;
                formatear_grilla(dgv_lista);
                dgv_lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            #endregion


            if (dgv_lista.Rows.Count != 0)
            {
                // posicion = 0;
                txt_buscar.Enabled = true;
                filtro = dgv_lista.Columns[0].HeaderText;

                dgv_lista.CurrentCell = dgv_lista.Rows[0].Cells[0];
                columna = dgv_lista.CurrentCell.ColumnIndex;
            }

            dgv_lista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void dgv_lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (titulo == "Lista de materiales" || titulo == "Lista de servicios")
            {
                //txt_cantidad.Focus();
            }
        }

        private void dgv_lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (titulo == "Listado de Proyectos")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO PROYECTO"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESC. PROYECTO"].Value);
                par3 = Convert.ToString(dgv_lista.CurrentRow.Cells["NRO OT"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, "", "Listado de Proyectos", "");
                Close();
            }
            if (titulo == "Listado de Almacenes")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO ALMACEN"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESC. ALMACEN"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, "", "", "Listado de Almacenes", "");
                Close();
            }
            if (titulo == "Listado de Ubicaciones")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO UBICACION"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESC. UBICACION"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, "", "", "Listado de Ubicaciones", "");
                Close();
            }
            if (titulo == "Listado de Cuentas")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO CUENTA"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESC. CUENTA"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, "", "", "Listado de Cuentas", "");
                Close();
            }
            if (titulo == "Listado de Cuentas de Rendición")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO CUENTA"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESC. CUENTA"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, "", "", "Listado de Cuentas de Rendición", "");
                Close();
            }
            if (titulo == "Listado de Usuarios")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO USUARIO"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESC. USUARIO"].Value);
                par3 = Convert.ToString(dgv_lista.CurrentRow.Cells["EMAIL"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, "", "Listado de Usuarios", "");
                Close();
            }
            if (titulo == "Listado de Proyectos VS")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO PROYECTO"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESC. PROYECTO"].Value);
                par3 = Convert.ToString(dgv_lista.CurrentRow.Cells["NRO. OT"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, "", "Listado de Proyectos VS", "");
                Close();
            }
            if (titulo == "Listado de Roles")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO ROL"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESC. ROL"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, "", "", "Listado de Roles", "");
                Close();
            }
            if (titulo == "Listado de SD")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["FECHA"].Value);
                par3 = Convert.ToString(dgv_lista.CurrentRow.Cells["MONTO"].Value);
                par4 = Convert.ToString(dgv_lista.CurrentRow.Cells["MONEDA_COD"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, par4, "Listado de SD", "");
                Close();
            }
            if (titulo == "Listado de Rendiciones")
            {
                par1 = string.Concat(Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO"].Value), "|", Convert.ToString(dgv_lista.CurrentRow.Cells["NRO OT"].Value));
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["FECHA"].Value);
                par3 = string.Concat(Convert.ToString(dgv_lista.CurrentRow.Cells["ID EMPLEADO"].Value), "|", Convert.ToString(dgv_lista.CurrentRow.Cells["NOMBRE EMPLEADO"].Value));
                par4 = string.Concat(Convert.ToString(dgv_lista.CurrentRow.Cells["MONTO"].Value), "|", Convert.ToString(dgv_lista.CurrentRow.Cells["MONEDA"].Value));

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, par4, "Listado de Rendiciones", "");
                Close();
            }
            if (titulo == "Listado de Empleados")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["ID"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["NOMBRE"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, "", "", "Listado de Empleados", "");
                Close();
            }
            if (titulo == "Listado de Articulos")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESCRIPCION"].Value);
                par3 = Convert.ToString(dgv_lista.CurrentRow.Cells["UNIDADMEDIDA"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, "", "Listado de Articulos", "");
                Close();
            }
            if (titulo == "Listado de Proveedores")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESCRIPCION"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, "", "", "Listado de Proveedores", "");
                Close();
            }
            if (titulo == "Listado de Impuestos")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESCRIPCION"].Value);
                par3 = Convert.ToString(dgv_lista.CurrentRow.Cells["CANTIDAD"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, "", "Listado de Impuestos", "");
                Close();
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            (dgv_lista.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(" + "[" + filtro + "]" + " ,'System.String') LIKE '%{0}%'", txt_buscar.Text);
            formatear_grilla(dgv_lista);
        }



        #endregion

        #region Botones

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (titulo == "Listado de Proyectos")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO PROYECTO"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESC. PROYECTO"].Value);
                par3 = Convert.ToString(dgv_lista.CurrentRow.Cells["NRO OT"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, "", "Listado de Proyectos", "");
                Close();
            }
            if (titulo == "Listado de Almacenes")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO ALMACEN"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESC. ALMACEN"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, "", "", "Listado de Almacenes", "");
                Close();
            }
            if (titulo == "Listado de Ubicaciones")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO UBICACION"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESC. UBICACION"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, "", "", "Listado de Ubicaciones", "");
                Close();
            }
            if (titulo == "Listado de Cuentas")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO CUENTA"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESC. CUENTA"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, "", "", "Listado de Cuentas", "");
                Close();
            }
            if (titulo == "Listado de Cuentas de Rendición")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO CUENTA"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESC. CUENTA"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, "", "", "Listado de Cuentas de Rendición", "");
                Close();
            }
            if (titulo == "Listado de Usuarios")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO USUARIO"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESC. USUARIO"].Value);
                par3 = Convert.ToString(dgv_lista.CurrentRow.Cells["EMAIL"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, "", "Listado de Usuarios", "");
                Close();
            }
            if (titulo == "Listado de Proyectos VS")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO PROYECTO"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESC. PROYECTO"].Value);
                par3 = Convert.ToString(dgv_lista.CurrentRow.Cells["NRO. OT"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, "", "Listado de Proyectos VS", "");
                Close();
            }
            if (titulo == "Listado de Roles")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO ROL"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESC. ROL"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, "", "", "Listado de Roles", "");
                Close();
            }
            if (titulo == "Listado de SD")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["FECHA"].Value);
                par3 = Convert.ToString(dgv_lista.CurrentRow.Cells["MONTO"].Value);
                par4 = Convert.ToString(dgv_lista.CurrentRow.Cells["MONEDA_COD"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, par4, "Listado de SD", "");
                Close();
            }
            if (titulo == "Listado de Rendiciones")
            {
                par1 = string.Concat(Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO"].Value), "|", Convert.ToString(dgv_lista.CurrentRow.Cells["NRO OT"].Value));
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["FECHA"].Value);
                par3 = string.Concat(Convert.ToString(dgv_lista.CurrentRow.Cells["ID EMPLEADO"].Value), "|", Convert.ToString(dgv_lista.CurrentRow.Cells["NOMBRE EMPLEADO"].Value));
                par4 = string.Concat(Convert.ToString(dgv_lista.CurrentRow.Cells["MONTO"].Value), "|", Convert.ToString(dgv_lista.CurrentRow.Cells["MONEDA"].Value));

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, par4, "Listado de Rendiciones", "");
                Close();
            }
            if (titulo == "Listado de Empleados")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["ID"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["NOMBRE"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, "", "", "Listado de Empleados", "");
                Close();
            }
            if (titulo == "Listado de Articulos")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESCRIPCION"].Value);
                par3 = Convert.ToString(dgv_lista.CurrentRow.Cells["UNIDADMEDIDA"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, "", "Listado de Articulos", "");
                Close();
            }
            if (titulo == "Listado de Proveedores")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESCRIPCION"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, "", "", "Listado de Proveedores", "");
                Close();
            }
            if (titulo == "Listado de Impuestos")
            {
                par1 = Convert.ToString(dgv_lista.CurrentRow.Cells["CODIGO"].Value);
                par2 = Convert.ToString(dgv_lista.CurrentRow.Cells["DESCRIPCION"].Value);
                par3 = Convert.ToString(dgv_lista.CurrentRow.Cells["CANTIDAD"].Value);

                IForm_opciones formulario_opciones = this.Owner as IForm_opciones;

                if (formulario_opciones != null)
                    formulario_opciones.pasar_valores(par1, par2, par3, "", "Listado de Impuestos", "");
                Close();
            }   
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Funciones
        void formatear_grilla(DataGridView grilla)
        {

            try
            {
                util.FormatearGrilla(grilla, false);


                if (titulo == "Lista de proyectos" || titulo == "Lista de ordenes de trabajo" || titulo == "Lista de presupuestos")
                {
                    grilla.Columns["Codigo"].Width = 139;
                    grilla.Columns["Descripcion"].Width = 250;

                }

                if (titulo == "Lista de materiales" || titulo == "Lista de servicios" || titulo == "Lista de activos")
                {
                    grilla.Columns["Codigo"].Width = 146;
                    grilla.Columns["Descripcion"].Width = 243;

                    grilla.Columns["Umed"].Width = 40;


                }

                if (titulo == "Lista de mes de trabajo")
                {
                    grilla.Columns["Codigo"].Width = 146;
                    grilla.Columns["Descripcion"].Width = 243;
                    grilla.Columns["Codigo"].DefaultCellStyle.Format = "dd/MM/yyyy";

                }

                if (titulo == "Lista de Cuentas")
                {
                    grilla.Columns["Numero de cuenta"].Width = 146;
                    grilla.Columns["Nombre de la cuenta"].Width = 243;

                }

                if (titulo == "Lista de bancos")
                {
                    grilla.Columns["Codigo bancario"].Width = 146;
                    grilla.Columns["Nombre de Banco"].Width = 243;
                }

                if (titulo == "Lista de documentos")
                {
                    grilla.Columns["Total"].DefaultCellStyle.Format = "###,##0.00";
                    grilla.Columns["Total Dolares"].DefaultCellStyle.Format = "###,##0.00";
                    grilla.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    grilla.Columns["Total Dolares"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un problema inesperado, por favor capture la pantalla y envíela por correo electrónico a soporte_apps@imecon.com.pe o comuníquese al anexo 221. " + ex.Message, "Fabricación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }


        #endregion

        #region Formulario

        public FrmVS_Opciones()
        {
            InitializeComponent();
            formatear_grilla(dgv_lista);
        }

        public FrmVS_Opciones(string pcodigo, string pfecha, string pestado, string pcodProy)
        {
            InitializeComponent();
            formatear_grilla(dgv_lista);
            ppcodigo = pcodigo; 
            ppfecha = pfecha; 
            ppestado = pestado;
            ppcodProy = pcodProy;
        }


        private void ninimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizar_Click(object sender, EventArgs e)
        {

            this.WindowState = (this.WindowState == FormWindowState.Maximized ?

                FormWindowState.Normal
                : FormWindowState.Maximized);

            if (this.WindowState == FormWindowState.Maximized)
            {
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));

                //for (int i = 0; i < dgv_lista.Columns.Count - 1; i++)
                //{
                //    dgv_lista.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //}
                //dgv_lista.Columns[dgv_lista.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i < dgv_lista.Columns.Count; i++)
                {
                    int colw = dgv_lista.Columns[i].Width;
                    dgv_lista.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgv_lista.Columns[i].Width = colw;
                }

            }

            if (this.WindowState == FormWindowState.Normal)
            {

                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
            }


            //if (lbl_maximi.Text == "1")
            //{
            //    this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //    maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));

            //    lbl_maximi.Text = "0";
            //}
            //else
            //{
            //    this.StartPosition = FormStartPosition.CenterScreen;
            //    maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
            //    this.SetBounds(this.Location.X, this.Location.Y, 919, 674);


            //    lbl_maximi.Text = "1";
            //}
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void titulo_DoubleClick(object sender, EventArgs e)
        {

            this.WindowState = (this.WindowState == FormWindowState.Maximized ?

                FormWindowState.Normal
                : FormWindowState.Maximized);

            if (this.WindowState == FormWindowState.Maximized)
            {
                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Restore0));


            }

            if (this.WindowState == FormWindowState.Normal)
            {

                maximizar.Image = ((System.Drawing.Image)(Properties.Resources.Frame_Maximize0));
            }

        }

        private void titulo_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

            //pos = new Point(e.X, e.Y);
            //move = true;
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

        #endregion

        private void txt_buscar_Enter(object sender, EventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(254, 240, 158);
            if (!String.IsNullOrEmpty(txt_buscar.Text))
            {
                txt_buscar.SelectionStart = 0;
                txt_buscar.SelectionLength = txt_buscar.Text.Length;
            }
        }

        private void txt_buscar_Leave(object sender, EventArgs e)
        {
            txt_buscar.BackColor = Color.White;
        }

        private void txt_buscar_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_buscar.Text))
            {
                txt_buscar.SelectionStart = 0;
                txt_buscar.SelectionLength = txt_buscar.Text.Length;
            }
        }

        private void dgv_lista_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_buscar.BackColor = Color.FromArgb(255, 239, 161);
            txt_buscar.Focus();
            txt_buscar.Clear();

            filtro = dgv_lista.Columns[e.ColumnIndex].HeaderText;
            dgv_lista.Text = "Buscar en " + filtro;

            dgv_lista.CurrentCell = dgv_lista.Rows[0].Cells[e.ColumnIndex];
        }
    }
}

