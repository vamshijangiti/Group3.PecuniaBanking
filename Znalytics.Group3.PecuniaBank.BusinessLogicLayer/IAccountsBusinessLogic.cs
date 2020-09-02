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

}