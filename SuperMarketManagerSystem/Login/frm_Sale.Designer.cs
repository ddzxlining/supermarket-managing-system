namespace Login
{
    partial class frm_Sale
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sale));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ssex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ssalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_code = new System.Windows.Forms.Label();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.lb_number = new System.Windows.Forms.Label();
            this.lb_count = new System.Windows.Forms.Label();
            this.lb_money = new System.Windows.Forms.Label();
            this.lb_count_value = new System.Windows.Forms.Label();
            this.lb_money_value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sno,
            this.Sname,
            this.Ssex,
            this.Ssalary,
            this.Spwd,
            this.sum});
            this.dataGridView1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.Location = new System.Drawing.Point(2, -2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(907, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // Sno
            // 
            this.Sno.DataPropertyName = "PId";
            this.Sno.HeaderText = "商品条码";
            this.Sno.Name = "Sno";
            this.Sno.ReadOnly = true;
            this.Sno.Width = 150;
            // 
            // Sname
            // 
            this.Sname.DataPropertyName = "PName";
            this.Sname.HeaderText = "商品名称";
            this.Sname.Name = "Sname";
            this.Sname.ReadOnly = true;
            // 
            // Ssex
            // 
            this.Ssex.DataPropertyName = "PUnit";
            this.Ssex.HeaderText = "商品单位";
            this.Ssex.Name = "Ssex";
            this.Ssex.ReadOnly = true;
            // 
            // Ssalary
            // 
            this.Ssalary.DataPropertyName = "PNumber";
            this.Ssalary.HeaderText = "商品数量";
            this.Ssalary.Name = "Ssalary";
            this.Ssalary.ReadOnly = true;
            // 
            // Spwd
            // 
            this.Spwd.DataPropertyName = "POutprice";
            this.Spwd.HeaderText = "商品单价";
            this.Spwd.Name = "Spwd";
            this.Spwd.ReadOnly = true;
            // 
            // sum
            // 
            this.sum.HeaderText = "小计";
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(323, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "付款";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(451, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "会员";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_code
            // 
            this.lb_code.AutoSize = true;
            this.lb_code.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_code.Location = new System.Drawing.Point(25, 374);
            this.lb_code.Name = "lb_code";
            this.lb_code.Size = new System.Drawing.Size(89, 29);
            this.lb_code.TabIndex = 3;
            this.lb_code.Text = "条码:";
            // 
            // tb_code
            // 
            this.tb_code.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_code.Location = new System.Drawing.Point(126, 374);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(225, 40);
            this.tb_code.TabIndex = 4;
            this.tb_code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_code_KeyDown);
            // 
            // tb_number
            // 
            this.tb_number.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_number.Location = new System.Drawing.Point(126, 429);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(225, 40);
            this.tb_number.TabIndex = 6;
            this.tb_number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_number_KeyDown);
            // 
            // lb_number
            // 
            this.lb_number.AutoSize = true;
            this.lb_number.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_number.Location = new System.Drawing.Point(25, 429);
            this.lb_number.Name = "lb_number";
            this.lb_number.Size = new System.Drawing.Size(89, 29);
            this.lb_number.TabIndex = 5;
            this.lb_number.Text = "数量:";
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_count.Location = new System.Drawing.Point(621, 374);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(89, 29);
            this.lb_count.TabIndex = 7;
            this.lb_count.Text = "件数:";
            // 
            // lb_money
            // 
            this.lb_money.AutoSize = true;
            this.lb_money.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_money.Location = new System.Drawing.Point(621, 429);
            this.lb_money.Name = "lb_money";
            this.lb_money.Size = new System.Drawing.Size(103, 29);
            this.lb_money.TabIndex = 8;
            this.lb_money.Text = "金额：";
            // 
            // lb_count_value
            // 
            this.lb_count_value.AutoSize = true;
            this.lb_count_value.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_count_value.Location = new System.Drawing.Point(734, 374);
            this.lb_count_value.Name = "lb_count_value";
            this.lb_count_value.Size = new System.Drawing.Size(109, 29);
            this.lb_count_value.TabIndex = 9;
            this.lb_count_value.Text = "label1";
            // 
            // lb_money_value
            // 
            this.lb_money_value.AutoSize = true;
            this.lb_money_value.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_money_value.Location = new System.Drawing.Point(734, 429);
            this.lb_money_value.Name = "lb_money_value";
            this.lb_money_value.Size = new System.Drawing.Size(109, 29);
            this.lb_money_value.TabIndex = 10;
            this.lb_money_value.Text = "label1";
            // 
            // frm_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 543);
            this.Controls.Add(this.lb_money_value);
            this.Controls.Add(this.lb_count_value);
            this.Controls.Add(this.lb_money);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.lb_number);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.lb_code);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Sale";
            this.Text = "销售系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_code;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.Label lb_number;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.Label lb_money;
        private System.Windows.Forms.Label lb_count_value;
        private System.Windows.Forms.Label lb_money_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ssex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ssalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
    }
}