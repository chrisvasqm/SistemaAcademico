﻿using System.Linq;

namespace SistemaAcademico.DAL
{
    public class StudentRepository
    {
        private AcademicEntities dataBase = new AcademicEntities();
        public bool VerifyStudent (string username, string password, int accountTypeId)
        {
            return dataBase.Logins.Any(x => x.Username == username && x.Password == password && x.AccountTypeID == accountTypeId);
        }
    }
}
