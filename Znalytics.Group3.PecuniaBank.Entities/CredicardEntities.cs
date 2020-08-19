//Mansa Entities
'

/// <summary>
/// Represents Entities of CreditCard Module
/// </summary>
namespace Znalytics.PecuniaBanking.CreditcardModule.Entities
{
    public class Customer
    {
        // list of details
        private string _customerName;
        private string _occupation;
        private string _address;
        private long _accountNumber;
        private float _income;
        private string _panCardNumber;
        private long _aadharCardNumber;

        /// <summary>
        /// Customer name
        /// </summary>
        public string CustomerName
        {
            set
            {
                if (value.Length <= 30)
                {
                    _customerName = value;
                }
            }
            get
            {
                return _customerName;
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
        /// Account number
        /// </summary>
               public long AccountNumber
        {
            set
            {
                if (value.Length = 12)
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
               public float Income
        {
            set
            {
                if (Income > 300000)
                {
                    _income = value;
                }
            }
            get
            {
                return _income;
            }
        }
        /// <summary>
        /// pan card number
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
        /// Aadhar card Number
        /// </summary>
               public long AadharCardNumber
        {
            set
            {
                if (value.Length = 12)
                {
                    _aadharCardNumber = value;
                }
            }
            get
            {
                return _aadharCardNumber;
            }
        }   

    }

    }
}