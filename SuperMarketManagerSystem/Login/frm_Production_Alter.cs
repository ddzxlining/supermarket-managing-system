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
    
    public partial class frm_Production_Alter : Form
    {
        string code = "";
        string name = "";
        string place = "";
        string norm = "";
        string unit = "";
        double inprice = 0.0;
        double outprice = 0.0;
        DateTime dt = new DateTime();
        int conserve = 0;
        public frm_Production_Alter(params string[] code)
        {
            InitializeComponent();
            if(code.Count<string>()>0)
            {
                tb_code.Text = code[0];
                tb_code.Focus();
                SendKeys.Send("{Enter}");
            }
        }
        private void frm_Production_Alter_Load(object sender, EventArgs e)
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
            tb_number.Enabled = false;
        }
        private void tb_code_Leave(object sender, EventArgs e)
        {
            code = tb_code.Text;
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
                Isable(true);
                name = tb_name.Text;
                place = tb_place.Text;
                inprice = double.Parse(tb_inprice.Text);
                outprice = double.Parse(tb_outprice.Text);
                norm = tb_norm.Text;
                unit = tb_unit.Text;
                dt = DateTime.Parse(tb_date.Text);
                conserve = int.Parse(tb_conserve.Text);
            }
            catch 
            {
                MessageBox.Show("输入有误！");
                dataclear();
            }
        }
        private void tb_name_Leave(object sender, EventArgs e)
        {
            if (!method.RegexMatch(tb_name.Text, @"\w{1,20}", out name)) { MessageBox.Show("数据长度非法！"); tb_name.Text = ""; tb_name.Focus(); }
        }
        private void tb_place_Leave(object sender, EventArgs e)
        {
            if (!method.RegexMatch(tb_place.Text, @"\w{1,20}", out place)) { MessageBox.Show("数据长度非法！"); tb_place.Text = ""; tb_place.Focus(); }
        }
        private void tb_norm_Leave(object sender, EventArgs e)
        {
            if (!method.RegexMatch(tb_norm.Text, @"\w{1,8}", out norm)) { MessageBox.Show("数据长度非法！"); tb_norm.Text = ""; tb_norm.Focus(); }
        }
        private void tb_unit_Leave(object sender, EventArgs e)
        {
            if (!method.RegexMatch(tb_unit.Text, @"\w{1,3}", out unit)) { MessageBox.Show("数据长度非法！"); tb_unit.Text = ""; tb_unit.Focus(); }
        }
        private void tb_inprice_Leave(object sender, EventArgs e)
        {
            if (!method.ConverToDouble(tb_inprice.Text, out inprice))
            {
                MessageBox.Show("数据不合法");
                tb_inprice.Text = "";
                tb_inprice.Focus();
            }
        }
        private void tb_outprice_Leave(object sender, EventArgs e)
        {
            if (!method.ConverToDouble(tb_outprice.Text, out outprice))
            {
                MessageBox.Show("数据不合法");
                tb_outprice.Text = "";
                tb_outprice.Focus();
            }
        }
        private void tb_prodate_Leave(object sender, EventArgs e)
        {
            if (!method.ConverToDateTime(tb_date.Text, out dt))
            {
                MessageBox.Show("数据不合法");
                tb_date.Text = "";
                tb_date.Focus();
            }
        }
        private void tb_conserve_Leave(object sender, EventArgs e)
        {
            if (!method.ConverToInt(tb_conserve.Text, out conserve))
            {
                MessageBox.Show("数据不合法！");
                tb_conserve.Text = "";
                tb_conserve.Focus();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_code.Text == "" || tb_number.Text == "" || tb_inprice.Text == "" || tb_outprice.Text == "")
            {
                MessageBox.Show("数据不完整！");
            }
            else
            {
                string sql = "update table_Production set PId=@code,PName=@name,PPlace=@place, PInprice=@inprice, POutprice=@outprice, PNorm=@norm, PUnit=@unit, PDate=@date, PConserve=@conserve where PId=@code;";
                SqlParameter[] sp =
                {
                new SqlParameter("@code",code),
                new SqlParameter("@name",name),
                new SqlParameter("@place",place),
                new SqlParameter("@norm",norm),
                new SqlParameter("@unit",unit),
                new SqlParameter("@inprice",inprice),
                new SqlParameter("@outprice",outprice),
                new SqlParameter("@date",dt),
                new SqlParameter("@conserve",conserve)
            };
                if (SqlHelper.SqlExecuteNonQuery(sql, "sql_login", sp) > 0)
                {
                    MessageBox.Show("修改成功！");
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    dataclear();
                }
            }
        }
        private void tb_code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tb_code_Leave(null, null);
        }
        private void dataclear()
        {
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
