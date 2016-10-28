using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class qooController : Controller
    {
        // GET: qoo
        public ActionResult qooIndex(string id)
        {
            return View();
            ViewBag.ID = id;
        }
    }
}