namespace FreshBooks.Api.ReportGetEstimateDetails {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.freshbooks.com/api/", IsNullable=false)]
    public partial class response: BaseResponse {
        
        private responseReports reportsField;
        
        private string statusField;
        
        /// <remarks/>
        public responseReports reports {
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
    public partial class responseReports {
        
        private responseReportsReport reportField;
        
        /// <remarks/>
        public responseReportsReport report {
            get {
                return this.reportField;
            }
            set {
                this.reportField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    public partial class responseReportsReport {
        
        private string currency_codeField;
        
        private decimal estimatedField;
        
        private decimal acceptedField;
        
        private decimal invoicedField;
        
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
        public decimal estimated {
            get {
                return this.estimatedField;
            }
            set {
                this.estimatedField = value;
            }
        }
        
        /// <remarks/>
        public decimal accepted {
            get {
                return this.acceptedField;
            }
            set {
                this.acceptedField = value;
            }
        }
        
        /// <remarks/>
        public decimal invoiced {
            get {
                return this.invoicedField;
            }
            set {
                this.invoicedField = value;
            }
        }
    }
}

		