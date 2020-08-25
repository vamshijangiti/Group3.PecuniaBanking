//ceated by sriram
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.Entities;
namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    public class AccountBusinessLogic
    {
        AccountDataAccessLayer _accountDataAccessLayer;
        public AccountBusinessLogic()
        {
            _accountDataAccessLayer = new AccountDataAccessLayer();
        }

        public void Add(Account account)
        {
            if (account.AccountNo!=12)
            {
                _accountDataAccessLayer.Add(account);

            }
            else
            {
                throw new Exception("account no cant be null");
            }
        }
      
     
        }
    }