using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVacina.Tudo
{
  public  class DataBaseVacina:DataContext

    {
         public static String str="data source = 'isostore:vacina.sdf'";

         public DataBaseVacina() : base (str) 
        {

        }

        public Table<Vacinacao> vacina
        {
            get
            {
                return GetTable<Vacinacao>();
            }
        }

    }
}
