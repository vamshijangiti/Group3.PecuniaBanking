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
                    //case 1 for personal loan
                    case 1:

                        System.Console.Write("\nEnter Account Number : ");//Enter the account number for personal loan
                        pl.AccountNumber = System.Console.ReadLine();


                        System.Console.WriteLine("Enter the CreditScore");//Enter the credit score for loan acceptance of personal loan
                        pl.CreditScore = (int.Parse(System.Console.ReadLine()));
                        if (pl.CreditScore >= 650)//If credit score value greater than or equal to 650 loan is accepted
                        {

                            System.Console.WriteLine("Enter the LoanAmount");//Enter the Loan amount for the personalloan
                            pl.LoanAmount = (float.Parse(System.Console.ReadLine()));

                            System.Console.WriteLine("Enter the Tenure in months");//Enter the tenure in months for the personalloan
                            pl.Tenure = (float.Parse(System.Console.ReadLine()));

                            pb.CalculateEmi(pl.Tenure,pl.LoanAmount);//enter the loanamount,tenure for calculation of emi
                            pb.AddPersonalLoan(pl);
                            System.Console.WriteLine("your loan is accepted");
                        }
                        else//if credit score value less than 650 loan is rejected
                        {
                            System.Console.WriteLine("your loan is rejected");
                        }

                        break;

                   //case 2 for vehicleloan
                    case 2:;
                        
                        System.Console.WriteLine("Enter the name of vehicle:");//Enter the name of vehicle you want to buy
                        vl.NameOfVehicle = System.Console.ReadLine();

                        System.Console.Write("\nEnter Account Number : ");//Enter the account number for vehicle loan
                        vl.AccountNumber = System.Console.ReadLine();


                        System.Console.WriteLine("Enter the CreditScore");//Enter the credit score for your loan acceptance of vehicle loan
                        vl.CreditScore = (int.Parse(System.Console.ReadLine()));
                        if (vl.CreditScore >= 650)//If credit score value greater than or equal to 650 loan is accepted
                        {

                            System.Console.WriteLine("Enter the LoanAmount");//Enter the loan amount for the vehicleLoan
                            vl.LoanAmount = (float.Parse(System.Console.ReadLine()));

                            System.Console.WriteLine("Enter the Tenure in months");//Enter the tenure in months for the vehicleLoan
                            vl.Tenure = (float.Parse(System.Console.ReadLine()));

                            vb.CalculateEmi(vl.Tenure, vl.LoanAmount);//calculation of emi
                            vb.AddVehicleLoan(vl);
                            System.Console.WriteLine("your loan is accepted");
                        }
                        else //If crdeit score value less than 650  loan is rejected
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