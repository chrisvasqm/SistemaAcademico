
using System.Collections.Generic;
using System.Linq;

namespace SistemaAcademico.DAL
{    
    public class PensumRepository
    {
        private AcademicEntities dataBase = new AcademicEntities();

        public List<Pensum> GetPensumContent()
        {
            return dataBase.Pensums.ToList();
        }
        
        public List<Pensum> GetPensumSubjects()
        {
            return dataBase.Pensums.ToList();
        }
    }
}
