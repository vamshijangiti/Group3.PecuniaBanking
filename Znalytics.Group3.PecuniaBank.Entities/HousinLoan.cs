

namespace Znalytics.Group3.PecuniaBank.Entities
{
   
            public class HousingLoan : Loan
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

                public int HousingLoanId
                {
                    get; set;
                }
                public HousingLoan(string accountHolderName, int HousingLoanId) : base(accountHolderName)
                {
                    this.HousingLoanId = HousingLoanId;
                }

                public HousingLoan(int _accountNo)//parameterized constructor
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

                public HousingLoan(string _accountHolderName)
                {
                    AccountHolderName = _accountHolderName;
                }

                public HousingLoan(double tenure)
                {
                }

                public HousingLoan()
                {
                }

                /* public HousingLoan()//parameter-less constructor
                 {
                 }
                */
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
                { set; get; }//automated property
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

            public class GoldLoan : Loan
            {
                private long _aadharNo;
                private int _age;
                private int _carotType;
                private double _loanAmount;
                private double _tenure;
                private double _rateOfInterest;
                private float _emi;

                public void SetAadharNo(long value)
                {
                    if (value == 12)//aadhar no should be 12 digits only
                    {

                        _aadharNo = value;
                    }
                    else
                    {
                        throw new System.Exception("invalid aadharno");
                    }
                }

                public long GetAadharNo()
                {
                    return _aadharNo;
                }

                public void SetAge(int value)
                {
                    if (_age >= 21)
                    {
                        _age = value;//age to apply goldloan should be from 21
                    }
                    else
                    {
                        throw new System.Exception("age not eligible");
                    }
                }
                public int GetAge()
                {
                    return _age;
                }
                public void SetCarotType(int value)
                {
                    _carotType = value;//carotType should be either 18 or 22
                }
                public int GetCarotType()
                {
                    return _carotType;
                }
                public void SetloanAmount(double value)
                {
                    if (_loanAmount <= 20000)
                    {
                        _loanAmount = value;//loanamount should be less than 20000
                    }
                }
                public double GetloanAmount()
                {
                    return _loanAmount;
                }
                public void Settenure(double value)
                {
                    _tenure = value;//tenure of gold loan
                }
                public double Gettenure()
                {
                    return _tenure;
                }
                public void SetrateOfInterest(double value)
                {
                    _rateOfInterest = value;//rateof interest of a gold loan
                }
                public double GetrateOfInterest()
                {
                    return _rateOfInterest;
                }
                public void Setemi(float value)
                {
                    _emi = value;//assigns emi for goldloan through below formula
                }
                public float Getemi()
                {
                    return ((float)(((float)(_loanAmount * _rateOfInterest * (1 + _rateOfInterest) * _tenure)) / (1 + _rateOfInterest) * _tenure - 1));

                }
            }
        }
    }

}
}
