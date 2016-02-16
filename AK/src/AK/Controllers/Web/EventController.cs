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


    public class EventController : Controller
        {

        private WorldContext _context;

        public EventController(WorldContext context)
        {

        _context = context;

        }
        [HttpPost]
        public IActionResult Event(EventViewModel model)
        {
            return View(model);
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListEvents()
        {
            IEnumerable<Event> newList = _context.Events.ToList();
            return View(newList); 
        }
    }
    
}
