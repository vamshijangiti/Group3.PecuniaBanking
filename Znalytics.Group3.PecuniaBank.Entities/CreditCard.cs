//Manasa Entities

using Znalytics.PecuniaBanking.CustomerModule.Entities;
/// <summary>
/// class that represents CreditCard Module CreditCard class of Pecunia Banking
/// </summary>
namespace Znalytics.PecuniaBanking.CreditcardModule.Entities
{
    /// <summary>
    /// Represents Customer class
    /// </summary>
    public class CreditCard
    {
        // list of details
        private int _appNumber;
        private int _cibilScore;
        private string _creditCardnumber;
        private Customer _customers;
        /// <summary>
        ///Constructor that initializes the fields
        /// </summary>
        /// <param name="Appnumber">Application number of the customer</param>
        /// <param name="CibilScore">Cibil score of the customer</param>
        /// <param name="CreditCardNumber">CreditCardNumber of the customer</param>
        /// <param name="Customer"></param>
        CreditCard(int AppNumber, int CibilScore,string CreditCardNumber,Customer Customer)
        {
            _appNumber = AppNumber;
            _cibilScore = CibilScore;
            _creditCardnumber = CreditCardNumber;
            _customers = Customer;
        }

        /// <summary>
        /// Application number of CreditCard
        /// </summary>
        public CreditCard()
        {

        }
        public int AppNumber
        {
            set
            {
                _appNumber = value;
            }
            get
            {
                return _appNumber;
            }
        }
        /// <summary>
        /// CibilScore of the CreditCard
        /// </summary>

        public int CibilScore
        {
            set
            {
                _cibilScore = value;
            }
            get
            {
                return _cibilScore;
            }
        }
        public Customer Customer
        {
            set
            {
                _customers = value;
            }
            get
            {
                return _customers;
            }
        }



    }

}