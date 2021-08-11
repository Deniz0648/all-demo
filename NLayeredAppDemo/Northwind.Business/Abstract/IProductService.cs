using NorthWind.Entities.Concrete;
using System.Collections.Generic;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetProductByCategory(int categoryId);
        List<Product> GetProductsByProductName(string productName);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}