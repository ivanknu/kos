using seocake.Logic;
using seocake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace seocake.Controllers
{
    public class PostController : Controller
    {

        private PostContext db = new PostContext();
        //
        // GET: all posts


        //public ActionResult Posts()
        //{   
        //    return View("Posts");
        //}

        // GET: one post

        public ActionResult PostOne(int id=0)
        {
            Posts post = db.PostSet.Find(id);

            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
            
        }

    }
}
