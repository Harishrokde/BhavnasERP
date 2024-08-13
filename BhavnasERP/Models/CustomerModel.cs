using BhavnasERP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BhavnasERP.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        public string Address { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public List<CustomerModel> GetCustomerlist()
        
        {
            BhavanasERPEntities db = new BhavanasERPEntities();
            List<CustomerModel> lstCustomer = new List<CustomerModel>();
            var Customerlist = db.tblCustomers.ToList();
            if (Customerlist != null)
            {
                foreach (var Customer in Customerlist)
                {
                    lstCustomer.Add(new CustomerModel()
                    {
                        Id = Customer.Id,
                        Name = Customer.Name,
                        Email = Customer.Email,
                        MobileNo = Customer.MobileNo,
                        State = Customer.State,
                        City = Customer.City,
                        Address = Customer.Address
                    });
                }
            }
            return lstCustomer;
        }
                
    }
}