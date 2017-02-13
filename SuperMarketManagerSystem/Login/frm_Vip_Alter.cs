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
    public partial class frm_Vip_Alter : Form
    {
        public frm_Vip_Alter(params string[] code)
        {
            
            InitializeComponent();
            if (code.Count<string>()>0)
            {
                tb_code.Text = code[0];
                tb_code.Focus();
                SendKeys.Send("{Enter}");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            cleardata();
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private void tb_code_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                tb_code_Leave(null, null);
            }
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
            string sql = "select VName, VSex, VBirthday, VTelephone,VScore,VAddress from table_Vip where VId=@code";
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
                        tb_name.Text = sdr[0].ToString();
                        if(sdr[1].ToString()=="男")
                        {
                            rb_sex_man.Checked = true;
                        }
                        else
                        {
                            rb_sex_woman.Checked = true;
                        }
                        tb_birthday.Text = sdr[2].ToString();
                        tb_tel.Text = sdr[3].ToString();
                        tb_score.Text = sdr[4].ToString();
                        tb_address.Text = (string)sdr[5];
                    }
                }
            }
            catch
            {
                MessageBox.Show("输入有误！");
            }
            tb_tel.Enabled = true;
            tb_score.Enabled = true;
            tb_address.Enabled = true;
        }
        private void frm_Vip_Alter_Load(object sender, EventArgs e)
        {
            tb_name.Enabled = false;
            rb_sex_man.Enabled = false;
            rb_sex_woman.Enabled = false;
            tb_birthday.Enabled = false;
            tb_tel.Enabled = false;
            tb_score.Enabled = false;
            tb_address.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(tb_code.Text=="")
            {
                MessageBox.Show("不能为空");
            }
            else
            {
                string code = tb_code.Text;
                string tel = tb_tel.Text;
                double score = Convert.ToDouble(tb_score.Text);
                string address = tb_address.Text;
                string sql = "update table_Vip set VTelephone=@tel,VScore=@score,VAddress=@address where VId=@code;";
                string db = "sql_login";
                SqlParameter[] sp =
                {
                    new SqlParameter("@code",code),
                    new SqlParameter("@tel",tel),
                    new SqlParameter("@score",score),
                    new SqlParameter("@address",address)
                };
                if(SqlHelper.SqlExecuteNonQuery(sql,db,sp)>0)
                {
                    cleardata();
                    MessageBox.Show("修改成功");
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                }
            }
        }
        private void cleardata()
        {
            tb_code.ResetText();
            tb_name.ResetText();
            tb_address.ResetText();
            tb_birthday.ResetText();
            tb_score.ResetText();
            tb_tel.ResetText();
            rb_sex_man.Checked = false;
            rb_sex_woman.Checked = false;
        }
    }
}
