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
        List<Customer> customers = new List<Customer>();

        public void AddCustomerName(Customer c)
        {
                customers.Add(c);
            }
            
        }
    }
}
