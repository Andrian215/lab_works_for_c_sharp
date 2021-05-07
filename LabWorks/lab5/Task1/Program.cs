using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = a;
            int i = 0;
            while (i < n)
            {

                sum *= a + i;
                if (n - i == 1)
                {
                    sum *= a + i - 1;
                }
                i++;
                i++;
            }
            Console.WriteLine(sum);


            Console.ReadLine();
        }

    }
}
