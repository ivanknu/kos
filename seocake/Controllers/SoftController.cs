using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace seocake.Controllers
{
    public class SoftController : Controller
    {
        //
        // GET: all softs

        public ActionResult AllSofts()
        {
            return View("Softs");
        }


        //
        // GET: all softs

        public ActionResult SoftPage()
        {
            return View("SoftPage");
        }

    }
}
