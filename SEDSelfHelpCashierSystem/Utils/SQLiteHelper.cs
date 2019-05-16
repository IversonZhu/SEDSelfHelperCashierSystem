using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SEDSelfHelpCashierSystem.Utils
{
    public class SQLiteHelper
    {
        //数据库连接链接
        private string connStr = @"Data Source=.;Initial Catalog=stu_sup_market_sys;User Id=sa;Pwd=zhy19930816";
        private SqlConnection conn;

        public SqlConnection Conn
        {
            get
            {
                if (conn == null)
                {
                    conn = new SqlConnection(connStr);
                }
                return conn;
            }
        }

      

        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public void OpenConnection()
        {
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
            else if (Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
                Conn.Open();
            }
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void CloseConnection()
        {
            if (Conn.State == ConnectionState.Open || Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
            }
        }

    }
}
