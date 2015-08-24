namespace FreshBooks.Api.ReceiptUpdate {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class request {
        
        private requestReceipt receiptField;
        
        private string methodField = "receipt.update";
        
        /// <remarks/>
        public requestReceipt receipt {
            get {
                return this.receiptField;
            }
            set {
                this.receiptField = value;
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
    public partial class requestReceipt {
        
        private byte expense_idField;
        
        private string imageField;
        
        /// <remarks/>
        public byte expense_id {
            get {
                return this.expense_idField;
            }
            set {
                this.expense_idField = value;
            }
        }
        
        /// <remarks/>
        public string image {
            get {
                return this.imageField;
            }
            set {
                this.imageField = value;
            }
        }
    }
}

		