using SistemaAcademico.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaAcademico.BLL
{
    class RegistrationService
    {
        private GenderRepository _GenderRepository = new GenderRepository();

        public List<Gender> GetGender()
        {
            return _GenderRepository.GetGenders();
        }
    }
}
