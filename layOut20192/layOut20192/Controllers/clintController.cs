using layOut20192.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using layOut20192.ViewModels;

namespace layOut20192.Controllers
{
    
    public class clintController : Controller
    {
        // GET: clint
        Sno7yEntities context = new Sno7yEntities();
        public bool testReservation(reservation_car RVC)
        {
            if (RVC.start_Date >= DateTime.Today && RVC.start_Date <= RVC.end_date)
            {
                int query = (
                from r in context.reservation_car
                where r.car_ID == RVC.car_ID && (((r.start_Date <= RVC.start_Date) && (r.end_date >= RVC.start_Date)) || ((r.start_Date <= RVC.end_date) && (r.end_date >= RVC.end_date)) || ((r.start_Date >= RVC.start_Date) && (r.end_date <= RVC.end_date)) || ((r.start_Date >= RVC.start_Date && r.start_Date <= RVC.end_date) && (r.end_date >= RVC.start_Date && r.end_date <= RVC.end_date)))
                select context.reservation_car.Count()
                ).Count();
                if (query == 0)
                    return true;
                else
                    return false;
            }
            else
                return false;


        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult logIn()
        {
            return View();
        }
        public ActionResult register()
        {
            return View();
        }
        public ActionResult addClient(client newClient)
        {
            client c = new client() { ssna = newClient.ssna, name = newClient.name, age = newClient.age };
            context.clients.Add(c);
            context.SaveChanges();
            return View("logIn");
        }

        public ActionResult book()
        {
            return View(context.cars.ToList());
        }

        public ActionResult okBook(int ID)
        {
            reserveCarViewModel RCVM = new reserveCarViewModel();
            car c = context.cars.FirstOrDefault(ca=>ca.CID==ID);
            List<type_client> typeClient = context.type_client.ToList();
            RCVM.carAvalible = c;
            RCVM.typeClient = typeClient;
            return View(RCVM);
        }
        public ActionResult realyBook(reservation_car RVC,  int ID)
        {
            int x = RVC.end_date.Subtract(RVC.start_Date).Days;
            if (testReservation(RVC))
            {

                reservation_car newRVC = new reservation_car() { car_ID = ID, client_ID = RVC.client_ID, type_reservation = RVC.type_reservation, start_Date = RVC.start_Date, end_date = RVC.end_date, duration = RVC.end_date.Subtract(RVC.start_Date).Days };
                if (newRVC.type_reservation == "business")
                    newRVC.price = (newRVC.duration * context.cars.FirstOrDefault(c => c.CID == ID).price) + ((context.cars.FirstOrDefault(c => c.CID == ID).price) * 10 / 100);
                else if (newRVC.type_reservation == "wedding party")
                    newRVC.price = (newRVC.duration * context.cars.FirstOrDefault(c => c.CID == ID).price) + ((context.cars.FirstOrDefault(c => c.CID == ID).price) * 25 / 100);
                else
                    newRVC.price = (newRVC.duration * context.cars.FirstOrDefault(c => c.CID == ID).price);
                context.reservation_car.Add(newRVC);
                context.SaveChanges();
                return View(newRVC.price);
            }
            else
                return View("book");
        }
        public ActionResult package()
        {
            return View(context.packages.ToList());
        }
        public ActionResult notUser()
        {
            return View();
        }
        public ActionResult clientInfo()
        {
            return View(context.cars.ToList());
        }
        public ActionResult national()
        {
            return View();
        }
        public ActionResult add()
        {
            return View();
        }
       
        public ActionResult reallyAdd()
        {
            return View();
        }
        public ActionResult addPackage()
        {
            return View();
        }
        public ActionResult reallyAddPackage()
        {
            return View();
        }
       
        public ActionResult ReadMore()
        {
            return View();
        }
        public ActionResult carOrPackage()
        {
            return View();
        }
        public ActionResult toReservationPackage()
        {
            reservePackageViewModel RPVM = new reservePackageViewModel();
            List<package> p = context.packages.ToList();
            List<type_client> typeClient = context.type_client.ToList();
            RPVM.packagesAvalible = p;
            RPVM.typeClient = typeClient;
            return View(RPVM);
        }

        public ActionResult reallyBookPackage()
        {
            return View();
        }
    }
}