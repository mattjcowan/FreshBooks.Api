namespace FreshBooks.Api.ExpenseCreate {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class request {
        
        private requestExpense expenseField;
        
        private string methodField = "expense.create";
        
        /// <remarks/>
        public requestExpense expense {
            get {
                return this.expenseField;
            }
            set {
                this.expenseField = value;
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
    public partial class requestExpense {
        
        private byte staff_idField;
        
        private byte category_idField;
        
        private byte project_idField;
        
        private byte client_idField;
        
        private decimal amountField;
        
        private string vendorField;
        
        private System.DateTime dateField;
        
        private string notesField;
        
        private byte statusField;
        
        private object tax1_nameField;
        
        private object tax1_percentField;
        
        private object tax1_amountField;
        
        private object tax2_nameField;
        
        private object tax2_percentField;
        
        private object tax2_amountField;
        
        /// <remarks/>
        public byte staff_id {
            get {
                return this.staff_idField;
            }
            set {
                this.staff_idField = value;
            }
        }
        
        /// <remarks/>
        public byte category_id {
            get {
                return this.category_idField;
            }
            set {
                this.category_idField = value;
            }
        }
        
        /// <remarks/>
        public byte project_id {
            get {
                return this.project_idField;
            }
            set {
                this.project_idField = value;
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
        public decimal amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        public string vendor {
            get {
                return this.vendorField;
            }
            set {
                this.vendorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
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
        public byte status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public object tax1_name {
            get {
                return this.tax1_nameField;
            }
            set {
                this.tax1_nameField = value;
            }
        }
        
        /// <remarks/>
        public object tax1_percent {
            get {
                return this.tax1_percentField;
            }
            set {
                this.tax1_percentField = value;
            }
        }
        
        /// <remarks/>
        public object tax1_amount {
            get {
                return this.tax1_amountField;
            }
            set {
                this.tax1_amountField = value;
            }
        }
        
        /// <remarks/>
        public object tax2_name {
            get {
                return this.tax2_nameField;
            }
            set {
                this.tax2_nameField = value;
            }
        }
        
        /// <remarks/>
        public object tax2_percent {
            get {
                return this.tax2_percentField;
            }
            set {
                this.tax2_percentField = value;
            }
        }
        
        /// <remarks/>
        public object tax2_amount {
            get {
                return this.tax2_amountField;
            }
            set {
                this.tax2_amountField = value;
            }
        }
    }
}

		