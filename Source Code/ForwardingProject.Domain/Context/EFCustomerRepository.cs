using ForwardingProject.Domain.Abstract;
using System.Collections.Generic;
using System.Linq;
using ForwardingProject.Domain.Entities;
using System.Data.Entity;

namespace ForwardingProject.Domain.Context
{
    public class EFCustomerRepository : ICustomerRepository
    {
        private readonly EFDbContext _context = new EFDbContext();

        public IEnumerable<Customer> Collection => _context.Customers;

        public void Add(Customer entity)
        {
            _context.Customers.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var customer = _context.Customers.SingleOrDefault(x => x.ID == id);
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        public void Edit(Customer entity)
        {
            _context.Customers.Attach(entity);
            var entry = _context.Entry(entity);
            entry.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
