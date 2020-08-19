using System;
using System.Collections.Generic;
using Znalytics.Group3.PecuniaBank.Entities;


namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// DataaccessLayer for housingloan and jewelloan
    /// </summary>
    public class HousingAndJewelDal
    {
        public HousingAndJewelDal()
        {
        }
    }
    //create list
    List<AccountNo> accountNos = new List<AccountNo>();

    public void AddAccountNo(AccountNo n) => AccountNo.add(n);

    public class AccountNo
    {
        public static void add(AccountNo n)
        {
            throw new NotImplementedException();
        }
    }
}

