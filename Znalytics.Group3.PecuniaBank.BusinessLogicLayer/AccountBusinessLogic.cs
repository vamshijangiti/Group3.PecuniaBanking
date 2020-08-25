//ceated by shwetha
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.Entities;
namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    public class AccountBusinessLogic
    {
          //AccountsDataAccessLogic _accountDataAccessLogic;
        public class Account
        {
            // _accountDataAccessLogic = new accounstDataAccessLogic();

            public string AccountID(string Accnum)
            {
                if (Accnum.Length == 16)
                {
                    //account number should be equals to 6 digits
                    return Accnum;
                }
                else
                {
                    throw new Exception("Enter less than 16 numbers \n");
                }

            }

            public string AccountHolderName(string Accname)
            {
                if ((Accname.Length <= 20) && (Accname != null))
                {
                    //accountholdername should be less than 20characters
                    return Accname;
                }
                else
                {
                    throw new System.Exception("account holder name is wrong");
                }

            }



        }
    }
}
