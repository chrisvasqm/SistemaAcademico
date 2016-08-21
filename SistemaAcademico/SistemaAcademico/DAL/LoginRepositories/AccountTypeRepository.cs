using System.Collections.Generic;
using System.Linq;

namespace SistemaAcademico.DAL.LoginRepositories
{
    public class AccountTypeRepository
    {
        private AcademicEntities dbContext = new AcademicEntities();        
        public List<AccountType> GetAccountType()   {      return dbContext.AccountTypes.ToList();    } 
    }
}
