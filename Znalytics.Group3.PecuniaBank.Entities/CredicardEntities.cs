namespace Znalytics.PecuniaBanking.CreditcardModule.Entities
{
    public class Customer
    {
        private string _customerName;
        private string _occupation;
        private string _address;
        private int _accountNumber;
        private float _income;
        private string _panCardNumber;
        private int _aadharCardNumber;


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
               public int AccountNumber
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
               public int AadharCardNumber
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