using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForwardingProject.Domain.Entities
{
    public class Invoice
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public string Description { get; set; }
        public double InvoiceAmount { get; set; }

    }

}
