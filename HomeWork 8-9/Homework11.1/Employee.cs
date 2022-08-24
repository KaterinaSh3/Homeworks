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
        internal int Age
        {
            get;
            set;
        }

        internal string Name
        {
            get;
            set;
        }

        internal double Salary
        {
            get;
            set;
        }



    }
}
