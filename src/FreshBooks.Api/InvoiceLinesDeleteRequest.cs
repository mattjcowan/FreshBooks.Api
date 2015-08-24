namespace FreshBooks.Api.InvoiceLinesDelete {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class request {
        
        private byte invoice_idField;
        
        private byte line_idField;
        
        private string methodField = "invoice.lines";
        
        /// <remarks/>
        public byte invoice_id {
            get {
                return this.invoice_idField;
            }
            set {
                this.invoice_idField = value;
            }
        }
        
        /// <remarks/>
        public byte line_id {
            get {
                return this.line_idField;
            }
            set {
                this.line_idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string method {
            get {
                return this.methodField;
            }
            set {
                this.methodField = value;
            }
        }
    }
}

		