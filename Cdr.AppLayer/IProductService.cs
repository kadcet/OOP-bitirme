using Cdr.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cdr.AppLayer
{
    public interface IProductService
    {
        Product Create(string name, decimal price, int stok, decimal tax, string categoryId);

        void GetProduct(string name,decimal price, int stok, decimal tax);
        
        // bu ne yapacak. Mesela ben bir product listesinden beyaz eşya kategorisindeki ürünleri almak istiyorum
        IReadOnlyCollection<Product> GetByCategoryId(int categoryId);
    }
}
