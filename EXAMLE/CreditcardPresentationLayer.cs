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
                Console.WriteLine("1. ApplyCreditCard");
                Console.WriteLine("2. ApproveCreditCard");
                Console.WriteLine("3. GenerateCreditCard");
                Console.WriteLine("4. UpdateCreditCard");
                Console.WriteLine("5. RequestToIncreaseCreditCardLimit");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {

                    case 1: ApplyCreditCard(); break;
                    case 2: ApproveCreditCard(); break;
                    case 3: GenerateCreditCard(); break;
                    case 4: UpdateCreditCard(); break;
                    case 5:RequestToIncreaseCreditCardLimit();break;
                    case 6: Console.WriteLine("Exit"); break;


                }
            }
            while (choice != 6);

        }

        //Method to Adding Customer details for credit card
        static void ApplyCreditCard()

        {
            CreditCard cr = new CreditCard();

            CreditcardBusinessLogicLayer cbl = new CreditcardBusinessLogicLayer();
            int a;
            Console.WriteLine("Enter CustomerID");
            a = int.Parse(Console.ReadLine());


            Customer l = cbl.GetCustomersByCustomerId(a);

            cr.Customer = l;


            Console.WriteLine("Enter AppNumber");
            cr.AppNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter CibilScore");
            cr.CibilScore = int.Parse(Console.ReadLine());



            int AppNumber = cbl.ApplyCreditCard(a);
            Console.WriteLine("Your Application Number is " + AppNumber);

        }

        //Approve credit card
        static void ApproveCreditCard()
        {
            CreditCard cr = new CreditCard();

            CreditcardBusinessLogicLayer cbl = new CreditcardBusinessLogicLayer();
            int a;
            Console.WriteLine("Enter CustomerID");
            a = int.Parse(Console.ReadLine());


            //Customer l = cbl.GetCustomersByCustomerId(a);

            //cr.Customer = l;

            bool b = cbl.ApproveCreditCard(a);
            if (b == true)
            {
                Console.WriteLine("You are eligible to approve credit card");
            }
            else
            {
                Console.WriteLine("You are not eligible to approve credit card");

            }
        }


        static void GenerateCreditCard()

        {
            CreditCard cr = new CreditCard();

            CreditcardBusinessLogicLayer cbl = new CreditcardBusinessLogicLayer();
            int a;
            Console.WriteLine("Enter CustomerID");
            a = int.Parse(Console.ReadLine());


            Customer l = cbl.GetCustomersByCustomerId(a);

            cr.Customer = l;

            string CreditCardNumber = cbl.GenerateCreditCard(a);
            Console.WriteLine("Your CreditCard Number is " + CreditCardNumber);
        }

        static void UpdateCreditCard()
        {
            CreditCard cr = new CreditCard();

            CreditcardBusinessLogicLayer cbl = new CreditcardBusinessLogicLayer();
            int a;
            Console.WriteLine("Enter CustomerID");
            a = int.Parse(Console.ReadLine());


            //Customer l = cbl.GetCustomersByCustomerId(a);

            //cr.Customer = l;

            bool b = cbl.UpdateCreditCard(a);
            if (b == true)
            {
                Console.WriteLine("Your CreditCard Number generated successfully ");
            }
            else
            {
                Console.WriteLine("Your Creditcard number generation is in progress");

            }


        }

        static void RequestToIncreaseCreditCardLimit()
        {
            CreditCard cr = new CreditCard();

            CreditcardBusinessLogicLayer cbl = new CreditcardBusinessLogicLayer();
            int a;
            Console.WriteLine("Enter CustomerID");
            a = int.Parse(Console.ReadLine());

            bool b = cbl.RequestToIncreaseCreditCardLimit(a);
            if (b == true)
            {
                Console.WriteLine("Your CreditCard Number generated successfully ");
            }
            else
            {
                Console.WriteLine("Your Creditcard number generation is in progress");

            }

        }


    }
}
   