using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.Entities;


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
        public void Add(HousingLoan housingLoan)
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


    }
   public class _housingLoanDataAccessLayer
    {
    }
}
