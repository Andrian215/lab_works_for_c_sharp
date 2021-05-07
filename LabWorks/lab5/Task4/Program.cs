using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x0 = 1;
            for (int i = 0; i <= 10; i++)
            {
                x0 = x0 + 2 * i;
            }
            Console.WriteLine("x10={0}", x0);
            Console.ReadLine();
        }


    }
}