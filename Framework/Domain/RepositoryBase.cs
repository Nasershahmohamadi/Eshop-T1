using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Framework.Domain
{
    public class RepositoryBase<Tkey, T> : IRepository<Tkey, T> where T : class
    {
        private readonly DbContext _contex;

        public RepositoryBase(DbContext contex)
        {
            _contex = contex;
        }

        public bool Create(T command)
        {
            try
            {
                _contex.Set<T>().Add(command);
                _contex.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public T Get(Tkey key)
        {
            return _contex.Set<T>().Find(key);
        }

        public List<T> Get()
        {
            return _contex.Set<T>().ToList();
        }
    }
}
