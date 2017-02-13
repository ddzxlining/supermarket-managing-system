using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frm_Stock_Alter : Form
    {
        double number=0.0, numbersub=0.0;
        public frm_Stock_Alter(params string[] code)
        {
            InitializeComponent();
            if (code.Count<string>() > 0)
            {
                tb_code.Text = code[0];
                tb_code.Focus();
                SendKeys.Send("{Enter}");
            }
        }
        private void frm_Stock_out_Load(object sender, EventArgs e)
        {
            tb_current_stock.Enabled = false;
            tb_name.Enabled = false;
            tb_number.Enabled = false;
            tb_user.Enabled = false;
        }
        private void tb_code_Leave(object sender, EventArgs e)
        {
            if (tb_code.Text == "")
            {
                MessageBox.Show("不能为空");
            }
            else
            {
                string code = tb_code.Text;
                string sql = "select PName,Number,u.Uname from table_User u,table_Production p,table_Stock s where s.PId=@code and p.PId=s.PId and u.UId=@uid";
                string db = "sql_login";
                SqlParameter[] sp =
                {
                    new SqlParameter ("@code",code),
                    new SqlParameter("@uid",SqlHelper.uid)
                };
                string connStr = ConfigurationManager.ConnectionStrings[db].ConnectionString;
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            conn.Open();
                            cmd.Parameters.AddRange(sp);
                            SqlDataReader sdr = cmd.ExecuteReader();
                            sdr.Read();
                            tb_name.Text = sdr[0].ToString();
                            tb_current_stock.Text = (Convert.ToDouble(sdr[1])).ToString();
                            number = Convert.ToDouble(tb_current_stock.Text);
                            tb_user.Text = sdr[2].ToString();
                        }
                    }
                    tb_number.Enabled = true;
                    tb_number.Focus();
                }
                catch
                {
                    MessageBox.Show("不存在该商品");
                    tb_code.Text = "";
                    tb_code.Focus();
                }                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private void tb_code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb_code_Leave(null, null);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_code.Text != ""&&tb_number.Text!="")
            {
                string code = tb_code.Text;
                if (tb_current_stock.Text != "" || tb_number.Text != "")
                {
                    number = Convert.ToDouble(tb_current_stock.Text);
                    number -= numbersub;
                }
                string sql = "update table_Stock set Number=@number where PId=@code;";
                string db = "sql_login";
                SqlParameter[] sp =
                {
                new SqlParameter("@code",code),
                new SqlParameter("@number",number)
            };
                if (SqlHelper.SqlExecuteNonQuery(sql, db, sp) > 0)
                {
                    MessageBox.Show("出库成功");
                    SqlParameter[] sp1 = {new SqlParameter("@UId",SqlHelper.uid),
                                        new SqlParameter("code",code),
                                        new SqlParameter("@Operation","出库"),
                                        new SqlParameter("@Pnumber",numbersub),
                                          new SqlParameter("@Time",DateTime.Now)};
                    sql = "insert into table_StockLog(UId,PId, Operation,PNumber, Time) values(@UId,@code,@Operation,@Pnumber,@Time);";
                    SqlHelper.SqlExecuteNonQuery(sql, db, sp1);
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    tb_code.Text = "";
                    tb_name.Text = "";
                    tb_current_stock.Text = "";
                    tb_number.Text = "";
                    tb_user.Text = "";
                    tb_code.Focus();
                }
            }
            else
            {
                MessageBox.Show("请输入有效数据");
            }
        }
        private void tb_number_Leave(object sender, EventArgs e)
        {
            if (tb_number.Text == "") { numbersub = 0.0; }
            else if (!method.ConverToDouble(tb_number.Text, out numbersub)) { MessageBox.Show("输入数据不合法！"); tb_number.Text = ""; tb_number.Focus(); }
            else
            {
                if (numbersub>number)
                {
                    MessageBox.Show("超过现有库存,请输入合法数据");
                    tb_number.Focus();
                    tb_number.Text = "";
                }
            }
        }
        private void tb_number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(!method.ConverToDouble(tb_number.Text,out numbersub)) { MessageBox.Show("输入数据不合法！");tb_number.Text = "";tb_number.Focus(); }
                else
                {
                    if(numbersub>number)
                    {
                    MessageBox.Show("超过现有库存,请输入合法数据");
                    tb_number.Focus();
                    tb_number.Text = "";
                    }
                    else
                    {
                    button1.Focus();
                    button1_Click(null, null);
                    }
                }                              
            }
        }
    }
}
