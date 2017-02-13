using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class SqlHelper
    {
        public static string uid,uname, uposition;   //用来存储登陆用户的用户id，用户名，职位；
        public static int Login(string sql, SqlParameter[] sp, string db)//登陆校验方法；如何登录成功记录登录的用户名和用户职位
        {
            string conStr = ConfigurationManager.ConnectionStrings[db].ConnectionString;
            int statue=0;
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddRange(sp);
                    SqlDataReader reader = cmd.ExecuteReader();
                    try {
                        reader.Read();
                        statue = (int)reader[0];
                        uname = reader[1].ToString();
                        uposition = reader[2].ToString();
                    }
                    catch
                    {
                        statue = 0;
                    }
                }
            }
            return statue;
        }       
        public static DataSet LoadData(string sql, string db, params SqlParameter[] sp)//返回类型为DataSet对象的Sql方法；
        {
            string conStr = ConfigurationManager.ConnectionStrings[db].ConnectionString;
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddRange(sp);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    return ds;
                }
            }
        }
        public static int SqlExecuteNonQuery(string sql, string db, params SqlParameter[] sp)//返回类型为受影响行数的Sql方法；
        {
            string conStr = ConfigurationManager.ConnectionStrings[db].ConnectionString;
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddRange(sp);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public static object SqlExecuteSaclar(string sql,string db,params SqlParameter[] sp)//返回类型为第一行第一列object类型数据的Sql方法；
        {
            string conStr = ConfigurationManager.ConnectionStrings[db].ConnectionString;
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql,conn))
                {
                    conn.Open();
                    cmd.Parameters.AddRange(sp);
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}
