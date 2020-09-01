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

        static List<CurrentAccount> currentAccounts = new List<CurrentAccount>();

        //constructor
        //collection
        static CurrentAccountDataAccessLayer() => currentAccounts = new List<CurrentAccount>()
             {
                 new CurrentAccount() { AccountNumber =101, DateOfCreation= Convert.ToDateTime("24-08-2020"), Balance = 1000 },
                 new CurrentAccount() { AccountNumber=102, DateOfCreation = Convert.ToDateTime("25-08-2020"), Balance =12000},
                 new CurrentAccount() { AccountNumber=103, DateOfCreation = Convert.ToDateTime("26-08-2020"), Balance = 1000 },
             };




        public void AddCurrentAccount(CurrentAccount currentAccount)
        {
            if (currentAccounts.Count == 0)
            {
                currentAccount.AccountNumber = 0;
            }
            else
            {
                currentAccount.AccountNumber = currentAccounts.Max(temp => temp.AccountNumber);
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
            if (currentAccount.AccountNumber!=0)
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


