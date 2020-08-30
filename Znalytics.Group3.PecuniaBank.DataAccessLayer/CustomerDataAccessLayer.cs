//////////// Done by Manasa ////////////

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
    public class CustomerDataAccessLayer: ICustomerDataAccessLayer
    {
        //List of the CustomerDetail
        private static List<Customer> _details;
        public CustomerDataAccessLayer()
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


       //Creating List
        List<Customer> customerdetail = new List<Customer>();

        //Adding Customer Personal Details
        public void AddCustomer(Customer customer)
        {
            customerdetail.Add(customer);
        }

        //Method to get existing Customer details
        public List<Customer> GetCustomers()
        {
            return customerdetail;
        }


        //Method to Update of customer details
        public void UpdateCustomer(Customer customer)
        {
           
        }

        //Method to get customers details by CustomerId
        public Customer GetCustomersByCustomerId(int CustomerId)
        {
            return null;
        }
    }
}