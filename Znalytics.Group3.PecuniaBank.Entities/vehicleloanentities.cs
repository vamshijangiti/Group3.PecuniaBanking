///Entities for vehicle loan
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.Entities
{

    /// <summary>
    /// Entity layer for vehicle loan
    /// </summary>

    public class VehicleLoan
    {
        private string _accountNumber;
        private string _accountHolderName;
        private string _phoneNumber;
        private string _permanentAddress;
        private string _panCardNumber;
        private string _profession;
        private double _annualIncome;
        private double _loanAmount;
        private double _rateOfInterest;
        private double _tenure;
        private float _emi;
        public VehicleLoan () { }


        //set and get methods for account number

        public String AccountNumber
        {
            set
            {
                _accountNumber = value;
            }
            get
            {
                return _accountNumber;
            }
        }
        //set and get methods for account holder name

        public String AccountHolderName
        {
            set
            {
                _accountHolderName = value;
            }
            get
            {
                return _accountHolderName;
            }
        }
        //set and get methods for phone number

        public String PhoneNumber
        {
            set
            {
                _phoneNumber = value;
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

        public double AnnualIncome
        {
            set
            {
                _annualIncome = value;
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
                _loanAmount = value;
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
                _tenure = value;

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
                _emi = value;
            }
            get
            {
                return ((float)(((float)(_loanAmount * _rateOfInterest * (1 + _rateOfInterest) * _tenure)) / (1 + _rateOfInterest) * _tenure - 1));


            }
        }

    }
}












