﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstract;
using Northwind.Entites.Concrete;

namespace Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

       public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    ProductId = 1,CategoryId = 1,ProductName = "Phone",QuantityPerUnit = "1 in a box",UnitPrice = 2000,UnitsInStock = 150
                }
            };
            return products;
        }

       public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
