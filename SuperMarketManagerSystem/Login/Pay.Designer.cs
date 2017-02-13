namespace Login
{
    partial class Pay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay));
            this.label1 = new System.Windows.Forms.Label();
            this.lb_shouldpay = new System.Windows.Forms.Label();
            this.lb_pay = new System.Windows.Forms.Label();
            this.lb_return = new System.Windows.Forms.Label();
            this.lb_shouldpay_value = new System.Windows.Forms.Label();
            this.tb_pay = new System.Windows.Forms.TextBox();
            this.lb_return_value = new System.Windows.Forms.Label();
            this.bt_done = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_sum_value = new System.Windows.Forms.Label();
            this.lb_discount_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 35F);
            this.label1.Location = new System.Drawing.Point(348, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "支付";
            // 
            // lb_shouldpay
            // 
            this.lb_shouldpay.AutoSize = true;
            this.lb_shouldpay.Font = new System.Drawing.Font("宋体", 30F);
            this.lb_shouldpay.Location = new System.Drawing.Point(251, 255);
            this.lb_shouldpay.Name = "lb_shouldpay";
            this.lb_shouldpay.Size = new System.Drawing.Size(212, 48);
            this.lb_shouldpay.TabIndex = 1;
            this.lb_shouldpay.Text = "应付款：";
            // 
            // lb_pay
            // 
            this.lb_pay.AutoSize = true;
            this.lb_pay.Font = new System.Drawing.Font("宋体", 30F);
            this.lb_pay.Location = new System.Drawing.Point(251, 323);
            this.lb_pay.Name = "lb_pay";
            this.lb_pay.Size = new System.Drawing.Size(212, 48);
            this.lb_pay.TabIndex = 2;
            this.lb_pay.Text = "付  款：";
            // 
            // lb_return
            // 
            this.lb_return.AutoSize = true;
            this.lb_return.Font = new System.Drawing.Font("宋体", 30F);
            this.lb_return.Location = new System.Drawing.Point(251, 385);
            this.lb_return.Name = "lb_return";
            this.lb_return.Size = new System.Drawing.Size(212, 48);
            this.lb_return.TabIndex = 3;
            this.lb_return.Text = "找  零：";
            // 
            // lb_shouldpay_value
            // 
            this.lb_shouldpay_value.AutoSize = true;
            this.lb_shouldpay_value.Font = new System.Drawing.Font("宋体", 30F);
            this.lb_shouldpay_value.Location = new System.Drawing.Point(423, 255);
            this.lb_shouldpay_value.Name = "lb_shouldpay_value";
            this.lb_shouldpay_value.Size = new System.Drawing.Size(0, 48);
            this.lb_shouldpay_value.TabIndex = 4;
            // 
            // tb_pay
            // 
            this.tb_pay.Font = new System.Drawing.Font("宋体", 30F);
            this.tb_pay.Location = new System.Drawing.Point(420, 320);
            this.tb_pay.Name = "tb_pay";
            this.tb_pay.Size = new System.Drawing.Size(229, 62);
            this.tb_pay.TabIndex = 5;
            this.tb_pay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_pay_KeyDown);
            // 
            // lb_return_value
            // 
            this.lb_return_value.AutoSize = true;
            this.lb_return_value.Font = new System.Drawing.Font("宋体", 30F);
            this.lb_return_value.Location = new System.Drawing.Point(423, 396);
            this.lb_return_value.Name = "lb_return_value";
            this.lb_return_value.Size = new System.Drawing.Size(0, 48);
            this.lb_return_value.TabIndex = 6;
            // 
            // bt_done
            // 
            this.bt_done.Font = new System.Drawing.Font("宋体", 25F);
            this.bt_done.Location = new System.Drawing.Point(304, 472);
            this.bt_done.Name = "bt_done";
            this.bt_done.Size = new System.Drawing.Size(193, 63);
            this.bt_done.TabIndex = 7;
            this.bt_done.Text = "完成";
            this.bt_done.UseVisualStyleBackColor = true;
            this.bt_done.Click += new System.EventHandler(this.bt_done_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 30F);
            this.label2.Location = new System.Drawing.Point(269, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 48);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 30F);
            this.label3.Location = new System.Drawing.Point(91, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 48);
            this.label3.TabIndex = 8;
            this.label3.Text = "总  价：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 30F);
            this.label4.Location = new System.Drawing.Point(461, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 48);
            this.label4.TabIndex = 10;
            this.label4.Text = "优  惠：";
            // 
            // lb_sum_value
            // 
            this.lb_sum_value.AutoSize = true;
            this.lb_sum_value.Font = new System.Drawing.Font("宋体", 30F);
            this.lb_sum_value.Location = new System.Drawing.Point(269, 178);
            this.lb_sum_value.Name = "lb_sum_value";
            this.lb_sum_value.Size = new System.Drawing.Size(0, 48);
            this.lb_sum_value.TabIndex = 11;
            // 
            // lb_discount_value
            // 
            this.lb_discount_value.AutoSize = true;
            this.lb_discount_value.Font = new System.Drawing.Font("宋体", 30F);
            this.lb_discount_value.Location = new System.Drawing.Point(632, 178);
            this.lb_discount_value.Name = "lb_discount_value";
            this.lb_discount_value.Size = new System.Drawing.Size(0, 48);
            this.lb_discount_value.TabIndex = 12;
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 564);
            this.Controls.Add(this.lb_discount_value);
            this.Controls.Add(this.lb_sum_value);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_done);
            this.Controls.Add(this.lb_return_value);
            this.Controls.Add(this.tb_pay);
            this.Controls.Add(this.lb_shouldpay_value);
            this.Controls.Add(this.lb_return);
            this.Controls.Add(this.lb_pay);
            this.Controls.Add(this.lb_shouldpay);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pay";
            this.Text = "支付";
            this.Load += new System.EventHandler(this.Pay_Load);
            this.Shown += new System.EventHandler(this.Pay_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_shouldpay;
        private System.Windows.Forms.Label lb_pay;
        private System.Windows.Forms.Label lb_return;
        private System.Windows.Forms.Label lb_shouldpay_value;
        private System.Windows.Forms.TextBox tb_pay;
        private System.Windows.Forms.Label lb_return_value;
        private System.Windows.Forms.Button bt_done;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_sum_value;
        private System.Windows.Forms.Label lb_discount_value;
    }
}