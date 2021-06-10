using Hyked.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Hyked.Data.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private ApplicationDbContext dbContext;

        private DbSet<T> table;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.table = dbContext.Set<T>();
        }

        public List<T> GetAll()
        {
            return this.table.ToList();
        }

        public T GetById(object id)
        {
            return this.table.Find(id);
        }

        public void Insert(T obj)
        {
            this.table.Add(obj);
        }

        public void Update(T obj)
        {
            this.table.Attach(obj);
            this.dbContext.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T exists = this.table.Find(id);
            this.table.Remove(exists);
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }
    }
}
