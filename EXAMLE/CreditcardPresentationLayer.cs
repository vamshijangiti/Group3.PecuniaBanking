//Manasa Presentation Layer


using System;
using System.Collections.Generic;
using Znalytics.PecuniaBanking.CreditcardModule.Entities;
using Znalytics.PecuniaBanking.CreditcardModule.BusinessLogicLayer;


namespace Znalytics.PecuniaBanking.Creditcard.PresentationLayer
{
    /// <summary>
    /// Represents presentation layer of credit card
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
            int choice = 0;
            do
            {
                // Displaying Menu
                Console.WriteLine("Welcome to Pecunia Bank");
                Console.WriteLine("1. AddCreditCard");
                Console.WriteLine("2. ApproveCreditCard");
                Console.WriteLine("3. ViewCreditCard");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: AddCreditCard(); break;
                    case 2: ApproveCreditCard(); break;
                    case 3: ViewCreditCard(); break;
                }
            }
            while (choice != 4);
            }


        }
    //Adding Customer details for credit card
    static void AddCreditCard()
    {
        CreditcardBusinessLogicLayer customerbusinesslogic = new CreditcardBusinessLogicLayer();
        CreditCard customer = new CreditCard();

        Console.WriteLine("Enter Account Holder name: ");
        customer.AccountHolderName = Console.ReadLine();

        //Account number
        Console.Write("Enter AccountNumber: ");
        customer.AccountNumber = Console.ReadLine();


        //Occupation
        Console.Write("Enter occupation: ");
        customer.Occupation = Console.ReadLine();

        //Address
        Console.Write("Enter address: ");
        customer.Address = Console.ReadLine();

        //Income
        Console.Write("Enter Income: ");
        customer.Income = Console.ReadLine();


        //Pancard Number

        Console.Write("Enter Pancard Number: ");
        customer.PancardNumber = Console.ReadLine();

        //Aadhar card Number
        Console.Write("Enter Aadharcard number: ");
        customer.AaadharCardNumber = Console.ReadLine();

        //Phone number
        Console.Write("Enter Phone number: ");
        customer.PhoneNumber = Console.ReadLine();

        customerbusinesslogic.AddCreditCard(customer);
        Console.WriteLine("Credit card details added successfully");

        //Approve credit card
        bool b = CreditcardBusinessLogicLayer.ApproveCreditCard(customer);
        if(b==true)
        {
            Console.WriteLine("You are eligible to approve credit card");
        }
        else
        {
            Console.WriteLine("You are not eligible to approve credit card");

        }

        //Displays application numb
        CreditcardBusinessLogicLayer.ApplicationNumber(customer);
        Console.WriteLine("Your application number is" + customer.AppNumber);

        //Displays credit card number
        CreditcardBusinessLogicLayer.GenerateCreditCard(customer);
        Console.WriteLine("Your credit card number is" + customer.crn);
    }











       // CreditCardBusinessLogicLayer.AddCreditcard(creditcard); 
        }
    }
}