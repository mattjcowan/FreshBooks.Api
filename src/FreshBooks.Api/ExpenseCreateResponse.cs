namespace FreshBooks.Api.ExpenseCreate {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.freshbooks.com/api/", IsNullable=false)]
    public partial class response: BaseResponse {
        
        private ushort expense_idField;
        
        private string statusField;
        
        /// <remarks/>
        public ushort expense_id {
            get {
                return this.expense_idField;
            }
            set {
                this.expense_idField = value;
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

		