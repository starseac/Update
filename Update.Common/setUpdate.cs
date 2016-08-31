using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Management;
using System.Diagnostics;

namespace Update.Common
{
    public class setUpdate
    {
        string updatePath;
        string updateFileName;

        string updateDate;
        string updateVersion;

        

        public void  setUpdatePar(string updatePath, string updateFileName)
        {
            this.updatePath = updatePath;
            this.updateFileName = updateFileName;
        
        }

        public void setUpdateDateAndVersion(){
            string [] str=getNewUpdate();
            this.updateDate = str[0];
            this.updateVersion = str[1];
        
        }

        public string []  getNewUpdate() {
            string url = updatePath + "\\" + updateFileName;
            setXML xml = new setXML();
            xml.setXMLPath(url);
            string newDate = xml.getSetXmlValue("newDate");
            string newVersion = xml.getSetXmlValue("newVersion");
            string[] str = new string[2];
            str[0] = newDate;
            str[1] = newVersion;
            return str;
        }

        public bool checkNewUpdate(string nowDate,string nowVersion) {
            string[] newVersionStr = getNewUpdate();

            if (DateTime.Parse(nowDate) < DateTime.Parse(newVersionStr[0]))
            {
                return true;
            }
            else if (DateTime.Parse(nowDate) < DateTime.Parse(newVersionStr[0]))
            {
                if (Convert.ToDouble(nowVersion) < Convert.ToDouble(newVersionStr[1]))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else {
                return false;
            }
        
        }

        public DataTable getUpdateIndex() {
            setXML xml = new setXML();
            string url = updatePath + "\\" + updateFileName;
            xml.setXMLPath(url);

            string updateIndexPath = updatePath + "\\updateStorage\\" + xml.getSetXmlValue("newDate") + "\\updateIndex_v"+xml.getSetXmlValue("newVersion")+".xml";
            xml.setXMLPath(updateIndexPath);
            return  xml.readXML();       
        
        }

        public void copyToTempFolder(DataTable updateIndex,string targetFolder) { 
            if(updateIndex!=null&&updateIndex.Rows.Count>0){
                for (int i = 0; i < updateIndex.Rows.Count;i++ )
                {
                    string filepath = updatePath + "\\updateStorage\\" + updateDate + "\\" + updateIndex.Rows[i]["value"].ToString();
                    string targetPath=targetFolder+"\\"+updateIndex.Rows[i]["value"].ToString().Replace("v"+updateVersion,"");
                    string [] str=updateIndex.Rows[i]["value"].ToString().Replace("v"+updateVersion,"").Split('\\');
                    string targetFolderPath = targetFolder + "\\" + updateIndex.Rows[i]["value"].ToString().Replace("v" + updateVersion, "").Replace(str[str.Length - 1], "");
                    if (!Directory.Exists(targetFolderPath)) {
                        Directory.CreateDirectory(targetFolderPath);
                    }
                    if(File.Exists(targetPath)){
                        File.Delete(targetPath);
                    }
                    File.Copy(filepath, targetPath);
                }
            }
        
        }

        public string getAppPath() {
            setXML xml = new setXML();
            xml.setXMLPathLocal("update.xml");
            return xml.getSetXmlValue("appPath");
        }

        public string getAppName() {
            setXML xml = new setXML();
            xml.setXMLPathLocal("update.xml");
            return xml.getSetXmlValue("appName");
        }
    
	 /** 
  * 传入参数：父进程id 
	  * 功能：根据父进程id，杀死与之相关的进程树 
	  */  
	 public static void KillProcessAndChildren(int pid)  
	 {  
          //ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" + pid);  
          //ManagementObjectCollection moc = searcher.Get();  
          //foreach (ManagementObject mo in moc)  
          //{  
          //    KillProcessAndChildren(Convert.ToInt32(mo["ProcessID"]));  
          //}  
	      try  
	      {  
	          Process proc = Process.GetProcessById(pid);  
	          Console.WriteLine(pid);  
	          proc.Kill();  
	      }  
	      catch (ArgumentException)  
	      {   
	         /* process already exited */  
	      }  
	 }

     public int getPID(string appName) {
         try
         {
             Process p = (Process.GetProcessesByName(appName.Replace(".exe","")))[0];
             return p.Id;
         }catch{
            return -1;
         }
     
     }
        
        public void startUpdate() { 
             //先拷贝文件到 updateTemp文件夹
            DataTable dt = getUpdateIndex();
            setUpdateDateAndVersion();

            //检查程序是否允许，关闭程序
            int pid = getPID(getAppName());
            if(pid!=-1){
                KillProcessAndChildren(pid);
            }
            //扫描现有程序，备份到 

            //覆盖更新
            copyToTempFolder(dt, getAppPath());
          

           //更新 更新配置
            setXML xml = new setXML();
            xml.setXMLPathLocal("update.xml");
            xml.editxml("lastupdateDate", updateDate);
            xml.editxml("lastupdateVersion", updateVersion);

            xml.editxml("appDate", updateDate);
            xml.editxml("appVersion", updateVersion);   
        
        }
    }
}
