using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    // generic repo using an in-memory list
    public class GenericRepository<T> : IRepository<T> where T : class, IEntity, new()
    {
        // backing store – replace with DbContext or any provider
        private readonly List<T> _items = new List<T>();

        // add new entity
        public void Add(T item)
        {
            _items.Add(item);
        }

        // remove existing entity
        public void Remove(T item)
        {
            _items.Remove(item);
        }

        // no-op for in-memory, hook into persistence here
        public void Save()
        {
            // e.g. _dbContext.SaveChanges();
        }

        // return all entities
        public IEnumerable<T> GetAll()
        {
            return _items.AsReadOnly();
        }

        // find by Id property
        public T GetById(int id)
        {
            return _items.FirstOrDefault(x => x.Id == id);
        }
    }
}
