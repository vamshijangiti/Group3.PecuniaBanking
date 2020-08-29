// Manasa Business Logic Layer
using System;
using System.Collections.Generic;
using Znalytics.PecuniaBanking.CreditcardModule.Entities;
using Znalytics.PecuniaBanking.CreditcardModule.DataAccessLayer;
using System.Security.Cryptography.X509Certificates;
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


    }




    //checking account number


    /* if (c.CibilScore != 0)
     {
         _creditcardDataAccessLayer.ApplyCreditCard(c);
     }
     else
     {
         throw new Exception("Account number can't be null");
     }
 }

 //Approve credit card
 public void ApproveCreditCard(CreditCard c)
 {
     /*if (creditcard.AnnualIncome >= 300000)
     {
         return;
     }*/
}


       
       
        //generating credit card number
        /*public string GenerateCreditCard(Customer creditcard)
        {
            long b = ApplicationNumber(creditcard);
            string apno = System.Convert.ToString(b);
            string ar = System.Convert.ToString(creditcard.AadharCardNumber);
            string CreditcardNumber = System.Convert.ToString(apno + ar);
            return CreditcardNumber;

        }

        public void ViewCreditCard()
        {

        }

        public void CreditCardLimitIncrease(Customer creditcard)
        {
            if (creditcard.CibilScore >= 750)
            {
                return;
            }

        }*/


    }

}