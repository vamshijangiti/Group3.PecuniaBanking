//    Done by Manasa


using System;
using System.Security.Cryptography.X509Certificates;

using Znalytics.PecuniaBanking.CustomerModule.Entities;
using Znalytics.Group3.PecuniaBanking.DataAccessLayer;
using System.Collections.Generic;



namespace Znalytics.Group3.PecuniaBanking.BusinessLayer
{
    /// <summary>
    /// Class that Represents Business logic layer of the customer personal details
    /// </summary>
    public class CustomerBusinessLogicLayer : ICustomerBusinessLogicLayer
    {

        private CustomerDataAccessLayer cdal;

        //Constructor for CustomerDetailBusinessLogicLayer
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
            //Validating CustomerName that can't be null
            try
            {
                if (cust.CustomerName != null)
                {
                    cdal.AddCustomer(cust);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Customer name can't be null,Please mention your name", ex);
            }

            //validating pancard number that can't be null
            try
            {
                if (cust.PanCardNumber != null)
                {
                    cdal.AddCustomer(cust);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("PanCardNumber can't be null,Please mention your PancardNumber", ex);
            }

            //Validating Aadharcard number that can't be null
            try
            {
                if (cust.AadharCardNumber != null)
                {
                    cdal.AddCustomer(cust);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("AadharCardNumber can't be null,Please mention your AadharCardNumber", ex);
            }

            //Checking Phone number that can't be null
            /*try
            {

                if (cust.PhoneNumber != null)
                {
                    cdal.AddCustomer(cust);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("PhoneNumber can't be null,Please mention your PhoneNumber", ex);
            }*/

            //Checking Age that can't be null
            try
            {
                if (cust.DateOfBirth != null)
                {
                    cdal.AddCustomer(cust);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DateOfBirth can't be null,Please mention your DateOfBirth", ex);
            }
            //Validation of Mail Id
            try
            {
                if (cust.MailId != null)
                {
                    cdal.AddCustomer(cust);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Mail Id can't be null,Please mention your Mail", ex);
            }

        }


        //Getting customer personal details
        public List<Customer> GetCustomers()
        {
            return cdal.GetCustomers();
        }
        public Customer GetCustomersByCustomerId(int CustomerId)
        {
            return cdal.GetCustomersByCustomerId(CustomerId);
        }

        //Update customer details
        public void UpdateCustomer(Customer customer)
        {

            cdal.UpdateCustomer(customer);
        }

        public int CustomerIdGeneration(Customer cust)
        {
            // cdal.CustomerIdGeneration(cust);
            return cdal.CustomerIdGeneration(cust);
        }
    }
}