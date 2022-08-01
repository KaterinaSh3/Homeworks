using System;

namespace HomeWork3numbers
{
    internal class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > 100 && b > 100)
            { 
                Console.WriteLine($"Each of the numbers A and B is greater than 100"); 
            }
            if (a % 2 == 0 ^ b % 2 == 0)
            {
                Console.WriteLine("Only one of the numbers A and B is even"); //как нписать только одно из?  попробовать переписать от нечетного
            }
            if (a > 0 || b > 0)
            {
                Console.WriteLine($"One of the numbers A and B is positive");
            }
            if (a % 3 == 0 && b % 3 == 0 && c % 3 == 0)
            {
                Console.WriteLine($"Each of the numbers A, B, C is a multiple of three");
            }
            if (a < 50 | b < 50 | c < 50)
            {
                Console.WriteLine($"Only one of the numbers A, B, C is less than 50"); //как написать только одно из?
            }
            if (a < 0 | b < 0 | c < 0)
            {
                Console.WriteLine($"One of the numbers A, B, C is negative");
            }

        Console.ReadKey();
        }
    }
}
