using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Eshopier.DAL
{
    public class Repository<T>: IDataAccess<T> where T : class 
    {
        Context con = new Context();

        public DbSet<T> setkısayol;
        public Repository()
        {
            setkısayol=con.Set<T>();    
        }
        public List<T> List()
        {
           return setkısayol.ToList();   
        }
        public int Instert(T entity)
        {
           setkısayol.Add(entity);
            return Save();
        }
        public int Delete(T obj)
        {
            setkısayol.Remove(obj);
            return Save();
        }
        public int Save()
        {
            return con.SaveChanges();
        }
        public T Find(Expression<Func<T, bool>> where)
        {
            return setkısayol.FirstOrDefault(where);
        }

        public int Update(T obj)
        {
            return Save();
        }
    }

}
