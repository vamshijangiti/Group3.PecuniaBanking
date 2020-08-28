//Manasa Entities

/// <summary>
/// Represents Entities of CreditCard Module
/// </summary>
namespace Znalytics.PecuniaBanking.CreditcardModule.Entities
{
    public class Customer
    {
        // list of details
        private int _appnumber;
        private int _cibilScore;


       /// <summary>
       /// Represents creditcard details of customer
       /// </summary>
       /// <param name="AccountHolderName">Name of AccountHolder</param>
       /// <param name="AccountNumber">Accountnumber of customer</param>
       /// <param name="Occupation">Occupation of customer</param>
       /// <param name="Address">Address of customer</param>
       /// <param name="Income">Income of customer</param>
       /// <param name="PanCardNumber">Pancardnumber of customer</param>
       /// <param name="AadharCardNumber">Aadharcardnumber of customer</param>
       /// <param name="PhoneNumber">Phonenumber of customer</param>
       /// <param name="Appnumber">Application number of customer</param>
       /// <param name="CibilScore"> Cibilscore of customer</param>
        Customer(int Appnumber,int CibilScore)
        {
            _appnumber = Appnumber;
            _cibilScore = CibilScore;
        }

        /// <summary>
        /// Customer name
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