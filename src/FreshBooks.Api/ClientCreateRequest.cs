namespace FreshBooks.Api.ClientCreate {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class request {
        
        private requestClient clientField;
        
        private string methodField = "client.create";
        
        /// <remarks/>
        public requestClient client {
            get {
                return this.clientField;
            }
            set {
                this.clientField = value;
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
    public partial class requestClient {
        
        private string first_nameField;
        
        private string last_nameField;
        
        private string organizationField;
        
        private string emailField;
        
        private string usernameField;
        
        private string passwordField;
        
        private requestClientContacts contactsField;
        
        private string work_phoneField;
        
        private string home_phoneField;
        
        private object mobileField;
        
        private object faxField;
        
        private string languageField;
        
        private string currency_codeField;
        
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
        
        private object vat_nameField;
        
        private object vat_numberField;
        
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
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        public requestClientContacts contacts {
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class requestClientContacts {
        
        private requestClientContactsContact contactField;
        
        /// <remarks/>
        public requestClientContactsContact contact {
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
    public partial class requestClientContactsContact {
        
        private string usernameField;
        
        private object first_nameField;
        
        private object last_nameField;
        
        private string emailField;
        
        private object phone1Field;
        
        private object phone2Field;
        
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
}

		