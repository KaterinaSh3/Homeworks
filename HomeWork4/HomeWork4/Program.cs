using System;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int [] mass = new int[a];
            for (int i = 0; i < a; i++)
            {
                mass[i] = int.Parse(Console.ReadLine());
            }

        }
    }
}
