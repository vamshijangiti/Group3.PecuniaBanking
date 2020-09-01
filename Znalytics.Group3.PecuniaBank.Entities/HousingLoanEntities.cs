/// <summary>
/// Housing Loan Entities
/// </summary>
namespace Znalytics.Group3.PecuniaBank.AccountEntities
{


    public class HousingLoan
    {

        //private fields
        private int _customerId;
        private int _customerAge;
        private float _loanAmount;
        private float _tenure;
        private float _RateOfInterest;
        private float _emi;
        private int _creditScore;
      



        ///<summary><param name="customerId">CustomerId</param>
        ///<param name="Customerage">Age of Customer</param>
        ///<param name="LoanAmount">Loan Amount</param>
        ///<param name="Tenure">span or period of loan</param>
        ///<param name="RateOfInterest">rate of interest of loan</param>
        ///<param name="creditScore">Credit score of customer</param>
        ///<param name="Emi">Emi of housing loan</param>

        public int CustomerId
        {
            set
            {
                if (_customerId != 0)
                {
                    _customerId = value;//customerid assigned to value
                }
                else
                {
                    throw new HousingLoanException("customer id value shouldnot be null");
                }
            }
            get//get property
            {
                return _customerId;
            }
        }

        public HousingLoan()//parameterless constructor
        {
        }


        public int CustomerAge
        {
            set//set property
            {
                if (value >= 21)
                {
                    _customerAge = value;//assigns customer value of age
                }
                else
                {
                    throw new HousingLoanException("customer Age is not eligible");//raises Exception if customer age is not greater than 21
                }
            }
            get
            {
                return _customerAge;//returns customer age
            }

        }

        public int CreditScore
        {
            set
            {
                if (_creditScore >= 650)//credit score should be greater than 650
                {
                    _creditScore = value;//assigns creditscore
                }
                else
                {
                    throw new HousingLoanException("credit score should be more than 650");
                }
            }
            get
            {
                return _creditScore;//returns creditscore
            }
        }


        public float LoanAmount
        {
            set
            {
                if (_loanAmount >= 600000)//validation of loanamount
                {
                    _loanAmount = value;
                }
                else
                {
                    throw new HousingLoanException("loan amount exceded");//raises exception if loan amount is exceeded
                }
            }
            get
            {
                return _loanAmount;//returns loanamount
            }
        }

        public float Tenure
        {
            set
            {
                if (value >= 5)//tenure period should be greater than 5 yrs
                {
                    _tenure = value;
                }
                else
                {
                    throw new HousingLoanException("tenure is not greater than 5 yrs");
                }
            }
            get
            {
                return _tenure;
            }
        }
        public float rateOfInterest
        {
            get
            {
                return _RateOfInterest;//returns rate of interest
            }

        }
        public float Emi
        {
            set//property
            {
                if (_emi != 0)
                {
                    _emi = value;//assigns emi value
                }
                else
                {
                    throw new HousingLoanException("emi should never be zero ");
                }
            }
            get
            {
                return ((float)(((float)(_loanAmount * _RateOfInterest * (1 + _RateOfInterest) * _tenure)) / (1 + _RateOfInterest) * _tenure - 1));


            }
        }
    }

}

