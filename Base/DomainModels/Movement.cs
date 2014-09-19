using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.DomainModels
{
    public class StockMovement
    {
        public StockMovement()
        {

        }

        public DateTime CreateDate { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public int From { get; set; }
        public int To { get; set; }

    }
}
