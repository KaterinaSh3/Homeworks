using System;

namespace HomeWork3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("----------------------------");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            char oper = char.Parse(Console.ReadLine());
            int c;
            switch (char)
            {
            
                case 1:
                        {
                        a = Console.ReadLine();
                        b = Console.ReadLine();
                        c = a + b;
                        Console.WriteLine(c);
                        break;
                        }
                case 2:
                        {
                        a = Console.ReadLine();
                        b = Console.ReadLine();
                        c = a - b;
                        Console.WriteLine(c);
                        break;
                        }
                case 3:
                        {
                        a = Console.ReadLine();
                        b = Console.ReadLine();
                        c = a * b;
                        Console.WriteLine(c);
                        break;
                        }
                case 4:
                        {
                        a = Console.ReadLine();
                        b = Console.ReadLine();
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
