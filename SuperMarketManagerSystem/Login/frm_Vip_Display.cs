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
    public partial class frm_Vip_Display : Form
    {
        public frm_Vip_Display()
        {
            InitializeComponent();
        }
        private void frm_VIP_Display_Load(object sender, EventArgs e)
        {
            string sql = "select VId, VName, VSex, VBirthday, VTelephone, VAddress,VScore,VEnrollDate from table_Vip";
            SqlParameter[] sp = { };
            dataGridView1.DataSource = SqlHelper.LoadData(sql, "sql_login", sp).Tables[0];
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Vip_Alter fva1 = null;
            if (dataGridView1.RowCount > 0)
            {
                string str1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                fva1 = new frm_Vip_Alter (str1);
            }
            else
                fva1 = new frm_Vip_Alter();
            if(fva1.ShowDialog()==  System.Windows.Forms.DialogResult.Yes)
            {
                frm_VIP_Display_Load(null, null);
            }
        }
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Vip_Del fvd1=null;
            if (dataGridView1.RowCount>0)
            { 
            string str = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
             fvd1= new frm_Vip_Del(str);
            }
            else
                fvd1 = new frm_Vip_Del();
            if(fvd1.ShowDialog()==System.Windows.Forms.DialogResult.Yes)
            {
                frm_VIP_Display_Load(null, null);
            }
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Vip_Add fva1 = new frm_Vip_Add();
            if (fva1.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                frm_VIP_Display_Load(null, null);
            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                dataGridView1.Rows[e.RowIndex].Selected = true;
        }
    }
}
