//Manasa Entities

using System;
/// <summary>
/// Represents Entities of CreditCard Module
/// </summary>
namespace Znalytics.PecuniaBanking.CustomerPersonalDetailModule.Entities
{
    public class CustomerPersonalDetail
    {
        // list of details
        private string _customerName;
        private string _customerId;
        private string _occupation;
        private string _address;
        private double _income;
        private string _panCardNumber;
        private long _aadharCardNumber;
        private long _phoneNumber;
        private DateTime _dateOfBirth;
        private string _mailId;

        CustomerPersonalDetail customer = new CustomerPersonalDetail();
        public CustomerPersonalDetail() { }


        /// <summary>
        /// Details of Customer
        /// </summary>
        /// <param name="CustomerName">Name of the customer</param>
        /// <param name="CustomerId">customer Id</param>
        /// <param name="Occupation">Occupation Customer</param>
        /// <param name="Address">Customer's Address</param>
        /// <param name="Income">Income of customer</param>
        /// <param name="PanCardNumber">Pancardnumber of customer</param>
        /// <param name="AadharCardNumber">Aadharcardnumber of customer</param>
        /// <param name="PhoneNumber">Phonenumber of customer</param>
        /// <param name="DateOfBirth">date of birth of customer</param>
        /// <param name="MailId">Mail id of customer</param>
        CustomerPersonalDetail(string CustomerName, string CustomerId, string Occupation, string Address, double Income, string PanCardNumber, long AadharCardNumber, long PhoneNumber, DateTime DateOfBirth,string MailId)
        {
            _customerName = CustomerName;
            _customerId = CustomerId;
            _occupation = Occupation;
            _address = Address;
            _income = Income;
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
        /// 
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
                _income = value;
            }
            get
            {
                return _income;
            }
        }
        /// <summary>
        /// Occupation
        /// </summary>

        public string Occupation
        {
            set
            {
                _occupation = value;
            }
            get
            {
                return _occupation;
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
        /// 
        /// </summary>
        public string PanCardNumber
        {
            set
            {
                if (value.Length = 10)
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
        /// 
        /// </summary>
        public long AadharCardNumber
        {
            set
            {
                _aadharCardNumber = value;
            }
            get
            {
                return _aadharCardNumber;
            }
        }

        public long PhoneNumber
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
        /// <summary>
        /// 
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
        /// 
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