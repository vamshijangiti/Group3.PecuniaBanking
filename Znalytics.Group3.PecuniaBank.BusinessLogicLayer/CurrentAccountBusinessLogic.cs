using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.AccountEntities;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    public class CurrentAccountBusinessLogic : ICurrentAccountBusinessLogic

    {
        CurrentAccountDataAccessLayer currentAccountDataAccessLayer = new CurrentAccountDataAccessLayer();

        /// <summary>
        /// Adds Current Account
        /// </summary>
        /// <param name="currentAccount"></param>
        public void AddCurrentAccount(CurrentAccount currentAccount)
        {
            try
            {
                if (currentAccount.AccountNumber != 0)
                {
                    currentAccountDataAccessLayer.AddCurrentAccount(currentAccount);
                }
            }


            catch (Exception e)
            {
                throw new AccountException("accountno is not added", e);//exception raised if accounId is not added
            }
        }

        public void DeleteCurrentAccount(CurrentAccount currentAccount, int AccountId)
        {
            try
            {
                if (currentAccount.AccountNumber != 0)
                {
                    currentAccountDataAccessLayer.DeleteCurrentAccount(currentAccount);
                }
            }
            catch (Exception e)
            {
                throw new AccountException("account is not deleted", e);
            }

        }

        public List<CurrentAccount> GetCurrentAccounts()
        {
            return GetCurrentAccounts();//retrieves all currentAccount 
        }
    }

  /*  public class AccountDetailBLL : IAccountsBusinessLogic
    {
        CurrentAccount current = new CurrentAccount();
        CurrentAccountDataAccessLayer c;
        public AccountDetailBLL() {
            c = new CurrentAccountDataAccessLayer();
       }
        List<CurrentAccount> sam = new List<CurrentAccount>();

        
        
        public List<AccountDetailBLL> GetAccounts()
        {
            return new List<AccountDetailBLL>(){ };
        }
        public CurrentAccount GetAccountByAccountNumber(long accountNumber)
        {
            sam=c.GetCurrentAccounts();
            CurrentAccount ac = sam.Find(temp=> temp.AccountNumber==accountNumber);
            return ac;          
        }

        public void UpdateAccount(AccountDetailBLL account)
        {

        }
    }*/
}
/*  public AccountDetailBLLFake GetAccountByAccountNumber(long accountNumber)
  {
      return new AccountDetailBLLFake() { Account = 1, Balance = 1000 };
  }
}

}*/










