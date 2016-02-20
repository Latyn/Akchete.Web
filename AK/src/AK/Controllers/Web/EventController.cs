using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Ak.ViewModels;
using Ak.Services;
using AK;
using Ak.Models;
using AutoMapper;
using System.Collections;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Ak.Controllers.Web{


    public class EventController : Controller
        {

        private WorldContext _context;
        //private MapperConfiguration _map;

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
            #region Autommaper 4.1.1
            ICollection<EventViewModel> newList = Mapper.Map<ICollection<Event>, ICollection<EventViewModel>>(_context.Events.ToList());
            #endregion



            //var mapper = _map.CreateMapper();
            //ICollection<EventViewModel> newList = mapper.Map<ICollection<Event>, ICollection<EventViewModel>>(_context.Events.ToList());

            //IEnumerable<Event> newList = _context.Events.ToList();
            return View(newList); 
        }
    }
    
}
