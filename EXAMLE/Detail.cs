/// <summary>
/// Creating presentation Layer for pecunia Banking
/// </summary>
namespace Znalytics.Group3.PecuniaBank
{
    class Accounts
    {
        /// <summary>
        /// Representing the main method of Presentation Layer
        /// </summary>
        static void Accountspresentation()
        {
            //creating the object for Pecunia.
            
            System.Console.WriteLine("WELCOME TO PECUNIA BANKING ");
            System.Console.WriteLine("If you want to opean SavingsAccount enter   1");
            System.Console.WriteLine("If you want to opean CurrentAccount enter   2");
            System.Console.Write("Choose the type of Bank Account you want to opean (1 or 2): ");
            int Accountname = System.Convert.ToInt32(System.Console.ReadLine());

            //Switching case represents the Account you want to choose.
            switch (Accountname)
            {
                // Case1 represent the details of SAVINGS ACCOUNT.
                case 1:

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
                    System.Console.WriteLine("Enter the details of driving license ");
                    string license = System.Console.ReadLine();
                    System.Console.WriteLine("Enter your Aaddhaar-card number:  ");
                    int aadhaarNumber = System.Convert.ToInt32(System.Console.ReadLine());
                    p.SavingsAccount(customerName: custName, address: addr, occupation: occupation, panCardNumber: pan, voterID: voterDetails, passport: passportNumber, drivingLicense: license, aadhaarCardNumber: aadhaarNumber);
                    System.Console.WriteLine("your details for savingsaccount are ");
                    System.Console.WriteLine("customer name : " + p.CustomerName);
                    System.Console.WriteLine("address : " + p.Address);
                    System.Console.WriteLine("occupation : " + p.Occupation);
                    System.Console.WriteLine("pancard number:" + p.PanCardNumber);
                    System.Console.WriteLine("voterID :" + p.VoterID);
                    System.Console.WriteLine("passport number : " + p.Passport);
                    System.Console.WriteLine("driving license : " + p.DrivingLicense);
                    System.Console.WriteLine("Aaddhaar-card number: " + p.AadhaarCardNumber);
                    System.Console.ReadKey();
                    break;
                    // Case2 represents thedetails of CURRENT ACCOUNT.
                case 2:
                    System.Console.WriteLine("Enter the customer name");
                    string cn = System.Console.ReadLine();
                    System.Console.WriteLine("enter the pancard number:  ");
                    string pN = System.Console.ReadLine();
                    System.Console.WriteLine("Enter the voterID ");
                    string vID = System.Console.ReadLine();
                    System.Console.WriteLine("enter the passport number ");
                    string ppN = System.Console.ReadLine();
                    System.Console.WriteLine("Enter the details od driving license ");
                    string l = System.Console.ReadLine();
                    System.Console.WriteLine("Enter your Aaddhaar-card number:  ");
                    int aN = System.Convert.ToInt32(System.Console.ReadLine());
                    System.Console.WriteLine("Enter the UtilityBillProof :");
                    string utility = System.Console.ReadLine();
                    System.Console.WriteLine("Enter the RationCardNumber");
                    int rationNumber = System.Convert.ToInt32(System.Console.ReadLine());
                    System.Console.WriteLine("Enter the  employeeID");
                    int empID = System.Convert.ToInt32(System.Console.ReadLine());
                    p.CurrentAccount(utilityBillProof: utility, rationCardNumber: rationNumber, employeeID: empID);
                    System.Console.WriteLine("your details for CurrentAccount are ");
                    System.Console.WriteLine("customer name : " + p.CustomerName);
                    System.Console.WriteLine("pancard number:" + p.PanCardNumber);
                    System.Console.WriteLine("voterID :" + p.VoterID);
                    System.Console.WriteLine("passport number : " + p.Passport);
                    System.Console.WriteLine("driving license : " + p.DrivingLicense);
                    System.Console.WriteLine("Aaddhaar-card number: " + p.AadhaarCardNumber);
                    System.Console.WriteLine(" Utility bill proof : " + p.UtilityBillProof);
                    System.Console.WriteLine(" Ration Card Number : " + p.RationCardNumber);
                    System.Console.WriteLine(" EmployeeID : " + p.EmployeeID);

                    break;
                    // Default represent the caussion to the person to enter the correct option.
                default:
                    System.Console.WriteLine("Please enter the correct option that is (1 or 2) ");
                    break;

            }
            System.Console.WriteLine("Thank you for showing intrest in Pecunia Banking");
            System.Console.ReadKey();
        }
    }
}