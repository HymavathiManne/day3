using practice2_Day3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace practice2_Day3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Display()
        {
            Empdept ed = new Empdept { Firstname = "Hyma", Lastname = "Manne", Deptname = "IT" };
            return View(ed);
        }
        public ActionResult Dis(string id)
        {
            TempData["value1"] = id;
            TempData.Keep("value1");
            return View();
        }
        public ActionResult Thanq()
        {
            
            return View();
        }
    }
}