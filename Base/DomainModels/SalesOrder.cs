using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.DomainModels
{
    public class SalesOrder
    {
        public List<SalesOrderLine> lines;

        public SalesOrder()
        {
            lines = new List<SalesOrderLine>();
        }

        public DateTime CreateDate { get; set; }
        public string CustomerReference { get; set; }
        public string OrderReference { get; set; }

        public bool addLine(SalesOrderLine sol)
        {
            lines.Add(sol);
            return true;
        }
        
    }
}
