using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.Entities
{
    /// <summary>
    /// PERSONAL LOAN FIELDS
    /// </summary>
    
        public class PersonalLoan
        {
            private string _accountNumber;
            private double _loanAmount;
            private static double _rateOfInterest = 10;
            private double _tenure;
            private double _emi;
            private int _creditScore;

            PersonalLoan personalLoan = new PersonalLoan();

            public PersonalLoan() { }
            /// <summary>
            /// Constructor For Entity Class
            /// </summary>
            /// <param name="accountNumber">Account Number </param>
            /// <param name="loanamount">sanction of loan amount</param>
            /// <param name="rateofinterest">interest to be paid per month</param>
            /// <param name="tenure">Duration of loan</param>
            /// <param name="emi"> Monthly emi</param>
            /// <param name="creditscore">credit score in your credit card</param>

            public PersonalLoan(string accountNumber, double loanAmount, double rateOfInterest, double tenure, double emi, int creditScore)
            {
                personalLoan._accountNumber = accountNumber;
                personalLoan._loanAmount = loanAmount;

                personalLoan._tenure = tenure;
                personalLoan._emi = emi;
                personalLoan._creditScore = creditScore;

            }

            //set and get methods for account number

            public string AccountNumber
            {
                set
                {
                    if (value.Length == 6)
                    {
                        _accountNumber = value;
                    }

                    else
                    {
                        throw new Exception("Enter 6 digits only\n");
                    }

                }
                get
                {
                    return _accountNumber;
                }
            }

            //set and get methods for loanamount

            public double LoanAmount
            {
                set
                {
                    if (LoanAmount >= 500000)
                    {
                        _loanAmount = value;
                    }

                    else
                    {
                        throw new Exception("not eligible\n");

                    }

                }
                get
                {
                    return _loanAmount;

                }
            }
            //set and get methods for tenure
            public double Tenure
            {
                set
                {
                    if (Tenure >= 3)
                    {
                        _tenure = value;
                    }

                    else
                    {
                        throw new Exception("not eligible\n");

                    }

                }
                get
                {
                    return _tenure;

                }
            }
            //set and get methods for rate of interest  
            public double RateOfInterest
            {

                get
                {
                    return _rateOfInterest;
                }
            }
            //set and get methods for rate of interest

            public int CreditScore
            {
                set
                {


                    if (CreditScore >= 650)//checks creditscore of a person which should starts from 650
                    {
                        _creditScore = value;
                    }
                    else
                    {
                        throw new System.Exception("your credit score is not up to the mark");
                    }
                }

                get
                {
                    return _creditScore;//returns credits score
                }
            }
            public double Emi
            {
                set
                {
                    _emi = value;
                }

                get
                {
                    return _emi;
                }
            }
        }
    } 