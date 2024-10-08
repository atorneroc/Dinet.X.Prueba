using Dinet.Integration.Domain.Common;
using Dinet.Integration.Domain.Common.Constants;
using Dinet.Integration.Domain.Wrapper.Interfaces.Tracking;
using Dinet.Integration.Implementation.WebService.DynamicClient;
using Dinet.Integration.Implementation.WebService.Wrappers.Tracking;
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
    public class MaskTracking : IMaskTracking
    {
        #region [Constructor]
        /// <summary>
        ///
        /// </summary>
        public MaskTracking()
        {
            CredentialManager.StoreCredentialsInSession();
        }
        #endregion

        #region [Members]
        ILog logService = LogManager.GetLogger("InterfacesTracking");
        #endregion

        #region [Register]
        /// <summary>
        ///
        /// </summary>
        /// <param name="iRequest"></param>
        /// <param name="callback"></param> 
        /// <param name="asyncState"></param>
        /// <returns></returns>
        public IAsyncResult BeginRegisterAsync(Wrappers.Tracking.TrackingRequest iRequest, AsyncCallback callback, object asyncState)
        {
            logService.Info("Carga de Interfaces: RegisterAsync - Inicio");

            Wrappers.Tracking.TrackingResponse result = new Wrappers.Tracking.TrackingResponse
            {
                itemResponse = new TrackingTypeResponse()
            };

            var itemRequest = iRequest.itemRequest;

            try
            {
                #region [TrackingDetalleRequest]
                List<TrackingDetalleRequest> oDetalleRequest = new List<TrackingDetalleRequest>();

                foreach (var itemDetail in itemRequest.DetailRequest)
                {
                    oDetalleRequest.Add(new TrackingDetalleRequest
                    {
                        Secuencia = itemDetail.Sequence,
                        NroDocumentoInterno = itemDetail.InternalDocumentNumber,
                        TipoDocumentoInterno = itemDetail.TypeInternalDocument,
                        StatusDocumento = itemDetail.DocumentStatus,
                        CodigoArticulo = itemDetail.ItemCode,
                        Articulo = itemDetail.Article,
                        CodigoUMArticulo = itemDetail.UMArticleCode,
                        CodigoUMCtrl = itemDetail.UMCtrlCode,
                        CantidadDocumento = itemDetail.AmountDocument,
                        CantidadEvento = itemDetail.AmountEvent,
                        EstadoArticulo = itemDetail.StateArticle,
                        CodigoLpn = itemDetail.LPNCode,
                        CodigoUbicacion = itemDetail.LocationCode,
                        CodigoSeccion = itemDetail.SectionCode,
                        CodigoEstadoLPN = itemDetail.LPNStateCode,
                        EstadoLPN = itemDetail.StateLPN,
                        Volumen = itemDetail.Volume,
                        TipoBL = itemDetail.TypeBL,
                        NroContenedor = itemDetail.ContainerNumber,
                        Peso = itemDetail.Weight,
                        Bulto = itemDetail.Package,
                        FlagRecojo = itemDetail.PickupFlag,
                        CodigoLinea = itemDetail.LineCode,
                        Linea = itemDetail.Line,
                        CodigoClase = itemDetail.ClassCode,
                        Clase = itemDetail.Class,
                        CodigoSubClase = itemDetail.SubclassCode,
                        SubClase = itemDetail.Subclass,
                        CantidadEnProceso = itemDetail.QuantityInProcess,
                        CantidadZonaDespacho = itemDetail.QuantityDispatchArea,
                        CantidadDespachada = itemDetail.DispatchedQuantity,
                        CantidadRecibida = itemDetail.ReceivedAmount
                    });
                }
                #endregion

                #region [Invoke - WebService]
                var resultWS = InterfacesClient.TrackingRegistrar(new Domain.Wrapper.Interfaces.Tracking.TrackingRequest
                {
                    CodigoSistema = itemRequest.SystemCode,
                    CodigoCuenta = itemRequest.AccountCode,
                    CodigoAlmacen = itemRequest.WarehouseCode,
                    Almacen = itemRequest.Warehouse,
                    TipoDocumentoCliente = itemRequest.DocumentTypeClient,
                    NroDocumentoCliente = itemRequest.ClientDocumentNumber,
                    NroExternoGuia = itemRequest.NumberOfExternalGuide,
                    NroDocumentoInterno = itemRequest.InternalDocumentNumber,
                    NroGuia = itemRequest.GuideNumber,
                    NroPicking = itemRequest.PickingNumber,
                    CodigoMotivo = itemRequest.ReasonCode,
                    Motivo = itemRequest.Reason,
                    TipoDocumentoInterno = itemRequest.TypeOfInternalDocument,
                    StatusDocumento = itemRequest.StatusDocument,
                    StatusEvento = itemRequest.StatusEvent,
                    FechaDocumento = itemRequest.DocumentDate,
                    FechaHoraEvento = itemRequest.DateTimeOfEvent,
                    CodigoClienteProveedor = itemRequest.ClientProviderCode,
                    ClienteProveedor = itemRequest.ClientProvider,
                    CodigoProveedorTransporte = itemRequest.SupplierTransportationCode,
                    ProveedorTransporte = itemRequest.TransportationProvider,
                    PlacaVehiculo = itemRequest.VehicleLicensePlate,
                    CodigoConductor = itemRequest.DriverCode,
                    Conductor = itemRequest.Driver,
                    GeoLongitudX = itemRequest.GeoLengthX,
                    GeoLatitudY = itemRequest.GeoLatitudeY,
                    RazonNoEntrega = itemRequest.ReasonNoDelivery,
                    FechaEntrega = itemRequest.DateOfDelivery,
                    NroTracking = itemRequest.NumberOfTracking,
                    IdImagen1 = itemRequest.IdImage1,
                    IdImagen2 = itemRequest.IdImage2,
                    IdImagen3 = itemRequest.IdImage3,
                    IdImagen4 = itemRequest.IdImage4,
                    CodigoDocumentoReferencia1 = itemRequest.DocumentCodeReference1,
                    NroDocumentoReferencia1 = itemRequest.DocumentNumberReference1,
                    CodigoDocumentoReferencia2 = itemRequest.DocumentCodeReference2,
                    NroDocumentoReferencia2 = itemRequest.DocumentNumberReference2,
                    CodigoDocumentoReferencia3 = itemRequest.DocumentCodeReference3,
                    NroDocumentoReferencia3 = itemRequest.DocumentNumberReference3,
                    UbigeoOrigen = itemRequest.UbigeoOrigin,
                    UbigeoDestino = itemRequest.UbigeoDestination,
                    CodigoEntidadOrigen = itemRequest.SourceEntityCode,
                    EntidadOrigen = itemRequest.OriginEntity,
                    CodigoCDTMS = itemRequest.CDTMSCode,
                    /*Cambio 20190709: Campos nuevos*/
                    TelefonoContacto = itemRequest.ContactPhone,
                    CorreoContacto = itemRequest.ContactMail,
                    DniContacto = itemRequest.ContactIdentityDocument,
                    NombreContacto = itemRequest.ContactName,
                    TelefonoContacto2 = itemRequest.ContactPhone2,
                    CorreoContacto2 = itemRequest.ContactMail2,
                    DniContacto2 = itemRequest.ContactIdentityDocument2,
                    NombreContacto2 = itemRequest.ContactName2,
                    TelefonoContacto3 = itemRequest.ContactPhone3,
                    CorreoContacto3 = itemRequest.ContactMail3,
                    DniContacto3 = itemRequest.ContactIdentityDocument3,
                    NombreContacto3 = itemRequest.ContactName3,
                    Direccion1 = itemRequest.Address1,
                    Direccion2 = itemRequest.Address2,
                    Direccion3 = itemRequest.Address3,
                    Ruc = itemRequest.Ruc,
                    /*Fin*/
                    DetalleRequest = oDetalleRequest.ToList()
                });
                #endregion

                result.itemResponse.ErrorCode = resultWS.ErrorCode;
                result.itemResponse.ErrorDescription = resultWS.ErrorDescription;
                result.itemResponse.TrackingNumber = resultWS.NroTracking;
            }
            catch (Exception ex)
            {
                result.itemResponse.ErrorCode = Enumerated.ResponseCode.ErrorCodeApplication;
                result.itemResponse.ErrorDescription = ex.Message;

                logService.Error("ErrorDescription: " + ex.Message);
                logService.Error("Request Sent: ");
                logService.Error(Converter.ToXML(itemRequest));
            }

            return new CompletedAsyncResult<Wrappers.Tracking.TrackingResponse>(result);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="iResult"></param>
        /// <returns></returns>
        public Wrappers.Tracking.TrackingResponse EndRegisterAsync(IAsyncResult iResult)
        {
            logService.Info("Carga de Interfaces: RegisterAsync - Fin");

            CompletedAsyncResult<Wrappers.Tracking.TrackingResponse> result = iResult as CompletedAsyncResult<Wrappers.Tracking.TrackingResponse>;

            return result.Data;
        }
        #endregion
    }
}