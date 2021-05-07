using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x=");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Задарна точнiсть=");
            int E = Convert.ToInt32(Console.ReadLine());
            double sum = 2;
            double p = (x - 1) / (x + 1);
            for (int i = 1; i < E; i++)
            {
                p = Math.Pow(p, 2 * i - 1);
                p *= 1 / (2 * i - 1);
                sum += p;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }


    }
}
