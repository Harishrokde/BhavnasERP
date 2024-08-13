using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BhavnasERP.Controllers.Customer
{
    public class CustomerInvController : Controller
    {
        // GET: CustomerInv
        public ActionResult CustomerInvoiceIndex()
        {
            return View();
        }
    }
}