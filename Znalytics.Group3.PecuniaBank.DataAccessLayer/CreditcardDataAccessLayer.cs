using System.Collections.Generic;
using Znalytics.PecuniaBanking.CreditcardModule.Entities;

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
