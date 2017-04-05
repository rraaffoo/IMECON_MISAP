using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MISAP.Entity;
using MISAP.Repository;

namespace MISAP.Service
{
    public class SolicitudDineroService
      : TesoreriaBaseService<SolicitudDineroEntity>
    {
        private SolicitudDineroRepository _repositorio;

        public SolicitudDineroService()
            : base(new SolicitudDineroRepository())
        {
            _repositorio = new SolicitudDineroRepository();
        }

        public override RespuestaEntity Guardar(SolicitudDineroEntity item)
        {
            RespuestaEntity respuesta = new RespuestaEntity();
            try
            {
                String mensaje = String.Empty;
                int docEntry = 0, filasAfectadas = 0;
                docEntry = item.docEntry;
                SolicitudDineroEntity itemSD;
                if (docEntry == 0)
                {
                    if (item.Usuario.Proyecto.Rol.isContab || item.Usuario.Proyecto.Rol.isSupervisor || item.Usuario.Proyecto.Rol.isAdmin)
                        throw new Exception("No tiene acceso a esta funcionalidad. No se ha Guardado.");
                }
                else
                {
                    Debug("Guardar_Detalle", item);
                    itemSD = _repositorio.Detalle(docEntry);
                    if (itemSD.Rendicion.aprob == "1")
                        throw new Exception("La Rendición asociada a la Solicitud de Dinero esta Contabilizada. No se ha modificado.");
                    if (!item.Usuario.Proyecto.Rol.isContab && !item.Usuario.Proyecto.Rol.isSupervisor)
                    {
                        if (itemSD.estado != "S")
                            throw new Exception(String.Format("La Solicitud de Dinero tiene estado {0}. No se ha Modificado", itemSD.nomEstado));

                        #region Explicacion
                        /*
                     * No es Contabilidad
                     * Estado :
                     *  - Solicitado
                     *  - Anulado
                         
                  --- item Vs itemSD
                  Si itemSD.Rendiciones.aprob == "1" entonces | "La Rendición asociada a la Solicitud de Dinero esta contabilizada.No se ha modificado."
                  Si item.estado es solicitado entonces
                        Si itemSD.estado es solicitado | actualizo
                        sino si itemSD.estado es aprobado | "La Solicitud de Dinero esta Aprobado. No se ha modificado."
                        sino si itemSD.estado es rechazado | "La Solicitud de Dinero esta Rechazado. No se ha modificado."
                        sino si itemSD.estado es anulado | "La Solicitud de Dinero esta Anulado. No se ha modificado."
                  sino si item.estado es anulado entonces
                        Si itemSD.estado es solicitado | actualizo
                        sino si itemSD.estado es aprobado | "La Solicitud de Dinero esta Aprobado. No se ha modificado."
                        sino si itemSD.estado es rechazado | "La Solicitud de Dinero esta Rechazado. No se ha modificado."
                        sino si itemSD.estado es anulado | "La Solicitud de Dinero esta Anulado. No se ha modificado."

                  Si itemSD.Rendiciones.aprob == "1" entonces | "La solicitud de Dinero esta Contabilizada. No se ha modificado."
                  Si itemSD.estado no es solicitado entonces
                        Si itemSD.estado es aprobado | "La Solicitud de Dinero esta Aprobado. No se ha modificado."
                        sino si itemSD.estado es rechazado | "La Solicitud de Dinero esta Rechazado. No se ha modificado."
                        sino si itemSD.estado es anulado | "La Solicitud de Dinero esta Anulado. No se ha modificado."
                          
                  Si itemSD.Rendiciones.aprob == "1" entonces | "La solicitud de Dinero esta Contabilizada. No se ha modificado."
                  Si itemSD.estado no es solicitado | "La Solicitud de Dinero esta (itemSD.nomEstado). No se ha Modificado"
                        
                  --- itemSD Vs item
                  Si itemSD.Rendiciones.aprob == "1" entonces | "La Rendición asociada a la Solicitud de Dinero esta contabilizada.No se ha modificado."
                  Si itemSD.estado es solicitado entonces
                        Si item.estado es solicitado | actualizo
                        sino si item.estado es anulado | actualizo
                  sino si itemSD.estado  es aprobado entonces
                        Si item.estado es solicitado | "La Solicitud de Dinero esta Aprobado. No se ha modificado."
                        sino si item.estado es anulado | "La Solicitud de Dinero esta Rechazado. No se ha modificado."
                  sino si itemSD.estado  es rechazado entonces
                        Si item.estado es solicitado | "La Solicitud de Dinero esta Rechazado. No se ha modificado."
                        sino si item.estado es anulado | "La Solicitud de Dinero esta Rechazado. No se ha modificado."
                  sino si itemSD.estado  es anulado entonces
                        Si item.estado es solicitado | "La Solicitud de Dinero esta Anulado. No se ha modificado."
                        sino si item.estado es anulado | "La Solicitud de Dinero esta Anulado. No se ha modificado."
                        
                  Si itemSD.Rendiciones.aprob == "1" entonces | "La Rendición asociada a la Solicitud de Dinero esta contabilizada.No se ha modificado."
                  si itemSD.estado no es solicitado entonces
                        Si itemSD.estado es aprobado | "La Solicitud de Dinero esta Aprobado. No se ha modificado."
                        sino si itemSD.estado es rechazado | "La Solicitud de Dinero esta Rechazado. No se ha modificado."
                        sino si itemSD.estado es anulado | "La Solicitud de Dinero esta Anulado. No se ha modificado."

                  Si itemSD.Rendiciones.aprob == "1" entonces | "La Rendición asociada a la Solicitud de Dinero esta contabilizada.No se ha modificado."
                  Si itemSD.estado no es solicitado | "La Solicitud de Dinero esta (itemSD.nomEstado). No se ha Modificado"
                  */
                        #endregion
                    }
                    else
                    {
                        if (item.Usuario.Proyecto.Rol.isContab)
                        {
                            if (itemSD.estado == "N")
                                throw new Exception(String.Format("La Solicitud de Dinero tiene estado {0}. No se ha modificado.", itemSD.nomEstado));
                            if (itemSD.estado == "S" && (item.estado == "S" || item.estado == "N"))
                                throw new Exception(String.Format("La Solicitud de Dinero tiene estado {0}. No se ha modificado.", itemSD.nomEstado));
                            if (item.estado != "N" && (itemSD.estado == "A" || itemSD.estado == "R"))
                                throw new Exception(String.Format("La Solicitud de Dinero tiene estado {0}. No se ha modificado.", itemSD.nomEstado));

                            #region Explicacion
                            /*
                        * Es Contabilidad
                        * Estado :
                        *  - Aprobado
                        *  - Rechazado
                        *  - Anulado
                         
                        --- item Vs itemSD
                        
                        Si itemSD.Rendiciones.aprob == "1" entonces | "La solicitud de Dinero esta Contabilizada. No se ha modificado."
                        Si item.estado es solicitado entonces
                            Si itemSD.estado es solicitado | "La Solicitud de Dinero esta Solicitado. No se ha modificado."
                            sino si itemSD.estado es aprobado | "La Solicitud de Dinero esta Aprobado. No se ha modificado."
                            sino si itemSD.estado es rechazado | "La Solicitud de Dinero esta Rechazado. No se ha modificado."
                            sino si itemSD.estado es anulado | "La Solicitud de Dinero esta Anulado. No se ha modificado."
                        sino si item.estado es aprobado entonces
                            Si itemSD.estado es solicitado | actualizo
                            sino si itemSD.estado es aprobado | "La Solicitud de Dinero esta Aprobado. No se ha modificado."
                            sino si itemSD.estado es rechazado | "La Solicitud de Dinero esta Rechazado. No se ha modificado."
                            sino si itemSD.estado es anulado | "La Solicitud de Dinero esta Anulado. No se ha modificado."
                        sino si item.estado es rechazado entonces
                            Si itemSD.estado es solicitado | actualizo
                            sino si itemSD.estado es aprobado | "La Solicitud de Dinero esta Aprobado. No se ha modificado."
                            sino si itemSD.estado es rechazado | "La Solicitud de Dinero esta Rechazado. No se ha modificado."
                            sino si itemSD.estado es anulado | "La Solicitud de Dinero esta Anulado. No se ha modificado."
                        sino si item.estado es anulado entonces
                            Si itemSD.estado es solicitado | "La Solicitud de Dinero esta Solicitado. No se ha modificado.
                            sino si itemSD.estado es aprobado | actualizo
                            sino si itemSD.estado es rechazado | actualizo
                            sino si itemSD.estado es anulado | "La Solicitud de Dinero esta Anulado. No se ha modificado."
                        
                        Si itemSD.Rendiciones.aprob == "1" entonces | "La solicitud de Dinero esta Contabilizada. No se ha modificado."
                        Si item.estado es solicitado | "La Solicitud de Dinero esta (itemSD.estado). No se ha modificado."
                        Si item.estado es aprobado entonces
                            Si itemSD.estado no es solicitado | "La Solicitud de Dinero esta (itemSD.estado). No se ha modificado."
                        Si item.estado es rechazado entonces
                            Si itemSD.estado no es solicitado | "La Solicitud de Dinero esta (itemSD.estado). No se ha modificado."
                        Si item.estado es anulado entonces
                            Si itemSD.estado es solicitado | "La Solicitud de Dinero esta (itemSD.estado). No se ha modificado."
                            sino Si itemSD.estado es anulado  | "La Solicitud de Dinero esta (itemSD.estado). No se ha modificado."

                        Si itemSD.Rendiciones.aprob == "1" entonces | "La solicitud de Dinero esta Contabilizada. No se ha modificado."
                        Si item.estado es solicitado | "La Solicitud de Dinero esta (itemSD.estado). No se ha modificado."
                        Si item.estado es aprobado || item.estado es rechazado entonces
                            Si itemSD.estado no es solicitado | "La Solicitud de Dinero esta (itemSD.estado). No se ha modificado."
                        Si item.estado es anulado && (itemSD.estado es solicitado || itemSD.estado es anulado) | "La Solicitud de Dinero esta (itemSD.estado). No se ha modificado."
                        
                        Si itemSD.Rendiciones.aprob == "1" entonces | "La solicitud de Dinero esta Contabilizada. No se ha modificado."
                        Si item.estado es solicitado | "La Solicitud de Dinero esta (item.estado). No se ha modificado."
                        Si itemSD.estado es anulado  | "La Solicitud de Dinero esta (itemSD.estado). No se ha modificado."
                        Si itemSD.estado no es solicitado && (item.estado es aprobado || item.estado es rechazado) | "La Solicitud de Dinero esta (itemSD.estado). No se ha modificado."
                        Si item.estado es anulado && (itemSD.estado es solicitado || itemSD.estado es anulado) | "La Solicitud de Dinero esta (itemSD.estado). No se ha modificado."
                        
                        --- itemSD Vs item
                        Si itemSD.Rendiciones.aprob == "1" entonces | "La solicitud de Dinero esta Contabilizada. No se ha modificado."
                        Si itemSD.estado es solicitado entonces
                            Si item.estado es solicitado | "La Solicitud de Dinero esta Solicitado. No se ha modificado."
                            sino si item.estado es aprobado | actualizo
                            sino si item.estado es rechazado | actualizo
                            sino si item.estado es anulado | "La Solicitud de Dinero esta Solicitado. No se ha modificado."
                        sino si itemSD.estado  es aprobado entonces
                            Si item.estado es solicitado | "La Solicitud de Dinero esta Aprobado. No se ha modificado."
                            sino si item.estado es aprobado | "La Solicitud de Dinero esta Aprobado. No se ha modificado."
                            sino si item.estado es rechazado | "La Solicitud de Dinero esta Aprobado. No se ha modificado."
                            sino si item.estado es anulado | actualizo
                        sino si itemSD.estado  es rechazado entonces
                            Si item.estado es solicitado | "La Solicitud de Dinero esta Rechazado. No se ha modificado."
                            sino si item.estado es aprobado | "La Solicitud de Dinero esta Rechazado. No se ha modificado."
                            sino si item.estado es rechazado | "La Solicitud de Dinero esta Rechazado. No se ha modificado."
                            sino si item.estado es anulado | actualizo
                        sino si itemSD.estado  es anulado entonces
                            Si item.estado es solicitado | "La Solicitud de Dinero esta Anulado. No se ha modificado."
                            sino si item.estado es aprobado | "La Solicitud de Dinero esta Anulado. No se ha modificado."
                            sino si item.estado es rechazado | "La Solicitud de Dinero esta Anulado. No se ha modificado."
                            sino si item.estado es anulado | "La Solicitud de Dinero esta Anulado. No se ha modificado."
                        
                        Si itemSD.Rendiciones.aprob == "1" entonces | "La solicitud de Dinero esta Contabilizada. No se ha modificado."
                        Si itemSD.estado es solicitado entonces
                            Si item.estado es solicitado | "La Solicitud de Dinero esta (itemSD.estado). No se ha modificado."
                            sino si item.estado es anulado | "La Solicitud de Dinero esta (itemSD.estado). No se ha modificado."
                        Si itemSD.estado es aprobado entonces
                            Si item.estado no es anulado | "La Solicitud de Dinero esta (itemSD.estado). No se ha modificado."
                        Si itemSD.estado es rechazado entonces
                            Si item.estado no es anulado | "La Solicitud de Dinero esta (itemSD.estado). No se ha modificado."
                        Si itemSD.estado es anulado | "La Solicitud de Dinero esta (itemSD.estado). No se ha modificado."

                        Si itemSD.Rendiciones.aprob == "1" entonces | "La solicitud de Dinero esta Contabilizada. No se ha modificado."
                        Si itemSD.estado es anulado | "La Solicitud de Dinero esta (itemSD.estado). No se ha modificado."
                        Si itemSD.estado es solicitado && (item.estado es solicitado ||  item.estado es anulado) | "La Solicitud de Dinero esta (itemSD.estado). No se ha modificado."
                        Si item.estado no es anulado && (itemSD.estado es aprobado || itemSD.estado es rechazado) | "La Solicitud de Dinero esta (itemSD.estado). No se ha modificado."
                        
                        Nota : Se programo el metodo 2. 
                        */
                            #endregion
                        }
                    }
                }
                this.Transaccion(delegate()
                {
                    if (docEntry == 0)
                    {
                        Debug("Guardar_Registrar", item);
                        docEntry = _repositorio.Registrar(item, out filasAfectadas);
                        mensaje = (docEntry == 0) ?
                           "Ya existe el registro." :
                           "Se ha registrado correctamente.";

                        if (docEntry > 0)
                            LlamarTareas(String.Format("{0} {1} {2} {3} {4}", "SD_Registro", item.Usuario.Proyecto.codProy, docEntry, itemUsuario.nomUsu, itemUsuario.Proyecto.nomProy));
                    }
                    else
                    {
                        Debug("Guardar_Modificar", item);
                        docEntry = _repositorio.Modificar(item, out filasAfectadas);
                        if (docEntry == 0)
                            mensaje = "Ya existe el registro.";
                        else
                        {
                            mensaje = "Se ha modificado Correctamente.";
                            if (item.estado == "A")
                                mensaje = "Se aprobó correctamente.";
                            else if (item.estado == "R")
                                mensaje = "Se rechazó correctamente.";
                            else if (item.estado == "N")
                                mensaje = "Se anuló correctamente.";
                        }
                    }
                });

                respuesta.success = (filasAfectadas > 0) ? true : false;
                respuesta.extra = (filasAfectadas > 0) ? docEntry.ToString() : String.Empty;
                respuesta.message = mensaje;
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }

            return respuesta;
        }

        public override RespuestaEntity<SolicitudDineroEntity> Buscar(SolicitudDineroEntity item, PaginadorEntity paginador)
        {
            RespuestaEntity<SolicitudDineroEntity> respuesta = new RespuestaEntity<SolicitudDineroEntity>();
            try
            {
                Debug("Buscar", item);
                List<SolicitudDineroEntity> items = _repositorio.Buscar(item, paginador);
                respuesta.items = items;
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;
        }

        #region Debug
        public override void Debug(string metodo, SolicitudDineroEntity item)
        {
            this.Debug(metodo, item, null);
        }

        public override void Debug(String metodo, SolicitudDineroEntity item, String parametro = null)
        {
            StringBuilder parametros = new StringBuilder();
            if (!String.IsNullOrEmpty(parametro))
                parametros.Append(parametro);
            else
            {
                parametros.Append(String.Format("docEntry = {0}, ", item.docEntry));
                parametros.Append(String.Format("codigo = {0}, ", item.codigo));
                parametros.Append(String.Format("fecha = {0}, ", item.fecha));
                parametros.Append(String.Format("monto = {0}, ", item.monto));
                parametros.Append(String.Format("moneda = {0}, ", item.moneda));
                parametros.Append(String.Format("motivo = {0}, ", item.motivo));
                parametros.Append(String.Format("motAdicional = {0}, ", item.motAdicional));
                parametros.Append(String.Format("fecharegistro = {0}, ", item.fecharegistro));
                parametros.Append(String.Format("estado = {0} ", item.estado));
                parametros.Append(String.Format("Comentarios = {0} ", item.comentarios));
                if (item.Rendicion != null)
                {
                    parametros.Append(", ");
                    parametros.Append(String.Format("Rendicion.docEntry = {0}, ", item.Rendicion.docEntry));
                    parametros.Append(String.Format("Rendicion.nroRen = {0}, ", item.Rendicion.nroRen));
                    parametros.Append(String.Format("Rendicion.codEmp = {0}, ", item.Rendicion.codEmp));
                    parametros.Append(String.Format("Rendicion.nomEmp = {0}, ", item.Rendicion.nomEmp));
                    parametros.Append(String.Format("Rendicion.nroOT = {0}, ", item.Rendicion.nroOT));
                    parametros.Append(String.Format("Rendicion.fecha = {0}, ", item.Rendicion.fecha));
                    parametros.Append(String.Format("Rendicion.aprob = {0}, ", item.Rendicion.aprob));
                    parametros.Append(String.Format("Rendicion.estado = {0}, ", item.Rendicion.estado));
                    parametros.Append(String.Format("Rendicion.fechaDesde = {0}, ", item.Rendicion.fechaDesde));
                    parametros.Append(String.Format("Rendicion.fechaHasta = {0} ", item.Rendicion.fechaHasta));
                }
                if (item.Usuario != null)
                {
                    parametros.Append(", ");
                    parametros.Append(String.Format("Usuario.codUsu = {0}, ", item.Usuario.codUsu));
                    parametros.Append(String.Format("Usuario.nomUsu = {0} ", item.Usuario.nomUsu));

                    if (item.Usuario.Proyecto != null)
                    {
                        parametros.Append(", ");
                        parametros.Append(String.Format("Usuario.Proyecto.codProy = {0}, ", item.Usuario.Proyecto.codProy));
                        parametros.Append(String.Format("Usuario.Proyecto.nomProy = {0} ", item.Usuario.Proyecto.nomProy));
                    }
                }
            }
            //base.Debug("Models.Service.Tesoreria.SolicitudDineroService.cs", metodo, parametros.ToString().Trim());
        }
        #endregion
    }
}
