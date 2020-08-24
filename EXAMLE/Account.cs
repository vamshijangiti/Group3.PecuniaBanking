//PresentationLayer created by sriram
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;
using Znalytics.Group3.PecuniaBank.Entities;
namespace Znalytics.Group3.PecuniaBank.PresentationLayer
{
    class Account
    {
        public static void BankDetails()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("WELCOME TO PECUNIA BANKING");
                Console.WriteLine("Menu");
                Console.WriteLine("1. Add Account ");
                Console.WriteLine("2. view Account");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter the choice: ");
                Console.ReadLine();
                switch (choice)
                {
                    case 1: AddAccount(); break;
                     case 2: ViewAccount(); break;

            }
            } while (choice != 2);
            public int AddAccount()
            {
                    AccountBusinessLogic accountBusinessLogic = new AccountBusinessLogic();
                    Account account = new Account();
                
                    Console.Write("\nEnter AccountNumber : ");
                account.AccountID(Console.ReadLine());
             Console.WriteLine("Enter the Account Holder Name: ");
                    account.AccountHolderName(Console.ReadLine());
                    accountBusinessLogic.Add(account);
                    Console.WriteLine("Account Created.\n");

                }
                static void ViewAccount()
                {
                    AccountBusinessLogic accountBusinessLogic = new AccountBusinessLogic();
                    List <Accounts>accounts = accountBusinessLogic.GetAccounts();
                    foreach(Accounts acc in accounts )
                {
                    Console.WriteLine("Account ID:" + acc.AccountID);
                }
                }
           
        }
    }
}
