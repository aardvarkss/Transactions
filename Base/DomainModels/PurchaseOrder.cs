using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.DomainModels
{
    public class PurchaseOrder
    {
        public List<PurchaseOrderLine> Lines;

        public PurchaseOrder()
        {
            Lines = new List<PurchaseOrderLine>();
        }

        public DateTime CreateDate { get; set; }

        public bool addLine(PurchaseOrderLine p)
        {
            Lines.Add(p);

            return true;
        }

    }
}
