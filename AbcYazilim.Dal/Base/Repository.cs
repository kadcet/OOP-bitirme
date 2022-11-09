using AbcYazilim.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace AbcYazilim.Dal.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {


        // işlemleri yapmak için context e ihtiyacımız var

        #region Variables
        private readonly DbContext _context;
        // class içindeki tüm fonksiyonlar bu değişkene ulaşabilsin.yerel değişken.readonly demek bu değişkene değer ataması yapamayız sadece değeri okuruz demek.Sadece oluşturuken değer atayabiliriz yada ctor da
        private readonly DbSet<T> _dbSet; // entity lerimiz temsil edecek

        #endregion


        public Repository(DbContext context)
        {
            if (context == null) return;
            _context = context;
            _dbSet = _context.Set<T>();
        }


        private bool disposedValue;

        public void Insert(T entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        public void Insert(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
                _context.Entry(entity).State = EntityState.Added;
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Update(T entity, IEnumerable<string> fields)
        {
            _dbSet.Attach(entity);
            var entry = _context.Entry(entity);
            foreach (var field in fields)
            {
                entry.Property(field).IsModified = true;
            }
        }

        public void Update(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
        }


        public void Delete(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public void Delete(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Deleted;
            }
        }

        // geriye bişey döndüreceği için return la başlacak.filtrenin null gelme durumu olabilir.filtre gönderilmeden veri çekilebilir.bunun için filtrenin boş olup olmdığının kontrol edilmesi lazım
        public TResult Find<TResult>(Expression<Func<T, bool>> filter,Expression<Func<T,TResult>> selector)
        {
            // select dediğimiz için kayıt çekicez
            return filter == null ? _dbSet.Select(selector).FirstOrDefault() : _dbSet.Where(filter).Select(selector).FirstOrDefault();
        }

        // burda tresult liste olarak değer döndürmüyor.sadece bir tane sql kodu döndürüyor.
        public IQueryable<TResult> Select<TResult>(Expression<Func<T, bool>> filter,Expression<Func<T,TResult>> selector)
        {
            return filter == null ? _dbSet.Select(selector) : _dbSet.Where(filter).Select(selector);
        }


        #region Dispose

        private bool _disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                disposedValue = true;
            }
        }


        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
