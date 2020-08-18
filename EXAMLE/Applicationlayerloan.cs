using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;
using Znalytics.Group3.PecuniaBank.Entities;

   public class Program
{
    static void Main()
    {
        LoanEntities lo= new LoanEntities();
        LoansBusiness lb = new LoansBusiness();
        
        {
            System.Console.WriteLine("WELCOME TO PECUNIA BANK");
            System.Console.WriteLine("FOR LOAN ACCEPTANCE");
            System.Console.WriteLine("1 - FOR PERSONAL LOAN");
            System.Console.WriteLine("2 - FOR VEHICLE LOAN");
            System.Console.WriteLine("3-EXIT");


            int n;
            n = int.Parse(System.Console.ReadLine());


        
      
            switch (n)
            {
                case 1:

                    System.Console.WriteLine("Bank Account Number for personal loan");
                    lo.AccountNumber = (System.Console.ReadLine());
                    
                    System.Console.WriteLine(lo.AccountNumber);

                    System.Console.WriteLine("Enter the Bank Holders Name");
                    lo.AccountHolderName = (System.Console.ReadLine());
                    System.Console.WriteLine(lo.AccountHolderName);

                    System.Console.WriteLine("Enter the PhoneNumber");
                    lo.PhoneNumber = (System.Console.ReadLine());
                    System.Console.WriteLine(lo.PhoneNumber);


                    System.Console.WriteLine("Enter the Permanent Address");
                    lo.PermanentAddress=(System.Console.ReadLine());
                    System.Console.WriteLine(lo.PermanentAddress);

                    System.Console.WriteLine("Enter the PanCardNumber");
                    lo.PanCardNumber=(System.Console.ReadLine());
                    System.Console.WriteLine(lo.PanCardNumber);

                    System.Console.WriteLine("Enter the Profession");
                    lo.Profession = (System.Console.ReadLine());
                    System.Console.WriteLine(lo.PanCardNumber);



                    System.Console.WriteLine("Enter the AnnualIncome");
                    lo.AnnualIncome = (double.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine(lo.AnnualIncome);

                    System.Console.WriteLine("Enter the LoanAmount");
                    lo.LoanAmount = (double.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine(lo .LoanAmount);
                    break;

                case 2:
                    System.Console.WriteLine("Bank Account Number for vehicle loan");
                    lo.AccountNumber = (System.Console.ReadLine());
                    System.Console.WriteLine(lo.AccountNumber);

                    System.Console.WriteLine("Enter the Bank Holders Name");
                    lo.AccountHolderName = (System.Console.ReadLine());
                    System.Console.WriteLine(lo.AccountHolderName);

                    System.Console.WriteLine("Enter the PhoneNumber");
                    lo.PhoneNumber = (System.Console.ReadLine());
                    System.Console.WriteLine(lo.PhoneNumber);


                    System.Console.WriteLine("Enter the Permanent Address");
                    lo.PermanentAddress=(System.Console.ReadLine());
                    System.Console.WriteLine(lo.PermanentAddress);

                    System.Console.WriteLine("Enter the PanCardNumber");
                    lo.PanCardNumber=(System.Console.ReadLine());
                    System.Console.WriteLine(lo.PanCardNumber);


                    System.Console.WriteLine("Enter the Profession");
                    lo .Profession = (System.Console.ReadLine());
                    System.Console.WriteLine(lo.Profession);

                    System.Console.WriteLine("Enter the AnnualIncome");
                    lo.AnnualIncome = (double.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine(lo.AnnualIncome);

                    System.Console.WriteLine("Enter the LoanAmount");
                    lo.LoanAmount = (double.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine(lo .LoanAmount);


                    break;
                case 3:
                    System.Console.WriteLine("Thanks For Using PECUNIA BANK");
                    break;
            }
        }
        System.Console.ReadKey();
    }
}
