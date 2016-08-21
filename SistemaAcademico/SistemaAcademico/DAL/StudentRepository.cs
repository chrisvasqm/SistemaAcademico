
using System.Linq;

namespace SistemaAcademico.DAL
{
    public class StudentRepository
    {
        AcademicEntities dbContext = new AcademicEntities();
        public int GetStudentIdByEnrollment(string StudentEnrollment)   {   return dbContext.Students.FirstOrDefault(x => x.Enrollment == StudentEnrollment).ID;   }        
    }
}