// Manasa Data Access Layer

using System.Collections.Generic;
using Znalytics.PecuniaBanking.CreditcardModule.Entities;


namespace Znalytics.PecuniaBanking.CreditcardModule.DataAccessLayer
{
/// <summary>
/// Represents data access layer of creditcard
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

        //Add
        public void Add(Creditcard customer)
        {
            _customers.Add(customer);
        }

        //public void AddCreditcard(Customer c)
        //{
        // customers.Add(c);
    }

}
    