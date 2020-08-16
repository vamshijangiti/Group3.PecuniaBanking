class Program
{
    static void Main()
    {
        PersonalLoan P;
        P = new PersonalLoan();
        VehicleLoan v;
        v = new VehicleLoan();

        System.Console.WriteLine("WELCOME TO PECUNIA BANK");
        System.Console.WriteLine("FOR LOAN ACCEPTANCE");
        System.Console.WriteLine("1 - FOR PERSONAL LOAN");
        System.Console.WriteLine("2 - FOR VEHICLE LOAN");
        System.Console.WriteLine("3-EXIT");


        int n;
        n = int.Parse(System.Console.ReadLine());



        {
            switch (n)
            {
                case 1:

                    System.Console.WriteLine("Bank Account Number for personal loan");
                    P.AccountNumber = (System.Console.ReadLine());
                    System.Console.WriteLine(P.AccountNumber);

                    System.Console.WriteLine("Enter the Bank Holders Name");
                    P.AccountHolderName = (System.Console.ReadLine());
                    System.Console.WriteLine(P.AccountHolderName);

                    System.Console.WriteLine("Enter the PhoneNumber");
                    P.PhoneNumber = (System.Console.ReadLine());
                    System.Console.WriteLine(P.PhoneNumber);


                    System.Console.WriteLine("Enter the Permanent Address");
                    P.SetPermanentAddress(System.Console.ReadLine());
                    System.Console.WriteLine(P.GetPermanentAddress());

                    System.Console.WriteLine("Enter the PanCardNumber");
                    P.SetPanCardNumber(System.Console.ReadLine());
                    System.Console.WriteLine(P.GetPanCardNumber());


                    System.Console.WriteLine("Enter the Profession");
                    P.profession = (System.Console.ReadLine());
                    System.Console.WriteLine(P.profession);

                    System.Console.WriteLine("Enter the AnnualIncome");
                    P.AnnualIncome = (double.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine(P.AnnualIncome);

                    System.Console.WriteLine("Enter the LoanAmount");
                    P.LoanAmount = (double.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine(P.LoanAmount);
                    break;

                case 2:
                    System.Console.WriteLine("Bank Account Number for vehicle loan");
                    P.AccountNumber = (System.Console.ReadLine());
                    System.Console.WriteLine(P.AccountNumber);

                    System.Console.WriteLine("Enter the Bank Holders Name");
                    P.AccountHolderName = (System.Console.ReadLine());
                    System.Console.WriteLine(P.AccountHolderName);

                    System.Console.WriteLine("Enter the PhoneNumber");
                    P.PhoneNumber = (System.Console.ReadLine());
                    System.Console.WriteLine(P.PhoneNumber);


                    System.Console.WriteLine("Enter the Permanent Address");
                    P.SetPermanentAddress(System.Console.ReadLine());
                    System.Console.WriteLine(P.GetPermanentAddress());

                    System.Console.WriteLine("Enter the PanCardNumber");
                    P.SetPanCardNumber(System.Console.ReadLine());
                    System.Console.WriteLine(P.GetPanCardNumber());


                    System.Console.WriteLine("Enter the Profession");
                    P.profession = (System.Console.ReadLine());
                    System.Console.WriteLine(P.profession);

                    System.Console.WriteLine("Enter the AnnualIncome");
                    P.AnnualIncome = (double.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine(P.AnnualIncome);

                    System.Console.WriteLine("Enter the LoanAmount");
                    P.LoanAmount = (double.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine(P.LoanAmount);


                    break;
                case 3:
                    System.Console.WriteLine("Thanks For Using PECUNIA BANK");
                    break;
            }
        }
        System.Console.ReadKey();
    }
}
