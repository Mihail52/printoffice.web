using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrintOffice.Web.Controllers
{
    public class CaseController : Controller
    {
        // GET: Case
        public ActionResult Index()
        {
            ViewBag.Caption = "Hello from Case Controller";
            return View();
        }
    }
}