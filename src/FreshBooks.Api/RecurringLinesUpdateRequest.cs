namespace FreshBooks.Api.RecurringLinesUpdate {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class request {
        
        private byte recurring_idField;
        
        private requestLine[] linesField;
        
        private string methodField = "recurring.lines";
        
        /// <remarks/>
        public byte recurring_id {
            get {
                return this.recurring_idField;
            }
            set {
                this.recurring_idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("line", IsNullable=false)]
        public requestLine[] lines {
            get {
                return this.linesField;
            }
            set {
                this.linesField = value;
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class requestLine {
        
        private byte line_idField;
        
        private byte amountField;
        
        private decimal quantityField;
        
        private string nameField;
        
        private byte unit_costField;
        
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
        public byte amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        public decimal quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public byte unit_cost {
            get {
                return this.unit_costField;
            }
            set {
                this.unit_costField = value;
            }
        }
    }
}

		