using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogIA.Controllers {

    public class BlogController : Controller {

        // GET: Blog
        public ActionResult Index() {

            return View();

        }

        // GET: Blog/Blog/1
        public ActionResult Blog(int id = 0) {

            return View();

        }

    }

}