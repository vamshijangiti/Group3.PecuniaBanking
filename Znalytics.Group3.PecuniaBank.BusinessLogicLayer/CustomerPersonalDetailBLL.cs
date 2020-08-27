//    Done by Manasa


using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Znalytics.PecuniaBanking.CustomerPersonalDetailModule.Entities;
using Znalytics.Group3.PecuniaBanking.DataAccessLayer;
using System.Collections.Generic;
using Znalytics.PecuniaBanking.CreditcardModule.Entities;

namespace Znalytics.Group3.PecuniaBanking.BusinessLogicLayer
{
    /// <summary>
    /// Represents Business logic layer of the customer personal details
    /// </summary>
    public class CustomerPersonalDetailBLL : ICustomerPersonalDetailBLL
    {
        private ICustomerPersonalDetailDAL cdal = null;


        public CustomerPersonalDetailBLL()
        {
            cdal = new CustomerPersonalDetailDAL();
        }


        public void AddCustomer(CustomerDetail customer)
        {
            //Validating customer name
            if (customer.CustomerName != null)
            {
                //cdal.AddCustomer(customer);
                
            }
            else
            {
                throw new Exception("Name can't be null,Please Mention your name");
            }


            //validating pancard number
            string checkPanCardNumber = @"^[A-Za-z]{5}[0-9]{4}[A-Za-z]{1}$";
            bool isPanCardNumberValid = Regex.IsMatch(customer.PanCardNumber, checkPanCardNumber);
            if (isPanCardNumberValid == true)
            {
                cdal.AddCustomer(customer);
            }
            else
            {
                throw new Exception("Invalid Pancardnumber");
            }

            //Validating Aadharcard number

            if (customer.AadharCardNumber != null)
            {
                cdal.AddCustomer(customer);

            }
            else
            {
                throw new Exception("Please enter 12digit aadharcard number");
            }

            //Checking Phone number

            if (customer.PhoneNumber != null)
            {
                cdal.AddCustomer(customer);
            }
            else
            {
                throw new Exception("Phone number can't be null,Please enter 10digit Phonenumber");
            }

            //Checking Age

            if (customer.Age >= 18)
            {
                cdal.AddCustomer(customer);
            }
            else
            {
                throw new Exception("Age must be 18 and above");
            }

        }
        //Validation of Mail Id
        public void ValidateMailId(CustomerDetail customer)
        {

            string mail = customer.MailId;
            //searching for space
            bool spaceFound = mail.Contains(" ");

            //searching for @
            bool AtFound = mail.Contains("@");

            char[] ch = mail.ToCharArray();
            int AtCharCount = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '@')
                {
                    AtCharCount++;
                }
            }
            cdal.AddCustomer(customer);


        }

        //View customer personal details
        public List<Customer> GetCustomers()
        {
            return cdal.GetCustomers();
        }

        //Update customer details
        public void UpdateCustomer(CustomerDetail customer)
        {

            cdal.UpdateCustomer(customer);
        }
    }
}