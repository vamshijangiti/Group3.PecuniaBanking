using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.Entities;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    interface ICurrentAccountBusinessLogic
    {
        void AddCurrentAccount(CurrentAccount a);
         void DeleteCurrentAccount(CurrentAccount c);
          List<CurrentAccount> GetCurrentAccount();
        void GetBalance(CurrentAccount currentAccount);
    }


    public class CurrentAccount
    {
        public static int AccId;
        public  int accId;
   
    }
}

