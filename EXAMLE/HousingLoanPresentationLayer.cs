using System;
using System.Collections.Generic;
using Znalytics.Group3.PecuniaBank.Entities;

namespace Znalytics.Group3.PecuniaBank.HousingAndJewelPresentationLayer
{
    /// <summary>
    /// PresentationLayer for HousingLoan
    /// </summary>
    class program
    {
        public static void HousingLoanPresentationLayer()
        {
            int choice = 0;
            do
            {

                System.Console.WriteLine("WELCOME TO PECUNIA BANKING");
                System.Console.WriteLine("Menu");
                System.Console.WriteLine("1. Approve HouseLoan ");
                System.Console.WriteLine("2.Pending request for HouseLoan");
                System.Console.WriteLine("3.rejectHouseLoan");
                System.Console.WriteLine("4. Exit");
                System.Console.WriteLine("Enter the choice: ");
                choice = int.Parse(System.Console.ReadLine());
                switch (choice)
                {

                }
                System.Console.WriteLine("-----welcome to pecunia bank-------");//options for type of loan
                System.Console.WriteLine("1.HousingLoan");
                System.Console.WriteLine("2.exit");
                int n;
                n = int.Parse(System.Console.ReadLine());//using n variable in the switch case
                {
                    switch (n)
                    {
                        case 1://choosing HousingLoan option
                            HousingLoan h = new HousingLoan();
                            System.Console.WriteLine("enter accountno");//prints account no
                            long _accountNo = long.Parse(System.Console.ReadLine());
                            System.Console.WriteLine("enter Age of Customer");
                            int _ageOfCustomer = int.Parse(System.Console.ReadLine());
                            System.Console.WriteLine("enter credit score");
                            int _creditScore = int.Parse(System.Console.ReadLine());
                            System.Console.WriteLine("enter Loan Amount");
                            int _loanOfAmount = int.Parse(System.Console.ReadLine());
                            System.Console.WriteLine("enter rateofinterest");
                            double _rateOfInterest = double.Parse(System.Console.ReadLine());
                            System.Console.WriteLine("enter tenure");
                            double _tenure = double.Parse(System.Console.ReadLine());
                            System.Console.WriteLine("emi value");
                            float _emi = float.Parse(System.Console.ReadLine());


                            break;

                        case 2:
                            System.Console.WriteLine("exit ");
                            break;
                    }

                    System.Console.ReadKey();
                }
            }
   }
    }
        
