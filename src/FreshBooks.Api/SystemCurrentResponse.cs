namespace FreshBooks.Api.SystemCurrent {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.freshbooks.com/api/", IsNullable=false)]
    public partial class response: BaseResponse {
        
        private responseSystem systemField;
        
        private string statusField;
        
        /// <remarks/>
        public responseSystem system {
            get {
                return this.systemField;
            }
            set {
                this.systemField = value;
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
    public partial class responseSystem {
        
        private string company_nameField;
        
        private string professionField;
        
        private responseSystemAddress addressField;
        
        private responseSystemApi apiField;
        
        /// <remarks/>
        public string company_name {
            get {
                return this.company_nameField;
            }
            set {
                this.company_nameField = value;
            }
        }
        
        /// <remarks/>
        public string profession {
            get {
                return this.professionField;
            }
            set {
                this.professionField = value;
            }
        }
        
        /// <remarks/>
        public responseSystemAddress address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        public responseSystemApi api {
            get {
                return this.apiField;
            }
            set {
                this.apiField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    public partial class responseSystemAddress {
        
        private string street1Field;
        
        private object street2Field;
        
        private string cityField;
        
        private string provinceField;
        
        private string postal_codeField;
        
        private string countryField;
        
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
        public string province {
            get {
                return this.provinceField;
            }
            set {
                this.provinceField = value;
            }
        }
        
        /// <remarks/>
        public string postal_code {
            get {
                return this.postal_codeField;
            }
            set {
                this.postal_codeField = value;
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    public partial class responseSystemApi {
        
        private byte requestsField;
        
        private responseSystemApiRequest_limit request_limitField;
        
        /// <remarks/>
        public byte requests {
            get {
                return this.requestsField;
            }
            set {
                this.requestsField = value;
            }
        }
        
        /// <remarks/>
        public responseSystemApiRequest_limit request_limit {
            get {
                return this.request_limitField;
            }
            set {
                this.request_limitField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    public partial class responseSystemApiRequest_limit {
        
        private byte deprecatedField;
        
        private uint valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte deprecated {
            get {
                return this.deprecatedField;
            }
            set {
                this.deprecatedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}

		