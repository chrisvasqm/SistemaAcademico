using System.Collections.Generic;
using SistemaAcademico.DAL;

namespace SistemaAcademico.BL
{
    class TeacherServices
    {
        private RecordsRepository _recordsRepo = new RecordsRepository();
        public List<StudentRecord> GetAllStudentsRecords()
        {
            return _recordsRepo.GetAllStudentRecords();
        }
        public List<StudentRecord> GetRecordsBySubject(string cmbValue)
        {
            return _recordsRepo.GetRecordBySubject(cmbValue);
        }
        public bool isNotOverOrUnderLimit(StudentRecord evaluationValues)
        {
            if (evaluationValues.P1 <= 20
                 && evaluationValues.P2 <= 20
                 && evaluationValues.P3 <= 20
                 && evaluationValues.Practica <= 30
                 && evaluationValues.Asistencia <= 10)
                return true;
            else
                return false;
        }

        public void EvaluateStudentsByEnrollment(StudentRecord evaluationValues)
        {            
            _recordsRepo.EvaluateStudentByEnrollment(evaluationValues);
        }

        public int GetRecordId (string matricula, string materia)
        {
            return _recordsRepo.GetIdByEnrollmentAndSubject(matricula, materia);
        }
    }
}
