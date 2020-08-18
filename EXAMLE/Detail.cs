/*class program
{
    static void Main()
    {
        System.Console.WriteLine("Choose the type of Bank Account you want to opean: Saving Account or Current Account ");
        System.Console.WriteLine("please enter the Bank Account you want: ");
        string Accountname = System.Console.ReadLine();
        if ((Accountname == "savingsaccount") || (Accountname == "SavingsAccount"))
        {
            System.Console.WriteLine("Enter the customer name");
            string custName = System.Console.ReadLine();
            System.Console.WriteLine("enter the pancard number:  ");
            string pan = System.Console.ReadLine();
            System.Console.WriteLine("Enter the address: ");
            string addr = System.Console.ReadLine();
            System.Console.WriteLine("enter the occupation ");
            string occupation = System.Console.ReadLine();
            System.Console.WriteLine("Enter the voterID ");
            string voterDetails = System.Console.ReadLine();
            System.Console.WriteLine("enter the passport number ");
            string passportNumber = System.Console.ReadLine();
            System.Console.WriteLine("Enter the details od driving license ");
            string license = System.Console.ReadLine();
            System.Console.WriteLine("Enter your Aaddhaar-card number:  ");
            int aadhaarNumber = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("your details for savingsaccount are ");
            pecunia p = new pecunia(custName, addr, occupation, pan, voterDetails, passportNumber, license, aadhaarNumber);
            System.Console.WriteLine("customer name : " + p.CustomerName);
            System.Console.WriteLine("address : " + p.Address);
            System.Console.WriteLine("occupation : " + p.Occupation);
            System.Console.WriteLine("pancard number:" + p.PanCardNumber);
            System.Console.WriteLine("voterID :" + p.VoterID);
            System.Console.WriteLine("passport number : " + p.Passport);
            System.Console.WriteLine("driving license : " + p.DrivingLicense);
            System.Console.WriteLine("Aaddhaar-card number: " + p.AadhaarCardNumber);
            System.Console.ReadKey();
        }
        else if (Accountname == "CurrentAccount")
        {
            System.Console.WriteLine("Please enter the correct account name ");
        }
        else
        {
            System.Console.WriteLine("Please enter the correct account name ");
        }






    }
} */