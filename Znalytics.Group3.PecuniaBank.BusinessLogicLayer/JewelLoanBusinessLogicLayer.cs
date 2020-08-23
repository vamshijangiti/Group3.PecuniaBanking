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
   public  class JewelLoanBusinessLogicLayer
    {
        JewelLoanDataAccessLayer _jewelLoan;
        

        public  JewelLoanBusinessLogicLayer()
        {
            _jewelLoan = new JewelLoanDataAccessLayer();
        }

        //Add
        public void Add(JewelLoan custId)
        {
            if (custId.custId != null)
            {
                _jewelLoan.Add(custId);
            }
            else
            {
                throw new Exception("JewelLoan id can't be null");
            }
        }

 
        public class _jewelLoanDataAccessLayer
        {
        }
    }

   
}
   
