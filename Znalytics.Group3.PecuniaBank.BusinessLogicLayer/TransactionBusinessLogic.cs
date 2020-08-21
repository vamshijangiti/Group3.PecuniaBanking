
//VAMSHI JANGITI BUSINESS LOGIC LAYER

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.Entities;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    /// <summary>
    /// Business Logic Layer For WithDrawl And Debit
    /// </summary>
   
    public class TransactionBusinessLogic
{


        

    /// <summary>
    /// Validation Of AccountNumber
    /// </summary>
    /// <param name="_accNumber">Account Number Of Customer should Be Less than 10</param>
    /// <returns></returns>
    public void ValidateAccountNumber(Transaction accNumber)
    {
        //if (_name.Length > 10)
        string l = accNumber + "";
            if (l.Length == 16)
            {
                TransactionDAL td = new TransactionDAL();
                td.GetTransactions(accNumber);
            }
            else
                throw new Exception("please check Account number");
    }




    /// <summary>
    /// Validation Of Withdrawl
    /// </summary>
    /// <param name="d1">Available Balance</param>
    /// <param name="d2">Entered Balance</param>
    /// <returns></returns>
    public bool ValidateWithDrawl(double d1, double d2)
    {
        if (d1 - d2 >= 5000)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    
    public bool ValidateDeposit(double d1,double d2)
        {
            return true;
        }

        public bool ValidateAccountNumber(long uan)
        {
            throw new NotImplementedException();
        }




        /*  public string Date
          {
              set
              {
                  //Phone number should contain 10 digits only
                  if (value.Length == 10)
                  {
                       = value;
                  }
                  else
                  {
                      throw new Exception("Phone number should contain 10 digits only");
                  }
              }
              get
              {
                  return ;
              }

          }*/


    }
}


