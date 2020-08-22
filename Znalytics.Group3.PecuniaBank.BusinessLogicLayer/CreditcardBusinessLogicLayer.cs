// Manasa Business Logic Layer
using System;
using System.Collections.Generic;
using Znalytics.PecuniaBanking.CreditcardModule.Entities;
using Znalytics.PecuniaBanking.CreditcardModule.DataAccessLayer;
using System.Security.Cryptography.X509Certificates;

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
       

 
       
        //checking account holder name
        public void CheckAccountHolderName(Creditcard customer)
        {
            if (customer.AccountHolderName != null)
            {
                _creditcardDataAccessLayer.CheckAccountHolderName(customer);
            }
            else
            {
                throw new Exception("Please mentione your name");
            }

        }
        //checking account number
        public void CheckAccountNumber(Creditcard customer)
        {
            if (customer.AccountNumber != null)
            {
                _creditcardDataAccessLayer.CheckAccountNumber(customer);
            }
            else
            {
                throw new Exception("Account number can't be null");
            }
        }

        //Approve credit card
        public void ApproveCreditCard(Creditcard customer)
        {
            if (customer.Income >= 300000)
            {
                return;
            }

        }
        // generating application number
        public void ApplicationNumber(Creditcard customer)
        {
            if (customer.Income >= 300000)
            {
                long i = customer.AadharNumber;
                long AppNumber = 0;
                int count = 0;
                while (count < 4)
                {
                    long j = i % 10;
                    AppNumber = AppNumber * 10 + j;
                    i = i / 10;
                    count++;
                }
                Console.WriteLine(AppNumber);
            }
        }
        //generating credit card number
        public void GenerateCreditCardNumber(Creditcard customer)
        {
            string crn = System.Convert.ToString(customer.AppNumber);
            long b = customer.AppNumber;
            string apno = System.Convert.ToString(b);
            string ar = System.Convert.ToString(customer.AadharNumber);
            Console.WriteLine(apno + ar);

        }


    }

}          