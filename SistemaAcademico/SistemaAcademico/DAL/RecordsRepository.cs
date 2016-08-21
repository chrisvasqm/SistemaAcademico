
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

        public int GetIdByEnrollmentAndSubject(string matricula, string materia)
        {
            return dataBase.StudentRecords.FirstOrDefault(x => x.Student == matricula && x.Materia == materia).ID;
        }

        public void EvaluateStudentByEnrollment(StudentRecord evaluationValues)
        {
            StudentRecord studentRecord = dataBase.StudentRecords.FirstOrDefault(x => x.ID == evaluationValues.ID);
            studentRecord.P1 = evaluationValues.P1;
            studentRecord.P2 = evaluationValues.P2;
            studentRecord.P3 = evaluationValues.P3;
            studentRecord.Practica = evaluationValues.Practica;
            studentRecord.Asistencia = evaluationValues.Asistencia;
            studentRecord.Nota = evaluationValues.P1 + evaluationValues.P2 + evaluationValues.P3 + evaluationValues.Practica + evaluationValues.Asistencia;
            dataBase.SaveChanges();
        }
    }
}