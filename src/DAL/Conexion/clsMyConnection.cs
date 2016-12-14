using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;


namespace DAL.Conexion
{
    public class clsMyConnection
    {

        public string dataBase { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
        public string host { get; set; }



        public clsMyConnection()
        {
            dataBase = "UWPSampleAlvaro";
            user = "prueba";
            pass = "iesnervion123.";
            host = "uwpsamplealvaro1.database.windows.net";

        }

        public clsMyConnection(string host, string dataBase, string user, string pass)
        {
            this.dataBase = dataBase;
            this.user = user;
            this.pass = pass;
            this.host = host;
        }


        //METODOS

        public SqlConnection getConnection()
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                
                connection.ConnectionString = string.Format("server={0};database={1};uid={2};pwd={3};", host, dataBase, user, pass);
               

                connection.Open();
            }
            catch (SqlException)
            {
                throw;
            }

            return connection;

        }




        public void closeConnection(ref SqlConnection connection)
        {
            try
            {
                connection.Close();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw; 
            }
            catch (Exception)
            {
            throw;
            }
        }


    }

}
