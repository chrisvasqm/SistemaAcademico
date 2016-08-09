using System.Collections.Generic;
using System.Linq;

namespace SistemaAcademico.DAL
{
    public class AccountTypeRepository
    {
        private AcademicEntities dataBase = new AcademicEntities();        
        public List<AccountType> GetAccountType()
        {
           var result = dataBase.AccountTypes;
           return result.ToList();
        } 
    }
}
