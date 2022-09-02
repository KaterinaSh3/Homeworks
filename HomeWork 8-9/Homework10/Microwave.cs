using System;
using System.Collections.Generic;
using System.Text;
//1. Создать класс Microwave
//2. В том же файле в namespace объявить делегат NotifyWarmUpCompleted, который ничего не возвращает и принимает 
//    в качестве параметра string (название подогреваемого блюда).
//3. В классе Microwave объявить событие WarmUpCompleted, которое будет иметь в качестве обработчика ранее созданный делегат NotifyWarmUpCompleted.
//4. В классе Microwave объявить метод WarmUp, который ничего не возвращает и в качестве параметра 
//    принимает string (название подогреваемого блюда). Этот метод выводит на консоль "Подогреваю <название блюда>". 
//    И далее вызывает событие WarmUpCompleted, если оно не равно null.
namespace Homework10

{
    //делегат
    public delegate void NotifyWarmUpCompleted(string dish);

    public class Microwave
    {
        //событие
        public event NotifyWarmUpCompleted WarmUpCompleted;

        //метод
        public void WarmUp(string dish)
        {
            Console.WriteLine($"Подогреваю {dish}" );
            OnWarmUp(dish);
        }

        //вызов события
        protected virtual void OnWarmUp (string dish)
        {
            if(WarmUpCompleted != null)
            {
                WarmUpCompleted.Invoke(dish);
            }
        }

    }
}
