using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
   public  class LoansBusiness
    {
        public string AccountNumber(string Accno)
        {
            if(Accno.Length==6)
            {
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
            {
                return PhneNo;
            }
            else
            {
                throw new System.Exception("enter ten digits of phone number");
            }
        }
      

    }
}
