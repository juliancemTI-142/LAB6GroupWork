using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForwardingProject.Domain.Entities
{
    public abstract class Equipment
    {
        public int ID { get; set;}
        public string Make { get; set; }
        public string Model { get; set; }
        public string PlateNumber { get; set; }
        public DateTime InspectionDate { get; set; }
        public DateTime InspectionDateExpiration { get; set; }

    }
}
