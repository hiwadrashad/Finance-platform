using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontPage.Controllers
{
    public class FrontPageController : Controller
    {
        // GET: FrontPageController
        public ActionResult MainPage()
        {
            return View();
        }

    }
}
