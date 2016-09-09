using ForwardingProject.Domain.Abstract;
using ForwardingProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForwardingProject.Domain.Context
{
    public class EFTrailerRepository:ITrailerRepository
    {
        private readonly EFDbContext _context = new EFDbContext();

        public IEnumerable<Trailer> Collection => _context.Trailers;

        public void Add(Trailer entity)
        {
            _context.Trailers.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var trailer = _context.Trailers.SingleOrDefault(x => x.ID == id);
            _context.Trailers.Remove(trailer);
            _context.SaveChanges();
        }

        public void Edit(Trailer entity)
        {
            _context.Trailers.Attach(entity);
            var entry = _context.Entry(entity);
            entry.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
