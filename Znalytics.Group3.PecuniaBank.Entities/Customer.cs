//      Done by Manasa



using System;
using System.Text.RegularExpressions;
/// <summary>
/// Represents details of customer
/// </summary>
namespace Znalytics.PecuniaBanking.CustomerModule.Entities
{
    /// <summary>
    /// Class That Represents Customer Module in PecuniaBanking Project
    /// </summary>
    public class Customer
    {
        // list of private fields
        private string _customerName;
        private int _customerId;
        private string _profession;
        private string _address;
        private double _annualIncome;
        private string _panCardNumber;
        private string _aadharCardNumber;
        private string _phoneNumber;
        private int _age;
        private string _mailId;

       // Default constructor
        public Customer() { }


        /// <summary>
        /// Constructor that initializes fields
        /// </summary>
        /// <param name="CustomerName">Name of the customer</param>
        /// <param name="CustomerId">Customer Id</param>
        /// <param name="Occupation">Occupation of customer</param>
        /// <param name="Address">Address of customer</param>
        /// <param name="Income">Income of customer</param>
        /// <param name="PanCardNumber">Pancard number of customer</param>
        /// <param name="AadharCardNumber">Aadhar card number of customer</param>
        /// <param name="PhoneNumber">Pan card number of customer</param>
        /// <param name="age">Age of the customer</param>
        /// <param name="MailId">Mail Id of the customer</param>
        Customer(string CustomerName, int CustomerId, string Profession, string Address, double AnnualIncome, string PanCardNumber, string AadharCardNumber, string PhoneNumber, int Age,string MailId)
        {
            _customerName = CustomerName;
            _customerId = CustomerId;
            _profession = Profession;
            _address = Address;
            _annualIncome = AnnualIncome;
            _panCardNumber = PanCardNumber;
            _aadharCardNumber = AadharCardNumber;
            _phoneNumber = PhoneNumber;
            _age = Age;
            _mailId = MailId;
        }


        /// <summary>
        /// Property for setting values to CustomerName field and Getting The value of the Field 
        /// </summary>
        public string CustomerName
        {
            set
            {
                Regex r = new Regex("[a-zA-Z_]$");//validating customer name that should be less than 30 characters
                //customerName should not be null or empty
                if (!string.IsNullOrEmpty(value) && r.IsMatch(value) && value.Length <= 30)
                {
                    _customerName = value;
                }
                else
                {
                    throw new System.Exception("enter the name having lessthan 30 charecter");
                }
            }
            get
            {
                return _customerName;
            }
        }
        /// <summary>
        /// Property for setting values to CustomerId field and Getting The value of the Field 
        /// </summary>
        public int CustomerId
        {
            set;
            get;
        }
        /// <summary>
        /// Property for setting values to AnnualIncome field and Getting The value of the Field 
        /// </summary>
        public double AnnualIncome
        {
            set
            {
                if (value !=0)
                {
                    _annualIncome = value;
                }
                else
                {
                    throw new Exception("Income can't be null,Please mention your Annual Income");
                }

            }
            get
            {
                return _annualIncome;
            }
        }
        /// <summary>
        /// Property for setting values to Profession field and Getting The value of the Field 
        /// </summary>

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

        /// <summary>
        /// Property for setting values to Address field and Getting The value of the Field 
        /// </summary>
        public string Address
        {
            set
            {
                _address = value;
            }
            get
            {
                return _address;
            }
        }

        /// <summary>
        /// Property for setting values to PanCardNumber field and Getting The value of the Field 
        /// </summary>
        public string PanCardNumber
        {
            set
            {
                //Validating Pan Card Number
                string checkPanCardNumber = @"^[A-Za-z]{5}[0-9]{4}[A-Za-z]{1}$";
                bool isPanCardNumberValid = Regex.IsMatch(value, checkPanCardNumber);
                if (isPanCardNumberValid == true)
                {
                    _panCardNumber = value;
                }
                else
                {
                    throw new Exception("Enter PanCardNumber and that must be 10 characters");
                }

            }
            get
            {
                return _panCardNumber;
            }
        }

        /// <summary>
        /// Property for setting values to AadharCardNumber field and Getting The value of the Field 
        /// </summary>
        public string AadharCardNumber
        {
            set
            {
                //Validating AadharCard Number
                string checkAadharCardNumber = @"^[0-9]{12}$";
                bool isAadharCardNumberValid = Regex.IsMatch(value, checkAadharCardNumber);
                if (isAadharCardNumberValid == true)
                {
                    _aadharCardNumber = value;
                }
                else
                {
                    throw new Exception("Aadharcardnumber must be 12 digits");

                }

            }
            get
            {
                return _aadharCardNumber;
            }


        }
        /// <summary>
        /// Property for setting values to PhoneNumber field and Getting The value of the Field 
        /// </summary>
        public string PhoneNumber
        {
            set
            {
                Regex r = new Regex("[0-9]$");//validating phone number  that should be 10 digits
                if (!string.IsNullOrEmpty(value) && r.IsMatch(value))
                {
                    if (value.Length == 10 && value[0] != 0)
                    {
                        _phoneNumber = value;
                    }
                }
                else
                {
                    throw new System.Exception("phone number must contain  10 digits ");
                }
            }
            get
            {
                return _phoneNumber;
            }
        }
        
        public string MailId
        {
            set
            {
                //Validating MailId
                Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                if (regex.IsMatch(value) == true)
                {
                    _mailId = value;
                }
                else
                {
                    throw new Exception("Email should not contain spaces and should include @ symbol.");
                }

            }
            get
            {
                return _mailId;
            }
        }
        /// <summary>
        /// Property for setting values to Age field and Getting The value of the Field 
        /// </summary>
        public int Age
        {
            set
            {
                if (value >= 18)
                {
                    _age = value;
                }
                else
                {
                    throw new Exception("Age should be  18 or above");
                }

            }
            get
            {
                return _age;
            }
        }
    }

}