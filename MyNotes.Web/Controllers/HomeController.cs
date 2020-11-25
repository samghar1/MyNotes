using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;
using MyNotes.Web.Models;

namespace MyNotes.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Text()
        {
            ViewBag.hi =  "Hello, I'm just a plain text version!!";
            return View("Privacy");
        }

        public IActionResult Json()
        {
            var obj = new { Id = "1", Name = "Samir", Age = 30 };
            return Json(obj);
        }
        public IActionResult Samir(string name, int id) {


            return View("Samir",name);

        }

        [HttpPost]
        public IActionResult Contact(string name, int id) { 
            TempData["greetings"] = $"Thank you {name} for registering with us.";
            return RedirectToAction("ThankYou");
        }
        public IActionResult ThankYou() {

            string greetings = (string)TempData["greetings"];
            if (string.IsNullOrEmpty(greetings)) {

              return  RedirectToAction("Index");
            }
            return View("Thankyou", greetings);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
