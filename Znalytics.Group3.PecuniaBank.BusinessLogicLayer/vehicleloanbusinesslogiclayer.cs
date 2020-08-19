//NAVYA vehicleloanbusinesslogiclayer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    /// <summary>
    /// Business logic layer for vehicle loan
    /// </summary>
    public class vehicleLoanBusinessLogicLayer

    { 
    
        public class LoansBusiness
        {
            public string AccountNumber(string Accno)
            {
                if (Accno.Length == 6)
                {
            //account number should be equals to 6 digits
                    return Accno;
                }
                else
                {
                    throw new Exception("Enter less than 16\n");
                }

            }
            public string AccountHolderName(string Accname)
            {
                if (Accname.Length <= 20)
                {
            //accountholdername should be less than 20characters
                    return Accname;
                }
                else
                {
                    throw new System.Exception("account holder name is wrong");
                }

            }
            public string PhoneNumber(string PhneNo)
            {
                if (PhneNo.Length == 10)
                {
            //phone number should be equal to 10 digits
                    return PhneNo;
                }
                else
                {
                    throw new System.Exception("enter ten digits of phone number");
                }
            }



        }
    }

}

