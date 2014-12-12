using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVacina.Tudo
{
     [Table(Name="vacina")]
    public class Vacinacao
    {
       
       
            [Column(IsDbGenerated = true, IsPrimaryKey = true)]
            public int Id { get; set; }
            [Column(CanBeNull = false)]
            public String NomeVacina { get; set; }
            [Column(CanBeNull = false)]
            public String Data { get; set; }
            [Column(CanBeNull= false)]
            public int IdPets{ get; set; }

       
    }
}
