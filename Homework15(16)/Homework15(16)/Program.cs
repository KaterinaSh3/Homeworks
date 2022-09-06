using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//2)Создать класс DogViewModel, который будет содержать 4 автосвоцства кличка, имя хозяина, возраст собаки и массу. Конструктор не создавайте.
//3) Создать контроллер в котором создать Action VetApplication(пометить его атрибутом HttpGet) ,
//  который принимает 0 параметров и возвращает IActionResult. Внутри экшена просто вернуть View().
//4)Создать папку название, которой должно совпадать с названием контроллера(без слова контроллер) в Views.
//  И внутри папки создать вью VetApplication.cshtml.В самом вью нужно создать форму. В этой форме 4 инпута для каждого из полей и кнопку.
//  Не забывайте про @model в самом начале файла и привязать поля к инпутам c помощью asp-for и у кнопки type submit.
//5)Создать в ранее созданном контроллере еще один action VetApplication(пометить его атрибутом HttpPost),
//  который в качестве параметра принимает объект DogViewModel и возвращает IActionResult.
//  Внутри просто выведите все поля этого объекта на консоль и в ретурне вызовите метод VetApplication без параметров созданный ранее.
//6)Добавьте в метод VetApplication без параметров перед ретурном ModelState.Clear();
//7)Во вью _Layout(оно находится в папочке Shared) добавьте еще один пункт меню который будет ссылаться на ваш контроллер и на экшен VetApplication.
//  Для этого скопируйте сам тэг li и его содержимое для пункта Privacy и вставьте после него.
//  И в этом li поменяйте название контроллера, экшена на ваши.


namespace Homework15_16_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
