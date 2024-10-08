using Dinet.Integration.Domain.Common.Constants;
using Dinet.Integration.Domain.Wrapper.Interfaces.Documento;
using Dinet.Integration.Domain.Wrapper.Interfaces.General;
using Dinet.Integration.Domain.Wrapper.External.Document;
using Dinet.Integration.WebApi.DynamicClient;
using System;
using System.Collections.Generic;
using System.Linq;
using log4net;
using Newtonsoft.Json;

namespace Dinet.Integration.WebApi.Areas.Interfaces.Contexts
{
    /// <summary>
    /// 
    /// </summary>
    public class DocumentContext
    {
        #region [Properties]
        ILog logService = LogManager.GetLogger("Integration");
        #endregion

        #region [Constructor]
        /// <summary>
        /// Constructor de implementación de la clase
        /// </summary>
        public DocumentContext()
        {

        }
        #endregion

        #region [Methods]
        /// <summary>
        /// Método que permite registrar los documentos
        /// </summary>
        /// <param name="itemRequest">Representa los parametros del registro de documento</param>
        /// <returns>Retorna la respuesta de la peticion</returns>
        public DocumentResponse Register(DocumentRequest itemRequest)
        {
            DocumentResponse result = new DocumentResponse();
            
            try
            {
                #region[Validation Request]
                if (itemRequest == null)
                    throw new Exception("Request Body no debe ser nulo");

                string messageValidation = string.Empty;

                if (string.IsNullOrEmpty(itemRequest.Account.Trim()))
                    messageValidation = messageValidation + "El parámetro " + "'Account'" + " enviado por el cliente no puede ser vacio o nulo. \n";
                else if (itemRequest.Account.Length > 5)
                    messageValidation = "El parámetro " + "'Account'" + " debe tener un máximo de 5 caracteres. \n";

                if (string.IsNullOrEmpty(itemRequest.NumberDocument.Trim()))
                    messageValidation = messageValidation + "El parámetro " + "'NumberDocument'" + " enviado por el cliente no puede ser vacio o nulo. \n";
                else if (itemRequest.NumberDocument.Length > 500)
                    messageValidation = messageValidation + "El parámetro " + "'NumberDocument'" + " debe tener un máximo de 500 caracteres. \n";

                if (!itemRequest.DateIssue.HasValue)
                    messageValidation = messageValidation + "El parámetro " + "'DateIssue'" + " enviado por el cliente no puede ser vacio o nulo. \n";

                if (string.IsNullOrEmpty(itemRequest.NameEntityDestination.Trim()))
                    messageValidation = messageValidation + "El parámetro " + "'NameEntityDestination'" + " enviado por el cliente no puede ser vacio o nulo. \n";
                else if (itemRequest.NameEntityDestination.Length > 60)
                    messageValidation = messageValidation + "El parámetro " + "'NameEntityDestination'" + " debe tener un máximo de 60 caracteres. \n";

                if (string.IsNullOrEmpty(itemRequest.AddressDestination.Trim()))
                    messageValidation = messageValidation + "El parámetro " + "'AddressDestination'" + " enviado por el cliente no puede ser vacio o nulo. \n";
                else if (itemRequest.AddressDestination.Length > 500)
                    messageValidation = messageValidation + "El parámetro " + "'AddressDestination'" + " debe tener un máximo de 500 caracteres. \n";

                if (!messageValidation.Equals(string.Empty))
                    throw new Exception(messageValidation);
                #endregion

                #region [PedidoDetalleRequest]
                List<DocumentoDetalleRequest> oDocumentoDetalleRequest = new List<DocumentoDetalleRequest>();

                if (itemRequest.DetailRequest != null && itemRequest.DetailRequest.Count() > 0)
                {
                    foreach (var itemDetail in itemRequest.DetailRequest)
                    {
                        oDocumentoDetalleRequest.Add(new DocumentoDetalleRequest
                        {
                            SNRO_DOC = itemRequest.NumberDocument,
                            NCORR_INTERNO = itemDetail.InternalCorrelative,
                            SCORR_CLIE = itemDetail.CorrelativeClient,
                            SCOD_ARTICULO = itemDetail.CodeArticle,
                            SDES_ARTICULO = itemDetail.DescriptionArticle,
                            SUNIDAD_MED = itemDetail.UnitSize,
                            NCANTIDAD = itemDetail.Quantity,
                            NPESO = itemDetail.Weight,
                            NVOLUMEN = itemDetail.Volume,
                            SSERIE_LOTE = itemDetail.BatchSeries,
                            SCOD_LINEA = itemDetail.CodeLine,
                            SCOD_CLASE = itemDetail.CodeClass,
                            SCOD_SUB_CLASE = itemDetail.CodeSubClass,
                            SNOM_LINEA = itemDetail.NameLine,
                            SNOM_CLASE = itemDetail.NameClass,
                            SNOM_SUB_CLASE = itemDetail.NameSubClass,
                            SFLAG_IQPF = itemDetail.FlagIQPF,
                            SCOMODIN1 = itemDetail.Wildcard1,
                            SCOMODIN2 = itemDetail.Wildcard2,
                            SCOMODIN3 = itemDetail.Wildcard3
                        });
                    }
                }
                #endregion

                #region [PedidoLpnRequest]
                List<DocumentoLpnRequest> oDocumentoLpnRequest = new List<DocumentoLpnRequest>();

                if (itemRequest.LpnRequest != null && itemRequest.LpnRequest.Count() > 0)
                {
                    foreach (var itemLpn in itemRequest.LpnRequest)
                    {
                        oDocumentoLpnRequest.Add(new DocumentoLpnRequest
                        {
                            NumeroDocumento = itemRequest.NumberDocument,
                            CorrelativoInterno = itemLpn.InternalCorrelative,
                            Lpn = itemLpn.Lpn,
                            Cantidad = itemLpn.Quantity
                        });
                    }
                }
                #endregion

                #region [ConfiguracionEquivalenciaListar]
                int flagUbigeoPedido = 0;
                var listConfiguracionEquivalencia = ConfiguracionEquivalenciaListar(itemRequest.Account);

                if (listConfiguracionEquivalencia.Count() > 0)
                    flagUbigeoPedido = listConfiguracionEquivalencia.FirstOrDefault().FlagUbigeoPedido;
                #endregion

                #region [EquivalenciaUbigeo]
                string codigoUbigeo = "";
                if (Convert.ToBoolean(flagUbigeoPedido))
                {
                    if (string.IsNullOrEmpty(itemRequest.UbigeoDestination) && (string.IsNullOrEmpty(itemRequest.Departamento) && string.IsNullOrEmpty(itemRequest.Provincia) && string.IsNullOrEmpty(itemRequest.Distrito)))
                        throw new Exception("Codigo ubigeo enviado por el cliente es vacio o nulo.");

                    //Validación de UbigeoDestination, para no realizar equivalencia 
                    if (!string.IsNullOrEmpty(itemRequest.UbigeoDestination))
                    {
                        var listEquivalenciaUbigeo = EquivalenciaUbigeoListar(itemRequest.Account);

                        if (listEquivalenciaUbigeo.Count() == 0)
                            throw new Exception("No se encontro configuracion de equivalencia ubigeo.");

                        var itemEquivalenciaUbigeo = listEquivalenciaUbigeo.Where(x => x.CodigoUbigeoCliente == itemRequest.UbigeoDestination && x.Tipo == Enumerated.DocumentType.Pedido).FirstOrDefault();

                        if (itemEquivalenciaUbigeo == null)
                            throw new Exception("No se encontro configuracion de equivalencia para el codigo ubigeo " + itemRequest.UbigeoDestination + ".");

                        if (!string.IsNullOrEmpty(itemEquivalenciaUbigeo.CodigoUbigeoD4W))
                            codigoUbigeo = itemEquivalenciaUbigeo.CodigoUbigeoD4W;
                        else
                            throw new Exception("Codigo ubigeo vacio o nulo en la tabla de configuracion de equivalencia.");
                    }
                }
                else
                {
                    codigoUbigeo = itemRequest.UbigeoDestination;
                }
                #endregion

                #region [Invoke - WebService]
                var resultWS = InterfacesClient.DocumentoRegistrar(new DocumentoRequest
                {
                    CUENTA = itemRequest.Account,
                    NRO_DOCU = itemRequest.NumberDocument,
                    TIPO_DOCU = itemRequest.TypeDocument,
                    NRO_PEDIDO = itemRequest.NumberOrder,
                    TIPO_DOCU_REF = itemRequest.TypeDocumentReference,
                    NRO_DOCU_REF = itemRequest.NumberDocumentReference,
                    NRO_DOCU_REF_ALM = itemRequest.NumberDocumentReferenceAlm,
                    NRO_DOCU_REF_TRAN = itemRequest.NumberDocReferenceTra,
                    FLAG_CITA = itemRequest.FlagAppointment,
                    TIPO_ATENCION = itemRequest.TypeAttention,
                    F_EMISION = itemRequest.DateIssue,
                    F_EST_RECOJO = itemRequest.DateEstimatedIssue,
                    F_EST_ENT = itemRequest.DateEstimateDelivery,
                    TIPO_ORIG = itemRequest.TypeOrigin,
                    COD_ENT_ORIG = itemRequest.CodeEntityOrigin,
                    NOM_ENT_ORIG = itemRequest.NameEntityOrigin,
                    DIREC_ORIG = itemRequest.AddressOrigin,
                    UBIG_ORIG = itemRequest.UbigeoOrigin,
                    TIPO_DEST = itemRequest.TypeDestiny,
                    COD_ENT_DEST = itemRequest.CodeEntityDestination,
                    NOM_ENT_DEST = itemRequest.NameEntityDestination,
                    DIREC_DEST = itemRequest.AddressDestination,
                    UBIG_DEST = codigoUbigeo,
                    CANTIDAD = itemRequest.Quantity,
                    PESO = itemRequest.Weight,
                    VOLUMEN = itemRequest.Volume,
                    VALOR_MERC = itemRequest.ValueCommodity,
                    MON_VAL_MERC = itemRequest.AmountValueCommodity,
                    OBSERVACION = itemRequest.Observation,
                    DNI_COMPRADOR = itemRequest.DniPurchased,
                    TELF_COMPRADOR = itemRequest.PhonePurchased,
                    MAIL_COMPRADOR = itemRequest.MailPurchased,
                    NOM_CONTACTO = itemRequest.NameContact,
                    DNI_CONTACTO = itemRequest.DniContact,
                    NRO_ORDEN_ENT = itemRequest.NumberOrderEntry,
                    TMPO_PROX_PED = itemRequest.TimeApproximateOrder,
                    REF_DIRECCION = itemRequest.ReferenceAddress,
                    LATITUD = itemRequest.Latitude,
                    LONGITUD = itemRequest.Longitude,
                    CLASIF_DOCU = itemRequest.ClassificationDocument,
                    TIPO_MERC_DOCU = itemRequest.TypeCommodityDocument,
                    FLAG_CUADRILLA = itemRequest.FlagCuadrilla,
                    FLAG_RESGUARDO = itemRequest.FlagGuard,
                    FLAG_MATERIA_PELIGRO = itemRequest.FlagSubjectHazard,
                    TIPO_CARGA = itemRequest.TypeLoad,
                    VIA_TRANSPORTE = itemRequest.ViaTransport,
                    DESCRIPCION_MERC = itemRequest.DescriptionMerchandise,
                    NRO_CONTENEDOR = itemRequest.NumberContainer,
                    FEC_DEV_CONTENEDOR = itemRequest.DateReturnContainer,
                    COD_LUGAR_ENT_CONT = itemRequest.CodePlaceReturnContainer,
                    NOM_LUGAR_ENT_CONT = itemRequest.NamePlaceDeliveryContainer,
                    DIR_LUGAR_ENT_CONT = itemRequest.AddressPlaceDeliveryContainer,
                    UBIG_LUGAR_ENT_CONT = itemRequest.UbigeoPlaceDeliveryContainer,
                    TIP_PAGO = itemRequest.PaymentType,
                    NRO_TRACKING = itemRequest.Tracking,
                    Departamento = itemRequest.Departamento,
                    Provincia = itemRequest.Provincia,
                    Distrito = itemRequest.Distrito,
                    COMODIN1 = itemRequest.Wildcard1,
                    COMODIN2 = itemRequest.Wildcard2,
                    COMODIN3 = itemRequest.Wildcard3,
                    COMODIN4 = itemRequest.Wildcard4,
                    COMODIN5 = itemRequest.Wildcard5,
                    DetalleRequest = oDocumentoDetalleRequest.ToList(),
                    LpnRequest = oDocumentoLpnRequest.ToList(),
                    COD_USUARIO = itemRequest.UserCode,
                    INTER_ORIG = "W",
                    BULTOS = itemRequest.QuantityPackages,
                    NOM_ARCHIVO = itemRequest.FileName,
                    DepartamentoOrigen = itemRequest.OriginDepartment,
                    ProvinciaOrigen = itemRequest.OriginProvince,
                    DistritoOrigen = itemRequest.OriginDistrict,
                    Marca = itemRequest.Brand
                });

                if (resultWS.ErrorCode != Enumerated.ResponseCode.CorrectCode)
                {
                    String errorDescription = "";
                    if (resultWS.ListadoDocumento != null && resultWS.ListadoDocumento.Count() > 0)
                    {
                        int contador = 0;
                        foreach (var item in resultWS.ListadoDocumento)
                        {
                            contador++;
                            if (contador < resultWS.ListadoDocumento.Count())
                                errorDescription += item.DESC_ERROR + Environment.NewLine;
                            else
                                errorDescription += item.DESC_ERROR;
                        }
                    }

                    if (!string.IsNullOrEmpty(errorDescription))
                        resultWS.ErrorDescription = resultWS.ErrorDescription + ": " + errorDescription;

                    throw new Exception(resultWS.ErrorDescription);
                }
                #endregion

                result.DocumentInternalNumber = resultWS.sNroIntDocu;
                result.TrackingNumber = resultWS.sNroTracking;
            }
            catch (Exception ex)
            {
                var sMessage = "En DocumentRegister => " + ex.Message;
                logService.Error(sMessage);
                logService.Error("Request Sent: " + Environment.NewLine + JsonConvert.SerializeObject(itemRequest));

                result.ErrorCode = Enumerated.ResponseCode.ErrorCodeModel;
                result.ErrorDescription = ex.Message;
            }

            return result;
        }

        /// <summary>
        /// Método que permite registrar los documentos - método reducido
        /// </summary>
        /// <param name="itemRequest">Representa los parametros del registro de documento</param>
        /// <returns>Retorna la respuesta de la peticion</returns>
        public DocumentSummaryResponse SummaryRegister(DocumentSummaryRequest itemRequest)
        {
            DocumentSummaryResponse result = new DocumentSummaryResponse();
            List<DocumentEL> DocumentList = new List<DocumentEL>();

            try
            {
                #region[Validation Request]
                if (itemRequest == null)
                    throw new Exception("Request Body no debe ser nulo");
                #endregion

                #region [PedidoDetalleRequest]
                int? correlativo = 1;
                List<DocumentoDetalleRequest> oDocumentoDetalleRequest = new List<DocumentoDetalleRequest>();

                if (itemRequest.DetailRequest != null && itemRequest.DetailRequest.Count() > 0)
                {
                    foreach (var itemDetail in itemRequest.DetailRequest)
                    {
                        oDocumentoDetalleRequest.Add(new DocumentoDetalleRequest
                        {
                            NCORR_INTERNO = correlativo,
                            SNRO_DOC = itemRequest.CustomerOrderNumber,
                            SCOD_ARTICULO = itemDetail.ArticleCode,
                            SDES_ARTICULO = itemDetail.Article,
                            SUNIDAD_MED = itemDetail.UnitMeasureCode,
                            NCANTIDAD = itemDetail.Quantity,
                            NPESO = itemDetail.Weight,
                            NVOLUMEN = itemDetail.Volume,
                            SCOMODIN1 = itemDetail.Wildcard1,
                            SCOMODIN2 = itemDetail.Wildcard2,
                            SCOMODIN3 = itemDetail.Wildcard3
                        }); correlativo++;
                    }
                }
                #endregion

                #region [PedidoLpnRequest]
                List<DocumentoLpnRequest> oDocumentoLpnRequest = new List<DocumentoLpnRequest>();
                //int flagGenera = 0;
                if (itemRequest.LpnRequest != null && itemRequest.LpnRequest.Count() > 0)
                {
                    #region [Registrar LPN]
                    if (itemRequest.QuantityPackages == itemRequest.LpnRequest.Count())
                    {
                        foreach (var itemLpn in itemRequest.LpnRequest)
                        {
                            correlativo = 0;

                            #region [Correlativo]
                            if (oDocumentoDetalleRequest != null && oDocumentoDetalleRequest.Count() > 0)
                            {
                                var itemCorrelativo = oDocumentoDetalleRequest.Where(x => x.SCOD_ARTICULO == itemLpn.ArticleCode).FirstOrDefault();
                                if (itemCorrelativo != null)
                                    correlativo = itemCorrelativo.NCORR_INTERNO;
                                else
                                    logService.Error("Codigo articulo " + itemLpn.ArticleCode + " no se encuentra en el detalle. Lpn sin correlativo");
                            }
                            #endregion

                            oDocumentoLpnRequest.Add(new DocumentoLpnRequest
                            {
                                NumeroDocumento = itemRequest.CustomerOrderNumber,
                                CorrelativoInterno = correlativo,
                                Lpn = itemLpn.Lpn,
                                Cantidad = itemLpn.Quantity,
                                Peso = itemLpn.Weight,
                                Volumen = itemLpn.Volume
                            });
                        }
                    }
                    else
                    {
                        var sMessage = "La cantidad de LPN no coincide con la cantidad de bultos";
                        logService.Error(sMessage);
                        logService.Error("Request Sent: " + Environment.NewLine + JsonConvert.SerializeObject(itemRequest));
                        throw new Exception("La cantidad de LPN no coincide con la cantidad de bultos.");
                    }
                    #endregion
                }
                #endregion

                #region [ConfiguracionEquivalenciaListar]
                int flagUbigeoPedido = 0;
                var listConfiguracionEquivalencia = ConfiguracionEquivalenciaListar(itemRequest.AccountCode);

                if (listConfiguracionEquivalencia.Count() > 0)
                    flagUbigeoPedido = listConfiguracionEquivalencia.FirstOrDefault().FlagUbigeoPedido;
                #endregion

                #region [EquivalenciaUbigeo]
                string codigoUbigeo = "";
                if (Convert.ToBoolean(flagUbigeoPedido))
                {
                    if (string.IsNullOrEmpty(itemRequest.DestinationUbigeoCode))
                        throw new Exception("Codigo ubigeo enviado por el cliente es vacio o nulo.");

                    var listEquivalenciaUbigeo = EquivalenciaUbigeoListar(itemRequest.AccountCode);

                    if (listEquivalenciaUbigeo.Count() == 0)
                        throw new Exception("No se encontro configuracion de equivalencia ubigeo.");

                    var itemEquivalenciaUbigeo = listEquivalenciaUbigeo.Where(x => x.CodigoUbigeoCliente == itemRequest.DestinationUbigeoCode && x.Tipo == Enumerated.DocumentType.Pedido).FirstOrDefault();

                    if (itemEquivalenciaUbigeo == null)
                        throw new Exception("No se encontro configuracion de equivalencia para el codigo ubigeo " + itemRequest.DestinationUbigeoCode + ".");

                    if (!string.IsNullOrEmpty(itemEquivalenciaUbigeo.CodigoUbigeoD4W))
                        codigoUbigeo = itemEquivalenciaUbigeo.CodigoUbigeoD4W;
                    else
                        throw new Exception("Codigo ubigeo vacio o nulo en la tabla de configuracion de equivalencia.");
                }
                else
                {
                    codigoUbigeo = itemRequest.DestinationUbigeoCode;
                }
                #endregion

                #region [Invoke - WebService]
                var resultWS = InterfacesClient.DocumentoRegistrar(new DocumentoRequest
                {
                    CUENTA = itemRequest.AccountCode,
                    NRO_DOCU = itemRequest.CustomerOrderNumber,
                    NRO_PEDIDO = itemRequest.CustomerOrderNumber,
                    NRO_DOCU_REF = itemRequest.NumberDocumentReference,//se agrego el nro documento referencial
                    F_EST_ENT = itemRequest.EstimatedDeliveryDate,
                    COD_ENT_ORIG = itemRequest.OriginEntityCode,
                    NOM_ENT_ORIG = itemRequest.OriginEntity,
                    DIREC_ORIG = itemRequest.OriginAddress,
                    DepartamentoOrigen = itemRequest.OriginDepartment,
                    ProvinciaOrigen = itemRequest.OriginProvince,
                    DistritoOrigen = itemRequest.OriginDistrict,
                    UBIG_ORIG = itemRequest.OriginUbigeoCode,
                    COD_ENT_DEST = itemRequest.DestinationEntityCode,
                    NOM_ENT_DEST = itemRequest.DestinationEntity,
                    DIREC_DEST = itemRequest.DestinationAddress,
                    REF_DIRECCION = itemRequest.AddressReference,
                    UBIG_DEST = codigoUbigeo,//itemRequest.DestinationUbigeoCode,
                    Departamento = itemRequest.DestinationDepartment,
                    Provincia = itemRequest.DestinationProvince,
                    Distrito = itemRequest.DestinationDistrict,
                    DNI_COMPRADOR = itemRequest.PurchaserDNI,
                    TELF_COMPRADOR = itemRequest.PurchaserPhone,
                    //TELF_COMPRADOR = itemRequest.PhonePurchased,
                    CLASIF_DOCU = string.IsNullOrWhiteSpace(itemRequest.ClassificationDocument) ? Enumerated.ConfigurationInitial.clasificacionDocumento : itemRequest.ClassificationDocument,
                    MAIL_COMPRADOR = itemRequest.PurchaserMail,
                    NOM_CONTACTO = itemRequest.ReceiveName,
                    DNI_CONTACTO = itemRequest.ReceiveDNI,
                    CANTIDAD = itemRequest.Quantity,
                    BULTOS = itemRequest.QuantityPackages,
                    OBSERVACION = itemRequest.Observation,
                    PESO = itemRequest.Weight,
                    VOLUMEN = itemRequest.Volume,
                    VALOR_MERC = itemRequest.MerchandiseValue,
                    MON_VAL_MERC = itemRequest.MerchandiseValueCurrency,
                    LATITUD = itemRequest.Latitude,
                    LONGITUD = itemRequest.Longitude,
                    TIP_PAGO = itemRequest.PaymentType,
                    COMODIN1 = itemRequest.Wildcard1,
                    COMODIN2 = itemRequest.Wildcard2,
                    COMODIN3 = itemRequest.Wildcard3,
                    COMODIN4 = itemRequest.Wildcard4,
                    COD_USUARIO = itemRequest.User,
                    F_EMISION = DateTime.Now,
                    DetalleRequest = oDocumentoDetalleRequest.ToList(),
                    LpnRequest = oDocumentoLpnRequest.ToList(),
                    Marca = itemRequest.Brand,
                    NRO_DOCU_REF_TRAN = itemRequest.NumberDocReferenceTra
                });

                if (resultWS.ErrorCode != Enumerated.ResponseCode.CorrectCode)
                {
                    if (resultWS.ListadoDocumento.Count() > 0)
                    {
                        List<DocumentEL> listDocument = resultWS.ListadoDocumento.Select(x => new DocumentEL { NumberDocumentInternal = x.NRO_DOCU_INT, NumberDocument = x.NRO_DOCU, DateError = x.FECHA_ERROR, DescriptionError = x.DESC_ERROR, CodeArticle = x.COD_ARTICULO }).OrderBy(y => y.NumberDocument).ToList();
                        DocumentList = listDocument;
                    }

                    throw new Exception(string.IsNullOrEmpty(resultWS.ErrorDescription) ? string.Empty : resultWS.ErrorDescription);
                }
                #endregion

                result.DocumentInternalNumber = resultWS.sNroIntDocu;
                result.TrackingNumber = resultWS.sNroTracking;
            }
            catch (Exception ex)
            {
                String Message = "";

                if (DocumentList.Count() > 0)
                {
                    foreach (var item in DocumentList)
                    {
                        if (item.CodeArticle != null) { Message += "DateError: " + item.DateError + ", DescriptionError: " + item.DescriptionError + ", CodeArticle: " + item.CodeArticle + "\\n\\n"; }
                        else { Message += "DateError: " + item.DateError + ", DescriptionError: " + item.DescriptionError + "\\n\\n"; }
                    }
                }
                else
                {
                    Message = ex.Message;
                }

                result.ErrorCode = Enumerated.ResponseCode.ErrorCodeControlled;
                result.ErrorDescription = Message;

                var sMessage = "En SummaryRegister => " + ex.Message;
                logService.Error(sMessage);
                logService.Error("Request Sent: " + Environment.NewLine + JsonConvert.SerializeObject(itemRequest));
            }

            return result;
        }
        #endregion

        #region [Internal]
        /// <summary>
        /// Metodo para Listar la configuracion de equivalencia
        /// </summary>
        /// <param name="codigoCuenta">Codigo Cuenta</param>
        /// <returns>Contiene el Resultado de la consulta</returns>
        private List<ConfiguracionEquivalenciaEL> ConfiguracionEquivalenciaListar(string codigoCuenta)
        {
            List<ConfiguracionEquivalenciaEL> listResult = new List<ConfiguracionEquivalenciaEL>();

            try
            {
                #region [Invoke - WS]
                var resultWS = InterfacesClient.GeneralConfiguracionEquivalenciaListar(new ConfiguracionEquivalenciaRequest
                {
                    CodigoCuenta = codigoCuenta
                });

                if (resultWS.ErrorCode != Enumerated.ResponseCode.CorrectCode)
                    throw new Exception(resultWS.ErrorDescription);

                if (resultWS.ListaConfiguracionEquivalencia != null && resultWS.ListaConfiguracionEquivalencia.Count() > 0)
                {
                    foreach (var item in resultWS.ListaConfiguracionEquivalencia)
                    {
                        listResult.Add(new ConfiguracionEquivalenciaEL
                        {
                            CodigoCuenta = item.CodigoCuenta,
                            FlagUbigeoPedido = item.FlagUbigeoPedido,
                            FlagUbigeoDevolucion = item.FlagUbigeoDevolucion
                        });
                    }
                }
                else
                {
                    var sMessage = "En ConfiguracionEquivalenciaListar => No se encontro la configuracion de equivalencias";
                    logService.Error(sMessage);
                }
                #endregion
            }
            catch (Exception ex)
            {
                var sMessage = "En ConfiguracionEquivalenciaListar => " + ex.Message;
                logService.Error(sMessage);

                listResult = new List<ConfiguracionEquivalenciaEL>();
            }

            return listResult;
        }

        /// <summary>
        /// Metodo para Listar la equivalencia del ubigeo
        /// </summary>
        /// <param name="codigoCuenta">Codigo Cuenta</param>
        /// <returns>Contiene el Resultado de la consulta</returns>
        private List<EquivalenciaUbigeoEL> EquivalenciaUbigeoListar(string codigoCuenta)
        {
            List<EquivalenciaUbigeoEL> listResult = new List<EquivalenciaUbigeoEL>();

            try
            {
                #region [Invoke - WS]
                var resultWS = InterfacesClient.GeneralEquivalenciaUbigeoListar(new EquivalenciaUbigeoRequest
                {
                    CodigoCuenta = codigoCuenta
                });

                if (resultWS.ErrorCode != Enumerated.ResponseCode.CorrectCode)
                    throw new Exception(resultWS.ErrorDescription);

                if (resultWS.ListaEquivalenciaUbigeo != null && resultWS.ListaEquivalenciaUbigeo.Count() > 0)
                {
                    foreach (var item in resultWS.ListaEquivalenciaUbigeo)
                    {
                        listResult.Add(new EquivalenciaUbigeoEL
                        {
                            CodigoCuenta = item.CodigoCuenta,
                            CodigoUbigeoCliente = item.CodigoUbigeoCliente,
                            CodigoUbigeoD4W = item.CodigoUbigeoD4W,
                            DescripcionUbigeoD4W = item.DescripcionUbigeoD4W,
                            Tipo = item.Tipo
                        });
                    }
                }
                else
                {
                    var sMessage = "En EquivalenciaUbigeoListar => No se encontraron equivalencias de ubigeo para la cuenta " + codigoCuenta;
                    logService.Error(sMessage);
                }
                #endregion
            }
            catch (Exception ex)
            {
                var sMessage = "En EquivalenciaUbigeoListar => " + ex.Message;
                logService.Error(sMessage);

                listResult = new List<EquivalenciaUbigeoEL>();
            }

            return listResult;
        }
        #endregion
    }
}