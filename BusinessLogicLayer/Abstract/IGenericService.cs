using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Abstract
{
   public  interface IGenericService<TEntity>where TEntity:class,ITable,new()
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        List<TEntity> Get();
        TEntity GetById(int id);

    }
}
