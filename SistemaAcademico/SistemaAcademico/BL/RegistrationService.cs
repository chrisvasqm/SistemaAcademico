using SistemaAcademico.DAL.RegistrationRepository;
using System.Collections.Generic;

namespace SistemaAcademico.BLL
{
    class RegistrationService
    {
        private GenderRepository _genderRepository = new GenderRepository();
        private AccountRepository _accountRepository = new AccountRepository();

        public List<Gender> GetGenders()
        {
            return _genderRepository.GetGender();
        }

        public void CreateNewAccount(Login loginValues)
        {
            _accountRepository.CreateLoginAccount(loginValues);            
        }

        public bool AccountExist(Login loginValues)
        {
            return _accountRepository.AccountExist(loginValues.Enrollment);
        }

        public void CreateStudentProfile(Student studentValues)
        {
            _accountRepository.CreateStudentInfo(studentValues);
        }
    }
}
