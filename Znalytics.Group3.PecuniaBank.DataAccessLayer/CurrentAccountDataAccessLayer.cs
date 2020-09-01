using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.AccountEntities;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// CuurentAccountDataAccessLayer
    /// </summary>
    public class CurrentAccountDataAccessLayer : ICurrentAccountDataAccessLayer//interface
    {

        List<CurrentAccount> currentAccounts = new List<CurrentAccount>();

        //constructor
        //collection
        public CurrentAccountDataAccessLayer() => currentAccounts = new List<CurrentAccount>()
             {
                 new CurrentAccount() { AccountId =1, DateOfCreation= Convert.ToDateTime("24-08-2020"), Balance = 1000 },
                 new CurrentAccount() { AccountId=2, DateOfCreation = Convert.ToDateTime("25-08-2020"), Balance =12000},
                 new CurrentAccount() { AccountId=3, DateOfCreation = Convert.ToDateTime("26-08-2020"), Balance = 1000 },
             };




        public void AddCurrentAccount(CurrentAccount currentAccount)
        {
            if (currentAccounts.Count == 0)
            {
                currentAccount.AccountId = 0;
            }
            else
            {
                currentAccount.AccountId = currentAccounts.Max(temp => temp.AccountId);
            }
            currentAccounts.Add(currentAccount);
        }


        //convert data to json
        public static void SaveIntoFile(int currentAccount)
        {
            string s = JsonConvert.SerializeObject(currentAccount);
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\source\repos\Group3.PecuniaBanking\CurrentAccount.txt");
            streamWriter.Write(s);
        }
        public void DeleteCurrentAccount(CurrentAccount currentAccount, int AccountId)
        {
            if (currentAccount.AccountId!=0)
            {
                currentAccounts.Remove(currentAccount);
            }
        }

        public void DeleteCurrentAccount(CurrentAccount currentAccount)
        {
            throw new NotImplementedException();
        }

        public List<CurrentAccount>GetCurrentAccounts()
        {
            return currentAccounts;
        }

        /*  List<CurrentAccount> ICurrentAccountDataAccessLayer.GetCurrentAccount(int AccountId)
          {
              throw new NotImplementedException();
          }
      }*/
    }
}


