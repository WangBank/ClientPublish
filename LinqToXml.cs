using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace 自动发布dll程序
{
    public static class LinqToXml
    {
        public static string Path
        {
            get
            {
                string path = string.Format("{0}\\Publish.config", Environment.CurrentDirectory);
                return path;
            }
        }

        /// <summary>
        /// 创建简单的xml并保存
        /// </summary>
        public static void CreateElement()
        {
            XDocument xdoc = new XDocument(
            new XDeclaration("1.0", "utf-8", "yes"),
            new XElement("root",
            new XElement("item", "1"),
            new XElement("item", "2")
            ));
            xdoc.Save(Path);
        }

        public static string  GetStringByXml(string path)
        {
            try
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(path);
                return xdoc.InnerXml;
            }
            catch (Exception)
            {
                return string.Empty;
            }
          
        }
        /// <summary>
        /// 根据对象创建xml并保存
        /// </summary>
        public static void CreateElementByObjects()
        {
            var s = Enumerable.Range(1, 10);
            XElement xele = new XElement(
                "Root",
                from item in s
                select new XElement("item", item.ToString())
                );
            xele.Save(Path);
        }

        /// <summary>
        /// 通过文件读取xml
        /// </summary>
        public static XElement QueryElementsByFile()
        {
            
            XElement xele = XElement.Load(Path);

            return xele ;
        }

        public static string InnerXML(this XElement el)
        {
            var reader = el.CreateReader();
            reader.MoveToContent();
            return reader.ReadInnerXml();
        }

        /// <summary>
        /// 通过文件读取xml
        /// </summary>
        public static List<string> QueryPathsByFile()
        {
            var result = new List<string>();
            XElement xele = XElement.Load(Path);
            XElement xele1 = xele.Element("FilePaths");
            foreach (var item in xele1.Elements())
            {
                result.Add(item.Element("Path").Value);
            }
            return result;
        }

        /// <summary>
        /// 在指定节点前后添加新节点
        /// </summary>
        public static void AddToElementAfterAndBefore()
        {
            XElement xele = XElement.Load(Path);
            var item = (from ele in xele.Elements("Item")
                        where ele.Value.Equals("Item2")
                        select ele).SingleOrDefault();
            if (item != null)
            {
                XElement nele = new XElement("NItem", "NItem");
                XElement nele2 = new XElement("BItem", "BItem");
                item.AddAfterSelf(nele);
                item.AddBeforeSelf(nele2);
                xele.Save(Path);
            }
        }

        /// <summary>
        /// 替换指定节点
        /// </summary>
        public static void ReplaceElement()
        {
            XElement xele = XElement.Load(Path);
            var item = (from ele in xele.Elements("Item")
                        where ele.Value.Equals("Item2")
                        select ele).FirstOrDefault();
            if (item != null)
            {
                item.ReplaceWith(new XElement("Item", "Item3"));
            }
            xele.Save(Path);
        }


        /// <summary>
        /// 删除指定属性
        /// </summary>
        public static void RemoveAttribute()
        {
            XElement xele = XElement.Load(Path);
            var item = (from ele in xele.Elements("Item")
                        where ele.Value.Equals("Item1")
                        select ele).FirstOrDefault().Attribute("v1");
            if (item != null)
            {
                item.Remove();
            }
            xele.Save(Path);
        }

        /// <summary>
        /// 删除指定节点
        /// </summary>
        public static void RemoveElement()
        {
            XElement xele = XElement.Load(Path);
            var item = (from ele in xele.Elements("Item")
                        where ele.Value.Equals("Item1")
                        select ele).FirstOrDefault();
            if (item != null)
            {
                item.Remove();
            }
            xele.Save(Path);
        }

        /// <summary>
        /// 显示指定节点的所有父节点
        /// </summary>
        public static void ShowAllParentEle()
        {
            XElement xele = XElement.Load(Path);
            var item = (from ele in xele.Descendants("Child")
                        select ele).FirstOrDefault();
            if (item != null)
            {
                foreach (var sub in item.Ancestors())
                {
                    Console.WriteLine(sub.Name);
                }
                Console.WriteLine("----------------");
                foreach (var sub in item.AncestorsAndSelf())
                {
                    Console.WriteLine(sub.Name);
                }
                Console.ReadKey();
            }
        }

        /// <summary>
        /// 显示指定节点的所有子节点
        /// </summary>
        public static void ShowAllChildEle()
        {
            XElement xele = XElement.Load(Path);
            foreach (var sub in xele.Descendants())
            {
                Console.WriteLine(sub.Name);
            }
            Console.WriteLine("-----------------");
            foreach (var sub in xele.DescendantsAndSelf())
            {
                Console.WriteLine(sub.Name);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 显示同级节点之前的节点
        /// </summary>
        public static void ShowPrevEle()
        {
            XElement xele = XElement.Load(Path);
            var item = (from ele in xele.Descendants("SubItem")
                        select ele).FirstOrDefault();
            if (item != null)
            {
                foreach (var sub in item.ElementsBeforeSelf())
                {
                    Console.WriteLine(sub.Name);
                }
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 显示同级节点后面的节点
        /// </summary>
        public static void ShowNextEle()
        {
            XElement xele = XElement.Load(Path);
            var item = (from ele in xele.Descendants("SubItem")
                        select ele).FirstOrDefault();
            if (item != null)
            {
                foreach (var sub in item.ElementsAfterSelf())
                {
                    Console.WriteLine(sub.Name);
                }
            }
            Console.ReadKey();
        }

        public static class ReadXmlStream
        {
            public static String Path
            {
                get
                {
                    String path = String.Format("{0}\\test3.xml", Environment.CurrentDirectory);
                    return path;
                }
            }

            /// <summary>
            /// 流式处理XML
            /// </summary>
            public static void ReadXml()
            {
                XmlReader reader = XmlReader.Create(Path);
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name.Equals("Item"))
                    {
                        XElement ele = XElement.ReadFrom(reader) as XElement;
                        Console.WriteLine(ele.Value.Trim());
                    }
                }
                Console.ReadKey();
            }
        }

        public static class EventXml
        {
            public static string ConvertXmlToString(XmlDocument xmlDoc)
            {
                MemoryStream stream = new MemoryStream();
                XmlTextWriter writer = new XmlTextWriter(stream, null);
                writer.Formatting = Formatting.Indented;
                xmlDoc.Save(writer);
                StreamReader sr = new StreamReader(stream, System.Text.Encoding.UTF8);
                stream.Position = 0;
                string xmlString = sr.ReadToEnd();
                sr.Close();
                stream.Close();
                return xmlString;
            }
            public static void BindChangeing()
            {
                XElement xele = new XElement("Root");
                xele.Changing += xele_Changing;
                xele.Changed += xele_Changed;
                xele.Add(new XElement("Item", "123"));
                var item = xele.Element("Item");
                item.ReplaceWith(new XElement("Item", "2"));
                item = xele.Element("Item");
                item.Remove();
                Console.ReadKey();
            }

            static void xele_Changed(object sender, XObjectChangeEventArgs e)
            {
                XElement ele = sender as XElement;
                Console.WriteLine(String.Format("已完成 {0}-{1}", ele.Name, e.ObjectChange));
            }

            static void xele_Changing(object sender, XObjectChangeEventArgs e)
            {
                XElement ele = sender as XElement;
                Console.WriteLine(String.Format("正在进行中 {0}-{1}", ele.Name, e.ObjectChange));
            }

            #region 反序列化
            /// <summary>
            /// 反序列化
            /// </summary>
            /// <param name="type">类型</param>
            /// <param name="xml">XML字符串</param>
            /// <returns></returns>
            public static object Deserialize(Type type, string xml)
            {
                try
                {
                    using (StringReader sr = new StringReader(xml))
                    {
                        XmlSerializer xmldes = new XmlSerializer(type);
                        return xmldes.Deserialize(sr);
                    }
                }
                catch (Exception e)
                {

                    return null;
                }
            }
            /// <summary>
            /// 反序列化
            /// </summary>
            /// <param name="type"></param>
            /// <param name="xml"></param>
            /// <returns></returns>
            public static object Deserialize(Type type, Stream stream)
            {
                XmlSerializer xmldes = new XmlSerializer(type);
                return xmldes.Deserialize(stream);
            }
            #endregion

            /// <summary>
            /// 序列化
            /// </summary>
            /// <param name="type">类型</param>
            /// <param name="obj">对象</param>
            /// <returns></returns>
            public static string Serializer(Type type, object obj)
            {
                MemoryStream Stream = new MemoryStream();
                XmlSerializer xml = new XmlSerializer(type);
                try
                {
                    //序列化对象
                    xml.Serialize(Stream, obj);
                }
                catch (InvalidOperationException)
                {
                    throw;
                }
                Stream.Position = 0;
                StreamReader sr = new StreamReader(Stream);
                string str = sr.ReadToEnd();

                sr.Dispose();
                Stream.Dispose();

                return str;
            }

        }
    }
}
