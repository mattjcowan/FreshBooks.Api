namespace FreshBooks.Api.CallbackCreate {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class request {
        
        private requestCallback callbackField;
        
        private string methodField = "callback.create";
        
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
        
        private string eventField;
        
        private string uriField;
        
        /// <remarks/>
        public string @event {
            get {
                return this.eventField;
            }
            set {
                this.eventField = value;
            }
        }
        
        /// <remarks/>
        public string uri {
            get {
                return this.uriField;
            }
            set {
                this.uriField = value;
            }
        }
    }
}

		