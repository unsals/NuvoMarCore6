﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

        Context c = new Context();
        
        public void Add(T entity)
        {
            c.Add(entity);
            c.SaveChanges();
        }

        public void Remove(T entity)
        {
            c.Remove(entity);
            c.SaveChanges();
        }

        public List<T> GetAll()
        {
            return c.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return c.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            c.Update(entity);
            c.SaveChanges();
        }
    }
}
