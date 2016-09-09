using ForwardingProject.Domain.Abstract;
using ForwardingProject.Domain.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using ForwardingProject.Domain.Context;
using System.Linq;

public class EFDriverRepository : IDriverRepository
    {
        private readonly EFDbContext _context = new EFDbContext();

    public IEnumerable<Driver> Collection => _context.Drivers;

    public void Add(Driver entity)
    {
        _context.Drivers.Add(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var driver = _context.Drivers.SingleOrDefault(x => x.ID == id);
        _context.Drivers.Remove(driver);
        _context.SaveChanges();
    }

    public void Edit(Driver entity)
    {
        _context.Drivers.Attach(entity);
        var entry = _context.Entry(entity);
        entry.State = EntityState.Modified;
        _context.SaveChanges();
    }

}
