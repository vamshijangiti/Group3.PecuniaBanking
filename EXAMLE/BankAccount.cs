using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank;

namespace EXAMLE
{
    class BankAccount
    {
        public static void BankDetails()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. creat Account ");
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
            static void AddAccount()
            {
                    AccountBusinessLogic accountBusinessLogic = new AccountBusinessLogic();
                    BankAccount account = new BankAccount();
                
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
