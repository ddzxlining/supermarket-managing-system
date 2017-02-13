namespace Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.lb_Uid = new System.Windows.Forms.Label();
            this.tb_Uid = new System.Windows.Forms.TextBox();
            this.tb_Pwd = new System.Windows.Forms.TextBox();
            this.lb_Pwd = new System.Windows.Forms.Label();
            this.bt_Login = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Uid
            // 
            this.lb_Uid.AutoSize = true;
            this.lb_Uid.BackColor = System.Drawing.Color.Transparent;
            this.lb_Uid.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lb_Uid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Uid.Location = new System.Drawing.Point(103, 158);
            this.lb_Uid.Name = "lb_Uid";
            this.lb_Uid.Size = new System.Drawing.Size(58, 20);
            this.lb_Uid.TabIndex = 1;
            this.lb_Uid.Text = "用户名:";
            // 
            // tb_Uid
            // 
            this.tb_Uid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_Uid.Location = new System.Drawing.Point(172, 155);
            this.tb_Uid.Name = "tb_Uid";
            this.tb_Uid.Size = new System.Drawing.Size(133, 23);
            this.tb_Uid.TabIndex = 2;
            // 
            // tb_Pwd
            // 
            this.tb_Pwd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_Pwd.Location = new System.Drawing.Point(172, 195);
            this.tb_Pwd.Name = "tb_Pwd";
            this.tb_Pwd.Size = new System.Drawing.Size(133, 23);
            this.tb_Pwd.TabIndex = 4;
            this.tb_Pwd.UseSystemPasswordChar = true;
            // 
            // lb_Pwd
            // 
            this.lb_Pwd.AutoSize = true;
            this.lb_Pwd.BackColor = System.Drawing.Color.Transparent;
            this.lb_Pwd.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lb_Pwd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Pwd.Location = new System.Drawing.Point(103, 198);
            this.lb_Pwd.Name = "lb_Pwd";
            this.lb_Pwd.Size = new System.Drawing.Size(59, 20);
            this.lb_Pwd.TabIndex = 3;
            this.lb_Pwd.Text = "密    码:";
            // 
            // bt_Login
            // 
            this.bt_Login.BackColor = System.Drawing.Color.White;
            this.bt_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Login.Location = new System.Drawing.Point(96, 265);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(104, 36);
            this.bt_Login.TabIndex = 5;
            this.bt_Login.Text = "登录";
            this.bt_Login.UseVisualStyleBackColor = false;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.Color.White;
            this.bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Cancel.Location = new System.Drawing.Point(253, 265);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(104, 36);
            this.bt_Cancel.TabIndex = 6;
            this.bt_Cancel.Text = "取消";
            this.bt_Cancel.UseVisualStyleBackColor = false;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Login.Properties.Resources.bt_eye;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(266, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 22);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 28F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(61, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "超市进销存系统";
            // 
            // frm_Login
            // 
            this.AcceptButton = this.bt_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(115F, 115F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(462, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.tb_Pwd);
            this.Controls.Add(this.lb_Pwd);
            this.Controls.Add(this.tb_Uid);
            this.Controls.Add(this.lb_Uid);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_Uid;
        private System.Windows.Forms.TextBox tb_Uid;
        private System.Windows.Forms.TextBox tb_Pwd;
        private System.Windows.Forms.Label lb_Pwd;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

