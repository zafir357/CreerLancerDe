using Dapper;
using System;
using System.Collections;
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
        private static int isRowAffected;
        /*        public static void DBConnect()
                {
                    *//*string connectionString;
                    SqlConnection conn;*//*
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
                }*/
        #region Query classic .NET avec SQL adapter
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlString"></param>
        /// <param name="dt"></param>
        public static void ExecuteCommand(string sqlString, out DataTable dt)
            {
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlString, connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    dt = new DataTable();
                    da.Fill(dt);
                }
            }
        }
        
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlString"></param>
        /// <param name="connectionString"></param>
        /// <param name="parameters"></param>
        private static void ExecuteCommand(string sqlString,
        string connectionString, Dictionary<string, string> parameters)
        {
            using (SqlConnection connection = new SqlConnection(
                   connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlString, connection))
                {
                    foreach (KeyValuePair<string, string> entry in parameters)
                    {
                        command.Parameters.AddWithValue(entry.Key, entry.Value);
                    }
                    command.Connection.Open();
                    isRowAffected = command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Query avec ORM dapper

        /// <summary>
        ///Lire une list d'objet directement de la base 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        public static List<T> ListReader<T>(string sqlString)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<T>(sqlString).ToList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sqlString"></param>
        /// <param name="ls"></param>
        public static void ListSave<T>(string sqlString, List<DynamicParameters> ls)
        {
            using (var db = new SqlConnection(connectionString))

            {
                ls.ForEach(delegate (DynamicParameters item) {
                    int rowsAffected = db.Execute(sqlString,
                        new[]
                {item }
                 ); });
            };
        }

        public static void InsertData<T>(string sqlString, DynamicParameters parameters)
        {


            using (var connection = new SqlConnection(connectionString))
            {
                object result = connection.Execute(sqlString, parameters);
            }
        }
        #endregion


    }

}

