using System;
using System.Collections.Generic;
using System.Text;


//Создать класс Phone в нём определить следующие элементы:
//1.Number - номер телефона, тип string.
//2.Model - модель телефона, тип string.
//3.Weight - масса телефона в граммах, тип double,
//при попытке записать в массу отрицательное число - записывать в weight 0.
//Для этих характеристик необходимо создать свойства.
//Для Model и Weight можно задавать значение только при создании объекта.
//4. Создать конструктор принимающий 3 параметра номер, модель и массу.
//5. Создать метод RecieveCall, который будет принимать в себя параметр string(имя звонящего) и ничего не возвращать.
//Этот метод должен просто выводить на консоль "Вам звонит <Имя звонящего>".
//В методе Main необходимо протестировать работу вашего класса. 


namespace Homework6
{
    internal class Phone
    {
        private string _number;
        private string _model;
        private double _weight;

        public Phone(string number, string model, double weight)
        {
            Number = number;
            Model = model;
            Weight = weight;
        }


    }
}
