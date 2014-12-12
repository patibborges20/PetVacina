using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVacina.Tudo
{
    class PetsDB
    {
        public static void Save(Pets pPets)
        {
            DataBase db = getDataBase();
            db.Pets.InsertOnSubmit(pPets);
            db.SubmitChanges();
        }

        public static void Editar(Pets P)
        {
            DataBase db = getDataBase();

            Pets Petsitem = (from r in db.Pets where r.Id == P.Id select r).First();

            Petsitem.NomePet = P.NomePet;
            Petsitem.Bicho = P.Bicho;
            Petsitem.Dono = P.Dono;

            db.SubmitChanges();
        }

        public static void Delete(Pets pPets)
        {
            DataBase db = getDataBase();
            var consulta = from d in db.Pets where d.Id == pPets.Id select d;
            db.Pets.DeleteOnSubmit(consulta.ToList()[0]);
            db.SubmitChanges();
        }

        public static List<Pets> Get()
        {
            DataBase db = getDataBase();
            var consulta = from d in db.Pets select d;
            List<Pets> listaPets = new List<Pets>(consulta.AsQueryable());
            return listaPets;
        }

        public static DataBase getDataBase()
        {
            DataBase db = new DataBase();
            if (db.DatabaseExists()==false)
            {
                db.CreateDatabase();
            }

            return db;
        }

    }
}
