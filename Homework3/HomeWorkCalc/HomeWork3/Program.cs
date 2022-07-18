using System;

namespace HomeWork3
{
    internal class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c;
            char oper = char.Parse(Console.ReadLine());
            switch(oper)
            { 
                case '+':
                    {
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        c = a + b;
                        Console.WriteLine(c);
                        break;
                        }
                case '-':
                        {
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        c = a - b;
                        Console.WriteLine(c);
                        break;
                        }
                case '*':
                        {
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        c = a * b;
                        Console.WriteLine(c);
                        break;
                        }
                case '/':
                        {
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
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
