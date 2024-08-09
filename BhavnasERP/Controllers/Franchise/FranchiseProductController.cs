using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BhavnasERP.Controllers
{
    public class FranchiseProductController : Controller
    {
        // GET: FranchiseProduct
        public ActionResult FranchiseProductIndex()
        {
            return View();
        }

        public ActionResult PlaceOrderIndex()
        {
            return View();
        }
    }
}