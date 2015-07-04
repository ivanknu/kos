using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace seocake.Controllers
{
    public class VocabluaryController : Controller
    {
        //
        // GET: all words

        public ActionResult AllWords()
        {
            return View("AllWords");
        }

        // GET: one word

        public ActionResult OneWord()
        {
            return View("OneWord");
        }

    }
}
