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
using MyNotesLibrary.DAL;
using MyNotesLibrary.DAL.Context;

namespace MyNotes.Web.Controllers
{
    public class HomeController : Controller

    {  
        private readonly MyNotesContext _dbContext;
        public HomeController(MyNotesContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string addUser(string firstname, string lastname) {

            try
            {
                var myUser = new User { CreatedDate = DateTime.Now, DateOfBirth = DateTime.Now, Email = "samir.mghar@gmail.com", FirstName = "Samir", LastName = "Amghar" };
                _dbContext.Users.Add(myUser);
                _dbContext.SaveChanges();

                return "Changes have been saved.";
            }
            catch (Exception ex)
            {

                return ex.Message;
            } 
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
