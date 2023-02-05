using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new DataContext();
            c.Remove(t);
            c.SaveChanges();
        }
        public List<T> GetAllList()
        {
            using var c = new DataContext();
            return c.Set<T>().ToList();
        }
        public List<T> GetAllList(Expression<Func<T, bool>> filter)
        {
            using var c = new DataContext();
            return c.Set<T>().Where(filter).ToList();
        }
        public T GetById(Guid id)
        {
            using var c = new DataContext();
            return c.Set<T>().Find(id);
        }
        public void Insert(T t)
        {
            DataContext myContext = new DataContext();
            myContext.Add(t);
            myContext.SaveChanges();
        }
        public void Update(T t)
        {
            using var myContext = new DataContext();
            myContext.Update(t);
            myContext.SaveChanges();
        }
    }
}
