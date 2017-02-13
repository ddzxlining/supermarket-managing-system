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
    public partial class frm_SaleSerial : Form
    {
        public frm_SaleSerial()
        {
            InitializeComponent();
        }
        private void frm_SaleSerial_Load(object sender, EventArgs e)
        {
            string sql = "select serial.SerialNumber,serial.Sum,serial.Isvip,serial.discount,serial.Pay,serial.Time,u.UName,v.VName from table_SerialLog serial left join table_Vip v on serial.VIp=v.VID left join table_User u on serial.Employer=u.UId order by SerialNumber desc";
            SqlParameter[] sp = { };
            dataGridView1.DataSource = SqlHelper.LoadData(sql, "sql_login", sp).Tables[0];
        }
    }
}
