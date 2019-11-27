using layOut20192.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace layOut20192.Controllers
{
    public class adminController : Controller
    {
        // GET: admin
        Sno7yEntities context = new Sno7yEntities();
        [Authorize]
        public ActionResult Index()
        {
            return View("../clint/notUser");
        }
        public ActionResult newCar()
        {
            return View("../clint/Add");
           // return View();
        }
        [HttpPost]
        public ActionResult addCar(car c)
        {
            if (ModelState.IsValid)
            {
                car newCar = new car() { num = c.num, price = c.price, type_car = c.type_car, num_seats = c.num_seats, col = c.col, pick = c.pick, available = c.available, air_conditioning = c.air_conditioning };
                context.cars.Add(newCar);
                context.SaveChanges();
                return View("../clint/reallyAdd");

            }
            else
                return View("../clint/Add");
        }
        public ActionResult ToEdit()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {//view Form Display Student Data
            car c = context.cars.FirstOrDefault(s => s.CID == ID);
            return View(c);
        }

        [HttpPost]
        public ActionResult SEdit(int ID, car newCar)
        {//save data from client to database
            try
            {
                car oldCar = context.cars.FirstOrDefault(s => s.CID == ID);
                oldCar.price = newCar.price;
                context.SaveChanges();
                return View();
            }
            catch
            {
                return View("Edit", newCar);
            }

        }
    }
}