
using System;
using System.Collections.Generic;
using Znalytics.PecuniaBanking.CustomerPersonalDetailModule.Entities;

namespace Znalytics.PecuniaBanking.CustomerPersonalDetails.DataAccessLayer
{
    public class CustomerPersonalDetailDAL
    {
        //private fields
        private static List<CustomerPersonalDetail> _customers;

        //constructor
        static CustomerPersonalDetailDAL()
        {
            _customers = new List<CustomerPersonalDetail>()
            {
                new CustomerPersonalDetail(){ },
                new CustomerPersonalDetail(){ }
            };
        }

        //Add
        public void Add(CustomerPersonalDetail customer)
        {
            _customers.Add(customer);
        }

        //Get all employees
        public List<CustomerPersonalDetail> GetCustomers()
        {
            return _customers;
        }

        //Update
        public void UpdateCustomer(CustomerPersonalDetail customer)
        {
            //Get matching employee based on EmpID
            CustomerPersonalDetail cust = _customers.Find(temp => temp.CustomerId == customer.CustomerId);
            if (cust != null)
            {
                cust.CustomerName = customer.CustomerName;
            }
        }
    }
}