﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Email(string name, string email)
        {
            ViewBag.Message = "Thank you " + name + "! " + "We will send an email to " + email + " ASAP.";

            return View();
        }
    }
}