using ForwardingProject.Domain.Entities;
using System.Data.Entity;


namespace ForwardingProject.Domain.Context
{
    public class EFDbContext : DbContext
    {
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Truck> Trucks { get; set; }
        public DbSet<Trailer> Trailers { get; set; }
        public DbSet<Broker> Brokers { get; set; }


    }
}
