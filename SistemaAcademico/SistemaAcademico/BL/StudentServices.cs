using SistemaAcademico.DAL;
using System.Collections.Generic;

namespace SistemaAcademico.BL
{
    class StudentServices
    {
        private SubjectsRepository _subjectRepo = new SubjectsRepository();
        private RecordsRepository _studentRecordsRepo = new RecordsRepository();
        
        public List<Subject> GetAllSubject()
        {
            return _subjectRepo.GetAllSubjects();
        }
        public List<StudentRecord> GetRecordsByMatricula(string studentMatricula)
        {
            return _studentRecordsRepo.GetRecordByEnrollment(studentMatricula);
        }    

        public bool ValidateDuplicate(StudentRecord selectionValues)
        {
            if (_studentRecordsRepo.isDuplicated(selectionValues))
                return true;
            else
                return false;
        }
        public void SetStudentSubject(StudentRecord selectionValues)
        {
            _studentRecordsRepo.SetStudentSubjects(selectionValues);
        }
    }
}
