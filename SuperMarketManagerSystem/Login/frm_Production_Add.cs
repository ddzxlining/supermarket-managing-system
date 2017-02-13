using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class frm_Production_Add : Form
    {
        string code = "";
        string name = "";
        string place = "";
        string norm = "";
        string unit = "";
        double inprice = 0.0;
        double outprice = 0.0;
        double number = 0.0;
        DateTime dt = new DateTime();
        int conserve = 0;
        public frm_Production_Add()
        { 
           InitializeComponent();
        }
        private void tb_code_Leave(object sender, EventArgs e)
        {
            
        }
        private void tb_name_Leave(object sender, EventArgs e)
        {
            if (!method.RegexMatch(tb_name.Text, @"\w{1,20}", out name)) { MessageBox.Show("数据长度非法！");tb_name.Text = ""; tb_name.Focus(); }
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
            if (!method.ConverToDouble(tb_inprice.Text,out inprice))
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
        private void tb_number_Leave(object sender, EventArgs e)
        {
            if (!method.ConverToDouble(tb_number.Text, out number))
            {
                MessageBox.Show("数据不合法！");
                tb_number.Focus();
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_code.Text == "" || tb_inprice.Text == "" || tb_outprice.Text == "")
            {
                MessageBox.Show("数据不完整！");
            }
            else
            {
                string sql = "insert into table_Production(PId, PName, PPlace, PInprice, POutprice, PNorm, PUnit, PDate, PConserve) values(@code,@name,@place,@inprice,@outprice,@norm,@unit,@date,@conserve);";
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
                    sql = "insert into table_Stock(PId, EnrollTime, Number, UId) values(@code,@enrolltime,@number,@uid);";
                    string enrolltime = DateTime.Now.ToString();
                    string uid = SqlHelper.uid;
                    SqlParameter[] sp1 =
                    {
                        new SqlParameter("@code",code),
                        new SqlParameter("@enrolltime",enrolltime),
                        new SqlParameter("@number",number),
                        new SqlParameter("@uid",uid)
                    };
                    if (SqlHelper.SqlExecuteNonQuery(sql, "sql_login", sp1) > 0)
                        MessageBox.Show("插入成功！");
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    dataclear();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private void dataclear()
        {
            tb_code.Text = "";
            tb_name.Text = "";
            tb_place.Text="";
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
