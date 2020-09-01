using System.Collections.Generic;
using Znalytics.Group3.PecuniaBank.AccountEntities;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    public interface IAccountsBusinessLogic
    {

        List<AccountDetailBLL> GetAccounts();
        SavingsAccount GetAccountByAccountNumber(long accountNumber);
        void UpdateAccount(AccountDetailBLL account);
    }

   /* public class AccountDetailBLL : IAccountsBusinessLogic
    {

        private long accno;
        private double balance;

        public double Balance { set; get; } = 20000;
        public long Account { set; get; } = 101;

        public List<AccountDetailBLL> GetAccounts()
        {
            return new List<AccountDetailBLL>()
            {
                new AccountDetailBLL() { accno=101,balance=20000},
                 new AccountDetailBLL() { accno=102,balance=30000 }

            };
        }
        public AccountDetailBLL GetAccountByAccountNumber(long accountNumber)
        {
            return new AccountDetailBLL() { accno = 101, balance = 20000 };
        }

        public void UpdateAccount(AccountDetailBLL account)
        {

        }
    }*/
}
