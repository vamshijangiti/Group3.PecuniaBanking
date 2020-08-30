
//CREATED BY VAMSHI JANGITI --- PRESENTATION LAYER

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;
using Znalytics.Group3.PecuniaBank.AccountEntities;

namespace Znalytics.Group3.PecuniaBank.PresentationLayer
{
    /// <summary>
    /// Presentation Layer For WithDrawl And Debit
    /// </summary>
    public class TransactionMenu
    {
        public void start()
        {
            //object Declaration for classes
            TransactionBusinessLogic b = new TransactionBusinessLogic();

            bool flag = false;
            long uan;
            int tx = 0;

            //Random Class
            Random random = new Random();


            //checking whether the entered Accout is correct or not
            while (true)
            {
                //Gives Random Numbers within 10 
                int num1 = random.Next(10);
                int num2 = random.Next(10);
                Console.Write("\nSecurity Check ");
                //Reading the user entered Data
                Console.Write("\nenter sum of " + num1 + "+" + num2 + " = ");
                int r = int.Parse(Console.ReadLine());
                if (r != (num1 + num2))
                    continue;


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
                if (uan == b.GetAccountNumber())
                {

                    System.Console.WriteLine("\n\t\t************* WELCOME TO PECUNIA BANK ***********\t\t \n\n");
                    char ch = 'Y';
                    do
                    {
                        //Menu For Choosing Options
                        System.Console.WriteLine("\nStart Your Transaction\n");
                        System.Console.WriteLine("\n1 - FOR DEPOSIT");
                        System.Console.WriteLine("\n2 - FOR WITHDRAWL");
                        System.Console.WriteLine("\n3 - CHECK BALANCE");
                        System.Console.WriteLine("\n4 - Transactions");
                        System.Console.WriteLine("\n5- EXIT");
                        Console.Write("\nEnter Your choice : ");
                        int n;
                        n = int.Parse(System.Console.ReadLine());


                        //Switch Case for 
                        switch (n)
                        {
                            case 1:
                                DisplayDeposit();

                                break;
                            case 2:

                                DisplayWithDrawl();
                                break;
                            case 3:
                                checkBalance();
                                break;


                            case 4:
                                LastTransactions();
                                break;
                            default:
                                //when you choose different nub
                                Console.WriteLine("\nOops...!  InCorrect Request \n");
                                break;


                        }
                        Console.Write("\n Do you want to Use it Again press Y else N : ");
                        ch = char.Parse(Console.ReadLine());

                    } while (ch == 'Y' || ch == 'y');

                }

                else
                {
                    Console.WriteLine("\nAccount does not exist\nPlease enter a valid Account Number");
                }

            }



            //Getting Last 10 Transactions
            void LastTransactions()
            {
                Console.Write("\nEnter AccountNumber to Check The Last 10 Transactions : ");
                //Entering data From Keyboard
                uan = long.Parse(Console.ReadLine());
                List<Transaction> tc = b.GetTransactions(uan);
                Transaction t = new Transaction();
                //foreach Loop to get details from list
                foreach (var item in tc)
                {
                    //if item is not equal to NULL
                    if (item != null)
                    {

                        t.TransactionTpe = Console.ReadLine();
                        if (t.TransactionTpe == "savings")
                        {
                            Console.WriteLine(" Transactions : " + item.TransactionID + " " + item.TransactionDate + " " + item.TransactionAmount + " " + item.TransactionTpe);
                        }
                        else if (t.TransactionTpe == "Current")
                        {
                            Console.WriteLine(" Transactions : " + item.TransactionID + " " + item.TransactionDate + " " + item.TransactionAmount + " " + item.TransactionTpe);
                        }


                    }
                    else
                    {
                        Console.WriteLine("\nsorry No Transactions are done for last 10 days. ");
                    }
                }
            }





            //Cheking the Balance
            void checkBalance()
            {
                Transaction e1 = new Transaction();
                Console.Write("\nEnter AccountNumber to Check The Balance : ");
                e1.AccountNumber = long.Parse(Console.ReadLine());
                Console.WriteLine(" Avaiable Balance : " + b.GetAmount(uan));
            }


            //For Displaying the Deposited Amount
            void DisplayDeposit()
            {
                Transaction e1 = new Transaction();
                Console.WriteLine("\nSelect type of Account \n 1.Savings \n2.Current\n");
                int n = int.Parse(Console.ReadLine());


                switch (n)
                {
                    case 1:
                        e1.TransactionTpe = "Savings";
                        Console.WriteLine("\nEnter amount to Deposit ");
                        e1.TransactionDate = System.DateTime.Today;
                        e1.AccountNumber = uan;
                        e1.TransactionID = ++tx;
                        e1.TransactionAmount = double.Parse(Console.ReadLine());
                        b.AddTranscation(e1);
                        b.Deposit(uan, e1.TransactionAmount);
                        if (b.ValidateEnteredAmount(e1.TransactionAmount) == true)
                        {
                            Console.WriteLine("\nThe Deposited Amount is : " + e1.TransactionAmount);

                        }
                        else
                        {
                            Console.WriteLine("\nAmount should be Greater than 500 \n");
                        }
                        break;

                    case 2:
                        e1.TransactionTpe = "Current";
                        Console.WriteLine("\nEnter amount to Deposit ");
                        e1.TransactionDate = System.DateTime.Today;
                        e1.AccountNumber = uan;
                        e1.TransactionID = ++tx;
                        e1.TransactionAmount = double.Parse(Console.ReadLine());
                        b.AddTranscation(e1);
                        b.Deposit(uan, e1.TransactionAmount);
                        if (b.ValidateEnteredAmount(e1.TransactionAmount) == true)
                        {
                            Console.WriteLine("\nThe Deposited Amount is : " + e1.TransactionAmount);

                        }
                        else
                        {
                            Console.WriteLine("\nAmount should be Greater than 500 \n");
                        }
                        break;


                }





            }

            //For Displaying the WithDrawled Amount
            void DisplayWithDrawl()
            {
                //creating the object
                Transaction e1 = new Transaction();
                Console.WriteLine("\nEnter the type of Account");
                e1.TransactionTpe = Console.ReadLine();
                Console.WriteLine("\nEnter amount to WithDrawl");
                e1.TransactionDate = System.DateTime.Today;
                e1.AccountNumber = uan;
                e1.TransactionID = ++tx;
                e1.TransactionAmount = double.Parse(Console.ReadLine());
                b.AddTranscation(e1);
                b.WithDrawlAmount(uan, e1.TransactionAmount);

                if (b.ValidateEnteredAmount(e1.TransactionAmount) == true)
                {
                    if (b.ValidateWithDrawl(e1.TransactionAmount) == true)
                    {

                        Console.WriteLine("\nThe WithDrawled Amount is : " + e1.TransactionAmount);
                    }
                    else
                    {
                        Console.WriteLine("\nInsufficient Balance--Minimum Balance is 5000");
                    }
                }
                else
                {
                    Console.WriteLine("The Withdrawl Amount Should Be Greater Than 500");
                }




            }


        }
    }
}


