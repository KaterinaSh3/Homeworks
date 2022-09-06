using Homework15_16_.Models;
using Microsoft.AspNetCore.Mvc;
using System;

//3) Создать контроллер в котором создать Action VetApplication(пометить его атрибутом HttpGet) ,
//  который принимает 0 параметров и возвращает IActionResult. Внутри экшена просто вернуть View().

//5)Создать в ранее созданном контроллере еще один action VetApplication(пометить его атрибутом HttpPost),
//  который в качестве параметра принимает объект DogViewModel и возвращает IActionResult.
//  Внутри просто выведите все поля этого объекта на консоль и в ретурне вызовите метод VetApplication без параметров созданный ранее.

//6)Добавьте в метод VetApplication без параметров перед ретурном ModelState.Clear();
namespace Homework15_16_.Controllers
{
    public class DogController : Controller
    {
        //3, 6
        [HttpGet]
        public IActionResult VetApplication()
        {
            ModelState.Clear();
            return View();
        }
        //5
        [HttpPost]
        public IActionResult VetApplication(DogViewModel dog)
        {
            Console.WriteLine($"Dog: {dog.Name}, Owner: {dog.Owner}, Age: {dog.Age}, Weight: {dog.Weight}");
            return VetApplication();


        }





    }

}
