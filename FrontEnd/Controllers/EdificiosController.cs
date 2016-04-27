using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontEnd.Controllers
{
    public class EdificiosController : Controller
    {
        // GET: Edificios
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CrearEdificio()
        {
            return View();
        }
    }
}