using SistemaAcademico.DAL.LoginRepositories;
using System.Collections.Generic;

namespace SistemaAcademico.BLL
{
    public class LoginServices
    {
        private LoginRepository _LoginRepository = new LoginRepository();
        private AccountTypeRepository _AccountRepository = new AccountTypeRepository();
        public TypeOfAccount ValidateAccountType(Login loginValues, int comboValue)
        {
            var user = _LoginRepository.VerifyLogin(loginValues);

            if (user != null && user.AccountTypeID == (int)TypeOfAccount.Student && user.AccountTypeID == comboValue)
                return TypeOfAccount.Student;

            else if (user != null && user.AccountTypeID == (int)TypeOfAccount.Teacher && user.AccountTypeID == comboValue)
                return TypeOfAccount.Teacher;

            return TypeOfAccount.Error;
        }
        public List<AccountType> GetLoginType()
        {
            return _AccountRepository.GetAccountType();
        }

        
    }
}


   
