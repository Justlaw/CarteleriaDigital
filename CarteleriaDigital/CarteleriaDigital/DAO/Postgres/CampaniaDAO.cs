using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using CarteleriaDigital.DTO;

namespace CarteleriaDigital.DAO
{
    class CampaniaDAO
    {
        private Conexion iConexion;

        public CampaniaDAO(Conexion pConexion)
        {
            this.iConexion = pConexion;

        }

        public void insertar(CampañaDTO camDTO)
        {
            try
            {
                iConexion.openConection();
                // Create insert command.
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO " +
                    "rango(nombre, activo, listaimagenes) VALUES(:nombre, :activo, :listaimagenes)", iConexion.connection);

                command.Parameters.AddWithValue("@idcampaña", camDTO.Nombre);
                command.Parameters.AddWithValue("@duracion", camDTO.Activo);
                command.Parameters.AddWithValue("@rutaimagen", camDTO.IdRango);

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

        public void Modificar(CampañaDTO camDTO)
        {
            iConexion.openConection();

            try
            {
                // Create update command.
                NpgsqlCommand command = new NpgsqlCommand(@"UPDATE rango " +
                    "SET idrango = @idrango, activo = @activo, nombre = @nombre WHERE idcampaña = " + camDTO.IdCampaña, iConexion.connection);

                // Add paramaters.
                command.Parameters.AddWithValue("@idcampaña", camDTO.IdCampaña);
                command.Parameters.AddWithValue("@idrango", camDTO.IdRango);
                command.Parameters.AddWithValue("@activo", camDTO.Activo);
                command.Parameters.AddWithValue("@nombre", camDTO.Nombre);

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

            iConexion.closeConection();
        }

    }
}
