using System;
using System.Collections.Generic;
using System.Text;
//Домашнее задание 11(Исключения)
//1) Создать класс  Employee
//2) В классе Employee создать свойства age(положительное число, большее или равное 18), name(строка, не должна быть пустой или null, 
//   а также её длина должна быть меньше 100),salary(дробное положительное число).При попытке изменения значения этих свойств 
//    необходимо проверять данные на корректность и в случае невалидных данных необходимо выкидывать исключения(ArgumentException, ArgumentNullException)
namespace Homework11._1
{
    internal class Employee
    {
        private readonly int age;

        //положительное число, большее или равное 18. нужно создать поле _age и дальше по примеру из шпаргалки, дописать return _age. в сетте написать =value

        private int _age;

        public Employee(int age, string name, double salary)
        {
            Age = age;
            Name = name;
            Salary = salary;
        } 
        
           

        public int Age
        {
            get
            {
                return -age;
            }
            set
            {

                if (value >= 18)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Wait your 18");
                }
            }
        }


        //строка, не должна быть пустой или null, длина до 100
        internal string Name    
        {
            get;
            set;
        }

        //дробное положительное число
        internal double Salary
        {
            get;
            set;
        }



    }
}
