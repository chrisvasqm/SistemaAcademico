
using System.Collections.Generic;
using System.Linq;

namespace SistemaAcademico.DAL
{
    class RecordsRepository
    {
        private AcademicEntities dataBase = new AcademicEntities();

        public List<StudentRecord> GetAllStudentRecords()
        {
            return dataBase.StudentRecords.ToList();
        }
        public List<StudentRecord> GetRecordByEnrollment(string studentMatricula)
        {
            return dataBase.StudentRecords.Where(x => x.Student == studentMatricula).ToList();
        }

        public List<StudentRecord> GetRecordBySubject(string cmbValue)
        {
            return dataBase.StudentRecords.Where(x => x.Materia == cmbValue).ToList();
        }
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