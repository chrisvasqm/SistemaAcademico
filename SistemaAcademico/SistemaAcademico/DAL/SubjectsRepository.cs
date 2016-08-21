
using System.Collections.Generic;
using System.Linq;

namespace SistemaAcademico.DAL
{
    class SubjectsRepository
    {
        private AcademicEntities dbContext = new AcademicEntities();
        public List<Subject> GetAllSubjects() {  return dbContext.Subjects.ToList();  }       
    }
}
