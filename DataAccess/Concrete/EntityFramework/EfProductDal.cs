using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, DataContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (DataContext conn = new DataContext())
            {
                var productDetail = from p in conn.Products
                                    join c in conn.Categories
                                    on p.CategoryId equals c.Id
                                    select new ProductDetailDto
                                    {
                                        ProductId = p.Id,
                                        ProductName = p.ProductName,
                                        CategoryName = c.CategoryName

                                    };
                return productDetail.ToList();
            }
        }
    }
}
