using APP1.Data;
using Microsoft.AspNetCore.Mvc;

namespace APP1.Controllers
{
    public class UsersController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public IActionResult Index()
        {
            var products = context.Users.ToList();
            return View("Index",products);
        }


    }
}
