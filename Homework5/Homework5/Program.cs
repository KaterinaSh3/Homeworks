using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> names = new Dictionary<string, int>
        {
            {"Pavel",5 },
            {"Lisa", 3 },
            {"Alena", 10 },
            {"Misha", 8 },
            {"Sasha", 6 }
        };
            //foreach (KeyValuePair<string, int> name in names)
            //{
            //    Console.WriteLine($"key:{name.Key}-value:{name.Value}");
            //}
            Console.WriteLine("------------------------");
            Console.WriteLine(@"Please, select the option:
Enter 1 for Add mark
Ener 2 for Change mark
Ener 3 for Delete mark
Ener 4 for see Students
Ener 5 for see Average mark
Ener 6 for see Max mark
Ener 7 for see Best marks
Ener 8 for see Worse marks
Ener 9 for Exit");
            string response = Console.ReadLine();
            menu studend = (menu)Enum.Parse(typeof(menu), response);
            menu student = Enum.Parse<menu>(response);
            string[] name = Enum.GetNames(typeof(menu));
            int intResponse = int.Parse(response);
            menu enteredMenu = (menu)intResponse;
            switch (enteredMenu)
            {
                case menu.Addmark: //1
                    {
                        Console.WriteLine("Enter student name");
                        string input = Console.ReadLine();
                        if (names.ContainsKey(input))
                        {
                            Console.WriteLine("student in base");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Add mark");
                            int mark = int.Parse(Console.ReadLine());
                            names.Add(input, mark);
                        }
                        break;
                    }
                case menu.Changemark://2
                    {
                        string input = Console.ReadLine();
                        if (names.ContainsKey(input))
                        {
                            Console.WriteLine("Change mark");
                            int mark = int.Parse(Console.ReadLine());
                            names[input] = mark;
                        }
                        else
                        {
                            Console.WriteLine("student not found");
                            return;
                        }
                    }
                    break;
                case menu.Deletemark://3
                    {
                        string input = Console.ReadLine();
                        if (names.ContainsKey(input))
                        {
                            Console.WriteLine("Delete mark");
                            int mark = int.Parse(Console.ReadLine());
                            names.Remove(input);
                        }
                        else
                        {
                            Console.WriteLine("student not found");
                            return;
                        }
                    }
                    break;
                case menu.Students://4
                    {
                        foreach (KeyValuePair<string, int> studentName in names)
                        {
                            Console.WriteLine($"key:{studentName.Key}-value:{studentName.Value}");
                        }
                    }
                    break;
                case menu.Average://5
                    {
                        int summ = 0;
                        foreach (var students in names)
                        {
                            summ += students.Value;
                        }
                        Console.WriteLine($"Average Mark: {summ / names.Count}");
                    }
                    break;
                case menu.Maxmark://6
                    {
                        int maxValue = (from marks in names select marks.Value).Max();
                        Console.WriteLine($"Max Mark is: {maxValue}");
                    }
                    break;
                case menu.Beststudents://7
                    {
                        foreach (KeyValuePair<string, int> mark in names)
                        {
                            if (mark.Value >=  8)
                            {
                                Console.WriteLine($"key:{mark.Key}-value:{mark.Value}");
                            }
                        }
                    }
                    break;
                case menu.Worsestudents://8
                    {
                        foreach (KeyValuePair<string, int> mark in names)
                        {
                            if (mark.Value < 4)
                            {
                                Console.WriteLine($"key:{mark.Key}-value:{mark.Value}");
                            }
                        }
                    }
                    break;
                case menu.Close://9
                    {
                        Environment.Exit(0);   //не работает
                    }
                    break;
            }
        }
    }
}

