using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CarteleriaDigital.DAO
{
    class ImagenDAO
    {
        public void insertar(Conexion con, Imagen imagen)
        {
            try
            {
                con.openConection();
                // Create insert command.
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO " +
                    "rango(duracion, rutaimagen) VALUES(:duracion, :rutaimagen)", con.connection);
                
                // Add paramaters.
                command.Parameters.Add(new NpgsqlParameter("fechainicio",
                    NpgsqlTypes.NpgsqlDbType.Integer));
                command.Parameters.Add(new NpgsqlParameter("fechafin",
                    NpgsqlTypes.NpgsqlDbType.Varchar));

                // Prepare the command.
                command.Prepare();

                // Add value to the paramater.
                command.Parameters[0].Value = imagen.Duracion;
                command.Parameters[1].Value = imagen.RutaImagen;


                // Execute SQL command.
                Int32 recordAffected = command.ExecuteNonQuery();
                if (Convert.ToBoolean(recordAffected))
                {
                    //Mostrar error
                }
            }
            catch (NpgsqlException ex)
            {
                //Mostrar error
            }

            con.closeConection();
        }
    }
}
