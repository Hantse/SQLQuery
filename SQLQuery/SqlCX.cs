// Basic using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// MySql using
using MySql.Data.MySqlClient;

namespace SQLQuery
{
    public class SqlCX
    {
        private MySqlConnection Cx = null;
        private SqlCX SqlCxInstance = null; 
        private string CxString;

        private SqlCX()
        {
        }

        public SqlCX getInstance(string _CxString = null)
        {
            if (SqlCxInstance == null)
            {
                if (_CxString == null)
                    throw new Exception(MySqlErrorCode.DatabaseAccessDenied.ToString());
                else
                    this.SqlCxInstance = new SqlCX();
            }
            return this.SqlCxInstance;
        }

        public void setCxString(string _CxString)
        {
            CxString = _CxString;
        }

    }
}
