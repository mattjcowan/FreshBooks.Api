namespace FreshBooks.Api.StaffCurrent {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.freshbooks.com/api/", IsNullable=false)]
    public partial class response: BaseResponse {
        
        private responseStaff staffField;
        
        private string statusField;
        
        /// <remarks/>
        public responseStaff staff {
            get {
                return this.staffField;
            }
            set {
                this.staffField = value;
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
    public partial class responseStaff {
        
        private byte staff_idField;
        
        private string usernameField;
        
        private string first_nameField;
        
        private string last_nameField;
        
        private string emailField;
        
        private object business_phoneField;
        
        private object mobile_phoneField;
        
        private byte rateField;
        
        private string last_loginField;
        
        private ushort number_of_loginsField;
        
        private string signup_dateField;
        
        private object street1Field;
        
        private object street2Field;
        
        private object cityField;
        
        private object stateField;
        
        private object countryField;
        
        private object codeField;
        
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
        public string username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
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
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public object business_phone {
            get {
                return this.business_phoneField;
            }
            set {
                this.business_phoneField = value;
            }
        }
        
        /// <remarks/>
        public object mobile_phone {
            get {
                return this.mobile_phoneField;
            }
            set {
                this.mobile_phoneField = value;
            }
        }
        
        /// <remarks/>
        public byte rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }
        
        /// <remarks/>
        public string last_login {
            get {
                return this.last_loginField;
            }
            set {
                this.last_loginField = value;
            }
        }
        
        /// <remarks/>
        public ushort number_of_logins {
            get {
                return this.number_of_loginsField;
            }
            set {
                this.number_of_loginsField = value;
            }
        }
        
        /// <remarks/>
        public string signup_date {
            get {
                return this.signup_dateField;
            }
            set {
                this.signup_dateField = value;
            }
        }
        
        /// <remarks/>
        public object street1 {
            get {
                return this.street1Field;
            }
            set {
                this.street1Field = value;
            }
        }
        
        /// <remarks/>
        public object street2 {
            get {
                return this.street2Field;
            }
            set {
                this.street2Field = value;
            }
        }
        
        /// <remarks/>
        public object city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        public object state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        public object country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
        
        /// <remarks/>
        public object code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
    }
}

		