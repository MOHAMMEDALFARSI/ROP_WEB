using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ROP_WEB.Models;

namespace ROP_WEB.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult PersonalServices()
        {
            ROPdbEntities db = new ROPdbEntities();
            var ServiceProviders = db.SERVICEs.Select(m =>  m.SERVICE_PROVIDER.Service_Provider_Name_Ar).Distinct();
            var personalServices = db.SERVICEs.Where(x=>x.Service_Cat_Id==1).ToList();

            ViewBag.ServiceProviders = ServiceProviders;

            return View(personalServices);
        }
        public ActionResult GovServices()
        {

            return View();
        }
        public ActionResult CompaniesServices()
        {

            return View();
        }

        public ActionResult ServicesDetails()
        {

            return View();
        }
    }
}