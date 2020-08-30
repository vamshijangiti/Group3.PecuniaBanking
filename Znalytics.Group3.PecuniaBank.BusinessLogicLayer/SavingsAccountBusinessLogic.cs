// BusinessLogicLayer created by sriram
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.AccountEntities;
using static Znalytics.Group3.PecuniaBank.AccountEntities.SavingsAccount;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{/// <summary>
/// BusinessLogicLayer for Accounts
/// </summary>
    /*public interface ISavingsAccountBusinessLogic
    {
        //methods
        void AddSavingsAccount(SavingsAccount a);
        void AddCurrentAccount(CurrentAccount account);
        void GenerateAccountId(int id);
        void DeleteSavingsAccount(SavingsAccount account);
       
    }
    */
}

public class SavingsAccountBusinessLogic : ISavingsAccountBusinessLogic
{
    SavingsAccountDataAccessLayer _savingsaccountDataAccessLayer;


    public SavingsAccountBusinessLogic()
    {
        _savingsaccountDataAccessLayer = new SavingsAccountDataAccessLayer();
    }

    public void AddSavingsAccount(SavingsAccount savingsAccount)
    {
        try
        {


            if (savingsAccount.AccountId != 0)
            {
                _savingsaccountDataAccessLayer.AddSavingsAccount(savingsAccount);
            }
            else
            {
                throw new ApplicationException("account no should not be null");//Exception raised if accountid is zero
            }
        }
        }

    /* public void AddCurrentAccount(CurrentAccount account)
     {
         if (account.AccountId!=0)
         {
         _accountDataAccessLayer.AddCurrentAccount(account);
         }
         else
         {
             throw new ApplicationException("account should not be null");
         }
     }
    */


    //GetAccounts
    public List<SavingsAccount> GetSavingsAccount()
    {
        return _savingsaccountDataAccessLayer.GetSavingsAccount();
    }

    /*  public void DeleteCurrentAccount(CurrentAccount account)
  {
      if (account.AccountId==null)
      {
          _accountDataAccessLayer.DeleteCurrentAccount(account);
      }
  }
    */
    public void DeleteSavingsAccount(SavingsAccount savingsaccount)
    {
        try
        {

           /* if (savingsaccount.AccountId == null)
            {
                _savingsaccountDataAccessLayer.DeleteAccount(savingsaccount);
            }

            catch            {
                throw new AccountException("deletes invalid Account");
            }*/
        }
}


  