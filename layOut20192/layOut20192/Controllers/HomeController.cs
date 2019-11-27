using layOut20192.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace layOut20192.Controllers
{
    public class HomeController : Controller
    {
        Sno7yEntities context = new Sno7yEntities();
        public ActionResult Index()
        {
            return View("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //[Exception]
        public ActionResult user()
        {
            return View("../clint/logIn");
        }
        public ActionResult checkUser(string email,string password)
        {
            if(context.clients.FirstOrDefault(c => c.email == email) != null)
            {
                if (context.clients.FirstOrDefault(c => c.email == email).password == password)
                    return View("../clint/carOrPackage");
                else
                    return View("../clint/logIn");
            }
            else if(context.setting_agency.FirstOrDefault(a => a.email == email) != null)
            {
                if (context.setting_agency.FirstOrDefault(a => a.email == email).password == password)
                    return View("../clint/notUser");
                else
                    return View("../clint/logIn");
            }
            else
                return View("../clint/logIn");
        }
        public ActionResult test()
        {
            return View();
        }
    }
    
}