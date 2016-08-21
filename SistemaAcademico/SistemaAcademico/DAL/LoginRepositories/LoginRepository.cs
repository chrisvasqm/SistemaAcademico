using System.Linq;

namespace SistemaAcademico.DAL.LoginRepositories
{
    public class LoginRepository
    {
        private AcademicEntities dbContext = new AcademicEntities();
        public Login VerifyLogin(Login loginValues) {    return dbContext.Logins.FirstOrDefault(x => x.Enrollment == loginValues.Enrollment && x.Password == loginValues.Password);   }
    }
}
