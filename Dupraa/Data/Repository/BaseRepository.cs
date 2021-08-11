using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BaseRepository<T> where T : BaseModel
    {
        public void Create(T model)
        {
            using (var context = new BaseContext())
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
            }
        }
        public List<T> Read()
        {
            List<T> Lista = new List<T>();
            using (var context = new BaseContext())
            {
                Lista = context.Set<T>().ToList();
            }
            return Lista;
        }
        public T Read(int id)
        {
            T model = Activator.CreateInstance<T>();
            using (var context = new BaseContext())
            {
                model = context.Set<T>().Find(id);
            }
            return model;
        }
        public void Update(T model)
        {
            using (var context = new BaseContext())
            {
                context.Entry<T>(model).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (var context = new BaseContext())
            {
                context.Entry<T>(this.Read(id)).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
