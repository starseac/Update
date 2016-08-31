using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data;

namespace Update.Common
{
   public class setXML
    {
       string xmlPath;

       public void  setXMLPathLocal(string path) {
           this.xmlPath = AppDomain.CurrentDomain.BaseDirectory + path;       
       }

       public void setXMLPath(string path) {
           this.xmlPath = path;
       }

        public DataTable readXML()
        {
            string fileurl = xmlPath;
            DataSet ds = new DataSet();
            ds.ReadXml(fileurl);

            DataTable parSets = ds.Tables["par"];
            return parSets;
        }

        public string getSetXmlValue(string parname)
        {
            string fileurl =  xmlPath;
            XmlDocument doc = new XmlDocument();
            doc.Load(fileurl);
            string value = "";
            XmlNodeList nodeList = doc.SelectSingleNode("update").ChildNodes;//获取Employees节点的所有子节点 

            foreach (XmlNode xn in nodeList)//遍历所有子节点 
            {
                XmlElement xe = (XmlElement)xn;//将子节点类型转换为XmlElement类型 
                if (xe.GetAttribute("name") == parname)//如果genre属性值为“张三” 
                {
                    value = xe.GetAttribute("value");

                    break;

                }
            }
            return value;
        }

        public DataTable readXMLCopyPath()
        {
            string fileurl =  xmlPath;
            DataSet ds = new DataSet();
            ds.ReadXml(fileurl);

            DataTable parSets = ds.Tables["copy"];
            return parSets;

        }


        public void editxml(string parString, string parValue)
        {

            string fileurl = xmlPath;
            XmlDocument doc = new XmlDocument();
            doc.Load(fileurl);

            XmlNodeList nodeList = doc.SelectSingleNode("update").ChildNodes;//获取Employees节点的所有子节点 

            foreach (XmlNode xn in nodeList)//遍历所有子节点 
            {
                XmlElement xe = (XmlElement)xn;//将子节点类型转换为XmlElement类型 
                if (xe.GetAttribute("name") == parString)//如果genre属性值为“张三” 
                {
                    xe.SetAttribute("value", parValue);//则修改该属性为“update张三” 

                    break;

                }
            }

            doc.Save(fileurl);


        }
    }
}
