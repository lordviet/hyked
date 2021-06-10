using System.Collections.Generic;

namespace Hyked.Data.Contracts
{
    public interface IGenericRepository<T> where T: class
    {
        List<T> GetAll();

        T GetById(object Id);

        void Insert(T obj);

        void Update(T obj);

        void Delete(object Id);

        void Save();
    }
}
