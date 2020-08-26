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
        private string _aadharCardNumber;
        private string _phoneNumber;
        private int _age;
        private string _mailId;

        CustomerPersonalDetail customer = new CustomerPersonalDetail();
        public CustomerPersonalDetail() { }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="CustomerName"></param>
        /// <param name="CustomerId"></param>
        /// <param name="Occupation"></param>
        /// <param name="Address"></param>
        /// <param name="Income"></param>
        /// <param name="PanCardNumber"></param>
        /// <param name="AadharCardNumber"></param>
        /// <param name="PhoneNumber"></param>
        /// <param name="Age"></param>
        /// <param name="MailId"></param>
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
        /// 
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
        /// 
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