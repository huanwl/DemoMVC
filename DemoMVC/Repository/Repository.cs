using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoMVC.Repository
{
    public class Repository<T> : IRepository<T>
        where T : BaseModel
    {
        public IDbSet<T> DbSet { get; set; }
        public MyContext DbContext { get; set; }

        public Repository(MyContext context)
        {
            this.DbContext = context;
            this.DbSet = this.DbContext.Set<T>();
        }

        public virtual string Create(T entity)
        {
            dynamic obj = this.DbSet.Add(entity);
            return obj.Id;
        }

        public virtual string Delete(T entity)
        {
            if (this.DbContext.Entry(entity).State == EntityState.Detached)
            {
                this.DbSet.Attach(entity);
            }
            dynamic obj = DbSet.Remove(entity);
            return obj.Id;
        }

        public virtual IQueryable<T> GetAll()
        {
            return this.DbSet;
        }

        public virtual T GetById(string id)
        {
            return this.DbSet.Find(id);
        }

        public virtual void Update(T entity)
        {
            this.DbSet.Attach(entity);
            this.DbContext.Entry(entity).State = EntityState.Modified;
        }

        public void SaveChange()
        {
            this.DbContext.SaveChanges();
        }
    }
}