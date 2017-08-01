using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCvWebsite.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyCvWebsite.Controllers
{
    public class LoginController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(LoginSpecification loginInput)
        {
            if (!ModelState.IsValid)
            {
                return View(loginInput);
            }

            IndexLoginVM loggedIn = new IndexLoginVM { IsLoggedIn = true };
            //Ändra html i navbar?

            return RedirectToAction("Index", "Home",loginInput);
        }
    }
}
