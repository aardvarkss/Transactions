using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.DomainModels
{
    public class PurchaseOrderLine
    {
        public PurchaseOrderLine()
        {

        }

        public DateTime CreateDate { get; set; }
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
    }
}
