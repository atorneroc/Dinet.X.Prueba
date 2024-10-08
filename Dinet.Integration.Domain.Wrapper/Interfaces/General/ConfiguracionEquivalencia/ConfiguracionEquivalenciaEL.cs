namespace Dinet.Integration.Domain.Wrapper.Interfaces.General
{
    /// <summary>
    /// 
    /// </summary>
    public class ConfiguracionEquivalenciaEL
    {
        /// <summary>
        /// Codigo Cuenta
        /// </summary>
        public string CodigoCuenta { get; set; }

        /// <summary>
        /// Flag Ubigeo Pedido
        /// </summary>
        public int FlagUbigeoPedido { get; set; }

        /// <summary>
        /// Flag Ubigeo Devolucion
        /// </summary>
        public int FlagUbigeoDevolucion { get; set; }
    }
}