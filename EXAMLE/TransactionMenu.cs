
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
            //object Declaration for classes
            Transaction e1 = new Transaction();
            TransactionBusinessLogic b = new TransactionBusinessLogic();
            ICustomerPersonalDetailBLL customerBLL = new CustomerBLL();

            bool flag = false;
            long uan;


            //checking whether the entered Accout is correct or not
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


                        //Switch Case for 
                        switch (n)
                        {
                            case 1:

                                Display();


                                break;
                            case 2:
                                DisplayWithDrawl();
                                break;
                            case 3:

                                Console.WriteLine("Available Balance is : " + e1.TransactionAmount);
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



            void Display()
            {
                Console.WriteLine("\nEnter amount to Deposit");
                e1.TransactionAmount = double.Parse(Console.ReadLine());
                b.Deposit(e1);
                if (b.ValidateDeposit(e1.TransactionAmount) == true)
                {
                    Console.WriteLine("\nThe Deposited Amount is : " + e1.TransactionAmount);

                }
            }

            void DisplayWithDrawl()
            {
                Console.WriteLine("\nEnter amount to WithDrawl");
                double wa = double.Parse(Console.ReadLine());
                if (b.ValidateWithDrawl(e1.TransactionAmount, wa))
                {
                    e1.TransactionAmount = e1.TransactionAmount - wa;
                    Console.WriteLine("\navailable balance" + e1.TransactionAmount);
                }
                else
                {
                    Console.WriteLine("\nInsufficient Balance");
                }
            }



           

        }
    }
}
