using System;
using System.Data;
using System.Data.SqlClient;
using SistemaAcademico.CapaDatos;

namespace CapaNegocio
{
    class Login
    {
        private void LoginEst()
        {
            
            SqlConnection con = new SqlConnection(Connection.stringConnection);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLogin";
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            ...

        }

        private void LoginProf()
        {

        }
    }
}
