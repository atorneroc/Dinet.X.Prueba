using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Dinet.Integration.Domain.Common
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Creación: Dinet  <br />
    /// Modificación: 
    /// </remarks>
    public class Converter
    {
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public static string ToXML(Object obj)
        {
            string xml = string.Empty;

            try
            {
                XmlSerializer serializer = new XmlSerializer(obj.GetType());
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Encoding = new UnicodeEncoding(false, false);
                settings.Indent = true;
                settings.OmitXmlDeclaration = true;

                using (StringWriter textWriter = new StringWriter())
                {
                    using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, settings))
                    {
                        serializer.Serialize(xmlWriter, obj);
                    }

                    xml = textWriter.ToString();
                }
            }
            catch (Exception)
            {
                xml = string.Empty;
            }

            return xml;
        }
    }
}