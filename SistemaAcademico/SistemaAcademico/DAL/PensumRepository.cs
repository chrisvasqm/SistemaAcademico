using System;
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

        //public List<Pensum> GetPensumContentById()
        //{
        //    return dataBase.Pensums.Where(x => x.);
        //}

        public List<Pensum> GetPensumSubjects()
        {
            var result = dataBase.Pensums;
            return result.ToList();
        }
    }
}
