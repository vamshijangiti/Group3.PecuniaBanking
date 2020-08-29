//Manasa Presentation Layer


using System;
using System.Collections.Generic;
using Znalytics.PecuniaBanking.CreditcardModule.Entities;
using Znalytics.PecuniaBanking.CreditcardModule.BusinessLogicLayer;


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
                        //case 2: ApproveCreditCard(); break;
                        //case 3: UpdateCreditCard(); break;

                }
            }
            while (choice != 4);

        }

        //Method to Adding Customer details for credit card
        static void ApplyCreditCard()

        {
            /*CreditcardBusinessLogicLayer customerbusinesslogic = new CreditcardBusinessLogicLayer();
            Customer creditcard = new Customer();

            Console.WriteLine("Enter Account Holder name: ");
            creditcard.AccountHolderName = Console.ReadLine();

            //Account number
            Console.Write("Enter AccountNumber: ");
            creditcard.AccountNumber = System.Convert.ToInt64(Console.ReadLine());


            //Occupation
            Console.Write("Enter occupation: ");
            creditcard.Occupation = Console.ReadLine();

            //Address
            Console.Write("Enter address: ");
            creditcard.Address = Console.ReadLine();

            //Income
            Console.Write("Enter Income: ");
            creditcard.Income = System.Convert.ToDouble(Console.ReadLine());


            //Pancard Number

            Console.Write("Enter Pancard Number: ");
            creditcard.PanCardNumber = Console.ReadLine();

            //Aadhar card Number
            Console.Write("Enter Aadharcard number: ");
            creditcard.AadharCardNumber = System.Convert.ToInt64(Console.ReadLine());

            //Phone number
            Console.Write("Enter Phone number: ");
            creditcard.PhoneNumber = System.Convert.ToInt64(Console.ReadLine());

            customerbusinesslogic.AddCreditCard(creditcard);
            Console.WriteLine("Credit card details added successfully");
        }*/

            //Approve credit card
            /* public void ApproveCreditCard()
             {
                 Customer creditcard = new Customer();
                 bool b = CreditcardBusinessLogicLayer.ApproveCreditCard(customer);
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


         }*/
        }


    }
}