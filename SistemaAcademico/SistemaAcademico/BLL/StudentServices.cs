using SistemaAcademico.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.BLL
{
    class StudentServices
    {
        private PensumRepository _PensumRepository = new PensumRepository();
        public List<Pensum> GetSubjects()
        {
            return _PensumRepository.GetPensumSubjects();
        }

        public List<Pensum> GetContent()
        {
            return _PensumRepository.GetPensumContent();
        }
    }
}
