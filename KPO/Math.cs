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
            int sum = 0; 
            
            for (i = 0; i <= n; i++)
            {
                sum = sum + i;
            }

            return sum;
        }

        public int SumOfAvgArray(int[] arr)
        {
            int sum = 0;

            int average = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            average = sum / arr.Length;

            return average;
        }

        public List<double> QuadraticEquation(double a, double b, double c)
        {
            int m;
            double r1, r2, d1;
            d1 = b * b - 4 * a * c;
            if (a == 0.0)
                m = 1;
            else if (d1 > 0.0)
                m = 2;
            else if (d1 == 0.0)
                m = 3;
            else
                m = 4;
            List<double> lista = new List<double>();
            switch (m)
            {
                case 1:
                    Console.WriteLine(@"\n Not a Quadratic equation, 
                                          Linear equation");
                    lista = null;
                    break;
                case 2:
                    lista.Add((-b + System.Math.Sqrt(d1)) / (2 * a));
                    lista.Add((-b - System.Math.Sqrt(d1)) / (2 * a));
                    break;
                case 3:
                    r1 = r2 = (-b) / (2 * a);
                    lista.Add((-b + System.Math.Sqrt(d1)) / (2 * a));
                    lista.Add((-b - System.Math.Sqrt(d1)) / (2 * a));
                    break;
                case 4:
                    Console.WriteLine("\n Roots are Imaginary");
                    lista.Add((-b) / (2 * a));
                    lista.Add(System.Math.Sqrt(-d1) / (2 * a));
                    break;
            }
            return lista;
        }
    }
}
