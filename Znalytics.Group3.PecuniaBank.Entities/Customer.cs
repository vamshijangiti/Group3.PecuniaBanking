//Manasa Entities

/// <summary>
/// class that represents CreditCard Module Customer class of Pecunia Banking
/// </summary>
namespace Znalytics.PecuniaBanking.CreditcardModule.Entities
{
    /// <summary>
    /// Represents Customer class
    /// </summary>
    public class Customer
    {
        // list of details
        private int _appnumber;
        private int _cibilScore;

        /// <summary>
        ///Constructor that initializes the fields
        /// </summary>
        /// <param name="Appnumber">Application number of the customer</param>
        /// <param name="CibilScore">Cibil score of the customer</param>
        Customer(int Appnumber, int CibilScore)
        {
            _appnumber = Appnumber;
            _cibilScore = CibilScore;
        }

        /// <summary>
        /// Application number of customer
        /// </summary>

        public int Appnumber
        {
            set
            {
                _appnumber = value;
            }
            get
            {
                return _appnumber;
            }
        }
        /// <summary>
        /// CibilScore of the Customer
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


    }

}