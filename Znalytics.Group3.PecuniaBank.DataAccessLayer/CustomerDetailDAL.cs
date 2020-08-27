// Done by Manasa

using Znalytics.Group3.PecuniaBanking.DataAccessLayer;
using System;
using System.Collections.Generic;
using Znalytics.PecuniaBanking.CustomerDetailModule.Entities;

namespace Znalytics.Group3.PecuniaBanking.DataAccessLayer
{
    /// <summary>
    /// Represents Data Access Layer of customer Personal details
    /// </summary>
    public class CustomerDetailDAL: ICustomerDetailDAL
    {
        //private fields
        //private static List<CustomerPersonalDetail> _customers;

        List<CustomerDetail> customerdetail = new List<CustomerDetail>();

        //Adding Customer Personal Details
        public void AddCustomer(CustomerDetail customer)
        {
            customerdetail.Add(customer);
        }

        //Getting existing Customer details
        public void ViewCustomer(CustomerDetail customer)
        {
             List<CustomerDetail> GetCustomers()
            {
                return customerdetail;
            }
        }

        //Updation of customer details
        public void UpdateCustomer(CustomerDetail customer)
        {
            //Get matching customer based on CustomerId
            CustomerDetail cust = customerdetail.Find(temp => temp.CustomerId == customer.CustomerId);
            if (customer != null)
            {
                customer.CustomerName = customer.CustomerName;
            }
        }
    }
}