using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.DomainModels
{
    public class SalesOrderLine
    {
        public SalesOrderLine()
        {

        }

        public string ProductCode { get; set; }
        public int Quantity { get; set; }
    }
}
