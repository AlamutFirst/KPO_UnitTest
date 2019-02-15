using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO
{
    class Program
    {
        static void Main(string[] args)
        {
            Math mt = new Math();
            var ss =mt.SumOfN(10);
            Console.WriteLine(ss);
            var users = new Users(new TableData());

            var result = users.GetAll();

        }
    }
}
