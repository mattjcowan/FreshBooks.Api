namespace FreshBooks.Api.PaymentGet {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.freshbooks.com/api/", IsNullable=false)]
    public partial class response: BaseResponse {
        
        private responsePayment paymentField;
        
        private string statusField;
        
        /// <remarks/>
        public responsePayment payment {
            get {
                return this.paymentField;
            }
            set {
                this.paymentField = value;
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
    public partial class responsePayment {
        
        private byte payment_idField;
        
        private byte client_idField;
        
        private byte invoice_idField;
        
        private string dateField;
        
        private decimal amountField;
        
        private string currency_codeField;
        
        private string typeField;
        
        private string notesField;
        
        private string updatedField;
        
        private responsePaymentGateway_transaction gateway_transactionField;
        
        /// <remarks/>
        public byte payment_id {
            get {
                return this.payment_idField;
            }
            set {
                this.payment_idField = value;
            }
        }
        
        /// <remarks/>
        public byte client_id {
            get {
                return this.client_idField;
            }
            set {
                this.client_idField = value;
            }
        }
        
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
        public string date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }
        
        /// <remarks/>
        public decimal amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
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
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public string notes {
            get {
                return this.notesField;
            }
            set {
                this.notesField = value;
            }
        }
        
        /// <remarks/>
        public string updated {
            get {
                return this.updatedField;
            }
            set {
                this.updatedField = value;
            }
        }
        
        /// <remarks/>
        public responsePaymentGateway_transaction gateway_transaction {
            get {
                return this.gateway_transactionField;
            }
            set {
                this.gateway_transactionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    public partial class responsePaymentGateway_transaction {
        
        private uint reference_idField;
        
        private string gateway_nameField;
        
        /// <remarks/>
        public uint reference_id {
            get {
                return this.reference_idField;
            }
            set {
                this.reference_idField = value;
            }
        }
        
        /// <remarks/>
        public string gateway_name {
            get {
                return this.gateway_nameField;
            }
            set {
                this.gateway_nameField = value;
            }
        }
    }
}

		