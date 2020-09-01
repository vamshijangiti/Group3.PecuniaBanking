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
        void AddCurrentAccount(CurrentAccount currentAccount);
        void DeleteCurrentAccount(CurrentAccount currentAccount,int AccountNo);
        List<CurrentAccount> GetCurrentAccounts();

    }



}

