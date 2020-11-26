using Shopping.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.DataAccess
{
    public interface IRepository<T> where T : class,IEntity,new()
    {
        void Add(T entity);
        List<T> GetAll();
        T GetById(int id);
        void Update(T entity);
        void Delete(T entity);
    }
}
