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
        long GenerateAccountNo(long accountNo);//methods
        void Add(Account account);

    }
    public class AccountBusinessLogic : IAccountBusinessLogic
    {
        AccountDataAccessLayer _accountDataAccessLayer;
        public AccountBusinessLogic()
        {
            _accountDataAccessLayer = new AccountDataAccessLayer();
        }

        public long GenerateAccountNo(long accountNo)
        {
            if (accountNo<=12)
            {

            }
        }
        /// <summary>
        /// Adding Accounts
        /// </summary>
        /// <param name="account">Add Account</param>
        public void Add(Account account)
        {
            if (account.AccountNo != 12)
            {
                _accountDataAccessLayer.AddAccount(account);

            }
            else
            {
                throw new Exception("account no cant be null");
            }
        }
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
    }

}
