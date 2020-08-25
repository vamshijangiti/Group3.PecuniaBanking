using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.Entities;
namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// DataAccessLayer For Accounts 
    /// </summary>
    public interface IAccountDataAccessLayer
    {
        void AddAccountDataAccessLayer(Account n);
        void AddAccountDateOfCreation(Account d);
        List<Account> GetAccounts(long AccountNo);

    }
    
    public class AccountDataAccessLayer : IAccountDataAccessLayer
    {

    }
}
