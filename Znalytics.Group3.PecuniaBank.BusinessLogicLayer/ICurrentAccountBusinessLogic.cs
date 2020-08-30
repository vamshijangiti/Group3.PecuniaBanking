using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    interface ICurrentAccountBusinessLogic
    {
        void AddCurrentAccount(CurrentAccount currentAccount);
        void DeleteCurrentAccount(CurrentAccount currentAccount);
        
    }


    public class CurrentAccount
    {
        public  int accId;
   
    }
}

