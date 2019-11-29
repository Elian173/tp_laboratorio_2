using System;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PaqueteDAO
    {
        #region Atributos

        private static SqlCommand comando;
        private static SqlConnection conexion;

        #endregion Atributos

        #region Constructor

        static PaqueteDAO()
        {
            conexion = new SqlConnection(".//SQL"); // :( no funciona
            comando = new SqlCommand();
        }

        #endregion Constructor

        #region Metodos

        /// <summary>
        /// Inserta un paquete en la base de datos ( no funciona )
        /// </summary>
        /// <param name="paquete"></param>
        /// <returns></returns>
        public static bool Insertar( Paquete paquete )
        {
            try
            {
                string comandoString = "INSERT INTO dbo.Paquetes (direccionEntrega, trackingID, alumno) VALUES (@direccionEntrega, @trackingID, @alumno);";
                SqlCommand command = new SqlCommand(comandoString, PaqueteDAO.conexion);
                command.Parameters.AddWithValue("@direccionEntrega", paquete.DireccionEntrega);
                command.Parameters.AddWithValue("@trackingID", paquete.TrackingID);
                command.Parameters.AddWithValue("@alumno", "Elian Rojas");

                PaqueteDAO.conexion.Open();
                PaqueteDAO.comando = command;
                PaqueteDAO.comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }
            return true;
        }

        #endregion Metodos
    }
}