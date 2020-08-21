using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.Entities
{
    class HousingLoanEntities
    {
        public class HousingLoan
        {
            //private fields
            private int _customerId;
            private string _loanAccepted;
            private string _loanPending;
            private string _loanRejected;
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
                set; get;
            }


            public HousingLoan(string _accountHolderName)
            {
                AccountHolderName = _accountHolderName;
            }

            /*public HousingLoan(double tenure)
            {
            }*/

            public HousingLoan()
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
            public float rateOfInterest
            {
                set; get;//autommated property
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
}