//      Done by Manasa

using System;
/// <summary>
/// Represents details of customer
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
        private string _aadharCardNumber;
        private string _phoneNumber;
        private int _age;
        private string _mailId;

        CustomerPersonalDetail customer = new CustomerPersonalDetail();
       // Creating constructor
        public CustomerPersonalDetail() { }


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
        CustomerPersonalDetail(string CustomerName, string CustomerId, string Occupation, string Address, double Income, string PanCardNumber, string AadharCardNumber, string PhoneNumber, int Age,string MailId)
        {
            _customerName = CustomerName;
            _customerId = CustomerId;
            _occupation = Occupation;
            _address = Address;
            _income = Income;
            _panCardNumber = PanCardNumber;
            _aadharCardNumber = AadharCardNumber;
            _phoneNumber = PhoneNumber;
            _age = Age;
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
        /// Pan card number
        /// </summary>
        public string PanCardNumber
        {
            set
            {
                if (value.Length ==10)
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
        public string AadharCardNumber
        {
            set
            {
                if(value.Length==12)
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
        public string PhoneNumber
        {
            set
            {
                if(value.Length==10)
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
        public int Age

        {
            set
            {
                _age = value;
            }
            get
            {
                return _age;
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