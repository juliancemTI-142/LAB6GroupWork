using ForwardingProject.Domain.Abstract;
using System.Collections.Generic;
using System.Linq;
using ForwardingProject.Domain.Entities;
using System.Data.Entity;

namespace ForwardingProject.Domain.Context
{
    public class EFBrokerRepository : IBrokerRepository
    {
        private readonly EFDbContext _context = new EFDbContext();

        public IEnumerable<Broker> Collection => _context.Brokers;

        public void Add(Broker entity)
        {
            _context.Brokers.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var broker = _context.Brokers.SingleOrDefault(x => x.ID == id);
            _context.Brokers.Remove(broker);
            _context.SaveChanges();
        }

        public void Edit(Broker entity)
        {
            _context.Brokers.Attach(entity);
            var entry = _context.Entry(entity);
            entry.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
