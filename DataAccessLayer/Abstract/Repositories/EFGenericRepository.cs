using DataAccessLayer.Abstract.EntityFrameWork.Context;
using DataAccessLayer.Concrete;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Abstract.Repositories
{
    public class EFGenericRepository<TEntity> : IGenericDAL<TEntity> where TEntity : class, ITable, new()
    {
        public void Add(TEntity entity)
        {
            using (var context=new BookContext())
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new BookContext())
            {
                var DeleteEntityState = context.Entry(entity);
                DeleteEntityState.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<TEntity> Get()
        {
            using (var context = new BookContext())
            {
                var result = context.Set<TEntity>().ToList();
                return result;
            }
        }

        public TEntity GetById(int id)
        {
            using (var context = new BookContext())
            {
                var result=context.Set<TEntity>().Find(id);
                return result;
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new BookContext())
            {
                var updateEntityState = context.Entry(entity);
                updateEntityState.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
