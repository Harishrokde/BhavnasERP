using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BhavnasERP.Models;

namespace BhavnasERP.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult CustomerListIndex()
        {
            return View();
        }
        public ActionResult GetCustomerlist()
        {
            try
            {
                return Json(new { model = (new CustomerModel().GetCustomerlist()) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }

        }
    }
}