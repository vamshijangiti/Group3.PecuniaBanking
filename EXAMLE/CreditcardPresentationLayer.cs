﻿//Manasa Presentation Layer


using System;
using Znalytics.PecuniaBanking.CreditcardModule.Entities;
using Znalytics.PecuniaBanking.BusinessLogicLayer;
/// <summary>
/// Represents Presentation Layer of Creditcard
/// </summary>

namespace Znalytics.PecuniaBanking.Creditcard.PresentationLayer
{
    public class DisplayMenu
    {
        public static void Menu()
        {
            int choice = -1;

            do
            {
                // Displaying Menu
                Console.WriteLine("Menu:");
                Console.WriteLine("1. AddCreditCard");
                Console.WriteLine("2. ApproveCreditCard");
                Console.WriteLine("3. ViewCreditCard");
                Console.WriteLine("4. Exit");

                bool b = int.TryParse(Console.ReadLine(), out choice);
                if (b == true)
                {
                    switch (choice)
                    {

                        case 1: AddCreditCard(); break;

                    }
                }
            } while (choice != 4);
        }

        public static void AddCreditCard()
        {
            Csutomer creditcard = new Customer();

            //Customer Name
            Console.Write("Enter customer name: ");
            creditcard.CustomerName = Console.ReadLine();

            //Occupation
            Console.Write("Enter occupation: ");
            creditcard.Occupation = Console.ReadLine();

            //Address
            Console.Write("Enter address: ");
            creditcard.Address = Console.ReadLine();

            //Income
            Console.Write("Enter Income: ");
            creditcard.Income= Console.ReadLine();

            //Account Number
            Console.Write("Enter AccountNumber: ");

            //Pancard Number

            Console.Write("Enter Pancard Number: ");
            creditcard.PancardNumber = Console.ReadLine();

            //Aadhar card Number
            Console.Write("Enter Aadharcard number: ");
            creditcard.AaadharCardNumber = Console.ReadLine();





            CreditCardBusinessLogicLayer.AddCreditcard(creditcard); 
        }
    }
}