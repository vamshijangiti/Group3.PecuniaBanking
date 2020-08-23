
//CREATED BY VAMSHI JANGITI --- PRESENTATION LAYER




using System;
using System.Collections.Generic;
using System.Linq;
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
            /*   Console.WriteLine("no of accounts");
               int n =int.Parse( Console.ReadLine());
               Entities[] allAcc = new Entities[n];
               for(int i=0;i<n;i++)
               {
                   Entities e = new Entities();
                   Console.WriteLine("Enter account no");
                   e.AccountNumber = long.Parse(Console.ReadLine());
                   Console.WriteLine("Enter Balance");
                   e.Balance = double.Parse(Console.ReadLine());
                   allAcc[i] = e;
               }*/


            Transaction e1 = new Transaction();
            TransactionBusinessLogic b = new TransactionBusinessLogic();
            //Created Statically Account Number And Balance
           // e1.AccountNumber = 1234567812345678;
            bool flag = false;
            long uan;


            while (true)
            {
                Console.Write("\nEnter AccountNumber : ");
                uan = long.Parse(Console.ReadLine());

                //Validating The Account Number 
                if (b.ValidateAccountNumber(uan))
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

                    Console.Write("\n Enter today's Date : "+e1.TransactionDate);

                    char ch = 'Y';
                    do
                    {
                        //Menu For Choosing Options

                        System.Console.WriteLine("Start Your Transaction\n");
                        System.Console.WriteLine("\n1 - FOR DEPOSIT");
                        System.Console.WriteLine("\n2 - FOR WITHDRAWL");
                        System.Console.WriteLine("\n2 - CHECK BALANCE");
                        //System.Console.WriteLine("\n3- EXIT");
                        Console.Write("\nEnter Your choice : ");
                        int n;
                        n = int.Parse(System.Console.ReadLine());

                        //Switch Case For Checking

                        switch (n)
                        {
                            case 1:
                                Console.WriteLine("\nEnter amount to Deposit");
                                double da = double.Parse(Console.ReadLine());
                                //e1.Balance=e1.Balance+ da;
                                // Console.WriteLine("\navailable balance" + e1.Balance);
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


                        }
                        Console.WriteLine("\n Do you want to Use it Again press Y else N ");
                        ch = char.Parse(Console.ReadLine());
                    } while (ch == 'Y');

                }

                else
                {
                    Console.WriteLine("\naccount not exist");
                }


            }

        }




    }
}
