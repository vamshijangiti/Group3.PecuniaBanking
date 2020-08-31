using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer.IAccountDetails
{
    public interface IAccountsBusinessLogic
    {
        List<AccountDetailBLLFake> GetAccounts();
        AccountDetailBLLFake GetAccountByAccountNumber(long accountNumber);
        void UpdateAccount(AccountDetailBLLFake account);
    }

    public class AccountDetailBLLFake : IAccountsBusinessLogic
    {

        //
        private long accno;
        private double balance;

      //  public double Balance { set; get; } = 20000;
        public List<AccountDetailBLLFake> GetAccounts()
        {
            return new List<AccountDetailBLLFake>()
            {
                new AccountDetailBLLFake() { accno=101,balance=20000},
                 new AccountDetailBLLFake() { accno=102,balance=30000}

            };
        }
        public AccountDetailBLLFake GetAccountByAccountNumber(long accountNumber)
        {
            return new AccountDetailBLLFake() { accno = 101, balance = 20000 };
        }

        public void UpdateAccount(AccountDetailBLLFake account)
        {

        }
    }
}
