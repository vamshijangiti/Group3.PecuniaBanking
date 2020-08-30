using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            private float _RateOfInterest=6;
            private float _emi;
            private int _creditScore;
            private bool AgeOfCustomer;
       
       

        ///<summary><param name="customerId">CustomerId</param>
        ///<param name="Customerage">Age of Customer</param>
        ///<param name="LoanAmount">Loan Amount</param>
        ///<param name="Tenure">span or period of loan</param>
        ///<param name="RateOfInterest">rate of interest of loan</param>
        ///<param name="creditScore">Credit score of customer</param>
        ///<param name="Emi">Emi of housing loan</param>
        /*public int HousingLoanId
          {
              get; set;
          }
          public HousingLoan(string accountHolderName, int HousingLoanId) : base(accountHolderName)
          {
              this.HousingLoanId = HousingLoanId;
          }*/


        public int CustomerId
            {
            set
            {
                if (_customerId!=0)
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
                        throw new HousingLoanException("customer Age is not eligible");
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
            public float LoanAmount
            {
                set
                {
                    if (_loanAmount>=600000)//validation of loanamount
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
            public float Tenure
        {
            set
            {
                if (value >= 5)
                {
                    _tenure =value;
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
                return _RateOfInterest;
            }

            }
            public float Emi
            {
                set//property
                {
                    if (_emi!=0)
                    {
                        _emi = value;//assigns emi value
                    }
                else
                {
                    throw new HousingLoanException("emi should never be zero");
                }
                }
                get
                {
                return _emi;
                   /* return  ((float)(((float)(_loanAmount * _rateOfInterest * (1 + _rateOfInterest) * _tenure)) / (1 + _rateOfInterest) * _tenure - 1));*/
                }
            }
            }
      
        }
   
