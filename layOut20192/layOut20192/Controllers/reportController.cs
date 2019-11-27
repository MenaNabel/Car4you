using layOut20192.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace layOut20192.Controllers
{
    public class reportController : Controller
    {
        // GET: report
        Sno7yEntities context = new Sno7yEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult cars()
        {
            return View(context.cars.ToList());
        }
    }
}