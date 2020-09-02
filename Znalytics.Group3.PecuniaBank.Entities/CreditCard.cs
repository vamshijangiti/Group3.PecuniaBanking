//Manasa Entities

using Znalytics.PecuniaBanking.CustomerModule.Entities;

namespace Znalytics.PecuniaBanking.CreditcardModule.Entities
{
    /// <summary>
    /// Class that represents CreditCard Module CreditCard class of Pecunia Banking
    /// </summary>
    public class CreditCard
    {
        // list of private fields
        private int _appNumber;
        private int _cibilScore;
        private string _creditCardnumber;
       
        /// <summary>
        ///Constructor that initializes the fields
        /// </summary>
        /// <param name="Appnumber">Application number of the customer</param>
        /// <param name="CibilScore">Cibil score of the customer</param>
        /// <param name="CreditCardNumber">CreditCardNumber of the customer</param>
        
        CreditCard(int AppNumber, int CibilScore,string CreditCardNumber)
        {
            _appNumber = AppNumber;
            _cibilScore = CibilScore;
            _creditCardnumber = CreditCardNumber;
           
        }

        
        public CreditCard()//Default constructor
        {

        }

        /// <summary>
        /// Application number of CreditCard
        /// </summary>
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


    }

}