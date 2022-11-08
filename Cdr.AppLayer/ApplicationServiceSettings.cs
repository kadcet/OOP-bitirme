using Cdr.Data.IOToTxt;
using Cdr.Data.MSSQLServer;
using Cdr.Domain.Entities;
using Cdr.Domain.Interfaces;
using Cdr.Infrastructer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cdr.AppLayer
{
    public class ApplicationServiceSettings
    {
        public static void RegisterAllService()
        {
            IOCContainer.Register<IRepository<Category>>(()=> new TextFileRepository<Category>());
            IOCContainer.Register<IRepository<Product>>(() => new TextFileRepository<Product>());
            IOCContainer.Register<ICategoryService>(() => new CategoryService());
            IOCContainer.Register<IProductService>(() => new ProductService());
        }
        
    }
}
