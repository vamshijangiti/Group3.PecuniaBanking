﻿
using System.Collections.Generic;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;
using Znalytics.Group3.PecuniaBank.HousingLoanEntities;

namespace Znalytics.Group3.PecuniaBank.HousingLoanPresentationLayer
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
                System.Console.WriteLine("2.rejectHouseLoan");
                System.Console.WriteLine("3. Exit");
                System.Console.WriteLine("Enter the choice: ");
                choice = int.Parse(System.Console.ReadLine());
                switch (choice)
                {
                    case 1: ApproveHouseLoan(); break;
                    case 2: RejectHouseLoan(); break;
                      case 3:Exit();       break; ;
                } while (choice != 4) ;


                static void ApproveHouseLoan()
                {
                    //Approval of HouseLoan
                    HousingLoan h = new HousingLoan();
                    HousingLoanBusinessLogicLayer hl = new HousingLoanBusinessLogicLayer();
                    System.Console.WriteLine("enter customerId");//prints CustomerId
                    h.CustomerId = int.Parse(System.Console.ReadLine());
                    long _accountNo = long.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("enter Age of Customer");
                    h.CustomerAge = int.Parse(System.Console.ReadLine());
                    int _ageOfCustomer = int.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("enter credit score");
                    h.CreditScore = int.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("enter Loan Amount");
                    h.LoanAmount = int.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("enter rateofinterest");
                    h.RateOfInterest = float.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("enter tenure");
                    h.Tenure = float.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("emi value");
                    h.Emi = float.Parse(System.Console.ReadLine());
                    hl.AddHousingLoan(h);
                    System.Console.WriteLine("congratilations your Loan is accepted");

                }

                static void RejectHouseLoan()
                {
                    HousingLoanBusinessLogicLayer housingLoanBusinessLogicLayer = new HousingLoanBusinessLogicLayer();


                }
                System.Console.ReadKey();
            };
        }
            }
    }
