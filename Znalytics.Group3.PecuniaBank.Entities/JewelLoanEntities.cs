using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Housing loan Entities
/// </summary>
namespace Znalytics.Group3.PecuniaBank.Entities
{
            public class JewelLoan
            {
                //private fields
                private int _custId;
                private long _aadharNo;
                private int _age;
                private int _carotType;
                private double _loanAmount;
                private double _tenure;
                private double _rateOfInterest;
                private float _emi;

                public int CustId
                {
                    set//property
                    {
                        if (_custId != 0)
                        {
                            this._custId = CustId;//this refers to current object
                        }
                    }
                    get
                    {
                        return CustId;//returns Cureent object
                    }
                }
                public long AadharNo
                {
                    set//property
                    {
                        if (value == 12)
                        {
                            this._aadharNo = AadharNo;//this keyword
                        }
                    }
                    get
                    {
                        return AadharNo;//returns aadharno
                    }
                }

                /*public void SetAadharNo(long value)
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
                }*/
                public int Age
                {
                    set
                    {
                        if (_age >= 21)//validation
                        {
                            this._age = Age;//assigns value as age
                        }
                    }
                    get
                    {
                        return Age;//returns age
                    }
                }
                /*public void SetAge(int value)
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
                }*/
                public int CarotType
                {
                    set
                    {
                        if (_carotType == 22 && _carotType == 24)//validation for carottype
                        {
                            this._carotType = CarotType;//asssigns value to carottype
                        }
                    }
                    get
                    {
                        return CarotType;//returns carottype
                    }
                }
                /*public void SetCarotType(int value)
                {
                    _carotType = value;//carotType should be either 18 or 22
                }
                public int GetCarotType()
                {
                    return _carotType;
                }*/
                public double LoanAmount
                {
                    set
                    {
                        if (_loanAmount <= 20000)//validation
                        {
                            this._loanAmount = LoanAmount;
                        }
                    }
                    get//property
                    {
                        return LoanAmount;
                    }
                }
                /*public void SetloanAmount(double value)
                {
                    if (_loanAmount <= 20000)
                    {
                        _loanAmount = value;//loanamount should be less than 20000
                    }
                }
                public double GetloanAmount()
                {
                    return _loanAmount;
                }*/
                public double tenure
                {
                    set; get;//automated property
                }
                public double rateOfInterest
                {
                    set; get;//automated property 
                }
                public float Emi
                {
                    set//property
                    {
                        if (_emi != 0)
                        {
                            this._emi = Emi;//refers to current object
                        }
                    }
                    get
                    {
                        return ((float)(((float)(_loanAmount * _rateOfInterest * (1 + _rateOfInterest) * _tenure)) / (1 + _rateOfInterest) * _tenure - 1));
                    }
                }

                /*  public void Setemi(float value)
                  {
                      _emi = value;//assigns emi for goldloan through below formula
                  }
                  public float Getemi()
                  {
                      return ((float)(((float)(_loanAmount * _rateOfInterest * (1 + _rateOfInterest) * _tenure)) / (1 + _rateOfInterest) * _tenure - 1));

                  }*/
            }
        }
    
