using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ROP_WEB.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult ropphones()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }

        public ActionResult workTimes()
        {
            return View();
        }
        public ActionResult FAQ()
        {
            return View();
        }
        public ActionResult Survey()
        {
            return View();
        }
    }
}