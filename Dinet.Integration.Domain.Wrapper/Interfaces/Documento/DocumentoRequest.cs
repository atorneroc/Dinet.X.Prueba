using System;
using System.Collections.Generic;

namespace Dinet.Integration.Domain.Wrapper.Interfaces.Documento
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DocumentoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        public string CUENTA { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NRO_DOCU { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TIPO_DOCU { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NRO_PEDIDO { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TIPO_DOCU_REF { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NRO_DOCU_REF { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NRO_DOCU_REF_ALM { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NRO_DOCU_REF_TRAN { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FLAG_CITA { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TIPO_ATENCION { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? F_EMISION { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? F_EST_RECOJO { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? F_EST_ENT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TIPO_ORIG { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string COD_ENT_ORIG { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NOM_ENT_ORIG { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DIREC_ORIG { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UBIG_ORIG { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TIPO_DEST { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string COD_ENT_DEST { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NOM_ENT_DEST { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DIREC_DEST { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UBIG_DEST { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32? CANTIDAD { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? PESO { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? VOLUMEN { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? VALOR_MERC { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MON_VAL_MERC { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? BULTOS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACION { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DNI_COMPRADOR { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TELF_COMPRADOR { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MAIL_COMPRADOR { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NOM_CONTACTO { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DNI_CONTACTO { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32? NRO_ORDEN_ENT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32? TMPO_PROX_PED { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string REF_DIRECCION { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? LATITUD { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? LONGITUD { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CLASIF_DOCU { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TIPO_MERC_DOCU { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FLAG_CUADRILLA { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FLAG_RESGUARDO { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FLAG_MATERIA_PELIGRO { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TIPO_CARGA { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string VIA_TRANSPORTE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPCION_MERC { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NRO_CONTENEDOR { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FEC_DEV_CONTENEDOR { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string COD_LUGAR_ENT_CONT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NOM_LUGAR_ENT_CONT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DIR_LUGAR_ENT_CONT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UBIG_LUGAR_ENT_CONT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TIP_PAGO { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NRO_TRACKING { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string COMODIN1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string COMODIN2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string COMODIN3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string COMODIN4 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string COMODIN5 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string COD_USUARIO { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string INTER_ORIG { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NOM_ARCHIVO { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<DocumentoDetalleRequest> DetalleRequest;

        /// <summary>
        /// 
        /// </summary>
        public List<DocumentoLpnRequest> LpnRequest;

        /// <summary>
        /// Fecha emision fin
        /// </summary>
        public DateTime? F_EMISION_FIN { get; set; }

        /// <summary>
        /// Flag Impreso
        /// </summary>
        public int? FlagImpreso { get; set; }

        /// <summary>
        /// Departamento
        /// </summary>
        public string Departamento { get; set; }

        /// <summary>
        /// Provincia
        /// </summary>
        public string Provincia { get; set; }

        /// <summary>
        /// Distrito
        /// </summary>
        public string Distrito { get; set; }

        /// <summary>
        /// Departamento Origen
        /// </summary>
        public string DepartamentoOrigen { get; set; }

        /// <summary>
        /// Provincia Origen
        /// </summary>
        public string ProvinciaOrigen { get; set; }

        /// <summary>
        /// Distrito Origen
        /// </summary>
        public string DistritoOrigen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigoUbigeo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Usuario { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Marca { get; set; }
    }
}