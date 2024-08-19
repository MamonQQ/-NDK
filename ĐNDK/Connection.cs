using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ĐNDK
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Test\ĐNDK\ĐNDK\Database1.mdf;Integrated Security=True";
        public static SqlConnection GetSqlConnecton()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
