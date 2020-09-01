using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.AccountEntities;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    interface ICurrentAccountBusinessLogic
    {
        void AddCurrentAccount(CurrentAccount a);
        void DeleteCurrentAccount(CurrentAccount currentAccount,int AccountId);
        List<CurrentAccount> GetCurrentAccounts();

    }



}

