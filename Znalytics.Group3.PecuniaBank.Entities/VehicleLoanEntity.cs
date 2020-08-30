///Entities for vehicle loan
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.Entities
{

    /// <summary>
    /// Entity layer for vehicle loan
    /// </summary>

    public class VehicleLoanEntity
    {
        private string _nameOfVehicle;

        private int _customerId;
        private float _loanAmount;
        private static float _rateOfInterest = 10;
        private float _tenure;
        private float _emi;
        private int _creditScore;
        VehicleLoanEntity vehicleLoan = new VehicleLoanEntity();
        public VehicleLoanEntity() { }
        /// <summary>
        /// Constructor For Entity Class
        /// </summary>
        /// <para name="vehicleName"> vehicleName</param>
        /// <param name="customerid">CustomerId </param>
        /// <param name="loanamount">sanction of loan amount</param>
        /// <param name="rateofinterest">interest to be paid per month</param>
        /// <param name="tenure">Duration of loan</param>
        /// <param name="emi"> Monthly emi</param>
        /// <param name="creditscore">credit score in your credit card</param>

        public VehicleLoanEntity(string NameOfVehicle, int CustomerId, float  LoanAmount, float Tenure, float Emi, int CreditScore)
        {

                this._nameOfVehicle = NameOfVehicle;
                this._customerId = CustomerId;
                this._loanAmount = LoanAmount;
                this._tenure = Tenure;
                this._emi = Emi;
                this._creditScore = CreditScore; 



        }
        //set and get methods for Nameofvehicle
        public string NameOfVehicle
        {
            set
            {
                _nameOfVehicle = value;

            }
            get
            {
                return _nameOfVehicle;

            }
        }

        //set and get methods for account number


        public int CustomerId
        {
            set
            {
                
                    if (value== 6)
                    {
                        _customerId = value;
                    }

                    else
                    {
                        throw new Exception("Enter 6 digits only\n");
                    }

               

            }

            get
            {
                return _customerId;
            }
        }

        //set and get methods for loanamount

        public float LoanAmount
        {
            set
            {
                    if (value >= 50000)
                    {
                        _loanAmount = value;
                    }

                    else
                    {
                        throw new Exception("not eligible\n");

                    }

                
            }
            get
            {
                return _loanAmount;

            }
        }
        //set and get methods for tenure
        public float Tenure
        {
            set
            {
                
                    if (value >= 10)
                    {
                        _tenure = value;
                    }

                    else
                    {
                        throw new Exception("not eligible\n");

                    }

               

            }
            get
            {
                return _tenure;

            }
        }
        //set and get methods for rate of interest  
        public float RateOfInterest
        {

            get
            {
                return _rateOfInterest;
            }
        }
        //set and get methods for rate of interest
        public float Emi
        {
            set
            {
                _emi = value;
            }
            get
            {
                return _emi;
            }
        }

        public int CreditScore
        {
            set
            {


                if (CreditScore >= 650)//checks creditscore of a person which should starts from 650
                {
                    _creditScore = value;
                }
                else
                {
                    throw new System.Exception("your credit score is not up to the mark");
                }
            }

            get
            {
                return _creditScore;//returns credits score
            }
        }

    }
}








