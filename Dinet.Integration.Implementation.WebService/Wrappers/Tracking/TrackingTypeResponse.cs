using System.Xml.Serialization;

namespace Dinet.Integration.Implementation.WebService.Wrappers.Tracking
{
    /// <summary>
    /// 
    /// </summary>
    [XmlTypeAttribute]
    public partial class TrackingTypeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 1)]
        public int ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 2)]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 3)]
        public string TrackingNumber { get; set; }
    }
}