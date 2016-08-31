using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Update.Common;

namespace Update
{
    public partial class UpdateSet : Form
    {
        public UpdateSet()
        {
            InitializeComponent();
            getValue();
        }

        private void getValue() {
            setXML xml = new setXML();
            xml.setXMLPathLocal("update.xml");
            this.txt_appdate.Value =  Convert.ToDateTime(xml.getSetXmlValue("appDate"));
            this.txt_appversion.Text = xml.getSetXmlValue("appVersion");
            this.txt_apppath.Text = xml.getSetXmlValue("appPath");
            this.txt_appname.Text = xml.getSetXmlValue("appName");
            this.txt_updateURL.Text = xml.getSetXmlValue("updatePath");        
        
        }

        private string folderPath()
        {
            string folderPath = "";
            FolderBrowserDialog folderfDialog = new FolderBrowserDialog();
            folderfDialog.Description = "请选着文件夹";
            if (folderfDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderfDialog.SelectedPath;

            }
            return folderPath;
        }


        private string filePath(string format,string folderPath)
        {
            string filePath = "";
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.InitialDirectory = folderPath==""?"C:\\":folderPath;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*." + format + ")|*." + format + "";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fileDialog.FileName;
            }
            return filePath;
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            string ans= folderPath();
            this.txt_apppath.Text =ans==""?this.txt_apppath.Text:ans;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            setXML xml = new setXML();
            xml.setXMLPathLocal("update.xml");
            xml.editxml("appVersion", this.txt_appversion.Text);
            xml.editxml("appDate", this.txt_appdate.Value.ToString("yyyy-MM-dd"));
            xml.editxml("appPath", this.txt_apppath.Text);
            xml.editxml("appName", this.txt_appname.Text);
            xml.editxml("updatePath", this.txt_updateURL.Text);
            MessageBox.Show("保存成功!");
        }

        private void btn_chooseApp_Click(object sender, EventArgs e)
        {
            string ans = filePath("exe",this.txt_apppath.Text);
            this.txt_appname.Text = ans == "" ? this.txt_appname.Text : ans;
        }
    }
}
