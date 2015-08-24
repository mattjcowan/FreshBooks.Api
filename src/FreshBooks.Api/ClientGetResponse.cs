namespace FreshBooks.Api.ClientGet {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.freshbooks.com/api/", IsNullable=false)]
    public partial class response: BaseResponse {
        
        private responseClient clientField;
        
        private string statusField;
        
        /// <remarks/>
        public responseClient client {
            get {
                return this.clientField;
            }
            set {
                this.clientField = value;
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
    public partial class responseClient {
        
        private byte client_idField;
        
        private string first_nameField;
        
        private string last_nameField;
        
        private string organizationField;
        
        private string emailField;
        
        private string usernameField;
        
        private responseClientContacts contactsField;
        
        private string work_phoneField;
        
        private string home_phoneField;
        
        private object mobileField;
        
        private object faxField;
        
        private string languageField;
        
        private string currency_codeField;
        
        private responseClientCredit creditField;
        
        private responseClientCredit1[] creditsField;
        
        private object notesField;
        
        private string p_street1Field;
        
        private string p_street2Field;
        
        private string p_cityField;
        
        private string p_stateField;
        
        private string p_countryField;
        
        private uint p_codeField;
        
        private object s_street1Field;
        
        private object s_street2Field;
        
        private object s_cityField;
        
        private object s_stateField;
        
        private object s_countryField;
        
        private object s_codeField;
        
        private responseClientUrl urlField;
        
        private responseClientAuth_url auth_urlField;
        
        private responseClientLinks linksField;
        
        private object vat_nameField;
        
        private object vat_numberField;
        
        private string folderField;
        
        private string updatedField;
        
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
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
        
        /// <remarks/>
        public responseClientContacts contacts {
            get {
                return this.contactsField;
            }
            set {
                this.contactsField = value;
            }
        }
        
        /// <remarks/>
        public string work_phone {
            get {
                return this.work_phoneField;
            }
            set {
                this.work_phoneField = value;
            }
        }
        
        /// <remarks/>
        public string home_phone {
            get {
                return this.home_phoneField;
            }
            set {
                this.home_phoneField = value;
            }
        }
        
        /// <remarks/>
        public object mobile {
            get {
                return this.mobileField;
            }
            set {
                this.mobileField = value;
            }
        }
        
        /// <remarks/>
        public object fax {
            get {
                return this.faxField;
            }
            set {
                this.faxField = value;
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
        public string currency_code {
            get {
                return this.currency_codeField;
            }
            set {
                this.currency_codeField = value;
            }
        }
        
        /// <remarks/>
        public responseClientCredit credit {
            get {
                return this.creditField;
            }
            set {
                this.creditField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("credit", IsNullable=false)]
        public responseClientCredit1[] credits {
            get {
                return this.creditsField;
            }
            set {
                this.creditsField = value;
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
        public uint p_code {
            get {
                return this.p_codeField;
            }
            set {
                this.p_codeField = value;
            }
        }
        
        /// <remarks/>
        public object s_street1 {
            get {
                return this.s_street1Field;
            }
            set {
                this.s_street1Field = value;
            }
        }
        
        /// <remarks/>
        public object s_street2 {
            get {
                return this.s_street2Field;
            }
            set {
                this.s_street2Field = value;
            }
        }
        
        /// <remarks/>
        public object s_city {
            get {
                return this.s_cityField;
            }
            set {
                this.s_cityField = value;
            }
        }
        
        /// <remarks/>
        public object s_state {
            get {
                return this.s_stateField;
            }
            set {
                this.s_stateField = value;
            }
        }
        
        /// <remarks/>
        public object s_country {
            get {
                return this.s_countryField;
            }
            set {
                this.s_countryField = value;
            }
        }
        
        /// <remarks/>
        public object s_code {
            get {
                return this.s_codeField;
            }
            set {
                this.s_codeField = value;
            }
        }
        
        /// <remarks/>
        public responseClientUrl url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
        
        /// <remarks/>
        public responseClientAuth_url auth_url {
            get {
                return this.auth_urlField;
            }
            set {
                this.auth_urlField = value;
            }
        }
        
        /// <remarks/>
        public responseClientLinks links {
            get {
                return this.linksField;
            }
            set {
                this.linksField = value;
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
        public string folder {
            get {
                return this.folderField;
            }
            set {
                this.folderField = value;
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    public partial class responseClientContacts {
        
        private byte contact_idField;
        
        private string usernameField;
        
        private object first_nameField;
        
        private object last_nameField;
        
        private string emailField;
        
        private object phone1Field;
        
        private object phone2Field;
        
        /// <remarks/>
        public byte contact_id {
            get {
                return this.contact_idField;
            }
            set {
                this.contact_idField = value;
            }
        }
        
        /// <remarks/>
        public string username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
        
        /// <remarks/>
        public object first_name {
            get {
                return this.first_nameField;
            }
            set {
                this.first_nameField = value;
            }
        }
        
        /// <remarks/>
        public object last_name {
            get {
                return this.last_nameField;
            }
            set {
                this.last_nameField = value;
            }
        }
        
        /// <remarks/>
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public object phone1 {
            get {
                return this.phone1Field;
            }
            set {
                this.phone1Field = value;
            }
        }
        
        /// <remarks/>
        public object phone2 {
            get {
                return this.phone2Field;
            }
            set {
                this.phone2Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    public partial class responseClientCredit {
        
        private string currencyField;
        
        private bool deprecatedField;
        
        private decimal valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool deprecated {
            get {
                return this.deprecatedField;
            }
            set {
                this.deprecatedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    public partial class responseClientCredit1 {
        
        private string currencyField;
        
        private decimal valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    public partial class responseClientUrl {
        
        private bool deprecatedField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool deprecated {
            get {
                return this.deprecatedField;
            }
            set {
                this.deprecatedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    public partial class responseClientAuth_url {
        
        private bool deprecatedField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool deprecated {
            get {
                return this.deprecatedField;
            }
            set {
                this.deprecatedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    public partial class responseClientLinks {
        
        private string client_viewField;
        
        private string viewField;
        
        private string statementField;
        
        /// <remarks/>
        public string client_view {
            get {
                return this.client_viewField;
            }
            set {
                this.client_viewField = value;
            }
        }
        
        /// <remarks/>
        public string view {
            get {
                return this.viewField;
            }
            set {
                this.viewField = value;
            }
        }
        
        /// <remarks/>
        public string statement {
            get {
                return this.statementField;
            }
            set {
                this.statementField = value;
            }
        }
    }
}

		