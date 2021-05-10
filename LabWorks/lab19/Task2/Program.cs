using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName;
            Console.Write("FileName:");
            FileName = Console.ReadLine();
            StreamReader SR = new StreamReader(FileName);
            int n = System.IO.File.ReadAllLines(FileName).Length;

            int[] arr = new int[n];

            for (int i = 0; !SR.EndOfStream; i++)
            {
                arr[i] = Convert.ToInt32(SR.ReadLine());
            }

            for (int i = 0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            SR.Close();
            StreamWriter sw = new StreamWriter("NP.dat.txt");
            Console.Write("FilenamE:");
            string FileNamE = Console.ReadLine();
            StreamWriter SW = new StreamWriter(FileNamE);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    SW.WriteLine(arr[i]);
                else
                    sw.WriteLine(arr[i]);
            }

            SW.Close();
            sw.Close();
            Console.ReadLine();
        }
    }
}


