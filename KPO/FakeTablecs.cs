using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO
{
    public class FakeTablecs : ITable
    {
        public List<Table> lista;

        public IEnumerable<Table> GetAll()
        {
            return lista;
        }
        public Table GetFirstItem()
        {
            var item = lista.OrderBy(r => r.ime).FirstOrDefault();
            return item;
            
        }
        public Table GetUserByName(string name)
        {
            return lista.Where(r => r.ime.Contains(name)).FirstOrDefault();
        }
        public Table GetUserByAddres(string address)
        {
            return lista.Where(r => r.naslov.Contains(address)).FirstOrDefault();
        }
        public Table GetUserByAddresAndName(string address, string name)
        {
            return lista.Where(r => r.naslov.Contains(address)&&r.ime.Contains(name)).FirstOrDefault();
        }
    }
}
