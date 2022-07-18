using System;

namespace HomeWork2
{
    internal class Program
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = x; i > 1; i--)
            {
                factorial = factorial * i;
            }
            {
                Console.WriteLine(factorial);
            }

            Console.ReadKey();
        }
    }
}

