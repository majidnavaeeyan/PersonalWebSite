using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonalWebsite.Common;
using PersonalWebsite.Models;

namespace PersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //[Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("Contact")]
        [HttpPost]
        public async Task<IActionResult> Contact(string subject, string body , string name , string email)
        {
            string info = $"<br/><br/><br/> <div>Name : {name}</div>";
            info += $"<div>Email Address : {email}</div>";
            body += info;

            EmailUtility sender = new EmailUtility();
            await sender.SendEmailAsync("MajidNavaeeyan@gmail.com", subject, body);

            return Ok("success");
        }


        [Route("Blog")]
        public IActionResult Blog()
        {
            return View();
        }

        [Route("BlogPost")]
        public IActionResult BlogPost()
        {
            return View();
        }

        [Route("Portfolio")]
        public IActionResult Portfolio()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
