using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;
using Negocio;


namespace Negocio
{
    public class AccesoLogica
    {
      
        #region CONSULTAR S10
       
        
        public static DataTable listar_presupuestos()
        {
            return AccesoDatos.listar_presupuestos();
        }

        public static DataTable consultar_posiciones(string CodPresupuesto)
        {

            return AccesoDatos.consultar_posiciones(CodPresupuesto);

        }

        #endregion 

        #region Consultar MISAP

        public static DataTable ejecutar_sp_pdt(string sp, string periodo)
        {

            return AccesoDatos.ejecutar_sp_pdt(sp, periodo);

        }

        public static DataTable listar_cuentas()
        {
            return AccesoDatos.consultar_cuentas();
        }

        public static DataTable listar_bancos()
        {
            return AccesoDatos.listar_bancos();
        }

        public static DataTable listar_columnas_eb(string tipo, string CodigoBanco, string TipoColumna)
        {
            return AccesoDatos.listar_columnas_eb(tipo, CodigoBanco, TipoColumna);
        }
      
        

        public static DataTable obtener_codigo_costo()
        {

            return AccesoDatos.obtener_codigo_costo();

        }

        public static DataTable obtener_clave(string cdg_usr)
        {

            return AccesoDatos.obtener_clave(cdg_usr);

        }

        public static DataTable obtener_usuario(string cdg_usr)
        {

            return AccesoDatos.obtener_usuario(cdg_usr);

        }

        public static DataTable obtener_usuario_is(string cdg_usr)
        {

            return AccesoDatos.obtener_usuario_is(cdg_usr);

        }

        public static DataTable obtener_usuario_SAP(string cdg_usr)
        {

            return AccesoDatos.obtener_usuario_SAP(cdg_usr);

        }

        public static DataTable obtener_perfil()
        {

            return AccesoDatos.obtener_perfil();

        }

        public static DataTable obtener_perfil_mcop()
        {

            return AccesoDatos.obtener_perfil_mcop();

        }

        public static DataTable listar_usuario(int swt_usr, int swt_usr_2, string operacion, string tipo)
        {

            return AccesoDatos.listar_usuario(swt_usr, swt_usr_2, operacion, tipo);

        }

        public static DataTable listar_extractos(string cuenta, int id, int StatemNo)
        {

            return AccesoDatos.listar_extractos(cuenta, id, StatemNo);

        }

        public static DataTable listar_solicitudes_alta(string estado, string tipo, int id_solicitud)
        {

            return AccesoDatos.listar_solicitudes_alta(estado, tipo, id_solicitud);

        }


        public static DataTable listar_codigo_costo(string swt_estado, string swt_estado_2)
        {

            return AccesoDatos.listar_codigo_costo(swt_estado, swt_estado_2);

        }

        public static DataTable obtener_id_session(string cdg_usr)
        {

            return AccesoDatos.obtener_id_session(cdg_usr);

        }

        public static DataTable listar_menu(string swt_tipo, int swt_estado)
        {

            return AccesoDatos.listar_menu(swt_tipo, swt_estado);

        }

        public static DataTable consultar_m_prd_menu(string name)
        {

            return AccesoDatos.consultar_m_prd_menu(name);

        }

        public static DataTable listar_menu_d(string swt_tipo, int parent_id, int swt_estado)
        {

            return AccesoDatos.listar_menu_d(swt_tipo, parent_id, swt_estado);

        }

        public static DataTable consultar_d_prd_marca(string num_ord, string swt_estado, string swt_estado_2, string nro_op)
        {

            return AccesoDatos.consultar_d_prd_marca(num_ord, swt_estado, swt_estado_2, nro_op);

        }

        public static DataTable listar_documentos()
        {

            return AccesoDatos.listar_documentos();

        }

        public static DataTable listar_maestro_plantilla()
        {

            return AccesoDatos.listar_maestro_plantilla();

        }

        public static DataTable listar_tipo_plantilla()
        {

            return AccesoDatos.listar_tipo_plantilla();

        }

        public static DataTable listar_proceso(string cdg_tipo_planilla)
        {

            return AccesoDatos.listar_proceso(cdg_tipo_planilla);

        }

        public static DataTable listar_plantilla(string proceso)
        {

            return AccesoDatos.listar_plantilla(proceso);

        }

        public static DataTable consultar_plantilla(int id_plantilla)
        {

            return AccesoDatos.consultar_plantilla(id_plantilla);

        }

        public static DataTable consultar_log(string nro_doc)
        {

            return AccesoDatos.consultar_log(nro_doc);

        }


        public static DataTable consultar_FRM1(string formulario, string grilla, string usuario, int GrillaId)
        {

            return AccesoDatos.consultar_FRM1(formulario, grilla, usuario, GrillaId);

        }


        public static DataTable consultar_detalle_ped_misap(string tipo_pedido, string num_ped, string cdg_origen)
        {

            return AccesoDatos.consultar_detalle_ped_misap(tipo_pedido, num_ped, cdg_origen);

        }

        public static DataTable listar_facturas_provision(string tipo, string proveedor)
        {

            return AccesoDatos.listar_facturas_provision(tipo, proveedor);

        }

        public static DataTable listar_cheques(string tipo, string proveedor)
        {

            return AccesoDatos.listar_cheques(tipo, proveedor);

        }

        public static DataTable listar_documentos_cheque(string tipo, int nro_cheque, int nro_pago)
        {

            return AccesoDatos.listar_documentos_cheque(tipo, nro_cheque,  nro_pago);

        }

        public static DataTable listar_pedidos_provision(string tipo, int nro_factura)
        {

            return AccesoDatos.listar_pedidos_provision(tipo, nro_factura);

        }

        public static DataTable listar_pedidos_misap(string est, string Anio, string usr, string perfil)
        {

            return AccesoDatos.listar_pedidos_misap(est, Anio, usr, perfil);

        }

        public static DataTable listar_anexo()
        {

            return AccesoDatos.listar_anexo();

        }

        public static DataTable listar_equivalencia()
        {

            return AccesoDatos.listar_equivalencia();

        }

        public static DataTable listar_requemiento_seguimiento(string tipo)
        {

            return AccesoDatos.listar_requemiento_seguimiento(tipo);

        }

        public static DataTable informe_seguimiento_aceros(string tipo, string ot)
        {

            return AccesoDatos.informe_seguimiento_aceros(tipo, ot);

        }

        public static DataTable informe_seguimiento_contratos(int idreg, string operacion, string tipo)
        {

            return AccesoDatos.informe_seguimiento_contratos( idreg,  operacion,  tipo);

        }

        public static DataTable informe_inventario_IPs(int idreg, string operacion, string tipo)
        {

            return AccesoDatos.informe_inventario_IPs(idreg, operacion, tipo);

        }

        public static DataTable informe_seguimiento_cambios_apl(int idreg, string operacion, string tipo)
        {

            return AccesoDatos.informe_seguimiento_cambios_apl(idreg, operacion, tipo);

        }

        public static DataTable consultar_CTR1(int idreg, string operacion, string tipo, string PrcCode)
        {

            return AccesoDatos.consultar_CTR1(idreg, operacion, tipo, PrcCode);

        }

        public static DataTable informe_seguimiento_aceros_det(string tipo, string ot)
        {

            return AccesoDatos.informe_seguimiento_aceros_det(tipo, ot);

        }

        public static DataTable listar_saldo_seguimiento(string ot)
        {

            return AccesoDatos.listar_saldo_seguimiento(ot);

        }

        public static DataTable listar_costos(string mat, string ot, string dDesde, string dHasta, string tip)
        {

            return AccesoDatos.listar_costos(mat, ot, dDesde, dHasta,tip);

        }

        public static DataTable listar_proveedores_provision(string tipo)
        {

            return AccesoDatos.listar_proveedores_provision(tipo);

        }

        public static DataTable listar_proveedores_cheque(string tipo)
        {

            return AccesoDatos.listar_proveedores_cheque(tipo);

        }

        

        public static DataTable listar_pca(int pca, string dni, string apellidos, string nombres, int id_area, int id_perfil, string id_usuario, int id_movimiento, string fecha, string autorizado, string swt_estado, string operacion, string usr_crea, string fec_crea,
                                                string terminal_crea, string operacion_mod, string usr_mod, string fec_mod, string terminal_mod, string formulario, string estado_registro)
        {
            return AccesoDatos.listar_pca(pca, dni, apellidos, nombres, id_area, id_perfil, id_usuario, id_movimiento, fecha, autorizado, swt_estado, operacion, usr_crea, fec_crea, terminal_crea, operacion_mod,
                                                                usr_mod, fec_mod, terminal_mod, formulario, estado_registro);
        }

        public static DataTable listar_pca_d(int pca, int linea, string id_usuario_g, int id_servicio, string contraseña, string swt_estado, string operacion, string usr_crea, string fec_crea,
                                                string terminal_crea, string operacion_mod, string usr_mod, string fec_mod, string terminal_mod, string formulario, string estado_registro)
        {
            return AccesoDatos.listar_pca_d(pca, linea, id_usuario_g, id_servicio, contraseña, swt_estado, operacion, usr_crea, fec_crea, terminal_crea, operacion_mod,
                                                                usr_mod, fec_mod, terminal_mod, formulario, estado_registro);
        }

        public static DataTable listar_servicios_pca()
        {

            return AccesoDatos.listar_servicios_pca();

        }


        public static DataTable obtener_nro_pca()
        {

            return AccesoDatos.obtener_nro_pca();
        }

        public static DataTable obtener_nro_solicitud_alta()
        {

            return AccesoDatos.obtener_nro_solicitud_alta();
        }

        public static DataTable listar_area()
        {

            return AccesoDatos.listar_area();

        }

        public static DataTable listar_ot(int id_area)
        {

            return AccesoDatos.listar_ot(id_area);

        }

        public static DataTable listar_ot_sap_2(string parametro, string tipo)
        {

            return AccesoDatos.listar_ot_sap_2(parametro, tipo);

        }

        public static DataTable consultar_estado_ot(string parametro, string tipo)
        {

            return AccesoDatos.consultar_estado_ot(parametro, tipo);

        }

        public static DataTable listar_movimiento()
        {

            return AccesoDatos.listar_movimiento();

        }

        public static DataTable listar_perfil(int id_area)
        {

            return AccesoDatos.listar_perfil(id_area);

        }

        public static DataTable obtener_personal(string dni, string sociedad)
        {

            return AccesoDatos.obtener_personal(dni,sociedad);
        }

        public static DataTable obtener_personal_pca(string dni)
        {

            return AccesoDatos.obtener_personal_pca(dni);
        }


        public static DataTable listar_parametros_usuario(string UserId, int GrillaId)
        {

            return AccesoDatos.listar_parametros_usuario(UserId, GrillaId);

        }

        public static DataTable listar_stock(string ot)
        {

            return AccesoDatos.listar_stock(ot);

        }

        public static DataTable listar_empleados(string tipo, string OT, string anio, string desde, string hasta)
        {

            return AccesoDatos.listar_empleados(tipo, OT, anio,desde, hasta);

        }

        public static DataTable listar_pedidos_filtro(string requerimiento,
  string solicitante,
  string ot,
  string responsable,
  string estado,
  string fecha_crea,
  string fecha_requerida,
  string usuario,
  string perfil,
  string tipo,
string anio)
        {

            return AccesoDatos.listar_pedidos_filtro(requerimiento,
   solicitante,
   ot,
   responsable,
   estado,
   fecha_crea,
   fecha_requerida,
   usuario,
   perfil,
   tipo,
 anio);

        }

        public static DataTable listar_responsable_misap(string num_ord)
        {

            return AccesoDatos.listar_responsable_misap(num_ord);

        }

        public static DataTable listar_servicios(string est, string Anio, string usuario,string perfil)
        {

            return AccesoDatos.listar_servicios(est, Anio, usuario,perfil);

        }

        public static DataTable listar_activos(string est, string Anio, string usuario, string perfil)
        {

            return AccesoDatos.listar_activos(est, Anio, usuario, perfil);

        }

        public static DataTable consultar_empelado(int empID)
        {

            return AccesoDatos.consultar_empelado(empID);

        }


        public static DataTable listar_combo_filtro(string formulario, string combo, string est, string Anio, string usuario, string perfil, string tipo)
        {

            return AccesoDatos.listar_combo_filtro(formulario,  combo,  est,  Anio,  usuario, perfil,  tipo);

        }

        public static DataTable listar_reporte_pdt(string tipo, int DocEntry)
        {

            return AccesoDatos.listar_reporte_pdt(tipo, DocEntry);

        }

        public static DataTable listar_periodo()
        {

            return AccesoDatos.listar_periodo();

        }

        public static DataTable listar_asientos_planillas(int crono, string seccion, string cod_provi)
        {

            return AccesoDatos.listar_asientos_planillas(crono, seccion, cod_provi);

        }

        public static DataTable consultar_partidas_s10(string CodPresupuesto)
        {

            return AccesoDatos.consultar_partidas_s10(CodPresupuesto);

        }


        public static DataTable consultar_ACT1(string IdActivo)
        {

            return AccesoDatos.consultar_ACT1(IdActivo);

        }

        public static DataTable consultar_permisos_mnu(string cdg_perf)
        {

            return AccesoDatos.consultar_permisos_mnu(cdg_perf);

        }

        public static DataTable consultar_OCAP(string PrjCode, string PrcCode, string CodPresupuesto, int CodFase, string Fase, string FechaInicio, int Duracion, decimal Avance, decimal Peso, string operacion, string tipo)
        {

            return AccesoDatos.consultar_OCAP(PrjCode, PrcCode, CodPresupuesto, CodFase, Fase, FechaInicio, Duracion, Avance, Peso, operacion,tipo);

        }
        public static DataTable consultar_OACT(string IdActivo, string operacion, string tipo)
        {

            return AccesoDatos.consultar_OACT(IdActivo , operacion, tipo);

        }

        public static DataTable consultar_OPCE(string idreg, string operacion, string tipo)
        {

            return AccesoDatos.consultar_OPCE(idreg, operacion, tipo);

        }

        public static DataTable consultar_OITM(string ItemCode, string operacion, string tipo)
        {

            return AccesoDatos.consultar_OITM(ItemCode, operacion, tipo);

        }

        public static DataTable consultar_OCRD(string TipoSocio, string CardCode, string operacion, string tipo)
        {

            return AccesoDatos.consultar_OCRD(TipoSocio, CardCode, operacion, tipo);

        }

        public static DataTable consultar_OPRC(string PrcCode, string operacion, string tipo)
        {

            return AccesoDatos.consultar_OPRC(PrcCode, operacion, tipo);

        }

        public static DataTable consultar_BPVSLN_SUNAT_T10(string Code, string operacion, string tipo)
        {

            return AccesoDatos.consultar_BPVSLN_SUNAT_T10(Code, operacion, tipo);

        }

        public static DataTable consultar_OTDC(int idreg, string operacion, string tipo)
        {

            return AccesoDatos.consultar_OTDC(idreg, operacion, tipo);

        }

        public static DataTable consultar_OAIN(int DocEntry, string operacion, string tipo)
        {

            return AccesoDatos.consultar_OAIN(DocEntry, operacion, tipo);

        }


        public static DataTable consultar_OCTE(int ComponenteId, string operacion, string tipo)
        {

            return AccesoDatos.consultar_OCTE(ComponenteId, operacion, tipo);

        }

        public static DataTable consultar_OERR(int Code)
        {

            return AccesoDatos.consultar_OERR(Code);

        }

        public static DataTable consultar_TDC1(int NroLote, string operacion, string tipo)
        {

            return AccesoDatos.consultar_TDC1(NroLote, operacion, tipo);

        }

        public static DataTable consultar_OPCA(int id_pca, string operacion, string tipo)
        {

            return AccesoDatos.consultar_OPCA(id_pca, operacion, tipo);

        }

        public static DataTable consultar_OANX(int AbsEntry, string operacion, string tipo)
        {

            return AccesoDatos.consultar_OANX(AbsEntry, operacion, tipo);

        }

        public static DataTable consultar_OCRN(string CurrCode, string operacion, string tipo)
        {

            return AccesoDatos.consultar_OCRN(CurrCode, operacion, tipo);

        }

        public static DataTable consultar_paSeguiMat(string codigo, string ot)
        {

            return AccesoDatos.consultar_paSeguiMat(codigo, ot);

        }

        public static DataTable consultar_ACT2(int TipoID, string operacion, string tipo)
        {

            return AccesoDatos.consultar_ACT2(TipoID, operacion, tipo);

        }

        #endregion

        #region Mantenimiento

   

        public int mantenimiento_OUSR
     (
         string cdg_usr, string des_usr, int swt_usr, string ema_usr, string dni, string cdg_perf, string clave , int swt_aprobacion,
         string usr_crea, string fec_crea, string terminal_crea, string usr_modi, string fec_modi, string terminal_modi, string operacion, string formulario)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.mantenimiento_OUSR(        cdg_usr, des_usr,swt_usr, ema_usr, dni,cdg_perf, clave , swt_aprobacion,
                                                    usr_crea, fec_crea, terminal_crea, usr_modi, fec_modi, terminal_modi, operacion, formulario);
        }

        public int sp_prd_mantenimiento_m_usuari_mcop
       (
           string cdg_usr, string des_usr, string cdg_perf, int swt_usr, string ema_usr, string usr_crea, string fec_crea,
                                     string usr_modi, string fec_modi, string operacion, string formulario, int swt_aprobacion, string dni, string clave)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.sp_prd_mantenimiento_m_usuari_mcop(cdg_usr, des_usr, cdg_perf, swt_usr, ema_usr, usr_crea, fec_crea, usr_modi, fec_modi, operacion, formulario, swt_aprobacion,dni,clave);
        }

        public int cargar_asistencia(string dDesde, string dHasta, int tipo)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.cargar_asistencia(dDesde,dHasta,tipo);
        }

        public static DataTable listar_tareos_costos(string dDesde, string dHasta, string fano, string fsem, string dni, string tip, string mes)
        {
            AccesoDatos acceso = new AccesoDatos();
            return AccesoDatos.listar_tareos_costos(dDesde, dHasta, fano, fsem, dni, tip, mes);
        }

        public int mantenimiento_OSAE
     (
         int id_solicitud, string fecha_solicitud, string dni_empleado, string empleado, string mail_empleado, 
        int id_area, int id_perfil, string id_cc, string fecha_induccion, string hora_induccion, string estado,
         string usr_crea, string fec_crea, string terminal_crea, string usr_modi, string fec_modi, string terminal_modi, string operacion, string formulario, string activo, int NumLinea)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.mantenimiento_OSAE(id_solicitud, fecha_solicitud, dni_empleado, empleado, mail_empleado, 
           id_area,  id_perfil,  id_cc,  fecha_induccion,  hora_induccion,  estado,
          usr_crea,  fec_crea,  terminal_crea,  usr_modi,  fec_modi,  terminal_modi,  operacion,  formulario,  activo, NumLinea);
        }

        public int mantenimiento_OCAP
    (
        string PrjCode, string  PrcCode, string  CodPresupuesto, int CodFase, string  Fase,  string  FechaInicio, string fechafin, int Duracion, decimal Avance, decimal Peso, decimal factor, decimal avancevalorizado, string operacion)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.mantenimiento_OCAP(PrjCode, PrcCode, CodPresupuesto, CodFase, Fase, FechaInicio, fechafin, Duracion, Avance, Peso,factor, avancevalorizado, operacion);
        }

        public int mantenimiento_OTDC
   (
       int idreg, string ruc, string tipdoc, string nserie, string ndocum, string fchdoc, string fecven, string moneda, decimal subtot, int swtigv, decimal igv, decimal totneto, decimal impret, string glosa, string docuref, string nroletra, string numord, string numocom, string numosrv, string numguia, string guirem, int prioridad, int estadodoc, string usrapr, string fchapr, string obs, int swtenvio, string fecenvio, string coment, int estado, string feccre, string usrcre, string fecact, string usract, int numref, string operacion, string fecrec, string formulario)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.mantenimiento_OTDC(idreg, ruc, tipdoc, nserie, ndocum, fchdoc, fecven, moneda, subtot, swtigv, igv, totneto, impret, glosa, docuref, nroletra, numord, numocom, numosrv, numguia, guirem, prioridad, estadodoc, usrapr, fchapr, obs, swtenvio, fecenvio, coment, estado, feccre, usrcre, fecact, usract, numref, operacion, fecrec, formulario);
        }


        public int mantenimiento_TDC1
  (
      int NroLote, string FechaDocumento, int idreg,  string usr_crea, string fec_crea, string terminal_crea, string usr_modi,
                                     string fec_modi, string terminal_modi, string operacion, string formulario)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.mantenimiento_TDC1( NroLote,  FechaDocumento,  idreg,   usr_crea,  fec_crea,  terminal_crea,  usr_modi,
                                      fec_modi,  terminal_modi,  operacion,  formulario);
        }

        public int mantenimiento_OANX(int AbsEntry, int Line, string srcPath, string trgtPath, string FileName, string FileExt, string Date, int UsrID, string Copied, string Override, string subPath, string operacion)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.mantenimiento_OANX( AbsEntry,  Line,  srcPath,  trgtPath,  FileName,  FileExt,  Date,  UsrID,  Copied,  Override,  subPath,  operacion);
        }

        public int mantenimiento_OPAC(string PrcCode, string Perfil, decimal Longitud, decimal cantidad)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.mantenimiento_OPAC(PrcCode, Perfil, Longitud, cantidad);
        }





        public int mantenimiento_OCEB
   (
       string CodigoBanco, string NombreBanco,string DescripcionColumna, int CantFilasEcanb,string TipoColumna)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.mantenimiento_OCEB(CodigoBanco, NombreBanco, DescripcionColumna, CantFilasEcanb, TipoColumna);
        }

        public int actualizar_correlativo
 (
     string CodigoBanco, int correlativo)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.actualizar_correlativo(CodigoBanco, correlativo);
        }



        public int sp_prd_mantenimiento_m_prd_firma
 (
    int itemnum, string cdg_usr, byte[] firma, string usr_crea, string fec_crea, string terminal_crea, string operacion,
                                   string usr_modi, string fec_modi, string terminal_modi, string formulario, string seccion, string bloque,
                                   string estado_registro)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.sp_prd_mantenimiento_m_prd_firma(itemnum, cdg_usr, firma, usr_crea, fec_crea, terminal_crea, operacion, usr_modi, fec_modi, terminal_modi, formulario, seccion, bloque, estado_registro);
        }

        public int mantenimiento_m_prd_codigo_costo
           (
               string codigo, string descripcion, decimal habilitado, decimal fabricacion, decimal granallado, decimal pintado, decimal global, string usr_crea, string fec_crea,
                                    string terminal_crea, string usr_modi, string fec_modi, string terminal_modi, string operacion, string formulario, string estado_registro)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.mantenimiento_m_prd_codigo_costo(codigo, descripcion, habilitado, fabricacion, granallado, pintado, global, usr_crea, fec_crea, terminal_crea, usr_modi, fec_modi, terminal_modi, operacion, formulario, estado_registro);
        }

        public int mantenimiento_m_prd_aprobaciones
    (
      string cdg_perf, string cdg_usr, string formulario, int swt_aprobacion, string cod_tipodoc, string operacion)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.mantenimiento_m_prd_aprobaciones(cdg_perf, cdg_usr, formulario, swt_aprobacion, cod_tipodoc, operacion);

        }


        public int sp_insertar_m_prd_test
        (
            int item, string nro_op, string marca, int cant_total, int nro_trans)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.sp_insertar_m_prd_test(item, nro_op, marca,cant_total, nro_trans);
        }

      
        public int insertar_log_session(string cdg_usr, string terminal, string fecha, string ip, string session, string doninio, string swt_activo, string hinicio, string hfin, int id_session)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.insertar_log_session(cdg_usr, terminal, fecha, ip, session, doninio, swt_activo, hinicio, hfin, id_session);

        }

        public int insertar_OAUD(string cdg_usr,  string fecha , string terminal, string ip, string session, string operacion, string formulario, string cod_tipodoc, string nro_doc)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.insertar_OAUD(cdg_usr, fecha, terminal, ip, session, operacion, formulario, cod_tipodoc, nro_doc);

        }

        #endregion

        #region Mantenimiento PLANILLA STARSOFT

        public int insertar_marcacion
        (
            string dni, string usu, string ip)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.insertar_marcacion(dni, usu, ip);
        }


        #endregion

        #region Mantenimiento IMERP

        public int grabar_detalle_ped
        (
            string numPE, string cdgprod, decimal canped, decimal candesp, decimal caning, string cdgeqv, 
            decimal faceqv, decimal cancmp, decimal canocom, string numord, decimal swtapr, decimal swtrev, 
            string usract, string tipact, string fecact, string horact, string cdgusr, decimal cjachk, decimal webnum,
            string obsped, string usrcrea, string usrmodi, string swtest,int linea, string operacion
            
        )
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.grabar_detalle_ped
            (
                numPE, cdgprod, canped, candesp, caning, cdgeqv, 
            faceqv, cancmp, canocom, numord, swtapr, swtrev, 
            usract, tipact, fecact, horact, cdgusr, cjachk, webnum,
            obsped, usrcrea, usrmodi, swtest,linea, operacion
            );
	     }

        public int grabar_parametrizacion
       (
           int id, string Userid, int ColumnaId, bool visible, int GrillaId 
       )
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.grabar_parametrizacion
            (
                 id,  Userid,  ColumnaId,  visible, GrillaId 
            );
        }


        public int grabar_cabecera_asiento
      (
         int CINT, string FECHA, string TIPO, string GLOSA, string ESTADO, int CSAP
      )
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.grabar_cabecera_asiento
            (CINT, FECHA, TIPO, GLOSA, ESTADO, CSAP);
        }


        public int grabar_detalle_asiento
     (
        int CINT, int LINEA, string CUENTA, string EMPDNI, string EMPNOM, decimal DEBIT, decimal CREDIT, decimal FCDEBIT, decimal FCCREDIT, string GLOSA, string CCOSTO

     )
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.grabar_detalle_asiento
            (CINT, LINEA, CUENTA, EMPDNI, EMPNOM, DEBIT, CREDIT, FCDEBIT, FCCREDIT, GLOSA, CCOSTO);
        }


        public int grabar_empleado
       (
          string CINT, string NOM1, string NOM2, string APEP, string APEM, string SEXO, string DNI, string TEMP, string AREA, string TELM, string TELF, 
          string EMAIL, string ACTIVO, string ESTADO, int CSAP, string ERROR

       )
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.grabar_empleado
            (CINT, NOM1, NOM2, APEP, APEM, SEXO, DNI, TEMP, AREA, TELM, TELF, EMAIL, ACTIVO, ESTADO, CSAP, ERROR);
        }

        public int grabar_detalle_ser
       (
           string numPE, string cdgprod, decimal canped, decimal candesp, decimal caning, string cdgeqv,
           decimal faceqv, decimal cancmp, decimal canocom, string numord, decimal swtapr, 
           string usract, string tipact, string fecact, string horact, string cdgusr,
           string usrcrea, string usrmodi, string swtest, int linea, string operacion

           
       )
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.grabar_detalle_ser
            (
                numPE, cdgprod, canped, candesp, caning, cdgeqv,
            faceqv, cancmp, canocom, numord, swtapr, 
            usract, tipact, fecact, horact, cdgusr, 
            usrcrea, usrmodi, swtest, linea, operacion
            );
        }


        public int grabar_cabecera_ped
       (
            string numPE, string fecped, string numord, string cdgemp, string fecreq, string obsped, 
            string swting, string fecapr, decimal swtapr, decimal swtrev, string cdgusr, string cdgapr,
			string cdgrev, string fecrev, string usucrea, string usumodi,  string fecanul, string usuanul,
            string usract, string tipact, string fecact, string horact, decimal webnum, string swtest, string U_CL_CODSOL, string U_CL_SOLICI, string operacion, string cod_autorizacion

       )
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.grabar_cabecera_ped
            (
                 numPE,  fecped,  numord,  cdgemp,  fecreq,  obsped, 
             swting,  fecapr,  swtapr,  swtrev,  cdgusr,  cdgapr,
			 cdgrev,  fecrev,  usucrea,  usumodi,   fecanul,  usuanul,
             usract, tipact, fecact, horact, webnum, swtest, U_CL_CODSOL, U_CL_SOLICI, operacion, cod_autorizacion
            );
        }

        public int grabar_cabecera_ser
      (
           string numPE, string fecped, string numord, string cdgemp, string fecreq, string obsped,
           string swting, string fecapr, decimal swtapr, string cdgusr, string cdgapr,
           string usucrea, string usumodi, string fecanul, string usuanul,
           string usract, string tipact, string fecact, string horact,  string swtest, string U_CL_CODSOL, string U_CL_SOLICI, string operacion

            


      )
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.grabar_cabecera_ser
            (
                 numPE, fecped, numord, cdgemp, fecreq, obsped,
             swting, fecapr, swtapr, cdgusr, cdgapr,
           usucrea, usumodi, fecanul, usuanul,
             usract, tipact, fecact, horact, swtest, U_CL_CODSOL, U_CL_SOLICI, operacion
            );
        }


        public int actualizar_num_ped(string num_ped, string tipo)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.actualizar_num_ped(num_ped, tipo);

        }

        public int actualizar_aprobar_materiales(string num_ped, int swtApr, string usrapr)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.actualizar_aprobar_materiales(num_ped, swtApr, usrapr);

        }

        public int actualizar_estado(string num_ped, string swt_estado, string usrapr, string tipo)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.actualizar_estado(num_ped, swt_estado, usrapr, tipo);

        }

        public int actualizar_DocEntry(string num_ped, int DocEntry, string tipo)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.actualizar_DocEntry(num_ped, DocEntry, tipo);

        }

    
        public static DataTable validar_req_sap(int DocEntry, string tipo)
        {

            return AccesoDatos.validar_req_sap(DocEntry, tipo);

        }

        public int actualizar_aprobar_servicios(string num_ped, int swtApr, string usrapr)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.actualizar_aprobar_servicios(num_ped, swtApr, usrapr);

        }

        public int mantenimiento_pca_d(int pca, int linea, string id_usuario_g, int id_servicio, string contraseña, string fecha, string swt_estado, string operacion, string usr_crea, string fec_crea,
                                              string terminal_crea, string operacion_mod, string usr_mod, string fec_mod, string terminal_mod, string formulario, string estado_registro)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.mantenimiento_pca_d(pca, linea, id_usuario_g, id_servicio, contraseña, fecha, swt_estado, operacion, usr_crea, fec_crea, terminal_crea, operacion_mod,
                                                                usr_mod, fec_mod, terminal_mod, formulario, estado_registro);
        }

        public int mantenimiento_pca(int pca, string dni, string apellidos, string nombres, int id_area, int id_perfil, string id_usuario, int id_movimiento, string fecha, string autorizado, string swt_estado, string operacion, string usr_crea, string fec_crea,
                                                 string terminal_crea, string operacion_mod, string usr_mod, string fec_mod, string terminal_mod, string formulario, string estado_registro, string ot)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.mantenimiento_pca(pca, dni, apellidos, nombres, id_area, id_perfil, id_usuario, id_movimiento, fecha, autorizado, swt_estado, operacion, usr_crea, fec_crea, terminal_crea, operacion_mod,
                                                                usr_mod, fec_mod, terminal_mod, formulario, estado_registro, ot);
        }
        #endregion 

        #region Consultar IMERP

     
        public static DataTable obtener_num_ped(string tipo)
        {

            return AccesoDatos.obtener_num_ped(tipo);

        }

      
     
       

        #endregion

        #region Consultar STARSOFT
        public static DataTable ejecutar_sp_starsoft(string sp, string periodo)
        {

            return AccesoDatos.ejecutar_sp_starsoft(sp, periodo);

        }

        public static DataTable listar_mes_trabajo()
        {

            return AccesoDatos.listar_mes_trabajo();

        }

        public static DataTable listar_periodos_cronograma(string mes)
        {

            return AccesoDatos.listar_periodos_cronograma(mes);

        }

        //public static DataTable listar_detalle_asientos(int CRONO)
        //{

        //    return AccesoDatos.listar_detalle_asientos(CRONO);

        //}

        //public static DataTable listar_cabecara_asientos(int CRONO)
        //{

        //    return AccesoDatos.listar_cabecara_asientos(CRONO);

        //}

        #endregion

        #region Consultar SAP

        public static DataTable listar_costos2(string mat, string ot, string dDesde, string dHasta, string tip, string mod)
        {

            return AccesoDatos.listar_costos2(mat, ot, dDesde, dHasta, tip, mod);

        }


        public static DataTable ejecutar_sp_SAP(string sp)
        {

            return AccesoDatos.ejecutar_sp_SAP(sp);

        }

        public static DataTable listar_materiales_servicios_sap(string tipo_requerimiento, string tipo)
        {

            return AccesoDatos.listar_materiales_servicios_sap(tipo_requerimiento, tipo);

        }


        public static DataTable listar_ot_sap()
        {

            return AccesoDatos.listar_ot_sap();

        }

        public static DataTable listar_ubicaciones_sap()
        {

            return AccesoDatos.listar_ubicaciones_sap();

        }

        public static DataTable listar_proyectos_sap(string num_ord)
        {

            return AccesoDatos.listar_proyectos_sap(num_ord);

        }

        public static DataTable listar_proyectos(string parametro)
        {

            return AccesoDatos.listar_proyectos(parametro);

        }

        public static DataTable listar_bd_sap()
        {

            return AccesoDatos.listar_bd_sap();

        }
        #endregion

        #region Tareos
        public static DataTable listar_semanas_anio(string anio)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.listar_semanas_anio(anio);
        }

        public static DataTable listar_fechas_inifin(string anio, string semana)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.listar_fechas_inifin(anio, semana);
        }

        public static DataTable listar_combo_tipo()
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.listar_combo_tipo();
        }

        public static DataTable listar_combo_actividad()
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.listar_combo_actividad();
        }

        public static DataTable listar_combo_edt(string ot)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.listar_combo_edt(ot);
        }

        public static DataTable listar_combo_personal(string dni, string origen)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.listar_grid_personal(dni, origen);
        }

        public static DataTable listar_grid_personal(string dni, string origen)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.listar_grid_personal(dni, origen);
        }

        public static DataTable listar_combo_ot()
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.listar_combo_ot();
        }

        public static DataTable listar_combo_falta()
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.listar_combo_falta();
        }

        public static DataTable listar_combo_turno()
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.listar_combo_turno();
        }


        public static DataTable validar_horas_semanales(string dni, string fec, string fini, string ffin, string usr)
        {
            return AccesoDatos.validar_horas_semanales(dni, fec, fini, ffin, usr);
        }

        public static DataTable listar_grilla_tareo(string anio, string semana, string usuario, int estado, string permiso, string ot)
        {
            if (ot == "00000")
            {
                ot = "";
            }
            else
            {
                if (ot.Substring(0, 3) == "OTF" || ot.Substring(0, 3) == "OTM")
                {
                    ot = string.Concat("20", ot.Substring(3, 5));
                }
            }
            AccesoDatos acceso = new AccesoDatos();
            return acceso.listar_grilla_tareo(anio, semana, usuario, estado, permiso, ot);
        }

        public static DataTable listar_grilla_tareo_ctrl(int anio, int semana, string usuario, int estado, string permiso, string ot)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.listar_grilla_tareo_ctrl(anio, semana, usuario, estado, permiso, ot);
        }

        public static DataTable listar_combo_personal_total()
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.listar_combo_personal_total();
        }

        public static DataTable obtener_estTareo(string anio, string semana, string usuario)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.obtener_estTareo(anio, semana, usuario);
        }

        public static int revisar_tareo(string anio, string semana, string usuario, string estado, string usuario_mod)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.revisar_tareo(anio, semana, usuario, estado, usuario_mod);
        }

        public static DataTable listar_combo_tareadores()
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.listar_combo_tareadores();
        }

        public static int asignar_trab_tareador(string tareador, string personal, string usuario)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.asignar_trab_tareador(tareador, personal, usuario);
        }

        public static int desasignar_trab_tareador(string tareador, string personal)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.desasignar_trab_tareador(tareador, personal);
        }

        public static int grabar_tareo(string p_1, string p_2, string p_3, string p_4, string p_5, string p_6, string p_7, string p_8, string p_9, string p_10, string p_11, string p_12, string p_13, string p_14, string p_15, string p_16)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.grabar_tareo(p_1, p_2, p_3, p_4, p_5, p_6, p_7, p_8, p_9, p_10, p_11, p_12, p_13, p_14, p_15, p_16);
        }

        public static DataTable obtener_user(string dni)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.obtener_user(dni);
        }

        public static DataTable Resumen_Tareo_Formato(string fechaIni, string fechaFin, string semana, string anio, string tfor, string eval, string dni, string swtht)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.Resumen_Tareo_Formato(fechaIni, fechaFin, semana, anio, tfor, eval, dni, swtht);
        }

        public static int anular_tareo(string anio, string semana, string usuario, string estado, string usuarioMod)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.anular_tareo(anio, semana, usuario, estado, usuarioMod);
        }

        public static DataTable Buscar_registro(string mod_Anio, string mod_Sem, string mod_UsrCrea, string mod_CodTrab, string mod_FechTrab, string mod_OT)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.Buscar_registro(mod_Anio, mod_Sem, mod_UsrCrea, mod_CodTrab, mod_FechTrab, mod_OT);
        }

        public static DataTable obtener_semana_actual()
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.obtener_semana_actual();
        }

        public static int actualizar_tareo(string anio, string semana, string usuarioCrea, string codigotrab, string fechaTrab, string turno, string tipo, string falta, string proc, string activ, string hn, string he, string ot)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.actualizar_tareo(anio, semana, usuarioCrea, codigotrab, fechaTrab, turno, tipo, falta, proc, activ, hn, he, ot);
        }

        public static int anula_registro_tareo(string anio, string semana, string usuarioCrea, string codigotrab, string fechaTrab, string ot)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.anula_registro_tareo(anio, semana, usuarioCrea, codigotrab, fechaTrab, ot);
        }

        public static int actualizar_tareo_masivo(string mod_Anio, string mod_Sem, string mod_UsrCrea, string turno, string ot, string tipo, string falta, string hn, string he, string observacion)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.actualizar_tareo_masivo(mod_Anio, mod_Sem, mod_UsrCrea, turno, ot, tipo, falta, hn, he, observacion);
        }

        public static DataTable buscar_asignacion(string personal)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.buscar_asignacion(personal);
        }

        public static DataTable verificar_acceso(string usuario)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.verificar_acceso(usuario);
        }


        public static int desasignar_trab_tareador(string tareador, string personal, string usuario)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.desasignar_trab_tareador(tareador, personal, usuario);
        }

        public static int actualizar_registro(string trabajador, string ot, string HTRABAJ, string OBHE25, string OBHE35, string CCHE100, string DFERIADO, string DFALTAS, string DDMEDICO, string DSUBENF, string DSUBMAT, string DVACAC, string DTRABAJ, string DLICSGO, string DBAJADA, string campo_HTRABAJ, string campo_OBHE25, string campo_OBHE35, string campo_CCHE100, string campo_DFERIADO, string campo_DFALTAS, string campo_DDMEDICO, string campo_DSUBENF, string campo_DSUBMAT, string campo_DVACAC, string campo_DTRABAJ, string campo_DLICSGO, string campo_DBAJADA, string campo_ccHTRABAJ, string campo_ccOBHE25, string campo_ccOBHE35, string campo_ccCCHE100, string campo_ccDFERIADO, string campo_ccDFALTAS, string campo_ccDDMEDICO, string campo_ccDSUBENF, string campo_ccDSUBMAT, string campo_ccDVACAC, string campo_ccDTRABAJ, string campo_ccDLICSGO, string campo_ccDBAJADA)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.actualizar_registro(trabajador, ot, HTRABAJ, OBHE25, OBHE35, CCHE100, DFERIADO, DFALTAS, DDMEDICO, DSUBENF, DSUBMAT, DVACAC, DTRABAJ, DLICSGO, DBAJADA, campo_HTRABAJ, campo_OBHE25, campo_OBHE35, campo_CCHE100, campo_DFERIADO, campo_DFALTAS, campo_DDMEDICO, campo_DSUBENF, campo_DSUBMAT, campo_DVACAC, campo_DTRABAJ, campo_DLICSGO, campo_DBAJADA, campo_ccHTRABAJ, campo_ccOBHE25, campo_ccOBHE35, campo_ccCCHE100, campo_ccDFERIADO, campo_ccDFALTAS, campo_ccDDMEDICO, campo_ccDSUBENF, campo_ccDSUBMAT, campo_ccDVACAC, campo_ccDTRABAJ, campo_ccDLICSGO, campo_ccDBAJADA);
        }



        public static int insertar_registro(string codigo, string trabajador, string ot, string opcion)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.insertar_registro(codigo, trabajador, ot, opcion);
        }

        public static int insertar_fecha(string fecha, string marcador)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.insertar_fecha(fecha, marcador);
        }
        public DataTable buscar_codigo(string fecha)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.buscar_codigo(fecha);
        }

        public static int reiniciar_tablas()
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.reiniciar_tablas();
        }

        public static int actualizar_registro_civil(string trabajador, string ot, string CCHTRAB, string CCDFALTA, string CCHE60, string CCHE100, string CCHDOBLE, string CCDDMED, string CCFERIAD, string campo_CCHTRAB, string campo_CCDFALTA, string campo_CCHE60, string campo_CCHE100, string campo_CCHDOBLE, string campo_CCDDMED, string campo_CCFERIAD, string campo_ccCCHTRAB, string campo_ccCCDFALTA, string campo_ccCCHE60, string campo_ccCCHE100, string campo_ccCCHDOBLE, string campo_ccCCDDMED, string campo_ccCCFERIAD)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.actualizar_registro_civil(trabajador, ot, CCHTRAB, CCDFALTA, CCHE60, CCHE100, CCHDOBLE, CCDDMED, CCFERIAD, campo_CCHTRAB, campo_CCDFALTA, campo_CCHE60, campo_CCHE100, campo_CCHDOBLE, campo_CCDDMED, campo_CCFERIAD, campo_ccCCHTRAB, campo_ccCCDFALTA, campo_ccCCHE60, campo_ccCCHE100, campo_ccCCHDOBLE, campo_ccCCDDMED, campo_ccCCFERIAD);
        }

        public DataTable Consulta_final(string opcPlanilla)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.Consulta_final(opcPlanilla);
        }

        public DataTable Buscar_Ot(string _codigo)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.Buscar_Ot(_codigo);
        }

        public DataTable cargar_grilla(string anio, string semana)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.cargar_grilla(anio, semana);
        }

        public DataTable cargar_grilla_civil(string anio, string semana)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.cargar_grilla_civil(anio, semana);
        }


        public DataTable verificar_asistencia(string codigo, string fecha)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.verificar_asistencia(codigo, fecha);
        }

        public static int actualizar_autorizacion(string formulario, string id_linea, string estado)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.actualizar_autorizacion(formulario, id_linea, estado);
        }

        public DataTable verificar_autorizacion(string formulario, string id_linea)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.verificar_autorizacion(formulario, id_linea);
        }

        public DataTable cargar_grilla_ingmasivo(string _dni, string _fecha)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.cargar_grilla_ingmasivo(_dni, _fecha);
        }

        public static DataTable listar_grilla_tareo_estados(string anio_estados, string semana_estados)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.listar_grilla_tareo_estados(anio_estados, semana_estados);
        }


        public static DataTable cargar_grilla_segui(string sql1, string sql2, string sql3, string sql4)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.cargar_grilla_segui(sql1, sql2, sql3, sql4);
        }

        public static DataTable cargar_responsables(string anio, string semana, string documento)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.cargar_responsables(anio, semana, documento);
        }

        public static DataTable cargar_responsables_asign(string documento)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.cargar_responsables_asign(documento);
        }

        public DataTable cargar_grilla_tareadores(string opcion)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.cargar_grilla_tareadores(opcion);
        }

        public DataTable Cargar_grilla_asistencia(string anio, string mes, string dia)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.Cargar_grilla_asistencia(anio, mes, dia);
        }

        #endregion

    

        public static int actualizar_nivel_acceso(string dni, string nacceso)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.actualizar_nivel_acceso(dni, nacceso);
        }

        public DataTable Listar_Personal_Activo()
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.Listar_Personal_Activo();
        }

        public DataTable listar_validacion_usuario(string opcion)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.listar_validacion_usuario(opcion);
        }

        public static int actualizar_configuracion(string usuario, string opcion, string estado)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.actualizar_configuracion(usuario, opcion, estado);
        }

        public static int actualizar_configuracion_todos(string opcion, string estado)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.actualizar_configuracion_todos(opcion, estado);
        }

        public DataTable listar_configuracion_horas()
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.listar_configuracion_horas();
        }

        public DataTable listar_configuracion_horas_defecto()
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.listar_configuracion_horas_defecto();
        }

        public static int actualizar_configuracion_horas(string hn_n, string he_n, string ht_n, string hns_n, string hes_n, string hnsa_n, string hesa_n, string hn_f, string he_f, string ht_f, string hns_f, string hes_f, string hnsa_f, string hesa_f)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.actualizar_configuracion_horas(hn_n, he_n, ht_n, hns_n, hes_n, hnsa_n, hesa_n, hn_f, he_f, ht_f, hns_f, hes_f, hnsa_f, hesa_f);
        }

        public DataTable verificar_autorizacion_usuario(string usuario, string validacion)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.verificar_autorizacion_usuario(usuario, validacion);
        }

        public DataTable verificar_semana_cerrada(string anio, string semana)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.verificar_semana_cerrada(anio, semana);
        }

        public int insertar_validaciones_tareador(string tareador, string opcion)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.insertar_validaciones_tareador(tareador, opcion);
        }


        #region Fondo Fijo y Rendiciones

        public DataTable Listar_Solicitud_Dinero(string pproyecto)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.Listar_Solicitud_Dinero(pproyecto);
        }
        
        public DataTable listar_combo_proyectos(string opcion)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.listar_combo_proyectos(opcion);
        }

        public DataTable VS_Listar_Proyectos(string opcion)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.VS_Listar_Proyectos(opcion);
        }

        public DataTable VS_Listar_Parametro(string parametro, string opcion)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.VS_Listar_Parametro(parametro, opcion);
        }

        public DataTable VS_Listar_Usuarios(string opcion)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.VS_Listar_Usuarios(opcion);
        }

        public DataTable VS_Listar_Rendiciones(string pcodigo, string pfecha, string pestado, string pcodProy)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.VS_Listar_Rendiciones(pcodigo, pfecha, pestado, pcodProy);
        }

        public DataTable VS_Listar_SD_AsigRendiciones(string proyecto)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.VS_Listar_SD_AsigRendiciones(proyecto);
        }

        public DataTable Listar_CajaChica_Gastos(string parametro)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.Listar_CajaChica_Gastos(parametro);
        }

        public DataTable VS_Listar_CajaChica(string proyecto)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.VS_Listar_CajaChica(proyecto);
        }

        public int VS_modificar_proyecto(string pProyecto, string pProyectoDesc, string pOT, string pEstado, string pAlmacen, string pAlmacenDesc, string pUbicacion, string pUbicacionDesc, string pCuenta, string pCuentaDesc, string pCuentaRendicion, string pCuentaRendicionDesc, string pTotalCaja, string pMoneda, string pComentario, string pUsuario, string pidCC, string pcorrelativoCC)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.VS_modificar_proyecto(pProyecto, pProyectoDesc, pOT, pEstado, pAlmacen, pAlmacenDesc, pUbicacion, pUbicacionDesc, pCuenta, pCuentaDesc, pCuentaRendicion, pCuentaRendicionDesc, pTotalCaja, pMoneda, pComentario, pUsuario, pidCC, pcorrelativoCC);
        }

        public DataTable VS_Listar_Ubicaciones(string palmacen)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.VS_Listar_Ubicaciones(palmacen);
        }

        public int VS_RegMod_Usuario(string pcodigo, string pnombre, string pcorreo, string pestado)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.VS_RegMod_Usuario(pcodigo, pnombre, pcorreo, pestado);
        }

        public int VS_Asignar_Proyecto_Usu(string pusuario, string pproyecto, string prol, string pestado)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.VS_Asignar_Proyecto_Usu(pusuario, pproyecto, prol, pestado);
        }

        public int VS_SD_RegMod(string pcodigo, DateTime pfecha, string pmonto, string pmoneda, string pmotivo, string pmotivoextra, string pestado, string pusuario, string pproyecto, string pcomentario, string pempleadocod, string pempleadodesc)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.VS_SD_RegMod(pcodigo, pfecha, pmonto, pmoneda, pmotivo, pmotivoextra, pestado, pusuario, pproyecto, pcomentario, pempleadocod, pempleadodesc);
        }

        public DataTable VS_Listar_Gasto_detalle(string pdocEntry)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.VS_Listar_Gasto_detalle(pdocEntry);
        }

        public int VS_OOGD_RegMod(int pdocEntry, int plineId, string pcodArt, string pdesArt, string pundMed, string pcant, string pprecio, string pdocEntryGC, string pCodProy, string pnroOT, int pfilaafectadas)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.VS_SD_RegMod(pdocEntry, plineId, pcodArt, pdesArt, pundMed, pcant, pprecio, pdocEntryGC, pCodProy, pnroOT, pfilaafectadas);
        }

        public int VS_OOGD_Eliminar(int pdocEntry)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.VS_OOGD_Eliminar(pdocEntry);
        }

        public int VS_modificar_caja_chica(string pdocEntry, string pnroCC, string pnroOT, decimal ptotalCaja, string pmoneda, DateTime pfechaCierre, string pestado, string pcodUsu, string pcodProy, string pcomentarios, int pfilaafectadas)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.VS_OOGD_Eliminar(pdocEntry, pnroCC, pnroOT, ptotalCaja, pmoneda, pfechaCierre, pestado, pcodUsu, pcodProy, pcomentarios, pfilaafectadas);
        }

        public int VS_OOGC_Eliminar(int pdocEntry, int pfilasAfectadas)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.VS_OOGC_Eliminar(pdocEntry, pfilasAfectadas);
        }

        public int VS_OOGC_RegMod(int pdocEntry, string ptipGasto, string pdesGasto, string pcodProv, string pnomProv, string ptipDocProv, string pnroDocProv, string ptipDoc, string pserDoc, string pcorDoc, decimal pmonGasto, DateTime pfecha, string pmoneda, int ptcespecial, int pmonImpGasto, int pmonDocGasto, string pnroRen, string pnroCC, string pcodImp, string pnomImp, decimal pcantImp, string pnomComentario, string pcodEmp, string pnomEmp, string pnumPla, string pCodProy, string pnroOT, int pfilaafectadas)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.VS_OOGC_RegMod(pdocEntry, ptipGasto, pdesGasto, pcodProv, pnomProv, ptipDocProv, pnroDocProv, ptipDoc, pserDoc, pcorDoc, pmonGasto, pfecha, pmoneda, ptcespecial, pmonImpGasto, pmonDocGasto, pnroRen, pnroCC, pcodImp, pnomImp, pcantImp, pnomComentario, pcodEmp, pnomEmp, pnumPla, pCodProy, pnroOT, pfilaafectadas);
        }

        public DataTable VS_Listar_Gasto_contabilizar(string pdocEntry)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.VS_Listar_Gasto_contabilizar(pdocEntry);
        }

        public int VS_OOGC_ActualizarFechaContabilizacionPorCajaChica(int pdocEntry, int pdocEntryCC, DateTime pfechaContabilizacion, int pfilaafectadas)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.VS_OOGC_ActualizarFechaContabilizacionPorCajaChica(pdocEntry, pdocEntryCC, pfechaContabilizacion, pfilaafectadas);
        }
        #endregion


        public static DataTable impresion_transmital(string transmital)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.impresion_transmital(transmital);
        }

        public static DataTable impresion_transmitalTM(string idtra)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.impresion_transmitalTM(idtra);
        }

        public DataTable Cargar_asistencia_rango()
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.Cargar_asistencia_rango();
        }

        public DataTable Cargar_personal()
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.Cargar_personal();
        }



        public DataTable listar_marcaciones(string fechaDesde, string fechaHasta)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.listar_marcaciones(fechaDesde, fechaHasta);
        }

        public int actualizar_anexo(string pDni, string pAnexo, string pRpc, string pOtro, string pOpc)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.actualizar_anexo(pDni, pAnexo, pRpc, pOtro, pOpc);
        }

        public DataTable buscar_anexo(string pDni)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.buscar_anexo(pDni);
        }

        public int nuevo_registro_anexo(string pDni, string pAnexo, string pRpc, string pOtro)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.nuevo_registro_anexo(pDni, pAnexo, pRpc, pOtro);
        }

        public int suprimir_registro_anexo(string pDni, string pOpc)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.suprimir_registro_anexo(pDni,pOpc);
        }

        public int nuevo_registro_anexo_nom(string pNombre, string pAnexo, string pRpc, string pOtro)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.nuevo_registro_anexo_nom(pNombre, pAnexo, pRpc, pOtro);
        }
    }
}
