using System;

namespace HomeWork3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Your Simple Calculator");
            Console.WriteLine("----------------------------");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c;
            char oper = char.Parse(Console.ReadLine());
            switch (oper)
            {
                case '+':
                    {
                        c = a + b;
                        Console.WriteLine(c);
                        break;
                    }
                case '-':
                    {
                        c = a - b;
                        Console.WriteLine(c);
                        break;
                    }
                case '*':
                    {
                        c = a * b;
                        Console.WriteLine(c);
                        break;
                    }
                case '/':
                    {
                        c = a / b;
                        Console.WriteLine(c);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Not valid command");
                        break;
                    }
            }
            Console.ReadKey();
        }

    }
}
