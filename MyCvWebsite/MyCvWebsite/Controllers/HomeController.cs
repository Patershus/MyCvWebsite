using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCvWebsite.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyCvWebsite.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index(LoginSpecification loginInput)
        {
            IndexLoginVM loggedIn = new IndexLoginVM();
            if (loginInput.Username=="Admin" && loginInput.Password=="123")
            {
                loggedIn.IsLoggedIn = true ;
            }
            else
                 loggedIn.IsLoggedIn = false;

            return View(loggedIn);
        }

        [HttpPost]
        public IActionResult Index(ContactFormMessage message)
        {


            return RedirectToAction(nameof(View));
        }
    }
}
