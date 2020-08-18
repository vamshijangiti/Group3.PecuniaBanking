//NAVYA personalloanbusinesslogiclayer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.Entities;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    /// <summary>
    /// Business logic layer for personalloan
    /// </summary>
   public  class PersonalLoanBusinessLogicLayer
    {

        /// <summary>
        /// validation of account number
        /// </summary>
        /// <param name="Accno"><account number should be less than 6>
        /// <returns></returns>
        public string AccountNumber(string Accno)
        {
            if(Accno.Length==6)
  //account number length should be equals to 6 digits
            {
                return Accno;
            }
            else
            {
                   throw new Exception("Enter 6 digits only\n");
            }

        }
        public string AccountHolderName(string Accname)
        {
            if (Accname.Length <= 20)
    //account name length should be less than 20characters
            {
                return Accname;
            }
            else
            {
                throw new System.Exception("account holder name is wrong");
            }

        }
        public string PhoneNumber(string PhneNo)
        {
            if(PhneNo.Length==10)
    //phone number should be equals to 10 digits
            {
                return PhneNo;
            }
            else
            {
                throw new System.Exception("enter ten digits of phone number");
            }
        }
        //public float emi()
        
        
       // return ((float)(((float)(_loanAmount* _rateOfInterest * (1 + _rateOfInterest) * _tenure)) / (1 + _rateOfInterest) * _tenure - 1));

    }
}
