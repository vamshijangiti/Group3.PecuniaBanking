using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer.IAccountDetails
{
    public interface IGetAccountByAccountNumberBLL
    {

    }

    public class AccountDetailBLL : IGetAccountByAccountNumberBLL
    {

        public static List<AccountDAL> GetAccountBLLAccList()
        {
            new AccountDetailDAL();
            return AccountDetailDAL.Getaccounts();
        }
    }
}
