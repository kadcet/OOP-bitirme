using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcYazilim.Dal.Interfaces
{
    public interface IUnitOfWork<T> : IDisposable where T : class
    {
        // IUnitofwork te Irepository e gelen talepleri databaseye göndericez.bunun için unitofwork ten ırepository e ulaşmamız lazım. oluşturduğumuz tüm functionlara ulaşmış olucaz

        IRepository<T> Rep { get; }

        bool Save();
    }
}
