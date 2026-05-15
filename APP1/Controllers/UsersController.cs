using APP1.Data;
using APP1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public ViewResult Create()
        {
            return View("Create");
        }
        public ViewResult Store(User request) {
            context.Users.Add(request);
            context.SaveChanges();
            return View("Create");


        }



    }
}
