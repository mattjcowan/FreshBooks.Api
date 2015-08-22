using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FreshBooks.Api.ServiceTypes
{
    [XmlRoot(ElementName = "response", Namespace = "http://www.freshbooks.com/api/")]
    public class StatusOnlyResponse : IServiceTypeResponse
    {
        [XmlAttribute(AttributeName = "status")]
        public string Status { get; set; }
        [XmlElement(ElementName = "error")]
        public string ErrorMessage { get; set; }
        [XmlElement(ElementName = "code")]
        public string ErrorCode { get; set; }
    }
}
