using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.DomainModels
{
    public class SalesOrder
    {
        public SalesOrder()
        {

        }

        public DateTime CreateDate { get; set; }
        public string CustomerReference { get; set; }
        public string OrderReference { get; set; }
    }
}
