namespace UpdateServer
{
    partial class UpdateServerSet
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_createFolder = new System.Windows.Forms.Button();
            this.btn_createUpdateIndex = new System.Windows.Forms.Button();
            this.txt_newVersion = new System.Windows.Forms.TextBox();
            this.txt_newDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "版本号";
            // 
            // btn_createFolder
            // 
            this.btn_createFolder.Location = new System.Drawing.Point(115, 186);
            this.btn_createFolder.Name = "btn_createFolder";
            this.btn_createFolder.Size = new System.Drawing.Size(95, 30);
            this.btn_createFolder.TabIndex = 2;
            this.btn_createFolder.Text = "创建目录";
            this.btn_createFolder.UseVisualStyleBackColor = true;
            this.btn_createFolder.Click += new System.EventHandler(this.btn_createFolder_Click);
            // 
            // btn_createUpdateIndex
            // 
            this.btn_createUpdateIndex.Location = new System.Drawing.Point(268, 186);
            this.btn_createUpdateIndex.Name = "btn_createUpdateIndex";
            this.btn_createUpdateIndex.Size = new System.Drawing.Size(95, 29);
            this.btn_createUpdateIndex.TabIndex = 3;
            this.btn_createUpdateIndex.Text = "生成配置";
            this.btn_createUpdateIndex.UseVisualStyleBackColor = true;
            this.btn_createUpdateIndex.Click += new System.EventHandler(this.btn_createUpdateIndex_Click);
            // 
            // txt_newVersion
            // 
            this.txt_newVersion.Location = new System.Drawing.Point(115, 102);
            this.txt_newVersion.Name = "txt_newVersion";
            this.txt_newVersion.Size = new System.Drawing.Size(272, 25);
            this.txt_newVersion.TabIndex = 5;
            // 
            // txt_newDate
            // 
            this.txt_newDate.Location = new System.Drawing.Point(115, 58);
            this.txt_newDate.Name = "txt_newDate";
            this.txt_newDate.Size = new System.Drawing.Size(272, 25);
            this.txt_newDate.TabIndex = 6;
            // 
            // UpdateServerSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 282);
            this.Controls.Add(this.txt_newDate);
            this.Controls.Add(this.txt_newVersion);
            this.Controls.Add(this.btn_createUpdateIndex);
            this.Controls.Add(this.btn_createFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateServerSet";
            this.Text = "更新服务设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_createFolder;
        private System.Windows.Forms.Button btn_createUpdateIndex;
        private System.Windows.Forms.TextBox txt_newVersion;
        private System.Windows.Forms.DateTimePicker txt_newDate;
    }
}

