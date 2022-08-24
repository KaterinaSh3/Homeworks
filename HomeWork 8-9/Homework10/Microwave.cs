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
    internal delegate void NotifyWarmUpCompleted(string dish);

    public class Microwave
    {
        public event NotifyWarmUpCompleted WarmUpCompleted;

        public string WarmUp(string dish)
        {
            Console.WriteLine($"Подогреваю" < dish >);
        }

        protected virtual string WarmUp
        {
            if(WarmUpCompleted != null)
            {
                WarmUpCompleted.Invoke();
            }
    }

    }



}
    
}
