namespace FreshBooks.Api.RecurringCreate {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class request {
        
        private requestRecurring recurringField;
        
        private string methodField = "recurring.create";
        
        /// <remarks/>
        public requestRecurring recurring {
            get {
                return this.recurringField;
            }
            set {
                this.recurringField = value;
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
    public partial class requestRecurring {
        
        private byte client_idField;
        
        private requestRecurringContacts contactsField;
        
        private System.DateTime dateField;
        
        private ushort po_numberField;
        
        private byte discountField;
        
        private byte occurrencesField;
        
        private string frequencyField;
        
        private byte send_emailField;
        
        private byte send_snail_mailField;
        
        private string currency_codeField;
        
        private string languageField;
        
        private string notesField;
        
        private string termsField;
        
        private string first_nameField;
        
        private string last_nameField;
        
        private string organizationField;
        
        private object p_street1Field;
        
        private object p_street2Field;
        
        private object p_cityField;
        
        private object p_stateField;
        
        private object p_countryField;
        
        private object p_codeField;
        
        private object vat_nameField;
        
        private object vat_numberField;
        
        private object return_uriField;
        
        private requestRecurringAutobill autobillField;
        
        private requestRecurringLines linesField;
        
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
        public requestRecurringContacts contacts {
            get {
                return this.contactsField;
            }
            set {
                this.contactsField = value;
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
        public ushort po_number {
            get {
                return this.po_numberField;
            }
            set {
                this.po_numberField = value;
            }
        }
        
        /// <remarks/>
        public byte discount {
            get {
                return this.discountField;
            }
            set {
                this.discountField = value;
            }
        }
        
        /// <remarks/>
        public byte occurrences {
            get {
                return this.occurrencesField;
            }
            set {
                this.occurrencesField = value;
            }
        }
        
        /// <remarks/>
        public string frequency {
            get {
                return this.frequencyField;
            }
            set {
                this.frequencyField = value;
            }
        }
        
        /// <remarks/>
        public byte send_email {
            get {
                return this.send_emailField;
            }
            set {
                this.send_emailField = value;
            }
        }
        
        /// <remarks/>
        public byte send_snail_mail {
            get {
                return this.send_snail_mailField;
            }
            set {
                this.send_snail_mailField = value;
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
        public string language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
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
        public string terms {
            get {
                return this.termsField;
            }
            set {
                this.termsField = value;
            }
        }
        
        /// <remarks/>
        public string first_name {
            get {
                return this.first_nameField;
            }
            set {
                this.first_nameField = value;
            }
        }
        
        /// <remarks/>
        public string last_name {
            get {
                return this.last_nameField;
            }
            set {
                this.last_nameField = value;
            }
        }
        
        /// <remarks/>
        public string organization {
            get {
                return this.organizationField;
            }
            set {
                this.organizationField = value;
            }
        }
        
        /// <remarks/>
        public object p_street1 {
            get {
                return this.p_street1Field;
            }
            set {
                this.p_street1Field = value;
            }
        }
        
        /// <remarks/>
        public object p_street2 {
            get {
                return this.p_street2Field;
            }
            set {
                this.p_street2Field = value;
            }
        }
        
        /// <remarks/>
        public object p_city {
            get {
                return this.p_cityField;
            }
            set {
                this.p_cityField = value;
            }
        }
        
        /// <remarks/>
        public object p_state {
            get {
                return this.p_stateField;
            }
            set {
                this.p_stateField = value;
            }
        }
        
        /// <remarks/>
        public object p_country {
            get {
                return this.p_countryField;
            }
            set {
                this.p_countryField = value;
            }
        }
        
        /// <remarks/>
        public object p_code {
            get {
                return this.p_codeField;
            }
            set {
                this.p_codeField = value;
            }
        }
        
        /// <remarks/>
        public object vat_name {
            get {
                return this.vat_nameField;
            }
            set {
                this.vat_nameField = value;
            }
        }
        
        /// <remarks/>
        public object vat_number {
            get {
                return this.vat_numberField;
            }
            set {
                this.vat_numberField = value;
            }
        }
        
        /// <remarks/>
        public object return_uri {
            get {
                return this.return_uriField;
            }
            set {
                this.return_uriField = value;
            }
        }
        
        /// <remarks/>
        public requestRecurringAutobill autobill {
            get {
                return this.autobillField;
            }
            set {
                this.autobillField = value;
            }
        }
        
        /// <remarks/>
        public requestRecurringLines lines {
            get {
                return this.linesField;
            }
            set {
                this.linesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class requestRecurringContacts {
        
        private requestRecurringContactsContact contactField;
        
        /// <remarks/>
        public requestRecurringContactsContact contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class requestRecurringContactsContact {
        
        private byte contact_idField;
        
        /// <remarks/>
        public byte contact_id {
            get {
                return this.contact_idField;
            }
            set {
                this.contact_idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class requestRecurringAutobill {
        
        private string gateway_nameField;
        
        private requestRecurringAutobillCard cardField;
        
        /// <remarks/>
        public string gateway_name {
            get {
                return this.gateway_nameField;
            }
            set {
                this.gateway_nameField = value;
            }
        }
        
        /// <remarks/>
        public requestRecurringAutobillCard card {
            get {
                return this.cardField;
            }
            set {
                this.cardField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class requestRecurringAutobillCard {
        
        private string numberField;
        
        private string nameField;
        
        private requestRecurringAutobillCardExpiration expirationField;
        
        /// <remarks/>
        public string number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
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
        public requestRecurringAutobillCardExpiration expiration {
            get {
                return this.expirationField;
            }
            set {
                this.expirationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class requestRecurringAutobillCardExpiration {
        
        private byte monthField;
        
        private ushort yearField;
        
        /// <remarks/>
        public byte month {
            get {
                return this.monthField;
            }
            set {
                this.monthField = value;
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class requestRecurringLines {
        
        private requestRecurringLinesLine lineField;
        
        /// <remarks/>
        public requestRecurringLinesLine line {
            get {
                return this.lineField;
            }
            set {
                this.lineField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class requestRecurringLinesLine {
        
        private string nameField;
        
        private string descriptionField;
        
        private byte unit_costField;
        
        private byte quantityField;
        
        private string tax1_nameField;
        
        private string tax2_nameField;
        
        private byte tax1_percentField;
        
        private byte tax2_percentField;
        
        private string typeField;
        
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
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
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
        
        /// <remarks/>
        public byte quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        public string tax1_name {
            get {
                return this.tax1_nameField;
            }
            set {
                this.tax1_nameField = value;
            }
        }
        
        /// <remarks/>
        public string tax2_name {
            get {
                return this.tax2_nameField;
            }
            set {
                this.tax2_nameField = value;
            }
        }
        
        /// <remarks/>
        public byte tax1_percent {
            get {
                return this.tax1_percentField;
            }
            set {
                this.tax1_percentField = value;
            }
        }
        
        /// <remarks/>
        public byte tax2_percent {
            get {
                return this.tax2_percentField;
            }
            set {
                this.tax2_percentField = value;
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
    }
}

		