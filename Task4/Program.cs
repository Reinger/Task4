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
                    Console.WriteLine("Ошибка ввода. Необходимо ввести вещественное число");
                    Console.ReadLine();
                    Console.Clear();
                }

                if (k<=1)
                {
                    Console.WriteLine("Ошибка ввода. Слишком маленькое число");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (!ok);
            return k;
        }

        static double Func(double i, double s)
        {
            return 1 / (i * i);
        }

        static void Main(string[] args)
        {
            double e = ReadDouble();
            double s=0;
            double i = 1;

            do
            {
                s += Func(i, s);
                i++;
            } while (s>=e);

            Console.Clear();
            Console.WriteLine("I={0}", i);
            Console.WriteLine("S={0}", s);
            Console.ReadLine();
        }
    }
}
