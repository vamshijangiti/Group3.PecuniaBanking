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
                System.Console.WriteLine("*********WELCOME TO PECUNIA BANK***********\n");
                System.Console.WriteLine("For LOAN ACCEPTANCE\n");
                System.Console.WriteLine("1 - PERSONAL LOAN\n");
                System.Console.WriteLine("2 - VEHICLE LOAN\n");
                System.Console.WriteLine("3 - EXIT\n");




                int n;
                n = int.Parse(System.Console.ReadLine());

                char c = 'Y';
                //switch case for checking whether to take personal loan or vehicle loan
                do
                {
                    switch (n)
                    {
                        //case 1 for personal loan
                        case 1:

                            try
                            {
                                System.Console.Write("\nEnter Account Number : ");//Enter the account number for personal loan
                                pl.AccountNumber = System.Console.ReadLine();
                            }
                            catch (PersonalLoanException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }


                            System.Console.Write("\nEnter the CreditScore : ");//Enter the credit score for loan acceptance of personal loan
                            pl.CreditScore = (int.Parse(System.Console.ReadLine()));

                            if (pb.CreditScore(pl.CreditScore) == 1)//If credit score value greater than or equal to 650 loan is accepted
                            {

                                System.Console.Write("\nEnter the LoanAmount : ");//Enter the Loan amount for the personalloan
                                pl.LoanAmount = (float.Parse(System.Console.ReadLine()));

                                System.Console.Write("\nEnter the Tenure in months : ");//Enter the tenure in months for the personalloan
                                pl.Tenure = (float.Parse(System.Console.ReadLine()));

                                
                                pb.AddPersonalLoan(pl);
                                //enter the loanamount,tenure for calculation of emi


                                System.Console.WriteLine("\n Congratulations...............your loan is accepted");
                                Console.Write("The Monthly EMI you have to pay is : " + pb.CalculateEmi(pl.Tenure, pl.LoanAmount));//Displays monthly EMI
                            }
                            else if (pb.CreditScore(pl.CreditScore) == 2)
                            {
                                Console.WriteLine(" \nYour Loan is in Pending status,please apply loan when your credit score is above 650\n");
                            }
                            else//if credit score value less than 650 loan is rejected
                            {
                                System.Console.WriteLine("sorry Your loan is rejected ");//if the entered credit score is less than 650 your loan will be rejected
                            }

                            break;

                        //case 2 for vehicleloan
                        case 2:


                            System.Console.Write("Enter the name of vehicle:");//Enter the name of vehicle you want to buy
                            vl.NameOfVehicle = System.Console.ReadLine();

                            System.Console.Write("\nEnter Account Number : ");//Enter the account number for vehicle loan
                            vl.AccountNumber = System.Console.ReadLine();


                            System.Console.Write("\nEnter the CreditScore : ");//Enter the credit score for your loan acceptance of vehicle loan
                            vl.CreditScore = (int.Parse(System.Console.ReadLine()));
                            if (vl.CreditScore >= 650)//If credit score value greater than or equal to 650 loan is accepted
                            {

                                System.Console.Write("\nEnter the LoanAmount : ");//Enter the loan amount for the vehicleLoan
                                vl.LoanAmount = (float.Parse(System.Console.ReadLine()));

                                System.Console.Write("Enter the Tenure in months : ");//Enter the tenure in months for the vehicleLoan
                                vl.Tenure = (float.Parse(System.Console.ReadLine()));

                                vb.CalculateEmi(vl.Tenure, vl.LoanAmount);//calculation of emi
                                vb.AddVehicleLoan(vl);
                                System.Console.WriteLine("\nYour loan is Accepted\n");
                            }
                            else //If crdeit score value less than 650  loan is rejected
                            {
                                System.Console.WriteLine(" \nyour loan is rejected\n");
                            }

                            break;

                        case 3:
                            Console.WriteLine("Thanks For Using PECUNIA BANK");

                            break;

                        default:
                            System.Console.WriteLine("\nplease choose the correct Option\n");//if you want to use again press yes or else press No
                            break;
                    }

                    Console.Write("\nIf You Want to Use Again Press Y/N : ");
                    c = char.Parse(Console.ReadLine());
                } while (c == 'Y' || c == 'y');
            }

            System.Console.ReadKey();
        }




    }
}
