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
    public partial class frm_Stock_Display : Form
    {
        public frm_Stock_Display()
        {
            InitializeComponent();
        }

        private void frm_Stock_Display_Load(object sender, EventArgs e)
        {
            string sql = "select p.PId,p.PName,p.POutprice,s.Number,u.UName,s.EnrollTime  from table_Production p,table_Stock s,table_User u where s.PId=p.PId and u.UId=s.UId";
            SqlParameter[] sp = { };
            dataGridView1.DataSource = SqlHelper.LoadData(sql, "sql_login", sp).Tables[0];
        }
        private void 出库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Stock_Alter fva1 = null;
            if (dataGridView1.RowCount > 0)
            {
                string str1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                fva1 = new frm_Stock_Alter(str1);
            }
            else
                fva1 = new frm_Stock_Alter();
            if (fva1.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                frm_Stock_Display_Load(null, null);
            }
        }
        private void 入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Stock_Add fva1 = null;
            if (dataGridView1.RowCount > 0)
            {
                string str1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                fva1 = new frm_Stock_Add(str1);
            }
            else
                fva1 = new frm_Stock_Add();
            if (fva1.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                frm_Stock_Display_Load(null, null);
            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                dataGridView1.Rows[e.RowIndex].Selected = true;
        }
    }
}
