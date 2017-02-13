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
    public delegate void DelSetValue(double discount,string vip);
    public partial class vip : Form
    {
        DelSetValue del;
        double discount = 1,score=0;
        string Vip = "";
        public vip(DelSetValue del)
        {
            InitializeComponent();
            this.del = del;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (score > 2000) discount = 0.9;
            else if (score > 1500) discount = 0.92;
            else if (score > 1000) discount = 0.94;
            else if (score > 500) discount = 0.96;
            else discount = 0.98;
            del(discount,Vip);
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void tb_vip_code_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                try
                {
                    SqlParameter[] sp = { new SqlParameter("@code", tb_vip_code.Text) };
                    string sql = "select VName,VScore from table_Vip where VId=@code";              
                    DataTable dt=SqlHelper.LoadData(sql, "sql_login", sp).Tables[0];
                    lb_vip_name.Text = dt.Rows[0][0].ToString();
                    lb_vip_discount.Text = dt.Rows[0][1].ToString();
                    double.TryParse(lb_vip_discount.Text, out score);
                    SendKeys.Send("{TAB}");
                    Vip = tb_vip_code.Text;
                }
                catch { MessageBox.Show("不存在该会员号！", "系统提示");tb_vip_code.Text = ""; tb_vip_code.Focus(); }                
            }
           
        }
    }
}
