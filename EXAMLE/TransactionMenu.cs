
//CREATED BY VAMSHI JANGITI --- PRESENTATION LAYER




using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;
using Znalytics.Group3.PecuniaBank.Entities;
namespace Znalytics.Group3.PecuniaBank.PresentationLayer
{
    /// <summary>
    /// Presentation Class For WithDrawl And Debit
    /// </summary>
    public class TransactionMenu
    {
        public void start()
        {
            
            Transaction e1 = new Transaction();
            TransactionBusinessLogic b = new TransactionBusinessLogic();
            ICustomerBLL customerBLL = new CustomerBLL();
           
            bool flag = false;
            long uan;



            while (true)
            {
                Console.Write("\nEnter AccountNumber : ");
                uan = long.Parse(Console.ReadLine());

                //Validating The Account Number 
                if (b.ValidateAccountNumber(uan) == customerBLL.GetAccountNumber())
                {
                    flag = true;
                    break;
                }
                else
                {
                    Console.WriteLine("\n Please Enter valid Account number : ");
                }
            }


            if (flag)
            {
                //if User entered Account Number is Equals To  Account Number
                if (e1.AccountNumber == uan)
                {

                    System.Console.WriteLine("\n\t\t************* WELCOME TO PECUNIA BANK ***********\t\t \n\n");

                    Console.Write("\n Enter today's Date (DT-MM-YEAR) : " + e1.TransactionDate);

                    char ch = 'Y';
                    do
                    {
                        //Menu For Choosing Options

                        System.Console.WriteLine("Start Your Transaction\n");
                        System.Console.WriteLine("\n1 - FOR DEPOSIT");
                        System.Console.WriteLine("\n2 - FOR WITHDRAWL");
                        System.Console.WriteLine("\n2 - CHECK BALANCE");
                        System.Console.WriteLine("\n3- EXIT");
                        Console.Write("\nEnter Your choice : ");
                        int n;
                        n = int.Parse(System.Console.ReadLine());
                        double da;
                        //Switch Case For Checking

                        switch (n)
                        {
                            case 1:
                                Console.WriteLine("\nEnter amount to Deposit");
                                 e1.TransactionAmount = double.Parse(Console.ReadLine());
                                b.Deposit(e1);
                                if(b.ValidateDeposit(e1.TransactionAmount)==true)
                                {
                                   

                                    Console.WriteLine("\nThe Deposited Amount is : "+e1.TransactionAmount);
                                    
                                }
                                break;
                            case 2:
                                Console.WriteLine("\nEnter amount to WithDrawl");
                                double wa = double.Parse(Console.ReadLine());
                                /* if (b.ValidateWithDrawl(e1.Balance, wa))
                                 {
                                     e1.Balance=e1.Balance - wa;
                                     Console.WriteLine("\navailable balance" + e1.Balance);
                                 }
                                 else
                                 {
                                     Console.WriteLine("\nInsufficient Balance");
                                 }*/
                                break;
                            case 3:
                                Console.WriteLine("Available Balance is : "+e1.TransactionAmount);
                                break;


                        }
                        Console.Write("\n Do you want to Use it Again press Y else N : ");
                        ch = char.Parse(Console.ReadLine());
                    } while (ch == 'Y');

                }

                else
                {
                    Console.WriteLine("\naccount not exist");
                }

               


            }

        }

        public double AvailableBalance(double available)
        {

          return  available += 0;

        }


    }
}
