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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        int flag = 0;

        private void btn_updateSet_Click(object sender, EventArgs e)
        {
            UpdateSet updateSet = new UpdateSet();
            updateSet.Show();
        }

        private void btn_showLog_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                this.Height = this.Height + 300;
                flag = 1;
            }
            else {
                this.Height = this.Height - 300;
                flag = 0;
            
            }
        }

        private void btn_checkUpdate_Click(object sender, EventArgs e)
        {
            setUpdate update = new setUpdate();
            setXML xml = new setXML();
            xml.setXMLPathLocal("update.xml");
            update.setUpdatePar(xml.getSetXmlValue("updatePath"), xml.getSetXmlValue("updateIndexFile"));
            bool ans=update.checkNewUpdate(xml.getSetXmlValue("lastupdateDate"), xml.getSetXmlValue("lastupdateVersion"));
            string [] updateStr=update.getNewUpdate();
            if (ans == true)
            {
                MessageBox.Show("发现更新:" + updateStr[0] + "-v" + updateStr[1]);
            }
            else {
                MessageBox.Show("没有发现更新");
            }

        }

        private void btn_updateStart_Click(object sender, EventArgs e)
        {
            setUpdate update = new setUpdate();
            setXML xml = new setXML();
            xml.setXMLPathLocal("update.xml");
            update.setUpdatePar(xml.getSetXmlValue("updatePath"), xml.getSetXmlValue("updateIndexFile"));
            bool ans = update.checkNewUpdate(xml.getSetXmlValue("lastupdateDate"), xml.getSetXmlValue("lastupdateVersion"));
            string[] updateStr = update.getNewUpdate();
            if (ans == true)
            {
              //  MessageBox.Show("发现更新:" + updateStr[0] + "-v" + updateStr[1]);
                if (MessageBox.Show("发现更新:" + updateStr[0] + "-v" + updateStr[1]+",更新，请点击确认按钮，不更新请点击取消按钮", "更新", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    update.startUpdate();
                    MessageBox.Show("更新完成!");
                }
               
            }
            else
            {
                MessageBox.Show("没有发现更新");
            }
        }
    }
}
