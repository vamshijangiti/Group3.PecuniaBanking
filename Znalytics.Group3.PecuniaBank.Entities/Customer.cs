//Manasa Entities

/// <summary>
/// Represents Entities of CreditCard Module
/// </summary>
namespace Znalytics.PecuniaBanking.CreditcardModule.Entities
{
    public class Customer
    {
        // list of details
        private string _accountHolderName;
        private long _accountNumber;
        private string _occupation;
        private string _address;
        private double _income;
        private string _panCardNumber;
        private long _aadharCardNumber;
        private long _phoneNumber;
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
        Customer(string AccountHolderName, long AccountNumber, string Occupation, string Address, double Income, string PanCardNumber, long AadharCardNumber, long PhoneNumber,int Appnumber,int CibilScore)
        {
            _accountHolderName = AccountHolderName;
            _accountNumber = AccountNumber;
            _occupation = Occupation;
            _address = Address;
            _income = Income;
            _panCardNumber = PanCardNumber;
            _aadharCardNumber = AadharCardNumber;
            _phoneNumber = PhoneNumber;
            _appnumber = Appnumber;
            _cibilScore = CibilScore;
        }

        /// <summary>
        /// Customer name
        /// </summary>
        public string AccountHolderName
        {
            set
            {
                if (value.Length <= 30)
                {
                    _accountHolderName = value;
                }
            }
            get
            {
                return _accountHolderName;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public long AccountNumber
        {
            set
            {
                if (value.length = 12)
                {
                    _accountNumber = value;
                }

            }
            get
            {
                return _accountNumber;
            }
        }
        /// <summary>
        /// Income
        /// </summary>
        public double Income
        {
            set
            {
                _income = value;
            }
            get
            {
                return _income;
            }
        }
        /// <summary>
        /// Occupation
        /// </summary>

        public string Occupation
        {
            set
            {
                _occupation = value;
            }
            get
            {
                return _occupation;
            }
        }

        /// <summary>
        /// Address
        /// </summary>
        public string Address
        {
            set
            {
                _address = value;
            }
            get
            {
                return _address;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string PanCardNumber
        {
            set
            {
                _panCardNumber = value;
            }
            get
            {
                return _panCardNumber;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public long AadharCardNumber
        {
            set
            {
                _aadharCardNumber = value;
            }
            get
            {
                return _aadharCardNumber;
            }
        }

        public long PhoneNumber
        {
            set
            {
                _phoneNumber = value;
            }
            get
            {
                return _phoneNumber;
            }
        }
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