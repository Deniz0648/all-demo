using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Northwind.DataAccess.Abstract;
using NorthWind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {


    }
}
