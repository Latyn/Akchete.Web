using System;
using Microsoft.AspNet.Mvc;
using Ak.ViewModels;
using Ak.Services;
using AK;
using Ak.Models;
using System.Linq;

namespace Ak.Controllers.Web
{
    public  class AppController : Controller 
    {
        private ImailService _mailService;
        private WorldContext _context;

        public AppController(ImailService service, WorldContext context )
        {
            _mailService = service;
            _context = context;
        }

        public IActionResult Index()
        {
            var trips = _context.Events.OrderBy(m=> m.Name).ToList();
            return View(trips);
        }
        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                var email = Startup.Configuration["AppSettings:SiteEmailAddress"];

                if (string.IsNullOrWhiteSpace(email))
                {
                    ModelState.AddModelError("", "Could not sent email");
                }

               if( _mailService.sendMail
                    (
                    email,
                    email,
                    $"Contact Page From {model.Name}({model.Email})",
                     model.Message))
                {
                    ModelState.Clear();
                    ViewBag.Message = "Message has been sent, Thanks!";
                }
            }

            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Event()
        {
            return View();
        }
    }
}