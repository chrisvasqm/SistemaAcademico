using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LinqTest
{
    class StudentRepository
    {
        private FinalEntities dataBase = new FinalEntities();

        public bool VerifyStudent (tbl_login loginValues)
        {
            return dataBase.tbl_login.Any(x => x.usuario == loginValues.usuario && x.contraseña == loginValues.contraseña);
        }

        public void InsertStudent (tbl_login insertValues)
        {
            dataBase.tbl_login.Add(insertValues);
            dataBase.SaveChanges();
        }
        public void DeleteStudentById (int deleteValue)
        {
            var student = dataBase.tbl_login.FirstOrDefault(x => x.id_login == deleteValue);
            dataBase.tbl_login.Remove(student);
            dataBase.SaveChanges();
        }
        public List<tbl_login> GetStudents()
        {
            return dataBase.tbl_login.ToList();            
        }
        public List<tbl_login> GetStudentsById (int idValue)
        {             
            return dataBase.tbl_login.Where(x => x.id_login == idValue).ToList();
        }

        // WORK IN PROGRESS, DO NOT TOUCH
        public void Update (tbl_login updateValues)
        {
            var student = new tbl_login
            {
                id_login = updateValues.id_login,
                usuario = updateValues.usuario
            };

            var state = dataBase.Entry(student).State;
            if (state == EntityState.Detached)
                dataBase.tbl_login.Attach(student);

            dataBase.tbl_login.Attach(student);
            dataBase.Entry(student).Property(x => x.usuario).IsModified = true;
            dataBase.SaveChanges();
        }
        // WORK IN PROGRESS, DO NOT TOUCH
    }
}             