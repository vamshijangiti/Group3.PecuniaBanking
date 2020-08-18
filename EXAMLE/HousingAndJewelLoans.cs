     //sriram  presentation layer 


using static Loan;

class program
{
    static void Main()
    {
        System.Console.WriteLine("----------Welcome to pecunia bank--------");
        System.Console.WriteLine("1.Housing Loan");//selects housing loan
        System.Console.WriteLine("2.GoldLoan");//selects GoldLoan
        System.Console.WriteLine("3.exit");//exit from 
        int n;
        n = int.Parse(System.Console.ReadLine());
        {
            switch (n)
            {
                case 1:
                    HousingLoan h = new HousingLoan();//reference variable for housingloan
                    System.Console.WriteLine("enter accountno");
                    int accountNo = System.Convert.ToInt32(System.Console.ReadLine());
                    System.Console.WriteLine("enter accountholdername");
                    //accountHolderName=AccountHolderName;
                    string accountHolderName = System.Console.ReadLine();//read values from keyboard
                    System.Console.WriteLine("enter age of customer");
                    //age=Age;
                    int ageOfCustomer = System.Convert.ToInt32(System.Console.ReadLine());
                    System.Console.WriteLine("enter credit score");
                    h.SetCreditScore(int.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine("enter LoanAmount");
                    h.SetLoanAmount(double.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine("enter tenure");
                    double tenure = double.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("enter rate of interest");
                    h.SetRateOfInterest(float.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine("enter emi");
                    h.Setemi(float.Parse(System.Console.ReadLine()));
                    HousingLoan h1 = new HousingLoan(accountNo);
                    System.Console.WriteLine(h1.AccountNo);
                    HousingLoan h2 = new HousingLoan(accountHolderName);
                    System.Console.WriteLine(h2.AccountHolderName);//get method will be called
                    HousingLoan h3 = new HousingLoan(ageOfCustomer);
                    System.Console.WriteLine(h3.GetAgeOfCustomer());
                    System.Console.WriteLine(h.GetCreditScore());
                    System.Console.WriteLine(h.GetLoanAmount());
                    HousingLoan h4 = new HousingLoan(tenure);
                    System.Console.WriteLine(h4.Tenure);
                    System.Console.WriteLine(h.GetEmi());
                    System.Console.ReadKey();
                    break;

                case 2:
                    GoldLoan g = new GoldLoan();
                    System.Console.WriteLine("enter aadharno");
                    g.SetAadharNo(long.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine("enter age");
                    g.SetAge(int.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine("check carottype");
                    g.SetCarotType((int)double.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine("loanamount");
                    g.SetloanAmount(double.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine("tenure");
                    g.Settenure(double.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine("rate of interest");
                    g.SetrateOfInterest(double.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine("emi");
                    g.Setemi(float.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine(g.GetAadharNo());
                    System.Console.WriteLine(g.GetAge());
                    System.Console.WriteLine(g.GetCarotType());
                    System.Console.WriteLine(g.GetloanAmount());
                    System.Console.WriteLine(g.Gettenure());
                    System.Console.WriteLine(g.GetrateOfInterest());
                    System.Console.WriteLine(g.Getemi());
                    System.Console.ReadKey();
                    break;

                case 3:
                    System.Console.WriteLine("exit from pecunia bank");
                    break;
            }
        }
    }
}
