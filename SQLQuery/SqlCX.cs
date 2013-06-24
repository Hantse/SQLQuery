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
        // MySql Object
        private static MySqlConnection Cx = null;
        // Library Object
        private static SqlCX SqlCxInstance = null; 
        // String Connection
        private string CxString;

        // Private constructor
        private SqlCX()
        {
            Cx = new MySqlConnection(CxString);
        }

        // Public getter instance (singleton)
        public SqlCX getInstance(string _CxString = null)
        {
            if (SqlCxInstance == null)
            {
                if (_CxString == null)
                    throw new Exception(MySqlErrorCode.DatabaseAccessDenied.ToString());
                else
                    SqlCxInstance = new SqlCX();
            }
            return SqlCxInstance;
        }

        // Public connection string setter
        public void setCxString(string _CxString)
        {
            CxString = _CxString;
        }

    }
}
