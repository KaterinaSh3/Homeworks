using System;

//1. Создать класс Microwave
//2. В том же файле в namespace объявить делегат NotifyWarmUpCompleted, который ничего не возвращает и принимает 
//    в качестве параметра string (название подогреваемого блюда).
//3. В классе Microwave объявить событие WarmUpCompleted, которое будет иметь в качестве обработчика ранее созданный делегат NotifyWarmUpCompleted.
//4. В классе Microwave объявить метод WarmUp, который ничего не возвращает и в качестве параметра 
//    принимает string (название подогреваемого блюда). Этот метод выводит на консоль "Подогреваю <название блюда>". 
//    И далее вызывает событие WarmUpCompleted, если оно не равно null.
//5. В классе Program(там где у вас main) создать статический метод WarmUpCompletedHandler, который будет вызываться, 
//    когда будет срабатывать событие WarmUpCompleted, он должен иметь сигнатуру NotifyWarmUpCompleted, и будет выводить на консоль 
//    "Ваша еда готова: <название блюда>". 
//6. В Main необходимо протестировать работу класса Microwave и его события(Создайте объект класса microwave, 
//    подпишитесь на событие WarmUpCompleted(в качестве обработчика WarmUpCompletedHandler) и вызовите метод WarmUp.

namespace Homework10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


    }
}
