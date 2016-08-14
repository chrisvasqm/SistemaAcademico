using System.Collections.Generic;
using System.Linq;

namespace SistemaAcademico.DAL.LoginRepositories
{
    public class AccountTypeRepository
    {
        private AcademicEntities dataBase = new AcademicEntities();        
        public List<AccountType> GetAccountType()
        {
           return dataBase.AccountTypes.ToList();
        } 
    }
}
