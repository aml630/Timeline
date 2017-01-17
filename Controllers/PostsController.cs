using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimeLineBlog.Controllers
{
    public class PostsController : Controller
    {
        // GET: Post
        public ActionResult Timeline()
        {
            return View();
        }

        public ActionResult OrangeGraph()
        {

            return View();
        }

        public ActionResult GraphDataCard()
        {

            return View();
        }

        public ActionResult TransparentBarGraph()
        {

            return View();
        }

        public ActionResult ColorfulDataPoints()
        {

            return View();
        }
    }
}