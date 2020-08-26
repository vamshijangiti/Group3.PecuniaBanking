// Done by Manasa


using System;
using System.Collections.Generic;
using Znalytics.PecuniaBanking.CustomerPersonalDetailModule.Entities;

namespace Znalytics.Group3.PecuniaBanking.DataAccessLayer
{
    /// <summary>
    /// Represents Data Access Layer of customer Personal details
    /// </summary>
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

        //Adding Customer Personal Details
        public void AddCustomer(CustomerPersonalDetail customer)
        {
            customerdetail.Add(customer);
        }

        //Getting existing Customer details
        public void ViewCustomer(CustomerPersonalDetail customer)
        {
             List<CustomerPersonalDetail> GetCustomers()
            {
                return customerdetail;
            }
        }

        //Updationof customer details
        public void UpdateCustomer(CustomerPersonalDetail customer)
        {
            //Get matching customer based on CustomerId
            CustomerPersonalDetail cust = customerdetail.Find(temp => temp.CustomerId == customer.CustomerId);
            if (customer != null)
            {
                customer.CustomerName = customer.CustomerName;
            }
        }
    }
}