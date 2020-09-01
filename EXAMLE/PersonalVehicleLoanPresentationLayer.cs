//NAVYA presentation layer
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;
using Znalytics.Group3.PecuniaBank.Entities;
using Znalytics.PecuniaBanking.CustomerModule.Entities;


namespace Znalytics.Group3.PecuniaBank.PresentationLayer
{
    /// <summary>
    /// presentation class for personal and vehicle loan
    /// </summary>

    public class PersonalVehicleLoanPresentationLayer
    {
        public static void Start()
        {
                  
        
            Customer cus = new Customer();
            PersonalLoanEntity pl = new PersonalLoanEntity();//creating a object for personalloan entity
            VehicleLoanEntity vl = new VehicleLoanEntity();//creating a object for vehicleloan entity
            PersonalLoanBusinessLogicLayer pb = new PersonalLoanBusinessLogicLayer();//creating a object for personaloanbusinesslogiclayer
            VehicleLoanBusinessLogicLayer vb = new VehicleLoanBusinessLogicLayer();//creating a object for vehicleloanbusinesslogiclayer

            char c = 'Y';
            do
            {
                System.Console.WriteLine("*********WELCOME TO PECUNIA BANK***********\n");
                System.Console.WriteLine("For LOAN ACCEPTANCE\n");
                System.Console.WriteLine("1 - PERSONAL LOAN\n");
                System.Console.WriteLine("2 - VEHICLE LOAN\n");
                System.Console.WriteLine("3 - EXIT\n");


                //switch case for checking whether to take personal loan or vehicle loan
                int n;
                n = int.Parse(System.Console.ReadLine());


                switch (n)
                {
                    //case 1 for personal loan
                    case 1:
                       
                            System.Console.Write("\nEnter CustomerId : ");//Enter the customerId for personal loan
                            pl.CustomerId = cus.CustomerId;
                           /* Customer s = pb.GetCustomersByCustomerId(pl.CustomerId);
                            WriteLine("Name" + s.CustomerName);
                            WriteLine("Profession" + s.Profession);
                            WriteLine("Address" + s.Address);
                            WriteLine("AnnualIncome" + s.AnnualIncome );
                            WriteLine("PanCardNumber" + s.PanCardNumber );
                            WriteLine("AadharCardNumber" + s.AadharCardNumber );*/
                            
                            

                        System.Console.Write("\nEnter the CreditScore : ");//Enter the credit score for loan acceptance of personal loan
                        pl.CreditScore = (int.Parse(System.Console.ReadLine()));

                        if (pb.CreditScore(pl.CreditScore) == 1)//If credit score value greater than or equal to 650 loan is accepted
                        {
                            try
                            {
                                System.Console.Write("\nEnter the LoanAmount : ");//Enter the Loan amount for the personalloan
                                pl.LoanAmount = (float.Parse(System.Console.ReadLine()));

                            }
                            catch (PersonalLoanException ex)
                            {
                                Console.WriteLine(ex.Message);
                                break;
                            }
                            try
                            {
                                System.Console.Write("\nEnter the Tenure in months : ");//Enter the tenure in months for the personalloan
                                pl.Tenure = (float.Parse(System.Console.ReadLine()));

                            }
                            catch (PersonalLoanException ex)
                            {
                                Console.WriteLine(ex.Message);
                                break;
                            }

                            pb.AddPersonalLoan(pl);
                            //enter the loanamount,tenure for calculation of emi

                            System.Console.WriteLine("\n Congratulations...............your loan is accepted");
                            Console.Write("The Monthly EMI you have to pay is : " + pb.CalculateEmi(pl.Tenure, pl.LoanAmount));
                        }
                        else if (pb.CreditScore(pl.CreditScore) == 2)
                        {
                            Console.WriteLine(" \nYour Loan is in Pending status,please apply loan when your credit score is above 650\n");
                        }
                        else//if credit score value less than 650 loan is rejected
                        {
                            System.Console.WriteLine("sorry Your loan is rejected ");
                        }


                        break;

                    //case 2 for vehicleloan
                    case 2:


                        System.Console.Write("Enter the name of vehicle:");//Enter the name of vehicle you want to buy
                        vl.NameOfVehicle = System.Console.ReadLine();

                        System.Console.Write("\nEnter CustomerId : ");//Enter the customerid for vehicle loan
                        vl.CustomerId = (int.Parse(System.Console.ReadLine()));


                        System.Console.Write("\nEnter the CreditScore : ");//Enter the credit score for your loan acceptance of vehicle loan
                        
                        int q = (int.Parse(System.Console.ReadLine()));
                        vl.CreditScore = q;

                        if (vb.CreditScore(vl)== 1)//If credit score value greater than or equal to 650 loan is accepted
                        {
                            try
                            {
                                System.Console.Write("\nEnter the LoanAmount : ");//Enter the Loan amount for the personalloan
                                vl.LoanAmount = (float.Parse(System.Console.ReadLine()));
                                vb.AddVehicleLoan(vl);

                            }
                            catch (PersonalLoanException ex)
                            {
                                Console.WriteLine(ex.Message);
                                break;
                            }
                            try
                            {
                                System.Console.Write("\nEnter the Tenure in months : ");//Enter the tenure in months for the personalloan
                                vl.Tenure = (float.Parse(System.Console.ReadLine()));
                                vb.AddVehicleLoan(vl);
                            }
                            catch (PersonalLoanException ex)
                            {
                                Console.WriteLine(ex.Message);
                                break;
                            }

                            vb.AddVehicleLoan(vl);
                            //enter the loanamount,tenure for calculation of emi


                            System.Console.WriteLine("\n Congratulations...............your loan is accepted");
                            if (vb.CalculateEmi(vl) == 0)
                            {
                                System.Console.WriteLine("sorry Your loan is rejected ");
                            }
                            else
                            {
                                vb.AddVehicleLoan(vl);
                                Console.Write("\nThe Monthly EMI you have to pay is : "+vl.Emi);

                            }
                        }
                        else if (vb.CreditScore(vl) == 2)
                        {
                            Console.WriteLine(" \nYour Loan is in Pending status,please apply loan when your credit score is above 650\n");
                        }
                        else//if credit score value less than 650 loan is rejected
                        {
                            System.Console.WriteLine("sorry Your loan is rejected ");
                        }

                        break;




                    case 3:
                        Console.WriteLine("Thanks For Using PECUNIA BANK");

                        break;

                    default:
                        System.Console.WriteLine("\nplease choose the correct Option\n");
                        break;
                }

                Console.Write("\nIf You Want to Use Again Press Y/N : ");
                c = char.Parse(Console.ReadLine());
            } while (c == 'Y' || c == 'y');
        }
    }
}



