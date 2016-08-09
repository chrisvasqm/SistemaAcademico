using System.Linq;

namespace SistemaAcademico.DAL
{
    public class LoginRepository
    {
        private AcademicEntities dataBase = new AcademicEntities();
        public Login VerifyLogin(string username, string password)
        {
            return dataBase.Logins.FirstOrDefault(x => x.Username == username && x.Password == password);
        }
    }
}
