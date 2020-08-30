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
       public  void AddCurrentAccount(CurrentAccount a);
        public void DeleteCurrentAccount(CurrentAccount c);
        public  List<CurrentAccount> GetCurrentAccount();
        
    }


    public class CurrentAccount
    {
        public static int AccId;
        public  int accId;
   
    }
}

