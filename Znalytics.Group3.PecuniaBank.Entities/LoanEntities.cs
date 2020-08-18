using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.Entities
{
  public  class LoanEntities
    {
        
        private string _accountNumber;
        private string _accountHolderName;
        private string _phoneNumber;
        private string _permanentAddress;
        private string _panCardNumber;
        private string _profession;
        private double _annualIncome;
        private double _loanAmount;
        public  LoanEntities() { }


       LoanEntities(string _accountNumber,string _accountHolderName,string _phoneNumber,string _permanentAddress,
           string _panCardNumber,string _profession,double _annualIncome,double _loanAmount)
        {
            this._accountNumber = _accountNumber;
            this._accountHolderName=_accountHolderName;
            this._phoneNumber = _phoneNumber;
            this._permanentAddress = _permanentAddress;
            this._panCardNumber = _panCardNumber;
            this._profession = _profession;
            this._annualIncome = _annualIncome;
            this._loanAmount = _loanAmount;





        }

        public string AccountNumber
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

        public string AccountHolderName
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

        public string PhoneNumber
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

        public string PermanentAddress
        {
            set
            {
                _permanentAddress= value;

            }
            get
            {
                return _permanentAddress;
            }


        }

        public string PanCardNumber
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
        public string Profession
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
