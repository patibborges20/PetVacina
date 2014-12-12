using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVacina.Tudo
{
    [Table]
    public class Pets
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }
        [Column(CanBeNull=false)]
        public String NomePet { get; set; }
        [Column(CanBeNull = false)]
        public String Bicho { get; set; }
        [Column(CanBeNull = false)]
        public String Dono { get; set; }
    
        
    }
}
