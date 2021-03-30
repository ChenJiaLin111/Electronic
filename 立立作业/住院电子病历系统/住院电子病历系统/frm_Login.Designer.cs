namespace 住院电子病历系统
{
    partial class frm_Login
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_lgName = new System.Windows.Forms.Label();
            this.lab_lgPwd = new System.Windows.Forms.Label();
            this.txb_lgName = new System.Windows.Forms.TextBox();
            this.txb_lgPwd = new System.Windows.Forms.TextBox();
            this.lab_lgidentity = new System.Windows.Forms.Label();
            this.cbB_lgidentity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_lg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_lgName
            // 
            this.lab_lgName.AutoSize = true;
            this.lab_lgName.Location = new System.Drawing.Point(46, 85);
            this.lab_lgName.Name = "lab_lgName";
            this.lab_lgName.Size = new System.Drawing.Size(80, 18);
            this.lab_lgName.TabIndex = 0;
            this.lab_lgName.Text = "用户名：";
            // 
            // lab_lgPwd
            // 
            this.lab_lgPwd.AutoSize = true;
            this.lab_lgPwd.Location = new System.Drawing.Point(64, 138);
            this.lab_lgPwd.Name = "lab_lgPwd";
            this.lab_lgPwd.Size = new System.Drawing.Size(62, 18);
            this.lab_lgPwd.TabIndex = 1;
            this.lab_lgPwd.Text = "密码：";
            // 
            // txb_lgName
            // 
            this.txb_lgName.Location = new System.Drawing.Point(132, 82);
            this.txb_lgName.Name = "txb_lgName";
            this.txb_lgName.Size = new System.Drawing.Size(166, 28);
            this.txb_lgName.TabIndex = 2;
            // 
            // txb_lgPwd
            // 
            this.txb_lgPwd.Location = new System.Drawing.Point(132, 135);
            this.txb_lgPwd.Name = "txb_lgPwd";
            this.txb_lgPwd.Size = new System.Drawing.Size(166, 28);
            this.txb_lgPwd.TabIndex = 3;
            // 
            // lab_lgidentity
            // 
            this.lab_lgidentity.AutoSize = true;
            this.lab_lgidentity.Location = new System.Drawing.Point(64, 31);
            this.lab_lgidentity.Name = "lab_lgidentity";
            this.lab_lgidentity.Size = new System.Drawing.Size(62, 18);
            this.lab_lgidentity.TabIndex = 4;
            this.lab_lgidentity.Text = "身份：";
            // 
            // cbB_lgidentity
            // 
            this.cbB_lgidentity.FormattingEnabled = true;
            this.cbB_lgidentity.Items.AddRange(new object[] {
            "医生",
            "护士",
            "管理员"});
            this.cbB_lgidentity.Location = new System.Drawing.Point(132, 28);
            this.cbB_lgidentity.Name = "cbB_lgidentity";
            this.cbB_lgidentity.Size = new System.Drawing.Size(166, 26);
            this.cbB_lgidentity.TabIndex = 5;
            this.cbB_lgidentity.Text = "--请选择--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "请选择身份，输入用户名、密码";
            // 
            // btn_lg
            // 
            this.btn_lg.Location = new System.Drawing.Point(145, 234);
            this.btn_lg.Name = "btn_lg";
            this.btn_lg.Size = new System.Drawing.Size(83, 34);
            this.btn_lg.TabIndex = 7;
            this.btn_lg.Text = "登录";
            this.btn_lg.UseVisualStyleBackColor = true;
            this.btn_lg.Click += new System.EventHandler(this.btn_lg_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 296);
            this.Controls.Add(this.btn_lg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbB_lgidentity);
            this.Controls.Add(this.lab_lgidentity);
            this.Controls.Add(this.txb_lgPwd);
            this.Controls.Add(this.txb_lgName);
            this.Controls.Add(this.lab_lgPwd);
            this.Controls.Add(this.lab_lgName);
            this.Name = "frm_Login";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_lgName;
        private System.Windows.Forms.Label lab_lgPwd;
        private System.Windows.Forms.TextBox txb_lgName;
        private System.Windows.Forms.TextBox txb_lgPwd;
        private System.Windows.Forms.Label lab_lgidentity;
        private System.Windows.Forms.ComboBox cbB_lgidentity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_lg;
    }
}

