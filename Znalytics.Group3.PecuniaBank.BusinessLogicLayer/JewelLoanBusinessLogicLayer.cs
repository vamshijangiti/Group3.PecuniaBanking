using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.Entities;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    class JewelLoanBusinessLogicLayer
    {
        JewelLoanDataAccessLayer=_jewelLoanDataAccessLayer;

        public  JewelLoanBusinessLogicLayer()
        {
            _jewelLoanDataAccessLayer = new JewelLoanDataAccessLayer();
        }

        //Add
        public void Add(GoldLoan goldLoan)
        {
            if (goldLoan.CustId != null)
            {
                _jewelLoanDataAccessLayer.Add(goldLoan);
            }
            else
            {
                throw new Exception("GoldLoanCustomerName can't be null");
            }
        }

        //GetAllgoldloanCustomers
        public List<Employee> GetEmployees()
        {
            return _jewelLoanDataAccessLayer.GetGoldLoanCustomers();
        }

        public void UpdateGoldloanCustomer(GoldLoanCustomer goldLoanCustomer)
        {
            if (goldLoanCustomer.GoldLoanCustomerName != null)
            {
                _jewelLoanDataAccessLayer.UpdateGoldLoanCustomer(goldLoanCustomer);
            }
        public class GoldLoan
        {
            //private fields
            private long _aadharNo;
            private int _age;
            private int _carotType;
            private double _loanAmount;
            private double _tenure;
            private double _rateOfInterest;
            private float _emi;

            public void SetAadharNo(long value)
            {
                if (value == 12)//aadhar no should be 12 digits only
                {

                    _aadharNo = value;
                }
                else
                {
                    throw new System.Exception("invalid aadharno");
                }
            }

            public long GetAadharNo()
            {
                return _aadharNo;
            }

            public void SetAge(int value)
            {
                if (_age >= 21)
                {
                    _age = value;//age to apply goldloan should be from 21
                }
                else
                {
                    throw new System.Exception("age not eligible");
                }
            }
            public int GetAge()
            {
                return _age;
            }
            public void SetCarotType(int value)
            {
                _carotType = value;//carotType should be either 18 or 22
            }
            public int GetCarotType()
            {
                return _carotType;
            }
            public void SetloanAmount(double value)
            {
                if (_loanAmount <= 20000)
                {
                    _loanAmount = value;//loanamount should be less than 20000
                }
            }
            public double GetloanAmount()
            {
                return _loanAmount;
            }
            public double tenure
            {
                set; get;//automated property
            }
            public double rateOfInterest
            {
                set; get;//automated property 
            }
            public object CustId { get; internal set; }

            public void Setemi(float value)
            {
                _emi = value;//assigns emi for goldloan through below formula
            }
            public float Getemi()
            {
                return ((float)(((float)(_loanAmount * _rateOfInterest * (1 + _rateOfInterest) * _tenure)) / (1 + _rateOfInterest) * _tenure - 1));

            }
        }

        public class _jewelLoanDataAccessLayer
        {
        }
    }
}
   
