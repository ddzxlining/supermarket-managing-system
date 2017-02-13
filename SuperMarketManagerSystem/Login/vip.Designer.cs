namespace Login
{
    partial class vip
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_vip_code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_vip_name = new System.Windows.Forms.Label();
            this.lb_vip_discount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 25F);
            this.label1.Location = new System.Drawing.Point(190, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 20F);
            this.label2.Location = new System.Drawing.Point(52, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "会员卡号：";
            // 
            // tb_vip_code
            // 
            this.tb_vip_code.Font = new System.Drawing.Font("宋体", 20F);
            this.tb_vip_code.Location = new System.Drawing.Point(209, 96);
            this.tb_vip_code.Name = "tb_vip_code";
            this.tb_vip_code.Size = new System.Drawing.Size(181, 44);
            this.tb_vip_code.TabIndex = 2;
            this.tb_vip_code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_vip_code_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 20F);
            this.label3.Location = new System.Drawing.Point(52, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "积    分：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 20F);
            this.label4.Location = new System.Drawing.Point(52, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "姓    名：";
            // 
            // lb_vip_name
            // 
            this.lb_vip_name.AutoSize = true;
            this.lb_vip_name.Font = new System.Drawing.Font("宋体", 20F);
            this.lb_vip_name.Location = new System.Drawing.Point(215, 151);
            this.lb_vip_name.Name = "lb_vip_name";
            this.lb_vip_name.Size = new System.Drawing.Size(0, 33);
            this.lb_vip_name.TabIndex = 7;
            // 
            // lb_vip_discount
            // 
            this.lb_vip_discount.AutoSize = true;
            this.lb_vip_discount.Font = new System.Drawing.Font("宋体", 20F);
            this.lb_vip_discount.Location = new System.Drawing.Point(215, 208);
            this.lb_vip_discount.Name = "lb_vip_discount";
            this.lb_vip_discount.Size = new System.Drawing.Size(0, 33);
            this.lb_vip_discount.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15F);
            this.button1.Location = new System.Drawing.Point(79, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 61);
            this.button1.TabIndex = 8;
            this.button1.Text = "继续付款";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 15F);
            this.button2.Location = new System.Drawing.Point(266, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 61);
            this.button2.TabIndex = 9;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // vip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 373);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_vip_name);
            this.Controls.Add(this.lb_vip_discount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_vip_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "vip";
            this.Text = "会员";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_vip_code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_vip_name;
        private System.Windows.Forms.Label lb_vip_discount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}