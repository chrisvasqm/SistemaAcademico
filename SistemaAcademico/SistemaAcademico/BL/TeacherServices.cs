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

        public List<StudentRecord> GetRecordsBySubject(StudentRecord cmbValue)
        {
            return _recordsRepository.GetRecordBySubject(cmbValue.Materia);
        }
    }
}
