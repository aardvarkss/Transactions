using Base.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class SalesOrderFactory
    {
        public SalesOrder createSalesOrder()
        {
            SalesOrder s = new SalesOrder();
            s.CreateDate = DateTime.Now;

            return s;
        }
    }
}
