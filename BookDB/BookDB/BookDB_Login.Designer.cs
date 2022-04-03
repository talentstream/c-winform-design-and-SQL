
namespace BookDB
{
    partial class BookDB_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBuser = new System.Windows.Forms.TextBox();
            this.tBpsw = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rBuser = new System.Windows.Forms.RadioButton();
            this.rBadmin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文楷体", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(364, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书管理系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(219, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "账号：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(219, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码：";
            // 
            // tBuser
            // 
            this.tBuser.Location = new System.Drawing.Point(366, 191);
            this.tBuser.Name = "tBuser";
            this.tBuser.Size = new System.Drawing.Size(441, 35);
            this.tBuser.TabIndex = 3;
            // 
            // tBpsw
            // 
            this.tBpsw.Location = new System.Drawing.Point(366, 268);
            this.tBpsw.Name = "tBpsw";
            this.tBpsw.Size = new System.Drawing.Size(441, 35);
            this.tBpsw.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("隶书", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.Location = new System.Drawing.Point(377, 445);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(144, 55);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("隶书", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(638, 445);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 55);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // rBuser
            // 
            this.rBuser.AutoSize = true;
            this.rBuser.Checked = true;
            this.rBuser.Location = new System.Drawing.Point(377, 366);
            this.rBuser.Name = "rBuser";
            this.rBuser.Size = new System.Drawing.Size(89, 28);
            this.rBuser.TabIndex = 7;
            this.rBuser.TabStop = true;
            this.rBuser.Text = "用户";
            this.rBuser.UseVisualStyleBackColor = true;
            this.rBuser.CheckedChanged += new System.EventHandler(this.rBUser_CheckedChanged);
            // 
            // rBadmin
            // 
            this.rBadmin.AutoSize = true;
            this.rBadmin.Location = new System.Drawing.Point(638, 366);
            this.rBadmin.Name = "rBadmin";
            this.rBadmin.Size = new System.Drawing.Size(113, 28);
            this.rBadmin.TabIndex = 8;
            this.rBadmin.Text = "管理员";
            this.rBadmin.UseVisualStyleBackColor = true;
            // 
            // BookDB_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 745);
            this.Controls.Add(this.rBadmin);
            this.Controls.Add(this.rBuser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tBpsw);
            this.Controls.Add(this.tBuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookDB_Login";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBuser;
        private System.Windows.Forms.TextBox tBpsw;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rBuser;
        private System.Windows.Forms.RadioButton rBadmin;
    }
}

