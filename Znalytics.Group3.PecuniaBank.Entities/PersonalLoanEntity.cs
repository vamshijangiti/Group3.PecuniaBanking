///Navya PersonalLoanEntityLayer
///Entities for Personal loan
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.Entities
{

    /// <summary>
    /// Entity layer for personal loan
    /// </summary>

    public class PersonalLoanEntity
    {
        private int _customerId;
        private float _loanAmount;
        private static float _rateOfInterest = 10;
        private float _tenure;
        private float _emi;
        private int _creditScore;

        public PersonalLoanEntity() { }
        /// <summary>
        /// Constructor For Entity Class
        /// </summary>
        /// <param name="customerId">CustomerId </param>
        /// <param name="loanamount">sanction of loan amount</param>
        /// <param name="rateofinterest">interest to be paid per month</param>
        /// <param name="tenure">Duration of loan</param>
        /// <param name="emi"> Monthly emi</param>
        /// <param name="creditscore">credit score in your credit card</param>

        public PersonalLoanEntity(int CustomerId, float loanAmount, float tenure, float emi, int creditScore)
        {

            this._customerId = CustomerId ;
            this._loanAmount = LoanAmount;
            this._tenure = Tenure;
            this._emi = Emi;
            this._creditScore = CreditScore;



        }

        //set and get methods for customerid

        public int CustomerId
        {
            set
            {
                 
                 _customerId = value;
                   
            }

            get
            {
                return _customerId;
            }
        }

        //set and get methods for loanamount

        public float LoanAmount
        {
            set
            {

                    if (value >= 50000)
                    {
                        _loanAmount = value;
                    }

                    else
                    {
                        throw new PersonalLoanException ("not eligible");

                    }

            }
                
                
            get
            {
                return _loanAmount;

            }
        }
        //set and get methods for tenure
        public float Tenure
        {
            set
            {
                
                    if (value >= 10)
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
        public float RateOfInterest
        {

            get
            {
                return _rateOfInterest;
            }
        }
        //set and get methods for rate of interest
        public float Emi
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

        public int CreditScore
        {
            set
            {
                _creditScore = value;
            }
            get
            {
                return _creditScore;//returns credits score
            }
        }

    }
}








