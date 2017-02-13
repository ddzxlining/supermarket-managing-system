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
    public partial class frm_User_Add : Form
    {
        public frm_User_Add()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into table_User(UId, UName, USex, UPosition, USalary, UEnrollDate, UBirthday, UAddress, UTelephone, UPwd) values(@code,@name,@sex,@position,@salary,@enrolldate,@birthday,@address,@tel,@pwd)";
            string db = "sql_login";
            string code = tb_code.Text;
            string name = tb_name.Text;
            string sex = "";
            if(rb_sex_man.Checked==true)
            {
                sex = "男";
            }
            else
            {
                sex = "女";
            }
            string position = tb_position.Text;
            double salary = Convert.ToDouble(tb_salary.Text);
            string enrolldate = DateTime.Now.ToString();
            string birthday = tb_birthday.Text;
            string address = tb_address.Text;
            string tel = tb_tel.Text;
            string pwd = tb_pwd.Text;
            SqlParameter[] sp =
            {
                new SqlParameter("@code",code),
                new SqlParameter("@name",name),
                new SqlParameter("@sex",sex),
                new SqlParameter("@position",position),
                new SqlParameter("@salary",salary),
                new SqlParameter("@enrolldate",enrolldate),
                new SqlParameter("@birthday",birthday),
                new SqlParameter("@address",address),
                new SqlParameter("@tel",tel),
                new SqlParameter("@pwd",pwd)
            };
            if(SqlHelper.SqlExecuteNonQuery(sql,db,sp)>0)
            {
                MessageBox.Show("添加成功");
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                dataclear();
            }
        }
        private void dataclear()
        {
            tb_code.Text = "";
            tb_address.Text = "";
            tb_birthday.Text = "";
            tb_name.Text = "";
            tb_position.Text = "";
            tb_pwd.Text = "";
            tb_tel.Text = "";
            tb_salary.Text = "";
            rb_sex_man.Checked = false;
            rb_sex_woman.Checked = false;      
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
