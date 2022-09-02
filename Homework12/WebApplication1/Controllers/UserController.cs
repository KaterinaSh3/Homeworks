using Microsoft.AspNetCore.Mvc;
using WebApplication1;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();
            user.Age = 18;
            user.Name = "Alice";
            return View(user);
        }
    }
}
