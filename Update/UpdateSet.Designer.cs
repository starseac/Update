namespace Update
{
    partial class UpdateSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_appversion = new System.Windows.Forms.TextBox();
            this.txt_apppath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_appdate = new System.Windows.Forms.DateTimePicker();
            this.btn_choose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_updateURL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_appname = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_chooseApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_appversion
            // 
            this.txt_appversion.Location = new System.Drawing.Point(112, 64);
            this.txt_appversion.Name = "txt_appversion";
            this.txt_appversion.Size = new System.Drawing.Size(277, 25);
            this.txt_appversion.TabIndex = 0;
            // 
            // txt_apppath
            // 
            this.txt_apppath.Location = new System.Drawing.Point(112, 111);
            this.txt_apppath.Multiline = true;
            this.txt_apppath.Name = "txt_apppath";
            this.txt_apppath.Size = new System.Drawing.Size(277, 72);
            this.txt_apppath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "程序路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "程序日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "程序版本";
            // 
            // txt_appdate
            // 
            this.txt_appdate.Location = new System.Drawing.Point(113, 16);
            this.txt_appdate.Name = "txt_appdate";
            this.txt_appdate.Size = new System.Drawing.Size(277, 25);
            this.txt_appdate.TabIndex = 6;
            // 
            // btn_choose
            // 
            this.btn_choose.Location = new System.Drawing.Point(410, 110);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(75, 28);
            this.btn_choose.TabIndex = 7;
            this.btn_choose.Text = "选择";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "更新地址";
            // 
            // txt_updateURL
            // 
            this.txt_updateURL.Location = new System.Drawing.Point(112, 238);
            this.txt_updateURL.Multiline = true;
            this.txt_updateURL.Name = "txt_updateURL";
            this.txt_updateURL.Size = new System.Drawing.Size(277, 79);
            this.txt_updateURL.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "程序名称";
            // 
            // txt_appname
            // 
            this.txt_appname.Location = new System.Drawing.Point(112, 194);
            this.txt_appname.Name = "txt_appname";
            this.txt_appname.Size = new System.Drawing.Size(277, 25);
            this.txt_appname.TabIndex = 11;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(210, 323);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 31);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_chooseApp
            // 
            this.btn_chooseApp.Location = new System.Drawing.Point(410, 188);
            this.btn_chooseApp.Name = "btn_chooseApp";
            this.btn_chooseApp.Size = new System.Drawing.Size(75, 30);
            this.btn_chooseApp.TabIndex = 13;
            this.btn_chooseApp.Text = "选择";
            this.btn_chooseApp.UseVisualStyleBackColor = true;
            this.btn_chooseApp.Click += new System.EventHandler(this.btn_chooseApp_Click);
            // 
            // UpdateSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 366);
            this.Controls.Add(this.btn_chooseApp);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_appname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_updateURL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_choose);
            this.Controls.Add(this.txt_appdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_apppath);
            this.Controls.Add(this.txt_appversion);
            this.Name = "UpdateSet";
            this.Text = "设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_appversion;
        private System.Windows.Forms.TextBox txt_apppath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txt_appdate;
        private System.Windows.Forms.Button btn_choose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_updateURL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_appname;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_chooseApp;
    }
}