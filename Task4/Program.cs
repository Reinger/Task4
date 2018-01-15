using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static double ReadDouble()
        {
            double k;
            bool ok;
            do
            {
                Console.Write("Введите е: ");
                ok = Double.TryParse(Console.ReadLine(), out k);
                if (!ok)
                {
                    Console.WriteLine("Ошибка ввода");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (!ok);
            return k;
        }

        static void Main(string[] args)
        {
            double e = ReadDouble();
        }
    }
}
