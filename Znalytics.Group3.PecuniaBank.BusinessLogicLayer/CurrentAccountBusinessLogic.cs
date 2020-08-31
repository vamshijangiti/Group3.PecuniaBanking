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
        CurrentAccountDataAccessLayer currentAccountDataAccessLayer;

        /// <summary>
        /// Adds Current Account
        /// </summary>
        /// <param name="a"></param>
        public void AddCurrentAccount(CurrentAccount a)
        {
            try
            {
                if (a.accId != 0)
                {
                   /* currentAccountDataAccessLayer.AddCurrentAccount(a);*/
                }
            }


            catch (Exception e)
            {
                throw new AccountException("accountid is not added", e);//exception raised if accounId is not added
            }
        }

        public void DeleteCurrentAccount(CurrentAccount c)
        {
            try
            {
                if (c.accId != 0)
                {
                    /* currentAccountDataAccessLayer.DeleteCurrentAccount(c);*/
                }
            }
            catch (Exception e)
            {
                throw new AccountException("account is not deleted", e);
            }

        }

        public List<CurrentAccount> GetCurrentAccount()
        {
            return GetCurrentAccount();//retrieves all currentAccount 
        }

    }
}


        
  


      

 
