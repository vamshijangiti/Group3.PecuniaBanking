//    Done by Manasa


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
    /// Represents Business logic layer of the customer personal details
    /// </summary>
    public class CustomerDetailBLL : ICustomerDetailBLL
    {

        private ICustomerDetailDAL cdal;

        //Constructor for CustomerDetailBusinessLogicLayer
        public CustomerDetailBLL()
        {
            cdal = new CustomerDetailDAL();
        }



        public void AddCustomer(CustomerDetail cust)
        {

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

            //validating pancard number
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

            //Validating Aadharcard number
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

            //Checking Phone number
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

            //Checking Age
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


        //View customer personal details
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