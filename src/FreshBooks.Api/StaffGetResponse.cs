namespace FreshBooks.Api.StaffGet {
    
    
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
        
        private string business_phoneField;
        
        private string mobile_phoneField;
        
        private byte rateField;
        
        private string last_loginField;
        
        private byte number_of_loginsField;
        
        private string signup_dateField;
        
        private string street1Field;
        
        private object street2Field;
        
        private string cityField;
        
        private string stateField;
        
        private string countryField;
        
        private string codeField;
        
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
        public string business_phone {
            get {
                return this.business_phoneField;
            }
            set {
                this.business_phoneField = value;
            }
        }
        
        /// <remarks/>
        public string mobile_phone {
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
        public byte number_of_logins {
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
        public string street1 {
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
        public string city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        public string state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        public string country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
        
        /// <remarks/>
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
    }
}

		