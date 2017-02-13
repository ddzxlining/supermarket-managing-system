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
    public partial class frm_Production_Del : Form
    {
        public frm_Production_Del(params string[] code)
        {
            InitializeComponent();
            if(code.Count<string>()>0)
            {
                tb_code.Text = code[0];
                tb_code.Focus();
                SendKeys.Send("{Enter}");
            }
        }
        private void frm_Production_Del_Load(object sender, EventArgs e)
        {
            Isable(false);
        }
        private void Isable(bool value)
        {
            tb_name.Enabled = value;
            tb_place.Enabled = value;
            tb_inprice.Enabled = value;
            tb_outprice.Enabled = value;
            tb_norm.Enabled = value;
            tb_unit.Enabled = value;
            tb_date.Enabled = value;
            tb_conserve.Enabled = value;
            tb_number.Enabled = value;
        }
        private void tb_code_Leave(object sender, EventArgs e)
        {
            string code = tb_code.Text;
            if (tb_code.Text == "")
            {
                MessageBox.Show("不能为空");
            }
            string conStr = ConfigurationManager.ConnectionStrings["sql_login"].ConnectionString;
            SqlParameter[] sp = { new SqlParameter("@code", code) };
            string sql = "select p.PName, p.PPlace, p.PInprice, p.POutprice, p.PNorm, p.PUnit, p.PDate, p.PConserve, s.Number from table_Production p,table_Stock s where p.PId=@code and s.PId=p.PId";
            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddRange(sp);
                        SqlDataReader sdr = cmd.ExecuteReader();
                        sdr.Read();
                        tb_name.Text = (string)sdr[0];
                        tb_place.Text = (string)sdr[1];
                        tb_inprice.Text = sdr[2].ToString();
                        tb_outprice.Text = sdr[3].ToString();
                        tb_norm.Text = (string)sdr[4];
                        tb_unit.Text = (string)sdr[5];
                        tb_date.Text = sdr[6].ToString();
                        tb_conserve.Text = sdr[7].ToString();
                        tb_number.Text = sdr[8].ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("输入有误！");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_code.Text == "" ||tb_inprice.Text == "" || tb_outprice.Text == "")
            {
                MessageBox.Show("不存在！");
            }
            else
            {
                string sql = "delete from table_Stock where PId=@code;";
                string no = tb_code.Text;
                SqlParameter[] sp ={new SqlParameter("@code",no)};
                if (SqlHelper.SqlExecuteNonQuery(sql, "sql_login", sp) > 0)
                {
                    SqlParameter[] sp1 = { new SqlParameter("@code", no) };
                    sql = "delete from table_Production where  PId=@code;";
                    if (SqlHelper.SqlExecuteNonQuery(sql, "sql_login", sp1) > 0)
                    {
                        MessageBox.Show("删除成功！");
                        this.DialogResult=System.Windows.Forms.DialogResult.Yes;
                        tb_code.Text = "";
                        tb_name.Text = "";
                        tb_place.Text = "";
                        tb_inprice.Text = "";
                        tb_outprice.Text = "";
                        tb_date.Text = "";
                        tb_conserve.Text = "";
                        tb_number.Text = "";
                        tb_norm.Text = "";
                        tb_unit.Text = "";
                    }
                }
            }
        }

        private void tb_code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tb_code_Leave(null, null);
        }
    }
}
