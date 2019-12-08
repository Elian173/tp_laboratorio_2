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
            string connectionString = @"Server =.\SQLEXPRESS; Database = correo-sp-2017; Trusted_Connection = true;";

            conexion = new SqlConnection(connectionString);
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        #endregion Constructor

        #region Metodos

        /// <summary>
        /// Inserta un paquete en la base de datos
        /// </summary>
        /// <param name="paquete"></param>
        /// <returns></returns>
        public static bool Insertar( Paquete paquete )
        {
            try
            {
                string comandoString = "INSERT INTO dbo.Paquetes (direccionEntrega, trackingID, alumno) VALUES (@direccionEntrega, @trackingID, @alumno);";
                PaqueteDAO.conexion.Open();

                PaqueteDAO.comando = new SqlCommand(comandoString, PaqueteDAO.conexion);
                PaqueteDAO.comando.Parameters.AddWithValue("@direccionEntrega", paquete.DireccionEntrega);
                PaqueteDAO.comando.Parameters.AddWithValue("@trackingID", paquete.TrackingID);
                PaqueteDAO.comando.Parameters.AddWithValue("@alumno", "Elian Rojas");

                PaqueteDAO.comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (PaqueteDAO.conexion != null && PaqueteDAO.conexion.State == System.Data.ConnectionState.Open)
                {
                    PaqueteDAO.conexion.Close();
                }
            }

            return true;
        }

        #endregion Metodos
    }
}