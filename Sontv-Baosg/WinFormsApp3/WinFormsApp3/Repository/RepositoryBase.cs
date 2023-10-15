using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp3.Models;

namespace WinFormsApp3.Repository
{
    public class RepositoryBase<T> where T : class
    {
        protected QL_KhoHangQuanNuocContext dbContext;
        protected DbSet<T> pros;

        public RepositoryBase()
        {
            dbContext = new QL_KhoHangQuanNuocContext();
            pros = dbContext.Set<T>();
        }

        public void Add(T item)
        {
            pros.Add(item);
            dbContext.SaveChanges();
        }

        public void Delete(T item)
        {
            pros.Remove(item);
            dbContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return pros.ToList();
        }

        public void Update(T item)
        {
            var tracker = dbContext.Attach(item);
            tracker.State = EntityState.Modified;
            dbContext.SaveChanges();
        }
      
    }
}
