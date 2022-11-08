using Cdr.Domain.Core;
using Cdr.Domain.Interfaces;
using System.Linq.Expressions;

namespace Cdr.Data.MSSQLServer
{
    public class MSSQLRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        public TEntity Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveCategory(string namebefore, string nameafter)
        {
            throw new NotImplementedException();
        }


        public TEntity GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<TEntity> GetList(Expression<Func<TEntity, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        
    }
}