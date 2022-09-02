using Microsoft.AspNetCore.Mvc;

//3) Создать контроллер в котором создать Action Index, который принимает 0 параметров и возвращает IActionResult.
//Внутри экшена создать объект книги, задать свойства значения и далее вернуть View передав во вью объект книг

namespace Homework14.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
