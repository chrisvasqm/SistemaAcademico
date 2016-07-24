using System;
using System.Data;
using System.Data.SqlClient;
using SistemaAcademico.CapaDatos;
using SistemaAcademico.Capa

namespace CapaNegocio
{
    class Login
    {
        private void LoginEst()
        {
            FormLoginEst 
            
            SqlConnection con = new SqlConnection(Connection.stringConnection);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLogin";
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@contra", txtContraseña.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();        

        }

        private void LoginProf()
        {

        }
    }
}
