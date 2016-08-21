
using System.Collections.Generic;
using System.Linq;

namespace SistemaAcademico.DAL
{
    class RecordsRepository
    {
        private AcademicEntities dbContext = new AcademicEntities();

        public List<StudentRecord> GetAllStudentRecords()
        {
            return dbContext.StudentRecords.ToList();
        }
        public List<StudentRecord> GetRecordByEnrollment(string studentMatricula)
        {
            return dbContext.StudentRecords.Where(x => x.Student == studentMatricula).ToList();
        }
        public List<StudentRecord> GetRecordBySubject(string cmbValue)
        {
            return dbContext.StudentRecords.Where(x => x.Materia == cmbValue).ToList();
        }
        public void SetStudentSubjects(StudentRecord selectionValues)
        {
            dbContext.StudentRecords.Add(selectionValues);
            dbContext.SaveChanges();
        }
        public bool isDuplicated(StudentRecord studentValues)
        {
            return dbContext.StudentRecords.Any(x => x.Student == studentValues.Student && x.Materia == studentValues.Materia);
        }

        public int GetIdByEnrollmentAndSubject(string matricula, string materia)
        {
            return dbContext.StudentRecords.FirstOrDefault(x => x.Student == matricula && x.Materia == materia).ID;
        }

        public void EvaluateStudentByEnrollment(StudentRecord evaluationValues)
        {
            var sumNota = evaluationValues.P1 + evaluationValues.P2 + evaluationValues.P3 + evaluationValues.Practica + evaluationValues.Asistencia;
            StudentRecord studentRecord = dbContext.StudentRecords.FirstOrDefault(x => x.ID == evaluationValues.ID);
            studentRecord.P1 = evaluationValues.P1;
            studentRecord.P2 = evaluationValues.P2;
            studentRecord.P3 = evaluationValues.P3;
            studentRecord.Practica = evaluationValues.Practica;
            studentRecord.Asistencia = evaluationValues.Asistencia;
            studentRecord.Nota = sumNota;
            studentRecord.isApproved = false;
            if (sumNota >= 70)
            {
                studentRecord.isApproved = true;
                dbContext.SaveChanges();
            }
            dbContext.SaveChanges();
        }
    }
}