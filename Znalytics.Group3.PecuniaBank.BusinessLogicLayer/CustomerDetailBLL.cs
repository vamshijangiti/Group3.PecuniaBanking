﻿//    Done by Manasa


using System;
using System.Security.Cryptography.X509Certificates;
//using System.Text.RegularExpressions;
using Znalytics.PecuniaBanking.CustomerDetailModule.Entities;
using Znalytics.Group3.PecuniaBanking.DataAccessLayer;
using System.Collections.Generic;
//using Znalytics.PecuniaBanking.CustomerDetailModule.PresentationLayer;


namespace Znalytics.Group3.PecuniaBanking.BusinessLogicLayer
{
    /// <summary>
    /// Class Represents Business logic layer of the customer personal details
    /// </summary>
    public class CustomerDetailBLL : ICustomerDetailBLL
    {

        private ICustomerDetailDAL cdal;

        //Constructor for CustomerDetailBusinessLogicLayer
        public CustomerDetailBLL()
        {
            cdal = new CustomerDetailDAL();
        }


        /// <summary>
        /// AddCustomer Method to Validate fields 
        /// </summary>
        /// <param name="cust"></param>
        public void AddCustomer(CustomerDetail cust)
        {
            //Validating CustomerName that can't be null
            try
            {
                if(cust.CustomerName!=null)
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
            try
            {

                if (cust.PhoneNumber != null)
                {
                    cdal.AddCustomer(cust);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("PhoneNumber can't be null,Please mention your PhoneNumber", ex);
            }

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
                if (cust.MailId!=null)
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
        public List<CustomerDetail> GetCustomers()
        {
            return cdal.GetCustomers();
        }
        public List<CustomerDetail> GetCustomerNameByCustomerId(string CustomerName)
        {
            return cdal.GetCustomerNameByCustomerId(CustomerName);
        }

        //Update customer details
        public void UpdateCustomer(CustomerDetail customer)
        {

            cdal.UpdateCustomer(customer);
        }
    }
}