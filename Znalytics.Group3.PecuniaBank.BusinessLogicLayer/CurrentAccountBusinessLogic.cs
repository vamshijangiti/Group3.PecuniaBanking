using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    public class CurrentAccountBusinessLogic : ICurrentAccountBusinessLogic
    {
        CurrentAccountDataAccessLayer currentAccountDataAccessLayer;

        public void AddCurrentAccount(CurrentAccount currentAccount)
        {
            if (currentAccount.accId!=0)
            {
               /* CurrentAccountDataAccessLayer.Add(currentAccount);*/
            }
            else
            {
                throw new ApplicationException("accountid is not added");
            }
        }

        public void DeleteCurrentAccount(CurrentAccount currentAccount)
        {
            throw new NotImplementedException();
        }
    }

    public class CurrentAccountDataAccessLayer
    {
        void AddCurrentAccount(CurrentAccount currentAccount)
        {
            throw new NotImplementedException();
        }
    }


}
