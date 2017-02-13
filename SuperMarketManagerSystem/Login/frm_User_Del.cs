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
    public partial class frm_User_Del : Form
    {
        public frm_User_Del(params string[] code)
        {
            InitializeComponent();
            if (code.Count<string>() > 0)
            {
                tb_code.Text = code[0];
                tb_code.Focus();
                SendKeys.Send("{Enter}");
            }
        }
        private void frm_User_Del_Load(object sender, EventArgs e)
        {
            tb_name.Enabled = false;
            rb_sex_man.Enabled = false;
            rb_sex_woman.Enabled = false;
            tb_salary.Enabled = false;
            tb_birthday.Enabled = false;
            tb_position.Enabled = false;
            tb_salary.Enabled = false;
            tb_pwd.Enabled = false;
            tb_tel.Enabled = false;
            tb_address.Enabled = false;
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
                string sql = "select UName, USex, UPosition, USalary, UBirthday, UAddress, UTelephone, UPwd from table_User where UId=@code;";
                string db = "sql_login";
                SqlParameter[] sp =
                {
                    new SqlParameter ("@code",code)
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
                            if (sdr[1].ToString() == "男")
                            {
                                rb_sex_man.Checked = true;
                            }
                            else
                            {
                                rb_sex_woman.Checked = true;
                            }
                            tb_position.Text = sdr[2].ToString();
                            tb_salary.Text = sdr[3].ToString();
                            tb_birthday.Text = sdr[4].ToString();
                            tb_address.Text = sdr[5].ToString();
                            tb_tel.Text = sdr[6].ToString();
                            tb_pwd.Text = sdr[7].ToString();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("不存在该用户");
                    tb_code.Focus();
                }
            }
        }
        private void tb_code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb_code_Leave(null, null);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }
        private void button1_Click(object sender, EventArgs e)
        {
                string db = "sql_login";
                string code = tb_code.Text;
                string sql = "delete from table_User where UId=@code;";
                SqlParameter[] sp =
                {
                    new SqlParameter("@code",code),
                };
                if (SqlHelper.SqlExecuteNonQuery(sql, db, sp) > 0)
                {
                    MessageBox.Show("删除成功");
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                }
            }
        }
}
