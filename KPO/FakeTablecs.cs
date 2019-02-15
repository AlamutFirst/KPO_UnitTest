using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO
{
    class FakeTablecs : ITable
    {
        public IEnumerable<Table> GetAll()
        {
            return new List<Table> { new Table { ime = "Bob", priimek = "Smith", naslov="Doma", Id=1 },
                new Table { ime = "loje", priimek = "Pišuka", naslov="Služba", Id=2 },
                new Table { ime = "Boris", priimek = "čižman", naslov="Internet", Id=3 },
                new Table { ime = "Peter", priimek = "Prevc", naslov="LJ", Id=4 }
            };
        }
    }
}
