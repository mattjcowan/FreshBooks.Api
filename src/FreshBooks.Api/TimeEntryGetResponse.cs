namespace FreshBooks.Api.TimeEntryGet {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.freshbooks.com/api/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.freshbooks.com/api/", IsNullable=false)]
    public partial class response: BaseResponse {
        
        private responseTime_entry time_entryField;
        
        private string statusField;
        
        /// <remarks/>
        public responseTime_entry time_entry {
            get {
                return this.time_entryField;
            }
            set {
                this.time_entryField = value;
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
    public partial class responseTime_entry {
        
        private byte time_entry_idField;
        
        private byte staff_idField;
        
        private byte project_idField;
        
        private byte task_idField;
        
        private byte hoursField;
        
        private System.DateTime dateField;
        
        private string notesField;
        
        private byte billedField;
        
        /// <remarks/>
        public byte time_entry_id {
            get {
                return this.time_entry_idField;
            }
            set {
                this.time_entry_idField = value;
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
        public byte hours {
            get {
                return this.hoursField;
            }
            set {
                this.hoursField = value;
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
        public byte billed {
            get {
                return this.billedField;
            }
            set {
                this.billedField = value;
            }
        }
    }
}

		