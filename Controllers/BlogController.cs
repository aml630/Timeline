using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimeLineBlog.Controllers
{
    public class BlogController : Controller
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

            return View("~/Views/Blog/Graphs/GraphDataCard.aspx");
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