using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Web.TsmArchiver;

namespace Web.Controllers
{
    public class TsmController : Controller
    {
        // POST: Retrieve
        [HttpPost]
        public ActionResult Retrieve(int projectId)
        {
            TsmService t = new TsmService();
            @ViewBag.status = t.Retrieve(projectId); 

            return View();
        }

        public ActionResult Archive(int projectId)
        {
            TsmService t = new TsmService();
            @ViewBag.status = t.Archive(projectId);

            return View("Retrieve");
        }
    }
}