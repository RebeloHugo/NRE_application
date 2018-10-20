using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NRE_application.Controllers
{
    public class RE_PagesController : Controller
    {
        // GET: RE_Pages

        public ActionResult Biogas()
        {
            return View();
        }

        public ActionResult Hydraulic()
        {
            return View();
        }


        public ActionResult Photovoltaic()
        {
            return View();
        }

        public ActionResult Windturbine()
        {
            return View();
        }


        


    }
}