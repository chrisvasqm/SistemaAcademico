using System.Linq;

namespace SistemaAcademico.DAL
{
    public class StudentRepository
    {
        AcademicEntities dataBase = new AcademicEntities();

        public int GetStudentIdByEnrollment(string StudentEnrollment)
        {
            return dataBase.Students.FirstOrDefault(x => x.Enrollment == StudentEnrollment).ID;
        }
       
    }
}