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
    public class ProductService : IProductService
    {
        IRepository<Product> _productRepository;
        public ProductService()
        {
            _productRepository=IOCContainer.Resolve<IRepository<Product>>();
        }

        private static List<Product> listeProduct = new List<Product>();

        public Product Create(string name, decimal price, int stok, decimal tax, string categoryId)
        {
            Product product = new Product();
            product.Name = name;
            product.Price = price;
            product.Stock = stok;
            product.Tax = tax;
            product.Id = Guid.NewGuid().ToString();
            _productRepository.Add(product);
            return product;

        }

        public IReadOnlyCollection<Product> GetByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void GetProduct(string name, decimal price, int stok, decimal tax)
        {
            throw new NotImplementedException();
        }
    }
}
