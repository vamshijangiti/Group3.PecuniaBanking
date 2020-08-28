// BusinessLogicLayer created by sriram
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.Entities;
namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{/// <summary>
/// BusinessLogicLayer for Accounts
/// </summary>
    public interface IAccountBusinessLogic
    {
      //methods
        void Add(Account account);
        void DeleteAccount(Account account);
        void UpdateAccount(Account account);
 }
    public class AccountBusinessLogic : IAccountBusinessLogic
    {
        AccountDataAccessLayer _accountDataAccessLayer;
        public AccountBusinessLogic()
        {
            _accountDataAccessLayer = new AccountDataAccessLayer();
        }

        public void Add(Account account)
        {
            if (account.AccountNo==12)
            {
            _accountDataAccessLayer.AddAccount(account);
        }
            else
            {
                throw new Exception("account no cant be more than 12 digits")
            }
                    

 
    }
        /// <summary>
        /// Adding Accounts
        /// </summary>
        /// <param name="account">Add Account</param>
    
        //GetAccounts
        public List<Account> GetAccounts()
        {
            return _accountDataAccessLayer.GetAccounts();
        }
        /// <summary>
        /// Update Accounts
        /// </summary>
        /// <param name="account">update</param>
        public void UpdateAccount(Account account)
        {
            if (account.AccountNo != 0)
            {
                _accountDataAccessLayer.UpdateAccount(account);
            }
        }
        public void DeleteAccount(Account account)
        {
            if (account.AccountNo==null)
            {
                _accountDataAccessLayer.DeleteAccount(account);
            }
        }
    }

}
