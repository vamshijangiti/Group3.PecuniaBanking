

namespace Znalytics.Group3.PecuniaBank.Entities
{
    public class Loan

    {
        private int _accountNo;
        private string _accountHolderName;
        private int _ageOfCustomer;
        private double _loanAmount;
        private double _tenure;
        private float _rateOfInterest;
        private float _emi;
        private int _creditScore;
        private bool AgeOfCustomer;
        public Loan(int _accountNo)//parameterized constructor
        {
            AccountNo = _accountNo;
        }
        public int AccountNo
        {
            set
            {
                if (value == 12)//12 digit AccountNo
                {
                    _accountNo = value;
                }
                else
                {
                    throw new System.Exception("Invalid account no");
                }
            }
            get
            {
                return _accountNo;//get method
            }
        }

        public Loan(string _accountHolderName)
        {
            AccountHolderName = _accountHolderName;
        }
        public string AccountHolderName
        {
            set
            {
                if (value.Length <= 30)
                {
                    _accountHolderName = value;//assigns value to accountHolderName
                }
                else
                {
                    throw new System.Exception("Invalid AccountHolder");
                }
            }
            get
            {
                return _accountHolderName;

            }
        }
        public void SetAgeOfCustomer(int value)
        {
            if (value >= 21)
            {
                _ageOfCustomer = value;//ageof customer should start from 21
            }
            else
            {
                throw new System.Exception("your age is not eligible");
            }
        }
        public int GetAgeOfCustomer()
        {
            return _ageOfCustomer;
        }
        public void SetCreditScore(int value)
        {
            if (_creditScore >= 650)//checks creditscore of a person which should starts from 650
            {
                _creditScore = value;
            }
            else
            {
                throw new System.Exception("your credit score is not up to the mark");
            }
        }
        public int GetCreditScore()
        {
            return _creditScore;//returns credits score
        }
        public void SetLoanAmount(double value)
        {
            if (_loanAmount <= 20000)//checks loan amount 
            {
                _loanAmount = value;
            }
            else
            {
                throw new System.Exception("loan amount exceeded");//raises loanamount exceded 
            }
        }
        public double GetLoanAmount()
        {
            return _loanAmount;
        }
        public double Tenure
        { set; get; }
        public void SetRateOfInterest(float value)
        {
            _rateOfInterest = value;//rate of Interest fora customer
        }
        public float GetRateOfInterest()
        {
            return _rateOfInterest;
        }
        public void Setemi(float value)
        {
            _emi = value;//assigns emi calculated value through formula
        }
        public float GetEmi()
        {
            return ((float)(((float)(_loanAmount * _rateOfInterest * (1 + _rateOfInterest) * _tenure)) / (1 + _rateOfInterest) * _tenure - 1));
        }

    }


}



