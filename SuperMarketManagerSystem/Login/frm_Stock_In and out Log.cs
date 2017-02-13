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
    public partial class frm_Stock_In_and_out_Log : Form
    {
        string OperationType = "";
        public frm_Stock_In_and_out_Log(string OperationType1)
        {
            InitializeComponent();
            if(OperationType1!=null)
                OperationType = OperationType1;
        }
        private void frm_Stock_In_and_out_Log_Load(object sender, EventArgs e)
        {
            SqlParameter[] sp = { new SqlParameter("@OperationType", OperationType) };
            string sql = "select sl.PId,p.PName,sl.Operation,sl.Pnumber, u.Uname,sl.Time from table_User u,table_Production p,table_StockLog sl where u.UId=sl.UId and p.PId=sl.PId and sl.Operation=@Operationtype and sl.Operation=@OperationType;";
            dataGridView1.DataSource = SqlHelper.LoadData(sql, "sql_login",sp).Tables[0];
        }
    }
}
