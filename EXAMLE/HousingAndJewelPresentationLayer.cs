
using Znalytics.Group3.PecuniaBank.Entities;
using Znalytics.Group3.PecuniaBank.HousingLoan.Entities;

namespace Znalytics.Group3.PecuniaBank.HousingAndJewelPresentationLayer
   {
    /// <summary>
    /// PresentationLayer for HousingLoan and JewelLoan
    /// </summary>
class HousingLoan
    {
        static void Main()
        {
            System.Console.WriteLine("-----welcome to pecunia bank-------");//options for type of loan
            System.Console.WriteLine("1.HousingLoan");
            System.Console.WriteLine("2.GoldLoan");
            System.Console.WriteLine("3.exit");
            int n;
            n = int.Parse(System.Console.ReadLine());//using n variable in the switch case
            {
                switch (n)
                {
                    case 1://choosing HousingLoan option
                        HousingLoan h = new HousingLoan();
                        System.Console.WriteLine("enter accountno");//prints account no
                        long _accountNo = long.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("enter Age of Customer");
                        int _ageOfCustomer = int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("enter credit score");
                        int _creditScore = int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("enter Loan Amount");
                        int _loanOfAmount = int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("enter rateofinterest");
                        double _rateOfInterest = double.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("enter tenure");
                        double _tenure = double.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("emi value");
                        float _emi = float.Parse(System.Console.ReadLine());


                        break;

                    case 2://choosing GoldLoan option
                        GoldLoan g = new GoldLoan();
                        System.Console.WriteLine("enter aadharno");
                        long _aadharNo = long.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("enter ageofcustomer");
                        int ageOfCustomer = int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("enter Loan Amount");
                        int loanOfAmount = int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("enter rateofinterest");
                        double rateOfInterest = double.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("enter tenure");
                        double tenure = double.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("emi value");
                        float emi = float.Parse(System.Console.ReadLine());

                        break;
                    case 3:
                        System.Console.WriteLine("exit ");
                        break;
                }
                System.Console.ReadKey();
            }
        }