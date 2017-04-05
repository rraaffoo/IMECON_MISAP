using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MISAP.Entity;
using MISAP.Repository;
using SAPbobsCOM;


namespace MISAP.Service
{
    public class CajaChicaService : TesoreriaBaseService<CajaChicaEntity>
    {
        private CajaChicaRepository _repositorio;

        public CajaChicaService()
            : base(new CajaChicaRepository())
        {
            _repositorio = new CajaChicaRepository();
        }
        string ot, proy;
        #region CajaChica
        public override RespuestaEntity Guardar(CajaChicaEntity item)
        {
            RespuestaEntity respuesta = new RespuestaEntity();
            try
            {
                String mensaje = String.Empty;
                int docEntry = 0, filasAfectadas = 0;
                docEntry = item.docEntry;
                if (docEntry > 0) Validar(item);
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
                        if (docEntry == 0) mensaje = "Ya existe el registro.";
                        else
                        {
                            mensaje = "Se ha modificado Correctamente.";
                            if (item.estado == "C") mensaje = "Se cerró correctamente.";
                            if (item.estado == "N") mensaje = "Se anuló correctamente.";
                        }
                        if (filasAfectadas > 0 && item.estado == "C") LlamarTareas(String.Format("{0} {1} {2} {3} {4}", "CC_Cerrado", item.Usuario.Proyecto.codProy, docEntry, itemUsuario.nomUsu, itemUsuario.Proyecto.nomProy));
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

        internal void Validar(CajaChicaEntity item, Boolean gasto = false, Boolean contabilizar = false)
        {
            //Debug("Validar_Detalle", item);
            //CajaChicaEntity itemCC = _repositorio.Detalle(item.docEntry);
            //if (itemCC.aprob == "1")
            //    throw new Exception("La Caja Chica esta Contabilizada. No se ha modificado.");
            ///* CajaChica: No puede actualizar
            //Gasto: Solo puede registrar, modificar y eliminar cuando la caja chica tenga estado pendiente.
            //Contabilizar: No puede contabilizar. */
            //if (!item.Usuario.Proyecto.Rol.isContab && !item.Usuario.Proyecto.Rol.isSupervisor)
            //{
            //    if (itemCC.estado != EstadoEnum.Pendiente.GetName() && !gasto)
            //        throw new Exception(String.Format("La Caja Chica tiene estado {0}. No se ha modificado.", itemCC.nomEstado));
            //    if (itemCC.estado != EstadoEnum.Pendiente.GetName() || item.estado != EstadoEnum.Pendiente.GetName() && !gasto)
            //        throw new Exception(String.Format("La Caja Chica tiene estado {0}. No se ha modificado.", itemCC.nomEstado));

            //}
            //else
            //{/*
            //CajaChica: Solo puede actualizar, cuando la caja chica tenga estado pendiente.
            //Gasto: No puede registrar,  modificar o eliminar.
            //Contabilizar: Solo puede contabilizar cuando la caja chica tenga estado cerrado.
            //if (item.Usuario.Proyecto.Rol.isContab)
            //{
            //   if (gasto)
            //      throw new Exception(String.Format("La Caja Chica tiene estado {0}. No se ha modificado.", itemCC.nomEstado));
            //   if ((itemCC.estado != EstadoEnum.Pendiente.GetName() || item.estado != EstadoEnum.Pendiente.GetName()) && !contabilizar)
            //      throw new Exception(String.Format("La Caja Chica tiene estado {0}. No se ha modificado.", itemCC.nomEstado));
            //   if ((itemCC.estado != EstadoEnum.Cerrado.GetName() || item.estado != EstadoEnum.Cerrado.GetName()) && contabilizar)
            //      throw new Exception(String.Format("La Caja Chica tiene estado {0}. No se ha modificado.", itemCC.nomEstado));
            //}
            //if (item.Usuario.Proyecto.Rol.isSupervisor)
            //{
            //    CajaChica: Puede actualizar cuando la caja chica tenga estado pendiente y cerrado.
            //   Gasto: No puede registrar,  modificar o eliminar.
            //   Contabilizar: No puede contabilizar.
            //   if (gasto || contabilizar) 
            //      throw new Exception(String.Format("La Caja Chica tiene estado {0}. No se ha modificado.", itemCC.nomEstado));
            //   if (itemCC.estado == EstadoEnum.Anulado.GetName() || item.estado == EstadoEnum.Anulado.GetName())
            //      throw new Exception(String.Format("La Caja Chica tiene estado {0}. No se ha modificado.", itemCC.nomEstado));
            //   //if ((itemCC.estado == EstadoEnum.Pendiente.GetName() && item.estado == EstadoEnum.Pendiente.GetName())
            //   //    || (itemCC.estado == EstadoEnum.Cerrado.GetName() && item.estado == EstadoEnum.Cerrado.GetName()))
            //   //   throw new Exception(String.Format("La Caja Chica tiene estado {0}. No se ha modificado.", itemCC.nomEstado));
            //}*/
            //}
            //if (item.estado == EstadoEnum.Cerrado.GetName())
            //{
            //    List<CajaChicaEntity> items = _repositorio.BuscarCajasChicasVecinas(item.Usuario.Proyecto.codProy, item.docEntry);
            //    CajaChicaEntity itemCC2;

            //    itemCC = (from c in items where !c.tiempoFecha() select c)
            //       .ToList()
            //       .FirstOrDefault();
            //    itemCC2 = (from c in items where c.tiempoFecha() select c)
            //       .ToList()
            //       .FirstOrDefault();

            //    if (itemCC != null && itemCC.docEntry > 0)
            //    {
            //        if (item.fechaCierre <= itemCC.fechaCierre)
            //            throw new Exception(String.Format("La Fecha de Cierre debe ser mayor que la Fecha de Cierre de la Caja Chica con Nro {0}. No se ha modificado.", itemCC.nroCC));
            //    }
            //    if (itemCC2 != null && itemCC2.docEntry > 0)
            //    {
            //        if (item.fechaCierre >= itemCC2.fechaCierre)
            //            throw new Exception(String.Format("La Fecha de Cierre debe ser menor que la Fecha de Cierre de la Caja Chica con Nro {0}. No se ha modificado.", itemCC2.nroCC));
            //    }
            //}
        }

        public override RespuestaEntity<CajaChicaEntity> Buscar(CajaChicaEntity item, PaginadorEntity paginador)
        {
            RespuestaEntity<CajaChicaEntity> respuesta = new RespuestaEntity<CajaChicaEntity>();
            try
            {
                //Debug("Buscar", item);
                //List<CajaChicaEntity> items = _repositorio.Buscar(item, paginador);
                //items.ForEach(t =>
                //{
                //    t.fechaCierre = ((t.fechaCierre == DateTime.MinValue) ? null : t.fechaCierre);
                //    t.nomContabilizado = ((t.aprob == "1") ? "Si" : "No");
                //});
                //respuesta.items = items;

            }
            catch (Exception ex)
            {
                //Error(ex);
                //respuesta.SetMessage(ex);
            } return respuesta;
        }

        public RespuestaEntity Contabilizar(CajaChicaEntity item, Company oCompany)
        {
            int numDIm = (itemUsuario != null && itemUsuario.Dimensiones != null) ?
            itemUsuario.Dimensiones.Count :
            5;

            RespuestaEntity respuesta = new RespuestaEntity();
            try
            {
                ValidarContabilizar(new GastoEntity() { CajaChica = item });

                int errCode = 0, filasAfectadas = 0, i;
                Decimal montoRetencion = 0;
                String errMsj = String.Empty;

                Debug("Contabilizar_Detalle", String.Format("docEntry = {0}", item.docEntry));
                CajaChicaEntity itemCajaChica = _repositorio.Detalle(item.docEntry);
                Debug("Contabilizar_BuscarGastosPorCajaChica", String.Format("docEntry = {0}", item.docEntry));
                List<GastoEntity> itemsGasto = new GastoRepository().BuscarGastosPorCajaChica(item.docEntry);
                itemsGasto.ForEach(t =>
                {
                    Debug("Contabilizar_BuscarGastosDetallePorGasto", String.Format("docEntry = {0}, codAlm = {1}", t.docEntry, item.Usuario.Proyecto.codAlm));
                    t.GastosDetalle = new GastoDetalleRepository().BuscarGastosDetallePorGasto(t.docEntry, item.Usuario.Proyecto.codAlm);
                });

                //Obtener Cabeceras - Detalle de Gastos Sustentados
                List<GastoEntity> itemsGastoD = (from c in itemsGasto where c.tipGasto == "D" select c).ToList();

                //Obtener Cabeceras - Detalle de Gastos No Sustentados
                List<GastoEntity> itemsGastoG = (from c in itemsGasto where c.tipGasto == "G" select c).ToList();

                oCompany.StartTransaction();
                #region Gastos sustentados
                //Registrar Cabeceras - Detalle Gastos Sustentados
                Documents oPurchase;

                foreach (GastoEntity itemGastoD in itemsGastoD)
                {
                    oPurchase = (Documents)oCompany.GetBusinessObject(BoObjectTypes.oPurchaseInvoices);
                    oPurchase.DocType = BoDocumentTypes.dDocument_Items;
                    oPurchase.HandWritten = BoYesNoEnum.tNO;
                    oPurchase.DocDate = itemGastoD.fechaContabilizacion.Value;
                    oPurchase.CardCode = itemGastoD.codProv;
                    oPurchase.CardName = itemGastoD.nomProv;

                    oPurchase.Project = item.Usuario.Proyecto.codProy;
                    oPurchase.NumAtCard = String.Format("{0}{1}-{2}", itemGastoD.tipDoc, itemGastoD.serDoc, itemGastoD.corDoc);
                    oPurchase.DocCurrency = itemGastoD.moneda;
                    if (itemGastoD.moneda == "USD")
                        oPurchase.DocRate = (Double)itemGastoD.tcespecial;
                    itemGastoD.nomProv = itemGastoD.nomProv.Trim();
                    oPurchase.JournalMemo = itemGastoD.nomProv.Substring(0, (itemGastoD.nomProv.Length < 50 ? itemGastoD.nomProv.Length : 50));
                    oPurchase.PaymentGroupCode = -1;
                    oPurchase.GroupNumber = -1;
                    oPurchase.SalesPersonCode = -1;
                    oPurchase.TransportationCode = -1;
                    oPurchase.PartialSupply = BoYesNoEnum.tYES;
                    oPurchase.Confirmed = BoYesNoEnum.tYES;
                    oPurchase.SummeryType = BoDocSummaryTypes.dNoSummary;
                    oPurchase.ContactPersonCode = 0;
                    oPurchase.ShowSCN = BoYesNoEnum.tNO;
                    oPurchase.TaxDate = itemGastoD.fecha;
                    oPurchase.Address2 = "PERU";
                    oPurchase.Rounding = BoYesNoEnum.tNO;
                    oPurchase.RevisionPo = BoYesNoEnum.tNO;
                    oPurchase.Pick = BoYesNoEnum.tNO;
                    oPurchase.BlockDunning = BoYesNoEnum.tNO;
                    oPurchase.PaymentBlock = BoYesNoEnum.tNO;
                    oPurchase.MaximumCashDiscount = BoYesNoEnum.tYES;
                    oPurchase.DeferredTax = BoYesNoEnum.tNO;
                    oPurchase.IsPayToBank = BoYesNoEnum.tNO;
                    oPurchase.UseCorrectionVATGroup = BoYesNoEnum.tNO;
                    oPurchase.OpenForLandedCosts = BoYesNoEnum.tYES;
                    oPurchase.InsuranceOperation347 = BoYesNoEnum.tNO;
                    oPurchase.ClosingOption = ClosingOptionEnum.coByCurrentSystemDate;
                    oPurchase.NTSApproved = BoYesNoEnum.tNO;
                    oPurchase.ExtraMonth = 0;
                    oPurchase.ExtraDays = 0;
                    oPurchase.CashDiscountDateOffset = 0;
                    oPurchase.CreateOnlineQuotation = BoYesNoEnum.tNO;
                    oPurchase.IsAlteration = BoYesNoEnum.tNO;
                    oPurchase.PrintSEPADirect = BoYesNoEnum.tNO;
                    oPurchase.Comments = itemGastoD.nomComentario;
                    if (itemGastoD.retencion != null)
                    {
                        montoRetencion = itemGastoD.monGasto * itemGastoD.retencion.Value;
                        oPurchase.WithholdingTaxData.SetCurrentLine(0);
                        if (itemGastoD.moneda == "SOL")
                        {
                            oPurchase.WithholdingTaxData.TaxableAmount = Convert.ToDouble(itemGastoD.monGasto);
                            oPurchase.WithholdingTaxData.WTAmount = Convert.ToDouble(montoRetencion);
                        }
                        else if (itemGastoD.moneda == "USD")
                        {
                            oPurchase.WithholdingTaxData.TaxableAmountFC = Convert.ToDouble(itemGastoD.monGasto);
                            oPurchase.WithholdingTaxData.WTAmountFC = Convert.ToDouble(montoRetencion);
                        }
                    }
                    oPurchase.UserFields.Fields.Item("U_BPV_SERI").Value = String.Format("{0}-{1}", itemGastoD.serDoc, itemGastoD.tipDoc);
                    oPurchase.UserFields.Fields.Item("U_BPV_NCON2").Value = itemGastoD.corDoc;
                    oPurchase.UserFields.Fields.Item("U_BPP_MDTD").Value = itemGastoD.tipDoc;
                    oPurchase.UserFields.Fields.Item("U_OK1_Anulada").Value = "N";
                    oPurchase.UserFields.Fields.Item("U_BPP_MDTS").Value = "TSI";
                    oPurchase.UserFields.Fields.Item("U_BPP_CDAD").Value = "0";
                    oPurchase.UserFields.Fields.Item("U_BPP_MDBI").Value = "A";
                    oPurchase.UserFields.Fields.Item("U_BPP_MDCD").Value = itemGastoD.corDoc;
                    oPurchase.UserFields.Fields.Item("U_BPP_MDSD").Value = itemGastoD.serDoc;
                    oPurchase.UserFields.Fields.Item("U_VS_FLGCOTIZA").Value = "N";
                    oPurchase.UserFields.Fields.Item("U_VS_SDOCTOTAL").Value = "0.00";
                    oPurchase.UserFields.Fields.Item("U_VS_USRSV").Value = "N";
                    oPurchase.UserFields.Fields.Item("U_VS_METVAL").Value = "N";
                    oPurchase.UserFields.Fields.Item("U_LN_TIPOCAP").Value = "-";
                    oPurchase.UserFields.Fields.Item("U_VS_AFEDET").Value = "N";
                    oPurchase.UserFields.Fields.Item("U_VS_PORDET").Value = "0.00";
                    oPurchase.UserFields.Fields.Item("U_VS_APLANT").Value = "Y";
                    oPurchase.UserFields.Fields.Item("U_VS_CODSER").Value = String.Empty;
                    oPurchase.UserFields.Fields.Item("U_NUMCC").Value = String.Format("{0}{1}", itemCajaChica.idCC(), itemCajaChica.correlativoCC());

                    i = 0;
                    foreach (GastoDetalleEntity itemGastoDetalleD in itemGastoD.GastosDetalle)
                    {
                        i++;
                        if (i > 1)
                            oPurchase.Lines.Add();

                        oPurchase.Lines.LineStatus = BoStatus.bost_Open;
                        oPurchase.Lines.ItemCode = itemGastoDetalleD.codArt;
                        oPurchase.Lines.ItemDescription = itemGastoDetalleD.desArt;
                        oPurchase.Lines.Quantity = Convert.ToDouble(itemGastoDetalleD.cant);
                        oPurchase.Lines.Price = Convert.ToDouble(itemGastoDetalleD.precio);
                        //     oPurchase.Lines.ProjectCode = item.Usuario.Proyecto.codProy;


                        oPurchase.Lines.Currency = itemGastoD.moneda;
                        if (itemGastoD.moneda == "USD")
                            oPurchase.Lines.Rate = (Double)itemGastoD.tcespecial;
                        oPurchase.Lines.WarehouseCode = item.Usuario.Proyecto.codAlm;
                        oPurchase.Lines.WTLiable = itemGastoD.retencion != null ? BoYesNoEnum.tYES : BoYesNoEnum.tNO;
                        oPurchase.Lines.UseBaseUnits = BoYesNoEnum.tNO;
                        oPurchase.Lines.TaxType = BoTaxTypes.tt_Yes;
                        oPurchase.Lines.FreeText = itemGastoDetalleD.desArt;
                        oPurchase.Lines.DeferredTax = BoYesNoEnum.tNO;
                        oPurchase.Lines.TaxCode = itemGastoD.Impuesto.codigo;
                        oPurchase.Lines.ShipToDescription = "PERU";
                        oPurchase.Lines.TaxOnly = BoYesNoEnum.tNO;


                        // centro de costos, mapear aqui
                        oPurchase.Lines.ProjectCode = itemGastoDetalleD.codProy;

                        if (itemGastoDetalleD.codProy == "PCF")
                        {
                            oPurchase.Lines.COGSCostingCode = itemGastoDetalleD.nroOT; //dimension 1 cf
                            oPurchase.Lines.CostingCode = itemGastoDetalleD.nroOT;

                            ot = itemGastoDetalleD.nroOT;
                            proy = itemGastoDetalleD.codProy;
                        }
                        else
                        {
                            oPurchase.Lines.COGSCostingCode2 = itemGastoDetalleD.nroOT;//dimesion 2 otf otm
                            oPurchase.Lines.CostingCode2 = itemGastoDetalleD.nroOT;
                            ot = itemGastoDetalleD.nroOT;
                            proy = itemGastoDetalleD.codProy;
                        }


                        //oPurchase.Lines.CostingCode = itemGastoDetalleD.codCentroCosto1;
                        //if (numDIm > 1)
                        //   oPurchase.Lines.CostingCode2 = itemGastoDetalleD.codCentroCosto2;
                        //if (numDIm > 2)
                        //   oPurchase.Lines.CostingCode3 = itemGastoDetalleD.codCentroCosto3;
                        //if (numDIm > 3)
                        //   oPurchase.Lines.CostingCode4 = itemGastoDetalleD.codCentroCosto4;
                        //if (numDIm > 4)
                        //   oPurchase.Lines.CostingCode5 = itemGastoDetalleD.codCentroCosto5;

                        oPurchase.Lines.UserFields.Fields.Item("U_BPP_OPER").Value = "A";
                        oPurchase.Lines.UserFields.Fields.Item("U_tipoOpT12").Value = "02";
                        oPurchase.Lines.UserFields.Fields.Item("U_VS_TIPSAP").Value = "--";
                        oPurchase.Lines.UserFields.Fields.Item("U_VS_MNTPRCP").Value = "0.00";
                        oPurchase.Lines.UserFields.Fields.Item("U_VS_MNTCBRD").Value = "0.00";
                        oPurchase.Lines.UserFields.Fields.Item("U_VS_DOCSI").Value = "N";
                        oPurchase.Lines.UserFields.Fields.Item("U_BPP_CTAD").Value = itemGastoDetalleD.cuentadestino;
                        oPurchase.Lines.UserFields.Fields.Item("U_VS_DOCTOTAL").Value = "0.00";

                        if (itemGastoD.idUbicacion > 0)
                        {
                            oPurchase.Lines.BinAllocations.SetCurrentLine(0);
                            oPurchase.Lines.BinAllocations.Quantity = Convert.ToDouble(itemGastoDetalleD.cant);
                            oPurchase.Lines.BinAllocations.BinAbsEntry = itemGastoD.idUbicacion;
                            oPurchase.Lines.BinAllocations.BaseLineNumber = i - 1;
                        }
                    }

                    errCode = oPurchase.Add();
                    if (errCode != 0)
                    {
                        oCompany.GetLastError(out errCode, out errMsj);

                        throw new Exception(errMsj);
                    }
                }
                #endregion

                #region Gastos No sustentados
                //Registrar Cabeceras - Detalle Gastos No Sustentados
                Payments oPago;
                foreach (GastoEntity itemGastoG in itemsGastoG)
                {
                    oPago = (Payments)oCompany.GetBusinessObject(BoObjectTypes.oVendorPayments);
                    oPago.DocType = BoRcptTypes.rAccount;
                    oPago.HandWritten = BoYesNoEnum.tNO;
                    oPago.DocDate = itemGastoG.fechaContabilizacion.Value;
                    oPago.TaxDate = itemGastoG.fecha;
                    oPago.CardCode = itemGastoG.nomTipDoc.Substring(0, (itemGastoG.nomTipDoc.Length < 15 ? itemGastoG.nomTipDoc.Length : 15));
                    oPago.CashAccount = itemGastoG.codCuenta;
                    oPago.CashSum = (Double)itemGastoG.monGasto;
                    oPago.Remarks = itemGastoG.nomComentario;
                    oPago.DocCurrency = itemGastoG.moneda;




                    if (itemGastoG.moneda == "USD")
                        oPago.DocRate = (Double)itemGastoG.tcespecial;
                    oPago.ApplyVAT = BoYesNoEnum.tNO;
                    oPago.ProjectCode = item.Usuario.Proyecto.codProy;

                    oPago.UserFields.Fields.Item("U_VS_PAGFAC").Value = "N";
                    oPago.UserFields.Fields.Item("U_VS_USRSV").Value = "N";
                    oPago.UserFields.Fields.Item("U_VS_TIPOPAGO").Value = "01";
                    oPago.UserFields.Fields.Item("U_RetUser").Value = "N";
                    oPago.UserFields.Fields.Item("U_VS_SAIGV").Value = "01";
                    oPago.UserFields.Fields.Item("U_BPP_EFEC").Value = "999";
                    oPago.UserFields.Fields.Item("U_CLASEOP").Value = "GPC";
                    //oPago.UserFields.Fields.Item("U_NROOP").Value = itemCajaChica.nroCC;
                    oPago.UserFields.Fields.Item("U_NROOP").Value = String.Format("{0}{1}", itemCajaChica.idCC(), itemCajaChica.correlativoCC());
                    oPago.AccountPayments.AccountCode = itemGastoG.tipDocCuenta;
                    oPago.AccountPayments.Decription = itemGastoG.nomTipDoc;
                    oPago.AccountPayments.ProjectCode = item.Usuario.Proyecto.codProy;
                    oPago.AccountPayments.SumPaid = Convert.ToDouble(itemGastoG.monGasto);
                    oPago.AccountPayments.UserFields.Fields.Item("U_BPP_CTAD").Value = itemGastoG.tipDocCuentaDestino;

                    // nuevos campos
                    oPago.UserFields.Fields.Item("U_NRODOCOP").Value = itemGastoG.numPla;
                    oPago.CardName = itemGastoG.nomEmp;
                    oPago.AccountPayments.UserFields.Fields.Item("U_BPP_IDEMP").Value = itemGastoG.codEmp;

                    oPago.AccountPayments.Add();
                    errCode = oPago.Add();
                    if (errCode != 0)
                    {
                        oCompany.GetLastError(out errCode, out errMsj);
                        throw new Exception(errMsj);
                    }
                }
                #endregion

                oCompany.EndTransaction(BoWfTransOpt.wf_Commit);

                if (errCode != 0)
                {
                    oCompany.GetLastError(out errCode, out errMsj);
                    throw new Exception(errMsj + "estoy adentro" + ot + " " + proy);
                }

                Debug("Contabilizar_Contabilizar", String.Format("docEntry = {0}", item.docEntry));
                if (errCode == 0)
                    _repositorio.Contabilizar(item.docEntry, out filasAfectadas);

                respuesta.success = (errCode == 0);
                respuesta.message = (errCode == 0) ? "La Caja Chica ha sido Contabilizada Correctamente." : errMsj;
            }
            catch (Exception ex)
            {
                //Error(ex);
                respuesta.SetMessage(ex);
            }
            return respuesta;
        }

        internal void ValidarContabilizar(GastoEntity item)
        {
            Validar(item.CajaChica, false, true);
            GastoService serviceGC = new GastoService();
            try
            {
                List<ContabilizarEntity> items;
                serviceGC.itemUsuario = itemUsuario;

                items = serviceGC.VerificarArticulos(item).items;
                if (items.Count > 0)
                    throw new Exception("Existen Artículos que no están registrados en SAP.");

                items = serviceGC.VerificarProveedores(item).items;
                if (items.Count > 0)
                    throw new Exception("Existen Proveedores que no están registrados en SAP.");
            }
            //catch (Exception)
            //{
            //   throw;
            //}
            finally
            {
                serviceGC.Dispose();
            }
        }
        #endregion

        #region Debug
        public override void Debug(String metodo, CajaChicaEntity item)
        {
            this.Debug(metodo, item, null);
        }

        public override void Debug(String metodo, CajaChicaEntity item, String parametro = null)
        {
            StringBuilder parametros = new StringBuilder();
            if (!String.IsNullOrEmpty(parametro))
                parametros.Append(parametro);
            else
            {
                parametros.Append(String.Format("docEntry = {0}, ", item.docEntry));
                parametros.Append(String.Format("nroRen = {0}, ", item.nroCC));
                parametros.Append(String.Format("codEmp = {0}, ", item.nroOT));
                parametros.Append(String.Format("nomEmp = {0}, ", item.totalCaja));
                parametros.Append(String.Format("nroOT = {0}, ", item.moneda));
                parametros.Append(String.Format("fecha = {0}, ", item.fechaCierre));
                parametros.Append(String.Format("aprob = {0}, ", item.aprob));
                parametros.Append(String.Format("estado = {0} ", item.estado));
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
            //base.Debug("Models.Service.Tesoreria.CajaChicaService.cs", metodo, parametros.ToString().Trim());
        }
        #endregion
    }
}
