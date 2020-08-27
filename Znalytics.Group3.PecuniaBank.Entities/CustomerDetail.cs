//      Done by Manasa

using System;
/// <summary>
/// Represents details of customer
/// </summary>
namespace Znalytics.PecuniaBanking.CustomerPersonalDetailModule.Entities
{
    public class CustomerDetail
    {
        // list of details
        private string _customerName;
        private string _customerId;
        private string _profession;
        private string _address;
        private double _annualIncome;
        private long _panCardNumber;
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
        CustomerDetail(string CustomerName, string CustomerId, string Profession, string Address, double AnnualIncome, long PanCardNumber, long AadharCardNumber, long PhoneNumber, DateTime DateOfBirth,string MailId)
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
 6       public string CustomerName
        {
            set
            {
                if (value.Length <= 30)
                {
                    _customerName = value;
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
                _annualIncome = value;
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
        public long PanCardNumber
        {
            set
            {
                if(value.Length=10)
                {
                    _panCardNumber = value;
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
        public long AadharCardNumber
        {
            set
            {
                if(value.Length=12)
                {
                    _aadharCardNumber = value;
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
        public long PhoneNumber
        {
            set
            {
                if(value.Length=10)
                {
                    _phoneNumber = value;
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
                _dateOfBirth = value;
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
                _mailId = value;
            }
            get
            {
                return _mailId;
            }
        }



    }

}