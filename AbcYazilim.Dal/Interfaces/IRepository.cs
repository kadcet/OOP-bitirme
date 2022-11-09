using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AbcYazilim.Dal.Interfaces
{
    public interface IRepository<T>:IDisposable where T: class
    {
        void Insert(T entity);

        void Insert(IEnumerable<T> entities);
        // birden çok entity nin gönderilmesi durumunda ınsert işlemi

        void Update(T entity);

        void Update(T entity, IEnumerable<string> fields);
        // Entity in değişen alanları update et.değişen alanların isimlerini göndericez

        void Update(IEnumerable<T> entities);
        // birden fazla entity i update et

        void Delete(T entity);

        void Delete(IEnumerable<T> entities);

        TResult Find<TResult>(Expression<Func<T, bool>> filter,Expression<Func<T,TResult>> selector);
        // t türünde bi sorgu göndericez.sorgu sonucunda true değeri dönüyorsa(sorgumuzun karşısında bir value olduğunu gösteriyor bu) bize bu value yi geri gönder.hangi tipte geri göndereceğini sorguda bildiricem.

        IQueryable<TResult> Select<TResult>(Expression<Func<T, bool>> filter,Expression<Func<T,TResult>> selector);
        // birden fazla kayıt seçmek için
    }
}
