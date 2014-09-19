using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.DomainModels
{
    public class SupplierInvoice
    {
        
        public SupplierInvoice()
        {

        }

        public DateTime CreateDate { get; set; }
        public int InvoiceNumber { get; set; }
        public string ProductCode { get; set; }
        public string Supplier { get; set; }
        public int Quantity { get; set; }
        public int Value { get; set; }

    }
}
