namespace FreshBooks.Api.CallbackCreate {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.freshbooks.com/api/", IsNullable=false)]
    public partial class response {
        
        private string errorField;
        
        private ushort codeField;
        
        private byte callback_idField;
        
        private string statusField;
        
        /// <remarks/>
        public string error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
        
        /// <remarks/>
        public ushort code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        public byte callback_id {
            get {
                return this.callback_idField;
            }
            set {
                this.callback_idField = value;
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
}

		