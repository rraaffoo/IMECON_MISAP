using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Datos
{
    public class AccesoDatos
    {

        #region CONSULTAR S10

        public static DataTable listar_presupuestos()
        {
            SqlCommand _comando = MetodosDatos.CrearComando_s10();
            _comando.CommandText = "SELECT CodPresupuesto as Codigo, Descripcion as Descripcion FROM Presupuesto";
            return MetodosDatos.EjecutarComandoSelect_s10(_comando);
        }

        public static DataTable consultar_posiciones(string CodPresupuesto)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_s10("sp_consultar_posiciones");
            _comando.Parameters.AddWithValue("@CodPresupuesto", CodPresupuesto);
            return MetodosDatos.EjecutarComandoSelect_s10(_comando);
        }



        #endregion 

        #region Consultar MISAP

        public static DataTable consultar_cuentas()
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_cuenta_contable");
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_bancos()
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_bancos");
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_columnas_eb(string tipo, string CodigoBanco, string TipoColumna)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_columnas_eb");
            _comando.Parameters.AddWithValue("@tipo", tipo);
            _comando.Parameters.AddWithValue("@CodigoBanco", CodigoBanco);
            _comando.Parameters.AddWithValue("@TipoColumna", TipoColumna);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_d_prd_marca(string num_ord, string swt_estado, string swt_estado_2, string nro_op)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_d_prd_marca");
            _comando.Parameters.AddWithValue("@num_ord_", num_ord);
            _comando.Parameters.AddWithValue("@swt_estado_", swt_estado);
            _comando.Parameters.AddWithValue("@swt_estado_2_", swt_estado_2);
            _comando.Parameters.AddWithValue("@nro_op_", nro_op);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_item_anulacion(int item, int cant)
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "SELECT d.linea, d.item, c.marca, c.descripcion, d.swt_estado FROM d_prd_marca d INNER JOIN m_prd_marca c ON (d.item = c.item) WHERE d.item = " + "'" + item + "'" + " AND d.estado_registro = 'A' AND d.linea > " + " " + cant;
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable obtener_codigo_costo()
        {

            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "SELECT '' AS codigo_costo, 'Todos' as descripcion UNION select codigo_costo, RTRIM(descripcion) FROM m_prd_codigo_costo";
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable obtener_clave(string cdg_usr)
        {

            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "select psw_usr from OUSR where cdg_usr = " + "'" + cdg_usr + "'";
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }


        public static DataTable obtener_perfil()
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "select rtrim(cdg_perf) as cdg_perf, rtrim(des_perf) as des_perf from OPER";
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable obtener_perfil_mcop()
        {
            SqlCommand _comando = MetodosDatos.CrearComando_mcop();
            _comando.CommandText = "select rtrim(cdg_perf) as cdg_perf, rtrim(des_perf) as des_perf from m_perfil";
            return MetodosDatos.EjecutarComandoSelect_mcop(_comando);
        }

        public static DataTable obtener_usuario(string cdg_usr)
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "SELECT RTRIM(u.cdg_usr) AS cdg_usr, RTRIM(u.psw_usr) AS psw_usr, RTRIM(p.cdg_perf) AS cdg_perf , RTRIM(p.des_perf) AS des_MOF, dni FROM OUSR u inner join OPER p ON p.cdg_perf = u.cdg_perf WHERE u.swt_usr = '1' and u.cdg_usr = " + "'" + cdg_usr + "'";
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable obtener_usuario_is(string cdg_usr)
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "SELECT RTRIM(u.cdg_usr) AS cdg_usr, RTRIM(u.psw_usr) AS psw_usr, RTRIM(p.cdg_perf) AS cdg_perf , RTRIM(p.des_perf) AS des_MOF, dni FROM MISAP_IS.dbo.OUSR u inner join MISAP_IS.dbo.OPER p ON p.cdg_perf = u.cdg_perf WHERE u.swt_usr = '1' and u.cdg_usr = " + "'" + cdg_usr + "'";
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable obtener_usuario_SAP(string cdg_usr)
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sap();
            _comando.CommandText = "SELECT empid as U_CL_CODSOL, lastName + ' ' + firstName as U_CL_SOLICI FROM OHEM where U_CDG_USER = " + "'" + cdg_usr + "'";
            return MetodosDatos.EjecutarComandoSelect_sap(_comando);
        }

      
        public static DataTable listar_usuario(int swt_usr, int swt_usr_2, string operacion, string tipo)
        {

            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_OUSR");
            _comando.Parameters.AddWithValue("@swt_usr", swt_usr);
            _comando.Parameters.AddWithValue("@swt_usr_2", swt_usr_2);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }


        public static DataTable listar_extractos(string cuenta, int id, int StatemNo)
        {

            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_extractos");
            _comando.Parameters.AddWithValue("@cuenta", cuenta);
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@StatemNo", StatemNo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_solicitudes_alta(string estado, string tipo, int id_solicitud)
        {

            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_solicitudes_alta");
            _comando.Parameters.AddWithValue("@estado", estado);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            _comando.Parameters.AddWithValue("@id_solicitud", id_solicitud);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_codigo_costo(string swt_estado, string swt_estado_2)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_prd_listar_codigo_costo");
            _comando.Parameters.AddWithValue("@swt_estado", swt_estado);
            _comando.Parameters.AddWithValue("@swt_estado_2", swt_estado_2);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable obtener_id_session(string cdg_usr)
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "select top(1) id_session from OLOG WHERE cdg_usr = " + "'" + cdg_usr + "'" + " order by id_session desc ";
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_menu(string swt_tipo, int swt_estado)
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "select menu_id, parent_id, name from OMNU where SWT_TIPO = " + "'" + swt_tipo + "'" + " AND SWT_ESTADO = " + swt_estado;

            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_m_prd_menu(string name)
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "select formulario from OMNU where name = " + "'" + name + "'";
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_menu_d(string swt_tipo, int parent_id, int swt_estado)
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "select menu_id, parent_id, name from OMNU where SWT_TIPO = " + "'" + swt_tipo + "'" + " AND SWT_ESTADO = " + swt_estado + " AND parent_id = " + parent_id;
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_documentos()
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "SELECT cod_tipodoc, nom_tipodoc, formulario FROM  ODOC";
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_tipo_plantilla()
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "select cdg_tipo_plantilla, tipo_plantilla from tipo_plantilla  ";
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_maestro_plantilla()
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "SELECT (ROW_NUMBER() OVER (ORDER BY p.carpeta ASC)) AS #, p.prioridad, p.id_plantilla, p.plantilla, p.carpeta, p.cdg_tipo_planilla, p.stored_procedure, p.base_datos, p.aplicacion, p.tipo_bd, p.id_estado, e.estado FROM plantilla AS p INNER JOIN estado AS e ON p.id_estado = e.id_estado  " +
                " WHERE p.estado_registro = 'A' AND p.id_estado <> '8' ORDER by p.prioridad DESC";
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }


        public static DataTable listar_proceso(string cdg_tipo_planilla)
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "select DISTINCT carpeta from plantilla where cdg_tipo_planilla = " + "'" + cdg_tipo_planilla + "'";
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_plantilla(string proceso)
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "select id_plantilla, plantilla from plantilla where id_estado <> 8 and estado_registro = 'A' AND  carpeta = " + "'" + proceso + "'";
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_plantilla(int id_plantilla)
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "select stored_procedure, stored_procedure_d, base_datos, aplicacion, tipo_bd  from plantilla where id_plantilla = " + "'" + id_plantilla + "'";
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable ejecutar_sp_SAP(string sp)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql(sp);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_detalle_ped_misap(string tipo_pedido, string num_ped, string cdg_origen)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_detalle_pedido");
            _comando.Parameters.AddWithValue("@tipo_pedido", tipo_pedido);
            _comando.Parameters.AddWithValue("@num_ped", num_ped);
            _comando.Parameters.AddWithValue("@cod_origen", cdg_origen);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_facturas_provision(string tipo, string proveedor)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_facturas_provision");
            _comando.Parameters.AddWithValue("@tipo", tipo);
            _comando.Parameters.AddWithValue("@proveedor", proveedor);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }


        public static DataTable listar_cheques(string tipo, string proveedor)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_cheques");
            _comando.Parameters.AddWithValue("@tipo", tipo);
            _comando.Parameters.AddWithValue("@proveedor", proveedor);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_pedidos_provision(string tipo, int  nro_factura)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_pedido_provision");
            _comando.Parameters.AddWithValue("@tipo", tipo);
            _comando.Parameters.AddWithValue("@nro_factura", nro_factura);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }


        public static DataTable listar_documentos_cheque(string tipo, int nro_cheque, int nro_pago)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_documentos_cheque");
            _comando.Parameters.AddWithValue("@tipo", tipo);
            _comando.Parameters.AddWithValue("@nro_cheque", nro_cheque);  
            _comando.Parameters.AddWithValue("@nro_pago", nro_pago);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }


        public static DataTable consultar_log(string nro_doc)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_OAUD");
            _comando.Parameters.AddWithValue("@nro_doc", nro_doc);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_FRM1(string formulario, string grilla, string usuario, int GrillaId)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_FRM1");
            _comando.Parameters.AddWithValue("@formulario", formulario);
            _comando.Parameters.AddWithValue("@grilla", grilla);
            _comando.Parameters.AddWithValue("@usuario", usuario);
            _comando.Parameters.AddWithValue("@grilla_id", GrillaId);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_pedidos_misap(string est, string Anio, string usr,string perfil)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("spLisPedMat2_");
            _comando.Parameters.AddWithValue("@est", est);
            _comando.Parameters.AddWithValue("@Anio", Anio);
            _comando.Parameters.AddWithValue("@usr", usr);
            _comando.Parameters.AddWithValue("@perfil", perfil);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_anexo()
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_anexos");
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_equivalencia()
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_ot");
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_requemiento_seguimiento(string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_requemiento_seguimiento");
            _comando.Parameters.AddWithValue("@tipo", tipo);
             return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable informe_seguimiento_aceros(string tipo, string ot)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_imforme_seguimiento_aceros");
            _comando.Parameters.AddWithValue("@tipo", tipo);
            _comando.Parameters.AddWithValue("@ot", ot);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable informe_seguimiento_contratos(int idreg, string operacion, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_OCTR");
            _comando.Parameters.AddWithValue("@idreg", idreg);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@tipo", tipo);
           
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable informe_inventario_IPs(int idreg, string operacion, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_OIIP");
            _comando.Parameters.AddWithValue("@idreg", idreg);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@tipo", tipo);
           
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        

        public static DataTable informe_seguimiento_cambios_apl(int idreg, string operacion, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_OBAP");
            _comando.Parameters.AddWithValue("@idreg", idreg);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@tipo", tipo);

            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_CTR1(int idreg, string operacion, string tipo, string PrcCode)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_CTR1");
            _comando.Parameters.AddWithValue("@idreg", idreg);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            _comando.Parameters.AddWithValue("@PrcCode", PrcCode);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable informe_seguimiento_aceros_det(string tipo, string ot)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_imforme_seguimiento_aceros_det");
            _comando.Parameters.AddWithValue("@tipo", tipo);
            _comando.Parameters.AddWithValue("@ot", ot);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }


        public static DataTable listar_saldo_seguimiento(string ot)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("paSaldosSegui");
            _comando.Parameters.AddWithValue("@_ot", ot);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_costos(string mat, string ot, string dDesde, string dHasta, string tip)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sap("VS_SP_CostosMatSer");
            _comando.Parameters.AddWithValue("@mat", mat);
            _comando.Parameters.AddWithValue("@ot", ot);
            _comando.Parameters.AddWithValue("@dDesde", dDesde);
            _comando.Parameters.AddWithValue("@dHasta", dHasta);
            _comando.Parameters.AddWithValue("@tip", tip);
            return MetodosDatos.EjecutarComandoSelect_sap(_comando);
        }

        public static DataTable listar_proveedores_provision(string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_proveedores_provision");
            _comando.Parameters.AddWithValue("@tipo", tipo);
           return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_proveedores_cheque(string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_proveedores_cheque");
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_pca_d(int pca, int linea, string id_usuario_g, int id_servicio, string contraseña, string swt_estado, string operacion, string usr_crea, string fec_crea,
                                                string terminal_crea, string operacion_mod, string usr_mod, string fec_mod, string terminal_mod, string formulario, string estado_registro)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_mantenimiento_d_pca");
            _comando.Parameters.AddWithValue("@id_pca", pca);
            _comando.Parameters.AddWithValue("@linea", linea);
            _comando.Parameters.AddWithValue("@id_usuario", id_usuario_g);
            _comando.Parameters.AddWithValue("@id_servicio", id_servicio);
            _comando.Parameters.AddWithValue("@contraseña", contraseña);

            //_comando.Parameters.AddWithValue("@fecha", fecha);

            _comando.Parameters.AddWithValue("@swt_estado", swt_estado);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@usr_crea", usr_crea);
            _comando.Parameters.AddWithValue("@fec_crea", fec_crea);
            _comando.Parameters.AddWithValue("@terminal_crea", terminal_crea);
            _comando.Parameters.AddWithValue("@operacion_mod", operacion_mod);
            _comando.Parameters.AddWithValue("@usr_mod", usr_mod);
            _comando.Parameters.AddWithValue("@fec_mod", fec_mod);
            _comando.Parameters.AddWithValue("@terminal_mod", terminal_mod);
            _comando.Parameters.AddWithValue("@formulario", formulario);
            _comando.Parameters.AddWithValue("@estado_registro", estado_registro);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_pca(int pca, string dni, string apellidos, string nombres, int id_area, int id_perfil, string id_usuario, int id_movimiento, string fecha, string autorizado, string swt_estado, string operacion, string usr_crea, string fec_crea,
                                                 string terminal_crea, string operacion_mod, string usr_mod, string fec_mod, string terminal_mod, string formulario, string estado_registro)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_mantenimiento_c_pca");
            _comando.Parameters.AddWithValue("@pca", pca);
            _comando.Parameters.AddWithValue("@dni", dni);
            _comando.Parameters.AddWithValue("@apellidos", apellidos);
            _comando.Parameters.AddWithValue("@nombres", nombres);
            _comando.Parameters.AddWithValue("@id_area", id_area);
            _comando.Parameters.AddWithValue("@id_perfil", id_perfil);
            _comando.Parameters.AddWithValue("@id_usuario", id_usuario);
            _comando.Parameters.AddWithValue("@id_movimiento", id_movimiento);
            _comando.Parameters.AddWithValue("@fecha", fecha);
            _comando.Parameters.AddWithValue("@autorizado", autorizado);
            _comando.Parameters.AddWithValue("@swt_estado", swt_estado);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@usr_crea", usr_crea);
            _comando.Parameters.AddWithValue("@fec_crea", fec_crea);
            _comando.Parameters.AddWithValue("@terminal_crea", terminal_crea);
            _comando.Parameters.AddWithValue("@operacion_mod", operacion_mod);
            _comando.Parameters.AddWithValue("@usr_mod", usr_mod);
            _comando.Parameters.AddWithValue("@fec_mod", fec_mod);
            _comando.Parameters.AddWithValue("@terminal_mod", terminal_mod);
            _comando.Parameters.AddWithValue("@formulario", formulario);
            _comando.Parameters.AddWithValue("@estado_registro", estado_registro);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_servicios_pca()
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "SELECT id_servicio as #, servicio as Servicio, '' as Usuario, '' as Contraseña, '' as Fecha, '' as linea, '' as Ejecutado from m_servicio where Activo = '1'";
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }


        public static DataTable obtener_nro_pca()
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "select MAX(id_pca) + 1 as id_pca from c_pca";
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable obtener_nro_solicitud_alta()
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "select ISNULL(MAX(id_solicitud) + 1,1) as id_solicitud from OSAE";
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_area()
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "SELECT * from m_area";
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_ot(int id_area)
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "select PrcCode, PrcCode + '-' + U_CL_DESCRI AS PrcName from SBO_IMECON_PRODUCCION.dbo.OPRC where Locked <> 'Y' AND PrcCode NOT LIKE ('CB%') ";
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_movimiento()
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "SELECT * from m_movimiento";
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_perfil(int id_area)
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "SELECT * from m_perfil where id_area = " + id_area;
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable obtener_personal(string dni, string sociedad)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_obtener_empleado_st");
            _comando.Parameters.AddWithValue("@dni", dni);
            _comando.Parameters.AddWithValue("@sociedad", sociedad);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }


        public static DataTable obtener_personal_pca(string dni)
        {

        SqlCommand _comando = MetodosDatos.CrearComando_sql();
        _comando.CommandText = "SELECT apellidos + ' ' + nombres as usr,id_usuario,id_usuario+'@imecon.com.pe' FROM c_pca WHERE dni =  " + "'" + dni + "'";
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_parametros_usuario(string UserId, int GrillaId)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_parametros_usuario");
            _comando.Parameters.AddWithValue("@UserId", UserId);
            _comando.Parameters.AddWithValue("@GrillaId", GrillaId);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_ot_sap_2(string parametro, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_ot_sap");
           _comando.Parameters.AddWithValue("@parametro", parametro);
           _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_estado_ot(string parametro, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_estado_ot");
            _comando.Parameters.AddWithValue("@parametro", parametro);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }


        public static DataTable listar_stock(string ot)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sap("VS_SP_RP_StockMateri");
            _comando.Parameters.AddWithValue("@ot", ot);
            return MetodosDatos.EjecutarComandoSelect_sap(_comando);
        }

        public static DataTable listar_empleados(string tipo, string OT, string anio, string desde, string hasta)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_empleados");
            _comando.Parameters.AddWithValue("@tipo", tipo);
            _comando.Parameters.AddWithValue("@OT", OT);
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@desde", desde);
            _comando.Parameters.AddWithValue("@hasta", hasta);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_pedidos_filtro(string requerimiento,string solicitante,string ot,string responsable,
                              string estado,string fecha_crea,string fecha_requerida,string usuario,string perfil,string tipo,string anio)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_requemiento_filtro");
            _comando.Parameters.AddWithValue("@requerimiento", requerimiento);
            _comando.Parameters.AddWithValue("@solicitante", solicitante);
            _comando.Parameters.AddWithValue("@ot", ot);
            _comando.Parameters.AddWithValue("@responsable", responsable);
            _comando.Parameters.AddWithValue("@estado", estado);
            _comando.Parameters.AddWithValue("@fecha_crea", fecha_crea);
            _comando.Parameters.AddWithValue("@fecha_requerida", fecha_requerida);
            _comando.Parameters.AddWithValue("@usuario", usuario);
            _comando.Parameters.AddWithValue("@perfil", perfil);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            _comando.Parameters.AddWithValue("@anio", anio);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_responsable_misap(string num_ord)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("spLisDesResp_2");
            _comando.Parameters.AddWithValue("@NumOrd_sap", num_ord);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }


        public static DataTable obtener_num_ped(string tipo)
        {

            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_obtener_num_ped");
            _comando.Parameters.AddWithValue("@tipo_pedido", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_servicios(string est, string Anio, string usuario, string perfil)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("spLisPedSrv2_");
            _comando.Parameters.AddWithValue("@est", est);
            _comando.Parameters.AddWithValue("@Anio", Anio);
            _comando.Parameters.AddWithValue("@usr", usuario);
            _comando.Parameters.AddWithValue("@perfil", perfil);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_activos(string est, string Anio, string usuario, string perfil)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("spLisPedAct2_");
            _comando.Parameters.AddWithValue("@est", est);
            _comando.Parameters.AddWithValue("@Anio", Anio);
            _comando.Parameters.AddWithValue("@usr", usuario);
            _comando.Parameters.AddWithValue("@perfil", perfil);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }


        public static DataTable consultar_empelado(int empID)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_empleado");
            _comando.Parameters.AddWithValue("@empID", empID);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_combo_filtro(string formulario, string combo, string est, string Anio, string usuario, string perfil, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_combo_filtro");
            _comando.Parameters.AddWithValue("@formulario", formulario);
            _comando.Parameters.AddWithValue("@combo", combo);
            _comando.Parameters.AddWithValue("@est", est);
            _comando.Parameters.AddWithValue("@Anio", Anio);
            _comando.Parameters.AddWithValue("@usr", usuario);
            _comando.Parameters.AddWithValue("@perfil", perfil);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_reporte_pdt(string tipo, int DocEntry)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_reportes_pdt");
            _comando.Parameters.AddWithValue("@tipo", tipo);
            _comando.Parameters.AddWithValue("@DocEntry", DocEntry);
          return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_periodo()
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_periodo");
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_asientos_planillas(int crono, string seccion,string cod_provi)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_asientos_planillas");
            _comando.Parameters.AddWithValue("@crono", crono);
            _comando.Parameters.AddWithValue("@seccion", seccion);
            _comando.Parameters.AddWithValue("@cod_provi", cod_provi);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_mes_trabajo()
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_mes_trabajo");
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }


        public static DataTable ejecutar_sp_pdt(string sp, string periodo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql(sp);
            _comando.Parameters.AddWithValue("@periodo", periodo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_partidas_s10(string CodPresupuesto)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_partidas_s10");
            _comando.Parameters.AddWithValue("@CodPresupuesto", CodPresupuesto);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_ACT1(string IdActivo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_ACT1");
            _comando.Parameters.AddWithValue("@IdActivo", IdActivo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_permisos_mnu(string cdg_perf)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_permisos_mnu");
            _comando.Parameters.AddWithValue("@cdg_perf", cdg_perf);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }


        public static DataTable consultar_paSeguiMat(string codigo, string ot)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("paSeguiMat");
            _comando.Parameters.AddWithValue("@codigo", codigo);
            _comando.Parameters.AddWithValue("@ot", ot);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_OACT(string IdActivo, string operacion, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_OACT");
            _comando.Parameters.AddWithValue("@IdActivo", IdActivo);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_OPCE(string idreg, string operacion, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_OPCE");
            _comando.Parameters.AddWithValue("@idreg", idreg);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_OITM(string ItemCode, string operacion, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_aceros");
            _comando.Parameters.AddWithValue("@ItemCode", ItemCode);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_OCRD(string TipoSocio, string CardCode, string operacion, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_OCRD");
            _comando.Parameters.AddWithValue("@TipoSocio", TipoSocio);
            _comando.Parameters.AddWithValue("@CardCode", CardCode);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_ACT2(int TipoID, string operacion, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_ACT2");
            _comando.Parameters.AddWithValue("@TipoID", TipoID);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_OPRC(string PrcCode, string operacion, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_OPRC");
            _comando.Parameters.AddWithValue("@PrcCode", PrcCode);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_BPVSLN_SUNAT_T10(string Code, string operacion, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_BPVSLN_SUNAT_T10");
            _comando.Parameters.AddWithValue("@Code", Code);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_OTDC(int idreg, string operacion, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_OTDC");
            _comando.Parameters.AddWithValue("@idreg", idreg);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_OAIN(int DocEntry, string operacion, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_OAIN");
            _comando.Parameters.AddWithValue("@DocEntry", DocEntry);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_OCTE(int ComponenteId, string operacion, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_OCTE");
            _comando.Parameters.AddWithValue("@ComponenteId", ComponenteId);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_OERR(int Code)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_OERR");
            _comando.Parameters.AddWithValue("@Code", Code);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable consultar_TDC1(int NroLote, string operacion, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_TDC1");
            _comando.Parameters.AddWithValue("@NroLote", NroLote);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }


        public static DataTable consultar_OPCA(int id_pca, string operacion, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_OPCA");
            _comando.Parameters.AddWithValue("@id_pca", id_pca);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }


        public static DataTable consultar_OANX(int AbsEntry, string operacion, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_OANX");
            _comando.Parameters.AddWithValue("@AbsEntry", AbsEntry);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }


        public static DataTable consultar_OCRN(string CurrCode, string operacion, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_OCRN");
            _comando.Parameters.AddWithValue("@CurrCode", CurrCode);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }


        public static DataTable consultar_OCAP(string PrjCode, string PrcCode, string CodPresupuesto, int CodFase, string Fase, string FechaInicio, int Duracion, decimal Avance, decimal Peso, string operacion, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_consultar_OCAP");
            _comando.Parameters.AddWithValue("@PrjCode", PrjCode);
            _comando.Parameters.AddWithValue("@PrcCode", PrcCode);
            _comando.Parameters.AddWithValue("@CodPresupuesto ", CodPresupuesto);
            _comando.Parameters.AddWithValue("@CodFase", CodFase);
            _comando.Parameters.AddWithValue("@Fase", Fase);
            _comando.Parameters.AddWithValue("@FechaInicio", FechaInicio);
            _comando.Parameters.AddWithValue("@Duracion", Duracion);
            _comando.Parameters.AddWithValue("@Avance", Avance);
            _comando.Parameters.AddWithValue("@Peso", Peso);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable Cargar_grilla_asistencia(string anio, string mes, string dia)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_Asistencia_AnioMesDia");
            _comando.Parameters.AddWithValue("@panio", anio);
            _comando.Parameters.AddWithValue("@pmes", mes);
            _comando.Parameters.AddWithValue("@pdia", dia);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }


        #endregion

        #region Mantenimiento

        public int mantenimiento_OUSR(string cdg_usr, string des_usr, int swt_usr, string ema_usr, string dni, string cdg_perf, string clave, int swt_aprobacion,
         string usr_crea, string fec_crea, string terminal_crea, string usr_modi, string fec_modi, string terminal_modi, string operacion, string formulario)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_mantenimiento_OUSR");
            _comando.Parameters.AddWithValue("@cdg_usr", cdg_usr);
            _comando.Parameters.AddWithValue("@des_usr", des_usr);
            _comando.Parameters.AddWithValue("@swt_usr ", swt_usr);
            _comando.Parameters.AddWithValue("@ema_usr", ema_usr);
            _comando.Parameters.AddWithValue("@dni", dni);
            _comando.Parameters.AddWithValue("@cdg_perf", cdg_perf);
            _comando.Parameters.AddWithValue("@psw_usr", clave);
            _comando.Parameters.AddWithValue("@usr_crea", usr_crea);
            _comando.Parameters.AddWithValue("@fec_crea", fec_crea);
            _comando.Parameters.AddWithValue("@terminal_crea", terminal_crea);
            _comando.Parameters.AddWithValue("@usr_modi", usr_modi);
            _comando.Parameters.AddWithValue("@fec_modi", fec_modi);
            _comando.Parameters.AddWithValue("@terminal_modi", terminal_modi);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@formulario", formulario);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);

        }

        public int sp_prd_mantenimiento_m_usuari_mcop(string cdg_usr, string des_usr, string cdg_perf, int swt_usr, string ema_usr, string usr_crea, string fec_crea,
                                    string usr_modi, string fec_modi, string operacion, string formulario, int swt_aprobacion, string dni, string clave)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_mcop("sp_prd_mantenimiento_m_usuari");
            _comando.Parameters.AddWithValue("@cdg_usr", cdg_usr);
            _comando.Parameters.AddWithValue("@des_usr", des_usr);
            _comando.Parameters.AddWithValue("@cdg_perf", cdg_perf);
            _comando.Parameters.AddWithValue("@swt_usr ", swt_usr);
            _comando.Parameters.AddWithValue("@ema_usr", ema_usr);
            _comando.Parameters.AddWithValue("@usr_crea", usr_crea);
            _comando.Parameters.AddWithValue("@fec_crea", fec_crea);
            _comando.Parameters.AddWithValue("@usr_modi", usr_modi);
            _comando.Parameters.AddWithValue("@fec_modi", fec_modi);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@formulario", formulario);
            _comando.Parameters.AddWithValue("@swt_aprobacion", swt_aprobacion);
            _comando.Parameters.AddWithValue("@dni", dni);
            _comando.Parameters.AddWithValue("@psw_usr", clave);
            return MetodosDatos.EjecutarComandoInsert_mcop(_comando);
        }

        public int cargar_asistencia(string dDesde, string dHasta, int tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_conasist("pa_cargamarcacion");
            _comando.Parameters.AddWithValue("@dDesde", dDesde);
            _comando.Parameters.AddWithValue("@dHasta", dHasta);
            _comando.Parameters.AddWithValue("@tipo ", tipo);
            return MetodosDatos.EjecutarComandoInsert_conasist(_comando);

        }


        public static DataTable listar_tareos_costos(string fini, string ffin, string fano, string fsem, string dni, string tip, string mes)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_SCIRERH("spReporPlanPag_ope");
            _comando.Parameters.AddWithValue("@fini", fini);
            _comando.Parameters.AddWithValue("@ffin", ffin);
            _comando.Parameters.AddWithValue("@fano ", fano);
            _comando.Parameters.AddWithValue("@fsem", fsem);
            _comando.Parameters.AddWithValue("@dni ", dni);
            _comando.Parameters.AddWithValue("@tip ", tip);
            _comando.Parameters.AddWithValue("@mes ", mes);
            return MetodosDatos.EjecutarComandoSelect_SCIRERH(_comando);

        }


        public int mantenimiento_OCEB(string CodigoBanco, string NombreBanco, string DescripcionColumna, int CantFilasEcanb, string TipoColumna)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_mantenimiento_OCEB");
            _comando.Parameters.AddWithValue("@CodigoBanco", CodigoBanco);
            _comando.Parameters.AddWithValue("@NombreBanco", NombreBanco);
            _comando.Parameters.AddWithValue("@DescripcionColumna ", DescripcionColumna);
            _comando.Parameters.AddWithValue("@CantFilasEcanb", CantFilasEcanb);
            _comando.Parameters.AddWithValue("@TipoColumna", TipoColumna);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);

        }


        public int actualizar_correlativo(string CodigoBanco, int correlativo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_actualizar_correlativo_extracto");
            _comando.Parameters.AddWithValue("@CodigoBanco", CodigoBanco);
            _comando.Parameters.AddWithValue("@Correlativo", correlativo);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);

        }


        public int mantenimiento_OSAE(int id_solicitud, string fecha_solicitud, string dni_empleado, string empleado, string mail_empleado,
         int id_area, int id_perfil, string id_cc, string fecha_induccion, string hora_induccion, string estado,
         string usr_crea, string fec_crea, string terminal_crea, string usr_modi, string fec_modi, string terminal_modi, string operacion, string formulario, string activo, int NumLinea)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_mantenimiento_OSAE");
            _comando.Parameters.AddWithValue("@id_solicitud", id_solicitud);
            _comando.Parameters.AddWithValue("@fecha_solicitud", fecha_solicitud);
            _comando.Parameters.AddWithValue("@dni_empleado ", dni_empleado);
            _comando.Parameters.AddWithValue("@empleado", empleado);
            _comando.Parameters.AddWithValue("@mail_empleado", mail_empleado);
            _comando.Parameters.AddWithValue("@id_area", id_area);
            _comando.Parameters.AddWithValue("@id_perfil", id_perfil);
            _comando.Parameters.AddWithValue("@id_cc", id_cc);
            _comando.Parameters.AddWithValue("@fecha_induccion", fecha_induccion);
            _comando.Parameters.AddWithValue("@hora_induccion", hora_induccion);
            _comando.Parameters.AddWithValue("@estado", estado);
            _comando.Parameters.AddWithValue("@usr_crea", usr_crea);
            _comando.Parameters.AddWithValue("@fec_crea", fec_crea);
            _comando.Parameters.AddWithValue("@terminal_crea", terminal_crea);
            _comando.Parameters.AddWithValue("@usr_modi", usr_modi);
            _comando.Parameters.AddWithValue("@fec_modi", fec_modi);
            _comando.Parameters.AddWithValue("@terminal_modi", terminal_modi);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@formulario", formulario);
            _comando.Parameters.AddWithValue("@NumLinea", NumLinea);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);

        }

        public int mantenimiento_OCAP(string PrjCode, string PrcCode, string CodPresupuesto, int CodFase, string Fase, string FechaInicio, string fechafin, int Duracion, decimal Avance, decimal Peso, decimal factor, decimal avancevalorizado, string operacion)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_mantenimiento_OCAP");
            _comando.Parameters.AddWithValue("@PrjCode", PrjCode);
            _comando.Parameters.AddWithValue("@PrcCode", PrcCode);
            _comando.Parameters.AddWithValue("@CodPresupuesto ", CodPresupuesto);
            _comando.Parameters.AddWithValue("@CodFase", CodFase);
            _comando.Parameters.AddWithValue("@Fase", Fase);
            _comando.Parameters.AddWithValue("@FechaInicio", FechaInicio);
            _comando.Parameters.AddWithValue("@FechaFin", fechafin);
            _comando.Parameters.AddWithValue("@Duracion", Duracion);
            _comando.Parameters.AddWithValue("@Avance", Avance);
            _comando.Parameters.AddWithValue("@Peso", Peso);
            _comando.Parameters.AddWithValue("@Factor", factor);
            _comando.Parameters.AddWithValue("@AvanceValorizado", avancevalorizado);
            _comando.Parameters.AddWithValue("@operacion", operacion);
           return MetodosDatos.EjecutarComandoInsert_sql(_comando);

        }

        public int mantenimiento_OTDC(int idreg, string ruc, string tipdoc, string nserie, string ndocum, string fchdoc, 
            string fecven, string moneda, decimal subtot, int swtigv, decimal igv, decimal totneto, decimal impret, 
            string glosa, string docuref, string nroletra, string numord, string numocom, string numosrv, string numguia, 
            string guirem, int prioridad, int estadodoc, string usrapr, string fchapr, string obs, int swtenvio, string fecenvio,
            string coment, int estado, string feccre, string usrcre, string fecact, string usract, int numref, string operacion, string fecrec, string formulario)
        {
            
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_mantenimiento_OTDC");
            _comando.Parameters.AddWithValue("@idreg", idreg);
            _comando.Parameters.AddWithValue("@ruc", ruc);
            _comando.Parameters.AddWithValue("@tipdoc", tipdoc);
            _comando.Parameters.AddWithValue("@nserie", nserie);
            _comando.Parameters.AddWithValue("@ndocum", ndocum);
            _comando.Parameters.AddWithValue("@fchdoc", fchdoc);
            _comando.Parameters.AddWithValue("@fecven", fecven);
            _comando.Parameters.AddWithValue("@moneda", moneda);
            _comando.Parameters.AddWithValue("@subtot", subtot);
            _comando.Parameters.AddWithValue("@swtigv", swtigv);
            _comando.Parameters.AddWithValue("@igv", igv);
            _comando.Parameters.AddWithValue("@totneto", totneto);
            _comando.Parameters.AddWithValue("@impret", impret);
            _comando.Parameters.AddWithValue("@glosa", glosa);
            _comando.Parameters.AddWithValue("@docuref", docuref);
            _comando.Parameters.AddWithValue("@nroletra", nroletra);
            _comando.Parameters.AddWithValue("@numord", numord);
            _comando.Parameters.AddWithValue("@numocom", numocom);
            _comando.Parameters.AddWithValue("@numosrv", numosrv);
            _comando.Parameters.AddWithValue("@numguia", numguia);
            _comando.Parameters.AddWithValue("@guirem", guirem);
            _comando.Parameters.AddWithValue("@prioridad", prioridad);
            _comando.Parameters.AddWithValue("@estadodoc", estadodoc);
            _comando.Parameters.AddWithValue("@usrapr", usrapr);
            _comando.Parameters.AddWithValue("@fchapr", fchapr);
            _comando.Parameters.AddWithValue("@obs", obs);
            _comando.Parameters.AddWithValue("@swtenvio", swtenvio);
            _comando.Parameters.AddWithValue("@fecenvio", fecenvio);
            _comando.Parameters.AddWithValue("@coment", coment);
            _comando.Parameters.AddWithValue("@estado", estado);
            _comando.Parameters.AddWithValue("@feccre", feccre);
            _comando.Parameters.AddWithValue("@usrcre", usrcre);
            _comando.Parameters.AddWithValue("@fecact", fecact);
            _comando.Parameters.AddWithValue("@usract", usract);
            _comando.Parameters.AddWithValue("@numref", numref);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@fecrec", fecrec);
            _comando.Parameters.AddWithValue("@formulario", formulario);
         
          
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);

        }


        public int mantenimiento_TDC1(int NroLote, string FechaDocumento, int idreg, string usr_crea, string fec_crea, string terminal_crea, string usr_modi,
                                     string fec_modi, string terminal_modi, string operacion, string formulario)
        {

            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_mantenimiento_TDC1");
            _comando.Parameters.AddWithValue("@NroLote", NroLote);
            _comando.Parameters.AddWithValue("@FechaDocumento", FechaDocumento);
            _comando.Parameters.AddWithValue("@idreg", idreg);
            _comando.Parameters.AddWithValue("@usr_crea", usr_crea);
            _comando.Parameters.AddWithValue("@fec_crea", fec_crea);
            _comando.Parameters.AddWithValue("@terminal_crea", terminal_crea);
            _comando.Parameters.AddWithValue("@usr_modi", usr_modi);
            _comando.Parameters.AddWithValue("@fec_modi", fec_modi);
            _comando.Parameters.AddWithValue("@terminal_modi", terminal_modi);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@formulario", formulario);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);

        }


        public int mantenimiento_OANX(int AbsEntry, int Line, string srcPath, string trgtPath, string FileName, string FileExt, string Date, int UsrID, string Copied, string Override, string subPath, string operacion)
        {

            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_mantenimiento_OANX");
            _comando.Parameters.AddWithValue("@AbsEntry", AbsEntry);
            _comando.Parameters.AddWithValue("@Line", Line);
            _comando.Parameters.AddWithValue("@srcPath", srcPath);
            _comando.Parameters.AddWithValue("@trgtPath", trgtPath);
            _comando.Parameters.AddWithValue("@FileName", FileName);
            _comando.Parameters.AddWithValue("@FileExt", FileExt);
            _comando.Parameters.AddWithValue("@Date", Date);
            _comando.Parameters.AddWithValue("@UsrID", UsrID);
            _comando.Parameters.AddWithValue("@Copied", Copied);
            _comando.Parameters.AddWithValue("@Override", Override);
            _comando.Parameters.AddWithValue("@subPath", subPath);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);

        }

        public int mantenimiento_OPAC(string PrcCode, string Perfil, decimal Longitud, decimal cantidad)
        {

            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_mantenimiento_OPAC");
            _comando.Parameters.AddWithValue("@PrcCode", PrcCode);
            _comando.Parameters.AddWithValue("@Perfil", Perfil);
            _comando.Parameters.AddWithValue("@Longitud", Longitud);
            _comando.Parameters.AddWithValue("@cantidad", cantidad);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);

        }


        public int mantenimiento_m_prd_codigo_costo(string codigo, string descripcion, decimal habilitado, decimal fabricacion, decimal granallado, decimal pintado, decimal global, string usr_crea, string fec_crea,
                                   string terminal_crea, string usr_modi, string fec_modi, string terminal_modi, string operacion, string formulario, string estado_registro)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_prd_mantenimiento_m_prd_codigo_costo");
            _comando.Parameters.AddWithValue("@codigo", codigo);
            _comando.Parameters.AddWithValue("@descripcion", descripcion);
            _comando.Parameters.AddWithValue("@habilitado", habilitado);
            _comando.Parameters.AddWithValue("@fabricacion", fabricacion);
            _comando.Parameters.AddWithValue("@granallado", granallado);
            _comando.Parameters.AddWithValue("@pintado", pintado);
            _comando.Parameters.AddWithValue("@global", global);
            _comando.Parameters.AddWithValue("@usr_crea", usr_crea);
            _comando.Parameters.AddWithValue("@fec_crea", fec_crea);
            _comando.Parameters.AddWithValue("@terminal_crea", terminal_crea);
            _comando.Parameters.AddWithValue("@usr_modi", usr_modi);
            _comando.Parameters.AddWithValue("@fec_modi", fec_modi);
            _comando.Parameters.AddWithValue("@terminal_modi", terminal_modi);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@formulario", formulario);
            _comando.Parameters.AddWithValue("@estado_registro", estado_registro);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int sp_insertar_m_prd_test(int item, string nro_op, string marca, int cant_total, int nro_trans)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_insertar_m_prd_test");
            _comando.Parameters.AddWithValue("@item_", item);
            _comando.Parameters.AddWithValue("@nro_op_", nro_op);
            _comando.Parameters.AddWithValue("@marca_", marca);
            _comando.Parameters.AddWithValue("@cant_total_", cant_total);
            _comando.Parameters.AddWithValue("@nro_trans_", nro_trans);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int insertar_log_session(string cdg_usr, string terminal, string fecha, string ip, string session, string doninio, string swt_activo, string hinicio, string hfin, int id_session)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_insertar_OLOG");
            _comando.Parameters.AddWithValue("@cdg_usr_", cdg_usr);
            _comando.Parameters.AddWithValue("@terminal_", terminal);
            _comando.Parameters.AddWithValue("@fecha_", fecha);
            _comando.Parameters.AddWithValue("@direccion_ip_", ip);
            _comando.Parameters.AddWithValue("@session_", session);
            _comando.Parameters.AddWithValue("@dominio_", doninio);
            _comando.Parameters.AddWithValue("@swt_activo_", swt_activo);
            _comando.Parameters.AddWithValue("@hinicio_", hinicio);
            _comando.Parameters.AddWithValue("@hfin_", hfin);
            _comando.Parameters.AddWithValue("@id_session_", id_session);


            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int insertar_OAUD(string cdg_usr, string fecha, string terminal, string ip, string session, string operacion, string formulario, string cod_tipodoc, string nro_doc)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_insertar_OAUD");
            _comando.Parameters.AddWithValue("@cdg_usr", cdg_usr);
            _comando.Parameters.AddWithValue("@fecha", fecha);
            _comando.Parameters.AddWithValue("@terminal", terminal);
            _comando.Parameters.AddWithValue("@direccion_ip", ip);
            _comando.Parameters.AddWithValue("@session", session);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@formulario", formulario);
            _comando.Parameters.AddWithValue("@cod_tipodoc", cod_tipodoc);
            _comando.Parameters.AddWithValue("@nro_doc", nro_doc);



            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int sp_prd_mantenimiento_m_prd_firma(int itemnum, string cdg_usr, byte[] firma, string usr_crea, string fec_crea, string terminal_crea, string operacion,
                                  string usr_modi, string fec_modi, string terminal_modi, string formulario, string seccion, string bloque,
                                  string estado_registro)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_mantenimiento_OFIR");
            _comando.Parameters.AddWithValue("@itemnum", itemnum);
            _comando.Parameters.AddWithValue("@cdg_usr", cdg_usr);
            _comando.Parameters.AddWithValue("@firma", firma);
            _comando.Parameters.AddWithValue("@usr_crea_", usr_crea);
            _comando.Parameters.AddWithValue("@fec_crea_", fec_crea);
            _comando.Parameters.AddWithValue("@terminal_crea_", terminal_crea);
            _comando.Parameters.AddWithValue("@operacion_modi_", operacion);
            _comando.Parameters.AddWithValue("@usr_modi_", usr_modi);
            _comando.Parameters.AddWithValue("@fec_modi_", fec_modi);
            _comando.Parameters.AddWithValue("@terminal_modi_", terminal_modi);
            _comando.Parameters.AddWithValue("@formulario_", formulario);
            _comando.Parameters.AddWithValue("@seccion_", seccion);
            _comando.Parameters.AddWithValue("@bloque_", bloque);
            _comando.Parameters.AddWithValue("@estado_registro_", estado_registro);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int mantenimiento_m_prd_aprobaciones(string cdg_perf, string cdg_usr, string formulario, int swt_aprobacion, string cod_tipodoc, string operacion)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_prd_mantenimiento_m_prd_aprobaciones");
            _comando.Parameters.AddWithValue("@cdg_perf", cdg_perf);
            _comando.Parameters.AddWithValue("@cdg_usr", cdg_usr);
            _comando.Parameters.AddWithValue("@formulario", formulario);
            _comando.Parameters.AddWithValue("@swt_aprobacion", swt_aprobacion);
            _comando.Parameters.AddWithValue("@cod_tipodoc", cod_tipodoc);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int grabar_cabecera_ped
          (
              string numPE, string fecped, string numord, string cdgemp, string fecreq, string obsped,
           string swting, string fecapr, decimal swtapr, decimal swtrev, string cdgusr, string cdgapr,
           string cdgrev, string fecrev, string usucrea, string usumodi, string fecanul, string usuanul,
           string usract, string tipact, string fecact, string horact, decimal webnum, string swtest, string U_CL_CODSOL, string U_CL_SOLICI, string operacion, string cod_autorizacion
          )
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("spGrabMPedM_2");
            _comando.Parameters.AddWithValue("@numPE", numPE);
            _comando.Parameters.AddWithValue("@fecped", fecped);
            _comando.Parameters.AddWithValue("@numord", numord);
            _comando.Parameters.AddWithValue("@cdgemp", cdgemp);
            _comando.Parameters.AddWithValue("@fecreq", fecreq);
            _comando.Parameters.AddWithValue("@obsped", obsped);
            _comando.Parameters.AddWithValue("@swting", swting);
            _comando.Parameters.AddWithValue("@fecapr", fecapr);
            _comando.Parameters.AddWithValue("@swtapr", swtapr);
            _comando.Parameters.AddWithValue("@swtrev", swtrev);
            _comando.Parameters.AddWithValue("@cdgusr", cdgusr);
            _comando.Parameters.AddWithValue("@cdgapr", cdgapr);
            _comando.Parameters.AddWithValue("@cdgrev", cdgrev);
            _comando.Parameters.AddWithValue("@fecrev", fecrev);
            _comando.Parameters.AddWithValue("@usucrea", usucrea);
            _comando.Parameters.AddWithValue("@usumodi", usumodi);
            _comando.Parameters.AddWithValue("@fecanul", fecanul);
            _comando.Parameters.AddWithValue("@usuanul", usuanul);
            _comando.Parameters.AddWithValue("@usract", usract);
            _comando.Parameters.AddWithValue("@tipact", tipact);
            _comando.Parameters.AddWithValue("@fecact", fecact);
            _comando.Parameters.AddWithValue("@horact", horact);
            _comando.Parameters.AddWithValue("@webnum", webnum);
            _comando.Parameters.AddWithValue("@swtest", swtest);
            _comando.Parameters.AddWithValue("@U_CL_CODSOL", U_CL_CODSOL);
            _comando.Parameters.AddWithValue("@U_CL_SOLICI", U_CL_SOLICI);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@cod_autorizacion", cod_autorizacion);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);

        }



        public int grabar_detalle_ped
            (
                string numPE, string cdgprod, decimal canped, decimal candesp, decimal caning, string cdgeqv,
                decimal faceqv, decimal cancmp, decimal canocom, string numord, decimal swtapr, decimal swtrev,
                string usract, string tipact, string fecact, string horact, string cdgusr, decimal cjachk, decimal webnum,
                string obsped, string usrcrea, string usrmodi, string swtest, int linea, string operacion
            )
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("spGrabDPedM_2");
            _comando.Parameters.AddWithValue("@numPE", numPE);
            _comando.Parameters.AddWithValue("@cdgprod", cdgprod);
            _comando.Parameters.AddWithValue("@canped", canped);
            _comando.Parameters.AddWithValue("@candesp", candesp);
            _comando.Parameters.AddWithValue("@caning", caning);
            _comando.Parameters.AddWithValue("@cdgeqv", cdgeqv);
            _comando.Parameters.AddWithValue("@faceqv", faceqv);
            _comando.Parameters.AddWithValue("@cancmp", cancmp);
            _comando.Parameters.AddWithValue("@canocom", canocom);
            _comando.Parameters.AddWithValue("@numord", numord);
            _comando.Parameters.AddWithValue("@swtapr", swtapr);
            _comando.Parameters.AddWithValue("@swtrev", swtrev);
            _comando.Parameters.AddWithValue("@usract", usract);
            _comando.Parameters.AddWithValue("@tipact", tipact);
            _comando.Parameters.AddWithValue("@fecact", fecact);
            _comando.Parameters.AddWithValue("@horact", horact);
            _comando.Parameters.AddWithValue("@cdgusr", cdgusr);
            _comando.Parameters.AddWithValue("@cjachk", cjachk);
            _comando.Parameters.AddWithValue("@webnum", webnum);
            _comando.Parameters.AddWithValue("@obsped", obsped);
            _comando.Parameters.AddWithValue("@usrcrea", usrcrea);
            _comando.Parameters.AddWithValue("@usrmodi", usrmodi);
            _comando.Parameters.AddWithValue("@swtest", swtest);
            _comando.Parameters.AddWithValue("@linea", linea);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);

        }

        public int grabar_parametrizacion
           (
                int id, string Userid, int ColumnaId, bool visible , int GrillaId
           )
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_grabar_parametrizacion");
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@Userid", Userid);
            _comando.Parameters.AddWithValue("@ColumnaId", ColumnaId);
            _comando.Parameters.AddWithValue("@visible", visible);
            _comando.Parameters.AddWithValue("@GrillaId", GrillaId);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);

        }

        public int grabar_empleado
          (
                string CINT, string NOM1, string NOM2, string APEP, string APEM, string SEXO, string DNI, string TEMP, string AREA, string TELM, string TELF,
                string EMAIL, string ACTIVO, string ESTADO, int CSAP, string ERROR
          )
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_interfaz("sp_mantenimiento_empleados");
            _comando.Parameters.AddWithValue("@CINT", CINT);
            _comando.Parameters.AddWithValue("@NOM1", NOM1);
            _comando.Parameters.AddWithValue("@NOM2", NOM2);
            _comando.Parameters.AddWithValue("@APEP", APEP);
            _comando.Parameters.AddWithValue("@APEM", APEM);
            _comando.Parameters.AddWithValue("@SEXO", SEXO);
            _comando.Parameters.AddWithValue("@DNI", DNI);
            _comando.Parameters.AddWithValue("@TEMP", TEMP);
            _comando.Parameters.AddWithValue("@AREA", AREA);
            _comando.Parameters.AddWithValue("@TELM", TELM);
            _comando.Parameters.AddWithValue("@TELF", TELF);
            _comando.Parameters.AddWithValue("@EMAIL", EMAIL);
            _comando.Parameters.AddWithValue("@ACTIVO", ACTIVO);
            _comando.Parameters.AddWithValue("@ESTADO", ESTADO);
            _comando.Parameters.AddWithValue("@CSAP", CSAP);
            _comando.Parameters.AddWithValue("@ERROR", ERROR);
            return MetodosDatos.EjecutarComandoInsert_interfaz(_comando);

        }

        public int grabar_cabecera_asiento
        (
              int CINT, string FECHA, string TIPO, string GLOSA, string ESTADO, int CSAP
        )
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_interfaz("sp_mantenimiento_c_asientos_planillas");
            _comando.Parameters.AddWithValue("@CINT", CINT);
            _comando.Parameters.AddWithValue("@FECHA", FECHA);
            _comando.Parameters.AddWithValue("@TIPO", TIPO);
            _comando.Parameters.AddWithValue("@GLOSA", GLOSA);
            _comando.Parameters.AddWithValue("@ESTADO", ESTADO);
            _comando.Parameters.AddWithValue("@CSAP", CSAP);
            return MetodosDatos.EjecutarComandoInsert_interfaz(_comando);

        }


        public int grabar_detalle_asiento
       (
            int CINT, int LINEA, string CUENTA, string EMPDNI, string EMPNOM, decimal DEBIT, decimal CREDIT, decimal FCDEBIT, decimal FCCREDIT, string GLOSA, string CCOSTO
       )
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_interfaz("sp_mantenimiento_d_asientos_planillas");
            _comando.Parameters.AddWithValue("@CINT", CINT);
            _comando.Parameters.AddWithValue("@LINEA", LINEA);
            _comando.Parameters.AddWithValue("@CUENTA", CUENTA);
            _comando.Parameters.AddWithValue("@EMPDNI", EMPDNI);
            _comando.Parameters.AddWithValue("@EMPNOM", EMPNOM);
            _comando.Parameters.AddWithValue("@DEBIT", DEBIT);
            _comando.Parameters.AddWithValue("@CREDIT", CREDIT);
            _comando.Parameters.AddWithValue("@FCDEBIT", FCDEBIT);
            _comando.Parameters.AddWithValue("@FCCREDIT", FCCREDIT);
            _comando.Parameters.AddWithValue("@GLOSA", GLOSA);
            _comando.Parameters.AddWithValue("@CCOSTO", CCOSTO);
            return MetodosDatos.EjecutarComandoInsert_interfaz(_comando);

        }

        public int grabar_cabecera_ser
         (
             string numPE, string fecped, string numord, string cdgemp, string fecreq, string obsped,
          string swting, string fecapr, decimal swtapr, string cdgusr, string cdgapr,
          string usucrea, string usumodi, string fecanul, string usuanul,
          string usract, string tipact, string fecact, string horact,string swtest, string U_CL_CODSOL, string U_CL_SOLICI, string operacion

          )
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("spGrabMPedS_2");
            _comando.Parameters.AddWithValue("@numPE", numPE);
            _comando.Parameters.AddWithValue("@fecped", fecped);
            _comando.Parameters.AddWithValue("@numord", numord);
            _comando.Parameters.AddWithValue("@cdgemp", cdgemp);
            _comando.Parameters.AddWithValue("@fecreq", fecreq);
            _comando.Parameters.AddWithValue("@obsped", obsped);
            _comando.Parameters.AddWithValue("@swting", swting);
            _comando.Parameters.AddWithValue("@fecapr", fecapr);
            _comando.Parameters.AddWithValue("@swtapr", swtapr);
            _comando.Parameters.AddWithValue("@cdgusr", cdgusr);
            _comando.Parameters.AddWithValue("@cdgapr", cdgapr);
            _comando.Parameters.AddWithValue("@usucrea", usucrea);
            _comando.Parameters.AddWithValue("@usumodi", usumodi);
            _comando.Parameters.AddWithValue("@fecanul", fecanul);
            _comando.Parameters.AddWithValue("@usuanul", usuanul);
            _comando.Parameters.AddWithValue("@usract", usract);
            _comando.Parameters.AddWithValue("@tipact", tipact);
            _comando.Parameters.AddWithValue("@fecact", fecact);
            _comando.Parameters.AddWithValue("@horact", horact);
            _comando.Parameters.AddWithValue("@swtest", swtest);
            _comando.Parameters.AddWithValue("@U_CL_CODSOL", U_CL_CODSOL);
            _comando.Parameters.AddWithValue("@U_CL_SOLICI", U_CL_SOLICI);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }


        public int grabar_detalle_ser
          (
              string numPE, string cdgprod, decimal canped, decimal candesp, decimal caning, string cdgeqv,
              decimal faceqv, decimal cancmp, decimal canocom, string numord, decimal swtapr,
              string usract, string tipact, string fecact, string horact, string cdgusr, string usrcrea, string usrmodi, string swtest, int linea, string operacion

          )
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("spGrabDPedS_2");
            _comando.Parameters.AddWithValue("@numPE", numPE);
            _comando.Parameters.AddWithValue("@cdgsrv", cdgprod);
            _comando.Parameters.AddWithValue("@canped", canped);
            _comando.Parameters.AddWithValue("@candesp", candesp);
            _comando.Parameters.AddWithValue("@caning", caning);
            _comando.Parameters.AddWithValue("@cdgeqv", cdgeqv);
            _comando.Parameters.AddWithValue("@faceqv", faceqv);
            _comando.Parameters.AddWithValue("@cancmp", cancmp);
            _comando.Parameters.AddWithValue("@canosrv", canocom);
            _comando.Parameters.AddWithValue("@numord", numord);
            _comando.Parameters.AddWithValue("@swtapr", swtapr);
            _comando.Parameters.AddWithValue("@usract", usract);
            _comando.Parameters.AddWithValue("@tipact", tipact);
            _comando.Parameters.AddWithValue("@fecact", fecact);
            _comando.Parameters.AddWithValue("@horact", horact);
            _comando.Parameters.AddWithValue("@cdgusr", cdgusr);
            _comando.Parameters.AddWithValue("@usrcrea", usrcrea);
            _comando.Parameters.AddWithValue("@usrmodi", usrmodi);
            _comando.Parameters.AddWithValue("@swtest", swtest);
            _comando.Parameters.AddWithValue("@linea", linea);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);

        }

        public int actualizar_num_ped(string num_ped, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "UPDATE m_numeradores SET valor_asignado =" + "'" + num_ped + "'" + " WHERE numerador= " + "'" + tipo + "'";
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int actualizar_aprobar_materiales(string num_ped, int swtApr, string usrapr)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("spAprMat_2");
            _comando.Parameters.AddWithValue("@numPE", num_ped);
            _comando.Parameters.AddWithValue("@swtApr", swtApr);
            _comando.Parameters.AddWithValue("@usrapr", usrapr);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int actualizar_aprobar_servicios(string num_ped, int swtApr, string usrapr)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("spAprServ_2");
            _comando.Parameters.AddWithValue("@numPE", num_ped);
            _comando.Parameters.AddWithValue("@swtApr", swtApr);
            _comando.Parameters.AddWithValue("@usrapr", usrapr);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int mantenimiento_pca(int pca, string dni, string apellidos, string nombres, int id_area, int id_perfil, string id_usuario, int id_movimiento, string fecha, string autorizado, string swt_estado, string operacion, string usr_crea, string fec_crea,
                                               string terminal_crea, string operacion_mod, string usr_mod, string fec_mod, string terminal_mod, string formulario, string estado_registro, string ot)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_mantenimiento_c_pca");
            _comando.Parameters.AddWithValue("@pca", pca);
            _comando.Parameters.AddWithValue("@dni", dni);
            _comando.Parameters.AddWithValue("@apellidos", apellidos);
            _comando.Parameters.AddWithValue("@nombres", nombres);
            _comando.Parameters.AddWithValue("@id_area", id_area);
            _comando.Parameters.AddWithValue("@id_perfil", id_perfil);
            _comando.Parameters.AddWithValue("@id_usuario", id_usuario);
            _comando.Parameters.AddWithValue("@id_movimiento", id_movimiento);
            _comando.Parameters.AddWithValue("@fecha", fecha);
            _comando.Parameters.AddWithValue("@autorizado", autorizado);
            _comando.Parameters.AddWithValue("@swt_estado", swt_estado);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@usr_crea", usr_crea);
            _comando.Parameters.AddWithValue("@fec_crea", fec_crea);
            _comando.Parameters.AddWithValue("@terminal_crea", terminal_crea);
            _comando.Parameters.AddWithValue("@operacion_mod", operacion_mod);
            _comando.Parameters.AddWithValue("@usr_mod", usr_mod);
            _comando.Parameters.AddWithValue("@fec_mod", fec_mod);
            _comando.Parameters.AddWithValue("@terminal_mod", terminal_mod);
            _comando.Parameters.AddWithValue("@formulario", formulario);
            _comando.Parameters.AddWithValue("@estado_registro", estado_registro);
            _comando.Parameters.AddWithValue("@ot", ot);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int mantenimiento_pca_d(int pca, int linea, string id_usuario_g, int id_servicio, string contraseña, string fecha, string swt_estado, string operacion, string usr_crea, string fec_crea,
                                                string terminal_crea, string operacion_mod, string usr_mod, string fec_mod, string terminal_mod, string formulario, string estado_registro)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_mantenimiento_d_pca");
            _comando.Parameters.AddWithValue("@id_pca", pca);
            _comando.Parameters.AddWithValue("@linea", linea);
            _comando.Parameters.AddWithValue("@id_usuario", id_usuario_g);
            _comando.Parameters.AddWithValue("@id_servicio", id_servicio);
            _comando.Parameters.AddWithValue("@contraseña", contraseña);
            _comando.Parameters.AddWithValue("@fecha", fecha);
            _comando.Parameters.AddWithValue("@swt_estado", swt_estado);
            _comando.Parameters.AddWithValue("@operacion", operacion);
            _comando.Parameters.AddWithValue("@usr_crea", usr_crea);
            _comando.Parameters.AddWithValue("@fec_crea", fec_crea);
            _comando.Parameters.AddWithValue("@terminal_crea", terminal_crea);
            _comando.Parameters.AddWithValue("@operacion_mod", operacion_mod);
            _comando.Parameters.AddWithValue("@usr_mod", usr_mod);
            _comando.Parameters.AddWithValue("@fec_mod", fec_mod);
            _comando.Parameters.AddWithValue("@terminal_mod", terminal_mod);
            _comando.Parameters.AddWithValue("@formulario", formulario);
            _comando.Parameters.AddWithValue("@estado_registro", estado_registro);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int actualizar_estado(string num_ped, string swt_estado, string usrapr, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_actualizar_estado_req");
            _comando.Parameters.AddWithValue("@numPE", num_ped);
            _comando.Parameters.AddWithValue("@swt_estado", swt_estado);
            _comando.Parameters.AddWithValue("@usrapr", usrapr);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }


        public int actualizar_DocEntry(string num_ped, int DocEntry, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_actualizar_DocEntry_req");
            _comando.Parameters.AddWithValue("@numPE", num_ped);
            _comando.Parameters.AddWithValue("@DocEntry", DocEntry);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

     
        public static DataTable validar_req_sap(int DocEntry, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_validar_req_sap");
            _comando.Parameters.AddWithValue("@DocEntry", DocEntry);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        #endregion

  

        #region Mantenimiento PLANILLA STARSOFT

        public int insertar_marcacion(string dni, string usu, string ip)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_planilla("SP_MAR_ASIS2");
            _comando.Parameters.AddWithValue("@dni", dni);
            _comando.Parameters.AddWithValue("@usu", usu);
            _comando.Parameters.AddWithValue("@ip", ip);
           return MetodosDatos.EjecutarComandoInsert_planilla(_comando);

        }

       

     

        #endregion

        #region Consultar STARSOFT

        public static DataTable ejecutar_sp_starsoft(string sp, string periodo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_starsoft(sp);
            _comando.Parameters.AddWithValue("@fecha", periodo);

            return MetodosDatos.EjecutarComandoSelect_starsoft(_comando);
        }

      

        public static DataTable listar_periodos_cronograma(string mes)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_periodo_cronograma");
            _comando.Parameters.AddWithValue("@mes", mes);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        
        }

        //public static DataTable listar_detalle_asientos(int CRONO)
        //{
        //    SqlCommand _comando = MetodosDatos.CrearComando_planilla();
        //    _comando.CommandText = "SELECT CRONO AS CINT,	CONVERT(INT, DMOV_SECUE) - 1 AS LINEA,	DMOV_CUENT AS CUENTA, DMOV_ANEXO AS EMPDNI,	'' EMPNOM,	DMOV_DEBE AS DEBIT, DMOV_HABER AS CREDIT, DMOV_DEBUS AS FCDEBIT, DMOV_HABUS AS FCCREDIT, SUBSTRING(DMOV_GLOSA,1,50) AS GLOSA,  DMOV_CENCO AS CCOSTO FROM CONTDET WHERE CRONO = " + CRONO + " ORDER BY DMOV_SECUE";
        //    return MetodosDatos.EjecutarComandoSelect_planilla(_comando);
        //}

        //public static DataTable listar_cabecara_asientos(int CRONO)
        //{
        //    SqlCommand _comando = MetodosDatos.CrearComando_planilla();
        //    _comando.CommandText = "select CRONO AS CINT,  CONVERT(VARCHAR, CMOV_FECHA,112)	 AS FECHA, 'NPLA' TIPO,SUBSTRING(CMOV_GLOSA,1,50) AS GLOSA,	'R' ESTADO,	'' CSAP from CONTCAB WHERE CRONO = " + CRONO  ;
        //    return MetodosDatos.EjecutarComandoSelect_planilla(_comando);
        //}

        #endregion
        
        #region Consultar SAP

        public static DataTable listar_costos2(string mat, string ot, string dDesde, string dHasta, string tip, string mod)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sap("VS_SP_CostosMatSer2");
            _comando.Parameters.AddWithValue("@mat", mat);
            _comando.Parameters.AddWithValue("@ot", ot);
            _comando.Parameters.AddWithValue("@dDesde", dDesde);
            _comando.Parameters.AddWithValue("@dHasta", dHasta);
            _comando.Parameters.AddWithValue("@tip", tip);
            _comando.Parameters.AddWithValue("@mod", mod);
            return MetodosDatos.EjecutarComandoSelect_sap(_comando);
        }

        public static DataTable listar_materiales_servicios_sap(string tipo_requerimiento, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_materiales_servicios");
            _comando.Parameters.AddWithValue("@tipo_requerimiento", tipo_requerimiento);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }


        public static DataTable listar_proyectos(string parametro)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_proyectos");
            _comando.Parameters.AddWithValue("@parametro", parametro);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable listar_ot_sap()
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sap();
           // _comando.CommandText = "SELECT SL1Code as num_ord , BinCode as Descripcion FROM OBIN order by SL1Code desc"; // WHERE U_CL_PROYEC =  " + "'" + U_CL_PROYEC + "'"
            _comando.CommandText = "SELECT PrcCode as num_ord , PrcCode + ' ' + U_CL_DESCRI as Descripcion FROM OPRC where Locked = 'N' AND Active = 'Y' order by PrcCode desc"; // WHERE U_CL_PROYEC =  " + "'" + U_CL_PROYEC + "'";
            return MetodosDatos.EjecutarComandoSelect_sap(_comando);
        }

        public static DataTable listar_ubicaciones_sap()
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sap();
            _comando.CommandText = "SELECT SL1Code as num_ord , BinCode as Descripcion FROM OBIN order by SL1Code desc"; // WHERE U_CL_PROYEC =  " + "'" + U_CL_PROYEC + "'"
            //_comando.CommandText = "SELECT PrcCode as num_ord , PrcCode + ' ' + U_CL_DESCRI as Descripcion FROM OPRC where Locked = 'N' AND Active = 'Y' order by PrcCode desc"; // WHERE U_CL_PROYEC =  " + "'" + U_CL_PROYEC + "'";
            return MetodosDatos.EjecutarComandoSelect_sap(_comando);
        }


        public static DataTable listar_proyectos_sap(string num_ord)
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sap();
            _comando.CommandText = "select  PrjCode, PrjName FROM OPRJ P INNER JOIN OPRC O ON P.PrjCode = O.U_CL_PROYEC WHERE O.PrcCode =  " + "'" + num_ord + "'";
            return MetodosDatos.EjecutarComandoSelect_sap(_comando);
        }

        public static DataTable listar_bd_sap()
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sap();
            _comando.CommandText = "SELECT name, database_id, create_date FROM sys.databases";
            return MetodosDatos.EjecutarComandoSelect_sap(_comando);
        }

       

        #endregion

        #region Tareos

        public DataTable listar_semanas_anio(string anio)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_lstSemanas_Anio");
            _comando.Parameters.AddWithValue("@anio", anio);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable listar_fechas_inifin(string anio, string semana)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_fechaIniFin_AnioSemana");
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@semana", semana);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable listar_combo_tipo()
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_lstTipoDia");
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable listar_combo_actividad()
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_lstActividad");
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable listar_combo_ot()
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_lstOT");
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable listar_combo_edt(string ot)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_lstEDT_OT");
            _comando.Parameters.AddWithValue("@ot", ot);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable listar_grid_personal(string dni, string origen)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_lstPerAsign_tar");
            _comando.Parameters.AddWithValue("@dni", dni);
            _comando.Parameters.AddWithValue("@origen", origen);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable listar_combo_falta()
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_lstTipoSusp");
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable listar_combo_turno()
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_lstTurno");
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public static DataTable validar_horas_semanales(string dni, string fec, string fini, string ffin, string usr)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_LisCargo");
            _comando.Parameters.AddWithValue("@dni", dni);
            _comando.Parameters.AddWithValue("@fec", fec);
            //_comando.Parameters.AddWithValue("@tur", tur);
            _comando.Parameters.AddWithValue("@fini", fini);
            _comando.Parameters.AddWithValue("@ffin", ffin);
            _comando.Parameters.AddWithValue("@usr", usr);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable listar_grilla_tareo(string anio, string semana, string usuario, int estado, string permiso, string ot)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_LisTareoTrab");
            _comando.Parameters.AddWithValue("@ano", anio);
            _comando.Parameters.AddWithValue("@sem", semana);
            _comando.Parameters.AddWithValue("@usr", usuario);
            _comando.Parameters.AddWithValue("@swt_tar", estado);
            _comando.Parameters.AddWithValue("@permi", permiso);
            _comando.Parameters.AddWithValue("@ot", ot);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);



        }

        public DataTable listar_grilla_tareo_ctrl(int anio, int semana, string usuario, int estado, string permiso, string ot)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_LisTareoTrab");
            _comando.Parameters.AddWithValue("@ano", anio);
            _comando.Parameters.AddWithValue("@sem", semana);
            _comando.Parameters.AddWithValue("@usr", usuario);
            _comando.Parameters.AddWithValue("@swt_tar", estado);
            _comando.Parameters.AddWithValue("@permi", permiso);
            _comando.Parameters.AddWithValue("@ot", ot);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable listar_combo_personal_total()
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_lstPersonal");
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable obtener_estTareo(string anio, string semana, string usuario)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_EstTareo");
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@sem", semana);
            _comando.Parameters.AddWithValue("@usr", usuario);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable listar_combo_tareadores()
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_lstTareadores");
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public int asignar_trab_tareador(string tareador, string personal, string usuario)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_paAsigPer");
            _comando.Parameters.AddWithValue("@codtar", tareador);
            _comando.Parameters.AddWithValue("@codper", personal);
            _comando.Parameters.AddWithValue("@usr", usuario);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }



        public int desasignar_trab_tareador(string tareador, string personal)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_paDesasigPer");
            _comando.Parameters.AddWithValue("@codtar", tareador);
            _comando.Parameters.AddWithValue("@codper", personal);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int grabar_tareo(string p_1, string p_2, string p_3, string p_4, string p_5, string p_6, string p_7, string p_8, string p_9, string p_10, string p_11, string p_12, string p_13, string p_14, string p_15, string p_16)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_GrabTareo");
            _comando.Parameters.AddWithValue("@fec", p_1);
            _comando.Parameters.AddWithValue("@turn", p_2);
            _comando.Parameters.AddWithValue("@cod", p_3);
            _comando.Parameters.AddWithValue("@ot", p_4);
            _comando.Parameters.AddWithValue("@edt", p_5);
            _comando.Parameters.AddWithValue("@pro", p_6);
            _comando.Parameters.AddWithValue("@activ", p_7);
            _comando.Parameters.AddWithValue("@ht", p_8);
            _comando.Parameters.AddWithValue("@he", p_9);
            _comando.Parameters.AddWithValue("@sus", p_10);
            _comando.Parameters.AddWithValue("@des", p_11);
            _comando.Parameters.AddWithValue("@usr", p_12);
            _comando.Parameters.AddWithValue("@fini", p_13);
            _comando.Parameters.AddWithValue("@ffin", p_14);
            _comando.Parameters.AddWithValue("@sem", p_15);
            _comando.Parameters.AddWithValue("@fal", p_16);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public DataTable obtener_user(string dni)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_user_dni");
            _comando.Parameters.AddWithValue("@dni", dni);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public int revisar_tareo(string anio, string semana, string usuario, string estado, string usuario_mod)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_ProcTar");
            _comando.Parameters.AddWithValue("@ano", anio);
            _comando.Parameters.AddWithValue("@sem", semana);
            _comando.Parameters.AddWithValue("@usr", usuario);
            _comando.Parameters.AddWithValue("@swt", estado);
            _comando.Parameters.AddWithValue("@usr_mod", usuario_mod);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public DataTable Resumen_Tareo_Formato(string fechaIni, string fechaFin, string semana, string anio, string tfor, string eval, string dni, string swtht)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_ReporResTar");
            _comando.Parameters.AddWithValue("@fini", fechaIni);
            _comando.Parameters.AddWithValue("@ffin", fechaFin);
            _comando.Parameters.AddWithValue("@fano", anio);
            _comando.Parameters.AddWithValue("@fsem", semana);
            _comando.Parameters.AddWithValue("@tfor", tfor);
            _comando.Parameters.AddWithValue("@teva", eval);
            _comando.Parameters.AddWithValue("@swtht", swtht);
            _comando.Parameters.AddWithValue("@dni", dni);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public int anular_tareo(string anio, string semana, string usuario, string estado, string usuarioMod)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_ProcTar");
            _comando.Parameters.AddWithValue("@sem", semana);
            _comando.Parameters.AddWithValue("@ano", anio);
            _comando.Parameters.AddWithValue("@usr", usuario);
            _comando.Parameters.AddWithValue("@swt", estado);
            _comando.Parameters.AddWithValue("@usr_mod", usuarioMod);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public DataTable Buscar_registro(string mod_Anio, string mod_Sem, string mod_UsrCrea, string mod_CodTrab, string mod_FechTrab, string mod_OT)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_BusRegtareo");
            _comando.Parameters.AddWithValue("@anio", mod_Anio);
            _comando.Parameters.AddWithValue("@semana", mod_Sem);
            _comando.Parameters.AddWithValue("@usrCrea", mod_UsrCrea);
            _comando.Parameters.AddWithValue("@codTrab", mod_CodTrab);
            _comando.Parameters.AddWithValue("@fechTrab", mod_FechTrab);
            _comando.Parameters.AddWithValue("@ot", mod_OT);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }



        public DataTable obtener_semana_actual()
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_semanaActual");
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public int actualizar_tareo(string anio, string semana, string usuarioCrea, string codigotrab, string fechaTrab, string turno, string tipo, string falta, string proc, string activ, string hn, string he)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_actualizar");
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@semana", semana);
            _comando.Parameters.AddWithValue("@usrCrea", usuarioCrea);
            _comando.Parameters.AddWithValue("@codTrab", codigotrab);
            _comando.Parameters.AddWithValue("@fecha", fechaTrab);
            _comando.Parameters.AddWithValue("@turno", turno);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            _comando.Parameters.AddWithValue("@falta", falta);
            _comando.Parameters.AddWithValue("@proc", proc);
            _comando.Parameters.AddWithValue("@activ", activ);
            _comando.Parameters.AddWithValue("@hn", hn);
            _comando.Parameters.AddWithValue("@he", he);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }


        public int actualizar_tareo(string anio, string semana, string usuarioCrea, string codigotrab, string fechaTrab, string turno, string tipo, string falta, string proc, string activ, string hn, string he, string ot)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_actualizar");
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@semana", semana);
            _comando.Parameters.AddWithValue("@usrCrea", usuarioCrea);
            _comando.Parameters.AddWithValue("@codTrab", codigotrab);
            _comando.Parameters.AddWithValue("@fecha", fechaTrab);
            _comando.Parameters.AddWithValue("@turno", turno);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            _comando.Parameters.AddWithValue("@falta", falta);
            _comando.Parameters.AddWithValue("@proc", proc);
            _comando.Parameters.AddWithValue("@activ", activ);
            _comando.Parameters.AddWithValue("@hn", hn);
            _comando.Parameters.AddWithValue("@he", he);
            _comando.Parameters.AddWithValue("@ot", ot);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }


        public int anula_registro_tareo(string anio, string semana, string usuarioCrea, string codigotrab, string fechaTrab, string ot)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_anular");
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@semana", semana);
            _comando.Parameters.AddWithValue("@usrCrea", usuarioCrea);
            _comando.Parameters.AddWithValue("@codTrab", codigotrab);
            _comando.Parameters.AddWithValue("@fecha", fechaTrab);
            _comando.Parameters.AddWithValue("@ot", ot);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int actualizar_tareo_masivo(string mod_Anio, string mod_Sem, string mod_UsrCrea, string turno, string ot, string tipo, string falta, string hn, string he, string observacion)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_actualizar_masivo");
            _comando.Parameters.AddWithValue("@anio", mod_Anio);
            _comando.Parameters.AddWithValue("@semana", mod_Sem);
            _comando.Parameters.AddWithValue("@usrCrea", mod_UsrCrea);
            _comando.Parameters.AddWithValue("@turno", turno);
            _comando.Parameters.AddWithValue("@ot", ot);
            _comando.Parameters.AddWithValue("@tipo", tipo);
            _comando.Parameters.AddWithValue("@falta", falta);
            _comando.Parameters.AddWithValue("@hn", hn);
            _comando.Parameters.AddWithValue("@he", he);
            _comando.Parameters.AddWithValue("@observacion", observacion);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }


        public DataTable buscar_asignacion(string personal)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_BusAsignacion");
            _comando.Parameters.AddWithValue("@personal", personal);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable verificar_acceso(string usuario)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_VerificarAcceso");
            _comando.Parameters.AddWithValue("@pUsuario", usuario);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public int desasignar_trab_tareador(string tareador, string personal, string usuario)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_paDesasigPer");
            _comando.Parameters.AddWithValue("@codtar", tareador);
            _comando.Parameters.AddWithValue("@codper", personal);
            _comando.Parameters.AddWithValue("@usuario", usuario);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int actualizar_registro(string trabajador, string ot, string HTRABAJ, string OBHE25, string OBHE35, string CCHE100, string DFERIADO, string DFALTAS, string DDMEDICO, string DSUBENF, string DSUBMAT, string DVACAC, string DTRABAJ, string DLICSGO, string DBAJADA, string campo_HTRABAJ, string campo_OBHE25, string campo_OBHE35, string campo_CCHE100, string campo_DFERIADO, string campo_DFALTAS, string campo_DDMEDICO, string campo_DSUBENF, string campo_DSUBMAT, string campo_DVACAC, string campo_DTRABAJ, string campo_DLICSGO, string campo_DBAJADA, string campo_ccHTRABAJ, string campo_ccOBHE25, string campo_ccOBHE35, string campo_ccCCHE100, string campo_ccDFERIADO, string campo_ccDFALTAS, string campo_ccDDMEDICO, string campo_ccDSUBENF, string campo_ccDSUBMAT, string campo_ccDVACAC, string campo_ccDTRABAJ, string campo_ccDLICSGO, string campo_ccDBAJADA)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_actualizar_reporte");
            _comando.Parameters.AddWithValue("@pTrabajador", trabajador);
            _comando.Parameters.AddWithValue("@pOt", ot);
            _comando.Parameters.AddWithValue("@pHTRABAJ", HTRABAJ);
            _comando.Parameters.AddWithValue("@pOBHE25", OBHE25);
            _comando.Parameters.AddWithValue("@pOBHE35", OBHE35);
            _comando.Parameters.AddWithValue("@pCCHE100", CCHE100);
            _comando.Parameters.AddWithValue("@pDFERIADO", DFERIADO);
            _comando.Parameters.AddWithValue("@pDFALTAS", DFALTAS);
            _comando.Parameters.AddWithValue("@pDDMEDICO", DDMEDICO);
            _comando.Parameters.AddWithValue("@pDSUBENF", DSUBENF);
            _comando.Parameters.AddWithValue("@pDSUBMAT", DSUBMAT);
            _comando.Parameters.AddWithValue("@pDVACAC", DVACAC);
            _comando.Parameters.AddWithValue("@pDTRABAJ", DTRABAJ);
            _comando.Parameters.AddWithValue("@pDLICSGO", DLICSGO);
            _comando.Parameters.AddWithValue("@pDBAJADA", DBAJADA);
            _comando.Parameters.AddWithValue("@pcampo_HTRABAJ", campo_HTRABAJ);
            _comando.Parameters.AddWithValue("@pcampo_OBHE25", campo_OBHE25);
            _comando.Parameters.AddWithValue("@pcampo_OBHE35", campo_OBHE35);
            _comando.Parameters.AddWithValue("@pcampo_CCHE100", campo_CCHE100);
            _comando.Parameters.AddWithValue("@pcampo_DFERIADO", campo_DFERIADO);
            _comando.Parameters.AddWithValue("@pcampo_DFALTAS", campo_DFALTAS);
            _comando.Parameters.AddWithValue("@pcampo_DDMEDICO", campo_DDMEDICO);
            _comando.Parameters.AddWithValue("@pcampo_DSUBENF", campo_DSUBENF);
            _comando.Parameters.AddWithValue("@pcampo_DSUBMAT", campo_DSUBMAT);
            _comando.Parameters.AddWithValue("@pcampo_DVACAC", campo_DVACAC);
            _comando.Parameters.AddWithValue("@pcampo_DTRABAJ", campo_DTRABAJ);
            _comando.Parameters.AddWithValue("@pcampo_DLICSGO", campo_DLICSGO);
            _comando.Parameters.AddWithValue("@pcampo_DBAJADA", campo_DBAJADA);
            _comando.Parameters.AddWithValue("@pcampo_ccHTRABAJ", campo_ccHTRABAJ);
            _comando.Parameters.AddWithValue("@pcampo_ccOBHE25", campo_ccOBHE25);
            _comando.Parameters.AddWithValue("@pcampo_ccOBHE35", campo_ccOBHE35);
            _comando.Parameters.AddWithValue("@pcampo_ccCCHE100", campo_ccCCHE100);
            _comando.Parameters.AddWithValue("@pcampo_ccDFERIADO", campo_ccDFERIADO);
            _comando.Parameters.AddWithValue("@pcampo_ccDFALTAS", campo_ccDFALTAS);
            _comando.Parameters.AddWithValue("@pcampo_ccDDMEDICO", campo_ccDDMEDICO);
            _comando.Parameters.AddWithValue("@pcampo_ccDSUBENF", campo_ccDSUBENF);
            _comando.Parameters.AddWithValue("@pcampo_ccDSUBMAT", campo_ccDSUBMAT);
            _comando.Parameters.AddWithValue("@pcampo_ccDVACAC", campo_ccDVACAC);
            _comando.Parameters.AddWithValue("@pcampo_ccDTRABAJ", campo_ccDTRABAJ);
            _comando.Parameters.AddWithValue("@pcampo_ccDLICSGO", campo_ccDLICSGO);
            _comando.Parameters.AddWithValue("@pcampo_ccDBAJADA", campo_ccDBAJADA);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }


        public int insertar_registro(string codigo, string trabajador, string ot, string opcion)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_insertar_reporte");
            _comando.Parameters.AddWithValue("@pCodigo", codigo);
            _comando.Parameters.AddWithValue("@pTrabajador", trabajador);
            _comando.Parameters.AddWithValue("@pOt", ot);
            _comando.Parameters.AddWithValue("@pOpcion", opcion);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int insertar_fecha(string fecha, string marcador)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_insertar_fecha");
            _comando.Parameters.AddWithValue("@pfecha", fecha);
            _comando.Parameters.AddWithValue("@pmarcador", marcador);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public DataTable buscar_codigo(string fecha)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_buscar_codigo");
            _comando.Parameters.AddWithValue("@pFecha", fecha);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public int reiniciar_tablas()
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_reiniciar_tablas");
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }


        public int actualizar_registro_civil(string trabajador, string ot, string CCHTRAB, string CCDFALTA, string CCHE60, string CCHE100, string CCHDOBLE, string CCDDMED, string CCFERIAD, string campo_CCHTRAB, string campo_CCDFALTA, string campo_CCHE60, string campo_CCHE100, string campo_CCHDOBLE, string campo_CCDDMED, string campo_CCFERIAD, string campo_ccCCHTRAB, string campo_ccCCDFALTA, string campo_ccCCHE60, string campo_ccCCHE100, string campo_ccCCHDOBLE, string campo_ccCCDDMED, string campo_ccCCFERIAD)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_actualizar_reporte_civ");
            _comando.Parameters.AddWithValue("@pTrabajador", trabajador);
            _comando.Parameters.AddWithValue("@pOt", ot);
            _comando.Parameters.AddWithValue("@pCCHTRAB", CCHTRAB);
            _comando.Parameters.AddWithValue("@pCCDFALTA", CCDFALTA);
            _comando.Parameters.AddWithValue("@pCCHE60", CCHE60);
            _comando.Parameters.AddWithValue("@pCCHE100", CCHE100);
            _comando.Parameters.AddWithValue("@pCCHDOBLE", CCHDOBLE);
            _comando.Parameters.AddWithValue("@pCCDDMED", CCDDMED);
            _comando.Parameters.AddWithValue("@pCCFERIAD", CCFERIAD);
            _comando.Parameters.AddWithValue("@pcampo_CCHTRAB", campo_CCHTRAB);
            _comando.Parameters.AddWithValue("@pcampo_CCDFALTA", campo_CCDFALTA);
            _comando.Parameters.AddWithValue("@pcampo_CCHE60", campo_CCHE60);
            _comando.Parameters.AddWithValue("@pcampo_CCHE100", campo_CCHE100);
            _comando.Parameters.AddWithValue("@pcampo_CCHDOBLE", campo_CCHDOBLE);
            _comando.Parameters.AddWithValue("@pcampo_CCDDMED", campo_CCDDMED);
            _comando.Parameters.AddWithValue("@pcampo_CCFERIAD", campo_CCFERIAD);
            _comando.Parameters.AddWithValue("@pcampo_ccCCHTRAB", campo_ccCCHTRAB);
            _comando.Parameters.AddWithValue("@pcampo_ccCCDFALTA", campo_ccCCDFALTA);
            _comando.Parameters.AddWithValue("@pcampo_ccCCHE60", campo_ccCCHE60);
            _comando.Parameters.AddWithValue("@pcampo_ccCCHE100", campo_ccCCHE100);
            _comando.Parameters.AddWithValue("@pcampo_ccCCHDOBLE", campo_ccCCHDOBLE);
            _comando.Parameters.AddWithValue("@pcampo_ccCCDDMED", campo_ccCCDDMED);
            _comando.Parameters.AddWithValue("@pcampo_ccCCFERIAD", campo_ccCCFERIAD);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public DataTable Consulta_final(string opcPlanilla)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_consulta_final");
            _comando.Parameters.AddWithValue("@popc_planilla", opcPlanilla);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable Buscar_Ot(string _codigo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_buscar_OT");
            _comando.Parameters.AddWithValue("@pdni", _codigo);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }



        public DataTable cargar_grilla(string anio, string semana)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("spReporTarsf");
            _comando.Parameters.AddWithValue("@fini", "");
            _comando.Parameters.AddWithValue("@ffin", "");
            _comando.Parameters.AddWithValue("@fano", anio);
            _comando.Parameters.AddWithValue("@fsem", semana);
            _comando.Parameters.AddWithValue("@dni", "");
            _comando.Parameters.AddWithValue("@plani", "2");
            _comando.Parameters.AddWithValue("@tip", "2");
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }
        public DataTable cargar_grilla_civil(string anio, string semana)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("spReporTarsf");
            _comando.Parameters.AddWithValue("@fini", "");
            _comando.Parameters.AddWithValue("@ffin", "");
            _comando.Parameters.AddWithValue("@fano", anio);
            _comando.Parameters.AddWithValue("@fsem", semana);
            _comando.Parameters.AddWithValue("@dni", "");
            _comando.Parameters.AddWithValue("@plani", "3");
            _comando.Parameters.AddWithValue("@tip", "2");
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable verificar_asistencia(string codigo, string fecha)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_verificar_asistencia");
            _comando.Parameters.AddWithValue("@pdni", codigo);
            _comando.Parameters.AddWithValue("@pfecha", fecha);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public int actualizar_autorizacion(string formulario, string id_linea, string estado)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_autorizacion");
            _comando.Parameters.AddWithValue("@pformulario", formulario);
            _comando.Parameters.AddWithValue("@pid_linea", id_linea);
            _comando.Parameters.AddWithValue("@pestado", estado);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public DataTable verificar_autorizacion(string formulario, string id_linea)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_verificar_autorizacion");
            _comando.Parameters.AddWithValue("@pformulario", formulario);
            _comando.Parameters.AddWithValue("@pid_linea", id_linea);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable cargar_grilla_ingmasivo(string _dni, string _fecha)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_lstPerAsign_tarfec");
            _comando.Parameters.AddWithValue("@pdni", _dni);
            _comando.Parameters.AddWithValue("@pfecha", _fecha);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable listar_grilla_tareo_estados(string anio_estados, string semana_estados)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_lstTareosEstado_anioSem");
            _comando.Parameters.AddWithValue("@panio", anio_estados);
            _comando.Parameters.AddWithValue("@psemana", semana_estados);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable cargar_grilla_segui(string sql1, string sql2, string sql3, string sql4)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_lstTareo_Seguimiento");
            _comando.Parameters.AddWithValue("@psql1", sql1);
            _comando.Parameters.AddWithValue("@psql2", sql2);
            _comando.Parameters.AddWithValue("@psql3", sql3);
            _comando.Parameters.AddWithValue("@psql4", sql4);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable cargar_responsables(string anio, string semana, string documento)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_lstResponTareo");
            _comando.Parameters.AddWithValue("@pAnio", anio);
            _comando.Parameters.AddWithValue("@pSemana", semana);
            _comando.Parameters.AddWithValue("@pDni", documento);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable cargar_responsables_asign(string documento)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_lstResponAsign");
            _comando.Parameters.AddWithValue("@pDni", documento);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable cargar_grilla_tareadores(string opcion)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_lstTareador_config");
            _comando.Parameters.AddWithValue("@pOpcion", opcion);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

  
        public int actualizar_nivel_acceso(string dni, string nacceso)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_actualizarNAcc");
            _comando.Parameters.AddWithValue("@pdni", dni);
            _comando.Parameters.AddWithValue("@pacceso", nacceso);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public DataTable Listar_Personal_Activo()
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_lstPersonalTotal");
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable listar_validacion_usuario(string opcion)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_lstValidacionUsuario");
            _comando.Parameters.AddWithValue("@pOpcion", opcion);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public int actualizar_configuracion(string usuario, string opcion, string estado)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_actualizarValidacion");
            _comando.Parameters.AddWithValue("@pUsuario", usuario);
            _comando.Parameters.AddWithValue("@pOpcion", opcion);
            _comando.Parameters.AddWithValue("@pEstado", estado);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int actualizar_configuracion_todos(string opcion, string estado)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_actualizarValidacion_todos");
            _comando.Parameters.AddWithValue("@pOpcion", opcion);
            _comando.Parameters.AddWithValue("@pEstado", estado);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public DataTable listar_configuracion_horas()
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_lstConfiguracionHoras");
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable listar_configuracion_horas_defecto()
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_lstConfigHoras_Defecto");
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public int actualizar_configuracion_horas(string hn_n, string he_n, string ht_n, string hns_n, string hes_n, string hnsa_n, string hesa_n, string hn_f, string he_f, string ht_f, string hns_f, string hes_f, string hnsa_f, string hesa_f)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_ActualizarConfigHoras");
            _comando.Parameters.AddWithValue("@pHNn", hn_n);
            _comando.Parameters.AddWithValue("@pHEn", he_n);
            _comando.Parameters.AddWithValue("@pHTn", ht_n);
            _comando.Parameters.AddWithValue("@pHNSn", hns_n);
            _comando.Parameters.AddWithValue("@pHESn", hes_n);
            _comando.Parameters.AddWithValue("@pHNSAn", hnsa_n);
            _comando.Parameters.AddWithValue("@pHESAn", hesa_n);
            _comando.Parameters.AddWithValue("@pHNf", hn_f);
            _comando.Parameters.AddWithValue("@pHEf", he_f);
            _comando.Parameters.AddWithValue("@pHTf", ht_f);
            _comando.Parameters.AddWithValue("@pHNSf", hns_f);
            _comando.Parameters.AddWithValue("@pHESf", hes_f);
            _comando.Parameters.AddWithValue("@pHNSAf", hnsa_f);
            _comando.Parameters.AddWithValue("@pHESAf", hesa_f);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public DataTable verificar_autorizacion_usuario(string usuario, string validacion)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_verificar_validacion");
            _comando.Parameters.AddWithValue("@pUsuario", usuario);
            _comando.Parameters.AddWithValue("@pValidacion", validacion);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable verificar_semana_cerrada(string anio, string semana)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_verificar_semCerrada");
            _comando.Parameters.AddWithValue("@pAnio", anio);
            _comando.Parameters.AddWithValue("@pSemana", semana);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public int insertar_validaciones_tareador(string tareador, string opcion)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_tareo_insdel_validac_tareador");
            _comando.Parameters.AddWithValue("@pTareador", tareador);
            _comando.Parameters.AddWithValue("@pOpcion", opcion);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }


        #endregion


        #region Fondo Fijo y Rendiciones

        public DataTable Listar_Solicitud_Dinero(string pproyecto)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_OOSD_Buscar");
            _comando.Parameters.AddWithValue("@pcodigo", "");
            //_comando.Parameters.AddWithValue("@pfecha", "");
            _comando.Parameters.AddWithValue("@pestado", "");
            _comando.Parameters.AddWithValue("@pcodProy", pproyecto);
            _comando.Parameters.AddWithValue("@ppaginaactual", 1);
            _comando.Parameters.AddWithValue("@pregistroPorPagina", 1000);
            _comando.Parameters.AddWithValue("@pcolumnaordenada", "codigo");
            _comando.Parameters.AddWithValue("@ptipoorden", "desc");
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable listar_combo_proyectos(string opcion)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_OOPR_Listar");
            _comando.Parameters.AddWithValue("@pOpcion", opcion);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }
        
        public DataTable VS_Listar_Proyectos(string opcion)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_OOPR_Listar");
            _comando.Parameters.AddWithValue("@pOpcion", opcion);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable VS_Listar_Parametro(string parametro, string opcion)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_Parametro_Listar");
            _comando.Parameters.AddWithValue("@pParametro", parametro);
            _comando.Parameters.AddWithValue("@pOpcion", opcion);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable VS_Listar_Usuarios(string opcion)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_OOUS_Listar");
            _comando.Parameters.AddWithValue("@pOpcion", opcion);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable VS_Listar_Rendiciones(string pcodigo, string pfecha, string pestado, string pcodProy)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_OORE_BuscarSolicitudesDinero");
            _comando.Parameters.AddWithValue("@pcodigo", pcodigo);
            _comando.Parameters.AddWithValue("@pfecha", pfecha);
            _comando.Parameters.AddWithValue("@pestado", pestado);
            _comando.Parameters.AddWithValue("@pcodProy", pcodProy);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable VS_Listar_SD_AsigRendiciones(string proyecto)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_ListarSD_AsignRendicion");
            _comando.Parameters.AddWithValue("@pcodProy", proyecto);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable VS_Listar_CajaChica(string proyecto)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_OOCC_Buscar");
            _comando.Parameters.AddWithValue("@pcodProy", proyecto);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }
        
        public DataTable Listar_CajaChica_Gastos(string parametro)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_OOGC_Listar_Gastos");
            //SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_OOGC_DetallePorCajaChica");
            _comando.Parameters.AddWithValue("@pdocEntry", parametro);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public int VS_modificar_proyecto(string pProyecto, string pProyectoDesc, string pOT, string pEstado, string pAlmacen, string pAlmacenDesc, string pUbicacion, string pUbicacionDesc, string pCuenta, string pCuentaDesc, string pCuentaRendicion, string pCuentaRendicionDesc, string pTotalCaja, string pMoneda, string pComentario, string pUsuario, string pidCC, string pcorrelativoCC)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_OOPR_RegMod");
            _comando.Parameters.AddWithValue("@pcodProy", pProyecto);
            _comando.Parameters.AddWithValue("@pnomProy", pProyectoDesc);
            _comando.Parameters.AddWithValue("@pnroOT", pOT);
            _comando.Parameters.AddWithValue("@pestado", pEstado);
            _comando.Parameters.AddWithValue("@pcodAlm", pAlmacen);
            _comando.Parameters.AddWithValue("@pnomAlm", pAlmacenDesc);
            _comando.Parameters.AddWithValue("@pidUbicacion", pUbicacion);
            _comando.Parameters.AddWithValue("@pnomUbicacion", pUbicacionDesc);
            _comando.Parameters.AddWithValue("@pcodCuenta", pCuenta);
            _comando.Parameters.AddWithValue("@pnomCuenta", pCuentaDesc);
            _comando.Parameters.AddWithValue("@pcodCuentaRendicion", pCuentaRendicion);
            _comando.Parameters.AddWithValue("@pnomCuentaRendicion", pCuentaRendicionDesc);
            _comando.Parameters.AddWithValue("@ptotalCaja", pTotalCaja);
            _comando.Parameters.AddWithValue("@pmoneda", pMoneda);
            _comando.Parameters.AddWithValue("@pcodUsu", pUsuario);
            _comando.Parameters.AddWithValue("@pidCC", pidCC);
            _comando.Parameters.AddWithValue("@pcorrelativoCC", pcorrelativoCC);
            _comando.Parameters.AddWithValue("@pcomentarios", pComentario);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public DataTable VS_Listar_Ubicaciones(string palmacen)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_Ubicaciones_Listar");
            _comando.Parameters.AddWithValue("@pAlmacen", palmacen);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public int VS_RegMod_Usuario(string pcodigo, string pnombre, string pcorreo, string pestado)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_OOUS_RegMod");
            _comando.Parameters.AddWithValue("@pcodUsu", pcodigo);
            _comando.Parameters.AddWithValue("@pnomUsu", pnombre);
            _comando.Parameters.AddWithValue("@pcorreo", pcorreo);
            _comando.Parameters.AddWithValue("@pestado", pestado);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int VS_Asignar_Proyecto_Usu(string pusuario, string pproyecto, string prol, string pestado)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_OOUS_RegModProyectoRol");
            _comando.Parameters.AddWithValue("@pcodUsu", pusuario);
            _comando.Parameters.AddWithValue("@pcodProy", pproyecto);
            _comando.Parameters.AddWithValue("@pidRol", prol);
            _comando.Parameters.AddWithValue("@pestado", pestado);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int VS_SD_RegMod(string pcodigo, DateTime pfecha, string pmonto, string pmoneda, string pmotivo, string pmotivoextra, string pestado, string pusuario, string pproyecto, string pcomentario, string pempleadocod, string pempleadodesc)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_OOSD_RegMod");
            _comando.Parameters.AddWithValue("@pcodigo", pcodigo);
            _comando.Parameters.AddWithValue("@pfecha", pfecha);
            _comando.Parameters.AddWithValue("@pmonto", pmonto);
            _comando.Parameters.AddWithValue("@pmoneda", pmoneda);
            _comando.Parameters.AddWithValue("@pmotivo", pmotivo);
            _comando.Parameters.AddWithValue("@pmotAdicional", pmotivoextra);
            _comando.Parameters.AddWithValue("@pestado", pestado);
            _comando.Parameters.AddWithValue("@pcodUsu", pusuario);
            _comando.Parameters.AddWithValue("@pcodProy", pproyecto);
            _comando.Parameters.AddWithValue("@pcomentarios", pcomentario);
            _comando.Parameters.AddWithValue("@pcodEmp", pempleadocod);
            _comando.Parameters.AddWithValue("@pnomEmp", pempleadodesc);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public DataTable VS_Listar_Gasto_detalle(string pdocEntry)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_OOGD_BuscarGastosDetallePorGasto");
            _comando.Parameters.AddWithValue("@pdocEntry", pdocEntry);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public int VS_SD_RegMod(int pdocEntry, int plineId, string pcodArt, string pdesArt, string pundMed, string pcant, string pprecio, string pdocEntryGC, string pCodProy, string pnroOT, int pfilaafectadas)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_OOGD_RegMod");
            _comando.Parameters.AddWithValue("@pdocEntry", pdocEntry);
            _comando.Parameters.AddWithValue("@plineId", plineId);
            _comando.Parameters.AddWithValue("@pcodArt", pcodArt);
            _comando.Parameters.AddWithValue("@pdesArt", pdesArt);
            _comando.Parameters.AddWithValue("@pundMed", pundMed);
            _comando.Parameters.AddWithValue("@pcant", pcant);
            _comando.Parameters.AddWithValue("@pprecio", pprecio);
            _comando.Parameters.AddWithValue("@pdocEntryGC", pdocEntryGC);
            _comando.Parameters.AddWithValue("@pCodProy", pCodProy);
            _comando.Parameters.AddWithValue("@pnroOT", pnroOT);
            _comando.Parameters.AddWithValue("@pfilaafectadas", pfilaafectadas);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int VS_OOGD_Eliminar(int pdocEntry)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_OOGD_Eliminar");
            _comando.Parameters.AddWithValue("@pdocEntry", pdocEntry);
            _comando.Parameters.AddWithValue("@pfilaafectadas", 0);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int VS_OOGD_Eliminar(string pdocEntry, string pnroCC, string pnroOT, decimal ptotalCaja, string pmoneda, DateTime pfechaCierre, string pestado, string pcodUsu, string pcodProy, string pcomentarios, int pfilaafectadas)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_OOCC_RegMod");
            _comando.Parameters.AddWithValue("@pdocEntry", pdocEntry);
            _comando.Parameters.AddWithValue("@pnroCC", pnroCC);
            _comando.Parameters.AddWithValue("@pnroOT", pnroOT);
            _comando.Parameters.AddWithValue("@ptotalCaja", ptotalCaja);
            _comando.Parameters.AddWithValue("@pmoneda", pmoneda);
            _comando.Parameters.AddWithValue("@pfechaCierre", pfechaCierre);
            _comando.Parameters.AddWithValue("@pestado", pestado);
            _comando.Parameters.AddWithValue("@pcodUsu", pcodUsu);
            _comando.Parameters.AddWithValue("@pcodProy", pcodProy);
            _comando.Parameters.AddWithValue("@pcomentarios", pcomentarios);
            _comando.Parameters.AddWithValue("@pfilaafectadas", pfilaafectadas);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int VS_OOGC_Eliminar(int pdocEntry, int pfilasAfectadas)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_OOGC_Eliminar");
            _comando.Parameters.AddWithValue("@pdocEntry", pdocEntry);
            _comando.Parameters.AddWithValue("@pfilaafectadas", pfilasAfectadas);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int VS_OOGC_RegMod(int pdocEntry, string ptipGasto, string pdesGasto, string pcodProv, string pnomProv, string ptipDocProv, string pnroDocProv, string ptipDoc, string pserDoc, string pcorDoc, decimal pmonGasto, DateTime pfecha, 
                                    string pmoneda, int ptcespecial, int pmonImpGasto, int pmonDocGasto, string pnroRen, string pnroCC, string pcodImp, string pnomImp, decimal pcantImp, string pnomComentario, string pcodEmp, string pnomEmp, 
                                    string pnumPla, string pCodProy, string pnroOT, int pfilaafectadas)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_OOGC_RegMod");
            _comando.Parameters.AddWithValue("@pdocEntry", pdocEntry);
            _comando.Parameters.AddWithValue("@ptipGasto", ptipGasto);
            _comando.Parameters.AddWithValue("@pdesGasto", pdesGasto);
            _comando.Parameters.AddWithValue("@pcodProv", pcodProv);
            _comando.Parameters.AddWithValue("@pnomProv", pnomProv);
            _comando.Parameters.AddWithValue("@ptipDocProv", ptipDocProv);
            _comando.Parameters.AddWithValue("@pnroDocProv", pnroDocProv);
            _comando.Parameters.AddWithValue("@ptipDoc", ptipDoc);
            _comando.Parameters.AddWithValue("@pserDoc", pserDoc);
            _comando.Parameters.AddWithValue("@pcorDoc", pcorDoc);
            _comando.Parameters.AddWithValue("@pmonGasto", pmonGasto);
            _comando.Parameters.AddWithValue("@pfecha", pfecha);
            _comando.Parameters.AddWithValue("@pmoneda", pmoneda);
            _comando.Parameters.AddWithValue("@ptcespecial", ptcespecial);
            _comando.Parameters.AddWithValue("@pmonImpGasto", pmonImpGasto);
            _comando.Parameters.AddWithValue("@pmonDocGasto", pmonDocGasto);
            _comando.Parameters.AddWithValue("@pnroRen", pnroRen);
            _comando.Parameters.AddWithValue("@pnroCC", pnroCC);
            _comando.Parameters.AddWithValue("@pcodImp", pcodImp);
            _comando.Parameters.AddWithValue("@pnomImp", pnomImp);
            _comando.Parameters.AddWithValue("@pcantImp", pcantImp);
            _comando.Parameters.AddWithValue("@pnomComentario", pnomComentario);
            _comando.Parameters.AddWithValue("@pcodEmp", pcodEmp);
            _comando.Parameters.AddWithValue("@pnomEmp", pnomEmp);
            _comando.Parameters.AddWithValue("@pnumPla", pnumPla);
            _comando.Parameters.AddWithValue("@pCodProy", pCodProy);
            _comando.Parameters.AddWithValue("@pnroOT", pnroOT);
            _comando.Parameters.AddWithValue("@pfilaafectadas", pfilaafectadas);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public DataTable VS_Listar_Gasto_contabilizar(string pdocEntry)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_OOGC_BuscarGastosPorCajaChica");
            _comando.Parameters.AddWithValue("@pdocEntry", pdocEntry);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public int VS_OOGC_ActualizarFechaContabilizacionPorCajaChica(int pdocEntry, int pdocEntryCC, DateTime pfechaContabilizacion, int pfilaafectadas)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("VS_OOGC_ActualizarFechaContabilizacionPorCajaChica");
            _comando.Parameters.AddWithValue("@pdocEntry", pdocEntry);
            _comando.Parameters.AddWithValue("@pdocEntryCC", pdocEntryCC);
            _comando.Parameters.AddWithValue("@pfechaContabilizacion", pfechaContabilizacion);
            _comando.Parameters.AddWithValue("@pfilaafectadas", pfilaafectadas);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        #endregion

        public DataTable impresion_transmital(string transmital)
        {
            MySqlCommand _comando = MetodosDatos.CrearComando_IMERP("spImprimirTransmital");
            _comando.Parameters.AddWithValue("transmital", transmital);
            return MetodosDatos.EjecutarComandoSelect_IMERP(_comando);
        }

        public DataTable impresion_transmitalTM(string idtra)
        {
            MySqlCommand _comando = MetodosDatos.CrearComando_IMERP("spImprimirTransmitalTM");
            _comando.Parameters.AddWithValue("idtra", idtra);
            return MetodosDatos.EjecutarComandoSelect_IMERP(_comando);
        }

        public DataTable Cargar_personal()
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_listar_Personal");
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public DataTable Cargar_asistencia_rango()
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            _comando.CommandText = "SELECT DNI      ,NOMBRE      ,AREA      ,CARGO      ,TIPOTRAB      ,OT      ,DIA_01      ,DIA_02      ,DIA_03      ,DIA_04      ,DIA_05      ,DIA_06      ,DIA_07      ,DIA_08      ,DIA_09      ,DIA_10      ,DIA_11      ,DIA_12      ,DIA_13      ,DIA_14      ,DIA_15      ,DIA_16      ,DIA_17      ,DIA_18      ,DIA_19      ,DIA_20      ,DIA_21      ,DIA_22      ,DIA_23      ,DIA_24      ,DIA_25      ,DIA_26      ,DIA_27      ,DIA_28      ,DIA_29      ,DIA_30      ,DIA_31  FROM temp_reporte_asistencia";            
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        

        public DataTable listar_marcaciones(string fechaDesde, string fechaHasta)
        {
            SqlCommand _comando = MetodosDatos.CrearComando_sql();
            string sql = "select	RIGHT('00000000'+(T1.Badgenumber),8) dni,  CONVERT(char,T0.checktime,103) fecha , LEFT(CONVERT(VARCHAR, MIN(T0.checktime), 108),5) + ' - ' + LEFT(CONVERT(VARCHAR, MAX(T0.checktime), 108),5) marcacion";
                   sql = sql + "	from	[10.0.0.20\\CONASIST].[att2000SQL].[dbo].CHECKINOUT T0    INNER JOIN [10.0.0.20\\CONASIST].[att2000SQL].[dbo].USERINFO T1 ON T0.USERID = T1.USERID  INNER JOIN [10.0.0.20\\STARSOFT].[IMECON].[dbo].[TRABAJADORES] T2 ON RIGHT('00000000'+T1.Badgenumber,8) = T2.DOCIDEN";
                   sql = sql + "	where	T0.checktime BETWEEN CONVERT (DATE, '"+ fechaDesde +"', 103) and DATEADD(day, 1, CONVERT (DATE, '"+ fechaHasta +"', 103))  group by T1.Badgenumber, CONVERT(char,T0.checktime,103)";
            _comando.CommandText = sql;
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public int actualizar_anexo(string pDni, string pAnexo, string pRpc, string pOtro, string pOpc)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_Actualizar_Anexo");
            _comando.Parameters.AddWithValue("@pDni", pDni);
            _comando.Parameters.AddWithValue("@pAnexo", pAnexo);
            _comando.Parameters.AddWithValue("@pRpc", pRpc);
            _comando.Parameters.AddWithValue("@pOtro", pOtro);
            _comando.Parameters.AddWithValue("@pOpc", pOpc);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public DataTable buscar_anexo(string pDni)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_lstBuscar_Anexo");
            _comando.Parameters.AddWithValue("@pDni", pDni);
            return MetodosDatos.EjecutarComandoSelect_sql(_comando);
        }

        public int nuevo_registro_anexo(string pDni, string pAnexo, string pRpc, string pOtro)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_Insertar_Anexo");
            _comando.Parameters.AddWithValue("@pDni", pDni);
            _comando.Parameters.AddWithValue("@pAnexo", pAnexo);
            _comando.Parameters.AddWithValue("@pRpc", pRpc);
            _comando.Parameters.AddWithValue("@pOtro", pOtro);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int suprimir_registro_anexo(string pDni, string pOpc)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_suprimir_Anexo");
            _comando.Parameters.AddWithValue("@pDni", pDni);
            _comando.Parameters.AddWithValue("@pOpc", pOpc);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }

        public int nuevo_registro_anexo_nom(string pNombre, string pAnexo, string pRpc, string pOtro)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc_sql("sp_Insertar_Anexo_Nom");
            _comando.Parameters.AddWithValue("@pNombre", pNombre);
            _comando.Parameters.AddWithValue("@pAnexo", pAnexo);
            _comando.Parameters.AddWithValue("@pRpc", pRpc);
            _comando.Parameters.AddWithValue("@pOtro", pOtro);
            return MetodosDatos.EjecutarComandoInsert_sql(_comando);
        }
    }
}

