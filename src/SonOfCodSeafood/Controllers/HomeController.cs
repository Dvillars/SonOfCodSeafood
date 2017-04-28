using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCodSeafood.Modles;

namespace SonOfCodSeafood.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NewsLetter()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewsLetter(Reader reader)
        {
            db.Subscribers.Add(reader);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult List()
        {
            return View(db.Subscribers.ToList());
        }

    }
}
