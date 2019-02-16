using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO
{
    public interface ITable
    {
        
        IEnumerable<Table> GetAll();
        Table GetFirstItem();
        Table GetUserByName(string Name);
        Table GetUserByAddres(string Addres);
    }
}
