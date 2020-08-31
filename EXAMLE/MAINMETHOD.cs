
using Znalytics.Group3.PecuniaBank.PresentationLayer;
using Znalytics.PecuniaBanking.CustomerDetailModule.PresentationLayer;
using Znalytics.PecuniaBanking.Creditcard.PresentationLayer;
using System;

/// <summary>
/// Main Class 
/// </summary>
public class MainMethod
{
    static void Main()
    {
        string ch;
        do
        {
            Console.WriteLine("\n\n\t\t***************** PECUNIA BANK  **************\n\n\t\tPecunia Finance Limited, established in the year 2015.\n\t\t\t\tBangalore, India.");
            Console.WriteLine("\n1- New Customer");
            Console.WriteLine("\n2- Account Creation");
            Console.WriteLine("\n3- Transactions");
            Console.WriteLine("\n4- Loans");
            Console.WriteLine("\n5- Credit Card");
            Console.WriteLine("\n6- Exit");

            Console.WriteLine("\nChoose Your Option\n");
            String s = Console.ReadLine();

            switch (s)
            {
                case "1":
                    CustomerPresentationLayer p = new CustomerPresentationLayer();
                    p.start();
                    break;
                case "2":
                    Console.WriteLine("\nImplementing\n");
                    break;
                case "3":
                    TransactionMenu.start();//Calling the Start Method 
                    break;
                case "4":
                    Console.WriteLine("\nImplementing\n");
                    break;
                case "5":
                    CreditcardPresentationLayer cr = new CreditcardPresentationLayer();
                    cr.start();
                    break;
                case "6":
                    Console.WriteLine("\nThanks For Using PECUNIA BANK....Have a Good Day\n ");
                    break;
                default:
                    Console.WriteLine("\n\nOops....!\nYou Have Choosen Wrong Option\n");
                    break;

            }
            Console.WriteLine("\nDo you Want To Use The PECUNIA BANK again press - Y \n");
            ch = Console.ReadLine();
        } while (ch.Equals("y") || ch.Equals("y"));


        Console.ReadKey();
    }



}