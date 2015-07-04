using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace seocake.Controllers
{
    public class PartnersController : Controller
    {
        //
        // GET: page for one partners

        public ActionResult PartnerPage()
        {
            return View("PartnerPage");
        }

        // GET: page for all partners
        public ActionResult Partners()
        {
            return View("Partners");
        }

    }
}
