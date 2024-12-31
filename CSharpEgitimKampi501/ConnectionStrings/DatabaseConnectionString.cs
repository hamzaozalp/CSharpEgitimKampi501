using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.ConnectionStrings
{
    public class DatabaseConnectionString
    {
        public static void SQlDatabaseConnectionString()
        {
            SqlConnection connection = new SqlConnection("Server=HAMZA;initial Catalog=EgitimKampi501Db;integrated security=true");
        }
        
    }
}
