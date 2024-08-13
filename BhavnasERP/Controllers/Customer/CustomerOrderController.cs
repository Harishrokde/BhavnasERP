using BhavnasERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BhavnasERP.Controllers.Customer
{
    public class CustomerOrderController : Controller
    {
        // GET: CustomerOrder
        public ActionResult CustomerOrderIndex()
        {
            return View();

        }

        public ActionResult CustomerOrderList()
        {
            return View();

        }

        public ActionResult SaveCustomerOrder(CustomerOrderModel model)
        {
            try
            {
                return Json(new { Message = (new CustomerOrderModel().SaveCustomerOrder(model)) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }

        }
        public ActionResult GetCustomerOrderlist()
        {
            try
            {
                return Json(new { model = (new CustomerOrderModel().GetCustomerOrderlist()) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }

        }
        public ActionResult Deletemvc(int Id)
        {
            try
            {
                return Json(new { model = (new CustomerOrderModel().Deletemvc(Id)) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult GetEditData(int ID)
        {
            try
            {
                return Json(new { model = (new CustomerOrderModel().EditData(ID)) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}