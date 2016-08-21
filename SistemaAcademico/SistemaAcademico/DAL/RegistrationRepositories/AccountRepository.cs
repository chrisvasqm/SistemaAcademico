using System.Linq;

namespace SistemaAcademico.DAL.RegistrationRepository
{
    class AccountRepository
    {
        private AcademicEntities dbContext = new AcademicEntities();
        public void CreateLoginAccount(Login loginValues)
        {            
            dbContext.Logins.Add(loginValues);
            dbContext.SaveChanges();
        }
        public void CreateStudentInfo(Student studentValues)
        {
            dbContext.Students.Add(studentValues);
            dbContext.SaveChanges();
        }
        public bool AccountExist (string loginEnrollment) {     return dbContext.Logins.Any(x => x.Enrollment == loginEnrollment);    }
    }
}
