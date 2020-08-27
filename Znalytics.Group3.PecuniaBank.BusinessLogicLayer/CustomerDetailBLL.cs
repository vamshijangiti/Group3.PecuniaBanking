﻿//    Done by Manasa


using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Znalytics.PecuniaBanking.CustomerDetailModule.Entities;
using Znalytics.Group3.PecuniaBanking.DataAccessLayer;
using System.Collections.Generic;


namespace Znalytics.Group3.PecuniaBanking.BusinessLogicLayer
{
    /// <summary>
    /// Represents Business logic layer of the customer personal details
    /// </summary>
    public class CustomerDetailBLL : ICustomerDetailBLL
    {

        ICustomerDetailBLL CustomerDetailBll = new CustomerDetailBLL();
        ICustomerDetailDAL CustomerDetailDAl = new CustomerDetailDAL();
        CustomerDetail customer = new CustomerDetail();

        /*private ICustomerDetailDAL cdal = null;


        public CustomerDetailBLL()
        {
            cdal = new CustomerDetailDAL();
        }*/


        public void AddCustomer(CustomerDetail customer)
        {
            //Validating customer name
            if (customer.CustomerName != null)
            {
                cdal.AddCustomer(customer);

            }
            else
            {
                throw new Exception("Name can't be null,Please Mention your name");
            }

           // void ValidatePanCardNumber(CustomerDetail customer)
            //{


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
        }

        //Checking Age
        public int ValidateAge(CustomerDetail customer)
        {
            DateTime dateOfBirth = Convert.ToDateTime("1998-07-03 7:00 am");
            DateTime presentDate = DateTime.Now;
            TimeSpan timeSpan = presentDate - dateOfBirth;
            int age = Convert.ToInt32(timeSpan.TotalDays / 365);

            return age;

            if (customer.age >= 18)
            {
                cdal.AddCustomer(customer);
            }
            else
            {
                throw new Exception("Age must be 18 or above");
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
        public List<CustomerDetail> GetCustomers()
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