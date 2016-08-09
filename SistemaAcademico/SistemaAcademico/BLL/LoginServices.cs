using SistemaAcademico.DAL;
using System.Collections.Generic;

namespace SistemaAcademico.BLL
{
    public class LoginServices
    {
        private StudentRepository _StudentRepository = new StudentRepository();
        private TeacherRepository _TeacherRepository = new TeacherRepository();
        private AccountTypeRepository _AccountRepository = new AccountTypeRepository();
        public TypeOfAccount ValidateAccountType(string username, string password, int comboValue)
        {
            if (_StudentRepository.VerifyStudent(username, password, comboValue))
                return TypeOfAccount.Student;
            else if (_TeacherRepository.VerifyTeacher(username, password, comboValue))
                return TypeOfAccount.Teacher;
            //TODO: Add other types of accounts
            return TypeOfAccount.Error;
        }
        public List<AccountType> GetLoginType()     {
            return _AccountRepository.GetAccountType();
        }
    }
}


   
