using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static 自动发布dll程序.LinqToXml;

namespace 自动发布dll程序
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Load += new EventHandler(this.MainForm_Load);
            publishBtn.Click += PublishBtn_Click;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void PublishBtn_Click(object sender, EventArgs e)
        {
            if (this.bdCountLbl.Text =="0")
            {
                MessageBox.Show("发布目录UpdateFiles下没有任何文件，不允许发布!");
                return;
            }
            configuration config = EventXml.Deserialize(typeof(configuration), LinqToXml.GetStringByXml("Publish.config")) as configuration;
            var maxsub = config.MaxSubVersion;
            var mainbb = config.MainVersion;
            var minsub = config.MinSubVersion;
            var nowsub = config.CurrVersion;
            var count = config.VersionCount;
            string nowbb;
            if (int.Parse(nowsub) == int.Parse(maxsub))
            {
                //主版本加一，当前值为最小值
                config.CurrVersion = minsub;
                config.MainVersion = (int.Parse(mainbb) + 1).ToString();
                nowbb = config.MainVersion + "." + config.CurrVersion;
                config.VersionCount = (int.Parse(count) + 1).ToString();
                string xml = EventXml.Serializer(typeof(configuration), config);
                StreamWriter sw = new StreamWriter("Publish.config");//这里写上你要保存的路径
                sw.WriteLine(xml);//按行写
                sw.Close();//关闭

            }
            else
            {
                //主版本不动，当前值加一
                config.CurrVersion = (int.Parse(nowsub) + 1).ToString();
                nowbb = config.MainVersion + "." + config.CurrVersion;
                config.VersionCount = (int.Parse(count) + 1).ToString();
                string xml = EventXml.Serializer(typeof(configuration), config);
                StreamWriter sw = new StreamWriter("Publish.config");//这里写上你要保存的路径
                sw.WriteLine(xml);//按行写
                sw.Close();//关闭

            }
            foreach (var item in paths)
            {
                MoveFile.CopyDir("UpdateFiles", item, config.MainVersion, config.CurrVersion);
            }
            //备份完成
            MoveFile.BakLog("UpdateFiles", "UpdateHistory", nowbb);
            //修改版本号,取最大值,最小值,现在的值  修改现在的值 修改发布版本次数
            
            
            MessageBox.Show($"发布成功，当前补丁版本为:{nowbb}");
            MainForm_Load(sender, e);


        }
        List<string> paths = new List<string>();
        private void MainForm_Load(object sender, EventArgs e)
        {
            //读取app setting中的文件路径配置
            paths = QueryPathsByFile();
            var appxml = QueryElementsByFile();
            string[] fileList = System.IO.Directory.GetFileSystemEntries("UpdateFiles");
            this.editionLbl.Text=appxml.Element("MainVersion").Value+"."+appxml.Element("CurrVersion").Value;
            this.bdCountLbl.Text = fileList == null ?"0":fileList.Length.ToString();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublishSetting publishSetting = new PublishSetting();
            publishSetting.StartPosition = FormStartPosition.CenterScreen;
            if (publishSetting.ShowDialog() == DialogResult.OK)
            {
                paths = QueryPathsByFile();
                var appxml = QueryElementsByFile();
                string[] fileList = System.IO.Directory.GetFileSystemEntries("UpdateFiles");
                this.editionLbl.Text = appxml.Element("MainVersion").Value + "." + appxml.Element("MinSubVersion").Value;
                this.bdCountLbl.Text = fileList == null ? "0" : fileList.Length.ToString();
            }
            
        }
    }
}
