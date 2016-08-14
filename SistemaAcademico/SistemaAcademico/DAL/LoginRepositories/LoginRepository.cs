using System.Linq;

namespace SistemaAcademico.DAL.LoginRepositories
{
    public class LoginRepository
    {
        private AcademicEntities dataBase = new AcademicEntities();
        public Login VerifyLogin(Login loginValues)
        {
            return dataBase.Logins.FirstOrDefault(x => x.Enrollment == loginValues.Enrollment && x.Password == loginValues.Password);
        }
    }
}
