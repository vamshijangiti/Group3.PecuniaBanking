//Manasa Presentation Layer


using System;
using System.Collections.Generic;
using Znalytics.PecuniaBanking.CreditcardModule.Entities;
using Znalytics.PecuniaBanking.CreditcardModule.BusinessLogicLayer;
using Znalytics.PecuniaBanking.CustomerModule.Entities;


namespace Znalytics.PecuniaBanking.Creditcard.PresentationLayer
{
    /// <summary>
    ///class that represents presentation layer of credit card
    /// </summary>
    class CreditcardPresentationLayer
    {
        //Menu
        static void Menu()
        {
            DisplayMenu();
            Console.ReadKey();
        }

        //Menu presentation
        static void DisplayMenu()
        {
            int choice = -1;
            do
            {
                // Displaying Menu
                Console.WriteLine("Welcome to Pecunia Bank");
                Console.WriteLine("1. AddCreditCard");
                Console.WriteLine("2. ApproveCreditCard");
                Console.WriteLine("3. UpdateCreditCard");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {

                    case 1: ApplyCreditCard(); break;
                    case 2: ApproveCreditCard(); break;
                    case 3: GenerateCreditCard(); break;
                    case 4: UpdateCreditCard(); break;
                    case 5: Console.WriteLine("Exit"); break;


                }
            }
            while (choice != 5);

        }

        //Method to Adding Customer details for credit card
        static void ApplyCreditCard()

        {
            CreditCard cr = new CreditCard();

            CreditcardBusinessLogicLayer cbl = new CreditcardBusinessLogicLayer();
            int a;
            Console.WriteLine("Enter CustomerID");
            a = int.Parse(Console.ReadLine());


            Customer l=cbl.GetCustomersByCustomerId(a);

            cr.Customer = l;
            Customer creditcard = new Customer();

            Console.WriteLine("Enter AppNumber");
            cr.AppNumber= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter CibilScore");
            cr.CibilScore = int.Parse(Console.ReadLine());



            int AppNumber=cbl.ApplyCreditCard(a);
            Console.WriteLine("Your Application Number is "+AppNumber);

        }

            //Approve credit card
             public void ApproveCreditCard()
             {
                 CreditCard cr = new CreditCard();
                 bool b = CreditcardBusinessLogicLayer.ApproveCreditCard(cr);
                 if (b == true)
                 {
                     Console.WriteLine("You are eligible to approve credit card");
                 }
                 else
                 {
                     Console.WriteLine("You are not eligible to approve credit card");

                 }


                 //Displays application number
                 CreditcardBusinessLogicLayer.ApplicationNumber(customer);
                 Console.WriteLine("Your application number is" + customer.AppNumber);

                 //Displays credit card number
                 CreditcardBusinessLogicLayer.GenerateCreditCard(creditcard);
                 Console.WriteLine("Your credit card number is" + creditcard.CreditcardNumber);
             }


         }
        }


    }
}