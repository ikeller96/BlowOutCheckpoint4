using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlowOut.Models;

namespace BlowOut.Controllers
{
    public class RentalsController : Controller
    {

        // GET: Rentals
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Trumpet(string price)
        {
            ViewBag.value = price;
            return View();
        }

        public ActionResult Trombone(string price)
        {
            ViewBag.value = price;
            return View();
        }

        public ActionResult Tuba(string price)
        {
            ViewBag.value = price;
            return View();
        }

        public ActionResult Flute(string price)
        {
            ViewBag.value = price;
            return View();
        }

        public ActionResult Clarinet(string price)
        {
            ViewBag.value = price;
            return View();
        }

        public ActionResult Saxaphone(string price)
        {
            ViewBag.value = price;
            return View();
        }
    }
}