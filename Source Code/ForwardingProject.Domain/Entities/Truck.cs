namespace ForwardingProject.Domain.Entities
{
    public class Truck:Equipment
    {

        public string TruckNumber { get; set; }
        public Driver Driver { get; set; }
        public Trailer Trailer { get; set; }
    }
}
