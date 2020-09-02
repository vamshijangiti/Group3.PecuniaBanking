//PresentationLayer created by sriram



using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;
using Znalytics.Group3.PecuniaBank.AccountEntities;
using Znalytics.PecuniaBanking.CustomerModule.Entities;

namespace Znalytics.Group3.PecuniaBank.PresentationLayer
{
    /// <summary>
    /// AccountsPresentation layer
    /// </summary>
    public class AccountsPresentationLayer
    {
        

        /// <summary>
        /// Do While loop starts where user selects choice
        /// </summary>
        public static void Start()
        {
            int choice = 0;
            do
            {
                System.Console.WriteLine("WELCOME TO PECUNIA BANKING");
                System.Console.WriteLine("Menu");
                System.Console.WriteLine("1. press 1 if you want to open SavingsAccount ");
                System.Console.WriteLine("2.press 2 if you want to open currentAccount");
                System.Console.WriteLine("3.exit");
                System.Console.WriteLine("Enter the choice: ");
                choice = int.Parse(System.Console.ReadLine());
                switch (choice)
                {
                    case 1: AddSavingsAccount(); break;
                    case 2: AddCurrentAccount(); break;
                }


            } while (choice != 3);

        }


        ///<summary>
        ///adding Savings Account
        /// </summary>

        static void AddSavingsAccount()
        {
            SavingsAccountBusinessLogic savingsAccountBusinessLogic = new SavingsAccountBusinessLogic();
            SavingsAccount _savingsaccount = new SavingsAccount();
            System.Console.WriteLine("enter customer Id");

            int CustomerId = 0;
            if (CustomerId<=3)
            {
                System.Console.WriteLine("valid customer id");
            }
            else
            {
                throw new AccountException("invalid customerId");
            }
            System.Console.WriteLine("enter AccountNo");
            _savingsaccount.AccountNumber = long.Parse(System.Console.ReadLine());
            //savingsAccountBusinessLogic.AddSavingsAccount(_savingsaccount);
            System.Console.WriteLine("enter balance");
            _savingsaccount.Balance = double.Parse(System.Console.ReadLine());
            savingsAccountBusinessLogic.AddSavingsAccount(_savingsaccount);
            System.Console.WriteLine("savings Account Added");
        }
        /// <summary>
        /// Cuurent account starts
        /// </summary>
        static void AddCurrentAccount()
        {
            try
            {

                CurrentAccountBusinessLogic accountBusinessLogic = new CurrentAccountBusinessLogic();
                CurrentAccount currentAccount = new CurrentAccount();
                System.Console.WriteLine("enter account No");
                currentAccount.AccountNumber = long.Parse(System.Console.ReadLine());
                System.Console.WriteLine("enter balance");
            }
            catch (AccountException ex)
            {
                if (ex.InnerException != null)
                {
                    System.Console.WriteLine(ex.InnerException.Message);//Inner exception is raised
                }
            }
        }
    }

    /* public class SavingsAccountBusinessLogic
     {
         internal static void AddSavingsAccount(SavingsAccount savingsaccount)
         {
              throw new NotImplementedException();
         }
     }*/
}

