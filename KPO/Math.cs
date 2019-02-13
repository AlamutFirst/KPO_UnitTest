using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO
{
    public class Math
    {
        public Math() { }

        public int SumOfN(int n)
        {
            int i;
            int sum = 10; 
            
            for (i = 0; i <= n; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
