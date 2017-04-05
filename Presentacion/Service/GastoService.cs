using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MISAP.Entity;
using MISAP.Repository;

namespace MISAP.Service
{
    public class GastoService
      : TesoreriaBaseService<GastoEntity>
    {
        private GastoRepository _repositorio;

        public GastoService()
            : base(new GastoRepository())
        {
            _repositorio = new GastoRepository();
        }

        #region Gasto
        public override RespuestaEntity Guardar(GastoEntity item)
        {
            RespuestaEntity respuesta = new RespuestaEntity();
            try
            {
                String mensaje = String.Empty;
                int docEntry = 0, filasAfectadas = 0;
                docEntry = item.docEntry;
                Validar(item);
                this.Transaccion(delegate()
                {
                    if (docEntry == 0)
                    {
                        Debug("Guardar_Registrar", item);
                        docEntry = _repositorio.Registrar(item, out filasAfectadas);
                        mensaje = (docEntry == 0) ? "Ya existe el registro." : "Se ha registrado Correctamente.";
                    }
                    else
                    {
                        Debug("Guardar_Modificar", item);
                        docEntry = _repositorio.Modificar(item, out filasAfectadas);
                        mensaje = (docEntry == 0) ? "Ya existe el registro." : "Se ha modificado Correctamente.";
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

        internal void Validar(GastoEntity item)
        {
            if (item.Rendiciones != null)
            {
                RendicionesService serviceRE = new RendicionesService();
                serviceRE.itemUsuario = itemUsuario;
                serviceRE.Validar(item.Rendiciones, true);
            }
            else if (item.CajaChica != null)
            {
                CajaChicaService serviceCC = new CajaChicaService();
                serviceCC.itemUsuario = itemUsuario;
                serviceCC.Validar(item.CajaChica, true);
            }
        }

        public RespuestaEntity<GastoEntity> DetallePorRendicion(int docEntry)
        {
            RespuestaEntity<GastoEntity> respuesta = new RespuestaEntity<GastoEntity>();
            try
            {
                Debug("DetallePorRendicion", String.Format("docEntry = {0}", docEntry));
                respuesta.item = _repositorio.DetallePorRendicion(docEntry);
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;
        }

        public RespuestaEntity<GastoEntity> DetallePorCajaChica(int docEntry)
        {
            RespuestaEntity<GastoEntity> respuesta = new RespuestaEntity<GastoEntity>();
            try
            {
                Debug("DetallePorCajaChica", String.Format("docEntry = {0}", docEntry));
                respuesta.item = _repositorio.DetallePorCajaChica(docEntry);
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;
        }
        // its - Joseph 
        public RespuestaEntity<GastoEntity> CentroCostoPorRendicion(string id)
        {
            RespuestaEntity<GastoEntity> respuesta = new RespuestaEntity<GastoEntity>();
            try
            {
                //Debug("DetallePorRendicion", String.Format("docEntry = {0}", docEntry));
                respuesta.item = _repositorio.CentroCostoPorRendicion(id);
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;
        }

        public RespuestaEntity<GastoEntity> CentroCostoPorCajaChica(string id)
        {
            RespuestaEntity<GastoEntity> respuesta = new RespuestaEntity<GastoEntity>();
            try
            {
                //Debug("DetallePorCajaChica", String.Format("docEntry = {0}", docEntry));
                respuesta.item = _repositorio.CentroCostoPorCajaChica(id);
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;
        }

        // its - Joseph Fin
        public RespuestaEntity<GastoEntity> BuscarGastosPorRendicion(int docEntry)
        {
            RespuestaEntity<GastoEntity> respuesta = new RespuestaEntity<GastoEntity>();
            try
            {
                Debug("BuscarGastosPorRendicion", String.Format("docEntry = {0}", docEntry));
                respuesta.items = _repositorio.BuscarGastosPorRendicion(docEntry);
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;

        }

        public RespuestaEntity<GastoEntity> BuscarGastosPorCajaChica(int docEntry)
        {
            RespuestaEntity<GastoEntity> respuesta = new RespuestaEntity<GastoEntity>();
            try
            {
                Debug("BuscarGastosPorCajaChica", String.Format("docEntry = {0}", docEntry));
                respuesta.items = _repositorio.BuscarGastosPorCajaChica(docEntry);
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;

        }

        public RespuestaEntity Eliminar(List<GastoEntity> items, GastoEntity itemG)
        {
            RespuestaEntity respuesta = new RespuestaEntity();
            try
            {
                Validar(itemG);
                int filasAfectadas = 0;
                base.Transaccion(delegate()
                {
                    foreach (GastoEntity item in items)
                    {
                        Debug("Eliminar", item);
                        _repositorio.Eliminar(item.docEntry, out filasAfectadas);
                    }
                });
                respuesta.success = (filasAfectadas > 0) ? true : false;
                respuesta.message = (filasAfectadas > 0) ? "Se ha eliminado correctamente." : "Ha ocurrido un error al Eliminar.";
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;
        }

        public RespuestaEntity GuardarFechaContabilizacionPorRendicion(GastoEntity item)
        {
            RespuestaEntity respuesta = new RespuestaEntity();
            try
            {
                RendicionesService serviceRE = new RendicionesService();
                serviceRE.itemUsuario = itemUsuario;
                serviceRE.ValidarContabilizar(item);
                int filasAfectadas = 0;
                base.Transaccion(delegate()
                {
                    foreach (GastoEntity itemGasto in item.Gastos)
                    {
                        Debug("GuardarFechaContabilizacionPorRendicion_ActualizarFechaContabilizacionPorRendicion", itemGasto);
                        _repositorio.ActualizarFechaContabilizacionPorRendicion(item.Rendiciones.docEntry, itemGasto, out filasAfectadas);
                    }
                });
                respuesta.success = (filasAfectadas > 0) ? true : false;
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;
        }

        public RespuestaEntity GuardarFechaContabilizacionPorCajaChica(GastoEntity item)
        {
            RespuestaEntity respuesta = new RespuestaEntity();
            try
            {
                CajaChicaService serviceCC = new CajaChicaService();
                serviceCC.itemUsuario = itemUsuario;
                serviceCC.ValidarContabilizar(item);
                int filasAfectadas = 0;
                base.Transaccion(delegate()
                {
                    foreach (GastoEntity itemGasto in item.Gastos)
                    {
                        Debug("GuardarFechaContabilizacionPorCajaChica_ActualizarFechaContabilizacionPorRendicion", itemGasto);
                        _repositorio.ActualizarFechaContabilizacionPorCajaChica(item.CajaChica.docEntry, itemGasto, out filasAfectadas);
                    }
                });
                respuesta.success = (filasAfectadas > 0) ? true : false;
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;
        }
        #endregion

        public RespuestaEntity<ProveedorEntity> BuscarProveedores(ProveedorEntity item)
        {
            RespuestaEntity<ProveedorEntity> respuesta = new RespuestaEntity<ProveedorEntity>();
            try
            {
                Debug("BuscarProveedores", String.Format("codigo = {0}, nombre = {1} tipoDocumento = {2}, numeroDocumento = {3}", item.codigo, item.nombre, item.tipoDocumento, item.nomTipoDocumento));
                respuesta.items = _repositorio.BuscarProveedores(item);
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;
        }

        public RespuestaEntity<ProveedorEntity> BuscarProveedor(String codigo)
        {
            RespuestaEntity<ProveedorEntity> respuesta = new RespuestaEntity<ProveedorEntity>();
            try
            {
                Debug("BuscarProveedor", String.Format("codigo = {0}", codigo));
                respuesta.item = _repositorio.BuscarProveedor(codigo);
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;
        }

        public RespuestaEntity<ContabilizarEntity> VerificarProveedores(GastoEntity item)
        {
            RespuestaEntity<ContabilizarEntity> respuesta = new RespuestaEntity<ContabilizarEntity>();
            try
            {
                Debug("VerificarProveedores", item);
                respuesta.items = _repositorio.VerificarProveedores(item);
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;
        }

        /// <summary>
        /// Busca las normas de reparto SAP
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public RespuestaEntity<CentroCostoEntity> BuscarCentroCostos(CentroCostoEntity item)
        {
            RespuestaEntity<CentroCostoEntity> respuesta = new RespuestaEntity<CentroCostoEntity>();
            try
            {
                Debug("BuscarCentroCostos", String.Format("codigo = {0}, nombre = {1}", item.codigo, item.nombre));
                respuesta.items = _repositorio.BuscarCentroCostos(item);
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;
        }

        /// <summary>
        /// Busca las normas de reparto SAP
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public RespuestaEntity<CentroCostoEntity> BuscarCentroCosto(String codigo)
        {
            RespuestaEntity<CentroCostoEntity> respuesta = new RespuestaEntity<CentroCostoEntity>();
            try
            {
                Debug("BuscarCentroCosto", String.Format("codigo = {0}", codigo));
                respuesta.item = _repositorio.BuscarCentroCosto(codigo);
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;
        }

        public RespuestaEntity<ImpuestoEntity> BuscarImpuestos(ImpuestoEntity item)
        {
            RespuestaEntity<ImpuestoEntity> respuesta = new RespuestaEntity<ImpuestoEntity>();
            try
            {
                Debug("BuscarImpuestos", String.Format("codigo = {0}, nombre = {1}", item.codigo, item.nombre));
                respuesta.items = _repositorio.BuscarImpuestos(item);
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;
        }

        public RespuestaEntity<ImpuestoEntity> BuscarImpuesto(String codigo)
        {
            RespuestaEntity<ImpuestoEntity> respuesta = new RespuestaEntity<ImpuestoEntity>();
            try
            {
                Debug("BuscarImpuesto", String.Format("codigo = {0}", codigo));
                respuesta.item = _repositorio.BuscarImpuesto(codigo);
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;
        }

        public RespuestaEntity<TipoDocumentoEntity> ListarTipoDocumentoDocumento()
        {
            RespuestaEntity<TipoDocumentoEntity> respuesta = new RespuestaEntity<TipoDocumentoEntity>();
            try
            {
                Debug("ListarTipoDocumentoDocumento", new GastoEntity());
                respuesta.items = _repositorio.ListarTipoDocumentoDocumento();
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;
        }

        public RespuestaEntity<TipoDocumentoEntity> ListarTipoDocumentoGasto()
        {
            RespuestaEntity<TipoDocumentoEntity> respuesta = new RespuestaEntity<TipoDocumentoEntity>();
            try
            {
                Debug("ListarTipoDocumentoGasto", new GastoEntity());
                respuesta.items = _repositorio.ListarTipoDocumentoGasto();
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;
        }

        public RespuestaEntity<ContabilizarEntity> VerificarArticulos(GastoEntity item)
        {
            RespuestaEntity<ContabilizarEntity> respuesta = new RespuestaEntity<ContabilizarEntity>();
            try
            {
                Debug("VerificarArticulos", item);
                respuesta.items = _repositorio.VerificarArticulos(item);
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;
        }

        public RespuestaEntity BuscarTipoCambio(String fecha)
        {
            RespuestaEntity respuesta = new RespuestaEntity();
            try
            {
                DateTime fechaDate = Convert.ToDateTime(fecha);
                fecha = fechaDate.ToString("yyyy-MM-dd");
                Debug("BuscarTipoCambio", String.Format("fecha = {0}", fecha));
                Decimal valorTipoCambio = Convert.ToDecimal(_repositorio.BuscarTipoCambio(fecha, "USD").valorTipoCambio);
                respuesta.extra = decimal.Round(valorTipoCambio, 3).ToString();
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;
        }
        //its - Joseph

        public RespuestaEntity Dimension01()
        {

            RespuestaEntity respuesta = new RespuestaEntity();

            try
            {
                String Dimension = Convert.ToString(_repositorio.Dimension01().Dimension1);
                respuesta.extra = Dimension;
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }

            return respuesta;


        }

        public RespuestaEntity Dimension02()
        {
            RespuestaEntity respuesta = new RespuestaEntity();

            try
            {
                String Dimension = Convert.ToString(_repositorio.Dimension02().Dimension2);
                respuesta.extra = Dimension;
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }

            return respuesta;
        }

        public RespuestaEntity Dimension03()
        {
            RespuestaEntity respuesta = new RespuestaEntity();

            try
            {
                String Dimension = Convert.ToString(_repositorio.Dimension03().Dimension3);
                respuesta.extra = Dimension;
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }

            return respuesta;
        }

        public RespuestaEntity Dimension04()
        {
            RespuestaEntity respuesta = new RespuestaEntity();

            try
            {
                String Dimension = Convert.ToString(_repositorio.Dimension04().Dimension4);
                respuesta.extra = Dimension;
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }

            return respuesta;
        }
        public RespuestaEntity Dimension05()
        {
            RespuestaEntity respuesta = new RespuestaEntity();

            try
            {
                String Dimension = Convert.ToString(_repositorio.Dimension05().Dimension5);
                respuesta.extra = Dimension;
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }

            return respuesta;
        }

        // its - Joseph Fin	   
        #region Debug
        public override void Debug(String metodo, GastoEntity item)
        {
            this.Debug(metodo, item, null);
        }

        public override void Debug(String metodo, GastoEntity item, String parametro = null)
        {
            StringBuilder parametros = new StringBuilder();
            if (!String.IsNullOrEmpty(parametro))
                parametros.Append(parametro);
            else
            {
                parametros.Append(String.Format("docEntry = {0}, ", item.docEntry));
                parametros.Append(String.Format("tipGasto = {0}, ", item.tipGasto));
                parametros.Append(String.Format("desGasto = {0}, ", item.desGasto));
                parametros.Append(String.Format("codProv = {0}, ", item.codProv));
                parametros.Append(String.Format("nomProv = {0}, ", item.nomProv));
                parametros.Append(String.Format("tipDocProv = {0}, ", item.tipDocProv));
                parametros.Append(String.Format("nroDocProv = {0}, ", item.nroDocProv));
                parametros.Append(String.Format("tipDoc {0}, ", item.tipDoc));
                parametros.Append(String.Format("serDoc = {0}, ", item.serDoc));
                parametros.Append(String.Format("corDoc = {0}, ", item.corDoc));
                parametros.Append(String.Format("monGasto = {0}, ", item.monGasto));
                parametros.Append(String.Format("fecha = {0}, ", item.fecha));
                parametros.Append(String.Format("moneda = {0}, ", item.moneda));
                parametros.Append(String.Format("tcespecial = {0} ", item.tcespecial));

                parametros.Append(String.Format("codCentroCosto1 = {0}, ", item.codCentroCosto1));
                parametros.Append(String.Format("nomCentroCosto1 = {0}, ", item.nomCentroCosto1));
                parametros.Append(String.Format("codCentroCosto2 = {0}, ", item.codCentroCosto2));
                parametros.Append(String.Format("nomCentroCosto2 = {0}, ", item.nomCentroCosto2));
                parametros.Append(String.Format("codCentroCosto3 = {0}, ", item.codCentroCosto3));
                parametros.Append(String.Format("nomCentroCosto3 = {0}, ", item.nomCentroCosto3));
                parametros.Append(String.Format("codCentroCosto4 = {0}, ", item.codCentroCosto4));
                parametros.Append(String.Format("nomCentroCosto4 = {0}, ", item.nomCentroCosto4));
                parametros.Append(String.Format("codCentroCosto5 = {0}, ", item.codCentroCosto5));
                parametros.Append(String.Format("nomCentroCosto5 = {0}, ", item.nomCentroCosto5));
                parametros.Append(String.Format("nomComentario = {0}, ", item.nomComentario));
                parametros.Append(String.Format("codEmp = {0}, ", item.codEmp));
                parametros.Append(String.Format("nomEmp = {0}, ", item.nomEmp));
                parametros.Append(String.Format("numPla = {0}, ", item.numPla));

                if (item.Impuesto != null)
                {
                    parametros.Append(", ");
                    parametros.Append(String.Format("Impuesto.codigo = {0}, ", item.Impuesto.codigo));
                    parametros.Append(String.Format("Impuesto.nombre = {0}, ", item.Impuesto.nombre));
                    parametros.Append(String.Format("Impuesto.cantidad = {0} ", item.Impuesto.cantidad));
                }
                if (item.Rendiciones != null)
                {
                    parametros.Append(", ");
                    parametros.Append(String.Format("Rendicion.docEntry = {0}, ", item.Rendiciones.docEntry));
                    parametros.Append(String.Format("Rendicion.nroRen = {0}, ", item.Rendiciones.nroRen));
                    parametros.Append(String.Format("Rendicion.codEmp = {0}, ", item.Rendiciones.codEmp));
                    parametros.Append(String.Format("Rendicion.nomEmp = {0}, ", item.Rendiciones.nomEmp));
                    parametros.Append(String.Format("Rendicion.nroOT = {0}, ", item.Rendiciones.nroOT));
                    parametros.Append(String.Format("Rendicion.fecha = {0}, ", item.Rendiciones.fecha));
                    parametros.Append(String.Format("Rendicion.aprob = {0}, ", item.Rendiciones.aprob));
                    parametros.Append(String.Format("Rendicion.estado = {0}, ", item.Rendiciones.estado));
                    parametros.Append(String.Format("Rendicion.fechaDesde = {0}, ", item.Rendiciones.fechaDesde));
                    parametros.Append(String.Format("Rendicion.fechaHasta = {0} ", item.Rendiciones.fechaHasta));
                }
                if (item.CajaChica != null)
                {
                    parametros.Append(", ");
                    parametros.Append(String.Format("CajaChica.docEntry = {0}, ", item.CajaChica.docEntry));
                    parametros.Append(String.Format("CajaChica.nroRen = {0}, ", item.CajaChica.nroCC));
                    parametros.Append(String.Format("CajaChica.codEmp = {0}, ", item.CajaChica.nroOT));
                    parametros.Append(String.Format("CajaChica.nomEmp = {0}, ", item.CajaChica.totalCaja));
                    parametros.Append(String.Format("CajaChica.nroOT = {0}, ", item.CajaChica.moneda));
                    parametros.Append(String.Format("CajaChica.fecha = {0}, ", item.CajaChica.fechaCierre));
                    parametros.Append(String.Format("CajaChica.aprob = {0}, ", item.CajaChica.aprob));
                    parametros.Append(String.Format("CajaChica.estado = {0} ", item.CajaChica.estado));
                }
            }
            //base.Debug("Models.Service.Tesoreria.GastoService.cs", metodo, parametros.ToString().Trim());
        }
        #endregion
    }
}
