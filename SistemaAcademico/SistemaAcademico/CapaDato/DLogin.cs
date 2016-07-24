using System;
using System.Data;
using System.Data.SqlClient;
using SistemaAcademico.CapaDatos;

namespace CapaDato
{
    public class DLogin
    {        
        private string _Usuario;
        private string _Contra;
        
        public string Usuario { get; set; }
        public string Contra { get; set; }

        public DLogin()
        {

        }

        public DLogin(string usuario, string contra)
        {
            this.Usuario    = usuario;
            this.Contra     = contra;
        }

        public string LoginUser(DLogin Login)
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                // Stablish connection with Database
                sqlcon.ConnectionString = Connection.stringConnection;
                // Open the connection
                sqlcon.Open();
                // Declare a SqlCommand and it's atributes
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = sqlcon;
                // Specify the StoredProcedure to use
                cmd.CommandText = "spLogin";

                // Declare a every single Paramter needed
                // Parameter for Usuario
                SqlParameter parUsuario = new SqlParameter();
                parUsuario.ParameterName = "@usuario";
                parUsuario.SqlDbType = SqlDbType.VarChar;
                parUsuario.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parUsuario);

                // Parameter for Contraseña
                SqlParameter parContra = new SqlParameter();
                parContra.ParameterName = "@contraseña";
                parUsuario.SqlDbType = SqlDbType.VarChar;
                parContra.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parContra);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No funciono la mielda eta";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }                
            }
            return respuesta;
        }
    }
}
