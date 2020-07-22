using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class PublishSetting : Form
    {
        public PublishSetting()
        {
            InitializeComponent();
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            this.ensureBtn.Click += new EventHandler(ensureBtn_Click);
            this.Shown += new System.EventHandler(this.button1_Click);
            this.localtionSetting.CellDoubleClick += LocaltionSetting_CellDoubleClick;
        }

        private void LocaltionSetting_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==1)
            {
                System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
                dialog.Description = "请选择客户端更新文件夹";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(dialog.SelectedPath))
                    {
                        MessageBox.Show(this, "文件夹路径不能为空", "提示");
                        return;
                    }

                    localtionSetting.Rows[e.RowIndex].Cells[1].Value = dialog.SelectedPath;
                }
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ensureBtn_Click(object sender, EventArgs e)
        {
           
            string MainVersion = MainVersiontxt.Text;
            string MaxSubVersion = MaxSubVersiontxt.Text;
            List<configurationFilePath> FilePaths = new List<configurationFilePath>();
            foreach (DataGridViewRow item in localtionSetting.Rows)
            {

                if (item.Cells[0].Value !=null && item.Cells[1].Value != null)
                {
                    FilePaths.Add(new configurationFilePath { 
                        Name = item.Cells[0].Value.ToString(),
                        Path= item.Cells[1].Value.ToString()
                    });
                }
            }
           //更新到config文件
           configuration config = new configuration {
               MaxSubVersion = MainVersion,
               CurrVersion = currentlabel.Text,
               MinSubVersion = MinSubVersiontxt.Text,
               MainVersion = MainVersion,
               VersionCount = nowsublabel.Text,
               FilePaths = FilePaths

           };
           
            string xml = EventXml.Serializer(typeof(configuration), config);
            StreamWriter sw = new StreamWriter("Publish.config");//这里写上你要保存的路径
            sw.WriteLine(xml);//按行写
            sw.Close();//关闭
            this.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var appxml = LinqToXml.QueryElementsByFile();
          
            var elemtns = appxml.Element("FilePaths").Elements();
            foreach (var item in elemtns)
            {
                string name = item.Element("Name").Value;
                string path = item.Element("Path").Value;
                int index = this.localtionSetting.Rows.Add();
                this.localtionSetting.Rows[index].Cells[0].Value = name;
                this.localtionSetting.Rows[index].Cells[1].Value = path;
            }

            this.MaxSubVersiontxt.Text = appxml.Element("MaxSubVersion").Value;
            this.MinSubVersiontxt.Text = appxml.Element("MinSubVersion").Value;
            this.currentlabel.Text = appxml.Element("CurrVersion").Value;
            this.nowsublabel.Text = appxml.Element("VersionCount").Value;
            this.MainVersiontxt.Text = appxml.Element("MainVersion").Value;
        }
    }
}
