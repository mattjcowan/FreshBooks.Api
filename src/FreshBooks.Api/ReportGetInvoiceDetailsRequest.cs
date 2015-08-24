namespace FreshBooks.Api.ReportGetInvoiceDetails {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class request {
        
        private string statusField;
        
        private ushort client_idField;
        
        private string date_fromField;
        
        private string date_toField;
        
        private string group_byField;
        
        private string methodField = "report.getInvoiceDetails";
        
        /// <remarks/>
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public ushort client_id {
            get {
                return this.client_idField;
            }
            set {
                this.client_idField = value;
            }
        }
        
        /// <remarks/>
        public string date_from {
            get {
                return this.date_fromField;
            }
            set {
                this.date_fromField = value;
            }
        }
        
        /// <remarks/>
        public string date_to {
            get {
                return this.date_toField;
            }
            set {
                this.date_toField = value;
            }
        }
        
        /// <remarks/>
        public string group_by {
            get {
                return this.group_byField;
            }
            set {
                this.group_byField = value;
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

		