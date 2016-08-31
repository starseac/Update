using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Update.Common;
using System.IO;

namespace UpdateServer
{
    public partial class UpdateServerSet : Form
    {
        public UpdateServerSet()
        {
            InitializeComponent();
            setValue();
        }

        private void setValue() {
            setXML xml = new setXML();
            xml.setXMLPath("updateInfo.xml");
            this.txt_newDate.Value = Convert.ToDateTime(xml.getSetXmlValue("newDate"));
            this.txt_newVersion.Text = xml.getSetXmlValue("newVersion");
          
        
        }

        private void btn_createFolder_Click(object sender, EventArgs e)
        {
            if(this.txt_newVersion.Text==""){
                MessageBox.Show("必须要填写版本号！");
                return;
            }
            setXML xml = new setXML();
            xml.setXMLPath("updateInfo.xml");
            xml.editxml("newDate",this.txt_newDate.Value.ToString("yyyy-MM-dd"));
            xml.editxml("newVersion", this.txt_newVersion.Text);

            string folderPath = AppDomain.CurrentDomain.BaseDirectory + "updateStorage\\" + this.txt_newDate.Value.ToString("yyyy-MM-dd") + "\\v" + this.txt_newVersion.Text;
            if(!Directory.Exists(folderPath)){
                Directory.CreateDirectory(folderPath);
            }
            MessageBox.Show("创建成功!");
        }

        private void btn_createUpdateIndex_Click(object sender, EventArgs e)
        {
            setScann scann = new setScann();
             string filePath = AppDomain.CurrentDomain.BaseDirectory + "updateStorage\\" + this.txt_newDate.Value.ToString("yyyy-MM-dd") + "\\updateIndex_v" + this.txt_newVersion.Text+".xml";

             scann.setScannXmlPath(filePath);
             scann.addCopyFileXML(scann.scanfiles());
             MessageBox.Show("生成完成!");
        }
    }
}
