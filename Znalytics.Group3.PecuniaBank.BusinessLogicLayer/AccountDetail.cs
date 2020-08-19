
namespace Znalytics.Group3.PecuniaBank
{
    /// <summary>
    /// Business Logic Layer for Accounts.
    /// </summary>
    public class AccountsLogic
    {
        /// <summary>
        /// validation of CustomerName.
        /// </summary>
        /// <param name="_customerName">customer Name should be less than 20 characters</param>
        /// <returns> Name of the customer</returns>
        public bool CustomerName(string _customerName)
        {
           
            if (_customerName.Length <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// validation of customer Address.
        /// </summary>
        /// <param name="_address">Customer Address should be less than 95characters</param>
        /// <returns>Address of customer</returns>
        public bool Address(string _address)
        {

            if (_address.Length <= 95)
            {
                return true;
            }
            else
            {
                return false;
                throw new System.Exception("you have entered Invalid Address");
            }
        }



        /*public bool Occupation()
         {
             set
             {
                 _occupation = value;
             }

             get
             {
                 return _occupation;
             }
         }*/
        /// <summary>
        /// validation of PAN card Number.
        /// </summary>
        /// <param name="_panCardNumber">PAN card number should be equal to 10 characters<</param>
        ///<returns>PAN card Number of customer</returns>
        public bool PanCardNumber(string _panCardNumber)
        {

            if (_panCardNumber.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
                throw new System.Exception("you have entered Invalid Pancard Number");
            }
        }

        /// <summary>
        /// validation of VoterID.
        /// </summary>
        /// <param name="_voterID">Voter-ID number should be equals to 10 charecters </param>
        ///<returns>VoterID Number of customer</returns>
        public bool VoterID(string _voterID)
        {
            if (_voterID.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
                throw new System.Exception("VoterID should contain only 10 digits");
            }
        }

        /// <summary>
        /// validation of Passport Number.
        /// </summary>
        /// <param name="_passport">Passport number should be equals to 8 charecters</param>
        /// <returns>Passport Number of customer </returns>
        public bool Passport(string _passport)
        {
            if (_passport.Length == 8)
            {
                return true;
            }
            else
            {
                return false;
                throw new System.Exception("Passport number should contain only 8 digits");
            }
        }



        /* public string DrivingLicense
         {
             set
             {
                 _drivingLicense = value;
             }

             get
             {
                 return _drivingLicense;
             }
         }*/

        /* public string UtilityBillProof
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
         }*/
    }
}

