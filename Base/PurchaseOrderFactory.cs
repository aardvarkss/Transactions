using Base.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class PurchaseOrderFactory
    {
        public PurchaseOrder createPurchaseOrder()
        {
            PurchaseOrder s = new PurchaseOrder();
            s.CreateDate = DateTime.Now;

            return s;
        }

        public PurchaseOrderLine addPurchaseOrderLine(int qty, string prod, PurchaseOrder s)
        {
            PurchaseOrderLine pol = new PurchaseOrderLine();
            pol.ProductCode = prod;
            pol.Quantity = qty;
            s.addLine(pol);

            return pol;

        }
    }
}
