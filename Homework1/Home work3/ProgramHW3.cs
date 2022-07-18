using System;

namespace CodeSamplesFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int summ = 0;
            int j = 100 * b + c;
            for (int i = 0; i < a - 1; i++)
            {
                summ = summ + j;
            }

            summ = summ - c;
            Console.WriteLine(summ);
            Console.ReadKey();

        }
    }
}
