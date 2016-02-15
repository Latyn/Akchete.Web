using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Ak.ViewModels;
using Ak.Services;
using AK;
using Ak.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Ak.Controllers.Web{

    [Route("Event")]
    public class EventController : Controller
        {

        private WorldContext _context;

        public EventController(WorldContext context)
        {

        _context = context;

        }
        [HttpPost]
        public IActionResult Index(EventViewModel model)
        {
            return View(model);
        }
        [Route("Index")]
        public IActionResult Test()
        {
            return View();
        }
    }
    
}
