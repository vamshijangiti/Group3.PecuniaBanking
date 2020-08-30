//PresentationLayer created by sriram


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;
using Znalytics.Group3.PecuniaBank.AccountEntities;
using static Znalytics.Group3.PecuniaBank.AccountEntities.SavingsAccount;
using CurrentAccount = Znalytics.Group3.PecuniaBank.BusinessLogicLayer.CurrentAccount;

namespace Znalytics.Group3.PecuniaBank.PresentationLayer
{
    /// <summary>
    /// AccountsPresentation layer
    /// </summary>
    class program
    {
       static void Main()
        {
            AccountsPresentationLayer();
        }

        static void AccountsPresentationLayer()
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
                SavingsAccountBusinessLogic savingsaccountBusinessLogic = new  SavingsAccountBusinessLogic();
                SavingsAccount _savingsaccount = new SavingsAccount();
                System.Console.WriteLine("enter AccountId");
                _savingsaccount.AccountId = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("enter balance");
                _savingsaccount.Balance = long.Parse(System.Console.ReadLine());
           // savingsaccountBusinessLogic.AddSavingsAccount(_savingsaccount);
                System.Console.WriteLine("savings Account Added");
            }
 
  static void AddCurrentAccount()
        {
            try
            { 

            CurrentAccountBusinessLogic accountBusinessLogic = new CurrentAccountBusinessLogic();
                BusinessLogicLayer.CurrentAccount currentAccount = new BusinessLogicLayer.CurrentAccount();
            System.Console.WriteLine("enter account id");
                CurrentAccount.AccId = int.Parse(Console.ReadLine());
            System.Console.WriteLine("enter balance");
        }
            catch (Exception ex)
            {
                if (ex.InnerException!= null)
                {
                    System.Console.WriteLine(ex.InnerException.Message);
                }
            }
        }
    }

   public  class SavingsAccountBusinessLogic
    {
    }
}
     
     