using Cdr.Domain.Core;
using Cdr.Domain.Entities;
using Cdr.Domain.Interfaces;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Cdr.Data.IOToTxt
{
    // Txt ye okuma yazma yapan sınıfımız.
    // IRepository şartımı koyduğum için burdada şartımı koyuyorum.
    public class TextFileRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        

        private readonly string fileName;

        public TextFileRepository()
        {
            var modalName = typeof(TEntity).Name;
            this.fileName = $"{modalName}.txt";
        }

        public TEntity Add(TEntity entity)
        {
            List<TEntity> list = new List<TEntity>();
            string jsonst = "";
           if(File.Exists(fileName))
            {
                jsonst = File.ReadAllText(fileName);
            }
            if (!string.IsNullOrEmpty(jsonst))
            {
                list = JsonSerializer.Deserialize<List<TEntity>>(jsonst, new JsonSerializerOptions { IncludeFields = true });
            }

            list.Add(entity);

            string ff = JsonSerializer.Serialize(list, new JsonSerializerOptions { IncludeFields = true });
            File.WriteAllText(fileName, ff); // içini siler son gönderdiğimi yazar
            return entity;
        }

        public bool Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        
        public bool Delete(string id)
        {
            string jsonst = "";
            if (!File.Exists(fileName))
            {
                return false;
            }

            jsonst=File.ReadAllText(fileName);

            if(string.IsNullOrEmpty(jsonst))
                return false;
            List<TEntity> list=new List<TEntity>();
            list=JsonSerializer.Deserialize<List<TEntity>>(jsonst,new JsonSerializerOptions { IncludeFields = true });

            list.RemoveAll(x => x.Id == id);

            string ff=JsonSerializer.Serialize(list, new JsonSerializerOptions { IncludeFields = true });
            File.WriteAllText(fileName, ff);
            return true;

        }

        public bool RemoveCategory(string namebefore,string nameafter)
        {
            List<Category> list = new List<Category>();
            string jsonst = "";
            if (!File.Exists(fileName))
            {
                return false;
            }

            jsonst = File.ReadAllText(fileName);
            if (string.IsNullOrEmpty(jsonst))
            {
                return false;
            }
                

                list = JsonSerializer.Deserialize<List<Category>>(jsonst, new JsonSerializerOptions { IncludeFields = true });
            foreach (var item in list)
            {
                if (item.Name == namebefore)
                {
                    item.Name = nameafter;
                }
                
            }

            string ff = JsonSerializer.Serialize(list, new JsonSerializerOptions { IncludeFields = true });
            File.WriteAllText(fileName, ff);
            return true;

        }

        public TEntity GetById(string id)
        {
            throw new NotImplementedException();
            //if (!File.Exists(fileName)) return null;
            //var rawData = File.ReadAllText(fileName);
            //var modalData = JsonSerializer.Deserialize<List<TEntity>>(rawData);
            //if (modalData == null) return null;

            //return ((IQueryable<TEntity>)modalData).Where(x => x.Id == id);
        }

        public IReadOnlyCollection<TEntity> GetList(Expression<Func<TEntity, bool>> expression = null)
        {
            throw new NotImplementedException();
            //if (!File.Exists(fileName)) return null;
            //var rawData=File.ReadAllText(fileName);
            //var modalData=JsonSerializer.Deserialize<List<TEntity>>(rawData);
            //if (modalData == null) return null;

            //return ((IQueryable<TEntity>)modalData).Where(expression);

        }

        
    }
}