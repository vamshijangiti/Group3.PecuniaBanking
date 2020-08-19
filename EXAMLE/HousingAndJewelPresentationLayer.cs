
using System;
using Znalytics.Group3.PecuniaBank.Entities;
using Znalytics.Group3.PecuniaBank.HousingLoan.Entities;

namespace Znalytics.Group3.PecuniaBank.HousingAndJewelPresentationLayer;
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
                    int accountNo = System.Convert.ToInt32(System.Console.ReadLine());
                    System.Console.WriteLine("enter accountholdername");
                    string accountHolderName = System.Console.ReadLine();
                    System.Console.WriteLine("enter age of customer");
                    int ageOfCustomer = System.Convert.ToInt32(System.Console.ReadLine());
                    System.Console.WriteLine("enter credit score");
                    int creditScore = System.Convert.ToInt32(System.Console.ReadLine());
                    h.SetCreditScore(int.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine("enter loan amount");
                    h.SetLoanAmount(double.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine("enter tenure");
                    h.SetTenure(double.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine("enter rateOfinterest");
                    h.SetRateOfInterest(double.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine("emi value");
                    h.SetEmi(float.Parse(System.Console.ReadLine()));
                    HousingLoan h1 = new HousingLoan();
                    HousingLoan h2 = new HousingLoan();
                    HousingLoan h3 = new HousingLoan();
                    HousingLoan h4 = new HousingLoan();
                    HousingLoan h5 = new HousingLoan();
                    Console.WriteLine(h.accountHolderName());
                    Console.WriteLine(h1.accountHolderName());
                    System.Console.WriteLine(h2.ageOfCustomer());
                    Console.WriteLine(h3.CreditScore());
                    break;

                case 2://choosing GoldLoan option
                    GoldLoan g = new GoldLoan();
                    
                    System.Console.WriteLine("enter aadharno");
                    long _aadharNo = long.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("enter ageofcustomer");
                    int _ageOfCustomer = int.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("enter Loan Amount");
                    int _loanOfAmount = int.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("enter rateofinterest");
                    double _rateOfInterest = double.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("enter tenure");
                    double _tenure = double.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("emi value");
                    float _emi = float.Parse(System.Console.ReadLine());
                    break;
                case 3:
                    System.Console.WriteLine("exit ");
                    break;
            }
            System.Console.ReadKey();
        }
    }

    private bool accountHolderName()
    {
        throw new NotImplementedException();
    }

    private bool ageOfCustomer()
    {
        throw new NotImplementedException();
    }
}
}