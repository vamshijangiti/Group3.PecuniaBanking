
using Znalytics.Group3.PecuniaBank.PresentationLayer;
//using Znalytics.PecuniaBanking.CustomerModule.PresentationLayer;
using Znalytics.PecuniaBanking.Creditcard.PresentationLayer;
using System;
using Znalytics.PecuniaBanking.CustomerModule.PresentationLayer;
using Znalytics.Group3.PecuniaBank.HousingLoanPresentationLayer;

/// <summary>
/// Main Class 
/// </summary>
public class MainMethod
{
    static void Main()
    {

        System.Console.WriteLine("\n\t\t************* WELCOME TO PECUNIA BANK ***********\t\t \n");
        System.Console.WriteLine("\t\tPecunia Finance Limited, established in the year 2015");
        System.Console.WriteLine("\t\t\t\tBangalore, India.");
        string ch = "Y";
        do
        {
            //Menu For Choosing Options
            System.Console.WriteLine("\n1 - NEW CUSTOMER ");
            System.Console.WriteLine("\n2 - NEW ACCOUNT");
            System.Console.WriteLine("\n3 - TRANSACTIONS");
            System.Console.WriteLine("\n4 - LOANS");
            System.Console.WriteLine("\n5_ HouseLoan");
            System.Console.WriteLine("\n6 - CREDIT CARD");

            Console.Write("\nEnter Your choice : ");

            ch = System.Console.ReadLine();
            switch (ch)
            {
                case "1":
                    //Creating object to CustomerPresentationLayer
                    CustomerPresentationLayer p = new CustomerPresentationLayer();
                    p.start();
                    break;
                case "2":
                    AccountsPresentationLayer.Start();
                      break;
                case "3":
                    //Calling method
                    TransactionMenu.start();

                    break;
                case "4":
                    PersonalVehicleLoanPresentationLayer.Start();
                    break;
                case "5":
                    HousingLoanPresentationLayer.Start();
                    break;

                case "6":
                    //Creating object to CreditcardPresentationLayer
                    CreditcardPresentationLayer cr = new CreditcardPresentationLayer();
                    cr.start();
                    break;
                default:
                    Console.WriteLine("\nOoops......You have Choosen Wrong Option\n");
                    break;

            }
            Console.Write("\n Do you want to Use PECUNIA BANK Again press Y else Press Any Key : ");
            ch = Console.ReadLine();

        } while (ch == "Y" || ch == "y");
        Console.ReadKey();
    }
}
