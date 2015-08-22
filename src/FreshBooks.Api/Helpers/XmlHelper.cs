using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace FreshBooks.Api
{
    public static class XmlHelper
    {
        public static T FromXmlString<T>(this string toDeserialize) where T: class, new()
        {
            if (toDeserialize == null)
                throw new NullReferenceException("toDeserialize");

            T output;
            using (StringReader textReader = new StringReader(toDeserialize))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                output = xmlSerializer.Deserialize(textReader) as T;
            }
            return output;
        }

        public static string ToXmlString<T>(this T toSerialize) where T : class
        {
            if (toSerialize == null)
                throw new NullReferenceException("toSerialize");

            var sb = new StringBuilder();
            using (StringWriter textWriter = new Utf8StringWriter(sb))
            {
                using (var writer = XmlWriter.Create(textWriter, new XmlWriterSettings
                {
                    Encoding = new UTF8Encoding(false),
                    Indent = false,
                    NamespaceHandling = NamespaceHandling.OmitDuplicates,
                    Async = false,
                    NewLineOnAttributes = false,
                    NewLineHandling = NewLineHandling.None
                }))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(textWriter, toSerialize, Namespaces);
                    writer.Flush();
                }
            }
            return sb.ToString();
        }


        private static readonly XmlSerializerNamespaces Namespaces = new XmlSerializerNamespaces(new[] { new XmlQualifiedName("", "") } );

        public class Utf8StringWriter : StringWriter
        {
            public Utf8StringWriter(StringBuilder sb) : base(sb)
            {
            }
            public override Encoding Encoding { get { return Encoding.UTF8; } }
        }
    }
}