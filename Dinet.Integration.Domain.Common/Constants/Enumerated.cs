namespace Dinet.Integration.Domain.Common.Constants
{
    /// <summary>
    /// 
    /// </summary>
    public class Enumerated
    {
        /// <summary>
        ///
        /// </summary>
        public struct ConfigurationInitial
        {
            /// <summary>
            /// Clasificacion Documento
            /// </summary>
            public const string clasificacionDocumento = "2";
        }

        /// <summary>
        /// Response Code
        /// </summary>
        public struct ResponseCode
        {
            /// <summary>
            /// Código Correcto
            /// </summary>
            public const int CorrectCode = 0;

            /// <summary>
            /// Error Controlado - Regla de Negocio
            /// </summary>
            public const int ErrorCodeControlled = 1;

            /// <summary>
            /// Error de Base de Datos
            /// </summary>
            public const int ErrorCodeDataBase = 2;

            /// <summary>
            /// Error de Aplicación
            /// </summary>
            public const int ErrorCodeApplication = 3;

            /// <summary>
            /// Error de Model
            /// </summary>
            public const int ErrorCodeModel = 4;
        }

        /// <summary>
        /// Tipo Documento
        /// </summary>
        public struct DocumentType
        {
            /// <summary>
            /// Pedido
            /// </summary>
            public const string Pedido = "PED";

            /// <summary>
            /// Devolucion
            /// </summary>
            public const string Devolucion = "DEV";
        }
    }
}