using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public delegate void DelPay(double discount, double pay,string vip);
    public partial class Pay : Form
    {
        DelPay dp;
        string vip="";
        double sum=0,money = 0, discount = 0, pay=0,reback=-1;
        bool isvip = false;
        void SetDiscount(double discount,string vip)
        {
           this. discount = sum * (1 - discount);
            money = sum - this.discount;
           this.vip = vip;
        }
        private void Pay_Shown(object sender, EventArgs e)
        {
            if (isvip)
            {
                this.Hide();
                vip v = new vip(SetDiscount);
               DialogResult dr= v.ShowDialog();
                if ( dr== System.Windows.Forms.DialogResult.Cancel)
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
                else if (dr== DialogResult.Yes)
                {
                this.Show();
                    Pay_Load(null, null);
                }                  
            }
        }
        public Pay(double sum1,bool isvip,DelPay dp1)
        {
            InitializeComponent();
            sum = sum1;
            if (isvip)
            {
                this.isvip = isvip;
            }
            else money = sum;
            dp = dp1;
        }
        private void bt_done_Click(object sender, EventArgs e)
        {
            if (reback >= 0)
            {
                  dp(discount, money,vip);
                  this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            }            
            else
            {
                MessageBox.Show("请先输入付款金额后再点完成！","系统提示");
            }            
        }
        private void Pay_Load(object sender, EventArgs e)
        {
            lb_sum_value.Text = sum.ToString();
            lb_discount_value.Text = discount.ToString();
            lb_shouldpay_value.Text = money.ToString();
            lb_discount_value.Text = discount.ToString();
            tb_pay.Focus();
        }
        private void tb_pay_KeyDown(object sender, KeyEventArgs e)
        {
            if(tb_pay.Text!=""&&e.KeyCode==Keys.Enter)
            {
                if (!double.TryParse(tb_pay.Text, out pay))
                { MessageBox.Show("输入金额不合法，请重新输入！");tb_pay.Text = "";tb_pay.Focus(); }
                else{
                    reback = pay - money;
                    if (reback < 0) { MessageBox.Show("付款不足，请重新支付或取消支付！", "系统提示"); tb_pay.Text = ""; tb_pay.Focus(); }
                    else
                    {
                        lb_return_value.Text = reback.ToString();
                        bt_done.Focus();
                    }
                }          
            }
        }
    }
}
