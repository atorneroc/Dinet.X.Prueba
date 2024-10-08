namespace Dinet.Integration.Domain.Wrapper.Interfaces.Documento
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DocumentoEL
    {
        /// <summary>
        /// 
        /// </summary>
        public string NRO_DOCU_INT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NRO_DOCU { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FECHA_ERROR { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DESC_ERROR { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string COD_ARTICULO { get; set; }

        /// <summary>
        /// Nombre Archivo
        /// </summary>
        public string NombreArchivo { get; set; }

        /// <summary>
        /// Cantidad
        /// </summary>
        public int Cantidad { get; set; }

        /// <summary>
        /// Flag Impreso
        /// </summary>
        public int FlagImpreso { get; set; }

        /// <summary>
        /// Codigo Cuenta
        /// </summary>
        public string CodigoCuenta { get; set; }

        /// <summary>
        /// Numero Pedido
        /// </summary>
        public string NumeroPedido { get; set; }

        /// <summary>
        /// Flag Autogenera Lpn
        /// </summary>
        public int FlagAutogeneraLpn { get; set; }

        /// <summary>
        /// Codigo Ubigeo Destino
        /// </summary>
        public string CodigoUbigeoDestino { get; set; }

        /// <summary>
        /// Departamento Destino
        /// </summary>
        public string DepartamentoDestino { get; set; }

        /// <summary>
        /// Provincia Destino
        /// </summary>
        public string ProvinciaDestino { get; set; }

        /// <summary>
        /// Distrtito Destino
        /// </summary>
        public string DistritoDestino { get; set; }
    }
}