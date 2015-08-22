namespace FreshBooks.Api.CallbackVerify {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class request {
        
        private requestCallback callbackField;
        
        private string methodField = "callback.verify";
        
        /// <remarks/>
        public requestCallback callback {
            get {
                return this.callbackField;
            }
            set {
                this.callbackField = value;
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
    public partial class requestCallback {
        
        private byte callback_idField;
        
        private string verifierField;
        
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
        public string verifier {
            get {
                return this.verifierField;
            }
            set {
                this.verifierField = value;
            }
        }
    }
}

		