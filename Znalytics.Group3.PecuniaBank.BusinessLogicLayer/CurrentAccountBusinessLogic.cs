using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.AccountEntities;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    public class CurrentAccountBusinessLogic : ICurrentAccountBusinessLogic
    {
        CurrentAccountDataAccessLayer currentAccountDataAccessLayer;

        public void AddCurrentAccount(CurrentAccount currentAccount)
        {
            if (currentAccount.AccId!=0)
            {
                CurrentAccountDataAccessLayer.AddCurrentAccount(currentAccount);
            }
            else
            {
                throw new ApplicationException("accountid is not added");
            }
        }

        public void DeleteCurrentAccount(CurrentAccount currentAccount)
        {
            if (currentAccount.AccId==null)
            {
               
               
            }

        
  


      

 
