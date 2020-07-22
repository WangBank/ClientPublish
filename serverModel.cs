using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 自动发布dll程序
{


    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ServerSetting
    {

        private List<ServerSettingUpdateFile> updateFileField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UpdateFile")]
        public List<ServerSettingUpdateFile> UpdateFile
        {
            get
            {
                return this.updateFileField;
            }
            set
            {
                this.updateFileField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ServerSettingUpdateFile
    {

        private string gUIDField;

        private string titleField;

        private string mainVersionField;

        private string childVersionField;

        private string saveFileNameField;

        private string filePathField;

        private object needVersionField;

        private string fileSizeField;

        private string needRegField;

        private string needReStartField;

        private string isZipFileField;

        private string isRollBackField;

        private string copyTypeField;

        private object savePathField;

        private object newVersionField;

        private object memoField;

        private string ruleTypeField;

        private object stopServicesField;

        private object startServicesField;

        /// <remarks/>
        public string GUID
        {
            get
            {
                return this.gUIDField;
            }
            set
            {
                this.gUIDField = value;
            }
        }

        /// <remarks/>
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public string MainVersion
        {
            get
            {
                return this.mainVersionField;
            }
            set
            {
                this.mainVersionField = value;
            }
        }

        /// <remarks/>
        public string ChildVersion
        {
            get
            {
                return this.childVersionField;
            }
            set
            {
                this.childVersionField = value;
            }
        }

        /// <remarks/>
        public string SaveFileName
        {
            get
            {
                return this.saveFileNameField;
            }
            set
            {
                this.saveFileNameField = value;
            }
        }

        /// <remarks/>
        public string FilePath
        {
            get
            {
                return this.filePathField;
            }
            set
            {
                this.filePathField = value;
            }
        }

        /// <remarks/>
        public object NeedVersion
        {
            get
            {
                return this.needVersionField;
            }
            set
            {
                this.needVersionField = value;
            }
        }

        /// <remarks/>
        public string FileSize
        {
            get
            {
                return this.fileSizeField;
            }
            set
            {
                this.fileSizeField = value;
            }
        }

        /// <remarks/>
        public string NeedReg
        {
            get
            {
                return this.needRegField;
            }
            set
            {
                this.needRegField = value;
            }
        }

        /// <remarks/>
        public string NeedReStart
        {
            get
            {
                return this.needReStartField;
            }
            set
            {
                this.needReStartField = value;
            }
        }

        /// <remarks/>
        public string IsZipFile
        {
            get
            {
                return this.isZipFileField;
            }
            set
            {
                this.isZipFileField = value;
            }
        }

        /// <remarks/>
        public string IsRollBack
        {
            get
            {
                return this.isRollBackField;
            }
            set
            {
                this.isRollBackField = value;
            }
        }

        /// <remarks/>
        public string CopyType
        {
            get
            {
                return this.copyTypeField;
            }
            set
            {
                this.copyTypeField = value;
            }
        }

        /// <remarks/>
        public object SavePath
        {
            get
            {
                return this.savePathField;
            }
            set
            {
                this.savePathField = value;
            }
        }

        /// <remarks/>
        public object NewVersion
        {
            get
            {
                return this.newVersionField;
            }
            set
            {
                this.newVersionField = value;
            }
        }

        /// <remarks/>
        public object Memo
        {
            get
            {
                return this.memoField;
            }
            set
            {
                this.memoField = value;
            }
        }

        /// <remarks/>
        public string RuleType
        {
            get
            {
                return this.ruleTypeField;
            }
            set
            {
                this.ruleTypeField = value;
            }
        }

        /// <remarks/>
        public object StopServices
        {
            get
            {
                return this.stopServicesField;
            }
            set
            {
                this.stopServicesField = value;
            }
        }

        /// <remarks/>
        public object StartServices
        {
            get
            {
                return this.startServicesField;
            }
            set
            {
                this.startServicesField = value;
            }
        }
    }




}
