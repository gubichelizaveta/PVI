//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

// Исходное имя файла:
// Дата создания: 28.12.2023 12:20:20
namespace lr7.ServiceReference1
{
    
    /// <summary>
    /// В схеме отсутствуют комментарии для WSGEAEntities1.
    /// </summary>
    public partial class WSGEAEntities1 : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Инициализируйте новый объект WSGEAEntities1.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public WSGEAEntities1(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::System.Data.Services.Common.DataServiceProtocolVersion.V3)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
        }
        partial void OnContextCreated();
        /// <summary>
        /// Поскольку пространство имен, настроенное для этой ссылки на службу
        /// в Visual Studio, отличается от пространства имен, указанного
        /// в схеме сервера, для сопоставления этих пространств имен используйте преобразователи типов.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            global::System.Type resolvedType = this.DefaultResolveType(typeName, "WSGEAModel1", "lr7.ServiceReference1");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            return null;
        }
        /// <summary>
        /// Поскольку пространство имен, настроенное для этой ссылки на службу
        /// в Visual Studio, отличается от пространства имен, указанного
        /// в схеме сервера, для сопоставления этих пространств имен используйте преобразователи типов.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("lr7.ServiceReference1", global::System.StringComparison.Ordinal))
            {
                return string.Concat("WSGEAModel1.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// В схеме отсутствуют комментарии для Notes.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Note> Notes
        {
            get
            {
                if ((this._Notes == null))
                {
                    this._Notes = base.CreateQuery<Note>("Notes");
                }
                return this._Notes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Note> _Notes;
        /// <summary>
        /// В схеме отсутствуют комментарии для Students.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Student> Students
        {
            get
            {
                if ((this._Students == null))
                {
                    this._Students = base.CreateQuery<Student>("Students");
                }
                return this._Students;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Student> _Students;
        /// <summary>
        /// В схеме отсутствуют комментарии для Notes.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToNotes(Note note)
        {
            base.AddObject("Notes", note);
        }
        /// <summary>
        /// В схеме отсутствуют комментарии для Students.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToStudents(Student student)
        {
            base.AddObject("Students", student);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private const string ModelPart0 = "<edmx:Edmx Version=\"1.0\" xmlns:edmx=\"http://schemas.microsoft.com/ado/2007/06/edm" +
                "x\"><edmx:DataServices m:DataServiceVersion=\"1.0\" m:MaxDataServiceVersion=\"3.0\" x" +
                "mlns:m=\"http://schemas.microsoft.com/ado/2007/08/dataservices/metadata\"><Schema " +
                "Namespace=\"WSGEAModel1\" xmlns=\"http://schemas.microsoft.com/ado/2009/11/edm\"><En" +
                "tityType Name=\"Note\"><Key><PropertyRef Name=\"Id\" /></Key><Property Name=\"Id\" Typ" +
                "e=\"Edm.Int32\" Nullable=\"false\" p6:StoreGeneratedPattern=\"Identity\" xmlns:p6=\"htt" +
                "p://schemas.microsoft.com/ado/2009/02/edm/annotation\" /><Property Name=\"StudentI" +
                "d\" Type=\"Edm.Int32\" /><Property Name=\"Subject\" Type=\"Edm.String\" MaxLength=\"70\" " +
                "FixedLength=\"false\" Unicode=\"true\" /><Property Name=\"Note1\" Type=\"Edm.Int32\" /><" +
                "NavigationProperty Name=\"Student\" Relationship=\"WSGEAModel1.FK__NOTE__ID\" ToRole" +
                "=\"Student\" FromRole=\"Note\" /></EntityType><EntityType Name=\"Student\"><Key><Prope" +
                "rtyRef Name=\"Id\" /></Key><Property Name=\"Id\" Type=\"Edm.Int32\" Nullable=\"false\" p" +
                "6:StoreGeneratedPattern=\"Identity\" xmlns:p6=\"http://schemas.microsoft.com/ado/20" +
                "09/02/edm/annotation\" /><Property Name=\"Name\" Type=\"Edm.String\" MaxLength=\"70\" F" +
                "ixedLength=\"false\" Unicode=\"true\" /><NavigationProperty Name=\"Note\" Relationship" +
                "=\"WSGEAModel1.FK__NOTE__ID\" ToRole=\"Note\" FromRole=\"Student\" /></EntityType><Ass" +
                "ociation Name=\"FK__NOTE__ID\"><End Type=\"WSGEAModel1.Student\" Role=\"Student\" Mult" +
                "iplicity=\"0..1\" /><End Type=\"WSGEAModel1.Note\" Role=\"Note\" Multiplicity=\"*\" /><R" +
                "eferentialConstraint><Principal Role=\"Student\"><PropertyRef Name=\"Id\" /></Princi" +
                "pal><Dependent Role=\"Note\"><PropertyRef Name=\"StudentId\" /></Dependent></Referen" +
                "tialConstraint></Association></Schema><Schema Namespace=\"lab_6_odata\" xmlns=\"htt" +
                "p://schemas.microsoft.com/ado/2009/11/edm\"><EntityContainer Name=\"WSGEAEntities1" +
                "\" m:IsDefaultEntityContainer=\"true\"><EntitySet Name=\"Notes\" EntityType=\"WSGEAMod" +
                "el1.Note\" /><EntitySet Name=\"Students\" EntityType=\"WSGEAModel1.Student\" /><Assoc" +
                "iationSet Name=\"FK__NOTE__ID\" Association=\"WSGEAModel1.FK__NOTE__ID\"><End Role=\"" +
                "Note\" EntitySet=\"Notes\" /><End Role=\"Student\" EntitySet=\"Students\" /></Associati" +
                "onSet></EntityContainer></Schema></edmx:DataServices></edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static string GetConcatenatedEdmxString()
            {
                return string.Concat(ModelPart0);
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            public static global::Microsoft.Data.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel LoadModelFromString()
            {
                string edmxToParse = GetConcatenatedEdmxString();
                global::System.Xml.XmlReader reader = CreateXmlReader(edmxToParse);
                try
                {
                    return global::Microsoft.Data.Edm.Csdl.EdmxReader.Parse(reader);
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
    }
    /// <summary>
    /// В схеме отсутствуют комментарии для WSGEAModel1.Note.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Notes")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Note : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Создайте новый объект Note.
        /// </summary>
        /// <param name="ID">Начальное значение Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Note CreateNote(int ID)
        {
            Note note = new Note();
            note.Id = ID;
            return note;
        }
        /// <summary>
        /// В схеме отсутствуют комментарии для свойства Id.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// В схеме отсутствуют комментарии для свойства StudentId.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> StudentId
        {
            get
            {
                return this._StudentId;
            }
            set
            {
                this.OnStudentIdChanging(value);
                this._StudentId = value;
                this.OnStudentIdChanged();
                this.OnPropertyChanged("StudentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _StudentId;
        partial void OnStudentIdChanging(global::System.Nullable<int> value);
        partial void OnStudentIdChanged();
        /// <summary>
        /// В схеме отсутствуют комментарии для свойства Subject.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Subject
        {
            get
            {
                return this._Subject;
            }
            set
            {
                this.OnSubjectChanging(value);
                this._Subject = value;
                this.OnSubjectChanged();
                this.OnPropertyChanged("Subject");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Subject;
        partial void OnSubjectChanging(string value);
        partial void OnSubjectChanged();
        /// <summary>
        /// В схеме отсутствуют комментарии для свойства Note1.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Note1
        {
            get
            {
                return this._Note1;
            }
            set
            {
                this.OnNote1Changing(value);
                this._Note1 = value;
                this.OnNote1Changed();
                this.OnPropertyChanged("Note1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Note1;
        partial void OnNote1Changing(global::System.Nullable<int> value);
        partial void OnNote1Changed();
        /// <summary>
        /// В схеме отсутствуют комментарии для Student.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Student Student
        {
            get
            {
                return this._Student;
            }
            set
            {
                this._Student = value;
                this.OnPropertyChanged("Student");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Student _Student;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// В схеме отсутствуют комментарии для WSGEAModel1.Student.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Students")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Student : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Создайте новый объект Student.
        /// </summary>
        /// <param name="ID">Начальное значение Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Student CreateStudent(int ID)
        {
            Student student = new Student();
            student.Id = ID;
            return student;
        }
        /// <summary>
        /// В схеме отсутствуют комментарии для свойства Id.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// В схеме отсутствуют комментарии для свойства Name.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// В схеме отсутствуют комментарии для Note.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<Note> Note
        {
            get
            {
                return this._Note;
            }
            set
            {
                this._Note = value;
                this.OnPropertyChanged("Note");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<Note> _Note = new global::System.Data.Services.Client.DataServiceCollection<Note>(null, global::System.Data.Services.Client.TrackingMode.None);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
