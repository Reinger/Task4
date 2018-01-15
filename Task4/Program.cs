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
                else if (k<=0 || k>=1)
                {
                    Console.WriteLine("Ошибка ввода. Выход за границы");
                    Console.ReadLine();
                    Console.Clear();
                    ok = false;
                }
            } while (!ok);
            return k;
        }

        static double Func(double i)
        {
            return 1 / (i * i);
        }

        static void Main(string[] args)
        {
            double e = ReadDouble();
            double s=0;
            double i = 1;

            while (Func(i) >= e)
            {
                s+= Func(i);
                i++;
            } 

            Console.Clear();
            Console.WriteLine("I={0}", --i);
            Console.WriteLine("S={0}", s);
            Console.ReadLine();
        }
    }
}
