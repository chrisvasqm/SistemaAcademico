using System.Collections.Generic;
using SistemaAcademico.DAL;

namespace SistemaAcademico.BL
{
    class TeacherServices
    {
        private RecordsRepository _recordsRepository = new RecordsRepository();
        public List<StudentRecord> GetAllStudentsRecords()
        {
            return _recordsRepository.GetAllStudentRecords();
        }
        public List<StudentRecord> GetRecordsBySubject(string cmbValue)
        {
            return _recordsRepository.GetRecordBySubject(cmbValue);
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
            _recordsRepository.EvaluateStudentByEnrollment(evaluationValues);
        }

        public int GetRecordId (string matricula, string materia)
        {
            return _recordsRepository.GetIdByEnrollmentAndSubject(matricula, materia);
        }
    }
}
