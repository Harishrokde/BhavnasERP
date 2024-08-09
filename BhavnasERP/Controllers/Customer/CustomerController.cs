using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BhavnasERP.Controllers.Customer
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult CustomerIndex()
        {
            return View();
        }
    }
}