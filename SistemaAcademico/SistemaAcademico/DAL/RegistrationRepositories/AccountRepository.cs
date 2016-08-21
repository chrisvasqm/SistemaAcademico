using System.Linq;

namespace SistemaAcademico.DAL.RegistrationRepository
{
    class AccountRepository
    {
        private AcademicEntities dataBase = new AcademicEntities();
        public void CreateLoginAccount(Login loginValues)
        {            
            dataBase.Logins.Add(loginValues);
            dataBase.SaveChanges();
        }
        public void CreateStudentInfo(Student studentValues)
        {
            dataBase.Students.Add(studentValues);
            dataBase.SaveChanges();
        }
        public bool AccountExist (string loginEnrollment) {     return dataBase.Logins.Any(x => x.Enrollment == loginEnrollment);    }
    }
}
