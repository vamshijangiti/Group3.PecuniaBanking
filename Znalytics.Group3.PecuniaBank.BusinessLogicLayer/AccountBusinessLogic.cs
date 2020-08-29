// BusinessLogicLayer created by sriram
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.Entities;
using static Znalytics.Group3.PecuniaBank.Entities.SavingsAccount;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{/// <summary>
/// BusinessLogicLayer for Accounts
/// </summary>
    public interface IAccountBusinessLogic
    {
      //methods
        void SavingsAccount(SavingsAccount account);
        void CurrentAccount(CurrentAccount account);
        void GenerateAccountId(int id);
        void DeleteAccount(SavingsAccount account);
        void UpdateAccount(Account account);
 }
    public class AccountBusinessLogic : IAccountBusinessLogic
    {
        AccountDataAccessLayer _accountDataAccessLayer;
     

        public AccountBusinessLogic()
        {
            _accountDataAccessLayer = new AccountDataAccessLayer();
        }

        public void SavingsAccount(SavingsAccount account)
        {
            try
            {

            if (account.AccountId != 0)
            {
                    _accountDataAccessLayer.AddSavingsAccount(account);
        }
            else
            {
                throw new ApplicationException("account no should not be null")
            }
            }
        public void CurrentAccount(CurrentAccount account)
        {

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
            if (account.AccountId != 0)
            {
                _accountDataAccessLayer.UpdateAccount(account);
            }
        }
        public void DeleteAccount(Account account)
        {
            if (account.AccountId==null)
            {
                _accountDataAccessLayer.DeleteAccount(account);
            }
        }

            public int GenerateAccountId(int id)
            {
                int AccountId = NewMethod(account);
                return AccountId++;
            }
        }

        private static int NewMethod(SavingsAccount account)
        {
            return account.Max(temp =>
            {
                return NewMethod1(temp);
            });

            static object NewMethod1(object temp)
            {
                return temp.AccountId;
            }
        }

        public void DeleteAccount(SavingsAccount account)
        {
       
        }
    }

}
