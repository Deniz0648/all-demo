using NorthWind.Entities.Concrete;
using System.Collections.Generic;

namespace Northwind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}
