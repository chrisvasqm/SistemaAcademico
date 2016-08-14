
using System.Collections.Generic;
using System.Linq;

namespace SistemaAcademico.DAL.RegistrationRepository
{
    class GenderRepository
    {
        private AcademicEntities dataBase = new AcademicEntities();
        public List<Gender> GetGender()
        {
            return dataBase.Genders.ToList();
        }
    }
}
