using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NiboChallenge.Controllers
{
    public class ChampionshipController : Controller
    {
        // GET: Championship
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Start()
        {
            ViewBag.Message = "And so it beggins...";

            return View();
        }
    }
}