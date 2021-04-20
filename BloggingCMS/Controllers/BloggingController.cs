using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingCMS.Controllers
{
    public class BloggingController : Controller
    {
        // GET: BloggingController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BloggingOverview()
        {
            return View();
        }
        // GET: BloggingController/Details/5

        public ActionResult Article()
        {
            return View();
        }
    }
}
