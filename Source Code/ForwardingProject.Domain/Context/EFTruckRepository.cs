using ForwardingProject.Domain.Abstract;
using ForwardingProject.Domain.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ForwardingProject.Domain.Context
{
    public class EFTruckRepository : ITruckRepository
    {
        private readonly EFDbContext _context = new EFDbContext();

        public IEnumerable<Truck> Collection => _context.Trucks;

        public void Add(Truck entity)
        {
            _context.Trucks.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var truck = _context.Trucks.SingleOrDefault(x => x.ID == id);
            _context.Trucks.Remove(truck);
            _context.SaveChanges();
        }

        public void Edit(Truck entity)
        {
            _context.Trucks.Attach(entity);
            var entry = _context.Entry(entity);
            entry.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
