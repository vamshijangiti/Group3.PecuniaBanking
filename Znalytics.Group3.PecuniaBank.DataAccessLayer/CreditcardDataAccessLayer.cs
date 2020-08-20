// Manasa Data Access Layer

using System.Collections.Generic;
using Znalytics.PecuniaBanking.CreditcardModule.Entities;

/// <summary>
/// Represnts Dataaccess Layer of Creditcard Module
/// </summary>
namespace Znalytics.PecuniaBanking.CreditcardModule.DataAccessLayer
{
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
    