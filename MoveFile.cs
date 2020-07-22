using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static 自动发布dll程序.LinqToXml;

namespace 自动发布dll程序
{
    class MoveFile
    {
        public static void CopyDir(string srcPath, string aimPath,string mainversion,string subversion)
        {
            try
            {
                string oldAimpath = aimPath;
                aimPath += "\\UpdateFiles";
                // 检查目标目录是否以目录分割字符结束如果不是则添加
                if (aimPath[aimPath.Length - 1] != System.IO.Path.DirectorySeparatorChar)
                {
                    aimPath += System.IO.Path.DirectorySeparatorChar;
                }
                //// 判断目标目录是否存在如果不存在则新建,
                //if (!System.IO.Directory.Exists(aimPath))
                //{
                //    System.IO.Directory.CreateDirectory(aimPath);
                //}
                // 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
                // 如果你指向copy目标文件下面的文件而不包含目录请使用下面的方法
                // string[] fileList = Directory.GetFiles（srcPath）；
                    //将当前目录下的server.xml改信息
                    ServerSetting serverSetting = EventXml.Deserialize(typeof(ServerSetting), LinqToXml.GetStringByXml(oldAimpath + "\\bin\\server.xml")) as ServerSetting;
                    string[] fileList = System.IO.Directory.GetFileSystemEntries(srcPath);
                    // 遍历所有的文件和目录
                    foreach (string file in fileList)
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        var size = fileInfo.Length.ToString();
                        var name = file.Split('\\')[1];
                        if (!serverSetting.UpdateFile.Where(s => name ==s.SaveFileName ).Any())
                        {
                            serverSetting.UpdateFile.Add(new ServerSettingUpdateFile {
                                SaveFileName = name,
                                FileSize = size,
                                NeedReStart = "False",
                                ChildVersion = subversion,
                                CopyType ="0" ,
                                FilePath = name,
                                GUID = Guid.NewGuid().ToString("N"),
                                IsRollBack = "False",
                                IsZipFile = "False",
                                MainVersion = mainversion,
                                NeedReg = "False",
                                RuleType ="1" ,
                                Title = "批量发布："+ name,
                                SavePath ="" ,
                                StartServices = "",
                                StopServices = "",
                                Memo = "",
                                NeedVersion = "",
                                NewVersion = ""
                            });
                        }
                        else
                        {
                            serverSetting.UpdateFile.ForEach(i =>
                            {
                                if (name == i.SaveFileName)
                                {
                                    i.MainVersion = mainversion;
                                    i.ChildVersion = subversion;
                                    i.FileSize = size;
                                }
                            });
                        }
                       
                       File.Copy(file, aimPath + System.IO.Path.GetFileName(file), true);
                    }
                string xmlsss = EventXml.Serializer(typeof(ServerSetting), serverSetting);
                    string xml = xmlsss.Replace("xsi:type=\"xsd:string\"", "");
                    StreamWriter sw = new StreamWriter(oldAimpath + "\\bin\\server.xml");//这里写上你要保存的路径
                    sw.WriteLine(xml);//按行写
                    sw.Close();//关闭
                
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static void BakLog(string srcPath, string aimPath,string version)
        {
            var dirs = new FileInfo(srcPath);
            var dirname = dirs.FullName;
            var newName = $"{aimPath}\\{version}_{DateTime.Now.ToString("yyyyMMddHHmmss")}.zip";
            CompressDirectory(dirname, newName, 5, false);
        }

        /// <summary>
        /// 压缩文件夹
        /// </summary>
        /// <param name="dirPath">要打包的文件夹</param>
        /// <param name="GzipFileName">目标文件名</param>
        /// <param name="CompressionLevel">压缩品质级别（0~9）</param>
        /// <param name="deleteDir">是否删除原文件夹</param>
        public static void CompressDirectory(string dirPath, string GzipFileName, int CompressionLevel, bool deleteDir)
        {
           
           
            using (ZipOutputStream zipoutputstream = new ZipOutputStream(File.Create(GzipFileName)))
            {
                zipoutputstream.SetLevel(CompressionLevel);
                Crc32 crc = new Crc32();
                Dictionary<string, DateTime> fileList = GetAllFies(dirPath);
                foreach (KeyValuePair<string, DateTime> item in fileList)
                {
                    FileStream fs = File.OpenRead(item.Key.ToString());
                    byte[] buffer = new byte[fs.Length];
                    fs.Read(buffer, 0, buffer.Length);
                    ZipEntry entry = new ZipEntry(item.Key.Substring(dirPath.Length+1));
                    entry.DateTime = item.Value;
                    entry.Size = fs.Length;
                    fs.Close();
                    crc.Reset();
                    crc.Update(buffer);
                    entry.Crc = crc.Value;
                    zipoutputstream.PutNextEntry(entry);
                    zipoutputstream.Write(buffer, 0, buffer.Length);
                }
            }
            if (deleteDir)
            {
                Directory.Delete(dirPath, true);
            }
        }

        /// <summary>
        /// 获取所有文件
        /// </summary>
        /// <returns></returns>
        private static Dictionary<string, DateTime> GetAllFies(string dir)
        {
            Dictionary<string, DateTime> FilesList = new Dictionary<string, DateTime>();
            DirectoryInfo fileDire = new DirectoryInfo(dir);
            if (!fileDire.Exists)
            {
                throw new System.IO.FileNotFoundException("目录:" + fileDire.FullName + "没有找到!");
            }
            GetAllDirFiles(fileDire, FilesList);
            //GetAllDirsFiles(fileDire.GetDirectories(), FilesList);
            return FilesList;
        }
        /// <summary>
        /// 获取一个文件夹下的所有文件夹里的文件
        /// </summary>
        /// <param name="dirs"></param>
        /// <param name="filesList"></param>
        private static void GetAllDirsFiles(DirectoryInfo[] dirs, Dictionary<string, DateTime> filesList)
        {
            foreach (DirectoryInfo dir in dirs)
            {
                foreach (FileInfo file in dir.GetFiles("*.*"))
                {
                    filesList.Add(file.FullName, file.LastWriteTime);
                }
                GetAllDirsFiles(dir.GetDirectories(), filesList);
            }
        }
        /// <summary>
        /// 获取一个文件夹下的文件
        /// </summary>
        /// <param name="dir">目录名称</param>
        /// <param name="filesList">文件列表HastTable</param>
        private static void GetAllDirFiles(DirectoryInfo dir, Dictionary<string, DateTime> filesList)
        {
            foreach (FileInfo file in dir.GetFiles("*.*"))
            {
                filesList.Add(file.FullName, file.LastWriteTime);
            }
        }
    }
}
