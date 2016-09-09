using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForwardingProject.Domain.Entities
{
    public class Broker :Person
    {
        public IList<Invoice> Invoices { get; set; }
    }
}
