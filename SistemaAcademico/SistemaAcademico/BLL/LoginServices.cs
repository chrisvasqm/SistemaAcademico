using SistemaAcademico.DAL;
using System.Collections.Generic;

namespace SistemaAcademico.BLL
{
    public class LoginServices
    {
        private LoginRepository _LoginRepository = new LoginRepository();
        private AccountTypeRepository _AccountRepository = new AccountTypeRepository();
        private PensumRepository _PensumRepository = new PensumRepository();
        public TypeOfAccount ValidateAccountType(string username, string password, int comboValue)
        {
            var user = _LoginRepository.VerifyLogin(username, password);

            if (user.AccountTypeID == (int)TypeOfAccount.Student && user.AccountTypeID == comboValue)
                return TypeOfAccount.Student;
            else if (user.AccountTypeID == (int)TypeOfAccount.Teacher && user.AccountTypeID == comboValue)
                return TypeOfAccount.Teacher;

            return TypeOfAccount.Error;
        }
        public List<AccountType> GetLoginType()
        {
            return _AccountRepository.GetAccountType();
        }

        
    }
}


   
