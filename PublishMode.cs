using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 自动发布dll程序
{
     public class PublishMode
    {
        public string PublishName { get; set; }
        public string PublishPath { get; set; }
    }



    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class configuration
    {

        private string mainVersionField;

        private string minSubVersionField;

        private string maxSubVersionField;

        private string currVersionField;

        private string versionCountField;

        private List<configurationFilePath> filePathsField;

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
        public string MinSubVersion
        {
            get
            {
                return this.minSubVersionField;
            }
            set
            {
                this.minSubVersionField = value;
            }
        }

        /// <remarks/>
        public string MaxSubVersion
        {
            get
            {
                return this.maxSubVersionField;
            }
            set
            {
                this.maxSubVersionField = value;
            }
        }

        /// <remarks/>
        public string CurrVersion
        {
            get
            {
                return this.currVersionField;
            }
            set
            {
                this.currVersionField = value;
            }
        }

        /// <remarks/>
        public string VersionCount
        {
            get
            {
                return this.versionCountField;
            }
            set
            {
                this.versionCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("FilePath", IsNullable = false)]
        public List<configurationFilePath> FilePaths
        {
            get
            {
                return this.filePathsField;
            }
            set
            {
                this.filePathsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationFilePath
    {

        private string nameField;

        private string pathField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }
    }



}
