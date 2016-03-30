using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelValidation.Models;
using NLog;

namespace ModelValidation.Controllers
{
    public class HomeController : Controller
    {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();
        public ViewResult MakeBooking()
        {
            return View(new Appointment {Date = DateTime.Now});
        }
        [HttpPost]
        public ViewResult MakeBooking(Appointment appt)
        {
            if (ModelState.IsValid) //Server 端驗證
            {
                _logger.Debug($"ModelState.IsValid = {ModelState.IsValid}");
                return View("Completed", appt);
            }
            else
            {
                return View();
            }
            //return View("Completed", appt);
        }

        public ViewResult MakePerson()
        {
            return View(new MakePersonViewModel {PhoneNumber = "09123456"});
        }
        [HttpPost]
        public ViewResult MakePerson(MakePersonViewModel person)
        {
            if (ModelState.IsValid) //Server 端驗證
            {
                return View("CompletedPerson", person);
            }
            else
            {
                return View();
            }
        }
        public ActionResult Index()
        {
            //return View();
            return RedirectToAction("MakePerson");
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
    }
}