using SistemaAcademico.DAL;
using System.Collections.Generic;

namespace SistemaAcademico.BLL
{
    class StudentServices
    {
        private SubjectsRepository _subjectRepository = new SubjectsRepository();
        private StudentSeccionRepository _studentSeccionRepository = new StudentSeccionRepository();
        
        public List<Subject> GetAllSubject() {   return _subjectRepository.GetAllSubjects();     }        
        public List<StudentRecord> GetAllStudentsSubject(string studentMatricula) {    return _studentSeccionRepository.GetAllStudentSubjects(studentMatricula);     } 

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
