using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_1.Models.Repositery
{
    public class Repositery <T> where T: class
    {

        private MusicStoreDataContext _context ;
        private bool disposed;


        protected DbSet<T>  DbSet
        {
            get; set;
        }

        public Repositery()
        {
            _context = new MusicStoreDataContext();
            DbSet = _context.Set<T>();

        }

        public Repositery(MusicStoreDataContext context)
        {
            _context = context;
        }

        public List<T> GetAll()
        {
            return DbSet.ToList();
        }


        public T Get(int id)
        {
            return DbSet.Find(id);
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (!disposed)
            {
                _context.Dispose();
                disposed = true;
            }
        }
    }


}
