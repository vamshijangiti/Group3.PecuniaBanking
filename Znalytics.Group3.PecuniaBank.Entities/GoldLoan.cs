using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.Entities
{
 class GoldLoan
    {
        public class GoldLoan : Loan
        {
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
            public void Settenure(double value)
            {
                _tenure = value;//tenure of gold loan
            }
            public double Gettenure()
            {
                return _tenure;
            }
            public void SetrateOfInterest(double value)
            {
                _rateOfInterest = value;//rateof interest of a gold loan
            }
            public double GetrateOfInterest()
            {
                return _rateOfInterest;
            }
            public void Setemi(float value)
            {
                _emi = value;//assigns emi for goldloan through below formula
            }
            public float Getemi()
            {
                return ((float)(((float)(_loanAmount * _rateOfInterest * (1 + _rateOfInterest) * _tenure)) / (1 + _rateOfInterest) * _tenure - 1));

            }
        }
    }
}

    }
}
