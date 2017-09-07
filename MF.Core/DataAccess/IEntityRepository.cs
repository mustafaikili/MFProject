using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MF.Core.DataAccess
{
    //class referance type tip class resort keyword
    //Bir projede gele olarak kullanılan metotlar vardır onları buraya tanımlayacağız
   public interface IEntityRepository<T> where T : class //Referansa type constraintd
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T Get(Expression<Func<T, bool>> filter = null);
        ICollection<T> GetAll(Expression<Func<T, bool>> filter = null);
    }
}
