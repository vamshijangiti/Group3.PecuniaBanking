
using System.Collections.Generic;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;
using Znalytics.Group3.PecuniaBank.AccountEntities;
using System;
using System.Linq.Expressions;

namespace Znalytics.Group3.PecuniaBank.HousingLoanPresentationLayer
{
    /// <summary>
    /// PresentationLayer for HousingLoan
    /// </summary>
    class program
    {
        private static int _creditScore;
        /// <summary>
        /// Start of HousingLoan Method
        /// </summary>
        public void start()
        {
            HousingLoanPresentationLayer();
            System.Console.ReadKey();
        }
        public static void HousingLoanPresentationLayer()
        {
            ///<summary>
            ///Do-While loop :  Excecutes at least once withot checking condition first
            ///</summary>
            ///
            int choice = 0;
            do
            {

                System.Console.WriteLine("WELCOME TO PECUNIA BANKING");
                System.Console.WriteLine("Menu");
                System.Console.WriteLine("1. HouseLoan ");
                System.Console.WriteLine("2 Exit");
                System.Console.WriteLine("Enter the choice: ");
                choice = int.Parse(System.Console.ReadLine());//reads choice into the keyboard
                switch (choice)
                {
                    case 1:
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
                        try {
                            if (_creditScore!=0)
                            {

                                h.CreditScore = int.Parse(System.Console.ReadLine());//credit score should not be zero
                            }
                        }
                        catch (HousingLoanException ex)
                        {
                            System.Console.WriteLine("exception Raised", ex);
                        }
                                System.Console.WriteLine("enter Loan Amount");
                                h.LoanAmount = int.Parse(System.Console.ReadLine());
                                System.Console.WriteLine("enter rateofinterest");
                                // h.RateOfInterest = float.Parse(System.Console.ReadLine());
                                System.Console.WriteLine("enter tenure");
                                h.Tenure = float.Parse(System.Console.ReadLine());
                                System.Console.WriteLine("emi value");
                                h.Emi = float.Parse(System.Console.ReadLine());
                                hl.AddHousingLoan(h);//adds house loan
                               

                            if (_creditScore>=650)
                        {
                            System.Console.WriteLine("yor loan is accepted");//prints your loan is accepted if creditscore greater than 650
                        }
                            else
                            {
                                System.Console.WriteLine("your loan is rejected");//otherwise your loan is rejected
                            }
                            break;
                        }

                } while (choice != 2) ;
            }
            }
      
        }

