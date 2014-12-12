using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace PetVacina.Tudo
{
    class VacinacaoDB
    {
      
        public static void Save(Vacinacao pvacina)
        {
            DataBaseVacina db = getVacina();
            db.vacina.InsertOnSubmit(pvacina);
            db.SubmitChanges();
        }

        public static void Editar(Vacinacao V)
        {
            DataBaseVacina db = getVacina();

            Vacinacao VacinaPet = (from r in db.vacina where r.Id == V.Id select r).First();

            VacinaPet.NomeVacina = V.NomeVacina;
            VacinaPet.Data = V.Data;
            db.SubmitChanges();
        }

        public static void Delete(Vacinacao pVacina)
        {
            DataBaseVacina db = getVacina();
            var consulta = from d in db.vacina where d.Id == pVacina.Id select d;
            db.vacina.DeleteOnSubmit(consulta.ToList()[0]);
            db.SubmitChanges();
        }

        public static List<Vacinacao> Get( int idpet)
        {
                DataBaseVacina db = getVacina();
                var consulta = from r in db.vacina where r.IdPets == idpet select r;
               // var consulta = from r in db.vacina select r;
                List<Vacinacao> ListaVacina = new List<Vacinacao>(consulta.AsQueryable());
                return ListaVacina;
        }
        public static DataBaseVacina getVacina()
        {
            DataBaseVacina db = new DataBaseVacina();
            if (db.DatabaseExists()==false)
            {
                db.CreateDatabase();
            }
              return db;
        }
    }
}
