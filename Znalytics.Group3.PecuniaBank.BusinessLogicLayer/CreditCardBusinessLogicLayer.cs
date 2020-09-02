// Manasa Business Logic Layer


using System;
using System.Collections.Generic;
using Znalytics.PecuniaBanking.CreditcardModule.Entities;//namespace of credit card module entities
using Znalytics.PecuniaBanking.CreditcardModule.DataAccessLayer;//namespace of credit card data access layer
using Znalytics.Group3.PecuniaBanking.BusinessLayer;//namespace of Businesslogic layer
using Znalytics.PecuniaBanking.CustomerModule.Entities;//namespace of customer module entities


namespace Znalytics.PecuniaBanking.CreditcardModule.BusinessLogicLayer
{

    /// <summary>
    /// class that represents businesslogic layer of credit card
    /// </summary>
    public class CreditcardBusinessLogicLayer                                 

    {
        CreditcardDataAccessLayer _creditcardDataAccessLayer;// //creating reference variable of CreditcardDataAccessLayer class
        public CreditcardBusinessLogicLayer()//Creating constructor for Creditcard Business Logic Layer
        {
            _creditcardDataAccessLayer = new CreditcardDataAccessLayer();//creating object to creditcard data access layer
        }
        ICustomerBusinessLogicLayer a = new CustomerBusinessLogicLayer();//interface of customer business logic layer

        /// <summary>
        /// Method to get customer details by customer id which is called from data access layer
        /// </summary>
        /// <param name="c">c</param>
        /// <returns>customers</returns>
        public Customer GetCustomersByCustomerId(int c)
        {
            return a.GetCustomersByCustomerId(c);

        }


        /// <summary>
        /// Method to Apply Credit card
        /// </summary>
        /// <param name="details">Adds details to the Creditcard</param>
        /// <returns>Application number</returns>
        public int ApplyCreditCard(int CustomerId)
        {
            Customer a = GetCustomersByCustomerId(CustomerId);//calling GetCustomersBycustomerId method from Businesslogic layer of Customer module
            _creditcardDataAccessLayer.ApplyCreditCard(a);//Calling ApplyCreditCard method from data access layer of creditcard
        
        int AppNumber = 0;

            string i = a.AadharCardNumber;

            int count = 0;
            while (count < 4)
            {
                int k = System.Convert.ToInt32(i);
                int j = k % 10;
                AppNumber = AppNumber * 10 + j;
                k = k / 10;
                count++;
            }


            return AppNumber;

           
        }
       
        /// <summary>
        /// Method to Approve Credit card
        /// </summary>
        /// <param name="CustomerId">Approve creditcard using customerId</param>
        /// <returns>Acceptance or rejection of creditcard</returns>
        public bool ApproveCreditCard(int CustomerId)
        {
            Customer a = GetCustomersByCustomerId(CustomerId);////calling GetCustomersBycustomerId method from Businesslogic layer of Customer module

            if (a.AnnualIncome >= 300000)//validating the condition that annulaincome should be morethan 300000 to approve credit card
            {
                return true;

            }
            else
            {
                throw new Exception("Income should be greaterthan 300000 to approve credit card");
            }

        }
        /// <summary>
        /// Method to generate Creditcard Number
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns>Creditcard Number</returns>
        public string GenerateCreditCard(int CustomerId)
        {

            Customer a = GetCustomersByCustomerId(CustomerId);//calling GetCustomersBycustomerId method from Businesslogic layer of Customer module

            int b = ApplyCreditCard(a.CustomerId);
            string apno = System.Convert.ToString(b);
            string ar = System.Convert.ToString(a.AadharCardNumber);
            string CreditCardNumber = System.Convert.ToString(apno + ar);
            return CreditCardNumber;
            

        }

        /// <summary>
        /// Method to Update Credit card 
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns>Status of creditcard</returns>
        public bool UpdateCreditCard(int CustomerId)
        {
            Customer a = GetCustomersByCustomerId(CustomerId);//calling GetCustomersBycustomerId method from Businesslogic layer of Customer module
            string b = GenerateCreditCard(a.CustomerId);

            if (b!=null)
            {
                return true;

            }
            else
            {
                throw new Exception("CreditCardNumber can't be null");
            }

        }

        /// <summary>
        /// Method to Increase credit card limit
        /// </summary>
        /// <returns>Acceptance or rejection to increase credit card limit</returns>
        public bool RequestToIncreaseCreditCardLimit()
        {
            
            CreditCard cr = new CreditCard();
            if(cr.CibilScore>=750)//checking condition to increase credit card limit
            {
                return true;

            }
            else
            {
                throw new Exception("You are not eligible to increase your creditcard limit");
            }
        }




    }



}