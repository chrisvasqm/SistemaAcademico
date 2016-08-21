
using System.Collections.Generic;
using System.Linq;

namespace SistemaAcademico.DAL
{
    class SubjectsRepository
    {
        private AcademicEntities dataBase = new AcademicEntities();
        public List<Subject> GetAllSubjects() {  return dataBase.Subjects.ToList();  }       
    }
}
