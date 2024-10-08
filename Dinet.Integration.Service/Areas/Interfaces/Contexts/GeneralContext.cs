using Dinet.Integration.Domain.Common.Constants;
using Dinet.Integration.Domain.Wrapper.Interfaces.General;
using System;
using System.Collections.Generic;

namespace Dinet.Integration.Service.Areas.Interfaces.Contexts
{
    /// <summary>
    /// 
    /// </summary>
    public class GeneralContext
    {
        #region [Configuraciones]
        /// <summary>
        /// Metodo para Listar la configuracion de equivalencia
        /// </summary>
        /// <param name="itemRequest">Contiene los parametros de consulta</param>
        /// <returns>Contiene el Resultado de la consulta</returns>
        public ConfiguracionEquivalenciaResponse ConfiguracionEquivalenciaListar(ConfiguracionEquivalenciaRequest itemRequest)
        {
            ConfiguracionEquivalenciaResponse result = new ConfiguracionEquivalenciaResponse();

            try
            {
                Random random = new Random();

                result.ListaConfiguracionEquivalencia = new List<ConfiguracionEquivalenciaEL>
                {
                    new ConfiguracionEquivalenciaEL
                    {
                        CodigoCuenta = itemRequest.CodigoCuenta,
                        FlagUbigeoPedido = random.Next(0, 2),
                        FlagUbigeoDevolucion = random.Next(0, 2)
                    }
                };
            }
            catch (Exception ex)
            {
                result.ErrorCode = Enumerated.ResponseCode.ErrorCodeApplication;
                result.ErrorDescription = ex.Message;
            }

            return result;
        }
        #endregion

        #region [Equivalencias]
        /// <summary>
        /// Metodo para Listar la equivalencia del ubigeo
        /// </summary>
        /// <param name="itemRequest">Representa los parametros</param>
        /// <returns>Contiene el Resultado de la consulta</returns>
        public EquivalenciaUbigeoResponse EquivalenciaUbigeoListar(EquivalenciaUbigeoRequest itemRequest)
        {
            EquivalenciaUbigeoResponse result = new EquivalenciaUbigeoResponse();

            try
            {
                result.ListaEquivalenciaUbigeo = new List<EquivalenciaUbigeoEL>
                {
                    new EquivalenciaUbigeoEL
                    {
                        CodigoCuenta = itemRequest.CodigoCuenta,
                        CodigoUbigeoCliente = "1501",
                        CodigoUbigeoD4W = "150101",
                        DescripcionUbigeoD4W = "LIMA",
                        Tipo  = Enumerated.DocumentType.Pedido
                    }
                };
            }
            catch (Exception ex)
            {
                result.ErrorCode = Enumerated.ResponseCode.ErrorCodeApplication;
                result.ErrorDescription = ex.Message;
            }

            return result;
        }
        #endregion
    }
}