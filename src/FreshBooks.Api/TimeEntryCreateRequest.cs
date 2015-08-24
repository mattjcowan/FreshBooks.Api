namespace FreshBooks.Api.TimeEntryCreate {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class request {
        
        private requestTime_entry time_entryField;
        
        private string methodField = "time_entry.create";
        
        /// <remarks/>
        public requestTime_entry time_entry {
            get {
                return this.time_entryField;
            }
            set {
                this.time_entryField = value;
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
    public partial class requestTime_entry {
        
        private byte project_idField;
        
        private byte task_idField;
        
        private byte staff_idField;
        
        private decimal hoursField;
        
        private string notesField;
        
        private System.DateTime dateField;
        
        /// <remarks/>
        public byte project_id {
            get {
                return this.project_idField;
            }
            set {
                this.project_idField = value;
            }
        }
        
        /// <remarks/>
        public byte task_id {
            get {
                return this.task_idField;
            }
            set {
                this.task_idField = value;
            }
        }
        
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
        public decimal hours {
            get {
                return this.hoursField;
            }
            set {
                this.hoursField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }
    }
}

		