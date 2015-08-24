namespace FreshBooks.Api.ReportGetProfitDetails {
    
    
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
        
        private decimal incomeField;
        
        private decimal expensesField;
        
        private decimal profitField;
        
        private string currency_codeField;
        
        private ushort yearField;
        
        private byte monthField;
        
        /// <remarks/>
        public decimal income {
            get {
                return this.incomeField;
            }
            set {
                this.incomeField = value;
            }
        }
        
        /// <remarks/>
        public decimal expenses {
            get {
                return this.expensesField;
            }
            set {
                this.expensesField = value;
            }
        }
        
        /// <remarks/>
        public decimal profit {
            get {
                return this.profitField;
            }
            set {
                this.profitField = value;
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

		