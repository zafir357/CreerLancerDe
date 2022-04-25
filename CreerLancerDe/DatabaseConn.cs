using CreerLancerDe.Classes;
using CreerLancerDe.Model;
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

        #region Query classic .NET avec SQL adapter
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlString"></param>
        /// <param name="dt"></param>
        public static DataTable ExecuteCommand(string sqlString,  DataTable dt)
         {
            try
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
            catch(Exception ex)
            {
                LogThisLine(ex.ToString());
            }
            return dt;
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
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    return connection.Query<T>(sqlString).ToList();
                }
            }
            catch (Exception ex)
            {
                List<T> z = null;
                LogThisLine(ex.ToString());
                MessageBox.Show("Problem technique, veuillez réessayer plus tard");
                return z;
            }

        }



        public static dynamic DeContenuDe()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var sql = "SELECT de.[id] ,de.[nom_de] ,de.[faces], conde.[contenu_de],td.Type, conde.[contenu_de] FROM [dbo].[de] "
                                + "inner join contenu_de conde on de.contenu_de_id = conde.id "
                                + "inner join  type_de td on de.type_de_id = td.Id";
                    dynamic De = connection.Query<DeModel, DeContenuModel, TypeDeModel, DeModel>(sql, (de, contenuDe,typeDe) =>
                    {
                        de.Contenu_de = contenuDe;
                         de.TypeDes = typeDe;
                        de.TypeDe = typeDe.Type;
                       return de;
                    },
                     splitOn: "contenu_de,Type");
                    return De;
                }
                
            }
            catch (Exception ex)
            {
                dynamic z = null;
                LogThisLine(ex.ToString());
                MessageBox.Show("Problem technique, veuillez réessayer plus tard");
                return z;
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
            try { 
            using (var db = new SqlConnection(connectionString))

            {
                ls.ForEach(delegate (DynamicParameters item) {
                    int rowsAffected = db.Execute(sqlString,
                        new[]
                {item }
                 ); });
            };
            }
            catch(Exception ex)
            {
                LogThisLine(ex.ToString());
                MessageBox.Show("Problem technique, veuillez réessayer plus tard");
            }
        }

        /// <summary>
        /// méthode pour sauvegarder une seule ligne dans la base
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sqlString"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static int InsertData<T>(string sqlString, DynamicParameters parameters)
        {

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    int result = connection.ExecuteScalar<int>(sqlString, parameters);
                    return result;
                }
            }
            catch(Exception ex)
            {
                LogThisLine(ex.ToString());
                MessageBox.Show("Problem technique, veuillez réessayer plus tard");
                return -1;
              
            }
           
        }
        #endregion


    }

}

