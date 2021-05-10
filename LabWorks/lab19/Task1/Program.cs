using System;
using System.IO;
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
            string FileName;
            Console.Write("FileName=");
            FileName = Console.ReadLine();
            StreamReader SR = new StreamReader(FileName);

            double max = double.MinValue;
            while (!SR.EndOfStream)
            {
                double c = double.Parse(SR.ReadLine());
                if (c > max)
                {
                    max = c;
                }
            }
            Console.WriteLine("max=" + max);
            SR.Close();

            Console.ReadLine();
        }
    }
}