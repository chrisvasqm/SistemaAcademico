
using System.Collections.Generic;
using System.Linq;

namespace SistemaAcademico.DAL.RegistrationRepository
{
    class GenderRepository
    {
        private AcademicEntities dbContext = new AcademicEntities();
        public List<Gender> GetGender() {   return dbContext.Genders.ToList();   }
    }
}
