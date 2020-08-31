
using System.Collections.Generic;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;
using Znalytics.Group3.PecuniaBank.AccountEntities;

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
                        /* case 2: RejectHouseLoan(); break;*/

                } while (choice != 3) ;


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
                    // h.RateOfInterest = float.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("enter tenure");
                    h.Tenure = float.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("emi value");
                    h.Emi = float.Parse(System.Console.ReadLine());
                    hl.AddHousingLoan(h);
                    System.Console.WriteLine("congratilations your Loan is accepted");

                }


                static void RejectHouseLoan(int Creditscore)
                {
                    HousingLoanBusinessLogicLayer housingLoanBusinessLogicLayer = new HousingLoanBusinessLogicLayer();
                    if (Creditscore <= 650)
                    {
                        System.Console.WriteLine("your loan is rejected");
                    }


                }
                System.Console.ReadKey();

            } while (choice != 3);
            }
    }
}
