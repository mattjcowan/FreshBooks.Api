namespace FreshBooks.Api.StaffCreate {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class request {
        
        private requestStaff staffField;
        
        private string methodField = "staff.create";
        
        /// <remarks/>
        public requestStaff staff {
            get {
                return this.staffField;
            }
            set {
                this.staffField = value;
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
    public partial class requestStaff {
        
        private string first_nameField;
        
        private string last_nameField;
        
        private string emailField;
        
        private string usernameField;
        
        private string passwordField;
        
        private byte email_credentialsField;
        
        private string countryField;
        
        private string stateField;
        
        private string cityField;
        
        private string street1Field;
        
        private string street2Field;
        
        private string codeField;
        
        private uint home_phoneField;
        
        private ulong business_phoneField;
        
        private string mobile_phoneField;
        
        private string faxField;
        
        private decimal rateField;
        
        private requestStaffProjects projectsField;
        
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
        public byte email_credentials {
            get {
                return this.email_credentialsField;
            }
            set {
                this.email_credentialsField = value;
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
        public string state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
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
        public string street1 {
            get {
                return this.street1Field;
            }
            set {
                this.street1Field = value;
            }
        }
        
        /// <remarks/>
        public string street2 {
            get {
                return this.street2Field;
            }
            set {
                this.street2Field = value;
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
        
        /// <remarks/>
        public uint home_phone {
            get {
                return this.home_phoneField;
            }
            set {
                this.home_phoneField = value;
            }
        }
        
        /// <remarks/>
        public ulong business_phone {
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
        public string fax {
            get {
                return this.faxField;
            }
            set {
                this.faxField = value;
            }
        }
        
        /// <remarks/>
        public decimal rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }
        
        /// <remarks/>
        public requestStaffProjects projects {
            get {
                return this.projectsField;
            }
            set {
                this.projectsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class requestStaffProjects {
        
        private requestStaffProjectsProject projectField;
        
        /// <remarks/>
        public requestStaffProjectsProject project {
            get {
                return this.projectField;
            }
            set {
                this.projectField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class requestStaffProjectsProject {
        
        private byte project_idField;
        
        /// <remarks/>
        public byte project_id {
            get {
                return this.project_idField;
            }
            set {
                this.project_idField = value;
            }
        }
    }
}

		