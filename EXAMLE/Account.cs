//PresentationLayer created by sriram


using System;
using System.Collections;
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
        public  int accountNo;

        public static void AccountsPresentationLayer()
        {
            int choice = 0;
            do
            {
                System.Console.WriteLine("WELCOME TO PECUNIA BANKING");
                System.Console.WriteLine("Menu");
                System.Console.WriteLine("1. press 1 if you want to open SavingsAccount ");
                System.Console.WriteLine("2.press 2 if you want to open currentAccount");
                System.Console.WriteLine("Enter the choice: ");
                choice = int.Parse(System.Console.ReadLine());
                switch (choice)
                {
                    case 1: SavingsAccount(); break;
                    case 2: CurrentAccount(); break;
                }
                

            } while (choice != 5);

            switch(choice)
            {
                case 1:
                    System.Console.WriteLine("enter  ");
                    break;
            }




            static void AddAccount()
            {
               
            }
            static void ViewAccount()
            {
               
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
