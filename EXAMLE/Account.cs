//PresentationLayer created by sriram


using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;
using Znalytics.Group3.PecuniaBank.Entities;
namespace Znalytics.Group3.PecuniaBank.PresentationLayer
{
    class Account
    {
        private int accountNo;

        public static void AccountsPresentationLayer()
        {
            int choice = 0;
            do
            {
                System.Console.WriteLine("WELCOME TO PECUNIA BANKING");
                System.Console.WriteLine("Menu");
                System.Console.WriteLine("1. Add Account ");
                System.Console.WriteLine("2. view Account");
                System.Console.WriteLine("3.UpdateAccount");
                System.Console.WriteLine("4.DeleteAccount");
                System.Console.WriteLine("5. Exit");
                System.Console.WriteLine("Enter the choice: ");
                choice = int.Parse(System.Console.ReadLine());
                switch (choice)
                {
                    case 1: AddAccount(); break;
                    case 2: ViewAccount(); break;
                    case 3: UpdateAccount(); break;
                    case 4: DeleteAccount(); break;


                }
            } while (choice != 5);


            static void AddAccount()
            {
                AccountBusinessLogic accountBusinessLogic = new AccountBusinessLogic();
                Account account = new Account();
                System.Console.WriteLine("enter AccountNo");
                account.accountNo = int.Parse(System.Console.ReadLine());

                /*System.Console.Write("\nEnter AccountId : ");
            account.AccountId = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Enter the Account Holder Name: ");
                account.AccountHolderName(System.Console.ReadLine());
                accountBusinessLogic.Add(account);
                System.Console.WriteLine("Account Created.\n");*/

            }
            static void ViewAccount()
            {
                AccountBusinessLogic accountBusinessLogic = new AccountBusinessLogic();
                List<Accounts> accounts = accountBusinessLogic.GetAccounts();
                foreach (Accounts acc in accounts)
                {
                    System.Console.WriteLine("Account ID:" + acc.accountId);
                }
            }

        }

        static void UpdateAccount()
        {

        }

        static void DeleteAccount()
        {

        }
    }
}
