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
    /// <summary>
    /// 登录窗体，连续三次登录失败，系统自动退出。
    /// </summary>
    public partial class frm_Login : Form
    {
        int count=3;
        public frm_Login()
        {
            InitializeComponent();
        }
        private void button1_MouseEnter(object sender, EventArgs e)//鼠标悬浮眼睛图标自动显示密码; 
        {
            tb_Pwd.UseSystemPasswordChar = false;
        }
        private void button1_MouseLeave(object sender, EventArgs e) //鼠标移开隐藏密码；
        {
            tb_Pwd.UseSystemPasswordChar = true;
        }         
        private void bt_Login_Click(object sender, EventArgs e)   //登陆按钮点击事件；
        {
            if (Login(tb_Uid.Text, tb_Pwd.Text) > 0)
                {
                    timer1.Interval = 500;
                    timer1.Start();
                    MessageBox.Show(string.Format("登录成功！尊敬的{0}{1},欢迎你!", SqlHelper.uname,SqlHelper.uposition));
                    SqlHelper.uid = tb_Uid.Text;
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                tb_Uid.Text = "";
                tb_Pwd.Text = "";
                }
            else
            {
                MessageBox.Show("登录失败!请重试");
                initbox();
                if (--count == 0)
                {
                    timer1.Interval = 3000;
                    timer1.Start();
                    MessageBox.Show("对不起，您不能继续登录，系统3秒后自动关闭！");
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
            }
        }
        private static int Login(string uid, string pwd)  //调用登陆函数，实现登陆；
        {
            string db = "sql_login";
            string sql = "select count(*) over(),UName,UPosition from table_User where UId=@uid and UPwd=@pwd;";
            SqlParameter[] sp = { new SqlParameter("@uid", uid), new SqlParameter("@pwd", pwd)};
            return (int)SqlHelper.Login(sql, sp, db);
        }
        private void bt_Cancel_Click(object sender, EventArgs e)//取消方法；
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }    
        public  void initbox()//密码框清空方法；
        {
            tb_Pwd.Text = "";
        }    
        private void timer1_Tick(object sender, EventArgs e)//等待一定实现发送“enter”按钮信息，实现自动按回车；
        {
            SendKeys.Send("{ENTER}");
            timer1.Stop();
        }     
    }
}
