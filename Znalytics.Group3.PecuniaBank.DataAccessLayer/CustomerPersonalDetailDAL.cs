
using System;
using System.Collections.Generic;
using Znalytics.PecuniaBanking.CustomerPersonalDetailModule.Entities;

namespace Znalytics.Group3.PecuniaBanking.DataAccessLayer
{
    public class CustomerPersonalDetailDAL: ICustomerPersonalDetailDAL
    {
        //private fields
        //private static List<CustomerPersonalDetail> _customers;

        List<CustomerPersonalDetail> customerdetail = new List<CustomerPersonalDetail>();

        //constructor
       /* static CustomerPersonalDetailDAL()
        {
            _customers = new List<CustomerPersonalDetail>()
            {
                new CustomerPersonalDetail(){ },
                new CustomerPersonalDetail(){ }
            };
        }*/

        //Add
        public void AddCustomer(CustomerPersonalDetail customer)
        {
            customerdetail.Add(customer);
        }

        //Get Customerts
        public void ViewCustomer(CustomerPersonalDetail customer)
        {
             List<CustomerPersonalDetail> GetCustomers()
            {
                return customerdetail;
            }
        }

        //Update
        public void UpdateCustomer(CustomerPersonalDetail customer)
        {
            //Get matching employee based on EmpID
            CustomerPersonalDetail cust = customerdetail.Find(temp => temp.CustomerId == customer.CustomerId);
            if (customer != null)
            {
                customer.CustomerName = customer.CustomerName;
            }
        }
    }
}