﻿namespace Login
{
    partial class frm_Stock_Alter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Stock_Alter));
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_current_stock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_user
            // 
            this.tb_user.BackColor = System.Drawing.SystemColors.Window;
            this.tb_user.Font = new System.Drawing.Font("宋体", 15F);
            this.tb_user.Location = new System.Drawing.Point(629, 202);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(224, 36);
            this.tb_user.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 15F);
            this.label6.Location = new System.Drawing.Point(494, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 99;
            this.label6.Text = "操作员工:";
            // 
            // tb_current_stock
            // 
            this.tb_current_stock.BackColor = System.Drawing.SystemColors.Window;
            this.tb_current_stock.Font = new System.Drawing.Font("宋体", 15F);
            this.tb_current_stock.Location = new System.Drawing.Point(225, 202);
            this.tb_current_stock.Name = "tb_current_stock";
            this.tb_current_stock.Size = new System.Drawing.Size(224, 36);
            this.tb_current_stock.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 15F);
            this.label5.Location = new System.Drawing.Point(90, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 97;
            this.label5.Text = "现有库存:";
            // 
            // tb_number
            // 
            this.tb_number.BackColor = System.Drawing.SystemColors.Window;
            this.tb_number.Font = new System.Drawing.Font("宋体", 18F);
            this.tb_number.Location = new System.Drawing.Point(402, 323);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(224, 42);
            this.tb_number.TabIndex = 96;
            this.tb_number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_number_KeyDown);
            this.tb_number.Leave += new System.EventHandler(this.tb_number_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 18F);
            this.label4.Location = new System.Drawing.Point(258, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 30);
            this.label4.TabIndex = 95;
            this.label4.Text = "出库数量:";
            // 
            // button2
            // 
            this.button2.CausesValidation = false;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(575, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 52);
            this.button2.TabIndex = 94;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 52);
            this.button1.TabIndex = 93;
            this.button1.Text = "出库";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("宋体", 15F);
            this.tb_name.Location = new System.Drawing.Point(615, 107);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(224, 36);
            this.tb_name.TabIndex = 92;
            // 
            // tb_code
            // 
            this.tb_code.BackColor = System.Drawing.SystemColors.Window;
            this.tb_code.Font = new System.Drawing.Font("宋体", 15F);
            this.tb_code.Location = new System.Drawing.Point(225, 107);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(224, 36);
            this.tb_code.TabIndex = 91;
            this.tb_code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_code_KeyDown);
            this.tb_code.Leave += new System.EventHandler(this.tb_code_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(494, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 90;
            this.label3.Text = "商品名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(90, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 89;
            this.label2.Text = "商品条码:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(404, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 52);
            this.label1.TabIndex = 88;
            this.label1.Text = "出库";
            // 
            // frm_Stock_Alter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(942, 561);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_current_stock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Stock_Alter";
            this.Text = "出库";
            this.Load += new System.EventHandler(this.frm_Stock_out_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_current_stock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}