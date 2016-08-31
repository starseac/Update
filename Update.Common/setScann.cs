using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace Update.Common
{
   public class setScann
    {
        string fileFolder;
        string filename;
        string fileVersion;
        public void setScannXmlPath(string filePath) {
            string[] arg = filePath.Split('\\');
            this.fileFolder =filePath.Replace( "\\"+arg[arg.Length-1],"");
            this.filename = arg[arg.Length - 1];
            this.fileVersion = filename.Replace("updateIndex_", "").Replace(".xml","");
        }
        public void scan(DirectoryInfo AppFolder, List<string> list)
        {

            foreach (DirectoryInfo folder in AppFolder.GetDirectories())
            {

                DirectoryInfo Folder = new DirectoryInfo(folder.FullName + @"\" + folder.Name);
                scan(folder, list);
            }

            //遍历文件
            foreach (FileInfo NextFile in AppFolder.GetFiles())
            {
                list.Add(NextFile.FullName);
            }
        }

        public List<string> scanfiles()
        {
            List<string> filepath = new List<string>();

            DirectoryInfo TheFolder = new DirectoryInfo(fileFolder + "\\" + fileVersion);
            //遍历文件夹
            foreach (DirectoryInfo NextFolder in TheFolder.GetDirectories())
            {
                DirectoryInfo AppFolder = new DirectoryInfo(TheFolder.FullName + @"\" + NextFolder.Name);
                scan(AppFolder, filepath);

                foreach (FileInfo NextFile in AppFolder.GetFiles())
                {
                    filepath.Add(NextFile.FullName);
                }

            }

            //遍历文件
            foreach (FileInfo NextFile in TheFolder.GetFiles())
            {
                filepath.Add(NextFile.FullName);
            }

            return filepath;

        }


        public void addCopyFileXML(List<string> filepath)
        {


            string url =fileFolder +"\\"+ filename + "";

            XmlTextWriter xw = new XmlTextWriter(url, Encoding.UTF8);

            xw.Formatting = Formatting.Indented;

            xw.WriteStartDocument();
            xw.WriteStartElement("update");

            //---

            if (filepath != null && filepath.Count >= 1)
            {

                foreach (string pathString in filepath)
                {
                    string newpathString = pathString.Replace( fileFolder+"\\", "");
                 //   string appname = newpathString.Split('\\')[0];
                   // string file = newpathString.Substring(appname.Length);

                    //申请书页面
                    xw.WriteStartElement("par");
                    xw.WriteAttributeString("name", "filepath");
                    xw.WriteAttributeString("value", newpathString);
                    xw.WriteEndElement();
                }
            }

            //-----


            xw.WriteEndElement();
            xw.WriteEndDocument();

            xw.Flush();
            xw.Close();

        }
    }
}
