using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            double n = Convert.ToDouble(Console.ReadLine());
            int sum = 0;
            while (n > 1)
            {
                n = n / 10;
                sum++;
            }

            Console.WriteLine($"Кiлькiсть цифр в числi={sum}");
            Console.ReadLine();
        }


    }
}