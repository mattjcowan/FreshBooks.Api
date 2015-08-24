namespace FreshBooks.Api.ClientList {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class request {
        
        private string emailField;
        
        private string usernameField;
        
        private string updated_fromField;
        
        private string updated_toField;
        
        private byte pageField;
        
        private byte per_pageField;
        
        private string folderField;
        
        private string notesField;
        
        private string methodField = "client.list";
        
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
        public string updated_from {
            get {
                return this.updated_fromField;
            }
            set {
                this.updated_fromField = value;
            }
        }
        
        /// <remarks/>
        public string updated_to {
            get {
                return this.updated_toField;
            }
            set {
                this.updated_toField = value;
            }
        }
        
        /// <remarks/>
        public byte page {
            get {
                return this.pageField;
            }
            set {
                this.pageField = value;
            }
        }
        
        /// <remarks/>
        public byte per_page {
            get {
                return this.per_pageField;
            }
            set {
                this.per_pageField = value;
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
        public string notes {
            get {
                return this.notesField;
            }
            set {
                this.notesField = value;
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
}

		