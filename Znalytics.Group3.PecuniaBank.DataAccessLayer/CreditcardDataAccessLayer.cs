///// Manasa Data Access Layer/////

using System.Collections.Generic;
using Znalytics.PecuniaBanking.CreditcardModule.Entities;
using Znalytics.PecuniaBanking.CustomerModule.Entities;


namespace Znalytics.PecuniaBanking.CreditcardModule.DataAccessLayer
{
/// <summary>
/// Class that represents data access layer of creditcard
/// </summary>
    public class CreditcardDataAccessLayer
    {
        //create list
        
        private static List<Customer> _customers;

        static CreditcardDataAccessLayer()
        {
            _customers = new List<Customer>()
            {
             
            };
        }

        //Method to add CreditCards
        public void ApplyCreditCard(Customer creditcard)
        {
            _customers.Add(creditcard);
        }


    }

}
    