using Dinet.Integration.Domain.Common;
using Dinet.Integration.Domain.Common.Constants;
using Dinet.Integration.Domain.Wrapper.Interfaces.Documento;
using Dinet.Integration.Implementation.WebService.DynamicClient;
using Dinet.Integration.Implementation.WebService.Wrappers.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using log4net;

namespace Dinet.Integration.Implementation.WebService
{
    /// <summary>
    /// 
    /// </summary>
    [ServiceBehaviorAttribute(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Single)]
    public class MaskDocument : IMaskDocument
    {
        #region [Constructor]
        /// <summary>
        ///
        /// </summary>
        public MaskDocument()
        {
            CredentialManager.StoreCredentialsInSession();
        }
        #endregion

        #region [Members]
        ILog logService = LogManager.GetLogger("InterfacesDocuments");
        #endregion

        #region [Register]
        /// <summary>
        ///
        /// </summary>
        /// <param name="iRequest"></param>
        /// <param name="callback"></param>
        /// <param name="asyncState"></param>
        /// <returns></returns>
        public IAsyncResult BeginRegisterAsync(DocumentRequest iRequest, AsyncCallback callback, object asyncState)
        {
            logService.Info("Carga de Interfaces: RegisterAsync - Inicio");

            DocumentResponse result = new DocumentResponse();
            result.itemResponse = new DocumentTypeResponse();
            result.itemResponse.ListDocument = new List<DocumentEL>();

            var itemRequest = iRequest.itemRequest;

            try
            {
                #region [PedidoDetalleRequest]
                List<DocumentoDetalleRequest> oDocumentoDetalleRequest = new List<DocumentoDetalleRequest>();

                foreach (var itemDetail in itemRequest.DetailRequest)
                {
                    oDocumentoDetalleRequest.Add(new DocumentoDetalleRequest
                    {
                        SNRO_DOC = itemDetail.NumberDocument,
                        NCORR_INTERNO = itemDetail.InternalCorrelative,
                        SCORR_CLIE = itemDetail.CorrelativeClient,
                        SCOD_ARTICULO = itemDetail.CodeArticle,
                        SDES_ARTICULO = itemDetail.DescriptionArticle,
                        SUNIDAD_MED = itemDetail.UnitSize,
                        NCANTIDAD = itemDetail.Quantity,
                        NPESO = Convert.ToDecimal(itemDetail.Weight),
                        NVOLUMEN = Convert.ToDecimal(itemDetail.Volume),
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
                #endregion

                #region [PedidoLpnRequest]
                List<DocumentoLpnRequest> oDocumentoLpnRequest = new List<DocumentoLpnRequest>();

                foreach (var itemLpn in itemRequest.LpnRequest)
                {
                    oDocumentoLpnRequest.Add(new DocumentoLpnRequest
                    {
                        NumeroDocumento = itemLpn.NumberDocument,
                        CorrelativoInterno = itemLpn.InternalCorrelative,
                        Lpn = itemLpn.Lpn,
                        Cantidad = itemLpn.Quantity
                    });
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
                    //SFLAG_ESPECIAL = itemRequest.FlagSpecial,
                    //SFLAG_URGENTE = itemRequest.FlagUrgent,
                    //SFLAG_RECOJO = itemRequest.FlagCollet,

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
                    UBIG_DEST = itemRequest.UbigeoDestination,
                    CANTIDAD = itemRequest.Quantity,
                    PESO = Convert.ToDecimal(itemRequest.Weight),
                    VOLUMEN = Convert.ToDecimal(itemRequest.Volume),
                    VALOR_MERC = Convert.ToDecimal(itemRequest.ValueCommodity),
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

                    COMODIN1 = itemRequest.Wildcard1,
                    COMODIN2 = itemRequest.Wildcard2,
                    COMODIN3 = itemRequest.Wildcard3,
                    COMODIN4 = itemRequest.Wildcard4,
                    COMODIN5 = itemRequest.Wildcard5,
                    DetalleRequest = oDocumentoDetalleRequest.ToList(),
                    LpnRequest = oDocumentoLpnRequest.ToList(),
                    COD_USUARIO = itemRequest.UserCode,
                    INTER_ORIG = "W",

                    BULTOS = itemRequest.QuantityPackages
                });

                if (resultWS.ErrorCode != Enumerated.ResponseCode.CorrectCode)
                {
                    if (resultWS.ListadoDocumento.Count() > 0)
                    {
                        List<DocumentEL> listDocument = new List<DocumentEL>();
                        listDocument = resultWS.ListadoDocumento.Select(x => new DocumentEL { NumberDocumentInternal = x.NRO_DOCU_INT, NumberDocument = x.NRO_DOCU, DateError = x.FECHA_ERROR, DescriptionError = x.DESC_ERROR, CodeArticle = x.COD_ARTICULO }).OrderBy(y => y.NumberDocument).ToList();
                        result.itemResponse.ListDocument = listDocument;
                    }
                }
                #endregion

                result.itemResponse.NumberInternalDocument = resultWS.sNroIntDocu;
                result.itemResponse.NumberTracking = resultWS.sNroTracking;
                result.itemResponse.ErrorCode = resultWS.ErrorCode;
                result.itemResponse.ErrorDescription = resultWS.ErrorDescription;
            }
            catch (Exception ex)
            {
                result.itemResponse.ErrorCode = Enumerated.ResponseCode.ErrorCodeApplication;
                result.itemResponse.ErrorDescription = ex.Message;

                logService.Error("ErrorDescription: " + ex.Message);
                logService.Error("Request Sent: ");
                logService.Error(Converter.ToXML(itemRequest));
            }

            return new CompletedAsyncResult<Dinet.Integration.Implementation.WebService.Wrappers.Document.DocumentResponse>(result);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="iResult"></param>
        /// <returns></returns>
        public DocumentResponse EndRegisterAsync(IAsyncResult iResult)
        {
            logService.Info("Carga de Interfaces: RegisterAsync - Fin");

            CompletedAsyncResult<DocumentResponse> result = iResult as CompletedAsyncResult<DocumentResponse>;

            return result.Data;
        }
        #endregion
    }
}