﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bookly.DataAccess.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(string? includeProperties = null);
        T Get(Expression<Func<T, bool>> filer, string? includeProperties = null);
        void Add(T entity);
        void Delete(T entity);
        void DeleteAll(IEnumerable<T> entity);

    }
}
