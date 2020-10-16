using System;
using System.Linq;
using System.Threading;

namespace faktorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число и мы рассчитаем факториал.");
            int fact = Convert.ToInt32(Console.ReadLine());
            ulong factorial = 1;
            for (int i = fact; i != 0; i--)
            {
                factorial = factorial * (ulong)i;
            }
            Console.WriteLine("\u2552" + new string('\u2550', factorial.ToString().Length + 2) + "\u2555");
            Console.WriteLine("\u2502 " + factorial + " \u2502");
            Console.WriteLine("\u2558" + new string('\u2550', factorial.ToString().Length + 2) + "\u255B");
        }
	}
}
