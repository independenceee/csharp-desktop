using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_LON.src.Databases
{
    internal class Databases
    {
        private static string SQL_SERVER_DATABASE_URL = @"Data Source=EL\DOANKOREA;Initial Catalog=AccountWinForm;Integrated Security=True";
        SqlConnection connect;


        public SqlConnection Connect() {
            
            return connect;    
        }
    }
}
