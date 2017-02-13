using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Login
{
    /// <summary>
    /// 应用程序主窗体。包含各个子系统的各项功能列表。用户可以根据需要选择对应的子系统进入。
    /// </summary>
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 系统菜单。包含登录、注销、退出三个子菜单。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Login f1 = new frm_Login();
            if(f1.ShowDialog()==System.Windows.Forms.DialogResult.Yes)
            {
                销售系统ToolStripMenuItem.Enabled = true;
                库存管理ToolStripMenuItem.Enabled = true;
                会员管理ToolStripMenuItem.Enabled = true;
                员工管理ToolStripMenuItem.Enabled = true;
                商品管理ToolStripMenuItem.Enabled = true;
                记录查询ToolStripMenuItem.Enabled = true;
            }
        }
        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            销售系统ToolStripMenuItem.Enabled = false;
            库存管理ToolStripMenuItem.Enabled = false;
            会员管理ToolStripMenuItem.Enabled = false;
            员工管理ToolStripMenuItem.Enabled = false;
            商品管理ToolStripMenuItem.Enabled = false;
            记录查询ToolStripMenuItem.Enabled = false;
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_Main_Shown(object sender, EventArgs e)//根据登录窗体返回的结果，确定主窗体的下一步状态。
        {
            this.Hide();
            frm_Login f = new frm_Login();
            DialogResult result = f.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Show();
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                f.initbox();
            }
            else if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                this.Close();
            }
        }

        /// <summary>
        /// 销售子系统。有销售窗体组成；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 销售系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Sale frm_Sale1 = new frm_Sale();
            frm_Sale1.Show();
        }
        
        /// <summary>
        /// 商品管理子系统。包含新增商品、修改商品、删除商品、查看商品列表；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 新增商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Production_Add fpa = new frm_Production_Add();
            DialogResult result=fpa.ShowDialog();
        }     
        private void 修改商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Production_Alter fpa1 = new frm_Production_Alter();
            fpa1.ShowDialog();
        }
        private void 删除商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Production_Del fpd1 = new frm_Production_Del();
            fpd1.ShowDialog();
        }
        private void 查看商品列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Production_Display fpd = new frm_Production_Display();
            fpd.ShowDialog();
        }

        /// <summary>
        /// 会员管理子系统。包含新增会员、修改会员、删除会员、查看会员列表；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>       
        private void 新增会员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Vip_Add fva1 = new frm_Vip_Add();
            fva1.ShowDialog();
        }
        private void 修改会员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Vip_Alter fva1 = new frm_Vip_Alter("0");
            fva1.ShowDialog();
        }
        private void 删除会员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Vip_Del fvd1 = new frm_Vip_Del();
            fvd1.ShowDialog();
        }
        private void 查看会员列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Vip_Display fvds1 = new frm_Vip_Display();
            fvds1.ShowDialog();
        }

        /// <summary>
        /// 员工管理子系统。包含新增员工、修改员工、删除员工、查看员工列表；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 新增员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_User_Add fua1 = new frm_User_Add();
            fua1.ShowDialog();
        }
        private void 修改员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_User_Alter fua1 = new frm_User_Alter();
            fua1.ShowDialog();
        }
        private void 删除员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_User_Del fud1 = new frm_User_Del();
            fud1.ShowDialog();
        }
        private void 查看员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_User_Display fudp1 = new frm_User_Display();
            fudp1.ShowDialog();
        }

        /// <summary>
        /// 库存管理子系统。包含入库、出库、查看库存列表；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Stock_Add fsa1 = new frm_Stock_Add();
            fsa1.ShowDialog();
        }
        private void 查看库存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Stock_Display fsd1 = new frm_Stock_Display();
            fsd1.ShowDialog();
        }
        private void 出库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Stock_Alter fsa1 = new frm_Stock_Alter();
            fsa1.ShowDialog();
        }

        /// <summary>
        /// 记录子系统。包含销售记录、入库记录、出库记录；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 销售记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale_log sl = new Sale_log();
            sl.ShowDialog();
        }
        private void 入库记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Stock_In_and_out_Log fsil = new frm_Stock_In_and_out_Log("入库");
            fsil.ShowDialog();
        }
        private void 出库记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Stock_In_and_out_Log fsil = new frm_Stock_In_and_out_Log("出库");
            fsil.ShowDialog();
        }
        private void 结算记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SaleSerial fss = new frm_SaleSerial();
            fss.ShowDialog();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            method.loadfile();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
             method.savefile();
        }
    }
}
