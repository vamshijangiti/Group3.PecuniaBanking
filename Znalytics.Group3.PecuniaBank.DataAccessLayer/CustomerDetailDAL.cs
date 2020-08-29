// Done by Manasa

using Znalytics.Group3.PecuniaBanking.DataAccessLayer;
using System;
using System.Linq;
using System.Collections.Generic;
using Znalytics.PecuniaBanking.CustomerDetailModule.Entities;
using Znalytics.PecuniaBanking.CreditcardModule.Entities;

namespace Znalytics.Group3.PecuniaBanking.DataAccessLayer
{
    /// <summary>
    /// Represents Data Access Layer of customer Personal details
    /// </summary>
    public class CustomerDetailDAL: ICustomerDetailDAL
    {
        //List of the CustomerDetail
        private static List<CustomerDetail> _details;
        public CustomerDetailDAL()
        {
            _details = new List<CustomerDetail>();
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

        List<CustomerDetail> customerdetail = new List<CustomerDetail>();

        //Adding Customer Personal Details
        public void AddCustomer(CustomerDetail customer)
        {
            customerdetail.Add(customer);
        }

        //Getting existing Customer details
        public List<CustomerDetail> GetCustomers()
        {
            return customerdetail;
        }

        //Updation of customer details
        public void UpdateCustomer(CustomerDetail customer)
        {
            //Get matching customer based on CustomerId
           /* CustomerDetail cust = customerdetail.Find(temp => temp.CustomerId == customer.CustomerId);
            if (customer != null)
            {
                customer.CustomerName = customer.CustomerName;

                

            }*/
        }

        public List<CustomerDetail> GetCustomerNameByCustomerId(string customerName)
        {
            return null;
        }
    }
}