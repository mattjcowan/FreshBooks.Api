namespace FreshBooks.Api.ReportGetInvoiceDetails {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.freshbooks.com/api/", IsNullable=false)]
    public partial class response: BaseResponse {
        
        private responseReport[] reportsField;
        
        private string statusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("report", IsNullable=false)]
        public responseReport[] reports {
            get {
                return this.reportsField;
            }
            set {
                this.reportsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    public partial class responseReport {
        
        private decimal billedField;
        
        private decimal collectedField;
        
        private decimal outstandingField;
        
        private string currency_codeField;
        
        private ushort yearField;
        
        private byte monthField;
        
        /// <remarks/>
        public decimal billed {
            get {
                return this.billedField;
            }
            set {
                this.billedField = value;
            }
        }
        
        /// <remarks/>
        public decimal collected {
            get {
                return this.collectedField;
            }
            set {
                this.collectedField = value;
            }
        }
        
        /// <remarks/>
        public decimal outstanding {
            get {
                return this.outstandingField;
            }
            set {
                this.outstandingField = value;
            }
        }
        
        /// <remarks/>
        public string currency_code {
            get {
                return this.currency_codeField;
            }
            set {
                this.currency_codeField = value;
            }
        }
        
        /// <remarks/>
        public ushort year {
            get {
                return this.yearField;
            }
            set {
                this.yearField = value;
            }
        }
        
        /// <remarks/>
        public byte month {
            get {
                return this.monthField;
            }
            set {
                this.monthField = value;
            }
        }
    }
}

		