// Done by Manasa

using Znalytics.Group3.PecuniaBanking.DataAccessLayer;
using System;
using System.Linq;
using System.Collections.Generic;
using Znalytics.PecuniaBanking.CustomerModule.Entities;
using Znalytics.PecuniaBanking.CreditcardModule.Entities;

namespace Znalytics.Group3.PecuniaBanking.DataAccessLayer
{
    /// <summary>
    /// Represents Data Access Layer of customer Personal details
    /// </summary>
    public class CustomerDAL: ICustomerDAL
    {
        //List of the CustomerDetail
        private static List<Customer> _details;
        public CustomerDAL()
        {
            _details = new List<Customer>();
        }
        /// <summary>
        /// Method to generate Customer Id
        /// </summary>
        /// <returns> Returns Customer Id</returns>
            public int CustomerIdGeneration()
        {
            int CustomerId = _details.Max(temp => temp.CustomerId);
            return CustomerId++;
        }


        //private fields
        //private static List<CustomerPersonalDetail> _customers;

        List<Customer> customerdetail = new List<Customer>();

        //Adding Customer Personal Details
        public void AddCustomer(Customer customer)
        {
            customerdetail.Add(customer);
        }

        //Getting existing Customer details
        public List<Customer> GetCustomers()
        {
            return customerdetail;
        }

        //Updation of customer details
        public void UpdateCustomer(Customer customer)
        {
            //Get matching customer based on CustomerId
           /* CustomerDetail cust = customerdetail.Find(temp => temp.CustomerId == customer.CustomerId);
            if (customer != null)
            {
                customer.CustomerName = customer.CustomerName;

                

            }*/
        }

        public Customer GetCustomersByCustomerId(int CustomerId)
        {
            return null;
        }
    }
}