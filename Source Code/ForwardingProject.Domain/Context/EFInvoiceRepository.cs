using ForwardingProject.Domain.Abstract;
using ForwardingProject.Domain.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ForwardingProject.Domain.Context
{
    public  class EFInvoiceRepository : IInvoiceRepository
    {
        private readonly EFDbContext _context = new EFDbContext();

        public IEnumerable<Invoice> Collection => _context.Invoices;

        public void Add(Invoice entity)
        {
            _context.Invoices.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var invoice = _context.Invoices.SingleOrDefault(x => x.ID == id);
            _context.Invoices.Remove(invoice);
            _context.SaveChanges();
        }

        public void Edit(Invoice entity)
        {
            _context.Invoices.Attach(entity);
            var entry = _context.Entry(entity);
            entry.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
