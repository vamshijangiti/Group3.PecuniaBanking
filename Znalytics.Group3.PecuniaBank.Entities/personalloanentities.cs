using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.Entities
{




    public class PersonalLoan
    {
        private long  _accountNumber;
        private string _accountId;
        private string _phoneNumber;
        private string _permanentAddress;
        private string _panCardNumber;
        private string _profession;
        private double  _annualIncome;
        private double  _loanAmount;
        private double _rateOfInterest;
        private double _tenure;
        private float _emi;
        private int _creditScore;               
      

       //set and get methods for account number

        public long AccountNumber
        {
            set
            {
               
                {
                    _accountNumber = value;
                }

            }
            get
            {
                return _accountNumber;
            }
        }
        //set and get methods for account holder name

        public String AccountId
        {
            set
            {

                if (AccountId.Length == 5)
                {
                    _accountId = value;
                }

                else
                {
                    throw new Exception("Enter 5 digits only\n");

                }
            }
            get
            {
                return _accountId;
            }
        }
         
         
        //set and get methods for phone number

        public String PhoneNumber
        {
           set
            {
                if (PhoneNumber .Length == 10)
                {
                    _phoneNumber = value;
                }

                else
                {
                    throw new Exception("Enter 10 digits only\n");

                }

            }
            get
            {
                return _phoneNumber;
            }
        }
        //set and get methods for permanent address
        public String PermanentAddress
        {
            set
            {
            int HouseNumber;
            bool b;
            string address = " ";
            b = int.TryParse(address, out HouseNumber);
            if (b == true)
            {
                System.Console.WriteLine();
            }

            _permanentAddress = value;
            }
           get
           {
            return _permanentAddress;
           }
    }
        //set and get methods for pancardnumber

        public String PanCardNumber
        {
            set
            {
            int Number;
            bool b;
            string Pan = " ";
            b = int.TryParse(Pan, out Number);
            if (b == true)
            {
                System.Console.WriteLine();
            }

            _panCardNumber = value;
            }
           get
           {
            return _panCardNumber;
           }

        }
    //set and get methods for profession
    public String Profession
        {
            set
            {
                _profession = value;
            }
            get
            {
                return _profession;
            }
        }
        //set and get methods for annual income

        public double  AnnualIncome
        {
            set
            {
                if (AnnualIncome >=400000 )
                {
                    _annualIncome = value;
                }

                else
                {
                    throw new Exception("not eligible\n");

                }

            }
            get
            {
                return _annualIncome;
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
            set
            {
                _rateOfInterest = value;
            }
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
                _emi= value;
            }
            get
            {
             return ((float)(((float)(_loanAmount * _rateOfInterest * (1 + _rateOfInterest) * _tenure)) / (1 + _rateOfInterest) * _tenure - 1));
                
            }
        }

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

    }
}









           