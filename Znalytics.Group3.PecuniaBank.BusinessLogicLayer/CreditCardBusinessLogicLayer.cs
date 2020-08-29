// Manasa Business Logic Layer


using System;
using System.Collections.Generic;
using Znalytics.PecuniaBanking.CreditcardModule.Entities;
using Znalytics.PecuniaBanking.CreditcardModule.DataAccessLayer;
using Znalytics.Group3.PecuniaBanking.BusinessLogicLayer;
using Znalytics.PecuniaBanking.CustomerModule.Entities;
using System.Linq.Expressions;

namespace Znalytics.PecuniaBanking.CreditcardModule.BusinessLogicLayer
{

    /// <summary>
    /// Represents businesslogic layer of credit card
    /// </summary>
    public class CreditcardBusinessLogicLayer

    {
        CreditcardDataAccessLayer _creditcardDataAccessLayer;
        public CreditcardBusinessLogicLayer()
        {
            _creditcardDataAccessLayer = new CreditcardDataAccessLayer();
        }
        ICustomerBLL a = new CustomerBLL();

        public Customer GetCustomersByCustomerId(int c)
        {
            return a.GetCustomersByCustomerId(c);

        }


        //checking account holder name
        public int ApplyCreditCard(int details)
        {
            Customer a = GetCustomersByCustomerId(details);
            _creditcardDataAccessLayer.ApplyCreditCard(a);
        
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
       
        public bool ApproveCreditCard(int CustomerId)
        {
            Customer a = GetCustomersByCustomerId(CustomerId);

            if (a.AnnualIncome >= 300000)
            {
                return true;

            }
            else
            {
                throw new Exception("Income should be greaterthan 300000 to approve credit card");
            }

        }

        public string GenerateCreditCard(int CustomerId)
        {

            Customer a = GetCustomersByCustomerId(CustomerId);

           // _creditcardDataAccessLayer.GenerateCreditCard(a);

            int b = ApplyCreditCard(a.CustomerId);
            string apno = System.Convert.ToString(b);
            string ar = System.Convert.ToString(a.AadharCardNumber);
            string CreditCardNumber = System.Convert.ToString(apno + ar);
            return CreditCardNumber;
            

        }

        public bool UpdateCreditCard(int CustomerId)
        {
            Customer a = GetCustomersByCustomerId(CustomerId);
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


        public bool RequestToIncreaseCreditCardLimit()
        {
            
            CreditCard cr = new CreditCard();
            if(cr.CibilScore>=750)
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