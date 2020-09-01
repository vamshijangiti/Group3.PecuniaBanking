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
       private static List<Customer> _customers;
        public CustomerDataAccessLayer()
        {
            _customers = new List<Customer>();
        }
        /// <summary>
        /// Method to generate Customer Id
        /// </summary>
        /// <returns> Returns Customer Id</returns>
            public int CustomerIdGeneration(Customer cust)
        {
            int CustomerId = _customers.Max(temp => temp.CustomerId);
            return CustomerId++;
        }


      
        //Adding Customer Personal Details
        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }


        //Method to get existing Customer details
        public List<Customer> GetCustomers()
        {
            return _customers;
        }


        //Method to Update of customer details
        
        public void UpdateCustomer(Customer c)
        {
            ///updating deatils based on cust id///
            Customer cu = _customers.Find(temp => temp.CustomerId == c.CustomerId);
            if (cu != null)
            {
                cu.CustomerName = c.CustomerName;

            }
        }

        //Method to get customers details by CustomerId
       

        public Customer GetCustomersByCustomerId(int CustomerId)//Displaying product Details using Product ID
        {
            Customer e;
            e = _customers.Find(n => n.CustomerId == CustomerId);
            
            return e;
        }
    }
}