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
        ///<summary>
        ///<param name=customerId></param>
        ///<param name==customerAge></param>
        ///<param name=loanAmount</param>
        ///<param name=tenure></param>
        ///<param name=rateOfInterest<param>
        ///<param name=creditscore></param>
        ///</summary>
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

          
            public int CustomerId
            {
            set
            {
                if (_customerId!=0)
                {
                    _customerId = value;
                }
                else
                {
                    throw new HousingLoanException("customer id value shouldnot be null");
                }
            }
            get
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
            public double LoanAmount
            {
                set
                {
                    if (_loanAmount<=2000)//validation of loanamount
                    {
                        _loanAmount = value;
                    }
                else
                {
                    throw new HousingLoanException("loan amount exceded");
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
                else
                {
                    throw new HousingLoanException("emi should never be zero");
                }
                }
                get
                {
                    return  ((float)(((float)(_loanAmount * _rateOfInterest * (1 + _rateOfInterest) * _tenure)) / (1 + _rateOfInterest) * _tenure - 1));
                }
            }
            }
      
        }
   
