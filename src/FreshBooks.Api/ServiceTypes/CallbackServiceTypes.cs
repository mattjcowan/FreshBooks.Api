using System.Xml.Serialization;

namespace FreshBooks.Api.ServiceTypes
{
    // see: http://www.freshbooks.com/developers/docs/callbacks

    [XmlRoot(ElementName = "request")]
    public class CallbackCreateRequest : IReturn<CallbackCreateResponse>
    {
        public CallbackCreateRequest()
        {
            Method = MethodNames.callback_create;
        }

        [XmlAttribute(AttributeName = "method")]
        public string Method { get; set; }

        [XmlElement(ElementName = "callback")]
        public CallbackCreate Callback { get; set; }
    }

    [XmlRoot(ElementName = "response", Namespace = "http://www.freshbooks.com/api/")]
    public class CallbackCreateResponse: IServiceTypeResponse
    {
        [XmlAttribute(AttributeName = "status")]
        public string Status { get; set; }
        [XmlElement(ElementName = "error")]
        public string ErrorMessage { get; set; }
        [XmlElement(ElementName = "code")]
        public string ErrorCode { get; set; }

        [XmlElement(ElementName = "callback_id")]
        public int CallbackId { get; set; }
    }

    [XmlRoot(ElementName = "request")]
    public class CallbackVerifyRequest: IReturn<StatusOnlyResponse>
    {
        public CallbackVerifyRequest()
        {
            Method = MethodNames.callback_verify;
        }

        [XmlAttribute(AttributeName = "method")]
        public string Method { get; set; }

        [XmlElement(ElementName = "callback")]
        public CallbackVerifier Callback { get; set; }
    }

    [XmlRoot(ElementName = "request")]
    public class CallbackResendTokenRequest : IReturn<StatusOnlyResponse>
    {
        public CallbackResendTokenRequest()
        {
            Method = MethodNames.callback_resendToken;
        }

        [XmlAttribute(AttributeName = "method")]
        public string Method { get; set; }

        [XmlElement(ElementName = "callback_id")]
        public int CallbackId { get; set; }
    }

    [XmlRoot(ElementName = "request")]
    public class CallbackListRequest: IReturn<CallbackListResponse>
    {
        public CallbackListRequest()
        {
            Method = MethodNames.callback_list;
        }

        [XmlAttribute(AttributeName = "method")]
        public string Method { get; set; }

        [XmlElement(ElementName = "event")]
        public string Event { get; set; }

        [XmlElement(ElementName = "uri")]
        public string Uri { get; set; }
    }

    [XmlRoot(ElementName = "response", Namespace = "http://www.freshbooks.com/api/")]
    public class CallbackListResponse : IServiceTypeResponse
    {
        [XmlAttribute(AttributeName = "status")]
        public string Status { get; set; }
        [XmlElement(ElementName = "error")]
        public string ErrorMessage { get; set; }
        [XmlElement(ElementName = "code")]
        public string ErrorCode { get; set; }

        // do not put any attributes heres
        public CallbackList callbacks { get; set; }
    }

    [XmlRoot(ElementName = "request")]
    public class CallbackDeleteRequest : IReturn<StatusOnlyResponse>
    {
        public CallbackDeleteRequest()
        {
            Method = MethodNames.callback_delete;
        }

        [XmlAttribute(AttributeName = "method")]
        public string Method { get; set; }

        [XmlElement(ElementName = "callback_id")]
        public int CallbackId { get; set; }
    }

    [XmlType("callbacks")]
    public class CallbackList
    {
        [XmlAttribute(AttributeName = "page")]
        public int Page { get; set; }
        [XmlAttribute(AttributeName = "per_page")]
        public int PerPage { get; set; }
        [XmlAttribute(AttributeName = "pages")]
        public int Pages { get; set; }
        [XmlAttribute(AttributeName = "total")]
        public int Total { get; set; }

        [XmlElement("callback")]
        public Callback[] Callbacks { get; set; }
    }

    [XmlType("callback")]
    public class Callback
    {
        //[XmlText]
        //public string Value { get; set; }

        [XmlElement(ElementName = "callback_id")]
        public int CallbackId { get; set; }

        [XmlElement(ElementName = "uri")]
        public string Uri { get; set; }

        [XmlElement(ElementName = "event")]
        public string Event { get; set; }

        [XmlElement(ElementName = "verified")]
        public string Verified { get; set; }
    }

    [XmlType("callback")]
    public class CallbackCreate
    {
        [XmlElement(ElementName = "event")]
        public string Event { get; set; }
        [XmlElement(ElementName = "uri")]
        public string Uri { get; set; }
    }

    [XmlType("callback")]
    public class CallbackVerifier
    {
        [XmlElement(ElementName = "callback_id")]
        public int CallbackId { get; set; }

        [XmlElement(ElementName = "verifier")]
        public string Verifier { get; set; }
    }
}
