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
            ArithProgression ap = new ArithProgression();
            GeomProgression gp = new GeomProgression();
            Console.WriteLine("Введите первый член прогрессии");
            int a = Convert.ToInt32(Console.ReadLine());
            ap.SetStart(a);
            gp.SetStart(a);
            Console.WriteLine("Введите шаг прогрессии");
            ap.D = Convert.ToInt32(Console.ReadLine());
            gp.Q = ap.D;
            Console.WriteLine("Пять следующих членов арифметической прогрессии:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{ap.GetNext()} ");
            }
            ap.Reset();
            Console.WriteLine();
            Console.WriteLine("Пять следующих членов геометрической прогрессии прогрессии:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{gp.GetNext()} ");
            }
            gp.Reset();
            Console.ReadKey();


        }
    }
}
