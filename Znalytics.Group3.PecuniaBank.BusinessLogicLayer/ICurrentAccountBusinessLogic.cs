using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.AccountEntities;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    interface ICurrentAccountBusinessLogic
    {
       public  void AddCurrentAccount(CurrentAccount currentAccount);
        public void DeleteCurrentAccount(CurrentAccount currentAccount);
        List<CurrentAccount> GetcurrentAccount();
        
    }


    public class CurrentAccount
    {
        public static int AccId;
        public  int accId;
   
    }
}

