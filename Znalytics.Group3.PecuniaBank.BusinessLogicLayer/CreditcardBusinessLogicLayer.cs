// Manasa Business Logic Layer

using Znalytics.PecuniaBanking.CreditcardModule.Entities;
using Znalytics.PecuniaBanking.DataAccessLayer;

/// <summary>
/// Represents BusinessLogic Layer of Creditcard 
/// </summary>
namespace Znalytics.PecuniaBanking.CreditcardModule.BusinessLogicLayer
{

        public class CreditcardBusinessLogicLayer
        {
        //Validating customer name
        public void CheckCustomerName(string customerName)
        {
            if (Creditcard.CustomerName != null)
            {
                CreditcardDataAccesLayer cdl = new CreditcardDataAccesLayer();
                cdl.AddCustomer(customerName);
            }
            else
            {
                throw new Exception("Please mentione your name");
            }
            
        }
        // validating account number
        public void CheckAccountNumber(long accountnumber)
        {
            if (Creditcard.AccountNumber != null)
            {
                CreditcardDataAccesLayer cdl = new CreditcardDataAccesLayer();
                cdl.AddCustomer(accountNumber);
            }
            else
            {
                throw new Exception("Please mentione your name");
            }
            
        }
    }
}
