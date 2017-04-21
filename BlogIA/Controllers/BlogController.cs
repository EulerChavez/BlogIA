using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogIA.Controllers {

    public class BlogController : Controller {

        // GET: Blog
        public ActionResult Index(int id) {

            return View();

        }

    }

}