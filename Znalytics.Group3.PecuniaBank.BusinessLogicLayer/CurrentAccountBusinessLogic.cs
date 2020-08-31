using System;
using System.Collections.Generic;
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
    public class CurrentAccountBusinessLogic  :ICurrentAccountBusinessLogic
    {
        CurrentAccountDataAccessLayer currentAccountDataAccessLayer=new CurrentAccountDataAccessLayer();

        /// <summary>
        /// Adds Current Account
        /// </summary>
        /// <param name="a"></param>
        public void AddCurrentAccount(CurrentAccount currentAccount)
        {
            try
            {
                if (currentAccount.AccountId != 0)
                {
                    currentAccountDataAccessLayer.AddCurrentAccount(currentAccount);
                }
            }


            catch (Exception e)
            {
                throw new AccountException("accountid is not added", e);//exception raised if accounId is not added
            }
        }

        public void DeleteCurrentAccount(CurrentAccount currentAccount,int AccountId)
        {
            try
            {
                if (currentAccount.AccountId != 0)
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
}


        
  


      

 
