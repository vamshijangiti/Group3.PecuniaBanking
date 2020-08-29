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
            
            PersonalLoanEntity pl = new PersonalLoanEntity();//creating a object for personalloan entity
            VehicleLoanEntity vl = new VehicleLoanEntity();//creating a object for vehicleloan entity
            PersonalLoanBusinessLogicLayer pb = new PersonalLoanBusinessLogicLayer();//creating a object for personaloanbusinesslogiclayer
            VehicleLoanBusinessLogicLayer vb = new VehicleLoanBusinessLogicLayer();//creating a object for vehicleloanbusinesslogiclayer
            //menu for choosing options
            {
                System.Console.WriteLine("WELCOME TO PECUNIA BANK");
                System.Console.WriteLine("FOR LOAN ACCEPTANCE");
                System.Console.WriteLine("1 - FOR PERSONAL LOAN");
                System.Console.WriteLine("2 - FOR VEHICLE LOAN");

                System.Console.WriteLine("3-EXIT");




                int n;
                n = int.Parse(System.Console.ReadLine());


                //switch case for checking whether to take personal loan or vehicle loan

                switch (n)
                {
                    case 1:

                        System.Console.Write("\nEnter Account Number : ");//Enter the account number for personal loan
                        pl.AccountNumber = System.Console.ReadLine();


                        System.Console.WriteLine("Enter the CreditScore");//Enter the credit score for personal loan
                        pl.CreditScore = (int.Parse(System.Console.ReadLine()));
                        if (pl.CreditScore >= 650)//if credit score value greater than or equal to 650 enter in to the loop
                        {

                            System.Console.WriteLine("Enter the LoanAmount");//Enter the Loan amount for the personalloan
                            pl.LoanAmount = (float.Parse(System.Console.ReadLine()));

                            System.Console.WriteLine("Enter the Tenure in months");//Enter the tenure for the personalloan
                            pl.Tenure = (float.Parse(System.Console.ReadLine()));

                            pb.CalculateEmi(pl.Tenure,pl.LoanAmount);//enter the loanamount,tenure for calculation of emi
                            pb.AddPersonalLoan(pl);
                            System.Console.WriteLine("your loan is accepted");
                        }
                        else//if credit score value less than 650 enter in to the loop
                        {
                            System.Console.WriteLine("your loan is rejected");
                        }

                        break;


                    case 2:
                        System.Console.Write("\nEnter Account Number : ");
                        vl.AccountNumber = System.Console.ReadLine();


                        System.Console.WriteLine("Enter the CreditScore");
                        vl.CreditScore = (int.Parse(System.Console.ReadLine()));
                        if (vl.CreditScore >= 650)
                        {

                            System.Console.WriteLine("Enter the LoanAmount");
                            vl.LoanAmount = (float.Parse(System.Console.ReadLine()));

                            System.Console.WriteLine("Enter the Tenure in months");
                            vl.Tenure = (float.Parse(System.Console.ReadLine()));

                            vb.CalculateEmi(vl.Tenure, vl.LoanAmount);
                            vb.AddVehicleLoan(vl);
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