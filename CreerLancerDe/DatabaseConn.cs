using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CréerLancerUnDé.Log.Logger;
namespace CreerLancerDe
{
   public class DatabaseConn
    {
      private static ConnectionStringSettings connectionStringSet = ConfigurationManager.ConnectionStrings["DBConnection"];
       private static string connectionString = connectionStringSet.ConnectionString;
        public static void DBConnect()
        {
            /*string connectionString;
            SqlConnection conn;*/
            //    SqlConnection connectionString1= "Data Source=.\localhost\SQLEXPRESS; Initial Catalog=Northwind;User id = sa;password=pass@123";



            //  connectionString = @"Data Source=localhost\SQLEXPRESS;initial catalog=DBDe;integrated security=True;trusted_connection=true;";

            try
            {
                ExecuteCommand("SELECT * FROM dbo.de", connectionString);
            }
            catch (Exception ex)
            {
                LogThisLine(ex.ToString());
            }

            MessageBox.Show("Connection Open");
        }

        private static void ExecuteCommand(string sqlString,
            string connectionString)
            {
                using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlString, connection))
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
