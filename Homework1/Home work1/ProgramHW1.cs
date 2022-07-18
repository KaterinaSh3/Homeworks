using System;

namespace Home_work1
{
    internal class Program
    {
        static void Main()
        {
            int i = int.Parse(Console.ReadLine());  // Считать число из консоли и вывести на консоль число противоположного знака
            Console.WriteLine((-1) * i);    
            Console.ReadKey();
        }
    }

}