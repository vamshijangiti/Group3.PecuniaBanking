using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.HousingLoanEntities;


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
        public void AddHousingLoan(HousingLoan housingLoan)
        {
            if (housingLoan.CustomerId == 0)
            {
                _housingLoanDataAccessLayer.Add(housingLoan);
            }
            else
            {
                throw new Exception("CustomerId cant be zero");
            }
        }
        public float CalculateEmi(float loanamount,float Tenure)
        {
            if (loanamount!=0&&Tenure!=0)
                    {
                float emi;
                float r = HousingLoan.RateOfInterest / (12 * 100); // 
                Tenure = Tenure * 12; // one month period 
                emi = (loanamount * r * (float)Math.Pow(1 + r, Tenure)) / (float)(Math.Pow(1 + r, Tenure) - 1);

                return _emi;
            }
        }


    }
   public class _housingLoanDataAccessLayer
    {
    }
}
