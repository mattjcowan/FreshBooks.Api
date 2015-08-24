namespace FreshBooks.Api.RecurringList {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.freshbooks.com/api/", IsNullable=false)]
    public partial class response: BaseResponse {
        
        private responseRecurrings recurringsField;
        
        private string statusField;
        
        /// <remarks/>
        public responseRecurrings recurrings {
            get {
                return this.recurringsField;
            }
            set {
                this.recurringsField = value;
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
    public partial class responseRecurrings {
        
        private responseRecurringsRecurring[] recurringField;
        
        private byte pageField;
        
        private byte per_pageField;
        
        private byte pagesField;
        
        private byte totalField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recurring")]
        public responseRecurringsRecurring[] recurring {
            get {
                return this.recurringField;
            }
            set {
                this.recurringField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte page {
            get {
                return this.pageField;
            }
            set {
                this.pageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte per_page {
            get {
                return this.per_pageField;
            }
            set {
                this.per_pageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pages {
            get {
                return this.pagesField;
            }
            set {
                this.pagesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    public partial class responseRecurringsRecurring {
        
        private byte recurring_idField;
        
        private string frequencyField;
        
        private byte occurrencesField;
        
        private byte stoppedField;
        
        private byte client_idField;
        
        private responseRecurringsRecurringContacts contactsField;
        
        private byte staff_idField;
        
        private string organizationField;
        
        private string first_nameField;
        
        private string last_nameField;
        
        private string p_street1Field;
        
        private string p_street2Field;
        
        private string p_cityField;
        
        private string p_stateField;
        
        private string p_countryField;
        
        private string p_codeField;
        
        private object vat_nameField;
        
        private object vat_numberField;
        
        private object po_numberField;
        
        private object statusField;
        
        private byte amountField;
        
        private string currency_codeField;
        
        private string languageField;
        
        private System.DateTime dateField;
        
        private object notesField;
        
        private string termsField;
        
        private byte discountField;
        
        private object return_uriField;
        
        private byte send_snail_mailField;
        
        private byte send_emailField;
        
        private string folderField;
        
        private responseRecurringsRecurringAutobill autobillField;
        
        private responseRecurringsRecurringLines linesField;
        
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
        public string frequency {
            get {
                return this.frequencyField;
            }
            set {
                this.frequencyField = value;
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
        public byte stopped {
            get {
                return this.stoppedField;
            }
            set {
                this.stoppedField = value;
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
        public responseRecurringsRecurringContacts contacts {
            get {
                return this.contactsField;
            }
            set {
                this.contactsField = value;
            }
        }
        
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
        public string organization {
            get {
                return this.organizationField;
            }
            set {
                this.organizationField = value;
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
        public string p_street1 {
            get {
                return this.p_street1Field;
            }
            set {
                this.p_street1Field = value;
            }
        }
        
        /// <remarks/>
        public string p_street2 {
            get {
                return this.p_street2Field;
            }
            set {
                this.p_street2Field = value;
            }
        }
        
        /// <remarks/>
        public string p_city {
            get {
                return this.p_cityField;
            }
            set {
                this.p_cityField = value;
            }
        }
        
        /// <remarks/>
        public string p_state {
            get {
                return this.p_stateField;
            }
            set {
                this.p_stateField = value;
            }
        }
        
        /// <remarks/>
        public string p_country {
            get {
                return this.p_countryField;
            }
            set {
                this.p_countryField = value;
            }
        }
        
        /// <remarks/>
        public string p_code {
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
        public object po_number {
            get {
                return this.po_numberField;
            }
            set {
                this.po_numberField = value;
            }
        }
        
        /// <remarks/>
        public object status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
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
        public object notes {
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
        public byte discount {
            get {
                return this.discountField;
            }
            set {
                this.discountField = value;
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
        public byte send_snail_mail {
            get {
                return this.send_snail_mailField;
            }
            set {
                this.send_snail_mailField = value;
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
        public string folder {
            get {
                return this.folderField;
            }
            set {
                this.folderField = value;
            }
        }
        
        /// <remarks/>
        public responseRecurringsRecurringAutobill autobill {
            get {
                return this.autobillField;
            }
            set {
                this.autobillField = value;
            }
        }
        
        /// <remarks/>
        public responseRecurringsRecurringLines lines {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    public partial class responseRecurringsRecurringContacts {
        
        private responseRecurringsRecurringContactsContact contactField;
        
        /// <remarks/>
        public responseRecurringsRecurringContactsContact contact {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    public partial class responseRecurringsRecurringContactsContact {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    public partial class responseRecurringsRecurringAutobill {
        
        private string gateway_nameField;
        
        private responseRecurringsRecurringAutobillCard cardField;
        
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
        public responseRecurringsRecurringAutobillCard card {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    public partial class responseRecurringsRecurringAutobillCard {
        
        private string numberField;
        
        private string nameField;
        
        private responseRecurringsRecurringAutobillCardExpiration expirationField;
        
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
        public responseRecurringsRecurringAutobillCardExpiration expiration {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    public partial class responseRecurringsRecurringAutobillCardExpiration {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    public partial class responseRecurringsRecurringLines {
        
        private responseRecurringsRecurringLinesLine lineField;
        
        /// <remarks/>
        public responseRecurringsRecurringLinesLine line {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    public partial class responseRecurringsRecurringLinesLine {
        
        private byte line_idField;
        
        private string nameField;
        
        private string descriptionField;
        
        private byte unit_costField;
        
        private byte quantityField;
        
        private byte amountField;
        
        private object tax1_nameField;
        
        private object tax2_nameField;
        
        private byte tax1_percentField;
        
        private byte tax2_percentField;
        
        private string typeField;
        
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
        public byte amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
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
        public object tax2_name {
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

		