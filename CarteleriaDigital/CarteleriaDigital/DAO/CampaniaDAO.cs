using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CarteleriaDigital.DAO
{
    class CampaniaDAO
    {
        public void insertar(Conexion con, Campania camp)
        {
            try
            {
                con.openConection();
                // Create insert command.
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO " +
                    "rango(nombre, activo, listaimagenes) VALUES(:nombre, :activo, :listaimagenes)", con.connection);
                // Add paramaters.
                command.Parameters.Add(new NpgsqlParameter("nombre",
                    NpgsqlTypes.NpgsqlDbType.Integer));
                command.Parameters.Add(new NpgsqlParameter("activo",
                    NpgsqlTypes.NpgsqlDbType.Varchar));
                command.Parameters.Add(new NpgsqlParameter("listaimagenes",
                    NpgsqlTypes.NpgsqlDbType.Array));

                // Prepare the command.
                command.Prepare();

                // Add value to the paramater.
                command.Parameters[0].Value = camp.Nombre;
                command.Parameters[1].Value = camp.Activo;
                command.Parameters[2].Value = camp.ListaImagenes;


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
