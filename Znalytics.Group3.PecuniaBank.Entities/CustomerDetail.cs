using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomerDetail
    {
        //Private fields
        private string _customerName;
        private string _address;
        private string _occupation;
        private string _panCardNumber;
        private string _voterID;
        private string _passport;
        private string _drivingLicense;
        private int _aadhaarCardNumber;
        private string _utilityBillProof;
        private int _rationCardNumber;
        private int _employeeID;

        /// <summary>
        /// Constructor that initializes details of Savings Account
        /// </summary>
        /// <param name="customerName">Name of the customer</param>
        /// <param name="address">Address of the customer</param>
        /// <param name="occupation">Occupation of the customer</param>
        /// <param name="panCardNumber">PAN card number of the customer</param>
        /// <param name="voterID">Voter-Id number of the customer</param>
        /// <param name="passport">Passport number of the customer</param>
        /// <param name="drivingLicense">Driving license of the customer</param>
        /// <param name="aadhaarCardNumber">Aadhaar card of the cutomer</param>
        public CustomerDetail(string customerName, string address, string occupation, string panCardNumber, string voterID, string passport, string drivingLicense, int aadhaarCardNumber)
        {
            
            CustomerName = customerName;
            Address = address;
            Occupation = occupation;
            PanCardNumber = panCardNumber;
            VoterID = voterID;
            Passport = passport;
            DrivingLicense = drivingLicense;
            AadhaarCardNumber = aadhaarCardNumber;
        }
        
        
        //To Do: Add parameterless constructor


        /// <summary>
        /// Constructor that initializes details of Current Account
        /// </summary>
        /// <param name="utilityBillProof">utilityBillProof of the customer</param>
        /// <param name="rationCardNumber">Ration Card Number of the customer</param>
        /// <param name="employeeID">Employee-ID number of the customer</param>
        public void CurrentAccount(string utilityBillProof, int rationCardNumber, int employeeID)
        {
            UtilityBillProof = utilityBillProof;
            RationCardNumber = rationCardNumber;
            EmployeeID = employeeID;
        }
        /// <summary>
        ///Represents name of the customer
        /// </summary>
     
        public string CustomerName
        {
            set
            {
              _customerName = value;
             }

   
            get
            {
                return _customerName;
            }
        }
        /// <summary>
        /// Represents the Address of the customer
        /// </summary>
        public string Address
        {
            set
            {
               
                {
                    _address = value;
                }
                
            }

            get
            {
                return _address;
            }
        }
        /// <summary>
        /// Represents the Occupation of the customer
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
        /// Represents the PAN card number of the customer
        /// </summary>
        public string PanCardNumber
        {
            set
            {
               
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
        /// Represents the Voter ID number of the customer
        /// </summary>
        public string VoterID
        {
            set
            {
          
                {
                    _voterID = value;
                }
               
            }

            get
            {
                return _voterID;
            }
        }
        /// <summary>
        /// Represents the Passport number of the customer
        /// </summary>
        public string Passport
        {
            set
            {
               
                {
                    _passport = value;
                }
                
            }

            get
            {
                return _passport;
            }
        }
        /// <summary>
        /// Represents the Driving License number of the customer
        /// </summary>
        public string DrivingLicense
        {
            set
            {
                _drivingLicense = value;
            }

            get
            {
                return _drivingLicense;
            }
        }
        /// <summary>
        /// Represents the Aadhaar card number of the customer
        /// </summary>
        public int AadhaarCardNumber
        {
            set
            {

                _aadhaarCardNumber = value;
            }

            get
            {
                return _aadhaarCardNumber;
            }
        }
        /// <summary>
        /// Represents the UtilityBill Proof of the customer
        /// </summary>
        public string UtilityBillProof
        {
            set
            {
                _utilityBillProof = value;
            }
            get
            {
                return _utilityBillProof;
            }
        }
        /// <summary>
        /// Represents the RationCard Number of the customer
        /// </summary>
        public int RationCardNumber
        {
            set
            {

                _rationCardNumber = value;
            }
            get
            {
                return _rationCardNumber;
            }
        }
        /// <summary>
        /// Represents the EmployeeID Number of the customer
        /// </summary>
        public int EmployeeID
        {
            set
            {
                _employeeID = value;
            }
            get
            {
                return _employeeID;
            }
        }
    }
}
