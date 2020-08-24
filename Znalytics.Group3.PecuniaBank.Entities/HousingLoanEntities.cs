using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Housing Loan Entities
/// </summary>
namespace Znalytics.Group3.PecuniaBank.Entities
{
 
        
        public class HousingLoan
        {
            //private fields
            private int _customerId;
            private int _customerAge;
            private double _loanAmount;
            private double _tenure;
            private float _rateOfInterest;
            private float _emi;
            private int _creditScore;
            private bool AgeOfCustomer;

          /*public int HousingLoanId
            {
                get; set;
            }
            public HousingLoan(string accountHolderName, int HousingLoanId) : base(accountHolderName)
            {
                this.HousingLoanId = HousingLoanId;
            }*/

            public HousingLoan(int _customerId)//parameterized constructor
            {
                if (CustomerId!=0)
                {
                    this._customerId = CustomerId;//this refers to current object
                }
                else
                {
                    throw new Exception("customer id is incorrect");//throws exception 
                }
            }
            public int CustomerId
            {
                set; get;//automated property
            }


           /* public HousingLoan(string _accountHolderName)
            {
                AccountHolderName = _accountHolderName;
            }

            /*public HousingLoan(double tenure)
            {
            }*/

            public HousingLoan()//parameterless constructor
            {
            }

            /* public HousingLoan()//parameter-less constructor
             {
             }
            */
            public string AccountHolderName
            {
                set; get;//automated property
            }
            /*public HousingLoan(int _customerAge)
            {
                CustomerAge = _customerAge;
            }*/
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
                        throw new Exception("customer Age is not eligible");
                    }
                }
                    get
                   {
                        return _customerAge;//returns customer age
                    }

                }
            /*public void SetAgeOfCustomer(int value)
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
            
}*/
            public int CreditScore
            {
                set
                {
                    if (_creditScore>=650)
                    {
                        _creditScore = value;//assigns creditscore
                    }
                }
                get
                {
                    return _creditScore;//returns creditscore
                }
            }
            /*public void SetCreditScore(int value)
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
            }*/
            public double LoanAmount
            {
                set
                {
                    if (_loanAmount<=2000)//validation of loanamount
                    {
                        _loanAmount = value;
                    }
                }
                get
                {
                    return _loanAmount;//returns loanamount
                }
            }
            /*public void SetLoanAmount(double value)
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
            */
            public double Tenure
            { set; get; }//automated property
            public float rateOfInterest
            {
                set; get;//autommated property
            }
            public float Emi
            {
                set//property
                {
                    if (_emi!=0)
                    {
                        _emi = value;//assigns emi value
                    }
                }
                get
                {
                    return  ((float)(((float)(_loanAmount * _rateOfInterest * (1 + _rateOfInterest) * _tenure)) / (1 + _rateOfInterest) * _tenure - 1));
                }
            }
            }
            /*public void Setemi(float value)
            {
                _emi = value;//assigns emi calculated value through formula
            }
            public float GetEmi()
            {
                return ((float)(((float)(_loanAmount * _rateOfInterest * (1 + _rateOfInterest) * _tenure)) / (1 + _rateOfInterest) * _tenure - 1));
            }*/

        }
   
