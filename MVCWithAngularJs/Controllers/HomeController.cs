using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithAngularJs.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Weather() // Cascade Dropdown
        {
            return View();
        }

    }
}
