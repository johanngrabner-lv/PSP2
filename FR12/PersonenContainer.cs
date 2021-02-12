using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR12
{
    class PersonenContainer
    {
        public List<Person> Personen { get; set; }
        public PersonenContainer()
        {
            Personen = new List<Person>()
            {
                new Person(){PersonId=1,Vorname="Hans",Bild="Hans.jpg"},
                new Person(){PersonId=2,Vorname="Margret",Bild="Margret.jpg"}
            };
        }

        public Person AusgewaehltePerson { get; set; }
    }
}
