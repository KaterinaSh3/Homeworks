using System;

namespace Wome_work2
{
    internal class Program
    {
       
        static void Main()  //Считать из консоли два числа и вывести все числа между ними на консоль включительно
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int summ = a;   //включая а, если а+1, то а включать не будет
                        
            while (summ <= b)
            {
                Console.WriteLine(summ);
                a++;
                summ = a + 1;
            }
            Console.ReadLine();
                     

        }
    }
}
