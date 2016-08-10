
using System.Collections.Generic;
using System.Linq;

namespace SistemaAcademico.DAL
{
    class GenderRepository
    {
        private AcademicEntities dataBase = new AcademicEntities();

        public List<Gender> GetGenders()
        {
            return dataBase.Genders.ToList();
        }
    }
}
