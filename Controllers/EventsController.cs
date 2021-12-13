using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        static private List<string> Events = new List<string>();
        [HttpGet]
        public IActionResult Index()
        {
            /*Events.Add("Strange Loop");
            Events.Add("Grace Hopper");
            Events.Add("Code Event");*/

            ViewBag.events = Events;

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Events/Add")]
        public IActionResult NewEvent(string name)
        {
            Events.Add(name);

            return Redirect("/Events");
        }
    }
}
