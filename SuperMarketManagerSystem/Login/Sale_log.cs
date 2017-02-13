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
    public partial class Sale_log : Form
    {
        public Sale_log()
        {
            InitializeComponent();
        }
        private void Sale_log_Load(object sender, EventArgs e)
        {
            string sql = "select sl.PId,p.PName,sl.number,sl.PSum,u.UName,sl.PTime from table_SaleLog sl,table_User u,table_Production p where u.UId=sl.UId and p.PId=sl.PId order by PTime desc;";
            string db = "sql_login";
            dataGridView1.DataSource = SqlHelper.LoadData(sql, db).Tables[0];
        }
    }
}
