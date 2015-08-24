namespace FreshBooks.Api.ReportGetExpenseDetails {
    
    
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
        
        private decimal unbilledField;
        
        private decimal invoicedField;
        
        private decimal recoupedField;
        
        private decimal internalField;
        
        private ushort yearField;
        
        private byte monthField;
        
        /// <remarks/>
        public decimal unbilled {
            get {
                return this.unbilledField;
            }
            set {
                this.unbilledField = value;
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
        
        /// <remarks/>
        public decimal recouped {
            get {
                return this.recoupedField;
            }
            set {
                this.recoupedField = value;
            }
        }
        
        /// <remarks/>
        public decimal @internal {
            get {
                return this.internalField;
            }
            set {
                this.internalField = value;
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

		