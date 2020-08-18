using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.Entities
{




    public class PersonalLoan
    {
        private string _accountNumber;
        private string _accountHolderName;
        private string _phoneNumber;
        private string _permanentAddress;
        private string _panCardNumber;
        private string _profession;
        private double _annualIncome;
        private double _loanAmount;


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

    }
}









           