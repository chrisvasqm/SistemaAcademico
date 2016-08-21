using SistemaAcademico.DAL;
using System.Collections.Generic;

namespace SistemaAcademico.BL
{
    class StudentServices
    {
        private SubjectsRepository _subjectRepository = new SubjectsRepository();
        private RecordsRepository _studentSeccionRepository = new RecordsRepository();
        
        public List<Subject> GetAllSubject()
        {
            return _subjectRepository.GetAllSubjects();
        }
        public List<StudentRecord> GetRecordsByMatricula(string studentMatricula)
        {
            return _studentSeccionRepository.GetRecordByEnrollment(studentMatricula);
        }    

        public bool ValidateDuplicate(StudentRecord selectionValues)
        {
            if (_studentSeccionRepository.isDuplicated(selectionValues))
                return true;
            else
                return false;
        }
        public void SetStudentSubject(StudentRecord selectionValues)
        {
            _studentSeccionRepository.SetStudentSubjects(selectionValues);
        }
    }
}
