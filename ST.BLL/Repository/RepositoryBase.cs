using ST.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ST.BLL.Repository
{
    public abstract class RepositoryBase<T, Id> where T : class
    {
        protected internal static MyContext dbContext;

        public virtual List<T> GetAll()
        {
            dbContext = new MyContext();
            return dbContext.Set<T>().ToList();
        }
        public virtual T GetById(Id id)
        {
            dbContext = new MyContext();
            return dbContext.Set<T>().Find(id);
        }
        public virtual int Insert(T entity)
        {
            try
            {
                dbContext = dbContext ?? new MyContext();
                dbContext.Set<T>().Add(entity);
                return dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual int Delete(T entity)
        {
            try
            {
                dbContext = dbContext ?? new MyContext();
                dbContext.Set<T>().Remove(entity);
                return dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual int Update()
        {
            try
            {
                dbContext = dbContext ?? new MyContext();
                return dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
