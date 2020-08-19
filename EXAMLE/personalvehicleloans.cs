
class Program
{
    static void Main()
    {
        PersonalLoan p;
        p = new PersonalLoan();
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
                    p.AccountNumber = (System.Console.ReadLine());
                    System.Console.WriteLine(p.AccountNumber);

                    System.Console.WriteLine("Enter the Bank Holders Name");
                    p.AccountHolderName = (System.Console.ReadLine());
                    System.Console.WriteLine(p.AccountHolderName);

                    System.Console.WriteLine("Enter the PhoneNumber");
                    p.PhoneNumber = (System.Console.ReadLine());
                    System.Console.WriteLine(p.PhoneNumber);


                    System.Console.WriteLine("Enter the Permanent Address");
                    p.SetPermanentAddress(System.Console.ReadLine());
                    System.Console.WriteLine(p.GetPermanentAddress());

                    System.Console.WriteLine("Enter the PanCardNumber");
                    p.SetPanCardNumber(System.Console.ReadLine());
                    System.Console.WriteLine(p.GetPanCardNumber());


                    System.Console.WriteLine("Enter the Profession");
                    p.profession = (System.Console.ReadLine());
                    System.Console.WriteLine(p.profession);

                    System.Console.WriteLine("Enter the AnnualIncome");
                    p.AnnualIncome = (double.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine(p.AnnualIncome);

                    System.Console.WriteLine("Enter the LoanAmount");
                    p.LoanAmount = (double.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine(p.LoanAmount);
                    break;

                case 2:
                    System.Console.WriteLine("Bank Account Number for vehicle loan");
                    v.AccountNumber = (System.Console.ReadLine());
                    System.Console.WriteLine(v.AccountNumber);

                    System.Console.WriteLine("Enter the Bank Holders Name");
                    v.AccountHolderName = (System.Console.ReadLine());
                    System.Console.WriteLine(v.AccountHolderName);

                    System.Console.WriteLine("Enter the PhoneNumber");
                    v.PhoneNumber = (System.Console.ReadLine());
                    System.Console.WriteLine(v.PhoneNumber);


                    System.Console.WriteLine("Enter the Permanent Address");
                    v.SetPermanentAddress(System.Console.ReadLine());
                    System.Console.WriteLine(v.GetPermanentAddress());

                    System.Console.WriteLine("Enter the PanCardNumber");
                    v.SetPanCardNumber(System.Console.ReadLine());
                    System.Console.WriteLine(v.GetPanCardNumber());


                    System.Console.WriteLine("Enter the Profession");
                    v.profession = (System.Console.ReadLine());
                    System.Console.WriteLine(v.profession);

                    System.Console.WriteLine("Enter the AnnualIncome");
                    v.AnnualIncome = (double.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine(v.AnnualIncome);

                    System.Console.WriteLine("Enter the LoanAmount");
                    v.LoanAmount = (double.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine(v.LoanAmount);


                    break;
                case 3:
                    System.Console.WriteLine("Thanks For Using PECUNIA BANK");
                    break;
            }
        }
        System.Console.ReadKey();
    }
}
