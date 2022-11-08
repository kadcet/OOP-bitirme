using Cdr.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cdr.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity:BaseEntity
    {
        TEntity Add(TEntity entity);

        bool Delete(TEntity entity); // T entitity tipinden parametre alıyor

        bool Delete(string id);  // int id alıyor sadece

        bool RemoveCategory(string namebefore,string nameafter);

        // bana int tipinden bir ıd verildiği zaman o entit nin detaylarını getireyim
        TEntity GetById(string id);

        IReadOnlyCollection<TEntity> GetList(Expression<Func<TEntity,bool>> expression=null);
        // Liste.Where(x=>x.Name.StartWith("A")  buna Expression yani ifade deniyor.
        // eğer expression varsa kullanıcaz. Yoksa listenin tamamını dönücez.
    }
}
