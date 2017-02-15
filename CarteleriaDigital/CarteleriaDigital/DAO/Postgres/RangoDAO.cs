using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using CarteleriaDigital.DTO;


namespace CarteleriaDigital.DAO
{
    class RangoDAO
    {

        private Conexion iConexion;

        public RangoDAO(Conexion pConexion)
        {
            this.iConexion = pConexion;

        }


        public void insertar(RangoDTO ranDto)
        {
            try
            {
                iConexion.openConection();
                // Create insert command.
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO " +
                    "rango(fechainicio, fechafin, horainicio, horafin) VALUES(:fechainicio, :fechafin, :horainicio, :horafin)", this.iConexion.connection);

                // Add paramaters.
                command.Parameters.Add(new NpgsqlParameter("fechainicio",
                    NpgsqlTypes.NpgsqlDbType.Date));
                command.Parameters.Add(new NpgsqlParameter("fechafin",
                    NpgsqlTypes.NpgsqlDbType.Date));
                command.Parameters.Add(new NpgsqlParameter("horainicio",
                   NpgsqlTypes.NpgsqlDbType.Time));
                command.Parameters.Add(new NpgsqlParameter("horafin",
                   NpgsqlTypes.NpgsqlDbType.Time));

                // Prepare the command.
                command.Prepare();

                // Add value to the paramater.
                command.Parameters[0].Value = ranDto.FechaInicio;
                command.Parameters[1].Value = ranDto.FechaFin.Date;
                command.Parameters[2].Value = ranDto.HoraInicio.TimeOfDay;
                command.Parameters[3].Value = ranDto.HoraFin.TimeOfDay;


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

            iConexion.closeConection();
        }

        public void Modificar(Conexion con, Rango ran, String nombre)
        {
            con.openConection();

            try
            {
                // Create update command.
                NpgsqlCommand command = new NpgsqlCommand("UPDATE rango " +
                    "SET fechainicio = :fechainicio, fechafin = :fechafin, horainicio = :horainicio, horafin = :horafin WHERE id = :id",
                    con.connection);

                command.Parameters.Add(new NpgsqlParameter("fechainicio",
                    NpgsqlTypes.NpgsqlDbType.Date));
                command.Parameters.Add(new NpgsqlParameter("fechafin",
                    NpgsqlTypes.NpgsqlDbType.Date));
                command.Parameters.Add(new NpgsqlParameter("horainicio",
                   NpgsqlTypes.NpgsqlDbType.Time));
                command.Parameters.Add(new NpgsqlParameter("horafin",
                   NpgsqlTypes.NpgsqlDbType.Time));

                // Prepare the command.
                command.Prepare();

                // Add value to the paramater.
                command.Parameters[0].Value = ran.FechaInicio.Date;
                command.Parameters[1].Value = ran.FechaFin.Date;
                command.Parameters[2].Value = ran.HoraInicio.TimeOfDay;
                command.Parameters[3].Value = ran.HoraFin.TimeOfDay;

                // Execute SQL command.
                int recordAffected = command.ExecuteNonQuery();
                if (Convert.ToBoolean(recordAffected))
                {
                    //showInformation("Data successfully updated!");
                }
            }
            catch (NpgsqlException ex)
            {
                //showError(ex);
            }

            con.closeConection();
        }
    }
}
