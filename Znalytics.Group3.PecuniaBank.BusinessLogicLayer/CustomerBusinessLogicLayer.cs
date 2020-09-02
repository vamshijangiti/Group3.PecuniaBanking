//    Done by Manasa


using System;
using System.Security.Cryptography.X509Certificates;

using Znalytics.PecuniaBanking.CustomerModule.Entities;//Name space of customer module entities
using Znalytics.Group3.PecuniaBanking.DataAccessLayer;//name space of data access layer
using System.Collections.Generic;


//namespace of customer business logic layer
namespace Znalytics.Group3.PecuniaBanking.BusinessLayer
{
    /// <summary>
    /// Class that Represents Business logic layer of the customer personal details
    /// </summary>
    public class CustomerBusinessLogicLayer : ICustomerBusinessLogicLayer
    {

        private CustomerDataAccessLayer cdal;

        //Constructor for CustomerBusinessLogicLayer
        public CustomerBusinessLogicLayer()
        {
            cdal = new CustomerDataAccessLayer();
        }


        /// <summary>
        /// AddCustomer Method to Validate fields 
        /// </summary>
        /// <param name="cust"></param>
        public void AddCustomer(Customer cust)
        {
            //Validating CustomerId that can't be zero
            try
            {
                if (cust.CustomerId != 0)
                {
                    cdal.AddCustomer(cust);
                }
            }
            catch (Exception ex)//rasing exception
            {
                throw new Exception("Customer Id can't be zero,Please mention your Id", ex);
            }

        }


        /// <summary>
        /// Getting customer  details
        /// </summary>
        /// <returns>list of customers</returns>
        public List<Customer> GetCustomers()
        {
            return cdal.GetCustomers();
        }
        /// <summary>
        /// calling GetCustomersBycustomerId method from Interface of customer businesslogic layer
        /// </summary>
        /// <param name="CustomerId">CustomerId</param>
        /// <returns></returns>
        public Customer GetCustomersByCustomerId(int CustomerId)
        {
            return cdal.GetCustomersByCustomerId(CustomerId);
        }

        /// <summary>
        /// calling update method from Interface of customer businesslogic layer
        /// </summary>
        /// <param name="customer">customer</param>
        public void UpdateCustomer(Customer customer)
        {

            cdal.UpdateCustomer(customer);
        }

       
    }
}