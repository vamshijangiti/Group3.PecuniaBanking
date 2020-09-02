﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.AccountEntities;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.HousingLoanEntities;
using Znalytics.PecuniaBanking.CustomerModule.Entities;

/// <summary>
/// Housing loan businesslogiclayer
/// </summary>
namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    public class HousingLoanBusinessLogicLayer
    {
        HousingLoanDataAccessLayer _housingLoanDataAccessLayer;
        

        public HousingLoanBusinessLogicLayer()
        {
            _housingLoanDataAccessLayer = new HousingLoanDataAccessLayer();
        }
        //add

        /// <summary>
        /// Add/Aprrove housing loan
        /// </summary>
        /// <param name="housingLoan">HosingLoan</param>
        public void AddHousingLoan(HousingLoan housingLoan)
        {
            try
            {
                if (housingLoan.CustomerId!=0)
                {
                    _housingLoanDataAccessLayer.Add(housingLoan);//Adds housingLoan
                }
            }

            catch (Exception e)
            {
                throw new HousingLoanException("CustomerId cant be zero",e);//exception raised where customerid cant be zero
            }
            }
        public List<Customer> GetCustomers()
        {
            return GetCustomers();
        }
        public Customer GetCustomersByCustomerId(int CustomerId)
        {
            return GetCustomersByCustomerId(CustomerId);
        }

        public void RejectHousingLoan(HousingLoan housingLoan, int CreditScore)

        {
            if (CreditScore <= 650)
            {
                _housingLoanDataAccessLayer.RejectHousingLoan(housingLoan);
                    
            }
        }
                   
       }
   

}
   public class _housingLoanDataAccessLayer
    {
    }

