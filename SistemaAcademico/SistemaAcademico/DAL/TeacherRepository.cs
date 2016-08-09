using System.Linq;

namespace SistemaAcademico.DAL
{
    class TeacherRepository
    {
        private AcademicEntities dataBase = new AcademicEntities();
        public bool VerifyTeacher (string username, string password, int accountTypeId)
        {
            return dataBase.Logins.Any(x => x.Username == username && x.Password == password && x.AccountTypeID == accountTypeId);
        }
    }
}