namespace Update
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.txt_updateLog = new System.Windows.Forms.TextBox();
            this.btn_updateSet = new System.Windows.Forms.Button();
            this.btn_updateStart = new System.Windows.Forms.Button();
            this.btn_showLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_updateLog
            // 
            this.txt_updateLog.Location = new System.Drawing.Point(12, 99);
            this.txt_updateLog.Multiline = true;
            this.txt_updateLog.Name = "txt_updateLog";
            this.txt_updateLog.Size = new System.Drawing.Size(615, 328);
            this.txt_updateLog.TabIndex = 1;
            // 
            // btn_updateSet
            // 
            this.btn_updateSet.Location = new System.Drawing.Point(12, 12);
            this.btn_updateSet.Name = "btn_updateSet";
            this.btn_updateSet.Size = new System.Drawing.Size(107, 31);
            this.btn_updateSet.TabIndex = 2;
            this.btn_updateSet.Text = "更新设置";
            this.btn_updateSet.UseVisualStyleBackColor = true;
            this.btn_updateSet.Click += new System.EventHandler(this.btn_updateSet_Click);
            // 
            // btn_updateStart
            // 
            this.btn_updateStart.Location = new System.Drawing.Point(265, 12);
            this.btn_updateStart.Name = "btn_updateStart";
            this.btn_updateStart.Size = new System.Drawing.Size(92, 31);
            this.btn_updateStart.TabIndex = 3;
            this.btn_updateStart.Text = "开始更新";
            this.btn_updateStart.UseVisualStyleBackColor = true;
            this.btn_updateStart.Click += new System.EventHandler(this.btn_updateStart_Click);
            // 
            // btn_showLog
            // 
            this.btn_showLog.Location = new System.Drawing.Point(535, 62);
            this.btn_showLog.Name = "btn_showLog";
            this.btn_showLog.Size = new System.Drawing.Size(92, 31);
            this.btn_showLog.TabIndex = 4;
            this.btn_showLog.Text = "详细信息";
            this.btn_showLog.UseVisualStyleBackColor = true;
            this.btn_showLog.Visible = false;
            this.btn_showLog.Click += new System.EventHandler(this.btn_showLog_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 97);
            this.Controls.Add(this.btn_showLog);
            this.Controls.Add(this.btn_updateStart);
            this.Controls.Add(this.btn_updateSet);
            this.Controls.Add(this.txt_updateLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update";
            this.Text = "更新";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_updateLog;
        private System.Windows.Forms.Button btn_updateSet;
        private System.Windows.Forms.Button btn_updateStart;
        private System.Windows.Forms.Button btn_showLog;
    }
}

