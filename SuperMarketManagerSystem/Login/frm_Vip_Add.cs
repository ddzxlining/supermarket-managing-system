using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frm_Vip_Add : Form
    {
        public frm_Vip_Add()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(tb_code.Text==""||tb_name.Text==""||tb_tel.Text==""||tb_score.Text=="")
            {
                MessageBox.Show("信息不完整！");
            }
            string sql = "insert into table_Vip(VId, VName, VSex, VBirthday, VTelephone, VAddress, VEnrollDate, VScore) values(@code,@name,@sex,@birthday,@tel,@address,@enrolldate,@score);";
            string code = tb_code.Text;
            string name = tb_name.Text;
            string sex="";
            if(rb_sex_man.Checked==true)
            {
                sex = "男";
            }
            else if(rb_sex_woman.Checked==true)
            {
                sex = "女";
            }
            string birthday = tb_birthday.Text;
            string tel = tb_tel.Text;
            double score = Convert.ToDouble(tb_score.Text);
            string address = tb_address.Text;
            string enrolldate = DateTime.Now.ToString();
            SqlParameter[] sp = {
                new SqlParameter("@code",code),
                new SqlParameter("@name",name),
                new SqlParameter("@sex",sex),
                new SqlParameter("@birthday",birthday),
                new SqlParameter("@tel", tel),
                new SqlParameter("@address",address),
                new SqlParameter("@score",score),
                new SqlParameter("@enrolldate",enrolldate)
            };
            if(SqlHelper.SqlExecuteNonQuery(sql, "sql_login", sp)>0)
            {
                cleardata();
                MessageBox.Show("添加成功");
                DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("添加失败");
                DialogResult= System.Windows.Forms.DialogResult.No;
            }
        }
        private void data_clear()
        {
            tb_code.Text = "";
            tb_name.Text = "";
            rb_sex_man.Checked = false;
            rb_sex_woman.Checked = false;
            tb_birthday.Text = "";
            tb_tel.Text = "";
            tb_address.Text = "";
            tb_score.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            cleardata();
            this.Close();
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
