//      Done by Manasa

using System;
using System.Text.RegularExpressions;
/// <summary>
/// Represents details of customer
/// </summary>
namespace Znalytics.PecuniaBanking.CustomerDetailModule.Entities
{
    public class CustomerDetail
    {
        // list of details
        private string _customerName;
        private string _customerId;
        private string _profession;
        private string _address;
        private double _annualIncome;
        private string _panCardNumber;
        private string _aadharCardNumber;
        private string _phoneNumber;
        private DateTime _dateOfBirth;
        private string _mailId;

        CustomerDetail customer = new CustomerDetail();
       // Creating constructor
        public CustomerDetail() { }


        /// <summary>
        /// Creating Constructor
        /// </summary>
        /// <param name="CustomerName">Name of the customer</param>
        /// <param name="CustomerId">Customer Id</param>
        /// <param name="Occupation">Occupation of customer</param>
        /// <param name="Address">Address of customer</param>
        /// <param name="Income">Income of customer</param>
        /// <param name="PanCardNumber">Pancard number of customer</param>
        /// <param name="AadharCardNumber">Aadhae card number of customer</param>
        /// <param name="PhoneNumber">Pan card number of customer</param>
        /// <param name="Age">Age of the customer</param>
        /// <param name="MailId">Mail Id of the customer</param>
        CustomerDetail(string CustomerName, string CustomerId, string Profession, string Address, double AnnualIncome, string PanCardNumber, string AadharCardNumber, string PhoneNumber, DateTime DateOfBirth,string MailId)
        {
            _customerName = CustomerName;
            _customerId = CustomerId;
            _profession = Profession;
            _address = Address;
            _annualIncome = AnnualIncome;
            _panCardNumber = PanCardNumber;
            _aadharCardNumber = AadharCardNumber;
            _phoneNumber = PhoneNumber;
            _dateOfBirth = DateOfBirth;
            _mailId = MailId;
        }


        /// <summary>
        /// Customer name
        /// </summary>
        public string CustomerName
        {
            set
            {
                if (value.Length <= 30)
                {
                    _customerName = value;
                }
                else
                {
                    throw new Exception("Name should be lessthan 30 characters");

                }

            }
            get
            {
                return _customerName;
            }
        }

        /// <summary>
        /// Customer Id
        /// </summary>
        public string CustomerId
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
        /// <summary>
        /// Income
        /// </summary>
        public double Income
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
        /// Occupation
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
        /// Address
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
        /// Pan card number
        /// </summary>
        public string PanCardNumber
        {
            set
            {
                string checkPanCardNumber = @"^[A-Za-z]{5}[0-9]{4}[A-Za-z]{1}$";
                bool isPanCardNumberValid = Regex.IsMatch(customer.PanCardNumber, checkPanCardNumber);
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
        /// Aadhar card number
        /// </summary>
        public string AadharCardNumber
        {
            set
            {
                string checkAadharCardNumber = @"^[0-9]{12}$";
                bool isAadharCardNumberValid = Regex.IsMatch(customer.AadharCardNumber, checkAadharCardNumber);
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
        /// Phone number
        /// </summary>
        public string PhoneNumber
        {
            set
            {
                //string checkPhoneNumber = @"^[0-9]{10}$";
                string checkPhoneNumber = @"^(\+)([1 - 9]{ 2})(\s)(\d{ 10})$";
                bool isPhoneNumberValid = Regex.IsMatch(customer.AadharCardNumber, checkPhoneNumber);
                if (isPhoneNumberValid == true)
                {
                    _phoneNumber = value;
                }

                else
                {
                    throw new Exception("Phonenumber must be 10 digits");
                }
            }
           
            get
            {
                return _phoneNumber;
            }
        }
        /// <summary>
        /// Age
        /// </summary>
        public DateTime DateOfBirth

        {
            set
            {
                DateTime dateOfBirth = Convert.ToDateTime("1998-07-03 7:00 am");
                DateTime presentDate = DateTime.Now;
                TimeSpan timeSpan = presentDate - dateOfBirth;
                int age = Convert.ToInt32(timeSpan.TotalDays / 365);

                if (age >= 18)
                {
                    _dateOfBirth = value;
                }


                else
                {
                    throw new Exception("Age must be 18 and above");

                }
            }

            get
            {
                return _dateOfBirth;
            }
        }
        /// <summary>
        /// Mail Id
        /// </summary>
        public string MailId
        {
            set
            {
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
    }

}