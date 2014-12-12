using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVacina.Tudo
{
    class DataBase:DataContext
    {

        static String str="data source = 'isostore:petVacinas.sdf'";


         public DataBase() : base (str) 
        {

        }

        public Table<Pets>Pets
        {
            get
            {
                return GetTable<Pets>();
            }
        }

            
        
    }
}
