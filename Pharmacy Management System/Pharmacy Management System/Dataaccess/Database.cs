using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Dataaccess.Entities;
using Dataaccess.Operation;

namespace Dataaccess
{
    public class Database
    {
        public static Database db;

        public Admin_Users Admin_Users { get; set; }
         /*string ConnStr = @"Server = DESKTOP-1JT0TF2\SQLEXPRESS; Database = Pharmacy Management; Integrated Security = True ";
         SqlConnection conn = new SqlConnection(connStr);
         Admin_User = new Admin_User(conn);*/
        public Database()
        {
            Admin_Users = new Admin_Users();
        }
    }
}
