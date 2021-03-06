﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
   

    public class AccountDAL //: IAccountDetailDAL
    {

        public long accno;
        public double balance;
        public string transactionType;

    }


    public class AccountDetailDAL : AccountDAL
    {


        //  public long GetAccountNumber { set; get; } = 101;
        //public long GetAmount { set; get; } = 20000;
        public static List<AccountDAL> _acclist;

        //constructor 
        public AccountDetailDAL()
        {
            _acclist = new List<AccountDAL>();

            _acclist.Add(new AccountDAL() { accno = 101, balance = 20000, transactionType = "Savings" });
            _acclist.Add(new AccountDAL() { accno = 102, balance = 30000, transactionType = "Current" });

        }

        /// <summary>
        /// Getting the Account Number
        /// </summary>
        /// <returns>Account Number List</returns>
        public static List<AccountDAL> Getaccounts()
        {
            return _acclist;
        }



    }
}
