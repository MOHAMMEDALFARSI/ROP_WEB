using ROP_WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace ROP_WEB.Controllers
{
    public class MediaController : Controller
    {
        ROP_WEBEntities db = new ROP_WEBEntities();
        // GET: Media
        public ActionResult News(string sortOrder, string CurrentSort, int? page)
        {

            List<NewsMain> News = new List<NewsMain>();

            News = db.NewsMains.Where(x => x.Show == true && x.Archive == false).ToList();
            int pageSize = 1;
            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            ViewBag.CurrentSort = sortOrder;
            sortOrder = String.IsNullOrEmpty(sortOrder) ? "NewsID" : sortOrder;
            IPagedList<NewsMain> Newslst = null;
            switch (sortOrder)
            {
                case "NewsID":
                        Newslst = News.OrderByDescending
                                (m => m.NewsID).ToPagedList(pageIndex, pageSize);
                    break;

                case "Default":
                    Newslst = News.OrderByDescending
                           (m => m.NewsID).ToPagedList(pageIndex, pageSize);
                    break;
            }

            return View(Newslst);
        }
        public ActionResult NewsDetails(int id)
        {

            return View(db.NewsMains.FirstOrDefault(x => x.NewsID == id));
        }
        public ActionResult Articles()
        {

            return View();
        }
        public ActionResult Ads()
        {

            return View();
        }
        public ActionResult Events()
        {

            return View();
        }
        public ActionResult PhotosAlbum()
        {

            return View();
        }
        public ActionResult Ropmagazine()
        {

            return View();
        }
        public ActionResult KidsMagazin()
        {

            return View();
        }
        public ActionResult AlainaAssahira()
        {

            return View();
        }
        public ActionResult EmploymentAds()
        {

            return View();
        }
    }
}