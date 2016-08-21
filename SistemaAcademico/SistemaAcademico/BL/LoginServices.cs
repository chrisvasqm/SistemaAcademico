using SistemaAcademico.DAL.LoginRepositories;
using System.Collections.Generic;

namespace SistemaAcademico.BL
{
    public class LoginServices
    {
        private LoginRepository _loginRepo = new LoginRepository();
        private AccountTypeRepository _accountRepo = new AccountTypeRepository();
        public TypeOfAccount ValidateAccountType(Login loginValues, int comboValue)
        {
            var user = _loginRepo.VerifyLogin(loginValues);

            if (user != null && user.AccountTypeID == (int)TypeOfAccount.Student && user.AccountTypeID == comboValue)
                return TypeOfAccount.Student;

            else if (user != null && user.AccountTypeID == (int)TypeOfAccount.Teacher && user.AccountTypeID == comboValue)
                return TypeOfAccount.Teacher;

            return TypeOfAccount.Error;
        }
        public List<AccountType> GetLoginType() {   return _accountRepo.GetAccountType();     }  
              
    }
}


   
