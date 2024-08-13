using BhavnasERP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace BhavnasERP.Models
{
    public class CustomerOrderModel
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public string TransactionMode { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string SaveCustomerOrder(CustomerOrderModel model)

        {
            BhavanasERPEntities db = new BhavanasERPEntities();
            string message = "";
            var getregistration = db.tblCustomerOrders.Where(t => t.Id == model.Id).FirstOrDefault();/*For condition of save in edit */
            if (getregistration == null)/*For condition of save in edit */
            {
                var SaveCustomerOrder = new tblCustomerOrder()
                {
                    Id = model.Id,
                    OrderDate = model.OrderDate,
                    DeliveryDate = model.DeliveryDate,
                    Amount = model.Amount,
                    Discount = model.Discount,
                    TotalAmount = model.TotalAmount,                    
                };
                db.tblCustomerOrders.Add(SaveCustomerOrder);
                db.SaveChanges();
                return message = "save Successfully";

            }
            else
            {
                getregistration.Id = model.Id;
                getregistration.OrderDate = model.OrderDate;
                getregistration.DeliveryDate = model.DeliveryDate;
                getregistration.Amount = model.Amount;
                getregistration.Discount = model.Discount;
                getregistration.TotalAmount = model.TotalAmount;
            }
            db.SaveChanges();
            return message = "update Successfully";






        }

        public List<CustomerOrderModel> GetCustomerOrderlist()
        {
            BhavanasERPEntities db = new BhavanasERPEntities();
            List<CustomerOrderModel> lstCustomerOrder = new List<CustomerOrderModel>();
            var CustomerOrderlist = db.tblCustomerOrders.ToList();
            if (CustomerOrderlist != null)
            {
                foreach (var CustomerOrder in CustomerOrderlist)
                {
                    lstCustomerOrder.Add(new CustomerOrderModel()
                    {
                        Id = CustomerOrder.Id,
                        OrderDate = CustomerOrder.OrderDate,
                        DeliveryDate = CustomerOrder.DeliveryDate,
                        TransactionMode = CustomerOrder.TransactionMode,
                        Amount = CustomerOrder.Amount,
                        TotalAmount = CustomerOrder.TotalAmount

                    });
                }
            }
            return lstCustomerOrder;
        }
        public string Deletemvc(int Id)
        {
            string Message = "";
            BhavanasERPEntities Db = new BhavanasERPEntities();
            var deleteRecord = Db.tblCustomerOrders.Where(p => p.Id == Id).FirstOrDefault();
            if (deleteRecord != null)
            {
                Db.tblCustomerOrders.Remove(deleteRecord);
            };
            Db.SaveChanges();
            Message = "Record Deleted Successfully";
            return Message;
        }
        public CustomerOrderModel EditData(int Id)
        {
            string Message = "";
            CustomerOrderModel model = new CustomerOrderModel();
            BhavanasERPEntities Db = new BhavanasERPEntities();
            var editData = Db.tblCustomerOrders.Where(p => p.Id == Id).FirstOrDefault();
            if (editData != null)
            {
                model.Id = editData.Id;
                model.OrderDate = editData.OrderDate;
                model.DeliveryDate = editData.DeliveryDate;
                model.TransactionMode = editData.TransactionMode;
                model.Amount = editData.Amount;
                model.Discount = editData.Discount;
                model.TotalAmount = editData.TotalAmount;
            }
            Message = "Record Edited Successfully";
            return model;
        }
    }
}