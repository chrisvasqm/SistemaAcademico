using SistemaAcademico.DAL.RegistrationRepository;
using System.Collections.Generic;

namespace SistemaAcademico.BL
{
    class RegistrationService
    {
        private GenderRepository _genderRepo = new GenderRepository();
        private AccountRepository _accountRepo = new AccountRepository();

        public List<Gender> GetGenders() { return _genderRepo.GetGender(); }

        public void CreateNewAccount(Login loginValues) { _accountRepo.CreateLoginAccount(loginValues); }

        public bool AccountExist(Login loginValues) { return _accountRepo.AccountExist(loginValues.Enrollment); }

        public void CreateStudentProfile(Student studentValues) { _accountRepo.CreateStudentInfo(studentValues); }
    }
}
