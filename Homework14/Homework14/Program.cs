using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//1)Создать проект MVC, подобно тому как мы это делали в классе.
//2)Создать класс Book, который будет содержать 3 автосвоцства Название книги, Автор книги и количество страниц.
//  По желанию можно создать конструктор. 
//3) Создать контроллер в котором создать Action Index, который принимает 0 параметров и возвращает IActionResult.
//  Внутри экшена создать объект книги, задать свойства значения и далее вернуть View передав во вью объект книги.
//4)Создать папку название, которой должно совпадать с названием контроллера(без слова контроллер).
//  И внутри папки создать вью Index.cshtml. В самом вью нужно вывести название книги, автора и количество страниц.


namespace Homework14
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
