
using System.Collections.Generic;
using System.Linq;

namespace SistemaAcademico.DAL
{
    class StudentSeccionRepository
    {
        private AcademicEntities dataBase = new AcademicEntities();
        public List<StudentRecord> GetAllStudentSubjects(string studentMatricula)    {   return dataBase.StudentRecords.Where(x => x.Student == studentMatricula).ToList();   }

        public void SetStudentSubjects(StudentRecord selectionValues)
        {
            dataBase.StudentRecords.Add(selectionValues);
            dataBase.SaveChanges();
        }

        public bool isDuplicated(StudentRecord studentValues)
        {
            return dataBase.StudentRecords.Any(x => x.Student == studentValues.Student && x.Materia == studentValues.Materia);
        }
    }
}