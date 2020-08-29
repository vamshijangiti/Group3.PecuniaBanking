//NAVYA presentation layer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;
using Znalytics.Group3.PecuniaBank.Entities;
namespace Znalytics.Group3.PecuniaBank.PresentationLayer
{
    /// <summary>
    /// presentation class for personal and vehicle loan
    /// </summary>

    public class Program
    {
        static void Main()
        {
            int count;
            count = 0;
            PersonalLoanEntity pl = new PersonalLoanEntity();
            VehicleLoan vl = new VehicleLoan();
            PersonalLoanBusinessLogicLayer pb = new PersonalLoanBusinessLogicLayer();
            vehicleLoanBusinessLogicLayer vb = new vehicleLoanBusinessLogicLayer();
            //menu for choosing options
            {
                System.Console.WriteLine("WELCOME TO PECUNIA BANK");
                System.Console.WriteLine("FOR LOAN ACCEPTANCE");
                System.Console.WriteLine("1 - FOR PERSONAL LOAN");
                System.Console.WriteLine("2 - FOR VEHICLE LOAN");

                System.Console.WriteLine("3-EXIT");




                int n;
                n = int.Parse(System.Console.ReadLine());


                //switch case for checking

                switch (n)
                {
                    case 1:

                        System.Console.Write("\nEnter Account Number : ");
                        pl.AccountNumber = System.Console.ReadLine();


                        System.Console.WriteLine("Enter the CreditScore");
                        pl.CreditScore = (int.Parse(System.Console.ReadLine()));
                        if (pl.CreditScore >= 650)
                        {

                            System.Console.WriteLine("Enter the LoanAmount");
                            pl.LoanAmount = (float.Parse(System.Console.ReadLine()));

                            System.Console.WriteLine("Enter the Tenure in months");
                            pl.Tenure = (float.Parse(System.Console.ReadLine()));

                            pb.CalculateEmi(pl.Tenure,pl.LoanAmount);
                            pb.AddPersonalLoan(pl);
                            System.Console.WriteLine("your loan is accepted");
                        }
                        else
                        {
                            System.Console.WriteLine("your loan is rejected");
                        }

                        break;


                    case 2:
                        System.Console.WriteLine("Bank Account Number for vehicle loan");
                        vl.AccountNumber = (System.Console.ReadLine());
                        System.Console.WriteLine(vl.AccountNumber);


                        System.Console.WriteLine("Enter the LoanAmount");
                        vl.LoanAmount = (double.Parse(System.Console.ReadLine()));
                        System.Console.WriteLine(vl.LoanAmount);

                       

                        System.Console.WriteLine("Enter the Tenure");
                        vl.Tenure = (double.Parse(System.Console.ReadLine()));
                        System.Console.WriteLine(vl.Tenure);

                        System.Console.WriteLine("Enter the CreditScore");
                        vl.CreditScore = (int.Parse(System.Console.ReadLine()));
                        System.Console.WriteLine(vl.CreditScore);

                        if (vl.CreditScore != 0)
                        {
                     //       vb.CalculateEmi(pl);
                            System.Console.WriteLine("your loan is accepted");
                        }
                        else
                        {
                            System.Console.WriteLine("your loan is rejected");
                        }


                        break;
                    case 3:
                        System.Console.WriteLine("Thanks For Using PECUNIA BANK");
                        break;
                }

            }

            System.Console.ReadKey();
        }




    }
}