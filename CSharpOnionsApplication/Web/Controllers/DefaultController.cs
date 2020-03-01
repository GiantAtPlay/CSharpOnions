using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IApplicationFascade _application;

        public DefaultController(IApplicationFascade application)
        {
            _application = application;
        }

        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
    }
}