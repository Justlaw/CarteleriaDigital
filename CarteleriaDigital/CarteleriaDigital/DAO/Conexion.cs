using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CarteleriaDigital.DAO
{
    class Conexion
    {
        private const String SERVER = "localhost";
        private const String PORT = "5432";
        private const String USER = "postgres";
        private const String PASSWORD = "123";
        private const String DATABASE = "DBCarteleria";


        public NpgsqlConnection connection = new NpgsqlConnection();

        public NpgsqlConnection ConectaPostgreSQL()
        {
            connection = new NpgsqlConnection(
                "Server=" + SERVER + ";" +
                "Port=" + PORT + ";" +
                "User Id=" + USER + ";" +
                "Password=" + PASSWORD + ";" +
                "Database=" + DATABASE + ";"
            );
            return connection;
        }

        public void openConection()
        {
            try
            {

                connection.Open();
            }
            catch (NpgsqlException ex)
            {
                
            }
        }

        public void closeConection()
        {
            try
            {
                connection.Close();
            }
            catch (NpgsqlException ex)
            {
                
            }
        }
    }
}
