using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frm_Sale : Form
    {
        public string lastcode = "";
        public int lastindex = 0;
        double Number=0.0;
        double discount=0, pay;
        string vip;
        void SetValue(double discount,double pay,string vip)
        {
            this.discount = discount;
            this.pay = pay;
            this.vip = vip;
        }
        DataTable dt = new DataTable();
        public frm_Sale()
        {
            InitializeComponent();
        }
        private void frm_Sale_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Size = new System.Drawing.Size(this.ClientSize.Width, this.ClientSize.Height - 200);
            this.Sno.Width = (this.dataGridView1.Size.Width - 50) / 6;
            this.Sname.Width = (this.dataGridView1.Size.Width - 50) / 6;
            this.Ssex.Width = (this.dataGridView1.Size.Width - 50) / 6;
            this.Ssalary.Width = (this.dataGridView1.Size.Width - 50) / 6;
            this.Spwd.Width = (this.dataGridView1.Size.Width - 50) / 6;
            this.sum.Width= (this.dataGridView1.Size.Width - 50) / 6;
            this.dataGridView1.AutoGenerateColumns = false;
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;
            this.button1.Location = new System.Drawing.Point((int)(width*0.414063), (int)(height*0.80025));
            this.button2.Location = new System.Drawing.Point((int)(width*0.414063), (int)(height*0.912609));
            this.lb_code.Location= new System.Drawing.Point((int)(width*0.023438), (int)(height*0.80025));
            this.lb_number.Location = new System.Drawing.Point((int)(width*0.023438), (int)(height*0.875156));
            this.tb_code.Location = new System.Drawing.Point((int)(width*0.075521), (int)(height*0.80025));
            this.tb_number.Location = new System.Drawing.Point((int)(width*0.075521), (int)(height*0.875156));
            this.lb_count.Location = new System.Drawing.Point((int)(width*0.739583), (int)(height*0.80025));
            this.lb_money.Location = new System.Drawing.Point((int)(width*0.739583), (int)(height*0.875156));
            this.lb_count_value.Location = new System.Drawing.Point((int)(width*0.798177), (int)(height*0.80025));
            this.lb_money_value.Location = new System.Drawing.Point((int)(width*0.798177), (int)(height*0.875156));
            timer1.Interval = 500;
            TableInit();
            dataGridView1.DataSource = dt;
            tb_code.Focus();
            lb_count_value.Text = "0";
            lb_money_value.Text = "0.00";
        }
        private void TableInit()
        {
            dt.Columns.Add("PId");
            dt.Columns.Add("PName");
            dt.Columns.Add("PUnit");
            dt.Columns.Add("POutprice"); 
            dt.Columns.Add("Number");            
            dt.Columns.Add("Sum");

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tb_code.Focus();
            timer1.Stop();
        }
        double totalnumber=0;
        double totalmoney = 0;
        double number = 1;
        double money = 0;
        double perprice = 0;
        private void tb_code_KeyDown(object sender, KeyEventArgs e)
        {
            if(tb_code.Text!=""&&e.KeyCode==Keys.Enter)
            {
                string code = tb_code.Text;
                if (!Regex.Match(code, "^[0-9]{6,13}$").Success) { tb_code.Text = "";tb_code.Focus(); }
                else
                {
                    string sql = "select PId,PName,PUnit,POutprice from table_Production where PId=@code;";
                    SqlParameter[] sp = { new SqlParameter("@code", code) };
                    DataRow dr = dt.NewRow();
                    try
                    {
                        dr = SqlHelper.LoadData(sql, "sql_login", sp).Tables[0].Rows[0];
                        dt.Rows.Add(dr.ItemArray);
                        lastindex = this.dataGridView1.Rows.Count - 1;
                        number = 1;
                        dataGridView1.Rows[lastindex].Cells[3].Value = number;
                        money = Convert.ToDouble(dataGridView1.Rows[lastindex].Cells[4].Value) * number;
                        dataGridView1.Rows[lastindex].Cells[5].Value = money;
                        perprice = money;
                        totalnumber += 1;
                        totalmoney += money;
                        this.dataGridView1.Rows[lastindex].Selected = true;
                        tb_code.Text = "";
                        lb_count_value.Text = totalnumber.ToString();
                        lb_money_value.Text = totalmoney.ToString();
                        tb_number.Enabled = true;
                        tb_number.Focus();
                        timer1.Start();
                        sql = "select Number from table_Stock where PId=@code";
                        SqlParameter[] sp1 = { new SqlParameter("@code", code) };
                        Number = double.Parse(SqlHelper.SqlExecuteSaclar(sql, "sql_login", sp1).ToString());
                        if (Number <= 0)
                        {
                            MessageBox.Show("该商品库存为0，不能出售！");
                            tb_code.Text = "";
                            tb_code.Focus();
                            this.dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
                            totalnumber -= 1;
                            totalmoney -= money;
                            lb_count_value.Text = totalnumber.ToString();
                            lb_money_value.Text = totalmoney.ToString();
                        }
                    }
                    catch { MessageBox.Show("没有该商品！"); tb_code.Text = "";tb_code.Focus(); }                    
                }     
            }
            else if(tb_code.Text == "" && e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }
        private void tb_number_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (!double.TryParse(tb_number.Text, out number)) { MessageBox.Show("输入数量不合法！"); tb_number.Text = ""; tb_number.Focus(); }
                else
                {
                    dataGridView1.Rows[lastindex].Cells[3].Value = number;
                    money = Convert.ToDouble(dataGridView1.Rows[lastindex].Cells[4].Value) * number;
                    dataGridView1.Rows[lastindex].Cells[5].Value = money;
                    this.dataGridView1.Rows[lastindex].Selected = true;
                    tb_number.Text = "";
                    totalnumber += number - 1;
                    totalmoney += money - perprice;
                    lb_count_value.Text = totalnumber.ToString();
                    lb_money_value.Text = totalmoney.ToString();
                    tb_number.Enabled = false;
                    tb_code.Focus();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PayandLog(false);
        }
        private void PayandLog(bool isvip)
        {
            Pay pay1 = new Pay(totalmoney, isvip,SetValue);
            if (pay1.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                string SerialNumber=method.SerialNumber();
                string code = "";
                string uid = "";
                DateTime time = DateTime.Now;
                double number = 0.0;
                double sum = 0.0;
                string db = "sql_login";
                string strisvip;
                if (isvip)
                    strisvip = "是";
                else
                    strisvip = "否";
                string sql = "";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    code = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    number = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    sum = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value.ToString());
                    uid = SqlHelper.uid;
                    time = DateTime.Now;
                    SqlParameter[] sp =
                {
                    new SqlParameter("@serialnumber",SerialNumber),
                    new SqlParameter("@code",code),
                    new SqlParameter("@number",number),
                    new SqlParameter("@sum",sum),
                    new SqlParameter("@uid",uid),
                    new SqlParameter("@time",time)
                };
                     sql = "insert into table_SaleLog(SerialNumber,PId, number, PSum, UId, PTime) values(@serialnumber,@code,@number,@sum,@uid,@time);";
                    SqlHelper.SqlExecuteNonQuery(sql, db, sp);
                    number = Number - number;
                    SqlParameter[] sp1 = { new SqlParameter("@code", code), new SqlParameter("@number", number) };
                    sql = "update table_Stock set Number=@number where PId=@code;";
                    SqlHelper.SqlExecuteNonQuery(sql, "sql_login", sp1);
                }
                SqlParameter[] sp2 =
                {
                    new SqlParameter("@serialnumber",SerialNumber),
                    new SqlParameter("@sum",totalmoney),
                    new SqlParameter("@isvip",strisvip),
                    new SqlParameter("@discount",discount),
                    new SqlParameter("@pay",pay),
                    new SqlParameter("@time",DateTime.Now),
                    new SqlParameter("@emp",SqlHelper.uid),
                    new SqlParameter("@vip",vip)
                };
                sql = "insert into table_SerialLog(SerialNumber, Sum, Isvip,discount, Pay, Time, Employer,Vip) values(@serialnumber,@sum,@isvip,@discount,@pay,@time,@emp,@vip);";
                SqlHelper.SqlExecuteNonQuery(sql, "sql_login", sp2);
                dt.Clear();
                totalnumber = 0;
                totalmoney = 0.0;
                lb_count_value.Text = totalnumber.ToString();
                lb_money_value.Text = totalmoney.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PayandLog(true);
        }
    }
}
