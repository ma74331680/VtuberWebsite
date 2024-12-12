using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VtuberWebsite.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Product
        public ActionResult Producttable()
        {
            return View();
        }
        public ActionResult Productshowing()
        {
            return View();
        }
    }
}