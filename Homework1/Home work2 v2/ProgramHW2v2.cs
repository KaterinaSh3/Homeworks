using System;

namespace Home_work2_v2
{
    internal class Program
    {
        static void Main() //Считать из консоли два числа и вывести все числа между ними на консоль включительно V2(for)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            for (int i = number1; i <= number2; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
