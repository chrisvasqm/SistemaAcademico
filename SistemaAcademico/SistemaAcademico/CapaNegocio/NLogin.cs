using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAcademico.CapaDatos;
using System.Data;

namespace CapaNegocio
{
    class NLogin
    {
        public static string Login(string usuario, string contra)
        {
            CapaDato.DLogin Obj = new CapaDato.DLogin();
            Obj.Usuario = usuario;
            Obj.Contra = contra;

            return Obj.LoginUser(Obj);
        }
    }
}
