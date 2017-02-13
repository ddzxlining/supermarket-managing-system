namespace Login
{
    partial class frm_Production_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Production_Add));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_place = new System.Windows.Forms.TextBox();
            this.tb_inprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_outprice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_conserve = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_norm = new System.Windows.Forms.TextBox();
            this.tb_unit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(306, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "添加商品";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(63, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品条码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(416, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "商品名称:";
            // 
            // tb_code
            // 
            this.tb_code.BackColor = System.Drawing.SystemColors.Window;
            this.tb_code.Font = new System.Drawing.Font("宋体", 15F);
            this.tb_code.Location = new System.Drawing.Point(181, 91);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(196, 35);
            this.tb_code.TabIndex = 1;
            this.tb_code.TextChanged += new System.EventHandler(this.tb_code_Leave);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("宋体", 15F);
            this.tb_name.Location = new System.Drawing.Point(522, 91);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(196, 35);
            this.tb_name.TabIndex = 2;
            this.tb_name.Leave += new System.EventHandler(this.tb_name_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(63, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "生 产 商:";
            // 
            // tb_place
            // 
            this.tb_place.Font = new System.Drawing.Font("宋体", 15F);
            this.tb_place.Location = new System.Drawing.Point(181, 159);
            this.tb_place.Name = "tb_place";
            this.tb_place.Size = new System.Drawing.Size(196, 35);
            this.tb_place.TabIndex = 3;
            this.tb_place.Leave += new System.EventHandler(this.tb_place_Leave);
            // 
            // tb_inprice
            // 
            this.tb_inprice.Font = new System.Drawing.Font("宋体", 15F);
            this.tb_inprice.Location = new System.Drawing.Point(181, 305);
            this.tb_inprice.Name = "tb_inprice";
            this.tb_inprice.Size = new System.Drawing.Size(196, 35);
            this.tb_inprice.TabIndex = 7;
            this.tb_inprice.Leave += new System.EventHandler(this.tb_inprice_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 15F);
            this.label6.Location = new System.Drawing.Point(60, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "商品进价:";
            // 
            // tb_outprice
            // 
            this.tb_outprice.Font = new System.Drawing.Font("宋体", 15F);
            this.tb_outprice.Location = new System.Drawing.Point(522, 305);
            this.tb_outprice.Name = "tb_outprice";
            this.tb_outprice.Size = new System.Drawing.Size(196, 35);
            this.tb_outprice.TabIndex = 8;
            this.tb_outprice.Leave += new System.EventHandler(this.tb_outprice_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 15F);
            this.label7.Location = new System.Drawing.Point(416, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "商品售价:";
            // 
            // tb_date
            // 
            this.tb_date.Font = new System.Drawing.Font("宋体", 15F);
            this.tb_date.Location = new System.Drawing.Point(181, 375);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(196, 35);
            this.tb_date.TabIndex = 9;
            this.tb_date.Leave += new System.EventHandler(this.tb_prodate_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("宋体", 15F);
            this.label8.Location = new System.Drawing.Point(63, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "生产日期:";
            // 
            // tb_conserve
            // 
            this.tb_conserve.Font = new System.Drawing.Font("宋体", 15F);
            this.tb_conserve.Location = new System.Drawing.Point(522, 375);
            this.tb_conserve.Name = "tb_conserve";
            this.tb_conserve.Size = new System.Drawing.Size(196, 35);
            this.tb_conserve.TabIndex = 10;
            this.tb_conserve.Leave += new System.EventHandler(this.tb_conserve_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("宋体", 15F);
            this.label9.Location = new System.Drawing.Point(416, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "保 质 期:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(487, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 49);
            this.button2.TabIndex = 11;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_number
            // 
            this.tb_number.Font = new System.Drawing.Font("宋体", 15F);
            this.tb_number.Location = new System.Drawing.Point(522, 159);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(196, 35);
            this.tb_number.TabIndex = 4;
            this.tb_number.Leave += new System.EventHandler(this.tb_number_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("宋体", 15F);
            this.label10.Location = new System.Drawing.Point(416, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "商品数量:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 15F);
            this.label5.Location = new System.Drawing.Point(63, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "商品规格:";
            // 
            // tb_norm
            // 
            this.tb_norm.Font = new System.Drawing.Font("宋体", 15F);
            this.tb_norm.Location = new System.Drawing.Point(181, 230);
            this.tb_norm.Name = "tb_norm";
            this.tb_norm.Size = new System.Drawing.Size(196, 35);
            this.tb_norm.TabIndex = 5;
            this.tb_norm.Leave += new System.EventHandler(this.tb_norm_Leave);
            // 
            // tb_unit
            // 
            this.tb_unit.Font = new System.Drawing.Font("宋体", 15F);
            this.tb_unit.Location = new System.Drawing.Point(522, 230);
            this.tb_unit.Name = "tb_unit";
            this.tb_unit.Size = new System.Drawing.Size(196, 35);
            this.tb_unit.TabIndex = 6;
            this.tb_unit.Leave += new System.EventHandler(this.tb_unit_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("宋体", 15F);
            this.label11.Location = new System.Drawing.Point(416, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "商品单位:";
            // 
            // frm_Production_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(772, 524);
            this.Controls.Add(this.tb_unit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_conserve);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_outprice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_inprice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_norm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_place);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Production_Add";
            this.Text = "添加商品";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_place;
        private System.Windows.Forms.TextBox tb_inprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_outprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_conserve;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_norm;
        private System.Windows.Forms.TextBox tb_unit;
        private System.Windows.Forms.Label label11;
    }
}